using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_BIDSECTION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_BIDSECTION")]
    [Serializable]
    public partial class T_EC2_BIDSECTION : FwEntity
    {
        #region Model
		private string _TENDERPROJECTCODE;
		private string _BIDSECTIONCODE;
		private string _TRADEPLATFBIDSECTIONCODE;
		private string _BIDSECTIONNAME;
		private string _BIDSECTIONCONTENT;
		private string _TENDERPROJECTCLASSIFYCODE;
		private string _TENDERERCODETYPE;
		private string _TENDERERCODE;
		private string _TENDERERNAME;
		private DateTime? _TENDERERBASICINFOVERSION;
		private string _TENDERMODE;
		private decimal? _CONTRACTRECKONPRICE;
		private string _CURRENCYCODE;
		private string _PRICEUNIT;
		private string _BIDQUALIFICATION;
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
		/// 标段（包）编号
		/// </summary>
		public string BIDSECTIONCODE
		{
			get{ return _BIDSECTIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONCODE, _BIDSECTIONCODE, value);
				this._BIDSECTIONCODE = value;
			}
		}
		/// <summary>
		/// 交易平台标段（包）编号
		/// </summary>
		public string TRADEPLATFBIDSECTIONCODE
		{
			get{ return _TRADEPLATFBIDSECTIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.TRADEPLATFBIDSECTIONCODE, _TRADEPLATFBIDSECTIONCODE, value);
				this._TRADEPLATFBIDSECTIONCODE = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string BIDSECTIONNAME
		{
			get{ return _BIDSECTIONNAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONNAME, _BIDSECTIONNAME, value);
				this._BIDSECTIONNAME = value;
			}
		}
		/// <summary>
		/// 标段（包）内容
		/// </summary>
		public string BIDSECTIONCONTENT
		{
			get{ return _BIDSECTIONCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONCONTENT, _BIDSECTIONCONTENT, value);
				this._BIDSECTIONCONTENT = value;
			}
		}
		/// <summary>
		/// 标段（包）分类代码
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
		/// 招标人基本信息版本号
		/// </summary>
		public DateTime? TENDERERBASICINFOVERSION
		{
			get{ return _TENDERERBASICINFOVERSION; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERBASICINFOVERSION, _TENDERERBASICINFOVERSION, value);
				this._TENDERERBASICINFOVERSION = value;
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
		/// 标段合同估算价
		/// </summary>
		public decimal? CONTRACTRECKONPRICE
		{
			get{ return _CONTRACTRECKONPRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACTRECKONPRICE, _CONTRACTRECKONPRICE, value);
				this._CONTRACTRECKONPRICE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价币种代码
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
		/// 标段合同估算价单位
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
		/// 投标人资格条件
		/// </summary>
		public string BIDQUALIFICATION
		{
			get{ return _BIDQUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BIDQUALIFICATION, _BIDQUALIFICATION, value);
				this._BIDQUALIFICATION = value;
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
				_.BIDSECTIONCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDERPROJECTCODE,
				_.BIDSECTIONCODE,
				_.TRADEPLATFBIDSECTIONCODE,
				_.BIDSECTIONNAME,
				_.BIDSECTIONCONTENT,
				_.TENDERPROJECTCLASSIFYCODE,
				_.TENDERERCODETYPE,
				_.TENDERERCODE,
				_.TENDERERNAME,
				_.TENDERERBASICINFOVERSION,
				_.TENDERMODE,
				_.CONTRACTRECKONPRICE,
				_.CURRENCYCODE,
				_.PRICEUNIT,
				_.BIDQUALIFICATION,
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
				this._TENDERPROJECTCODE,
				this._BIDSECTIONCODE,
				this._TRADEPLATFBIDSECTIONCODE,
				this._BIDSECTIONNAME,
				this._BIDSECTIONCONTENT,
				this._TENDERPROJECTCLASSIFYCODE,
				this._TENDERERCODETYPE,
				this._TENDERERCODE,
				this._TENDERERNAME,
				this._TENDERERBASICINFOVERSION,
				this._TENDERMODE,
				this._CONTRACTRECKONPRICE,
				this._CURRENCYCODE,
				this._PRICEUNIT,
				this._BIDQUALIFICATION,
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
			public readonly static Field All = new Field("*", "T_EC2_BIDSECTION");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_BIDSECTION", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODE = new Field("BIDSECTIONCODE", "T_EC2_BIDSECTION", "标段（包）编号");
            /// <summary>
			/// 交易平台标段（包）编号
			/// </summary>
			public readonly static Field TRADEPLATFBIDSECTIONCODE = new Field("TRADEPLATFBIDSECTIONCODE", "T_EC2_BIDSECTION", "交易平台标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BIDSECTIONNAME = new Field("BIDSECTIONNAME", "T_EC2_BIDSECTION",DbType.AnsiString, null, "标段（包）名称");
            /// <summary>
			/// 标段（包）内容
			/// </summary>
			public readonly static Field BIDSECTIONCONTENT = new Field("BIDSECTIONCONTENT", "T_EC2_BIDSECTION",DbType.AnsiString, null, "标段（包）内容");
            /// <summary>
			/// 标段（包）分类代码
			/// </summary>
			public readonly static Field TENDERPROJECTCLASSIFYCODE = new Field("TENDERPROJECTCLASSIFYCODE", "T_EC2_BIDSECTION", "标段（包）分类代码");
            /// <summary>
			/// 招标人代码类型
			/// </summary>
			public readonly static Field TENDERERCODETYPE = new Field("TENDERERCODETYPE", "T_EC2_BIDSECTION", "招标人代码类型");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERERCODE = new Field("TENDERERCODE", "T_EC2_BIDSECTION", "招标人代码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERERNAME = new Field("TENDERERNAME", "T_EC2_BIDSECTION", "招标人名称");
            /// <summary>
			/// 招标人基本信息版本号
			/// </summary>
			public readonly static Field TENDERERBASICINFOVERSION = new Field("TENDERERBASICINFOVERSION", "T_EC2_BIDSECTION", "招标人基本信息版本号");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDERMODE = new Field("TENDERMODE", "T_EC2_BIDSECTION", "招标方式");
            /// <summary>
			/// 标段合同估算价
			/// </summary>
			public readonly static Field CONTRACTRECKONPRICE = new Field("CONTRACTRECKONPRICE", "T_EC2_BIDSECTION", "标段合同估算价");
            /// <summary>
			/// 标段合同估算价币种代码
			/// </summary>
			public readonly static Field CURRENCYCODE = new Field("CURRENCYCODE", "T_EC2_BIDSECTION", "标段合同估算价币种代码");
            /// <summary>
			/// 标段合同估算价单位
			/// </summary>
			public readonly static Field PRICEUNIT = new Field("PRICEUNIT", "T_EC2_BIDSECTION", "标段合同估算价单位");
            /// <summary>
			/// 投标人资格条件
			/// </summary>
			public readonly static Field BIDQUALIFICATION = new Field("BIDQUALIFICATION", "T_EC2_BIDSECTION",DbType.AnsiString, null, "投标人资格条件");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_BIDSECTION", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_BIDSECTION", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_BIDSECTION", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_BIDSECTION", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_BIDSECTION", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_BIDSECTION", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_BIDSECTION", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_BIDSECTION", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_BIDSECTION", "数据时间");
        }
        #endregion
	}
}