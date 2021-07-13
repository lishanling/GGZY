using System;
using System.Collections.Generic;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_WRITTEN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_WRITTEN")]
    [Serializable]
    public partial class RECORD_WRITTEN : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _WIN_UNIT_NAME;
		private string _WIN_UNIT_CODE;
		private string _WIN_UNIT_CREDIT_GRADE;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _BID_SECTION_CODE;

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
		/// 备案主表ID
		/// </summary>
		public decimal? RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 中标单位名称
		/// </summary>
		public string WIN_UNIT_NAME
		{
			get{ return _WIN_UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_UNIT_NAME, _WIN_UNIT_NAME, value);
				this._WIN_UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 中标单位代码
		/// </summary>
		public string WIN_UNIT_CODE
		{
			get{ return _WIN_UNIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_UNIT_CODE, _WIN_UNIT_CODE, value);
				this._WIN_UNIT_CODE = value;
			}
		}
		/// <summary>
		/// 中标单位使用的信用等级
		/// </summary>
		public string WIN_UNIT_CREDIT_GRADE
		{
			get{ return _WIN_UNIT_CREDIT_GRADE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_UNIT_CREDIT_GRADE, _WIN_UNIT_CREDIT_GRADE, value);
				this._WIN_UNIT_CREDIT_GRADE = value;
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
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 
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
				_.RECORD_ID,
				_.WIN_UNIT_NAME,
				_.WIN_UNIT_CODE,
				_.WIN_UNIT_CREDIT_GRADE,
				_.CREATE_TM,
				_.CREATOR,
				_.BID_SECTION_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._RECORD_ID,
				this._WIN_UNIT_NAME,
				this._WIN_UNIT_CODE,
				this._WIN_UNIT_CREDIT_GRADE,
				this._CREATE_TM,
				this._CREATOR,
				this._BID_SECTION_CODE,
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
			public readonly static Field All = new Field("*", "RECORD_WRITTEN");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_WRITTEN", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_WRITTEN", "备案主表ID");
            /// <summary>
			/// 中标单位名称
			/// </summary>
			public readonly static Field WIN_UNIT_NAME = new Field("WIN_UNIT_NAME", "RECORD_WRITTEN", "中标单位名称");
            /// <summary>
			/// 中标单位代码
			/// </summary>
			public readonly static Field WIN_UNIT_CODE = new Field("WIN_UNIT_CODE", "RECORD_WRITTEN", "中标单位代码");
            /// <summary>
			/// 中标单位使用的信用等级
			/// </summary>
			public readonly static Field WIN_UNIT_CREDIT_GRADE = new Field("WIN_UNIT_CREDIT_GRADE", "RECORD_WRITTEN", "中标单位使用的信用等级");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_WRITTEN", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_WRITTEN", "创建人");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "RECORD_WRITTEN", "");
        }
        #endregion
	}
}