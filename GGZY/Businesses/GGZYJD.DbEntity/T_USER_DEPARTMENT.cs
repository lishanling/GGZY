using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_DEPARTMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_DEPARTMENT")]
    [Serializable]
    public partial class T_USER_DEPARTMENT : JdEntity
    {
        #region Model
		private decimal? _DEPID;
		private string _DNAME;
		private string _AREACODE;
		private decimal? _PARENTID;
		private string _DREMARK;
		private decimal? _LONGI;
		private decimal? _LATI;
		private string _DTYPE;
		private string _ORGPROPERTY;
		private decimal? _ORDERID;
		private string _DEPCODE;
		private decimal? _ISCK;
		private decimal? _CKID;
		private string _KINDS;
		private decimal? _ISALLKIND;
		private string _OTHERIDS;
		private string _DCODE;
		private decimal? _ISBJ;
		private decimal? _ISBA;
		private string _PHONE;
		private string _JGBM;
		private string _DADDRESS;
		private decimal? _ISTS;
		private string _HY_TYPE;

		/// <summary>
		/// 单位ID
		/// </summary>
		public decimal? DEPID
		{
			get{ return _DEPID; }
			set
			{
				this.OnPropertyValueChange(_.DEPID, _DEPID, value);
				this._DEPID = value;
			}
		}
		/// <summary>
		/// 单位名称
		/// </summary>
		public string DNAME
		{
			get{ return _DNAME; }
			set
			{
				this.OnPropertyValueChange(_.DNAME, _DNAME, value);
				this._DNAME = value;
			}
		}
		/// <summary>
		/// 地区编码
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 上级单位
		/// </summary>
		public decimal? PARENTID
		{
			get{ return _PARENTID; }
			set
			{
				this.OnPropertyValueChange(_.PARENTID, _PARENTID, value);
				this._PARENTID = value;
			}
		}
		/// <summary>
		/// 单位备注
		/// </summary>
		public string DREMARK
		{
			get{ return _DREMARK; }
			set
			{
				this.OnPropertyValueChange(_.DREMARK, _DREMARK, value);
				this._DREMARK = value;
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
        /// 单位类型 1 2 3 4
        /// 1科室2办公司 3纪委监委4公安
		/// </summary>
		public string DTYPE
		{
			get{ return _DTYPE; }
			set
			{
				this.OnPropertyValueChange(_.DTYPE, _DTYPE, value);
				this._DTYPE = value;
			}
		}
		/// <summary>
		/// 组织属性
		/// </summary>
		public string ORGPROPERTY
		{
			get{ return _ORGPROPERTY; }
			set
			{
				this.OnPropertyValueChange(_.ORGPROPERTY, _ORGPROPERTY, value);
				this._ORGPROPERTY = value;
			}
		}
		/// <summary>
		/// 排序号
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
		/// 组织机构编码
		/// </summary>
		public string DEPCODE
		{
			get{ return _DEPCODE; }
			set
			{
				this.OnPropertyValueChange(_.DEPCODE, _DEPCODE, value);
				this._DEPCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISCK
		{
			get{ return _ISCK; }
			set
			{
				this.OnPropertyValueChange(_.ISCK, _ISCK, value);
				this._ISCK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CKID
		{
			get{ return _CKID; }
			set
			{
				this.OnPropertyValueChange(_.CKID, _CKID, value);
				this._CKID = value;
			}
		}
		/// <summary>
		/// 账号行业类型，多个用“,”分割
		/// </summary>
		public string KINDS
		{
			get{ return _KINDS; }
			set
			{
				this.OnPropertyValueChange(_.KINDS, _KINDS, value);
				this._KINDS = value;
			}
		}
		/// <summary>
		/// 是否有所有行业的权限
		/// </summary>
		public decimal? ISALLKIND
		{
			get{ return _ISALLKIND; }
			set
			{
				this.OnPropertyValueChange(_.ISALLKIND, _ISALLKIND, value);
				this._ISALLKIND = value;
			}
		}
		/// <summary>
		/// 可查阅的其它组织机构
		/// </summary>
		public string OTHERIDS
		{
			get{ return _OTHERIDS; }
			set
			{
				this.OnPropertyValueChange(_.OTHERIDS, _OTHERIDS, value);
				this._OTHERIDS = value;
			}
		}
		/// <summary>
		/// 组织机构编码
		/// </summary>
		public string DCODE
		{
			get{ return _DCODE; }
			set
			{
				this.OnPropertyValueChange(_.DCODE, _DCODE, value);
				this._DCODE = value;
			}
		}
		/// <summary>
		/// 是否报建
		/// </summary>
		public decimal? ISBJ
		{
			get{ return _ISBJ; }
			set
			{
				this.OnPropertyValueChange(_.ISBJ, _ISBJ, value);
				this._ISBJ = value;
			}
		}
		/// <summary>
		/// 是否备案
		/// </summary>
		public decimal? ISBA
		{
			get{ return _ISBA; }
			set
			{
				this.OnPropertyValueChange(_.ISBA, _ISBA, value);
				this._ISBA = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PHONE
		{
			get{ return _PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PHONE, _PHONE, value);
				this._PHONE = value;
			}
		}
		/// <summary>
		/// 监管部门
		/// </summary>
		public string JGBM
		{
			get{ return _JGBM; }
			set
			{
				this.OnPropertyValueChange(_.JGBM, _JGBM, value);
				this._JGBM = value;
			}
		}
		/// <summary>
		/// 单位地址
		/// </summary>
		public string DADDRESS
		{
			get{ return _DADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.DADDRESS, _DADDRESS, value);
				this._DADDRESS = value;
			}
		}
		/// <summary>
		/// 是否投诉受理单位
		/// </summary>
		public decimal? ISTS
		{
			get{ return _ISTS; }
			set
			{
				this.OnPropertyValueChange(_.ISTS, _ISTS, value);
				this._ISTS = value;
			}
		}
		/// <summary>
		/// 行业类型
		/// </summary>
		public string HY_TYPE
		{
			get{ return _HY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.HY_TYPE, _HY_TYPE, value);
				this._HY_TYPE = value;
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
				_.DEPID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.DEPID,
				_.DNAME,
				_.AREACODE,
				_.PARENTID,
				_.DREMARK,
				_.LONGI,
				_.LATI,
				_.DTYPE,
				_.ORGPROPERTY,
				_.ORDERID,
				_.DEPCODE,
				_.ISCK,
				_.CKID,
				_.KINDS,
				_.ISALLKIND,
				_.OTHERIDS,
				_.DCODE,
				_.ISBJ,
				_.ISBA,
				_.PHONE,
				_.JGBM,
				_.DADDRESS,
				_.ISTS,
				_.HY_TYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._DEPID,
				this._DNAME,
				this._AREACODE,
				this._PARENTID,
				this._DREMARK,
				this._LONGI,
				this._LATI,
				this._DTYPE,
				this._ORGPROPERTY,
				this._ORDERID,
				this._DEPCODE,
				this._ISCK,
				this._CKID,
				this._KINDS,
				this._ISALLKIND,
				this._OTHERIDS,
				this._DCODE,
				this._ISBJ,
				this._ISBA,
				this._PHONE,
				this._JGBM,
				this._DADDRESS,
				this._ISTS,
				this._HY_TYPE,
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
			public readonly static Field All = new Field("*", "T_USER_DEPARTMENT");
            /// <summary>
			/// 单位ID
			/// </summary>
			public readonly static Field DEPID = new Field("DEPID", "T_USER_DEPARTMENT", "单位ID");
            /// <summary>
			/// 单位名称
			/// </summary>
			public readonly static Field DNAME = new Field("DNAME", "T_USER_DEPARTMENT", "单位名称");
            /// <summary>
			/// 地区编码
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "T_USER_DEPARTMENT", "地区编码");
            /// <summary>
			/// 上级单位
			/// </summary>
			public readonly static Field PARENTID = new Field("PARENTID", "T_USER_DEPARTMENT", "上级单位");
            /// <summary>
			/// 单位备注
			/// </summary>
			public readonly static Field DREMARK = new Field("DREMARK", "T_USER_DEPARTMENT", "单位备注");
            /// <summary>
			/// 经度
			/// </summary>
			public readonly static Field LONGI = new Field("LONGI", "T_USER_DEPARTMENT", "经度");
            /// <summary>
			/// 纬度
			/// </summary>
			public readonly static Field LATI = new Field("LATI", "T_USER_DEPARTMENT", "纬度");
			/// <summary>
			/// 单位类型 1 2 3 4
			/// 1科室2办公司 3纪委监委4公安
			/// </summary>
			public readonly static Field DTYPE = new Field("DTYPE", "T_USER_DEPARTMENT", "单位类型");
            /// <summary>
			/// 组织属性
			/// </summary>
			public readonly static Field ORGPROPERTY = new Field("ORGPROPERTY", "T_USER_DEPARTMENT", "组织属性");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "T_USER_DEPARTMENT", "排序号");
            /// <summary>
			/// 组织机构编码
			/// </summary>
			public readonly static Field DEPCODE = new Field("DEPCODE", "T_USER_DEPARTMENT", "组织机构编码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISCK = new Field("ISCK", "T_USER_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CKID = new Field("CKID", "T_USER_DEPARTMENT", "");
            /// <summary>
			/// 账号行业类型，多个用“,”分割
			/// </summary>
			public readonly static Field KINDS = new Field("KINDS", "T_USER_DEPARTMENT", "账号行业类型，多个用“,”分割");
            /// <summary>
			/// 是否有所有行业的权限
			/// </summary>
			public readonly static Field ISALLKIND = new Field("ISALLKIND", "T_USER_DEPARTMENT", "是否有所有行业的权限");
            /// <summary>
			/// 可查阅的其它组织机构
			/// </summary>
			public readonly static Field OTHERIDS = new Field("OTHERIDS", "T_USER_DEPARTMENT", "可查阅的其它组织机构");
            /// <summary>
			/// 组织机构编码
			/// </summary>
			public readonly static Field DCODE = new Field("DCODE", "T_USER_DEPARTMENT", "组织机构编码");
            /// <summary>
			/// 是否报建
			/// </summary>
			public readonly static Field ISBJ = new Field("ISBJ", "T_USER_DEPARTMENT", "是否报建");
            /// <summary>
			/// 是否备案
			/// </summary>
			public readonly static Field ISBA = new Field("ISBA", "T_USER_DEPARTMENT", "是否备案");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "T_USER_DEPARTMENT", "联系电话");
            /// <summary>
			/// 监管部门
			/// </summary>
			public readonly static Field JGBM = new Field("JGBM", "T_USER_DEPARTMENT", "监管部门");
            /// <summary>
			/// 单位地址
			/// </summary>
			public readonly static Field DADDRESS = new Field("DADDRESS", "T_USER_DEPARTMENT", "单位地址");
            /// <summary>
			/// 是否投诉受理单位
			/// </summary>
			public readonly static Field ISTS = new Field("ISTS", "T_USER_DEPARTMENT", "是否投诉受理单位");
            /// <summary>
			/// 行业类型
			/// </summary>
			public readonly static Field HY_TYPE = new Field("HY_TYPE", "T_USER_DEPARTMENT", "行业类型");
        }
        #endregion
	}
}