using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_MP_PLAN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MP_PLAN")]
    [Serializable]
    public partial class T_MP_PLAN : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _REMARK;
		private DateTime? _CREAT_TM;
		private decimal? _TP_ID;

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
		/// 方案名称
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
		/// 方案说明
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
		/// 创建时间
		/// </summary>
		public DateTime? CREAT_TM
		{
			get{ return _CREAT_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREAT_TM, _CREAT_TM, value);
				this._CREAT_TM = value;
			}
		}
		/// <summary>
		/// 归属流程ID
		/// </summary>
		public decimal? TP_ID
		{
			get{ return _TP_ID; }
			set
			{
				this.OnPropertyValueChange(_.TP_ID, _TP_ID, value);
				this._TP_ID = value;
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
				_.CREAT_TM,
				_.TP_ID,
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
				this._CREAT_TM,
				this._TP_ID,
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
			public readonly static Field All = new Field("*", "T_MP_PLAN");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MP_PLAN", "ID");
            /// <summary>
			/// 方案名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_MP_PLAN", "方案名称");
            /// <summary>
			/// 方案说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_MP_PLAN", "方案说明");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREAT_TM = new Field("CREAT_TM", "T_MP_PLAN", "创建时间");
            /// <summary>
			/// 归属流程ID
			/// </summary>
			public readonly static Field TP_ID = new Field("TP_ID", "T_MP_PLAN", "归属流程ID");
        }
        #endregion
	}
}