using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_TXTEDIT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_TXTEDIT")]
    [Serializable]
    public partial class PT_TXTEDIT : JdEntity
    {
        #region Model
		private string _CODE;
		private string _NAME;
		private string _FILEPATH;
		private decimal? _CTYPE;
		private string _CONTENT;
		private decimal? _GTYPE;

		/// <summary>
		/// 文本编码
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
		/// 文本名称
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
		/// 文件地址
		/// </summary>
		public string FILEPATH
		{
			get{ return _FILEPATH; }
			set
			{
				this.OnPropertyValueChange(_.FILEPATH, _FILEPATH, value);
				this._FILEPATH = value;
			}
		}
		/// <summary>
		/// 编辑框类型0(文本)1(富文本)，默认0
		/// </summary>
		public decimal? CTYPE
		{
			get{ return _CTYPE; }
			set
			{
				this.OnPropertyValueChange(_.CTYPE, _CTYPE, value);
				this._CTYPE = value;
			}
		}
		/// <summary>
		/// 文本内容
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 获取类型0(数据库)，1(文件地址)
		/// </summary>
		public decimal? GTYPE
		{
			get{ return _GTYPE; }
			set
			{
				this.OnPropertyValueChange(_.GTYPE, _GTYPE, value);
				this._GTYPE = value;
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
				_.CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.CODE,
				_.NAME,
				_.FILEPATH,
				_.CTYPE,
				_.CONTENT,
				_.GTYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._CODE,
				this._NAME,
				this._FILEPATH,
				this._CTYPE,
				this._CONTENT,
				this._GTYPE,
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
			public readonly static Field All = new Field("*", "PT_TXTEDIT");
            /// <summary>
			/// 文本编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "PT_TXTEDIT", "文本编码");
            /// <summary>
			/// 文本名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "PT_TXTEDIT", "文本名称");
            /// <summary>
			/// 文件地址
			/// </summary>
			public readonly static Field FILEPATH = new Field("FILEPATH", "PT_TXTEDIT", "文件地址");
            /// <summary>
			/// 编辑框类型0(文本)1(富文本)，默认0
			/// </summary>
			public readonly static Field CTYPE = new Field("CTYPE", "PT_TXTEDIT", "编辑框类型0(文本)1(富文本)，默认0");
            /// <summary>
			/// 文本内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "PT_TXTEDIT", "文本内容");
            /// <summary>
			/// 获取类型0(数据库)，1(文件地址)
			/// </summary>
			public readonly static Field GTYPE = new Field("GTYPE", "PT_TXTEDIT", "获取类型0(数据库)，1(文件地址)");
        }
        #endregion
	}
}