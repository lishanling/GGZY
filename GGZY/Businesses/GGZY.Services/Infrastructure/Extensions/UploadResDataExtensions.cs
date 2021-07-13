using System;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Extensions
{
    public static class UploadResDataExtensions
    {

        /// <summary>
        /// 统一文件服务上传对象(UploadResData) 转 服务平台系统附件（SYS_ATTACHMENT）类型
        /// </summary>
        /// <param name="data">统一文件服务上传对象(UploadResData)</param>
        /// <param name="uid">当前登录用户</param>
        /// <param name="maxOrderIdFun">排序id</param>
        /// <returns></returns>
        public static SYS_ATTACHMENT FwSysAttachment(this UploadResData data, decimal? uid=null,Func<int> maxOrderIdFun=null)
        {
            var s = new SYS_ATTACHMENT
            {
                AID = 0,
                AOBJID = null,
                //GUID = data.Id,
                CREATEID = uid?.ToString(),
                CREATETIME = DateTime.Now,
                UPDATETIME = DateTime.Now,
                UPDATEID = uid?.ToString(),
                AOBJTYPE = SYS_ATTACHMENT.FILE_CENTER,
                FILEPATH = data.Url,
                //MD5 = data.Md5,
                FILETILE = data.Name.FileName(),
                FILETYPE = data.Name.Extension(),
                ORDERID = maxOrderIdFun?.Invoke() ?? 0,
                CONVERTREMARK = data.Md5,
                CONVERTDATETIME = DateTime.Now
            };
            return s;
        }
        /// <summary>
        /// 统一文件服务上传对象(UploadResData) 转 监督平台系统附件（SYS_ATTACHMENT）类型
        /// </summary>
        /// <param name="data">统一文件服务上传对象(UploadResData)</param>
        /// <param name="uid">当前登录用户</param>
        /// <param name="maxOrderIdFun">排序id</param>
        /// <returns></returns>
        public static GGZYJD.DbEntity.SYS_ATTACHMENT JdSysAttachment(this UploadResData data, decimal? uid=null, Func<int> maxOrderIdFun = null)
        {
            var s = new GGZYJD.DbEntity.SYS_ATTACHMENT
            {
                AID = 0,
                GUID = data.Id,
                CREATEID = uid?.ToString(),
                CREATETIME = DateTime.Now,
                UPDATETIME = DateTime.Now,
                UPDATEID = uid?.ToString(),
                AOBJTYPE = SYS_ATTACHMENT.FILE_CENTER,
                FILEPATH = data.Url,
                MD5 = data.Md5,
                FILETILE = data.Name.FileNameWithoutExtension(),
                FILETYPE = data.Name.Extension(),
                ORDERID = 0,//maxOrderIdFun?.Invoke() ?? 0,
                CONVERTREMARK = string.Empty,
                CONVERTDATETIME = DateTime.Now
            };
            return s;
        }
    }
}