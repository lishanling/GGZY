using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类STATL_SUM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("STATL_SUM")]
    [Serializable]
    public partial class STATL_SUM : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _STATL_WAY_NAME;
		private string _IS_ENABLE;
		private string _ADD_PEOPLE;
		private DateTime? _ADD_TIME;
		private string _REMARK;

		/// <summary>
		/// ID
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
		/// 统计方法名称
		/// </summary>
		public string STATL_WAY_NAME
		{
			get{ return _STATL_WAY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.STATL_WAY_NAME, _STATL_WAY_NAME, value);
				this._STATL_WAY_NAME = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public string IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public string ADD_PEOPLE
		{
			get{ return _ADD_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.ADD_PEOPLE, _ADD_PEOPLE, value);
				this._ADD_PEOPLE = value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? ADD_TIME
		{
			get{ return _ADD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ADD_TIME, _ADD_TIME, value);
				this._ADD_TIME = value;
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
				_.STATL_WAY_NAME,
				_.IS_ENABLE,
				_.ADD_PEOPLE,
				_.ADD_TIME,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._STATL_WAY_NAME,
				this._IS_ENABLE,
				this._ADD_PEOPLE,
				this._ADD_TIME,
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
			public readonly static Field All = new Field("*", "STATL_SUM");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "STATL_SUM", "ID");
            /// <summary>
			/// 统计方法名称
			/// </summary>
			public readonly static Field STATL_WAY_NAME = new Field("STATL_WAY_NAME", "STATL_SUM", "统计方法名称");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "STATL_SUM", "是否启用");
            /// <summary>
			/// 添加人
			/// </summary>
			public readonly static Field ADD_PEOPLE = new Field("ADD_PEOPLE", "STATL_SUM", "添加人");
            /// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field ADD_TIME = new Field("ADD_TIME", "STATL_SUM", "添加时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "STATL_SUM", "备注");
        }
        #endregion
	}
}