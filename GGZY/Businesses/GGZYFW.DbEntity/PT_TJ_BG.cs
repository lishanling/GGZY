using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PT_TJ_BG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_TJ_BG")]
    [Serializable]
    public partial class PT_TJ_BG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private DateTime? _TM;
		private decimal? _QUARTER;
		private decimal? _UPDATE_UID;
		private string _AREACODE;
		private DateTime? _CREATE_TM;
		private string _AID;

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
		/// 季度
		/// </summary>
		public decimal? QUARTER
		{
			get{ return _QUARTER; }
			set
			{
				this.OnPropertyValueChange(_.QUARTER, _QUARTER, value);
				this._QUARTER = value;
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
		/// 所属地区
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
		/// <summary>
		/// 上传报告
		/// </summary>
		public string AID
		{
			get{ return _AID; }
			set
			{
				this.OnPropertyValueChange(_.AID, _AID, value);
				this._AID = value;
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
				_.QUARTER,
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
				_.QUARTER,
				_.UPDATE_UID,
				_.AREACODE,
				_.CREATE_TM,
				_.AID,
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
				this._QUARTER,
				this._UPDATE_UID,
				this._AREACODE,
				this._CREATE_TM,
				this._AID,
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
			public readonly static Field All = new Field("*", "PT_TJ_BG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_TJ_BG", "");
            /// <summary>
			/// 年月
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_TJ_BG", "年月");
            /// <summary>
			/// 季度
			/// </summary>
			public readonly static Field QUARTER = new Field("QUARTER", "PT_TJ_BG", "季度");
            /// <summary>
			/// 上传人
			/// </summary>
			public readonly static Field UPDATE_UID = new Field("UPDATE_UID", "PT_TJ_BG", "上传人");
            /// <summary>
			/// 所属地区
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "PT_TJ_BG", "所属地区");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_TJ_BG", "创建时间");
            /// <summary>
			/// 上传报告
			/// </summary>
			public readonly static Field AID = new Field("AID", "PT_TJ_BG", "上传报告");
        }
        #endregion
	}
}