using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_PUBLICTYPEINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_PUBLICTYPEINFO")]
    [Serializable]
    public partial class SYS_PUBLICTYPEINFO : FwEntity
    {
        #region Model
		private decimal? _PTIID;
		private decimal? _PARENTTYPEID;
		private decimal? _SIGN;
		private string _TYPENAME;
		private string _TYPEVALUE;
		private string _TYPEVALUE2;
		private string _ISDEL;
		private string _ISENABLE;
		private decimal? _ORDERID;
		private string _REMARK;
		private string _CREATEID;
		private decimal? _ISFORUSER;

		/// <summary>
		/// 
		/// </summary>
		public decimal? PTIID
		{
			get{ return _PTIID; }
			set
			{
				this.OnPropertyValueChange(_.PTIID, _PTIID, value);
				this._PTIID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PARENTTYPEID
		{
			get{ return _PARENTTYPEID; }
			set
			{
				this.OnPropertyValueChange(_.PARENTTYPEID, _PARENTTYPEID, value);
				this._PARENTTYPEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SIGN
		{
			get{ return _SIGN; }
			set
			{
				this.OnPropertyValueChange(_.SIGN, _SIGN, value);
				this._SIGN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPENAME
		{
			get{ return _TYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.TYPENAME, _TYPENAME, value);
				this._TYPENAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPEVALUE
		{
			get{ return _TYPEVALUE; }
			set
			{
				this.OnPropertyValueChange(_.TYPEVALUE, _TYPEVALUE, value);
				this._TYPEVALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPEVALUE2
		{
			get{ return _TYPEVALUE2; }
			set
			{
				this.OnPropertyValueChange(_.TYPEVALUE2, _TYPEVALUE2, value);
				this._TYPEVALUE2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISDEL
		{
			get{ return _ISDEL; }
			set
			{
				this.OnPropertyValueChange(_.ISDEL, _ISDEL, value);
				this._ISDEL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISENABLE
		{
			get{ return _ISENABLE; }
			set
			{
				this.OnPropertyValueChange(_.ISENABLE, _ISENABLE, value);
				this._ISENABLE = value;
			}
		}
		/// <summary>
		/// 
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
		/// <summary>
		/// 
		/// </summary>
		public string CREATEID
		{
			get{ return _CREATEID; }
			set
			{
				this.OnPropertyValueChange(_.CREATEID, _CREATEID, value);
				this._CREATEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISFORUSER
		{
			get{ return _ISFORUSER; }
			set
			{
				this.OnPropertyValueChange(_.ISFORUSER, _ISFORUSER, value);
				this._ISFORUSER = value;
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
				_.PTIID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PTIID,
				_.PARENTTYPEID,
				_.SIGN,
				_.TYPENAME,
				_.TYPEVALUE,
				_.TYPEVALUE2,
				_.ISDEL,
				_.ISENABLE,
				_.ORDERID,
				_.REMARK,
				_.CREATEID,
				_.ISFORUSER,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PTIID,
				this._PARENTTYPEID,
				this._SIGN,
				this._TYPENAME,
				this._TYPEVALUE,
				this._TYPEVALUE2,
				this._ISDEL,
				this._ISENABLE,
				this._ORDERID,
				this._REMARK,
				this._CREATEID,
				this._ISFORUSER,
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
			public readonly static Field All = new Field("*", "SYS_PUBLICTYPEINFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PTIID = new Field("PTIID", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PARENTTYPEID = new Field("PARENTTYPEID", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SIGN = new Field("SIGN", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPENAME = new Field("TYPENAME", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPEVALUE = new Field("TYPEVALUE", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPEVALUE2 = new Field("TYPEVALUE2", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISDEL = new Field("ISDEL", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISENABLE = new Field("ISENABLE", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "SYS_PUBLICTYPEINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISFORUSER = new Field("ISFORUSER", "SYS_PUBLICTYPEINFO", "");
        }
        #endregion
	}
}