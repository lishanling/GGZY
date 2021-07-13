using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PT_COMMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_COMMENT")]
    [Serializable]
    public partial class PT_COMMENT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _ARTICLEID;
		private string _COMMENTCONTENT;
		private decimal? _USERID;
		private decimal? _ISSHOW;
		private DateTime? _TM;
		private decimal? _PID;
		private string _IP;
		private string _RCONTENT;
		private DateTime? _RTM;

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
		/// 文章id
		/// </summary>
		public decimal? ARTICLEID
		{
			get{ return _ARTICLEID; }
			set
			{
				this.OnPropertyValueChange(_.ARTICLEID, _ARTICLEID, value);
				this._ARTICLEID = value;
			}
		}
		/// <summary>
		/// 评论内容
		/// </summary>
		public string COMMENTCONTENT
		{
			get{ return _COMMENTCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COMMENTCONTENT, _COMMENTCONTENT, value);
				this._COMMENTCONTENT = value;
			}
		}
		/// <summary>
		/// 用户id
		/// </summary>
		public decimal? USERID
		{
			get{ return _USERID; }
			set
			{
				this.OnPropertyValueChange(_.USERID, _USERID, value);
				this._USERID = value;
			}
		}
		/// <summary>
		/// 是否显示
		/// </summary>
		public decimal? ISSHOW
		{
			get{ return _ISSHOW; }
			set
			{
				this.OnPropertyValueChange(_.ISSHOW, _ISSHOW, value);
				this._ISSHOW = value;
			}
		}
		/// <summary>
		/// 时间
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
		/// 父节点
		/// </summary>
		public decimal? PID
		{
			get{ return _PID; }
			set
			{
				this.OnPropertyValueChange(_.PID, _PID, value);
				this._PID = value;
			}
		}
		/// <summary>
		/// IP
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP, _IP, value);
				this._IP = value;
			}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string RCONTENT
		{
			get{ return _RCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.RCONTENT, _RCONTENT, value);
				this._RCONTENT = value;
			}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? RTM
		{
			get{ return _RTM; }
			set
			{
				this.OnPropertyValueChange(_.RTM, _RTM, value);
				this._RTM = value;
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
				_.ARTICLEID,
				_.COMMENTCONTENT,
				_.USERID,
				_.ISSHOW,
				_.TM,
				_.PID,
				_.IP,
				_.RCONTENT,
				_.RTM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._ARTICLEID,
				this._COMMENTCONTENT,
				this._USERID,
				this._ISSHOW,
				this._TM,
				this._PID,
				this._IP,
				this._RCONTENT,
				this._RTM,
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
			public readonly static Field All = new Field("*", "PT_COMMENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_COMMENT", "");
            /// <summary>
			/// 文章id
			/// </summary>
			public readonly static Field ARTICLEID = new Field("ARTICLEID", "PT_COMMENT", "文章id");
            /// <summary>
			/// 评论内容
			/// </summary>
			public readonly static Field COMMENTCONTENT = new Field("COMMENTCONTENT", "PT_COMMENT",DbType.AnsiString, null, "评论内容");
            /// <summary>
			/// 用户id
			/// </summary>
			public readonly static Field USERID = new Field("USERID", "PT_COMMENT", "用户id");
            /// <summary>
			/// 是否显示
			/// </summary>
			public readonly static Field ISSHOW = new Field("ISSHOW", "PT_COMMENT", "是否显示");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_COMMENT", "时间");
            /// <summary>
			/// 父节点
			/// </summary>
			public readonly static Field PID = new Field("PID", "PT_COMMENT", "父节点");
            /// <summary>
			/// IP
			/// </summary>
			public readonly static Field IP = new Field("IP", "PT_COMMENT", "IP");
            /// <summary>
			/// 回复内容
			/// </summary>
			public readonly static Field RCONTENT = new Field("RCONTENT", "PT_COMMENT",DbType.AnsiString, null, "回复内容");
            /// <summary>
			/// 回复时间
			/// </summary>
			public readonly static Field RTM = new Field("RTM", "PT_COMMENT", "回复时间");
        }
        #endregion
	}
}