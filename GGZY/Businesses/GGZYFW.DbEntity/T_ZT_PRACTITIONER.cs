using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_PRACTITIONER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_PRACTITIONER")]
    [Serializable]
    public partial class T_ZT_PRACTITIONER : FwEntity
    {
        #region Model
		private string _IDCARD;
		private string _IDCARDTYPE;
		private string _PERSONNAME;
		private string _GENDER;
		private DateTime? _BIRTHDATE;
		private string _REGIONCODE;
		private string _PERSONEDU;
		private string _PERSONPHONE;
		private string _UNITCODE;
		private string _UNITNAME;
		private string _ONJOB;
		private string _JOB;
		private string _TECHTITLE;
		private DateTime? _WORKSTARTDATE;
		private string _WORKINGEXPERIENCE;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 身份证件号码
		/// </summary>
		public string IDCARD
		{
			get{ return _IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.IDCARD, _IDCARD, value);
				this._IDCARD = value;
			}
		}
		/// <summary>
		/// 身份证件类型
		/// </summary>
		public string IDCARDTYPE
		{
			get{ return _IDCARDTYPE; }
			set
			{
				this.OnPropertyValueChange(_.IDCARDTYPE, _IDCARDTYPE, value);
				this._IDCARDTYPE = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string PERSONNAME
		{
			get{ return _PERSONNAME; }
			set
			{
				this.OnPropertyValueChange(_.PERSONNAME, _PERSONNAME, value);
				this._PERSONNAME = value;
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
		public DateTime? BIRTHDATE
		{
			get{ return _BIRTHDATE; }
			set
			{
				this.OnPropertyValueChange(_.BIRTHDATE, _BIRTHDATE, value);
				this._BIRTHDATE = value;
			}
		}
		/// <summary>
		/// 行政区域代码
		/// </summary>
		public string REGIONCODE
		{
			get{ return _REGIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.REGIONCODE, _REGIONCODE, value);
				this._REGIONCODE = value;
			}
		}
		/// <summary>
		/// 最高学历
		/// </summary>
		public string PERSONEDU
		{
			get{ return _PERSONEDU; }
			set
			{
				this.OnPropertyValueChange(_.PERSONEDU, _PERSONEDU, value);
				this._PERSONEDU = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PERSONPHONE
		{
			get{ return _PERSONPHONE; }
			set
			{
				this.OnPropertyValueChange(_.PERSONPHONE, _PERSONPHONE, value);
				this._PERSONPHONE = value;
			}
		}
		/// <summary>
		/// 所在单位代码
		/// </summary>
		public string UNITCODE
		{
			get{ return _UNITCODE; }
			set
			{
				this.OnPropertyValueChange(_.UNITCODE, _UNITCODE, value);
				this._UNITCODE = value;
			}
		}
		/// <summary>
		/// 所在单位名称
		/// </summary>
		public string UNITNAME
		{
			get{ return _UNITNAME; }
			set
			{
				this.OnPropertyValueChange(_.UNITNAME, _UNITNAME, value);
				this._UNITNAME = value;
			}
		}
		/// <summary>
		/// 是否在职
		/// </summary>
		public string ONJOB
		{
			get{ return _ONJOB; }
			set
			{
				this.OnPropertyValueChange(_.ONJOB, _ONJOB, value);
				this._ONJOB = value;
			}
		}
		/// <summary>
		/// 职务
		/// </summary>
		public string JOB
		{
			get{ return _JOB; }
			set
			{
				this.OnPropertyValueChange(_.JOB, _JOB, value);
				this._JOB = value;
			}
		}
		/// <summary>
		/// 技术职称
		/// </summary>
		public string TECHTITLE
		{
			get{ return _TECHTITLE; }
			set
			{
				this.OnPropertyValueChange(_.TECHTITLE, _TECHTITLE, value);
				this._TECHTITLE = value;
			}
		}
		/// <summary>
		/// 从业开始时间
		/// </summary>
		public DateTime? WORKSTARTDATE
		{
			get{ return _WORKSTARTDATE; }
			set
			{
				this.OnPropertyValueChange(_.WORKSTARTDATE, _WORKSTARTDATE, value);
				this._WORKSTARTDATE = value;
			}
		}
		/// <summary>
		/// 从业经历
		/// </summary>
		public string WORKINGEXPERIENCE
		{
			get{ return _WORKINGEXPERIENCE; }
			set
			{
				this.OnPropertyValueChange(_.WORKINGEXPERIENCE, _WORKINGEXPERIENCE, value);
				this._WORKINGEXPERIENCE = value;
			}
		}
		/// <summary>
		/// 来源平台编码
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
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATATIMESTAMP
		{
			get{ return _DATATIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATATIMESTAMP, _DATATIMESTAMP, value);
				this._DATATIMESTAMP = value;
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
				_.IDCARD,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.IDCARD,
				_.IDCARDTYPE,
				_.PERSONNAME,
				_.GENDER,
				_.BIRTHDATE,
				_.REGIONCODE,
				_.PERSONEDU,
				_.PERSONPHONE,
				_.UNITCODE,
				_.UNITNAME,
				_.ONJOB,
				_.JOB,
				_.TECHTITLE,
				_.WORKSTARTDATE,
				_.WORKINGEXPERIENCE,
				_.DATASOURCECODE,
				_.DATATIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._IDCARD,
				this._IDCARDTYPE,
				this._PERSONNAME,
				this._GENDER,
				this._BIRTHDATE,
				this._REGIONCODE,
				this._PERSONEDU,
				this._PERSONPHONE,
				this._UNITCODE,
				this._UNITNAME,
				this._ONJOB,
				this._JOB,
				this._TECHTITLE,
				this._WORKSTARTDATE,
				this._WORKINGEXPERIENCE,
				this._DATASOURCECODE,
				this._DATATIMESTAMP,
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
			public readonly static Field All = new Field("*", "T_ZT_PRACTITIONER");
            /// <summary>
			/// 身份证件号码
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "T_ZT_PRACTITIONER", "身份证件号码");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field IDCARDTYPE = new Field("IDCARDTYPE", "T_ZT_PRACTITIONER", "身份证件类型");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field PERSONNAME = new Field("PERSONNAME", "T_ZT_PRACTITIONER", "姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "T_ZT_PRACTITIONER", "性别");
            /// <summary>
			/// 出生年月
			/// </summary>
			public readonly static Field BIRTHDATE = new Field("BIRTHDATE", "T_ZT_PRACTITIONER", "出生年月");
            /// <summary>
			/// 行政区域代码
			/// </summary>
			public readonly static Field REGIONCODE = new Field("REGIONCODE", "T_ZT_PRACTITIONER", "行政区域代码");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field PERSONEDU = new Field("PERSONEDU", "T_ZT_PRACTITIONER", "最高学历");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PERSONPHONE = new Field("PERSONPHONE", "T_ZT_PRACTITIONER", "联系电话");
            /// <summary>
			/// 所在单位代码
			/// </summary>
			public readonly static Field UNITCODE = new Field("UNITCODE", "T_ZT_PRACTITIONER", "所在单位代码");
            /// <summary>
			/// 所在单位名称
			/// </summary>
			public readonly static Field UNITNAME = new Field("UNITNAME", "T_ZT_PRACTITIONER", "所在单位名称");
            /// <summary>
			/// 是否在职
			/// </summary>
			public readonly static Field ONJOB = new Field("ONJOB", "T_ZT_PRACTITIONER", "是否在职");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field JOB = new Field("JOB", "T_ZT_PRACTITIONER", "职务");
            /// <summary>
			/// 技术职称
			/// </summary>
			public readonly static Field TECHTITLE = new Field("TECHTITLE", "T_ZT_PRACTITIONER", "技术职称");
            /// <summary>
			/// 从业开始时间
			/// </summary>
			public readonly static Field WORKSTARTDATE = new Field("WORKSTARTDATE", "T_ZT_PRACTITIONER", "从业开始时间");
            /// <summary>
			/// 从业经历
			/// </summary>
			public readonly static Field WORKINGEXPERIENCE = new Field("WORKINGEXPERIENCE", "T_ZT_PRACTITIONER", "从业经历");
            /// <summary>
			/// 来源平台编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_ZT_PRACTITIONER", "来源平台编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_ZT_PRACTITIONER", "数据时间戳");
        }
        #endregion
	}
}