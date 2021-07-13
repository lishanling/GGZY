using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Utils;
using GGZYFW.DbEntity;

namespace GGZY.Services.DZBH
{
    /// <summary>
    /// 电子保函返回给前端的附件信息帮助类
    /// </summary>
    public static class BhAttachmentHelper
    {
        public static List<object> ToBhAttachments(this List<BH_ATTACHMENT> list)
        {
            var fileUrl = AppSettingUtils.GetString("FileServerUrl");
            List<object> r = new List<object>();
            foreach (var attachment in list)
            {
                r.Add(new
                {
                    id = attachment.ID,
                    url = attachment.URL,
                    md5 = attachment.MD5,
                    name = attachment.NAME
                });
            }
            return r;
        }
    }
}
