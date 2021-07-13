using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_EXT_SELFPROVE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_EXT_SELFPROVE")]
    [Serializable]
    public partial class ZJPRI_EXT_SELFPROVE : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _Z_TYPE;
		private string _Z_CONTENT;
		private decimal? _IS_PUBLIC;
		private string _FILES;
		private DateTime? _CREATE_TM;
		private string _LEGAL_NAME;
		private string _LEGAL_CODE;

		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 资料名称
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
		/// 资料类型
		/// </summary>
		public string Z_TYPE
		{
			get{ return _Z_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.Z_TYPE, _Z_TYPE, value);
				this._Z_TYPE = value;
			}
		}
		/// <summary>
		/// 资料类容
		/// </summary>
		public string Z_CONTENT
		{
			get{ return _Z_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.Z_CONTENT, _Z_CONTENT, value);
				this._Z_CONTENT = value;
			}
		}
		/// <summary>
		/// 是否公开
		/// </summary>
		public decimal? IS_PUBLIC
		{
			get{ return _IS_PUBLIC; }
			set
			{
				this.OnPropertyValueChange(_.IS_PUBLIC, _IS_PUBLIC, value);
				this._IS_PUBLIC = value;
			}
		}
		/// <summary>
		/// 资料附件
		/// </summary>
		public string FILES
		{
			get{ return _FILES; }
			set
			{
				this.OnPropertyValueChange(_.FILES, _FILES, value);
				this._FILES = value;
			}
		}
		/// <summary>
		/// 数据时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 企业名称
		/// </summary>
		public string LEGAL_NAME
		{
			get{ return _LEGAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_NAME, _LEGAL_NAME, value);
				this._LEGAL_NAME = value;
			}
		}
		/// <summary>
		/// 社会统一信用代码
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
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
				_.Z_TYPE,
				_.Z_CONTENT,
				_.IS_PUBLIC,
				_.FILES,
				_.CREATE_TM,
				_.LEGAL_NAME,
				_.LEGAL_CODE,
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
				this._Z_TYPE,
				this._Z_CONTENT,
				this._IS_PUBLIC,
				this._FILES,
				this._CREATE_TM,
				this._LEGAL_NAME,
				this._LEGAL_CODE,
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
			public readonly static Field All = new Field("*", "ZJPRI_EXT_SELFPROVE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "ZJPRI_EXT_SELFPROVE", "");
            /// <summary>
			/// 资料名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_EXT_SELFPROVE", "资料名称");
            /// <summary>
			/// 资料类型
			/// </summary>
			public readonly static Field Z_TYPE = new Field("Z_TYPE", "ZJPRI_EXT_SELFPROVE", "资料类型");
            /// <summary>
			/// 资料类容
			/// </summary>
			public readonly static Field Z_CONTENT = new Field("Z_CONTENT", "ZJPRI_EXT_SELFPROVE",DbType.AnsiString, null, "资料类容");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field IS_PUBLIC = new Field("IS_PUBLIC", "ZJPRI_EXT_SELFPROVE", "是否公开");
            /// <summary>
			/// 资料附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "ZJPRI_EXT_SELFPROVE", "资料附件");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "ZJPRI_EXT_SELFPROVE", "数据时间");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "ZJPRI_EXT_SELFPROVE", "企业名称");
            /// <summary>
			/// 社会统一信用代码
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "ZJPRI_EXT_SELFPROVE", "社会统一信用代码");
        }
        #endregion
	}
}