namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TUserDepartment
    {
		#region Model

		/// <summary>
		/// 单位ID
		/// </summary>
		public decimal? DEPID { get; set; }
		/// <summary>
		/// 单位名称
		/// </summary>
		public string DNAME { get; set; }
		/// <summary>
		/// 地区编码
		/// </summary>
		public string AREACODE { get; set; }
		/// <summary>
		/// 上级单位
		/// </summary>
		public decimal? PARENTID { get; set; }
		/// <summary>
		/// 单位备注
		/// </summary>
		public string DREMARK { get; set; }
		/// <summary>
		/// 经度
		/// </summary>
		public decimal? LONGI { get; set; }
		/// <summary>
		/// 纬度
		/// </summary>
		public decimal? LATI { get; set; }
		/// <summary>
        /// 单位类型 1 2 3 4
        /// 1科室2办公司 3纪委监委4公安
		/// </summary>
		public string DTYPE { get; set; }
		/// <summary>
		/// 组织属性
		/// </summary>
		public string ORGPROPERTY { get; set; }
		/// <summary>
		/// 排序号
		/// </summary>
		public decimal? ORDERID { get; set; }
		/// <summary>
		/// 组织机构编码
		/// </summary>
		public string DEPCODE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISCK { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? CKID { get; set; }
		/// <summary>
		/// 账号行业类型，多个用“,”分割
		/// </summary>
		public string KINDS { get; set; }
		/// <summary>
		/// 是否有所有行业的权限
		/// </summary>
		public decimal? ISALLKIND { get; set; }
		/// <summary>
		/// 可查阅的其它组织机构
		/// </summary>
		public string OTHERIDS { get; set; }
		/// <summary>
		/// 组织机构编码
		/// </summary>
		public string DCODE { get; set; }
		/// <summary>
		/// 是否报建
		/// </summary>
		public decimal? ISBJ { get; set; }
		/// <summary>
		/// 是否备案
		/// </summary>
		public decimal? ISBA { get; set; }
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PHONE { get; set; }
		/// <summary>
		/// 监管部门
		/// </summary>
		public string JGBM { get; set; }
		/// <summary>
		/// 单位地址
		/// </summary>
		public string DADDRESS { get; set; }
		/// <summary>
		/// 是否投诉受理单位
		/// </summary>
		public decimal? ISTS { get; set; }
		/// <summary>
		/// 行业类型
		/// </summary>
		public string HY_TYPE { get; set; }
		#endregion
	}
}