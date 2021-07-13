using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public partial class EarlyWarnModel
    {
        /// <summary>
        /// M_ID
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// 招标项目代码
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }

        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 监督类型
        /// </summary>
        /// 
        public string SP_TYPE { get; set; }
        /// <summary>
        /// 监督方式
        /// </summary>
        public string SP_WAY { get; set; }
        /// <summary>
        /// 列表监督状态状态（ 1绿 2黄 3红）
        /// </summary>
        public string SP_STATUS { get; set; }

        /// <summary>
        /// 监督时间
        /// </summary>
        public DateTime? SP_TIME { get; set; }

        /// <summary>
        /// 列表监督处理状态（ 1:待处理 2：已发出预警信息，3 已反馈  4  反馈已读  5 已办结）
        /// </summary>
        public string OPERATE_STATUS { get; set; }

        /// <summary>
        /// 监督点名称
        /// </summary>
        public string SP_NAME { get; set; }
        /// <summary>
        /// 监督点规则描述
        /// </summary>
        public string SP_POINT_RULE { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime? CREATE_TIME { get; set; }
        

        public EarlyWarnModel()
        {
            this.Buttons = new List<string>();
        }
        public List<string> Buttons { get; set; }
    }
}
