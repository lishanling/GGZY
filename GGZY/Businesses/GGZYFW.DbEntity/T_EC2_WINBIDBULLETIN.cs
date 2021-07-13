using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_WINBIDBULLETIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_WINBIDBULLETIN")]
    [Serializable]
    public partial class T_EC2_WINBIDBULLETIN : FwEntity
    {
        #region Model
		private string _WINBIDBULLETINCODE;
		private string _TENDERPROJECTCODE;
		private string _TENDERPROJECTNAME;
		private string _BIDSECTIONCODES;
		private string _BULLETINNAME;
		private string _BULLETINTYPE;
		private DateTime? _BULLETINISSUETIME;
		private string _BULLETINCONTENT;
		private string _URL;
		private string _ATTACHMENTCODE;
		private DateTime? _VERSION;
		private string _ISOPEN;
		private string _OPENTYPE;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private DateTime? _VERIFYTIME;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 中标公告编号
		/// </summary>
		public string WINBIDBULLETINCODE
		{
			get{ return _WINBIDBULLETINCODE; }
			set
			{
				this.OnPropertyValueChange(_.WINBIDBULLETINCODE, _WINBIDBULLETINCODE, value);
				this._WINBIDBULLETINCODE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDERPROJECTCODE
		{
			get{ return _TENDERPROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTCODE, _TENDERPROJECTCODE, value);
				this._TENDERPROJECTCODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDERPROJECTNAME
		{
			get{ return _TENDERPROJECTNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTNAME, _TENDERPROJECTNAME, value);
				this._TENDERPROJECTNAME = value;
			}
		}
		/// <summary>
		/// 相关标段（包）编号
		/// </summary>
		public string BIDSECTIONCODES
		{
			get{ return _BIDSECTIONCODES; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONCODES, _BIDSECTIONCODES, value);
				this._BIDSECTIONCODES = value;
			}
		}
		/// <summary>
		/// 公告名称
		/// </summary>
		public string BULLETINNAME
		{
			get{ return _BULLETINNAME; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINNAME, _BULLETINNAME, value);
				this._BULLETINNAME = value;
			}
		}
		/// <summary>
		/// 公告类型
		/// </summary>
		public string BULLETINTYPE
		{
			get{ return _BULLETINTYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINTYPE, _BULLETINTYPE, value);
				this._BULLETINTYPE = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? BULLETINISSUETIME
		{
			get{ return _BULLETINISSUETIME; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINISSUETIME, _BULLETINISSUETIME, value);
				this._BULLETINISSUETIME = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string BULLETINCONTENT
		{
			get{ return _BULLETINCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINCONTENT, _BULLETINCONTENT, value);
				this._BULLETINCONTENT = value;
			}
		}
		/// <summary>
		/// 源URL
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
		/// 版本号
		/// </summary>
		public DateTime? VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 是否公开
		/// </summary>
		public string ISOPEN
		{
			get{ return _ISOPEN; }
			set
			{
				this.OnPropertyValueChange(_.ISOPEN, _ISOPEN, value);
				this._ISOPEN = value;
			}
		}
		/// <summary>
		/// 公开类型
		/// </summary>
		public string OPENTYPE
		{
			get{ return _OPENTYPE; }
			set
			{
				this.OnPropertyValueChange(_.OPENTYPE, _OPENTYPE, value);
				this._OPENTYPE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人姓名
		/// </summary>
		public string EXAMINERNAME
		{
			get{ return _EXAMINERNAME; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERNAME, _EXAMINERNAME, value);
				this._EXAMINERNAME = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人证件类型
		/// </summary>
		public string EXAMINERCODETYPE
		{
			get{ return _EXAMINERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERCODETYPE, _EXAMINERCODETYPE, value);
				this._EXAMINERCODETYPE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人证件号码
		/// </summary>
		public string EXAMINERCODE
		{
			get{ return _EXAMINERCODE; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERCODE, _EXAMINERCODE, value);
				this._EXAMINERCODE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证时间
		/// </summary>
		public DateTime? VERIFYTIME
		{
			get{ return _VERIFYTIME; }
			set
			{
				this.OnPropertyValueChange(_.VERIFYTIME, _VERIFYTIME, value);
				this._VERIFYTIME = value;
			}
		}
		/// <summary>
		/// 数据源
		/// </summary>
		public string DATA_SOURCE
		{
			get{ return _DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.DATA_SOURCE, _DATA_SOURCE, value);
				this._DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 数据时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
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
				_.WINBIDBULLETINCODE,
				_.TENDERPROJECTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.WINBIDBULLETINCODE,
				_.TENDERPROJECTCODE,
				_.TENDERPROJECTNAME,
				_.BIDSECTIONCODES,
				_.BULLETINNAME,
				_.BULLETINTYPE,
				_.BULLETINISSUETIME,
				_.BULLETINCONTENT,
				_.URL,
				_.ATTACHMENTCODE,
				_.VERSION,
				_.ISOPEN,
				_.OPENTYPE,
				_.EXAMINERNAME,
				_.EXAMINERCODETYPE,
				_.EXAMINERCODE,
				_.VERIFYTIME,
				_.DATA_SOURCE,
				_.CREATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._WINBIDBULLETINCODE,
				this._TENDERPROJECTCODE,
				this._TENDERPROJECTNAME,
				this._BIDSECTIONCODES,
				this._BULLETINNAME,
				this._BULLETINTYPE,
				this._BULLETINISSUETIME,
				this._BULLETINCONTENT,
				this._URL,
				this._ATTACHMENTCODE,
				this._VERSION,
				this._ISOPEN,
				this._OPENTYPE,
				this._EXAMINERNAME,
				this._EXAMINERCODETYPE,
				this._EXAMINERCODE,
				this._VERIFYTIME,
				this._DATA_SOURCE,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "T_EC2_WINBIDBULLETIN");
            /// <summary>
			/// 中标公告编号
			/// </summary>
			public readonly static Field WINBIDBULLETINCODE = new Field("WINBIDBULLETINCODE", "T_EC2_WINBIDBULLETIN", "中标公告编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_WINBIDBULLETIN", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDERPROJECTNAME = new Field("TENDERPROJECTNAME", "T_EC2_WINBIDBULLETIN",DbType.AnsiString, null, "招标项目名称");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODES = new Field("BIDSECTIONCODES", "T_EC2_WINBIDBULLETIN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 公告名称
			/// </summary>
			public readonly static Field BULLETINNAME = new Field("BULLETINNAME", "T_EC2_WINBIDBULLETIN", "公告名称");
            /// <summary>
			/// 公告类型
			/// </summary>
			public readonly static Field BULLETINTYPE = new Field("BULLETINTYPE", "T_EC2_WINBIDBULLETIN", "公告类型");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field BULLETINISSUETIME = new Field("BULLETINISSUETIME", "T_EC2_WINBIDBULLETIN", "公告发布时间");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field BULLETINCONTENT = new Field("BULLETINCONTENT", "T_EC2_WINBIDBULLETIN",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_EC2_WINBIDBULLETIN", "源URL");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_WINBIDBULLETIN",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_WINBIDBULLETIN", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_WINBIDBULLETIN", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_WINBIDBULLETIN", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_WINBIDBULLETIN", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_WINBIDBULLETIN", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_WINBIDBULLETIN", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_WINBIDBULLETIN", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_WINBIDBULLETIN", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_WINBIDBULLETIN", "数据时间");
        }
        #endregion
	}
}