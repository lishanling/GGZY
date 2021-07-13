using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_RP_ST_TREE_NODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RP_ST_TREE_NODE")]
    [Serializable]
    public partial class T_RP_ST_TREE_NODE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TREE_CODE;
		private string _NAME;
		private string _P_CODE;
		private string _STCD;
		private decimal? _ORDER_ID;

		/// <summary>
		/// 
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
		public string STCD
		{
			get{ return _STCD; }
			set
			{
				this.OnPropertyValueChange(_.STCD, _STCD, value);
				this._STCD = value;
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
				_.TREE_CODE,
				_.NAME,
				_.P_CODE,
				_.STCD,
				_.ORDER_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TREE_CODE,
				this._NAME,
				this._P_CODE,
				this._STCD,
				this._ORDER_ID,
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
			public readonly static Field All = new Field("*", "T_RP_ST_TREE_NODE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RP_ST_TREE_NODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TREE_CODE = new Field("TREE_CODE", "T_RP_ST_TREE_NODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_RP_ST_TREE_NODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field P_CODE = new Field("P_CODE", "T_RP_ST_TREE_NODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD = new Field("STCD", "T_RP_ST_TREE_NODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "T_RP_ST_TREE_NODE", "");
        }
        #endregion
	}
}