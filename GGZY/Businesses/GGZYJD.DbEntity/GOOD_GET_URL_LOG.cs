using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类GOOD_GET_URL_LOG。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("GOOD_GET_URL_LOG")]
	[Serializable]
	public partial class GOOD_GET_URL_LOG : JdEntity
	{
		#region Model
		private decimal? _ID;
		private decimal? _TEMP_ID;
		private decimal? _AFC_ID;
		private DateTime? _CREATE_TIME;
		private string _SYSNO;
		private string _BUSINESSCODE;
		private string _BUSINESSNAME;
		private string _PROJECTNO;
		private decimal? _PROSTATUS;
		private string _REGIONCODE;
		private DateTime? _ACCEPTDATE;
		private decimal? _USERPROP;
		private string _USERNAME;
		private string _USERPAGETYPE;
		private string _CERTKEY;
		private string _HANDLEUSERNAME;
		private string _HANDLEUSERPAGETYPE;
		private string _HANDLEUSERPAGECODE;
		private DateTime? _RESULTDATE;
		private DateTime? _SERVICETIME;
		private decimal? _EVALUATETYPE;
		private string _PROJECTNAME;
		private string _NODENAME;
		private string _CONTACTMOBILE;
		private decimal? _PF;
		private decimal? _TYPE;
		private string _BACKURL;
		private string _CUSTOMFIELDS;
		private decimal? _PF5URLTYPE;
		private string _RESULT;
		private string _RESULT_URL;

		/// <summary>
		/// 主键
		/// </summary>
		public decimal? ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 暂存id，对应表good_temp_param
		/// </summary>
		public decimal? TEMP_ID
		{
			get { return _TEMP_ID; }
			set
			{
				this.OnPropertyValueChange(_.TEMP_ID, _TEMP_ID, value);
				this._TEMP_ID = value;
			}
		}
		/// <summary>
		/// 报建id，对应表t_afc_project
		/// </summary>
		public decimal? AFC_ID
		{
			get { return _AFC_ID; }
			set
			{
				this.OnPropertyValueChange(_.AFC_ID, _AFC_ID, value);
				this._AFC_ID = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 系统编号
		/// </summary>
		public string SYSNO
		{
			get { return _SYSNO; }
			set
			{
				this.OnPropertyValueChange(_.SYSNO, _SYSNO, value);
				this._SYSNO = value;
			}
		}
		/// <summary>
		/// 省网事项编码
		/// </summary>
		public string BUSINESSCODE
		{
			get { return _BUSINESSCODE; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSCODE, _BUSINESSCODE, value);
				this._BUSINESSCODE = value;
			}
		}
		/// <summary>
		/// 省网事项名称
		/// </summary>
		public string BUSINESSNAME
		{
			get { return _BUSINESSNAME; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSNAME, _BUSINESSNAME, value);
				this._BUSINESSNAME = value;
			}
		}
		/// <summary>
		/// 办件申报号
		/// </summary>
		public string PROJECTNO
		{
			get { return _PROJECTNO; }
			set
			{
				this.OnPropertyValueChange(_.PROJECTNO, _PROJECTNO, value);
				this._PROJECTNO = value;
			}
		}
		/// <summary>
		/// 办理状态（待受理=1，已受理=2，已办结=3）
		/// </summary>
		public decimal? PROSTATUS
		{
			get { return _PROSTATUS; }
			set
			{
				this.OnPropertyValueChange(_.PROSTATUS, _PROSTATUS, value);
				this._PROSTATUS = value;
			}
		}
		/// <summary>
		/// _6位行政区划编码
		/// </summary>
		public string REGIONCODE
		{
			get { return _REGIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.REGIONCODE, _REGIONCODE, value);
				this._REGIONCODE = value;
			}
		}
		/// <summary>
		/// 受理时间
		/// </summary>
		public DateTime? ACCEPTDATE
		{
			get { return _ACCEPTDATE; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPTDATE, _ACCEPTDATE, value);
				this._ACCEPTDATE = value;
			}
		}
		/// <summary>
		/// 申请人类型（自然人=1，企业法人=2，事业法人=3，社会组织法人=4，非法人企业=5，行政机关=6，其他组织=9）
		/// </summary>
		public decimal? USERPROP
		{
			get { return _USERPROP; }
			set
			{
				this.OnPropertyValueChange(_.USERPROP, _USERPROP, value);
				this._USERPROP = value;
			}
		}
		/// <summary>
		/// 申请单位名称/申请人名称
		/// </summary>
		public string USERNAME
		{
			get { return _USERNAME; }
			set
			{
				this.OnPropertyValueChange(_.USERNAME, _USERNAME, value);
				this._USERNAME = value;
			}
		}
		/// <summary>
		/// 申请人证件类型
		/// </summary>
		public string USERPAGETYPE
		{
			get { return _USERPAGETYPE; }
			set
			{
				this.OnPropertyValueChange(_.USERPAGETYPE, _USERPAGETYPE, value);
				this._USERPAGETYPE = value;
			}
		}
		/// <summary>
		/// 申请人证件号码
		/// </summary>
		public string CERTKEY
		{
			get { return _CERTKEY; }
			set
			{
				this.OnPropertyValueChange(_.CERTKEY, _CERTKEY, value);
				this._CERTKEY = value;
			}
		}
		/// <summary>
		/// 代理人姓名
		/// </summary>
		public string HANDLEUSERNAME
		{
			get { return _HANDLEUSERNAME; }
			set
			{
				this.OnPropertyValueChange(_.HANDLEUSERNAME, _HANDLEUSERNAME, value);
				this._HANDLEUSERNAME = value;
			}
		}
		/// <summary>
		/// 代理人证件类型
		/// </summary>
		public string HANDLEUSERPAGETYPE
		{
			get { return _HANDLEUSERPAGETYPE; }
			set
			{
				this.OnPropertyValueChange(_.HANDLEUSERPAGETYPE, _HANDLEUSERPAGETYPE, value);
				this._HANDLEUSERPAGETYPE = value;
			}
		}
		/// <summary>
		/// 代理人证件号码
		/// </summary>
		public string HANDLEUSERPAGECODE
		{
			get { return _HANDLEUSERPAGECODE; }
			set
			{
				this.OnPropertyValueChange(_.HANDLEUSERPAGECODE, _HANDLEUSERPAGECODE, value);
				this._HANDLEUSERPAGECODE = value;
			}
		}
		/// <summary>
		/// 办结时间
		/// </summary>
		public DateTime? RESULTDATE
		{
			get { return _RESULTDATE; }
			set
			{
				this.OnPropertyValueChange(_.RESULTDATE, _RESULTDATE, value);
				this._RESULTDATE = value;
			}
		}
		/// <summary>
		/// 服务时间
		/// </summary>
		public DateTime? SERVICETIME
		{
			get { return _SERVICETIME; }
			set
			{
				this.OnPropertyValueChange(_.SERVICETIME, _SERVICETIME, value);
				this._SERVICETIME = value;
			}
		}
		/// <summary>
		/// 评价类型（第一次主动评价=1，追加评价=2）
		/// </summary>
		public decimal? EVALUATETYPE
		{
			get { return _EVALUATETYPE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATETYPE, _EVALUATETYPE, value);
				this._EVALUATETYPE = value;
			}
		}
		/// <summary>
		/// 办件名称
		/// </summary>
		public string PROJECTNAME
		{
			get { return _PROJECTNAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECTNAME, _PROJECTNAME, value);
				this._PROJECTNAME = value;
			}
		}
		/// <summary>
		/// 环节名称
		/// </summary>
		public string NODENAME
		{
			get { return _NODENAME; }
			set
			{
				this.OnPropertyValueChange(_.NODENAME, _NODENAME, value);
				this._NODENAME = value;
			}
		}
		/// <summary>
		/// 评价人手机号码
		/// </summary>
		public string CONTACTMOBILE
		{
			get { return _CONTACTMOBILE; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTMOBILE, _CONTACTMOBILE, value);
				this._CONTACTMOBILE = value;
			}
		}
		/// <summary>
		/// 评价渠道（pc端=1，移动服务端=2，二维码=3，政务大厅平板电脑=4，政务大厅自助终端=5，电话=6，短信=7）
		/// </summary>
		public decimal? PF
		{
			get { return _PF; }
			set
			{
				this.OnPropertyValueChange(_.PF, _PF, value);
				this._PF = value;
			}
		}
		/// <summary>
		/// 评价地址网络方式（互联网=1，政务信息网=2，政务外网公共区=3）
		/// </summary>
		public decimal? TYPE
		{
			get { return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 回调网址（评价完成之后跳转的链接地址）
		/// </summary>
		public string BACKURL
		{
			get { return _BACKURL; }
			set
			{
				this.OnPropertyValueChange(_.BACKURL, _BACKURL, value);
				this._BACKURL = value;
			}
		}
		/// <summary>
		/// 自定义字段
		/// </summary>
		public string CUSTOMFIELDS
		{
			get { return _CUSTOMFIELDS; }
			set
			{
				this.OnPropertyValueChange(_.CUSTOMFIELDS, _CUSTOMFIELDS, value);
				this._CUSTOMFIELDS = value;
			}
		}
		/// <summary>
		/// Pf等于5时，如果该字段值等于1，刚返回PC端地址，否则返回H5地址
		/// </summary>
		public decimal? PF5URLTYPE
		{
			get { return _PF5URLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.PF5URLTYPE, _PF5URLTYPE, value);
				this._PF5URLTYPE = value;
			}
		}
		/// <summary>
		/// 返回的数据
		/// </summary>
		public string RESULT
		{
			get { return _RESULT; }
			set
			{
				this.OnPropertyValueChange(_.RESULT, _RESULT, value);
				this._RESULT = value;
			}
		}
		/// <summary>
		/// 返回的评价地址
		/// </summary>
		public string RESULT_URL
		{
			get { return _RESULT_URL; }
			set
			{
				this.OnPropertyValueChange(_.RESULT_URL, _RESULT_URL, value);
				this._RESULT_URL = value;
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
				_.TEMP_ID,
				_.AFC_ID,
				_.CREATE_TIME,
				_.SYSNO,
				_.BUSINESSCODE,
				_.BUSINESSNAME,
				_.PROJECTNO,
				_.PROSTATUS,
				_.REGIONCODE,
				_.ACCEPTDATE,
				_.USERPROP,
				_.USERNAME,
				_.USERPAGETYPE,
				_.CERTKEY,
				_.HANDLEUSERNAME,
				_.HANDLEUSERPAGETYPE,
				_.HANDLEUSERPAGECODE,
				_.RESULTDATE,
				_.SERVICETIME,
				_.EVALUATETYPE,
				_.PROJECTNAME,
				_.NODENAME,
				_.CONTACTMOBILE,
				_.PF,
				_.TYPE,
				_.BACKURL,
				_.CUSTOMFIELDS,
				_.PF5URLTYPE,
				_.RESULT,
				_.RESULT_URL,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._TEMP_ID,
				this._AFC_ID,
				this._CREATE_TIME,
				this._SYSNO,
				this._BUSINESSCODE,
				this._BUSINESSNAME,
				this._PROJECTNO,
				this._PROSTATUS,
				this._REGIONCODE,
				this._ACCEPTDATE,
				this._USERPROP,
				this._USERNAME,
				this._USERPAGETYPE,
				this._CERTKEY,
				this._HANDLEUSERNAME,
				this._HANDLEUSERPAGETYPE,
				this._HANDLEUSERPAGECODE,
				this._RESULTDATE,
				this._SERVICETIME,
				this._EVALUATETYPE,
				this._PROJECTNAME,
				this._NODENAME,
				this._CONTACTMOBILE,
				this._PF,
				this._TYPE,
				this._BACKURL,
				this._CUSTOMFIELDS,
				this._PF5URLTYPE,
				this._RESULT,
				this._RESULT_URL,
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
			public readonly static Field All = new Field("*", "GOOD_GET_URL_LOG");
			/// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "GOOD_GET_URL_LOG", "主键");
			/// <summary>
			/// 暂存id，对应表good_temp_param
			/// </summary>
			public readonly static Field TEMP_ID = new Field("TEMP_ID", "GOOD_GET_URL_LOG", "暂存id，对应表good_temp_param");
			/// <summary>
			/// 报建id，对应表t_afc_project
			/// </summary>
			public readonly static Field AFC_ID = new Field("AFC_ID", "GOOD_GET_URL_LOG", "报建id，对应表t_afc_project");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "GOOD_GET_URL_LOG", "创建时间");
			/// <summary>
			/// 系统编号
			/// </summary>
			public readonly static Field SYSNO = new Field("SYSNO", "GOOD_GET_URL_LOG", "系统编号");
			/// <summary>
			/// 省网事项编码
			/// </summary>
			public readonly static Field BUSINESSCODE = new Field("BUSINESSCODE", "GOOD_GET_URL_LOG", "省网事项编码");
			/// <summary>
			/// 省网事项名称
			/// </summary>
			public readonly static Field BUSINESSNAME = new Field("BUSINESSNAME", "GOOD_GET_URL_LOG", "省网事项名称");
			/// <summary>
			/// 办件申报号
			/// </summary>
			public readonly static Field PROJECTNO = new Field("PROJECTNO", "GOOD_GET_URL_LOG", "办件申报号");
			/// <summary>
			/// 办理状态（待受理=1，已受理=2，已办结=3）
			/// </summary>
			public readonly static Field PROSTATUS = new Field("PROSTATUS", "GOOD_GET_URL_LOG", "办理状态（待受理=1，已受理=2，已办结=3）");
			/// <summary>
			/// _6位行政区划编码
			/// </summary>
			public readonly static Field REGIONCODE = new Field("REGIONCODE", "GOOD_GET_URL_LOG", "_6位行政区划编码");
			/// <summary>
			/// 受理时间
			/// </summary>
			public readonly static Field ACCEPTDATE = new Field("ACCEPTDATE", "GOOD_GET_URL_LOG", "受理时间");
			/// <summary>
			/// 申请人类型（自然人=1，企业法人=2，事业法人=3，社会组织法人=4，非法人企业=5，行政机关=6，其他组织=9）
			/// </summary>
			public readonly static Field USERPROP = new Field("USERPROP", "GOOD_GET_URL_LOG", "申请人类型（自然人=1，企业法人=2，事业法人=3，社会组织法人=4，非法人企业=5，行政机关=6，其他组织=9）");
			/// <summary>
			/// 申请单位名称/申请人名称
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "GOOD_GET_URL_LOG", "申请单位名称/申请人名称");
			/// <summary>
			/// 申请人证件类型
			/// </summary>
			public readonly static Field USERPAGETYPE = new Field("USERPAGETYPE", "GOOD_GET_URL_LOG", "申请人证件类型");
			/// <summary>
			/// 申请人证件号码
			/// </summary>
			public readonly static Field CERTKEY = new Field("CERTKEY", "GOOD_GET_URL_LOG", "申请人证件号码");
			/// <summary>
			/// 代理人姓名
			/// </summary>
			public readonly static Field HANDLEUSERNAME = new Field("HANDLEUSERNAME", "GOOD_GET_URL_LOG", "代理人姓名");
			/// <summary>
			/// 代理人证件类型
			/// </summary>
			public readonly static Field HANDLEUSERPAGETYPE = new Field("HANDLEUSERPAGETYPE", "GOOD_GET_URL_LOG", "代理人证件类型");
			/// <summary>
			/// 代理人证件号码
			/// </summary>
			public readonly static Field HANDLEUSERPAGECODE = new Field("HANDLEUSERPAGECODE", "GOOD_GET_URL_LOG", "代理人证件号码");
			/// <summary>
			/// 办结时间
			/// </summary>
			public readonly static Field RESULTDATE = new Field("RESULTDATE", "GOOD_GET_URL_LOG", "办结时间");
			/// <summary>
			/// 服务时间
			/// </summary>
			public readonly static Field SERVICETIME = new Field("SERVICETIME", "GOOD_GET_URL_LOG", "服务时间");
			/// <summary>
			/// 评价类型（第一次主动评价=1，追加评价=2）
			/// </summary>
			public readonly static Field EVALUATETYPE = new Field("EVALUATETYPE", "GOOD_GET_URL_LOG", "评价类型（第一次主动评价=1，追加评价=2）");
			/// <summary>
			/// 办件名称
			/// </summary>
			public readonly static Field PROJECTNAME = new Field("PROJECTNAME", "GOOD_GET_URL_LOG", "办件名称");
			/// <summary>
			/// 环节名称
			/// </summary>
			public readonly static Field NODENAME = new Field("NODENAME", "GOOD_GET_URL_LOG", "环节名称");
			/// <summary>
			/// 评价人手机号码
			/// </summary>
			public readonly static Field CONTACTMOBILE = new Field("CONTACTMOBILE", "GOOD_GET_URL_LOG", "评价人手机号码");
			/// <summary>
			/// 评价渠道（pc端=1，移动服务端=2，二维码=3，政务大厅平板电脑=4，政务大厅自助终端=5，电话=6，短信=7）
			/// </summary>
			public readonly static Field PF = new Field("PF", "GOOD_GET_URL_LOG", "评价渠道（pc端=1，移动服务端=2，二维码=3，政务大厅平板电脑=4，政务大厅自助终端=5，电话=6，短信=7）");
			/// <summary>
			/// 评价地址网络方式（互联网=1，政务信息网=2，政务外网公共区=3）
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "GOOD_GET_URL_LOG", "评价地址网络方式（互联网=1，政务信息网=2，政务外网公共区=3）");
			/// <summary>
			/// 回调网址（评价完成之后跳转的链接地址）
			/// </summary>
			public readonly static Field BACKURL = new Field("BACKURL", "GOOD_GET_URL_LOG", "回调网址（评价完成之后跳转的链接地址）");
			/// <summary>
			/// 自定义字段
			/// </summary>
			public readonly static Field CUSTOMFIELDS = new Field("CUSTOMFIELDS", "GOOD_GET_URL_LOG", "自定义字段");
			/// <summary>
			/// Pf等于5时，如果该字段值等于1，刚返回PC端地址，否则返回H5地址
			/// </summary>
			public readonly static Field PF5URLTYPE = new Field("PF5URLTYPE", "GOOD_GET_URL_LOG", "Pf等于5时，如果该字段值等于1，刚返回PC端地址，否则返回H5地址");
			/// <summary>
			/// 返回的数据
			/// </summary>
			public readonly static Field RESULT = new Field("RESULT", "GOOD_GET_URL_LOG", DbType.AnsiString, null, "返回的数据");
			/// <summary>
			/// 返回的评价地址
			/// </summary>
			public readonly static Field RESULT_URL = new Field("RESULT_URL", "GOOD_GET_URL_LOG", "返回的评价地址");
		}
		#endregion
		public override string GetSequence()
        {
            return "SEQ_GOOD_GET_URL_LOG";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
	}
}