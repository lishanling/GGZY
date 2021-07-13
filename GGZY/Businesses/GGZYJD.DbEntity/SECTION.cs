using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SECTION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SECTION")]
    [Serializable]
    public partial class SECTION : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _BID_SECTION_CONTENT;
		private string _TENDER_PROJECT_CLASSIFY_CODE;
		private decimal? _CONTRACT_RECKON_PRICE;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private string _BID_QUALIFICATION;
		private DateTime? _BEGIN_DATE;
		private decimal? _LIMITE_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private DateTime? _CREATE_TIME;
		private decimal? _M_ID;
		private string _M_ATT_TENDER_FILE;
		private string _M_ATT_TENDER_FILE_ATTACHS;
		private string _M_ATT_TENDER_NOTICE;
		private string _M_ATT_TENDER_AGENT_CONTRACT;
		private string _M_ATT_FILE_EX_TDOC;
		private string _M_ATT_INVITE_DOC;
		private string _M_ATT_PUBLICITY_DOC;
		private string _M_ATT_WIN_BID_NOTICE;
		private string _M_ATT_DISSENT_DOC;
		private string _M_ATT_CONTRACT_DOC;
		private string _M_ATT_QUALIFICATION_DOC;
		private decimal? _M_CREATOR;
		private DateTime? _M_CREATE_TM;
		private decimal? _CONTROL_PRICE;
		private string _CONTROL_PRICE_CURRENCY;
		private string _CONTROL_PRICE_UNIT;

		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）内容
		/// </summary>
		public string BID_SECTION_CONTENT
		{
			get{ return _BID_SECTION_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CONTENT, _BID_SECTION_CONTENT, value);
				this._BID_SECTION_CONTENT = value;
			}
		}
		/// <summary>
		/// 标段（包）分类代码
		/// </summary>
		public string TENDER_PROJECT_CLASSIFY_CODE
		{
			get{ return _TENDER_PROJECT_CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CLASSIFY_CODE, _TENDER_PROJECT_CLASSIFY_CODE, value);
				this._TENDER_PROJECT_CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价
		/// </summary>
		public decimal? CONTRACT_RECKON_PRICE
		{
			get{ return _CONTRACT_RECKON_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_RECKON_PRICE, _CONTRACT_RECKON_PRICE, value);
				this._CONTRACT_RECKON_PRICE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价币种代码
		/// </summary>
		public string CURRENCY_CODE
		{
			get{ return _CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY_CODE, _CURRENCY_CODE, value);
				this._CURRENCY_CODE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价单位
		/// </summary>
		public string PRICE_UNIT
		{
			get{ return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 投标人资格条件
		/// </summary>
		public string BID_QUALIFICATION
		{
			get{ return _BID_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_QUALIFICATION, _BID_QUALIFICATION, value);
				this._BID_QUALIFICATION = value;
			}
		}
		/// <summary>
		/// 计划开工日期
		/// </summary>
		public DateTime? BEGIN_DATE
		{
			get{ return _BEGIN_DATE; }
			set
			{
				this.OnPropertyValueChange(_.BEGIN_DATE, _BEGIN_DATE, value);
				this._BEGIN_DATE = value;
			}
		}
		/// <summary>
		/// 工期
		/// </summary>
		public decimal? LIMITE_TIME
		{
			get{ return _LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_TIME, _LIMITE_TIME, value);
				this._LIMITE_TIME = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 建立时间
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 招标文件
		/// </summary>
		public string M_ATT_TENDER_FILE
		{
			get{ return _M_ATT_TENDER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE, _M_ATT_TENDER_FILE, value);
				this._M_ATT_TENDER_FILE = value;
			}
		}
		/// <summary>
		/// 招标文件附件
		/// </summary>
		public string M_ATT_TENDER_FILE_ATTACHS
		{
			get{ return _M_ATT_TENDER_FILE_ATTACHS; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE_ATTACHS, _M_ATT_TENDER_FILE_ATTACHS, value);
				this._M_ATT_TENDER_FILE_ATTACHS = value;
			}
		}
		/// <summary>
		/// 招标公告
		/// </summary>
		public string M_ATT_TENDER_NOTICE
		{
			get{ return _M_ATT_TENDER_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_NOTICE, _M_ATT_TENDER_NOTICE, value);
				this._M_ATT_TENDER_NOTICE = value;
			}
		}
		/// <summary>
		/// 招标代理合同
		/// </summary>
		public string M_ATT_TENDER_AGENT_CONTRACT
		{
			get{ return _M_ATT_TENDER_AGENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_AGENT_CONTRACT, _M_ATT_TENDER_AGENT_CONTRACT, value);
				this._M_ATT_TENDER_AGENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 加盖电子印章的澄清、答疑及补充PDF电子文件
		/// </summary>
		public string M_ATT_FILE_EX_TDOC
		{
			get{ return _M_ATT_FILE_EX_TDOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_FILE_EX_TDOC, _M_ATT_FILE_EX_TDOC, value);
				this._M_ATT_FILE_EX_TDOC = value;
			}
		}
		/// <summary>
		/// 投标邀请书
		/// </summary>
		public string M_ATT_INVITE_DOC
		{
			get{ return _M_ATT_INVITE_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_INVITE_DOC, _M_ATT_INVITE_DOC, value);
				this._M_ATT_INVITE_DOC = value;
			}
		}
		/// <summary>
		/// 中标候选人公示
		/// </summary>
		public string M_ATT_PUBLICITY_DOC
		{
			get{ return _M_ATT_PUBLICITY_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PUBLICITY_DOC, _M_ATT_PUBLICITY_DOC, value);
				this._M_ATT_PUBLICITY_DOC = value;
			}
		}
		/// <summary>
		/// 中标结果公告
		/// </summary>
		public string M_ATT_WIN_BID_NOTICE
		{
			get{ return _M_ATT_WIN_BID_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BID_NOTICE, _M_ATT_WIN_BID_NOTICE, value);
				this._M_ATT_WIN_BID_NOTICE = value;
			}
		}
		/// <summary>
		/// 异议/投诉
		/// </summary>
		public string M_ATT_DISSENT_DOC
		{
			get{ return _M_ATT_DISSENT_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_DISSENT_DOC, _M_ATT_DISSENT_DOC, value);
				this._M_ATT_DISSENT_DOC = value;
			}
		}
		/// <summary>
		/// 合同
		/// </summary>
		public string M_ATT_CONTRACT_DOC
		{
			get{ return _M_ATT_CONTRACT_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_CONTRACT_DOC, _M_ATT_CONTRACT_DOC, value);
				this._M_ATT_CONTRACT_DOC = value;
			}
		}
		/// <summary>
		/// 资格预审文件
		/// </summary>
		public string M_ATT_QUALIFICATION_DOC
		{
			get{ return _M_ATT_QUALIFICATION_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_QUALIFICATION_DOC, _M_ATT_QUALIFICATION_DOC, value);
				this._M_ATT_QUALIFICATION_DOC = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// 数据上传时间
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get{ return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// 控制价（最高限价）
		/// </summary>
		public decimal? CONTROL_PRICE
		{
			get{ return _CONTROL_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE, _CONTROL_PRICE, value);
				this._CONTROL_PRICE = value;
			}
		}
		/// <summary>
		/// 控制价币种代码
		/// </summary>
		public string CONTROL_PRICE_CURRENCY
		{
			get{ return _CONTROL_PRICE_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_CURRENCY, _CONTROL_PRICE_CURRENCY, value);
				this._CONTROL_PRICE_CURRENCY = value;
			}
		}
		/// <summary>
		/// 控制价单位
		/// </summary>
		public string CONTROL_PRICE_UNIT
		{
			get{ return _CONTROL_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_UNIT, _CONTROL_PRICE_UNIT, value);
				this._CONTROL_PRICE_UNIT = value;
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
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.BID_SECTION_CONTENT,
				_.TENDER_PROJECT_CLASSIFY_CODE,
				_.CONTRACT_RECKON_PRICE,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.BID_QUALIFICATION,
				_.BEGIN_DATE,
				_.LIMITE_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.CREATE_TIME,
				_.M_ID,
				_.M_ATT_TENDER_FILE,
				_.M_ATT_TENDER_FILE_ATTACHS,
				_.M_ATT_TENDER_NOTICE,
				_.M_ATT_TENDER_AGENT_CONTRACT,
				_.M_ATT_FILE_EX_TDOC,
				_.M_ATT_INVITE_DOC,
				_.M_ATT_PUBLICITY_DOC,
				_.M_ATT_WIN_BID_NOTICE,
				_.M_ATT_DISSENT_DOC,
				_.M_ATT_CONTRACT_DOC,
				_.M_ATT_QUALIFICATION_DOC,
				_.M_CREATOR,
				_.M_CREATE_TM,
				_.CONTROL_PRICE,
				_.CONTROL_PRICE_CURRENCY,
				_.CONTROL_PRICE_UNIT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._BID_SECTION_CONTENT,
				this._TENDER_PROJECT_CLASSIFY_CODE,
				this._CONTRACT_RECKON_PRICE,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._BID_QUALIFICATION,
				this._BEGIN_DATE,
				this._LIMITE_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._CREATE_TIME,
				this._M_ID,
				this._M_ATT_TENDER_FILE,
				this._M_ATT_TENDER_FILE_ATTACHS,
				this._M_ATT_TENDER_NOTICE,
				this._M_ATT_TENDER_AGENT_CONTRACT,
				this._M_ATT_FILE_EX_TDOC,
				this._M_ATT_INVITE_DOC,
				this._M_ATT_PUBLICITY_DOC,
				this._M_ATT_WIN_BID_NOTICE,
				this._M_ATT_DISSENT_DOC,
				this._M_ATT_CONTRACT_DOC,
				this._M_ATT_QUALIFICATION_DOC,
				this._M_CREATOR,
				this._M_CREATE_TM,
				this._CONTROL_PRICE,
				this._CONTROL_PRICE_CURRENCY,
				this._CONTROL_PRICE_UNIT,
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
			public readonly static Field All = new Field("*", "SECTION");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SECTION", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SECTION", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "SECTION", "标段（包）名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "SECTION", "统一交易标识码");
            /// <summary>
			/// 标段（包）内容
			/// </summary>
			public readonly static Field BID_SECTION_CONTENT = new Field("BID_SECTION_CONTENT", "SECTION",DbType.AnsiString, null, "标段（包）内容");
            /// <summary>
			/// 标段（包）分类代码
			/// </summary>
			public readonly static Field TENDER_PROJECT_CLASSIFY_CODE = new Field("TENDER_PROJECT_CLASSIFY_CODE", "SECTION", "标段（包）分类代码");
            /// <summary>
			/// 标段合同估算价
			/// </summary>
			public readonly static Field CONTRACT_RECKON_PRICE = new Field("CONTRACT_RECKON_PRICE", "SECTION", "标段合同估算价");
            /// <summary>
			/// 标段合同估算价币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "SECTION", "标段合同估算价币种代码");
            /// <summary>
			/// 标段合同估算价单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "SECTION", "标段合同估算价单位");
            /// <summary>
			/// 投标人资格条件
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "SECTION",DbType.AnsiString, null, "投标人资格条件");
            /// <summary>
			/// 计划开工日期
			/// </summary>
			public readonly static Field BEGIN_DATE = new Field("BEGIN_DATE", "SECTION", "计划开工日期");
            /// <summary>
			/// 工期
			/// </summary>
			public readonly static Field LIMITE_TIME = new Field("LIMITE_TIME", "SECTION", "工期");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SECTION", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SECTION", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SECTION", "数据时间戳");
            /// <summary>
			/// 建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "SECTION", "建立时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SECTION", "");
            /// <summary>
			/// 招标文件
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE = new Field("M_ATT_TENDER_FILE", "SECTION", "招标文件");
            /// <summary>
			/// 招标文件附件
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE_ATTACHS = new Field("M_ATT_TENDER_FILE_ATTACHS", "SECTION", "招标文件附件");
            /// <summary>
			/// 招标公告
			/// </summary>
			public readonly static Field M_ATT_TENDER_NOTICE = new Field("M_ATT_TENDER_NOTICE", "SECTION", "招标公告");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field M_ATT_TENDER_AGENT_CONTRACT = new Field("M_ATT_TENDER_AGENT_CONTRACT", "SECTION", "招标代理合同");
            /// <summary>
			/// 加盖电子印章的澄清、答疑及补充PDF电子文件
			/// </summary>
			public readonly static Field M_ATT_FILE_EX_TDOC = new Field("M_ATT_FILE_EX_TDOC", "SECTION", "加盖电子印章的澄清、答疑及补充PDF电子文件");
            /// <summary>
			/// 投标邀请书
			/// </summary>
			public readonly static Field M_ATT_INVITE_DOC = new Field("M_ATT_INVITE_DOC", "SECTION", "投标邀请书");
            /// <summary>
			/// 中标候选人公示
			/// </summary>
			public readonly static Field M_ATT_PUBLICITY_DOC = new Field("M_ATT_PUBLICITY_DOC", "SECTION", "中标候选人公示");
            /// <summary>
			/// 中标结果公告
			/// </summary>
			public readonly static Field M_ATT_WIN_BID_NOTICE = new Field("M_ATT_WIN_BID_NOTICE", "SECTION", "中标结果公告");
            /// <summary>
			/// 异议/投诉
			/// </summary>
			public readonly static Field M_ATT_DISSENT_DOC = new Field("M_ATT_DISSENT_DOC", "SECTION", "异议/投诉");
            /// <summary>
			/// 合同
			/// </summary>
			public readonly static Field M_ATT_CONTRACT_DOC = new Field("M_ATT_CONTRACT_DOC", "SECTION", "合同");
            /// <summary>
			/// 资格预审文件
			/// </summary>
			public readonly static Field M_ATT_QUALIFICATION_DOC = new Field("M_ATT_QUALIFICATION_DOC", "SECTION", "资格预审文件");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "SECTION", "创建人");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SECTION", "数据上传时间");
            /// <summary>
			/// 控制价（最高限价）
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "SECTION", "控制价（最高限价）");
            /// <summary>
			/// 控制价币种代码
			/// </summary>
			public readonly static Field CONTROL_PRICE_CURRENCY = new Field("CONTROL_PRICE_CURRENCY", "SECTION", "控制价币种代码");
            /// <summary>
			/// 控制价单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_UNIT = new Field("CONTROL_PRICE_UNIT", "SECTION", "控制价单位");
        }
        #endregion
	}
}