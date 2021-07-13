using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_UPDATEEMAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_UPDATEEMAIL")]
    [Serializable]
    public partial class T_UPDATEEMAIL : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _CODE;
		private string _EMAIL_OLD;
		private string _EMAIL_NEW;
		private DateTime? _CREATE_TM;
		private decimal? _IS_ENABLE;

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
		/// T_USER外键
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 验证码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 旧电子邮箱
		/// </summary>
		public string EMAIL_OLD
		{
			get{ return _EMAIL_OLD; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL_OLD, _EMAIL_OLD, value);
				this._EMAIL_OLD = value;
			}
		}
		/// <summary>
		/// 新电子邮箱
		/// </summary>
		public string EMAIL_NEW
		{
			get{ return _EMAIL_NEW; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL_NEW, _EMAIL_NEW, value);
				this._EMAIL_NEW = value;
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
		/// 是否有效
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
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
				_.U_ID,
				_.CODE,
				_.EMAIL_OLD,
				_.EMAIL_NEW,
				_.CREATE_TM,
				_.IS_ENABLE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._U_ID,
				this._CODE,
				this._EMAIL_OLD,
				this._EMAIL_NEW,
				this._CREATE_TM,
				this._IS_ENABLE,
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
			public readonly static Field All = new Field("*", "T_UPDATEEMAIL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_UPDATEEMAIL", "ID");
            /// <summary>
			/// T_USER外键
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_UPDATEEMAIL", "T_USER外键");
            /// <summary>
			/// 验证码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_UPDATEEMAIL", "验证码");
            /// <summary>
			/// 旧电子邮箱
			/// </summary>
			public readonly static Field EMAIL_OLD = new Field("EMAIL_OLD", "T_UPDATEEMAIL", "旧电子邮箱");
            /// <summary>
			/// 新电子邮箱
			/// </summary>
			public readonly static Field EMAIL_NEW = new Field("EMAIL_NEW", "T_UPDATEEMAIL", "新电子邮箱");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_UPDATEEMAIL", "创建时间");
            /// <summary>
			/// 是否有效
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "T_UPDATEEMAIL", "是否有效");
        }
        #endregion
	}
}