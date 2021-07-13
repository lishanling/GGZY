using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_HOLIDAY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_HOLIDAY")]
    [Serializable]
    public partial class T_HOLIDAY : JdEntity
    {
        #region Model
		private decimal? _ID;
		private DateTime? _TM;
		private string _NAME;
		private string _TYPE;
		private string _REMARK;
		private DateTime? _CREATE_TM;

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
		/// 日期
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 节日名称
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
		/// 类型
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 说明
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
		/// 创建日期
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
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
				_.TM,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.TM,
				_.NAME,
				_.TYPE,
				_.REMARK,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TM,
				this._NAME,
				this._TYPE,
				this._REMARK,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_HOLIDAY");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_HOLIDAY", "");
            /// <summary>
			/// 日期
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_HOLIDAY", "日期");
            /// <summary>
			/// 节日名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_HOLIDAY", "节日名称");
            /// <summary>
			/// 类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_HOLIDAY", "类型");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_HOLIDAY", "说明");
            /// <summary>
			/// 创建日期
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_HOLIDAY", "创建日期");
        }
        #endregion
	}
}