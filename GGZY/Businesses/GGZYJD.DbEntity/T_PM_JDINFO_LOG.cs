using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PM_JDINFO_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PM_JDINFO_LOG")]
    [Serializable]
    public partial class T_PM_JDINFO_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TENDER_PROJECT_CODE;
		private decimal? _MPID;
		private string _U_ID;
		private string _LEVEL_TYPE_OLD;
		private string _LEVEL_TYPE;
		private string _REMARK;
		private DateTime? _TM;
		private string _BUSINESSID;

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
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 监督点ID
		/// </summary>
		public decimal? MPID
		{
			get{ return _MPID; }
			set
			{
				this.OnPropertyValueChange(_.MPID, _MPID, value);
				this._MPID = value;
			}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 旧预警等级
		/// </summary>
		public string LEVEL_TYPE_OLD
		{
			get{ return _LEVEL_TYPE_OLD; }
			set
			{
				this.OnPropertyValueChange(_.LEVEL_TYPE_OLD, _LEVEL_TYPE_OLD, value);
				this._LEVEL_TYPE_OLD = value;
			}
		}
		/// <summary>
		/// 新预警等级
		/// </summary>
		public string LEVEL_TYPE
		{
			get{ return _LEVEL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LEVEL_TYPE, _LEVEL_TYPE, value);
				this._LEVEL_TYPE = value;
			}
		}
		/// <summary>
		/// 描述
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
		/// 记录时间
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
		/// 业务流水号
		/// </summary>
		public string BUSINESSID
		{
			get{ return _BUSINESSID; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSID, _BUSINESSID, value);
				this._BUSINESSID = value;
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
				_.TENDER_PROJECT_CODE,
				_.MPID,
				_.U_ID,
				_.LEVEL_TYPE_OLD,
				_.LEVEL_TYPE,
				_.REMARK,
				_.TM,
				_.BUSINESSID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TENDER_PROJECT_CODE,
				this._MPID,
				this._U_ID,
				this._LEVEL_TYPE_OLD,
				this._LEVEL_TYPE,
				this._REMARK,
				this._TM,
				this._BUSINESSID,
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
			public readonly static Field All = new Field("*", "T_PM_JDINFO_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PM_JDINFO_LOG", "ID");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_PM_JDINFO_LOG", "招标项目编号");
            /// <summary>
			/// 监督点ID
			/// </summary>
			public readonly static Field MPID = new Field("MPID", "T_PM_JDINFO_LOG", "监督点ID");
            /// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_PM_JDINFO_LOG", "操作人");
            /// <summary>
			/// 旧预警等级
			/// </summary>
			public readonly static Field LEVEL_TYPE_OLD = new Field("LEVEL_TYPE_OLD", "T_PM_JDINFO_LOG", "旧预警等级");
            /// <summary>
			/// 新预警等级
			/// </summary>
			public readonly static Field LEVEL_TYPE = new Field("LEVEL_TYPE", "T_PM_JDINFO_LOG", "新预警等级");
            /// <summary>
			/// 描述
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_PM_JDINFO_LOG", "描述");
            /// <summary>
			/// 记录时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_PM_JDINFO_LOG", "记录时间");
            /// <summary>
			/// 业务流水号
			/// </summary>
			public readonly static Field BUSINESSID = new Field("BUSINESSID", "T_PM_JDINFO_LOG", "业务流水号");
        }
        #endregion
	}
}