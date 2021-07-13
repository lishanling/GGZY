using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_CA_PLOY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_CA_PLOY")]
    [Serializable]
    public partial class T_CA_PLOY : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _CA_ID;
		private string _ATTRIBUTES_NAME;
		private string _ZSX_TYPE;
		private string _ZSX;

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
		/// CA_ID
		/// </summary>
		public decimal? CA_ID
		{
			get{ return _CA_ID; }
			set
			{
				this.OnPropertyValueChange(_.CA_ID, _CA_ID, value);
				this._CA_ID = value;
			}
		}
		/// <summary>
		/// 属性名
		/// </summary>
		public string ATTRIBUTES_NAME
		{
			get{ return _ATTRIBUTES_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTRIBUTES_NAME, _ATTRIBUTES_NAME, value);
				this._ATTRIBUTES_NAME = value;
			}
		}
		/// <summary>
		/// 证书项类型
		/// </summary>
		public string ZSX_TYPE
		{
			get{ return _ZSX_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ZSX_TYPE, _ZSX_TYPE, value);
				this._ZSX_TYPE = value;
			}
		}
		/// <summary>
		/// 证书项
		/// </summary>
		public string ZSX
		{
			get{ return _ZSX; }
			set
			{
				this.OnPropertyValueChange(_.ZSX, _ZSX, value);
				this._ZSX = value;
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
				_.CA_ID,
				_.ATTRIBUTES_NAME,
				_.ZSX_TYPE,
				_.ZSX,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CA_ID,
				this._ATTRIBUTES_NAME,
				this._ZSX_TYPE,
				this._ZSX,
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
			public readonly static Field All = new Field("*", "T_CA_PLOY");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_CA_PLOY", "ID");
            /// <summary>
			/// CA_ID
			/// </summary>
			public readonly static Field CA_ID = new Field("CA_ID", "T_CA_PLOY", "CA_ID");
            /// <summary>
			/// 属性名
			/// </summary>
			public readonly static Field ATTRIBUTES_NAME = new Field("ATTRIBUTES_NAME", "T_CA_PLOY", "属性名");
            /// <summary>
			/// 证书项类型
			/// </summary>
			public readonly static Field ZSX_TYPE = new Field("ZSX_TYPE", "T_CA_PLOY", "证书项类型");
            /// <summary>
			/// 证书项
			/// </summary>
			public readonly static Field ZSX = new Field("ZSX", "T_CA_PLOY", "证书项");
        }
        #endregion
	}
}