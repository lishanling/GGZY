using System;
using System.Collections.Generic;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.JianDu
{
	public partial class JDCount_Model 
	{
        public JDCount_Model()
        {
            this.Buttons = new List<string>();
        }
	
		#region Model

		/// <summary>
		/// M_ID
		/// </summary>
		public string M_ID { get; set; }

		/// <summary>
		/// 监督点名称
		/// </summary>
		[Display(Name = "监督点名称", Order = 20)]
		public string SP_NAME{ get; set; }


		/// <summary>
		/// 监督点类型
		/// </summary>
		[Display(Name = "监督点类型", Order = 30)]
		public string SP_TYPE { get; set; }

		/// <summary>
		/// 监督时间
		/// </summary>
		public DateTime? SP_TIME { get; set; }

		/// <summary>
		/// 监督方式
		/// </summary>
		[Display(Name = "监督方式", Order = 40)]
		public string SP_WAY { get; set; }

		/// <summary>
		/// 地区
		/// </summary>
		[Display(Name = "所在地区", Order = 70)]
		public string REGION_CODE { get; set; }

		/// <summary>
		/// 业务类型
		/// </summary>
		[Display(Name = "业务类型", Order = 80)]
		public string TENDER_PROJECT_TYPE { get; set; }

		/// <summary>
		/// 所属环节
		/// </summary>
		[Display(Name = "归属环节", Order = 50)]
		public string SP_FLOW_NAME { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		public string SP_STATUS { get; set; }
		/// <summary>
		/// 状态
		/// </summary>
		[Display(Name = "状态", Order = 10)]
		public string SP_STATUS_TEXT => SP_STATUS == "1" ? "正常" : SP_STATUS == "2" ? "黄灯" : SP_STATUS == "3" ? "红灯" : "未启用";

		/// <summary>
		/// 招标项目名称
		/// </summary>
		[Display(Name = "归属招标项目名称", Order =60)]
		public string TENDER_PROJECT_NAME { get; set; }

        /// <summary>
        /// 监督平台招标项目编号
        /// </summary>
        public string JD_TENDER_PROJECT_CODE { get; set; }

		/// <summary>
		/// 代理机构自己的交易编码
		/// </summary>
		public string TENDER_PROJECT_CODE_OLD1 { get; set; }

		#endregion

		/// <summary>
		/// 服务平台招标项目编号 FW_TENDER_PROJECT_CODE
		/// </summary>
		[JsonProperty("FW_TENDER_PROJECT_CODE")]
		public string TENDER_PROJECT_CODE { get; set; }

		/// <summary>
		/// 审查单位ID
		/// </summary>
		public string APPROVAL_DEPID { get; set; }
		/// <summary>
		/// 审查单位名称
		/// </summary>
		public string APPROVAL_NAME { get; set; }

		/// <summary>
		/// 业务类型(用于返回G01 G02)
		/// </summary>
		public string G_TENDER_PROJECT_TYPE { get; set; }

		/// <summary>
		/// 操作按钮
		/// </summary>
		public List<string> Buttons { get; set; }

	}
}
