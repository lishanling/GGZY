using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZY_JIEKOU_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZY_JIEKOU_USER")]
    [Serializable]
    public partial class ZY_JIEKOU_USER : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _USERNAME;
		private string _APP_ID;
		private string _APP_SECRET;
		private string _TYPE;
		private string _REMARK;
		private string _FTP_ID;
		private string _FTP_SECRET;
		private string _URL_SECRET;

		/// <summary>
		/// id
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
		/// 用户名
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
		/// 接口账号
		/// </summary>
		public string APP_ID
		{
			get{ return _APP_ID; }
			set
			{
				this.OnPropertyValueChange(_.APP_ID, _APP_ID, value);
				this._APP_ID = value;
			}
		}
		/// <summary>
		/// 接口密码
		/// </summary>
		public string APP_SECRET
		{
			get{ return _APP_SECRET; }
			set
			{
				this.OnPropertyValueChange(_.APP_SECRET, _APP_SECRET, value);
				this._APP_SECRET = value;
			}
		}
		/// <summary>
		/// 所应用于某个接口
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
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// FTP账号
		/// </summary>
		public string FTP_ID
		{
			get{ return _FTP_ID; }
			set
			{
				this.OnPropertyValueChange(_.FTP_ID, _FTP_ID, value);
				this._FTP_ID = value;
			}
		}
		/// <summary>
		/// FTP密码
		/// </summary>
		public string FTP_SECRET
		{
			get{ return _FTP_SECRET; }
			set
			{
				this.OnPropertyValueChange(_.FTP_SECRET, _FTP_SECRET, value);
				this._FTP_SECRET = value;
			}
		}
		/// <summary>
		/// URL密钥
		/// </summary>
		public string URL_SECRET
		{
			get{ return _URL_SECRET; }
			set
			{
				this.OnPropertyValueChange(_.URL_SECRET, _URL_SECRET, value);
				this._URL_SECRET = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.USERNAME,
				_.APP_ID,
				_.APP_SECRET,
				_.TYPE,
				_.REMARK,
				_.FTP_ID,
				_.FTP_SECRET,
				_.URL_SECRET,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._USERNAME,
				this._APP_ID,
				this._APP_SECRET,
				this._TYPE,
				this._REMARK,
				this._FTP_ID,
				this._FTP_SECRET,
				this._URL_SECRET,
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
			public readonly static Field All = new Field("*", "ZY_JIEKOU_USER");
            /// <summary>
			/// id
			/// </summary>
			public readonly static Field ID = new Field("ID", "ZY_JIEKOU_USER", "id");
            /// <summary>
			/// 用户名
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "ZY_JIEKOU_USER", "用户名");
            /// <summary>
			/// 接口账号
			/// </summary>
			public readonly static Field APP_ID = new Field("APP_ID", "ZY_JIEKOU_USER", "接口账号");
            /// <summary>
			/// 接口密码
			/// </summary>
			public readonly static Field APP_SECRET = new Field("APP_SECRET", "ZY_JIEKOU_USER", "接口密码");
            /// <summary>
			/// 所应用于某个接口
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "ZY_JIEKOU_USER", "所应用于某个接口");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "ZY_JIEKOU_USER", "备注");
            /// <summary>
			/// FTP账号
			/// </summary>
			public readonly static Field FTP_ID = new Field("FTP_ID", "ZY_JIEKOU_USER", "FTP账号");
            /// <summary>
			/// FTP密码
			/// </summary>
			public readonly static Field FTP_SECRET = new Field("FTP_SECRET", "ZY_JIEKOU_USER", "FTP密码");
            /// <summary>
			/// URL密钥
			/// </summary>
			public readonly static Field URL_SECRET = new Field("URL_SECRET", "ZY_JIEKOU_USER", "URL密钥");
        }
        #endregion
	}
}