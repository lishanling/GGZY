using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.JianDu.Models
{
    /// <summary>
    /// 书面报告客户端提交请求
    /// </summary>
    public class RECORD_WRITTEN_REQUEST: RECORD_WRITTEN
    {
        public List<UploadResData_ReviewRequest> ATTACHMENTS { get; set; }
    }
    /// <summary>
    /// 书面报告客户端提交请求
    /// </summary>
    public class RECORD_BIDDING_WRITE_REQUEST : RECORD_BIDDING_WRITE
    {
        public List<UploadResData_ReviewRequest> ATTACHMENTS { get; set; }
    }
    /// <summary>
    /// 书面报告-标段信息客户端提交请求
    /// </summary>
    public class RECORD_SECTION_INFO_REQUEST : RECORD_SECTION_INFO
    {
        public List<UploadResData_ReviewRequest> ATTACHMENTS { get; set; }
    }

    public class TENDER_PROJECT_RECORD_REVIEW
    {
        public string Tender_Project_Code { get; set; }

        public string Tender_Project_Name { get; set; }
        /// <summary>
        /// 备案类型
        /// </summary>
        public string Review_Type { get; set; }
        /// <summary>
        /// 审核状态
        /// </summary>
        public int? Review_Status { get; set; }
        /// <summary>
        /// 是否签收
        /// </summary>
        public int? Is_Sign { get; set; }
        /// <summary>
        /// 是否签章
        /// </summary>
        public int? Is_SignUp { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}