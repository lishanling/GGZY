using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Extensions;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationEntityService
    { /// <summary>
      /// 分页显示
      /// </summary>
      /// <param name="search">分页参数</param>
      /// <param name="AREA_CODE"></param>
      /// <param name="POINT_CODE"></param>
      /// <param name="DATETIME_START"></param>
      /// <param name="DATETIME_END"></param>
      /// <param name="STATE"></param>
      /// <param name="TENDER_PROJECT_CODE"></param>
      /// <param name="TENDER_PROJECT_NAME"></param>
      /// <returns></returns>
        public PageTableResult List(SearchCondition search, string AREA_CODE, string POINT_CODE, DateTime? DATETIME_START,
            DateTime? DATETIME_END, decimal? STATE, string ENTITY_CODE, string ENTITY_NAME, decimal? ENTITY_TYPE)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))// && typeList != null && typeList.Any()
            {
                //BD_VIOLATION_ENTITY的行政区划都是空的，企业没有所属地
                //var condition = new WhereClipBuilder(BD_VIOLATION_ENTITY._.AREA_CODE.BeginWith(rootAreaCode)); 
                var condition = new WhereClipBuilder();
                /*if (rootAreaCode == "3501")
                {
                    condition.And(BD_VIOLATION_ENTITY._.AREA_CODE != "350128");
                }*/
                condition.And(BD_VIOLATION_ENTITY._.ENTITY_CODE.NotIn(new List<string> { "-", "无", "暂无", "/" }));

                if (!String.IsNullOrEmpty(AREA_CODE))
                {
                    AREA_CODE = AREA_CODE.TrimEnd('0');
                    condition.And(BD_VIOLATION_ENTITY._.AREA_CODE.BeginWith(AREA_CODE));
                }

                if (!String.IsNullOrEmpty(POINT_CODE))
                {
                    condition.And(BD_VIOLATION_ENTITY._.POINT_CODE.Like(POINT_CODE));
                }

                if (!String.IsNullOrEmpty(ENTITY_CODE))
                {
                    condition.And(BD_VIOLATION_ENTITY._.ENTITY_CODE.Like(ENTITY_CODE));
                }

                if (!String.IsNullOrEmpty(ENTITY_NAME))
                {
                    condition.And(BD_VIOLATION_ENTITY._.ENTITY_NAME.Like(ENTITY_NAME));
                }

                if (ENTITY_TYPE.HasValue && ENTITY_TYPE > 0)
                {
                    condition.And(BD_VIOLATION_ENTITY._.ENTITY_TYPE == ENTITY_TYPE);
                }


                if (STATE.HasValue)
                {
                    condition.And(BD_VIOLATION_ENTITY._.STATE == STATE.Value);
                }

                if (DATETIME_START.HasValue)
                {
                    condition.And(BD_VIOLATION_ENTITY._.CHECK_TIME >= DATETIME_START);
                }

                if (DATETIME_END.HasValue)
                {
                    condition.And(BD_VIOLATION_ENTITY._.CHECK_TIME <= DATETIME_END);
                }

                var count = Count(condition);
                var data = FromWhere<BD_VIOLATION_ENTITY>(condition.ToWhereClip())
                     .InnerJoin<BD_VIOLATION_POINT>(BD_VIOLATION_POINT._.ID == BD_VIOLATION_ENTITY._.POINT_ID)
                    .Select(
                        BD_VIOLATION_POINT._.CATEGORY_NAME,
                        BD_VIOLATION_ENTITY._.AREA_CODE,
                        BD_VIOLATION_ENTITY._.CHECK_TIME,
                        BD_VIOLATION_ENTITY._.CREATE_TIME,
                        BD_VIOLATION_ENTITY._.ID,
                        BD_VIOLATION_ENTITY._.POINT_CODE,
                        BD_VIOLATION_ENTITY._.POINT_ID,
                        BD_VIOLATION_ENTITY._.POINT_NAME,
                        BD_VIOLATION_ENTITY._.SCORE,
                        BD_VIOLATION_ENTITY._.STATE,
                        BD_VIOLATION_ENTITY._.ENTITY_CODE,
                        BD_VIOLATION_ENTITY._.ENTITY_NAME,
                        BD_VIOLATION_ENTITY._.ENTITY_TYPE,
                        BD_VIOLATION_ENTITY._.TRANSFER_STATE
                    )
                    .Page(search.PageSize, search.PageNo)
                     .OrderByDescending(BD_VIOLATION_ENTITY._.TRANSFER_STATE)
                    .ToList<BD_VIOLATION_ENTITY_LIST>();

                //此返回在监督平台中使用，与大数据无关
                #region
                if ((JdUser.TYPE == 5))
                {
                    data.ForEach(c =>
                    {
                        c.Buttons.AddRange(new List<string> { "SUPERVISE", "DETAIL", "PROJECT" });
                        c.TRANS_TYPE = '1'.ToString();
                    });
                }
                if (JdUser.TYPE == 0 && JdUser.UserExtend == null)
                {
                    data.ForEach(c =>
                    {
                        if (c.STATE == 1)
                        {
                            c.Buttons.AddRange(new List<string> { "TRANS", "DETAIL", "PROJECT" });
                        }
                        else if (c.STATE == 0)
                        {
                            c.Buttons.AddRange(new List<string> { "TRANS", "DETAIL", "PROJECT", "RECORD" });
                        }
                        c.TRANS_TYPE = '1'.ToString();
                    });
                }
                #endregion

                var datas = new List<Dictionary<string, object>>();

                data.ForEach(e =>
                {
                    var dic = e.ToDictionary();
                    if (!dic.ContainsKey("AREA_NAME"))
                    {
                        dic.Add("AREA_NAME", Fw.SysAreaQuanguoService.GetRegionNames(e.AREA_CODE));
                    }
                    if (dic.ContainsKey("SCORE"))
                    {
                        dic["SCORE"] = (Convert.ToDecimal(dic["SCORE"]) * 100).ToString() + "%";
                    }
                    dic.Remove("RESULT_MSG");
                    dic.Remove("RESULT_DATA");
                    dic.Remove("IS_DELETE");
                    datas.Add(dic);
                });
                return new PageTableResult
                {
                    PageNo = search.PageNo,
                    PageSize = search.PageSize,
                    Total = count,
                    Table = datas
                };
            }

            return search.ToPageTableResult();
        }

        public GeneralResult Detail(string id)
        {
            var r = new GeneralResult();

            if (String.IsNullOrWhiteSpace(id))
            {
                r.SetFail("id不能为空");
                return r;
            }

            var model = FromWhere<BD_VIOLATION_ENTITY>(BD_VIOLATION_ENTITY._.IS_DELETE == 0
                && BD_VIOLATION_ENTITY._.ID == id)
                .InnerJoin<BD_VIOLATION_POINT_DETAIL>(
                BD_VIOLATION_POINT_DETAIL._.IS_DELETE == 0
                && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1
                && BD_VIOLATION_POINT_DETAIL._.CODE == BD_VIOLATION_ENTITY._.POINT_CODE)
                .Select(
                BD_VIOLATION_ENTITY._.ID,
                BD_VIOLATION_POINT_DETAIL._.NAME,
                BD_VIOLATION_POINT_DETAIL._.DESCRIPTION,
                BD_VIOLATION_POINT_DETAIL._.RULE_DESCRIPTION,
                BD_VIOLATION_ENTITY._.POINT_CODE,
                BD_VIOLATION_ENTITY._.RESULT_MSG,
                BD_VIOLATION_ENTITY._.RESULT_DATA,
                BD_VIOLATION_ENTITY._.STATE,
                BD_VIOLATION_ENTITY._.CHECK_TIME,
                BD_VIOLATION_ENTITY._.ENTITY_NAME,
                BD_VIOLATION_ENTITY._.ENTITY_CODE,
                BD_VIOLATION_ENTITY._.ENTITY_TYPE,
                BD_VIOLATION_ENTITY._.AREA_CODE,
               new Field("BD_VIOLATION_ENTITY.SCORE*100 || '%'").As("SCORE")
                ).ToFirst<dynamic>();

            if (null == model)
            {
                r.SetFail("记录不存在或已被删除");
                return r;
            }




            BD_VIOLATION_BASIC basic = FirstOrNull<BD_VIOLATION_BASIC>(BD_VIOLATION_BASIC._.IS_DELETE == 0
                && BD_VIOLATION_BASIC._.CODE == model.ENTITY_CODE);

            decimal? score = 0;
            if (null != basic)
            {
                score = basic.SCORE;
            }

            var entity = new
            {
                ENTITY_NAME = model.ENTITY_NAME,
                ENTITY_CODE = model.ENTITY_CODE,
                ENTITY_TYPE = model.ENTITY_TYPE,
                SCORE = (score.Value * 100).ToString() + "%",
                AREA_NAME = Fw.SysAreaQuanguoService.GetRegionNames(model.AREA_CODE)
            };
            List<BD_VIOLATION_ENTITY> tabs = FindList<BD_VIOLATION_ENTITY>(
                BD_VIOLATION_ENTITY._.ENTITY_CODE == model.ENTITY_CODE
                && BD_VIOLATION_ENTITY._.ENTITY_NAME == model.ENTITY_NAME
                && BD_VIOLATION_ENTITY._.IS_DELETE == 0, BD_VIOLATION_ENTITY._.CHECK_TIME.Asc);

            var tabList = tabs.Select(t => new
            {
                ID = t.ID,
                POINT_CODE = t.POINT_CODE,
                POINT_NAME = t.POINT_NAME,
                IS_CURRENT = t.ID == id ? 1 : 0
            });
            var records = FromWhere<BD_VIOLATION_HISTORY>(BD_VIOLATION_HISTORY._.RECORD_ID == id)
                .OrderBy(BD_VIOLATION_HISTORY._.CREATE_TIME)
                .Select(
                BD_VIOLATION_HISTORY._.SOURCE_FIELD,
                BD_VIOLATION_HISTORY._.SOURCE_VALUE,
                BD_VIOLATION_HISTORY._.TARGET_FIELD,
                BD_VIOLATION_HISTORY._.TARGET_VALUE
                ).ToList<dynamic>();
            var result = new List<Dictionary<string, object>>();
            try
            {
                result = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(model.RESULT_DATA.ToString());
            }
            catch
            { }

            #region 添加调查结果详情
            var record = Fw.BdInquireRecordService.FromWhere(BD_INQUIRE_RECORD._.VIOLATION_RECORD_ID == id)
            .OrderBy(BD_INQUIRE_RECORD._.CREATE_TIME)
            .Select
            (
             BD_INQUIRE_RECORD._.OPERATION_TIME,
             BD_INQUIRE_RECORD._.STATE,
             BD_INQUIRE_RECORD._.OPERATION_USER,
             BD_INQUIRE_RECORD._.DESCRIPTION,
             BD_INQUIRE_RECORD._.GUIDS
            )
            .ToFirst<dynamic>();
            #endregion

            r.SetSuccess(new
            {
                Entity = entity,
                Header = tabList,
                Data = new
                {
                    ID = model.ID,
                    NAME = model.NAME,
                    DESCRIPTION = model.DESCRIPTION,
                    RULE_DESCRIPTION = model.RULE_DESCRIPTION,
                    RESULT_MSG = model.RESULT_MSG,
                    RESULT_DATA = result,
                    CHECK_TIME = model.CHECK_TIME,
                    STATE = model.STATE,
                    SCORE = model.SCORE
                },
                Record = records,
                Relues = record
            });
            return r;
        }
        public class BD_VIOLATION_ENTITY_LIST : BD_VIOLATION_ENTITY
        {
            public BD_VIOLATION_ENTITY_LIST()
            {
                this.Buttons = new List<string>();
            }
            public string CATEGORY_NAME { get; set; }
            /// <summary>
            /// Button返回按钮
            /// </summary>
            public List<string> Buttons
            {
                get; set;
            }
            /// <summary>
            /// 移送类型
            /// </summary>
            public string TRANS_TYPE { get; set; }
        }
    }
}
