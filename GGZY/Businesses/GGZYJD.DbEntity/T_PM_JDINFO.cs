using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PM_JDINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PM_JDINFO")]
    [Serializable]
    public partial class T_PM_JDINFO : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TENDER_PROJECT_CODE;
		private decimal? _MPID;
		private string _LEVEL_TYPE;
		private string _U_ID;
		private string _REMARK;
		private DateTime? _UPDATE_TM;
		private DateTime? _CREATE_TM;
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
		/// 预警等级
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
		/// 描述说明
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
		/// 修改时间
		/// </summary>
		public DateTime? UPDATE_TM
		{
			get{ return _UPDATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TM, _UPDATE_TM, value);
				this._UPDATE_TM = value;
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
				_.LEVEL_TYPE,
				_.U_ID,
				_.REMARK,
				_.UPDATE_TM,
				_.CREATE_TM,
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
				this._LEVEL_TYPE,
				this._U_ID,
				this._REMARK,
				this._UPDATE_TM,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_PM_JDINFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PM_JDINFO", "ID");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_PM_JDINFO", "招标项目编号");
            /// <summary>
			/// 监督点ID
			/// </summary>
			public readonly static Field MPID = new Field("MPID", "T_PM_JDINFO", "监督点ID");
            /// <summary>
			/// 预警等级
			/// </summary>
			public readonly static Field LEVEL_TYPE = new Field("LEVEL_TYPE", "T_PM_JDINFO", "预警等级");
            /// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_PM_JDINFO", "操作人");
            /// <summary>
			/// 描述说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_PM_JDINFO", "描述说明");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATE_TM = new Field("UPDATE_TM", "T_PM_JDINFO", "修改时间");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_PM_JDINFO", "创建时间");
            /// <summary>
			/// 业务流水号
			/// </summary>
			public readonly static Field BUSINESSID = new Field("BUSINESSID", "T_PM_JDINFO", "业务流水号");
        }
        #endregion
	}
}