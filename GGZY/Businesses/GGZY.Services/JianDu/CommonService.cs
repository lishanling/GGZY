using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using GGZY.Core.Utils;
using GGZY.Services.Extensions;

namespace GGZY.Services.JianDu
{
    public partial class CommonService : BaseServiceT<JdEntity>
    {
        public string Attachment(string id, string type = "")
        {
            return Attachments(id, type,false).FirstOrDefault()?.FullUrl;
        }
        public DateTime GetDBDateTime()
        {
            return FromSql("select sysdate from dual").First<DateTime>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="urlBuilder">是否构建附件访问地址 </param>
        /// <returns></returns>
        public List<UploadResData> Attachments(string id, string type = "Sys",bool urlBuilder=true)
        {
            var ls = new List<UploadResData>();
            if (!string.IsNullOrWhiteSpace(id))
            {
                var ids = id.Split(new []{',' }, StringSplitOptions.RemoveEmptyEntries).Select(c => c.Split('.').FirstOrDefault()).ToArray();
                if (ids.Any())
                {
                    if (string.Compare(type, "sys", StringComparison.CurrentCultureIgnoreCase) == 0)
                    {
                        ls = Jd.SysAttachmentService.FindSysAttachments(urlBuilder,ids);
                    }
                    else
                    {
                        ls = Jd.TAttachmentService.FindList(T_ATTACHMENT._.ID.In(ids))
                            .FindAll(c => File.Exists(HttpContext.Current.Server.MapPath($"~/file/{c.ATTACHMENT_FILE_NAME}")))
                            .Select(c =>
                            {
                                var path = HttpContext.Current?.Server.MapPath($"~/file/{c.ATTACHMENT_FILE_NAME}");
                                if (!string.IsNullOrWhiteSpace(path) && !path.StartsWith("http"))
                                {
                                    path = CommonAttachmentBuilder(c.GUID, "Jd", type);// attachmentFun.Invoke(type, c.GUID);
                                }
                                var res = new UploadResData
                                {
                                    Id = c.ID?.ToString(),
                                    new_id = c.ID?.ToString(),
                                    FullUrl = path,
                                    Md5 = c.MD5,
                                    Url = c.ATTACHMENT_FILE_NAME,
                                    Name = c.ATTACHMENT_NAME,
                                    FileType = c.ATTACHMENT_TYPE,
                                };
                                return res;

                            }).ToList();

                    }
                }
            }

            return ls;
        }

        



    }
}