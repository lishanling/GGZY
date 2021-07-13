using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类CREDIT_ASSESSMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("CREDIT_ASSESSMENT")]
    [Serializable]
    public partial class CREDIT_ASSESSMENT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _COMPANY_NAME;
		private string _CREDIT_SITUATION;
		private string _CREDIT_NOTE;
		private DateTime? _TIMES;
		private string _REMARKS;

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
		/// 企业名称
		/// </summary>
		public string COMPANY_NAME
		{
			get{ return _COMPANY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPANY_NAME, _COMPANY_NAME, value);
				this._COMPANY_NAME = value;
			}
		}
		/// <summary>
		/// 信用情况
		/// </summary>
		public string CREDIT_SITUATION
		{
			get{ return _CREDIT_SITUATION; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_SITUATION, _CREDIT_SITUATION, value);
				this._CREDIT_SITUATION = value;
			}
		}
		/// <summary>
		/// 信用说明
		/// </summary>
		public string CREDIT_NOTE
		{
			get{ return _CREDIT_NOTE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_NOTE, _CREDIT_NOTE, value);
				this._CREDIT_NOTE = value;
			}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? TIMES
		{
			get{ return _TIMES; }
			set
			{
				this.OnPropertyValueChange(_.TIMES, _TIMES, value);
				this._TIMES = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARKS
		{
			get{ return _REMARKS; }
			set
			{
				this.OnPropertyValueChange(_.REMARKS, _REMARKS, value);
				this._REMARKS = value;
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
				_.COMPANY_NAME,
				_.CREDIT_SITUATION,
				_.CREDIT_NOTE,
				_.TIMES,
				_.REMARKS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._COMPANY_NAME,
				this._CREDIT_SITUATION,
				this._CREDIT_NOTE,
				this._TIMES,
				this._REMARKS,
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
			public readonly static Field All = new Field("*", "CREDIT_ASSESSMENT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "CREDIT_ASSESSMENT", "ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANY_NAME = new Field("COMPANY_NAME", "CREDIT_ASSESSMENT", "企业名称");
            /// <summary>
			/// 信用情况
			/// </summary>
			public readonly static Field CREDIT_SITUATION = new Field("CREDIT_SITUATION", "CREDIT_ASSESSMENT", "信用情况");
            /// <summary>
			/// 信用说明
			/// </summary>
			public readonly static Field CREDIT_NOTE = new Field("CREDIT_NOTE", "CREDIT_ASSESSMENT", "信用说明");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TIMES = new Field("TIMES", "CREDIT_ASSESSMENT", "时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "CREDIT_ASSESSMENT", "备注");
        }
        #endregion
	}
}