using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SSO_JYCENTER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SSO_JYCENTER")]
    [Serializable]
    public partial class T_SSO_JYCENTER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _SSO_INFO_ID;
		private string _JYNO;
		private decimal? _ORDERID;

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
		/// 交易平台ID
		/// </summary>
		public decimal? SSO_INFO_ID
		{
			get{ return _SSO_INFO_ID; }
			set
			{
				this.OnPropertyValueChange(_.SSO_INFO_ID, _SSO_INFO_ID, value);
				this._SSO_INFO_ID = value;
			}
		}
		/// <summary>
		/// 交易中心编号
		/// </summary>
		public string JYNO
		{
			get{ return _JYNO; }
			set
			{
				this.OnPropertyValueChange(_.JYNO, _JYNO, value);
				this._JYNO = value;
			}
		}
		/// <summary>
		/// ORDERID
		/// </summary>
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
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
				_.SSO_INFO_ID,
				_.JYNO,
				_.ORDERID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SSO_INFO_ID,
				this._JYNO,
				this._ORDERID,
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
			public readonly static Field All = new Field("*", "T_SSO_JYCENTER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SSO_JYCENTER", "ID");
            /// <summary>
			/// 交易平台ID
			/// </summary>
			public readonly static Field SSO_INFO_ID = new Field("SSO_INFO_ID", "T_SSO_JYCENTER", "交易平台ID");
            /// <summary>
			/// 交易中心编号
			/// </summary>
			public readonly static Field JYNO = new Field("JYNO", "T_SSO_JYCENTER", "交易中心编号");
            /// <summary>
			/// ORDERID
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "T_SSO_JYCENTER", "ORDERID");
        }
        #endregion
	}
}