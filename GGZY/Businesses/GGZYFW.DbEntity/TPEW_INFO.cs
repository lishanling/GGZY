using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TPEW_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TPEW_INFO")]
    [Serializable]
    public partial class TPEW_INFO : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _EW_NUMBER;
		private string _TP_NUMBER;
		private string _STATUS;
		private string _SUPV_POINT_ID;
		private string _RECEIVER;
		private string _EW_CONTENT;
		private decimal? _APV_PEOPLE;
		private DateTime? _APV_TIME;
		private decimal? _CREATE_PEOPLE;
		private DateTime? _CREATE_TIME;

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
		/// 预警编号
		/// </summary>
		public string EW_NUMBER
		{
			get{ return _EW_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.EW_NUMBER, _EW_NUMBER, value);
				this._EW_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TP_NUMBER
		{
			get{ return _TP_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TP_NUMBER, _TP_NUMBER, value);
				this._TP_NUMBER = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public string STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 监督点ID
		/// </summary>
		public string SUPV_POINT_ID
		{
			get{ return _SUPV_POINT_ID; }
			set
			{
				this.OnPropertyValueChange(_.SUPV_POINT_ID, _SUPV_POINT_ID, value);
				this._SUPV_POINT_ID = value;
			}
		}
		/// <summary>
		/// 接收人
		/// </summary>
		public string RECEIVER
		{
			get{ return _RECEIVER; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER, _RECEIVER, value);
				this._RECEIVER = value;
			}
		}
		/// <summary>
		/// 预警内容
		/// </summary>
		public string EW_CONTENT
		{
			get{ return _EW_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.EW_CONTENT, _EW_CONTENT, value);
				this._EW_CONTENT = value;
			}
		}
		/// <summary>
		/// 审批人
		/// </summary>
		public decimal? APV_PEOPLE
		{
			get{ return _APV_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.APV_PEOPLE, _APV_PEOPLE, value);
				this._APV_PEOPLE = value;
			}
		}
		/// <summary>
		/// 审批时间
		/// </summary>
		public DateTime? APV_TIME
		{
			get{ return _APV_TIME; }
			set
			{
				this.OnPropertyValueChange(_.APV_TIME, _APV_TIME, value);
				this._APV_TIME = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATE_PEOPLE
		{
			get{ return _CREATE_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_PEOPLE, _CREATE_PEOPLE, value);
				this._CREATE_PEOPLE = value;
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
				_.EW_NUMBER,
				_.TP_NUMBER,
				_.STATUS,
				_.SUPV_POINT_ID,
				_.RECEIVER,
				_.EW_CONTENT,
				_.APV_PEOPLE,
				_.APV_TIME,
				_.CREATE_PEOPLE,
				_.CREATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._EW_NUMBER,
				this._TP_NUMBER,
				this._STATUS,
				this._SUPV_POINT_ID,
				this._RECEIVER,
				this._EW_CONTENT,
				this._APV_PEOPLE,
				this._APV_TIME,
				this._CREATE_PEOPLE,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "TPEW_INFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TPEW_INFO", "ID");
            /// <summary>
			/// 预警编号
			/// </summary>
			public readonly static Field EW_NUMBER = new Field("EW_NUMBER", "TPEW_INFO", "预警编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TP_NUMBER = new Field("TP_NUMBER", "TPEW_INFO", "招标项目编号");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "TPEW_INFO", "状态");
            /// <summary>
			/// 监督点ID
			/// </summary>
			public readonly static Field SUPV_POINT_ID = new Field("SUPV_POINT_ID", "TPEW_INFO", "监督点ID");
            /// <summary>
			/// 接收人
			/// </summary>
			public readonly static Field RECEIVER = new Field("RECEIVER", "TPEW_INFO", "接收人");
            /// <summary>
			/// 预警内容
			/// </summary>
			public readonly static Field EW_CONTENT = new Field("EW_CONTENT", "TPEW_INFO", "预警内容");
            /// <summary>
			/// 审批人
			/// </summary>
			public readonly static Field APV_PEOPLE = new Field("APV_PEOPLE", "TPEW_INFO", "审批人");
            /// <summary>
			/// 审批时间
			/// </summary>
			public readonly static Field APV_TIME = new Field("APV_TIME", "TPEW_INFO", "审批时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_PEOPLE = new Field("CREATE_PEOPLE", "TPEW_INFO", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "TPEW_INFO", "创建时间");
        }
        #endregion
	}
}