using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_EMPLOYEES_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_EMPLOYEES_INFO")]
    [Serializable]
    public partial class ZJPRI_EMPLOYEES_INFO : FwEntity
    {
        #region Model
		private decimal? _PERSONID;
		private string _NAME;
		private string _SEX;
		private DateTime? _BIRTHDAY;
		private string _IDENTITYCARDTYPE;
		private string _IDENTITYCARDNUMBER;
		private string _HIGHESTEDUCATION;
		private string _TELEPHONE;
		private string _MOBILEPHONE;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;

		/// <summary>
		/// 人员ID
		/// </summary>
		public decimal? PERSONID
		{
			get{ return _PERSONID; }
			set
			{
				this.OnPropertyValueChange(_.PERSONID, _PERSONID, value);
				this._PERSONID = value;
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
		public string SEX
		{
			get{ return _SEX; }
			set
			{
				this.OnPropertyValueChange(_.SEX, _SEX, value);
				this._SEX = value;
			}
		}
		/// <summary>
		/// 出生年月
		/// </summary>
		public DateTime? BIRTHDAY
		{
			get{ return _BIRTHDAY; }
			set
			{
				this.OnPropertyValueChange(_.BIRTHDAY, _BIRTHDAY, value);
				this._BIRTHDAY = value;
			}
		}
		/// <summary>
		/// 证件类型
		/// </summary>
		public string IDENTITYCARDTYPE
		{
			get{ return _IDENTITYCARDTYPE; }
			set
			{
				this.OnPropertyValueChange(_.IDENTITYCARDTYPE, _IDENTITYCARDTYPE, value);
				this._IDENTITYCARDTYPE = value;
			}
		}
		/// <summary>
		/// 证件号码
		/// </summary>
		public string IDENTITYCARDNUMBER
		{
			get{ return _IDENTITYCARDNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.IDENTITYCARDNUMBER, _IDENTITYCARDNUMBER, value);
				this._IDENTITYCARDNUMBER = value;
			}
		}
		/// <summary>
		/// 最高学历
		/// </summary>
		public string HIGHESTEDUCATION
		{
			get{ return _HIGHESTEDUCATION; }
			set
			{
				this.OnPropertyValueChange(_.HIGHESTEDUCATION, _HIGHESTEDUCATION, value);
				this._HIGHESTEDUCATION = value;
			}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string TELEPHONE
		{
			get{ return _TELEPHONE; }
			set
			{
				this.OnPropertyValueChange(_.TELEPHONE, _TELEPHONE, value);
				this._TELEPHONE = value;
			}
		}
		/// <summary>
		/// 移动电话
		/// </summary>
		public string MOBILEPHONE
		{
			get{ return _MOBILEPHONE; }
			set
			{
				this.OnPropertyValueChange(_.MOBILEPHONE, _MOBILEPHONE, value);
				this._MOBILEPHONE = value;
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
				_.PERSONID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PERSONID,
				_.NAME,
				_.SEX,
				_.BIRTHDAY,
				_.IDENTITYCARDTYPE,
				_.IDENTITYCARDNUMBER,
				_.HIGHESTEDUCATION,
				_.TELEPHONE,
				_.MOBILEPHONE,
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
				this._PERSONID,
				this._NAME,
				this._SEX,
				this._BIRTHDAY,
				this._IDENTITYCARDTYPE,
				this._IDENTITYCARDNUMBER,
				this._HIGHESTEDUCATION,
				this._TELEPHONE,
				this._MOBILEPHONE,
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
			public readonly static Field All = new Field("*", "ZJPRI_EMPLOYEES_INFO");
            /// <summary>
			/// 人员ID
			/// </summary>
			public readonly static Field PERSONID = new Field("PERSONID", "ZJPRI_EMPLOYEES_INFO", "人员ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_EMPLOYEES_INFO", "姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field SEX = new Field("SEX", "ZJPRI_EMPLOYEES_INFO", "性别");
            /// <summary>
			/// 出生年月
			/// </summary>
			public readonly static Field BIRTHDAY = new Field("BIRTHDAY", "ZJPRI_EMPLOYEES_INFO", "出生年月");
            /// <summary>
			/// 证件类型
			/// </summary>
			public readonly static Field IDENTITYCARDTYPE = new Field("IDENTITYCARDTYPE", "ZJPRI_EMPLOYEES_INFO", "证件类型");
            /// <summary>
			/// 证件号码
			/// </summary>
			public readonly static Field IDENTITYCARDNUMBER = new Field("IDENTITYCARDNUMBER", "ZJPRI_EMPLOYEES_INFO", "证件号码");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field HIGHESTEDUCATION = new Field("HIGHESTEDUCATION", "ZJPRI_EMPLOYEES_INFO", "最高学历");
            /// <summary>
			/// 电话
			/// </summary>
			public readonly static Field TELEPHONE = new Field("TELEPHONE", "ZJPRI_EMPLOYEES_INFO", "电话");
            /// <summary>
			/// 移动电话
			/// </summary>
			public readonly static Field MOBILEPHONE = new Field("MOBILEPHONE", "ZJPRI_EMPLOYEES_INFO", "移动电话");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_EMPLOYEES_INFO", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_EMPLOYEES_INFO", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_EMPLOYEES_INFO", "版本号");
        }
        #endregion
	}
}