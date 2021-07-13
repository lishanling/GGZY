﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_VIOLATING_LAWS_RULES_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_VIOLATING_LAWS_RULES_INFO")]
    [Serializable]
    public partial class ZJ_VIOLATING_LAWS_RULES_INFO : FwEntity
    {
        #region Model
		private string _VIOLATING_CODE;
		private string _VIOLATING_NAME;
		private DateTime? _VIOLATING_TIME;
		private string _VIOLATING_TYPE;
		private string _BODY_NAME;
		private string _BODY_TYPE;
		private string _BODY_CODE;
		private string _BODY_ROLE;
		private string _AREA;
		private string _REWARD_PUNISHMENT_BODY;
		private string _VIOLATING_INSTRUCTIONS;
		private string _GOVERNMENT;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _DOCUMENT_CODE;
		private string _PUNISHMENT_BASIS;
		private string _PUNISHMENT_RESULT;
		private string _CONFINED_ACTION;
		private DateTime? _CONFINED_START;
		private DateTime? _CONFINED_END;
		private DateTime? _OPERATE_DATE;
		private string _M_DATA_SOURCE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _SCOPE;

		/// <summary>
		/// 违法违规信息标识号
		/// </summary>
		public string VIOLATING_CODE
		{
			get{ return _VIOLATING_CODE; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_CODE, _VIOLATING_CODE, value);
				this._VIOLATING_CODE = value;
			}
		}
		/// <summary>
		/// 违规事项名称
		/// </summary>
		public string VIOLATING_NAME
		{
			get{ return _VIOLATING_NAME; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_NAME, _VIOLATING_NAME, value);
				this._VIOLATING_NAME = value;
			}
		}
		/// <summary>
		/// 违规时间
		/// </summary>
		public DateTime? VIOLATING_TIME
		{
			get{ return _VIOLATING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_TIME, _VIOLATING_TIME, value);
				this._VIOLATING_TIME = value;
			}
		}
		/// <summary>
		/// 违规类型
		/// </summary>
		public string VIOLATING_TYPE
		{
			get{ return _VIOLATING_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_TYPE, _VIOLATING_TYPE, value);
				this._VIOLATING_TYPE = value;
			}
		}
		/// <summary>
		/// 主体名称
		/// </summary>
		public string BODY_NAME
		{
			get{ return _BODY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BODY_NAME, _BODY_NAME, value);
				this._BODY_NAME = value;
			}
		}
		/// <summary>
		/// 主体类别
		/// </summary>
		public string BODY_TYPE
		{
			get{ return _BODY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_TYPE, _BODY_TYPE, value);
				this._BODY_TYPE = value;
			}
		}
		/// <summary>
		/// 主体代码
		/// </summary>
		public string BODY_CODE
		{
			get{ return _BODY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_CODE, _BODY_CODE, value);
				this._BODY_CODE = value;
			}
		}
		/// <summary>
		/// 主体角色
		/// </summary>
		public string BODY_ROLE
		{
			get{ return _BODY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_ROLE, _BODY_ROLE, value);
				this._BODY_ROLE = value;
			}
		}
		/// <summary>
		/// 区域代码
		/// </summary>
		public string AREA
		{
			get{ return _AREA; }
			set
			{
				this.OnPropertyValueChange(_.AREA, _AREA, value);
				this._AREA = value;
			}
		}
		/// <summary>
		/// 奖惩或处罚类型
		/// </summary>
		public string REWARD_PUNISHMENT_BODY
		{
			get{ return _REWARD_PUNISHMENT_BODY; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_PUNISHMENT_BODY, _REWARD_PUNISHMENT_BODY, value);
				this._REWARD_PUNISHMENT_BODY = value;
			}
		}
		/// <summary>
		/// 违法违规说明
		/// </summary>
		public string VIOLATING_INSTRUCTIONS
		{
			get{ return _VIOLATING_INSTRUCTIONS; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_INSTRUCTIONS, _VIOLATING_INSTRUCTIONS, value);
				this._VIOLATING_INSTRUCTIONS = value;
			}
		}
		/// <summary>
		/// 违法违规通报部门
		/// </summary>
		public string GOVERNMENT
		{
			get{ return _GOVERNMENT; }
			set
			{
				this.OnPropertyValueChange(_.GOVERNMENT, _GOVERNMENT, value);
				this._GOVERNMENT = value;
			}
		}
		/// <summary>
		/// 招标项目（采购项目）名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 招标项目（采购项目）编号
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
		/// 处理文件文号
		/// </summary>
		public string DOCUMENT_CODE
		{
			get{ return _DOCUMENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_CODE, _DOCUMENT_CODE, value);
				this._DOCUMENT_CODE = value;
			}
		}
		/// <summary>
		/// 处罚依据
		/// </summary>
		public string PUNISHMENT_BASIS
		{
			get{ return _PUNISHMENT_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHMENT_BASIS, _PUNISHMENT_BASIS, value);
				this._PUNISHMENT_BASIS = value;
			}
		}
		/// <summary>
		/// 处罚结果
		/// </summary>
		public string PUNISHMENT_RESULT
		{
			get{ return _PUNISHMENT_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHMENT_RESULT, _PUNISHMENT_RESULT, value);
				this._PUNISHMENT_RESULT = value;
			}
		}
		/// <summary>
		/// 限制的行为
		/// </summary>
		public string CONFINED_ACTION
		{
			get{ return _CONFINED_ACTION; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_ACTION, _CONFINED_ACTION, value);
				this._CONFINED_ACTION = value;
			}
		}
		/// <summary>
		/// 限制行为开始时间
		/// </summary>
		public DateTime? CONFINED_START
		{
			get{ return _CONFINED_START; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_START, _CONFINED_START, value);
				this._CONFINED_START = value;
			}
		}
		/// <summary>
		/// 限制行为结束时间
		/// </summary>
		public DateTime? CONFINED_END
		{
			get{ return _CONFINED_END; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_END, _CONFINED_END, value);
				this._CONFINED_END = value;
			}
		}
		/// <summary>
		/// 发布日期
		/// </summary>
		public DateTime? OPERATE_DATE
		{
			get{ return _OPERATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_DATE, _OPERATE_DATE, value);
				this._OPERATE_DATE = value;
			}
		}
		/// <summary>
		/// 数据来源
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
		/// M_ID
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
		/// 公开范围
		/// </summary>
		public string SCOPE
		{
			get{ return _SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE, _SCOPE, value);
				this._SCOPE = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.VIOLATING_CODE,
				_.VIOLATING_NAME,
				_.VIOLATING_TIME,
				_.VIOLATING_TYPE,
				_.BODY_NAME,
				_.BODY_TYPE,
				_.BODY_CODE,
				_.BODY_ROLE,
				_.AREA,
				_.REWARD_PUNISHMENT_BODY,
				_.VIOLATING_INSTRUCTIONS,
				_.GOVERNMENT,
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.DOCUMENT_CODE,
				_.PUNISHMENT_BASIS,
				_.PUNISHMENT_RESULT,
				_.CONFINED_ACTION,
				_.CONFINED_START,
				_.CONFINED_END,
				_.OPERATE_DATE,
				_.M_DATA_SOURCE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.SCOPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._VIOLATING_CODE,
				this._VIOLATING_NAME,
				this._VIOLATING_TIME,
				this._VIOLATING_TYPE,
				this._BODY_NAME,
				this._BODY_TYPE,
				this._BODY_CODE,
				this._BODY_ROLE,
				this._AREA,
				this._REWARD_PUNISHMENT_BODY,
				this._VIOLATING_INSTRUCTIONS,
				this._GOVERNMENT,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._DOCUMENT_CODE,
				this._PUNISHMENT_BASIS,
				this._PUNISHMENT_RESULT,
				this._CONFINED_ACTION,
				this._CONFINED_START,
				this._CONFINED_END,
				this._OPERATE_DATE,
				this._M_DATA_SOURCE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._SCOPE,
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
			public readonly static Field All = new Field("*", "ZJ_VIOLATING_LAWS_RULES_INFO");
            /// <summary>
			/// 违法违规信息标识号
			/// </summary>
			public readonly static Field VIOLATING_CODE = new Field("VIOLATING_CODE", "ZJ_VIOLATING_LAWS_RULES_INFO", "违法违规信息标识号");
            /// <summary>
			/// 违规事项名称
			/// </summary>
			public readonly static Field VIOLATING_NAME = new Field("VIOLATING_NAME", "ZJ_VIOLATING_LAWS_RULES_INFO", "违规事项名称");
            /// <summary>
			/// 违规时间
			/// </summary>
			public readonly static Field VIOLATING_TIME = new Field("VIOLATING_TIME", "ZJ_VIOLATING_LAWS_RULES_INFO", "违规时间");
            /// <summary>
			/// 违规类型
			/// </summary>
			public readonly static Field VIOLATING_TYPE = new Field("VIOLATING_TYPE", "ZJ_VIOLATING_LAWS_RULES_INFO", "违规类型");
            /// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "ZJ_VIOLATING_LAWS_RULES_INFO", "主体名称");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "ZJ_VIOLATING_LAWS_RULES_INFO", "主体类别");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "ZJ_VIOLATING_LAWS_RULES_INFO", "主体代码");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "ZJ_VIOLATING_LAWS_RULES_INFO", "主体角色");
            /// <summary>
			/// 区域代码
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJ_VIOLATING_LAWS_RULES_INFO", "区域代码");
            /// <summary>
			/// 奖惩或处罚类型
			/// </summary>
			public readonly static Field REWARD_PUNISHMENT_BODY = new Field("REWARD_PUNISHMENT_BODY", "ZJ_VIOLATING_LAWS_RULES_INFO", "奖惩或处罚类型");
            /// <summary>
			/// 违法违规说明
			/// </summary>
			public readonly static Field VIOLATING_INSTRUCTIONS = new Field("VIOLATING_INSTRUCTIONS", "ZJ_VIOLATING_LAWS_RULES_INFO",DbType.AnsiString, null, "违法违规说明");
            /// <summary>
			/// 违法违规通报部门
			/// </summary>
			public readonly static Field GOVERNMENT = new Field("GOVERNMENT", "ZJ_VIOLATING_LAWS_RULES_INFO", "违法违规通报部门");
            /// <summary>
			/// 招标项目（采购项目）名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "ZJ_VIOLATING_LAWS_RULES_INFO", "招标项目（采购项目）名称");
            /// <summary>
			/// 招标项目（采购项目）编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_VIOLATING_LAWS_RULES_INFO", "招标项目（采购项目）编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_VIOLATING_LAWS_RULES_INFO", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "ZJ_VIOLATING_LAWS_RULES_INFO", "标段（包）名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_VIOLATING_LAWS_RULES_INFO", "统一交易标识码");
            /// <summary>
			/// 处理文件文号
			/// </summary>
			public readonly static Field DOCUMENT_CODE = new Field("DOCUMENT_CODE", "ZJ_VIOLATING_LAWS_RULES_INFO", "处理文件文号");
            /// <summary>
			/// 处罚依据
			/// </summary>
			public readonly static Field PUNISHMENT_BASIS = new Field("PUNISHMENT_BASIS", "ZJ_VIOLATING_LAWS_RULES_INFO",DbType.AnsiString, null, "处罚依据");
            /// <summary>
			/// 处罚结果
			/// </summary>
			public readonly static Field PUNISHMENT_RESULT = new Field("PUNISHMENT_RESULT", "ZJ_VIOLATING_LAWS_RULES_INFO",DbType.AnsiString, null, "处罚结果");
            /// <summary>
			/// 限制的行为
			/// </summary>
			public readonly static Field CONFINED_ACTION = new Field("CONFINED_ACTION", "ZJ_VIOLATING_LAWS_RULES_INFO", "限制的行为");
            /// <summary>
			/// 限制行为开始时间
			/// </summary>
			public readonly static Field CONFINED_START = new Field("CONFINED_START", "ZJ_VIOLATING_LAWS_RULES_INFO", "限制行为开始时间");
            /// <summary>
			/// 限制行为结束时间
			/// </summary>
			public readonly static Field CONFINED_END = new Field("CONFINED_END", "ZJ_VIOLATING_LAWS_RULES_INFO", "限制行为结束时间");
            /// <summary>
			/// 发布日期
			/// </summary>
			public readonly static Field OPERATE_DATE = new Field("OPERATE_DATE", "ZJ_VIOLATING_LAWS_RULES_INFO", "发布日期");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_VIOLATING_LAWS_RULES_INFO", "数据来源");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_VIOLATING_LAWS_RULES_INFO", "数据时间戳");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_VIOLATING_LAWS_RULES_INFO", "M_ID");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field SCOPE = new Field("SCOPE", "ZJ_VIOLATING_LAWS_RULES_INFO", "公开范围");
        }
        #endregion
	}
}