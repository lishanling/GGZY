using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_SERVICEOPENBIDLIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_SERVICEOPENBIDLIST")]
    [Serializable]
    public partial class T_EC2_SERVICEOPENBIDLIST : FwEntity
    {
        #region Model
		private string _SERVICEOPENBIDLISTCODE;
		private string _OPENBIDRECORDCODE;
		private string _BIDSECTIONCODE;
		private string _ISUNION;
		private string _UNIONCODETYPE;
		private string _UNIONCODE;
		private string _UNIONNAME;
		private string _UNIONMEMBERBASICINFOVERSION;
		private string _BIDDERCODETYPE;
		private string _BIDDERCODE;
		private string _BIDDERNAME;
		private DateTime? _BIDDERBASICINFOVERSION;
		private string _DURATION;
		private decimal? _BIDAMOUNT;
		private string _CURRENCYCODE;
		private string _PRICEUNIT;
		private string _OTHERBIDPRICE;
		private string _RESPONSIBLENAME;
		private string _RESPONSIBLECODETYPE;
		private string _RESPONSIBLECODE;
		private string _OTHEROPENBIDCONTENT;
		private DateTime? _VERSION;
		private string _OPENTYPE;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private DateTime? _VERIFYTIME;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 开标明细（服务）编号
		/// </summary>
		public string SERVICEOPENBIDLISTCODE
		{
			get{ return _SERVICEOPENBIDLISTCODE; }
			set
			{
				this.OnPropertyValueChange(_.SERVICEOPENBIDLISTCODE, _SERVICEOPENBIDLISTCODE, value);
				this._SERVICEOPENBIDLISTCODE = value;
			}
		}
		/// <summary>
		/// 开标记录编号
		/// </summary>
		public string OPENBIDRECORDCODE
		{
			get{ return _OPENBIDRECORDCODE; }
			set
			{
				this.OnPropertyValueChange(_.OPENBIDRECORDCODE, _OPENBIDRECORDCODE, value);
				this._OPENBIDRECORDCODE = value;
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
		/// 是否联合体
		/// </summary>
		public string ISUNION
		{
			get{ return _ISUNION; }
			set
			{
				this.OnPropertyValueChange(_.ISUNION, _ISUNION, value);
				this._ISUNION = value;
			}
		}
		/// <summary>
		/// 联合体代码类型
		/// </summary>
		public string UNIONCODETYPE
		{
			get{ return _UNIONCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.UNIONCODETYPE, _UNIONCODETYPE, value);
				this._UNIONCODETYPE = value;
			}
		}
		/// <summary>
		/// 联合体代码
		/// </summary>
		public string UNIONCODE
		{
			get{ return _UNIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIONCODE, _UNIONCODE, value);
				this._UNIONCODE = value;
			}
		}
		/// <summary>
		/// 联合体名称
		/// </summary>
		public string UNIONNAME
		{
			get{ return _UNIONNAME; }
			set
			{
				this.OnPropertyValueChange(_.UNIONNAME, _UNIONNAME, value);
				this._UNIONNAME = value;
			}
		}
		/// <summary>
		/// 联合体成员基本信息版本号
		/// </summary>
		public string UNIONMEMBERBASICINFOVERSION
		{
			get{ return _UNIONMEMBERBASICINFOVERSION; }
			set
			{
				this.OnPropertyValueChange(_.UNIONMEMBERBASICINFOVERSION, _UNIONMEMBERBASICINFOVERSION, value);
				this._UNIONMEMBERBASICINFOVERSION = value;
			}
		}
		/// <summary>
		/// 投标人代码类型
		/// </summary>
		public string BIDDERCODETYPE
		{
			get{ return _BIDDERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERCODETYPE, _BIDDERCODETYPE, value);
				this._BIDDERCODETYPE = value;
			}
		}
		/// <summary>
		/// 投标人代码
		/// </summary>
		public string BIDDERCODE
		{
			get{ return _BIDDERCODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERCODE, _BIDDERCODE, value);
				this._BIDDERCODE = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDERNAME
		{
			get{ return _BIDDERNAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERNAME, _BIDDERNAME, value);
				this._BIDDERNAME = value;
			}
		}
		/// <summary>
		/// 投标人基本信息版本号
		/// </summary>
		public DateTime? BIDDERBASICINFOVERSION
		{
			get{ return _BIDDERBASICINFOVERSION; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERBASICINFOVERSION, _BIDDERBASICINFOVERSION, value);
				this._BIDDERBASICINFOVERSION = value;
			}
		}
		/// <summary>
		/// 服务期
		/// </summary>
		public string DURATION
		{
			get{ return _DURATION; }
			set
			{
				this.OnPropertyValueChange(_.DURATION, _DURATION, value);
				this._DURATION = value;
			}
		}
		/// <summary>
		/// 投标报价金额
		/// </summary>
		public decimal? BIDAMOUNT
		{
			get{ return _BIDAMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BIDAMOUNT, _BIDAMOUNT, value);
				this._BIDAMOUNT = value;
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
		/// 其他类型投标报价
		/// </summary>
		public string OTHERBIDPRICE
		{
			get{ return _OTHERBIDPRICE; }
			set
			{
				this.OnPropertyValueChange(_.OTHERBIDPRICE, _OTHERBIDPRICE, value);
				this._OTHERBIDPRICE = value;
			}
		}
		/// <summary>
		/// 负责人姓名
		/// </summary>
		public string RESPONSIBLENAME
		{
			get{ return _RESPONSIBLENAME; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSIBLENAME, _RESPONSIBLENAME, value);
				this._RESPONSIBLENAME = value;
			}
		}
		/// <summary>
		/// 负责人证件类型
		/// </summary>
		public string RESPONSIBLECODETYPE
		{
			get{ return _RESPONSIBLECODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSIBLECODETYPE, _RESPONSIBLECODETYPE, value);
				this._RESPONSIBLECODETYPE = value;
			}
		}
		/// <summary>
		/// 负责人证件号码
		/// </summary>
		public string RESPONSIBLECODE
		{
			get{ return _RESPONSIBLECODE; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSIBLECODE, _RESPONSIBLECODE, value);
				this._RESPONSIBLECODE = value;
			}
		}
		/// <summary>
		/// 其他开标内容
		/// </summary>
		public string OTHEROPENBIDCONTENT
		{
			get{ return _OTHEROPENBIDCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.OTHEROPENBIDCONTENT, _OTHEROPENBIDCONTENT, value);
				this._OTHEROPENBIDCONTENT = value;
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
				_.SERVICEOPENBIDLISTCODE,
				_.BIDSECTIONCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.SERVICEOPENBIDLISTCODE,
				_.OPENBIDRECORDCODE,
				_.BIDSECTIONCODE,
				_.ISUNION,
				_.UNIONCODETYPE,
				_.UNIONCODE,
				_.UNIONNAME,
				_.UNIONMEMBERBASICINFOVERSION,
				_.BIDDERCODETYPE,
				_.BIDDERCODE,
				_.BIDDERNAME,
				_.BIDDERBASICINFOVERSION,
				_.DURATION,
				_.BIDAMOUNT,
				_.CURRENCYCODE,
				_.PRICEUNIT,
				_.OTHERBIDPRICE,
				_.RESPONSIBLENAME,
				_.RESPONSIBLECODETYPE,
				_.RESPONSIBLECODE,
				_.OTHEROPENBIDCONTENT,
				_.VERSION,
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
				this._SERVICEOPENBIDLISTCODE,
				this._OPENBIDRECORDCODE,
				this._BIDSECTIONCODE,
				this._ISUNION,
				this._UNIONCODETYPE,
				this._UNIONCODE,
				this._UNIONNAME,
				this._UNIONMEMBERBASICINFOVERSION,
				this._BIDDERCODETYPE,
				this._BIDDERCODE,
				this._BIDDERNAME,
				this._BIDDERBASICINFOVERSION,
				this._DURATION,
				this._BIDAMOUNT,
				this._CURRENCYCODE,
				this._PRICEUNIT,
				this._OTHERBIDPRICE,
				this._RESPONSIBLENAME,
				this._RESPONSIBLECODETYPE,
				this._RESPONSIBLECODE,
				this._OTHEROPENBIDCONTENT,
				this._VERSION,
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
			public readonly static Field All = new Field("*", "T_EC2_SERVICEOPENBIDLIST");
            /// <summary>
			/// 开标明细（服务）编号
			/// </summary>
			public readonly static Field SERVICEOPENBIDLISTCODE = new Field("SERVICEOPENBIDLISTCODE", "T_EC2_SERVICEOPENBIDLIST", "开标明细（服务）编号");
            /// <summary>
			/// 开标记录编号
			/// </summary>
			public readonly static Field OPENBIDRECORDCODE = new Field("OPENBIDRECORDCODE", "T_EC2_SERVICEOPENBIDLIST", "开标记录编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODE = new Field("BIDSECTIONCODE", "T_EC2_SERVICEOPENBIDLIST", "标段（包）编号");
            /// <summary>
			/// 是否联合体
			/// </summary>
			public readonly static Field ISUNION = new Field("ISUNION", "T_EC2_SERVICEOPENBIDLIST", "是否联合体");
            /// <summary>
			/// 联合体代码类型
			/// </summary>
			public readonly static Field UNIONCODETYPE = new Field("UNIONCODETYPE", "T_EC2_SERVICEOPENBIDLIST", "联合体代码类型");
            /// <summary>
			/// 联合体代码
			/// </summary>
			public readonly static Field UNIONCODE = new Field("UNIONCODE", "T_EC2_SERVICEOPENBIDLIST", "联合体代码");
            /// <summary>
			/// 联合体名称
			/// </summary>
			public readonly static Field UNIONNAME = new Field("UNIONNAME", "T_EC2_SERVICEOPENBIDLIST",DbType.AnsiString, null, "联合体名称");
            /// <summary>
			/// 联合体成员基本信息版本号
			/// </summary>
			public readonly static Field UNIONMEMBERBASICINFOVERSION = new Field("UNIONMEMBERBASICINFOVERSION", "T_EC2_SERVICEOPENBIDLIST",DbType.AnsiString, null, "联合体成员基本信息版本号");
            /// <summary>
			/// 投标人代码类型
			/// </summary>
			public readonly static Field BIDDERCODETYPE = new Field("BIDDERCODETYPE", "T_EC2_SERVICEOPENBIDLIST", "投标人代码类型");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDERCODE = new Field("BIDDERCODE", "T_EC2_SERVICEOPENBIDLIST", "投标人代码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDERNAME = new Field("BIDDERNAME", "T_EC2_SERVICEOPENBIDLIST", "投标人名称");
            /// <summary>
			/// 投标人基本信息版本号
			/// </summary>
			public readonly static Field BIDDERBASICINFOVERSION = new Field("BIDDERBASICINFOVERSION", "T_EC2_SERVICEOPENBIDLIST", "投标人基本信息版本号");
            /// <summary>
			/// 服务期
			/// </summary>
			public readonly static Field DURATION = new Field("DURATION", "T_EC2_SERVICEOPENBIDLIST",DbType.AnsiString, null, "服务期");
            /// <summary>
			/// 投标报价金额
			/// </summary>
			public readonly static Field BIDAMOUNT = new Field("BIDAMOUNT", "T_EC2_SERVICEOPENBIDLIST", "投标报价金额");
            /// <summary>
			/// 金额币种
			/// </summary>
			public readonly static Field CURRENCYCODE = new Field("CURRENCYCODE", "T_EC2_SERVICEOPENBIDLIST", "金额币种");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field PRICEUNIT = new Field("PRICEUNIT", "T_EC2_SERVICEOPENBIDLIST", "金额单位");
            /// <summary>
			/// 其他类型投标报价
			/// </summary>
			public readonly static Field OTHERBIDPRICE = new Field("OTHERBIDPRICE", "T_EC2_SERVICEOPENBIDLIST",DbType.AnsiString, null, "其他类型投标报价");
            /// <summary>
			/// 负责人姓名
			/// </summary>
			public readonly static Field RESPONSIBLENAME = new Field("RESPONSIBLENAME", "T_EC2_SERVICEOPENBIDLIST", "负责人姓名");
            /// <summary>
			/// 负责人证件类型
			/// </summary>
			public readonly static Field RESPONSIBLECODETYPE = new Field("RESPONSIBLECODETYPE", "T_EC2_SERVICEOPENBIDLIST", "负责人证件类型");
            /// <summary>
			/// 负责人证件号码
			/// </summary>
			public readonly static Field RESPONSIBLECODE = new Field("RESPONSIBLECODE", "T_EC2_SERVICEOPENBIDLIST", "负责人证件号码");
            /// <summary>
			/// 其他开标内容
			/// </summary>
			public readonly static Field OTHEROPENBIDCONTENT = new Field("OTHEROPENBIDCONTENT", "T_EC2_SERVICEOPENBIDLIST", "其他开标内容");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_SERVICEOPENBIDLIST", "版本号");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_SERVICEOPENBIDLIST", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_SERVICEOPENBIDLIST", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_SERVICEOPENBIDLIST", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_SERVICEOPENBIDLIST", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_SERVICEOPENBIDLIST", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_SERVICEOPENBIDLIST", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_SERVICEOPENBIDLIST", "数据时间");
        }
        #endregion
	}
}