using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_OPENBIDRECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_OPENBIDRECORD")]
    [Serializable]
    public partial class T_EC2_OPENBIDRECORD : FwEntity
    {
        #region Model
		private string _OPENBIDRECORDCODE;
		private string _OPENBIDRECORDNAME;
		private string _TENDERPROJECTCODE;
		private string _BIDSECTIONCODES;
		private string _BIDOPENINGACTOR;
		private string _BIDOPENINGCONTENT;
		private string _BIDOPENINGADDRESS;
		private DateTime? _BIDOPENINGTIME;
		private string _URL;
		private string _ATTACHMENTCODE;
		private DateTime? _VERSION;
		private string _ISOPEN;
		private string _OPENTYPE;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private DateTime? _VERIFYTIME;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 开标记录编号
		/// </summary>
		public string OPENBIDRECORDCODE
		{
			get{ return _OPENBIDRECORDCODE; }
			set
			{
				this.OnPropertyValueChange(_.OPENBIDRECORDCODE, _OPENBIDRECORDCODE, value);
				this._OPENBIDRECORDCODE = value;
			}
		}
		/// <summary>
		/// 开标记录名称
		/// </summary>
		public string OPENBIDRECORDNAME
		{
			get{ return _OPENBIDRECORDNAME; }
			set
			{
				this.OnPropertyValueChange(_.OPENBIDRECORDNAME, _OPENBIDRECORDNAME, value);
				this._OPENBIDRECORDNAME = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDERPROJECTCODE
		{
			get{ return _TENDERPROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTCODE, _TENDERPROJECTCODE, value);
				this._TENDERPROJECTCODE = value;
			}
		}
		/// <summary>
		/// 相关标段（包）编号
		/// </summary>
		public string BIDSECTIONCODES
		{
			get{ return _BIDSECTIONCODES; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONCODES, _BIDSECTIONCODES, value);
				this._BIDSECTIONCODES = value;
			}
		}
		/// <summary>
		/// 开标参与人
		/// </summary>
		public string BIDOPENINGACTOR
		{
			get{ return _BIDOPENINGACTOR; }
			set
			{
				this.OnPropertyValueChange(_.BIDOPENINGACTOR, _BIDOPENINGACTOR, value);
				this._BIDOPENINGACTOR = value;
			}
		}
		/// <summary>
		/// 开标记录内容
		/// </summary>
		public string BIDOPENINGCONTENT
		{
			get{ return _BIDOPENINGCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BIDOPENINGCONTENT, _BIDOPENINGCONTENT, value);
				this._BIDOPENINGCONTENT = value;
			}
		}
		/// <summary>
		/// 开标地点
		/// </summary>
		public string BIDOPENINGADDRESS
		{
			get{ return _BIDOPENINGADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.BIDOPENINGADDRESS, _BIDOPENINGADDRESS, value);
				this._BIDOPENINGADDRESS = value;
			}
		}
		/// <summary>
		/// 开标时间
		/// </summary>
		public DateTime? BIDOPENINGTIME
		{
			get{ return _BIDOPENINGTIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDOPENINGTIME, _BIDOPENINGTIME, value);
				this._BIDOPENINGTIME = value;
			}
		}
		/// <summary>
		/// 源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 附件关联标识号
		/// </summary>
		public string ATTACHMENTCODE
		{
			get{ return _ATTACHMENTCODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTCODE, _ATTACHMENTCODE, value);
				this._ATTACHMENTCODE = value;
			}
		}
		/// <summary>
		/// 版本号
		/// </summary>
		public DateTime? VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 是否公开
		/// </summary>
		public string ISOPEN
		{
			get{ return _ISOPEN; }
			set
			{
				this.OnPropertyValueChange(_.ISOPEN, _ISOPEN, value);
				this._ISOPEN = value;
			}
		}
		/// <summary>
		/// 公开类型
		/// </summary>
		public string OPENTYPE
		{
			get{ return _OPENTYPE; }
			set
			{
				this.OnPropertyValueChange(_.OPENTYPE, _OPENTYPE, value);
				this._OPENTYPE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人姓名
		/// </summary>
		public string EXAMINERNAME
		{
			get{ return _EXAMINERNAME; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERNAME, _EXAMINERNAME, value);
				this._EXAMINERNAME = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人证件类型
		/// </summary>
		public string EXAMINERCODETYPE
		{
			get{ return _EXAMINERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERCODETYPE, _EXAMINERCODETYPE, value);
				this._EXAMINERCODETYPE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人证件号码
		/// </summary>
		public string EXAMINERCODE
		{
			get{ return _EXAMINERCODE; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERCODE, _EXAMINERCODE, value);
				this._EXAMINERCODE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证时间
		/// </summary>
		public DateTime? VERIFYTIME
		{
			get{ return _VERIFYTIME; }
			set
			{
				this.OnPropertyValueChange(_.VERIFYTIME, _VERIFYTIME, value);
				this._VERIFYTIME = value;
			}
		}
		/// <summary>
		/// 数据源
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
		/// <summary>
		/// 数据时间
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.OPENBIDRECORDCODE,
				_.TENDERPROJECTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.OPENBIDRECORDCODE,
				_.OPENBIDRECORDNAME,
				_.TENDERPROJECTCODE,
				_.BIDSECTIONCODES,
				_.BIDOPENINGACTOR,
				_.BIDOPENINGCONTENT,
				_.BIDOPENINGADDRESS,
				_.BIDOPENINGTIME,
				_.URL,
				_.ATTACHMENTCODE,
				_.VERSION,
				_.ISOPEN,
				_.OPENTYPE,
				_.EXAMINERNAME,
				_.EXAMINERCODETYPE,
				_.EXAMINERCODE,
				_.VERIFYTIME,
				_.DATA_SOURCE,
				_.CREATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._OPENBIDRECORDCODE,
				this._OPENBIDRECORDNAME,
				this._TENDERPROJECTCODE,
				this._BIDSECTIONCODES,
				this._BIDOPENINGACTOR,
				this._BIDOPENINGCONTENT,
				this._BIDOPENINGADDRESS,
				this._BIDOPENINGTIME,
				this._URL,
				this._ATTACHMENTCODE,
				this._VERSION,
				this._ISOPEN,
				this._OPENTYPE,
				this._EXAMINERNAME,
				this._EXAMINERCODETYPE,
				this._EXAMINERCODE,
				this._VERIFYTIME,
				this._DATA_SOURCE,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "T_EC2_OPENBIDRECORD");
            /// <summary>
			/// 开标记录编号
			/// </summary>
			public readonly static Field OPENBIDRECORDCODE = new Field("OPENBIDRECORDCODE", "T_EC2_OPENBIDRECORD", "开标记录编号");
            /// <summary>
			/// 开标记录名称
			/// </summary>
			public readonly static Field OPENBIDRECORDNAME = new Field("OPENBIDRECORDNAME", "T_EC2_OPENBIDRECORD", "开标记录名称");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_OPENBIDRECORD", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODES = new Field("BIDSECTIONCODES", "T_EC2_OPENBIDRECORD",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 开标参与人
			/// </summary>
			public readonly static Field BIDOPENINGACTOR = new Field("BIDOPENINGACTOR", "T_EC2_OPENBIDRECORD", "开标参与人");
            /// <summary>
			/// 开标记录内容
			/// </summary>
			public readonly static Field BIDOPENINGCONTENT = new Field("BIDOPENINGCONTENT", "T_EC2_OPENBIDRECORD",DbType.AnsiString, null, "开标记录内容");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BIDOPENINGADDRESS = new Field("BIDOPENINGADDRESS", "T_EC2_OPENBIDRECORD", "开标地点");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BIDOPENINGTIME = new Field("BIDOPENINGTIME", "T_EC2_OPENBIDRECORD", "开标时间");
            /// <summary>
			/// 源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_EC2_OPENBIDRECORD", "源URL");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_OPENBIDRECORD",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_OPENBIDRECORD", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_OPENBIDRECORD", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_OPENBIDRECORD", "公开类型");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_OPENBIDRECORD", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_OPENBIDRECORD", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_OPENBIDRECORD", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_OPENBIDRECORD", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_OPENBIDRECORD", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_OPENBIDRECORD", "数据时间");
        }
        #endregion
	}
}