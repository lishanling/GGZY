using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_BIDINVITE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_BIDINVITE")]
    [Serializable]
    public partial class T_EC2_BIDINVITE : FwEntity
    {
        #region Model
		private string _BIDINVITECODE;
		private string _BIDSECTIONCODE;
		private string _BIDQUALIFICATION;
		private string _BIDDERCODETYPE;
		private string _BIDDERCODE;
		private string _BIDDERNAME;
		private DateTime? _TENDERDOCGETSTARTTIME;
		private DateTime? _TENDERDOCDEADLINE;
		private string _TENDERDOCGETMETHOD;
		private DateTime? _BIDDOCREFERENDTIME;
		private string _BIDDOCREFERMETHOD;
		private DateTime? _BIDINVITEENDTIME;
		private DateTime? _BIDINVITEISSUETIME;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private string _ATTACHMENTCODE;
		private DateTime? _VERSION;
		private string _ISOPEN;
		private string _OPENTYPE;
		private DateTime? _VERIFYTIME;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 投标邀请书编号
		/// </summary>
		public string BIDINVITECODE
		{
			get{ return _BIDINVITECODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDINVITECODE, _BIDINVITECODE, value);
				this._BIDINVITECODE = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string BIDSECTIONCODE
		{
			get{ return _BIDSECTIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONCODE, _BIDSECTIONCODE, value);
				this._BIDSECTIONCODE = value;
			}
		}
		/// <summary>
		/// 投标资格
		/// </summary>
		public string BIDQUALIFICATION
		{
			get{ return _BIDQUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BIDQUALIFICATION, _BIDQUALIFICATION, value);
				this._BIDQUALIFICATION = value;
			}
		}
		/// <summary>
		/// 投标人代码类型
		/// </summary>
		public string BIDDERCODETYPE
		{
			get{ return _BIDDERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERCODETYPE, _BIDDERCODETYPE, value);
				this._BIDDERCODETYPE = value;
			}
		}
		/// <summary>
		/// 投标人代码
		/// </summary>
		public string BIDDERCODE
		{
			get{ return _BIDDERCODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERCODE, _BIDDERCODE, value);
				this._BIDDERCODE = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDERNAME
		{
			get{ return _BIDDERNAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERNAME, _BIDDERNAME, value);
				this._BIDDERNAME = value;
			}
		}
		/// <summary>
		/// 招标文件获取开始时间
		/// </summary>
		public DateTime? TENDERDOCGETSTARTTIME
		{
			get{ return _TENDERDOCGETSTARTTIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERDOCGETSTARTTIME, _TENDERDOCGETSTARTTIME, value);
				this._TENDERDOCGETSTARTTIME = value;
			}
		}
		/// <summary>
		/// 招标文件获取截止时间
		/// </summary>
		public DateTime? TENDERDOCDEADLINE
		{
			get{ return _TENDERDOCDEADLINE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERDOCDEADLINE, _TENDERDOCDEADLINE, value);
				this._TENDERDOCDEADLINE = value;
			}
		}
		/// <summary>
		/// 招标文件获取方法
		/// </summary>
		public string TENDERDOCGETMETHOD
		{
			get{ return _TENDERDOCGETMETHOD; }
			set
			{
				this.OnPropertyValueChange(_.TENDERDOCGETMETHOD, _TENDERDOCGETMETHOD, value);
				this._TENDERDOCGETMETHOD = value;
			}
		}
		/// <summary>
		/// 投标文件递交截止时间
		/// </summary>
		public DateTime? BIDDOCREFERENDTIME
		{
			get{ return _BIDDOCREFERENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDOCREFERENDTIME, _BIDDOCREFERENDTIME, value);
				this._BIDDOCREFERENDTIME = value;
			}
		}
		/// <summary>
		/// 投标文件递交方法
		/// </summary>
		public string BIDDOCREFERMETHOD
		{
			get{ return _BIDDOCREFERMETHOD; }
			set
			{
				this.OnPropertyValueChange(_.BIDDOCREFERMETHOD, _BIDDOCREFERMETHOD, value);
				this._BIDDOCREFERMETHOD = value;
			}
		}
		/// <summary>
		/// 投标邀请回复截止时间
		/// </summary>
		public DateTime? BIDINVITEENDTIME
		{
			get{ return _BIDINVITEENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDINVITEENDTIME, _BIDINVITEENDTIME, value);
				this._BIDINVITEENDTIME = value;
			}
		}
		/// <summary>
		/// 投标邀请发出时间
		/// </summary>
		public DateTime? BIDINVITEISSUETIME
		{
			get{ return _BIDINVITEISSUETIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDINVITEISSUETIME, _BIDINVITEISSUETIME, value);
				this._BIDINVITEISSUETIME = value;
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
				_.BIDINVITECODE,
				_.BIDSECTIONCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.BIDINVITECODE,
				_.BIDSECTIONCODE,
				_.BIDQUALIFICATION,
				_.BIDDERCODETYPE,
				_.BIDDERCODE,
				_.BIDDERNAME,
				_.TENDERDOCGETSTARTTIME,
				_.TENDERDOCDEADLINE,
				_.TENDERDOCGETMETHOD,
				_.BIDDOCREFERENDTIME,
				_.BIDDOCREFERMETHOD,
				_.BIDINVITEENDTIME,
				_.BIDINVITEISSUETIME,
				_.EXAMINERNAME,
				_.EXAMINERCODETYPE,
				_.EXAMINERCODE,
				_.ATTACHMENTCODE,
				_.VERSION,
				_.ISOPEN,
				_.OPENTYPE,
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
				this._BIDINVITECODE,
				this._BIDSECTIONCODE,
				this._BIDQUALIFICATION,
				this._BIDDERCODETYPE,
				this._BIDDERCODE,
				this._BIDDERNAME,
				this._TENDERDOCGETSTARTTIME,
				this._TENDERDOCDEADLINE,
				this._TENDERDOCGETMETHOD,
				this._BIDDOCREFERENDTIME,
				this._BIDDOCREFERMETHOD,
				this._BIDINVITEENDTIME,
				this._BIDINVITEISSUETIME,
				this._EXAMINERNAME,
				this._EXAMINERCODETYPE,
				this._EXAMINERCODE,
				this._ATTACHMENTCODE,
				this._VERSION,
				this._ISOPEN,
				this._OPENTYPE,
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
			public readonly static Field All = new Field("*", "T_EC2_BIDINVITE");
            /// <summary>
			/// 投标邀请书编号
			/// </summary>
			public readonly static Field BIDINVITECODE = new Field("BIDINVITECODE", "T_EC2_BIDINVITE", "投标邀请书编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODE = new Field("BIDSECTIONCODE", "T_EC2_BIDINVITE", "标段（包）编号");
            /// <summary>
			/// 投标资格
			/// </summary>
			public readonly static Field BIDQUALIFICATION = new Field("BIDQUALIFICATION", "T_EC2_BIDINVITE",DbType.AnsiString, null, "投标资格");
            /// <summary>
			/// 投标人代码类型
			/// </summary>
			public readonly static Field BIDDERCODETYPE = new Field("BIDDERCODETYPE", "T_EC2_BIDINVITE", "投标人代码类型");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDERCODE = new Field("BIDDERCODE", "T_EC2_BIDINVITE", "投标人代码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDERNAME = new Field("BIDDERNAME", "T_EC2_BIDINVITE", "投标人名称");
            /// <summary>
			/// 招标文件获取开始时间
			/// </summary>
			public readonly static Field TENDERDOCGETSTARTTIME = new Field("TENDERDOCGETSTARTTIME", "T_EC2_BIDINVITE", "招标文件获取开始时间");
            /// <summary>
			/// 招标文件获取截止时间
			/// </summary>
			public readonly static Field TENDERDOCDEADLINE = new Field("TENDERDOCDEADLINE", "T_EC2_BIDINVITE", "招标文件获取截止时间");
            /// <summary>
			/// 招标文件获取方法
			/// </summary>
			public readonly static Field TENDERDOCGETMETHOD = new Field("TENDERDOCGETMETHOD", "T_EC2_BIDINVITE",DbType.AnsiString, null, "招标文件获取方法");
            /// <summary>
			/// 投标文件递交截止时间
			/// </summary>
			public readonly static Field BIDDOCREFERENDTIME = new Field("BIDDOCREFERENDTIME", "T_EC2_BIDINVITE", "投标文件递交截止时间");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BIDDOCREFERMETHOD = new Field("BIDDOCREFERMETHOD", "T_EC2_BIDINVITE",DbType.AnsiString, null, "投标文件递交方法");
            /// <summary>
			/// 投标邀请回复截止时间
			/// </summary>
			public readonly static Field BIDINVITEENDTIME = new Field("BIDINVITEENDTIME", "T_EC2_BIDINVITE", "投标邀请回复截止时间");
            /// <summary>
			/// 投标邀请发出时间
			/// </summary>
			public readonly static Field BIDINVITEISSUETIME = new Field("BIDINVITEISSUETIME", "T_EC2_BIDINVITE", "投标邀请发出时间");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_BIDINVITE", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_BIDINVITE", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_BIDINVITE", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_BIDINVITE",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_BIDINVITE", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_BIDINVITE", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_BIDINVITE", "公开类型");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_BIDINVITE", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_BIDINVITE", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_BIDINVITE", "数据时间");
        }
        #endregion
	}
}