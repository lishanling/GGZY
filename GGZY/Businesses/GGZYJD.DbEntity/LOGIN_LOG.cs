using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类LOGIN_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("LOGIN_LOG")]
    [Serializable]
    public partial class LOGIN_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _REMOTE_ADDR;
		private string _HTTP_VIA;
		private string _HTTP_X_FORWARDED_FOR;
		private string _USERNAME;
		private DateTime? _TM;

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
		/// 最后的ip
		/// </summary>
		public string REMOTE_ADDR
		{
			get{ return _REMOTE_ADDR; }
			set
			{
				this.OnPropertyValueChange(_.REMOTE_ADDR, _REMOTE_ADDR, value);
				this._REMOTE_ADDR = value;
			}
		}
		/// <summary>
		/// 代理服务器ip
		/// </summary>
		public string HTTP_VIA
		{
			get{ return _HTTP_VIA; }
			set
			{
				this.OnPropertyValueChange(_.HTTP_VIA, _HTTP_VIA, value);
				this._HTTP_VIA = value;
			}
		}
		/// <summary>
		/// 经过的代理ip
		/// </summary>
		public string HTTP_X_FORWARDED_FOR
		{
			get{ return _HTTP_X_FORWARDED_FOR; }
			set
			{
				this.OnPropertyValueChange(_.HTTP_X_FORWARDED_FOR, _HTTP_X_FORWARDED_FOR, value);
				this._HTTP_X_FORWARDED_FOR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERNAME
		{
			get{ return _USERNAME; }
			set
			{
				this.OnPropertyValueChange(_.USERNAME, _USERNAME, value);
				this._USERNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
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
				_.REMOTE_ADDR,
				_.HTTP_VIA,
				_.HTTP_X_FORWARDED_FOR,
				_.USERNAME,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REMOTE_ADDR,
				this._HTTP_VIA,
				this._HTTP_X_FORWARDED_FOR,
				this._USERNAME,
				this._TM,
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
			public readonly static Field All = new Field("*", "LOGIN_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "LOGIN_LOG", "");
            /// <summary>
			/// 最后的ip
			/// </summary>
			public readonly static Field REMOTE_ADDR = new Field("REMOTE_ADDR", "LOGIN_LOG", "最后的ip");
            /// <summary>
			/// 代理服务器ip
			/// </summary>
			public readonly static Field HTTP_VIA = new Field("HTTP_VIA", "LOGIN_LOG", "代理服务器ip");
            /// <summary>
			/// 经过的代理ip
			/// </summary>
			public readonly static Field HTTP_X_FORWARDED_FOR = new Field("HTTP_X_FORWARDED_FOR", "LOGIN_LOG", "经过的代理ip");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "LOGIN_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "LOGIN_LOG", "");
        }
        #endregion
	}
}