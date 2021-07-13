using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRO_EX_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRO_EX_RESULT")]
    [Serializable]
    public partial class PRO_EX_RESULT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRO_CODE;
		private string _PRO_NAME;
		private string _PHS_METHOD;
		private DateTime? _ELT_STIME;
		private string _ELT_DAYS;
		private string _CNT_PERSON;
		private string _CNT_TEL;
		private string _EX_CODE;
		private string _EX_NAME;
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
		/// 采购方式
		/// </summary>
		public string PHS_METHOD
		{
			get{ return _PHS_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.PHS_METHOD, _PHS_METHOD, value);
				this._PHS_METHOD = value;
			}
		}
		/// <summary>
		/// 评标开始时间
		/// </summary>
		public DateTime? ELT_STIME
		{
			get{ return _ELT_STIME; }
			set
			{
				this.OnPropertyValueChange(_.ELT_STIME, _ELT_STIME, value);
				this._ELT_STIME = value;
			}
		}
		/// <summary>
		/// 评标时间(天)
		/// </summary>
		public string ELT_DAYS
		{
			get{ return _ELT_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.ELT_DAYS, _ELT_DAYS, value);
				this._ELT_DAYS = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CNT_PERSON
		{
			get{ return _CNT_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.CNT_PERSON, _CNT_PERSON, value);
				this._CNT_PERSON = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CNT_TEL
		{
			get{ return _CNT_TEL; }
			set
			{
				this.OnPropertyValueChange(_.CNT_TEL, _CNT_TEL, value);
				this._CNT_TEL = value;
			}
		}
		/// <summary>
		/// 专家编号
		/// </summary>
		public string EX_CODE
		{
			get{ return _EX_CODE; }
			set
			{
				this.OnPropertyValueChange(_.EX_CODE, _EX_CODE, value);
				this._EX_CODE = value;
			}
		}
		/// <summary>
		/// 专家姓名
		/// </summary>
		public string EX_NAME
		{
			get{ return _EX_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EX_NAME, _EX_NAME, value);
				this._EX_NAME = value;
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
				_.PRO_NAME,
				_.PHS_METHOD,
				_.ELT_STIME,
				_.ELT_DAYS,
				_.CNT_PERSON,
				_.CNT_TEL,
				_.EX_CODE,
				_.EX_NAME,
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
				this._PRO_NAME,
				this._PHS_METHOD,
				this._ELT_STIME,
				this._ELT_DAYS,
				this._CNT_PERSON,
				this._CNT_TEL,
				this._EX_CODE,
				this._EX_NAME,
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
			public readonly static Field All = new Field("*", "PRO_EX_RESULT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRO_EX_RESULT", "ID");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PRO_CODE = new Field("PRO_CODE", "PRO_EX_RESULT", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PRO_NAME = new Field("PRO_NAME", "PRO_EX_RESULT", "项目名称");
            /// <summary>
			/// 采购方式
			/// </summary>
			public readonly static Field PHS_METHOD = new Field("PHS_METHOD", "PRO_EX_RESULT", "采购方式");
            /// <summary>
			/// 评标开始时间
			/// </summary>
			public readonly static Field ELT_STIME = new Field("ELT_STIME", "PRO_EX_RESULT", "评标开始时间");
            /// <summary>
			/// 评标时间(天)
			/// </summary>
			public readonly static Field ELT_DAYS = new Field("ELT_DAYS", "PRO_EX_RESULT", "评标时间(天)");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CNT_PERSON = new Field("CNT_PERSON", "PRO_EX_RESULT", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CNT_TEL = new Field("CNT_TEL", "PRO_EX_RESULT", "联系电话");
            /// <summary>
			/// 专家编号
			/// </summary>
			public readonly static Field EX_CODE = new Field("EX_CODE", "PRO_EX_RESULT", "专家编号");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EX_NAME = new Field("EX_NAME", "PRO_EX_RESULT", "专家姓名");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "PRO_EX_RESULT", "备注");
        }
        #endregion
	}
}