using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_COMPREHENSIVE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_COMPREHENSIVE")]
    [Serializable]
    public partial class ZJPRI_COMPREHENSIVE : FwEntity
    {
        #region Model
		private string _DK_ID;
		private string _INDUSTRY;
		private decimal? _RANK;
		private string _CORPNAME;
		private string _SCCORPCODE;
		private string _CORPCODE;
		private decimal? _SCORE;
		private string _SYEAR;
		private string _QUARTER;
		private string _SCORETYPE;
		private DateTime? _SCOREDATE;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;

		/// <summary>
		/// 唯一标识码
		/// </summary>
		public string DK_ID
		{
			get{ return _DK_ID; }
			set
			{
				this.OnPropertyValueChange(_.DK_ID, _DK_ID, value);
				this._DK_ID = value;
			}
		}
		/// <summary>
		/// 行业类型
		/// </summary>
		public string INDUSTRY
		{
			get{ return _INDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRY, _INDUSTRY, value);
				this._INDUSTRY = value;
			}
		}
		/// <summary>
		/// 综合排名
		/// </summary>
		public decimal? RANK
		{
			get{ return _RANK; }
			set
			{
				this.OnPropertyValueChange(_.RANK, _RANK, value);
				this._RANK = value;
			}
		}
		/// <summary>
		/// 企业名称
		/// </summary>
		public string CORPNAME
		{
			get{ return _CORPNAME; }
			set
			{
				this.OnPropertyValueChange(_.CORPNAME, _CORPNAME, value);
				this._CORPNAME = value;
			}
		}
		/// <summary>
		/// 社会统一信用代码
		/// </summary>
		public string SCCORPCODE
		{
			get{ return _SCCORPCODE; }
			set
			{
				this.OnPropertyValueChange(_.SCCORPCODE, _SCCORPCODE, value);
				this._SCCORPCODE = value;
			}
		}
		/// <summary>
		/// 企业组织机构代码
		/// </summary>
		public string CORPCODE
		{
			get{ return _CORPCODE; }
			set
			{
				this.OnPropertyValueChange(_.CORPCODE, _CORPCODE, value);
				this._CORPCODE = value;
			}
		}
		/// <summary>
		/// 分数
		/// </summary>
		public decimal? SCORE
		{
			get{ return _SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SCORE, _SCORE, value);
				this._SCORE = value;
			}
		}
		/// <summary>
		/// 年度
		/// </summary>
		public string SYEAR
		{
			get{ return _SYEAR; }
			set
			{
				this.OnPropertyValueChange(_.SYEAR, _SYEAR, value);
				this._SYEAR = value;
			}
		}
		/// <summary>
		/// 季度
		/// </summary>
		public string QUARTER
		{
			get{ return _QUARTER; }
			set
			{
				this.OnPropertyValueChange(_.QUARTER, _QUARTER, value);
				this._QUARTER = value;
			}
		}
		/// <summary>
		/// 分数类型
		/// </summary>
		public string SCORETYPE
		{
			get{ return _SCORETYPE; }
			set
			{
				this.OnPropertyValueChange(_.SCORETYPE, _SCORETYPE, value);
				this._SCORETYPE = value;
			}
		}
		/// <summary>
		/// 计算日期
		/// </summary>
		public DateTime? SCOREDATE
		{
			get{ return _SCOREDATE; }
			set
			{
				this.OnPropertyValueChange(_.SCOREDATE, _SCOREDATE, value);
				this._SCOREDATE = value;
			}
		}
		/// <summary>
		/// 全局唯一标识符
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 创建时间
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
		/// 版本号
		/// </summary>
		public string VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
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
				_.DK_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.DK_ID,
				_.INDUSTRY,
				_.RANK,
				_.CORPNAME,
				_.SCCORPCODE,
				_.CORPCODE,
				_.SCORE,
				_.SYEAR,
				_.QUARTER,
				_.SCORETYPE,
				_.SCOREDATE,
				_.GUID,
				_.CREATE_TIME,
				_.VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._DK_ID,
				this._INDUSTRY,
				this._RANK,
				this._CORPNAME,
				this._SCCORPCODE,
				this._CORPCODE,
				this._SCORE,
				this._SYEAR,
				this._QUARTER,
				this._SCORETYPE,
				this._SCOREDATE,
				this._GUID,
				this._CREATE_TIME,
				this._VERSION,
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
			public readonly static Field All = new Field("*", "ZJPRI_COMPREHENSIVE");
            /// <summary>
			/// 唯一标识码
			/// </summary>
			public readonly static Field DK_ID = new Field("DK_ID", "ZJPRI_COMPREHENSIVE", "唯一标识码");
            /// <summary>
			/// 行业类型
			/// </summary>
			public readonly static Field INDUSTRY = new Field("INDUSTRY", "ZJPRI_COMPREHENSIVE", "行业类型");
            /// <summary>
			/// 综合排名
			/// </summary>
			public readonly static Field RANK = new Field("RANK", "ZJPRI_COMPREHENSIVE", "综合排名");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field CORPNAME = new Field("CORPNAME", "ZJPRI_COMPREHENSIVE", "企业名称");
            /// <summary>
			/// 社会统一信用代码
			/// </summary>
			public readonly static Field SCCORPCODE = new Field("SCCORPCODE", "ZJPRI_COMPREHENSIVE", "社会统一信用代码");
            /// <summary>
			/// 企业组织机构代码
			/// </summary>
			public readonly static Field CORPCODE = new Field("CORPCODE", "ZJPRI_COMPREHENSIVE", "企业组织机构代码");
            /// <summary>
			/// 分数
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "ZJPRI_COMPREHENSIVE", "分数");
            /// <summary>
			/// 年度
			/// </summary>
			public readonly static Field SYEAR = new Field("SYEAR", "ZJPRI_COMPREHENSIVE", "年度");
            /// <summary>
			/// 季度
			/// </summary>
			public readonly static Field QUARTER = new Field("QUARTER", "ZJPRI_COMPREHENSIVE", "季度");
            /// <summary>
			/// 分数类型
			/// </summary>
			public readonly static Field SCORETYPE = new Field("SCORETYPE", "ZJPRI_COMPREHENSIVE", "分数类型");
            /// <summary>
			/// 计算日期
			/// </summary>
			public readonly static Field SCOREDATE = new Field("SCOREDATE", "ZJPRI_COMPREHENSIVE", "计算日期");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_COMPREHENSIVE", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_COMPREHENSIVE", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_COMPREHENSIVE", "版本号");
        }
        #endregion
	}
}