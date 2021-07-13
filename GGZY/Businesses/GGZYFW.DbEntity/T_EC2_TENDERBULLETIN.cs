﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_TENDERBULLETIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_TENDERBULLETIN")]
    [Serializable]
    public partial class T_EC2_TENDERBULLETIN : FwEntity
    {
        #region Model
		private string _TENDERBULLETINCODE;
		private string _TENDERPROJECTCODE;
		private string _BULLETINNATURE;
		private string _BULLETINTYPE;
		private DateTime? _TENDERDOCGETSTARTTIME;
		private string _TENDERDOCGETMETHOD;
		private DateTime? _TENDERDOCDEADLINE;
		private DateTime? _BIDDOCREFERENDTIME;
		private string _BIDDOCREFERMETHOD;
		private string _BULLETINNAME;
		private string _BULLETINCONTENT;
		private DateTime? _BULLETINISSUETIME;
		private string _BIDSECTIONCODES;
		private string _TENDERMODE;
		private DateTime? _BULLETINENDTIME;
		private string _BULLETINDUTY;
		private string _BULLETINDUTYCODETYPE;
		private string _BULLETINDUTYCODE;
		private string _BULLETINMEDIA;
		private string _URL;
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
		/// 招标公告编号
		/// </summary>
		public string TENDERBULLETINCODE
		{
			get{ return _TENDERBULLETINCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERBULLETINCODE, _TENDERBULLETINCODE, value);
				this._TENDERBULLETINCODE = value;
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
		/// 公告性质
		/// </summary>
		public string BULLETINNATURE
		{
			get{ return _BULLETINNATURE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINNATURE, _BULLETINNATURE, value);
				this._BULLETINNATURE = value;
			}
		}
		/// <summary>
		/// 公告类型
		/// </summary>
		public string BULLETINTYPE
		{
			get{ return _BULLETINTYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINTYPE, _BULLETINTYPE, value);
				this._BULLETINTYPE = value;
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
		/// 公告名称
		/// </summary>
		public string BULLETINNAME
		{
			get{ return _BULLETINNAME; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINNAME, _BULLETINNAME, value);
				this._BULLETINNAME = value;
			}
		}
		/// <summary>
		/// 公告内容文本
		/// </summary>
		public string BULLETINCONTENT
		{
			get{ return _BULLETINCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINCONTENT, _BULLETINCONTENT, value);
				this._BULLETINCONTENT = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? BULLETINISSUETIME
		{
			get{ return _BULLETINISSUETIME; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINISSUETIME, _BULLETINISSUETIME, value);
				this._BULLETINISSUETIME = value;
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
		/// 招标方式
		/// </summary>
		public string TENDERMODE
		{
			get{ return _TENDERMODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERMODE, _TENDERMODE, value);
				this._TENDERMODE = value;
			}
		}
		/// <summary>
		/// 公告结束日期
		/// </summary>
		public DateTime? BULLETINENDTIME
		{
			get{ return _BULLETINENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINENDTIME, _BULLETINENDTIME, value);
				this._BULLETINENDTIME = value;
			}
		}
		/// <summary>
		/// 公告发布责任人
		/// </summary>
		public string BULLETINDUTY
		{
			get{ return _BULLETINDUTY; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINDUTY, _BULLETINDUTY, value);
				this._BULLETINDUTY = value;
			}
		}
		/// <summary>
		/// 公告发布责任人证件种类
		/// </summary>
		public string BULLETINDUTYCODETYPE
		{
			get{ return _BULLETINDUTYCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINDUTYCODETYPE, _BULLETINDUTYCODETYPE, value);
				this._BULLETINDUTYCODETYPE = value;
			}
		}
		/// <summary>
		/// 公告发布责任人证件号码
		/// </summary>
		public string BULLETINDUTYCODE
		{
			get{ return _BULLETINDUTYCODE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINDUTYCODE, _BULLETINDUTYCODE, value);
				this._BULLETINDUTYCODE = value;
			}
		}
		/// <summary>
		/// 公告发布媒体
		/// </summary>
		public string BULLETINMEDIA
		{
			get{ return _BULLETINMEDIA; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINMEDIA, _BULLETINMEDIA, value);
				this._BULLETINMEDIA = value;
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
		/// 公告附件关联标识号
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
				_.TENDERBULLETINCODE,
				_.TENDERPROJECTCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDERBULLETINCODE,
				_.TENDERPROJECTCODE,
				_.BULLETINNATURE,
				_.BULLETINTYPE,
				_.TENDERDOCGETSTARTTIME,
				_.TENDERDOCGETMETHOD,
				_.TENDERDOCDEADLINE,
				_.BIDDOCREFERENDTIME,
				_.BIDDOCREFERMETHOD,
				_.BULLETINNAME,
				_.BULLETINCONTENT,
				_.BULLETINISSUETIME,
				_.BIDSECTIONCODES,
				_.TENDERMODE,
				_.BULLETINENDTIME,
				_.BULLETINDUTY,
				_.BULLETINDUTYCODETYPE,
				_.BULLETINDUTYCODE,
				_.BULLETINMEDIA,
				_.URL,
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
				this._TENDERBULLETINCODE,
				this._TENDERPROJECTCODE,
				this._BULLETINNATURE,
				this._BULLETINTYPE,
				this._TENDERDOCGETSTARTTIME,
				this._TENDERDOCGETMETHOD,
				this._TENDERDOCDEADLINE,
				this._BIDDOCREFERENDTIME,
				this._BIDDOCREFERMETHOD,
				this._BULLETINNAME,
				this._BULLETINCONTENT,
				this._BULLETINISSUETIME,
				this._BIDSECTIONCODES,
				this._TENDERMODE,
				this._BULLETINENDTIME,
				this._BULLETINDUTY,
				this._BULLETINDUTYCODETYPE,
				this._BULLETINDUTYCODE,
				this._BULLETINMEDIA,
				this._URL,
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
			public readonly static Field All = new Field("*", "T_EC2_TENDERBULLETIN");
            /// <summary>
			/// 招标公告编号
			/// </summary>
			public readonly static Field TENDERBULLETINCODE = new Field("TENDERBULLETINCODE", "T_EC2_TENDERBULLETIN", "招标公告编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_EC2_TENDERBULLETIN", "招标项目编号");
            /// <summary>
			/// 公告性质
			/// </summary>
			public readonly static Field BULLETINNATURE = new Field("BULLETINNATURE", "T_EC2_TENDERBULLETIN", "公告性质");
            /// <summary>
			/// 公告类型
			/// </summary>
			public readonly static Field BULLETINTYPE = new Field("BULLETINTYPE", "T_EC2_TENDERBULLETIN", "公告类型");
            /// <summary>
			/// 招标文件获取开始时间
			/// </summary>
			public readonly static Field TENDERDOCGETSTARTTIME = new Field("TENDERDOCGETSTARTTIME", "T_EC2_TENDERBULLETIN", "招标文件获取开始时间");
            /// <summary>
			/// 招标文件获取方法
			/// </summary>
			public readonly static Field TENDERDOCGETMETHOD = new Field("TENDERDOCGETMETHOD", "T_EC2_TENDERBULLETIN",DbType.AnsiString, null, "招标文件获取方法");
            /// <summary>
			/// 招标文件获取截止时间
			/// </summary>
			public readonly static Field TENDERDOCDEADLINE = new Field("TENDERDOCDEADLINE", "T_EC2_TENDERBULLETIN", "招标文件获取截止时间");
            /// <summary>
			/// 投标文件递交截止时间
			/// </summary>
			public readonly static Field BIDDOCREFERENDTIME = new Field("BIDDOCREFERENDTIME", "T_EC2_TENDERBULLETIN", "投标文件递交截止时间");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BIDDOCREFERMETHOD = new Field("BIDDOCREFERMETHOD", "T_EC2_TENDERBULLETIN",DbType.AnsiString, null, "投标文件递交方法");
            /// <summary>
			/// 公告名称
			/// </summary>
			public readonly static Field BULLETINNAME = new Field("BULLETINNAME", "T_EC2_TENDERBULLETIN", "公告名称");
            /// <summary>
			/// 公告内容文本
			/// </summary>
			public readonly static Field BULLETINCONTENT = new Field("BULLETINCONTENT", "T_EC2_TENDERBULLETIN",DbType.AnsiString, null, "公告内容文本");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field BULLETINISSUETIME = new Field("BULLETINISSUETIME", "T_EC2_TENDERBULLETIN", "公告发布时间");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODES = new Field("BIDSECTIONCODES", "T_EC2_TENDERBULLETIN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDERMODE = new Field("TENDERMODE", "T_EC2_TENDERBULLETIN", "招标方式");
            /// <summary>
			/// 公告结束日期
			/// </summary>
			public readonly static Field BULLETINENDTIME = new Field("BULLETINENDTIME", "T_EC2_TENDERBULLETIN", "公告结束日期");
            /// <summary>
			/// 公告发布责任人
			/// </summary>
			public readonly static Field BULLETINDUTY = new Field("BULLETINDUTY", "T_EC2_TENDERBULLETIN", "公告发布责任人");
            /// <summary>
			/// 公告发布责任人证件种类
			/// </summary>
			public readonly static Field BULLETINDUTYCODETYPE = new Field("BULLETINDUTYCODETYPE", "T_EC2_TENDERBULLETIN", "公告发布责任人证件种类");
            /// <summary>
			/// 公告发布责任人证件号码
			/// </summary>
			public readonly static Field BULLETINDUTYCODE = new Field("BULLETINDUTYCODE", "T_EC2_TENDERBULLETIN", "公告发布责任人证件号码");
            /// <summary>
			/// 公告发布媒体
			/// </summary>
			public readonly static Field BULLETINMEDIA = new Field("BULLETINMEDIA", "T_EC2_TENDERBULLETIN", "公告发布媒体");
            /// <summary>
			/// 源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_EC2_TENDERBULLETIN", "源URL");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_TENDERBULLETIN", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_TENDERBULLETIN", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_TENDERBULLETIN", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 公告附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "T_EC2_TENDERBULLETIN",DbType.AnsiString, null, "公告附件关联标识号");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_TENDERBULLETIN", "版本号");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "T_EC2_TENDERBULLETIN", "是否公开");
            /// <summary>
			/// 公开类型
			/// </summary>
			public readonly static Field OPENTYPE = new Field("OPENTYPE", "T_EC2_TENDERBULLETIN", "公开类型");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_TENDERBULLETIN", "交易平台数据验证时间");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_TENDERBULLETIN", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_TENDERBULLETIN", "数据时间");
        }
        #endregion
	}
}