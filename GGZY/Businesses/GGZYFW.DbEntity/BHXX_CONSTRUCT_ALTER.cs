using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BHXX_CONSTRUCT_ALTER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BHXX_CONSTRUCT_ALTER")]
    [Serializable]
    public partial class BHXX_CONSTRUCT_ALTER : FwEntity
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
		private string _CHANGE_ITEM;
		private string _BEFORE_VALUE;
		private string _AFTET_VALUE;
		private DateTime? _CREATE_DATE;
		private string _CHECK_DEPART_NAME;
		private string _CHECK_PERSON_NAME;

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
		/// 变更项
		/// </summary>
		public string CHANGE_ITEM
		{
			get{ return _CHANGE_ITEM; }
			set
			{
				this.OnPropertyValueChange(_.CHANGE_ITEM, _CHANGE_ITEM, value);
				this._CHANGE_ITEM = value;
			}
		}
		/// <summary>
		/// 变更前的内容
		/// </summary>
		public string BEFORE_VALUE
		{
			get{ return _BEFORE_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.BEFORE_VALUE, _BEFORE_VALUE, value);
				this._BEFORE_VALUE = value;
			}
		}
		/// <summary>
		/// 变更后的内容
		/// </summary>
		public string AFTET_VALUE
		{
			get{ return _AFTET_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.AFTET_VALUE, _AFTET_VALUE, value);
				this._AFTET_VALUE = value;
			}
		}
		/// <summary>
		/// 变更审核时间
		/// </summary>
		public DateTime? CREATE_DATE
		{
			get{ return _CREATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_DATE, _CREATE_DATE, value);
				this._CREATE_DATE = value;
			}
		}
		/// <summary>
		/// 变更审核部门
		/// </summary>
		public string CHECK_DEPART_NAME
		{
			get{ return _CHECK_DEPART_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_DEPART_NAME, _CHECK_DEPART_NAME, value);
				this._CHECK_DEPART_NAME = value;
			}
		}
		/// <summary>
		/// 变更审核人
		/// </summary>
		public string CHECK_PERSON_NAME
		{
			get{ return _CHECK_PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_PERSON_NAME, _CHECK_PERSON_NAME, value);
				this._CHECK_PERSON_NAME = value;
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
				_.CHANGE_ITEM,
				_.BEFORE_VALUE,
				_.AFTET_VALUE,
				_.CREATE_DATE,
				_.CHECK_DEPART_NAME,
				_.CHECK_PERSON_NAME,
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
				this._CHANGE_ITEM,
				this._BEFORE_VALUE,
				this._AFTET_VALUE,
				this._CREATE_DATE,
				this._CHECK_DEPART_NAME,
				this._CHECK_PERSON_NAME,
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
			public readonly static Field All = new Field("*", "BHXX_CONSTRUCT_ALTER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BHXX_CONSTRUCT_ALTER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BHXX_CONSTRUCT_ALTER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BHXX_CONSTRUCT_ALTER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BHXX_CONSTRUCT_ALTER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BHXX_CONSTRUCT_ALTER", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "BHXX_CONSTRUCT_ALTER", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "BHXX_CONSTRUCT_ALTER", "项目名称");
            /// <summary>
			/// 项目代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "BHXX_CONSTRUCT_ALTER", "项目代码");
            /// <summary>
			/// 施工许可证编号
			/// </summary>
			public readonly static Field BUILDER_LICENCE_NUM = new Field("BUILDER_LICENCE_NUM", "BHXX_CONSTRUCT_ALTER", "施工许可证编号");
            /// <summary>
			/// 变更项
			/// </summary>
			public readonly static Field CHANGE_ITEM = new Field("CHANGE_ITEM", "BHXX_CONSTRUCT_ALTER", "变更项");
            /// <summary>
			/// 变更前的内容
			/// </summary>
			public readonly static Field BEFORE_VALUE = new Field("BEFORE_VALUE", "BHXX_CONSTRUCT_ALTER", "变更前的内容");
            /// <summary>
			/// 变更后的内容
			/// </summary>
			public readonly static Field AFTET_VALUE = new Field("AFTET_VALUE", "BHXX_CONSTRUCT_ALTER", "变更后的内容");
            /// <summary>
			/// 变更审核时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "BHXX_CONSTRUCT_ALTER", "变更审核时间");
            /// <summary>
			/// 变更审核部门
			/// </summary>
			public readonly static Field CHECK_DEPART_NAME = new Field("CHECK_DEPART_NAME", "BHXX_CONSTRUCT_ALTER", "变更审核部门");
            /// <summary>
			/// 变更审核人
			/// </summary>
			public readonly static Field CHECK_PERSON_NAME = new Field("CHECK_PERSON_NAME", "BHXX_CONSTRUCT_ALTER", "变更审核人");
        }
        #endregion
	}
}