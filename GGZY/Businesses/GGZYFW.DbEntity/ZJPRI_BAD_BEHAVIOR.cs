using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_BAD_BEHAVIOR。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_BAD_BEHAVIOR")]
    [Serializable]
    public partial class ZJPRI_BAD_BEHAVIOR : FwEntity
    {
        #region Model
		private string _UK_ID;
		private string _STATE;
		private string _QYBSM;
		private string _CORPSCCODE;
		private string _CORPCODE;
		private string _CORPNAME;
		private string _PUNISHTYPE;
		private string _EVALUATECRITERION;
		private string _EVALUATEEVIDENCE;
		private string _PUNISHFILENAME;
		private string _PUNISHFILENUM;
		private string _PUNISHDEPARTNAME;
		private DateTime? _PUNISHDATE;
		private DateTime? _PUNISHSDATE;
		private DateTime? _PUNISHEDATE;
		private string _PRJNAME;
		private string _MINISTRYPRJNUM;
		private string _PROVICEPRJNUM;
		private string _PUNISHREASON;
		private string _PUNISHEVIDENCE;
		private string _PUNISHRESULT;
		private decimal? _CREDITSCORE;
		private string _CREATEDEPNAME;
		private string _CREATEUSERNAME;
		private DateTime? _CREATEDATE;
		private string _CORPTYPE;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;

		/// <summary>
		/// 唯一标识码
		/// </summary>
		public string UK_ID
		{
			get{ return _UK_ID; }
			set
			{
				this.OnPropertyValueChange(_.UK_ID, _UK_ID, value);
				this._UK_ID = value;
			}
		}
		/// <summary>
		/// 评价状态
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
		/// 企业标识码
		/// </summary>
		public string QYBSM
		{
			get{ return _QYBSM; }
			set
			{
				this.OnPropertyValueChange(_.QYBSM, _QYBSM, value);
				this._QYBSM = value;
			}
		}
		/// <summary>
		/// 企业信用代码
		/// </summary>
		public string CORPSCCODE
		{
			get{ return _CORPSCCODE; }
			set
			{
				this.OnPropertyValueChange(_.CORPSCCODE, _CORPSCCODE, value);
				this._CORPSCCODE = value;
			}
		}
		/// <summary>
		/// 企业机构代码
		/// </summary>
		public string CORPCODE
		{
			get{ return _CORPCODE; }
			set
			{
				this.OnPropertyValueChange(_.CORPCODE, _CORPCODE, value);
				this._CORPCODE = value;
			}
		}
		/// <summary>
		/// 企业名称
		/// </summary>
		public string CORPNAME
		{
			get{ return _CORPNAME; }
			set
			{
				this.OnPropertyValueChange(_.CORPNAME, _CORPNAME, value);
				this._CORPNAME = value;
			}
		}
		/// <summary>
		/// 处罚类别
		/// </summary>
		public string PUNISHTYPE
		{
			get{ return _PUNISHTYPE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHTYPE, _PUNISHTYPE, value);
				this._PUNISHTYPE = value;
			}
		}
		/// <summary>
		/// 评价标准
		/// </summary>
		public string EVALUATECRITERION
		{
			get{ return _EVALUATECRITERION; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATECRITERION, _EVALUATECRITERION, value);
				this._EVALUATECRITERION = value;
			}
		}
		/// <summary>
		/// 评价描述
		/// </summary>
		public string EVALUATEEVIDENCE
		{
			get{ return _EVALUATEEVIDENCE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATEEVIDENCE, _EVALUATEEVIDENCE, value);
				this._EVALUATEEVIDENCE = value;
			}
		}
		/// <summary>
		/// 处罚文件名称
		/// </summary>
		public string PUNISHFILENAME
		{
			get{ return _PUNISHFILENAME; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHFILENAME, _PUNISHFILENAME, value);
				this._PUNISHFILENAME = value;
			}
		}
		/// <summary>
		/// 处罚文件文号
		/// </summary>
		public string PUNISHFILENUM
		{
			get{ return _PUNISHFILENUM; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHFILENUM, _PUNISHFILENUM, value);
				this._PUNISHFILENUM = value;
			}
		}
		/// <summary>
		/// 处罚发布机关单位
		/// </summary>
		public string PUNISHDEPARTNAME
		{
			get{ return _PUNISHDEPARTNAME; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHDEPARTNAME, _PUNISHDEPARTNAME, value);
				this._PUNISHDEPARTNAME = value;
			}
		}
		/// <summary>
		/// 处罚日期
		/// </summary>
		public DateTime? PUNISHDATE
		{
			get{ return _PUNISHDATE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHDATE, _PUNISHDATE, value);
				this._PUNISHDATE = value;
			}
		}
		/// <summary>
		/// 处罚开始日期
		/// </summary>
		public DateTime? PUNISHSDATE
		{
			get{ return _PUNISHSDATE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHSDATE, _PUNISHSDATE, value);
				this._PUNISHSDATE = value;
			}
		}
		/// <summary>
		/// 处罚截至日期
		/// </summary>
		public DateTime? PUNISHEDATE
		{
			get{ return _PUNISHEDATE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHEDATE, _PUNISHEDATE, value);
				this._PUNISHEDATE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PRJNAME
		{
			get{ return _PRJNAME; }
			set
			{
				this.OnPropertyValueChange(_.PRJNAME, _PRJNAME, value);
				this._PRJNAME = value;
			}
		}
		/// <summary>
		/// 项目编号(部)
		/// </summary>
		public string MINISTRYPRJNUM
		{
			get{ return _MINISTRYPRJNUM; }
			set
			{
				this.OnPropertyValueChange(_.MINISTRYPRJNUM, _MINISTRYPRJNUM, value);
				this._MINISTRYPRJNUM = value;
			}
		}
		/// <summary>
		/// 工程代码(省)
		/// </summary>
		public string PROVICEPRJNUM
		{
			get{ return _PROVICEPRJNUM; }
			set
			{
				this.OnPropertyValueChange(_.PROVICEPRJNUM, _PROVICEPRJNUM, value);
				this._PROVICEPRJNUM = value;
			}
		}
		/// <summary>
		/// 处罚事由
		/// </summary>
		public string PUNISHREASON
		{
			get{ return _PUNISHREASON; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHREASON, _PUNISHREASON, value);
				this._PUNISHREASON = value;
			}
		}
		/// <summary>
		/// 处罚依据
		/// </summary>
		public string PUNISHEVIDENCE
		{
			get{ return _PUNISHEVIDENCE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHEVIDENCE, _PUNISHEVIDENCE, value);
				this._PUNISHEVIDENCE = value;
			}
		}
		/// <summary>
		/// 处罚结果
		/// </summary>
		public string PUNISHRESULT
		{
			get{ return _PUNISHRESULT; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHRESULT, _PUNISHRESULT, value);
				this._PUNISHRESULT = value;
			}
		}
		/// <summary>
		/// 信用分数
		/// </summary>
		public decimal? CREDITSCORE
		{
			get{ return _CREDITSCORE; }
			set
			{
				this.OnPropertyValueChange(_.CREDITSCORE, _CREDITSCORE, value);
				this._CREDITSCORE = value;
			}
		}
		/// <summary>
		/// 登记部门
		/// </summary>
		public string CREATEDEPNAME
		{
			get{ return _CREATEDEPNAME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDEPNAME, _CREATEDEPNAME, value);
				this._CREATEDEPNAME = value;
			}
		}
		/// <summary>
		/// 登记人姓名
		/// </summary>
		public string CREATEUSERNAME
		{
			get{ return _CREATEUSERNAME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEUSERNAME, _CREATEUSERNAME, value);
				this._CREATEUSERNAME = value;
			}
		}
		/// <summary>
		/// 登记日期
		/// </summary>
		public DateTime? CREATEDATE
		{
			get{ return _CREATEDATE; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDATE, _CREATEDATE, value);
				this._CREATEDATE = value;
			}
		}
		/// <summary>
		/// 企业类别
		/// </summary>
		public string CORPTYPE
		{
			get{ return _CORPTYPE; }
			set
			{
				this.OnPropertyValueChange(_.CORPTYPE, _CORPTYPE, value);
				this._CORPTYPE = value;
			}
		}
		/// <summary>
		/// 全局唯一标识符
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 版本号
		/// </summary>
		public string VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string DATA_SOURCE
		{
			get{ return _DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.DATA_SOURCE, _DATA_SOURCE, value);
				this._DATA_SOURCE = value;
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
				_.UK_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.UK_ID,
				_.STATE,
				_.QYBSM,
				_.CORPSCCODE,
				_.CORPCODE,
				_.CORPNAME,
				_.PUNISHTYPE,
				_.EVALUATECRITERION,
				_.EVALUATEEVIDENCE,
				_.PUNISHFILENAME,
				_.PUNISHFILENUM,
				_.PUNISHDEPARTNAME,
				_.PUNISHDATE,
				_.PUNISHSDATE,
				_.PUNISHEDATE,
				_.PRJNAME,
				_.MINISTRYPRJNUM,
				_.PROVICEPRJNUM,
				_.PUNISHREASON,
				_.PUNISHEVIDENCE,
				_.PUNISHRESULT,
				_.CREDITSCORE,
				_.CREATEDEPNAME,
				_.CREATEUSERNAME,
				_.CREATEDATE,
				_.CORPTYPE,
				_.GUID,
				_.CREATE_TIME,
				_.VERSION,
				_.DATA_SOURCE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._UK_ID,
				this._STATE,
				this._QYBSM,
				this._CORPSCCODE,
				this._CORPCODE,
				this._CORPNAME,
				this._PUNISHTYPE,
				this._EVALUATECRITERION,
				this._EVALUATEEVIDENCE,
				this._PUNISHFILENAME,
				this._PUNISHFILENUM,
				this._PUNISHDEPARTNAME,
				this._PUNISHDATE,
				this._PUNISHSDATE,
				this._PUNISHEDATE,
				this._PRJNAME,
				this._MINISTRYPRJNUM,
				this._PROVICEPRJNUM,
				this._PUNISHREASON,
				this._PUNISHEVIDENCE,
				this._PUNISHRESULT,
				this._CREDITSCORE,
				this._CREATEDEPNAME,
				this._CREATEUSERNAME,
				this._CREATEDATE,
				this._CORPTYPE,
				this._GUID,
				this._CREATE_TIME,
				this._VERSION,
				this._DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "ZJPRI_BAD_BEHAVIOR");
            /// <summary>
			/// 唯一标识码
			/// </summary>
			public readonly static Field UK_ID = new Field("UK_ID", "ZJPRI_BAD_BEHAVIOR", "唯一标识码");
            /// <summary>
			/// 评价状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "ZJPRI_BAD_BEHAVIOR", "评价状态");
            /// <summary>
			/// 企业标识码
			/// </summary>
			public readonly static Field QYBSM = new Field("QYBSM", "ZJPRI_BAD_BEHAVIOR", "企业标识码");
            /// <summary>
			/// 企业信用代码
			/// </summary>
			public readonly static Field CORPSCCODE = new Field("CORPSCCODE", "ZJPRI_BAD_BEHAVIOR", "企业信用代码");
            /// <summary>
			/// 企业机构代码
			/// </summary>
			public readonly static Field CORPCODE = new Field("CORPCODE", "ZJPRI_BAD_BEHAVIOR", "企业机构代码");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field CORPNAME = new Field("CORPNAME", "ZJPRI_BAD_BEHAVIOR", "企业名称");
            /// <summary>
			/// 处罚类别
			/// </summary>
			public readonly static Field PUNISHTYPE = new Field("PUNISHTYPE", "ZJPRI_BAD_BEHAVIOR", "处罚类别");
            /// <summary>
			/// 评价标准
			/// </summary>
			public readonly static Field EVALUATECRITERION = new Field("EVALUATECRITERION", "ZJPRI_BAD_BEHAVIOR", "评价标准");
            /// <summary>
			/// 评价描述
			/// </summary>
			public readonly static Field EVALUATEEVIDENCE = new Field("EVALUATEEVIDENCE", "ZJPRI_BAD_BEHAVIOR", "评价描述");
            /// <summary>
			/// 处罚文件名称
			/// </summary>
			public readonly static Field PUNISHFILENAME = new Field("PUNISHFILENAME", "ZJPRI_BAD_BEHAVIOR", "处罚文件名称");
            /// <summary>
			/// 处罚文件文号
			/// </summary>
			public readonly static Field PUNISHFILENUM = new Field("PUNISHFILENUM", "ZJPRI_BAD_BEHAVIOR", "处罚文件文号");
            /// <summary>
			/// 处罚发布机关单位
			/// </summary>
			public readonly static Field PUNISHDEPARTNAME = new Field("PUNISHDEPARTNAME", "ZJPRI_BAD_BEHAVIOR", "处罚发布机关单位");
            /// <summary>
			/// 处罚日期
			/// </summary>
			public readonly static Field PUNISHDATE = new Field("PUNISHDATE", "ZJPRI_BAD_BEHAVIOR", "处罚日期");
            /// <summary>
			/// 处罚开始日期
			/// </summary>
			public readonly static Field PUNISHSDATE = new Field("PUNISHSDATE", "ZJPRI_BAD_BEHAVIOR", "处罚开始日期");
            /// <summary>
			/// 处罚截至日期
			/// </summary>
			public readonly static Field PUNISHEDATE = new Field("PUNISHEDATE", "ZJPRI_BAD_BEHAVIOR", "处罚截至日期");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PRJNAME = new Field("PRJNAME", "ZJPRI_BAD_BEHAVIOR", "项目名称");
            /// <summary>
			/// 项目编号(部)
			/// </summary>
			public readonly static Field MINISTRYPRJNUM = new Field("MINISTRYPRJNUM", "ZJPRI_BAD_BEHAVIOR", "项目编号(部)");
            /// <summary>
			/// 工程代码(省)
			/// </summary>
			public readonly static Field PROVICEPRJNUM = new Field("PROVICEPRJNUM", "ZJPRI_BAD_BEHAVIOR", "工程代码(省)");
            /// <summary>
			/// 处罚事由
			/// </summary>
			public readonly static Field PUNISHREASON = new Field("PUNISHREASON", "ZJPRI_BAD_BEHAVIOR",DbType.AnsiString, null, "处罚事由");
            /// <summary>
			/// 处罚依据
			/// </summary>
			public readonly static Field PUNISHEVIDENCE = new Field("PUNISHEVIDENCE", "ZJPRI_BAD_BEHAVIOR",DbType.AnsiString, null, "处罚依据");
            /// <summary>
			/// 处罚结果
			/// </summary>
			public readonly static Field PUNISHRESULT = new Field("PUNISHRESULT", "ZJPRI_BAD_BEHAVIOR",DbType.AnsiString, null, "处罚结果");
            /// <summary>
			/// 信用分数
			/// </summary>
			public readonly static Field CREDITSCORE = new Field("CREDITSCORE", "ZJPRI_BAD_BEHAVIOR", "信用分数");
            /// <summary>
			/// 登记部门
			/// </summary>
			public readonly static Field CREATEDEPNAME = new Field("CREATEDEPNAME", "ZJPRI_BAD_BEHAVIOR", "登记部门");
            /// <summary>
			/// 登记人姓名
			/// </summary>
			public readonly static Field CREATEUSERNAME = new Field("CREATEUSERNAME", "ZJPRI_BAD_BEHAVIOR", "登记人姓名");
            /// <summary>
			/// 登记日期
			/// </summary>
			public readonly static Field CREATEDATE = new Field("CREATEDATE", "ZJPRI_BAD_BEHAVIOR", "登记日期");
            /// <summary>
			/// 企业类别
			/// </summary>
			public readonly static Field CORPTYPE = new Field("CORPTYPE", "ZJPRI_BAD_BEHAVIOR", "企业类别");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_BAD_BEHAVIOR", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_BAD_BEHAVIOR", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_BAD_BEHAVIOR", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_BAD_BEHAVIOR", "数据来源");
        }
        #endregion
	}
}