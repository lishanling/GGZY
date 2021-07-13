using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_PURCHASINGAGENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_PURCHASINGAGENT")]
    [Serializable]
    public partial class T_ZT_PURCHASINGAGENT : FwEntity
    {
        #region Model
		private string _LEGALCODE;
		private DateTime? _REGISTERDATE;
		private string _REGISTERADDRESS;
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
		/// 登记日期
		/// </summary>
		public DateTime? REGISTERDATE
		{
			get{ return _REGISTERDATE; }
			set
			{
				this.OnPropertyValueChange(_.REGISTERDATE, _REGISTERDATE, value);
				this._REGISTERDATE = value;
			}
		}
		/// <summary>
		/// 登记地点
		/// </summary>
		public string REGISTERADDRESS
		{
			get{ return _REGISTERADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.REGISTERADDRESS, _REGISTERADDRESS, value);
				this._REGISTERADDRESS = value;
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
				_.REGISTERDATE,
				_.REGISTERADDRESS,
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
				this._REGISTERDATE,
				this._REGISTERADDRESS,
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
			public readonly static Field All = new Field("*", "T_ZT_PURCHASINGAGENT");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field LEGALCODE = new Field("LEGALCODE", "T_ZT_PURCHASINGAGENT", "主体代码");
            /// <summary>
			/// 登记日期
			/// </summary>
			public readonly static Field REGISTERDATE = new Field("REGISTERDATE", "T_ZT_PURCHASINGAGENT", "登记日期");
            /// <summary>
			/// 登记地点
			/// </summary>
			public readonly static Field REGISTERADDRESS = new Field("REGISTERADDRESS", "T_ZT_PURCHASINGAGENT", "登记地点");
            /// <summary>
			/// 自定义数据项
			/// </summary>
			public readonly static Field CUSTOMDEFINITIONDATAITEM = new Field("CUSTOMDEFINITIONDATAITEM", "T_ZT_PURCHASINGAGENT", "自定义数据项");
        }
        #endregion
	}
}