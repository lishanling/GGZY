using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SERVICE_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SERVICE_LOG")]
    [Serializable]
    public partial class T_SERVICE_LOG : FwEntity
    {
        #region Model
		private DateTime? _TM;
		private string _RES;
		private string _SYSTEMCODE;
		private string _TABLENAME;
		private decimal? _ID;

		/// <summary>
		/// 时间
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
		/// 内容
		/// </summary>
		public string RES
		{
			get{ return _RES; }
			set
			{
				this.OnPropertyValueChange(_.RES, _RES, value);
				this._RES = value;
			}
		}
		/// <summary>
		/// 系统编码
		/// </summary>
		public string SYSTEMCODE
		{
			get{ return _SYSTEMCODE; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEMCODE, _SYSTEMCODE, value);
				this._SYSTEMCODE = value;
			}
		}
		/// <summary>
		/// 所属表表名
		/// </summary>
		public string TABLENAME
		{
			get{ return _TABLENAME; }
			set
			{
				this.OnPropertyValueChange(_.TABLENAME, _TABLENAME, value);
				this._TABLENAME = value;
			}
		}
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.TM,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TM,
				_.RES,
				_.SYSTEMCODE,
				_.TABLENAME,
				_.ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TM,
				this._RES,
				this._SYSTEMCODE,
				this._TABLENAME,
				this._ID,
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
			public readonly static Field All = new Field("*", "T_SERVICE_LOG");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_SERVICE_LOG", "时间");
            /// <summary>
			/// 内容
			/// </summary>
			public readonly static Field RES = new Field("RES", "T_SERVICE_LOG",DbType.AnsiString, null, "内容");
            /// <summary>
			/// 系统编码
			/// </summary>
			public readonly static Field SYSTEMCODE = new Field("SYSTEMCODE", "T_SERVICE_LOG", "系统编码");
            /// <summary>
			/// 所属表表名
			/// </summary>
			public readonly static Field TABLENAME = new Field("TABLENAME", "T_SERVICE_LOG", "所属表表名");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SERVICE_LOG", "");
        }
        #endregion
	}
}