using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BHXX_SCENE_SUPERVISOR_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BHXX_SCENE_SUPERVISOR_INFO")]
    [Serializable]
    public partial class BHXX_SCENE_SUPERVISOR_INFO : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _INVEST_PROJECT_CODE;
		private string _BUILDER_LICENCE_NUM;
		private string _CORP_NAME;
		private string _CORP_CODE;
		private string _USERNAME;
		private string _IDCARD_TYPE_NUM;
		private string _IDCARD;
		private string _POST_CERT_NAME;
		private string _POST_CERT_NUM;
		private DateTime? _CERT_END_DATE;

		/// <summary>
		/// 
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
			}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 项目代码
		/// </summary>
		public string INVEST_PROJECT_CODE
		{
			get{ return _INVEST_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_PROJECT_CODE, _INVEST_PROJECT_CODE, value);
				this._INVEST_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 施工许可证编号
		/// </summary>
		public string BUILDER_LICENCE_NUM
		{
			get{ return _BUILDER_LICENCE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BUILDER_LICENCE_NUM, _BUILDER_LICENCE_NUM, value);
				this._BUILDER_LICENCE_NUM = value;
			}
		}
		/// <summary>
		/// 所属企业名称
		/// </summary>
		public string CORP_NAME
		{
			get{ return _CORP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CORP_NAME, _CORP_NAME, value);
				this._CORP_NAME = value;
			}
		}
		/// <summary>
		/// 所属企业统一社会信用代码
		/// </summary>
		public string CORP_CODE
		{
			get{ return _CORP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CORP_CODE, _CORP_CODE, value);
				this._CORP_CODE = value;
			}
		}
		/// <summary>
		/// 人员姓名
		/// </summary>
		public string USERNAME
		{
			get{ return _USERNAME; }
			set
			{
				this.OnPropertyValueChange(_.USERNAME, _USERNAME, value);
				this._USERNAME = value;
			}
		}
		/// <summary>
		/// 证件类型
		/// </summary>
		public string IDCARD_TYPE_NUM
		{
			get{ return _IDCARD_TYPE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.IDCARD_TYPE_NUM, _IDCARD_TYPE_NUM, value);
				this._IDCARD_TYPE_NUM = value;
			}
		}
		/// <summary>
		/// 人员证件号码
		/// </summary>
		public string IDCARD
		{
			get{ return _IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.IDCARD, _IDCARD, value);
				this._IDCARD = value;
			}
		}
		/// <summary>
		/// 证书类型
		/// </summary>
		public string POST_CERT_NAME
		{
			get{ return _POST_CERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.POST_CERT_NAME, _POST_CERT_NAME, value);
				this._POST_CERT_NAME = value;
			}
		}
		/// <summary>
		/// 证书编号
		/// </summary>
		public string POST_CERT_NUM
		{
			get{ return _POST_CERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.POST_CERT_NUM, _POST_CERT_NUM, value);
				this._POST_CERT_NUM = value;
			}
		}
		/// <summary>
		/// 证书有效期
		/// </summary>
		public DateTime? CERT_END_DATE
		{
			get{ return _CERT_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CERT_END_DATE, _CERT_END_DATE, value);
				this._CERT_END_DATE = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.M_ID,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.INVEST_PROJECT_CODE,
				_.BUILDER_LICENCE_NUM,
				_.CORP_NAME,
				_.CORP_CODE,
				_.USERNAME,
				_.IDCARD_TYPE_NUM,
				_.IDCARD,
				_.POST_CERT_NAME,
				_.POST_CERT_NUM,
				_.CERT_END_DATE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._INVEST_PROJECT_CODE,
				this._BUILDER_LICENCE_NUM,
				this._CORP_NAME,
				this._CORP_CODE,
				this._USERNAME,
				this._IDCARD_TYPE_NUM,
				this._IDCARD,
				this._POST_CERT_NAME,
				this._POST_CERT_NUM,
				this._CERT_END_DATE,
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "BHXX_SCENE_SUPERVISOR_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BHXX_SCENE_SUPERVISOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BHXX_SCENE_SUPERVISOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BHXX_SCENE_SUPERVISOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BHXX_SCENE_SUPERVISOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BHXX_SCENE_SUPERVISOR_INFO", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "BHXX_SCENE_SUPERVISOR_INFO", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "BHXX_SCENE_SUPERVISOR_INFO", "项目名称");
            /// <summary>
			/// 项目代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "BHXX_SCENE_SUPERVISOR_INFO", "项目代码");
            /// <summary>
			/// 施工许可证编号
			/// </summary>
			public readonly static Field BUILDER_LICENCE_NUM = new Field("BUILDER_LICENCE_NUM", "BHXX_SCENE_SUPERVISOR_INFO", "施工许可证编号");
            /// <summary>
			/// 所属企业名称
			/// </summary>
			public readonly static Field CORP_NAME = new Field("CORP_NAME", "BHXX_SCENE_SUPERVISOR_INFO", "所属企业名称");
            /// <summary>
			/// 所属企业统一社会信用代码
			/// </summary>
			public readonly static Field CORP_CODE = new Field("CORP_CODE", "BHXX_SCENE_SUPERVISOR_INFO", "所属企业统一社会信用代码");
            /// <summary>
			/// 人员姓名
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "BHXX_SCENE_SUPERVISOR_INFO", "人员姓名");
            /// <summary>
			/// 证件类型
			/// </summary>
			public readonly static Field IDCARD_TYPE_NUM = new Field("IDCARD_TYPE_NUM", "BHXX_SCENE_SUPERVISOR_INFO", "证件类型");
            /// <summary>
			/// 人员证件号码
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "BHXX_SCENE_SUPERVISOR_INFO", "人员证件号码");
            /// <summary>
			/// 证书类型
			/// </summary>
			public readonly static Field POST_CERT_NAME = new Field("POST_CERT_NAME", "BHXX_SCENE_SUPERVISOR_INFO", "证书类型");
            /// <summary>
			/// 证书编号
			/// </summary>
			public readonly static Field POST_CERT_NUM = new Field("POST_CERT_NUM", "BHXX_SCENE_SUPERVISOR_INFO", "证书编号");
            /// <summary>
			/// 证书有效期
			/// </summary>
			public readonly static Field CERT_END_DATE = new Field("CERT_END_DATE", "BHXX_SCENE_SUPERVISOR_INFO", "证书有效期");
        }
        #endregion
	}
}