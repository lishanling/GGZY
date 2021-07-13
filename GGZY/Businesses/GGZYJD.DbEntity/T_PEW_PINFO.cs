using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PEW_PINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PEW_PINFO")]
    [Serializable]
    public partial class T_PEW_PINFO : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _PROT_PNUM;
		private string _PRO_NAME;
		private string _PRO_NUM;
		private string _TEN_NUM;
		private string _SUTP;
		private string _NOTICE;
		private string _BPS_FILE;
		private string _QTIONS_REVIEW;
		private string _Q_A;
		private string _S_DEP;
		private string _OBB_SITUATION;
		private string _WTBD_PUBLICITY;
		private string _WTBD_NOTICE;
		private string _PRO_STATUS;
		private string _PRO_PROCESS;
		private string _CPT_INFO;
		private string _STS_REPORT;
		private string _EPT_EXTRACT;
		private string _EPT_EVAL;
		private string _EPT_BLACKLIST;
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
		public string PROT_PNUM
		{
			get{ return _PROT_PNUM; }
			set
			{
				this.OnPropertyValueChange(_.PROT_PNUM, _PROT_PNUM, value);
				this._PROT_PNUM = value;
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
		/// 项目编号
		/// </summary>
		public string PRO_NUM
		{
			get{ return _PRO_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PRO_NUM, _PRO_NUM, value);
				this._PRO_NUM = value;
			}
		}
		/// <summary>
		/// 标段编号
		/// </summary>
		public string TEN_NUM
		{
			get{ return _TEN_NUM; }
			set
			{
				this.OnPropertyValueChange(_.TEN_NUM, _TEN_NUM, value);
				this._TEN_NUM = value;
			}
		}
		/// <summary>
		/// 立项
		/// </summary>
		public string SUTP
		{
			get{ return _SUTP; }
			set
			{
				this.OnPropertyValueChange(_.SUTP, _SUTP, value);
				this._SUTP = value;
			}
		}
		/// <summary>
		/// 公告
		/// </summary>
		public string NOTICE
		{
			get{ return _NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE, _NOTICE, value);
				this._NOTICE = value;
			}
		}
		/// <summary>
		/// 招标/采购/出让文件
		/// </summary>
		public string BPS_FILE
		{
			get{ return _BPS_FILE; }
			set
			{
				this.OnPropertyValueChange(_.BPS_FILE, _BPS_FILE, value);
				this._BPS_FILE = value;
			}
		}
		/// <summary>
		/// 资格审查
		/// </summary>
		public string QTIONS_REVIEW
		{
			get{ return _QTIONS_REVIEW; }
			set
			{
				this.OnPropertyValueChange(_.QTIONS_REVIEW, _QTIONS_REVIEW, value);
				this._QTIONS_REVIEW = value;
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
		public string S_DEP
		{
			get{ return _S_DEP; }
			set
			{
				this.OnPropertyValueChange(_.S_DEP, _S_DEP, value);
				this._S_DEP = value;
			}
		}
		/// <summary>
		/// 开标/竞价情况
		/// </summary>
		public string OBB_SITUATION
		{
			get{ return _OBB_SITUATION; }
			set
			{
				this.OnPropertyValueChange(_.OBB_SITUATION, _OBB_SITUATION, value);
				this._OBB_SITUATION = value;
			}
		}
		/// <summary>
		/// 中标/成交公示
		/// </summary>
		public string WTBD_PUBLICITY
		{
			get{ return _WTBD_PUBLICITY; }
			set
			{
				this.OnPropertyValueChange(_.WTBD_PUBLICITY, _WTBD_PUBLICITY, value);
				this._WTBD_PUBLICITY = value;
			}
		}
		/// <summary>
		/// 中标/成交通知书
		/// </summary>
		public string WTBD_NOTICE
		{
			get{ return _WTBD_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.WTBD_NOTICE, _WTBD_NOTICE, value);
				this._WTBD_NOTICE = value;
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
		/// 投诉信息
		/// </summary>
		public string CPT_INFO
		{
			get{ return _CPT_INFO; }
			set
			{
				this.OnPropertyValueChange(_.CPT_INFO, _CPT_INFO, value);
				this._CPT_INFO = value;
			}
		}
		/// <summary>
		/// 统计报表
		/// </summary>
		public string STS_REPORT
		{
			get{ return _STS_REPORT; }
			set
			{
				this.OnPropertyValueChange(_.STS_REPORT, _STS_REPORT, value);
				this._STS_REPORT = value;
			}
		}
		/// <summary>
		/// 专家抽取情况
		/// </summary>
		public string EPT_EXTRACT
		{
			get{ return _EPT_EXTRACT; }
			set
			{
				this.OnPropertyValueChange(_.EPT_EXTRACT, _EPT_EXTRACT, value);
				this._EPT_EXTRACT = value;
			}
		}
		/// <summary>
		/// 专家评价信息
		/// </summary>
		public string EPT_EVAL
		{
			get{ return _EPT_EVAL; }
			set
			{
				this.OnPropertyValueChange(_.EPT_EVAL, _EPT_EVAL, value);
				this._EPT_EVAL = value;
			}
		}
		/// <summary>
		/// 专家黑名单信息
		/// </summary>
		public string EPT_BLACKLIST
		{
			get{ return _EPT_BLACKLIST; }
			set
			{
				this.OnPropertyValueChange(_.EPT_BLACKLIST, _EPT_BLACKLIST, value);
				this._EPT_BLACKLIST = value;
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
				_.PROT_PNUM,
				_.PRO_NAME,
				_.PRO_NUM,
				_.TEN_NUM,
				_.SUTP,
				_.NOTICE,
				_.BPS_FILE,
				_.QTIONS_REVIEW,
				_.Q_A,
				_.S_DEP,
				_.OBB_SITUATION,
				_.WTBD_PUBLICITY,
				_.WTBD_NOTICE,
				_.PRO_STATUS,
				_.PRO_PROCESS,
				_.CPT_INFO,
				_.STS_REPORT,
				_.EPT_EXTRACT,
				_.EPT_EVAL,
				_.EPT_BLACKLIST,
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
				this._PROT_PNUM,
				this._PRO_NAME,
				this._PRO_NUM,
				this._TEN_NUM,
				this._SUTP,
				this._NOTICE,
				this._BPS_FILE,
				this._QTIONS_REVIEW,
				this._Q_A,
				this._S_DEP,
				this._OBB_SITUATION,
				this._WTBD_PUBLICITY,
				this._WTBD_NOTICE,
				this._PRO_STATUS,
				this._PRO_PROCESS,
				this._CPT_INFO,
				this._STS_REPORT,
				this._EPT_EXTRACT,
				this._EPT_EVAL,
				this._EPT_BLACKLIST,
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
			public readonly static Field All = new Field("*", "T_PEW_PINFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PEW_PINFO", "ID");
            /// <summary>
			/// 项目交易平台编号
			/// </summary>
			public readonly static Field PROT_PNUM = new Field("PROT_PNUM", "T_PEW_PINFO", "项目交易平台编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PRO_NAME = new Field("PRO_NAME", "T_PEW_PINFO", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PRO_NUM = new Field("PRO_NUM", "T_PEW_PINFO", "项目编号");
            /// <summary>
			/// 标段编号
			/// </summary>
			public readonly static Field TEN_NUM = new Field("TEN_NUM", "T_PEW_PINFO", "标段编号");
            /// <summary>
			/// 立项
			/// </summary>
			public readonly static Field SUTP = new Field("SUTP", "T_PEW_PINFO", "立项");
            /// <summary>
			/// 公告
			/// </summary>
			public readonly static Field NOTICE = new Field("NOTICE", "T_PEW_PINFO", "公告");
            /// <summary>
			/// 招标/采购/出让文件
			/// </summary>
			public readonly static Field BPS_FILE = new Field("BPS_FILE", "T_PEW_PINFO", "招标/采购/出让文件");
            /// <summary>
			/// 资格审查
			/// </summary>
			public readonly static Field QTIONS_REVIEW = new Field("QTIONS_REVIEW", "T_PEW_PINFO", "资格审查");
            /// <summary>
			/// 答疑
			/// </summary>
			public readonly static Field Q_A = new Field("Q_A", "T_PEW_PINFO", "答疑");
            /// <summary>
			/// 保证金
			/// </summary>
			public readonly static Field S_DEP = new Field("S_DEP", "T_PEW_PINFO", "保证金");
            /// <summary>
			/// 开标/竞价情况
			/// </summary>
			public readonly static Field OBB_SITUATION = new Field("OBB_SITUATION", "T_PEW_PINFO", "开标/竞价情况");
            /// <summary>
			/// 中标/成交公示
			/// </summary>
			public readonly static Field WTBD_PUBLICITY = new Field("WTBD_PUBLICITY", "T_PEW_PINFO", "中标/成交公示");
            /// <summary>
			/// 中标/成交通知书
			/// </summary>
			public readonly static Field WTBD_NOTICE = new Field("WTBD_NOTICE", "T_PEW_PINFO", "中标/成交通知书");
            /// <summary>
			/// 项目状态
			/// </summary>
			public readonly static Field PRO_STATUS = new Field("PRO_STATUS", "T_PEW_PINFO", "项目状态");
            /// <summary>
			/// 项目进程
			/// </summary>
			public readonly static Field PRO_PROCESS = new Field("PRO_PROCESS", "T_PEW_PINFO", "项目进程");
            /// <summary>
			/// 投诉信息
			/// </summary>
			public readonly static Field CPT_INFO = new Field("CPT_INFO", "T_PEW_PINFO", "投诉信息");
            /// <summary>
			/// 统计报表
			/// </summary>
			public readonly static Field STS_REPORT = new Field("STS_REPORT", "T_PEW_PINFO", "统计报表");
            /// <summary>
			/// 专家抽取情况
			/// </summary>
			public readonly static Field EPT_EXTRACT = new Field("EPT_EXTRACT", "T_PEW_PINFO", "专家抽取情况");
            /// <summary>
			/// 专家评价信息
			/// </summary>
			public readonly static Field EPT_EVAL = new Field("EPT_EVAL", "T_PEW_PINFO", "专家评价信息");
            /// <summary>
			/// 专家黑名单信息
			/// </summary>
			public readonly static Field EPT_BLACKLIST = new Field("EPT_BLACKLIST", "T_PEW_PINFO", "专家黑名单信息");
            /// <summary>
			/// 数据上传用户
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_PEW_PINFO", "数据上传用户");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_PEW_PINFO", "数据上传时间");
            /// <summary>
			/// 数据对应的key
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_PEW_PINFO", "数据对应的key");
        }
        #endregion
	}
}