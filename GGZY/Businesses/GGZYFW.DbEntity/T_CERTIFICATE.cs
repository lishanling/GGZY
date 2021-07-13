using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_CERTIFICATE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_CERTIFICATE")]
    [Serializable]
    public partial class T_CERTIFICATE : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _CODE;
		private string _NAME;
		private string _TYPE;
		private string _ZSTGS;
		private string _RZJG;
		private DateTime? _YXQ;
		private decimal? _M_F_ID;

		/// <summary>
		/// M_ID
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
		/// 证书编号
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 证书名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 证书类型
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 证书提供商
		/// </summary>
		public string ZSTGS
		{
			get{ return _ZSTGS; }
			set
			{
				this.OnPropertyValueChange(_.ZSTGS, _ZSTGS, value);
				this._ZSTGS = value;
			}
		}
		/// <summary>
		/// 证书认证机构
		/// </summary>
		public string RZJG
		{
			get{ return _RZJG; }
			set
			{
				this.OnPropertyValueChange(_.RZJG, _RZJG, value);
				this._RZJG = value;
			}
		}
		/// <summary>
		/// 证书有效期
		/// </summary>
		public DateTime? YXQ
		{
			get{ return _YXQ; }
			set
			{
				this.OnPropertyValueChange(_.YXQ, _YXQ, value);
				this._YXQ = value;
			}
		}
		/// <summary>
		/// 法人信息关联ID
		/// </summary>
		public decimal? M_F_ID
		{
			get{ return _M_F_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_F_ID, _M_F_ID, value);
				this._M_F_ID = value;
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
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.M_ID,
				_.CODE,
				_.NAME,
				_.TYPE,
				_.ZSTGS,
				_.RZJG,
				_.YXQ,
				_.M_F_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._CODE,
				this._NAME,
				this._TYPE,
				this._ZSTGS,
				this._RZJG,
				this._YXQ,
				this._M_F_ID,
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
			public readonly static Field All = new Field("*", "T_CERTIFICATE");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "T_CERTIFICATE", "M_ID");
            /// <summary>
			/// 证书编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_CERTIFICATE", "证书编号");
            /// <summary>
			/// 证书名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_CERTIFICATE", "证书名称");
            /// <summary>
			/// 证书类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_CERTIFICATE", "证书类型");
            /// <summary>
			/// 证书提供商
			/// </summary>
			public readonly static Field ZSTGS = new Field("ZSTGS", "T_CERTIFICATE", "证书提供商");
            /// <summary>
			/// 证书认证机构
			/// </summary>
			public readonly static Field RZJG = new Field("RZJG", "T_CERTIFICATE", "证书认证机构");
            /// <summary>
			/// 证书有效期
			/// </summary>
			public readonly static Field YXQ = new Field("YXQ", "T_CERTIFICATE", "证书有效期");
            /// <summary>
			/// 法人信息关联ID
			/// </summary>
			public readonly static Field M_F_ID = new Field("M_F_ID", "T_CERTIFICATE", "法人信息关联ID");
        }
        #endregion
	}
}