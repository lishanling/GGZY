using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_EXT_PEOPLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_EXT_PEOPLE")]
    [Serializable]
    public partial class ZJPRI_EXT_PEOPLE : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _ID_CARD;
		private string _ID_CARD_FILE;
		private DateTime? _BTIME;
		private DateTime? _ETIME;
		private string _COMPANYNAME;
		private decimal? _ZJPRI_CONSTRUCT_KEYPERSON;
		private decimal? _ZJPRI_CONSTRUCT_INTERMEDIATE;
		private decimal? _ZJPRI_REGISTER_PERSON;
		private decimal? _ZJPRI_EMPLOYEES_QUALI;

		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 姓名
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
		/// 身份证号码
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
		/// 身份证附件
		/// </summary>
		public string ID_CARD_FILE
		{
			get{ return _ID_CARD_FILE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_FILE, _ID_CARD_FILE, value);
				this._ID_CARD_FILE = value;
			}
		}
		/// <summary>
		/// 有效期开始时间
		/// </summary>
		public DateTime? BTIME
		{
			get{ return _BTIME; }
			set
			{
				this.OnPropertyValueChange(_.BTIME, _BTIME, value);
				this._BTIME = value;
			}
		}
		/// <summary>
		/// 有效期结束时间
		/// </summary>
		public DateTime? ETIME
		{
			get{ return _ETIME; }
			set
			{
				this.OnPropertyValueChange(_.ETIME, _ETIME, value);
				this._ETIME = value;
			}
		}
		/// <summary>
		/// 所属企业
		/// </summary>
		public string COMPANYNAME
		{
			get{ return _COMPANYNAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYNAME, _COMPANYNAME, value);
				this._COMPANYNAME = value;
			}
		}
		/// <summary>
		/// 是否有主要人员
		/// </summary>
		public decimal? ZJPRI_CONSTRUCT_KEYPERSON
		{
			get{ return _ZJPRI_CONSTRUCT_KEYPERSON; }
			set
			{
				this.OnPropertyValueChange(_.ZJPRI_CONSTRUCT_KEYPERSON, _ZJPRI_CONSTRUCT_KEYPERSON, value);
				this._ZJPRI_CONSTRUCT_KEYPERSON = value;
			}
		}
		/// <summary>
		/// 是否有职称信息人员
		/// </summary>
		public decimal? ZJPRI_CONSTRUCT_INTERMEDIATE
		{
			get{ return _ZJPRI_CONSTRUCT_INTERMEDIATE; }
			set
			{
				this.OnPropertyValueChange(_.ZJPRI_CONSTRUCT_INTERMEDIATE, _ZJPRI_CONSTRUCT_INTERMEDIATE, value);
				this._ZJPRI_CONSTRUCT_INTERMEDIATE = value;
			}
		}
		/// <summary>
		/// 是否有注册人员信息
		/// </summary>
		public decimal? ZJPRI_REGISTER_PERSON
		{
			get{ return _ZJPRI_REGISTER_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.ZJPRI_REGISTER_PERSON, _ZJPRI_REGISTER_PERSON, value);
				this._ZJPRI_REGISTER_PERSON = value;
			}
		}
		/// <summary>
		/// 是否从业资格信息
		/// </summary>
		public decimal? ZJPRI_EMPLOYEES_QUALI
		{
			get{ return _ZJPRI_EMPLOYEES_QUALI; }
			set
			{
				this.OnPropertyValueChange(_.ZJPRI_EMPLOYEES_QUALI, _ZJPRI_EMPLOYEES_QUALI, value);
				this._ZJPRI_EMPLOYEES_QUALI = value;
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
				_.NAME,
				_.ID_CARD,
				_.ID_CARD_FILE,
				_.BTIME,
				_.ETIME,
				_.COMPANYNAME,
				_.ZJPRI_CONSTRUCT_KEYPERSON,
				_.ZJPRI_CONSTRUCT_INTERMEDIATE,
				_.ZJPRI_REGISTER_PERSON,
				_.ZJPRI_EMPLOYEES_QUALI,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._ID_CARD,
				this._ID_CARD_FILE,
				this._BTIME,
				this._ETIME,
				this._COMPANYNAME,
				this._ZJPRI_CONSTRUCT_KEYPERSON,
				this._ZJPRI_CONSTRUCT_INTERMEDIATE,
				this._ZJPRI_REGISTER_PERSON,
				this._ZJPRI_EMPLOYEES_QUALI,
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
			public readonly static Field All = new Field("*", "ZJPRI_EXT_PEOPLE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "ZJPRI_EXT_PEOPLE", "");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_EXT_PEOPLE", "姓名");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "ZJPRI_EXT_PEOPLE", "身份证号码");
            /// <summary>
			/// 身份证附件
			/// </summary>
			public readonly static Field ID_CARD_FILE = new Field("ID_CARD_FILE", "ZJPRI_EXT_PEOPLE", "身份证附件");
            /// <summary>
			/// 有效期开始时间
			/// </summary>
			public readonly static Field BTIME = new Field("BTIME", "ZJPRI_EXT_PEOPLE", "有效期开始时间");
            /// <summary>
			/// 有效期结束时间
			/// </summary>
			public readonly static Field ETIME = new Field("ETIME", "ZJPRI_EXT_PEOPLE", "有效期结束时间");
            /// <summary>
			/// 所属企业
			/// </summary>
			public readonly static Field COMPANYNAME = new Field("COMPANYNAME", "ZJPRI_EXT_PEOPLE", "所属企业");
            /// <summary>
			/// 是否有主要人员
			/// </summary>
			public readonly static Field ZJPRI_CONSTRUCT_KEYPERSON = new Field("ZJPRI_CONSTRUCT_KEYPERSON", "ZJPRI_EXT_PEOPLE", "是否有主要人员");
            /// <summary>
			/// 是否有职称信息人员
			/// </summary>
			public readonly static Field ZJPRI_CONSTRUCT_INTERMEDIATE = new Field("ZJPRI_CONSTRUCT_INTERMEDIATE", "ZJPRI_EXT_PEOPLE", "是否有职称信息人员");
            /// <summary>
			/// 是否有注册人员信息
			/// </summary>
			public readonly static Field ZJPRI_REGISTER_PERSON = new Field("ZJPRI_REGISTER_PERSON", "ZJPRI_EXT_PEOPLE", "是否有注册人员信息");
            /// <summary>
			/// 是否从业资格信息
			/// </summary>
			public readonly static Field ZJPRI_EMPLOYEES_QUALI = new Field("ZJPRI_EMPLOYEES_QUALI", "ZJPRI_EXT_PEOPLE", "是否从业资格信息");
        }
        #endregion
	}
}