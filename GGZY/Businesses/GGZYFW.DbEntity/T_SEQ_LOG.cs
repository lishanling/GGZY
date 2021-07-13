using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SEQ_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SEQ_LOG")]
    [Serializable]
    public partial class T_SEQ_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TB_NAME;
		private string _FNAME;
		private decimal? _VAL;
		private string _CUR_DATE;

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
		/// 字段名
		/// </summary>
		public string FNAME
		{
			get{ return _FNAME; }
			set
			{
				this.OnPropertyValueChange(_.FNAME, _FNAME, value);
				this._FNAME = value;
			}
		}
		/// <summary>
		/// 值
		/// </summary>
		public decimal? VAL
		{
			get{ return _VAL; }
			set
			{
				this.OnPropertyValueChange(_.VAL, _VAL, value);
				this._VAL = value;
			}
		}
		/// <summary>
		/// 当前日期(yyyyMMdd)
		/// </summary>
		public string CUR_DATE
		{
			get{ return _CUR_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CUR_DATE, _CUR_DATE, value);
				this._CUR_DATE = value;
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
				_.TB_NAME,
				_.FNAME,
				_.VAL,
				_.CUR_DATE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TB_NAME,
				this._FNAME,
				this._VAL,
				this._CUR_DATE,
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
			public readonly static Field All = new Field("*", "T_SEQ_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SEQ_LOG", "ID");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_SEQ_LOG", "表名");
            /// <summary>
			/// 字段名
			/// </summary>
			public readonly static Field FNAME = new Field("FNAME", "T_SEQ_LOG", "字段名");
            /// <summary>
			/// 值
			/// </summary>
			public readonly static Field VAL = new Field("VAL", "T_SEQ_LOG", "值");
            /// <summary>
			/// 当前日期(yyyyMMdd)
			/// </summary>
			public readonly static Field CUR_DATE = new Field("CUR_DATE", "T_SEQ_LOG", "当前日期(yyyyMMdd)");
        }
        #endregion
	}
}