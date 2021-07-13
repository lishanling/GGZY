using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_TRANSFER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_TRANSFER")]
    [Serializable]
    public partial class T_ZT_TRANSFER : FwEntity
    {
        #region Model
		private string _LEGALCODE;
		private string _NATIONASSET;
		private string _CENTRALENTERPRISE;
		private string _MGRTYPE;
		private string _MGRORGNAME;
		private string _MGRNAME;
		private string _MGRCODE;
		private string _CREATETIME;
		private string _ECONOMYTYPE;
		private string _COMPANYSCALE;
		private string _COMPANYSCOPE;
		private decimal? _EMPLOYEENUMBER;
		private string _CUSTOMDEFINITIONDATAITEM;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string LEGALCODE
		{
			get{ return _LEGALCODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGALCODE, _LEGALCODE, value);
				this._LEGALCODE = value;
			}
		}
		/// <summary>
		/// 是否国资
		/// </summary>
		public string NATIONASSET
		{
			get{ return _NATIONASSET; }
			set
			{
				this.OnPropertyValueChange(_.NATIONASSET, _NATIONASSET, value);
				this._NATIONASSET = value;
			}
		}
		/// <summary>
		/// 是否央企
		/// </summary>
		public string CENTRALENTERPRISE
		{
			get{ return _CENTRALENTERPRISE; }
			set
			{
				this.OnPropertyValueChange(_.CENTRALENTERPRISE, _CENTRALENTERPRISE, value);
				this._CENTRALENTERPRISE = value;
			}
		}
		/// <summary>
		/// 国资监管类型
		/// </summary>
		public string MGRTYPE
		{
			get{ return _MGRTYPE; }
			set
			{
				this.OnPropertyValueChange(_.MGRTYPE, _MGRTYPE, value);
				this._MGRTYPE = value;
			}
		}
		/// <summary>
		/// 国资监管机构
		/// </summary>
		public string MGRORGNAME
		{
			get{ return _MGRORGNAME; }
			set
			{
				this.OnPropertyValueChange(_.MGRORGNAME, _MGRORGNAME, value);
				this._MGRORGNAME = value;
			}
		}
		/// <summary>
		/// 主管集团或其他部门名称
		/// </summary>
		public string MGRNAME
		{
			get{ return _MGRNAME; }
			set
			{
				this.OnPropertyValueChange(_.MGRNAME, _MGRNAME, value);
				this._MGRNAME = value;
			}
		}
		/// <summary>
		/// 主管集团或其他部门组织机构代码
		/// </summary>
		public string MGRCODE
		{
			get{ return _MGRCODE; }
			set
			{
				this.OnPropertyValueChange(_.MGRCODE, _MGRCODE, value);
				this._MGRCODE = value;
			}
		}
		/// <summary>
		/// 成立时间
		/// </summary>
		public string CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 经济类型
		/// </summary>
		public string ECONOMYTYPE
		{
			get{ return _ECONOMYTYPE; }
			set
			{
				this.OnPropertyValueChange(_.ECONOMYTYPE, _ECONOMYTYPE, value);
				this._ECONOMYTYPE = value;
			}
		}
		/// <summary>
		/// 经营规模
		/// </summary>
		public string COMPANYSCALE
		{
			get{ return _COMPANYSCALE; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYSCALE, _COMPANYSCALE, value);
				this._COMPANYSCALE = value;
			}
		}
		/// <summary>
		/// 营业范围
		/// </summary>
		public string COMPANYSCOPE
		{
			get{ return _COMPANYSCOPE; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYSCOPE, _COMPANYSCOPE, value);
				this._COMPANYSCOPE = value;
			}
		}
		/// <summary>
		/// 职工人数
		/// </summary>
		public decimal? EMPLOYEENUMBER
		{
			get{ return _EMPLOYEENUMBER; }
			set
			{
				this.OnPropertyValueChange(_.EMPLOYEENUMBER, _EMPLOYEENUMBER, value);
				this._EMPLOYEENUMBER = value;
			}
		}
		/// <summary>
		/// 自定义数据项
		/// </summary>
		public string CUSTOMDEFINITIONDATAITEM
		{
			get{ return _CUSTOMDEFINITIONDATAITEM; }
			set
			{
				this.OnPropertyValueChange(_.CUSTOMDEFINITIONDATAITEM, _CUSTOMDEFINITIONDATAITEM, value);
				this._CUSTOMDEFINITIONDATAITEM = value;
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
				_.LEGALCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.LEGALCODE,
				_.NATIONASSET,
				_.CENTRALENTERPRISE,
				_.MGRTYPE,
				_.MGRORGNAME,
				_.MGRNAME,
				_.MGRCODE,
				_.CREATETIME,
				_.ECONOMYTYPE,
				_.COMPANYSCALE,
				_.COMPANYSCOPE,
				_.EMPLOYEENUMBER,
				_.CUSTOMDEFINITIONDATAITEM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._LEGALCODE,
				this._NATIONASSET,
				this._CENTRALENTERPRISE,
				this._MGRTYPE,
				this._MGRORGNAME,
				this._MGRNAME,
				this._MGRCODE,
				this._CREATETIME,
				this._ECONOMYTYPE,
				this._COMPANYSCALE,
				this._COMPANYSCOPE,
				this._EMPLOYEENUMBER,
				this._CUSTOMDEFINITIONDATAITEM,
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
			public readonly static Field All = new Field("*", "T_ZT_TRANSFER");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field LEGALCODE = new Field("LEGALCODE", "T_ZT_TRANSFER", "主体代码");
            /// <summary>
			/// 是否国资
			/// </summary>
			public readonly static Field NATIONASSET = new Field("NATIONASSET", "T_ZT_TRANSFER", "是否国资");
            /// <summary>
			/// 是否央企
			/// </summary>
			public readonly static Field CENTRALENTERPRISE = new Field("CENTRALENTERPRISE", "T_ZT_TRANSFER", "是否央企");
            /// <summary>
			/// 国资监管类型
			/// </summary>
			public readonly static Field MGRTYPE = new Field("MGRTYPE", "T_ZT_TRANSFER", "国资监管类型");
            /// <summary>
			/// 国资监管机构
			/// </summary>
			public readonly static Field MGRORGNAME = new Field("MGRORGNAME", "T_ZT_TRANSFER", "国资监管机构");
            /// <summary>
			/// 主管集团或其他部门名称
			/// </summary>
			public readonly static Field MGRNAME = new Field("MGRNAME", "T_ZT_TRANSFER", "主管集团或其他部门名称");
            /// <summary>
			/// 主管集团或其他部门组织机构代码
			/// </summary>
			public readonly static Field MGRCODE = new Field("MGRCODE", "T_ZT_TRANSFER", "主管集团或其他部门组织机构代码");
            /// <summary>
			/// 成立时间
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_ZT_TRANSFER", "成立时间");
            /// <summary>
			/// 经济类型
			/// </summary>
			public readonly static Field ECONOMYTYPE = new Field("ECONOMYTYPE", "T_ZT_TRANSFER", "经济类型");
            /// <summary>
			/// 经营规模
			/// </summary>
			public readonly static Field COMPANYSCALE = new Field("COMPANYSCALE", "T_ZT_TRANSFER", "经营规模");
            /// <summary>
			/// 营业范围
			/// </summary>
			public readonly static Field COMPANYSCOPE = new Field("COMPANYSCOPE", "T_ZT_TRANSFER", "营业范围");
            /// <summary>
			/// 职工人数
			/// </summary>
			public readonly static Field EMPLOYEENUMBER = new Field("EMPLOYEENUMBER", "T_ZT_TRANSFER", "职工人数");
            /// <summary>
			/// 自定义数据项
			/// </summary>
			public readonly static Field CUSTOMDEFINITIONDATAITEM = new Field("CUSTOMDEFINITIONDATAITEM", "T_ZT_TRANSFER", "自定义数据项");
        }
        #endregion
	}
}