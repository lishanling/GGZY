using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PC_NODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PC_NODE")]
    [Serializable]
    public partial class T_PC_NODE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _PC_CODE;
		private string _CODE;
		private string _TEXT;
		private decimal? _X;
		private decimal? _Y;
		private decimal? _WIDTH;
		private decimal? _HEIGHT;
		private string _TYPE;

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
		/// 
		/// </summary>
		public string PC_CODE
		{
			get{ return _PC_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PC_CODE, _PC_CODE, value);
				this._PC_CODE = value;
			}
		}
		/// <summary>
		/// 
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
		/// 显示
		/// </summary>
		public string TEXT
		{
			get{ return _TEXT; }
			set
			{
				this.OnPropertyValueChange(_.TEXT, _TEXT, value);
				this._TEXT = value;
			}
		}
		/// <summary>
		/// 横坐标
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
		/// 纵坐标
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
		/// 宽度
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
		/// 高度
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
		/// 节点类型
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
				_.PC_CODE,
				_.CODE,
				_.TEXT,
				_.X,
				_.Y,
				_.WIDTH,
				_.HEIGHT,
				_.TYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PC_CODE,
				this._CODE,
				this._TEXT,
				this._X,
				this._Y,
				this._WIDTH,
				this._HEIGHT,
				this._TYPE,
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
			public readonly static Field All = new Field("*", "T_PC_NODE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PC_NODE", "ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PC_CODE = new Field("PC_CODE", "T_PC_NODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_PC_NODE", "");
            /// <summary>
			/// 显示
			/// </summary>
			public readonly static Field TEXT = new Field("TEXT", "T_PC_NODE", "显示");
            /// <summary>
			/// 横坐标
			/// </summary>
			public readonly static Field X = new Field("X", "T_PC_NODE", "横坐标");
            /// <summary>
			/// 纵坐标
			/// </summary>
			public readonly static Field Y = new Field("Y", "T_PC_NODE", "纵坐标");
            /// <summary>
			/// 宽度
			/// </summary>
			public readonly static Field WIDTH = new Field("WIDTH", "T_PC_NODE", "宽度");
            /// <summary>
			/// 高度
			/// </summary>
			public readonly static Field HEIGHT = new Field("HEIGHT", "T_PC_NODE", "高度");
            /// <summary>
			/// 节点类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_PC_NODE", "节点类型");
        }
        #endregion
	}
}