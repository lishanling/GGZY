using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_ORGANQUAL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_ORGANQUAL")]
    [Serializable]
    public partial class T_ZT_ORGANQUAL : FwEntity
    {
        #region Model
		private string _ORGANNO;
		private string _QUALLEVEL;
		private string _QUALNAME;
		private string _QUALTYPE;
		private string _QUALCERTNO;
		private DateTime? _QUALCERTENDDATE;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string ORGANNO
		{
			get{ return _ORGANNO; }
			set
			{
				this.OnPropertyValueChange(_.ORGANNO, _ORGANNO, value);
				this._ORGANNO = value;
			}
		}
		/// <summary>
		/// 资质等级
		/// </summary>
		public string QUALLEVEL
		{
			get{ return _QUALLEVEL; }
			set
			{
				this.OnPropertyValueChange(_.QUALLEVEL, _QUALLEVEL, value);
				this._QUALLEVEL = value;
			}
		}
		/// <summary>
		/// 资质名称
		/// </summary>
		public string QUALNAME
		{
			get{ return _QUALNAME; }
			set
			{
				this.OnPropertyValueChange(_.QUALNAME, _QUALNAME, value);
				this._QUALNAME = value;
			}
		}
		/// <summary>
		/// 资质序列、行业和专业类别
		/// </summary>
		public string QUALTYPE
		{
			get{ return _QUALTYPE; }
			set
			{
				this.OnPropertyValueChange(_.QUALTYPE, _QUALTYPE, value);
				this._QUALTYPE = value;
			}
		}
		/// <summary>
		/// 资质证书编号
		/// </summary>
		public string QUALCERTNO
		{
			get{ return _QUALCERTNO; }
			set
			{
				this.OnPropertyValueChange(_.QUALCERTNO, _QUALCERTNO, value);
				this._QUALCERTNO = value;
			}
		}
		/// <summary>
		/// 资质证书失效日期
		/// </summary>
		public DateTime? QUALCERTENDDATE
		{
			get{ return _QUALCERTENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.QUALCERTENDDATE, _QUALCERTENDDATE, value);
				this._QUALCERTENDDATE = value;
			}
		}
		/// <summary>
		/// 来源平台编码
		/// </summary>
		public string DATASOURCECODE
		{
			get{ return _DATASOURCECODE; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCECODE, _DATASOURCECODE, value);
				this._DATASOURCECODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATATIMESTAMP
		{
			get{ return _DATATIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATATIMESTAMP, _DATATIMESTAMP, value);
				this._DATATIMESTAMP = value;
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
				_.ORGANNO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ORGANNO,
				_.QUALLEVEL,
				_.QUALNAME,
				_.QUALTYPE,
				_.QUALCERTNO,
				_.QUALCERTENDDATE,
				_.DATASOURCECODE,
				_.DATATIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ORGANNO,
				this._QUALLEVEL,
				this._QUALNAME,
				this._QUALTYPE,
				this._QUALCERTNO,
				this._QUALCERTENDDATE,
				this._DATASOURCECODE,
				this._DATATIMESTAMP,
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
			public readonly static Field All = new Field("*", "T_ZT_ORGANQUAL");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field ORGANNO = new Field("ORGANNO", "T_ZT_ORGANQUAL", "主体代码");
            /// <summary>
			/// 资质等级
			/// </summary>
			public readonly static Field QUALLEVEL = new Field("QUALLEVEL", "T_ZT_ORGANQUAL", "资质等级");
            /// <summary>
			/// 资质名称
			/// </summary>
			public readonly static Field QUALNAME = new Field("QUALNAME", "T_ZT_ORGANQUAL", "资质名称");
            /// <summary>
			/// 资质序列、行业和专业类别
			/// </summary>
			public readonly static Field QUALTYPE = new Field("QUALTYPE", "T_ZT_ORGANQUAL", "资质序列、行业和专业类别");
            /// <summary>
			/// 资质证书编号
			/// </summary>
			public readonly static Field QUALCERTNO = new Field("QUALCERTNO", "T_ZT_ORGANQUAL", "资质证书编号");
            /// <summary>
			/// 资质证书失效日期
			/// </summary>
			public readonly static Field QUALCERTENDDATE = new Field("QUALCERTENDDATE", "T_ZT_ORGANQUAL", "资质证书失效日期");
            /// <summary>
			/// 来源平台编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_ZT_ORGANQUAL", "来源平台编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_ZT_ORGANQUAL", "数据时间戳");
        }
        #endregion
	}
}