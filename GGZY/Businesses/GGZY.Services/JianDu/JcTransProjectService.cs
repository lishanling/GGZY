using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JcTransProjectService
    {

        public List<dynamic> Collection(string tender_project_code)
        {
            var info = Fw.TenderProjectService.FromWhere()
             .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
             .LeftJoin<TENDER_CANDIDATE_ANNOUNCE>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE)
             .LeftJoin<WIN_RESULT_ANNO>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
             .Where(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code)
             .Select(
             //公告开始时间
             TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
             //公告截止时间
             TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
             //招标文件/资格预审文件获取时开始间
             TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_START_TIME,
              //招标文件/资格预审文件获取截至时间
              TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME,
              //开标时间
              TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
              //投标截止时间
              TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME,
               //保证金缴纳开始时间
               TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
               //候选人公示开始时间
               TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_START_TIME,
               //候选人公示结束时间
               TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_END_TIME,
               //结果公示开始时间
               WIN_RESULT_ANNO._.NOTICE_SEND_TIME.As("WIN_NOTICE_SEND_TIME")
             ).ToList<dynamic>();
            return info;

            // var records = Fw.TenderProjectService.FindList(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            //var project = FromWhere<JC_TRANS_PROJECT>(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == tender_project_code)
            //            .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
            //            .LeftJoin<TENDER_CANDIDATE_ANNOUNCE>(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE)
            //            .LeftJoin<WIN_RESULT_ANNO>(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
            //            .Select(
            //                JC_TRANS_PROJECT._.ID,
            //                JC_TRANS_PROJECT._.TENDER_PROJECT_NAME,
            //                JC_TRANS_PROJECT._.TENDER_PROJECT_CODE,
            //                JC_TRANS_PROJECT._.TENDER_NAME,
            //                JC_TRANS_PROJECT._.TENDER_CONTRACT,
            //                JC_TRANS_PROJECT._.TENDER_AGENCY_NAME,
            //                JC_TRANS_PROJECT._.TENDER_ANENCY_CODE,
            //                JC_TRANS_PROJECT._.RECORD_ID,
            //               //公告开始时间
            //               TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
            //               //公告截止时间
            //               TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
            //               //招标文件/资格预审文件获取时开始间
            //               TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_START_TIME,
            //                //招标文件/资格预审文件获取截至时间
            //                TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME,
            //                //开标时间
            //                TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
            //                //投标截止时间
            //                TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME,
            //                 //保证金缴纳开始时间
            //                 TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
            //                 //候选人公示开始时间
            //                 TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_START_TIME,
            //                 //候选人公示结束时间
            //                 TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_END_TIME,
            //                 //结果公示开始时间
            //                 WIN_RESULT_ANNO._.NOTICE_SEND_TIME
            //            ).ToList<dynamic>()
            //            .Select(w => new
            //            {
            //                ID = JC_TRANS_PROJECT._.ID,
            //                TENDER_PROJECT_NAME = JC_TRANS_PROJECT._.TENDER_PROJECT_NAME,
            //                TENDER_PROJECT_CODE = JC_TRANS_PROJECT._.TENDER_PROJECT_CODE,
            //                TENDER_NAME = JC_TRANS_PROJECT._.TENDER_NAME,
            //                TENDER_CONTRACT = JC_TRANS_PROJECT._.TENDER_CONTRACT,
            //                TENDER_AGENCY_NAME = JC_TRANS_PROJECT._.TENDER_AGENCY_NAME,
            //                TENDER_ANENCY_CODE = JC_TRANS_PROJECT._.TENDER_ANENCY_CODE,
            //                RECORD_ID = JC_TRANS_PROJECT._.RECORD_ID,
            //                //公告开始时间
            //                NOTICE_START_TIME = TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
            //                //公告截止时间
            //                NOTICE_END_TIME = TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
            //                //招标文件/资格预审文件获取时开始间
            //                DOC_GET_START_TIME = TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_START_TIME,
            //                //招标文件/资格预审文件获取截至时间
            //                DOC_GET_END_TIME = TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME,
            //                //开标时间
            //                BID_OPEN_TIME = TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
            //                //投标截止时间
            //                BID_DOC_REFER_END_TIME = TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME,
            //                //保证金缴纳截止时间
            //                MARGIN_RECEIVE_END_TIME = TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME,
            //                //候选人公示开始时间
            //                PUBLICITY_START_TIME = TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_START_TIME,
            //                //候选人公示结束时间
            //                PUBLICITY_END_TIME = TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_END_TIME,
            //                //结果公示开始时间
            //                NOTICE_SEND_TIME = WIN_RESULT_ANNO._.NOTICE_SEND_TIME
            //            }).ToList<dynamic>();



        }
        public List<dynamic> Collections(string tender_project_code)
        {
            var records = Jd.JcTransProjectService.FindList(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            return records.Select(t => new
            {
                TENDER_PROJECT_CODE= t.TENDER_PROJECT_CODE,
                TENDER_PROJECT_NAME = t.TENDER_PROJECT_NAME,
                TENDER_NAME=t.TENDER_NAME,
                TENDER_ANENCY_CODE=t.TENDER_ANENCY_CODE,
                TENDER_AGENCY_NAME=t.TENDER_AGENCY_NAME
            }).ToList<dynamic>();
        }
    }
}