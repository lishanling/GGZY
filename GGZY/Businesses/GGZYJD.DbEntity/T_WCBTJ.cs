using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_WCBTJ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_WCBTJ")]
    [Serializable]
    public partial class T_WCBTJ : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _BIDDER_NAME;
		private string _BIDDER_ORG_CODE;
		private string _BID_DOCUMENT_NAME;
		private DateTime? _TENDER_DOC_SUBMITTIME;
		private string _MAC_ADDRESS;
		private string _NET_ID;
		private string _CPU_ID;

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
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 标段包编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 标段包名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人代码
		/// </summary>
		public string BIDDER_ORG_CODE
		{
			get{ return _BIDDER_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ORG_CODE, _BIDDER_ORG_CODE, value);
				this._BIDDER_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 投标文件名称
		/// </summary>
		public string BID_DOCUMENT_NAME
		{
			get{ return _BID_DOCUMENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOCUMENT_NAME, _BID_DOCUMENT_NAME, value);
				this._BID_DOCUMENT_NAME = value;
			}
		}
		/// <summary>
		/// 投标文件提交时间
		/// </summary>
		public DateTime? TENDER_DOC_SUBMITTIME
		{
			get{ return _TENDER_DOC_SUBMITTIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_SUBMITTIME, _TENDER_DOC_SUBMITTIME, value);
				this._TENDER_DOC_SUBMITTIME = value;
			}
		}
		/// <summary>
		/// MAC地址
		/// </summary>
		public string MAC_ADDRESS
		{
			get{ return _MAC_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.MAC_ADDRESS, _MAC_ADDRESS, value);
				this._MAC_ADDRESS = value;
			}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string NET_ID
		{
			get{ return _NET_ID; }
			set
			{
				this.OnPropertyValueChange(_.NET_ID, _NET_ID, value);
				this._NET_ID = value;
			}
		}
		/// <summary>
		/// CPU码
		/// </summary>
		public string CPU_ID
		{
			get{ return _CPU_ID; }
			set
			{
				this.OnPropertyValueChange(_.CPU_ID, _CPU_ID, value);
				this._CPU_ID = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.BIDDER_NAME,
				_.BIDDER_ORG_CODE,
				_.BID_DOCUMENT_NAME,
				_.TENDER_DOC_SUBMITTIME,
				_.MAC_ADDRESS,
				_.NET_ID,
				_.CPU_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._BIDDER_NAME,
				this._BIDDER_ORG_CODE,
				this._BID_DOCUMENT_NAME,
				this._TENDER_DOC_SUBMITTIME,
				this._MAC_ADDRESS,
				this._NET_ID,
				this._CPU_ID,
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
			public readonly static Field All = new Field("*", "T_WCBTJ");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_WCBTJ", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "T_WCBTJ", "招标项目名称");
            /// <summary>
			/// 标段包编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "T_WCBTJ", "标段包编号");
            /// <summary>
			/// 标段包名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "T_WCBTJ", "标段包名称");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "T_WCBTJ", "投标人名称");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "T_WCBTJ", "投标人代码");
            /// <summary>
			/// 投标文件名称
			/// </summary>
			public readonly static Field BID_DOCUMENT_NAME = new Field("BID_DOCUMENT_NAME", "T_WCBTJ", "投标文件名称");
            /// <summary>
			/// 投标文件提交时间
			/// </summary>
			public readonly static Field TENDER_DOC_SUBMITTIME = new Field("TENDER_DOC_SUBMITTIME", "T_WCBTJ", "投标文件提交时间");
            /// <summary>
			/// MAC地址
			/// </summary>
			public readonly static Field MAC_ADDRESS = new Field("MAC_ADDRESS", "T_WCBTJ", "MAC地址");
            /// <summary>
			/// IP地址
			/// </summary>
			public readonly static Field NET_ID = new Field("NET_ID", "T_WCBTJ", "IP地址");
            /// <summary>
			/// CPU码
			/// </summary>
			public readonly static Field CPU_ID = new Field("CPU_ID", "T_WCBTJ", "CPU码");
        }
        #endregion
	}
}