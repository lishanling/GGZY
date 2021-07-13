using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_PRACTICEQUAL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_PRACTICEQUAL")]
    [Serializable]
    public partial class T_ZT_PRACTICEQUAL : FwEntity
    {
        #region Model
		private string _QUALNAME;
		private string _QUALTYPE;
		private string _IDCARD;
		private string _IDCARDTYPE;
		private string _CERTNO;
		private DateTime? _CERTENDDATE;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 执业资格名称
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
		/// 执业资格类型
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
		/// 执业人员证件号
		/// </summary>
		public string IDCARD
		{
			get{ return _IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.IDCARD, _IDCARD, value);
				this._IDCARD = value;
			}
		}
		/// <summary>
		/// 执业人员身份证件类型
		/// </summary>
		public string IDCARDTYPE
		{
			get{ return _IDCARDTYPE; }
			set
			{
				this.OnPropertyValueChange(_.IDCARDTYPE, _IDCARDTYPE, value);
				this._IDCARDTYPE = value;
			}
		}
		/// <summary>
		/// 执业资格证书编号
		/// </summary>
		public string CERTNO
		{
			get{ return _CERTNO; }
			set
			{
				this.OnPropertyValueChange(_.CERTNO, _CERTNO, value);
				this._CERTNO = value;
			}
		}
		/// <summary>
		/// 执业资格注册有效期止
		/// </summary>
		public DateTime? CERTENDDATE
		{
			get{ return _CERTENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.CERTENDDATE, _CERTENDDATE, value);
				this._CERTENDDATE = value;
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
				_.IDCARD,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.QUALNAME,
				_.QUALTYPE,
				_.IDCARD,
				_.IDCARDTYPE,
				_.CERTNO,
				_.CERTENDDATE,
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
				this._QUALNAME,
				this._QUALTYPE,
				this._IDCARD,
				this._IDCARDTYPE,
				this._CERTNO,
				this._CERTENDDATE,
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
			public readonly static Field All = new Field("*", "T_ZT_PRACTICEQUAL");
            /// <summary>
			/// 执业资格名称
			/// </summary>
			public readonly static Field QUALNAME = new Field("QUALNAME", "T_ZT_PRACTICEQUAL", "执业资格名称");
            /// <summary>
			/// 执业资格类型
			/// </summary>
			public readonly static Field QUALTYPE = new Field("QUALTYPE", "T_ZT_PRACTICEQUAL", "执业资格类型");
            /// <summary>
			/// 执业人员证件号
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "T_ZT_PRACTICEQUAL", "执业人员证件号");
            /// <summary>
			/// 执业人员身份证件类型
			/// </summary>
			public readonly static Field IDCARDTYPE = new Field("IDCARDTYPE", "T_ZT_PRACTICEQUAL", "执业人员身份证件类型");
            /// <summary>
			/// 执业资格证书编号
			/// </summary>
			public readonly static Field CERTNO = new Field("CERTNO", "T_ZT_PRACTICEQUAL", "执业资格证书编号");
            /// <summary>
			/// 执业资格注册有效期止
			/// </summary>
			public readonly static Field CERTENDDATE = new Field("CERTENDDATE", "T_ZT_PRACTICEQUAL", "执业资格注册有效期止");
            /// <summary>
			/// 来源平台编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_ZT_PRACTICEQUAL", "来源平台编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_ZT_PRACTICEQUAL", "数据时间戳");
        }
        #endregion
	}
}