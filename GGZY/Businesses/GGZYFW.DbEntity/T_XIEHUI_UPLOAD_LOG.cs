using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_XIEHUI_UPLOAD_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_XIEHUI_UPLOAD_LOG")]
    [Serializable]
    public partial class T_XIEHUI_UPLOAD_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _DATA_KEY;
		private string _TB_NAME;
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _SECTION_CODE;
		private string _INSTANCE_ID;
		private DateTime? _CREATE_TIME;
		private string _STATUS;

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
		/// 
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 表名
		/// </summary>
		public string TB_NAME
		{
			get{ return _TB_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TB_NAME, _TB_NAME, value);
				this._TB_NAME = value;
			}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string SECTION_CODE
		{
			get{ return _SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_CODE, _SECTION_CODE, value);
				this._SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 流水号
		/// </summary>
		public string INSTANCE_ID
		{
			get{ return _INSTANCE_ID; }
			set
			{
				this.OnPropertyValueChange(_.INSTANCE_ID, _INSTANCE_ID, value);
				this._INSTANCE_ID = value;
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
		/// 返回的状态（true或false，成功或者失败）
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
				_.DATA_KEY,
				_.TB_NAME,
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.SECTION_CODE,
				_.INSTANCE_ID,
				_.CREATE_TIME,
				_.STATUS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DATA_KEY,
				this._TB_NAME,
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._SECTION_CODE,
				this._INSTANCE_ID,
				this._CREATE_TIME,
				this._STATUS,
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
			public readonly static Field All = new Field("*", "T_XIEHUI_UPLOAD_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_XIEHUI_UPLOAD_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_XIEHUI_UPLOAD_LOG", "");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_XIEHUI_UPLOAD_LOG", "表名");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_XIEHUI_UPLOAD_LOG", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_XIEHUI_UPLOAD_LOG", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "T_XIEHUI_UPLOAD_LOG", "标段（包）编号");
            /// <summary>
			/// 流水号
			/// </summary>
			public readonly static Field INSTANCE_ID = new Field("INSTANCE_ID", "T_XIEHUI_UPLOAD_LOG", "流水号");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_XIEHUI_UPLOAD_LOG", "创建时间");
            /// <summary>
			/// 返回的状态（true或false，成功或者失败）
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_XIEHUI_UPLOAD_LOG", "返回的状态（true或false，成功或者失败）");
        }
        #endregion
	}
}