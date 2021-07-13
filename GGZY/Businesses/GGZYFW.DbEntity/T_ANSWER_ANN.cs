using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ANSWER_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ANSWER_ANN")]
    [Serializable]
    public partial class T_ANSWER_ANN : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _ANN_ID;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _ANN_CONTENT;
		private decimal? _M_CREATOR;
		private DateTime? _M_TM;
		private string _M_ATT_FILE_EX_TDOC;
		private string _TITLE;
		private decimal? _M_ZPID;
		private decimal? _M_STATUS;
		private string _M_REMARK;

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
		/// 招标公告外键ID
		/// </summary>
		public decimal? ANN_ID
		{
			get{ return _ANN_ID; }
			set
			{
				this.OnPropertyValueChange(_.ANN_ID, _ANN_ID, value);
				this._ANN_ID = value;
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
		/// 相关标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
			}
		}
		/// <summary>
		/// 答疑公示内容
		/// </summary>
		public string ANN_CONTENT
		{
			get{ return _ANN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.ANN_CONTENT, _ANN_CONTENT, value);
				this._ANN_CONTENT = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// ???????????????PDF????
		/// </summary>
		public string M_ATT_FILE_EX_TDOC
		{
			get{ return _M_ATT_FILE_EX_TDOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_FILE_EX_TDOC, _M_ATT_FILE_EX_TDOC, value);
				this._M_ATT_FILE_EX_TDOC = value;
			}
		}
		/// <summary>
		/// 答疑公示标题
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_ZPID
		{
			get{ return _M_ZPID; }
			set
			{
				this.OnPropertyValueChange(_.M_ZPID, _M_ZPID, value);
				this._M_ZPID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_STATUS
		{
			get{ return _M_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.M_STATUS, _M_STATUS, value);
				this._M_STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_REMARK
		{
			get{ return _M_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.M_REMARK, _M_REMARK, value);
				this._M_REMARK = value;
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
				_.ANN_ID,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODES,
				_.ANN_CONTENT,
				_.M_CREATOR,
				_.M_TM,
				_.M_ATT_FILE_EX_TDOC,
				_.TITLE,
				_.M_ZPID,
				_.M_STATUS,
				_.M_REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._ANN_ID,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODES,
				this._ANN_CONTENT,
				this._M_CREATOR,
				this._M_TM,
				this._M_ATT_FILE_EX_TDOC,
				this._TITLE,
				this._M_ZPID,
				this._M_STATUS,
				this._M_REMARK,
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
			public readonly static Field All = new Field("*", "T_ANSWER_ANN");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_ANSWER_ANN", "");
            /// <summary>
			/// 招标公告外键ID
			/// </summary>
			public readonly static Field ANN_ID = new Field("ANN_ID", "T_ANSWER_ANN", "招标公告外键ID");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_ANSWER_ANN", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "T_ANSWER_ANN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 答疑公示内容
			/// </summary>
			public readonly static Field ANN_CONTENT = new Field("ANN_CONTENT", "T_ANSWER_ANN",DbType.AnsiString, null, "答疑公示内容");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "T_ANSWER_ANN", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_ANSWER_ANN", "创建时间");
            /// <summary>
			/// ???????????????PDF????
			/// </summary>
			public readonly static Field M_ATT_FILE_EX_TDOC = new Field("M_ATT_FILE_EX_TDOC", "T_ANSWER_ANN", "???????????????PDF????");
            /// <summary>
			/// 答疑公示标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_ANSWER_ANN", "答疑公示标题");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ZPID = new Field("M_ZPID", "T_ANSWER_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_STATUS = new Field("M_STATUS", "T_ANSWER_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_REMARK = new Field("M_REMARK", "T_ANSWER_ANN", "");
        }
        #endregion
	}
}