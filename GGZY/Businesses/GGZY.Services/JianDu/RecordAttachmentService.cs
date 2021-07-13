using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.JianDu
{
    public partial class RecordAttachmentService 
    {
        //
        //TODO:涉及多标段业务，逻辑较为复杂，等待重构
        //

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="RECORD_ID">Record_review id</param>
        /// <param name="data">附件信息 UploadResData_ReviewRequest</param>
        /// <param name="bid_section_code">标段包编号</param>
        public void Insert(DbTrans tran, decimal? RECORD_ID, List<UploadResData_ReviewRequest> data,string bid_section_code="")
        {
            var uid = Identity?.JdUser()?.ID;
            if (null !=data && data.Any())
            {
                string IsUseDoc = ",MT101_F07,MT102_F01,MZ101_F07,MZ102_F01,";

                data.ForEach(attr => {
                    var type_code = attr.TYPE;
                    var attachment = attr.ATTACHMENTS;

                    RECORD_ATTACHMENT record = new RECORD_ATTACHMENT();
                    record.RECORD_ID = RECORD_ID;
                    record.ATTFILE_TYPENAME = attr.TITLE;
                    record.DESCRIPTION = attr.DESCRIPTION;
                    record.IS_INTACT = attr.IS_INTACT;
                    record.CATEGORY = attr.CATEGORY;
                    record.GUIDS = (null==attachment || ! attachment.Any())? "": String.Join(",", attachment.Select(t => t.Id));
                    record.ATTFILE_TYPECODE = type_code;
                    record.BID_SECTION_CODE = bid_section_code;
                    record.ID = tran.Insert<RECORD_ATTACHMENT>(record);

                    if (null != attachment && attachment.Any())
                    {
                        attachment.ForEach(e =>
                        {
                            var sys_attachment = e.JdSysAttachment(uid);
                            sys_attachment.AOBJTYPE = "FC";
                            tran.Insert<SYS_ATTACHMENT>(sys_attachment);
                        });
                    }

                    if(IsUseDoc.Contains("," + type_code + ","))
                    {
                        var guids = record.GUIDS.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        if (guids.Any())
                        {
                            tran.FromSql("UPDATE TENDER_DOC_TRANS_LOG  SET IS_USE=1 WHERE GUID in(" + JsonConvert.SerializeObject(guids).Replace("[", "").Replace("]", "").Replace("\"", "'") + ")").ToScalar();
                        }
                    }
                });
            }
            return;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="RECORD_ID"></param>
        /// <param name="attachments"></param>
        public void Update(DbTrans tran, decimal? RECORD_ID, List<UploadResData_ReviewRequest> data, string bid_section_code = "")
        {
            var uid = Identity?.JdUser()?.ID;
            if (!data.Any())
            {
                return;
            }
            string IsUseDoc = ",MT101_F07,MT102_F01,MZ101_F07,MZ102_F01,";
            List<string> guids = new List<string>();
            data.ForEach(attr =>
            {
                var attachment = new List<UploadResData>();
                var type_code = attr.TYPE;
                var ids = new List<string>();
                if (attr.ATTACHMENTS != null && attr.ATTACHMENTS.Any())
                {
                    ids = attr.ATTACHMENTS.Select(t => t.Id).ToList();
                    attachment = attr.ATTACHMENTS;
                    guids.AddRange(ids);
                }

                var condition = new WhereClipBuilder();
                condition.And(RECORD_ATTACHMENT._.ATTFILE_TYPECODE == type_code &&
                            RECORD_ATTACHMENT._.RECORD_ID == RECORD_ID);
                if (!String.IsNullOrWhiteSpace(bid_section_code))
                {
                    condition.And(RECORD_ATTACHMENT._.BID_SECTION_CODE == bid_section_code);
                }
                var record_attachment = FirstOrNull<RECORD_ATTACHMENT>(condition.ToWhereClip());
                if(record_attachment == null)
                {
                    Insert(tran, RECORD_ID, data.Where(w => w.TYPE == attr.TYPE).ToList(), bid_section_code);
                    return;
                }
                if (true)
                {
                    var atta_ids = new List<string>();
                    if (!String.IsNullOrWhiteSpace(record_attachment.GUIDS))
                    {
                        atta_ids = record_attachment.GUIDS.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    }

                    if (IsUseDoc.Contains("," + type_code + ",") && atta_ids.Any())
                    {

                        var sqlwhere = JsonConvert.SerializeObject(atta_ids).Replace("[", "").Replace("]", "").Replace("\"","'");
                        tran.FromSql("UPDATE TENDER_DOC_TRANS_LOG  SET IS_USE=1 WHERE GUID in(" + sqlwhere + ")").ToScalar();
                        tran.FromSql("UPDATE TENDER_DOC_TRANS_LOG  SET IS_USE=0 WHERE RECORD_ID = " + RECORD_ID + " AND GUID not in(" + sqlwhere + ")").ToScalar();
                    }

                    attachment.ForEach(e =>
                    {
                        if (atta_ids.Contains(e.Id))
                        {
                            return;
                        }
                        var sys_attachment = e.JdSysAttachment(uid);
                        sys_attachment.AOBJTYPE = "FC";
                        tran.Insert<SYS_ATTACHMENT>(sys_attachment);
                    });
                    record_attachment.Attach();
                    record_attachment.ATTFILE_TYPENAME = attr.TITLE;
                    record_attachment.DESCRIPTION = attr.DESCRIPTION;
                    record_attachment.BID_SECTION_CODE = bid_section_code;
                    record_attachment.IS_INTACT = attr.IS_INTACT;
                    record_attachment.CATEGORY = attr.CATEGORY;
                    record_attachment.GUIDS = String.Join(",", ids);
                    tran.Update<RECORD_ATTACHMENT>(record_attachment);
                }
            });

        }
    }
}