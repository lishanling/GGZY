using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS_REVOKE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS_REVOKE")]
    [Serializable]
    public partial class PT_ZXTS_REVOKE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _TS_ID;
		private string _TYPE;
		private DateTime? _TM;
		private string _REMARK;
		private string _REVOKE_AIDS;
		private string _OTHER_AIDS;
		private decimal? _APPROVAL_UID;
		private decimal? _APPROVAL_STATE;
		private string _APPROVAL_REMARK;
		private DateTime? _APPROVAL_TM;
		private string _APPROVAL_AIDS;

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
		/// 投诉ID
		/// </summary>
		public decimal? TS_ID
		{
			get{ return _TS_ID; }
			set
			{
				this.OnPropertyValueChange(_.TS_ID, _TS_ID, value);
				this._TS_ID = value;
			}
		}
		/// <summary>
		/// 撤销类型（1撤销2申请撤诉type=76）
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 时间
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
		/// 说明
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
		/// 附件_书面的撤回原由
		/// </summary>
		public string REVOKE_AIDS
		{
			get{ return _REVOKE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.REVOKE_AIDS, _REVOKE_AIDS, value);
				this._REVOKE_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_其他相关材料
		/// </summary>
		public string OTHER_AIDS
		{
			get{ return _OTHER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_AIDS, _OTHER_AIDS, value);
				this._OTHER_AIDS = value;
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
		/// 审批状态（1待审查2同意撤回3不予撤回type=77）
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
		/// 附件_审批附件
		/// </summary>
		public string APPROVAL_AIDS
		{
			get{ return _APPROVAL_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_AIDS, _APPROVAL_AIDS, value);
				this._APPROVAL_AIDS = value;
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
				_.TS_ID,
				_.TYPE,
				_.TM,
				_.REMARK,
				_.REVOKE_AIDS,
				_.OTHER_AIDS,
				_.APPROVAL_UID,
				_.APPROVAL_STATE,
				_.APPROVAL_REMARK,
				_.APPROVAL_TM,
				_.APPROVAL_AIDS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TS_ID,
				this._TYPE,
				this._TM,
				this._REMARK,
				this._REVOKE_AIDS,
				this._OTHER_AIDS,
				this._APPROVAL_UID,
				this._APPROVAL_STATE,
				this._APPROVAL_REMARK,
				this._APPROVAL_TM,
				this._APPROVAL_AIDS,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_REVOKE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_REVOKE", "ID");
            /// <summary>
			/// 投诉ID
			/// </summary>
			public readonly static Field TS_ID = new Field("TS_ID", "PT_ZXTS_REVOKE", "投诉ID");
            /// <summary>
			/// 撤销类型（1撤销2申请撤诉type=76）
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "PT_ZXTS_REVOKE", "撤销类型（1撤销2申请撤诉type=76）");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_ZXTS_REVOKE", "时间");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "PT_ZXTS_REVOKE", "说明");
            /// <summary>
			/// 附件_书面的撤回原由
			/// </summary>
			public readonly static Field REVOKE_AIDS = new Field("REVOKE_AIDS", "PT_ZXTS_REVOKE", "附件_书面的撤回原由");
            /// <summary>
			/// 附件_其他相关材料
			/// </summary>
			public readonly static Field OTHER_AIDS = new Field("OTHER_AIDS", "PT_ZXTS_REVOKE", "附件_其他相关材料");
            /// <summary>
			/// 审批人员
			/// </summary>
			public readonly static Field APPROVAL_UID = new Field("APPROVAL_UID", "PT_ZXTS_REVOKE", "审批人员");
            /// <summary>
			/// 审批状态（1待审查2同意撤回3不予撤回type=77）
			/// </summary>
			public readonly static Field APPROVAL_STATE = new Field("APPROVAL_STATE", "PT_ZXTS_REVOKE", "审批状态（1待审查2同意撤回3不予撤回type=77）");
            /// <summary>
			/// 审批意见
			/// </summary>
			public readonly static Field APPROVAL_REMARK = new Field("APPROVAL_REMARK", "PT_ZXTS_REVOKE", "审批意见");
            /// <summary>
			/// 审批日期
			/// </summary>
			public readonly static Field APPROVAL_TM = new Field("APPROVAL_TM", "PT_ZXTS_REVOKE", "审批日期");
            /// <summary>
			/// 附件_审批附件
			/// </summary>
			public readonly static Field APPROVAL_AIDS = new Field("APPROVAL_AIDS", "PT_ZXTS_REVOKE", "附件_审批附件");
        }
        #endregion
	}
}