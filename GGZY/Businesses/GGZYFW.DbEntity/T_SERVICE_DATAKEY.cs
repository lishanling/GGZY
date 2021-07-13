using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SERVICE_DATAKEY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SERVICE_DATAKEY")]
    [Serializable]
    public partial class T_SERVICE_DATAKEY : FwEntity
    {
        #region Model
		private DateTime? _TM;
		private string _DATA_KEY;
		private string _TABLENAME;
		private string _TRADEPLATFORM_ID;

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
		/// 数据唯一标识码
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
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
		/// 交易平台id
		/// </summary>
		public string TRADEPLATFORM_ID
		{
			get{ return _TRADEPLATFORM_ID; }
			set
			{
				this.OnPropertyValueChange(_.TRADEPLATFORM_ID, _TRADEPLATFORM_ID, value);
				this._TRADEPLATFORM_ID = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TM,
				_.DATA_KEY,
				_.TABLENAME,
				_.TRADEPLATFORM_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TM,
				this._DATA_KEY,
				this._TABLENAME,
				this._TRADEPLATFORM_ID,
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
			public readonly static Field All = new Field("*", "T_SERVICE_DATAKEY");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_SERVICE_DATAKEY", "时间");
            /// <summary>
			/// 数据唯一标识码
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_SERVICE_DATAKEY", "数据唯一标识码");
            /// <summary>
			/// 所属表表名
			/// </summary>
			public readonly static Field TABLENAME = new Field("TABLENAME", "T_SERVICE_DATAKEY", "所属表表名");
            /// <summary>
			/// 交易平台id
			/// </summary>
			public readonly static Field TRADEPLATFORM_ID = new Field("TRADEPLATFORM_ID", "T_SERVICE_DATAKEY", "交易平台id");
        }
        #endregion
	}
}