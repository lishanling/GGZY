using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 在线投诉处理
    /// </summary>
    public class PtZxtsHandleModel
    {
        private string _CONTENT;
        public string CODE { get; set; }

        public string TITLE { get; set; }

        public string CONTENT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_CONTENT))
                {
                    _CONTENT = CONTENTS;
                }
                return _CONTENT;
            }
            set => _CONTENT = value;
        }

        public string CONTENTS { get; set; }
        public DateTime PUBLISH_TIME { get; set; }

        public decimal? IS_PUBLIC { get; set; }
        public string COMPLAINT_DNAME { get; set; }
        public string COMPLAINT_NAME { get; set; }
        public decimal? DLJG_UID { get; set; }
        public string DLJG_NAME { get; set; }
        public decimal? JSDW_UID { get; set; }
        public string JSDW_NAME { get; set; }

        public List<UploadResData> HANDLE_JDS_ATTACHMENTS { get; set; }

        public string HANDLE_JDS
        {
            get
            {
                if (HANDLE_JDS_ATTACHMENTS != null && HANDLE_JDS_ATTACHMENTS.Any())
                {
                    return string.Join(",", HANDLE_JDS_ATTACHMENTS.Select(c => c.Id));
                }
                return String.Empty;
            }
        }

        #region 抄送

        public List<string> ChaoSong { get; set; }
        /// <summary>
        /// 抄送招标人
        /// </summary>
        public bool ToZbr => ChaoSong != null &&
                             ChaoSong.Any(c => c.Equals("zbr", StringComparison.CurrentCultureIgnoreCase));
        /// <summary>
        /// 抄送投诉人
        /// </summary>
        public bool ToTsr => ChaoSong != null &&
                             ChaoSong.Any(c => c.Equals("tsr", StringComparison.CurrentCultureIgnoreCase));
        /// <summary>
        /// 抄送被投诉人
        /// </summary>
        public bool ToBtsr => ChaoSong != null &&
                              ChaoSong.Any(c => c.Equals("btsr", StringComparison.CurrentCultureIgnoreCase));


        /// <summary>
        /// 抄送代理机构
        /// </summary>
        public bool ToDljg => ChaoSong != null &&
                              ChaoSong.Any(c => c.Equals("dljg", StringComparison.CurrentCultureIgnoreCase));
        /// <summary>
        /// 抄送其他
        /// </summary>
        public bool ToQt => ChaoSong != null &&
                              ChaoSong.Any(c => c.Equals("qt", StringComparison.CurrentCultureIgnoreCase));
        #endregion


    }
}