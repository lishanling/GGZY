using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TPA_QA_TABLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TPA_QA_TABLE")]
    [Serializable]
    public partial class TPA_QA_TABLE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRO_CODE;
		private string _QS_TITLE;
		private string _TEN_TITLE;
		private string _QS_CONTENT;
		private DateTime? _QS_DATE;
		private string _TEN_PERSON;
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
		/// 答疑标题
		/// </summary>
		public string QS_TITLE
		{
			get{ return _QS_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.QS_TITLE, _QS_TITLE, value);
				this._QS_TITLE = value;
			}
		}
		/// <summary>
		/// 招标标题
		/// </summary>
		public string TEN_TITLE
		{
			get{ return _TEN_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TEN_TITLE, _TEN_TITLE, value);
				this._TEN_TITLE = value;
			}
		}
		/// <summary>
		/// 答疑内容
		/// </summary>
		public string QS_CONTENT
		{
			get{ return _QS_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.QS_CONTENT, _QS_CONTENT, value);
				this._QS_CONTENT = value;
			}
		}
		/// <summary>
		/// 答疑日期
		/// </summary>
		public DateTime? QS_DATE
		{
			get{ return _QS_DATE; }
			set
			{
				this.OnPropertyValueChange(_.QS_DATE, _QS_DATE, value);
				this._QS_DATE = value;
			}
		}
		/// <summary>
		/// 招标人
		/// </summary>
		public string TEN_PERSON
		{
			get{ return _TEN_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.TEN_PERSON, _TEN_PERSON, value);
				this._TEN_PERSON = value;
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
				_.PRO_CODE,
				_.QS_TITLE,
				_.TEN_TITLE,
				_.QS_CONTENT,
				_.QS_DATE,
				_.TEN_PERSON,
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
				this._PRO_CODE,
				this._QS_TITLE,
				this._TEN_TITLE,
				this._QS_CONTENT,
				this._QS_DATE,
				this._TEN_PERSON,
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
			public readonly static Field All = new Field("*", "TPA_QA_TABLE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TPA_QA_TABLE", "ID");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PRO_CODE = new Field("PRO_CODE", "TPA_QA_TABLE", "项目编号");
            /// <summary>
			/// 答疑标题
			/// </summary>
			public readonly static Field QS_TITLE = new Field("QS_TITLE", "TPA_QA_TABLE", "答疑标题");
            /// <summary>
			/// 招标标题
			/// </summary>
			public readonly static Field TEN_TITLE = new Field("TEN_TITLE", "TPA_QA_TABLE", "招标标题");
            /// <summary>
			/// 答疑内容
			/// </summary>
			public readonly static Field QS_CONTENT = new Field("QS_CONTENT", "TPA_QA_TABLE", "答疑内容");
            /// <summary>
			/// 答疑日期
			/// </summary>
			public readonly static Field QS_DATE = new Field("QS_DATE", "TPA_QA_TABLE", "答疑日期");
            /// <summary>
			/// 招标人
			/// </summary>
			public readonly static Field TEN_PERSON = new Field("TEN_PERSON", "TPA_QA_TABLE", "招标人");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "TPA_QA_TABLE", "备注");
        }
        #endregion
	}
}