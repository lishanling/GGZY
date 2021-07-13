using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_MULTIMEDIA_DATA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MULTIMEDIA_DATA")]
    [Serializable]
    public partial class T_MULTIMEDIA_DATA : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _URL;
		private string _DATA;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;
		private DateTime? _MODIFY_TIME;

		/// <summary>
		/// 主键
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
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 视频外链地址
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 视频信息数据
		/// </summary>
		public string DATA
		{
			get{ return _DATA; }
			set
			{
				this.OnPropertyValueChange(_.DATA, _DATA, value);
				this._DATA = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string DATA_SOURCE
		{
			get{ return _DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.DATA_SOURCE, _DATA_SOURCE, value);
				this._DATA_SOURCE = value;
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
		/// 修改时间
		/// </summary>
		public DateTime? MODIFY_TIME
		{
			get{ return _MODIFY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFY_TIME, _MODIFY_TIME, value);
				this._MODIFY_TIME = value;
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
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.URL,
				_.DATA,
				_.DATA_SOURCE,
				_.CREATE_TIME,
				_.MODIFY_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._URL,
				this._DATA,
				this._DATA_SOURCE,
				this._CREATE_TIME,
				this._MODIFY_TIME,
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
			public readonly static Field All = new Field("*", "T_MULTIMEDIA_DATA");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MULTIMEDIA_DATA", "主键");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_MULTIMEDIA_DATA", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_MULTIMEDIA_DATA", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "T_MULTIMEDIA_DATA", "标段（包）编号");
            /// <summary>
			/// 视频外链地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_MULTIMEDIA_DATA", "视频外链地址");
            /// <summary>
			/// 视频信息数据
			/// </summary>
			public readonly static Field DATA = new Field("DATA", "T_MULTIMEDIA_DATA", "视频信息数据");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_MULTIMEDIA_DATA", "数据来源");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_MULTIMEDIA_DATA", "创建时间");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field MODIFY_TIME = new Field("MODIFY_TIME", "T_MULTIMEDIA_DATA", "修改时间");
        }
        #endregion
	}
}