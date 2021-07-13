using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_REVIEW。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_REVIEW")]
    [Serializable]
    public partial class RECORD_REVIEW : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _REVIEW_CODE;
		private string _REVIEW_TYPE;
		private string _TENDER_PROJECT_CODE;
		private DateTime? _COMMIT_TIME;
		private string _REVIEW_STATUS;
		private DateTime? _SIGN_TIME;
		private string _SIGN_PERSON;
		private string _SIGN_COMMENT;
		private DateTime? _REVIEW_TIME;
		private string _REVIEW_PERSON;
		private string _REVIEW_COMMENT;
		private string _IS_ADJUST;
		private DateTime? _ADJUST_TIME;
		private string _AMENDMENT_OPINION;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _AUDIT_UNIT;
		private decimal? _IS_SIGN;
		private string _ADJUST_PERSON;
		private string _IS_SUBMIT_AGAIN;
		private string _IS_GET_DATA;
		private DateTime? _SIGN_OVER_TM;
		private DateTime? _OVER_TM;
		private string _GET_SYSTEM_NO;
		private DateTime? _GET_DATA_TIME;
		private decimal? _M_ID;

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
		/// 备案编号
		/// </summary>
		public string REVIEW_CODE
		{
			get{ return _REVIEW_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_CODE, _REVIEW_CODE, value);
				this._REVIEW_CODE = value;
			}
		}
		/// <summary>
		/// sys_dic(type=3021)备案类型
		/// </summary>
		public string REVIEW_TYPE
		{
			get{ return _REVIEW_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_TYPE, _REVIEW_TYPE, value);
				this._REVIEW_TYPE = value;
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
		/// 提交时间
		/// </summary>
		public DateTime? COMMIT_TIME
		{
			get{ return _COMMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COMMIT_TIME, _COMMIT_TIME, value);
				this._COMMIT_TIME = value;
			}
		}
		/// <summary>
		/// （0暂存1待审查2退回-不属于本部门监管的项目3退回-备案材料不完整5审查通过6审查不通过)（8签收、9意见修改(无效)） (住建状态：0暂存1未签收2退回-3退回-8已签收4待审核5审核通过6审核不通过)
		/// </summary>
		public string REVIEW_STATUS
		{
			get{ return _REVIEW_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_STATUS, _REVIEW_STATUS, value);
				this._REVIEW_STATUS = value;
			}
		}
		/// <summary>
		/// 签收或退回时间
		/// </summary>
		public DateTime? SIGN_TIME
		{
			get{ return _SIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_TIME, _SIGN_TIME, value);
				this._SIGN_TIME = value;
			}
		}
		/// <summary>
		/// 签收或退回人
		/// </summary>
		public string SIGN_PERSON
		{
			get{ return _SIGN_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_PERSON, _SIGN_PERSON, value);
				this._SIGN_PERSON = value;
			}
		}
		/// <summary>
		/// 签收或退回意见
		/// </summary>
		public string SIGN_COMMENT
		{
			get{ return _SIGN_COMMENT; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_COMMENT, _SIGN_COMMENT, value);
				this._SIGN_COMMENT = value;
			}
		}
		/// <summary>
		/// 审查时间
		/// </summary>
		public DateTime? REVIEW_TIME
		{
			get{ return _REVIEW_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_TIME, _REVIEW_TIME, value);
				this._REVIEW_TIME = value;
			}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string REVIEW_PERSON
		{
			get{ return _REVIEW_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_PERSON, _REVIEW_PERSON, value);
				this._REVIEW_PERSON = value;
			}
		}
		/// <summary>
		/// 审查意见
		/// </summary>
		public string REVIEW_COMMENT
		{
			get{ return _REVIEW_COMMENT; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_COMMENT, _REVIEW_COMMENT, value);
				this._REVIEW_COMMENT = value;
			}
		}
		/// <summary>
		/// 是否进行调整
		/// </summary>
		public string IS_ADJUST
		{
			get{ return _IS_ADJUST; }
			set
			{
				this.OnPropertyValueChange(_.IS_ADJUST, _IS_ADJUST, value);
				this._IS_ADJUST = value;
			}
		}
		/// <summary>
		/// 调整时间
		/// </summary>
		public DateTime? ADJUST_TIME
		{
			get{ return _ADJUST_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ADJUST_TIME, _ADJUST_TIME, value);
				this._ADJUST_TIME = value;
			}
		}
		/// <summary>
		/// 整改意见修改说明
		/// </summary>
		public string AMENDMENT_OPINION
		{
			get{ return _AMENDMENT_OPINION; }
			set
			{
				this.OnPropertyValueChange(_.AMENDMENT_OPINION, _AMENDMENT_OPINION, value);
				this._AMENDMENT_OPINION = value;
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
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 备案部门（无用）
		/// </summary>
		public string AUDIT_UNIT
		{
			get{ return _AUDIT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_UNIT, _AUDIT_UNIT, value);
				this._AUDIT_UNIT = value;
			}
		}
		/// <summary>
		/// 是否签收
		/// </summary>
		public decimal? IS_SIGN
		{
			get{ return _IS_SIGN; }
			set
			{
				this.OnPropertyValueChange(_.IS_SIGN, _IS_SIGN, value);
				this._IS_SIGN = value;
			}
		}
		/// <summary>
		/// 意见修改人
		/// </summary>
		public string ADJUST_PERSON
		{
			get{ return _ADJUST_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.ADJUST_PERSON, _ADJUST_PERSON, value);
				this._ADJUST_PERSON = value;
			}
		}
		/// <summary>
		/// 是否再次提交（0为否，1为是）
		/// </summary>
		public string IS_SUBMIT_AGAIN
		{
			get{ return _IS_SUBMIT_AGAIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_SUBMIT_AGAIN, _IS_SUBMIT_AGAIN, value);
				this._IS_SUBMIT_AGAIN = value;
			}
		}
		/// <summary>
		/// 是否获取数据
		/// </summary>
		public string IS_GET_DATA
		{
			get{ return _IS_GET_DATA; }
			set
			{
				this.OnPropertyValueChange(_.IS_GET_DATA, _IS_GET_DATA, value);
				this._IS_GET_DATA = value;
			}
		}
		/// <summary>
		/// 签收-超时时间(最后处理时间)
		/// </summary>
		public DateTime? SIGN_OVER_TM
		{
			get{ return _SIGN_OVER_TM; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_OVER_TM, _SIGN_OVER_TM, value);
				this._SIGN_OVER_TM = value;
			}
		}
		/// <summary>
		/// 审查-超时时间(最后处理时间)
		/// </summary>
		public DateTime? OVER_TM
		{
			get{ return _OVER_TM; }
			set
			{
				this.OnPropertyValueChange(_.OVER_TM, _OVER_TM, value);
				this._OVER_TM = value;
			}
		}
		/// <summary>
		/// 获取备案数据的用户（最新一个）
		/// </summary>
		public string GET_SYSTEM_NO
		{
			get{ return _GET_SYSTEM_NO; }
			set
			{
				this.OnPropertyValueChange(_.GET_SYSTEM_NO, _GET_SYSTEM_NO, value);
				this._GET_SYSTEM_NO = value;
			}
		}
		/// <summary>
		/// 获取备案数据的时间（最新一个）
		/// </summary>
		public DateTime? GET_DATA_TIME
		{
			get{ return _GET_DATA_TIME; }
			set
			{
				this.OnPropertyValueChange(_.GET_DATA_TIME, _GET_DATA_TIME, value);
				this._GET_DATA_TIME = value;
			}
		}
		/// <summary>
		/// 公共平台，招标项目表M_ID
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
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
				_.REVIEW_CODE,
				_.REVIEW_TYPE,
				_.TENDER_PROJECT_CODE,
				_.COMMIT_TIME,
				_.REVIEW_STATUS,
				_.SIGN_TIME,
				_.SIGN_PERSON,
				_.SIGN_COMMENT,
				_.REVIEW_TIME,
				_.REVIEW_PERSON,
				_.REVIEW_COMMENT,
				_.IS_ADJUST,
				_.ADJUST_TIME,
				_.AMENDMENT_OPINION,
				_.CREATE_TM,
				_.CREATOR,
				_.AUDIT_UNIT,
				_.IS_SIGN,
				_.ADJUST_PERSON,
				_.IS_SUBMIT_AGAIN,
				_.IS_GET_DATA,
				_.SIGN_OVER_TM,
				_.OVER_TM,
				_.GET_SYSTEM_NO,
				_.GET_DATA_TIME,
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REVIEW_CODE,
				this._REVIEW_TYPE,
				this._TENDER_PROJECT_CODE,
				this._COMMIT_TIME,
				this._REVIEW_STATUS,
				this._SIGN_TIME,
				this._SIGN_PERSON,
				this._SIGN_COMMENT,
				this._REVIEW_TIME,
				this._REVIEW_PERSON,
				this._REVIEW_COMMENT,
				this._IS_ADJUST,
				this._ADJUST_TIME,
				this._AMENDMENT_OPINION,
				this._CREATE_TM,
				this._CREATOR,
				this._AUDIT_UNIT,
				this._IS_SIGN,
				this._ADJUST_PERSON,
				this._IS_SUBMIT_AGAIN,
				this._IS_GET_DATA,
				this._SIGN_OVER_TM,
				this._OVER_TM,
				this._GET_SYSTEM_NO,
				this._GET_DATA_TIME,
				this._M_ID,
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
			public readonly static Field All = new Field("*", "RECORD_REVIEW");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_REVIEW", "ID");
            /// <summary>
			/// 备案编号
			/// </summary>
			public readonly static Field REVIEW_CODE = new Field("REVIEW_CODE", "RECORD_REVIEW", "备案编号");
            /// <summary>
			/// sys_dic(type=3021)备案类型
			/// </summary>
			public readonly static Field REVIEW_TYPE = new Field("REVIEW_TYPE", "RECORD_REVIEW", "sys_dic(type=3021)备案类型");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "RECORD_REVIEW", "招标项目编号");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "RECORD_REVIEW", "提交时间");
            /// <summary>
			/// （0暂存1待审查2退回-不属于本部门监管的项目3退回-备案材料不完整5审查通过6审查不通过)（8签收、9意见修改(无效)） (住建状态：0暂存1未签收2退回-3退回-8已签收4待审核5审核通过6审核不通过)
			/// </summary>
			public readonly static Field REVIEW_STATUS = new Field("REVIEW_STATUS", "RECORD_REVIEW", "（0暂存1待审查2退回-不属于本部门监管的项目3退回-备案材料不完整5审查通过6审查不通过)（8签收、9意见修改(无效)） (住建状态：0暂存1未签收2退回-3退回-8已签收4待审核5审核通过6审核不通过)");
            /// <summary>
			/// 签收或退回时间
			/// </summary>
			public readonly static Field SIGN_TIME = new Field("SIGN_TIME", "RECORD_REVIEW", "签收或退回时间");
            /// <summary>
			/// 签收或退回人
			/// </summary>
			public readonly static Field SIGN_PERSON = new Field("SIGN_PERSON", "RECORD_REVIEW", "签收或退回人");
            /// <summary>
			/// 签收或退回意见
			/// </summary>
			public readonly static Field SIGN_COMMENT = new Field("SIGN_COMMENT", "RECORD_REVIEW",DbType.AnsiString, null, "签收或退回意见");
            /// <summary>
			/// 审查时间
			/// </summary>
			public readonly static Field REVIEW_TIME = new Field("REVIEW_TIME", "RECORD_REVIEW", "审查时间");
            /// <summary>
			/// 审核人
			/// </summary>
			public readonly static Field REVIEW_PERSON = new Field("REVIEW_PERSON", "RECORD_REVIEW", "审核人");
            /// <summary>
			/// 审查意见
			/// </summary>
			public readonly static Field REVIEW_COMMENT = new Field("REVIEW_COMMENT", "RECORD_REVIEW",DbType.AnsiString, null, "审查意见");
            /// <summary>
			/// 是否进行调整
			/// </summary>
			public readonly static Field IS_ADJUST = new Field("IS_ADJUST", "RECORD_REVIEW", "是否进行调整");
            /// <summary>
			/// 调整时间
			/// </summary>
			public readonly static Field ADJUST_TIME = new Field("ADJUST_TIME", "RECORD_REVIEW", "调整时间");
            /// <summary>
			/// 整改意见修改说明
			/// </summary>
			public readonly static Field AMENDMENT_OPINION = new Field("AMENDMENT_OPINION", "RECORD_REVIEW", "整改意见修改说明");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_REVIEW", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_REVIEW", "创建人");
            /// <summary>
			/// 备案部门（无用）
			/// </summary>
			public readonly static Field AUDIT_UNIT = new Field("AUDIT_UNIT", "RECORD_REVIEW", "备案部门（无用）");
            /// <summary>
			/// 是否签收
			/// </summary>
			public readonly static Field IS_SIGN = new Field("IS_SIGN", "RECORD_REVIEW", "是否签收");
            /// <summary>
			/// 意见修改人
			/// </summary>
			public readonly static Field ADJUST_PERSON = new Field("ADJUST_PERSON", "RECORD_REVIEW", "意见修改人");
            /// <summary>
			/// 是否再次提交（0为否，1为是）
			/// </summary>
			public readonly static Field IS_SUBMIT_AGAIN = new Field("IS_SUBMIT_AGAIN", "RECORD_REVIEW", "是否再次提交（0为否，1为是）");
            /// <summary>
			/// 是否获取数据
			/// </summary>
			public readonly static Field IS_GET_DATA = new Field("IS_GET_DATA", "RECORD_REVIEW", "是否获取数据");
            /// <summary>
			/// 签收-超时时间(最后处理时间)
			/// </summary>
			public readonly static Field SIGN_OVER_TM = new Field("SIGN_OVER_TM", "RECORD_REVIEW", "签收-超时时间(最后处理时间)");
            /// <summary>
			/// 审查-超时时间(最后处理时间)
			/// </summary>
			public readonly static Field OVER_TM = new Field("OVER_TM", "RECORD_REVIEW", "审查-超时时间(最后处理时间)");
            /// <summary>
			/// 获取备案数据的用户（最新一个）
			/// </summary>
			public readonly static Field GET_SYSTEM_NO = new Field("GET_SYSTEM_NO", "RECORD_REVIEW", "获取备案数据的用户（最新一个）");
            /// <summary>
			/// 获取备案数据的时间（最新一个）
			/// </summary>
			public readonly static Field GET_DATA_TIME = new Field("GET_DATA_TIME", "RECORD_REVIEW", "获取备案数据的时间（最新一个）");
            /// <summary>
			/// 公共平台，招标项目表M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "RECORD_REVIEW", "公共平台，招标项目表M_ID");
        }
        #endregion
	}
}