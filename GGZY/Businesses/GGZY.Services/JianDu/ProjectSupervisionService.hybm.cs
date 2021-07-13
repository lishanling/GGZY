using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;


namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 处长门户 项目监督
    /// </summary>
    public partial class ProjectSupervisionService
    {
        #region 处长门户

        #region 项目监督 行业部门 处理项目及事项

        #region 项目监督 行业部门 处理项目及事项 列表
        /// <summary>
        /// 行业部门 项目监督 列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult HyProjectSupervisions(ProjectSupervisionRequestModel model)
        {

            var list = new List<ProjectSupervisionResponseHyModel>();
            int count = 0;
            switch (model.Type)
            {
                case nameof(T_AFC_PROJECT):
                    list = AfcProjectSupervisions(model, out count);
                    break;
                case nameof(RECORD_REVIEW):
                    list = RecordProjectSupervisions(model, out count);
                    break;
                case nameof(PT_ZXTS):
                    list = TsProjectSupervisions(model, out count);
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    list = JddProjectSupervisions(model, out count);
                    break;
                default:
                    var afcQueryable = AfcProjectSupervisionQueryable(model);
                    var recordQueryable = RecordProjectSupervisionQueryable(model);
                    var tsQueryable = TsProjectSupervisionQueryable(model);
                    var jddQueryable = JddProjectSupervisionQueryable(model);
                    var query = afcQueryable
                            .UnionAll(tsQueryable)
                        .UnionAll(recordQueryable) //闽政通 小程序 先把备案拿掉 //todo mzt
                        .UnionAll(jddQueryable)  //闽政通 小程序 先把监督点拿掉 //todo mzt
                        ;
                    count = query.Count();
                    if (count > 0)
                    {
                        list = query.OrderBy(new Field("TM").Desc)
                            .Page(model.PageSize, model.PageNo)
                            .ToList<ProjectSupervisionResponseHyModel>();
                    }

                    break;
            }

            #region 从服务平台获取开标时间 公告发布时间

            if (list.Any())
            {
                var codes = list.Select(c => c.CODE).Distinct().ToList();
                var anns = Fw.TenderAnnQuaInqueryAnnService.FromWhere()
                    .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(
                        GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.In(codes) &&
                        GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                        GGZYFW.DbEntity.TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
                    .Select(
                        GGZYFW.DbEntity.TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
                        GGZYFW.DbEntity.TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
                        GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.As("TENDER_PROJECT_CODE")
                    ).ToList();
                if (anns.Any())
                {
                    foreach (var item in list)
                    {
                        var curAnns = anns.FindAll(c => c.TENDER_PROJECT_CODE == item.CODE).OrderByDescending(c => c.NOTICE_SEND_TIME).ToList();

                        item.BID_OPEN_TIME = curAnns.FirstOrDefault()?.BID_OPEN_TIME;
                        item.NOTICE_SEND_TIME = curAnns.FirstOrDefault()?.NOTICE_SEND_TIME;
                    }
                }

                var review = list.FindAll(c => c.TYPE == nameof(RECORD_REVIEW)).ToList();
                if (review.Any())
                {
                    var reviewIds = review.Select(c => c.ID).ToList();
                    var recordReviews = Jd.RecordReviewService.FindList(RECORD_REVIEW._.ID.In(reviewIds));
                    review.ForEach(c =>
                    {
                        var record = recordReviews.FirstOrDefault(r => r.ID?.ToString() == c.ID);
                        c.REVIEW_STATUS = record?.REVIEW_STATUS;
                        c.REVIEW_TYPE = record?.REVIEW_TYPE;
                    });
                }

            }

            #endregion
            var pageList = list.ToPageTableResult(model, count);
            return pageList;
        }
       
        #region 招标计划登记

        public List<ProjectSupervisionResponseHyModel> AfcProjectSupervisions(ProjectSupervisionRequestModel model, out int count)
        {
            var list = new List<ProjectSupervisionResponseHyModel>();
            var queryable = AfcProjectSupervisionQueryable(model);
            count = queryable.Count();
            if (count > 0)
            {
                list = queryable.OrderBy(new Field("TM").Desc).Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseHyModel>();
            }

            return list;
        }
        private FromSection<T_AFC_PROJECT> AfcProjectSupervisionQueryable(ProjectSupervisionRequestModel model)
        {
            var hasCensor = JdUser != null && (JdUser.HasPermission("JdTAfcProject", "Approval") ||
                                               JdUser.HasPermission("JdTAfcProject", "ChangeApproval"));
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var afcCon = new WhereClipBuilder(T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId);

            #region 处理状态

            if (model.HANDLE_STATE == "DCL")//待处理项目及事项
            {
                if (hasCensor)
                {
                    afcCon.And(T_AFC_PROJECT._.APPROVAL_STATE == "2");
                }
                else
                {
                    afcCon.And(T_AFC_PROJECT._.APPROVAL_STATE == "-1");
                }
            }
            else if (model.HANDLE_STATE == "CQWCL")//
            {
                if (hasCensor)
                {
                    afcCon.And(T_AFC_PROJECT._.APPROVAL_STATE == "2" && T_AFC_PROJECT._.OVER_TM < DateTime.Now);
                }
                else
                {
                    afcCon.And(T_AFC_PROJECT._.APPROVAL_STATE == "-1");
                }
            }
            else if(model.HANDLE_STATE == "YCL")//已处理项目及事项
            {
                afcCon.And(T_AFC_PROJECT._.APPROVAL_STATE.In(3, 4, 6));
            }


            #endregion

            #region 工程类型

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                afcCon.And(T_AFC_PROJECT._.PROJECT_TYPE == model.PROJECT_TYPE);
            }

            #endregion

            #region 创建时间

            if (model.BeginTime.HasValue)
            {
                afcCon.And(T_AFC_PROJECT._.TM >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                afcCon.And(T_AFC_PROJECT._.TM <= model.EndTime);
            }
            #endregion

            #region 工程类型

            if (!string.IsNullOrWhiteSpace(model.FBFS))
            {
                var field = EntityUtils.GetField<T_AFC_PROJECT>(model.FBFS);
                afcCon.And(field.IsNotNull());
            }

            #endregion

            if (!string.IsNullOrWhiteSpace(model.KeyWord))
            {
                afcCon.And(T_AFC_PROJECT._.CODE.Contain(model.KeyWord) || T_AFC_PROJECT._.PROJECT_NAME.Contain(model.KeyWord));
            }
            #endregion


            var afcQueryable = Jd.TAfcProjectService.FromWhere(afcCon.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE=="63"&&SYS_DIC._.VALUE==T_AFC_PROJECT._.PROJECT_TYPE)
                .Select(
                T_AFC_PROJECT._.ID.ToChar().As("ID"),
                T_AFC_PROJECT._.TM,
                T_AFC_PROJECT._.CODE.ToChar().As("CODE"),
                T_AFC_PROJECT._.PROJECT_NAME.ToChar().As("NAME"),
                new Field("'T_AFC_PROJECT'").As("TYPE"),
                new Field("'招标计划登记'").As("TYPE_TEXT"),
                SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_TEXT")
            );
            return afcQueryable;
        }


        #endregion

        #region 投诉处理

        public List<ProjectSupervisionResponseHyModel> TsProjectSupervisions(ProjectSupervisionRequestModel model, out int count)
        {
            var list = new List<ProjectSupervisionResponseHyModel>();
            var queryable = TsProjectSupervisionQueryable(model);
            count = queryable.Count();
            if (count > 0)
            {
                list = queryable.OrderBy(new Field("TM").Desc).Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseHyModel>();
            }
            return list;
        }
        private FromSection<PT_ZXTS> TsProjectSupervisionQueryable(ProjectSupervisionRequestModel model)
        {
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var tsCon = new WhereClipBuilder(PT_ZXTS._.TYPE != 2 && PT_ZXTS._.ACCEPT_DEPID == jdUserDepartId);

            //var con = new WhereClipBuilder();
            #region 处理状态

            if (model.HANDLE_STATE == "DCL")//待处理项目及事项
            {
                tsCon.And(PT_ZXTS._.STATE.In(1, 2, 4, 6, 7));
            }
            else if (model.HANDLE_STATE == "CQWCL")//超期未处理
            {
                tsCon.And(PT_ZXTS._.STATE.In(1, 2, 4, 6, 7) && PT_ZXTS._.OVER_TM < DateTime.Now);
            }
            else if (model.HANDLE_STATE == "YCL")//已处理项目及事项
            {
                tsCon.And(PT_ZXTS._.STATE.In(3, 5, 8));
            }


            #endregion

            #region 创建时间

            if (model.BeginTime.HasValue)
            {

                tsCon.And(PT_ZXTS._.CREATE_TM >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                tsCon.And(PT_ZXTS._.CREATE_TM <= model.EndTime);
            }
            #endregion

            #region 工程类型

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                tsCon.And(T_AFC_PROJECT._.PROJECT_TYPE == model.PROJECT_TYPE);
            }

            #endregion

            #region 项目类型

            if (!string.IsNullOrWhiteSpace(model.FBFS))
            {
                var field = EntityUtils.GetField<T_AFC_PROJECT>(model.FBFS);
                tsCon.And(field.IsNotNull());
            }

            #endregion

            #region 关键字

            if (!string.IsNullOrWhiteSpace(model.KeyWord))
            {
                tsCon.And(PT_ZXTS._.TENDER_PROJECT_CODE.Contain(model.KeyWord) || PT_ZXTS._.TENDER_PROJECT_NAME.Contain(model.KeyWord));
            }

            #endregion

            #endregion

            //var afcQuery = Jd.TAfcProjectService.FromWhere(con.ToWhereClip());
            var tsQueryable = Jd.PtZxtsService.FromWhere(tsCon.ToWhereClip())
                .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                .LeftJoin<PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                .LeftJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                //.LeftJoinTmp<T_AFC_PROJECT>(afcQuery, T_AFC_PROJECT._.CODE == TENDER_PROJECT._.CONSTRUCTION_ID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE=="2002"&& SYS_DIC._.VALUE==TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(
                    PT_ZXTS._.ID.ToChar().As("ID"),
                    PT_ZXTS._.CREATE_TM.As("TM"),
                    PT_ZXTS._.CODE.ToChar().As("CODE"),
                    PT_ZXTS._.COMPLAINT_TITLE.ToChar().As("NAME"),
                    new Field("'PT_ZXTS'").As("TYPE"),
                    new Field("'投诉处理'").As("TYPE_TEXT"),
                    SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_TEXT")
                );

            return tsQueryable;
        }


        #endregion

        #region 备案
        public List<ProjectSupervisionResponseHyModel> RecordProjectSupervisions(ProjectSupervisionRequestModel model, out int count)
        {
            var list = new List<ProjectSupervisionResponseHyModel>();
            var queryable = RecordProjectSupervisionQueryable(model);
            count = queryable.Count();
            if (count > 0)
            {
                list = queryable.OrderBy(new Field("TM").Desc).Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseHyModel>();
            }
            return list;
        }

        private FromSection<RECORD_REVIEW> RecordProjectSupervisionQueryable(ProjectSupervisionRequestModel model)
        {

            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var recordCon = new WhereClipBuilder(GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID == jdUserDepartId);


            //var con = new WhereClipBuilder();
            #region 处理状态

            if (model.HANDLE_STATE == "DCL")//待处理项目及事项
            {
                recordCon.And(RECORD_REVIEW._.REVIEW_STATUS == 1);
            }
            else if (model.HANDLE_STATE == "CQWCL")
            {
                recordCon.And(RECORD_REVIEW._.REVIEW_STATUS == 1 && RECORD_REVIEW._.OVER_TM < DateTime.Now);
            }
            else if (model.HANDLE_STATE == "YCL")//已处理项目及事项
            {
                recordCon.And(RECORD_REVIEW._.REVIEW_STATUS > 1);
            }
            #endregion

            #region 工程类型

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                recordCon.And(T_AFC_PROJECT._.PROJECT_TYPE == model.PROJECT_TYPE);
            }

            #endregion


            #region 创建时间

            if (model.BeginTime.HasValue)
            {
                recordCon.And(RECORD_REVIEW._.CREATE_TM >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                recordCon.And(RECORD_REVIEW._.CREATE_TM <= model.EndTime);
            }
            #endregion

            #region 项目类型

            if (!string.IsNullOrWhiteSpace(model.FBFS))
            {
                var field = EntityUtils.GetField<T_AFC_PROJECT>(model.FBFS);
                recordCon.And(field.IsNotNull());
            }

            #endregion

            #region 关键字

            if (!string.IsNullOrWhiteSpace(model.KeyWord))
            {
                recordCon.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.KeyWord)|| TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.KeyWord));
            }

            #endregion
            #endregion

            //var afcQuery = Jd.TAfcProjectService.FromWhere(con.ToWhereClip());
            var recordQueryable = Jd.RecordReviewService.FromWhere(recordCon.ToWhereClip())
                .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE)
                .LeftJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                //.InnerJoinTmp<T_AFC_PROJECT>(afcQuery, T_AFC_PROJECT._.CODE == TENDER_PROJECT._.CONSTRUCTION_ID)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(
                    RECORD_REVIEW._.ID.ToChar().As("ID"),
                    RECORD_REVIEW._.CREATE_TM.As("TM"),
                    RECORD_REVIEW._.TENDER_PROJECT_CODE.ToChar().As("CODE"),
                    GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.ToChar().As("NAME"),
                    new Field("'RECORD_REVIEW'").As("TYPE"),
                    SYS_DIC._.TEXT.ToChar(alias: "TYPE_TEXT"),
                    new Field("TEXT","SYS_DIC2").As("TENDER_PROJECT_TYPE_TEXT")
                );
            return recordQueryable;
        }
        #endregion

        #region 监督点

        public List<ProjectSupervisionResponseHyModel> JddProjectSupervisions(ProjectSupervisionRequestModel model, out int count)
        {
            var list = new List<ProjectSupervisionResponseHyModel>();
            var queryable = JddProjectSupervisionQueryable(model);
            count = queryable.Count();
            if (count > 0)
            {
                list = queryable.OrderBy(new Field("TM").Desc).Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseHyModel>();
            }
            return list;
        }

        private FromSection<GGZYFW.DbEntity.WARN_RESULT> JddProjectSupervisionQueryable(ProjectSupervisionRequestModel model)
        {

            //var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var jddCon = new WhereClipBuilder();


            //var con = new WhereClipBuilder();
            #region 处理状态

            if (model.HANDLE_STATE == "DCL")//待处理项目及事项
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.OPERATE_STATUS == 1);//红灯
            }
            else if (model.HANDLE_STATE == "CQWCL")//超期未处理
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.OPERATE_STATUS == 4);//红灯
            }
            else if (model.HANDLE_STATE == "YCL")//已处理项目及事项
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.OPERATE_STATUS.In(2, 3));
            }
            #endregion

            #region 工程类型

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_TYPE.Contain(model.PROJECT_TYPE));
            }

            #endregion


            #region 创建时间

            if (model.BeginTime.HasValue)
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.SP_TIME >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.SP_TIME <= model.EndTime);
            }
            #endregion

            #region 项目类型

            if (!string.IsNullOrWhiteSpace(model.FBFS))
            {
                //var field = EntityUtils.GetField<T_AFC_PROJECT>(model.FBFS);
                //jddCon.And(field.IsNotNull());
            }


            #region 关键字

            if (!string.IsNullOrWhiteSpace(model.KeyWord))
            {
                jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE.Contain(model.KeyWord) || GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.KeyWord));
            }

            #endregion
            #endregion

            #endregion

            #region 归属地过滤
            var rootAreaCode = JdUser?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                var areaCondition = new WhereClipBuilder();
                if (rootAreaCode == "3501")//福州市排除平潭
                {
                    areaCondition.And(GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE.BeginWith(rootAreaCode) && GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE != "350128");
                }
                else
                {
                    areaCondition.And(GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE.BeginWith(rootAreaCode));
                }

                if (rootAreaCode.Length > 2)
                {
                    var pCode = string.Empty;
                    if (rootAreaCode == "350128") //平潭直接查看省级数据
                    {
                        pCode += "350000";
                    }
                    else
                    {
                        pCode = rootAreaCode.Substring(0, rootAreaCode.Length - 2).PadRight(6, '0');
                    }
                    areaCondition.Or(GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE == pCode);
                }
            }

            #endregion

            #region 行业过滤

            if (JdUser?.ISALLKIND != 1)
            {
                if (string.IsNullOrWhiteSpace(JdUser?.HY_TYPE))
                {
                    jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_TYPE == "-1");
                }
                else
                {
                    var hyTypes = JdUser.HY_TYPE.Split(',').ToList();
                    jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyTypes));
                }
            }

            #endregion

            var jddQueryable = Fw.WarnResultService.FromWhere(jddCon.ToWhereClip())

                .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<GGZYFW.DbEntity.WARN_EXPRESSION>(GGZYFW.DbEntity.WARN_EXPRESSION._.M_ID == GGZYFW.DbEntity.WARN_RESULT._.SP_ID)
                .LeftJoin<GGZYFW.DbEntity.SYS_DIC> (GGZYFW.DbEntity.SYS_DIC._.TYPE==""&& GGZYFW.DbEntity.SYS_DIC._.VALUE== GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(
                    GGZYFW.DbEntity.WARN_RESULT._.M_ID.ToChar().As("ID"),
                    GGZYFW.DbEntity.WARN_RESULT._.SP_TIME.As("TM"),
                    GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE.ToChar().As("CODE"),
                    TENDER_PROJECT._.TENDER_PROJECT_NAME.ToChar().As("NAME"),
                    new Field("'WARN_RESULT'").As("TYPE"),
                    GGZYFW.DbEntity.WARN_EXPRESSION._.SP_NAME.ToChar(alias: "TYPE_TEXT"),
                    GGZYFW.DbEntity.SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_TEXT")
                );

            return jddQueryable;
        }

        #endregion

        #endregion

        #endregion

        #region 项目监督 行业部门 项目处理信息汇总
        /// <summary>
        /// 项目处理信息汇总
        /// </summary>
        /// <returns></returns>
        public List<ProjectSupervisionCountResponseModel> HyProjectSupervisionCount()
        {
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            var jdUserId = JdUser?.ID?.ToString();

            var cacheCounts = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:HyProjectSupervisionCount:{jdUserDepartId}:{jdUserId}", 10, () =>
            {
                var counts = new List<ProjectSupervisionCountResponseModel>();

                #region 招标计划登记

                var afc = new ProjectSupervisionCountResponseModel() { Label = "招标计划登记" };
                var hasCensor = JdUser != null && (JdUser.HasPermission("JdTAfcProject", "Approval") ||
                                                   JdUser.HasPermission("JdTAfcProject", "ChangeApproval"));
                if (hasCensor)
                {
                    afc.UndoCount =
                        Jd.TAfcProjectService.Count(T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId &&
                                                    T_AFC_PROJECT._.APPROVAL_STATE == 2);
                }
                else
                {
                    afc.UndoCount = 0;
                }

                afc.DoneCount = Jd.TAfcProjectService.Count(T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId &&
                                                            T_AFC_PROJECT._.APPROVAL_STATE.In(3, 4, 6));
                counts.Add(afc);

                #endregion

                #region 招标备案

                var record = new ProjectSupervisionCountResponseModel() { Label = "招标备案" };
                record.DoneCount = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.REVIEW_STATUS > 1)
                    .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(
                        GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE &&
                        GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID == jdUserDepartId).Count();
                record.UndoCount = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.REVIEW_STATUS == 1)
                    .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(
                        GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE &&
                        GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID == jdUserDepartId).Count();
                counts.Add(record);

                #endregion

                #region 投诉处理

                var ts = new ProjectSupervisionCountResponseModel { Label = "投诉处理" };
                ts.DoneCount =
                    Jd.PtZxtsService.Count(PT_ZXTS._.TYPE != 2 && PT_ZXTS._.ACCEPT_DEPID == jdUserDepartId &&
                                           PT_ZXTS._.STATE.In(3, 5, 8));
                ts.UndoCount =
                    Jd.PtZxtsService.Count(PT_ZXTS._.TYPE != 2 && PT_ZXTS._.ACCEPT_DEPID == jdUserDepartId &&
                                           PT_ZXTS._.STATE.In(1, 2, 4, 6, 7));
                counts.Add(ts);

                #endregion

                #region 监督点处理

                var jddCon = new WhereClipBuilder();
                #region 归属地过滤
                var rootAreaCode = JdUser?.RootAreaCode;
                if (!string.IsNullOrWhiteSpace(rootAreaCode))
                {
                    var areaCondition = new WhereClipBuilder();
                    if (rootAreaCode == "3501")//福州市排除平潭
                    {
                        areaCondition.And(GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE.BeginWith(rootAreaCode) && GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE != "350128");
                    }
                    else
                    {
                        areaCondition.And(GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE.BeginWith(rootAreaCode));
                    }

                    if (rootAreaCode.Length > 2)
                    {
                        var pCode = string.Empty;
                        if (rootAreaCode == "350128") //平潭直接查看省级数据
                        {
                            pCode += "350000";
                        }
                        else
                        {
                            pCode = rootAreaCode.Substring(0, rootAreaCode.Length - 2).PadRight(6, '0');
                        }
                        areaCondition.Or(GGZYFW.DbEntity.WARN_RESULT._.REGION_CODE == pCode);
                    }
                }

                #endregion

                #region 行业过滤

                if (JdUser?.ISALLKIND != 1)
                {
                    if (string.IsNullOrWhiteSpace(JdUser?.HY_TYPE))
                    {
                        jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_TYPE == "-1");
                    }
                    else
                    {
                        var hyTypes = JdUser.HY_TYPE.Split(',').ToList();
                        jddCon.And(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyTypes));
                    }
                }

                #endregion

                var jdd = new ProjectSupervisionCountResponseModel { Label = "监督点处理" };
                jdd.UndoCount =
                    Fw.WarnResultService.Count(jddCon.ToWhereClip() &&
                                               GGZYFW.DbEntity.WARN_RESULT._.OPERATE_STATUS.In(1, 4));
                jdd.DoneCount = Fw.WarnResultService.Count(jddCon.ToWhereClip() && GGZYFW.DbEntity.WARN_RESULT._.OPERATE_STATUS.In(2, 3));
                counts.Add(jdd);
                #endregion
                counts.Add(new ProjectSupervisionCountResponseModel { Label = " 收到的处罚记录" });//TODO zlw
                counts.Add(new ProjectSupervisionCountResponseModel { Label = " 提交“双随机一公开”重点抽查" });//TODO zlw

                #region 移送公安线索

                var toPolice = new ProjectSupervisionCountResponseModel { Label = "移送公安线索" };
                toPolice.DoneCount = Jd.JcTransRecordService.Count(JC_TRANS_RECORD._.TRANS_USER_ID == jdUserId &&
                                                                   JC_TRANS_RECORD._.TRANS_TYPE != 3 &&
                                                                   JC_TRANS_RECORD._.IS_DELETE != 1);
                counts.Add(toPolice);

                #endregion

                #region 移送有关公职人员违纪违法线索

                var staff2Police = new ProjectSupervisionCountResponseModel { Label = " 移送有关公职人员违纪违法线索" };
                staff2Police.DoneCount = Jd.JcTransRecordService.Count(JC_TRANS_RECORD._.TRANS_USER_ID == jdUserId &&
                                                                       JC_TRANS_RECORD._.TRANS_TYPE == 3 &&
                                                                       JC_TRANS_RECORD._.IS_DELETE != 1);
                counts.Add(staff2Police);

                #endregion
                return counts;
            });
            return cacheCounts;
        }
        #endregion

        #region 项目监督 行业部门 项目交易数据统计
        /// <summary>
        /// 项目交易数据统计
        /// </summary>
        /// <returns></returns>
        public List<ProjectSupervisionTradeCountResponseModel> ProjectSupervisionTradeCount()
        {
            var r = new List<ProjectSupervisionTradeCountResponseModel>();
            var types = Fw.SysDicService.FindDicByType("10",2525).FindAll(c => c.VALUE.Length == 3);//行业类别
            //var types = Fw.SysDicService.FromWhere(SYS_DIC._.PID=="2525").Select().FindAll(c => c.VALUE.Length == 3);//行业类别
            if (JdUser?.UserDepartment?.ISALLKIND != 1)
            {
                var userDepartmentProjectTypes = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
                if (userDepartmentProjectTypes != null && userDepartmentProjectTypes.Any())
                {
                    types = types.FindAll(c => userDepartmentProjectTypes.Contains(c.VALUE));
                }
                else
                {
                    types.Clear();
                }
            }

            var projectTypes = types.Select(c => c.VALUE).ToList();
            var gProjectTypes = projectTypes.Select(c => c.Replace("A", "G")).ToList();
            projectTypes.AddRange(gProjectTypes);
            var todayAdds =
                Fw.TenderProjectService.FromWhere(
                        GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes) && GGZYFW.DbEntity.TENDER_PROJECT._.M_TM > DateTime.Today).GroupBy(TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                    .Select(
                        TENDER_PROJECT._.TENDER_PROJECT_TYPE.As("Label"),
                        TENDER_PROJECT._.All.Count().As("TodayAdd"))
                    .ToList<ProjectSupervisionTradeCountResponseModel>();
            var todayAmounts = Fw.WinResultAnnoService
                .FromWhere(
                    GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes)
                    && GGZYFW.DbEntity.WIN_RESULT_ANNO._.M_DATA_SOURCE == "9999"
                    && GGZYFW.DbEntity.WIN_RESULT_ANNO._.M_STATUS == 2
                    && GGZYFW.DbEntity.WIN_RESULT_ANNO._.NOTICE_SEND_TIME >= DateTime.Today)
                .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                .GroupBy(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(
                    GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.As("Label"),
                    new Field("(CASE TO_CHAR(PRICE_UNIT) WHEN '1' THEN BID_AMOUNT ELSE BID_AMOUNT/10000 END)").Sum().As("TodayAmount")
                ).ToList<ProjectSupervisionTradeCountResponseModel>();
            var total = Fw.WinResultAnnoService
                .FromWhere(
                    GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes)
                    && GGZYFW.DbEntity.WIN_RESULT_ANNO._.M_DATA_SOURCE == "9999"
                    && GGZYFW.DbEntity.WIN_RESULT_ANNO._.M_STATUS == 2)
                .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                .GroupBy(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE.As("Label"),
                    GGZYFW.DbEntity.WIN_RESULT_ANNO._.All.Count().As("AllTradeCount"),
                    new Field("(CASE TO_CHAR(PRICE_UNIT) WHEN '1' THEN BID_AMOUNT/10000 ELSE BID_AMOUNT/100000000 END)").Sum().As("AllAmount")
                ).ToList<ProjectSupervisionTradeCountResponseModel>();
            foreach (var sysDic in types)
            {
                var gType = sysDic.VALUE.Replace("A", "G");
                var todayAdd = todayAdds.FindAll(c => c.Label == sysDic.VALUE || c.Label == gType);
                var todayAmount = todayAmounts.FindAll(c => c.Label == sysDic.VALUE || c.Label == gType);
                var totalAmount = total.FindAll(c => c.Label == sysDic.VALUE || c.Label == gType);
                r.Add(new ProjectSupervisionTradeCountResponseModel
                {
                    Label = sysDic.TEXT,
                    TodayAdd = todayAdd.Sum(c => c.TodayAdd),
                    TodayAmount = todayAmount.Sum(c => c.TodayAmount),
                    AllTradeCount = totalAmount.Sum(c => c.AllTradeCount),
                    AllAmount = totalAmount.Sum(c => c.AllAmount)
                });
            }

            return r;
        }

        #endregion

        #region 项目监督 行业部门 标后监管系统


        public PageTableResult HyAfterSupervisions(SearchCondition search)
        {
            return search.ToPageTableResult();
        }

        #endregion

        #region 项目监督 行业部门 处理项目及事项 详情

        #region 项目监督 行业部门 处理项目及事项 项目信息

        public GeneralResult HyProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            switch (model.TYPE)
            {
                case nameof(T_AFC_PROJECT):
                    r = HyAfcProjectDetail(model);
                    break;
                case nameof(RECORD_REVIEW):
                    r = HyRecordProjectDetail(model);
                    break;
                case nameof(PT_ZXTS):
                    r = HyTsProjectDetail(model);
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    r = HyWarnResultProjectDetail(model);
                    break;
                default:
                    r.SetFail("参数错误");
                    break;
            }
            return r;
        }
        /// <summary>
        /// 招标计划登记 项目基础信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult HyAfcProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            ProjectSupervisionBaseInfoResponseModel data = null;
            var dbModel = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                .Select(
                    SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                    new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                    T_AFC_PROJECT._.All
                ).ToFirst<TAfcProjectModel>();
            if (dbModel == null)
            {
                r.SetFail("未找到对应的招标计划登记信息");
            }
            else
            {
                var tenderProject = Jd.TenderProjectService.FromWhere()
                    .InnerJoin<PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE &&
                                        PROJECT._.CONSTRUCTION_ID == dbModel.CODE)
                    .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.PLATFORM_CODE)
                    .Select(T_USER_TRADEPLATFORM._.SYSTEM_NAME,
                        GGZYJD.DbEntity.TENDER_PROJECT._.All)
                    .ToFirst<JdTenderProjectModel>();
                if (!string.IsNullOrWhiteSpace(tenderProject?.TENDER_PROJECT_CODE))
                {
                    data = Fw.TenderProjectService.HyProjectDetailModel(tenderProject.TENDER_PROJECT_CODE);
                }

                if (data == null)
                {
                    data = new ProjectSupervisionBaseInfoResponseModel
                    {
                        M_ID = dbModel.ID,
                        PROJECT_CODE = tenderProject?.TENDER_PROJECT_CODE ?? dbModel.CODE,
                        PROJECT_NAME = dbModel.PROJECT_NAME,
                        AGENCY_NAME = tenderProject?.TENDER_AGENCY_NAME ?? string.Empty,
                        AREANAME = $"{dbModel.REGION_COUNTY_NAME}",
                        CREATE_TIME = dbModel.TM,
                        OWNER_NAME = dbModel.JS_DEP,
                        REGION_CODE = dbModel.REGION_COUNTY,
                        P_REGION_CODE = dbModel.REGION_CITY,
                        P_AREANAME = $"{dbModel.REGION_CITY_NAME}",
                        PLATFORM_CODE = tenderProject?.PLATFORM_CODE ?? string.Empty,
                        SYSTEM_NAME = tenderProject?.SYSTEM_NAME ?? string.Empty,
                        TENDERER_CONTRACT= tenderProject?.TENDERER_CONTRACT??dbModel.MANAGER,
                        TENDERER_PHONE = tenderProject?.TENDERER_PHONE??dbModel.MANAGER_PHONE,
                        TENDER_AGENT_CONTRACT = tenderProject?.TENDER_AGENT_CONTRACT,
                        TENDER_AGENT_PHONE = tenderProject?.TENDER_AGENT_PHONE,
                    };
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(data.TENDERER_CONTRACT))
                    {
                        data.TENDERER_CONTRACT = tenderProject?.TENDERER_CONTRACT ?? dbModel.MANAGER;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDERER_PHONE))
                    {
                        data.TENDERER_PHONE = tenderProject?.TENDERER_PHONE ?? dbModel.MANAGER_PHONE;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDER_AGENT_CONTRACT))
                    {
                        data.TENDER_AGENT_CONTRACT = tenderProject?.TENDER_AGENT_CONTRACT ;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDER_AGENT_PHONE))
                    {
                        data.TENDER_AGENT_PHONE = tenderProject?.TENDER_AGENT_PHONE ;
                    }
                }
                r.SetSuccess(data);
            }

            return r;
        }

        /// <summary>
        /// 招标备案 项目基础信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult HyRecordProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            ProjectSupervisionBaseInfoResponseModel data = null;
            var dbModel = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == model.ID);
            if (dbModel == null)
            {
                r.SetFail("未找到对应的招标计划登记信息");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(dbModel.TENDER_PROJECT_CODE))
                {
                    data = Fw.TenderProjectService.HyProjectDetailModel(dbModel.TENDER_PROJECT_CODE);
                }
                JdTenderProjectModel tenderProject = Jd.TenderProjectService.FromWhere(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == dbModel.TENDER_PROJECT_CODE)
                    .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.PLATFORM_CODE)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == GGZYJD.DbEntity.TENDER_PROJECT._.REGION_CODE)
                    .Select(T_USER_TRADEPLATFORM._.SYSTEM_NAME,
                        SYS_AREA_QUANGUO._.AREANAME,
                        GGZYJD.DbEntity.TENDER_PROJECT._.All)
                    .ToFirst<JdTenderProjectModel>();
                if (data == null)
                {
                    
                    data = new ProjectSupervisionBaseInfoResponseModel
                    {
                        M_ID = dbModel.ID,
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
                        SYSTEM_NAME = tenderProject?.SYSTEM_NAME ?? String.Empty,
                        TENDERER_CONTRACT = tenderProject?.TENDERER_CONTRACT,
                        TENDERER_PHONE = tenderProject?.TENDERER_PHONE,
                        TENDER_AGENT_CONTRACT = tenderProject?.TENDER_AGENT_CONTRACT,
                        TENDER_AGENT_PHONE = tenderProject?.TENDER_AGENT_PHONE,
                    };
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(data.TENDERER_CONTRACT))
                    {
                        data.TENDERER_CONTRACT = tenderProject?.TENDERER_CONTRACT;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDERER_PHONE))
                    {
                        data.TENDERER_PHONE = tenderProject?.TENDERER_PHONE ;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDER_AGENT_CONTRACT))
                    {
                        data.TENDER_AGENT_CONTRACT = tenderProject?.TENDER_AGENT_CONTRACT;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDER_AGENT_PHONE))
                    {
                        data.TENDER_AGENT_PHONE = tenderProject?.TENDER_AGENT_PHONE;
                    }
                }
                r.SetSuccess(data);
            }

            return r;
        }

        /// <summary>
        /// 在线投诉 项目基础信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult HyTsProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            ProjectSupervisionBaseInfoResponseModel data = null;
            var dbModel = Jd.PtZxtsService.FirstOrNull(PT_ZXTS._.ID == model.ID);
            if (dbModel == null)
            {
                r.SetFail("未找到对应的招标计划登记信息");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(dbModel.TENDER_PROJECT_CODE))
                {
                    data = Fw.TenderProjectService.HyProjectDetailModel(dbModel.TENDER_PROJECT_CODE);
                }
                var tenderProject = Jd.TenderProjectService.FromWhere(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == dbModel.TENDER_PROJECT_CODE)
                    .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.PLATFORM_CODE)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == GGZYJD.DbEntity.TENDER_PROJECT._.REGION_CODE)
                    .Select(T_USER_TRADEPLATFORM._.SYSTEM_NAME,
                        SYS_AREA_QUANGUO._.AREANAME,
                        GGZYJD.DbEntity.TENDER_PROJECT._.All)
                    .ToFirst<JdTenderProjectModel>();
                if (data == null)
                {
                    data = new ProjectSupervisionBaseInfoResponseModel
                    {
                        M_ID = dbModel.ID,
                        PROJECT_CODE = dbModel.TENDER_PROJECT_CODE,
                        PROJECT_NAME = dbModel.TENDER_PROJECT_NAME,
                        AGENCY_NAME = tenderProject?.TENDER_AGENCY_NAME ?? string.Empty,
                        AREANAME = tenderProject?.AREANAME,
                        CREATE_TIME = tenderProject?.CREATE_TIME,
                        OWNER_NAME = tenderProject?.OWNER_NAME,
                        REGION_CODE = tenderProject?.REGION_CODE,
                        P_REGION_CODE = "",
                        P_AREANAME = $"",
                        PLATFORM_CODE = tenderProject?.PLATFORM_CODE ?? String.Empty,
                        SYSTEM_NAME = tenderProject?.SYSTEM_NAME ?? String.Empty,
                        TENDERER_CONTRACT = tenderProject?.TENDERER_CONTRACT,
                        TENDERER_PHONE = tenderProject?.TENDERER_PHONE,
                        TENDER_AGENT_CONTRACT = tenderProject?.TENDER_AGENT_CONTRACT,
                        TENDER_AGENT_PHONE = tenderProject?.TENDER_AGENT_PHONE,
                    };
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(data.TENDERER_CONTRACT))
                    {
                        data.TENDERER_CONTRACT = tenderProject?.TENDERER_CONTRACT;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDERER_PHONE))
                    {
                        data.TENDERER_PHONE = tenderProject?.TENDERER_PHONE;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDER_AGENT_CONTRACT))
                    {
                        data.TENDER_AGENT_CONTRACT = tenderProject?.TENDER_AGENT_CONTRACT;
                    }
                    if (string.IsNullOrWhiteSpace(data.TENDER_AGENT_PHONE))
                    {
                        data.TENDER_AGENT_PHONE = tenderProject?.TENDER_AGENT_PHONE;
                    }
                }
                r.SetSuccess(data);
            }

            return r;
        }



        /// <summary>
        /// 监督点 项目基础信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult HyWarnResultProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            ProjectSupervisionBaseInfoResponseModel data = null;
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 条件
            var jddCon = new WhereClipBuilder(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model.ID);





            #endregion


            //var afcQuery = Jd.TAfcProjectService.FromWhere(con.ToWhereClip());
            var tenderProjectCodeOld1 = Fw.WarnResultService.FromWhere(jddCon.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE)
                .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
            if (string.IsNullOrWhiteSpace(tenderProjectCodeOld1))
            {
                r.SetFail("未找到对应的监督点信息");
            }
            else
            {
                data = Fw.TenderProjectService.HyProjectDetailModel(tenderProjectCodeOld1);
                r.SetSuccess(data);
            }

            return r;
        }
        #endregion

        #region 项目监督 行业部门 处理项目及事项 详情 时限监督


        protected string GetJdTenderProjectCodeOld1(ProjectSupervisionResponseHyModel model)
        {
            var tenderProjectCodeOld1 = string.Empty;
            switch (model.TYPE)
            {
                case nameof(T_AFC_PROJECT):
                    tenderProjectCodeOld1 = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                        .InnerJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.CODE)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
                    break;
                case nameof(RECORD_REVIEW):
                    tenderProjectCodeOld1 = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.ID == model.ID)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
                    break;
                case nameof(PT_ZXTS):

                    tenderProjectCodeOld1 = Jd.PtZxtsService.FromWhere(PT_ZXTS._.ID == model.ID)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    tenderProjectCodeOld1 = Fw.WarnResultService.FirstOrNull(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model.ID)?.TENDER_PROJECT_CODE;
                    break;
            }

            return tenderProjectCodeOld1;
        }
        //列表展示内容规则：1、红灯状态的监督点2、由红灯变为绿灯后的监督点
        public PageTableResult Sxjd(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = search.ToPageTableResult();
            var tenderProjectCodeOld1 = GetJdTenderProjectCodeOld1(model);

            if (!string.IsNullOrWhiteSpace(tenderProjectCodeOld1))
            {
                var count = Fw.WarnResultService.Count(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == tenderProjectCodeOld1);
                if (count > 0)
                {
                    var list = Fw.WarnResultService.FromWhere(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == tenderProjectCodeOld1 && GGZYFW.DbEntity.WARN_RESULT._.RESULT_STATUS == 3)
                        .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                        .InnerJoin<GGZYFW.DbEntity.WARN_EXPRESSION>(GGZYFW.DbEntity.WARN_EXPRESSION._.M_ID == GGZYFW.DbEntity.WARN_RESULT._.SP_ID)
                        .OrderBy(GGZYFW.DbEntity.WARN_RESULT._.SP_TIME.Desc)
                        .Page(search.PageSize, search.PageNo)
                        .Select(
                            GGZYFW.DbEntity.WARN_RESULT._.M_ID,
                            GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE,
                            GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                            GGZYFW.DbEntity.WARN_EXPRESSION._.SP_NAME,
                            GGZYFW.DbEntity.WARN_EXPRESSION._.SP_WAY,
                            GGZYFW.DbEntity.WARN_RESULT._.RESULT_STATUS,
                            GGZYFW.DbEntity.WARN_RESULT._.SP_TIME
                        ).ToList<object>();
                    r = list.ToPageTableResult(search, count);
                }

            }

            return r;
        }

        #endregion


        #region 项目监督 行业部门 处理项目及事项 详情 违法违规大数据分析提示

        public PageTableResult IllegalBigData(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {

            var r = search.ToPageTableResult();
            var tenderProjectCodeOld1 = GetJdTenderProjectCodeOld1(model);

            if (!string.IsNullOrWhiteSpace(tenderProjectCodeOld1))
            {
                var count = Fw.BdViolationRecordService
                    .Count(GGZYFW.DbEntity.BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == tenderProjectCodeOld1);
                if (count > 0)
                {
                    var list = Fw.BdViolationRecordService
                        .FromWhere(GGZYFW.DbEntity.BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == tenderProjectCodeOld1)
                        .LeftJoin<GGZYFW.DbEntity.BD_VIOLATION_POINT>(GGZYFW.DbEntity.BD_VIOLATION_POINT._.ID==GGZYFW.DbEntity.BD_VIOLATION_RECORD._.POINT_ID)
                        .OrderBy(GGZYFW.DbEntity.BD_VIOLATION_RECORD._.CHECK_TIME.Desc)
                        .Select(
                            GGZYFW.DbEntity.BD_VIOLATION_RECORD._.CHECK_TIME,
                            GGZYFW.DbEntity.BD_VIOLATION_RECORD._.STATE,
                            GGZYFW.DbEntity.BD_VIOLATION_RECORD._.POINT_NAME,
                            GGZYFW.DbEntity.BD_VIOLATION_POINT._.CATEGORY_NAME
                        )
                        .Page(search.PageSize, search.PageNo)
                        .ToList<object>();
                    r = list.ToPageTableResult(search, count);
                }

            }

            return r;
        }

        #endregion


        #region 项目监督 行业部门 处理项目及事项 详情 线上线下异议、投诉、举报信息
        /// <summary>
        /// 项目监督 行业部门 处理项目及事项 详情 线上线下异议、投诉、举报信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult TsJbYy(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var tenderProjectCode = string.Empty;
            switch (model.TYPE)
            {
                case nameof(T_AFC_PROJECT):
                    tenderProjectCode = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                        .InnerJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.CODE)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE).ToScalar<string>();
                    break;
                case nameof(RECORD_REVIEW):
                    tenderProjectCode = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == model.ID)
                        ?.TENDER_PROJECT_CODE;
                    break;
                case nameof(PT_ZXTS):

                    tenderProjectCode = Jd.PtZxtsService.FirstOrNull(PT_ZXTS._.ID == model.ID)?.TENDER_PROJECT_CODE;
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    var tenderProjectCodeOld1 = Fw.WarnResultService.FirstOrNull(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model.ID)
                        ?.TENDER_PROJECT_CODE;
                    tenderProjectCode = Jd.TenderProjectService
                        .FirstOrNull(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == tenderProjectCodeOld1)
                        ?.TENDER_PROJECT_CODE;
                    break;
            }

            if (!string.IsNullOrWhiteSpace(tenderProjectCode))
            {

                var objection = Jd.TenderProjectService.FromWhere(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == tenderProjectCode)
                    .InnerJoin<RECORD_REVIEW>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                    .InnerJoin<RECORD_HANDLE_RESULT>(RECORD_HANDLE_RESULT._.RECORD_ID == RECORD_REVIEW._.ID)
                    .Select(RECORD_HANDLE_RESULT._.ID, GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                        GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME, RECORD_REVIEW._.COMMIT_TIME.As("CREATE_TM"),
                        new Field("'RECORD_HANDLE_RESULT'").As("TYPE"),
                        new Field("'异议'").As("TYPE_TEXT"));
                var query = Jd.PtZxtsService.FromWhere(PT_ZXTS._.TENDER_PROJECT_CODE == tenderProjectCode && PT_ZXTS._.ACCEPT_DEPID == JdUser?.DEPARTID).Select(
                        PT_ZXTS._.ID, PT_ZXTS._.TENDER_PROJECT_CODE, PT_ZXTS._.TENDER_PROJECT_NAME, PT_ZXTS._.CREATE_TM,
                        new Field("'PT_ZXTS'").As("TYPE"),
                        new Field("'投诉'").As("TYPE_TEXT"))
                    .UnionAll(objection);
                var count = query.Count();
                if (count > 0)
                {
                    var list = query
                        .OrderBy(new Field("CREATE_TM").Desc)
                        .Page(search.PageSize, search.PageNo)
                        .ToList<object>();
                    var plist = list.ToPageTableResult(search, count);
                    return plist;
                }
            }
            return search.ToPageTableResult();
        }

        #endregion

        #region 项目监督 行业部门 处理项目及事项 详情 其他信息提示

        public PageTableResult OtherInfoTips(string tenderProjectCode, SearchCondition search)
        {
            return search.ToPageTableResult();
        }

        #endregion

        #region 项目监督 行业部门 处理项目及事项 详情 处理事项

        public PageTableResult HandleItems(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            GGZYJD.DbEntity.TENDER_PROJECT tenderProject = null;
            switch (model.TYPE)
            {
                case nameof(T_AFC_PROJECT):
                    tenderProject = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                        .LeftJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.CODE)
                        .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                            GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                            T_AFC_PROJECT._.CODE.As("CONSTRUCTION_ID")).ToFirst<GGZYJD.DbEntity.TENDER_PROJECT>();
                    break;
                case nameof(RECORD_REVIEW):
                    tenderProject = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.ID == model.ID)
                        .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                        .LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE)
                        .Select(RECORD_REVIEW._.TENDER_PROJECT_CODE,
                            GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                            PROJECT._.CONSTRUCTION_ID).ToFirst<GGZYJD.DbEntity.TENDER_PROJECT>();
                    break;
                case nameof(PT_ZXTS):
                    tenderProject = Jd.PtZxtsService.FromWhere(PT_ZXTS._.ID == model.ID)
                        .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                        .LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE)
                        .Select(PT_ZXTS._.TENDER_PROJECT_CODE,
                            GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                            PROJECT._.CONSTRUCTION_ID).ToFirst<GGZYJD.DbEntity.TENDER_PROJECT>();
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    var tenderProjectCodeOld1 = Fw.WarnResultService.FirstOrNull(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model.ID)
                        ?.TENDER_PROJECT_CODE;
                    tenderProject = Jd.TenderProjectService
                                        .FirstOrNull(
                                            GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == tenderProjectCodeOld1) ??
                                    new GGZYJD.DbEntity.TENDER_PROJECT { TENDER_PROJECT_CODE_OLD1 = tenderProjectCodeOld1 };
                    break;
            }
            if (tenderProject != null)
            {

                #region 招标计划登记

                var afcQueryable = Jd.TAfcLogService
                    .FromWhere(T_AFC_LOG._.CODE == tenderProject?.CONSTRUCTION_ID && T_AFC_LOG._.ISNEW == "1")
                    .Select(
                        new Field("'T_AFC_PROJECT'").As("TYPE"),
                        new Field("'招标计划登记'").As("TYPE_TEXT"),
                        new Field("''").As("FROM"),
                        new Field("''").As("TO"),
                        T_AFC_LOG._.APPROVAL_UNAME.ToChar().As("OPERATOR"),
                        T_AFC_LOG._.APPROVAL_REMARK.ToChar().As("HANDLE_OPINION"),
                        new Field("(CASE WHEN RECORDER_OPERATION>2 THEN 2 WHEN RECORDER_OPERATION='2' AND RECORDER_TACHE>1 THEN 1 ELSE 0 END)").ToChar().As("HANDLE_TYPE"),
                        T_AFC_LOG._.RECORDER_TM.As("HANDLE_TIME"));

                #endregion

                #region 招标备案

                var recordQueryable = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE)
                    .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID)
                    .Select(
                        new Field("'RECORD_REVIEW'").As("TYPE"),
                        SYS_DIC._.TEXT.ToChar().As("TYPE_TEXT"),
                        new Field("''").As("FROM"),
                        new Field("''").As("TO"),
                        T_USER_DEPARTMENT._.DNAME.ToChar().As("OPERATOR"),
                        RECORD_REVIEW._.AUDIT_UNIT.ToChar().As("HANDLE_OPINION"),
                        RECORD_REVIEW._.REVIEW_STATUS.ToChar().As("HANDLE_TYPE"),
                        RECORD_REVIEW._.CREATE_TM.As("HANDLE_TIME"));


                #endregion

                #region 投诉

                var tsQueryable = Jd.PtZxtsService.FromWhere(PT_ZXTS._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE && PT_ZXTS._.TYPE != 2)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID)
                    .Select(
                        new Field("'PT_ZXTS'").As("TYPE"),
                        new Field("'投诉处理'").As("TYPE_TEXT"),
                        new Field("''").As("FROM"),
                        new Field("''").As("TO"),
                        T_USER_DEPARTMENT._.DNAME.ToChar().As("OPERATOR"),
                        new Field("(CASE WHEN STATE =2 THEN SIGN_REMARK WHEN STATE IN (4,6,7) THEN ACCEPT_REMARK WHEN STATE=5 THEN HANDLE_REMARK ELSE '' END )").ToChar().As("HANDLE_OPINION"),

                        new Field("(CASE WHEN STATE IN(3,5,8,9) THEN 2 WHEN STATE IN (2,4,6,7) THEN 1 ELSE 0 END )").ToChar().As("HANDLE_TYPE"),
                        PT_ZXTS._.CREATE_TM.As("HANDLE_TIME"));

                #endregion

                #region 触发监督点

                var jddQueryable = FromWhere<GGZYFW.DbEntity.WARN_RESULT>(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE_OLD1 && GGZYFW.DbEntity.WARN_RESULT._.ISDELETE != 1)
                    .LeftJoin<GGZYFW.DbEntity.WARN_EXPRESSION>(GGZYFW.DbEntity.WARN_EXPRESSION._.M_ID == GGZYFW.DbEntity.WARN_RESULT._.SP_ID)
                    .Select(
                        new Field("'WARN_RESULT'").As("TYPE"),
                        GGZYFW.DbEntity.WARN_EXPRESSION._.SP_NAME.ToChar().As("TYPE_TEXT"),
                        new Field("''").As("FROM"),
                        new Field("''").As("TO"),
                        new Field("''").As("OPERATOR"),
                        new Field("''").As("HANDLE_OPINION"),

                        new Field("(CASE WHEN OPERATE_STATUS IN(3,4) THEN 2 WHEN OPERATE_STATUS=2 THEN 1 ELSE 0 END )").ToChar().As("HANDLE_TYPE"),
                        GGZYFW.DbEntity.WARN_RESULT._.SP_TIME.As("HANDLE_TIME"));

                #endregion

                #region 触发疑似违规点

                var illegalQueryable = FromWhere<GGZYFW.DbEntity.BD_VIOLATION_RECORD>(GGZYFW.DbEntity.BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE_OLD1).Select(
                    new Field("'BD_VIOLATION_RECORD'").As("TYPE"),
                    GGZYFW.DbEntity.BD_VIOLATION_RECORD._.POINT_NAME.ToChar().As("TYPE_TEXT"),
                    new Field("''").As("FROM"),
                    new Field("''").As("TO"),
                    new Field("''").As("OPERATOR"),
                    new Field("''").As("HANDLE_OPINION"),
                    new Field("(CASE WHEN STATE =1 THEN 2  ELSE 0 END )").ToChar().As("HANDLE_TYPE"),
                    GGZYFW.DbEntity.BD_VIOLATION_RECORD._.CHECK_TIME.As("HANDLE_TIME"));

                #endregion

                #region 发出移送

                var sendProjectQueryable = Jd.JcTransRecordService.FromWhere(JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.TRANS_USER_ID == JdUser?.ID && JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE)
                    .LeftJoin<JC_TRANS_PROJECT>(JC_TRANS_PROJECT._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_PROJECT._.IS_DELETE != 1)
                    .LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RESULT._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_RESULT._.IS_DELETE != 1)
                    .Select(
                        new Field("'JC_TRANS_PROJECT_SEND'").As("TYPE"),
                        JC_TRANS_RECORD._.TITLE.ToChar().As("TYPE_TEXT"),
                        JC_TRANS_RECORD._.TRANS_USER.ToChar().As("FROM"),
                        JC_TRANS_RECORD._.RECEIVER.ToChar().As("TO"),
                        JC_TRANS_RECORD._.TRANS_USER.ToChar().As("OPERATOR"),
                        JC_TRANS_RESULT._.RESULT_MSG.ToChar().As("HANDLE_OPINION"),
                        new Field("(CASE WHEN HAS_RESULT=1 THEN 2 ELSE 0 END )").ToChar().As("HANDLE_TYPE"),
                        JC_TRANS_RECORD._.TRANS_TIME.As("HANDLE_TIME"));

                #endregion

                #region 收到移送

                var receiveProjectQueryable = Jd.JcTransRecordService.FromWhere(JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.DEPARTID && JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE)
                    .LeftJoin<JC_TRANS_PROJECT>(JC_TRANS_PROJECT._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_PROJECT._.IS_DELETE != 1)
                    .LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RESULT._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_RESULT._.IS_DELETE != 1)
                    .Select(
                        new Field("'JC_TRANS_PROJECT_RECEIVE'").As("TYPE"),
                        JC_TRANS_RECORD._.TITLE.ToChar().As("TYPE_TEXT"),
                        JC_TRANS_RECORD._.TRANS_USER.ToChar().As("FROM"),
                        JC_TRANS_RECORD._.RECEIVER.ToChar().As("TO"),
                        JC_TRANS_RECORD._.TRANS_USER.ToChar().As("OPERATOR"),
                        JC_TRANS_RESULT._.RESULT_MSG.ToChar().As("HANDLE_OPINION"),
                        new Field("(CASE WHEN HAS_RESULT=1 THEN 2 ELSE 0 END )").ToChar().As("HANDLE_TYPE"),
                        JC_TRANS_RECORD._.TRANS_TIME.As("HANDLE_TIME"));

                #endregion

                #region 向纪委移送疑似违规点

                var sendPersonQueryable = Jd.JcTransRecordService.FromWhere(JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.TRANS_USER_ID == JdUser?.ID && JC_TRANS_PERSON._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE && T_USER_DEPARTMENT._.DTYPE == 3)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == JC_TRANS_RECORD._.RECEIVER_UNIT_ID)
                    .LeftJoin<JC_TRANS_PERSON>(JC_TRANS_PERSON._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_PERSON._.IS_DELETE != 1)
                    .LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RESULT._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_RESULT._.IS_DELETE != 1)
                    .Select(
                        new Field("'JC_TRANS_PERSON'").As("TYPE"),
                        JC_TRANS_RECORD._.TITLE.ToChar().As("TYPE_TEXT"),
                        JC_TRANS_RECORD._.TRANS_USER.ToChar().As("FROM"),
                        JC_TRANS_RECORD._.RECEIVER.ToChar().As("TO"),
                        JC_TRANS_RECORD._.TRANS_USER.ToChar().As("OPERATOR"),
                        JC_TRANS_RESULT._.RESULT_MSG.ToChar().As("HANDLE_OPINION"),
                        new Field("(CASE WHEN HAS_RESULT=1 THEN 2 ELSE 0 END )").ToChar().As("HANDLE_TYPE"),
                        JC_TRANS_RECORD._.TRANS_TIME.As("HANDLE_TIME"));

                #endregion

                var unionQuery = afcQueryable
                    .UnionAll(recordQueryable)
                    .UnionAll(tsQueryable)
                    .UnionAll(jddQueryable)
                    .UnionAll(illegalQueryable)
                    .UnionAll(sendPersonQueryable)
                    .UnionAll(sendProjectQueryable)
                    .UnionAll(receiveProjectQueryable);
                var count = unionQuery.Count();
                if (count > 0)
                {
                    var list = unionQuery.OrderByDescending(new Field("HANDLE_TIME"))
                        .Page(search.PageSize, search.PageNo)
                        .ToList<ProjectSupervisionHandleItemResponseModel>();
                    plist = list.ToPageTableResult(search, count);
                }
            }
            return plist;
        }

        #endregion

        #endregion



        #endregion


        #region 闽政通
        /// <summary>
        /// 项目监督 行业主管 待处理 已处理 超期未处理 统计
        /// </summary>
        /// <returns></returns>
        public List<object> MztHyProjectSupervisionCount()
        {
            #region 待处理

            ProjectSupervisionRequestModel model = new ProjectSupervisionRequestModel { HANDLE_STATE = "DCL" };
            var afcQueryable = AfcProjectSupervisionQueryable(model);
            var recordQueryable = RecordProjectSupervisionQueryable(model);
            var tsQueryable = TsProjectSupervisionQueryable(model);
            var jddQueryable = JddProjectSupervisionQueryable(model);
            var query = afcQueryable.UnionAll(tsQueryable).UnionAll(recordQueryable).UnionAll(jddQueryable);//todo mzt
            var dcl = query.Count();

            #endregion

            #region 已处理

            model.HANDLE_STATE = "YCL";
            afcQueryable = AfcProjectSupervisionQueryable(model);
            recordQueryable = RecordProjectSupervisionQueryable(model);
            tsQueryable = TsProjectSupervisionQueryable(model);
            jddQueryable = JddProjectSupervisionQueryable(model);
            query = afcQueryable.UnionAll(tsQueryable).UnionAll(recordQueryable).UnionAll(jddQueryable);//todo mzt
            var ycl = query.Count();

            #endregion

            #region 超期未处理

            model.HANDLE_STATE = "CQWCL";
            afcQueryable = AfcProjectSupervisionQueryable(model);
            recordQueryable = RecordProjectSupervisionQueryable(model);
            tsQueryable = TsProjectSupervisionQueryable(model);
            jddQueryable = JddProjectSupervisionQueryable(model);
            query = afcQueryable.UnionAll(tsQueryable).UnionAll(recordQueryable).UnionAll(jddQueryable);//todo mzt
            var cqwcl = query.Count();

            #endregion
            return new List<object>
            {
                new  {value = "DCL", label = "待处理", count = dcl},
                new  {value = "YCL", label = "已处理", count = ycl},
                new  {value = "CQWCL", label = "超期未处理", count = cqwcl},
            };
        }

        #endregion
    }
}