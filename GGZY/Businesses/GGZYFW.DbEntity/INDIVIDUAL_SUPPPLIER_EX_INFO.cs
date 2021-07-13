using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类INDIVIDUAL_SUPPPLIER_EX_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("INDIVIDUAL_SUPPPLIER_EX_INFO")]
    [Serializable]
    public partial class INDIVIDUAL_SUPPPLIER_EX_INFO : FwEntity
    {
        #region Model
		private string _LEGAL_CODE;
		private string _CUSTOM_DEFINITION_DATAITEM;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
			}
		}
		/// <summary>
		/// 自定义数据项
		/// </summary>
		public string CUSTOM_DEFINITION_DATAITEM
		{
			get{ return _CUSTOM_DEFINITION_DATAITEM; }
			set
			{
				this.OnPropertyValueChange(_.CUSTOM_DEFINITION_DATAITEM, _CUSTOM_DEFINITION_DATAITEM, value);
				this._CUSTOM_DEFINITION_DATAITEM = value;
			}
		}
		/// <summary>
		/// 交易平台标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
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
				_.LEGAL_CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.LEGAL_CODE,
				_.CUSTOM_DEFINITION_DATAITEM,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._LEGAL_CODE,
				this._CUSTOM_DEFINITION_DATAITEM,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "INDIVIDUAL_SUPPPLIER_EX_INFO");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "INDIVIDUAL_SUPPPLIER_EX_INFO", "主体代码");
            /// <summary>
			/// 自定义数据项
			/// </summary>
			public readonly static Field CUSTOM_DEFINITION_DATAITEM = new Field("CUSTOM_DEFINITION_DATAITEM", "INDIVIDUAL_SUPPPLIER_EX_INFO",DbType.AnsiString, null, "自定义数据项");
            /// <summary>
			/// 交易平台标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "INDIVIDUAL_SUPPPLIER_EX_INFO", "交易平台标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "INDIVIDUAL_SUPPPLIER_EX_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "INDIVIDUAL_SUPPPLIER_EX_INFO", "数据时间戳");
        }
        #endregion
	}
}