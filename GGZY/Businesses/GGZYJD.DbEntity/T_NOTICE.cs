using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_NOTICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_NOTICE")]
    [Serializable]
    public partial class T_NOTICE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private decimal? _U_ID;
		private decimal? _IMG_AID;
		private string _CONTENTS_SHORT;
		private string _CONTENTS;
		private DateTime? _TM;
		private string _STATE;
		private decimal? _ISTOP;
		private string _FLAGS;
		private decimal? _ORDERID;
		private decimal? _REMOTE;
		private decimal? _AUTOLITPIC;

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
		/// 展示图片
		/// </summary>
		public decimal? IMG_AID
		{
			get{ return _IMG_AID; }
			set
			{
				this.OnPropertyValueChange(_.IMG_AID, _IMG_AID, value);
				this._IMG_AID = value;
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
				_.U_ID,
				_.IMG_AID,
				_.CONTENTS_SHORT,
				_.CONTENTS,
				_.TM,
				_.STATE,
				_.ISTOP,
				_.FLAGS,
				_.ORDERID,
				_.REMOTE,
				_.AUTOLITPIC,
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
				this._U_ID,
				this._IMG_AID,
				this._CONTENTS_SHORT,
				this._CONTENTS,
				this._TM,
				this._STATE,
				this._ISTOP,
				this._FLAGS,
				this._ORDERID,
				this._REMOTE,
				this._AUTOLITPIC,
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
			public readonly static Field All = new Field("*", "T_NOTICE");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_NOTICE", "编号");
            /// <summary>
			/// 文章标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_NOTICE", "文章标题");
            /// <summary>
			/// 发布人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_NOTICE", "发布人");
            /// <summary>
			/// 展示图片
			/// </summary>
			public readonly static Field IMG_AID = new Field("IMG_AID", "T_NOTICE", "展示图片");
            /// <summary>
			/// 内容说明
			/// </summary>
			public readonly static Field CONTENTS_SHORT = new Field("CONTENTS_SHORT", "T_NOTICE", "内容说明");
            /// <summary>
			/// 文章内容
			/// </summary>
			public readonly static Field CONTENTS = new Field("CONTENTS", "T_NOTICE", "文章内容");
            /// <summary>
			/// 发布日期
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_NOTICE", "发布日期");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "T_NOTICE", "状态");
            /// <summary>
			/// 是否置顶
			/// </summary>
			public readonly static Field ISTOP = new Field("ISTOP", "T_NOTICE", "是否置顶");
            /// <summary>
			/// 自定义属性
			/// </summary>
			public readonly static Field FLAGS = new Field("FLAGS", "T_NOTICE", "自定义属性");
            /// <summary>
			/// 排序ID
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "T_NOTICE", "排序ID");
            /// <summary>
			/// 下载远程图片和资源
			/// </summary>
			public readonly static Field REMOTE = new Field("REMOTE", "T_NOTICE", "下载远程图片和资源");
            /// <summary>
			/// 提取第一个图片为缩略图
			/// </summary>
			public readonly static Field AUTOLITPIC = new Field("AUTOLITPIC", "T_NOTICE", "提取第一个图片为缩略图");
        }
        #endregion
	}
}