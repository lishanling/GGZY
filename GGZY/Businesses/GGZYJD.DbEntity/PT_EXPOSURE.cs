using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_EXPOSURE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_EXPOSURE")]
    [Serializable]
    public partial class PT_EXPOSURE : JdEntity
    {
        #region Model
		private string _NO;
		private string _ENTERPRISENAME;
		private string _BUSINESSNO;
		private string _LEGALREPRESENT;
		private string _ILLEGAL;
		private string _DISHONESTYCONTENT;
		private string _DISHONESTYDISCIPLINE;
		private DateTime? _TM;
		private string _DISHONESTYTYPE;
		private string _BUSINESSADDRESS;
		private DateTime? _DEADLINE;
		private string _LAWENFORCEMENTUNIT;

		/// <summary>
		/// 
		/// </summary>
		public string NO
		{
			get{ return _NO; }
			set
			{
				this.OnPropertyValueChange(_.NO, _NO, value);
				this._NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENTERPRISENAME
		{
			get{ return _ENTERPRISENAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTERPRISENAME, _ENTERPRISENAME, value);
				this._ENTERPRISENAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUSINESSNO
		{
			get{ return _BUSINESSNO; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSNO, _BUSINESSNO, value);
				this._BUSINESSNO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEGALREPRESENT
		{
			get{ return _LEGALREPRESENT; }
			set
			{
				this.OnPropertyValueChange(_.LEGALREPRESENT, _LEGALREPRESENT, value);
				this._LEGALREPRESENT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ILLEGAL
		{
			get{ return _ILLEGAL; }
			set
			{
				this.OnPropertyValueChange(_.ILLEGAL, _ILLEGAL, value);
				this._ILLEGAL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISHONESTYCONTENT
		{
			get{ return _DISHONESTYCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.DISHONESTYCONTENT, _DISHONESTYCONTENT, value);
				this._DISHONESTYCONTENT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISHONESTYDISCIPLINE
		{
			get{ return _DISHONESTYDISCIPLINE; }
			set
			{
				this.OnPropertyValueChange(_.DISHONESTYDISCIPLINE, _DISHONESTYDISCIPLINE, value);
				this._DISHONESTYDISCIPLINE = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string DISHONESTYTYPE
		{
			get{ return _DISHONESTYTYPE; }
			set
			{
				this.OnPropertyValueChange(_.DISHONESTYTYPE, _DISHONESTYTYPE, value);
				this._DISHONESTYTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUSINESSADDRESS
		{
			get{ return _BUSINESSADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSADDRESS, _BUSINESSADDRESS, value);
				this._BUSINESSADDRESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DEADLINE
		{
			get{ return _DEADLINE; }
			set
			{
				this.OnPropertyValueChange(_.DEADLINE, _DEADLINE, value);
				this._DEADLINE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LAWENFORCEMENTUNIT
		{
			get{ return _LAWENFORCEMENTUNIT; }
			set
			{
				this.OnPropertyValueChange(_.LAWENFORCEMENTUNIT, _LAWENFORCEMENTUNIT, value);
				this._LAWENFORCEMENTUNIT = value;
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
				_.NO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.NO,
				_.ENTERPRISENAME,
				_.BUSINESSNO,
				_.LEGALREPRESENT,
				_.ILLEGAL,
				_.DISHONESTYCONTENT,
				_.DISHONESTYDISCIPLINE,
				_.TM,
				_.DISHONESTYTYPE,
				_.BUSINESSADDRESS,
				_.DEADLINE,
				_.LAWENFORCEMENTUNIT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._NO,
				this._ENTERPRISENAME,
				this._BUSINESSNO,
				this._LEGALREPRESENT,
				this._ILLEGAL,
				this._DISHONESTYCONTENT,
				this._DISHONESTYDISCIPLINE,
				this._TM,
				this._DISHONESTYTYPE,
				this._BUSINESSADDRESS,
				this._DEADLINE,
				this._LAWENFORCEMENTUNIT,
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
			public readonly static Field All = new Field("*", "PT_EXPOSURE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NO = new Field("NO", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISENAME = new Field("ENTERPRISENAME", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUSINESSNO = new Field("BUSINESSNO", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGALREPRESENT = new Field("LEGALREPRESENT", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ILLEGAL = new Field("ILLEGAL", "PT_EXPOSURE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DISHONESTYCONTENT = new Field("DISHONESTYCONTENT", "PT_EXPOSURE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DISHONESTYDISCIPLINE = new Field("DISHONESTYDISCIPLINE", "PT_EXPOSURE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DISHONESTYTYPE = new Field("DISHONESTYTYPE", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUSINESSADDRESS = new Field("BUSINESSADDRESS", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEADLINE = new Field("DEADLINE", "PT_EXPOSURE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LAWENFORCEMENTUNIT = new Field("LAWENFORCEMENTUNIT", "PT_EXPOSURE", "");
        }
        #endregion
	}
}