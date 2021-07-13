using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
	public partial class XinPtZxtsModel
	{
		#region 投诉信息新模型重构

		/// <summary>
		/// M_ID
		/// </summary>
		public decimal? M_ID { get; set; }

		/// <summary>
		/// 投诉编号
		/// </summary>
		[Display(Name = "投诉编号", Order = 10)]
		public string CODE { get; set; }
		/// <summary>
		/// 投诉标题
		/// </summary>
		[Display(Name = "投诉标题", Order = 20)]
		public string COMPLAINT_TITLE { get; set; }
		/// <summary>
		/// 招标项目名称
		/// </summary>
		[Display(Name = "招标项目名称", Order = 40)]
		public string TENDER_PROJECT_NAME { get; set; }
		/// <summary>
		/// 投诉日期
		/// </summary>

		public string CREATE_TM { get; set; }

		[Display(Name = "投诉时间", Order = 60)]
		public string CREATE_TM_FORMAT => string.IsNullOrEmpty(CREATE_TM) ? "" : Convert.ToDateTime(CREATE_TM).ToString("yyyy-MM-dd HH : mm");
		/// <summary>
		/// 业务类型
		/// </summary>
		public string TENDER_PROJECT_TYPE { get; set; }
		/// <summary>
		/// 审查单位
		/// </summary>
		public string ACCEPT_DEPID { get; set; }
		/// <summary>
		/// 投诉人
		/// </summary>
		[Display(Name = "投诉人", Order = 30)]
		public string COMPLAINT_NAME { get; set; }
		/// <summary>
		/// 处理时间
		/// </summary>
		public string HANDLE_TM { get; set; }

		[Display(Name = "处理时间", Order = 70)]
		public string HANDLE_TM_FORMAT => string.IsNullOrEmpty(HANDLE_TM) ? "" : Convert.ToDateTime(HANDLE_TM).ToString("yyyy-MM-dd HH : mm");

		/// <summary>
		/// 投诉事项
		/// </summary>
		public string COMPLAINT_SX { get; set; }
		/// <summary>
		/// 单位名称
		/// </summary>
		[Display(Name = "处理单位", Order = 50)]
		public string DNAME { get; set; }

		#endregion

		public string AREANAME { get; set; }
        public string TENDER_PROJECT_CODE { get; set; }
	}
}
