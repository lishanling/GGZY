using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PT_TJ_MAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_TJ_MAIN")]
    [Serializable]
    public partial class PT_TJ_MAIN : FwEntity
    {
        #region Model
		private decimal? _ID;
		private DateTime? _TM;
		private string _AREACODE;
		private decimal? _UPDATE_UID;
		private decimal? _DATACOUNT;
		private string _FILEPATH;
		private DateTime? _CREATE_TM;

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
		/// 年月
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
		/// 行政级别
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 上传人
		/// </summary>
		public decimal? UPDATE_UID
		{
			get{ return _UPDATE_UID; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_UID, _UPDATE_UID, value);
				this._UPDATE_UID = value;
			}
		}
		/// <summary>
		/// 上传记录数
		/// </summary>
		public decimal? DATACOUNT
		{
			get{ return _DATACOUNT; }
			set
			{
				this.OnPropertyValueChange(_.DATACOUNT, _DATACOUNT, value);
				this._DATACOUNT = value;
			}
		}
		/// <summary>
		/// 文件路径
		/// </summary>
		public string FILEPATH
		{
			get{ return _FILEPATH; }
			set
			{
				this.OnPropertyValueChange(_.FILEPATH, _FILEPATH, value);
				this._FILEPATH = value;
			}
		}
		/// <summary>
		/// 创建时间
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.TM,
				_.AREACODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.TM,
				_.AREACODE,
				_.UPDATE_UID,
				_.DATACOUNT,
				_.FILEPATH,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TM,
				this._AREACODE,
				this._UPDATE_UID,
				this._DATACOUNT,
				this._FILEPATH,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "PT_TJ_MAIN");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_TJ_MAIN", "ID");
            /// <summary>
			/// 年月
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_TJ_MAIN", "年月");
            /// <summary>
			/// 行政级别
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "PT_TJ_MAIN", "行政级别");
            /// <summary>
			/// 上传人
			/// </summary>
			public readonly static Field UPDATE_UID = new Field("UPDATE_UID", "PT_TJ_MAIN", "上传人");
            /// <summary>
			/// 上传记录数
			/// </summary>
			public readonly static Field DATACOUNT = new Field("DATACOUNT", "PT_TJ_MAIN", "上传记录数");
            /// <summary>
			/// 文件路径
			/// </summary>
			public readonly static Field FILEPATH = new Field("FILEPATH", "PT_TJ_MAIN", "文件路径");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_TJ_MAIN", "创建时间");
        }
        #endregion
	}
}