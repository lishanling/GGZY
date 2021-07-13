using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class XinWarnResultModel
    {
        public XinWarnResultModel()
        {
			this.Buttons=new List<string>();
        }
        #region  行政监督-招投标项目监督新建模型

        /// <summary>
        /// M_ID
        /// </summary>
        public string M_ID { get; set; }

		/// <summary>
		/// 监督点名称
		/// </summary>
		public string SP_NAME { get; set; }


		/// <summary>
		/// 监督点类型
		/// </summary>
		public string SP_TYPE { get; set; }
		/// <summary>
		/// 监督点类型 内容监督
		/// </summary>
		public decimal SP_TYPE_CONMENT { get; set; }
		/// <summary>
		/// 监督点类型 时限监督
		/// </summary>
		public decimal SP_TYPE_TIME { get; set; }

		/// <summary>
		/// 监督时间
		/// </summary>
		public DateTime? SP_TIME { get; set; }

		/// <summary>
		/// 所属环节（当前环节）
		/// </summary>
		public string SP_FLOW_NAME { get; set; }

		/// <summary>
		/// 状态（0未监督 1绿 2黄 3红）
		/// </summary>
		public string RESULT_STATUS { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		[Display(Name = "状态", Order = 10)]
		public string RESULT_STATUS_TEXT => RESULT_STATUS == "1" ? "正常" : RESULT_STATUS == "2" ? "黄灯" : RESULT_STATUS == "3" ? "红灯" : "未启用";
		/// <summary>
		/// 招标项目名称
		/// </summary>
		[Display(Name = "招标项目名称", Order = 30)]
		public string TENDER_PROJECT_NAME { get; set; }
		

		/// <summary>
		/// 代理机构自己的交易编码
		/// </summary>
		public string TENDER_PROJECT_CODE_OLD1 { get; set; }

		/// <summary>
		/// 招标项目编号FW_TENDER_PROJECT_CODE
		/// </summary>
		[Display(Name = "招标项目编号", Order = 20),JsonProperty("FW_TENDER_PROJECT_CODE")]
		public string TENDER_PROJECT_CODE { get; set; }
        public string JD_TENDER_PROJECT_CODE { get; set; }
		/// <summary>
		/// 审查单位ID
		/// </summary>
		public string APPROVAL_DEPID { get; set; }
		/// <summary>
		/// 审查单位名称
		/// </summary>
		public string APPROVAL_NAME { get; set; }

		/// <summary>
		/// 正常监督点
		/// </summary>
		[Display(Name = "正常监督点", Order = 70)]
		public int NORMAL { get; set; }

		/// <summary>
		/// 异常监督点
		/// </summary>
		[Display(Name = "异常监督点", Order = 80)]
		public int STRANG { get; set; }
		/// <summary>
		/// 监督点总数 
		/// </summary>
		[Display(Name = "监督点总数", Order = 60)]
        public int ALL { get; set; }
		/// <summary>
		/// 黄灯监督点总数 
		/// </summary>
		public int WARNING { get; set; }
	

		#endregion
		/// <summary>
		/// 操作按钮
		/// </summary>
		public List<string> Buttons { get; set; }
		/// <summary>
		/// 地区
		/// </summary>
		[Display(Name = "所在地区", Order = 50)]
		public string REGION_CODE { get; set; }

		/// <summary>
		/// 业务类型
		/// </summary>
		[Display(Name = "业务类型", Order = 40)]
		public string TENDER_PROJECT_TYPE { get; set; }
		/// <summary>
		/// 地区
		/// </summary>
		public string AREANAME { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public string RECORD_DEPID { get; set; }
		/// <summary>
		/// 部门名称
		/// </summary>
		public string APPROVAL_DEPNAME { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public string TENDER_PROJECT_TYPE_TEXT { get; set; }
	}
}
