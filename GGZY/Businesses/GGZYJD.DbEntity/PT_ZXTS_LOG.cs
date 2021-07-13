using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS_LOG")]
    [Serializable]
    public partial class PT_ZXTS_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _TS_ID;
		private decimal? _RECORDER_UID;
		private string _RECORDER_UNAME;
		private decimal? _RECORDER_DEPID;
		private DateTime? _RECORDER_TM;
		private string _RECORDER_OPERATION;
		private string _RECORDER_REMARK;
		private string _RECORDER_AIDS;

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
		/// 在线投诉ID
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
		/// 记录人
		/// </summary>
		public decimal? RECORDER_UID
		{
			get{ return _RECORDER_UID; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_UID, _RECORDER_UID, value);
				this._RECORDER_UID = value;
			}
		}
		/// <summary>
		/// 记录-操作人名称
		/// </summary>
		public string RECORDER_UNAME
		{
			get{ return _RECORDER_UNAME; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_UNAME, _RECORDER_UNAME, value);
				this._RECORDER_UNAME = value;
			}
		}
		/// <summary>
		/// 记录-操作人单位
		/// </summary>
		public decimal? RECORDER_DEPID
		{
			get{ return _RECORDER_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_DEPID, _RECORDER_DEPID, value);
				this._RECORDER_DEPID = value;
			}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime? RECORDER_TM
		{
			get{ return _RECORDER_TM; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_TM, _RECORDER_TM, value);
				this._RECORDER_TM = value;
			}
		}
		/// <summary>
		/// 记录-操作（1提交投诉2撤销投诉3驳回投诉4受理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理10延迟处理type=75）
		/// </summary>
		public string RECORDER_OPERATION
		{
			get{ return _RECORDER_OPERATION; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_OPERATION, _RECORDER_OPERATION, value);
				this._RECORDER_OPERATION = value;
			}
		}
		/// <summary>
		/// 记录-相关意见
		/// </summary>
		public string RECORDER_REMARK
		{
			get{ return _RECORDER_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_REMARK, _RECORDER_REMARK, value);
				this._RECORDER_REMARK = value;
			}
		}
		/// <summary>
		/// 记录-附件
		/// </summary>
		public string RECORDER_AIDS
		{
			get{ return _RECORDER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.RECORDER_AIDS, _RECORDER_AIDS, value);
				this._RECORDER_AIDS = value;
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
				_.RECORDER_UID,
				_.RECORDER_UNAME,
				_.RECORDER_DEPID,
				_.RECORDER_TM,
				_.RECORDER_OPERATION,
				_.RECORDER_REMARK,
				_.RECORDER_AIDS,
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
				this._RECORDER_UID,
				this._RECORDER_UNAME,
				this._RECORDER_DEPID,
				this._RECORDER_TM,
				this._RECORDER_OPERATION,
				this._RECORDER_REMARK,
				this._RECORDER_AIDS,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_LOG", "ID");
            /// <summary>
			/// 在线投诉ID
			/// </summary>
			public readonly static Field TS_ID = new Field("TS_ID", "PT_ZXTS_LOG", "在线投诉ID");
            /// <summary>
			/// 记录人
			/// </summary>
			public readonly static Field RECORDER_UID = new Field("RECORDER_UID", "PT_ZXTS_LOG", "记录人");
            /// <summary>
			/// 记录-操作人名称
			/// </summary>
			public readonly static Field RECORDER_UNAME = new Field("RECORDER_UNAME", "PT_ZXTS_LOG", "记录-操作人名称");
            /// <summary>
			/// 记录-操作人单位
			/// </summary>
			public readonly static Field RECORDER_DEPID = new Field("RECORDER_DEPID", "PT_ZXTS_LOG", "记录-操作人单位");
            /// <summary>
			/// 记录时间
			/// </summary>
			public readonly static Field RECORDER_TM = new Field("RECORDER_TM", "PT_ZXTS_LOG", "记录时间");
            /// <summary>
			/// 记录-操作（1提交投诉2撤销投诉3驳回投诉4受理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理10延迟处理type=75）
			/// </summary>
			public readonly static Field RECORDER_OPERATION = new Field("RECORDER_OPERATION", "PT_ZXTS_LOG", "记录-操作（1提交投诉2撤销投诉3驳回投诉4受理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理10延迟处理type=75）");
            /// <summary>
			/// 记录-相关意见
			/// </summary>
			public readonly static Field RECORDER_REMARK = new Field("RECORDER_REMARK", "PT_ZXTS_LOG", "记录-相关意见");
            /// <summary>
			/// 记录-附件
			/// </summary>
			public readonly static Field RECORDER_AIDS = new Field("RECORDER_AIDS", "PT_ZXTS_LOG", "记录-附件");
        }
        #endregion
	}
}