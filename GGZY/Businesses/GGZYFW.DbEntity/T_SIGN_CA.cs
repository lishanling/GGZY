using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SIGN_CA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SIGN_CA")]
    [Serializable]
    public partial class T_SIGN_CA : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _URL_PROTOCOL;
		private decimal? _ORDER_BY;
		private string _IMG;
		private string _UPLOAD_URL;

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
		/// ca公司名称
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
		/// URL协议名称
		/// </summary>
		public string URL_PROTOCOL
		{
			get{ return _URL_PROTOCOL; }
			set
			{
				this.OnPropertyValueChange(_.URL_PROTOCOL, _URL_PROTOCOL, value);
				this._URL_PROTOCOL = value;
			}
		}
		/// <summary>
		/// 
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
		/// 图片
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
		/// 签章完上传文件的地址
		/// </summary>
		public string UPLOAD_URL
		{
			get{ return _UPLOAD_URL; }
			set
			{
				this.OnPropertyValueChange(_.UPLOAD_URL, _UPLOAD_URL, value);
				this._UPLOAD_URL = value;
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
				_.URL_PROTOCOL,
				_.ORDER_BY,
				_.IMG,
				_.UPLOAD_URL,
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
				this._URL_PROTOCOL,
				this._ORDER_BY,
				this._IMG,
				this._UPLOAD_URL,
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
			public readonly static Field All = new Field("*", "T_SIGN_CA");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SIGN_CA", "");
            /// <summary>
			/// ca公司名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_SIGN_CA", "ca公司名称");
            /// <summary>
			/// URL协议名称
			/// </summary>
			public readonly static Field URL_PROTOCOL = new Field("URL_PROTOCOL", "T_SIGN_CA", "URL协议名称");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_SIGN_CA", "");
            /// <summary>
			/// 图片
			/// </summary>
			public readonly static Field IMG = new Field("IMG", "T_SIGN_CA", "图片");
            /// <summary>
			/// 签章完上传文件的地址
			/// </summary>
			public readonly static Field UPLOAD_URL = new Field("UPLOAD_URL", "T_SIGN_CA", "签章完上传文件的地址");
        }
        #endregion
	}
}