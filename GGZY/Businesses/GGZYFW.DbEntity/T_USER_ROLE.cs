using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER_ROLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_ROLE")]
    [Serializable]
    public partial class T_USER_ROLE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _REMARK;
		private decimal? _ORDER_BY;

		/// <summary>
		/// 角色ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 角色说明
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
		/// 排序号
		/// </summary>
		public decimal? ORDER_BY
		{
			get{ return _ORDER_BY; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_BY, _ORDER_BY, value);
				this._ORDER_BY = value;
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
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.NAME,
				_.REMARK,
				_.ORDER_BY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._REMARK,
				this._ORDER_BY,
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
			public readonly static Field All = new Field("*", "T_USER_ROLE");
            /// <summary>
			/// 角色ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_ROLE", "角色ID");
            /// <summary>
			/// 角色名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_USER_ROLE", "角色名称");
            /// <summary>
			/// 角色说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_USER_ROLE", "角色说明");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_USER_ROLE", "排序号");
        }
        #endregion
	}
}