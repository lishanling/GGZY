using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_CHANGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_CHANGE")]
    [Serializable]
    public partial class T_AFC_CHANGE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _AFC_ID;
		private decimal? _U_ID;
		private DateTime? _TM;
		private string _REMARK;
		private decimal? _APPROVAL_UID;
		private decimal? _APPROVAL_STATE;
		private string _APPROVAL_REMARK;
		private DateTime? _APPROVAL_TM;
		private string _AIDS;
		private string _APPROVAL_UNAME;
		private string _APPROVAL_CONTACT_INFORMATION;

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
		/// 项目报建ID
		/// </summary>
		public decimal? AFC_ID
		{
			get{ return _AFC_ID; }
			set
			{
				this.OnPropertyValueChange(_.AFC_ID, _AFC_ID, value);
				this._AFC_ID = value;
			}
		}
		/// <summary>
		/// 申请人
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
		/// 申请时间
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 申请说明
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
		/// 审批人员
		/// </summary>
		public decimal? APPROVAL_UID
		{
			get{ return _APPROVAL_UID; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_UID, _APPROVAL_UID, value);
				this._APPROVAL_UID = value;
			}
		}
		/// <summary>
		/// 审批状态(1提交2通过3不通过)
		/// </summary>
		public decimal? APPROVAL_STATE
		{
			get{ return _APPROVAL_STATE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_STATE, _APPROVAL_STATE, value);
				this._APPROVAL_STATE = value;
			}
		}
		/// <summary>
		/// 审批意见
		/// </summary>
		public string APPROVAL_REMARK
		{
			get{ return _APPROVAL_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_REMARK, _APPROVAL_REMARK, value);
				this._APPROVAL_REMARK = value;
			}
		}
		/// <summary>
		/// 审批日期
		/// </summary>
		public DateTime? APPROVAL_TM
		{
			get{ return _APPROVAL_TM; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_TM, _APPROVAL_TM, value);
				this._APPROVAL_TM = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string AIDS
		{
			get{ return _AIDS; }
			set
			{
				this.OnPropertyValueChange(_.AIDS, _AIDS, value);
				this._AIDS = value;
			}
		}
		/// <summary>
		/// 审查人员-姓名
		/// </summary>
		public string APPROVAL_UNAME
		{
			get{ return _APPROVAL_UNAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_UNAME, _APPROVAL_UNAME, value);
				this._APPROVAL_UNAME = value;
			}
		}
		/// <summary>
		/// 审查人员-联系方式
		/// </summary>
		public string APPROVAL_CONTACT_INFORMATION
		{
			get{ return _APPROVAL_CONTACT_INFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_CONTACT_INFORMATION, _APPROVAL_CONTACT_INFORMATION, value);
				this._APPROVAL_CONTACT_INFORMATION = value;
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
				_.AFC_ID,
				_.U_ID,
				_.TM,
				_.REMARK,
				_.APPROVAL_UID,
				_.APPROVAL_STATE,
				_.APPROVAL_REMARK,
				_.APPROVAL_TM,
				_.AIDS,
				_.APPROVAL_UNAME,
				_.APPROVAL_CONTACT_INFORMATION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._AFC_ID,
				this._U_ID,
				this._TM,
				this._REMARK,
				this._APPROVAL_UID,
				this._APPROVAL_STATE,
				this._APPROVAL_REMARK,
				this._APPROVAL_TM,
				this._AIDS,
				this._APPROVAL_UNAME,
				this._APPROVAL_CONTACT_INFORMATION,
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
			public readonly static Field All = new Field("*", "T_AFC_CHANGE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_AFC_CHANGE", "ID");
            /// <summary>
			/// 项目报建ID
			/// </summary>
			public readonly static Field AFC_ID = new Field("AFC_ID", "T_AFC_CHANGE", "项目报建ID");
            /// <summary>
			/// 申请人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_AFC_CHANGE", "申请人");
            /// <summary>
			/// 申请时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_AFC_CHANGE", "申请时间");
            /// <summary>
			/// 申请说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_AFC_CHANGE", "申请说明");
            /// <summary>
			/// 审批人员
			/// </summary>
			public readonly static Field APPROVAL_UID = new Field("APPROVAL_UID", "T_AFC_CHANGE", "审批人员");
            /// <summary>
			/// 审批状态(1提交2通过3不通过)
			/// </summary>
			public readonly static Field APPROVAL_STATE = new Field("APPROVAL_STATE", "T_AFC_CHANGE", "审批状态(1提交2通过3不通过)");
            /// <summary>
			/// 审批意见
			/// </summary>
			public readonly static Field APPROVAL_REMARK = new Field("APPROVAL_REMARK", "T_AFC_CHANGE", "审批意见");
            /// <summary>
			/// 审批日期
			/// </summary>
			public readonly static Field APPROVAL_TM = new Field("APPROVAL_TM", "T_AFC_CHANGE", "审批日期");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field AIDS = new Field("AIDS", "T_AFC_CHANGE", "附件");
            /// <summary>
			/// 审查人员-姓名
			/// </summary>
			public readonly static Field APPROVAL_UNAME = new Field("APPROVAL_UNAME", "T_AFC_CHANGE", "审查人员-姓名");
            /// <summary>
			/// 审查人员-联系方式
			/// </summary>
			public readonly static Field APPROVAL_CONTACT_INFORMATION = new Field("APPROVAL_CONTACT_INFORMATION", "T_AFC_CHANGE", "审查人员-联系方式");
        }
        #endregion
	}
}