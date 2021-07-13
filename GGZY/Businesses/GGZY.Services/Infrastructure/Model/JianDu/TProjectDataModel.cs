using System;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TProjectDataModel
    {
		#region Model

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID { get; set; }
		/// <summary>
		/// 业务流水号
		/// </summary>
		public string BUSINESSID { get; set; }
		/// <summary>
		/// 归属流程编码
		/// </summary>
		public string TP_CODE { get; set; }
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE { get; set; }
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string PROJECT_NAME { get; set; }
		/// <summary>
		/// 项目类型
		/// </summary>
		public string PROJECT_TYPE { get; set; }
		/// <summary>
		/// 项目所在行政区域代码
		/// </summary>
		public string REGION_CODE { get; set; }
		/// <summary>
		/// 项目建立时间
		/// </summary>
		public DateTime? CREATE_TIME { get; set; }
		/// <summary>
		/// 交易平台名称
		/// </summary>
		public string PLATFORM_NAME { get; set; }
		/// <summary>
		/// 交易平台标识码
		/// </summary>
		public string PLATFORM_CODE { get; set; }
		/// <summary>
		/// 项目业主名称
		/// </summary>
		public string OWNER_NAME { get; set; }
		/// <summary>
		/// 代理机构名称
		/// </summary>
		public string AGENCY_NAME { get; set; }
		/// <summary>
		/// 代理机构代码
		/// </summary>
		public string AGENCY_CODE { get; set; }
		/// <summary>
		/// 监督部门名称
		/// </summary>
		public string SUPERVISE_DEPT_NAME { get; set; }
		/// <summary>
		/// 监督部门代码
		/// </summary>
		public string SUPERVISE_DEPT_CODE { get; set; }
		/// <summary>
		/// 是否已完成监督
		/// </summary>
		public decimal? IS_FINISH { get; set; }
		/// <summary>
		/// 浏览次数
		/// </summary>
		public decimal? BROWSE_NUM { get; set; }
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? T_TM { get; set; }
		/// <summary>
		/// 行业类别
		/// </summary>
		public string PROJECT_CATEGORY { get; set; }
		/// <summary>
		/// 当前监督节点
		/// </summary>
		public string IN_NODE { get; set; }
		/// <summary>
		/// 监督启动时间
		/// </summary>
		public DateTime? START_TM { get; set; }
		/// <summary>
		/// 监督失败的节点，多个用“,”分割
		/// </summary>
		public string ERROR_NODES { get; set; }
		/// <summary>
		/// 数据类型（通用：无,住建：ZJ,水利：SL,交通：JT）
		/// </summary>
		public string TYPE { get; set; }
		#endregion
	}
}