using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Aspose.Words.Lists;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using GGZYFW.DbEntity;
using System.Reflection.Emit;
using GGZY.Core.Helper;
using GGZY.Core.Utils;
using System.Web;
using GGZY.Services.Infrastructure.Enums.Jd;
using Newtonsoft.Json;
using System.Text;
using System.Web.UI.WebControls;
using TzCodeService;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 智能监察-监督点
    /// </summary>
    public partial class TSuperviseResultService
    {
        #region 首页

        #region 待办事项
        public object DaiBanCount(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {

                #region condition1 WARN_RESULT条件
                var condition1 = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition1.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition1.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));
                #endregion


                var normal = Fw.WarnResultService.FromWhere(condition1.ToWhereClip() && (WARN_RESULT._.RESULT_STATUS == 2 || WARN_RESULT._.RESULT_STATUS == 3))//todo 黄+红= 异常
                             .Select(WARN_RESULT._.M_ID.Count().As("red"))
                             .ToScalar<int>();

                var r = Jd.TSuperviseService.FromWhere(T_SUPERVISE._.OBJ_DEP_ID == JdUser?.DEPARTID && T_SUPERVISE._.STATUS == 0)
                        .Select(T_SUPERVISE._.M_ID.Count().As("Upred"))
                       .ToScalar<int>();

                var y = Jd.JcTransRecordService.FromWhere(JC_TRANS_RECORD._.TRANS_TIME == DateTime.Today && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.DEPARTID)
                        .Select(JC_TRANS_RECORD._.ID.Count().As("Send"))
                        .ToScalar<int>();//todo 移送时间为今天

                //返回列表值
                return new
                {
                    red = normal,
                    Upred = r,
                    Send = y
                };

            }
            return null;
        }

        #endregion

        #region 督查情况 总体统计
        public object DuChaCount(JDHomePageModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            #region 查询条件
            //督查人
            condition.And(T_SUPERVISE._.OP_ID == JdUser?.ID);

            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME <= search.EndTime);
            }

            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            #endregion
            //未反馈
            var list = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS == 0)
                     .Select
                     (
                        T_SUPERVISE._.All.Count().As("Upred")
                       ).ToScalar<int>();
            //已反馈
            var list1 = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS > 0)
                       .Select
                       (
                            T_SUPERVISE._.All.Count().As("Send")
                         ).ToScalar<int>();
            var all = list + list1;
            //返回列表值
            return new
            {
                Upred = list,
                Send = list1,
                ALL = all
            };
        }
        #endregion

        #region  督查事项类型分布统计
        public object DuChaProject(JDHomePageModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            #region 查询条件
            //督查人
            condition.And(T_SUPERVISE._.OP_ID == JdUser?.ID);

            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {

                condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(model.REGION_CODE));

            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            #endregion

            //列表返回值
            var list = Jd.TSuperviseService.FromWhere(condition.ToWhereClip())
                       .GroupBy(T_SUPERVISE._.ENTITY_TYPE_NAME)
                      .Select(
                       T_SUPERVISE._.ENTITY_TYPE_NAME.As("ENTITY_TYPE_NAME"),
                       T_SUPERVISE._.ENTITY_TYPE_NAME.Count().As("ENTITY_TYPE_NAME_COUNT")
                       )
                      .ToList<JDHomePageModel>();
            Dictionary<string, string> dic = new Dictionary<string, string>()
                {
                    {"T_AFC_PROJECT","招标计划" },
                    {"PT_ZXTS","投诉处理" },
                    {"RECORD_REVIEW","招标备案" },
                    {"WARN_RESULT","监督点处理" },
                    {"TENDER_PROJECT","招标项目" },
                    {"BD_VIOLATION_RECORD","疑似违规点" },
                };
            var result = new List<object>();
            foreach (var item in dic)
            {
                var count = list.FirstOrDefault(c => c.ENTITY_TYPE_NAME == item.Key)?.ENTITY_TYPE_NAME_COUNT ?? 0;
                if (item.Key == "BD_VIOLATION_RECORD")
                {
                    count = list.FirstOrDefault(c => c.ENTITY_TYPE_NAME == item.Key || c.ENTITY_TYPE_NAME == "BD_VIOLATION_ENTITY")?.ENTITY_TYPE_NAME_COUNT ?? 0;
                }
                result.Add(new LabelValueModel { Label = item.Value, Value = count.ToString() });
            }
            //返回列表值
            return result;
        }

        #endregion

        #region 督查地区分布统计
        public object DuChaRegion(JDHomePageModel model, SearchCondition search)
        {

            var result = new List<SYLabelValueModel<int>>();
            var gm = new Field("T_SUPERVISE._.REGION_CODE");
            var list = new List<SYLabelValueModel<int>>();
            var list1 = new List<SYLabelValueModel<int>>();

            var condition = new WhereClipBuilder();
            var condition1 = new WhereClipBuilder();
            #region 查询条件
            //督查人
            condition.And(T_SUPERVISE._.OP_ID == JdUser?.ID);

            //时间
            if (search.BeginTime.HasValue)
             {
                 condition.And(T_SUPERVISE._.TIME >= search.BeginTime);
             }
             if (search.EndTime.HasValue)
             {
                 condition.And(T_SUPERVISE._.TIME <= search.EndTime);
             }
             //归属地
             if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
             {
                 if (model.REGION_CODE.Length < 4)
                 {
                     gm = T_SUPERVISE._.REGION_CODE.Substring(0, 4);
                     condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == "350000" && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350000");
                 }
                 else if (model.REGION_CODE.Length >= 4)
                 {
                     condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.BeginWith(model.REGION_CODE)
                              && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.Substring(5, 6) != "00");//不等于本身，但包含市本级
                    gm = T_SUPERVISE._.REGION_CODE;
                     if (model.REGION_CODE == "3501")
                     {
                         condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350128");
                     }
                 }
                 condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(model.REGION_CODE));
             }
             //行业类型
             if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
             {
                 condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
             }
             //督查事项类型
             if (!string.IsNullOrWhiteSpace(model.ENTITY_TYPE_NAME))
             {
                 condition.And(T_SUPERVISE._.ENTITY_TYPE_NAME == model.ENTITY_TYPE_NAME);
             }
             #endregion

                var regions = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                           .Select(
                               GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.As("AREACODE"),
                               GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME")
                             )
                           .ToList<JDHomePageModel>();

                //列表返回值
                #region 未反馈
                if (model.REGION_CODE.Length < 4)
                {
                    list = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS == 0)
                              .GroupBy(gm)
                              .Select(
                                      T_SUPERVISE._.REGION_CODE.Substring(0, 4).As("Label"),
                                      T_SUPERVISE._.All.Count().As("Value")
                                    )
                              .ToList<SYLabelValueModel<int>>();
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    list = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS == 0)
                           .GroupBy(gm)
                           .Select(
                                   T_SUPERVISE._.REGION_CODE.As("Label"),
                                   T_SUPERVISE._.All.Count().As("Value")
                                 )
                           .ToList<SYLabelValueModel<int>>();
                }
                #endregion
                #region 已反馈
                if (model.REGION_CODE.Length < 4)
                {
                    list1 = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS > 0)
                              .GroupBy(gm)
                              .Select(
                                      T_SUPERVISE._.REGION_CODE.Substring(0, 4).As("Label"),
                                      T_SUPERVISE._.All.Count().As("Value1")
                                    )
                              .ToList<SYLabelValueModel<int>>();
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    list1 = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS > 0)
                           .GroupBy(gm)
                           .Select(
                                   T_SUPERVISE._.REGION_CODE.As("Label"),
                                   T_SUPERVISE._.All.Count().As("Value1")
                                 )
                           .ToList<SYLabelValueModel<int>>();
                }
                #endregion

                var d = Jd.TSuperviseService
                     .FromWhere(condition.ToWhereClip() && T_SUPERVISE._.REGION_CODE == "350128").Count();
                //350100  350128
                result = regions.Select(c =>
                {
                    var value = new int();
                    var value1 = new int();
                    if (model.REGION_CODE.Length < 4)
                    {
                        value = list.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value ?? 0;
                        value1 = list1.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value1 ?? 0;
                    }
                    else if (model.REGION_CODE.Length >= 4)
                    {
                        value = list.FirstOrDefault(v => v.Label == c.AREACODE)?.Value ?? 0;
                        value1 = list1.FirstOrDefault(v => v.Label == c.AREACODE)?.Value1 ?? 0;
                    }
                    if (c.AREACODE == "350100")
                    {
                        value = value - d;
                        value1 = value1 - d;
                    }

                    if (c.AREACODE == "350128")
                    {
                        value = d;
                        value1 = d;
                    }
                    var item = new SYLabelValueModel<int>()
                    {
                        Label = c.AREANAME,
                        Value = value,//已反馈
                        Value1 = value1,//未反馈
                        Value2 = value + value1
                    };
                    return item;
                }).ToList();
                var r1 = new
                {
                    Label = result.Select(c => c.Label).ToList(),
                    Value = result.Select(c => c.Value).ToList(),
                    Value1 = result.Select(c => c.Value1).ToList(),
                    Value2 = result.Select(c => c.Value2).ToList(),

                };
                return r1;
        }
        #endregion

        #region 上级督查情况 总体统计
        //[Obsolete]
        public object UpDuChaCount(JDHomePageModel model, SearchCondition search)
        {
            #region  查询条件
            var condition = new WhereClipBuilder();
            //督查对象部门id为当前登录账号组织机构id
            condition.And(T_SUPERVISE._.OBJ_DEP_ID == JdUser?.DEPARTID);
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME <= search.EndTime);
            }

            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            #endregion

            //列表返回值
            var list = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS == 0)
                      .Select
                       (
                         T_SUPERVISE._.All.Count().As("Upred")
                        ).ToScalar<int>();
            var list1 = Jd.TSuperviseService.FromWhere(condition.ToWhereClip() && T_SUPERVISE._.STATUS > 0)
                       .Select
                       (
                            T_SUPERVISE._.All.Count().As("Send")
                         ).ToScalar<int>();
            var all = list + list1;

            //返回列表值
            return new
            {
                Upred = list,
                Send = list1,
                ALL = all
            };
        }

        #endregion

        #region  上级督查事项类型分布统计
        //[Obsolete]
        public object UpDuChaProject(JDHomePageModel model, SearchCondition search)
        {
            #region 查询条件
            var condition = new WhereClipBuilder();
            //督查人
            condition.And(T_SUPERVISE._.OBJ_DEP_ID == JdUser?.DEPARTID);

            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME <= search.EndTime);
            }

            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            #endregion

            //列表返回值
            var list = Jd.TSuperviseService.FromWhere(condition.ToWhereClip())
                       .GroupBy(T_SUPERVISE._.ENTITY_TYPE_NAME)
                      .Select(
                       T_SUPERVISE._.ENTITY_TYPE_NAME.As("ENTITY_TYPE_NAME"),
                       T_SUPERVISE._.ENTITY_TYPE_NAME.Count().As("ENTITY_TYPE_NAME_COUNT")
                       )
                      .ToList<JDHomePageModel>();
            //返回列表值
            Dictionary<string, string> dic = new Dictionary<string, string>()
                {
                    {"T_AFC_PROJECT","招标计划" },
                    {"PT_ZXTS","投诉处理" },
                    {"RECORD_REVIEW","招标备案" },
                    {"WARN_RESULT","监督点处理" },
                    {"TENDER_PROJECT","招标项目" },
                    {"BD_VIOLATION_RECORD","疑似违规点" },
                };
            var result = new List<object>();
            foreach (var item in dic)
            {
                var count = list.FirstOrDefault(c => c.ENTITY_TYPE_NAME == item.Key)?.ENTITY_TYPE_NAME_COUNT ?? 0;
                if (item.Key == "BD_VIOLATION_RECORD")
                {
                    count = list.FirstOrDefault(c => c.ENTITY_TYPE_NAME == item.Key || c.ENTITY_TYPE_NAME == "BD_VIOLATION_ENTITY")?.ENTITY_TYPE_NAME_COUNT ?? 0;
                }
                result.Add(new LabelValueModel { Label = item.Value, Value = count.ToString() });
            }
            //返回列表值
            return result;
        }
        #endregion

        #region 智能监察点统计
        public object JCCount(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            var hyList = JdUser?.UserDepartment?.SYS_DIC_63?.Select(c => c.VALUE).ToList();
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                #region condition T_SUPERVISE条件
                var condition = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(rootCode));//todo 操作人id为当前登录账号id

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(T_SUPERVISE._.TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(T_SUPERVISE._.TIME <= search.EndTime);
                }

                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(T_SUPERVISE._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                #endregion

                #region condition1 T_SUPERVISE_RESULT条件
                var condition1 = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition1.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition1.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootCode));

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition1.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition1.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME <= search.EndTime);
                }

                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition1.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition1.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
                }
                #endregion

                #region condition2 TENDER_PROJECT条件
                var condition2 = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition2.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition2.And(GGZYJD.DbEntity.TENDER_PROJECT._.REGION_CODE.BeginWith(rootCode));

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition2.And(GGZYJD.DbEntity.TENDER_PROJECT._.CREATE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition2.And(GGZYJD.DbEntity.TENDER_PROJECT._.CREATE_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition2.And(GGZYJD.DbEntity.TENDER_PROJECT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition2.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
                }
                #endregion

                #region condition3 T_AFC_PROJECT条件
                var condition3 = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition3.And(T_AFC_PROJECT._.PROJECT_TYPE.In(hylist));//todo 
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition3.And(T_AFC_PROJECT._.REGION_CITY.BeginWith(rootCode));

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition3.And(T_AFC_PROJECT._.TM >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition3.And(T_AFC_PROJECT._.TM <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition3.And(T_AFC_PROJECT._.REGION_CITY.BeginWith(model.REGION_CODE) || T_AFC_PROJECT._.REGION_COUNTY.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition3.And(T_AFC_PROJECT._.PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
                }
                #endregion

                #region condition4 PT_ZXTS条件
                var condition4 = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition4.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition4.And(GGZYJD.DbEntity.TENDER_PROJECT._.REGION_CODE.BeginWith(rootCode));

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition4.And(PT_ZXTS._.CREATE_TM >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition4.And(PT_ZXTS._.CREATE_TM <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition4.And(GGZYJD.DbEntity.TENDER_PROJECT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition4.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
                }
                #endregion

                //统计异常检查点总数
                var list = Jd.TSuperviseResultService.FromWhere(condition1.ToWhereClip() && T_SUPERVISE_RESULT._.WARNING == 1 && T_SUPERVISE_RESULT._.STATUS == 1)
                          .Select(
                                   T_SUPERVISE_RESULT._.M_ID.Count().As("T_SUPERVISE_COUNT")
                                  ).ToScalar<int>();
                var tm = list;
                //已发督查数
                var list1 = Jd.TSuperviseService.FromWhere(condition.ToWhereClip())
                       .GroupBy(T_SUPERVISE._.ENTITY_ID, T_SUPERVISE._.ENTITY_TYPE_NAME)
                       .Select(
                               (T_SUPERVISE._.M_ID.Count()).Sum().As("SEND_COUNT")
                              ).ToScalar<int>();
                var tm1 = list1;
                //未发督查数
                var list2 = Jd.TenderProjectService.FromWhere(condition2.ToWhereClip())
                           .Select(
                               GGZYJD.DbEntity.TENDER_PROJECT._.M_ID.Count().As("TENDER_PROJECT_CODE_COUNT")
                                ).ToScalar<int>();

                var list3 = Jd.TAfcProjectService.FromWhere(condition3.ToWhereClip())
                           .Select(
                               T_AFC_PROJECT._.ID.Count().As("T_PROJECTT_AFC_PROJECT_COUNT")
                              ).ToScalar<int>();

                var list4 = Jd.PtZxtsService.FromWhere(condition4.ToWhereClip())
                           .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                           .Select
                            (
                              PT_ZXTS._.ID.Count().As("PT_ZXTS_COUNT")
                             ).ToScalar<int>();
                var TM = list2 + list3 + list4;
                var sum = list + TM - list1;
                //LabelValueModel
                return new
                {
                    NO_SEND_COUNT = sum,
                    T_SUPERVISE_COUNT = tm,
                    SEND_COUNT = tm1
                };
            }
            return null;
        }
        #endregion

        #region 各地区红灯预警总数分布统计

        public object RedLedCount(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            var gm = new Field("T_SUPERVISE_RESULT._.ENTITY_REGION_CODE");//用于设置分组条件
            var result = new List<LabelValueModel<int>>();
            var list = new List<LabelValueModel<int>>();
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();
                var condition1 = new WhereClipBuilder();
                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootCode));

                #region 查询条件

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    if (model.REGION_CODE.Length < 4)
                    {
                        gm = T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.Substring(0, 4);
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == "350000" && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350000");
                    }
                    else if (model.REGION_CODE.Length >= 4)
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.BeginWith(model.REGION_CODE)
                                       && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.Substring(5, 6) != "00");
                        gm = T_SUPERVISE_RESULT._.ENTITY_REGION_CODE;
                        if (model.REGION_CODE == "3501")
                        {
                            condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350128");
                        }
                    }
                    condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(model.REGION_CODE));
                }

                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }

                #endregion

                condition.And(T_SUPERVISE_RESULT._.WARNING == 1 && T_SUPERVISE_RESULT._.STATUS == 1);
                var regions = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                            .Select(
                                GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.As("AREACODE"),
                                GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME")
                              )
                            .ToList<JDHomePageModel>();

                //列表返回值
                if (model.REGION_CODE.Length < 4)
                {
                    list = Jd.TSuperviseResultService.FromWhere(condition.ToWhereClip())
                       .GroupBy(gm)
                       .Select(
                           T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.Substring(0, 4).As("Label"),
                           T_SUPERVISE_RESULT._.All.Count().As("Value")
                       )
                       .ToList<LabelValueModel<int>>();
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    list = Jd.TSuperviseResultService.FromWhere(condition.ToWhereClip())
                          .GroupBy(gm)
                          .Select(
                              T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.As("Label"),
                              T_SUPERVISE_RESULT._.All.Count().As("Value")
                          )
                          .ToList<LabelValueModel<int>>();
                }
                var d = Jd.TSuperviseResultService
                .FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.ENTITY_REGION_CODE == "350128").Count();
                //350100  350128
                result = regions.Select(c =>
                {
                    var value = new int();
                    if (model.REGION_CODE.Length < 4)
                    {
                        value = list.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value ?? 0;
                    }
                    else if (model.REGION_CODE.Length >= 4)
                    {
                        value = list.FirstOrDefault(v => v.Label == c.AREACODE)?.Value ?? 0;
                    }
                    if (c.AREACODE == "350100")
                    {
                        value = value - d;
                    }

                    if (c.AREACODE == "350128")
                    {
                        value = d;
                    }
                    var item = new LabelValueModel<int>()
                    {
                        Label = c.AREANAME,
                        Value = value
                    };
                    return item;
                }).ToList();
                //todo 返回值类型转换
                var r1 = new
                {
                    Label = result.Select(c => c.Label).ToList(),
                    Value = result.Select(c => c.Value).ToList(),
                };

                return r1;
            }

            return result;
        }

        #endregion

        #region 时限监督类型分布统计
        public object TimeProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootCode));
                #region 查询条件
                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                #endregion

                //列表返回值
                var list = Jd.TSuperviseResultService.FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.WARNING == 1 && T_SUPERVISE_RESULT._.STATUS == 1)
                          .GroupBy(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME)
                          .Select(
                                    T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME.As("ENTITY_TYPE_NAME"),
                                    T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME.Count().As("ENTITY_TYPE_NAME_COUNT")
                                  )
                          .ToList<JDHomePageModel>();
                //返回列表值
                Dictionary<string, string> dic = new Dictionary<string, string>()
                {
                    {"T_AFC_PROJECT","招标计划" },
                    {"PT_ZXTS","投诉处理" },
                    {"RECORD_REVIEW","招标备案" },
                    {"WARN_RESULT","监督点处理" },
                    {"TENDER_PROJECT","招标项目" },
                    {"BD_VIOLATION_RECORD","疑似违规点" },
                };
                var result = new List<object>();
                foreach (var item in dic)
                {
                    var count = list.FirstOrDefault(c => c.ENTITY_TYPE_NAME == item.Key)?.ENTITY_TYPE_NAME_COUNT ?? 0;
                    if (item.Key == "BD_VIOLATION_RECORD")
                    {
                        count = list.FirstOrDefault(c => c.ENTITY_TYPE_NAME == item.Key || c.ENTITY_TYPE_NAME == "BD_VIOLATION_ENTITY")?.ENTITY_TYPE_NAME_COUNT ?? 0;
                    }
                    result.Add(new LabelValueModel { Label = item.Value, Value = count.ToString() });
                }
                //返回列表值
                return result;
            }
            return null;
        }

        #endregion

        #region 异常项目统计
        public object RedProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));
                #region 查询条件 统计异常项目总数

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                #endregion

                #region 查询条件 处理超期数
                var condition1 = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition1.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition1.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));
                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition1.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition1.And(WARN_RESULT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                #endregion
                //列表返回值

                var list = Fw.WarnResultService.FromWhere(condition1.ToWhereClip() && WARN_RESULT._.OPERATE_STATUS == 1
                                                          && WARN_RESULT._.LAST_RECORD_TIME < DateTime.Today)
                           .Select(WARN_RESULT._.M_ID.Count().As("NoUse"))
                           .ToScalar<int>();
                var list1 = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 3)
                           .Select(WARN_RESULT._.M_ID.Count().As("red"))
                           .ToScalar<int>();
                return new
                {
                    NoUse = list,
                    red = list1

                };
            }
            return null;
        }

        #endregion

        #region 各地区监督点异常项目总数 
        public object AreaRedProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            var result = new List<LabelValueModel<int>>();
            var gm = new Field("WARN_RESULT._.REGION_CODE");//用于设置分组条件
            var list = new List<LabelValueModel<int>>();
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();
                var condition1 = new WhereClipBuilder();
                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));
                #region 查询条件

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    if (model.REGION_CODE.Length < 4)
                    {
                        gm = WARN_RESULT._.REGION_CODE.Substring(0, 4);
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == "350000" && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350000");
                    }
                    else if (model.REGION_CODE.Length >= 4)
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.BeginWith(model.REGION_CODE)
                                    && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.Substring(5, 6) != "00");
                        gm = WARN_RESULT._.REGION_CODE;
                        if (model.REGION_CODE == "3501")
                        {
                            condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350128");
                        }
                    }
                    condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                #endregion

                //地区查询
                var regions = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                            .Select(
                                GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.As("AREACODE"),
                                GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME")
                              )
                            .ToList<JDHomePageModel>();

                //列表返回值
                if (model.REGION_CODE.Length < 4)
                {
                    list = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 3)
                              .GroupBy(WARN_RESULT._.REGION_CODE.Substring(0, 4))
                              .Select(
                                  WARN_RESULT._.REGION_CODE.Substring(0, 4).As("Label"),
                                  WARN_RESULT._.All.Count().As("Value")
                                 ).ToList<LabelValueModel<int>>();
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    list = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 3)
                           .GroupBy(WARN_RESULT._.REGION_CODE)
                           .Select(
                               WARN_RESULT._.REGION_CODE.As("Label"),
                               WARN_RESULT._.All.Count().As("Value")
                              ).ToList<LabelValueModel<int>>();

                }
                var d = Fw.WarnResultService
                .FromWhere(condition.ToWhereClip() && WARN_RESULT._.REGION_CODE == "350128").Count();
                //350100  350128
                result = regions.Select(c =>
                {
                    var value = new int();
                    if (model.REGION_CODE.Length < 4)
                    {
                        value = list.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value ?? 0;
                    }
                    else if (model.REGION_CODE.Length >= 4)
                    {
                        value = list.FirstOrDefault(v => v.Label == c.AREACODE)?.Value ?? 0;
                    }
                    if (c.AREACODE == "350100")
                    {
                        value = value - d;
                    }

                    if (c.AREACODE == "350128")
                    {
                        value = d;
                    }
                    var item = new LabelValueModel<int>()
                    {
                        Label = c.AREANAME,
                        Value = value
                    };
                    return item;
                }).ToList();
                //todo 返回值类型转换
                var r1 = new
                {
                    Label = result.Select(c => c.Label).ToList(),
                    Value = result.Select(c => c.Value).ToList(),
                };

                return r1;
            }
            return null;
        }

        #endregion

        #region 异常项目类型分布统计
        public object RedProject(JDHomePageModel model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));
                #region 查询条件

                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
                }
                //归属地
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
                //行业类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                #endregion

                //列表返回值
                var list = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && (WARN_RESULT._.RESULT_STATUS == 3 || WARN_RESULT._.RESULT_STATUS == 2))
                           .LeftJoin<GGZYFW.DbEntity.SYS_DIC>(GGZYFW.DbEntity.SYS_DIC._.TYPE == "2002" && GGZYFW.DbEntity.SYS_DIC._.VALUE == WARN_RESULT._.TENDER_PROJECT_TYPE)
                           .GroupBy(WARN_RESULT._.TENDER_PROJECT_TYPE.Replace("G", "A"))
                          .Select
                          (
                               WARN_RESULT._.All.Count().As("Value"),
                               GGZYFW.DbEntity.SYS_DIC._.TEXT.Max().As("Label")
                          )
                          .ToList<LabelValueModel>();

                return list;
            }
            return null;
        }

        #endregion

        #region 移送事项统计
        public object SendProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            var condition1 = new WhereClipBuilder();

            #region 查询条件 发出移送
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNIT_REGION.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNIT_HY_TYPE == (model.TENDER_PROJECT_TYPE));
            }

            #endregion

            #region 查询条件 收到移送
            //时间
            if (search.BeginTime.HasValue)
            {
                condition1.And(JC_TRANS_RECORD._.TRANS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition1.And(JC_TRANS_RECORD._.TRANS_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition1.And(JC_TRANS_RECORD._.RECEIVER_UNIT_REGION.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition1.And(JC_TRANS_RECORD._.RECEIVER_UNIT_HY_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            #endregion


            //列表返回值
            //收到
            var list = Jd.JcTransRecordService.FromWhere(condition1.ToWhereClip() && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.DEPARTID)
                       .Select(JC_TRANS_RECORD._.All.Count().As("Accept"))
                       .ToScalar<int>();

            //发送
            var list1 = Jd.JcTransRecordService.FromWhere(condition.ToWhereClip() && JC_TRANS_RECORD._.TRANS_USER_ID == JdUser?.ID)
                       .Select(JC_TRANS_RECORD._.All.Count().As("Send"))
                       .ToScalar<int>();

            //返回列表值
            return new
            {
                Accept = list,
                Send = list1

            };
        }

        #endregion

        #region 移送事项类型统计
        public object SendProjectType(JDHomePageModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            var condition1 = new WhereClipBuilder();

            #region 查询条件 发出移送
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNIT_REGION.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNIT_HY_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            condition.And((JC_TRANS_RECORD._.TRANS_USER_ID == JdUser?.ID));
            #endregion

            #region 查询条件 收到移送
            //时间
            if (search.BeginTime.HasValue)
            {
                condition1.And(JC_TRANS_RECORD._.TRANS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition1.And(JC_TRANS_RECORD._.TRANS_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition1.And(JC_TRANS_RECORD._.RECEIVER_UNIT_REGION.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition1.And(JC_TRANS_RECORD._.RECEIVER_UNIT_HY_TYPE == (model.TENDER_PROJECT_TYPE));
            }
            //移送对象部门ID为当前登录用户所在组织机构id 或者 操作人ID为当前登录用户
            condition1.And((JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.DEPARTID));
            #endregion

            //列表返回值
            var list = Jd.JcTransRecordService.FromWhere(condition.ToWhereClip())
                      .GroupBy(JC_TRANS_RECORD._.TRANS_TYPE)
                      .Select(
                        JC_TRANS_RECORD._.TRANS_TYPE.As("Label"),
                        JC_TRANS_RECORD._.TRANS_TYPE.Count().As("Value")
                        )
                      .ToList<LabelValueModel>();

            var list1 = Jd.JcTransRecordService.FromWhere(condition1.ToWhereClip())
                      .GroupBy(JC_TRANS_RECORD._.TRANS_TYPE)
                      .Select(
                        JC_TRANS_RECORD._.TRANS_TYPE.As("Label"),
                        JC_TRANS_RECORD._.TRANS_TYPE.Count().As("Value")
                        )
                      .ToList<LabelValueModel>();

        Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"1","项目" },
                {"2","主体" },
                {"3","公职人员" },
                {"9","其他" },
            };
            var result = new List<object>();
            foreach (var item in dic)
            {
                var count = list.FirstOrDefault(c => c.Label == item.Key)?.Value.ToDecimal() ?? 0;
                var count1 = list1.FirstOrDefault(c => c.Label == item.Key)?.Value.ToDecimal() ?? 0;
                result.Add(new LabelValueModel { Label = item.Value, Value = (count + count1).ToString() });
            }
            //返回列表值
            return result;
        }

        #endregion

        #region 移送地区统计

        public object SendProjectArea(JDHomePageModel model, SearchCondition search)
        {

            var result = new List<SYLabelValueModel<int>>();
            var list = new List<SYLabelValueModel<int>>();
            var list1 = new List<SYLabelValueModel<int>>();
            var condition = new WhereClipBuilder();//发出移送
            var condition1 = new WhereClipBuilder();//地区条件
            var condition2 = new WhereClipBuilder();//收到移送
            var gm = new Field("JC_TRANS_RECORD._.TRANS_UNIT_REGION");//用于设置分组条件
            var gm1 = new Field("JC_TRANS_RECORD._.RECEIVER_UNIT_REGION");//用于设置分组条件
            #region 查询条件 发出移送
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                if (model.REGION_CODE.Length < 4)
                {
                    gm = JC_TRANS_RECORD._.TRANS_UNIT_REGION.Substring(0, 4);
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == "350000" && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350000");
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.BeginWith(model.REGION_CODE)
                                && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.Substring(5, 6) != "00");
                    gm = JC_TRANS_RECORD._.TRANS_UNIT_REGION;
                    if (model.REGION_CODE == "3501")
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350128");
                    }
                }
                condition.And(JC_TRANS_RECORD._.TRANS_UNIT_REGION.BeginWith(model.REGION_CODE));
            }
            //行业类型
                   if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNIT_HY_TYPE == (model.TENDER_PROJECT_TYPE));
            }

            #endregion

            #region 查询条件 收到移送
            //时间
            if (search.BeginTime.HasValue)
            {
                condition2.And(JC_TRANS_RECORD._.TRANS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition2.And(JC_TRANS_RECORD._.TRANS_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                if (model.REGION_CODE.Length < 4)
                {
                    gm1 = JC_TRANS_RECORD._.RECEIVER_UNIT_REGION.Substring(0, 4);
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == "350000" && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350000");
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.BeginWith(model.REGION_CODE)
                                && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.Substring(5, 6) != "00");
                    gm1 = JC_TRANS_RECORD._.RECEIVER_UNIT_REGION;
                    if (model.REGION_CODE == "3501")
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350128");
                    }
                }
                condition2.And(JC_TRANS_RECORD._.RECEIVER_UNIT_REGION.BeginWith(model.REGION_CODE));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition2.And(JC_TRANS_RECORD._.RECEIVER_UNIT_HY_TYPE == (model.TENDER_PROJECT_TYPE));
            }

            #endregion

            //地区返回
            var regions = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                                       .Select(
                                           GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.As("AREACODE"),
                                           GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME")
                                         )
                                       .ToList<JDHomePageModel>();
            // 列表返回值
            if (model.REGION_CODE.Length < 4)
            {
                //发出
                list = Jd.JcTransRecordService.FromWhere(condition.ToWhereClip() && JC_TRANS_RECORD._.TRANS_USER_ID == JdUser?.ID)
                            .GroupBy(gm)
                           .Select(
                                  JC_TRANS_RECORD._.TRANS_UNIT_REGION.Substring(0, 4).As("Label"),
                                  JC_TRANS_RECORD._.All.Count().As("Value")
                                     )
                               .ToList<SYLabelValueModel<int>>();
                //收到
                list1 = Jd.JcTransRecordService.FromWhere(condition2.ToWhereClip() && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.DEPARTID)
                          .GroupBy(gm1)
                          .Select(
                                  JC_TRANS_RECORD._.RECEIVER_UNIT_REGION.Substring(0, 4).As("Label"),
                                  JC_TRANS_RECORD._.All.Count().As("Value1")
                                     )
                               .ToList<SYLabelValueModel<int>>();
            }
            else if (model.REGION_CODE.Length >= 4)
            {
                //发出
                list = Jd.JcTransRecordService.FromWhere(condition.ToWhereClip() && JC_TRANS_RECORD._.TRANS_USER_ID == JdUser?.ID)
                      .GroupBy(gm)
                      .Select(
                             JC_TRANS_RECORD._.TRANS_UNIT_REGION.As("Label"),
                             JC_TRANS_RECORD._.All.Count().As("Value")
                                )
                          .ToList<SYLabelValueModel<int>>();
                //收到
                list1 = Jd.JcTransRecordService.FromWhere(condition2.ToWhereClip() && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.DEPARTID)
                       .GroupBy(gm1)
                       .Select(
                               JC_TRANS_RECORD._.RECEIVER_UNIT_REGION.As("Label"),
                               JC_TRANS_RECORD._.All.Count().As("Value1")
                                  )
                            .ToList<SYLabelValueModel<int>>();
            }
            //计算发送时，平潭地区的个数
            var t = Jd.JcTransRecordService
                   .FromWhere(condition.ToWhereClip() && JC_TRANS_RECORD._.TRANS_UNIT_REGION == "350128").Count();
            //计算收到时，平潭地区的个数
            var d = Jd.JcTransRecordService
                    .FromWhere(condition2.ToWhereClip() && JC_TRANS_RECORD._.RECEIVER_UNIT_REGION == "350128").Count();

            //返回列表值
            result = regions.Select(c =>
            {
                var value = new int();
                var value1= new int();
                if (model.REGION_CODE.Length < 4)
                {
                    value = list.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value ?? 0;
                    value1 = list1.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value1 ?? 0;
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    value = list.FirstOrDefault(v => v.Label == c.AREACODE)?.Value ?? 0;
                    value1 = list1.FirstOrDefault(v => v.Label == c.AREACODE)?.Value1 ?? 0;
                }
                if (c.AREACODE == "350100" )
                {
                        value = value - t;
                        value1 = value1 - d;
                }
                if (c.AREACODE == "350128")
                {
                        value = t;
                        value1 = d;
                }
                var item = new SYLabelValueModel<int>()
                {
                    Label = c.AREANAME,
                    Value = value,//发出
                    Value1 = value1//收到
                };
                return item;
            }).ToList();
            return new
            {
                areaname = result.Select(c => c.Label).ToList(),
                value = result.Select(c => c.Value).ToList(),
                value1 = result.Select(c => c.Value1).ToList(),
            };

        }

        #endregion

        #region 处罚记录统计 
        public object CFRecord(JDHomePageModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();

            #region 查询条件

            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_PUNISH._.REGION_CODE.BeginWith(model.REGION_CODE));
            }
            // 行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_PUNISH._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }

            #endregion
            condition.And(T_PUNISH._.USE_OPERATOR == JdUser?.ID);

            //列表返回值
            var list = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                      .Select
                      (
                            T_PUNISH._.All.Count().As("USE_OPERATOR_COUNT")
                       ).ToScalar<int>();

            return new
            {
                USE_OPERATOR_COUNT = list
            };
        }

        #endregion

        #region 处罚记录各地区分布
        public object CFRecordCount(JDHomePageModel model, SearchCondition search)
        {
            var result = new List<LabelValueModel<int>>();
            var gm = new Field("T_PUNISH._.REGION_CODE");//用于设置分组条件
            var list = new List<LabelValueModel<int>>();
            var condition = new WhereClipBuilder();
            var condition1 = new WhereClipBuilder();
            #region 查询条件

            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME <= search.EndTime);
            }
            //归属地
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                if (model.REGION_CODE.Length < 4)
                {
                    gm = T_PUNISH._.REGION_CODE.Substring(0, 4);
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == "350000" && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350000");
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.BeginWith(model.REGION_CODE)
                                && GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.Substring(5, 6) != "00");
                    gm = T_PUNISH._.REGION_CODE;
                    if (model.REGION_CODE == "3501")
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE != "350128");
                    }
                }
                condition.And(T_PUNISH._.REGION_CODE.BeginWith(model.REGION_CODE));
            }
            // 行业类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_PUNISH._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }

            #endregion
            condition.And(T_PUNISH._.USE_OPERATOR == JdUser?.ID);
            //地区返回值
            var regions = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                        .Select(
                            GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.As("AREACODE"),
                            GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME")
                          )
                        .ToList<JDHomePageModel>();
            //列表返回值
            if (model.REGION_CODE.Length < 4)
            {
                list = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                         .GroupBy(gm)
                         .Select
                         (
                               T_PUNISH._.REGION_CODE.Substring(0, 4).As("Label"),
                               T_PUNISH._.All.Count().As("Value")
                           )
                        .ToList<LabelValueModel<int>>();
            }
            else if (model.REGION_CODE.Length >= 4)
            {
                list = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                      .GroupBy(gm)
                      .Select
                      (
                            T_PUNISH._.REGION_CODE.As("Label"),
                            T_PUNISH._.All.Count().As("Value")
                        )
                     .ToList<LabelValueModel<int>>();

            }
            var d = Jd.TPunishService
                   .FromWhere(condition.ToWhereClip() && T_PUNISH._.REGION_CODE == "350128").Count();

            result = regions.Select(c =>
            {
                var value = new int();
                if (model.REGION_CODE.Length < 4)
                {
                    value = list.FirstOrDefault(v => v.Label == c.AREACODE.Substring(0, 4))?.Value ?? 0;
                }
                else if (model.REGION_CODE.Length >= 4)
                {
                    value = list.FirstOrDefault(v => v.Label == c.AREACODE)?.Value ?? 0;
                }
                if (c.AREACODE == "350100")
                {
                    value = value - d;
                }

                if (c.AREACODE == "350128")
                {
                    value = d;
                }
                var item = new LabelValueModel<int>()
                {
                    Label = c.AREANAME,
                    Value = value
                };
                return item;
            }).ToList();
            var r1 = new
            {
                Label = result.Select(c => c.Label).ToList(),
                Value = result.Select(c => c.Value).ToList(),
            };

            return r1;
        }

        #endregion

        #endregion

        #region 智能监察

        public List<LabelValueModel> PointSuperviseCount(TSuperviseResultSearchModel model)
        {
            var condition = PointConditionBuilder(model);

            var normal = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 0)
                .Select(new Field("'正常项目（个）'").As("Label"), Field.All.Count().As("Value"));
            var red = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 1)
                .Select(new Field("'红灯项目（个）'").As("Label"), Field.All.Count().As("Value"));

            var r = FromWhere(condition.ToWhereClip())
                .Select(new Field("'监察项目数（个）'").As("Label"), Field.All.Count().As("Value"))
                .UnionAll(normal)
                .UnionAll(red)
                .ToList<LabelValueModel>();

            return r;
        }
        public PageTableResult<TSupervisePointResultModel> PointSuperviseList(TSuperviseResultSearchModel model)
        {
            var condition = PointConditionBuilder(model);
            //var tenderProject = Jd.TenderProjectService
            //    .FromWhere(TENDER_PROJECT._.M_ID_GGFW.IsNotNull() && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() &&
            //               RECORD_REVIEW._.REVIEW_STATUS != '0')
            //    .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
            //    .GroupBy(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
            //    .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1, TENDER_PROJECT._.RECORD_DEPID.Max());

            var queryable = FromWhere(condition.ToWhereClip())
                .LeftJoin<GGZYJD.DbEntity.SYS_AREA_QUANGUO>(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == T_SUPERVISE_RESULT._.ENTITY_REGION_CODE);
            var total = queryable.Count();
            if (total > 0)
            {
                var list = queryable
                    .OrderBy(T_SUPERVISE_RESULT._.SUPERVISE_TIME.Desc)
                    .Page(model.PageSize, model.PageNo)
                    .Select(T_SUPERVISE_RESULT._.All,
                        T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE.As("CODE"),
                        T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_NAME.As("PROJECT_NAME"),
                        //T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("REGION_NAME"))
                    .ToList<TSupervisePointResultModel>();
                var tenderProjectCodes = list.Select(c => c.CODE).Distinct().ToList();
                var tenderProjects =
                    Jd.TenderProjectService.FindList(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.In(tenderProjectCodes));
                var depids = tenderProjects.Select(c => c.RECORD_DEPID).ToList();
                var departs = Jd.TUserDepartmentService.FindList(T_USER_DEPARTMENT._.DEPID.In(depids));
                var warnid = list.Select(c => c.ENTITY_ID).ToList();
                var warns = Fw.WarnResultService.FromWhere(WARN_RESULT._.M_ID.In(warnid))
                    .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                    .Select(WARN_RESULT._.M_ID, WARN_EXPRESSION._.SP_NAME).ToList<WARN_EXPRESSION>();
                var pageList = list.ToPageTableTResult(model, total, c =>
                {
                    var tenderProject = tenderProjects.FirstOrDefault(o => o.TENDER_PROJECT_CODE_OLD1 == c.CODE);
                    c.APPROVAL_DEPNAME = departs.FirstOrDefault(d => d.DEPID.ToString() == tenderProject?.RECORD_DEPID)?.DNAME;
                    c.DEPID = departs.FirstOrDefault(d => d.DEPID.ToString() == tenderProject?.RECORD_DEPID)?.DEPID?.ToString();
                    c.SPNAME = warns.FirstOrDefault(w => w.M_ID?.ToString() == c.ENTITY_ID)?.SP_NAME;
                    return c;
                });
                return pageList;
            }

            return model.ToPageTableTResult<TSupervisePointResultModel>(total);
        }

        public GeneralResult<UploadResData> PointExport(TSuperviseResultSearchModel model)
        {
            model.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = PointSuperviseList(model);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    //Id = Guid.NewGuid().ToString("N"),
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/智能监察_招标备案_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }
        /// <summary>
        /// 监察详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult PointSuperviseDetail(TSuperviseResultModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(T_SUPERVISE_RESULT._.M_ID == model.M_ID)
                .Select(T_SUPERVISE_RESULT._.All,
                    T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE.As("CODE"),
                    T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_NAME.As("PROJECT_NAME")
                )
                .ToFirst<TSuperviseResultModel>(); //审查状态
            if (dbModel != null)
            {
                var tenderProject =
                    Jd.TenderProjectService.FirstOrNull(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == dbModel.CODE);
                if (!string.IsNullOrWhiteSpace(tenderProject?.RECORD_DEPID))
                {
                    dbModel.APPROVAL_DEPNAME = Jd.TUserDepartmentService
                        .FirstOrNull(T_USER_DEPARTMENT._.DEPID == tenderProject.RECORD_DEPID)?.DNAME;
                }
                dbModel.Logs =
                    FromWhere<T_SUPERVISE_RESULT_LOG>(T_SUPERVISE_RESULT_LOG._.SUPERVISE_ID == model.M_ID)
                        .OrderByDescending(T_SUPERVISE_RESULT_LOG._.SUPERVISE_TIME)
                        .ToList();

                #region 督查&反馈

                var entityTypeName = dbModel.ENTITY_TYPE_NAME;
                var supervise = FromWhere<T_SUPERVISE>(T_SUPERVISE._.ENTITY_ID == dbModel.ENTITY_ID && T_SUPERVISE._.ENTITY_TYPE_NAME == entityTypeName).ToList<TSuperviseModel>();
                var feedback = FromWhere<T_SUPERVISE_FEEDBACK>(T_SUPERVISE_FEEDBACK._.ENTITY_ID == dbModel.ENTITY_ID && T_SUPERVISE_FEEDBACK._.ENTITY_TYPE_NAME == entityTypeName).ToList<TSuperviseFeedbackModel>();
                var superviseFeedback = new List<TSuperviseAndFeedbackModel>();
                foreach (var PointSuperviseModel in supervise)
                {
                    PointSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        PointSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "发起督查",
                        VALUE = nameof(T_SUPERVISE),
                        TIME = PointSuperviseModel.TIME,
                        DATA = PointSuperviseModel
                    });
                }
                foreach (var PointSuperviseModel in feedback)
                {
                    PointSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        PointSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "督察反馈",
                        VALUE = nameof(T_SUPERVISE_FEEDBACK),
                        TIME = PointSuperviseModel.TIME,
                        DATA = PointSuperviseModel
                    });
                }


                #endregion

                dbModel.SuperviseFeedback = superviseFeedback.OrderByDescending(c => c.TIME).ToList();

                r.SetSuccess(dbModel);
            }
            else
            {
                r.SetFail("未找到对应的监察记录信息");
            }

            return r;
        }

        /// <summary>
        /// 监督点·督察
        /// </summary>
        /// <returns></returns>
        public GeneralResult PointSupervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = nameof(WARN_RESULT);
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            var superviseItem = Fw.WarnResultService.FromWhere(WARN_RESULT._.M_ID == model.ENTITY_ID)
                .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                .Select(GGZYFW.DbEntity.WARN_RESULT._.All, GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME)
                .ToFirst<JDCount_Model>();
            model.TENDER_PROJECT_CODE = superviseItem?.TENDER_PROJECT_CODE;
            model.TENDER_PROJECT_NAME = superviseItem?.TENDER_PROJECT_NAME;
            model.TENDER_PROJECT_TYPE = superviseItem?.TENDER_PROJECT_TYPE;
            model.REGION_CODE = superviseItem?.REGION_CODE;
            model.ENTITY_NAME = superviseItem?.TENDER_PROJECT_NAME;
            if (!string.IsNullOrWhiteSpace(model.OBJ) && decimal.TryParse(model.OBJ, out decimal objId))
            {
                //var obj = Jd.TUserService.JdUserInfo(objId);
                var obj = Jd.TUserDepartmentService.FindDepartmentByDepid(objId);
                model.OBJ_NAME = obj?.DNAME;
                model.OBJ_DEP_ID = obj?.DEPID?.ToString();
                model.OBJDEP_NAME = obj?.DNAME;// obj?.UserDepartment?.DNAME;
                model.CODE = CreateSuperviseCode();
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.FILES_ATTACHMENT.Select(c => c.JdSysAttachment()).ToList();
                    trans.Insert(attachments);
                    model.FILES = string.Join(",", attachments.Select(c => c.GUID));
                    var entity = model.ConvertTo<T_SUPERVISE>();
                    trans.Insert(entity);

                    #region 督查操作记录

                    var log = new T_SUPERVISE_LOG
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = model.M_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        LOG_TIME = DateTime.Now,
                        LOG_TYPE = "10",
                        LOG_TYPE_TXT = "发起督察",
                        SUPERVISE_FEEDBACK_ID = String.Empty,
                        SUPERVISE_FORWORD_ID = string.Empty,
                    };
                    trans.Insert(log);

                    #endregion

                    #region 督查流转实例
                    var forward = new T_SUPERVISE_FORWARD
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = model.M_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        FORWARD_TIME = DateTime.Now,
                        SUPERVISE_INSTANCE_ID = model.M_ID,
                    };
                    trans.Insert(forward);


                    #endregion

                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail("请选择督查对象");
            }

            return r;
        }

       
        protected WhereClipBuilder PointConditionBuilder(TSuperviseResultSearchModel model)
        {
            #region condition builder

            var entityName = nameof(WARN_RESULT);// model.ENTITY_TYPE_NAME;
            var condition = new WhereClipBuilder(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName && T_SUPERVISE_RESULT._.WARNING == 1);
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_NAME.Contain(model.PROJECT_NAME));
            }

            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_NAME.Contain(model.CODE));
            }

            if (model.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME >= model.BeginTime);
            }

            if (model.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE == model.REGION_CODE);
            }

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE == model.PROJECT_TYPE);
            }

            if (!string.IsNullOrWhiteSpace(model.STATUS))
            {
                condition.And(T_SUPERVISE_RESULT._.STATUS == model.STATUS);
            }

            //if (!string.IsNullOrWhiteSpace(model.DEPID))
            //{
            //    condition.And(TENDER_PROJECT._.RECORD_DEPID == model.DEPID);
            //}
            #endregion


            #region 纪委监委组织机构所在归属地过滤

            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootAreaCode));
                if (rootAreaCode == "3501")
                {
                    condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE != "350128");
                }
            }

            #endregion

            #region 纪委监委组织机构可查看行业过滤

            var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63;
            if (hyTypes != null && hyTypes.Any())
            {
                var projectTypes = hyTypes.Select(c => c.VALUE3).ToList();//A01 A02
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(projectTypes));
            }

            #endregion

            return condition;
        }

        #endregion

        #region 行政监督信息

        #region 招投标过程监督

        #region 监督点统计



        #region 监督点统计接口

        protected WhereClipBuilder PointCondition(JDCount_Model model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            var hylist = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                #region condition 条件拼接

                //状态
                if (!string.IsNullOrWhiteSpace(model.SP_STATUS))
                {
                    condition.And(WARN_RESULT._.RESULT_STATUS == model.SP_STATUS);
                }
                //监督点名称
                if (!string.IsNullOrWhiteSpace(model.SP_NAME))
                {
                    condition.And(WARN_EXPRESSION._.SP_NAME.Contain(model.SP_NAME));
                }
                //监督点类型
                if (!string.IsNullOrWhiteSpace(model.SP_TYPE))
                {

                    condition.And(WARN_EXPRESSION._.SP_TYPE == model.SP_TYPE);
                }
                //监督方式
                if (!string.IsNullOrWhiteSpace(model.SP_WAY))
                {

                    condition.And(WARN_EXPRESSION._.SP_WAY == model.SP_WAY);
                }
                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
                }
                //所在地区
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
                }
                //监督方式
                if (!string.IsNullOrWhiteSpace(model.SP_FLOW_NAME))
                {
                    condition.And(WARN_EXPRESSION._.SP_FLOW_NAME == model.SP_FLOW_NAME);
                }
                //业务类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
                }

                //}
                #endregion


                #region 纪委监委组织机构所在归属地过滤


                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));
                if (rootCode == "3501")
                {
                    condition.And(WARN_RESULT._.REGION_CODE != "350128");
                }

                #endregion

                #region 纪委监委组织机构可查看行业过滤

                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hylist));

                #endregion
            }
            else
            {
                condition.And("1=0");
            }


            return condition;
        }
        public List<LabelValueModel<int>> PointJDCount(JDCount_Model model, SearchCondition search)
        {
            var condition = PointCondition(model, search);
            var stat = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .GroupBy(WARN_RESULT._.RESULT_STATUS)
                .Select(WARN_RESULT._.RESULT_STATUS.As("Label"), Field.All.Count().As("Value")).ToList<LabelValueModel<int>>();
            List<LabelValueModel<int>> r;
            if (stat.Any())
            {
                r = new List<LabelValueModel<int>>
                {
                    new LabelValueModel<int>{Id="Info",Label ="监督点总数（个）",Value =stat.Sum(s=>s.Value)},
                    new LabelValueModel<int>{Id="Success",Label ="正常监督点（个）",Value =stat.FirstOrDefault(s=>s.Label=="1")?.Value??0},
                    new LabelValueModel<int>{Id="Danger",Label ="红灯（个）",Value =stat.FirstOrDefault(s=>s.Label=="3")?.Value??0},
                    new LabelValueModel<int>{Id="Warning",Label ="黄灯（个）",Value =stat.FirstOrDefault(s=>s.Label=="2")?.Value??0},
                    //new LabelValueModel<int>{Id="Primary",Label ="未监督点（个）",Value =stat.FirstOrDefault(s=>s.Label=="0")?.Value??0},
                };
            }
            else
            {
                r = new List<LabelValueModel<int>>
                {
                    new LabelValueModel<int>{Id="Info",Label ="监督点总数（个）",Value =0},
                    new LabelValueModel<int>{Id="Success",Label ="正常监督点（个）",Value =0},
                    new LabelValueModel<int>{Id="Danger",Label ="红灯（个）",Value =0},
                    new LabelValueModel<int>{Id="Warning",Label ="黄灯（个）",Value =0},
                    //new LabelValueModel<int>{Id="Primary",Label ="未监督点（个）",Value =0},
                };
            }
            return r;
        }
        #endregion

        #region 监督点列表接口
        public PageTableResult<JDCount_Model> PointSearchList(JDCount_Model model, SearchCondition search)
        {
            var condition = PointCondition(model, search);
            var total = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                    .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
                    .Count();
            var list = new List<JDCount_Model>();
            if (total > 0)
            {
                var query = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                    .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
                    .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE ==
                                                              GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .LeftJoin<GGZYFW.DbEntity.SYS_DIC>(GGZYFW.DbEntity.SYS_DIC._.TYPE == "2002" &&
                                                       GGZYFW.DbEntity.SYS_DIC._.VALUE == GGZYFW.DbEntity.TENDER_PROJECT
                                                           ._.TENDER_PROJECT_TYPE) //工程类别
                    .LeftJoin<GGZYFW.DbEntity.SYS_AREA_QUANGUO>(
                        GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == WARN_RESULT._.REGION_CODE)
                    .OrderByDescending(WARN_RESULT._.SP_TIME);
                if (search.PageSize < int.MaxValue)
                {
                    //分页页码
                    query.Page(search.PageSize, search.PageNo);
                }
                //列表返回值
                list = query.Select(
                           WARN_RESULT._.M_ID,
                           WARN_RESULT._.TENDER_PROJECT_CODE,
                           WARN_RESULT._.RESULT_STATUS.As("SP_STATUS"),
                           WARN_EXPRESSION._.SP_NAME,
                           WARN_EXPRESSION._.SP_TYPE,
                           WARN_EXPRESSION._.SP_WAY,
                           WARN_EXPRESSION._.SP_FLOW_NAME,
                           GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                           GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("REGION_CODE"),
                           GGZYFW.DbEntity.SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE"),
                           GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                           //需要修改，只返回空字符,需重构
                           GGZYFW.DbEntity.SYS_DIC._.VALUE2.As("APPROVAL_DEPNAME"),
                           //用于返回G01,G02....
                           WARN_RESULT._.TENDER_PROJECT_TYPE.As("G_TENDER_PROJECT_TYPE")
                  ).ToList<JDCount_Model>();
            }

            var jdTenderProjects = new List<GGZYJD.DbEntity.TENDER_PROJECT>();
            if (total > 0 && search.PageSize < int.MaxValue)
            {
                var fwTenderProjectCodes = list.Select(c => c.TENDER_PROJECT_CODE).ToArray();
                jdTenderProjects = Jd.TenderProjectService.GetJdTenderProjectsFwTpCodes(fwTenderProjectCodes);
            }
            var isJw = JdUser?.TYPE == (int)JdTUserType.JiWeiJianWei;//是否是纪委监委
            //返回列表值
            var pageList = list.ToPageTableTResult(search, total, c =>
            {
                c.Buttons.Add("DETAIL");
                c.JD_TENDER_PROJECT_CODE = jdTenderProjects
                    .FirstOrDefault(o => o.TENDER_PROJECT_CODE_OLD1 == c.TENDER_PROJECT_CODE)?.TENDER_PROJECT_CODE;
                if (isJw)
                {
                    c.Buttons.Add("SUPERVISE");
                }
                return c;
            });
            return pageList;
        }

        public GeneralResult<UploadResData> PointSearchExport(JDCount_Model model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = PointSearchList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/行政监督信息_监督点统计_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }
        #endregion

        #endregion

        #region 项目监督

        #region  项目监督 监督点统计
        protected WhereClipBuilder ProjectPointCondition(XinWarnResultModel model, SearchCondition search)
        {

            var condition = new WhereClipBuilder();
            var hylist = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{ "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2", "A96", "A97", "A13", "A14" };
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;// ?? "35";
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                #region 查询条件

                //招标项目编号
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
                }
                //招标项目名称
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
                {
                    condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
                }
                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.CREATE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.CREATE_TIME <= search.EndTime);
                }
                //所在地区
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE == (model.REGION_CODE));
                }
                //业务类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))//A01 =>A01 G01
                {
                    var gType = model.TENDER_PROJECT_TYPE.Replace("A", "G");
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE) || GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE == gType);
                }

                //状态
                if (!string.IsNullOrWhiteSpace(model.RESULT_STATUS))
                {
                    condition.And(WARN_RESULT._.RESULT_STATUS == model.RESULT_STATUS);
                }
                #endregion

                #region 纪委监委组织机构所在归属地过滤

                condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE.BeginWith(rootCode));
                if (rootCode == "3501")
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE != "350128");
                }

                #endregion

                #region 纪委监委组织机构可查看行业过滤
                condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(hylist));

                #endregion
            }
            else
            {
                condition.And("1=0");
            }





            return condition;
        }

        public List<LabelValueModel<int>> ProjectPointJDCount(XinWarnResultModel model, SearchCondition search)
        {
            var condition = ProjectPointCondition(model, search);

            var warnResultTmp = Fw.WarnResultService.FromWhere()
                .GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE)
                .Select(
                    WARN_RESULT._.RESULT_STATUS.Max().Nvl(0).As("RESULT_STATUS"),
                    WARN_RESULT._.TENDER_PROJECT_CODE);

            //数据记录条数
            var stat = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())
                .LeftJoinTmp<WARN_RESULT>(warnResultTmp,
                    GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                .GroupBy(WARN_RESULT._.RESULT_STATUS)
                .Select(WARN_RESULT._.RESULT_STATUS.As("Label"),
                    GGZYFW.DbEntity.TENDER_PROJECT._.M_ID.Count().As("Value")).ToList<LabelValueModel<int>>();
            List<LabelValueModel<int>> r;
            if (stat.Any())
            {
                r = new List<LabelValueModel<int>>
                {
                    new LabelValueModel<int>{Id="Info",Label ="监督项目数（个）",Value =stat.Sum(s=>s.Value)},
                    new LabelValueModel<int>{Id="Success",Label ="正常项目（个）",Value =stat.FirstOrDefault(s=>s.Label=="1")?.Value??0},
                    new LabelValueModel<int>{Id="Danger",Label ="红灯项目（个）",Value =stat.FirstOrDefault(s=>s.Label=="3")?.Value??0},
                    new LabelValueModel<int>{Id="Warning",Label ="黄灯项目（个）",Value =stat.FirstOrDefault(s=>s.Label=="2")?.Value??0},
                    //new LabelValueModel<int>{Id="Primary",Label ="未监督项目（个）",Value =stat.FirstOrDefault(s=>s.Label=="0")?.Value??0},
                };
            }
            else
            {
                r = new List<LabelValueModel<int>>
                {
                    new LabelValueModel<int>{Id="Info",Label ="监督项目数（个）",Value =0},
                    new LabelValueModel<int>{Id="Success",Label ="正常项目（个）",Value =0},
                    new LabelValueModel<int>{Id="Danger",Label ="红灯项目（个）",Value =0},
                    new LabelValueModel<int>{Id="Warning",Label ="黄灯项目（个）",Value =0},
                    //new LabelValueModel<int>{Id="Primary",Label ="未监督项目（个）",Value =0},
                };
            }

            return r;
        }

        #endregion


        #region 项目监督 监督列表查询
        public PageTableResult<XinWarnResultModel> ProjectPointSearchList(XinWarnResultModel model, SearchCondition search)
        {
            var condition = ProjectPointCondition(model, search);

            var warnResultTmp = Fw.WarnResultService.FromWhere()
                .GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE)             
                .Select(
                    new Field("(CASE WHEN RESULT_STATUS='0' THEN 1 ELSE 0 END)").Sum().As("PRIMARY"),
                    new Field("(CASE WHEN RESULT_STATUS='1' THEN 1 ELSE 0 END)").Sum().As("NORMAL"),
                    new Field("(CASE WHEN RESULT_STATUS='2' THEN 1 ELSE 0 END)").Sum().As("WARNING"),
                    new Field("(CASE WHEN RESULT_STATUS='3' THEN 1 ELSE 0 END)").Sum().As("STRANG"),
                    new Field("SUM(1)").As("ALL"),
                    WARN_RESULT._.RESULT_STATUS.Max().Nvl(0).As("RESULT_STATUS"),
                    WARN_RESULT._.TENDER_PROJECT_CODE                  
                    );     

            //数据记录条数
            var total = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())
                .LeftJoinTmp<WARN_RESULT>(warnResultTmp, GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                .Count();

            var list = new List<XinWarnResultModel>();
            if (total > 0)
            {
                var query = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())

                    .LeftJoin<GGZYFW.DbEntity.SYS_AREA_QUANGUO>(
                        GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE)
                    .LeftJoin<GGZYFW.DbEntity.SYS_DIC>(GGZYFW.DbEntity.SYS_DIC._.TYPE == "2002" &&
                                                       GGZYFW.DbEntity.SYS_DIC._.VALUE == GGZYFW.DbEntity.TENDER_PROJECT
                                                           ._.TENDER_PROJECT_TYPE) //工程类别
                    .LeftJoinTmp<WARN_RESULT>(warnResultTmp,
                        GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                    .OrderBy(GGZYFW.DbEntity.TENDER_PROJECT._.CREATE_TIME.Desc);
                if (search.PageSize < int.MaxValue)
                {
                    query.Page(search.PageSize, search.PageNo);
                }
                //列表返回值
                list = query
                   .Select(
                       GGZYFW.DbEntity.TENDER_PROJECT._.M_ID,
                       GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                       GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                       GGZYFW.DbEntity.SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_TEXT"),
                       GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE,
                       GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREANAME,
                       GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                       //new Field("''").As("APPROVAL_DEPNAME"),//需要修改，只返回空字符，未错误的
                       GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE, //用于返回G01,G02....
                       new Field("PRIMARY", "WARN_RESULT"),
                       new Field("NORMAL", "WARN_RESULT"),
                       new Field("WARNING", "WARN_RESULT"),
                       new Field("STRANG", "WARN_RESULT"),
                       new Field("ALL", "WARN_RESULT"),
                       WARN_RESULT._.RESULT_STATUS
                       
                   )
                   .ToList<XinWarnResultModel>();
            }
            var jdTenderProjects = new List<GGZYJD.DbEntity.TENDER_PROJECT>();
            if (total > 0 && search.PageSize < int.MaxValue)
            {
                var fwTenderProjectCodes = list.Select(c => c.TENDER_PROJECT_CODE).ToArray();
                jdTenderProjects = Jd.TenderProjectService.GetJdTenderProjectsFwTpCodes(fwTenderProjectCodes);
            }
            //返回列表值
            var isJw = JdUser?.TYPE == (int)JdTUserType.JiWeiJianWei;//是否纪委监委
            var pageList = list.ToPageTableTResult(search, total, c =>
            {
                c.Buttons.Add("LOG");
                c.JD_TENDER_PROJECT_CODE = jdTenderProjects
                    .FirstOrDefault(o => o.TENDER_PROJECT_CODE_OLD1 == c.TENDER_PROJECT_CODE)?.TENDER_PROJECT_CODE;
                    
                if (isJw)
                {
                    c.Buttons.Add("SUPERVISE");
                }
                return c;
            });
            return pageList;
        }

        //     return search.ToPageTableResult();

        //     }

        /// <summary>
        /// 投诉信息-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> ProjectPointSearchExport(XinWarnResultModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = ProjectPointSearchList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/行政监督信息_项目监督_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }
        #endregion



        #endregion

        #endregion

        #region 联动对比监督

        #region 联动监督对比 疑似违规点返回接口

        ///// <summary>
        ///// 树形结构返回违规类别信息
        ///// </summary>
        ///// <param name="code">父级违规类别编码</param>
        ///// <returns></returns>
        //public List<RETURN_POINT> TreeList(string code = "")
        //{
        //    //查询所有的违规点对应的项目以及主体记录
        //    StringBuilder sbType = new StringBuilder();
        //    sbType.AppendLine("  SELECT DISTINCT POINT_CODE, 'ENTITY' AS RECORD_TYPE");
        //    sbType.AppendLine("    FROM BD_VIOLATION_ENTITY");
        //    sbType.AppendLine("  UNION ALL");
        //    sbType.AppendLine("  SELECT  DISTINCT POINT_CODE, 'PROJECT' AS RECORD_TYPE");
        //    sbType.AppendLine("    FROM BD_VIOLATION_RECORD");

        //    var types = Fw.BdViolationEntityService.FromSql(sbType.ToString()).ToList<POINT_TYPE>();

        //    var data = GetChild(types, code);

        //    data.Insert(0, new RETURN_POINT { label = "全部", value = code, record_type = new List<string>(), children = null });

        //    return data;
        //}


        //private List<RETURN_POINT> GetChild(List<POINT_TYPE> types, string code = "")
        //{

        //    var condition = new WhereClipBuilder();
        //    condition.And(BD_VIOLATION_POINT._.IS_DELETE == 0 &&
        //        BD_VIOLATION_POINT._.IS_ENABLE == 1);
        //    if (!String.IsNullOrWhiteSpace(code))
        //    {
        //        condition.And(BD_VIOLATION_POINT._.CATEGORY_CODE.BeginWith(code.ToUpper())
        //            && BD_VIOLATION_POINT._.CATEGORY_CODE != code.ToUpper());
        //    }
        //    else
        //    {
        //        condition.And(BD_VIOLATION_POINT._.PARENT_ID == 0);
        //    }


        //    //父级CODE不为空
        //    if (!String.IsNullOrWhiteSpace(code))
        //    {
        //        var cond = new WhereClipBuilder();
        //        cond.And(BD_VIOLATION_POINT_DETAIL._.CODE.BeginWith(code.ToUpper()) &&
        //            BD_VIOLATION_POINT_DETAIL._.CODE != code.ToUpper());
        //        var result = Fw.BdViolationPointDetailService.FindList<BD_VIOLATION_POINT_DETAIL>(cond.ToWhereClip())
        //            .OrderByDescending(od => od.IS_ENABLE)
        //            .OrderBy(od => od.SORT)
        //            .Select(t => new RETURN_POINT
        //            {
        //                label = t.NAME,
        //                value = t.CODE,
        //                record_type = t.IS_ENABLE == 0 ? new List<string>() : types.Where(w => w.POINT_CODE.StartsWith(t.CODE)).Select(t1 => t1.RECORD_TYPE).Distinct(),
        //                children = null
        //            }).ToList();

        //        return result;
        //    }


        //    var data = Fw.BdViolationPointService.FindList<BD_VIOLATION_POINT>(condition.ToWhereClip() && BD_VIOLATION_POINT._.CATEGORY_CODE != "WG07" //不显示围串标
        //                                                                                                & BD_VIOLATION_POINT._.CATEGORY_CODE != "WG08")//不显示主体线索
        //        .OrderBy(od => od.SORT)
        //        .Select(t => new RETURN_POINT
        //        {
        //            label = t.CATEGORY_NAME,
        //            value = t.CATEGORY_CODE,
        //            record_type = types.Where(w => w.POINT_CODE.StartsWith(t.CATEGORY_CODE)).Select(t1 => t1.RECORD_TYPE).Distinct(),
        //            children = GetChild(types, t.CATEGORY_CODE)
        //        }).ToList();

        //    return data;
        //}

        public class POINT_TYPE
        {
            /// <summary>
            /// 违规类别编码
            /// </summary>
            public string POINT_CODE { get; set; }
            /// <summary>
            /// 违规记录类型  ENTITY:主体 PROJECT:项目
            /// </summary>
            public string RECORD_TYPE { get; set; }
        }
        /// <summary>
        /// 返回给前端使用的违规项目类别树形列表信息
        /// </summary>
        public class RETURN_POINT
        {
            public string label { get; set; }
            public string value { get; set; }
            //规记录类型 ENTITY:主体 PROJECT:项目
            public IEnumerable<string> record_type { get; set; }

            public List<RETURN_POINT> children { get; set; }
        }

        #endregion

        #region 联动监督对比列表查询接口
        //public dynamic JDCompare(JDCompareModel model, SearchCondition search)
        //{
        //    var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
        //    var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
        //    if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
        //    {
        //        #region 项目查询
        //        if (model.PAGE_ID == "PROJECT")
        //        {
        //            var condition = new WhereClipBuilder(BD_VIOLATION_RECORD._.AREA_CODE.BeginWith(rootAreaCode)
        //                                                  && BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE.In(typeList));
        //            #region 查询条件
        //            //招标项目名称
        //            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
        //            {
        //                condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
        //            }
        //            //招标编号
        //            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
        //            {
        //                condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
        //            }
        //            //行业类型
        //            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
        //            {
        //                condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
        //            }
        //            //地区
        //            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
        //            {
        //                var AREA_CODE = model.AREA_CODE.TrimEnd('0');
        //                condition.And(BD_VIOLATION_RECORD._.AREA_CODE.BeginWith(AREA_CODE));
        //            }
        //            //时间
        //            if (search.BeginTime.HasValue)
        //            {
        //                condition.And(BD_VIOLATION_RECORD._.CHECK_TIME >= search.BeginTime);
        //            }
        //            if (search.EndTime.HasValue)
        //            {
        //                condition.And(BD_VIOLATION_RECORD._.CHECK_TIME <= search.BeginTime);
        //            }
        //            //疑似违规点编号
        //            if (string.IsNullOrWhiteSpace(model.PAGE_TITLE_ID))//如果此时标题行选择是全部
        //            {
        //                if (!string.IsNullOrWhiteSpace(model.CATEGORY_CODE))
        //                {
        //                    condition.And(BD_VIOLATION_POINT_DETAIL._.CODE.BeginWith(model.CATEGORY_CODE));
        //                }
        //            }
        //            else if (!string.IsNullOrWhiteSpace(model.PAGE_TITLE_ID))
        //            {
        //                if (!string.IsNullOrWhiteSpace(model.CATEGORY_CODE))
        //                {
        //                    condition.And(BD_VIOLATION_POINT_DETAIL._.CODE.BeginWith(model.CATEGORY_CODE));
        //                }
        //            }
        //            #endregion

        //            var total = Fw.BdViolationRecordService.FromWhere(condition.ToWhereClip())
        //                .LeftJoin<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.ID == BD_VIOLATION_RECORD._.POINT_ID)
        //                .Count();

        //            var list = Fw.BdViolationRecordService.FromWhere(condition.ToWhereClip())
        //                .LeftJoin<BD_VIOLATION_POINT>(BD_VIOLATION_POINT._.ID == BD_VIOLATION_RECORD._.POINT_ID)
        //                .LeftJoin<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.ID == BD_VIOLATION_RECORD._.POINT_ID)
        //                .LeftJoin<GGZYFW.DbEntity.SYS_DIC>(GGZYFW.DbEntity.SYS_DIC._.TYPE == "2002" && GGZYFW.DbEntity.SYS_DIC._.VALUE == BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE)
        //                .LeftJoin<GGZYFW.DbEntity.SYS_AREA_QUANGUO>(GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == BD_VIOLATION_RECORD._.AREA_CODE)             
        //                .OrderByDescending(BD_VIOLATION_RECORD._.CHECK_TIME)
        //                .Select(
        //                     BD_VIOLATION_RECORD._.ID,
        //                     BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE,
        //                     BD_VIOLATION_RECORD._.TENDER_PROJECT_NAME,
        //                     GGZYFW.DbEntity.SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_NAME"),
        //                     GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME"),
        //                     BD_VIOLATION_POINT_DETAIL._.NAME.As("POINT_NAME"),
        //                     BD_VIOLATION_RECORD._.STATE,
        //                     BD_VIOLATION_RECORD._.CHECK_TIME
        //                   )
        //                 .ToList<JDCompareModel>();

        //            if ((JdUser.TYPE == 5))
        //            {
        //                list.ForEach(c =>
        //                {
        //                    c.Buttons.AddRange(new List<string> { "SUPERVISE", "DETAIL", "PROJECT" });
        //                    c.TRANS_TYPE = '1'.ToString();
        //                });
        //            }
        //            if (JdUser.TYPE == 0 && JdUser.UserExtend == null)
        //            {
        //                list.ForEach(c =>
        //                {
        //                    if (c.STATE == 1)
        //                    {
        //                        c.Buttons.AddRange(new List<string> { "TRANS", "DETAIL", "PROJECT" });
        //                    }
        //                    else if (c.STATE == 0)
        //                    {
        //                        c.Buttons.AddRange(new List<string> { "TRANS", "DETAIL", "PROJECT", "RECORD" });
        //                    }
        //                    c.TRANS_TYPE = '1'.ToString();
        //                });
        //            }
        //            var pageList = list.ToPageTableTResult(search, total);
        //            return pageList;
        //        }
        //        #endregion

        //        #region 列表查询
        //        else if (model.PAGE_ID == "ENTITY")
        //        {
        //            var condition1 = new WhereClipBuilder();
        //           // condition1.And(BD_VIOLATION_ENTITY._.ENTITY_CODE.NotIn(new List<string> { "-", "无", "暂无", "/" }));
        //            //地区
        //            if (!String.IsNullOrEmpty(model.AREA_CODE))
        //            {
        //                var AREA_CODE = model.AREA_CODE.TrimEnd('0');
        //                condition1.And(BD_VIOLATION_ENTITY._.AREA_CODE.BeginWith(AREA_CODE));
        //            }
        //            //疑似违规点编码
        //            if (string.IsNullOrWhiteSpace(model.PAGE_TITLE_ID))//如果此时标题行选择是全部
        //            {
        //                if (!string.IsNullOrWhiteSpace(model.POINT_CODE))
        //                {
        //                    condition1.And(BD_VIOLATION_POINT_DETAIL._.CODE.BeginWith(model.POINT_CODE));
        //                }
        //            }
        //            else if (!string.IsNullOrWhiteSpace(model.PAGE_TITLE_ID))
        //            {
        //                if (!string.IsNullOrWhiteSpace(model.POINT_CODE))
        //                {
        //                    condition1.And(BD_VIOLATION_ENTITY._.POINT_CODE.BeginWith(model.POINT_CODE));
        //                }
        //            }
        //            //企业代码
        //            if (!String.IsNullOrEmpty(model.ENTITY_CODE))
        //            {
        //                condition1.And(BD_VIOLATION_ENTITY._.ENTITY_CODE.BeginWith(model.ENTITY_CODE));
        //            }
        //            //单位名称
        //            if (!String.IsNullOrEmpty(model.ENTITY_NAME))
        //            {
        //                condition1.And(BD_VIOLATION_ENTITY._.ENTITY_NAME.BeginWith(model.ENTITY_NAME));
        //            }
        //            //主体类型
        //            if (!String.IsNullOrEmpty(model.ENTITY_TYPE))
        //            {
        //                condition1.And(BD_VIOLATION_ENTITY._.ENTITY_TYPE == model.ENTITY_TYPE);
        //            }
        //            //状态
        //            if (!String.IsNullOrEmpty(model.STATE.ToString()))
        //            {
        //                condition1.And(BD_VIOLATION_ENTITY._.STATE == model.STATE);
        //            }
        //            //时间
        //            if (search.BeginTime.HasValue)
        //            {
        //                condition1.And(BD_VIOLATION_ENTITY._.CHECK_TIME >= search.BeginTime);
        //            }

        //            if (search.EndTime.HasValue)
        //            {
        //                condition1.And(BD_VIOLATION_ENTITY._.CHECK_TIME <= search.EndTime);
        //            }

        //            var total = Fw.BdViolationEntityService.FromWhere(condition1.ToWhereClip())
        //                        .Count();

        //            var list = Fw.BdViolationEntityService.FromWhere<BD_VIOLATION_ENTITY>(condition1.ToWhereClip())
        //                       .InnerJoin<BD_VIOLATION_POINT>(BD_VIOLATION_POINT._.ID == BD_VIOLATION_ENTITY._.POINT_ID)
        //                       .LeftJoin<GGZYFW.DbEntity.SYS_AREA_QUANGUO>(GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == BD_VIOLATION_ENTITY._.AREA_CODE)
        //                       .Page(search.PageSize, search.PageNo)
        //                       .OrderByDescending(BD_VIOLATION_ENTITY._.TRANSFER_STATE)
        //                       .Select(
        //                          BD_VIOLATION_POINT._.CATEGORY_NAME,
        //                          BD_VIOLATION_ENTITY._.CHECK_TIME,
        //                          BD_VIOLATION_ENTITY._.ID,
        //                          BD_VIOLATION_ENTITY._.POINT_NAME,
        //                          BD_VIOLATION_ENTITY._.STATE,
        //                          BD_VIOLATION_ENTITY._.ENTITY_CODE,
        //                          BD_VIOLATION_ENTITY._.ENTITY_NAME,
        //                          BD_VIOLATION_ENTITY._.ENTITY_TYPE,
        //                          GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("AREANAME")
        //                      )
        //                   .ToList<JDCompareModel>();

        //            if ((JdUser.TYPE == 5))
        //            {
        //                list.ForEach(c =>
        //                {
        //                    c.Buttons.AddRange(new List<string> { "SUPERVISE", "DETAIL" });
        //                    c.TRANS_TYPE = '2'.ToString();
        //                });
        //            }
        //            if (JdUser.TYPE == 0 && JdUser.UserExtend == null)
        //            {
        //                list.ForEach(c =>
        //                {
        //                    if (c.STATE == 1)
        //                    {
        //                        c.Buttons.AddRange(new List<string> { "TRANS","DETAIL" });
        //                    }
        //                    else if(c.STATE == 0)
        //                    {
        //                        c.Buttons.AddRange(new List<string> { "TRANS", "DETAIL", "RECORD" });
        //                    }
        //                    c.TRANS_TYPE = '2'.ToString();
        //                });
        //            }

        //            var pageList = list.ToPageTableTResult(search, total);
        //            return pageList;
        //        }
        //        else if (string.IsNullOrEmpty(model.PAGE_ID))
        //        {
        //            return search.ToPageTableResult();
        //        }
                 
        //        #endregion
        //    }
        //    return search.ToPageTableResult();
        //}

        #endregion


        #endregion
        #endregion

        #region 首页监督点统计
        /// <summary>
        ///  首页监督点统计-预警计数接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> PointAlarmCount(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//默认归属地
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');
                    if (model.REGION_CODE.Length < 6)
                    {
                        condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                        if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                        {
                            condition.And(WARN_RESULT._.REGION_CODE != "350128");//平潭综合试验区 350100 福州市
                        }
                    }
                    else
                    {
                        condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
                    }
                }
            }
            if (model.BeginTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
            }
            //RESULT_STATUS （0未监督 1绿 2黄 3红）
            var con = condition.ToWhereClip();
            var result = Fw.WarnResultService.FromWhere(con).ToList();
            var yellow = result.Where(p => p.RESULT_STATUS == "2").Count();
            var red = result.Where(p => p.RESULT_STATUS == "3").Count();
            var toal = yellow + red;
            var overtime = result.Where(p => p.OPERATE_STATUS == "1" && p.LAST_RECORD_TIME < DateTime.Now).Count();
            return new List<LabelValueModel<int>>
            {
                new LabelValueModel<int>{Label = "异常监督点总数",Value = toal},
                new LabelValueModel<int>{Label = "黄灯预警",Value = yellow},
                new LabelValueModel<int>{Label = "红灯预警",Value = red},
                new LabelValueModel<int>{Label = "处理超期数",Value = overtime},
            };
        }
        /// <summary>
        ///  首页监督点统计-根据类型统计接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Object> PointGroupByType(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//默认归属地
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');
                    if (model.REGION_CODE.Length < 6)
                    {
                        condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                        if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                        {
                            condition.And(WARN_RESULT._.REGION_CODE != "350128");//平潭综合试验区 350100 福州市
                        }
                    }
                    else
                    {
                        condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
                    }
                }
            }
            if (model.BeginTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
            }

            var result = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                 .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .GroupBy(WARN_EXPRESSION._.SP_TYPE)
                .Select(
                   WARN_EXPRESSION._.SP_TYPE.As("name"),
                   Field.All.Count().As("value")
                ).ToList<Object>();
            return result;
        }
        /// <summary>
        /// 首页监督点统计-归属地统计
        /// </summary>
        /// <param name="jdUserDepartId"></param>
        /// <returns></returns>
        public object PointGroupByRegion(TAfcProjectStatisticsModel model)
        {
            var areaname = new List<string>();
            var value = new List<string>();
            var value1 = new List<string>();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//350100
            var condition = new WhereClipBuilder();
            var condition1 = new WhereClipBuilder();
            condition.And(WARN_RESULT._.RESULT_STATUS >= 2);//查询红灯和黄灯
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');//默认查询当前这个账号的归属地
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))//有查询条件的时候
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');//补6位
                }
                if (model.BeginTime != null)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
                }
                if (model.EndTime != null)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
                }
                bool isCity = false; //判断当前查询的归属地是否省市
                var mod = Jd.SysAreaQuanguoService;
                var ppCode = mod.FromWhere(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == pcode).First().PCODE;
                if (ppCode == pcode)
                {
                    isCity = true;
                }
                else
                {
                    var temp = mod.FromWhere(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == ppCode).ToFirstDefault();
                    if (temp.PCODE == temp.AREACODE)
                    {
                        isCity = true;
                    }
                }

                if (isCity)//省市 归属地编码0结尾
                {
                    if (pcode == "350000" || pcode == "350100")
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.NotIn("350128", "350000"));//平潭综合试验区 350100 福建省
                    }
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == pcode);
                }
                else //归属地是区县
                {
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == pcode);
                }
                // var srr=Fw.WarnResultService.FromWhere(condition.ToWhereClip()).ToList();
                var mo = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip()).ToList();
                //关联查询 查询有数据的
                var s = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                    .InnerJoin<WARN_RESULT>(WARN_RESULT._.REGION_CODE == GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE && condition.ToWhereClip())
                    .Select(
                    GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("Label"),
                    WARN_RESULT._.RESULT_STATUS.As("Name")
                    ).ToList<LabelValueModel>();
                var r = s.GroupBy(p => new { p.Label }).Select(p => new LabelValueModel
                {
                    Label = p.Key.Label,
                    Id = p.Where(w => w.Name == "2").Count().ToString(),
                    Value = p.Where(w => w.Name == "3").Count().ToString()
                }).ToList();
                var Labels = r.Select(c => c.Label).ToList();
                var rs = mo.Where(p => !Labels.Contains(p.AREANAME)).Select(p => new LabelValueModel
                {
                    Label = p.AREANAME,
                    Value = "0",
                    Id = "0",
                });
                r.AddRange(rs);
                rs = rs.Select(p => new LabelValueModel
                {
                    Label = p.Label,
                    Value = "0",
                    Id = "0",
                }).ToList();
                r.AddRange(rs);
                areaname = r.Select(c => c.Label).ToList();
                value = r.Select(c => c.Id).ToList();
                value1 = r.Select(c => c.Value).ToList();
            }
            return new
            {
                areaname,
                value,
                value1
            };
        }
        #endregion
    }
}
