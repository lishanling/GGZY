using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_COMPLAINTS_PROCESS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_COMPLAINTS_PROCESS")]
    [Serializable]
    public partial class T_COMPLAINTS_PROCESS : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _ITEM_NUM;
		private string _PRO_NAME;
		private string _PRO_TYPE;
		private string _COMPLAINT;
		private string _CODE;
		private string _NAME;
		private string _CONTENT;
		private DateTime? _TIME;
		private string _ACCEPTOR;
		private DateTime? _RECRPTION_TIME;
		private string _DEAL_PEO;
		private DateTime? _DEAL_TIME;
		private string _PRO_CONTENT;
		private string _PUBLISHER;
		private DateTime? _PUB_TIME;
		private string _ANNEX;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_KEY;

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
		public string ITEM_NUM
		{
			get{ return _ITEM_NUM; }
			set
			{
				this.OnPropertyValueChange(_.ITEM_NUM, _ITEM_NUM, value);
				this._ITEM_NUM = value;
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
		/// 项目类型
		/// </summary>
		public string PRO_TYPE
		{
			get{ return _PRO_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PRO_TYPE, _PRO_TYPE, value);
				this._PRO_TYPE = value;
			}
		}
		/// <summary>
		/// 投诉类型
		/// </summary>
		public string COMPLAINT
		{
			get{ return _COMPLAINT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT, _COMPLAINT, value);
				this._COMPLAINT = value;
			}
		}
		/// <summary>
		/// 投诉人代码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 投诉人名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 投诉内容
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 投诉时间
		/// </summary>
		public DateTime? TIME
		{
			get{ return _TIME; }
			set
			{
				this.OnPropertyValueChange(_.TIME, _TIME, value);
				this._TIME = value;
			}
		}
		/// <summary>
		/// 受理人
		/// </summary>
		public string ACCEPTOR
		{
			get{ return _ACCEPTOR; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPTOR, _ACCEPTOR, value);
				this._ACCEPTOR = value;
			}
		}
		/// <summary>
		/// 受理时间
		/// </summary>
		public DateTime? RECRPTION_TIME
		{
			get{ return _RECRPTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.RECRPTION_TIME, _RECRPTION_TIME, value);
				this._RECRPTION_TIME = value;
			}
		}
		/// <summary>
		/// 处理人
		/// </summary>
		public string DEAL_PEO
		{
			get{ return _DEAL_PEO; }
			set
			{
				this.OnPropertyValueChange(_.DEAL_PEO, _DEAL_PEO, value);
				this._DEAL_PEO = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? DEAL_TIME
		{
			get{ return _DEAL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DEAL_TIME, _DEAL_TIME, value);
				this._DEAL_TIME = value;
			}
		}
		/// <summary>
		/// 处理内容
		/// </summary>
		public string PRO_CONTENT
		{
			get{ return _PRO_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PRO_CONTENT, _PRO_CONTENT, value);
				this._PRO_CONTENT = value;
			}
		}
		/// <summary>
		/// 发布人
		/// </summary>
		public string PUBLISHER
		{
			get{ return _PUBLISHER; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISHER, _PUBLISHER, value);
				this._PUBLISHER = value;
			}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? PUB_TIME
		{
			get{ return _PUB_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUB_TIME, _PUB_TIME, value);
				this._PUB_TIME = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string ANNEX
		{
			get{ return _ANNEX; }
			set
			{
				this.OnPropertyValueChange(_.ANNEX, _ANNEX, value);
				this._ANNEX = value;
			}
		}
		/// <summary>
		/// 数据上传用户
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 数据上传时间
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
		/// 数据对应的key
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
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
				_.ITEM_NUM,
				_.PRO_NAME,
				_.PRO_TYPE,
				_.COMPLAINT,
				_.CODE,
				_.NAME,
				_.CONTENT,
				_.TIME,
				_.ACCEPTOR,
				_.RECRPTION_TIME,
				_.DEAL_PEO,
				_.DEAL_TIME,
				_.PRO_CONTENT,
				_.PUBLISHER,
				_.PUB_TIME,
				_.ANNEX,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_KEY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._ITEM_NUM,
				this._PRO_NAME,
				this._PRO_TYPE,
				this._COMPLAINT,
				this._CODE,
				this._NAME,
				this._CONTENT,
				this._TIME,
				this._ACCEPTOR,
				this._RECRPTION_TIME,
				this._DEAL_PEO,
				this._DEAL_TIME,
				this._PRO_CONTENT,
				this._PUBLISHER,
				this._PUB_TIME,
				this._ANNEX,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_KEY,
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
			public readonly static Field All = new Field("*", "T_COMPLAINTS_PROCESS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_COMPLAINTS_PROCESS", "ID");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field ITEM_NUM = new Field("ITEM_NUM", "T_COMPLAINTS_PROCESS", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PRO_NAME = new Field("PRO_NAME", "T_COMPLAINTS_PROCESS", "项目名称");
            /// <summary>
			/// 项目类型
			/// </summary>
			public readonly static Field PRO_TYPE = new Field("PRO_TYPE", "T_COMPLAINTS_PROCESS", "项目类型");
            /// <summary>
			/// 投诉类型
			/// </summary>
			public readonly static Field COMPLAINT = new Field("COMPLAINT", "T_COMPLAINTS_PROCESS", "投诉类型");
            /// <summary>
			/// 投诉人代码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_COMPLAINTS_PROCESS", "投诉人代码");
            /// <summary>
			/// 投诉人名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_COMPLAINTS_PROCESS", "投诉人名称");
            /// <summary>
			/// 投诉内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_COMPLAINTS_PROCESS", "投诉内容");
            /// <summary>
			/// 投诉时间
			/// </summary>
			public readonly static Field TIME = new Field("TIME", "T_COMPLAINTS_PROCESS", "投诉时间");
            /// <summary>
			/// 受理人
			/// </summary>
			public readonly static Field ACCEPTOR = new Field("ACCEPTOR", "T_COMPLAINTS_PROCESS", "受理人");
            /// <summary>
			/// 受理时间
			/// </summary>
			public readonly static Field RECRPTION_TIME = new Field("RECRPTION_TIME", "T_COMPLAINTS_PROCESS", "受理时间");
            /// <summary>
			/// 处理人
			/// </summary>
			public readonly static Field DEAL_PEO = new Field("DEAL_PEO", "T_COMPLAINTS_PROCESS", "处理人");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field DEAL_TIME = new Field("DEAL_TIME", "T_COMPLAINTS_PROCESS", "处理时间");
            /// <summary>
			/// 处理内容
			/// </summary>
			public readonly static Field PRO_CONTENT = new Field("PRO_CONTENT", "T_COMPLAINTS_PROCESS", "处理内容");
            /// <summary>
			/// 发布人
			/// </summary>
			public readonly static Field PUBLISHER = new Field("PUBLISHER", "T_COMPLAINTS_PROCESS", "发布人");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field PUB_TIME = new Field("PUB_TIME", "T_COMPLAINTS_PROCESS", "发布时间");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field ANNEX = new Field("ANNEX", "T_COMPLAINTS_PROCESS", "附件");
            /// <summary>
			/// 数据上传用户
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_COMPLAINTS_PROCESS", "数据上传用户");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_COMPLAINTS_PROCESS", "数据上传时间");
            /// <summary>
			/// 数据对应的key
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_COMPLAINTS_PROCESS", "数据对应的key");
        }
        #endregion
	}
}