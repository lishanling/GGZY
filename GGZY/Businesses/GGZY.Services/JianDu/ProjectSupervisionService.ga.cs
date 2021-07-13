using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.WebSockets;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 处长门户 项目监督 公安
    /// </summary>
    public partial class ProjectSupervisionService
    {

        #region 公安 列表

        #region 项目监督 公安 处理项目及事项 列表
        /// <summary>
        /// 项目监督 公安 处理项目及事项 列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult GaProjectSupervisions(ProjectSupervisionRequestModel model)
        {
            var list = YsProjectSupervisions(model, out int count);
            var pageList= list.ToPageTableResult(model, count);
            return pageList;
        }

        #region 移送

        public List<ProjectSupervisionResponseJwModel> YsProjectSupervisions(ProjectSupervisionRequestModel model, out int count)
        {
            var list = new List<ProjectSupervisionResponseJwModel>();
            var queryable = YsProjectSupervisionQueryable(model);
            count = queryable.Count();
            if (count > 0)
            {
                list = queryable.OrderBy(new Field("TM").Desc).Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseJwModel>();
            }
            return list;
        }
        private FromSection<JC_TRANS_RECORD> YsProjectSupervisionQueryable(ProjectSupervisionRequestModel model)
        {
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var tsCon = new WhereClipBuilder(JC_TRANS_RECORD._.RECEIVER_UNIT_ID == jdUserDepartId && JC_TRANS_RECORD._.IS_DELETE
                                              != 1 && JC_TRANS_PROJECT._.IS_DELETE != 1);

            //var con = new WhereClipBuilder();
            #region 处理状态

            if (model.HANDLE_STATE == "DCL")//待处理项目及事项
            {
                tsCon.And(JC_TRANS_RECORD._.HAS_RESULT != 1);
            }
            else//已处理项目及事项
            {
                tsCon.And(JC_TRANS_RECORD._.HAS_RESULT == 1);
            }


            #endregion

            #region 创建时间

            if (model.BeginTime.HasValue)
            {

                tsCon.And(JC_TRANS_RECORD._.TRANS_TIME >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                tsCon.And(JC_TRANS_RECORD._.TRANS_TIME <= model.EndTime);
            }
            #endregion


            #region 关键字

            if (!string.IsNullOrWhiteSpace(model.KeyWord))
            {
                tsCon.And(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE.Contain(model.KeyWord) || JC_TRANS_PROJECT._.TENDER_AGENCY_NAME.Contain(model.KeyWord));
            }

            #endregion


            #endregion

            //var afcQuery = Jd.TAfcProjectService.FromWhere(con.ToWhereClip());
            var tsQueryable = Jd.JcTransRecordService.FromWhere(tsCon.ToWhereClip())
                .LeftJoin<JC_TRANS_PROJECT>(JC_TRANS_RECORD._.ID == JC_TRANS_PROJECT._.RECORD_ID)
                .Select(
                    JC_TRANS_RECORD._.ID.ToChar().As("ID"),
                    JC_TRANS_RECORD._.TRANS_TIME.As("TM"),
                    JC_TRANS_PROJECT._.TENDER_PROJECT_CODE.ToChar().As("CODE"),
                    JC_TRANS_PROJECT._.TENDER_PROJECT_NAME.ToChar().As("NAME"),
                    new Field("'JC_TRANS_RECORD'").As("TYPE"),
                    new Field("'移送信息'").As("TYPE_TEXT")
                );

            return tsQueryable;
        }

        private FromSection<JC_TRANS_RECORD> YsSupervisionQueryable(ProjectSupervisionRequestModel model)
        {
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var tsCon = new WhereClipBuilder(JC_TRANS_RECORD._.RECEIVER_UNIT_ID == jdUserDepartId && JC_TRANS_RECORD._.IS_DELETE
                                              != 1 && JC_TRANS_RECORD._.IS_DELETE != 1);

            //var con = new WhereClipBuilder();
            #region 处理状态

            if (model.HANDLE_STATE == "DCL")//待处理项目及事项
            {
                tsCon.And(JC_TRANS_RECORD._.HAS_RESULT != 1);
            }
            else//已处理项目及事项
            {
                tsCon.And(JC_TRANS_RECORD._.HAS_RESULT == 1);
            }


            #endregion

            #region 创建时间

            if (model.BeginTime.HasValue)
            {

                tsCon.And(JC_TRANS_RECORD._.TRANS_TIME >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                tsCon.And(JC_TRANS_RECORD._.TRANS_TIME <= model.EndTime);
            }
            #endregion


            #region 关键字

            if (!string.IsNullOrWhiteSpace(model.KeyWord))
            {
                tsCon.And(JC_TRANS_RECORD._.TITLE.Contain(model.KeyWord) || JC_TRANS_RECORD._.TRANS_CODE.Contain(model.KeyWord));
            }

            #endregion


            #endregion

            //var afcQuery = Jd.TAfcProjectService.FromWhere(con.ToWhereClip());
            var tsQueryable = Jd.JcTransRecordService.FromWhere(tsCon.ToWhereClip())
                .Select(
                    JC_TRANS_RECORD._.ID.ToChar().As("ID"),
                    JC_TRANS_RECORD._.TRANS_TIME.As("TM"),
                    JC_TRANS_RECORD._.TRANS_CODE.ToChar().As("CODE"),
                    JC_TRANS_RECORD._.TITLE.ToChar().As("NAME"),
                    new Field("'JC_TRANS_RECORD'").As("TYPE"),
                    new Field("'移送信息'").As("TYPE_TEXT")
                );

            return tsQueryable;
        }
        #endregion


        #endregion

        #region 项目监督 公安 项目处理信息汇总
        /// <summary>
        /// 项目监督 公安 项目处理信息汇总
        /// </summary>
        /// <returns></returns>
        public List<ProjectSupervisionCountResponseModel> GaProjectSupervisionCount()
        {
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            var cacheCounts = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:GaProjectSupervisionCount:{jdUserDepartId}", 10, () =>
            {
                var counts = new List<ProjectSupervisionCountResponseModel>();

                var receive = new ProjectSupervisionCountResponseModel {Label = "收到移送信息", DoneCount = 0};
                receive.DoneCount = Jd.JcTransRecordService.Count(
                    JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT == 1 &&
                    JC_TRANS_RECORD._.RECEIVER_UNIT_ID == jdUserDepartId);
                receive.UndoCount= Jd.JcTransRecordService.Count(
                    JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT != 1 &&
                    JC_TRANS_RECORD._.RECEIVER_UNIT_ID == jdUserDepartId);
                counts.Add(receive);
                var send = new ProjectSupervisionCountResponseModel {Label = "向行业监督部门移送信息", DoneCount = 0};
                send.DoneCount = Jd.JcTransRecordService.Count(
                    JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT == 1 &&
                    JC_TRANS_RECORD._.TRANS_UNITID == jdUserDepartId);
                send.UndoCount = Jd.JcTransRecordService.Count(
                    JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT != 1 &&
                    JC_TRANS_RECORD._.TRANS_UNITID == jdUserDepartId);
                counts.Add(send);

                return counts;
            });
            return cacheCounts;
        }
        #endregion

        #region 项目监督 公安 标后监管系统


        public PageTableResult GaAfterSupervisions(SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            //

            return plist;
        }

        #endregion
        #endregion

        #region 公安 详情

        #region 行业监督部门移送的信息
        /// <summary>
        /// 行业监督部门移送的信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult DepTransRecord( SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            var departid = JdUser?.DEPARTID;
            if (departid != null)
            {
                var query = Jd.JcTransRecordService.FromWhere(JC_TRANS_RECORD._.RECEIVER_UNIT_ID==departid&&JC_TRANS_RECORD._.IS_DELETE!=1)
                    .InnerJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID==JC_TRANS_RECORD._.TRANS_UNITID&& T_USER_DEPARTMENT._.DTYPE.NotIn(3,4));
                var count = query.Count();
                if (count > 0)
                {
                    var list = query.OrderByDescending(JC_TRANS_RECORD._.TRANS_TIME)
                        .Page(search.PageSize, search.PageNo)
                        .Select(JC_TRANS_RECORD._.TITLE, JC_TRANS_RECORD._.TRANS_USER, new Field($"'{JdUser?.UserDepartment?.DNAME}'").As("RECEIVER_UNIT"),JC_TRANS_RECORD._.TRANS_TIME)
                        .ToList<object>();
                    plist = list.ToPageTableResult(search, count);
                }
            }
            
            return plist;
        }

        #endregion

        #region 0591-87094240公安平台举报信息

        /// <summary>
        /// 0591-87094240公安平台举报信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PolicePlatformReport(SearchCondition search)
        {
            var plist = search.ToPageTableResult();//TODO zlw 0591-87094240公安平台举报信息
            //举报标题 举报人 时间
            //返回字段用标题大写首字母
            return plist;
        }

        #endregion

        #region 公安其他渠道掌握的信息

        /// <summary>
        /// 公安其他渠道掌握的信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PoliceOtherChannelInfo(SearchCondition search)
        {
            var plist = search.ToPageTableResult();//TODO zlw 公安其他渠道掌握的信息
            //信息标题 提供人 时间
            //返回字段用标题大写首字母
            return plist;
        }

        #endregion

        #region 项目监督 纪委监委 处理项目及事项 详情 处理事项
        /// <summary>
        /// 项目监督 纪委监委 处理项目及事项 详情 处理事项
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult GaHandleItems( SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            var departId = JdUser?.DEPARTID;
            if (departId != null)
            {
               
                var count = Jd.JcTransRecordService.FromWhere((JC_TRANS_RECORD._.RECEIVER_UNIT_ID == departId|| JC_TRANS_RECORD._.TRANS_UNITID == departId) &&JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RESULT._.IS_DELETE != 1).LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RECORD._.ID == JC_TRANS_RESULT._.RECORD_ID).Count();
                if (count > 0)
                {
                    var receive = Jd.JcTransRecordService
                        .FromWhere(JC_TRANS_RECORD._.RECEIVER_UNIT_ID == departId && JC_TRANS_RECORD._.IS_DELETE != 1&& JC_TRANS_RESULT._.IS_DELETE!=1)
                        .LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RECORD._.ID == JC_TRANS_RESULT._.RECORD_ID)
                        .Select(
                            JC_TRANS_RECORD._.TITLE,
                            JC_TRANS_RECORD._.HAS_RESULT,
                            JC_TRANS_RECORD._.TRANS_USER,
                            JC_TRANS_RECORD._.TRANS_UNIT.As("UNIT_NAME"),
                            JC_TRANS_RESULT._.RESULT_MSG,
                            JC_TRANS_RECORD._.TRANS_TIME,
                            new Field("'RECEIVE'").As("TYPE")
                            );
                    var send = Jd.JcTransRecordService
                        .FromWhere(JC_TRANS_RECORD._.TRANS_UNITID == departId && JC_TRANS_RECORD._.IS_DELETE != 1)
                        .LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RECORD._.ID == JC_TRANS_RESULT._.RECORD_ID)
                        .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == JC_TRANS_RECORD._.RECEIVER_UNIT_ID)
                        .Select(
                            JC_TRANS_RECORD._.TITLE,
                            JC_TRANS_RECORD._.HAS_RESULT,
                            JC_TRANS_RECORD._.TRANS_USER,
                            T_USER_DEPARTMENT._.DNAME.As("UNIT_NAME"),
                            JC_TRANS_RESULT._.RESULT_MSG,
                            JC_TRANS_RECORD._.TRANS_TIME,
                            new Field("'SEND'").As("TYPE")
                        );

                    var list = receive.UnionAll(send).OrderByDescending(JC_TRANS_RECORD._.TRANS_TIME)
                        .Page(search.PageSize, search.PageNo).ToList<ProjectSupervisionHandleItemResponseModelGA>();
                    plist = list.ToPageTableResult(search, count);
                }
            }
            return plist;
        }
        #endregion

        #region 项目监督 公安 处理项目及事项 项目信息
        /// <summary>
        /// 项目监督 公安 处理项目及事项 项目信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult GaProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            ProjectSupervisionBaseInfoResponseModel data = null;
            var dbModel = Jd.JcTransProjectService.FirstOrNull(JC_TRANS_PROJECT._.RECORD_ID == model.ID);
            if (dbModel == null)
            {
                r.SetFail("未找到对应的项目移送信息");
            }
            else
            {

                if (!string.IsNullOrWhiteSpace(dbModel?.TENDER_PROJECT_CODE))
                {
                    data = Fw.TenderProjectService.HyProjectDetailModel(dbModel.TENDER_PROJECT_CODE);
                }
                if (data == null)
                {
                    var tenderProject = Jd.TenderProjectService.FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE == dbModel?.TENDER_PROJECT_CODE)
                        .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == TENDER_PROJECT._.PLATFORM_CODE)
                        .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                        .Select(T_USER_TRADEPLATFORM._.SYSTEM_NAME,
                            SYS_AREA_QUANGUO._.AREANAME,
                            TENDER_PROJECT._.All)
                        .ToFirst<JdTenderProjectModel>();
                    data = new ProjectSupervisionBaseInfoResponseModel
                    {
                        M_ID = 0,// dbModel.RECORD_ID,
                        PROJECT_CODE = dbModel.TENDER_PROJECT_CODE,
                        PROJECT_NAME = tenderProject?.TENDER_PROJECT_NAME,
                        AGENCY_NAME = tenderProject?.TENDER_AGENCY_NAME ?? string.Empty,
                        AREANAME = tenderProject?.AREANAME,
                        CREATE_TIME = tenderProject?.CREATE_TIME,
                        OWNER_NAME = tenderProject?.OWNER_NAME,
                        REGION_CODE = tenderProject?.REGION_CODE,
                        P_REGION_CODE = "",
                        P_AREANAME = $"",
                        PLATFORM_CODE = tenderProject?.PLATFORM_CODE ?? String.Empty,
                        SYSTEM_NAME = tenderProject?.SYSTEM_NAME ?? String.Empty
                    };
                    r.SetSuccess(data);
                }
            }
            return r;
        }
        #endregion

        #endregion
    }
}