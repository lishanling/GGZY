using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_BASE_TRADE_CENTER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_BASE_TRADE_CENTER")]
    [Serializable]
    public partial class T_BASE_TRADE_CENTER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _LINK;
		private string _AREACODE;
		private decimal? _X;
		private decimal? _Y;
		private decimal? _ORDER_BY;

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
		/// 链接
		/// </summary>
		public string LINK
		{
			get{ return _LINK; }
			set
			{
				this.OnPropertyValueChange(_.LINK, _LINK, value);
				this._LINK = value;
			}
		}
		/// <summary>
		/// 行政区划
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// X
		/// </summary>
		public decimal? X
		{
			get{ return _X; }
			set
			{
				this.OnPropertyValueChange(_.X, _X, value);
				this._X = value;
			}
		}
		/// <summary>
		/// Y
		/// </summary>
		public decimal? Y
		{
			get{ return _Y; }
			set
			{
				this.OnPropertyValueChange(_.Y, _Y, value);
				this._Y = value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public decimal? ORDER_BY
		{
			get{ return _ORDER_BY; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_BY, _ORDER_BY, value);
				this._ORDER_BY = value;
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
				_.LINK,
				_.AREACODE,
				_.X,
				_.Y,
				_.ORDER_BY,
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
				this._LINK,
				this._AREACODE,
				this._X,
				this._Y,
				this._ORDER_BY,
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
			public readonly static Field All = new Field("*", "T_BASE_TRADE_CENTER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_BASE_TRADE_CENTER", "ID");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_BASE_TRADE_CENTER", "名称");
            /// <summary>
			/// 链接
			/// </summary>
			public readonly static Field LINK = new Field("LINK", "T_BASE_TRADE_CENTER", "链接");
            /// <summary>
			/// 行政区划
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "T_BASE_TRADE_CENTER", "行政区划");
            /// <summary>
			/// X
			/// </summary>
			public readonly static Field X = new Field("X", "T_BASE_TRADE_CENTER", "X");
            /// <summary>
			/// Y
			/// </summary>
			public readonly static Field Y = new Field("Y", "T_BASE_TRADE_CENTER", "Y");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_BASE_TRADE_CENTER", "排序");
        }
        #endregion
	}
}