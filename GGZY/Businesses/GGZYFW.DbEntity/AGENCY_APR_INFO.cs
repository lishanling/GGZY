using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AGENCY_APR_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AGENCY_APR_INFO")]
    [Serializable]
    public partial class AGENCY_APR_INFO : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _AGENCY_CODE;
		private string _AGENCY_NAME;
		private string _SCORE;
		private string _APR_CONTENT;
		private DateTime? _APR_DATE;
		private string _APR_PERSON;
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
		/// 代理机构编号
		/// </summary>
		public string AGENCY_CODE
		{
			get{ return _AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_CODE, _AGENCY_CODE, value);
				this._AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 代理机构名称
		/// </summary>
		public string AGENCY_NAME
		{
			get{ return _AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_NAME, _AGENCY_NAME, value);
				this._AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 评分
		/// </summary>
		public string SCORE
		{
			get{ return _SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SCORE, _SCORE, value);
				this._SCORE = value;
			}
		}
		/// <summary>
		/// 评价内容
		/// </summary>
		public string APR_CONTENT
		{
			get{ return _APR_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.APR_CONTENT, _APR_CONTENT, value);
				this._APR_CONTENT = value;
			}
		}
		/// <summary>
		/// 评价时间
		/// </summary>
		public DateTime? APR_DATE
		{
			get{ return _APR_DATE; }
			set
			{
				this.OnPropertyValueChange(_.APR_DATE, _APR_DATE, value);
				this._APR_DATE = value;
			}
		}
		/// <summary>
		/// 评价人
		/// </summary>
		public string APR_PERSON
		{
			get{ return _APR_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.APR_PERSON, _APR_PERSON, value);
				this._APR_PERSON = value;
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
				_.AGENCY_CODE,
				_.AGENCY_NAME,
				_.SCORE,
				_.APR_CONTENT,
				_.APR_DATE,
				_.APR_PERSON,
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
				this._AGENCY_CODE,
				this._AGENCY_NAME,
				this._SCORE,
				this._APR_CONTENT,
				this._APR_DATE,
				this._APR_PERSON,
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
			public readonly static Field All = new Field("*", "AGENCY_APR_INFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "AGENCY_APR_INFO", "ID");
            /// <summary>
			/// 代理机构编号
			/// </summary>
			public readonly static Field AGENCY_CODE = new Field("AGENCY_CODE", "AGENCY_APR_INFO", "代理机构编号");
            /// <summary>
			/// 代理机构名称
			/// </summary>
			public readonly static Field AGENCY_NAME = new Field("AGENCY_NAME", "AGENCY_APR_INFO", "代理机构名称");
            /// <summary>
			/// 评分
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "AGENCY_APR_INFO", "评分");
            /// <summary>
			/// 评价内容
			/// </summary>
			public readonly static Field APR_CONTENT = new Field("APR_CONTENT", "AGENCY_APR_INFO", "评价内容");
            /// <summary>
			/// 评价时间
			/// </summary>
			public readonly static Field APR_DATE = new Field("APR_DATE", "AGENCY_APR_INFO", "评价时间");
            /// <summary>
			/// 评价人
			/// </summary>
			public readonly static Field APR_PERSON = new Field("APR_PERSON", "AGENCY_APR_INFO", "评价人");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "AGENCY_APR_INFO", "备注");
        }
        #endregion
	}
}