using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;
using GGZY.Core.Utils;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TAttachmentService
    {
        public string FindAttachment(string mAttIds, string ex = "pdf")
        {
            if (!string.IsNullOrWhiteSpace(mAttIds))
            {
                var cacheTime = Convert.ToInt32((DateTime.Today.AddDays(1) - DateTime.Now).TotalMinutes);
                var cacheKey = $"ATT:{CommonUtils.Md5Str(mAttIds)}";
                Cache.Get(cacheKey, cacheTime, () =>
               {
                   var ids = mAttIds.Split(',').ToList();
                   var attachments = FindList((T_ATTACHMENT._.ATTACHMENT_TYPE == ex.ToLower() ||
                                               T_ATTACHMENT._.ATTACHMENT_TYPE == ex.ToUpper()) &&
                                              T_ATTACHMENT._.ID.In(ids));
                   return attachments;
               });
                return cacheKey;
            }
            return null;
            //FindList()
        }
    }
}