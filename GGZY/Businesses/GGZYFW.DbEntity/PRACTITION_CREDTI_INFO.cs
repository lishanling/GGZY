using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRACTITION_CREDTI_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRACTITION_CREDTI_INFO")]
    [Serializable]
    public partial class PRACTITION_CREDTI_INFO : FwEntity
    {
        #region Model
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private string _PERSON_NAME;
		private string _GENDER;
		private string _PERSON_PHONE;
		private string _UNIT_CODE;
		private string _UNIT_NAME;
		private decimal? _CREDIT_SCORE;
		private string _CREDIT_TYPE;
		private string _INDUSTRIES_TYPE;
		private DateTime? _UPDATE_TIME;
		private string _M_DATA_SOURCE;
		private DateTime? _DATA_TIMESTAMP;

		/// <summary>
		/// 身份证件号码
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
		/// 身份证件类型
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
		/// 姓名
		/// </summary>
		public string PERSON_NAME
		{
			get{ return _PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_NAME, _PERSON_NAME, value);
				this._PERSON_NAME = value;
			}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string GENDER
		{
			get{ return _GENDER; }
			set
			{
				this.OnPropertyValueChange(_.GENDER, _GENDER, value);
				this._GENDER = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PERSON_PHONE
		{
			get{ return _PERSON_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_PHONE, _PERSON_PHONE, value);
				this._PERSON_PHONE = value;
			}
		}
		/// <summary>
		/// 所在单位代码
		/// </summary>
		public string UNIT_CODE
		{
			get{ return _UNIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_CODE, _UNIT_CODE, value);
				this._UNIT_CODE = value;
			}
		}
		/// <summary>
		/// 所在单位名称
		/// </summary>
		public string UNIT_NAME
		{
			get{ return _UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_NAME, _UNIT_NAME, value);
				this._UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 信用分
		/// </summary>
		public decimal? CREDIT_SCORE
		{
			get{ return _CREDIT_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_SCORE, _CREDIT_SCORE, value);
				this._CREDIT_SCORE = value;
			}
		}
		/// <summary>
		/// 信用类型
		/// </summary>
		public string CREDIT_TYPE
		{
			get{ return _CREDIT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_TYPE, _CREDIT_TYPE, value);
				this._CREDIT_TYPE = value;
			}
		}
		/// <summary>
		/// 项目行业分类
		/// </summary>
		public string INDUSTRIES_TYPE
		{
			get{ return _INDUSTRIES_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRIES_TYPE, _INDUSTRIES_TYPE, value);
				this._INDUSTRIES_TYPE = value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			get{ return _UPDATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TIME, _UPDATE_TIME, value);
				this._UPDATE_TIME = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.PERSON_NAME,
				_.GENDER,
				_.PERSON_PHONE,
				_.UNIT_CODE,
				_.UNIT_NAME,
				_.CREDIT_SCORE,
				_.CREDIT_TYPE,
				_.INDUSTRIES_TYPE,
				_.UPDATE_TIME,
				_.M_DATA_SOURCE,
				_.DATA_TIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._PERSON_NAME,
				this._GENDER,
				this._PERSON_PHONE,
				this._UNIT_CODE,
				this._UNIT_NAME,
				this._CREDIT_SCORE,
				this._CREDIT_TYPE,
				this._INDUSTRIES_TYPE,
				this._UPDATE_TIME,
				this._M_DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "PRACTITION_CREDTI_INFO");
            /// <summary>
			/// 身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "PRACTITION_CREDTI_INFO", "身份证件号码");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "PRACTITION_CREDTI_INFO", "身份证件类型");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field PERSON_NAME = new Field("PERSON_NAME", "PRACTITION_CREDTI_INFO", "姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "PRACTITION_CREDTI_INFO", "性别");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PERSON_PHONE = new Field("PERSON_PHONE", "PRACTITION_CREDTI_INFO", "联系电话");
            /// <summary>
			/// 所在单位代码
			/// </summary>
			public readonly static Field UNIT_CODE = new Field("UNIT_CODE", "PRACTITION_CREDTI_INFO", "所在单位代码");
            /// <summary>
			/// 所在单位名称
			/// </summary>
			public readonly static Field UNIT_NAME = new Field("UNIT_NAME", "PRACTITION_CREDTI_INFO", "所在单位名称");
            /// <summary>
			/// 信用分
			/// </summary>
			public readonly static Field CREDIT_SCORE = new Field("CREDIT_SCORE", "PRACTITION_CREDTI_INFO", "信用分");
            /// <summary>
			/// 信用类型
			/// </summary>
			public readonly static Field CREDIT_TYPE = new Field("CREDIT_TYPE", "PRACTITION_CREDTI_INFO", "信用类型");
            /// <summary>
			/// 项目行业分类
			/// </summary>
			public readonly static Field INDUSTRIES_TYPE = new Field("INDUSTRIES_TYPE", "PRACTITION_CREDTI_INFO", "项目行业分类");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "PRACTITION_CREDTI_INFO", "更新时间");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PRACTITION_CREDTI_INFO", "数据来源");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PRACTITION_CREDTI_INFO", "数据时间戳");
        }
        #endregion
	}
}