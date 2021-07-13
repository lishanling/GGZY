using System;
using System.Collections.Generic;
using System.Web;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 线下_投诉处理决定书
    /// </summary>
    public class TouSuChuLiJueDingShuModel
    {
        private string _CONTENTS;
        /// <summary>
        /// 编号
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string STATE { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string TITLE { get; set; }
        /// <summary>
        /// 处理结果
        /// </summary>
        public string CONTENTS
        {
            get => HttpUtility.HtmlDecode(_CONTENTS);
            set => _CONTENTS = value;
        }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime? HANDLE_TM { get; set; }
        public string Year => (HANDLE_TM??DateTime.Now).ToString("yyyy");
        public string Month => (HANDLE_TM ?? DateTime.Now).ToString("MM");
        public string Day => (HANDLE_TM ?? DateTime.Now).ToString("dd");

        public DateTime PUBLISH_TIME { get; set; }
        public int IS_PUBLIC { get; set; }
        public string HANDLE_JL { get; set; }
        public List<UploadResData> HANDLE_JDS_ATTACHMENTS { get; set; }
    }
}