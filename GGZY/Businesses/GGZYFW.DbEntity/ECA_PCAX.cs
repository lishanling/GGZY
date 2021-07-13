using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ECA_PCAX。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ECA_PCAX")]
    [Serializable]
    public partial class ECA_PCAX : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _EPLY_CODE;
		private string _NAME;
		private string _GENDER;
		private DateTime? _DATE_BIRTHDAY;
		private string _ADMITA_CODE;
		private string _HIGHEST_EDU;
		private string _CNT_NUMBER;
		private string _POS_ADDRESS;
		private string _POSTCODE;
		private string _WTU_CODE;
		private string _IS_JOB;
		private string _POST;
		private string _TECH_TITLE;
		private string _WORK_EXP;
		private string _WORK_YEARS;
		private string _PQ_SEQUENCE;
		private string _PQ_LEVEL;
		private string _QC_CODE;
		private string _RC_CODE;

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
		/// 从业人员代码
		/// </summary>
		public string EPLY_CODE
		{
			get{ return _EPLY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.EPLY_CODE, _EPLY_CODE, value);
				this._EPLY_CODE = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string GENDER
		{
			get{ return _GENDER; }
			set
			{
				this.OnPropertyValueChange(_.GENDER, _GENDER, value);
				this._GENDER = value;
			}
		}
		/// <summary>
		/// 出生年月
		/// </summary>
		public DateTime? DATE_BIRTHDAY
		{
			get{ return _DATE_BIRTHDAY; }
			set
			{
				this.OnPropertyValueChange(_.DATE_BIRTHDAY, _DATE_BIRTHDAY, value);
				this._DATE_BIRTHDAY = value;
			}
		}
		/// <summary>
		/// 所在行政区域代码
		/// </summary>
		public string ADMITA_CODE
		{
			get{ return _ADMITA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ADMITA_CODE, _ADMITA_CODE, value);
				this._ADMITA_CODE = value;
			}
		}
		/// <summary>
		/// 最高学历
		/// </summary>
		public string HIGHEST_EDU
		{
			get{ return _HIGHEST_EDU; }
			set
			{
				this.OnPropertyValueChange(_.HIGHEST_EDU, _HIGHEST_EDU, value);
				this._HIGHEST_EDU = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CNT_NUMBER
		{
			get{ return _CNT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CNT_NUMBER, _CNT_NUMBER, value);
				this._CNT_NUMBER = value;
			}
		}
		/// <summary>
		/// 通讯地址
		/// </summary>
		public string POS_ADDRESS
		{
			get{ return _POS_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.POS_ADDRESS, _POS_ADDRESS, value);
				this._POS_ADDRESS = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string POSTCODE
		{
			get{ return _POSTCODE; }
			set
			{
				this.OnPropertyValueChange(_.POSTCODE, _POSTCODE, value);
				this._POSTCODE = value;
			}
		}
		/// <summary>
		/// 所在单位代码
		/// </summary>
		public string WTU_CODE
		{
			get{ return _WTU_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WTU_CODE, _WTU_CODE, value);
				this._WTU_CODE = value;
			}
		}
		/// <summary>
		/// 是否在职
		/// </summary>
		public string IS_JOB
		{
			get{ return _IS_JOB; }
			set
			{
				this.OnPropertyValueChange(_.IS_JOB, _IS_JOB, value);
				this._IS_JOB = value;
			}
		}
		/// <summary>
		/// 职务
		/// </summary>
		public string POST
		{
			get{ return _POST; }
			set
			{
				this.OnPropertyValueChange(_.POST, _POST, value);
				this._POST = value;
			}
		}
		/// <summary>
		/// 技术职称
		/// </summary>
		public string TECH_TITLE
		{
			get{ return _TECH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TECH_TITLE, _TECH_TITLE, value);
				this._TECH_TITLE = value;
			}
		}
		/// <summary>
		/// 从业经历
		/// </summary>
		public string WORK_EXP
		{
			get{ return _WORK_EXP; }
			set
			{
				this.OnPropertyValueChange(_.WORK_EXP, _WORK_EXP, value);
				this._WORK_EXP = value;
			}
		}
		/// <summary>
		/// 从业年限
		/// </summary>
		public string WORK_YEARS
		{
			get{ return _WORK_YEARS; }
			set
			{
				this.OnPropertyValueChange(_.WORK_YEARS, _WORK_YEARS, value);
				this._WORK_YEARS = value;
			}
		}
		/// <summary>
		/// 职业资格序列
		/// </summary>
		public string PQ_SEQUENCE
		{
			get{ return _PQ_SEQUENCE; }
			set
			{
				this.OnPropertyValueChange(_.PQ_SEQUENCE, _PQ_SEQUENCE, value);
				this._PQ_SEQUENCE = value;
			}
		}
		/// <summary>
		/// 职业资格等级
		/// </summary>
		public string PQ_LEVEL
		{
			get{ return _PQ_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.PQ_LEVEL, _PQ_LEVEL, value);
				this._PQ_LEVEL = value;
			}
		}
		/// <summary>
		/// 资格证书编号
		/// </summary>
		public string QC_CODE
		{
			get{ return _QC_CODE; }
			set
			{
				this.OnPropertyValueChange(_.QC_CODE, _QC_CODE, value);
				this._QC_CODE = value;
			}
		}
		/// <summary>
		/// 注册登记证书编号
		/// </summary>
		public string RC_CODE
		{
			get{ return _RC_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RC_CODE, _RC_CODE, value);
				this._RC_CODE = value;
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
				_.EPLY_CODE,
				_.NAME,
				_.GENDER,
				_.DATE_BIRTHDAY,
				_.ADMITA_CODE,
				_.HIGHEST_EDU,
				_.CNT_NUMBER,
				_.POS_ADDRESS,
				_.POSTCODE,
				_.WTU_CODE,
				_.IS_JOB,
				_.POST,
				_.TECH_TITLE,
				_.WORK_EXP,
				_.WORK_YEARS,
				_.PQ_SEQUENCE,
				_.PQ_LEVEL,
				_.QC_CODE,
				_.RC_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._EPLY_CODE,
				this._NAME,
				this._GENDER,
				this._DATE_BIRTHDAY,
				this._ADMITA_CODE,
				this._HIGHEST_EDU,
				this._CNT_NUMBER,
				this._POS_ADDRESS,
				this._POSTCODE,
				this._WTU_CODE,
				this._IS_JOB,
				this._POST,
				this._TECH_TITLE,
				this._WORK_EXP,
				this._WORK_YEARS,
				this._PQ_SEQUENCE,
				this._PQ_LEVEL,
				this._QC_CODE,
				this._RC_CODE,
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
			public readonly static Field All = new Field("*", "ECA_PCAX");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "ECA_PCAX", "ID");
            /// <summary>
			/// 从业人员代码
			/// </summary>
			public readonly static Field EPLY_CODE = new Field("EPLY_CODE", "ECA_PCAX", "从业人员代码");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ECA_PCAX", "姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "ECA_PCAX", "性别");
            /// <summary>
			/// 出生年月
			/// </summary>
			public readonly static Field DATE_BIRTHDAY = new Field("DATE_BIRTHDAY", "ECA_PCAX", "出生年月");
            /// <summary>
			/// 所在行政区域代码
			/// </summary>
			public readonly static Field ADMITA_CODE = new Field("ADMITA_CODE", "ECA_PCAX", "所在行政区域代码");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field HIGHEST_EDU = new Field("HIGHEST_EDU", "ECA_PCAX", "最高学历");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CNT_NUMBER = new Field("CNT_NUMBER", "ECA_PCAX", "联系电话");
            /// <summary>
			/// 通讯地址
			/// </summary>
			public readonly static Field POS_ADDRESS = new Field("POS_ADDRESS", "ECA_PCAX", "通讯地址");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field POSTCODE = new Field("POSTCODE", "ECA_PCAX", "邮政编码");
            /// <summary>
			/// 所在单位代码
			/// </summary>
			public readonly static Field WTU_CODE = new Field("WTU_CODE", "ECA_PCAX", "所在单位代码");
            /// <summary>
			/// 是否在职
			/// </summary>
			public readonly static Field IS_JOB = new Field("IS_JOB", "ECA_PCAX", "是否在职");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field POST = new Field("POST", "ECA_PCAX", "职务");
            /// <summary>
			/// 技术职称
			/// </summary>
			public readonly static Field TECH_TITLE = new Field("TECH_TITLE", "ECA_PCAX", "技术职称");
            /// <summary>
			/// 从业经历
			/// </summary>
			public readonly static Field WORK_EXP = new Field("WORK_EXP", "ECA_PCAX", "从业经历");
            /// <summary>
			/// 从业年限
			/// </summary>
			public readonly static Field WORK_YEARS = new Field("WORK_YEARS", "ECA_PCAX", "从业年限");
            /// <summary>
			/// 职业资格序列
			/// </summary>
			public readonly static Field PQ_SEQUENCE = new Field("PQ_SEQUENCE", "ECA_PCAX", "职业资格序列");
            /// <summary>
			/// 职业资格等级
			/// </summary>
			public readonly static Field PQ_LEVEL = new Field("PQ_LEVEL", "ECA_PCAX", "职业资格等级");
            /// <summary>
			/// 资格证书编号
			/// </summary>
			public readonly static Field QC_CODE = new Field("QC_CODE", "ECA_PCAX", "资格证书编号");
            /// <summary>
			/// 注册登记证书编号
			/// </summary>
			public readonly static Field RC_CODE = new Field("RC_CODE", "ECA_PCAX", "注册登记证书编号");
        }
        #endregion
	}
}