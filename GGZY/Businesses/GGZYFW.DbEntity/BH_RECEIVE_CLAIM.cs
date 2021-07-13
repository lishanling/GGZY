using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BH_RECEIVE_CLAIM。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BH_RECEIVE_CLAIM")]
	[Serializable]
	public partial class BH_RECEIVE_CLAIM : Entity
	{
		#region Model
		private decimal _M_ID;
		private string _ORDER_ID;
		private string _GUARANTEE_NO;
		private string _COMPENSATE_STATUS;
		private string _COMPENSATE_REMARK;
		private string _COMPENSATE_NAME;
		private string _COMPENSATE_CREDIT_CODE;
		private string _COMPENSATE_CONTACT;
		private string _COMPENSATE_TEL;
		private string _COMPENSATE_BANK_CODE;
		private string _COMPENSATE_BANK_OPENBANK;
		private string _FAVOREE;
		private string _FAVOREE_CREDIT_CODE;
		private string _FAVOREE_CONTACT;
		private string _FAVOREE_TEL;
		private string _FAVOREE_BANK_CODE;
		private string _FAVOREE_BANK_OPENBANK;
		private decimal? _COMPENSATE_AMOUNT;
		private DateTime? _CREATE_TIME;
		private decimal? _USER_ID;
		private string _M_DATA_KEY;

		/// <summary>
		/// 
		/// </summary>
		public decimal M_ID
		{
			get { return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDER_ID
		{
			get { return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GUARANTEE_NO
		{
			get { return _GUARANTEE_NO; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_NO, _GUARANTEE_NO, value);
				this._GUARANTEE_NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_STATUS
		{
			get { return _COMPENSATE_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_STATUS, _COMPENSATE_STATUS, value);
				this._COMPENSATE_STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_REMARK
		{
			get { return _COMPENSATE_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_REMARK, _COMPENSATE_REMARK, value);
				this._COMPENSATE_REMARK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_NAME
		{
			get { return _COMPENSATE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_NAME, _COMPENSATE_NAME, value);
				this._COMPENSATE_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_CREDIT_CODE
		{
			get { return _COMPENSATE_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_CREDIT_CODE, _COMPENSATE_CREDIT_CODE, value);
				this._COMPENSATE_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_CONTACT
		{
			get { return _COMPENSATE_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_CONTACT, _COMPENSATE_CONTACT, value);
				this._COMPENSATE_CONTACT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_TEL
		{
			get { return _COMPENSATE_TEL; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_TEL, _COMPENSATE_TEL, value);
				this._COMPENSATE_TEL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_BANK_CODE
		{
			get { return _COMPENSATE_BANK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_BANK_CODE, _COMPENSATE_BANK_CODE, value);
				this._COMPENSATE_BANK_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPENSATE_BANK_OPENBANK
		{
			get { return _COMPENSATE_BANK_OPENBANK; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_BANK_OPENBANK, _COMPENSATE_BANK_OPENBANK, value);
				this._COMPENSATE_BANK_OPENBANK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAVOREE
		{
			get { return _FAVOREE; }
			set
			{
				this.OnPropertyValueChange(_.FAVOREE, _FAVOREE, value);
				this._FAVOREE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAVOREE_CREDIT_CODE
		{
			get { return _FAVOREE_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.FAVOREE_CREDIT_CODE, _FAVOREE_CREDIT_CODE, value);
				this._FAVOREE_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAVOREE_CONTACT
		{
			get { return _FAVOREE_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.FAVOREE_CONTACT, _FAVOREE_CONTACT, value);
				this._FAVOREE_CONTACT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAVOREE_TEL
		{
			get { return _FAVOREE_TEL; }
			set
			{
				this.OnPropertyValueChange(_.FAVOREE_TEL, _FAVOREE_TEL, value);
				this._FAVOREE_TEL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAVOREE_BANK_CODE
		{
			get { return _FAVOREE_BANK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.FAVOREE_BANK_CODE, _FAVOREE_BANK_CODE, value);
				this._FAVOREE_BANK_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAVOREE_BANK_OPENBANK
		{
			get { return _FAVOREE_BANK_OPENBANK; }
			set
			{
				this.OnPropertyValueChange(_.FAVOREE_BANK_OPENBANK, _FAVOREE_BANK_OPENBANK, value);
				this._FAVOREE_BANK_OPENBANK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COMPENSATE_AMOUNT
		{
			get { return _COMPENSATE_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.COMPENSATE_AMOUNT, _COMPENSATE_AMOUNT, value);
				this._COMPENSATE_AMOUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? USER_ID
		{
			get { return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_KEY
		{
			get { return _M_DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_KEY, _M_DATA_KEY, value);
				this._M_DATA_KEY = value;
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
				_.ORDER_ID,
				_.GUARANTEE_NO,
				_.COMPENSATE_STATUS,
				_.COMPENSATE_REMARK,
				_.COMPENSATE_NAME,
				_.COMPENSATE_CREDIT_CODE,
				_.COMPENSATE_CONTACT,
				_.COMPENSATE_TEL,
				_.COMPENSATE_BANK_CODE,
				_.COMPENSATE_BANK_OPENBANK,
				_.FAVOREE,
				_.FAVOREE_CREDIT_CODE,
				_.FAVOREE_CONTACT,
				_.FAVOREE_TEL,
				_.FAVOREE_BANK_CODE,
				_.FAVOREE_BANK_OPENBANK,
				_.COMPENSATE_AMOUNT,
				_.CREATE_TIME,
				_.USER_ID,
				_.M_DATA_KEY,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._ORDER_ID,
				this._GUARANTEE_NO,
				this._COMPENSATE_STATUS,
				this._COMPENSATE_REMARK,
				this._COMPENSATE_NAME,
				this._COMPENSATE_CREDIT_CODE,
				this._COMPENSATE_CONTACT,
				this._COMPENSATE_TEL,
				this._COMPENSATE_BANK_CODE,
				this._COMPENSATE_BANK_OPENBANK,
				this._FAVOREE,
				this._FAVOREE_CREDIT_CODE,
				this._FAVOREE_CONTACT,
				this._FAVOREE_TEL,
				this._FAVOREE_BANK_CODE,
				this._FAVOREE_BANK_OPENBANK,
				this._COMPENSATE_AMOUNT,
				this._CREATE_TIME,
				this._USER_ID,
				this._M_DATA_KEY,
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
			public readonly static Field All = new Field("*", "BH_RECEIVE_CLAIM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GUARANTEE_NO = new Field("GUARANTEE_NO", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_STATUS = new Field("COMPENSATE_STATUS", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_REMARK = new Field("COMPENSATE_REMARK", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_NAME = new Field("COMPENSATE_NAME", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_CREDIT_CODE = new Field("COMPENSATE_CREDIT_CODE", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_CONTACT = new Field("COMPENSATE_CONTACT", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_TEL = new Field("COMPENSATE_TEL", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_BANK_CODE = new Field("COMPENSATE_BANK_CODE", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_BANK_OPENBANK = new Field("COMPENSATE_BANK_OPENBANK", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAVOREE = new Field("FAVOREE", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAVOREE_CREDIT_CODE = new Field("FAVOREE_CREDIT_CODE", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAVOREE_CONTACT = new Field("FAVOREE_CONTACT", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAVOREE_TEL = new Field("FAVOREE_TEL", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAVOREE_BANK_CODE = new Field("FAVOREE_BANK_CODE", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAVOREE_BANK_OPENBANK = new Field("FAVOREE_BANK_OPENBANK", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPENSATE_AMOUNT = new Field("COMPENSATE_AMOUNT", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "BH_RECEIVE_CLAIM", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_KEY = new Field("M_DATA_KEY", "BH_RECEIVE_CLAIM", "");
		}
		#endregion
		public override string GetSequence()
        {
            return "SEQ_BH_RECEIVE_CLAIM";
        }

        public override Field GetIdentityField()
        {
            return _.M_ID;
        }
	}
}