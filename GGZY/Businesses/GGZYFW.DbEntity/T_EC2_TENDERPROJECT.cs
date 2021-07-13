using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_TENDERPROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_TENDERPROJECT")]
    [Serializable]
    public partial class T_EC2_TENDERPROJECT : FwEntity
    {
        #region Model
		private string _PROJECTCODE;
		private string _TENDERPROJECTCODE;
		private string _TRADEPLATFTENDERPROJECTCODE;
		private string _TENDERPROJECTNAME;
		private string _TENDERPROJECTCLASSIFYCODE;
		private string _REGIONCODE;
		private string _TENDERCONTENT;
		private string _TENDERERCODETYPE;
		private string _TENDERERCODE;
		private string _TENDERERNAME;
		private string _TENDERAGENCYCODETYPE;
		private string _TENDERAGENCYCODE;
		private string _TENDERAGENCYNAME;
		private DateTime? _TENDERERAGENCYBASICINFOVERSION;
		private string _TENDERMODE;
		private string _TENDERORGANIZEFORM;
		private DateTime? _CREATETIME;
		private string _SUPERVISEDEPTCODETYPE;
		private string _SUPERVISEDEPTCODE;
		private string _SUPERVISEDEPTNAME;
		private string _APPROVEDEPTCODETYPE;
		private string _APPROVEDEPTCODE;
		private string _APPROVEDEPTNAME;
		private string _PLATFORMCODE;
		private string _PUBSERVICEPLATCODE;
		private string _INFOREPORTERNAME;
		private string _INFOREPORTERCODETYPE;
		private string _INFOREPORTERCODE;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private string _ATTACHMENTCODE;
		private DateTime? _VERSION;
		private string _ISOPEN;
		private string _OPENTYPE;
		private DateTime? _VERIFYTIME;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECTCODE
		{
			get{ return _PROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECTCODE, _PROJECTCODE, value);
				this._PROJECTCODE = value;
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
		/// 交易平台招标项目编号
		/// </summary>
		public string TRADEPLATFTENDERPROJECTCODE
		{
			get{ return _TRADEPLATFTENDERPROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TRADEPLATFTENDERPROJECTCODE, _TRADEPLATFTENDERPROJECTCODE, value);
				this._TRADEPLATFTENDERPROJECTCODE = value;
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
		/// 招标项目分类代码
		/// </summary>
		public string TENDERPROJECTCLASSIFYCODE
		{
			get{ return _TENDERPROJECTCLASSIFYCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTCLASSIFYCODE, _TENDERPROJECTCLASSIFYCODE, value);
				this._TENDERPROJECTCLASSIFYCODE = value;
			}
		}
		/// <summary>
		/// 招标项目所在行政区域代码
		/// </summary>
		public string REGIONCODE
		{
			get{ return _REGIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.REGIONCODE, _REGIONCODE, value);
				this._REGIONCODE = value;
			}
		}
		/// <summary>
		/// 招标内容与范围及招标方案说明
		/// </summary>
		public string TENDERCONTENT
		{
			get{ return _TENDERCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERCONTENT, _TENDERCONTENT, value);
				this._TENDERCONTENT = value;
			}
		}
		/// <summary>
		/// 招标人代码类型
		/// </summary>
		public string TENDERERCODETYPE
		{
			get{ return _TENDERERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERCODETYPE, _TENDERERCODETYPE, value);
				this._TENDERERCODETYPE = value;
			}
		}
		/// <summary>
		/// 招标人代码
		/// </summary>
		public string TENDERERCODE
		{
			get{ return _TENDERERCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERCODE, _TENDERERCODE, value);
				this._TENDERERCODE = value;
			}
		}
		/// <summary>
		/// 招标人名称
		/// </summary>
		public string TENDERERNAME
		{
			get{ return _TENDERERNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERNAME, _TENDERERNAME, value);
				this._TENDERERNAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构代码类型
		/// </summary>
		public string TENDERAGENCYCODETYPE
		{
			get{ return _TENDERAGENCYCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERAGENCYCODETYPE, _TENDERAGENCYCODETYPE, value);
				this._TENDERAGENCYCODETYPE = value;
			}
		}
		/// <summary>
		/// 招标代理机构代码
		/// </summary>
		public string TENDERAGENCYCODE
		{
			get{ return _TENDERAGENCYCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERAGENCYCODE, _TENDERAGENCYCODE, value);
				this._TENDERAGENCYCODE = value;
			}
		}
		/// <summary>
		/// 招标代理机构名称
		/// </summary>
		public string TENDERAGENCYNAME
		{
			get{ return _TENDERAGENCYNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERAGENCYNAME, _TENDERAGENCYNAME, value);
				this._TENDERAGENCYNAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构基本信息版本号
		/// </summary>
		public DateTime? TENDERERAGENCYBASICINFOVERSION
		{
			get{ return _TENDERERAGENCYBASICINFOVERSION; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERAGENCYBASICINFOVERSION, _TENDERERAGENCYBASICINFOVERSION, value);
				this._TENDERERAGENCYBASICINFOVERSION = value;
			}
		}
		/// <summary>
		/// 招标方式
		/// </summary>
		public string TENDERMODE
		{
			get{ return _TENDERMODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERMODE, _TENDERMODE, value);
				this._TENDERMODE = value;
			}
		}
		/// <summary>
		/// 招标组织形式
		/// </summary>
		public string TENDERORGANIZEFORM
		{
			get{ return _TENDERORGANIZEFORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDERORGANIZEFORM, _TENDERORGANIZEFORM, value);
				this._TENDERORGANIZEFORM = value;
			}
		}
		/// <summary>
		/// 招标项目建立时间
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 监督部门代码类型
		/// </summary>
		public string SUPERVISEDEPTCODETYPE
		{
			get{ return _SUPERVISEDEPTCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISEDEPTCODETYPE, _SUPERVISEDEPTCODETYPE, value);
				this._SUPERVISEDEPTCODETYPE = value;
			}
		}
		/// <summary>
		/// 监督部门代码
		/// </summary>
		public string SUPERVISEDEPTCODE
		{
			get{ return _SUPERVISEDEPTCODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISEDEPTCODE, _SUPERVISEDEPTCODE, value);
				this._SUPERVISEDEPTCODE = value;
			}
		}
		/// <summary>
		/// 监督部门名称
		/// </summary>
		public string SUPERVISEDEPTNAME
		{
			get{ return _SUPERVISEDEPTNAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISEDEPTNAME, _SUPERVISEDEPTNAME, value);
				this._SUPERVISEDEPTNAME = value;
			}
		}
		/// <summary>
		/// 审核部门代码类型
		/// </summary>
		public string APPROVEDEPTCODETYPE
		{
			get{ return _APPROVEDEPTCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVEDEPTCODETYPE, _APPROVEDEPTCODETYPE, value);
				this._APPROVEDEPTCODETYPE = value;
			}
		}
		/// <summary>
		/// 审核部门代码
		/// </summary>
		public string APPROVEDEPTCODE
		{
			get{ return _APPROVEDEPTCODE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVEDEPTCODE, _APPROVEDEPTCODE, value);
				this._APPROVEDEPTCODE = value;
			}
		}
		/// <summary>
		/// 审核部门名称
		/// </summary>
		public string APPROVEDEPTNAME
		{
			get{ return _APPROVEDEPTNAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVEDEPTNAME, _APPROVEDEPTNAME, value);
				this._APPROVEDEPTNAME = value;
			}
		}
		/// <summary>
		/// 交易平台标识码
		/// </summary>
		public string PLATFORMCODE
		{
			get{ return _PLATFORMCODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORMCODE, _PLATFORMCODE, value);
				this._PLATFORMCODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUBSERVICEPLATCODE
		{
			get{ return _PUBSERVICEPLATCODE; }
			set
			{
				this.OnPropertyValueChange(_.PUBSERVICEPLATCODE, _PUBSERVICEPLATCODE, value);
				this._PUBSERVICEPLATCODE = value;
			}
		}
		/// <summary>
		/// 信息申报责任人姓名
		/// </summary>
		public string INFOREPORTERNAME
		{
			get{ return _INFOREPORTERNAME; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERNAME, _INFOREPORTERNAME, value);
				this._INFOREPORTERNAME = value;
			}
		}
		/// <summary>
		/// 信息申报责任人证件种类
		/// </summary>
		public string INFOREPORTERCODETYPE
		{
			get{ return _INFOREPORTERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERCODETYPE, _INFOREPORTERCODETYPE, value);
				this._INFOREPORTERCODETYPE = value;
			}
		}
		/// <summary>
		/// 信息申报责任人证件号码
		/// </summary>
		public string INFOREPORTERCODE
		{
			get{ return _INFOREPORTERCODE; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERCODE, _INFOREPORTERCODE, value);
				this._INFOREPORTERCODE = value;
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
				_.TENDERPROJECTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PROJECTCODE,
				_.TENDERPROJECTCODE,
				_.TRADEPLATFTENDERPROJECTCODE,
				_.TENDERPROJECTNAME,
				_.TENDERPROJECTCLASSIFYCODE,
				_.REGIONCODE,
				_.TENDERCONTENT,
				_.TENDERERCODETYPE,
				_.TENDERERCODE,
				_.TENDERERNAME,
				_.TENDERAGENCYCODETYPE,
				_.TENDERAGENCYCODE,
				_.TENDERAGENCYNAME,
				_.TENDERERAGENCYBASICINFOVERSION,
				_.TENDERMODE,
				_.TENDERORGANIZEFORM,
				_.CREATETIME,
				_.SUPERVISEDEPTCODETYPE,
				_.SUPERVISEDEPTCODE,
				_.SUPERVISEDEPTNAME,
				_.APPROVEDEPTCODETYPE,
				_.APPROVEDEPTCODE,
				_.APPROVEDEPTNAME,
				_.PLATFORMCODE,
				_.PUBSERVICEPLATCODE,
				_.INFOREPORTERNAME,
				_.INFOREPORTERCODETYPE,
				_.INFOREPORTERCODE,
				_.EXAMINERNAME,
				_.EXAMINERCODETYPE,
				_.EXAMINERCODE,
				_.ATTACHMENTCODE,
				_.VERSION,
				_.ISOPEN,
				_.OPENTYPE,
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
				this._PROJECTCODE,
				this._TENDERPROJECTCODE,
				this._TRADEPLATFTENDERPROJECTCODE,
				this._TENDERPROJECTNAME,
				this._TENDERPROJECTCLASSIFYCODE,
				this._REGIONCODE,
				this._TENDERCONTENT,
				this._TENDERERCODETYPE,
				this._TENDERERCODE,
				this._TENDERERNAME,
				this._TENDERAGENCYCODETYPE,
				this._TENDERAGENCYCODE,
				this._TENDERAGENCYNAME,
				this._TENDERERAGENCYBASICINFOVERSION,
				this._TENDERMODE,
				this._TENDERORGANIZEFORM,
				this._CREATETIME,
				this._SUPERVISEDEPTCODETYPE,
				this._SUPERVISEDEPTCODE,
				this._SUPERVISEDEPTNAME,
				this._APPROVEDEPTCODETYPE,
				this._APPROVEDEPTCODE,
				this._APPROVEDEPTNAME,
				this._PLATFORMCODE,
				this._PUBSERVICEPLATCODE,
				this._INFOREPORTERNAME,
				this._INFOREPORTERCODETYPE,
				this._INFOREPORTERCODE,
				this._EXAMINERNAME,
				this._EXAMINERCODETYPE,
				this._EXAMINERCODE,
				this._ATTACHMENTCODE,
				this._VERSION,
				this._ISOPEN,
				this._OPENTYPE,
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
			public readonly static Field All = new Field("*", "T_EC2_TENDERPROJECT");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECTCODE = new Field("PROJECTCODE", "T_EC2_TENDERPROJECT", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_TENDERPROJECT", "招标项目编号");
            /// <summary>
			/// 交易平台招标项目编号
			/// </summary>
			public readonly static Field TRADEPLATFTENDERPROJECTCODE = new Field("TRADEPLATFTENDERPROJECTCODE", "T_EC2_TENDERPROJECT", "交易平台招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDERPROJECTNAME = new Field("TENDERPROJECTNAME", "T_EC2_TENDERPROJECT",DbType.AnsiString, null, "招标项目名称");
            /// <summary>
			/// 招标项目分类代码
			/// </summary>
			public readonly static Field TENDERPROJECTCLASSIFYCODE = new Field("TENDERPROJECTCLASSIFYCODE", "T_EC2_TENDERPROJECT", "招标项目分类代码");
            /// <summary>
			/// 招标项目所在行政区域代码
			/// </summary>
			public readonly static Field REGIONCODE = new Field("REGIONCODE", "T_EC2_TENDERPROJECT", "招标项目所在行政区域代码");
            /// <summary>
			/// 招标内容与范围及招标方案说明
			/// </summary>
			public readonly static Field TENDERCONTENT = new Field("TENDERCONTENT", "T_EC2_TENDERPROJECT",DbType.AnsiString, null, "招标内容与范围及招标方案说明");
            /// <summary>
			/// 招标人代码类型
			/// </summary>
			public readonly static Field TENDERERCODETYPE = new Field("TENDERERCODETYPE", "T_EC2_TENDERPROJECT", "招标人代码类型");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERERCODE = new Field("TENDERERCODE", "T_EC2_TENDERPROJECT", "招标人代码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERERNAME = new Field("TENDERERNAME", "T_EC2_TENDERPROJECT", "招标人名称");
            /// <summary>
			/// 招标代理机构代码类型
			/// </summary>
			public readonly static Field TENDERAGENCYCODETYPE = new Field("TENDERAGENCYCODETYPE", "T_EC2_TENDERPROJECT", "招标代理机构代码类型");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDERAGENCYCODE = new Field("TENDERAGENCYCODE", "T_EC2_TENDERPROJECT", "招标代理机构代码");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDERAGENCYNAME = new Field("TENDERAGENCYNAME", "T_EC2_TENDERPROJECT", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构基本信息版本号
			/// </summary>
			public readonly static Field TENDERERAGENCYBASICINFOVERSION = new Field("TENDERERAGENCYBASICINFOVERSION", "T_EC2_TENDERPROJECT", "招标代理机构基本信息版本号");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDERMODE = new Field("TENDERMODE", "T_EC2_TENDERPROJECT", "招标方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDERORGANIZEFORM = new Field("TENDERORGANIZEFORM", "T_EC2_TENDERPROJECT", "招标组织形式");
            /// <summary>
			/// 招标项目建立时间
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_EC2_TENDERPROJECT", "招标项目建立时间");
            /// <summary>
			/// 监督部门代码类型
			/// </summary>
			public readonly static Field SUPERVISEDEPTCODETYPE = new Field("SUPERVISEDEPTCODETYPE", "T_EC2_TENDERPROJECT", "监督部门代码类型");
            /// <summary>
			/// 监督部门代码
			/// </summary>
			public readonly static Field SUPERVISEDEPTCODE = new Field("SUPERVISEDEPTCODE", "T_EC2_TENDERPROJECT", "监督部门代码");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISEDEPTNAME = new Field("SUPERVISEDEPTNAME", "T_EC2_TENDERPROJECT", "监督部门名称");
            /// <summary>
			/// 审核部门代码类型
			/// </summary>
			public readonly static Field APPROVEDEPTCODETYPE = new Field("APPROVEDEPTCODETYPE", "T_EC2_TENDERPROJECT", "审核部门代码类型");
            /// <summary>
			/// 审核部门代码
			/// </summary>
			public readonly static Field APPROVEDEPTCODE = new Field("APPROVEDEPTCODE", "T_EC2_TENDERPROJECT", "审核部门代码");
            /// <summary>
			/// 审核部门名称
			/// </summary>
			public readonly static Field APPROVEDEPTNAME = new Field("APPROVEDEPTNAME", "T_EC2_TENDERPROJECT", "审核部门名称");
            /// <summary>
			/// 交易平台标识码
			/// </summary>
			public readonly static Field PLATFORMCODE = new Field("PLATFORMCODE", "T_EC2_TENDERPROJECT", "交易平台标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUBSERVICEPLATCODE = new Field("PUBSERVICEPLATCODE", "T_EC2_TENDERPROJECT", "公共服务平台标识码");
            /// <summary>
			/// 信息申报责任人姓名
			/// </summary>
			public readonly static Field INFOREPORTERNAME = new Field("INFOREPORTERNAME", "T_EC2_TENDERPROJECT", "信息申报责任人姓名");
            /// <summary>
			/// 信息申报责任人证件种类
			/// </summary>
			public readonly static Field INFOREPORTERCODETYPE = new Field("INFOREPORTERCODETYPE", "T_EC2_TENDERPROJECT", "信息申报责任人证件种类");
            /// <summary>
			/// 信息申报责任人证件号码
			/// </summary>
			public readonly static Field INFOREPORTERCODE = new Field("INFOREPORTERCODE", "T_EC2_TENDERPROJECT", "信息申报责任人证件号码");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_TENDERPROJECT", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_TENDERPROJECT", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_TENDERPROJECT", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_TENDERPROJECT",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_TENDERPROJECT", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_TENDERPROJECT", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_TENDERPROJECT", "公开类型");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_TENDERPROJECT", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_TENDERPROJECT", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_TENDERPROJECT", "数据时间");
        }
        #endregion
	}
}