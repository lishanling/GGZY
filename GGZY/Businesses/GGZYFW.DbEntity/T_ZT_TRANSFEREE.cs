using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_TRANSFEREE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_TRANSFEREE")]
    [Serializable]
    public partial class T_ZT_TRANSFEREE : FwEntity
    {
        #region Model
		private string _LEGALCODE;
		private string _COMPANYINDUSTRY;
		private string _COMPANYTIME;
		private string _ECONOMYTYPE;
		private string _COMPANYSCALE;
		private string _COMPANYSCOPE;
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
		/// 所属行业
		/// </summary>
		public string COMPANYINDUSTRY
		{
			get{ return _COMPANYINDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYINDUSTRY, _COMPANYINDUSTRY, value);
				this._COMPANYINDUSTRY = value;
			}
		}
		/// <summary>
		/// 成立时间
		/// </summary>
		public string COMPANYTIME
		{
			get{ return _COMPANYTIME; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYTIME, _COMPANYTIME, value);
				this._COMPANYTIME = value;
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
				_.COMPANYINDUSTRY,
				_.COMPANYTIME,
				_.ECONOMYTYPE,
				_.COMPANYSCALE,
				_.COMPANYSCOPE,
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
				this._COMPANYINDUSTRY,
				this._COMPANYTIME,
				this._ECONOMYTYPE,
				this._COMPANYSCALE,
				this._COMPANYSCOPE,
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
			public readonly static Field All = new Field("*", "T_ZT_TRANSFEREE");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field LEGALCODE = new Field("LEGALCODE", "T_ZT_TRANSFEREE", "主体代码");
            /// <summary>
			/// 所属行业
			/// </summary>
			public readonly static Field COMPANYINDUSTRY = new Field("COMPANYINDUSTRY", "T_ZT_TRANSFEREE", "所属行业");
            /// <summary>
			/// 成立时间
			/// </summary>
			public readonly static Field COMPANYTIME = new Field("COMPANYTIME", "T_ZT_TRANSFEREE", "成立时间");
            /// <summary>
			/// 经济类型
			/// </summary>
			public readonly static Field ECONOMYTYPE = new Field("ECONOMYTYPE", "T_ZT_TRANSFEREE", "经济类型");
            /// <summary>
			/// 经营规模
			/// </summary>
			public readonly static Field COMPANYSCALE = new Field("COMPANYSCALE", "T_ZT_TRANSFEREE", "经营规模");
            /// <summary>
			/// 营业范围
			/// </summary>
			public readonly static Field COMPANYSCOPE = new Field("COMPANYSCOPE", "T_ZT_TRANSFEREE", "营业范围");
            /// <summary>
			/// 自定义数据项
			/// </summary>
			public readonly static Field CUSTOMDEFINITIONDATAITEM = new Field("CUSTOMDEFINITIONDATAITEM", "T_ZT_TRANSFEREE", "自定义数据项");
        }
        #endregion
	}
}