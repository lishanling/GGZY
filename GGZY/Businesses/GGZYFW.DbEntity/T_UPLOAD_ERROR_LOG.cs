using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_UPLOAD_ERROR_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_UPLOAD_ERROR_LOG")]
    [Serializable]
    public partial class T_UPLOAD_ERROR_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _M_ID;
		private string _TB_NAME;
		private string _DATA_KEY;
		private DateTime? _CREATE_TM;

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
		/// 
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.M_ID,
				_.TB_NAME,
				_.DATA_KEY,
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
				this._M_ID,
				this._TB_NAME,
				this._DATA_KEY,
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
			public readonly static Field All = new Field("*", "T_UPLOAD_ERROR_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_UPLOAD_ERROR_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "T_UPLOAD_ERROR_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_UPLOAD_ERROR_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_UPLOAD_ERROR_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_UPLOAD_ERROR_LOG", "");
        }
        #endregion
	}
}