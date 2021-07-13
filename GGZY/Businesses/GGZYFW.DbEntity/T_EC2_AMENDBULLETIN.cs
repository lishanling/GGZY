using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_AMENDBULLETIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_AMENDBULLETIN")]
    [Serializable]
    public partial class T_EC2_AMENDBULLETIN : FwEntity
    {
        #region Model
		private string _AMENDBULLETINCODE;
		private string _AMENDBULLETINNAME;
		private string _ORIGINALBULLETINTYPE;
		private string _ORIGINALBULLETINCODE;
		private string _TENDERPROJECTCODE;
		private string _BIDSECTIONCODES;
		private string _AMENDCONTENT;
		private DateTime? _AMENDBULLETINISSUETIME;
		private DateTime? _AMENDBIDDOCREFERENDTIME;
		private string _URL;
		private DateTime? _VERSION;
		private string _ATTACHMENTCODE;
		private string _OPENTYPE;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private DateTime? _VERIFYTIME;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 变更公告编号
		/// </summary>
		public string AMENDBULLETINCODE
		{
			get{ return _AMENDBULLETINCODE; }
			set
			{
				this.OnPropertyValueChange(_.AMENDBULLETINCODE, _AMENDBULLETINCODE, value);
				this._AMENDBULLETINCODE = value;
			}
		}
		/// <summary>
		/// 变更公告名称
		/// </summary>
		public string AMENDBULLETINNAME
		{
			get{ return _AMENDBULLETINNAME; }
			set
			{
				this.OnPropertyValueChange(_.AMENDBULLETINNAME, _AMENDBULLETINNAME, value);
				this._AMENDBULLETINNAME = value;
			}
		}
		/// <summary>
		/// 原公告类型
		/// </summary>
		public string ORIGINALBULLETINTYPE
		{
			get{ return _ORIGINALBULLETINTYPE; }
			set
			{
				this.OnPropertyValueChange(_.ORIGINALBULLETINTYPE, _ORIGINALBULLETINTYPE, value);
				this._ORIGINALBULLETINTYPE = value;
			}
		}
		/// <summary>
		/// 原公告编号
		/// </summary>
		public string ORIGINALBULLETINCODE
		{
			get{ return _ORIGINALBULLETINCODE; }
			set
			{
				this.OnPropertyValueChange(_.ORIGINALBULLETINCODE, _ORIGINALBULLETINCODE, value);
				this._ORIGINALBULLETINCODE = value;
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
		/// 变更内容
		/// </summary>
		public string AMENDCONTENT
		{
			get{ return _AMENDCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.AMENDCONTENT, _AMENDCONTENT, value);
				this._AMENDCONTENT = value;
			}
		}
		/// <summary>
		/// 变更公告发布时间
		/// </summary>
		public DateTime? AMENDBULLETINISSUETIME
		{
			get{ return _AMENDBULLETINISSUETIME; }
			set
			{
				this.OnPropertyValueChange(_.AMENDBULLETINISSUETIME, _AMENDBULLETINISSUETIME, value);
				this._AMENDBULLETINISSUETIME = value;
			}
		}
		/// <summary>
		/// 变更的投标文件递交截止时间
		/// </summary>
		public DateTime? AMENDBIDDOCREFERENDTIME
		{
			get{ return _AMENDBIDDOCREFERENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.AMENDBIDDOCREFERENDTIME, _AMENDBIDDOCREFERENDTIME, value);
				this._AMENDBIDDOCREFERENDTIME = value;
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
				_.AMENDBULLETINCODE,
				_.ORIGINALBULLETINCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.AMENDBULLETINCODE,
				_.AMENDBULLETINNAME,
				_.ORIGINALBULLETINTYPE,
				_.ORIGINALBULLETINCODE,
				_.TENDERPROJECTCODE,
				_.BIDSECTIONCODES,
				_.AMENDCONTENT,
				_.AMENDBULLETINISSUETIME,
				_.AMENDBIDDOCREFERENDTIME,
				_.URL,
				_.VERSION,
				_.ATTACHMENTCODE,
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
				this._AMENDBULLETINCODE,
				this._AMENDBULLETINNAME,
				this._ORIGINALBULLETINTYPE,
				this._ORIGINALBULLETINCODE,
				this._TENDERPROJECTCODE,
				this._BIDSECTIONCODES,
				this._AMENDCONTENT,
				this._AMENDBULLETINISSUETIME,
				this._AMENDBIDDOCREFERENDTIME,
				this._URL,
				this._VERSION,
				this._ATTACHMENTCODE,
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
			public readonly static Field All = new Field("*", "T_EC2_AMENDBULLETIN");
            /// <summary>
			/// 变更公告编号
			/// </summary>
			public readonly static Field AMENDBULLETINCODE = new Field("AMENDBULLETINCODE", "T_EC2_AMENDBULLETIN", "变更公告编号");
            /// <summary>
			/// 变更公告名称
			/// </summary>
			public readonly static Field AMENDBULLETINNAME = new Field("AMENDBULLETINNAME", "T_EC2_AMENDBULLETIN", "变更公告名称");
            /// <summary>
			/// 原公告类型
			/// </summary>
			public readonly static Field ORIGINALBULLETINTYPE = new Field("ORIGINALBULLETINTYPE", "T_EC2_AMENDBULLETIN", "原公告类型");
            /// <summary>
			/// 原公告编号
			/// </summary>
			public readonly static Field ORIGINALBULLETINCODE = new Field("ORIGINALBULLETINCODE", "T_EC2_AMENDBULLETIN", "原公告编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_AMENDBULLETIN", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODES = new Field("BIDSECTIONCODES", "T_EC2_AMENDBULLETIN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 变更内容
			/// </summary>
			public readonly static Field AMENDCONTENT = new Field("AMENDCONTENT", "T_EC2_AMENDBULLETIN",DbType.AnsiString, null, "变更内容");
            /// <summary>
			/// 变更公告发布时间
			/// </summary>
			public readonly static Field AMENDBULLETINISSUETIME = new Field("AMENDBULLETINISSUETIME", "T_EC2_AMENDBULLETIN", "变更公告发布时间");
            /// <summary>
			/// 变更的投标文件递交截止时间
			/// </summary>
			public readonly static Field AMENDBIDDOCREFERENDTIME = new Field("AMENDBIDDOCREFERENDTIME", "T_EC2_AMENDBULLETIN", "变更的投标文件递交截止时间");
            /// <summary>
			/// 源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_EC2_AMENDBULLETIN", "源URL");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_AMENDBULLETIN", "版本号");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_AMENDBULLETIN",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_AMENDBULLETIN", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_AMENDBULLETIN", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_AMENDBULLETIN", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_AMENDBULLETIN", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_AMENDBULLETIN", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_AMENDBULLETIN", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_AMENDBULLETIN", "数据时间");
        }
        #endregion
	}
}