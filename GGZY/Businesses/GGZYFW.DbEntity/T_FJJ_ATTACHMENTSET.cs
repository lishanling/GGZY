using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_FJJ_ATTACHMENTSET。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_FJJ_ATTACHMENTSET")]
    [Serializable]
    public partial class T_FJJ_ATTACHMENTSET : FwEntity
    {
        #region Model
		private string _ATTACHMENTSETCODE;
		private decimal? _ATTACHMENTCOUNT;
		private string _ATTACHMENTCODE;
		private string _ATTACHMENTNAME;
		private string _ATTACHMENTTYPE;
		private string _MD5;
		private string _ATTACHMENTFILENAME;
		private string _URL;

		/// <summary>
		/// 附件关联数据集标识符
		/// </summary>
		public string ATTACHMENTSETCODE
		{
			get{ return _ATTACHMENTSETCODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTSETCODE, _ATTACHMENTSETCODE, value);
				this._ATTACHMENTSETCODE = value;
			}
		}
		/// <summary>
		/// 关联附件数量
		/// </summary>
		public decimal? ATTACHMENTCOUNT
		{
			get{ return _ATTACHMENTCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTCOUNT, _ATTACHMENTCOUNT, value);
				this._ATTACHMENTCOUNT = value;
			}
		}
		/// <summary>
		/// 附件关联标识号
		/// </summary>
		public string ATTACHMENTCODE
		{
			get{ return _ATTACHMENTCODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTCODE, _ATTACHMENTCODE, value);
				this._ATTACHMENTCODE = value;
			}
		}
		/// <summary>
		/// 附件名称
		/// </summary>
		public string ATTACHMENTNAME
		{
			get{ return _ATTACHMENTNAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTNAME, _ATTACHMENTNAME, value);
				this._ATTACHMENTNAME = value;
			}
		}
		/// <summary>
		/// 附件类型
		/// </summary>
		public string ATTACHMENTTYPE
		{
			get{ return _ATTACHMENTTYPE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTTYPE, _ATTACHMENTTYPE, value);
				this._ATTACHMENTTYPE = value;
			}
		}
		/// <summary>
		/// MD5检验码
		/// </summary>
		public string MD5
		{
			get{ return _MD5; }
			set
			{
				this.OnPropertyValueChange(_.MD5, _MD5, value);
				this._MD5 = value;
			}
		}
		/// <summary>
		/// 附件文件名
		/// </summary>
		public string ATTACHMENTFILENAME
		{
			get{ return _ATTACHMENTFILENAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTFILENAME, _ATTACHMENTFILENAME, value);
				this._ATTACHMENTFILENAME = value;
			}
		}
		/// <summary>
		/// 附件URL地址
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ATTACHMENTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ATTACHMENTSETCODE,
				_.ATTACHMENTCOUNT,
				_.ATTACHMENTCODE,
				_.ATTACHMENTNAME,
				_.ATTACHMENTTYPE,
				_.MD5,
				_.ATTACHMENTFILENAME,
				_.URL,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ATTACHMENTSETCODE,
				this._ATTACHMENTCOUNT,
				this._ATTACHMENTCODE,
				this._ATTACHMENTNAME,
				this._ATTACHMENTTYPE,
				this._MD5,
				this._ATTACHMENTFILENAME,
				this._URL,
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
			public readonly static Field All = new Field("*", "T_FJJ_ATTACHMENTSET");
            /// <summary>
			/// 附件关联数据集标识符
			/// </summary>
			public readonly static Field ATTACHMENTSETCODE = new Field("ATTACHMENTSETCODE", "T_FJJ_ATTACHMENTSET",DbType.AnsiString, null, "附件关联数据集标识符");
            /// <summary>
			/// 关联附件数量
			/// </summary>
			public readonly static Field ATTACHMENTCOUNT = new Field("ATTACHMENTCOUNT", "T_FJJ_ATTACHMENTSET", "关联附件数量");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_FJJ_ATTACHMENTSET", "附件关联标识号");
            /// <summary>
			/// 附件名称
			/// </summary>
			public readonly static Field ATTACHMENTNAME = new Field("ATTACHMENTNAME", "T_FJJ_ATTACHMENTSET", "附件名称");
            /// <summary>
			/// 附件类型
			/// </summary>
			public readonly static Field ATTACHMENTTYPE = new Field("ATTACHMENTTYPE", "T_FJJ_ATTACHMENTSET", "附件类型");
            /// <summary>
			/// MD5检验码
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "T_FJJ_ATTACHMENTSET", "MD5检验码");
            /// <summary>
			/// 附件文件名
			/// </summary>
			public readonly static Field ATTACHMENTFILENAME = new Field("ATTACHMENTFILENAME", "T_FJJ_ATTACHMENTSET", "附件文件名");
            /// <summary>
			/// 附件URL地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_FJJ_ATTACHMENTSET", "附件URL地址");
        }
        #endregion
	}
}