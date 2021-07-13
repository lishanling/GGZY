using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Extensions;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Log;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationRecordService
    {
        /// <summary>
        /// 分页显示疑似违规项目信息
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
            DateTime? DATETIME_END, decimal? STATE, string TENDER_PROJECT_CODE, string TENDER_PROJECT_NAME  ,string TENDER_PROJECT_TYPE)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {


                var condition = new WhereClipBuilder(BD_VIOLATION_RECORD._.AREA_CODE.BeginWith(rootAreaCode) && BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    condition.And(BD_VIOLATION_RECORD._.AREA_CODE != "350128");
                }
                if (!String.IsNullOrEmpty(AREA_CODE))
                {
                    AREA_CODE = AREA_CODE.TrimEnd('0');
                    condition.And(BD_VIOLATION_RECORD._.AREA_CODE.BeginWith(AREA_CODE));
                }

                if (!String.IsNullOrEmpty(POINT_CODE))
                {
                    condition.And(BD_VIOLATION_RECORD._.POINT_CODE.BeginWith(POINT_CODE));
                }

                if (!String.IsNullOrEmpty(TENDER_PROJECT_CODE))
                {
                    condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE.Like(TENDER_PROJECT_CODE));
                }

                if (!String.IsNullOrEmpty(TENDER_PROJECT_NAME))
                {
                    condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_NAME.Like(TENDER_PROJECT_NAME));
                }
                if (!String.IsNullOrEmpty(TENDER_PROJECT_TYPE))
                {
                    condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE.Like(TENDER_PROJECT_TYPE));
                }
                if (STATE.HasValue)
                {
                    condition.And(BD_VIOLATION_RECORD._.STATE == STATE.Value);
                }

                if (DATETIME_START.HasValue)
                {
                    condition.And(BD_VIOLATION_RECORD._.CHECK_TIME >= DATETIME_START);
                }

                if (DATETIME_END.HasValue)
                {
                    condition.And(BD_VIOLATION_RECORD._.CHECK_TIME <= DATETIME_END);
                }

                var count = FromWhere<BD_VIOLATION_RECORD>(condition.ToWhereClip())
                    .InnerJoin<BD_VIOLATION_POINT>(BD_VIOLATION_POINT._.ID == BD_VIOLATION_RECORD._.POINT_ID)
                    .Where(condition.ToWhereClip()).
                    Count();
                var data = FromWhere<BD_VIOLATION_RECORD>(condition.ToWhereClip())
                    .InnerJoin<BD_VIOLATION_POINT>(BD_VIOLATION_POINT._.ID == BD_VIOLATION_RECORD._.POINT_ID)
                    .Select(
                        BD_VIOLATION_POINT._.CATEGORY_NAME,
                        BD_VIOLATION_RECORD._.AREA_CODE,
                        BD_VIOLATION_RECORD._.CHECK_TIME,
                        BD_VIOLATION_RECORD._.CREATE_TIME,
                        BD_VIOLATION_RECORD._.ID,
                        BD_VIOLATION_RECORD._.INDUSTRIES,
                        BD_VIOLATION_RECORD._.POINT_CODE,
                        BD_VIOLATION_RECORD._.POINT_ID,
                        BD_VIOLATION_RECORD._.POINT_NAME,
                        BD_VIOLATION_RECORD._.SCORE,
                        BD_VIOLATION_RECORD._.STATE,
                        BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE,
                        BD_VIOLATION_RECORD._.TENDER_PROJECT_NAME,
                        BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE,
                        BD_VIOLATION_RECORD._.TRANSFER_STATE
                    )
                    .Page(search.PageSize, search.PageNo)

                    .ToList<BD_VIOLATION_RECORD_LIST>();
                //此返回在监督平台使用，与大数据无关
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

                //到此为止

                var datas = new List<Dictionary<string, object>>();

                data.ForEach(e =>
                {
                    var dic = e.ToBindDicDictionary();
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

            var model = FromWhere<BD_VIOLATION_RECORD>(BD_VIOLATION_RECORD._.IS_DELETE == 0
                && BD_VIOLATION_RECORD._.ID == id)
                .InnerJoin<BD_VIOLATION_POINT_DETAIL>(
                BD_VIOLATION_POINT_DETAIL._.IS_DELETE == 0
                && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1
                && BD_VIOLATION_POINT_DETAIL._.ID == BD_VIOLATION_RECORD._.POINT_ID)
                .Select(
                BD_VIOLATION_RECORD._.ID,
                BD_VIOLATION_POINT_DETAIL._.NAME,
                BD_VIOLATION_POINT_DETAIL._.DESCRIPTION,
                BD_VIOLATION_POINT_DETAIL._.RULE_DESCRIPTION,
                BD_VIOLATION_RECORD._.RESULT_MSG,
                BD_VIOLATION_RECORD._.RESULT_DATA,
                BD_VIOLATION_RECORD._.STATE,
                new Field("BD_VIOLATION_RECORD.SCORE*100 || '%'").As("SCORE"),
                BD_VIOLATION_RECORD._.CHECK_TIME,
                BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE
                ).ToFirst<dynamic>();

            if (null == model)
            {
                r.SetFail("记录不存在或已被删除");
                return r;
            }
            if (null != model.RESULT_DATA)
            {
                try
                {
                    model.RESULT_DATA = JsonConvert.DeserializeObject<Dictionary<string, object>>(model.RESULT_DATA.ToString());
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message,e);
                }
            }


            var tender_project = FirstOrNull<TENDER_PROJECT>(
                TENDER_PROJECT._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE);
            if (null == tender_project)
            {
                r.SetFail("记录不存在或已被删除");
                return r;
            }

            BD_VIOLATION_BASIC basic = FirstOrNull<BD_VIOLATION_BASIC>(BD_VIOLATION_BASIC._.IS_DELETE == 0
                && BD_VIOLATION_BASIC._.CODE == tender_project.TENDER_PROJECT_CODE);


            decimal? score = 0;
            if (null != basic)
            {
                score = basic.SCORE;
            }

            var tender_project_data = new
            {
                tender_project.TENDER_PROJECT_NAME,
                tender_project.TENDER_PROJECT_CODE,
                tender_project.TENDER_AGENCY_NAME,
                tender_project.TENDER_AGENCY_CODE,
                tender_project.TENDERER_NAME,
                TENDERER_CONTRACT = "",
                SCORE = (score.Value * 100).ToString() + "%"
            };


            List<BD_VIOLATION_RECORD> tabs = FindList<BD_VIOLATION_RECORD>(
                BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == tender_project.TENDER_PROJECT_CODE
                && BD_VIOLATION_RECORD._.IS_DELETE == 0, BD_VIOLATION_RECORD._.CHECK_TIME.Asc);

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
                TenderProject = tender_project_data,
                Header = tabList,
                Data = model,
                Record = records,
                Relues = record
            });
            return r;
        }

        #region 公安厅外网
        public List<dynamic> Show(string tender_project_code)
       {
            var records = FromWhere<BD_VIOLATION_RECORD>(BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == tender_project_code)
                .InnerJoin<BD_VIOLATION_BASIC>(BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == BD_VIOLATION_BASIC._.CODE)
                .LeftJoin<BD_VIOLATION_POINT>(BD_VIOLATION_RECORD._.POINT_CODE == BD_VIOLATION_POINT._.CATEGORY_CODE)
                .Select(
                    BD_VIOLATION_RECORD._.ID,
                    BD_VIOLATION_RECORD._.POINT_NAME,
                    BD_VIOLATION_POINT._.CATEGORY_CODE,
                    BD_VIOLATION_POINT._.CATEGORY_NAME,
                    BD_VIOLATION_RECORD._.POINT_ID,
                    new Field("BD_VIOLATION_RECORD.SCORE*100 || '%'").As("SCORE"),
                    BD_VIOLATION_BASIC._.RECORD_TYPE,
                    BD_VIOLATION_RECORD._.STATE,
                    BD_VIOLATION_RECORD._.CHECK_TIME,
                    BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE,
                    BD_VIOLATION_RECORD._.TENDER_PROJECT_NAME,
                    new Field("BD_VIOLATION_BASIC.SCORE*100 || '%'").As("ZH_SCORE")
                    
                ).ToList<dynamic>();
            return records;
        }



        public GeneralResult Details(string id)
        {
            var r = new GeneralResult();

            if (String.IsNullOrWhiteSpace(id))
            {
                r.SetFail("id不能为空");
                return r;
            }

            var model = FromWhere<BD_VIOLATION_RECORD>(BD_VIOLATION_RECORD._.IS_DELETE == 0
                && BD_VIOLATION_RECORD._.ID == id)
                .InnerJoin<BD_VIOLATION_POINT_DETAIL>(
                BD_VIOLATION_POINT_DETAIL._.IS_DELETE == 0
                && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1
                && BD_VIOLATION_POINT_DETAIL._.ID == BD_VIOLATION_RECORD._.POINT_ID)
                .Select(
                BD_VIOLATION_RECORD._.ID,
                BD_VIOLATION_POINT_DETAIL._.NAME,
                BD_VIOLATION_POINT_DETAIL._.DESCRIPTION,
                BD_VIOLATION_POINT_DETAIL._.RULE_DESCRIPTION,
                BD_VIOLATION_RECORD._.RESULT_MSG,
                BD_VIOLATION_RECORD._.RESULT_DATA,
                BD_VIOLATION_RECORD._.STATE,
                new Field("BD_VIOLATION_RECORD.SCORE*100 || '%'").As("SCORE"),
                BD_VIOLATION_RECORD._.CHECK_TIME,
                BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE
                ).ToFirst<dynamic>();
            if (null == model)
            {
                r.SetFail("记录不存在或已被删除");
                return r;
            }

            if (null != model.RESULT_DATA)
            {
                try
                {
                    model.RESULT_DATA = JsonConvert.DeserializeObject<Dictionary<string, object>>(model.RESULT_DATA.ToString());
                }
                catch (Exception e)
                {

                }
            }

            var tender_project = FirstOrNull<TENDER_PROJECT>(
                TENDER_PROJECT._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE);
            if (null == tender_project)
            {
                r.SetFail("记录不存在或已被删除");
                return r;
            }

            BD_VIOLATION_BASIC basic = FirstOrNull<BD_VIOLATION_BASIC>(BD_VIOLATION_BASIC._.IS_DELETE == 0
                && BD_VIOLATION_BASIC._.CODE == tender_project.TENDER_PROJECT_CODE);


            decimal? score = 0;
            if (null != basic)
            {
                score = basic.SCORE;
            }

            var tender_project_data = new
            {
                tender_project.TENDER_PROJECT_NAME,
                tender_project.TENDER_PROJECT_CODE,
                tender_project.TENDER_AGENCY_NAME,
                tender_project.TENDER_AGENCY_CODE,
                tender_project.TENDERER_NAME,
                TENDERER_CONTRACT = "",
                SCORE = (score.Value * 100).ToString() + "%"
            };


            List<BD_VIOLATION_RECORD> tabs = FindList<BD_VIOLATION_RECORD>(
                BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == tender_project.TENDER_PROJECT_CODE
                && BD_VIOLATION_RECORD._.IS_DELETE == 0, BD_VIOLATION_RECORD._.CHECK_TIME.Asc);

            var tabList = tabs.Select(t => new
            {
                ID = t.ID,
                POINT_CODE = t.POINT_CODE,
                POINT_NAME = t.POINT_NAME,
                IS_CURRENT = t.ID == id ? 1 : 0
            });


            r.SetSuccess(new
            {
                TenderProject = tender_project_data,
                Header = tabList,
                Data = model,
                
            });
            return r;
        }

        #endregion

    }
    public class BD_VIOLATION_RECORD_LIST : BD_VIOLATION_RECORD
    {
        public BD_VIOLATION_RECORD_LIST()
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