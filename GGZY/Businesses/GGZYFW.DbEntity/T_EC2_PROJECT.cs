using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_PROJECT")]
    [Serializable]
    public partial class T_EC2_PROJECT : FwEntity
    {
        #region Model
		private string _PROJECTCODE;
		private string _TRADEPLATFPROJECTCODE;
		private string _PROJECTNAME;
		private string _REGIONCODE;
		private string _ADDRESS;
		private string _LEGALPERSON;
		private string _INDUSTRIESTYPE;
		private string _FUNDSOURCE;
		private string _PROJECTSCALE;
		private string _CONNECTOR;
		private string _CONTACTINFORMATION;
		private string _APPROVALNAME;
		private string _APPROVALNUMBER;
		private string _APPROVALAUTHORITY;
		private DateTime? _CREATETIME;
		private string _ATTACHMENTCODE;
		private DateTime? _VERSION;
		private string _ISOPEN;
		private string _OPENTYPE;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private DateTime? _VERIFYTIME;
		private decimal? _INVESTMENTAMOUNT;
		private string _CURRENCYCODE;
		private string _PRICEUNIT;
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
		/// 交易平台项目编号
		/// </summary>
		public string TRADEPLATFPROJECTCODE
		{
			get{ return _TRADEPLATFPROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TRADEPLATFPROJECTCODE, _TRADEPLATFPROJECTCODE, value);
				this._TRADEPLATFPROJECTCODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECTNAME
		{
			get{ return _PROJECTNAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECTNAME, _PROJECTNAME, value);
				this._PROJECTNAME = value;
			}
		}
		/// <summary>
		/// 项目所在行政区域代码
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
		/// 项目地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 项目法人
		/// </summary>
		public string LEGALPERSON
		{
			get{ return _LEGALPERSON; }
			set
			{
				this.OnPropertyValueChange(_.LEGALPERSON, _LEGALPERSON, value);
				this._LEGALPERSON = value;
			}
		}
		/// <summary>
		/// 项目行业分类
		/// </summary>
		public string INDUSTRIESTYPE
		{
			get{ return _INDUSTRIESTYPE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRIESTYPE, _INDUSTRIESTYPE, value);
				this._INDUSTRIESTYPE = value;
			}
		}
		/// <summary>
		/// 资金来源
		/// </summary>
		public string FUNDSOURCE
		{
			get{ return _FUNDSOURCE; }
			set
			{
				this.OnPropertyValueChange(_.FUNDSOURCE, _FUNDSOURCE, value);
				this._FUNDSOURCE = value;
			}
		}
		/// <summary>
		/// 项目规模
		/// </summary>
		public string PROJECTSCALE
		{
			get{ return _PROJECTSCALE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECTSCALE, _PROJECTSCALE, value);
				this._PROJECTSCALE = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONNECTOR
		{
			get{ return _CONNECTOR; }
			set
			{
				this.OnPropertyValueChange(_.CONNECTOR, _CONNECTOR, value);
				this._CONNECTOR = value;
			}
		}
		/// <summary>
		/// 联系方式
		/// </summary>
		public string CONTACTINFORMATION
		{
			get{ return _CONTACTINFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTINFORMATION, _CONTACTINFORMATION, value);
				this._CONTACTINFORMATION = value;
			}
		}
		/// <summary>
		/// 项目批文名称
		/// </summary>
		public string APPROVALNAME
		{
			get{ return _APPROVALNAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVALNAME, _APPROVALNAME, value);
				this._APPROVALNAME = value;
			}
		}
		/// <summary>
		/// 项目批准文号
		/// </summary>
		public string APPROVALNUMBER
		{
			get{ return _APPROVALNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.APPROVALNUMBER, _APPROVALNUMBER, value);
				this._APPROVALNUMBER = value;
			}
		}
		/// <summary>
		/// 项目批准单位
		/// </summary>
		public string APPROVALAUTHORITY
		{
			get{ return _APPROVALAUTHORITY; }
			set
			{
				this.OnPropertyValueChange(_.APPROVALAUTHORITY, _APPROVALAUTHORITY, value);
				this._APPROVALAUTHORITY = value;
			}
		}
		/// <summary>
		/// 项目建立时间
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
		/// 投资金额
		/// </summary>
		public decimal? INVESTMENTAMOUNT
		{
			get{ return _INVESTMENTAMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.INVESTMENTAMOUNT, _INVESTMENTAMOUNT, value);
				this._INVESTMENTAMOUNT = value;
			}
		}
		/// <summary>
		/// 金额币种
		/// </summary>
		public string CURRENCYCODE
		{
			get{ return _CURRENCYCODE; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCYCODE, _CURRENCYCODE, value);
				this._CURRENCYCODE = value;
			}
		}
		/// <summary>
		/// 金额单位
		/// </summary>
		public string PRICEUNIT
		{
			get{ return _PRICEUNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICEUNIT, _PRICEUNIT, value);
				this._PRICEUNIT = value;
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
				_.PROJECTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PROJECTCODE,
				_.TRADEPLATFPROJECTCODE,
				_.PROJECTNAME,
				_.REGIONCODE,
				_.ADDRESS,
				_.LEGALPERSON,
				_.INDUSTRIESTYPE,
				_.FUNDSOURCE,
				_.PROJECTSCALE,
				_.CONNECTOR,
				_.CONTACTINFORMATION,
				_.APPROVALNAME,
				_.APPROVALNUMBER,
				_.APPROVALAUTHORITY,
				_.CREATETIME,
				_.ATTACHMENTCODE,
				_.VERSION,
				_.ISOPEN,
				_.OPENTYPE,
				_.EXAMINERNAME,
				_.EXAMINERCODETYPE,
				_.EXAMINERCODE,
				_.VERIFYTIME,
				_.INVESTMENTAMOUNT,
				_.CURRENCYCODE,
				_.PRICEUNIT,
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
				this._TRADEPLATFPROJECTCODE,
				this._PROJECTNAME,
				this._REGIONCODE,
				this._ADDRESS,
				this._LEGALPERSON,
				this._INDUSTRIESTYPE,
				this._FUNDSOURCE,
				this._PROJECTSCALE,
				this._CONNECTOR,
				this._CONTACTINFORMATION,
				this._APPROVALNAME,
				this._APPROVALNUMBER,
				this._APPROVALAUTHORITY,
				this._CREATETIME,
				this._ATTACHMENTCODE,
				this._VERSION,
				this._ISOPEN,
				this._OPENTYPE,
				this._EXAMINERNAME,
				this._EXAMINERCODETYPE,
				this._EXAMINERCODE,
				this._VERIFYTIME,
				this._INVESTMENTAMOUNT,
				this._CURRENCYCODE,
				this._PRICEUNIT,
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
			public readonly static Field All = new Field("*", "T_EC2_PROJECT");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECTCODE = new Field("PROJECTCODE", "T_EC2_PROJECT", "项目编号");
            /// <summary>
			/// 交易平台项目编号
			/// </summary>
			public readonly static Field TRADEPLATFPROJECTCODE = new Field("TRADEPLATFPROJECTCODE", "T_EC2_PROJECT", "交易平台项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECTNAME = new Field("PROJECTNAME", "T_EC2_PROJECT",DbType.AnsiString, null, "项目名称");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGIONCODE = new Field("REGIONCODE", "T_EC2_PROJECT", "项目所在行政区域代码");
            /// <summary>
			/// 项目地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "T_EC2_PROJECT", "项目地址");
            /// <summary>
			/// 项目法人
			/// </summary>
			public readonly static Field LEGALPERSON = new Field("LEGALPERSON", "T_EC2_PROJECT", "项目法人");
            /// <summary>
			/// 项目行业分类
			/// </summary>
			public readonly static Field INDUSTRIESTYPE = new Field("INDUSTRIESTYPE", "T_EC2_PROJECT", "项目行业分类");
            /// <summary>
			/// 资金来源
			/// </summary>
			public readonly static Field FUNDSOURCE = new Field("FUNDSOURCE", "T_EC2_PROJECT", "资金来源");
            /// <summary>
			/// 项目规模
			/// </summary>
			public readonly static Field PROJECTSCALE = new Field("PROJECTSCALE", "T_EC2_PROJECT", "项目规模");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONNECTOR = new Field("CONNECTOR", "T_EC2_PROJECT", "联系人");
            /// <summary>
			/// 联系方式
			/// </summary>
			public readonly static Field CONTACTINFORMATION = new Field("CONTACTINFORMATION", "T_EC2_PROJECT", "联系方式");
            /// <summary>
			/// 项目批文名称
			/// </summary>
			public readonly static Field APPROVALNAME = new Field("APPROVALNAME", "T_EC2_PROJECT", "项目批文名称");
            /// <summary>
			/// 项目批准文号
			/// </summary>
			public readonly static Field APPROVALNUMBER = new Field("APPROVALNUMBER", "T_EC2_PROJECT", "项目批准文号");
            /// <summary>
			/// 项目批准单位
			/// </summary>
			public readonly static Field APPROVALAUTHORITY = new Field("APPROVALAUTHORITY", "T_EC2_PROJECT", "项目批准单位");
            /// <summary>
			/// 项目建立时间
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_EC2_PROJECT", "项目建立时间");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_PROJECT",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_PROJECT", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_PROJECT", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_PROJECT", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_PROJECT", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_PROJECT", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_PROJECT", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_PROJECT", "交易平台数据验证时间");
            /// <summary>
			/// 投资金额
			/// </summary>
			public readonly static Field INVESTMENTAMOUNT = new Field("INVESTMENTAMOUNT", "T_EC2_PROJECT", "投资金额");
            /// <summary>
			/// 金额币种
			/// </summary>
			public readonly static Field CURRENCYCODE = new Field("CURRENCYCODE", "T_EC2_PROJECT", "金额币种");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field PRICEUNIT = new Field("PRICEUNIT", "T_EC2_PROJECT", "金额单位");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_PROJECT", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_PROJECT", "数据时间");
        }
        #endregion
	}
}