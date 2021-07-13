using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_INDEXSHOW_SET。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_INDEXSHOW_SET")]
    [Serializable]
    public partial class T_INDEXSHOW_SET : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _DIV_ID;
		private string _MODEL_NAME;
		private decimal? _ISSHOW;

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
		/// 控制首页隐藏显示的DIV  id
		/// </summary>
		public string DIV_ID
		{
			get{ return _DIV_ID; }
			set
			{
				this.OnPropertyValueChange(_.DIV_ID, _DIV_ID, value);
				this._DIV_ID = value;
			}
		}
		/// <summary>
		/// 模块简称
		/// </summary>
		public string MODEL_NAME
		{
			get{ return _MODEL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MODEL_NAME, _MODEL_NAME, value);
				this._MODEL_NAME = value;
			}
		}
		/// <summary>
		/// 是否展示 sys_dic type=&#39;28&#39;
		/// </summary>
		public decimal? ISSHOW
		{
			get{ return _ISSHOW; }
			set
			{
				this.OnPropertyValueChange(_.ISSHOW, _ISSHOW, value);
				this._ISSHOW = value;
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
				_.DIV_ID,
				_.MODEL_NAME,
				_.ISSHOW,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DIV_ID,
				this._MODEL_NAME,
				this._ISSHOW,
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
			public readonly static Field All = new Field("*", "T_INDEXSHOW_SET");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_INDEXSHOW_SET", "ID");
            /// <summary>
			/// 控制首页隐藏显示的DIV  id
			/// </summary>
			public readonly static Field DIV_ID = new Field("DIV_ID", "T_INDEXSHOW_SET", "控制首页隐藏显示的DIV  id");
            /// <summary>
			/// 模块简称
			/// </summary>
			public readonly static Field MODEL_NAME = new Field("MODEL_NAME", "T_INDEXSHOW_SET", "模块简称");
            /// <summary>
			/// 是否展示 sys_dic type=&#39;28&#39;
			/// </summary>
			public readonly static Field ISSHOW = new Field("ISSHOW", "T_INDEXSHOW_SET", "是否展示 sys_dic type=&#39;28&#39;");
        }
        #endregion
	}
}