using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类GOOD_ITEM_INFO。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("GOOD_ITEM_INFO")]
	[Serializable]
	public partial class GOOD_ITEM_INFO : JdEntity
	{
		#region Model
		private decimal? _ID;
		private string _CITY;
		private string _COUNTRY;
		private string _DEPART_NAME;
		private string _ITEM_NAME;
		private string _ITEM_CODE;
		private string _AREA_CODE;

		/// <summary>
		/// 
		/// </summary>
		public decimal? ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CITY
		{
			get { return _CITY; }
			set
			{
				this.OnPropertyValueChange(_.CITY, _CITY, value);
				this._CITY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COUNTRY
		{
			get { return _COUNTRY; }
			set
			{
				this.OnPropertyValueChange(_.COUNTRY, _COUNTRY, value);
				this._COUNTRY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPART_NAME
		{
			get { return _DEPART_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DEPART_NAME, _DEPART_NAME, value);
				this._DEPART_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_NAME
		{
			get { return _ITEM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ITEM_NAME, _ITEM_NAME, value);
				this._ITEM_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_CODE
		{
			get { return _ITEM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ITEM_CODE, _ITEM_CODE, value);
				this._ITEM_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREA_CODE
		{
			get { return _AREA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AREA_CODE, _AREA_CODE, value);
				this._AREA_CODE = value;
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
				_.CITY,
				_.COUNTRY,
				_.DEPART_NAME,
				_.ITEM_NAME,
				_.ITEM_CODE,
				_.AREA_CODE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._CITY,
				this._COUNTRY,
				this._DEPART_NAME,
				this._ITEM_NAME,
				this._ITEM_CODE,
				this._AREA_CODE,
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
			public readonly static Field All = new Field("*", "GOOD_ITEM_INFO");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "GOOD_ITEM_INFO", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CITY = new Field("CITY", "GOOD_ITEM_INFO", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field COUNTRY = new Field("COUNTRY", "GOOD_ITEM_INFO", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DEPART_NAME = new Field("DEPART_NAME", "GOOD_ITEM_INFO", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ITEM_NAME = new Field("ITEM_NAME", "GOOD_ITEM_INFO", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ITEM_CODE = new Field("ITEM_CODE", "GOOD_ITEM_INFO", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "GOOD_ITEM_INFO", "");
		}
		#endregion
		public override string GetSequence()
        {
            return "SEQ_GOOD_ITEM_INFO";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
	}
}