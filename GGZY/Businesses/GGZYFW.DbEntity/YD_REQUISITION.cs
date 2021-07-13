using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类YD_REQUISITION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YD_REQUISITION")]
    [Serializable]
    public partial class YD_REQUISITION : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private string _NAME;
		private decimal? _IS_DEL;
		private decimal? _STATUS;
		private decimal? _IS_DONE;
		private string _FILES;
		private DateTime? _DONE_TM;
		private decimal? _DONE_BY;
		private decimal? _TP_ID;
		private DateTime? _SQ_BTM;
		private DateTime? _SQ_ETM;
		private string _MAIN_MEETING;
		private string _OTHER_MEETING;
		private string _REMARK;
		private DateTime? _SUBMIT_TM;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;
		private decimal? _DEL_BY;
		private DateTime? _DEL_TM;

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
		/// 申请单编号
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
		/// 申请单名称
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
		/// 
		/// </summary>
		public decimal? IS_DEL
		{
			get{ return _IS_DEL; }
			set
			{
				this.OnPropertyValueChange(_.IS_DEL, _IS_DEL, value);
				this._IS_DEL = value;
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
		/// 是否归档
		/// </summary>
		public decimal? IS_DONE
		{
			get{ return _IS_DONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DONE, _IS_DONE, value);
				this._IS_DONE = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public DateTime? DONE_TM
		{
			get{ return _DONE_TM; }
			set
			{
				this.OnPropertyValueChange(_.DONE_TM, _DONE_TM, value);
				this._DONE_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DONE_BY
		{
			get{ return _DONE_BY; }
			set
			{
				this.OnPropertyValueChange(_.DONE_BY, _DONE_BY, value);
				this._DONE_BY = value;
			}
		}
		/// <summary>
		/// 招标项目ID
		/// </summary>
		public decimal? TP_ID
		{
			get{ return _TP_ID; }
			set
			{
				this.OnPropertyValueChange(_.TP_ID, _TP_ID, value);
				this._TP_ID = value;
			}
		}
		/// <summary>
		/// 申请开始时间
		/// </summary>
		public DateTime? SQ_BTM
		{
			get{ return _SQ_BTM; }
			set
			{
				this.OnPropertyValueChange(_.SQ_BTM, _SQ_BTM, value);
				this._SQ_BTM = value;
			}
		}
		/// <summary>
		/// 申请结束时间
		/// </summary>
		public DateTime? SQ_ETM
		{
			get{ return _SQ_ETM; }
			set
			{
				this.OnPropertyValueChange(_.SQ_ETM, _SQ_ETM, value);
				this._SQ_ETM = value;
			}
		}
		/// <summary>
		/// 主会场相关信息
		/// </summary>
		public string MAIN_MEETING
		{
			get{ return _MAIN_MEETING; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_MEETING, _MAIN_MEETING, value);
				this._MAIN_MEETING = value;
			}
		}
		/// <summary>
		/// 分会场相关信息
		/// </summary>
		public string OTHER_MEETING
		{
			get{ return _OTHER_MEETING; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_MEETING, _OTHER_MEETING, value);
				this._OTHER_MEETING = value;
			}
		}
		/// <summary>
		/// 
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
		/// 申请单提交时间，用于识别旧的审批记录，新建和打回后重新申请都要更新次字段
		/// </summary>
		public DateTime? SUBMIT_TM
		{
			get{ return _SUBMIT_TM; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_TM, _SUBMIT_TM, value);
				this._SUBMIT_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal? DEL_BY
		{
			get{ return _DEL_BY; }
			set
			{
				this.OnPropertyValueChange(_.DEL_BY, _DEL_BY, value);
				this._DEL_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DEL_TM
		{
			get{ return _DEL_TM; }
			set
			{
				this.OnPropertyValueChange(_.DEL_TM, _DEL_TM, value);
				this._DEL_TM = value;
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
				_.CODE,
				_.NAME,
				_.IS_DEL,
				_.STATUS,
				_.IS_DONE,
				_.FILES,
				_.DONE_TM,
				_.DONE_BY,
				_.TP_ID,
				_.SQ_BTM,
				_.SQ_ETM,
				_.MAIN_MEETING,
				_.OTHER_MEETING,
				_.REMARK,
				_.SUBMIT_TM,
				_.CREATE_BY,
				_.CREATE_TM,
				_.DEL_BY,
				_.DEL_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CODE,
				this._NAME,
				this._IS_DEL,
				this._STATUS,
				this._IS_DONE,
				this._FILES,
				this._DONE_TM,
				this._DONE_BY,
				this._TP_ID,
				this._SQ_BTM,
				this._SQ_ETM,
				this._MAIN_MEETING,
				this._OTHER_MEETING,
				this._REMARK,
				this._SUBMIT_TM,
				this._CREATE_BY,
				this._CREATE_TM,
				this._DEL_BY,
				this._DEL_TM,
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
			public readonly static Field All = new Field("*", "YD_REQUISITION");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "YD_REQUISITION", "");
            /// <summary>
			/// 申请单编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "YD_REQUISITION", "申请单编号");
            /// <summary>
			/// 申请单名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "YD_REQUISITION", "申请单名称");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_DEL = new Field("IS_DEL", "YD_REQUISITION", "");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "YD_REQUISITION", "状态");
            /// <summary>
			/// 是否归档
			/// </summary>
			public readonly static Field IS_DONE = new Field("IS_DONE", "YD_REQUISITION", "是否归档");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "YD_REQUISITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DONE_TM = new Field("DONE_TM", "YD_REQUISITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DONE_BY = new Field("DONE_BY", "YD_REQUISITION", "");
            /// <summary>
			/// 招标项目ID
			/// </summary>
			public readonly static Field TP_ID = new Field("TP_ID", "YD_REQUISITION", "招标项目ID");
            /// <summary>
			/// 申请开始时间
			/// </summary>
			public readonly static Field SQ_BTM = new Field("SQ_BTM", "YD_REQUISITION", "申请开始时间");
            /// <summary>
			/// 申请结束时间
			/// </summary>
			public readonly static Field SQ_ETM = new Field("SQ_ETM", "YD_REQUISITION", "申请结束时间");
            /// <summary>
			/// 主会场相关信息
			/// </summary>
			public readonly static Field MAIN_MEETING = new Field("MAIN_MEETING", "YD_REQUISITION", "主会场相关信息");
            /// <summary>
			/// 分会场相关信息
			/// </summary>
			public readonly static Field OTHER_MEETING = new Field("OTHER_MEETING", "YD_REQUISITION", "分会场相关信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YD_REQUISITION", "");
            /// <summary>
			/// 申请单提交时间，用于识别旧的审批记录，新建和打回后重新申请都要更新次字段
			/// </summary>
			public readonly static Field SUBMIT_TM = new Field("SUBMIT_TM", "YD_REQUISITION", "申请单提交时间，用于识别旧的审批记录，新建和打回后重新申请都要更新次字段");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "YD_REQUISITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "YD_REQUISITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEL_BY = new Field("DEL_BY", "YD_REQUISITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEL_TM = new Field("DEL_TM", "YD_REQUISITION", "");
        }
        #endregion
	}
}