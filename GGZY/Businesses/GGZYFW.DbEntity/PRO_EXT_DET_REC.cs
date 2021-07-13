using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRO_EXT_DET_REC。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRO_EXT_DET_REC")]
    [Serializable]
    public partial class PRO_EXT_DET_REC : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRO_CODE;
		private string _PRO_NAME;
		private DateTime? _REC_TIME;
		private string _REC_PERSON;
		private string _WORK_DESC;
		private string _COMM_REC;
		private string _ACT_PROB_REC;
		private string _RESULT;
		private string _SUM_UP;

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
		/// 项目编号
		/// </summary>
		public string PRO_CODE
		{
			get{ return _PRO_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRO_CODE, _PRO_CODE, value);
				this._PRO_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PRO_NAME
		{
			get{ return _PRO_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PRO_NAME, _PRO_NAME, value);
				this._PRO_NAME = value;
			}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime? REC_TIME
		{
			get{ return _REC_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REC_TIME, _REC_TIME, value);
				this._REC_TIME = value;
			}
		}
		/// <summary>
		/// 记录人员
		/// </summary>
		public string REC_PERSON
		{
			get{ return _REC_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.REC_PERSON, _REC_PERSON, value);
				this._REC_PERSON = value;
			}
		}
		/// <summary>
		/// 工作描述
		/// </summary>
		public string WORK_DESC
		{
			get{ return _WORK_DESC; }
			set
			{
				this.OnPropertyValueChange(_.WORK_DESC, _WORK_DESC, value);
				this._WORK_DESC = value;
			}
		}
		/// <summary>
		/// 沟通记录
		/// </summary>
		public string COMM_REC
		{
			get{ return _COMM_REC; }
			set
			{
				this.OnPropertyValueChange(_.COMM_REC, _COMM_REC, value);
				this._COMM_REC = value;
			}
		}
		/// <summary>
		/// 事故问题记录
		/// </summary>
		public string ACT_PROB_REC
		{
			get{ return _ACT_PROB_REC; }
			set
			{
				this.OnPropertyValueChange(_.ACT_PROB_REC, _ACT_PROB_REC, value);
				this._ACT_PROB_REC = value;
			}
		}
		/// <summary>
		/// 成果
		/// </summary>
		public string RESULT
		{
			get{ return _RESULT; }
			set
			{
				this.OnPropertyValueChange(_.RESULT, _RESULT, value);
				this._RESULT = value;
			}
		}
		/// <summary>
		/// 总结
		/// </summary>
		public string SUM_UP
		{
			get{ return _SUM_UP; }
			set
			{
				this.OnPropertyValueChange(_.SUM_UP, _SUM_UP, value);
				this._SUM_UP = value;
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
				_.PRO_CODE,
				_.PRO_NAME,
				_.REC_TIME,
				_.REC_PERSON,
				_.WORK_DESC,
				_.COMM_REC,
				_.ACT_PROB_REC,
				_.RESULT,
				_.SUM_UP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PRO_CODE,
				this._PRO_NAME,
				this._REC_TIME,
				this._REC_PERSON,
				this._WORK_DESC,
				this._COMM_REC,
				this._ACT_PROB_REC,
				this._RESULT,
				this._SUM_UP,
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
			public readonly static Field All = new Field("*", "PRO_EXT_DET_REC");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRO_EXT_DET_REC", "ID");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PRO_CODE = new Field("PRO_CODE", "PRO_EXT_DET_REC", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PRO_NAME = new Field("PRO_NAME", "PRO_EXT_DET_REC", "项目名称");
            /// <summary>
			/// 记录时间
			/// </summary>
			public readonly static Field REC_TIME = new Field("REC_TIME", "PRO_EXT_DET_REC", "记录时间");
            /// <summary>
			/// 记录人员
			/// </summary>
			public readonly static Field REC_PERSON = new Field("REC_PERSON", "PRO_EXT_DET_REC", "记录人员");
            /// <summary>
			/// 工作描述
			/// </summary>
			public readonly static Field WORK_DESC = new Field("WORK_DESC", "PRO_EXT_DET_REC", "工作描述");
            /// <summary>
			/// 沟通记录
			/// </summary>
			public readonly static Field COMM_REC = new Field("COMM_REC", "PRO_EXT_DET_REC", "沟通记录");
            /// <summary>
			/// 事故问题记录
			/// </summary>
			public readonly static Field ACT_PROB_REC = new Field("ACT_PROB_REC", "PRO_EXT_DET_REC", "事故问题记录");
            /// <summary>
			/// 成果
			/// </summary>
			public readonly static Field RESULT = new Field("RESULT", "PRO_EXT_DET_REC", "成果");
            /// <summary>
			/// 总结
			/// </summary>
			public readonly static Field SUM_UP = new Field("SUM_UP", "PRO_EXT_DET_REC", "总结");
        }
        #endregion
	}
}