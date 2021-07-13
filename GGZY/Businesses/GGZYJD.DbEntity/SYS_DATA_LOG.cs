using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_DATA_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_DATA_LOG")]
    [Serializable]
    public partial class SYS_DATA_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _TB_NAME;
		private string _KEY_FIELD;
		private string _KEY_VALUE;
		private string _OPERATION;
		private string _REMARK;
		private DateTime? _TM;

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
		/// 操作人
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
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
		/// 主键字段
		/// </summary>
		public string KEY_FIELD
		{
			get{ return _KEY_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.KEY_FIELD, _KEY_FIELD, value);
				this._KEY_FIELD = value;
			}
		}
		/// <summary>
		/// 主键值
		/// </summary>
		public string KEY_VALUE
		{
			get{ return _KEY_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.KEY_VALUE, _KEY_VALUE, value);
				this._KEY_VALUE = value;
			}
		}
		/// <summary>
		/// 操作
		/// </summary>
		public string OPERATION
		{
			get{ return _OPERATION; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION, _OPERATION, value);
				this._OPERATION = value;
			}
		}
		/// <summary>
		/// 说明
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 操作时间
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
				_.U_ID,
				_.TB_NAME,
				_.KEY_FIELD,
				_.KEY_VALUE,
				_.OPERATION,
				_.REMARK,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._U_ID,
				this._TB_NAME,
				this._KEY_FIELD,
				this._KEY_VALUE,
				this._OPERATION,
				this._REMARK,
				this._TM,
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
			public readonly static Field All = new Field("*", "SYS_DATA_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_DATA_LOG", "ID");
            /// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "SYS_DATA_LOG", "操作人");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "SYS_DATA_LOG", "表名");
            /// <summary>
			/// 主键字段
			/// </summary>
			public readonly static Field KEY_FIELD = new Field("KEY_FIELD", "SYS_DATA_LOG", "主键字段");
            /// <summary>
			/// 主键值
			/// </summary>
			public readonly static Field KEY_VALUE = new Field("KEY_VALUE", "SYS_DATA_LOG", "主键值");
            /// <summary>
			/// 操作
			/// </summary>
			public readonly static Field OPERATION = new Field("OPERATION", "SYS_DATA_LOG", "操作");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_DATA_LOG", "说明");
            /// <summary>
			/// 操作时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "SYS_DATA_LOG", "操作时间");
        }
        #endregion
	}
}