using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PM_RELATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PM_RELATION")]
    [Serializable]
    public partial class T_PM_RELATION : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TENDER_PROJECT_CODE;
		private decimal? _MPID;
		private DateTime? _START_TIM;
		private DateTime? _CREATE_TM;
		private decimal? _RUN_NUM;

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
		/// 监督启动时间
		/// </summary>
		public DateTime? START_TIM
		{
			get{ return _START_TIM; }
			set
			{
				this.OnPropertyValueChange(_.START_TIM, _START_TIM, value);
				this._START_TIM = value;
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
		/// 执行次数
		/// </summary>
		public decimal? RUN_NUM
		{
			get{ return _RUN_NUM; }
			set
			{
				this.OnPropertyValueChange(_.RUN_NUM, _RUN_NUM, value);
				this._RUN_NUM = value;
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
				_.START_TIM,
				_.CREATE_TM,
				_.RUN_NUM,
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
				this._START_TIM,
				this._CREATE_TM,
				this._RUN_NUM,
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
			public readonly static Field All = new Field("*", "T_PM_RELATION");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PM_RELATION", "ID");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_PM_RELATION", "招标项目编号");
            /// <summary>
			/// 监督点ID
			/// </summary>
			public readonly static Field MPID = new Field("MPID", "T_PM_RELATION", "监督点ID");
            /// <summary>
			/// 监督启动时间
			/// </summary>
			public readonly static Field START_TIM = new Field("START_TIM", "T_PM_RELATION", "监督启动时间");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_PM_RELATION", "创建时间");
            /// <summary>
			/// 执行次数
			/// </summary>
			public readonly static Field RUN_NUM = new Field("RUN_NUM", "T_PM_RELATION", "执行次数");
        }
        #endregion
	}
}