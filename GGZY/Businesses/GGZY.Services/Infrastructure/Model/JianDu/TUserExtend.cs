namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TUserExtend
    {
		#region Model
		/// <summary>
		/// 主键ID 自增
		/// </summary>
		public decimal? ID { get; set; }
		/// <summary>
		/// 用户ID
		/// </summary>
		public decimal? U_ID { get; set; }
		/// <summary>
		/// 单位名称
		/// </summary>
		public string DEP_NAME { get; set; }
		/// <summary>
		/// 单位性质
		/// </summary>
		public string DEP_KIND { get; set; }
		/// <summary>
		/// 代码类型
		/// </summary>
		public string CODE_TYPE { get; set; }
		/// <summary>
		/// 统一信用代码
		/// </summary>
		public string UNIFIED_CREDIT_CODE { get; set; }
		/// <summary>
		/// 组织机构代码
		/// </summary>
		public string ORGAN_CODE { get; set; }
		/// <summary>
		/// 所在地-省
		/// </summary>
		public string PROV_CODE { get; set; }
		/// <summary>
		/// 所在地-市
		/// </summary>
		public string CITY_CODE { get; set; }
		/// <summary>
		/// 所在地-县
		/// </summary>
		public string COUNTY_CODE { get; set; }
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string POSTAL_CODE { get; set; }
		/// <summary>
		/// 单位地址
		/// </summary>
		public string ADDRESS { get; set; }
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONTACTS { get; set; }
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACTS_PHONE { get; set; }
		/// <summary>
		/// 扫描件_统一信用代码
		/// </summary>
		public string AIDS_UCC { get; set; }
		/// <summary>
		/// 扫描件_组织机构代码
		/// </summary>
		public string AIDS_OC { get; set; }
		/// <summary>
		/// 账号类型
		/// </summary>
		public string ACCOUNT_TYPE { get; set; }
		/// <summary>
		/// 个人注册时记录身份证号，企业则为空
		/// </summary>
		public string IDCARD { get; set; }
		#endregion
	}
}