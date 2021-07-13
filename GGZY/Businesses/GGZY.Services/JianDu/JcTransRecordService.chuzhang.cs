using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using GGZY.Services.Infrastructure.Model.JianDu;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 处长门户|闽政通相关接口
    /// </summary>
    public partial class JcTransRecordService
    {
        /// <summary>
        /// 闽政通 项目监督 纪委监委 移送 项目 主体 人员 其他 结果 接口
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GeneralResult TransRecordDetail(string id)
        {
            var r = new GeneralResult();
            var record = Jd.JcTransRecordService.FromWhere(JC_TRANS_RECORD._.ID == id).ToFirst<JdJcTransRecordModel>();
            if (record != null)
            {
                record.RECORD_ATTACHMENTS = Jd.CommonService.Attachments(record.ATTACHMENT_IDS, "Sys",true);
                record.PROJECT =
                    Jd.JcTransProjectService.FirstOrNull(JC_TRANS_PROJECT._.RECORD_ID == id &&
                                                         JC_TRANS_PROJECT._.IS_DELETE != 1);
                record.ENTITY =
                    Jd.JcTransEntityService.FirstOrNull(JC_TRANS_ENTITY._.RECORD_ID == id &&
                                                        JC_TRANS_ENTITY._.IS_DELETE != 1);
                record.PERSON =
                    Jd.JcTransPersonService.FirstOrNull(JC_TRANS_PERSON._.RECORD_ID == id &&
                                                        JC_TRANS_PERSON._.IS_DELETE != 1);
               record.DETAIL =
                    Jd.JcTransDetailService.FirstOrNull(JC_TRANS_DETAIL._.RECORD_ID == id &&
                                                        JC_TRANS_DETAIL._.IS_DELETE != 1);
               record.RESULTS =
                   Jd.JcTransResultService.FromWhere(JC_TRANS_RESULT._.RECORD_ID == id&&JC_TRANS_RESULT._.IS_DELETE != 1)
                       //.LeftJoin<T_USER>(JC_TRANS_RESULT._.SEBDER_ID==T_USER._.ID)
                       //.LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID== T_USER._.DEPARTID)
                       .OrderBy(JC_TRANS_RESULT._.SUBMIT_TIME.Desc)
                       .Select(
                           //T_USER._.MANAGE_NAME.As("SEBDER"),
                           //T_USER_DEPARTMENT._.DNAME.As("SEBDER_UNIT"),
                           JC_TRANS_RESULT._.All
                           )
                       .ToList<JdJcTransResultModel>();
               if (record.RESULTS.Any())
               {
                   record.RESULTS.ForEach(o =>
                   {
                      o.RESULT_ATTACHMENTS= Jd.CommonService.Attachments(o.ATTACHMENTS, "Sys",true);
                   });
               }
               r.SetSuccess(record);
            }
            else
            {
                r.SetFail("未找到对应的移送信息");
            }
            return r;
        }
    }
}
