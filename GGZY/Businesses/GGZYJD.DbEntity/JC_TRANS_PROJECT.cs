using System;
using System.Data;
using Dos.ORM;
using Newtonsoft.Json;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JC_TRANS_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JC_TRANS_PROJECT")]
    [Serializable]
    public partial class JC_TRANS_PROJECT : JdEntity
    {
        #region Model
		private string _ID;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_NAME;
		private string _TENDER_CONTRACT;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_ANENCY_CODE;
		private string _RECORD_ID;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;

		/// <summary>
		/// ID
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
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
		/// 招标人
		/// </summary>
		public string TENDER_NAME
		{
			get{ return _TENDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NAME, _TENDER_NAME, value);
				this._TENDER_NAME = value;
			}
		}
		/// <summary>
		/// 招标联系人
		/// </summary>
		public string TENDER_CONTRACT
		{
			get{ return _TENDER_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CONTRACT, _TENDER_CONTRACT, value);
				this._TENDER_CONTRACT = value;
			}
		}
		/// <summary>
		/// 招标代理机构
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get{ return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构统一社会信用代码
		/// </summary>
		public string TENDER_ANENCY_CODE
		{
			get{ return _TENDER_ANENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_ANENCY_CODE, _TENDER_ANENCY_CODE, value);
				this._TENDER_ANENCY_CODE = value;
			}
		}
		/// <summary>
		/// 移送记录ID
		/// </summary>
		public string RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		[JsonIgnore]
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
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
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_CODE,
				_.TENDER_NAME,
				_.TENDER_CONTRACT,
				_.TENDER_AGENCY_NAME,
				_.TENDER_ANENCY_CODE,
				_.RECORD_ID,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_CODE,
				this._TENDER_NAME,
				this._TENDER_CONTRACT,
				this._TENDER_AGENCY_NAME,
				this._TENDER_ANENCY_CODE,
				this._RECORD_ID,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "JC_TRANS_PROJECT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "JC_TRANS_PROJECT", "ID");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "JC_TRANS_PROJECT", "招标项目名称");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JC_TRANS_PROJECT", "招标项目编号");
            /// <summary>
			/// 招标人
			/// </summary>
			public readonly static Field TENDER_NAME = new Field("TENDER_NAME", "JC_TRANS_PROJECT", "招标人");
            /// <summary>
			/// 招标联系人
			/// </summary>
			public readonly static Field TENDER_CONTRACT = new Field("TENDER_CONTRACT", "JC_TRANS_PROJECT", "招标联系人");
            /// <summary>
			/// 招标代理机构
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "JC_TRANS_PROJECT", "招标代理机构");
            /// <summary>
			/// 招标代理机构统一社会信用代码
			/// </summary>
			public readonly static Field TENDER_ANENCY_CODE = new Field("TENDER_ANENCY_CODE", "JC_TRANS_PROJECT", "招标代理机构统一社会信用代码");
            /// <summary>
			/// 移送记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "JC_TRANS_PROJECT", "移送记录ID");
            /// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JC_TRANS_PROJECT", "时间戳");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "JC_TRANS_PROJECT", "是否删除");
        }
        #endregion
	}
}