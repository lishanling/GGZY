using System;
using System.Collections.Generic;
using System.Data;
using GGZY.Core.Models;

namespace GGZY.Services.FuWu
{
    public partial class SectionService
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 标段信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="attachmentFunc">门户网站不展示附件null 后台展示附件 </param>
        /// <returns></returns>
        public List<dynamic> JD_GCJS_XMJC_SectionInfo(string projectCode, Func<string, List<UploadResData>> attachmentFunc = null)
        {
            var entities = FromSql(@"
                SELECT T.BID_SECTION_CODE,
                       T.BID_SECTION_NAME,
                       T2.TEXT AS TENDER_PROJECT_CLASSIFY,
                       T.BID_SECTION_CONTENT,
                       T.BID_QUALIFICATION,
                       (CASE
                         WHEN T.PRICE_UNIT = '0' THEN T.CONTRACT_RECKON_PRICE / 10000
                         ELSE T.CONTRACT_RECKON_PRICE
                       END) AS CONTRACT_RECKON_PRICE,
                       T.BEGIN_DATE,
                       T.LIMITE_TIME,
                       T.M_ATT_TENDER_FILE,
                       T.M_ATT_TENDER_FILE_ATTACHS,
                       T.M_ATT_TENDER_AGENT_CONTRACT,
                       T.M_ATT_INVITE_DOC,
                       T.M_ATT_PUBLICITY_DOC,
                       T.M_ATT_PUBLICITY_DOC_SIGN,
                       T.M_ATT_WIN_BID_NOTICE,
                       T.M_ATT_WIN_BID_NOTICE_SIGN,
                       T.M_ATT_DISSENT_DOC,
                       T.M_ATT_CONTRACT_DOC,
                       T.M_ATT_QUALIFICATION_DOC
                  FROM SECTION T
                       LEFT JOIN SYS_DIC T2 ON TYPE = 5001 AND T.TENDER_PROJECT_CLASSIFY_CODE = T2.VALUE
                 WHERE T.TENDER_PROJECT_CODE =:tender_project_code")
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode).ToList<dynamic>();
            #region 监督平台后台 sType == "HT" && MemberUserInfo.UserID != -1

            if (attachmentFunc != null)
            {
                foreach (var entity in entities)
                {
                    entity.M_ATT_TENDER_FILE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_TENDER_FILE);
                    entity.M_ATT_TENDER_FILE_ATTACHS_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_TENDER_FILE_ATTACHS);
                    entity.M_ATT_TENDER_AGENT_CONTRACT_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_TENDER_AGENT_CONTRACT);
                    entity.M_ATT_INVITE_DOC_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_INVITE_DOC);
                    entity.M_ATT_PUBLICITY_DOC_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_PUBLICITY_DOC);
                    entity.M_ATT_PUBLICITY_DOC_SIGN_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_PUBLICITY_DOC_SIGN);
                    entity.M_ATT_WIN_BID_NOTICE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_WIN_BID_NOTICE);
                    entity.M_ATT_WIN_BID_NOTICE_SIGN_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_WIN_BID_NOTICE_SIGN);
                    entity.M_ATT_DISSENT_DOC_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_DISSENT_DOC);
                    entity.M_ATT_CONTRACT_DOC_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_CONTRACT_DOC);
                    entity.M_ATT_QUALIFICATION_DOC_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_QUALIFICATION_DOC);
                }
            }
            #endregion
            return entities;
        }
    }
}