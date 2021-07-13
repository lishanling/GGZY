using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS_BTSR。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS_BTSR")]
    [Serializable]
    public partial class PT_ZXTS_BTSR : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _TS_ID;
		private string _NAME;
		private string _TYPE;
		private string _CODE;
		private string _ADRESS;
		private string _CONTACT;
		private string _CONTACT_PHONE;

		/// <summary>
		/// ID
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
		/// 在线投诉ID
		/// </summary>
		public decimal? TS_ID
		{
			get{ return _TS_ID; }
			set
			{
				this.OnPropertyValueChange(_.TS_ID, _TS_ID, value);
				this._TS_ID = value;
			}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 类型（1招标人，2招标代理机构，3投标人，4评标委员会，5其他 type=84）
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 代码（统一社会信用代码）
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string ADRESS
		{
			get{ return _ADRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADRESS, _ADRESS, value);
				this._ADRESS = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONTACT
		{
			get{ return _CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT, _CONTACT, value);
				this._CONTACT = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACT_PHONE
		{
			get{ return _CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_PHONE, _CONTACT_PHONE, value);
				this._CONTACT_PHONE = value;
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
				_.TS_ID,
				_.NAME,
				_.TYPE,
				_.CODE,
				_.ADRESS,
				_.CONTACT,
				_.CONTACT_PHONE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TS_ID,
				this._NAME,
				this._TYPE,
				this._CODE,
				this._ADRESS,
				this._CONTACT,
				this._CONTACT_PHONE,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_BTSR");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_BTSR", "ID");
            /// <summary>
			/// 在线投诉ID
			/// </summary>
			public readonly static Field TS_ID = new Field("TS_ID", "PT_ZXTS_BTSR", "在线投诉ID");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "PT_ZXTS_BTSR", "名称");
            /// <summary>
			/// 类型（1招标人，2招标代理机构，3投标人，4评标委员会，5其他 type=84）
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "PT_ZXTS_BTSR", "类型（1招标人，2招标代理机构，3投标人，4评标委员会，5其他 type=84）");
            /// <summary>
			/// 代码（统一社会信用代码）
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "PT_ZXTS_BTSR", "代码（统一社会信用代码）");
            /// <summary>
			/// 地址
			/// </summary>
			public readonly static Field ADRESS = new Field("ADRESS", "PT_ZXTS_BTSR", "地址");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONTACT = new Field("CONTACT", "PT_ZXTS_BTSR", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACT_PHONE = new Field("CONTACT_PHONE", "PT_ZXTS_BTSR", "联系电话");
        }
        #endregion
	}
}