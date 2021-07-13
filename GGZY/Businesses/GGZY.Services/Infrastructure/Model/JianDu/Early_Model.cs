using System;
using System.Collections.Generic;

namespace GGZY.Services.Infrastructure.Model.JianDu
{

    public partial class Early_Model
    {
       
        public string TENDER_PROJECT_CODE { get; set; }

        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 监督时间
        /// </summary>
        public DateTime? SP_TIME { get; set; }
        /// <summary>
        /// 状态（ 1绿 2黄 3红）
        /// </summary>
        /// 
        public string STATUS { get; set; }
        /// <summary>
        /// 处理状态（ 1:待处理 2：已发出预警信息，3 已反馈  4  反馈已读  5 已办结）
        /// </summary>
        public string PROCESS_STATUS { get; set; }
        /// <summary>
        /// 预警是否发送
        /// </summary>
        public string EARLY { get; set; }
        /// <summary>
        /// 是否已反馈
        /// </summary>
        public string FEEDBACK { get; set; }
        /// <summary>
        /// 类型（1：全部，2：待处理，3:反馈代查看，4：超期未反馈，5：超期未处理）
        /// </summary>
        public string TYPE { get; set; }
       
       


    }
}