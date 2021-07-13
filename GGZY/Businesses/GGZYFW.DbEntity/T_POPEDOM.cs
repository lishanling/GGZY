using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_POPEDOM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_POPEDOM")]
    [Serializable]
    public partial class T_POPEDOM : FwEntity
    {
        #region Model
		private decimal? _POPID;
		private decimal? _MENUID;
		private decimal? _ROLEID;
		private string _REMARK;
		private string _CREATEID;
		private DateTime? _CREATETIME;

		/// <summary>
		/// 
		/// </summary>
		public decimal? POPID
		{
			get{ return _POPID; }
			set
			{
				this.OnPropertyValueChange(_.POPID, _POPID, value);
				this._POPID = value;
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
		public decimal? ROLEID
		{
			get{ return _ROLEID; }
			set
			{
				this.OnPropertyValueChange(_.ROLEID, _ROLEID, value);
				this._ROLEID = value;
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
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
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
				_.POPID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.POPID,
				_.MENUID,
				_.ROLEID,
				_.REMARK,
				_.CREATEID,
				_.CREATETIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._POPID,
				this._MENUID,
				this._ROLEID,
				this._REMARK,
				this._CREATEID,
				this._CREATETIME,
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
			public readonly static Field All = new Field("*", "T_POPEDOM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field POPID = new Field("POPID", "T_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MENUID = new Field("MENUID", "T_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ROLEID = new Field("ROLEID", "T_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "T_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_POPEDOM", "");
        }
        #endregion
	}
}