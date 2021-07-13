using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER_MENU。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_MENU")]
    [Serializable]
    public partial class T_USER_MENU : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _PID;
		private string _NAME;
		private decimal? _ORDER_BY;
		private string _URL;
		private string _IMG;
		private decimal? _IS_DEFAULT;
		private decimal? _IS_EANBLED;
		private decimal? _ISURL;
		private decimal? _HEIGHT;
		private decimal? _WIDTH;
		private string _POWER_STR;

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
		/// 父节点编号
		/// </summary>
		public decimal? PID
		{
			get{ return _PID; }
			set
			{
				this.OnPropertyValueChange(_.PID, _PID, value);
				this._PID = value;
			}
		}
		/// <summary>
		/// 菜单名称
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
		/// <summary>
		/// 导航地址
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
		/// 图片路径
		/// </summary>
		public string IMG
		{
			get{ return _IMG; }
			set
			{
				this.OnPropertyValueChange(_.IMG, _IMG, value);
				this._IMG = value;
			}
		}
		/// <summary>
		/// 默认展示
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
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? IS_EANBLED
		{
			get{ return _IS_EANBLED; }
			set
			{
				this.OnPropertyValueChange(_.IS_EANBLED, _IS_EANBLED, value);
				this._IS_EANBLED = value;
			}
		}
		/// <summary>
		/// 是否地址连接
		/// </summary>
		public decimal? ISURL
		{
			get{ return _ISURL; }
			set
			{
				this.OnPropertyValueChange(_.ISURL, _ISURL, value);
				this._ISURL = value;
			}
		}
		/// <summary>
		/// 高
		/// </summary>
		public decimal? HEIGHT
		{
			get{ return _HEIGHT; }
			set
			{
				this.OnPropertyValueChange(_.HEIGHT, _HEIGHT, value);
				this._HEIGHT = value;
			}
		}
		/// <summary>
		/// 宽
		/// </summary>
		public decimal? WIDTH
		{
			get{ return _WIDTH; }
			set
			{
				this.OnPropertyValueChange(_.WIDTH, _WIDTH, value);
				this._WIDTH = value;
			}
		}
		/// <summary>
		/// 拥有的权限用逗号隔开
		/// </summary>
		public string POWER_STR
		{
			get{ return _POWER_STR; }
			set
			{
				this.OnPropertyValueChange(_.POWER_STR, _POWER_STR, value);
				this._POWER_STR = value;
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
				_.PID,
				_.NAME,
				_.ORDER_BY,
				_.URL,
				_.IMG,
				_.IS_DEFAULT,
				_.IS_EANBLED,
				_.ISURL,
				_.HEIGHT,
				_.WIDTH,
				_.POWER_STR,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PID,
				this._NAME,
				this._ORDER_BY,
				this._URL,
				this._IMG,
				this._IS_DEFAULT,
				this._IS_EANBLED,
				this._ISURL,
				this._HEIGHT,
				this._WIDTH,
				this._POWER_STR,
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
			public readonly static Field All = new Field("*", "T_USER_MENU");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_MENU", "ID");
            /// <summary>
			/// 父节点编号
			/// </summary>
			public readonly static Field PID = new Field("PID", "T_USER_MENU", "父节点编号");
            /// <summary>
			/// 菜单名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_USER_MENU", "菜单名称");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_USER_MENU", "排序");
            /// <summary>
			/// 导航地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_USER_MENU", "导航地址");
            /// <summary>
			/// 图片路径
			/// </summary>
			public readonly static Field IMG = new Field("IMG", "T_USER_MENU", "图片路径");
            /// <summary>
			/// 默认展示
			/// </summary>
			public readonly static Field IS_DEFAULT = new Field("IS_DEFAULT", "T_USER_MENU", "默认展示");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field IS_EANBLED = new Field("IS_EANBLED", "T_USER_MENU", "是否启用");
            /// <summary>
			/// 是否地址连接
			/// </summary>
			public readonly static Field ISURL = new Field("ISURL", "T_USER_MENU", "是否地址连接");
            /// <summary>
			/// 高
			/// </summary>
			public readonly static Field HEIGHT = new Field("HEIGHT", "T_USER_MENU", "高");
            /// <summary>
			/// 宽
			/// </summary>
			public readonly static Field WIDTH = new Field("WIDTH", "T_USER_MENU", "宽");
            /// <summary>
			/// 拥有的权限用逗号隔开
			/// </summary>
			public readonly static Field POWER_STR = new Field("POWER_STR", "T_USER_MENU", "拥有的权限用逗号隔开");
        }
        #endregion
	}
}