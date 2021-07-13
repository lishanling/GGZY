using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_RP_ST_TREE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RP_ST_TREE")]
    [Serializable]
    public partial class T_RP_ST_TREE : FwEntity
    {
        #region Model
		private string _RP_CODE;
		private string _TREE_CODE;
		private string _NAME;
		private decimal? _TYPE;
		private string _URL;
		private decimal? _ORDER_ID;
		private string _CREATE_BY;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_CHECK;
		private decimal? _TREE_CHECK_TYPE;
		private string _TREE_PARAM;

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
		public string TREE_CODE
		{
			get{ return _TREE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TREE_CODE, _TREE_CODE, value);
				this._TREE_CODE = value;
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
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
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
		public decimal? IS_CHECK
		{
			get{ return _IS_CHECK; }
			set
			{
				this.OnPropertyValueChange(_.IS_CHECK, _IS_CHECK, value);
				this._IS_CHECK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TREE_CHECK_TYPE
		{
			get{ return _TREE_CHECK_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TREE_CHECK_TYPE, _TREE_CHECK_TYPE, value);
				this._TREE_CHECK_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TREE_PARAM
		{
			get{ return _TREE_PARAM; }
			set
			{
				this.OnPropertyValueChange(_.TREE_PARAM, _TREE_PARAM, value);
				this._TREE_PARAM = value;
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
				_.TREE_CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.RP_CODE,
				_.TREE_CODE,
				_.NAME,
				_.TYPE,
				_.URL,
				_.ORDER_ID,
				_.CREATE_BY,
				_.CREATE_TIME,
				_.IS_CHECK,
				_.TREE_CHECK_TYPE,
				_.TREE_PARAM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._RP_CODE,
				this._TREE_CODE,
				this._NAME,
				this._TYPE,
				this._URL,
				this._ORDER_ID,
				this._CREATE_BY,
				this._CREATE_TIME,
				this._IS_CHECK,
				this._TREE_CHECK_TYPE,
				this._TREE_PARAM,
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
			public readonly static Field All = new Field("*", "T_RP_ST_TREE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_CODE = new Field("RP_CODE", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TREE_CODE = new Field("TREE_CODE", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_CHECK = new Field("IS_CHECK", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TREE_CHECK_TYPE = new Field("TREE_CHECK_TYPE", "T_RP_ST_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TREE_PARAM = new Field("TREE_PARAM", "T_RP_ST_TREE", "");
        }
        #endregion
	}
}