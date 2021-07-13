using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_CREDIT_DEDUCTION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_CREDIT_DEDUCTION")]
    [Serializable]
    public partial class RECORD_CREDIT_DEDUCTION : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _REVIEW_ID;
		private string _REVIEW_CODE;
		private string _EXIST_PROBLEM;
		private string _EXAMIN_OPINION;
		private string _PROBLEM_ATTRIBUTE;
		private string _IS_ADJUST;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _BEFORE_IS_DOUBLE;
		private string _AFTER_IS_DOUBLE;
		private string _BEFORE_CREDIT_NUM;
		private string _AFTER_CREDIT_NUM;
		private string _VERSION;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 备案主表的编号
		/// </summary>
		public string REVIEW_ID
		{
			get{ return _REVIEW_ID; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_ID, _REVIEW_ID, value);
				this._REVIEW_ID = value;
			}
		}
		/// <summary>
		/// 备案编号
		/// </summary>
		public string REVIEW_CODE
		{
			get{ return _REVIEW_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_CODE, _REVIEW_CODE, value);
				this._REVIEW_CODE = value;
			}
		}
		/// <summary>
		/// 存在问题
		/// </summary>
		public string EXIST_PROBLEM
		{
			get{ return _EXIST_PROBLEM; }
			set
			{
				this.OnPropertyValueChange(_.EXIST_PROBLEM, _EXIST_PROBLEM, value);
				this._EXIST_PROBLEM = value;
			}
		}
		/// <summary>
		/// 审查意见
		/// </summary>
		public string EXAMIN_OPINION
		{
			get{ return _EXAMIN_OPINION; }
			set
			{
				this.OnPropertyValueChange(_.EXAMIN_OPINION, _EXAMIN_OPINION, value);
				this._EXAMIN_OPINION = value;
			}
		}
		/// <summary>
		/// 问题属性(type=3029)
		/// </summary>
		public string PROBLEM_ATTRIBUTE
		{
			get{ return _PROBLEM_ATTRIBUTE; }
			set
			{
				this.OnPropertyValueChange(_.PROBLEM_ATTRIBUTE, _PROBLEM_ATTRIBUTE, value);
				this._PROBLEM_ATTRIBUTE = value;
			}
		}
		/// <summary>
		/// 是否进行调整
		/// </summary>
		public string IS_ADJUST
		{
			get{ return _IS_ADJUST; }
			set
			{
				this.OnPropertyValueChange(_.IS_ADJUST, _IS_ADJUST, value);
				this._IS_ADJUST = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 调整前是否加倍
		/// </summary>
		public string BEFORE_IS_DOUBLE
		{
			get{ return _BEFORE_IS_DOUBLE; }
			set
			{
				this.OnPropertyValueChange(_.BEFORE_IS_DOUBLE, _BEFORE_IS_DOUBLE, value);
				this._BEFORE_IS_DOUBLE = value;
			}
		}
		/// <summary>
		/// 调整后是否加倍
		/// </summary>
		public string AFTER_IS_DOUBLE
		{
			get{ return _AFTER_IS_DOUBLE; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_IS_DOUBLE, _AFTER_IS_DOUBLE, value);
				this._AFTER_IS_DOUBLE = value;
			}
		}
		/// <summary>
		/// 调整前信用分扣分值
		/// </summary>
		public string BEFORE_CREDIT_NUM
		{
			get{ return _BEFORE_CREDIT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BEFORE_CREDIT_NUM, _BEFORE_CREDIT_NUM, value);
				this._BEFORE_CREDIT_NUM = value;
			}
		}
		/// <summary>
		/// 调整后信用分扣分值
		/// </summary>
		public string AFTER_CREDIT_NUM
		{
			get{ return _AFTER_CREDIT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_CREDIT_NUM, _AFTER_CREDIT_NUM, value);
				this._AFTER_CREDIT_NUM = value;
			}
		}
		/// <summary>
		/// 版本号（审查时才生成版本号）
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
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.REVIEW_ID,
				_.REVIEW_CODE,
				_.EXIST_PROBLEM,
				_.EXAMIN_OPINION,
				_.PROBLEM_ATTRIBUTE,
				_.IS_ADJUST,
				_.CREATE_TM,
				_.CREATOR,
				_.BEFORE_IS_DOUBLE,
				_.AFTER_IS_DOUBLE,
				_.BEFORE_CREDIT_NUM,
				_.AFTER_CREDIT_NUM,
				_.VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REVIEW_ID,
				this._REVIEW_CODE,
				this._EXIST_PROBLEM,
				this._EXAMIN_OPINION,
				this._PROBLEM_ATTRIBUTE,
				this._IS_ADJUST,
				this._CREATE_TM,
				this._CREATOR,
				this._BEFORE_IS_DOUBLE,
				this._AFTER_IS_DOUBLE,
				this._BEFORE_CREDIT_NUM,
				this._AFTER_CREDIT_NUM,
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
			public readonly static Field All = new Field("*", "RECORD_CREDIT_DEDUCTION");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_CREDIT_DEDUCTION", "ID");
            /// <summary>
			/// 备案主表的编号
			/// </summary>
			public readonly static Field REVIEW_ID = new Field("REVIEW_ID", "RECORD_CREDIT_DEDUCTION", "备案主表的编号");
            /// <summary>
			/// 备案编号
			/// </summary>
			public readonly static Field REVIEW_CODE = new Field("REVIEW_CODE", "RECORD_CREDIT_DEDUCTION", "备案编号");
            /// <summary>
			/// 存在问题
			/// </summary>
			public readonly static Field EXIST_PROBLEM = new Field("EXIST_PROBLEM", "RECORD_CREDIT_DEDUCTION", "存在问题");
            /// <summary>
			/// 审查意见
			/// </summary>
			public readonly static Field EXAMIN_OPINION = new Field("EXAMIN_OPINION", "RECORD_CREDIT_DEDUCTION", "审查意见");
            /// <summary>
			/// 问题属性(type=3029)
			/// </summary>
			public readonly static Field PROBLEM_ATTRIBUTE = new Field("PROBLEM_ATTRIBUTE", "RECORD_CREDIT_DEDUCTION", "问题属性(type=3029)");
            /// <summary>
			/// 是否进行调整
			/// </summary>
			public readonly static Field IS_ADJUST = new Field("IS_ADJUST", "RECORD_CREDIT_DEDUCTION", "是否进行调整");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_CREDIT_DEDUCTION", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_CREDIT_DEDUCTION", "创建人");
            /// <summary>
			/// 调整前是否加倍
			/// </summary>
			public readonly static Field BEFORE_IS_DOUBLE = new Field("BEFORE_IS_DOUBLE", "RECORD_CREDIT_DEDUCTION", "调整前是否加倍");
            /// <summary>
			/// 调整后是否加倍
			/// </summary>
			public readonly static Field AFTER_IS_DOUBLE = new Field("AFTER_IS_DOUBLE", "RECORD_CREDIT_DEDUCTION", "调整后是否加倍");
            /// <summary>
			/// 调整前信用分扣分值
			/// </summary>
			public readonly static Field BEFORE_CREDIT_NUM = new Field("BEFORE_CREDIT_NUM", "RECORD_CREDIT_DEDUCTION", "调整前信用分扣分值");
            /// <summary>
			/// 调整后信用分扣分值
			/// </summary>
			public readonly static Field AFTER_CREDIT_NUM = new Field("AFTER_CREDIT_NUM", "RECORD_CREDIT_DEDUCTION", "调整后信用分扣分值");
            /// <summary>
			/// 版本号（审查时才生成版本号）
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "RECORD_CREDIT_DEDUCTION", "版本号（审查时才生成版本号）");
        }
        #endregion
	}
}