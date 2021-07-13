using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderProjectService
    {
        #region 测试

        public GeneralResult Join(decimal? M_ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.M_ID == M_ID);

            var dbModel = FromWhere(condition.ToWhereClip()).Select(TENDER_PROJECT._.TENDER_PROJECT_TYPE, SYS_DIC._.VALUE)
                .LeftJoin<SYS_DIC>(TENDER_PROJECT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "10")
                .LeftJoin<SYS_DIC>(TENDER_PROJECT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "10")

                .ToDataTable();
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }
        public GeneralResult Join1(decimal? M_ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.M_ID == M_ID);

            var dbModel = FromWhere(condition.ToWhereClip()).Select(TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .AddSelect(FromWhere<SYS_DIC>(TENDER_PROJECT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "10").Select(SYS_DIC._.VALUE), "VALUE1")
                .AddSelect(FromWhere<SYS_DIC>(TENDER_PROJECT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "10").Select(SYS_DIC._.VALUE), "VALUE2")
                //.ToFirst()
                //.First<object>()
                .ToList<object>();
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }

        public GeneralResult Join2(decimal? M_ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.M_ID == M_ID);

            var dbModel = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(TENDER_PROJECT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "10")
                .LeftJoin<SYS_DIC>(TENDER_PROJECT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "10")//生成SQL时这里对应的时候SYS_DIC2
                .Select(SYS_DIC._.TEXT, new Field("TEXT", "SYS_DIC2").As("TENDER_PROJECT_NAME"), TENDER_PROJECT._.All)
                .ToDataTable();
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }


        #endregion


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 招标项目信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="attachmentFunc">门户网站不显示附件null  后台显示附件不为null</param>
        /// <returns></returns>
        public dynamic JD_GCJS_XMJC_TenderProjectInfo(string projectCode, Func<string,  List<UploadResData>> attachmentFunc = null)
        {
            var entity = FromSql(@"
                SELECT T.TENDER_PROJECT_CODE,
                       T.TENDER_PROJECT_NAME,
                       T.TENDERER_NAME,
                       T.TENDERER_CODE,
                       T.TENDER_AGENCY_NAME,
                       T.TENDER_AGENCY_CODE,
                       T.TENDER_CONTENT,       
                       T.TENDER_PROJECT_TYPE,
                       T.TENDER_MODE,
                       T.TENDER_ORGANIZE_FORM,
                       T.SUPERVISE_DEPT_NAME,
                       T.APPROVE_DEPT_NAME,
                       T.CREATE_TIME,
                       T1.TEXT                  AS TENDER_PROJECT_TYPE_TEXT,
                       T2.TEXT                  AS TENDER_MODE_TEXT,
                       T3.TEXT                  AS TENDER_ORGANIZE_FORM_TEXT,
                       T5.AREANAME||T4.AREANAME AS REGION_NAME,
                       T.M_ATT_PROJECT_REG,
                       T.M_ATT_AGENT_COMMIT,
                       T.M_ATT_OTHER_FILE,
                       T.M_ATT_PROJECT_REG_APPROVE,
                       T.M_ATT_COR_AUTHORITY_FILE,
                       T.M_ATT_FUND_SOURCE_CERTIFY_FILE
                  FROM TENDER_PROJECT T
                       LEFT JOIN sys_dic T1 ON T1.type = 2002 AND T.TENDER_PROJECT_TYPE = T1.VALUE
                       LEFT JOIN sys_dic T2 ON T2.TYPE = 1000 AND T.TENDER_MODE = T2.VALUE
                       LEFT JOIN sys_dic T3 ON T3.TYPE = 21 AND T.TENDER_ORGANIZE_FORM = T3.VALUE       
                       LEFT JOIN SYS_AREA_QUANGUO T4 ON T.REGION_CODE=T4.AREACODE
                       LEFT JOIN SYS_AREA_QUANGUO T5 ON substr(T.REGION_CODE,5,2)!='00' AND T.REGION_CODE!='350128' AND substr(T.REGION_CODE,1,4)||'00' =T5.AREACODE
                 WHERE T.TENDER_PROJECT_CODE=:tender_project_code")
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode).ToFirst<dynamic>();
            #region 监督平台后台 sType == "HT" && MemberUserInfo.UserID != -1

            if (attachmentFunc != null)
            {
                entity.M_ATT_PROJECT_REG_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_PROJECT_REG);
                entity.M_ATT_AGENT_COMMIT_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_AGENT_COMMIT);
                entity.M_ATT_OTHER_FILE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_OTHER_FILE);
                entity.M_ATT_PROJECT_REG_APPROVE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_PROJECT_REG_APPROVE);
                entity.M_ATT_COR_AUTHORITY_FILE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_COR_AUTHORITY_FILE);
                entity.M_ATT_FUND_SOURCE_CERTIFY_FILE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_FUND_SOURCE_CERTIFY_FILE);
            }
            #endregion
            return entity;
        }


        public TENDER_PROJECT FindTenderProjectByTenderProjectCode(string tenderProjectCode)
        {
            return FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == tenderProjectCode);
        }

        /// <summary>
        /// 站点选择插件（招标项目）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageTable(TENDER_PROJECT model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.IS_TO_LAW ==1);
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDERER_NAME.Contain(model.TENDERER_NAME));
            }

            if (!string.IsNullOrWhiteSpace(search.KeyWord))//闽政通 只有一个查询条件 使用关键字
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(search.KeyWord)
                || TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(search.KeyWord)
                || TENDER_PROJECT._.TENDERER_NAME.Contain(search.KeyWord));
            }

            var query = FromWhere(condition.ToWhereClip());
          
            var count = query.Count();
            var pageList = query
                .LeftJoin<SYS_AREA_QUANGUO>(TENDER_PROJECT._.REGION_CODE == SYS_AREA_QUANGUO._.AREACODE)
                .OrderBy(TENDER_PROJECT._.M_ID)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    TENDER_PROJECT._.M_ID,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    TENDER_PROJECT._.TENDERER_NAME,
                    SYS_AREA_QUANGUO._.AREANAME,
                    SYS_AREA_QUANGUO._.AREACODE,
                    TENDER_PROJECT._.DATA_TIMESTAMP
                ).ToList<object>()
                .ToPageTableResult(search, count);
            return pageList;

        }

        #region 处长门户 项目监督 处理项目及事项 详情 项目基础信息

        public ProjectSupervisionBaseInfoResponseModel HyProjectDetailModel(string tenderProjectCodeOld1)
        {
            var tmp = Fw.TenderFileClariModiService
                .FromWhere(TENDER_FILE_CLARI_MODI._.BID_OPEN_TIME < DateTime.Now )
                .GroupBy(TENDER_FILE_CLARI_MODI._.TENDER_PROJECT_CODE,
                    TENDER_FILE_CLARI_MODI._.BID_SECTION_CODE)
                .Select(TENDER_FILE_CLARI_MODI._.TENDER_PROJECT_CODE, TENDER_FILE_CLARI_MODI._.BID_SECTION_CODE,
                    new Field("MAX(CASE WHEN IS_POSTPONE='1' THEN POST_OPEN_TIME ELSE BID_OPEN_TIME END)").As(
                        "BID_OPEN_TIME"));
            var dbModel = FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == tenderProjectCodeOld1)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == TENDER_PROJECT._.PLATFORM_CODE)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                .Select(
                    TENDER_PROJECT._.M_ID,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE.As("PROJECT_CODE"),
                    TENDER_PROJECT._.TENDER_PROJECT_NAME.As("PROJECT_NAME"),
                    TENDER_PROJECT._.TENDER_AGENCY_NAME.As("AGENCY_NAME"),
                    SYS_AREA_QUANGUO._.AREANAME,
                    TENDER_PROJECT._.CREATE_TIME,
                    TENDER_PROJECT._.OWNER_NAME,
                    TENDER_PROJECT._.REGION_CODE,
                    TENDER_PROJECT._.PLATFORM_CODE,
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME
                    )
                .AddSelect(Fw.TenderAnnQuaInqueryAnnService.FromWhere(
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE.In(1, 2) &&
                    TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE == '1' && TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == '2' &&
                    TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE).Select(TENDER_ANN_QUA_INQUERY_ANN._.All.Count()),"ZBGG")//招标公告
                .AddSelect(Fw.TenderListService
                    .FromWhere(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .InnerJoinTmp<TENDER_FILE_CLARI_MODI>(tmp,
                        TENDER_FILE_CLARI_MODI._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE &&
                        TENDER_FILE_CLARI_MODI._.BID_SECTION_CODE == TENDER_LIST._.BID_SECTION_CODE)
                    .GroupBy(TENDER_LIST._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.TENDER_PROJECT_CODE.Count()),"TBBM")//投标报名
                .AddSelect(Fw.BidOpeningRecordService.FromWhere(BID_OPENING_RECORD._.TENDER_PROJECT_CODE==TENDER_PROJECT._.TENDER_PROJECT_CODE).Select(BID_OPENING_RECORD._.All.Count()),"KB")//开标
                .AddSelect(Fw.EvaluationReportService.FromWhere(EVALUATION_REPORT._.TENDER_PROJECT_CODE==TENDER_PROJECT._.TENDER_PROJECT_CODE).Select(EVALUATION_REPORT._.All.Count()),"PB")//评标
                .AddSelect(Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE==TENDER_PROJECT._.TENDER_PROJECT_CODE&&WIN_RESULT_ANNO._.BULLETIN_TYPE=='3'&&WIN_RESULT_ANNO._.M_STATUS=='2').Select(WIN_RESULT_ANNO._.All.Count()),"JGGG")//结果公告
                .AddSelect(Fw.TenderCandidateAnnounceService.FromWhere(TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE &&  TENDER_CANDIDATE_ANNOUNCE._.M_STATUS == '2').Select(TENDER_CANDIDATE_ANNOUNCE._.All.Count()), "ZBHXR")//中标候选人
                .ToFirst<ProjectSupervisionBaseInfoResponseModel>();
            //if (dbModel != null)
            //{
            //    dbModel.ZBGG = Fw.TenderAnnQuaInqueryAnnService.Count(
            //        TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE.In(1, 2) &&
            //        TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE == '1' && TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == '2' &&
            //        TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == dbModel.PROJECT_CODE);
            //    if (dbModel.ZBGG>0)
            //    {
                  
            //        dbModel.TBBM = Fw.TenderListService
            //            .FromWhere(TENDER_LIST._.TENDER_PROJECT_CODE == dbModel.PROJECT_CODE)
            //            .InnerJoinTmp<TENDER_FILE_CLARI_MODI>(tmp,
            //                TENDER_FILE_CLARI_MODI._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE &&
            //                TENDER_FILE_CLARI_MODI._.BID_SECTION_CODE == TENDER_LIST._.BID_SECTION_CODE)
            //            .GroupBy(TENDER_LIST._.TENDER_PROJECT_CODE)
            //            .Select(TENDER_LIST._.TENDER_PROJECT_CODE).Count();

            //    }
            //}
            return dbModel;
        }

        #endregion


        #region   公安厅外网系统

        /// <summary>
        /// 公安厅外网
        /// 项目查询模块
        /// </summary>
        /// <param name="search"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public PageTableResult PageList(SearchCondition search, WhereClip condition)
        {
            var query = FromWhere(condition);
            var count = query.Count();
            var pageList = query
                .LeftJoin<SYS_AREA_QUANGUO>(TENDER_PROJECT._.REGION_CODE == SYS_AREA_QUANGUO._.AREACODE)
                .OrderBy(TENDER_PROJECT._.CREATE_TIME.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    TENDER_PROJECT._.M_ID,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    TENDER_PROJECT._.TENDERER_NAME,
                    TENDER_PROJECT._.TENDER_AGENCY_NAME,
                    TENDER_PROJECT._.APPROVE_DEPT_NAME,
                    SYS_AREA_QUANGUO._.AREANAME,
                    TENDER_PROJECT._.CREATE_TIME

                ).ToList<dynamic>().ToPageTableResult(search, count);
            return pageList;
        }
        /// <summary>
        /// 公安外网-项目信息-项目关键信息模块
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public List<dynamic> Collection(string tender_project_code)
        {
            var project = FromWhere<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code)
                .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_AREA_QUANGUO>(TENDER_PROJECT._.REGION_CODE== SYS_AREA_QUANGUO._.AREACODE)
                .Select(
                TENDER_PROJECT._.PROJECT_CODE,
                TENDER_PROJECT._.TENDER_PROJECT_CODE,
                TENDER_PROJECT._.TENDER_PROJECT_NAME,
                TENDER_PROJECT._.CREATE_TIME,
                SYS_AREA_QUANGUO._.AREANAME,
                TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                TENDER_PROJECT._.SUPERVISE_DEPT_NAME,
                TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_BID_NUM,
                TENDER_ANN_QUA_INQUERY_ANN._.BID_SECTION_CODES,
                TENDER_ANN_QUA_INQUERY_ANN._.TRAD_CENTER_NAME,
                TENDER_ANN_QUA_INQUERY_ANN._.UNIFIED_DEAL_CODES,
                TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_NAME,
                TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_CODE,
                TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_ADDRESS
                ).ToList<dynamic>();
            return project;
        }
        #endregion

    }
}