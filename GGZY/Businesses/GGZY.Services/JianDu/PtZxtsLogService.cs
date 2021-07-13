using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsLogService
    {
        /// <summary>
        /// 通过投诉ID查找投诉操作记录
        /// </summary>
        /// <param name="tsId"></param>
        /// <returns></returns>
        public List<PtZxtsLogModel> GetPtZxtsLogByTsId(decimal? tsId)
        {
            var list = FromWhere(PT_ZXTS_LOG._.TS_ID == tsId)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "75" && SYS_DIC._.VALUE == PT_ZXTS_LOG._.RECORDER_OPERATION)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS_LOG._.RECORDER_DEPID)
                .OrderBy(PT_ZXTS_LOG._.RECORDER_TM.Desc)
                .Select(PT_ZXTS_LOG._.All, SYS_DIC._.TEXT.As("RECORDER_OPERATION_TEXT"), T_USER_DEPARTMENT._.DNAME.As("RECORDER_DEPID_TEXT"))
                .ToList<PtZxtsLogModel>();
            foreach (var m in list)
            {
                m.RECORDER_AIDS_ATTACHMENTS = Jd.CommonService.Attachments(m.RECORDER_AIDS, "Sys",true);
            }
            return list;
        }
        /// <summary>
        /// 通过投诉编号查找投诉操作记录
        /// </summary>
        /// <param name="tsCode"></param>
        /// <returns></returns>
        public List<PtZxtsLogModel> GetPtZxtsLogByTsCode(string tsCode)
        {
            var list = FromWhere()
                .InnerJoin<PT_ZXTS>(PT_ZXTS._.ID == PT_ZXTS_LOG._.TS_ID && PT_ZXTS._.CODE == tsCode)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "75" && SYS_DIC._.VALUE == PT_ZXTS_LOG._.RECORDER_OPERATION)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS_LOG._.RECORDER_DEPID)
                .OrderBy(PT_ZXTS_LOG._.RECORDER_TM.Desc)
                .Select(PT_ZXTS_LOG._.All, SYS_DIC._.TEXT.As("RECORDER_OPERATION_TEXT"), T_USER_DEPARTMENT._.DNAME.As("RECORDER_DEPID_TEXT"))
                .ToList<PtZxtsLogModel>();
            return list;
        }
        /// <summary>
        /// 通过招标项目编号查找投诉操作记录
        /// </summary>
        /// <param name="tenderProjectCode">监督平台招标项目编号</param>
        /// <returns></returns>
        public List<PtZxtsLogModel> GetPtZxtsLogByTenderProjectCode(string tenderProjectCode)
        {
            var list = FromWhere()
                .InnerJoin<PT_ZXTS>(PT_ZXTS._.ID == PT_ZXTS_LOG._.TS_ID && PT_ZXTS._.TENDER_PROJECT_CODE == tenderProjectCode)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "75" && SYS_DIC._.VALUE == PT_ZXTS_LOG._.RECORDER_OPERATION)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS_LOG._.RECORDER_DEPID)
                .OrderBy(PT_ZXTS_LOG._.RECORDER_TM.Desc)
                .Select(PT_ZXTS_LOG._.All, SYS_DIC._.TEXT.As("RECORDER_OPERATION_TEXT"), T_USER_DEPARTMENT._.DNAME.As("RECORDER_DEPID_TEXT"))
                .ToList<PtZxtsLogModel>();
            foreach (var m in list)
            {
                m.RECORDER_AIDS_ATTACHMENTS = Jd.CommonService.Attachments(m.RECORDER_AIDS, "Sys", true);
            }
            return list;
        }
    }
}