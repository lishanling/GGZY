using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_TP_MAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TP_MAIN")]
    [Serializable]
    public partial class T_TP_MAIN : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _CODE;
		private string _REMARK;
		private DateTime? _CREATE_TM;
		private string _SYS_CODE;

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
		/// 流程名称
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
		/// 流程编码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
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
		/// 创建时间
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
		/// <summary>
		/// 归属系统编码
		/// </summary>
		public string SYS_CODE
		{
			get{ return _SYS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SYS_CODE, _SYS_CODE, value);
				this._SYS_CODE = value;
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
				_.CODE,
				_.REMARK,
				_.CREATE_TM,
				_.SYS_CODE,
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
				this._CODE,
				this._REMARK,
				this._CREATE_TM,
				this._SYS_CODE,
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
			public readonly static Field All = new Field("*", "T_TP_MAIN");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TP_MAIN", "ID");
            /// <summary>
			/// 流程名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_TP_MAIN", "流程名称");
            /// <summary>
			/// 流程编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_TP_MAIN", "流程编码");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_TP_MAIN", "说明");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_TP_MAIN", "创建时间");
            /// <summary>
			/// 归属系统编码
			/// </summary>
			public readonly static Field SYS_CODE = new Field("SYS_CODE", "T_TP_MAIN", "归属系统编码");
        }
        #endregion
	}
}