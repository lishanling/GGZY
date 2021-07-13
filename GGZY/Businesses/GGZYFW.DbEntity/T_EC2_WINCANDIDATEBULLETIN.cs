using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_WINCANDIDATEBULLETIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_WINCANDIDATEBULLETIN")]
    [Serializable]
    public partial class T_EC2_WINCANDIDATEBULLETIN : FwEntity
    {
        #region Model
		private string _WINCANDIDATEBULLETINCODE;
		private string _TENDERPROJECTCODE;
		private string _TENDERPROJECTNAME;
		private string _BIDSECTIONCODES;
		private string _PUBLICITYNAME;
		private string _PUBLICITYTYPE;
		private DateTime? _PUBLICITYSTARTTIME;
		private DateTime? _PUBLICITYENDTIME;
		private string _PUBLICITYCONTENT;
		private DateTime? _PUBLICITYREFERTIME;
		private DateTime? _BULLETINISSUETIME;
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
		/// 中标候选人公示编号
		/// </summary>
		public string WINCANDIDATEBULLETINCODE
		{
			get{ return _WINCANDIDATEBULLETINCODE; }
			set
			{
				this.OnPropertyValueChange(_.WINCANDIDATEBULLETINCODE, _WINCANDIDATEBULLETINCODE, value);
				this._WINCANDIDATEBULLETINCODE = value;
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
		/// 公示名称
		/// </summary>
		public string PUBLICITYNAME
		{
			get{ return _PUBLICITYNAME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITYNAME, _PUBLICITYNAME, value);
				this._PUBLICITYNAME = value;
			}
		}
		/// <summary>
		/// 公示类型
		/// </summary>
		public string PUBLICITYTYPE
		{
			get{ return _PUBLICITYTYPE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITYTYPE, _PUBLICITYTYPE, value);
				this._PUBLICITYTYPE = value;
			}
		}
		/// <summary>
		/// 公示开始时间
		/// </summary>
		public DateTime? PUBLICITYSTARTTIME
		{
			get{ return _PUBLICITYSTARTTIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITYSTARTTIME, _PUBLICITYSTARTTIME, value);
				this._PUBLICITYSTARTTIME = value;
			}
		}
		/// <summary>
		/// 公示结束时间
		/// </summary>
		public DateTime? PUBLICITYENDTIME
		{
			get{ return _PUBLICITYENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITYENDTIME, _PUBLICITYENDTIME, value);
				this._PUBLICITYENDTIME = value;
			}
		}
		/// <summary>
		/// 公示内容
		/// </summary>
		public string PUBLICITYCONTENT
		{
			get{ return _PUBLICITYCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITYCONTENT, _PUBLICITYCONTENT, value);
				this._PUBLICITYCONTENT = value;
			}
		}
		/// <summary>
		/// 公示提交时间
		/// </summary>
		public DateTime? PUBLICITYREFERTIME
		{
			get{ return _PUBLICITYREFERTIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITYREFERTIME, _PUBLICITYREFERTIME, value);
				this._PUBLICITYREFERTIME = value;
			}
		}
		/// <summary>
		/// 公示发布时间
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
				_.WINCANDIDATEBULLETINCODE,
				_.TENDERPROJECTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.WINCANDIDATEBULLETINCODE,
				_.TENDERPROJECTCODE,
				_.TENDERPROJECTNAME,
				_.BIDSECTIONCODES,
				_.PUBLICITYNAME,
				_.PUBLICITYTYPE,
				_.PUBLICITYSTARTTIME,
				_.PUBLICITYENDTIME,
				_.PUBLICITYCONTENT,
				_.PUBLICITYREFERTIME,
				_.BULLETINISSUETIME,
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
				this._WINCANDIDATEBULLETINCODE,
				this._TENDERPROJECTCODE,
				this._TENDERPROJECTNAME,
				this._BIDSECTIONCODES,
				this._PUBLICITYNAME,
				this._PUBLICITYTYPE,
				this._PUBLICITYSTARTTIME,
				this._PUBLICITYENDTIME,
				this._PUBLICITYCONTENT,
				this._PUBLICITYREFERTIME,
				this._BULLETINISSUETIME,
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
			public readonly static Field All = new Field("*", "T_EC2_WINCANDIDATEBULLETIN");
            /// <summary>
			/// 中标候选人公示编号
			/// </summary>
			public readonly static Field WINCANDIDATEBULLETINCODE = new Field("WINCANDIDATEBULLETINCODE", "T_EC2_WINCANDIDATEBULLETIN", "中标候选人公示编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_WINCANDIDATEBULLETIN", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDERPROJECTNAME = new Field("TENDERPROJECTNAME", "T_EC2_WINCANDIDATEBULLETIN",DbType.AnsiString, null, "招标项目名称");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODES = new Field("BIDSECTIONCODES", "T_EC2_WINCANDIDATEBULLETIN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 公示名称
			/// </summary>
			public readonly static Field PUBLICITYNAME = new Field("PUBLICITYNAME", "T_EC2_WINCANDIDATEBULLETIN", "公示名称");
            /// <summary>
			/// 公示类型
			/// </summary>
			public readonly static Field PUBLICITYTYPE = new Field("PUBLICITYTYPE", "T_EC2_WINCANDIDATEBULLETIN", "公示类型");
            /// <summary>
			/// 公示开始时间
			/// </summary>
			public readonly static Field PUBLICITYSTARTTIME = new Field("PUBLICITYSTARTTIME", "T_EC2_WINCANDIDATEBULLETIN", "公示开始时间");
            /// <summary>
			/// 公示结束时间
			/// </summary>
			public readonly static Field PUBLICITYENDTIME = new Field("PUBLICITYENDTIME", "T_EC2_WINCANDIDATEBULLETIN", "公示结束时间");
            /// <summary>
			/// 公示内容
			/// </summary>
			public readonly static Field PUBLICITYCONTENT = new Field("PUBLICITYCONTENT", "T_EC2_WINCANDIDATEBULLETIN",DbType.AnsiString, null, "公示内容");
            /// <summary>
			/// 公示提交时间
			/// </summary>
			public readonly static Field PUBLICITYREFERTIME = new Field("PUBLICITYREFERTIME", "T_EC2_WINCANDIDATEBULLETIN", "公示提交时间");
            /// <summary>
			/// 公示发布时间
			/// </summary>
			public readonly static Field BULLETINISSUETIME = new Field("BULLETINISSUETIME", "T_EC2_WINCANDIDATEBULLETIN", "公示发布时间");
            /// <summary>
			/// 源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_EC2_WINCANDIDATEBULLETIN", "源URL");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_WINCANDIDATEBULLETIN",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_WINCANDIDATEBULLETIN", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_WINCANDIDATEBULLETIN", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_WINCANDIDATEBULLETIN", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_WINCANDIDATEBULLETIN", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_WINCANDIDATEBULLETIN", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_WINCANDIDATEBULLETIN", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_WINCANDIDATEBULLETIN", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_WINCANDIDATEBULLETIN", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_WINCANDIDATEBULLETIN", "数据时间");
        }
        #endregion
	}
}