using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER_URL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_URL")]
    [Serializable]
    public partial class T_USER_URL : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _MENUID;
		private string _URL;
		private string _PARAM;
		private string _POWER;
		private decimal? _IS_ENABLE;
		private string _REMARK;

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
		public decimal? MENUID
		{
			get{ return _MENUID; }
			set
			{
				this.OnPropertyValueChange(_.MENUID, _MENUID, value);
				this._MENUID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 格式为 TCID=123&amp;flag=add
		/// </summary>
		public string PARAM
		{
			get{ return _PARAM; }
			set
			{
				this.OnPropertyValueChange(_.PARAM, _PARAM, value);
				this._PARAM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string POWER
		{
			get{ return _POWER; }
			set
			{
				this.OnPropertyValueChange(_.POWER, _POWER, value);
				this._POWER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 
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
				_.MENUID,
				_.URL,
				_.PARAM,
				_.POWER,
				_.IS_ENABLE,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._MENUID,
				this._URL,
				this._PARAM,
				this._POWER,
				this._IS_ENABLE,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "T_USER_URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_URL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MENUID = new Field("MENUID", "T_USER_URL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_USER_URL", "");
            /// <summary>
			/// 格式为 TCID=123&amp;flag=add
			/// </summary>
			public readonly static Field PARAM = new Field("PARAM", "T_USER_URL", "格式为 TCID=123&amp;flag=add");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field POWER = new Field("POWER", "T_USER_URL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "T_USER_URL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_USER_URL", "");
        }
        #endregion
	}
}