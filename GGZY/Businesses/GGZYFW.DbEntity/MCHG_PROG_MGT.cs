using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MCHG_PROG_MGT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MCHG_PROG_MGT")]
    [Serializable]
    public partial class MCHG_PROG_MGT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _MCHG_WAY;
		private string _MCHG_PROG;
		private string _IS_ENABLE;
		private string _ASSOCIATION_TABLE;
		private string _ASSOCIATION_FIELD;
		private string _ADD_PEOPLE;
		private DateTime? _ADD_TIME;
		private string _ANNEX;
		private string _REMARK;

		/// <summary>
		/// 
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
		/// 加工方法
		/// </summary>
		public string MCHG_WAY
		{
			get{ return _MCHG_WAY; }
			set
			{
				this.OnPropertyValueChange(_.MCHG_WAY, _MCHG_WAY, value);
				this._MCHG_WAY = value;
			}
		}
		/// <summary>
		/// 加工方案
		/// </summary>
		public string MCHG_PROG
		{
			get{ return _MCHG_PROG; }
			set
			{
				this.OnPropertyValueChange(_.MCHG_PROG, _MCHG_PROG, value);
				this._MCHG_PROG = value;
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
		/// 关联表
		/// </summary>
		public string ASSOCIATION_TABLE
		{
			get{ return _ASSOCIATION_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.ASSOCIATION_TABLE, _ASSOCIATION_TABLE, value);
				this._ASSOCIATION_TABLE = value;
			}
		}
		/// <summary>
		/// 关联字段
		/// </summary>
		public string ASSOCIATION_FIELD
		{
			get{ return _ASSOCIATION_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.ASSOCIATION_FIELD, _ASSOCIATION_FIELD, value);
				this._ASSOCIATION_FIELD = value;
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
		/// 附件
		/// </summary>
		public string ANNEX
		{
			get{ return _ANNEX; }
			set
			{
				this.OnPropertyValueChange(_.ANNEX, _ANNEX, value);
				this._ANNEX = value;
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
				_.MCHG_WAY,
				_.MCHG_PROG,
				_.IS_ENABLE,
				_.ASSOCIATION_TABLE,
				_.ASSOCIATION_FIELD,
				_.ADD_PEOPLE,
				_.ADD_TIME,
				_.ANNEX,
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
				this._MCHG_WAY,
				this._MCHG_PROG,
				this._IS_ENABLE,
				this._ASSOCIATION_TABLE,
				this._ASSOCIATION_FIELD,
				this._ADD_PEOPLE,
				this._ADD_TIME,
				this._ANNEX,
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
			public readonly static Field All = new Field("*", "MCHG_PROG_MGT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "MCHG_PROG_MGT", "");
            /// <summary>
			/// 加工方法
			/// </summary>
			public readonly static Field MCHG_WAY = new Field("MCHG_WAY", "MCHG_PROG_MGT", "加工方法");
            /// <summary>
			/// 加工方案
			/// </summary>
			public readonly static Field MCHG_PROG = new Field("MCHG_PROG", "MCHG_PROG_MGT", "加工方案");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "MCHG_PROG_MGT", "是否启用");
            /// <summary>
			/// 关联表
			/// </summary>
			public readonly static Field ASSOCIATION_TABLE = new Field("ASSOCIATION_TABLE", "MCHG_PROG_MGT", "关联表");
            /// <summary>
			/// 关联字段
			/// </summary>
			public readonly static Field ASSOCIATION_FIELD = new Field("ASSOCIATION_FIELD", "MCHG_PROG_MGT", "关联字段");
            /// <summary>
			/// 添加人
			/// </summary>
			public readonly static Field ADD_PEOPLE = new Field("ADD_PEOPLE", "MCHG_PROG_MGT", "添加人");
            /// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field ADD_TIME = new Field("ADD_TIME", "MCHG_PROG_MGT", "添加时间");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field ANNEX = new Field("ANNEX", "MCHG_PROG_MGT", "附件");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "MCHG_PROG_MGT", "备注");
        }
        #endregion
	}
}