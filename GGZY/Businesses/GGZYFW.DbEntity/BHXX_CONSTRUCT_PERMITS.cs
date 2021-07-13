using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BHXX_CONSTRUCT_PERMITS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BHXX_CONSTRUCT_PERMITS")]
    [Serializable]
    public partial class BHXX_CONSTRUCT_PERMITS : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _INVEST_PROJECT_CODE;
		private string _BUILDER_LICENCE_NUM;
		private string _BUILD_PLAN_NUM;
		private string _PROJECT_PLAN_NUM;
		private string _TENDER_NUM;
		private string _CENSOR_NUM;
		private decimal? _BARGAIN_DAYS;
		private decimal? _CONTRACT_MONEY;
		private decimal? _AREA;
		private decimal? _LENGTH;
		private decimal? _SPAN;
		private string _PROJECT_SIZE;
		private DateTime? _RELEASE_DATE;
		private string _TWO_DIM_CODE;
		private DateTime? _CREATE_DATE;
		private string _CHECK_DEPART_NAME;
		private string _CHECK_PERSON_NAME;
		private string _DATA_SOURCE;
		private string _DATA_LEVEL;

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
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
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
		/// 项目代码
		/// </summary>
		public string INVEST_PROJECT_CODE
		{
			get{ return _INVEST_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_PROJECT_CODE, _INVEST_PROJECT_CODE, value);
				this._INVEST_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 施工许可证编号
		/// </summary>
		public string BUILDER_LICENCE_NUM
		{
			get{ return _BUILDER_LICENCE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BUILDER_LICENCE_NUM, _BUILDER_LICENCE_NUM, value);
				this._BUILDER_LICENCE_NUM = value;
			}
		}
		/// <summary>
		/// 建设用地规划许可证编号
		/// </summary>
		public string BUILD_PLAN_NUM
		{
			get{ return _BUILD_PLAN_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BUILD_PLAN_NUM, _BUILD_PLAN_NUM, value);
				this._BUILD_PLAN_NUM = value;
			}
		}
		/// <summary>
		/// 建设工程规划许可证编号
		/// </summary>
		public string PROJECT_PLAN_NUM
		{
			get{ return _PROJECT_PLAN_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PLAN_NUM, _PROJECT_PLAN_NUM, value);
				this._PROJECT_PLAN_NUM = value;
			}
		}
		/// <summary>
		/// 中标通知书编号
		/// </summary>
		public string TENDER_NUM
		{
			get{ return _TENDER_NUM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NUM, _TENDER_NUM, value);
				this._TENDER_NUM = value;
			}
		}
		/// <summary>
		/// 施工图审查合格书编号
		/// </summary>
		public string CENSOR_NUM
		{
			get{ return _CENSOR_NUM; }
			set
			{
				this.OnPropertyValueChange(_.CENSOR_NUM, _CENSOR_NUM, value);
				this._CENSOR_NUM = value;
			}
		}
		/// <summary>
		/// 合同工期*
		/// </summary>
		public decimal? BARGAIN_DAYS
		{
			get{ return _BARGAIN_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.BARGAIN_DAYS, _BARGAIN_DAYS, value);
				this._BARGAIN_DAYS = value;
			}
		}
		/// <summary>
		/// 合同金额(万元)
		/// </summary>
		public decimal? CONTRACT_MONEY
		{
			get{ return _CONTRACT_MONEY; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_MONEY, _CONTRACT_MONEY, value);
				this._CONTRACT_MONEY = value;
			}
		}
		/// <summary>
		/// 面积（平方米）
		/// </summary>
		public decimal? AREA
		{
			get{ return _AREA; }
			set
			{
				this.OnPropertyValueChange(_.AREA, _AREA, value);
				this._AREA = value;
			}
		}
		/// <summary>
		/// 长度（米）
		/// </summary>
		public decimal? LENGTH
		{
			get{ return _LENGTH; }
			set
			{
				this.OnPropertyValueChange(_.LENGTH, _LENGTH, value);
				this._LENGTH = value;
			}
		}
		/// <summary>
		/// 跨度（米）
		/// </summary>
		public decimal? SPAN
		{
			get{ return _SPAN; }
			set
			{
				this.OnPropertyValueChange(_.SPAN, _SPAN, value);
				this._SPAN = value;
			}
		}
		/// <summary>
		/// 建设规模
		/// </summary>
		public string PROJECT_SIZE
		{
			get{ return _PROJECT_SIZE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_SIZE, _PROJECT_SIZE, value);
				this._PROJECT_SIZE = value;
			}
		}
		/// <summary>
		/// 发证日期
		/// </summary>
		public DateTime? RELEASE_DATE
		{
			get{ return _RELEASE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.RELEASE_DATE, _RELEASE_DATE, value);
				this._RELEASE_DATE = value;
			}
		}
		/// <summary>
		/// 证书二维码
		/// </summary>
		public string TWO_DIM_CODE
		{
			get{ return _TWO_DIM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TWO_DIM_CODE, _TWO_DIM_CODE, value);
				this._TWO_DIM_CODE = value;
			}
		}
		/// <summary>
		/// 记录登记时间
		/// </summary>
		public DateTime? CREATE_DATE
		{
			get{ return _CREATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_DATE, _CREATE_DATE, value);
				this._CREATE_DATE = value;
			}
		}
		/// <summary>
		/// 信息审核部门
		/// </summary>
		public string CHECK_DEPART_NAME
		{
			get{ return _CHECK_DEPART_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_DEPART_NAME, _CHECK_DEPART_NAME, value);
				this._CHECK_DEPART_NAME = value;
			}
		}
		/// <summary>
		/// 信息审核人
		/// </summary>
		public string CHECK_PERSON_NAME
		{
			get{ return _CHECK_PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_PERSON_NAME, _CHECK_PERSON_NAME, value);
				this._CHECK_PERSON_NAME = value;
			}
		}
		/// <summary>
		/// 数据来源
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
		/// 数据等级
		/// </summary>
		public string DATA_LEVEL
		{
			get{ return _DATA_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.DATA_LEVEL, _DATA_LEVEL, value);
				this._DATA_LEVEL = value;
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
				_.M_VERSION,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.INVEST_PROJECT_CODE,
				_.BUILDER_LICENCE_NUM,
				_.BUILD_PLAN_NUM,
				_.PROJECT_PLAN_NUM,
				_.TENDER_NUM,
				_.CENSOR_NUM,
				_.BARGAIN_DAYS,
				_.CONTRACT_MONEY,
				_.AREA,
				_.LENGTH,
				_.SPAN,
				_.PROJECT_SIZE,
				_.RELEASE_DATE,
				_.TWO_DIM_CODE,
				_.CREATE_DATE,
				_.CHECK_DEPART_NAME,
				_.CHECK_PERSON_NAME,
				_.DATA_SOURCE,
				_.DATA_LEVEL,
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
				this._M_VERSION,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._INVEST_PROJECT_CODE,
				this._BUILDER_LICENCE_NUM,
				this._BUILD_PLAN_NUM,
				this._PROJECT_PLAN_NUM,
				this._TENDER_NUM,
				this._CENSOR_NUM,
				this._BARGAIN_DAYS,
				this._CONTRACT_MONEY,
				this._AREA,
				this._LENGTH,
				this._SPAN,
				this._PROJECT_SIZE,
				this._RELEASE_DATE,
				this._TWO_DIM_CODE,
				this._CREATE_DATE,
				this._CHECK_DEPART_NAME,
				this._CHECK_PERSON_NAME,
				this._DATA_SOURCE,
				this._DATA_LEVEL,
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
			public readonly static Field All = new Field("*", "BHXX_CONSTRUCT_PERMITS");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BHXX_CONSTRUCT_PERMITS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BHXX_CONSTRUCT_PERMITS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BHXX_CONSTRUCT_PERMITS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BHXX_CONSTRUCT_PERMITS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BHXX_CONSTRUCT_PERMITS", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "BHXX_CONSTRUCT_PERMITS", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "BHXX_CONSTRUCT_PERMITS", "项目名称");
            /// <summary>
			/// 项目代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "BHXX_CONSTRUCT_PERMITS", "项目代码");
            /// <summary>
			/// 施工许可证编号
			/// </summary>
			public readonly static Field BUILDER_LICENCE_NUM = new Field("BUILDER_LICENCE_NUM", "BHXX_CONSTRUCT_PERMITS", "施工许可证编号");
            /// <summary>
			/// 建设用地规划许可证编号
			/// </summary>
			public readonly static Field BUILD_PLAN_NUM = new Field("BUILD_PLAN_NUM", "BHXX_CONSTRUCT_PERMITS", "建设用地规划许可证编号");
            /// <summary>
			/// 建设工程规划许可证编号
			/// </summary>
			public readonly static Field PROJECT_PLAN_NUM = new Field("PROJECT_PLAN_NUM", "BHXX_CONSTRUCT_PERMITS", "建设工程规划许可证编号");
            /// <summary>
			/// 中标通知书编号
			/// </summary>
			public readonly static Field TENDER_NUM = new Field("TENDER_NUM", "BHXX_CONSTRUCT_PERMITS", "中标通知书编号");
            /// <summary>
			/// 施工图审查合格书编号
			/// </summary>
			public readonly static Field CENSOR_NUM = new Field("CENSOR_NUM", "BHXX_CONSTRUCT_PERMITS", "施工图审查合格书编号");
            /// <summary>
			/// 合同工期*
			/// </summary>
			public readonly static Field BARGAIN_DAYS = new Field("BARGAIN_DAYS", "BHXX_CONSTRUCT_PERMITS", "合同工期*");
            /// <summary>
			/// 合同金额(万元)
			/// </summary>
			public readonly static Field CONTRACT_MONEY = new Field("CONTRACT_MONEY", "BHXX_CONSTRUCT_PERMITS", "合同金额(万元)");
            /// <summary>
			/// 面积（平方米）
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "BHXX_CONSTRUCT_PERMITS", "面积（平方米）");
            /// <summary>
			/// 长度（米）
			/// </summary>
			public readonly static Field LENGTH = new Field("LENGTH", "BHXX_CONSTRUCT_PERMITS", "长度（米）");
            /// <summary>
			/// 跨度（米）
			/// </summary>
			public readonly static Field SPAN = new Field("SPAN", "BHXX_CONSTRUCT_PERMITS", "跨度（米）");
            /// <summary>
			/// 建设规模
			/// </summary>
			public readonly static Field PROJECT_SIZE = new Field("PROJECT_SIZE", "BHXX_CONSTRUCT_PERMITS", "建设规模");
            /// <summary>
			/// 发证日期
			/// </summary>
			public readonly static Field RELEASE_DATE = new Field("RELEASE_DATE", "BHXX_CONSTRUCT_PERMITS", "发证日期");
            /// <summary>
			/// 证书二维码
			/// </summary>
			public readonly static Field TWO_DIM_CODE = new Field("TWO_DIM_CODE", "BHXX_CONSTRUCT_PERMITS", "证书二维码");
            /// <summary>
			/// 记录登记时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "BHXX_CONSTRUCT_PERMITS", "记录登记时间");
            /// <summary>
			/// 信息审核部门
			/// </summary>
			public readonly static Field CHECK_DEPART_NAME = new Field("CHECK_DEPART_NAME", "BHXX_CONSTRUCT_PERMITS", "信息审核部门");
            /// <summary>
			/// 信息审核人
			/// </summary>
			public readonly static Field CHECK_PERSON_NAME = new Field("CHECK_PERSON_NAME", "BHXX_CONSTRUCT_PERMITS", "信息审核人");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "BHXX_CONSTRUCT_PERMITS", "数据来源");
            /// <summary>
			/// 数据等级
			/// </summary>
			public readonly static Field DATA_LEVEL = new Field("DATA_LEVEL", "BHXX_CONSTRUCT_PERMITS", "数据等级");
        }
        #endregion
	}
}