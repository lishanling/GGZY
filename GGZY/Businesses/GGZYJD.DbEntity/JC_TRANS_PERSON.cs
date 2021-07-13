using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JC_TRANS_PERSON。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JC_TRANS_PERSON")]
    [Serializable]
    public partial class JC_TRANS_PERSON : JdEntity
    {
        #region Model
		private string _ID;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _PERSON_NAME;
		private string _ENTITY_CODE;
		private string _ENTITY_NAME;
		private string _RECORD_ID;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;

		/// <summary>
		/// 
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
		/// 公职人员姓名
		/// </summary>
		public string PERSON_NAME
		{
			get{ return _PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_NAME, _PERSON_NAME, value);
				this._PERSON_NAME = value;
			}
		}
		/// <summary>
		/// 所在单位统一社会信用代码
		/// </summary>
		public string ENTITY_CODE
		{
			get{ return _ENTITY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_CODE, _ENTITY_CODE, value);
				this._ENTITY_CODE = value;
			}
		}
		/// <summary>
		/// 所在单位名称
		/// </summary>
		public string ENTITY_NAME
		{
			get{ return _ENTITY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_NAME, _ENTITY_NAME, value);
				this._ENTITY_NAME = value;
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
				_.PERSON_NAME,
				_.ENTITY_CODE,
				_.ENTITY_NAME,
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
				this._PERSON_NAME,
				this._ENTITY_CODE,
				this._ENTITY_NAME,
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
			public readonly static Field All = new Field("*", "JC_TRANS_PERSON");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "JC_TRANS_PERSON", "");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "JC_TRANS_PERSON", "招标项目名称");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JC_TRANS_PERSON", "招标项目编号");
            /// <summary>
			/// 公职人员姓名
			/// </summary>
			public readonly static Field PERSON_NAME = new Field("PERSON_NAME", "JC_TRANS_PERSON", "公职人员姓名");
            /// <summary>
			/// 所在单位统一社会信用代码
			/// </summary>
			public readonly static Field ENTITY_CODE = new Field("ENTITY_CODE", "JC_TRANS_PERSON", "所在单位统一社会信用代码");
            /// <summary>
			/// 所在单位名称
			/// </summary>
			public readonly static Field ENTITY_NAME = new Field("ENTITY_NAME", "JC_TRANS_PERSON", "所在单位名称");
            /// <summary>
			/// 移送记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "JC_TRANS_PERSON", "移送记录ID");
            /// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JC_TRANS_PERSON", "时间戳");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "JC_TRANS_PERSON", "是否删除");
        }
        #endregion
	}
}