using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PT_TJ_DATA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_TJ_DATA")]
    [Serializable]
    public partial class PT_TJ_DATA : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _DATA_TYPE;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _PROJECT_TYPE;
		private string _TRANSACTION_MODE;
		private string _TRANSACTION_TYPE;
		private decimal? _TRANSACTION_AMOUNT;
		private decimal? _SAVING_AMOUNT;
		private decimal? _VA_AMOUNT;
		private decimal? _GI_AMOUNT;
		private decimal? _EI_AMOUNT;
		private decimal? _OI_AMOUNT;
		private string _TZZTXZ;
		private DateTime? _TM;
		private decimal? _UPDATE_UID;
		private string _AREACODE;
		private DateTime? _CREATE_TM;
		private decimal? _MID;

		/// <summary>
		/// 
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 数据类型
		/// </summary>
		public string DATA_TYPE
		{
			get{ return _DATA_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TYPE, _DATA_TYPE, value);
				this._DATA_TYPE = value;
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
		/// 项目类型
		/// </summary>
		public string PROJECT_TYPE
		{
			get{ return _PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
				this._PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 交易方式
		/// </summary>
		public string TRANSACTION_MODE
		{
			get{ return _TRANSACTION_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TRANSACTION_MODE, _TRANSACTION_MODE, value);
				this._TRANSACTION_MODE = value;
			}
		}
		/// <summary>
		/// 交易类别
		/// </summary>
		public string TRANSACTION_TYPE
		{
			get{ return _TRANSACTION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRANSACTION_TYPE, _TRANSACTION_TYPE, value);
				this._TRANSACTION_TYPE = value;
			}
		}
		/// <summary>
		/// 交易额
		/// </summary>
		public decimal? TRANSACTION_AMOUNT
		{
			get{ return _TRANSACTION_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.TRANSACTION_AMOUNT, _TRANSACTION_AMOUNT, value);
				this._TRANSACTION_AMOUNT = value;
			}
		}
		/// <summary>
		/// 节约金额
		/// </summary>
		public decimal? SAVING_AMOUNT
		{
			get{ return _SAVING_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.SAVING_AMOUNT, _SAVING_AMOUNT, value);
				this._SAVING_AMOUNT = value;
			}
		}
		/// <summary>
		/// 增值金额
		/// </summary>
		public decimal? VA_AMOUNT
		{
			get{ return _VA_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.VA_AMOUNT, _VA_AMOUNT, value);
				this._VA_AMOUNT = value;
			}
		}
		/// <summary>
		/// 政府投资额
		/// </summary>
		public decimal? GI_AMOUNT
		{
			get{ return _GI_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.GI_AMOUNT, _GI_AMOUNT, value);
				this._GI_AMOUNT = value;
			}
		}
		/// <summary>
		/// 企业投资额
		/// </summary>
		public decimal? EI_AMOUNT
		{
			get{ return _EI_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.EI_AMOUNT, _EI_AMOUNT, value);
				this._EI_AMOUNT = value;
			}
		}
		/// <summary>
		/// 其他投资额
		/// </summary>
		public decimal? OI_AMOUNT
		{
			get{ return _OI_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.OI_AMOUNT, _OI_AMOUNT, value);
				this._OI_AMOUNT = value;
			}
		}
		/// <summary>
		/// 投资主体性质
		/// </summary>
		public string TZZTXZ
		{
			get{ return _TZZTXZ; }
			set
			{
				this.OnPropertyValueChange(_.TZZTXZ, _TZZTXZ, value);
				this._TZZTXZ = value;
			}
		}
		/// <summary>
		/// 年月
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 上传人
		/// </summary>
		public decimal? UPDATE_UID
		{
			get{ return _UPDATE_UID; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_UID, _UPDATE_UID, value);
				this._UPDATE_UID = value;
			}
		}
		/// <summary>
		/// 所属地区
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 主表ID
		/// </summary>
		public decimal? MID
		{
			get{ return _MID; }
			set
			{
				this.OnPropertyValueChange(_.MID, _MID, value);
				this._MID = value;
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
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.DATA_TYPE,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.PROJECT_TYPE,
				_.TRANSACTION_MODE,
				_.TRANSACTION_TYPE,
				_.TRANSACTION_AMOUNT,
				_.SAVING_AMOUNT,
				_.VA_AMOUNT,
				_.GI_AMOUNT,
				_.EI_AMOUNT,
				_.OI_AMOUNT,
				_.TZZTXZ,
				_.TM,
				_.UPDATE_UID,
				_.AREACODE,
				_.CREATE_TM,
				_.MID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DATA_TYPE,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._PROJECT_TYPE,
				this._TRANSACTION_MODE,
				this._TRANSACTION_TYPE,
				this._TRANSACTION_AMOUNT,
				this._SAVING_AMOUNT,
				this._VA_AMOUNT,
				this._GI_AMOUNT,
				this._EI_AMOUNT,
				this._OI_AMOUNT,
				this._TZZTXZ,
				this._TM,
				this._UPDATE_UID,
				this._AREACODE,
				this._CREATE_TM,
				this._MID,
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
			public readonly static Field All = new Field("*", "PT_TJ_DATA");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_TJ_DATA", "");
            /// <summary>
			/// 数据类型
			/// </summary>
			public readonly static Field DATA_TYPE = new Field("DATA_TYPE", "PT_TJ_DATA", "数据类型");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "PT_TJ_DATA", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "PT_TJ_DATA", "项目名称");
            /// <summary>
			/// 项目类型
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "PT_TJ_DATA", "项目类型");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field TRANSACTION_MODE = new Field("TRANSACTION_MODE", "PT_TJ_DATA", "交易方式");
            /// <summary>
			/// 交易类别
			/// </summary>
			public readonly static Field TRANSACTION_TYPE = new Field("TRANSACTION_TYPE", "PT_TJ_DATA", "交易类别");
            /// <summary>
			/// 交易额
			/// </summary>
			public readonly static Field TRANSACTION_AMOUNT = new Field("TRANSACTION_AMOUNT", "PT_TJ_DATA", "交易额");
            /// <summary>
			/// 节约金额
			/// </summary>
			public readonly static Field SAVING_AMOUNT = new Field("SAVING_AMOUNT", "PT_TJ_DATA", "节约金额");
            /// <summary>
			/// 增值金额
			/// </summary>
			public readonly static Field VA_AMOUNT = new Field("VA_AMOUNT", "PT_TJ_DATA", "增值金额");
            /// <summary>
			/// 政府投资额
			/// </summary>
			public readonly static Field GI_AMOUNT = new Field("GI_AMOUNT", "PT_TJ_DATA", "政府投资额");
            /// <summary>
			/// 企业投资额
			/// </summary>
			public readonly static Field EI_AMOUNT = new Field("EI_AMOUNT", "PT_TJ_DATA", "企业投资额");
            /// <summary>
			/// 其他投资额
			/// </summary>
			public readonly static Field OI_AMOUNT = new Field("OI_AMOUNT", "PT_TJ_DATA", "其他投资额");
            /// <summary>
			/// 投资主体性质
			/// </summary>
			public readonly static Field TZZTXZ = new Field("TZZTXZ", "PT_TJ_DATA", "投资主体性质");
            /// <summary>
			/// 年月
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_TJ_DATA", "年月");
            /// <summary>
			/// 上传人
			/// </summary>
			public readonly static Field UPDATE_UID = new Field("UPDATE_UID", "PT_TJ_DATA", "上传人");
            /// <summary>
			/// 所属地区
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "PT_TJ_DATA", "所属地区");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_TJ_DATA", "创建时间");
            /// <summary>
			/// 主表ID
			/// </summary>
			public readonly static Field MID = new Field("MID", "PT_TJ_DATA", "主表ID");
        }
        #endregion
	}
}