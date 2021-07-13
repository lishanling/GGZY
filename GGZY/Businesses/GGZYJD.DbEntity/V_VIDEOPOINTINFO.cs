using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类V_VIDEOPOINTINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("V_VIDEOPOINTINFO")]
    [Serializable]
    public partial class V_VIDEOPOINTINFO : JdEntity
    {
        #region Model
		private decimal? _ENNMCD;
		private decimal? _CAMERAID;
		private decimal? _CHANNEL;
		private decimal? _DEVICEID;
		private string _DEVICETYPE;
		private string _ITEMNAME;
		private string _ITEMTYPE;
		private string _PARENTITEMID;
		private decimal? _PLATFORMID;
		private decimal? _ACTIVE;
		private decimal? _STATUS;

		/// <summary>
		/// 主表id
		/// </summary>
		public decimal? ENNMCD
		{
			get{ return _ENNMCD; }
			set
			{
				this.OnPropertyValueChange(_.ENNMCD, _ENNMCD, value);
				this._ENNMCD = value;
			}
		}
		/// <summary>
		/// 通道id
		/// </summary>
		public decimal? CAMERAID
		{
			get{ return _CAMERAID; }
			set
			{
				this.OnPropertyValueChange(_.CAMERAID, _CAMERAID, value);
				this._CAMERAID = value;
			}
		}
		/// <summary>
		/// （暂时无用）
		/// </summary>
		public decimal? CHANNEL
		{
			get{ return _CHANNEL; }
			set
			{
				this.OnPropertyValueChange(_.CHANNEL, _CHANNEL, value);
				this._CHANNEL = value;
			}
		}
		/// <summary>
		/// 排序id
		/// </summary>
		public decimal? DEVICEID
		{
			get{ return _DEVICEID; }
			set
			{
				this.OnPropertyValueChange(_.DEVICEID, _DEVICEID, value);
				this._DEVICEID = value;
			}
		}
		/// <summary>
		/// 通道类型
		/// </summary>
		public string DEVICETYPE
		{
			get{ return _DEVICETYPE; }
			set
			{
				this.OnPropertyValueChange(_.DEVICETYPE, _DEVICETYPE, value);
				this._DEVICETYPE = value;
			}
		}
		/// <summary>
		/// 通道名称
		/// </summary>
		public string ITEMNAME
		{
			get{ return _ITEMNAME; }
			set
			{
				this.OnPropertyValueChange(_.ITEMNAME, _ITEMNAME, value);
				this._ITEMNAME = value;
			}
		}
		/// <summary>
		/// 通道类型（暂时无用）
		/// </summary>
		public string ITEMTYPE
		{
			get{ return _ITEMTYPE; }
			set
			{
				this.OnPropertyValueChange(_.ITEMTYPE, _ITEMTYPE, value);
				this._ITEMTYPE = value;
			}
		}
		/// <summary>
		/// （暂时无用）
		/// </summary>
		public string PARENTITEMID
		{
			get{ return _PARENTITEMID; }
			set
			{
				this.OnPropertyValueChange(_.PARENTITEMID, _PARENTITEMID, value);
				this._PARENTITEMID = value;
			}
		}
		/// <summary>
		/// （暂时无用）
		/// </summary>
		public decimal? PLATFORMID
		{
			get{ return _PLATFORMID; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORMID, _PLATFORMID, value);
				this._PLATFORMID = value;
			}
		}
		/// <summary>
		/// （暂时无用）
		/// </summary>
		public decimal? ACTIVE
		{
			get{ return _ACTIVE; }
			set
			{
				this.OnPropertyValueChange(_.ACTIVE, _ACTIVE, value);
				this._ACTIVE = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
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
				_.ENNMCD,
				_.CAMERAID,
				_.CHANNEL,
				_.DEVICEID,
				_.DEVICETYPE,
				_.ITEMNAME,
				_.ITEMTYPE,
				_.PARENTITEMID,
				_.PLATFORMID,
				_.ACTIVE,
				_.STATUS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ENNMCD,
				this._CAMERAID,
				this._CHANNEL,
				this._DEVICEID,
				this._DEVICETYPE,
				this._ITEMNAME,
				this._ITEMTYPE,
				this._PARENTITEMID,
				this._PLATFORMID,
				this._ACTIVE,
				this._STATUS,
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
			public readonly static Field All = new Field("*", "V_VIDEOPOINTINFO");
            /// <summary>
			/// 主表id
			/// </summary>
			public readonly static Field ENNMCD = new Field("ENNMCD", "V_VIDEOPOINTINFO", "主表id");
            /// <summary>
			/// 通道id
			/// </summary>
			public readonly static Field CAMERAID = new Field("CAMERAID", "V_VIDEOPOINTINFO", "通道id");
            /// <summary>
			/// （暂时无用）
			/// </summary>
			public readonly static Field CHANNEL = new Field("CHANNEL", "V_VIDEOPOINTINFO", "（暂时无用）");
            /// <summary>
			/// 排序id
			/// </summary>
			public readonly static Field DEVICEID = new Field("DEVICEID", "V_VIDEOPOINTINFO", "排序id");
            /// <summary>
			/// 通道类型
			/// </summary>
			public readonly static Field DEVICETYPE = new Field("DEVICETYPE", "V_VIDEOPOINTINFO", "通道类型");
            /// <summary>
			/// 通道名称
			/// </summary>
			public readonly static Field ITEMNAME = new Field("ITEMNAME", "V_VIDEOPOINTINFO", "通道名称");
            /// <summary>
			/// 通道类型（暂时无用）
			/// </summary>
			public readonly static Field ITEMTYPE = new Field("ITEMTYPE", "V_VIDEOPOINTINFO", "通道类型（暂时无用）");
            /// <summary>
			/// （暂时无用）
			/// </summary>
			public readonly static Field PARENTITEMID = new Field("PARENTITEMID", "V_VIDEOPOINTINFO", "（暂时无用）");
            /// <summary>
			/// （暂时无用）
			/// </summary>
			public readonly static Field PLATFORMID = new Field("PLATFORMID", "V_VIDEOPOINTINFO", "（暂时无用）");
            /// <summary>
			/// （暂时无用）
			/// </summary>
			public readonly static Field ACTIVE = new Field("ACTIVE", "V_VIDEOPOINTINFO", "（暂时无用）");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "V_VIDEOPOINTINFO", "是否启用");
        }
        #endregion
	}
}