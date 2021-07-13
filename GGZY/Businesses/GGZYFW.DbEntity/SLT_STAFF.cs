using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SLT_STAFF。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SLT_STAFF")]
    [Serializable]
    public partial class SLT_STAFF : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _ORGCODE;
		private string _IDCARD;
		private string _BIRTHDATE;
		private string _PROTITLE;
		private decimal? _WORKYEAR;
		private string _QUALIFYNAME;
		private string _QUALIFYLEVEL;
		private string _QUALIFYNO;
		private string _SCHOOL;
		private string _MAJOR;
		private string _EDUCATE;
		private string _SYNCDATA;
		private string _SYNCTIME;

		/// <summary>
		/// 人员ID
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
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
		/// 企业信用社代码
		/// </summary>
		public string ORGCODE
		{
			get{ return _ORGCODE; }
			set
			{
				this.OnPropertyValueChange(_.ORGCODE, _ORGCODE, value);
				this._ORGCODE = value;
			}
		}
		/// <summary>
		/// 身份证号（已加密，解密方式见后文）
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
		/// 出生年月（yyyy-MM）
		/// </summary>
		public string BIRTHDATE
		{
			get{ return _BIRTHDATE; }
			set
			{
				this.OnPropertyValueChange(_.BIRTHDATE, _BIRTHDATE, value);
				this._BIRTHDATE = value;
			}
		}
		/// <summary>
		/// 职称
		/// </summary>
		public string PROTITLE
		{
			get{ return _PROTITLE; }
			set
			{
				this.OnPropertyValueChange(_.PROTITLE, _PROTITLE, value);
				this._PROTITLE = value;
			}
		}
		/// <summary>
		/// 工作年限
		/// </summary>
		public decimal? WORKYEAR
		{
			get{ return _WORKYEAR; }
			set
			{
				this.OnPropertyValueChange(_.WORKYEAR, _WORKYEAR, value);
				this._WORKYEAR = value;
			}
		}
		/// <summary>
		/// 证书名称（多个以，分割）
		/// </summary>
		public string QUALIFYNAME
		{
			get{ return _QUALIFYNAME; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYNAME, _QUALIFYNAME, value);
				this._QUALIFYNAME = value;
			}
		}
		/// <summary>
		/// 证书级别（多个以，分割）
		/// </summary>
		public string QUALIFYLEVEL
		{
			get{ return _QUALIFYLEVEL; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYLEVEL, _QUALIFYLEVEL, value);
				this._QUALIFYLEVEL = value;
			}
		}
		/// <summary>
		/// 证书编号（多个以，分割）
		/// </summary>
		public string QUALIFYNO
		{
			get{ return _QUALIFYNO; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYNO, _QUALIFYNO, value);
				this._QUALIFYNO = value;
			}
		}
		/// <summary>
		/// 毕业学校（多个以，分割）
		/// </summary>
		public string SCHOOL
		{
			get{ return _SCHOOL; }
			set
			{
				this.OnPropertyValueChange(_.SCHOOL, _SCHOOL, value);
				this._SCHOOL = value;
			}
		}
		/// <summary>
		/// 专业（多个以，分割）
		/// </summary>
		public string MAJOR
		{
			get{ return _MAJOR; }
			set
			{
				this.OnPropertyValueChange(_.MAJOR, _MAJOR, value);
				this._MAJOR = value;
			}
		}
		/// <summary>
		/// 学历（多个以，分割）
		/// </summary>
		public string EDUCATE
		{
			get{ return _EDUCATE; }
			set
			{
				this.OnPropertyValueChange(_.EDUCATE, _EDUCATE, value);
				this._EDUCATE = value;
			}
		}
		/// <summary>
		/// 同步日期
		/// </summary>
		public string SYNCDATA
		{
			get{ return _SYNCDATA; }
			set
			{
				this.OnPropertyValueChange(_.SYNCDATA, _SYNCDATA, value);
				this._SYNCDATA = value;
			}
		}
		/// <summary>
		/// 同步时间
		/// </summary>
		public string SYNCTIME
		{
			get{ return _SYNCTIME; }
			set
			{
				this.OnPropertyValueChange(_.SYNCTIME, _SYNCTIME, value);
				this._SYNCTIME = value;
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
				_.ID,
				_.NAME,
				_.ORGCODE,
				_.IDCARD,
				_.BIRTHDATE,
				_.PROTITLE,
				_.WORKYEAR,
				_.QUALIFYNAME,
				_.QUALIFYLEVEL,
				_.QUALIFYNO,
				_.SCHOOL,
				_.MAJOR,
				_.EDUCATE,
				_.SYNCDATA,
				_.SYNCTIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._ORGCODE,
				this._IDCARD,
				this._BIRTHDATE,
				this._PROTITLE,
				this._WORKYEAR,
				this._QUALIFYNAME,
				this._QUALIFYLEVEL,
				this._QUALIFYNO,
				this._SCHOOL,
				this._MAJOR,
				this._EDUCATE,
				this._SYNCDATA,
				this._SYNCTIME,
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
			public readonly static Field All = new Field("*", "SLT_STAFF");
            /// <summary>
			/// 人员ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "SLT_STAFF", "人员ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "SLT_STAFF", "姓名");
            /// <summary>
			/// 企业信用社代码
			/// </summary>
			public readonly static Field ORGCODE = new Field("ORGCODE", "SLT_STAFF", "企业信用社代码");
            /// <summary>
			/// 身份证号（已加密，解密方式见后文）
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "SLT_STAFF", "身份证号（已加密，解密方式见后文）");
            /// <summary>
			/// 出生年月（yyyy-MM）
			/// </summary>
			public readonly static Field BIRTHDATE = new Field("BIRTHDATE", "SLT_STAFF", "出生年月（yyyy-MM）");
            /// <summary>
			/// 职称
			/// </summary>
			public readonly static Field PROTITLE = new Field("PROTITLE", "SLT_STAFF", "职称");
            /// <summary>
			/// 工作年限
			/// </summary>
			public readonly static Field WORKYEAR = new Field("WORKYEAR", "SLT_STAFF", "工作年限");
            /// <summary>
			/// 证书名称（多个以，分割）
			/// </summary>
			public readonly static Field QUALIFYNAME = new Field("QUALIFYNAME", "SLT_STAFF", "证书名称（多个以，分割）");
            /// <summary>
			/// 证书级别（多个以，分割）
			/// </summary>
			public readonly static Field QUALIFYLEVEL = new Field("QUALIFYLEVEL", "SLT_STAFF", "证书级别（多个以，分割）");
            /// <summary>
			/// 证书编号（多个以，分割）
			/// </summary>
			public readonly static Field QUALIFYNO = new Field("QUALIFYNO", "SLT_STAFF", "证书编号（多个以，分割）");
            /// <summary>
			/// 毕业学校（多个以，分割）
			/// </summary>
			public readonly static Field SCHOOL = new Field("SCHOOL", "SLT_STAFF", "毕业学校（多个以，分割）");
            /// <summary>
			/// 专业（多个以，分割）
			/// </summary>
			public readonly static Field MAJOR = new Field("MAJOR", "SLT_STAFF", "专业（多个以，分割）");
            /// <summary>
			/// 学历（多个以，分割）
			/// </summary>
			public readonly static Field EDUCATE = new Field("EDUCATE", "SLT_STAFF", "学历（多个以，分割）");
            /// <summary>
			/// 同步日期
			/// </summary>
			public readonly static Field SYNCDATA = new Field("SYNCDATA", "SLT_STAFF", "同步日期");
            /// <summary>
			/// 同步时间
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "SLT_STAFF", "同步时间");
        }
        #endregion
	}
}