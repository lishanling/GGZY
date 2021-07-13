using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SW_PUBLISH。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SW_PUBLISH")]
    [Serializable]
    public partial class T_SW_PUBLISH : FwEntity
    {
        #region Model
		private string _PROJECT_NO;
		private string _PROJECT_NAME;
		private string _PROJECT_PRICE;
		private string _PAY_MODE;
		private string _PAY_MODE_PART;
		private decimal? _PUBLISH_DAYSN3;
		private DateTime? _PUBLISH_START_TIME;
		private DateTime? _PUBLISH_END_TIME;
		private string _PUBLISH_DELAY_FLAG;
		private string _DELAY_MAXN2;
		private decimal? _DELAY_PEROID;
		private string _PUBLISH_DEAL_WAY;
		private string _BAIL_TYPE;
		private string _BAIL;
		private string _BAIL_PAYMETHOD;
		private DateTime? _BAIL_DEAD_TIME;
		private string _BAIL_BANK_NO;
		private string _HAS_PRIORITY;
		private string _UNIT_TRANSFER;
		private string _BUY_CONDITIONS;
		private string _SUBMIT_FILES;
		private string _BAIL_CONTENT;
		private string _BAIL_CONTENT_DEAL;
		private string _IMPORTANT;
		private string _SELL_CONDITIONS;
		private string _M_INDUSTRIESTYPE;
		private string _M_NOTICECONTENT;
		private string _M_BULLETINTYPE;
		private string _M_NOTICENATURE;
		private DateTime? _M_NOTICESENDTIME;
		private string _M_AREACODE;
		private string _M_ANNOUNCEMENT_TITLE;
		private decimal? _CONTROLPRICE;
		private string _DATASOURCENAME;
		private string _DATASOURCECODE;

		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_NO
		{
			get{ return _PROJECT_NO; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NO, _PROJECT_NO, value);
				this._PROJECT_NO = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 挂牌价格
		/// </summary>
		public string PROJECT_PRICE
		{
			get{ return _PROJECT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PRICE, _PROJECT_PRICE, value);
				this._PROJECT_PRICE = value;
			}
		}
		/// <summary>
		/// 交易价款支付方式
		/// </summary>
		public string PAY_MODE
		{
			get{ return _PAY_MODE; }
			set
			{
				this.OnPropertyValueChange(_.PAY_MODE, _PAY_MODE, value);
				this._PAY_MODE = value;
			}
		}
		/// <summary>
		/// 分期支付要求
		/// </summary>
		public string PAY_MODE_PART
		{
			get{ return _PAY_MODE_PART; }
			set
			{
				this.OnPropertyValueChange(_.PAY_MODE_PART, _PAY_MODE_PART, value);
				this._PAY_MODE_PART = value;
			}
		}
		/// <summary>
		/// 挂牌公告期
		/// </summary>
		public decimal? PUBLISH_DAYSN3
		{
			get{ return _PUBLISH_DAYSN3; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DAYSN3, _PUBLISH_DAYSN3, value);
				this._PUBLISH_DAYSN3 = value;
			}
		}
		/// <summary>
		/// 挂牌开始时间
		/// </summary>
		public DateTime? PUBLISH_START_TIME
		{
			get{ return _PUBLISH_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_START_TIME, _PUBLISH_START_TIME, value);
				this._PUBLISH_START_TIME = value;
			}
		}
		/// <summary>
		/// 挂牌截止时间
		/// </summary>
		public DateTime? PUBLISH_END_TIME
		{
			get{ return _PUBLISH_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_END_TIME, _PUBLISH_END_TIME, value);
				this._PUBLISH_END_TIME = value;
			}
		}
		/// <summary>
		/// 是否延牌
		/// </summary>
		public string PUBLISH_DELAY_FLAG
		{
			get{ return _PUBLISH_DELAY_FLAG; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DELAY_FLAG, _PUBLISH_DELAY_FLAG, value);
				this._PUBLISH_DELAY_FLAG = value;
			}
		}
		/// <summary>
		/// 延牌规则
		/// </summary>
		public string DELAY_MAXN2
		{
			get{ return _DELAY_MAXN2; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_MAXN2, _DELAY_MAXN2, value);
				this._DELAY_MAXN2 = value;
			}
		}
		/// <summary>
		/// 延牌周期（工作日）
		/// </summary>
		public decimal? DELAY_PEROID
		{
			get{ return _DELAY_PEROID; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_PEROID, _DELAY_PEROID, value);
				this._DELAY_PEROID = value;
			}
		}
		/// <summary>
		/// 交易方式
		/// </summary>
		public string PUBLISH_DEAL_WAY
		{
			get{ return _PUBLISH_DEAL_WAY; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DEAL_WAY, _PUBLISH_DEAL_WAY, value);
				this._PUBLISH_DEAL_WAY = value;
			}
		}
		/// <summary>
		/// 保证金类型
		/// </summary>
		public string BAIL_TYPE
		{
			get{ return _BAIL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BAIL_TYPE, _BAIL_TYPE, value);
				this._BAIL_TYPE = value;
			}
		}
		/// <summary>
		/// 保证金金额
		/// </summary>
		public string BAIL
		{
			get{ return _BAIL; }
			set
			{
				this.OnPropertyValueChange(_.BAIL, _BAIL, value);
				this._BAIL = value;
			}
		}
		/// <summary>
		/// 保证金交纳形式
		/// </summary>
		public string BAIL_PAYMETHOD
		{
			get{ return _BAIL_PAYMETHOD; }
			set
			{
				this.OnPropertyValueChange(_.BAIL_PAYMETHOD, _BAIL_PAYMETHOD, value);
				this._BAIL_PAYMETHOD = value;
			}
		}
		/// <summary>
		/// 保证金交纳时间
		/// </summary>
		public DateTime? BAIL_DEAD_TIME
		{
			get{ return _BAIL_DEAD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BAIL_DEAD_TIME, _BAIL_DEAD_TIME, value);
				this._BAIL_DEAD_TIME = value;
			}
		}
		/// <summary>
		/// 保证金监管账户信息
		/// </summary>
		public string BAIL_BANK_NO
		{
			get{ return _BAIL_BANK_NO; }
			set
			{
				this.OnPropertyValueChange(_.BAIL_BANK_NO, _BAIL_BANK_NO, value);
				this._BAIL_BANK_NO = value;
			}
		}
		/// <summary>
		/// 是否涉及优先购买权
		/// </summary>
		public string HAS_PRIORITY
		{
			get{ return _HAS_PRIORITY; }
			set
			{
				this.OnPropertyValueChange(_.HAS_PRIORITY, _HAS_PRIORITY, value);
				this._HAS_PRIORITY = value;
			}
		}
		/// <summary>
		/// 是否允许联合受让
		/// </summary>
		public string UNIT_TRANSFER
		{
			get{ return _UNIT_TRANSFER; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_TRANSFER, _UNIT_TRANSFER, value);
				this._UNIT_TRANSFER = value;
			}
		}
		/// <summary>
		/// 受让方资格条件
		/// </summary>
		public string BUY_CONDITIONS
		{
			get{ return _BUY_CONDITIONS; }
			set
			{
				this.OnPropertyValueChange(_.BUY_CONDITIONS, _BUY_CONDITIONS, value);
				this._BUY_CONDITIONS = value;
			}
		}
		/// <summary>
		/// 意向受让方需要提交的材料
		/// </summary>
		public string SUBMIT_FILES
		{
			get{ return _SUBMIT_FILES; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_FILES, _SUBMIT_FILES, value);
				this._SUBMIT_FILES = value;
			}
		}
		/// <summary>
		/// 备注（保证内容）
		/// </summary>
		public string BAIL_CONTENT
		{
			get{ return _BAIL_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BAIL_CONTENT, _BAIL_CONTENT, value);
				this._BAIL_CONTENT = value;
			}
		}
		/// <summary>
		/// 备注（处置方法）
		/// </summary>
		public string BAIL_CONTENT_DEAL
		{
			get{ return _BAIL_CONTENT_DEAL; }
			set
			{
				this.OnPropertyValueChange(_.BAIL_CONTENT_DEAL, _BAIL_CONTENT_DEAL, value);
				this._BAIL_CONTENT_DEAL = value;
			}
		}
		/// <summary>
		/// 备注（重大事项及其他披露内容）
		/// </summary>
		public string IMPORTANT
		{
			get{ return _IMPORTANT; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTANT, _IMPORTANT, value);
				this._IMPORTANT = value;
			}
		}
		/// <summary>
		/// 备注（与转让相关的其他条件)
		/// </summary>
		public string SELL_CONDITIONS
		{
			get{ return _SELL_CONDITIONS; }
			set
			{
				this.OnPropertyValueChange(_.SELL_CONDITIONS, _SELL_CONDITIONS, value);
				this._SELL_CONDITIONS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_INDUSTRIESTYPE
		{
			get{ return _M_INDUSTRIESTYPE; }
			set
			{
				this.OnPropertyValueChange(_.M_INDUSTRIESTYPE, _M_INDUSTRIESTYPE, value);
				this._M_INDUSTRIESTYPE = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string M_NOTICECONTENT
		{
			get{ return _M_NOTICECONTENT; }
			set
			{
				this.OnPropertyValueChange(_.M_NOTICECONTENT, _M_NOTICECONTENT, value);
				this._M_NOTICECONTENT = value;
			}
		}
		/// <summary>
		/// 公告类型
		/// </summary>
		public string M_BULLETINTYPE
		{
			get{ return _M_BULLETINTYPE; }
			set
			{
				this.OnPropertyValueChange(_.M_BULLETINTYPE, _M_BULLETINTYPE, value);
				this._M_BULLETINTYPE = value;
			}
		}
		/// <summary>
		/// 公告性质
		/// </summary>
		public string M_NOTICENATURE
		{
			get{ return _M_NOTICENATURE; }
			set
			{
				this.OnPropertyValueChange(_.M_NOTICENATURE, _M_NOTICENATURE, value);
				this._M_NOTICENATURE = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? M_NOTICESENDTIME
		{
			get{ return _M_NOTICESENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.M_NOTICESENDTIME, _M_NOTICESENDTIME, value);
				this._M_NOTICESENDTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_AREACODE
		{
			get{ return _M_AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.M_AREACODE, _M_AREACODE, value);
				this._M_AREACODE = value;
			}
		}
		/// <summary>
		/// 公告标题
		/// </summary>
		public string M_ANNOUNCEMENT_TITLE
		{
			get{ return _M_ANNOUNCEMENT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.M_ANNOUNCEMENT_TITLE, _M_ANNOUNCEMENT_TITLE, value);
				this._M_ANNOUNCEMENT_TITLE = value;
			}
		}
		/// <summary>
		/// 控制价（最高限价）（如有）
		/// </summary>
		public decimal? CONTROLPRICE
		{
			get{ return _CONTROLPRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTROLPRICE, _CONTROLPRICE, value);
				this._CONTROLPRICE = value;
			}
		}
		/// <summary>
		/// 数据来源名称
		/// </summary>
		public string DATASOURCENAME
		{
			get{ return _DATASOURCENAME; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCENAME, _DATASOURCENAME, value);
				this._DATASOURCENAME = value;
			}
		}
		/// <summary>
		/// 数据来源编码
		/// </summary>
		public string DATASOURCECODE
		{
			get{ return _DATASOURCECODE; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCECODE, _DATASOURCECODE, value);
				this._DATASOURCECODE = value;
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
				_.PROJECT_NO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PROJECT_NO,
				_.PROJECT_NAME,
				_.PROJECT_PRICE,
				_.PAY_MODE,
				_.PAY_MODE_PART,
				_.PUBLISH_DAYSN3,
				_.PUBLISH_START_TIME,
				_.PUBLISH_END_TIME,
				_.PUBLISH_DELAY_FLAG,
				_.DELAY_MAXN2,
				_.DELAY_PEROID,
				_.PUBLISH_DEAL_WAY,
				_.BAIL_TYPE,
				_.BAIL,
				_.BAIL_PAYMETHOD,
				_.BAIL_DEAD_TIME,
				_.BAIL_BANK_NO,
				_.HAS_PRIORITY,
				_.UNIT_TRANSFER,
				_.BUY_CONDITIONS,
				_.SUBMIT_FILES,
				_.BAIL_CONTENT,
				_.BAIL_CONTENT_DEAL,
				_.IMPORTANT,
				_.SELL_CONDITIONS,
				_.M_INDUSTRIESTYPE,
				_.M_NOTICECONTENT,
				_.M_BULLETINTYPE,
				_.M_NOTICENATURE,
				_.M_NOTICESENDTIME,
				_.M_AREACODE,
				_.M_ANNOUNCEMENT_TITLE,
				_.CONTROLPRICE,
				_.DATASOURCENAME,
				_.DATASOURCECODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_NO,
				this._PROJECT_NAME,
				this._PROJECT_PRICE,
				this._PAY_MODE,
				this._PAY_MODE_PART,
				this._PUBLISH_DAYSN3,
				this._PUBLISH_START_TIME,
				this._PUBLISH_END_TIME,
				this._PUBLISH_DELAY_FLAG,
				this._DELAY_MAXN2,
				this._DELAY_PEROID,
				this._PUBLISH_DEAL_WAY,
				this._BAIL_TYPE,
				this._BAIL,
				this._BAIL_PAYMETHOD,
				this._BAIL_DEAD_TIME,
				this._BAIL_BANK_NO,
				this._HAS_PRIORITY,
				this._UNIT_TRANSFER,
				this._BUY_CONDITIONS,
				this._SUBMIT_FILES,
				this._BAIL_CONTENT,
				this._BAIL_CONTENT_DEAL,
				this._IMPORTANT,
				this._SELL_CONDITIONS,
				this._M_INDUSTRIESTYPE,
				this._M_NOTICECONTENT,
				this._M_BULLETINTYPE,
				this._M_NOTICENATURE,
				this._M_NOTICESENDTIME,
				this._M_AREACODE,
				this._M_ANNOUNCEMENT_TITLE,
				this._CONTROLPRICE,
				this._DATASOURCENAME,
				this._DATASOURCECODE,
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
			public readonly static Field All = new Field("*", "T_SW_PUBLISH");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_NO = new Field("PROJECT_NO", "T_SW_PUBLISH", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_SW_PUBLISH", "项目名称");
            /// <summary>
			/// 挂牌价格
			/// </summary>
			public readonly static Field PROJECT_PRICE = new Field("PROJECT_PRICE", "T_SW_PUBLISH", "挂牌价格");
            /// <summary>
			/// 交易价款支付方式
			/// </summary>
			public readonly static Field PAY_MODE = new Field("PAY_MODE", "T_SW_PUBLISH", "交易价款支付方式");
            /// <summary>
			/// 分期支付要求
			/// </summary>
			public readonly static Field PAY_MODE_PART = new Field("PAY_MODE_PART", "T_SW_PUBLISH", "分期支付要求");
            /// <summary>
			/// 挂牌公告期
			/// </summary>
			public readonly static Field PUBLISH_DAYSN3 = new Field("PUBLISH_DAYSN3", "T_SW_PUBLISH", "挂牌公告期");
            /// <summary>
			/// 挂牌开始时间
			/// </summary>
			public readonly static Field PUBLISH_START_TIME = new Field("PUBLISH_START_TIME", "T_SW_PUBLISH", "挂牌开始时间");
            /// <summary>
			/// 挂牌截止时间
			/// </summary>
			public readonly static Field PUBLISH_END_TIME = new Field("PUBLISH_END_TIME", "T_SW_PUBLISH", "挂牌截止时间");
            /// <summary>
			/// 是否延牌
			/// </summary>
			public readonly static Field PUBLISH_DELAY_FLAG = new Field("PUBLISH_DELAY_FLAG", "T_SW_PUBLISH", "是否延牌");
            /// <summary>
			/// 延牌规则
			/// </summary>
			public readonly static Field DELAY_MAXN2 = new Field("DELAY_MAXN2", "T_SW_PUBLISH", "延牌规则");
            /// <summary>
			/// 延牌周期（工作日）
			/// </summary>
			public readonly static Field DELAY_PEROID = new Field("DELAY_PEROID", "T_SW_PUBLISH", "延牌周期（工作日）");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field PUBLISH_DEAL_WAY = new Field("PUBLISH_DEAL_WAY", "T_SW_PUBLISH", "交易方式");
            /// <summary>
			/// 保证金类型
			/// </summary>
			public readonly static Field BAIL_TYPE = new Field("BAIL_TYPE", "T_SW_PUBLISH", "保证金类型");
            /// <summary>
			/// 保证金金额
			/// </summary>
			public readonly static Field BAIL = new Field("BAIL", "T_SW_PUBLISH", "保证金金额");
            /// <summary>
			/// 保证金交纳形式
			/// </summary>
			public readonly static Field BAIL_PAYMETHOD = new Field("BAIL_PAYMETHOD", "T_SW_PUBLISH", "保证金交纳形式");
            /// <summary>
			/// 保证金交纳时间
			/// </summary>
			public readonly static Field BAIL_DEAD_TIME = new Field("BAIL_DEAD_TIME", "T_SW_PUBLISH", "保证金交纳时间");
            /// <summary>
			/// 保证金监管账户信息
			/// </summary>
			public readonly static Field BAIL_BANK_NO = new Field("BAIL_BANK_NO", "T_SW_PUBLISH", "保证金监管账户信息");
            /// <summary>
			/// 是否涉及优先购买权
			/// </summary>
			public readonly static Field HAS_PRIORITY = new Field("HAS_PRIORITY", "T_SW_PUBLISH", "是否涉及优先购买权");
            /// <summary>
			/// 是否允许联合受让
			/// </summary>
			public readonly static Field UNIT_TRANSFER = new Field("UNIT_TRANSFER", "T_SW_PUBLISH", "是否允许联合受让");
            /// <summary>
			/// 受让方资格条件
			/// </summary>
			public readonly static Field BUY_CONDITIONS = new Field("BUY_CONDITIONS", "T_SW_PUBLISH",DbType.AnsiString, null, "受让方资格条件");
            /// <summary>
			/// 意向受让方需要提交的材料
			/// </summary>
			public readonly static Field SUBMIT_FILES = new Field("SUBMIT_FILES", "T_SW_PUBLISH",DbType.AnsiString, null, "意向受让方需要提交的材料");
            /// <summary>
			/// 备注（保证内容）
			/// </summary>
			public readonly static Field BAIL_CONTENT = new Field("BAIL_CONTENT", "T_SW_PUBLISH",DbType.AnsiString, null, "备注（保证内容）");
            /// <summary>
			/// 备注（处置方法）
			/// </summary>
			public readonly static Field BAIL_CONTENT_DEAL = new Field("BAIL_CONTENT_DEAL", "T_SW_PUBLISH",DbType.AnsiString, null, "备注（处置方法）");
            /// <summary>
			/// 备注（重大事项及其他披露内容）
			/// </summary>
			public readonly static Field IMPORTANT = new Field("IMPORTANT", "T_SW_PUBLISH",DbType.AnsiString, null, "备注（重大事项及其他披露内容）");
            /// <summary>
			/// 备注（与转让相关的其他条件)
			/// </summary>
			public readonly static Field SELL_CONDITIONS = new Field("SELL_CONDITIONS", "T_SW_PUBLISH",DbType.AnsiString, null, "备注（与转让相关的其他条件)");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_INDUSTRIESTYPE = new Field("M_INDUSTRIESTYPE", "T_SW_PUBLISH", "");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field M_NOTICECONTENT = new Field("M_NOTICECONTENT", "T_SW_PUBLISH",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 公告类型
			/// </summary>
			public readonly static Field M_BULLETINTYPE = new Field("M_BULLETINTYPE", "T_SW_PUBLISH", "公告类型");
            /// <summary>
			/// 公告性质
			/// </summary>
			public readonly static Field M_NOTICENATURE = new Field("M_NOTICENATURE", "T_SW_PUBLISH", "公告性质");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field M_NOTICESENDTIME = new Field("M_NOTICESENDTIME", "T_SW_PUBLISH", "公告发布时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_AREACODE = new Field("M_AREACODE", "T_SW_PUBLISH", "");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field M_ANNOUNCEMENT_TITLE = new Field("M_ANNOUNCEMENT_TITLE", "T_SW_PUBLISH", "公告标题");
            /// <summary>
			/// 控制价（最高限价）（如有）
			/// </summary>
			public readonly static Field CONTROLPRICE = new Field("CONTROLPRICE", "T_SW_PUBLISH", "控制价（最高限价）（如有）");
            /// <summary>
			/// 数据来源名称
			/// </summary>
			public readonly static Field DATASOURCENAME = new Field("DATASOURCENAME", "T_SW_PUBLISH", "数据来源名称");
            /// <summary>
			/// 数据来源编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_SW_PUBLISH", "数据来源编码");
        }
        #endregion
	}
}