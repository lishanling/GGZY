using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.JianDu.Controllers
{
    /// <summary>
    /// 监察子系统-移送记录
    /// </summary>
    public class TransRecordController : BaseController
    {
        // GET: TransRecord
        public ActionResult List(Trans_Record_Request request,SearchCondition search)
        {
            GeneralResult r = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(JC_TRANS_RECORD._.IS_DELETE !=1);

            if(request.Request_Type ==0)
            {
                condition.And(JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.UserDepartment.DEPID);
            }
            else
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNITID == JdUser?.UserDepartment.DEPID);
            }
            if(! String.IsNullOrWhiteSpace(request.Trans_Code))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_CODE == request.Trans_Code);
            }
            if (!String.IsNullOrWhiteSpace(request.Title))
            {
                condition.And(JC_TRANS_RECORD._.TITLE.Contain(request.Trans_Code));
            }
            if (request.Begin_Time.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME >= request.Begin_Time);
            }
            if (request.End_Time.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME <= request.End_Time);
            }
            if (request.Trans_Type.HasValue && request.Trans_Type.Value >0)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TYPE > request.Trans_Type);
            }
            if (request.Has_Result.HasValue && (request.Has_Result == 0 || request.Has_Result ==1))
            {
                condition.And(JC_TRANS_RECORD._.HAS_RESULT == request.Has_Result);
            }
            var result = Jd.JcTransRecordService.PageList(search,condition.ToWhereClip());
            r.SetSuccess(result);
            return JResult(r);
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Detail(string id)
        {
            GeneralResult r = new GeneralResult();
            var record = Jd.JcTransRecordService.Detail(id);
            if(null == record)
            {
                r.SetFail("记录信息不存在");
                return JResult(r);
            }
            var record_data = new
            {
                ID = record.ID,
                TRANS_CODE = record.TRANS_CODE,
                TITLE = record.TITLE,
                CONTENT = record.CONTENT,
                RECEIVER = record.RECEIVER,
                RECEIVER_PHONE = record.RECEIVER_PHONE,
                TRANS_TIME = record.TRANS_TIME,
                TRANS_TYPE = record.TRANS_TYPE,
                TRANS_USER = record.TRANS_USER,
                ATTACHMENT_IDS = record.ATTACHMENT_IDS,
                TRANS_USER_ID = record.TRANS_USER_ID,
                RECEIVER_UNIT_ID = record.RECEIVER_UNIT_ID,
                RECEIVER_ID = record.RECEIVER_ID,
                DATA_TIMESTAMP = record.DATA_TIMESTAMP,
                TRANS_UNIT = record.TRANS_UNIT,
                TRANS_UNITID = record.TRANS_UNITID,
                HAS_RESULT = record.HAS_RESULT,
                TRANS_USER_PHONE =record.TRANS_USER_PHONE,
                ATTACHMENTS = String.IsNullOrWhiteSpace(record.ATTACHMENT_IDS) ? new List<GGZY.Core.Models.UploadResData>() :
                Jd.SysAttachmentService.FindAttachment(record.ATTACHMENT_IDS, aid => CommonAttachmentBuilder(aid, "Jd", "Sys"))
            };

            var history = Jd.JcTransResultService.Collection(id, aid => CommonAttachmentBuilder(aid, "Jd", "Sys"));
            
            if (record?.TRANS_TYPE == 1)
            {
                var project = Jd.JcTransProjectService.FirstOrNull<JC_TRANS_PROJECT>(JC_TRANS_PROJECT._.RECORD_ID == id);
                var detail = Jd.JcTransDetailService.FindList(JC_TRANS_DETAIL._.RECORD_ID == id);
                r.SetSuccess(new
                {
                    Record = record_data,
                    BaseInfo = project,
                    Detail = detail,
                    Result = history
                });
            }

            if (record?.TRANS_TYPE == 2)
            {
                var entity = Jd.JcTransEntityService.FirstOrNull<JC_TRANS_ENTITY>(JC_TRANS_ENTITY._.RECORD_ID == id);
                var detail = Jd.JcTransDetailService.FindList(JC_TRANS_DETAIL._.RECORD_ID == id);
                r.SetSuccess(new
                {
                    Record = record_data,
                    BaseInfo = entity,
                    Detail = detail,
                    Result = history
                });
            }
            if (record?.TRANS_TYPE == 3)
            {
                var person = Jd.JcTransPersonService.FirstOrNull(JC_TRANS_PERSON._.RECORD_ID == id);
                r.SetSuccess(new
                {
                    Record = record_data,
                    BaseInfo = person,
                    Result = history
                });
            }

            if (record?.TRANS_TYPE == 9)
            {
                r.SetSuccess(new
                {
                    Record = record_data,
                    Result = history
                });
            }
            return JResult(r);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(string id)
        {
            GeneralResult r = new GeneralResult();
            var record = Jd.JcTransRecordService.Detail(id);
            if (null == record || record.IS_DELETE ==1)
            {
                r.SetFail("记录信息不存在");
                return JResult(r);
            }
            record.Attach();
            record.IS_DELETE = 1;
            Jd.JcTransRecordService.Update<JC_TRANS_RECORD>(record);
            r.SetSuccess();
            return JResult(r);
        }

        public ActionResult Export(List<string> record_ids,
            Trans_Record_Request request, SearchCondition search)
        {
            GeneralResult r = new GeneralResult();

            if(record_ids != null && record_ids.Any())
            {
                 r = Jd.JcTransRecordService.Export(record_ids);
                return JResult(r);
            }

            var condition = new WhereClipBuilder();
            condition.And(JC_TRANS_RECORD._.IS_DELETE != 1);

            if (request.Request_Type == 0)
            {
                condition.And(JC_TRANS_RECORD._.RECEIVER_UNIT_ID == JdUser?.UserDepartment.DEPID);
            }
            else
            {
                condition.And(JC_TRANS_RECORD._.TRANS_UNITID == JdUser?.UserDepartment.DEPID);
            }
            if (!String.IsNullOrWhiteSpace(request.Trans_Code))
            {
                condition.And(JC_TRANS_RECORD._.TRANS_CODE == request.Trans_Code);
            }
            if (!String.IsNullOrWhiteSpace(request.Title))
            {
                condition.And(JC_TRANS_RECORD._.TITLE.Contain(request.Trans_Code));
            }
            if (request.Begin_Time.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME >= request.Begin_Time);
            }
            if (request.End_Time.HasValue)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TIME <= request.End_Time);
            }
            if (request.Trans_Type.HasValue && request.Trans_Type.Value > 0)
            {
                condition.And(JC_TRANS_RECORD._.TRANS_TYPE > request.Trans_Type);
            }
            if (request.Has_Result.HasValue && (request.Has_Result == 0 || request.Has_Result == 1))
            {
                condition.And(JC_TRANS_RECORD._.HAS_RESULT == request.Has_Result);
            }
            r = Jd.JcTransRecordService.Export(new List<string>(),condition.ToWhereClip());
            return JResult(r);

        }

        public class Trans_Record_Request
        {
            /// <summary>
            ///  0：收到的 1:发出的
            /// </summary>
            public int Request_Type { get; set; }

            public string Title { get; set; }

            public string Trans_Code { get; set; }

            public int? Trans_Unit_Id { get; set; }

            public DateTime? Begin_Time { get; set; }

            public DateTime? End_Time { get; set; }

            public int? Trans_Type { get; set; }

            public int? Has_Result { get; set; }
        }
    }
}