using System;
using System.Data;
using Dos.ORM;
using Newtonsoft.Json;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JC_TRANS_ENTITY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JC_TRANS_ENTITY")]
    [Serializable]
    public partial class JC_TRANS_ENTITY : JdEntity
    {
        #region Model
		private string _ID;
		private string _ENTITY_NAME;
		private string _ENTITY_CODE;
		private decimal? _ENTITY_TYPE;
		private string _REGION_CODE;
		private string _REGION_NAME;
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
		/// 企业名称
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
		/// 企业代码
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
		/// 主体类型 1:招标人 2：代理机构 3：投标人
		/// </summary>
		public decimal? ENTITY_TYPE
		{
			get{ return _ENTITY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_TYPE, _ENTITY_TYPE, value);
				this._ENTITY_TYPE = value;
			}
		}
		/// <summary>
		/// 所在地区编码
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 所在地区
		/// </summary>
		public string REGION_NAME
		{
			get{ return _REGION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.REGION_NAME, _REGION_NAME, value);
				this._REGION_NAME = value;
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
				_.ENTITY_NAME,
				_.ENTITY_CODE,
				_.ENTITY_TYPE,
				_.REGION_CODE,
				_.REGION_NAME,
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
				this._ENTITY_NAME,
				this._ENTITY_CODE,
				this._ENTITY_TYPE,
				this._REGION_CODE,
				this._REGION_NAME,
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
			public readonly static Field All = new Field("*", "JC_TRANS_ENTITY");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "JC_TRANS_ENTITY", "ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field ENTITY_NAME = new Field("ENTITY_NAME", "JC_TRANS_ENTITY", "企业名称");
            /// <summary>
			/// 企业代码
			/// </summary>
			public readonly static Field ENTITY_CODE = new Field("ENTITY_CODE", "JC_TRANS_ENTITY", "企业代码");
            /// <summary>
			/// 主体类型 1:招标人 2：代理机构 3：投标人
			/// </summary>
			public readonly static Field ENTITY_TYPE = new Field("ENTITY_TYPE", "JC_TRANS_ENTITY", "主体类型 1:招标人 2：代理机构 3：投标人");
            /// <summary>
			/// 所在地区编码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "JC_TRANS_ENTITY", "所在地区编码");
            /// <summary>
			/// 所在地区
			/// </summary>
			public readonly static Field REGION_NAME = new Field("REGION_NAME", "JC_TRANS_ENTITY", "所在地区");
            /// <summary>
			/// 移送记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "JC_TRANS_ENTITY", "移送记录ID");
            /// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JC_TRANS_ENTITY", "时间戳");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "JC_TRANS_ENTITY", "是否删除");
        }
        #endregion
	}
}