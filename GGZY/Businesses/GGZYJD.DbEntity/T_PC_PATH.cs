using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PC_PATH。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PC_PATH")]
    [Serializable]
    public partial class T_PC_PATH : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _PC_CODE;
		private string _FROM_NODE;
		private string _TO_NODE;
		private string _TEXT;
		private decimal? _X;
		private decimal? _Y;
		private string _DOTS;
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
		/// 流程图编码
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
		/// 起始节点
		/// </summary>
		public string FROM_NODE
		{
			get{ return _FROM_NODE; }
			set
			{
				this.OnPropertyValueChange(_.FROM_NODE, _FROM_NODE, value);
				this._FROM_NODE = value;
			}
		}
		/// <summary>
		/// 指向节点
		/// </summary>
		public string TO_NODE
		{
			get{ return _TO_NODE; }
			set
			{
				this.OnPropertyValueChange(_.TO_NODE, _TO_NODE, value);
				this._TO_NODE = value;
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
		/// 点列表配置：JSON格式
		/// </summary>
		public string DOTS
		{
			get{ return _DOTS; }
			set
			{
				this.OnPropertyValueChange(_.DOTS, _DOTS, value);
				this._DOTS = value;
			}
		}
		/// <summary>
		/// 路径类型
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
				_.FROM_NODE,
				_.TO_NODE,
				_.TEXT,
				_.X,
				_.Y,
				_.DOTS,
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
				this._FROM_NODE,
				this._TO_NODE,
				this._TEXT,
				this._X,
				this._Y,
				this._DOTS,
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
			public readonly static Field All = new Field("*", "T_PC_PATH");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PC_PATH", "ID");
            /// <summary>
			/// 流程图编码
			/// </summary>
			public readonly static Field PC_CODE = new Field("PC_CODE", "T_PC_PATH", "流程图编码");
            /// <summary>
			/// 起始节点
			/// </summary>
			public readonly static Field FROM_NODE = new Field("FROM_NODE", "T_PC_PATH", "起始节点");
            /// <summary>
			/// 指向节点
			/// </summary>
			public readonly static Field TO_NODE = new Field("TO_NODE", "T_PC_PATH", "指向节点");
            /// <summary>
			/// 显示
			/// </summary>
			public readonly static Field TEXT = new Field("TEXT", "T_PC_PATH", "显示");
            /// <summary>
			/// 横坐标
			/// </summary>
			public readonly static Field X = new Field("X", "T_PC_PATH", "横坐标");
            /// <summary>
			/// 纵坐标
			/// </summary>
			public readonly static Field Y = new Field("Y", "T_PC_PATH", "纵坐标");
            /// <summary>
			/// 点列表配置：JSON格式
			/// </summary>
			public readonly static Field DOTS = new Field("DOTS", "T_PC_PATH", "点列表配置：JSON格式");
            /// <summary>
			/// 路径类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_PC_PATH", "路径类型");
        }
        #endregion
	}
}