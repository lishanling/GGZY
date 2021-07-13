using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_TUISONG_TOTAL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TUISONG_TOTAL")]
    [Serializable]
    public partial class T_TUISONG_TOTAL : JdEntity
    {
        #region Model
		private string _GUID;
		private decimal? _COUNT;
		private DateTime? _CREATETIME;
		private string _TABLENAME;

		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COUNT
		{
			get{ return _COUNT; }
			set
			{
				this.OnPropertyValueChange(_.COUNT, _COUNT, value);
				this._COUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.GUID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.GUID,
				_.COUNT,
				_.CREATETIME,
				_.TABLENAME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._GUID,
				this._COUNT,
				this._CREATETIME,
				this._TABLENAME,
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
			public readonly static Field All = new Field("*", "T_TUISONG_TOTAL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_TUISONG_TOTAL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COUNT = new Field("COUNT", "T_TUISONG_TOTAL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_TUISONG_TOTAL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLENAME = new Field("TABLENAME", "T_TUISONG_TOTAL", "");
        }
        #endregion
	}
}