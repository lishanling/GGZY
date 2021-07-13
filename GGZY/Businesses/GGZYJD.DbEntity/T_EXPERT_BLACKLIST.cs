using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_EXPERT_BLACKLIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EXPERT_BLACKLIST")]
    [Serializable]
    public partial class T_EXPERT_BLACKLIST : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _EXPERT_NO;
		private string _EXPERT_NAME;
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private string _REASON_BLACK;
		private string _M_ATTACHMENT;
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
		/// 专家编号
		/// </summary>
		public string EXPERT_NO
		{
			get{ return _EXPERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NO, _EXPERT_NO, value);
				this._EXPERT_NO = value;
			}
		}
		/// <summary>
		/// 专家姓名
		/// </summary>
		public string EXPERT_NAME
		{
			get{ return _EXPERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NAME, _EXPERT_NAME, value);
				this._EXPERT_NAME = value;
			}
		}
		/// <summary>
		/// 身份证件号码
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 身份证件类型
		/// </summary>
		public string ID_CARD_TYPE
		{
			get{ return _ID_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_TYPE, _ID_CARD_TYPE, value);
				this._ID_CARD_TYPE = value;
			}
		}
		/// <summary>
		/// 列入黑名单原因
		/// </summary>
		public string REASON_BLACK
		{
			get{ return _REASON_BLACK; }
			set
			{
				this.OnPropertyValueChange(_.REASON_BLACK, _REASON_BLACK, value);
				this._REASON_BLACK = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string M_ATTACHMENT
		{
			get{ return _M_ATTACHMENT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATTACHMENT, _M_ATTACHMENT, value);
				this._M_ATTACHMENT = value;
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
				_.EXPERT_NO,
				_.EXPERT_NAME,
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.REASON_BLACK,
				_.M_ATTACHMENT,
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
				this._EXPERT_NO,
				this._EXPERT_NAME,
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._REASON_BLACK,
				this._M_ATTACHMENT,
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
			public readonly static Field All = new Field("*", "T_EXPERT_BLACKLIST");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_EXPERT_BLACKLIST", "ID");
            /// <summary>
			/// 专家编号
			/// </summary>
			public readonly static Field EXPERT_NO = new Field("EXPERT_NO", "T_EXPERT_BLACKLIST", "专家编号");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EXPERT_NAME = new Field("EXPERT_NAME", "T_EXPERT_BLACKLIST", "专家姓名");
            /// <summary>
			/// 身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "T_EXPERT_BLACKLIST", "身份证件号码");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "T_EXPERT_BLACKLIST", "身份证件类型");
            /// <summary>
			/// 列入黑名单原因
			/// </summary>
			public readonly static Field REASON_BLACK = new Field("REASON_BLACK", "T_EXPERT_BLACKLIST",DbType.AnsiString, null, "列入黑名单原因");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field M_ATTACHMENT = new Field("M_ATTACHMENT", "T_EXPERT_BLACKLIST", "附件");
            /// <summary>
			/// 数据上传用户
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_EXPERT_BLACKLIST", "数据上传用户");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_EXPERT_BLACKLIST", "数据上传时间");
            /// <summary>
			/// 数据对应的key
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_EXPERT_BLACKLIST", "数据对应的key");
        }
        #endregion
	}
}