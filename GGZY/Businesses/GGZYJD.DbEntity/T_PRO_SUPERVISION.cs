using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PRO_SUPERVISION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PRO_SUPERVISION")]
    [Serializable]
    public partial class T_PRO_SUPERVISION : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRO_PLA_NUM;
		private string _PRO_NAME_NUM;
		private string _LOT_NUM;
		private string _PROJECT;
		private string _ANNOUNCE;
		private string _TEN_PUR_TRA;
		private string _QUA_REV;
		private string _Q_A;
		private string _MARGIN;
		private string _OPEN_BIDS;
		private string _WINNING_BID;
		private string _WINNING_NOTICE;
		private string _PRO_STATUS;
		private string _PRO_PROCESS;
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
		/// 项目交易平台编号
		/// </summary>
		public string PRO_PLA_NUM
		{
			get{ return _PRO_PLA_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PRO_PLA_NUM, _PRO_PLA_NUM, value);
				this._PRO_PLA_NUM = value;
			}
		}
		/// <summary>
		/// 项目名称及编号
		/// </summary>
		public string PRO_NAME_NUM
		{
			get{ return _PRO_NAME_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PRO_NAME_NUM, _PRO_NAME_NUM, value);
				this._PRO_NAME_NUM = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string LOT_NUM
		{
			get{ return _LOT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.LOT_NUM, _LOT_NUM, value);
				this._LOT_NUM = value;
			}
		}
		/// <summary>
		/// 立项
		/// </summary>
		public string PROJECT
		{
			get{ return _PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT, _PROJECT, value);
				this._PROJECT = value;
			}
		}
		/// <summary>
		/// 公告
		/// </summary>
		public string ANNOUNCE
		{
			get{ return _ANNOUNCE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCE, _ANNOUNCE, value);
				this._ANNOUNCE = value;
			}
		}
		/// <summary>
		/// 招标/采购/出让文件
		/// </summary>
		public string TEN_PUR_TRA
		{
			get{ return _TEN_PUR_TRA; }
			set
			{
				this.OnPropertyValueChange(_.TEN_PUR_TRA, _TEN_PUR_TRA, value);
				this._TEN_PUR_TRA = value;
			}
		}
		/// <summary>
		/// 资格审查
		/// </summary>
		public string QUA_REV
		{
			get{ return _QUA_REV; }
			set
			{
				this.OnPropertyValueChange(_.QUA_REV, _QUA_REV, value);
				this._QUA_REV = value;
			}
		}
		/// <summary>
		/// 答疑
		/// </summary>
		public string Q_A
		{
			get{ return _Q_A; }
			set
			{
				this.OnPropertyValueChange(_.Q_A, _Q_A, value);
				this._Q_A = value;
			}
		}
		/// <summary>
		/// 保证金
		/// </summary>
		public string MARGIN
		{
			get{ return _MARGIN; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN, _MARGIN, value);
				this._MARGIN = value;
			}
		}
		/// <summary>
		/// 开标/竞价情况
		/// </summary>
		public string OPEN_BIDS
		{
			get{ return _OPEN_BIDS; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_BIDS, _OPEN_BIDS, value);
				this._OPEN_BIDS = value;
			}
		}
		/// <summary>
		/// 中标/成交公示
		/// </summary>
		public string WINNING_BID
		{
			get{ return _WINNING_BID; }
			set
			{
				this.OnPropertyValueChange(_.WINNING_BID, _WINNING_BID, value);
				this._WINNING_BID = value;
			}
		}
		/// <summary>
		/// 中标/成交通知书
		/// </summary>
		public string WINNING_NOTICE
		{
			get{ return _WINNING_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.WINNING_NOTICE, _WINNING_NOTICE, value);
				this._WINNING_NOTICE = value;
			}
		}
		/// <summary>
		/// 项目状态
		/// </summary>
		public string PRO_STATUS
		{
			get{ return _PRO_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.PRO_STATUS, _PRO_STATUS, value);
				this._PRO_STATUS = value;
			}
		}
		/// <summary>
		/// 项目进程
		/// </summary>
		public string PRO_PROCESS
		{
			get{ return _PRO_PROCESS; }
			set
			{
				this.OnPropertyValueChange(_.PRO_PROCESS, _PRO_PROCESS, value);
				this._PRO_PROCESS = value;
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
				_.PRO_PLA_NUM,
				_.PRO_NAME_NUM,
				_.LOT_NUM,
				_.PROJECT,
				_.ANNOUNCE,
				_.TEN_PUR_TRA,
				_.QUA_REV,
				_.Q_A,
				_.MARGIN,
				_.OPEN_BIDS,
				_.WINNING_BID,
				_.WINNING_NOTICE,
				_.PRO_STATUS,
				_.PRO_PROCESS,
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
				this._PRO_PLA_NUM,
				this._PRO_NAME_NUM,
				this._LOT_NUM,
				this._PROJECT,
				this._ANNOUNCE,
				this._TEN_PUR_TRA,
				this._QUA_REV,
				this._Q_A,
				this._MARGIN,
				this._OPEN_BIDS,
				this._WINNING_BID,
				this._WINNING_NOTICE,
				this._PRO_STATUS,
				this._PRO_PROCESS,
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
			public readonly static Field All = new Field("*", "T_PRO_SUPERVISION");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PRO_SUPERVISION", "ID");
            /// <summary>
			/// 项目交易平台编号
			/// </summary>
			public readonly static Field PRO_PLA_NUM = new Field("PRO_PLA_NUM", "T_PRO_SUPERVISION", "项目交易平台编号");
            /// <summary>
			/// 项目名称及编号
			/// </summary>
			public readonly static Field PRO_NAME_NUM = new Field("PRO_NAME_NUM", "T_PRO_SUPERVISION", "项目名称及编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field LOT_NUM = new Field("LOT_NUM", "T_PRO_SUPERVISION", "标段（包）编号");
            /// <summary>
			/// 立项
			/// </summary>
			public readonly static Field PROJECT = new Field("PROJECT", "T_PRO_SUPERVISION", "立项");
            /// <summary>
			/// 公告
			/// </summary>
			public readonly static Field ANNOUNCE = new Field("ANNOUNCE", "T_PRO_SUPERVISION", "公告");
            /// <summary>
			/// 招标/采购/出让文件
			/// </summary>
			public readonly static Field TEN_PUR_TRA = new Field("TEN_PUR_TRA", "T_PRO_SUPERVISION", "招标/采购/出让文件");
            /// <summary>
			/// 资格审查
			/// </summary>
			public readonly static Field QUA_REV = new Field("QUA_REV", "T_PRO_SUPERVISION", "资格审查");
            /// <summary>
			/// 答疑
			/// </summary>
			public readonly static Field Q_A = new Field("Q_A", "T_PRO_SUPERVISION", "答疑");
            /// <summary>
			/// 保证金
			/// </summary>
			public readonly static Field MARGIN = new Field("MARGIN", "T_PRO_SUPERVISION", "保证金");
            /// <summary>
			/// 开标/竞价情况
			/// </summary>
			public readonly static Field OPEN_BIDS = new Field("OPEN_BIDS", "T_PRO_SUPERVISION", "开标/竞价情况");
            /// <summary>
			/// 中标/成交公示
			/// </summary>
			public readonly static Field WINNING_BID = new Field("WINNING_BID", "T_PRO_SUPERVISION", "中标/成交公示");
            /// <summary>
			/// 中标/成交通知书
			/// </summary>
			public readonly static Field WINNING_NOTICE = new Field("WINNING_NOTICE", "T_PRO_SUPERVISION", "中标/成交通知书");
            /// <summary>
			/// 项目状态
			/// </summary>
			public readonly static Field PRO_STATUS = new Field("PRO_STATUS", "T_PRO_SUPERVISION", "项目状态");
            /// <summary>
			/// 项目进程
			/// </summary>
			public readonly static Field PRO_PROCESS = new Field("PRO_PROCESS", "T_PRO_SUPERVISION", "项目进程");
            /// <summary>
			/// 数据上传用户
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_PRO_SUPERVISION", "数据上传用户");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_PRO_SUPERVISION", "数据上传时间");
            /// <summary>
			/// 数据对应的key
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_PRO_SUPERVISION", "数据对应的key");
        }
        #endregion
	}
}