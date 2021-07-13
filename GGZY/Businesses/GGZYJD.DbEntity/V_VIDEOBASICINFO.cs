using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类V_VIDEOBASICINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("V_VIDEOBASICINFO")]
    [Serializable]
    public partial class V_VIDEOBASICINFO : JdEntity
    {
        #region Model
		private decimal? _VID;
		private string _VNAME;
		private string _SERVERIP;
		private string _SERVERPORT;
		private string _LOGINACCOUNT;
		private string _VPASSWORD;
		private decimal? _VISIBLE;
		private string _AREACODE;
		private string _RTYPE;
		private decimal? _ORDER_BY;
		private string _VCODE;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;

		/// <summary>
		/// 
		/// </summary>
		public decimal? VID
		{
			get{ return _VID; }
			set
			{
				this.OnPropertyValueChange(_.VID, _VID, value);
				this._VID = value;
			}
		}
		/// <summary>
		/// 交易场所名称
		/// </summary>
		public string VNAME
		{
			get{ return _VNAME; }
			set
			{
				this.OnPropertyValueChange(_.VNAME, _VNAME, value);
				this._VNAME = value;
			}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string SERVERIP
		{
			get{ return _SERVERIP; }
			set
			{
				this.OnPropertyValueChange(_.SERVERIP, _SERVERIP, value);
				this._SERVERIP = value;
			}
		}
		/// <summary>
		/// 端口
		/// </summary>
		public string SERVERPORT
		{
			get{ return _SERVERPORT; }
			set
			{
				this.OnPropertyValueChange(_.SERVERPORT, _SERVERPORT, value);
				this._SERVERPORT = value;
			}
		}
		/// <summary>
		/// 签名人
		/// </summary>
		public string LOGINACCOUNT
		{
			get{ return _LOGINACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.LOGINACCOUNT, _LOGINACCOUNT, value);
				this._LOGINACCOUNT = value;
			}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string VPASSWORD
		{
			get{ return _VPASSWORD; }
			set
			{
				this.OnPropertyValueChange(_.VPASSWORD, _VPASSWORD, value);
				this._VPASSWORD = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? VISIBLE
		{
			get{ return _VISIBLE; }
			set
			{
				this.OnPropertyValueChange(_.VISIBLE, _VISIBLE, value);
				this._VISIBLE = value;
			}
		}
		/// <summary>
		/// 行政区划
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 插件类型
		/// </summary>
		public string RTYPE
		{
			get{ return _RTYPE; }
			set
			{
				this.OnPropertyValueChange(_.RTYPE, _RTYPE, value);
				this._RTYPE = value;
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
		/// 交易场所代码
		/// </summary>
		public string VCODE
		{
			get{ return _VCODE; }
			set
			{
				this.OnPropertyValueChange(_.VCODE, _VCODE, value);
				this._VCODE = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 创建时间
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.VID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.VID,
				_.VNAME,
				_.SERVERIP,
				_.SERVERPORT,
				_.LOGINACCOUNT,
				_.VPASSWORD,
				_.VISIBLE,
				_.AREACODE,
				_.RTYPE,
				_.ORDER_BY,
				_.VCODE,
				_.CREATE_BY,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._VID,
				this._VNAME,
				this._SERVERIP,
				this._SERVERPORT,
				this._LOGINACCOUNT,
				this._VPASSWORD,
				this._VISIBLE,
				this._AREACODE,
				this._RTYPE,
				this._ORDER_BY,
				this._VCODE,
				this._CREATE_BY,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "V_VIDEOBASICINFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VID = new Field("VID", "V_VIDEOBASICINFO", "");
            /// <summary>
			/// 交易场所名称
			/// </summary>
			public readonly static Field VNAME = new Field("VNAME", "V_VIDEOBASICINFO", "交易场所名称");
            /// <summary>
			/// IP地址
			/// </summary>
			public readonly static Field SERVERIP = new Field("SERVERIP", "V_VIDEOBASICINFO", "IP地址");
            /// <summary>
			/// 端口
			/// </summary>
			public readonly static Field SERVERPORT = new Field("SERVERPORT", "V_VIDEOBASICINFO", "端口");
            /// <summary>
			/// 签名人
			/// </summary>
			public readonly static Field LOGINACCOUNT = new Field("LOGINACCOUNT", "V_VIDEOBASICINFO", "签名人");
            /// <summary>
			/// 密码
			/// </summary>
			public readonly static Field VPASSWORD = new Field("VPASSWORD", "V_VIDEOBASICINFO", "密码");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field VISIBLE = new Field("VISIBLE", "V_VIDEOBASICINFO", "是否启用");
            /// <summary>
			/// 行政区划
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "V_VIDEOBASICINFO", "行政区划");
            /// <summary>
			/// 插件类型
			/// </summary>
			public readonly static Field RTYPE = new Field("RTYPE", "V_VIDEOBASICINFO", "插件类型");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "V_VIDEOBASICINFO", "排序");
            /// <summary>
			/// 交易场所代码
			/// </summary>
			public readonly static Field VCODE = new Field("VCODE", "V_VIDEOBASICINFO", "交易场所代码");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "V_VIDEOBASICINFO", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "V_VIDEOBASICINFO", "创建时间");
        }
        #endregion
	}
}