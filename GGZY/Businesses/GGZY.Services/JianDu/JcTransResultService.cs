using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.JianDu
{
    public partial class JcTransResultService
    {
        /// <summary>
        /// 移送记录id
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public List<dynamic> Collection(string record_id, Func<string, string> urlBuilder)
        {
            var records =Jd.JcTransResultService.FindList(JC_TRANS_RESULT._.RECORD_ID == record_id,
                JC_TRANS_RESULT._.SUBMIT_TIME.Desc);
            return records.Select(t => new {
                ID = t.ID,
                RECORD_ID = t.RECORD_ID,
                F_RECORD_ID = t.F_RECORD_ID,
                RESULT_MSG = t.RESULT_MSG,
                SENDER = t.SENDER,
                SENDER_UNIT = t.SENDER_UNIT,
                SEBDER_ID = t.SEBDER_ID,
                SENDER_UNIT_ID = t.SENDER_UNIT_ID,
                SUBMIT_TIME = t.SUBMIT_TIME,
                DATA_TIMESTAMP = t.DATA_TIMESTAMP,
                ATTACHMENTS = String.IsNullOrEmpty(t.ATTACHMENTS)?new List<GGZY.Core.Models.UploadResData>()
                :Jd.SysAttachmentService.FindAttachment(t.ATTACHMENTS,urlBuilder)
            }).ToList<dynamic>();
        }

        /// <summary>
        /// 添加移送处理结果
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public GeneralResult Submit(JC_TRANS_RECORD record,JC_TRANS_RESULT entity, List<UploadResData> attachments)
        {
            GeneralResult r = new GeneralResult();
            List<SYS_ATTACHMENT> files = new List<SYS_ATTACHMENT>();
            List<string> attachment_ids = new List<string>();

            if (attachments != null)
            {
                attachments.ForEach(e =>
                {
                    attachment_ids.Add(e.Id);
                    files.Add(e.JdSysAttachment(JdUser?.ID));
                });
            }

            var db = GetDbSession();
            var now = GetDBTime();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    record.Attach();
                    record.HAS_RESULT = 1;
                    tran.Update(record);

                    entity.ID = Guid.NewGuid().ToString().ToLower();
                    entity.ATTACHMENTS = String.Join(",", attachment_ids);
                    entity.SUBMIT_TIME = now;
                    tran.Insert(entity);

                    files.ForEach(e =>
                    {
                        tran.Insert<SYS_ATTACHMENT>(e);
                    });
                    tran.Commit();
                    r.SetSuccess();
                    return r;
                }
                catch(Exception ex)
                {
                    Logger.Error("添加移送处理结果失败:"+ex.Message,ex);
                    tran.Rollback();
                    r.SetFail("添加移送处理结果失败：服务器异常");
                    return r;
                }
            }
        }
    }
}
