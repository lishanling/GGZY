using GGZY.Core.Models;
using GGZY.Services.Extensions;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GGZY.Services.FuWu
{
    public partial class SysAttachmentService 
    {
        /// <summary>
        /// 获取附件对象
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public List<UploadResData> FindAttachment(object aids, Func<string, string> urlBuilder)
        {
            var list = new List<UploadResData>();
            if (aids != null)
            {
                var attachments = FindList<SYS_ATTACHMENT>(SYS_ATTACHMENT._.FILEPATH.In(aids.ToString().Split(',')));
                if (attachments.Any())
                {
                    list = attachments.Distinct(new FwSysAttachmentComparer()).Select(c =>
                    {
                        var name = $"{c.FILETILE}";
                        if (!c.FILETILE.Contains("."))
                        {
                            name = $"{c.FILETILE}{c.FILETYPE}";
                        }

                        var url = urlBuilder.Invoke(c.AID.ToString());
                        return new UploadResData
                        {
                            Id = c.AID?.ToString(),
                            new_id = "",
                            Url = url,
                            Name = name,
                            Md5 = "",
                            FullUrl = url
                        };
                    }).ToList();
                }
            }
            return list;
        }
    }
}