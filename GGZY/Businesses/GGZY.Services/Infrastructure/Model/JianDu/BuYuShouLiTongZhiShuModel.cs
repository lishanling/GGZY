using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 线下_不予受理通知书
    /// </summary>
    public class BuYuShouLiTongZhiShuModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string STATE { get; set; }
        /// <summary>
        /// 不予受理类型
        /// </summary>
        public string TYPE { get; set; }

        /// <summary>
        /// 不予受理类型
        /// </summary>
        public string TYPE_TEXT => TYPE == "1" ? "不符条件" : "非本部门";
        /// <summary>
        /// 审查存在问题
        /// </summary>
        public string SCCZWT { get; set; }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 作出不予受理时间
        /// </summary>
        public DateTime? ACCEPT_TM { get; set; }
        /// <summary>
        /// 是否公开
        /// </summary>
        public int IS_PUBLIC { get; set; }
        /// <summary>
        /// 投诉不予受理通知书
        /// </summary>
        public List<UploadResData> ACCEPT_TZS_ATTACHMENT { get; set; }

        public string ACCEPT_TZS
        {
            get
            {
                if (ACCEPT_TZS_ATTACHMENT != null)
                {
                    return string.Join(",", ACCEPT_TZS_ATTACHMENT.Select(c => c.Id));
                }
                return String.Empty;
            }
        }
    }
}