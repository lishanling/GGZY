using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类COMPARE_SELECT_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("COMPARE_SELECT_RESULT")]
    [Serializable]
    public partial class COMPARE_SELECT_RESULT : FwEntity
    {
        #region Model
		private decimal? _ANNID;
		private string _AGENCY_NAME;
		private decimal? _M_STATUS;
		private string _CONTENT;
		private DateTime? _ADD_TIME;
		private decimal? _USERID;
		private string _REMARK;
		private decimal? _M_ID;
		private string _PLATFORM_CODE;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _URL;

		/// <summary>
		/// 所属比选公告ID
		/// </summary>
		public decimal? ANNID
		{
			get{ return _ANNID; }
			set
			{
				this.OnPropertyValueChange(_.ANNID, _ANNID, value);
				this._ANNID = value;
			}
		}
		/// <summary>
		/// 中选代理机构名称
		/// </summary>
		public string AGENCY_NAME
		{
			get{ return _AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_NAME, _AGENCY_NAME, value);
				this._AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public decimal? M_STATUS
		{
			get{ return _M_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.M_STATUS, _M_STATUS, value);
				this._M_STATUS = value;
			}
		}
		/// <summary>
		/// 中选内容
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? ADD_TIME
		{
			get{ return _ADD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ADD_TIME, _ADD_TIME, value);
				this._ADD_TIME = value;
			}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public decimal? USERID
		{
			get{ return _USERID; }
			set
			{
				this.OnPropertyValueChange(_.USERID, _USERID, value);
				this._USERID = value;
			}
		}
		/// <summary>
		/// 备注
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
		/// 
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 公告源URL
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ANNID,
				_.AGENCY_NAME,
				_.M_STATUS,
				_.CONTENT,
				_.ADD_TIME,
				_.USERID,
				_.REMARK,
				_.M_ID,
				_.PLATFORM_CODE,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.URL,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ANNID,
				this._AGENCY_NAME,
				this._M_STATUS,
				this._CONTENT,
				this._ADD_TIME,
				this._USERID,
				this._REMARK,
				this._M_ID,
				this._PLATFORM_CODE,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._URL,
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
			public readonly static Field All = new Field("*", "COMPARE_SELECT_RESULT");
            /// <summary>
			/// 所属比选公告ID
			/// </summary>
			public readonly static Field ANNID = new Field("ANNID", "COMPARE_SELECT_RESULT", "所属比选公告ID");
            /// <summary>
			/// 中选代理机构名称
			/// </summary>
			public readonly static Field AGENCY_NAME = new Field("AGENCY_NAME", "COMPARE_SELECT_RESULT", "中选代理机构名称");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field M_STATUS = new Field("M_STATUS", "COMPARE_SELECT_RESULT", "状态");
            /// <summary>
			/// 中选内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "COMPARE_SELECT_RESULT",DbType.AnsiString, null, "中选内容");
            /// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field ADD_TIME = new Field("ADD_TIME", "COMPARE_SELECT_RESULT", "添加时间");
            /// <summary>
			/// 添加人
			/// </summary>
			public readonly static Field USERID = new Field("USERID", "COMPARE_SELECT_RESULT", "添加人");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "COMPARE_SELECT_RESULT", "备注");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "COMPARE_SELECT_RESULT", "");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "COMPARE_SELECT_RESULT", "交易系统标识码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "COMPARE_SELECT_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "COMPARE_SELECT_RESULT", "");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "COMPARE_SELECT_RESULT", "公告源URL");
        }
        #endregion
	}
}