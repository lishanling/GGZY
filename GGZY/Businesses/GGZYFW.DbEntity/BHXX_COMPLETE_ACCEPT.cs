using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BHXX_COMPLETE_ACCEPT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BHXX_COMPLETE_ACCEPT")]
    [Serializable]
    public partial class BHXX_COMPLETE_ACCEPT : FwEntity
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
		private string _PROJECT_FINISH_CHECK_NUM;
		private string _BUILDER_LICENCE_NUM;
		private decimal? _FACT_COST;
		private decimal? _FACT_AREA;
		private decimal? _LENGTH;
		private decimal? _SPAN;
		private string _FACT_SIZE;
		private string _PROJECT_STRUCTURE_TYPE_NUM;
		private DateTime? _BEGIN_DATE;
		private DateTime? _END_DATE;
		private string _REMARK;
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
		/// 竣工验收编号
		/// </summary>
		public string PROJECT_FINISH_CHECK_NUM
		{
			get{ return _PROJECT_FINISH_CHECK_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_FINISH_CHECK_NUM, _PROJECT_FINISH_CHECK_NUM, value);
				this._PROJECT_FINISH_CHECK_NUM = value;
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
		/// 实际造价（万元）
		/// </summary>
		public decimal? FACT_COST
		{
			get{ return _FACT_COST; }
			set
			{
				this.OnPropertyValueChange(_.FACT_COST, _FACT_COST, value);
				this._FACT_COST = value;
			}
		}
		/// <summary>
		/// 实际面积（平方米）
		/// </summary>
		public decimal? FACT_AREA
		{
			get{ return _FACT_AREA; }
			set
			{
				this.OnPropertyValueChange(_.FACT_AREA, _FACT_AREA, value);
				this._FACT_AREA = value;
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
		/// 实际建设规模
		/// </summary>
		public string FACT_SIZE
		{
			get{ return _FACT_SIZE; }
			set
			{
				this.OnPropertyValueChange(_.FACT_SIZE, _FACT_SIZE, value);
				this._FACT_SIZE = value;
			}
		}
		/// <summary>
		/// 结构体系
		/// </summary>
		public string PROJECT_STRUCTURE_TYPE_NUM
		{
			get{ return _PROJECT_STRUCTURE_TYPE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_STRUCTURE_TYPE_NUM, _PROJECT_STRUCTURE_TYPE_NUM, value);
				this._PROJECT_STRUCTURE_TYPE_NUM = value;
			}
		}
		/// <summary>
		/// 实际开工日期
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
		/// 实际竣工验收日期
		/// </summary>
		public DateTime? END_DATE
		{
			get{ return _END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.END_DATE, _END_DATE, value);
				this._END_DATE = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
		/// 信息审核部门*
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
		/// 信息审核人*
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
				_.PROJECT_FINISH_CHECK_NUM,
				_.BUILDER_LICENCE_NUM,
				_.FACT_COST,
				_.FACT_AREA,
				_.LENGTH,
				_.SPAN,
				_.FACT_SIZE,
				_.PROJECT_STRUCTURE_TYPE_NUM,
				_.BEGIN_DATE,
				_.END_DATE,
				_.REMARK,
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
				this._PROJECT_FINISH_CHECK_NUM,
				this._BUILDER_LICENCE_NUM,
				this._FACT_COST,
				this._FACT_AREA,
				this._LENGTH,
				this._SPAN,
				this._FACT_SIZE,
				this._PROJECT_STRUCTURE_TYPE_NUM,
				this._BEGIN_DATE,
				this._END_DATE,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "BHXX_COMPLETE_ACCEPT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BHXX_COMPLETE_ACCEPT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BHXX_COMPLETE_ACCEPT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BHXX_COMPLETE_ACCEPT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BHXX_COMPLETE_ACCEPT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BHXX_COMPLETE_ACCEPT", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "BHXX_COMPLETE_ACCEPT", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "BHXX_COMPLETE_ACCEPT", "项目名称");
            /// <summary>
			/// 项目代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "BHXX_COMPLETE_ACCEPT", "项目代码");
            /// <summary>
			/// 竣工验收编号
			/// </summary>
			public readonly static Field PROJECT_FINISH_CHECK_NUM = new Field("PROJECT_FINISH_CHECK_NUM", "BHXX_COMPLETE_ACCEPT", "竣工验收编号");
            /// <summary>
			/// 施工许可证编号
			/// </summary>
			public readonly static Field BUILDER_LICENCE_NUM = new Field("BUILDER_LICENCE_NUM", "BHXX_COMPLETE_ACCEPT", "施工许可证编号");
            /// <summary>
			/// 实际造价（万元）
			/// </summary>
			public readonly static Field FACT_COST = new Field("FACT_COST", "BHXX_COMPLETE_ACCEPT", "实际造价（万元）");
            /// <summary>
			/// 实际面积（平方米）
			/// </summary>
			public readonly static Field FACT_AREA = new Field("FACT_AREA", "BHXX_COMPLETE_ACCEPT", "实际面积（平方米）");
            /// <summary>
			/// 长度（米）
			/// </summary>
			public readonly static Field LENGTH = new Field("LENGTH", "BHXX_COMPLETE_ACCEPT", "长度（米）");
            /// <summary>
			/// 跨度（米）
			/// </summary>
			public readonly static Field SPAN = new Field("SPAN", "BHXX_COMPLETE_ACCEPT", "跨度（米）");
            /// <summary>
			/// 实际建设规模
			/// </summary>
			public readonly static Field FACT_SIZE = new Field("FACT_SIZE", "BHXX_COMPLETE_ACCEPT",DbType.AnsiString, null, "实际建设规模");
            /// <summary>
			/// 结构体系
			/// </summary>
			public readonly static Field PROJECT_STRUCTURE_TYPE_NUM = new Field("PROJECT_STRUCTURE_TYPE_NUM", "BHXX_COMPLETE_ACCEPT", "结构体系");
            /// <summary>
			/// 实际开工日期
			/// </summary>
			public readonly static Field BEGIN_DATE = new Field("BEGIN_DATE", "BHXX_COMPLETE_ACCEPT", "实际开工日期");
            /// <summary>
			/// 实际竣工验收日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "BHXX_COMPLETE_ACCEPT", "实际竣工验收日期");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "BHXX_COMPLETE_ACCEPT",DbType.AnsiString, null, "备注");
            /// <summary>
			/// 记录登记时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "BHXX_COMPLETE_ACCEPT", "记录登记时间");
            /// <summary>
			/// 信息审核部门*
			/// </summary>
			public readonly static Field CHECK_DEPART_NAME = new Field("CHECK_DEPART_NAME", "BHXX_COMPLETE_ACCEPT", "信息审核部门*");
            /// <summary>
			/// 信息审核人*
			/// </summary>
			public readonly static Field CHECK_PERSON_NAME = new Field("CHECK_PERSON_NAME", "BHXX_COMPLETE_ACCEPT", "信息审核人*");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "BHXX_COMPLETE_ACCEPT", "数据来源");
            /// <summary>
			/// 数据等级
			/// </summary>
			public readonly static Field DATA_LEVEL = new Field("DATA_LEVEL", "BHXX_COMPLETE_ACCEPT", "数据等级");
        }
        #endregion
	}
}