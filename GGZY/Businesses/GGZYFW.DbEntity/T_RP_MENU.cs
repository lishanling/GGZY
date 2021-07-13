using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_RP_MENU。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RP_MENU")]
    [Serializable]
    public partial class T_RP_MENU : FwEntity
    {
        #region Model
		private string _MENU_CODE;
		private string _P_CODE;
		private string _NAME;
		private decimal? _ORDER_ID;
		private string _CREATE_BY;
		private DateTime? _CREATE_TIME;
		private string _SYS_CODE;
		private decimal? _IS_VISIBLE;
		private string _URL;
		private string _RP_CODE;
		private decimal? _IS_DEFAULT;

		/// <summary>
		/// 
		/// </summary>
		public string MENU_CODE
		{
			get{ return _MENU_CODE; }
			set
			{
				this.OnPropertyValueChange(_.MENU_CODE, _MENU_CODE, value);
				this._MENU_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string P_CODE
		{
			get{ return _P_CODE; }
			set
			{
				this.OnPropertyValueChange(_.P_CODE, _P_CODE, value);
				this._P_CODE = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal? ORDER_ID
		{
			get{ return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYS_CODE
		{
			get{ return _SYS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SYS_CODE, _SYS_CODE, value);
				this._SYS_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_VISIBLE
		{
			get{ return _IS_VISIBLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_VISIBLE, _IS_VISIBLE, value);
				this._IS_VISIBLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RP_CODE
		{
			get{ return _RP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RP_CODE, _RP_CODE, value);
				this._RP_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_DEFAULT
		{
			get{ return _IS_DEFAULT; }
			set
			{
				this.OnPropertyValueChange(_.IS_DEFAULT, _IS_DEFAULT, value);
				this._IS_DEFAULT = value;
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
				_.MENU_CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.MENU_CODE,
				_.P_CODE,
				_.NAME,
				_.ORDER_ID,
				_.CREATE_BY,
				_.CREATE_TIME,
				_.SYS_CODE,
				_.IS_VISIBLE,
				_.URL,
				_.RP_CODE,
				_.IS_DEFAULT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MENU_CODE,
				this._P_CODE,
				this._NAME,
				this._ORDER_ID,
				this._CREATE_BY,
				this._CREATE_TIME,
				this._SYS_CODE,
				this._IS_VISIBLE,
				this._URL,
				this._RP_CODE,
				this._IS_DEFAULT,
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
			public readonly static Field All = new Field("*", "T_RP_MENU");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MENU_CODE = new Field("MENU_CODE", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field P_CODE = new Field("P_CODE", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYS_CODE = new Field("SYS_CODE", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_VISIBLE = new Field("IS_VISIBLE", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_CODE = new Field("RP_CODE", "T_RP_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_DEFAULT = new Field("IS_DEFAULT", "T_RP_MENU", "");
        }
        #endregion
	}
}