using GGZY.BigData.GCJS.Models;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Extensions;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.BigData.GCJS.Controllers
{
    public class BdInquireRecordController : BaseController
    {
        

        public ActionResult Detail(string VIOLATION_RECORD_ID)
        {
            var data = Fw.BdInquireRecordService.Detail(VIOLATION_RECORD_ID, aid => CommonAttachmentBuilder(aid, "Fw", "Sys"));
            return JResult(data);
        }


        /// <summary>
        /// 添加处理结果记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public ActionResult Add(BD_INQUIRE_RECORD record, List<UploadResData> attachments)
        {
            var r = new GeneralResult();
            if(null == record)
            {
                r.SetFail("调查结果不能为空");
                return JResult(r);
            }

            List<SYS_ATTACHMENT> files = new List<SYS_ATTACHMENT>();
            if (attachments != null)
            {
                attachments.ForEach(e =>
                {
                    files.Add(e.FwSysAttachment(JdUser?.ID));
                });
            }
            record.ID = Guid.NewGuid().ToString().ToLower();
            record.OPERATION_USER = JdUser?.ID;
            record.OPERATION_DEPT = JdUser?.UserDepartment?.DEPID;
            record.OPERATION_TIME = DateTime.Now;
            r = Fw.BdInquireRecordService.Add(record, files);
            return JResult(r);
        }
    }
}