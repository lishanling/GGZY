using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_QUALI_PERSON_QUALI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_QUALI_PERSON_QUALI")]
    [Serializable]
    public partial class ZJ_QUALI_PERSON_QUALI : FwEntity
    {
        #region Model
		private string _QUAL_NAME;
		private string _QUAL_TYPE;
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private string _CERT_NO;
		private DateTime? _CERT_END_DATE;
		private string _M_DATA_SOURCE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;

		/// <summary>
		/// 执业资格名称
		/// </summary>
		public string QUAL_NAME
		{
			get{ return _QUAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_NAME, _QUAL_NAME, value);
				this._QUAL_NAME = value;
			}
		}
		/// <summary>
		/// 执业资格类型
		/// </summary>
		public string QUAL_TYPE
		{
			get{ return _QUAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_TYPE, _QUAL_TYPE, value);
				this._QUAL_TYPE = value;
			}
		}
		/// <summary>
		/// 执业人员证件号
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 执业人员身份证件类型
		/// </summary>
		public string ID_CARD_TYPE
		{
			get{ return _ID_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_TYPE, _ID_CARD_TYPE, value);
				this._ID_CARD_TYPE = value;
			}
		}
		/// <summary>
		/// 执业资格证书编号
		/// </summary>
		public string CERT_NO
		{
			get{ return _CERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.CERT_NO, _CERT_NO, value);
				this._CERT_NO = value;
			}
		}
		/// <summary>
		/// 执业资格注册有效期止
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
		/// <summary>
		/// 数据来源
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
		/// <summary>
		/// M_ID
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.QUAL_NAME,
				_.QUAL_TYPE,
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.CERT_NO,
				_.CERT_END_DATE,
				_.M_DATA_SOURCE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._QUAL_NAME,
				this._QUAL_TYPE,
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._CERT_NO,
				this._CERT_END_DATE,
				this._M_DATA_SOURCE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
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
			public readonly static Field All = new Field("*", "ZJ_QUALI_PERSON_QUALI");
            /// <summary>
			/// 执业资格名称
			/// </summary>
			public readonly static Field QUAL_NAME = new Field("QUAL_NAME", "ZJ_QUALI_PERSON_QUALI", "执业资格名称");
            /// <summary>
			/// 执业资格类型
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "ZJ_QUALI_PERSON_QUALI", "执业资格类型");
            /// <summary>
			/// 执业人员证件号
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "ZJ_QUALI_PERSON_QUALI", "执业人员证件号");
            /// <summary>
			/// 执业人员身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "ZJ_QUALI_PERSON_QUALI", "执业人员身份证件类型");
            /// <summary>
			/// 执业资格证书编号
			/// </summary>
			public readonly static Field CERT_NO = new Field("CERT_NO", "ZJ_QUALI_PERSON_QUALI", "执业资格证书编号");
            /// <summary>
			/// 执业资格注册有效期止
			/// </summary>
			public readonly static Field CERT_END_DATE = new Field("CERT_END_DATE", "ZJ_QUALI_PERSON_QUALI", "执业资格注册有效期止");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_QUALI_PERSON_QUALI", "数据来源");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_QUALI_PERSON_QUALI", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_QUALI_PERSON_QUALI", "数据时间戳");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_QUALI_PERSON_QUALI", "M_ID");
        }
        #endregion
	}
}