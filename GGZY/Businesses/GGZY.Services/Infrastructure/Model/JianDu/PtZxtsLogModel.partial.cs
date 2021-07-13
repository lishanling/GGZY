using System.Collections.Generic;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class PtZxtsLogModel
    {
        public int RN { get; set; }
        /// <summary>
        /// 记录-操作
        /// </summary>
        public string RECORDER_OPERATION_TEXT { get; set; }

        public List<UploadResData> RECORDER_AIDS_ATTACHMENTS { get; set; }

        public string RECORDER_DEPID_TEXT { get; set; }
    }
}