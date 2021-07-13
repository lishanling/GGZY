using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.DZBH.ParamModel;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysAttachmentService
    {
        /// <summary>
        /// 获取当前最大
        /// </summary>
        /// <returns></returns>
        public int MaxOrderId()
        {
            var orderId = Max(SYS_ATTACHMENT._.ORDERID) + 1;
            return orderId;
        }
        /// <summary>
        /// 添加签章附件
        /// </summary>
        /// <param name="model">签章信息</param>
        /// <param name="data">附件上传信息</param>
        /// <param name="guid">附件上传信息</param>
        /// <returns></returns>
        public SYS_ATTACHMENT AddSignedAttachment(SignParamModel model, UploadResData data, string guid)
        {
            var maxOrderId = MaxOrderId();
            var uid = JdUser?.ID?.ToString();
            var attachment = new SYS_ATTACHMENT
            {
                AID = 0,
                GUID = guid,
                CREATEID = uid,
                CREATETIME = DateTime.Now,
                UPDATETIME = DateTime.Now,
                UPDATEID = uid,
                AOBJTYPE = SYS_ATTACHMENT.FILE_CENTER,
                FILEPATH = data.Url.Replace(ConfigHelper.AppSettings.UploadHost, ""),
                MD5 = data.Md5,
                FILETILE = data.Name.FileNameWithoutExtension(),
                FILETYPE = data.Name.Extension(),
                ORDERID = maxOrderId,
                CONVERTREMARK = "已签章",
                CONVERTDATETIME = DateTime.Now,
                //CONVERTSTATUS = 1,
                SIGN_INFO = new { model.pc_info, model.file_info, model.ca_info }.Serializer(),

            };
            Insert(attachment);
            //Cache.Set(guid, $"{ConfigHelper.AppSettings.UploadHost}{data.Url}", 60);
            return attachment;
        }
        /// <summary>
        /// 添加解密附件
        /// </summary>
        /// <param name="data">附件上传信息</param>
        /// <param name="model">附件上传信息</param>
        /// <returns></returns>
        public SYS_ATTACHMENT AddDecodeAttachment(UploadResData data, CaDecodeParamModel model)
        {
            var maxOrderId = MaxOrderId();
            var uid = JdUser?.ID?.ToString();
            var attachment = new SYS_ATTACHMENT
            {
                AID = 0,
                GUID = model.Guid,
                CREATEID = uid,
                CREATETIME = DateTime.Now,
                UPDATETIME = DateTime.Now,
                UPDATEID = uid,
                AOBJTYPE = SYS_ATTACHMENT.FILE_CENTER,
                FILEPATH = data.Url.Replace(ConfigHelper.AppSettings.UploadHost, ""),
                MD5 = data.Md5,
                FILETILE = data.Name.FileName(),
                FILETYPE = data.Name.ContentType(),
                ORDERID = maxOrderId,
                CONVERTREMARK = "已解密",
                CONVERTDATETIME = DateTime.Now,
                //CONVERTSTATUS = 1,
                SIGN_INFO = model.Info,

            };
            Insert(attachment);
            //Cache.Set(guid, $"{ConfigHelper.AppSettings.UploadHost}{data.Url}", 60);
            return attachment;
        }

        /// <summary>
        /// 查找已签名附件
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public SYS_ATTACHMENT FindAttachmentByGuid(string guid)
        {
            return FirstOrNull(SYS_ATTACHMENT._.GUID == guid);
        }
        /// <summary>
        /// 获取统一文件服务器文件
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public List<SYS_ATTACHMENT> FindFileCenterAttachmentsByGuids(string guid)
        {
            return FindAttachmentsByGuids(guid).FindAll(c => c.AOBJTYPE == SYS_ATTACHMENT.FILE_CENTER)
                .Select(c =>
                {
                    c.FILEPATH = $"{ConfigHelper.AppSettings.UploadHost}{c.FILEPATH}";
                    return c;
                }).ToList();
        }


        /// <summary>
        /// 获取统一文件服务器文件
        /// </summary>
        /// <param name="guid">guid 逗号分割</param>
        /// <returns></returns>
        public List<SYS_ATTACHMENT> FindAttachmentsByGuids(string guid)
        {
            if (!string.IsNullOrWhiteSpace(guid))
            {
                var guids = guid.Split(',').Where(c => !string.IsNullOrWhiteSpace(c)).ToList();
                return FindList(SYS_ATTACHMENT._.GUID.In(guids)).Distinct(new SysAttachmentComparer()).ToList();
            }
            return new List<SYS_ATTACHMENT>();

        }
        /// <summary>
        /// 获取附件对象
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public List<UploadResData> FindAttachment(object guid, Func<string, string> urlBuilder)
        {
            var list = new List<UploadResData>();
            if (guid != null)
            {
                var attachments = FindAttachmentsByGuids(guid.ToString());
                if (attachments.Any())
                {
                    list = attachments.Select(c =>
                    {
                        var name = $"{c.FILETILE}";
                        if (!c.FILETILE.Contains("."))
                        {
                            name = $"{c.FILETILE}{c.FILETYPE}";
                        }

                        var url = urlBuilder.Invoke(c.GUID);
                        return new UploadResData
                        {
                            Id = c.AID?.ToString(),
                            new_id = c.GUID,
                            Url = url,
                            Name = name,
                            Md5 = c.MD5,
                            FullUrl = url
                        };
                    }).Distinct().ToList();
                }
            }
            return list;
        }


        /// <summary>
        /// 获取附件对象
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public List<UploadResData> FindAttachments(object guid, Func<string, string> urlBuilder = null)
        {
            var list = new List<UploadResData>();
            if (guid != null)
            {
                var attachments = FindAttachmentsByGuids(guid.ToString());
                if (attachments.Any())
                {
                    list = attachments.Select(c =>
                    {
                        var name = $"{c.FILETILE}";
                        if (!c.FILETILE.Contains("."))
                        {
                            name = $"{c.FILETILE}{c.FILETYPE}";
                        }
                        var url = urlBuilder == null ? c.FILEPATH : urlBuilder.Invoke(c.GUID);
                        return new UploadResData
                        {
                            Id = c.AID?.ToString(),
                            new_id = c.GUID,
                            Url = url,
                            Name = name,
                            Md5 = c.MD5,
                            FullUrl = url
                        };
                    }).Distinct().ToList();
                }
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlBuilder">是否构建附件访问地址</param>
        /// <param name="guids">附件GUID集合</param>
        /// <returns></returns>
        public List<UploadResData> FindSysAttachments(bool urlBuilder=true,params string[] guids)
        {
            var sysAttachments = Jd.SysAttachmentService.FindList(SYS_ATTACHMENT._.GUID.In(guids));
            var r = sysAttachments.Distinct(new SysAttachmentComparer())
                .Select(c =>
                {

                    var fullPath = c.FILEPATH;
                    if (c.FILEPATH.IndexOf("http", StringComparison.CurrentCultureIgnoreCase) == -1)
                    {
                        fullPath = HttpContext.Current?.Server.MapPath($"~/{c.FILEPATH}");
                        if (c.AOBJTYPE == SYS_ATTACHMENT.FILE_CENTER)
                        {
                            fullPath = $"{ConfigHelper.AppSettings.UploadHost}{c.FILEPATH}";
                        }
                    }
                    if(urlBuilder)
                    {
                        fullPath = CommonAttachmentBuilder(c.GUID, "Jd", "Sys");
                    }
                    var res = new UploadResData
                    {
                        Id = c.GUID?.ToString(),
                        new_id = c.GUID?.ToString(),
                        FullUrl = fullPath,
                        Md5 = c.MD5,
                        Url = c.FILEPATH,
                        Name = c.FILETILE,
                        FileType = c.FILETYPE,
                    };
                    return res;
                }).ToList();
            return r;
        }
    }
}