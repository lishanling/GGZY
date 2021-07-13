using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEA_MEDI_WIN_BID_DETAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEA_MEDI_WIN_BID_DETAIL")]
    [Serializable]
    public partial class DEA_MEDI_WIN_BID_DETAIL : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _PROJECT_CODE;
		private string _PROJNAME;
		private string _DRUGGROUP;
		private string _CATAID;
		private string _CATANAME;
		private string _DRUGNUM;
		private string _DRUGCATA;
		private string _YPID;
		private string _DRUGID;
		private string _DRUGNAME;
		private string _DRUGFORM;
		private string _DRUGSPEC;
		private string _DRUGPREUNIT;
		private decimal? _DRUGFACTOR;
		private string _DRUGUNIT;
		private string _DRUGMATERIAL;
		private string _APPROVALNUM;
		private string _FACTORYNAME;
		private string _FACTORYID;
		private string _FACTORY_ORGCODE;
		private string _BIDDER_ID;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE;
		private decimal? _PREPRICE_BID;
		private decimal? _PRICE_BID;
		private decimal? _PRICE_RETAIL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_VERSION;

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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJNAME
		{
			get{ return _PROJNAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJNAME, _PROJNAME, value);
				this._PROJNAME = value;
			}
		}
		/// <summary>
		/// 采购类别
		/// </summary>
		public string DRUGGROUP
		{
			get{ return _DRUGGROUP; }
			set
			{
				this.OnPropertyValueChange(_.DRUGGROUP, _DRUGGROUP, value);
				this._DRUGGROUP = value;
			}
		}
		/// <summary>
		/// 目录编号
		/// </summary>
		public string CATAID
		{
			get{ return _CATAID; }
			set
			{
				this.OnPropertyValueChange(_.CATAID, _CATAID, value);
				this._CATAID = value;
			}
		}
		/// <summary>
		/// 目录名称
		/// </summary>
		public string CATANAME
		{
			get{ return _CATANAME; }
			set
			{
				this.OnPropertyValueChange(_.CATANAME, _CATANAME, value);
				this._CATANAME = value;
			}
		}
		/// <summary>
		/// 产品序号
		/// </summary>
		public string DRUGNUM
		{
			get{ return _DRUGNUM; }
			set
			{
				this.OnPropertyValueChange(_.DRUGNUM, _DRUGNUM, value);
				this._DRUGNUM = value;
			}
		}
		/// <summary>
		/// 所属品种名称
		/// </summary>
		public string DRUGCATA
		{
			get{ return _DRUGCATA; }
			set
			{
				this.OnPropertyValueChange(_.DRUGCATA, _DRUGCATA, value);
				this._DRUGCATA = value;
			}
		}
		/// <summary>
		/// 国家药品编码
		/// </summary>
		public string YPID
		{
			get{ return _YPID; }
			set
			{
				this.OnPropertyValueChange(_.YPID, _YPID, value);
				this._YPID = value;
			}
		}
		/// <summary>
		/// 产品编码
		/// </summary>
		public string DRUGID
		{
			get{ return _DRUGID; }
			set
			{
				this.OnPropertyValueChange(_.DRUGID, _DRUGID, value);
				this._DRUGID = value;
			}
		}
		/// <summary>
		/// 通用名
		/// </summary>
		public string DRUGNAME
		{
			get{ return _DRUGNAME; }
			set
			{
				this.OnPropertyValueChange(_.DRUGNAME, _DRUGNAME, value);
				this._DRUGNAME = value;
			}
		}
		/// <summary>
		/// 剂型
		/// </summary>
		public string DRUGFORM
		{
			get{ return _DRUGFORM; }
			set
			{
				this.OnPropertyValueChange(_.DRUGFORM, _DRUGFORM, value);
				this._DRUGFORM = value;
			}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string DRUGSPEC
		{
			get{ return _DRUGSPEC; }
			set
			{
				this.OnPropertyValueChange(_.DRUGSPEC, _DRUGSPEC, value);
				this._DRUGSPEC = value;
			}
		}
		/// <summary>
		/// 最小制剂单位
		/// </summary>
		public string DRUGPREUNIT
		{
			get{ return _DRUGPREUNIT; }
			set
			{
				this.OnPropertyValueChange(_.DRUGPREUNIT, _DRUGPREUNIT, value);
				this._DRUGPREUNIT = value;
			}
		}
		/// <summary>
		/// 包装数量
		/// </summary>
		public decimal? DRUGFACTOR
		{
			get{ return _DRUGFACTOR; }
			set
			{
				this.OnPropertyValueChange(_.DRUGFACTOR, _DRUGFACTOR, value);
				this._DRUGFACTOR = value;
			}
		}
		/// <summary>
		/// 包装单位
		/// </summary>
		public string DRUGUNIT
		{
			get{ return _DRUGUNIT; }
			set
			{
				this.OnPropertyValueChange(_.DRUGUNIT, _DRUGUNIT, value);
				this._DRUGUNIT = value;
			}
		}
		/// <summary>
		/// 材质
		/// </summary>
		public string DRUGMATERIAL
		{
			get{ return _DRUGMATERIAL; }
			set
			{
				this.OnPropertyValueChange(_.DRUGMATERIAL, _DRUGMATERIAL, value);
				this._DRUGMATERIAL = value;
			}
		}
		/// <summary>
		/// 药品批准文号
		/// </summary>
		public string APPROVALNUM
		{
			get{ return _APPROVALNUM; }
			set
			{
				this.OnPropertyValueChange(_.APPROVALNUM, _APPROVALNUM, value);
				this._APPROVALNUM = value;
			}
		}
		/// <summary>
		/// 生产企业名称
		/// </summary>
		public string FACTORYNAME
		{
			get{ return _FACTORYNAME; }
			set
			{
				this.OnPropertyValueChange(_.FACTORYNAME, _FACTORYNAME, value);
				this._FACTORYNAME = value;
			}
		}
		/// <summary>
		/// 生产企业编码
		/// </summary>
		public string FACTORYID
		{
			get{ return _FACTORYID; }
			set
			{
				this.OnPropertyValueChange(_.FACTORYID, _FACTORYID, value);
				this._FACTORYID = value;
			}
		}
		/// <summary>
		/// 生产企业统一社会信用代码/组织机构代码
		/// </summary>
		public string FACTORY_ORGCODE
		{
			get{ return _FACTORY_ORGCODE; }
			set
			{
				this.OnPropertyValueChange(_.FACTORY_ORGCODE, _FACTORY_ORGCODE, value);
				this._FACTORY_ORGCODE = value;
			}
		}
		/// <summary>
		/// 中标企业编码
		/// </summary>
		public string BIDDER_ID
		{
			get{ return _BIDDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ID, _BIDDER_ID, value);
				this._BIDDER_ID = value;
			}
		}
		/// <summary>
		/// 中标企业名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 中标企业统一社会信用代码/组织机构代码
		/// </summary>
		public string BIDDER_CODE
		{
			get{ return _BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE, _BIDDER_CODE, value);
				this._BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 最小制剂单位统一采购价格
		/// </summary>
		public decimal? PREPRICE_BID
		{
			get{ return _PREPRICE_BID; }
			set
			{
				this.OnPropertyValueChange(_.PREPRICE_BID, _PREPRICE_BID, value);
				this._PREPRICE_BID = value;
			}
		}
		/// <summary>
		/// 包装价格
		/// </summary>
		public decimal? PRICE_BID
		{
			get{ return _PRICE_BID; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_BID, _PRICE_BID, value);
				this._PRICE_BID = value;
			}
		}
		/// <summary>
		/// 中标后零售价
		/// </summary>
		public decimal? PRICE_RETAIL
		{
			get{ return _PRICE_RETAIL; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_RETAIL, _PRICE_RETAIL, value);
				this._PRICE_RETAIL = value;
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
		/// 
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
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
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
				_.M_ID,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.PROJECT_CODE,
				_.PROJNAME,
				_.DRUGGROUP,
				_.CATAID,
				_.CATANAME,
				_.DRUGNUM,
				_.DRUGCATA,
				_.YPID,
				_.DRUGID,
				_.DRUGNAME,
				_.DRUGFORM,
				_.DRUGSPEC,
				_.DRUGPREUNIT,
				_.DRUGFACTOR,
				_.DRUGUNIT,
				_.DRUGMATERIAL,
				_.APPROVALNUM,
				_.FACTORYNAME,
				_.FACTORYID,
				_.FACTORY_ORGCODE,
				_.BIDDER_ID,
				_.BIDDER_NAME,
				_.BIDDER_CODE,
				_.PREPRICE_BID,
				_.PRICE_BID,
				_.PRICE_RETAIL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._PROJECT_CODE,
				this._PROJNAME,
				this._DRUGGROUP,
				this._CATAID,
				this._CATANAME,
				this._DRUGNUM,
				this._DRUGCATA,
				this._YPID,
				this._DRUGID,
				this._DRUGNAME,
				this._DRUGFORM,
				this._DRUGSPEC,
				this._DRUGPREUNIT,
				this._DRUGFACTOR,
				this._DRUGUNIT,
				this._DRUGMATERIAL,
				this._APPROVALNUM,
				this._FACTORYNAME,
				this._FACTORYID,
				this._FACTORY_ORGCODE,
				this._BIDDER_ID,
				this._BIDDER_NAME,
				this._BIDDER_CODE,
				this._PREPRICE_BID,
				this._PRICE_BID,
				this._PRICE_RETAIL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_VERSION,
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
			public readonly static Field All = new Field("*", "DEA_MEDI_WIN_BID_DETAIL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "DEA_MEDI_WIN_BID_DETAIL", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJNAME = new Field("PROJNAME", "DEA_MEDI_WIN_BID_DETAIL", "项目名称");
            /// <summary>
			/// 采购类别
			/// </summary>
			public readonly static Field DRUGGROUP = new Field("DRUGGROUP", "DEA_MEDI_WIN_BID_DETAIL", "采购类别");
            /// <summary>
			/// 目录编号
			/// </summary>
			public readonly static Field CATAID = new Field("CATAID", "DEA_MEDI_WIN_BID_DETAIL", "目录编号");
            /// <summary>
			/// 目录名称
			/// </summary>
			public readonly static Field CATANAME = new Field("CATANAME", "DEA_MEDI_WIN_BID_DETAIL", "目录名称");
            /// <summary>
			/// 产品序号
			/// </summary>
			public readonly static Field DRUGNUM = new Field("DRUGNUM", "DEA_MEDI_WIN_BID_DETAIL", "产品序号");
            /// <summary>
			/// 所属品种名称
			/// </summary>
			public readonly static Field DRUGCATA = new Field("DRUGCATA", "DEA_MEDI_WIN_BID_DETAIL", "所属品种名称");
            /// <summary>
			/// 国家药品编码
			/// </summary>
			public readonly static Field YPID = new Field("YPID", "DEA_MEDI_WIN_BID_DETAIL", "国家药品编码");
            /// <summary>
			/// 产品编码
			/// </summary>
			public readonly static Field DRUGID = new Field("DRUGID", "DEA_MEDI_WIN_BID_DETAIL", "产品编码");
            /// <summary>
			/// 通用名
			/// </summary>
			public readonly static Field DRUGNAME = new Field("DRUGNAME", "DEA_MEDI_WIN_BID_DETAIL", "通用名");
            /// <summary>
			/// 剂型
			/// </summary>
			public readonly static Field DRUGFORM = new Field("DRUGFORM", "DEA_MEDI_WIN_BID_DETAIL", "剂型");
            /// <summary>
			/// 规格
			/// </summary>
			public readonly static Field DRUGSPEC = new Field("DRUGSPEC", "DEA_MEDI_WIN_BID_DETAIL", "规格");
            /// <summary>
			/// 最小制剂单位
			/// </summary>
			public readonly static Field DRUGPREUNIT = new Field("DRUGPREUNIT", "DEA_MEDI_WIN_BID_DETAIL", "最小制剂单位");
            /// <summary>
			/// 包装数量
			/// </summary>
			public readonly static Field DRUGFACTOR = new Field("DRUGFACTOR", "DEA_MEDI_WIN_BID_DETAIL", "包装数量");
            /// <summary>
			/// 包装单位
			/// </summary>
			public readonly static Field DRUGUNIT = new Field("DRUGUNIT", "DEA_MEDI_WIN_BID_DETAIL", "包装单位");
            /// <summary>
			/// 材质
			/// </summary>
			public readonly static Field DRUGMATERIAL = new Field("DRUGMATERIAL", "DEA_MEDI_WIN_BID_DETAIL", "材质");
            /// <summary>
			/// 药品批准文号
			/// </summary>
			public readonly static Field APPROVALNUM = new Field("APPROVALNUM", "DEA_MEDI_WIN_BID_DETAIL", "药品批准文号");
            /// <summary>
			/// 生产企业名称
			/// </summary>
			public readonly static Field FACTORYNAME = new Field("FACTORYNAME", "DEA_MEDI_WIN_BID_DETAIL", "生产企业名称");
            /// <summary>
			/// 生产企业编码
			/// </summary>
			public readonly static Field FACTORYID = new Field("FACTORYID", "DEA_MEDI_WIN_BID_DETAIL", "生产企业编码");
            /// <summary>
			/// 生产企业统一社会信用代码/组织机构代码
			/// </summary>
			public readonly static Field FACTORY_ORGCODE = new Field("FACTORY_ORGCODE", "DEA_MEDI_WIN_BID_DETAIL", "生产企业统一社会信用代码/组织机构代码");
            /// <summary>
			/// 中标企业编码
			/// </summary>
			public readonly static Field BIDDER_ID = new Field("BIDDER_ID", "DEA_MEDI_WIN_BID_DETAIL", "中标企业编码");
            /// <summary>
			/// 中标企业名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "DEA_MEDI_WIN_BID_DETAIL", "中标企业名称");
            /// <summary>
			/// 中标企业统一社会信用代码/组织机构代码
			/// </summary>
			public readonly static Field BIDDER_CODE = new Field("BIDDER_CODE", "DEA_MEDI_WIN_BID_DETAIL", "中标企业统一社会信用代码/组织机构代码");
            /// <summary>
			/// 最小制剂单位统一采购价格
			/// </summary>
			public readonly static Field PREPRICE_BID = new Field("PREPRICE_BID", "DEA_MEDI_WIN_BID_DETAIL", "最小制剂单位统一采购价格");
            /// <summary>
			/// 包装价格
			/// </summary>
			public readonly static Field PRICE_BID = new Field("PRICE_BID", "DEA_MEDI_WIN_BID_DETAIL", "包装价格");
            /// <summary>
			/// 中标后零售价
			/// </summary>
			public readonly static Field PRICE_RETAIL = new Field("PRICE_RETAIL", "DEA_MEDI_WIN_BID_DETAIL", "中标后零售价");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEA_MEDI_WIN_BID_DETAIL", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEA_MEDI_WIN_BID_DETAIL", "公共服务平台标识码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEA_MEDI_WIN_BID_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEA_MEDI_WIN_BID_DETAIL", "");
        }
        #endregion
	}
}