using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_RECORD_REGULATOR。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RECORD_REGULATOR")]
    [Serializable]
    public partial class T_RECORD_REGULATOR : JdEntity
    {
        #region Model
		private string _RCODE;
		private string _RNAME;
		private decimal? _LONGI;
		private decimal? _LATI;
		private string _ADDRESS;
		private string _REMARK;

		/// <summary>
		/// 监管部门编号
		/// </summary>
		public string RCODE
		{
			get{ return _RCODE; }
			set
			{
				this.OnPropertyValueChange(_.RCODE, _RCODE, value);
				this._RCODE = value;
			}
		}
		/// <summary>
		/// 监管部门名称
		/// </summary>
		public string RNAME
		{
			get{ return _RNAME; }
			set
			{
				this.OnPropertyValueChange(_.RNAME, _RNAME, value);
				this._RNAME = value;
			}
		}
		/// <summary>
		/// 经度
		/// </summary>
		public decimal? LONGI
		{
			get{ return _LONGI; }
			set
			{
				this.OnPropertyValueChange(_.LONGI, _LONGI, value);
				this._LONGI = value;
			}
		}
		/// <summary>
		/// 纬度
		/// </summary>
		public decimal? LATI
		{
			get{ return _LATI; }
			set
			{
				this.OnPropertyValueChange(_.LATI, _LATI, value);
				this._LATI = value;
			}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 备注
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
				_.RCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.RCODE,
				_.RNAME,
				_.LONGI,
				_.LATI,
				_.ADDRESS,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._RCODE,
				this._RNAME,
				this._LONGI,
				this._LATI,
				this._ADDRESS,
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
			public readonly static Field All = new Field("*", "T_RECORD_REGULATOR");
            /// <summary>
			/// 监管部门编号
			/// </summary>
			public readonly static Field RCODE = new Field("RCODE", "T_RECORD_REGULATOR", "监管部门编号");
            /// <summary>
			/// 监管部门名称
			/// </summary>
			public readonly static Field RNAME = new Field("RNAME", "T_RECORD_REGULATOR", "监管部门名称");
            /// <summary>
			/// 经度
			/// </summary>
			public readonly static Field LONGI = new Field("LONGI", "T_RECORD_REGULATOR", "经度");
            /// <summary>
			/// 纬度
			/// </summary>
			public readonly static Field LATI = new Field("LATI", "T_RECORD_REGULATOR", "纬度");
            /// <summary>
			/// 地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "T_RECORD_REGULATOR", "地址");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_RECORD_REGULATOR", "备注");
        }
        #endregion
	}
}