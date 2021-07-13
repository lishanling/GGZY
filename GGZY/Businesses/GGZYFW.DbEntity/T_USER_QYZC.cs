using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER_QYZC。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_QYZC")]
    [Serializable]
    public partial class T_USER_QYZC : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _UNAME;
		private string _CODE_TYPE;
		private string _QY_CODE;
		private string _LXR;
		private string _TEL_PHONE;
		private DateTime? _CREATETIME;
		private decimal? _STATUS;
		private string _FILES;
		private string _EMAIL;

		/// <summary>
		/// 
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
		/// 企业名称，账号名
		/// </summary>
		public string UNAME
		{
			get{ return _UNAME; }
			set
			{
				this.OnPropertyValueChange(_.UNAME, _UNAME, value);
				this._UNAME = value;
			}
		}
		/// <summary>
		/// 代码类型
		/// </summary>
		public string CODE_TYPE
		{
			get{ return _CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CODE_TYPE, _CODE_TYPE, value);
				this._CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 企业代码
		/// </summary>
		public string QY_CODE
		{
			get{ return _QY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.QY_CODE, _QY_CODE, value);
				this._QY_CODE = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string LXR
		{
			get{ return _LXR; }
			set
			{
				this.OnPropertyValueChange(_.LXR, _LXR, value);
				this._LXR = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string TEL_PHONE
		{
			get{ return _TEL_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TEL_PHONE, _TEL_PHONE, value);
				this._TEL_PHONE = value;
			}
		}
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 证明材料，附件
		/// </summary>
		public string FILES
		{
			get{ return _FILES; }
			set
			{
				this.OnPropertyValueChange(_.FILES, _FILES, value);
				this._FILES = value;
			}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
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
				_.UNAME,
				_.CODE_TYPE,
				_.QY_CODE,
				_.LXR,
				_.TEL_PHONE,
				_.CREATETIME,
				_.STATUS,
				_.FILES,
				_.EMAIL,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._UNAME,
				this._CODE_TYPE,
				this._QY_CODE,
				this._LXR,
				this._TEL_PHONE,
				this._CREATETIME,
				this._STATUS,
				this._FILES,
				this._EMAIL,
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
			public readonly static Field All = new Field("*", "T_USER_QYZC");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_QYZC", "");
            /// <summary>
			/// 企业名称，账号名
			/// </summary>
			public readonly static Field UNAME = new Field("UNAME", "T_USER_QYZC", "企业名称，账号名");
            /// <summary>
			/// 代码类型
			/// </summary>
			public readonly static Field CODE_TYPE = new Field("CODE_TYPE", "T_USER_QYZC", "代码类型");
            /// <summary>
			/// 企业代码
			/// </summary>
			public readonly static Field QY_CODE = new Field("QY_CODE", "T_USER_QYZC", "企业代码");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field LXR = new Field("LXR", "T_USER_QYZC", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field TEL_PHONE = new Field("TEL_PHONE", "T_USER_QYZC", "联系电话");
            /// <summary>
			/// 申请时间
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_USER_QYZC", "申请时间");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_USER_QYZC", "状态");
            /// <summary>
			/// 证明材料，附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "T_USER_QYZC", "证明材料，附件");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "T_USER_QYZC", "电子邮箱");
        }
        #endregion
	}
}