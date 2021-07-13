using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ARTICLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ARTICLE")]
    [Serializable]
    public partial class PT_ARTICLE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _TITLE_SHORT;
		private string _SOURCES;
		private string _WRITER;
		private decimal? _U_ID;
		private string _TYPE;
		private string _CONTENTS_SHORT;
		private string _CONTENTS;
		private DateTime? _TM;
		private decimal? _READ_NUM;
		private string _STATE;
		private decimal? _ISTOP;
		private string _FLAGS;
		private decimal? _ORDERID;
		private decimal? _REMOTE;
		private decimal? _AUTOLITPIC;
		private DateTime? _CREATE_TM;
		private decimal? _IMG_NEWS;
		private decimal? _IS_IMPORT;
		private decimal? _IS_REPLY;
		private string _AIDS;
		private string _IMG_AID;

		/// <summary>
		/// 编号
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
		/// 文章标题
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
		/// 简略标题
		/// </summary>
		public string TITLE_SHORT
		{
			get{ return _TITLE_SHORT; }
			set
			{
				this.OnPropertyValueChange(_.TITLE_SHORT, _TITLE_SHORT, value);
				this._TITLE_SHORT = value;
			}
		}
		/// <summary>
		/// 文章来源
		/// </summary>
		public string SOURCES
		{
			get{ return _SOURCES; }
			set
			{
				this.OnPropertyValueChange(_.SOURCES, _SOURCES, value);
				this._SOURCES = value;
			}
		}
		/// <summary>
		/// 作者
		/// </summary>
		public string WRITER
		{
			get{ return _WRITER; }
			set
			{
				this.OnPropertyValueChange(_.WRITER, _WRITER, value);
				this._WRITER = value;
			}
		}
		/// <summary>
		/// 发布人
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 文章类型
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 内容说明
		/// </summary>
		public string CONTENTS_SHORT
		{
			get{ return _CONTENTS_SHORT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENTS_SHORT, _CONTENTS_SHORT, value);
				this._CONTENTS_SHORT = value;
			}
		}
		/// <summary>
		/// 文章内容
		/// </summary>
		public string CONTENTS
		{
			get{ return _CONTENTS; }
			set
			{
				this.OnPropertyValueChange(_.CONTENTS, _CONTENTS, value);
				this._CONTENTS = value;
			}
		}
		/// <summary>
		/// 发布日期
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 阅读次数
		/// </summary>
		public decimal? READ_NUM
		{
			get{ return _READ_NUM; }
			set
			{
				this.OnPropertyValueChange(_.READ_NUM, _READ_NUM, value);
				this._READ_NUM = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public string STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 是否置顶
		/// </summary>
		public decimal? ISTOP
		{
			get{ return _ISTOP; }
			set
			{
				this.OnPropertyValueChange(_.ISTOP, _ISTOP, value);
				this._ISTOP = value;
			}
		}
		/// <summary>
		/// 自定义属性
		/// </summary>
		public string FLAGS
		{
			get{ return _FLAGS; }
			set
			{
				this.OnPropertyValueChange(_.FLAGS, _FLAGS, value);
				this._FLAGS = value;
			}
		}
		/// <summary>
		/// 排序ID
		/// </summary>
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
			}
		}
		/// <summary>
		/// 下载远程图片和资源
		/// </summary>
		public decimal? REMOTE
		{
			get{ return _REMOTE; }
			set
			{
				this.OnPropertyValueChange(_.REMOTE, _REMOTE, value);
				this._REMOTE = value;
			}
		}
		/// <summary>
		/// 提取第一个图片为缩略图
		/// </summary>
		public decimal? AUTOLITPIC
		{
			get{ return _AUTOLITPIC; }
			set
			{
				this.OnPropertyValueChange(_.AUTOLITPIC, _AUTOLITPIC, value);
				this._AUTOLITPIC = value;
			}
		}
		/// <summary>
		/// 创建日期
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
		/// 图片新闻
		/// </summary>
		public decimal? IMG_NEWS
		{
			get{ return _IMG_NEWS; }
			set
			{
				this.OnPropertyValueChange(_.IMG_NEWS, _IMG_NEWS, value);
				this._IMG_NEWS = value;
			}
		}
		/// <summary>
		/// 是否重要通知(仅通知公告有效)
		/// </summary>
		public decimal? IS_IMPORT
		{
			get{ return _IS_IMPORT; }
			set
			{
				this.OnPropertyValueChange(_.IS_IMPORT, _IS_IMPORT, value);
				this._IS_IMPORT = value;
			}
		}
		/// <summary>
		/// 是否可以回复
		/// </summary>
		public decimal? IS_REPLY
		{
			get{ return _IS_REPLY; }
			set
			{
				this.OnPropertyValueChange(_.IS_REPLY, _IS_REPLY, value);
				this._IS_REPLY = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string AIDS
		{
			get{ return _AIDS; }
			set
			{
				this.OnPropertyValueChange(_.AIDS, _AIDS, value);
				this._AIDS = value;
			}
		}
		/// <summary>
		/// 展示图片
		/// </summary>
		public string IMG_AID
		{
			get{ return _IMG_AID; }
			set
			{
				this.OnPropertyValueChange(_.IMG_AID, _IMG_AID, value);
				this._IMG_AID = value;
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
				_.TITLE,
				_.TITLE_SHORT,
				_.SOURCES,
				_.WRITER,
				_.U_ID,
				_.TYPE,
				_.CONTENTS_SHORT,
				_.CONTENTS,
				_.TM,
				_.READ_NUM,
				_.STATE,
				_.ISTOP,
				_.FLAGS,
				_.ORDERID,
				_.REMOTE,
				_.AUTOLITPIC,
				_.CREATE_TM,
				_.IMG_NEWS,
				_.IS_IMPORT,
				_.IS_REPLY,
				_.AIDS,
				_.IMG_AID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._TITLE_SHORT,
				this._SOURCES,
				this._WRITER,
				this._U_ID,
				this._TYPE,
				this._CONTENTS_SHORT,
				this._CONTENTS,
				this._TM,
				this._READ_NUM,
				this._STATE,
				this._ISTOP,
				this._FLAGS,
				this._ORDERID,
				this._REMOTE,
				this._AUTOLITPIC,
				this._CREATE_TM,
				this._IMG_NEWS,
				this._IS_IMPORT,
				this._IS_REPLY,
				this._AIDS,
				this._IMG_AID,
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
			public readonly static Field All = new Field("*", "PT_ARTICLE");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ARTICLE", "编号");
            /// <summary>
			/// 文章标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "PT_ARTICLE", "文章标题");
            /// <summary>
			/// 简略标题
			/// </summary>
			public readonly static Field TITLE_SHORT = new Field("TITLE_SHORT", "PT_ARTICLE", "简略标题");
            /// <summary>
			/// 文章来源
			/// </summary>
			public readonly static Field SOURCES = new Field("SOURCES", "PT_ARTICLE", "文章来源");
            /// <summary>
			/// 作者
			/// </summary>
			public readonly static Field WRITER = new Field("WRITER", "PT_ARTICLE", "作者");
            /// <summary>
			/// 发布人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "PT_ARTICLE", "发布人");
            /// <summary>
			/// 文章类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "PT_ARTICLE", "文章类型");
            /// <summary>
			/// 内容说明
			/// </summary>
			public readonly static Field CONTENTS_SHORT = new Field("CONTENTS_SHORT", "PT_ARTICLE", "内容说明");
            /// <summary>
			/// 文章内容
			/// </summary>
			public readonly static Field CONTENTS = new Field("CONTENTS", "PT_ARTICLE", "文章内容");
            /// <summary>
			/// 发布日期
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_ARTICLE", "发布日期");
            /// <summary>
			/// 阅读次数
			/// </summary>
			public readonly static Field READ_NUM = new Field("READ_NUM", "PT_ARTICLE", "阅读次数");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "PT_ARTICLE", "状态");
            /// <summary>
			/// 是否置顶
			/// </summary>
			public readonly static Field ISTOP = new Field("ISTOP", "PT_ARTICLE", "是否置顶");
            /// <summary>
			/// 自定义属性
			/// </summary>
			public readonly static Field FLAGS = new Field("FLAGS", "PT_ARTICLE", "自定义属性");
            /// <summary>
			/// 排序ID
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "PT_ARTICLE", "排序ID");
            /// <summary>
			/// 下载远程图片和资源
			/// </summary>
			public readonly static Field REMOTE = new Field("REMOTE", "PT_ARTICLE", "下载远程图片和资源");
            /// <summary>
			/// 提取第一个图片为缩略图
			/// </summary>
			public readonly static Field AUTOLITPIC = new Field("AUTOLITPIC", "PT_ARTICLE", "提取第一个图片为缩略图");
            /// <summary>
			/// 创建日期
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_ARTICLE", "创建日期");
            /// <summary>
			/// 图片新闻
			/// </summary>
			public readonly static Field IMG_NEWS = new Field("IMG_NEWS", "PT_ARTICLE", "图片新闻");
            /// <summary>
			/// 是否重要通知(仅通知公告有效)
			/// </summary>
			public readonly static Field IS_IMPORT = new Field("IS_IMPORT", "PT_ARTICLE", "是否重要通知(仅通知公告有效)");
            /// <summary>
			/// 是否可以回复
			/// </summary>
			public readonly static Field IS_REPLY = new Field("IS_REPLY", "PT_ARTICLE", "是否可以回复");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field AIDS = new Field("AIDS", "PT_ARTICLE", "附件");
            /// <summary>
			/// 展示图片
			/// </summary>
			public readonly static Field IMG_AID = new Field("IMG_AID", "PT_ARTICLE", "展示图片");
        }
        #endregion
	}
}