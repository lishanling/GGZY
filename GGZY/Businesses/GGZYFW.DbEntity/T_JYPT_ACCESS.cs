using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_JYPT_ACCESS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_JYPT_ACCESS")]
    [Serializable]
    public partial class T_JYPT_ACCESS : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _JYPT_NAME;
		private string _YYHYFW;
		private string _YYQYFW;
		private string _KFGS;
		private string _KFGS_CODE;
		private string _YWGS;
		private string _YWGS_CODE;
		private string _LXR_NAME;
		private string _LXR_PHONE;
		private string _LXR_EMAIL;
		private string _PT_URL;
		private string _PT_IP;
		private string _PT_QY;
		private string _SF_BD;
		private string _SF_HTTPS;
		private string _PTAQJB;
		private string _PTRZ;
		private string _PTYW;
		private string _PTDRFS;
		private string _SF_JRFJ;
		private string _PTAL;
		private string _PTJJ;
		private decimal? _STATUS;
		private string _STOP_REMARK;
		private string _STOP_FILE;
		private DateTime? _STOP_TM;
		private decimal? _CLHY_STATUS;
		private string _CLHY_REMARK;
		private string _CLHY_PEOPLE;
		private DateTime? _CLHY_TM;
		private decimal? _ZGDW_STATUS;
		private string _ZGDW_REMARK;
		private string _ZGDW_PEOPLE;
		private DateTime? _ZGDW_TM;
		private string _CLHY_FILES;
		private string _ZGDW_FILES;
		private decimal? _DJCG_STATUS;
		private string _DJCG_REMARK;
		private string _DJCG_PEOPLE;
		private DateTime? _DJCG_TM;
		private string _DJCG_FILES;
		private DateTime? _CREATE_TM;

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
		/// 交易平台名称
		/// </summary>
		public string JYPT_NAME
		{
			get{ return _JYPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.JYPT_NAME, _JYPT_NAME, value);
				this._JYPT_NAME = value;
			}
		}
		/// <summary>
		/// 应用行业范围
		/// </summary>
		public string YYHYFW
		{
			get{ return _YYHYFW; }
			set
			{
				this.OnPropertyValueChange(_.YYHYFW, _YYHYFW, value);
				this._YYHYFW = value;
			}
		}
		/// <summary>
		/// 应用区域范围
		/// </summary>
		public string YYQYFW
		{
			get{ return _YYQYFW; }
			set
			{
				this.OnPropertyValueChange(_.YYQYFW, _YYQYFW, value);
				this._YYQYFW = value;
			}
		}
		/// <summary>
		/// 平台开发公司
		/// </summary>
		public string KFGS
		{
			get{ return _KFGS; }
			set
			{
				this.OnPropertyValueChange(_.KFGS, _KFGS, value);
				this._KFGS = value;
			}
		}
		/// <summary>
		/// 开发公司统一信用代码
		/// </summary>
		public string KFGS_CODE
		{
			get{ return _KFGS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.KFGS_CODE, _KFGS_CODE, value);
				this._KFGS_CODE = value;
			}
		}
		/// <summary>
		/// 平台运维公司
		/// </summary>
		public string YWGS
		{
			get{ return _YWGS; }
			set
			{
				this.OnPropertyValueChange(_.YWGS, _YWGS, value);
				this._YWGS = value;
			}
		}
		/// <summary>
		/// 平台运维公司统一信用代码
		/// </summary>
		public string YWGS_CODE
		{
			get{ return _YWGS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.YWGS_CODE, _YWGS_CODE, value);
				this._YWGS_CODE = value;
			}
		}
		/// <summary>
		/// 联系人姓名
		/// </summary>
		public string LXR_NAME
		{
			get{ return _LXR_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LXR_NAME, _LXR_NAME, value);
				this._LXR_NAME = value;
			}
		}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public string LXR_PHONE
		{
			get{ return _LXR_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.LXR_PHONE, _LXR_PHONE, value);
				this._LXR_PHONE = value;
			}
		}
		/// <summary>
		/// 联系人电子邮箱
		/// </summary>
		public string LXR_EMAIL
		{
			get{ return _LXR_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.LXR_EMAIL, _LXR_EMAIL, value);
				this._LXR_EMAIL = value;
			}
		}
		/// <summary>
		/// 平台访问地址
		/// </summary>
		public string PT_URL
		{
			get{ return _PT_URL; }
			set
			{
				this.OnPropertyValueChange(_.PT_URL, _PT_URL, value);
				this._PT_URL = value;
			}
		}
		/// <summary>
		/// 平台IP地址
		/// </summary>
		public string PT_IP
		{
			get{ return _PT_IP; }
			set
			{
				this.OnPropertyValueChange(_.PT_IP, _PT_IP, value);
				this._PT_IP = value;
			}
		}
		/// <summary>
		/// 平台部署区域
		/// </summary>
		public string PT_QY
		{
			get{ return _PT_QY; }
			set
			{
				this.OnPropertyValueChange(_.PT_QY, _PT_QY, value);
				this._PT_QY = value;
			}
		}
		/// <summary>
		/// 是否支持本地部署
		/// </summary>
		public string SF_BD
		{
			get{ return _SF_BD; }
			set
			{
				this.OnPropertyValueChange(_.SF_BD, _SF_BD, value);
				this._SF_BD = value;
			}
		}
		/// <summary>
		/// 平台是否有HTTPS加密
		/// </summary>
		public string SF_HTTPS
		{
			get{ return _SF_HTTPS; }
			set
			{
				this.OnPropertyValueChange(_.SF_HTTPS, _SF_HTTPS, value);
				this._SF_HTTPS = value;
			}
		}
		/// <summary>
		/// 平台安全级别
		/// </summary>
		public string PTAQJB
		{
			get{ return _PTAQJB; }
			set
			{
				this.OnPropertyValueChange(_.PTAQJB, _PTAQJB, value);
				this._PTAQJB = value;
			}
		}
		/// <summary>
		/// 平台认证
		/// </summary>
		public string PTRZ
		{
			get{ return _PTRZ; }
			set
			{
				this.OnPropertyValueChange(_.PTRZ, _PTRZ, value);
				this._PTRZ = value;
			}
		}
		/// <summary>
		/// 平台业务范围
		/// </summary>
		public string PTYW
		{
			get{ return _PTYW; }
			set
			{
				this.OnPropertyValueChange(_.PTYW, _PTYW, value);
				this._PTYW = value;
			}
		}
		/// <summary>
		/// 平台登入方式
		/// </summary>
		public string PTDRFS
		{
			get{ return _PTDRFS; }
			set
			{
				this.OnPropertyValueChange(_.PTDRFS, _PTDRFS, value);
				this._PTDRFS = value;
			}
		}
		/// <summary>
		/// 是否愿意加入福建省统一身份认证体系
		/// </summary>
		public string SF_JRFJ
		{
			get{ return _SF_JRFJ; }
			set
			{
				this.OnPropertyValueChange(_.SF_JRFJ, _SF_JRFJ, value);
				this._SF_JRFJ = value;
			}
		}
		/// <summary>
		/// 平台应用案例
		/// </summary>
		public string PTAL
		{
			get{ return _PTAL; }
			set
			{
				this.OnPropertyValueChange(_.PTAL, _PTAL, value);
				this._PTAL = value;
			}
		}
		/// <summary>
		/// 平台简介
		/// </summary>
		public string PTJJ
		{
			get{ return _PTJJ; }
			set
			{
				this.OnPropertyValueChange(_.PTJJ, _PTJJ, value);
				this._PTJJ = value;
			}
		}
		/// <summary>
		/// 对接状态 对接中、对接暂停，对接完成
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 对接暂停说明
		/// </summary>
		public string STOP_REMARK
		{
			get{ return _STOP_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.STOP_REMARK, _STOP_REMARK, value);
				this._STOP_REMARK = value;
			}
		}
		/// <summary>
		/// 对接暂停附件
		/// </summary>
		public string STOP_FILE
		{
			get{ return _STOP_FILE; }
			set
			{
				this.OnPropertyValueChange(_.STOP_FILE, _STOP_FILE, value);
				this._STOP_FILE = value;
			}
		}
		/// <summary>
		/// 对接暂停时间
		/// </summary>
		public DateTime? STOP_TM
		{
			get{ return _STOP_TM; }
			set
			{
				this.OnPropertyValueChange(_.STOP_TM, _STOP_TM, value);
				this._STOP_TM = value;
			}
		}
		/// <summary>
		/// 材料核验状态 通过不通过
		/// </summary>
		public decimal? CLHY_STATUS
		{
			get{ return _CLHY_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_STATUS, _CLHY_STATUS, value);
				this._CLHY_STATUS = value;
			}
		}
		/// <summary>
		/// 材料核验意见
		/// </summary>
		public string CLHY_REMARK
		{
			get{ return _CLHY_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_REMARK, _CLHY_REMARK, value);
				this._CLHY_REMARK = value;
			}
		}
		/// <summary>
		/// 材料核验人
		/// </summary>
		public string CLHY_PEOPLE
		{
			get{ return _CLHY_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_PEOPLE, _CLHY_PEOPLE, value);
				this._CLHY_PEOPLE = value;
			}
		}
		/// <summary>
		/// 材料核验提交时间
		/// </summary>
		public DateTime? CLHY_TM
		{
			get{ return _CLHY_TM; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_TM, _CLHY_TM, value);
				this._CLHY_TM = value;
			}
		}
		/// <summary>
		/// 主管单位状态 通过不通过
		/// </summary>
		public decimal? ZGDW_STATUS
		{
			get{ return _ZGDW_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_STATUS, _ZGDW_STATUS, value);
				this._ZGDW_STATUS = value;
			}
		}
		/// <summary>
		/// 主管单位意见
		/// </summary>
		public string ZGDW_REMARK
		{
			get{ return _ZGDW_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_REMARK, _ZGDW_REMARK, value);
				this._ZGDW_REMARK = value;
			}
		}
		/// <summary>
		/// 主管单位人
		/// </summary>
		public string ZGDW_PEOPLE
		{
			get{ return _ZGDW_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_PEOPLE, _ZGDW_PEOPLE, value);
				this._ZGDW_PEOPLE = value;
			}
		}
		/// <summary>
		/// 主管单位提交时间
		/// </summary>
		public DateTime? ZGDW_TM
		{
			get{ return _ZGDW_TM; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_TM, _ZGDW_TM, value);
				this._ZGDW_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLHY_FILES
		{
			get{ return _CLHY_FILES; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_FILES, _CLHY_FILES, value);
				this._CLHY_FILES = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGDW_FILES
		{
			get{ return _ZGDW_FILES; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_FILES, _ZGDW_FILES, value);
				this._ZGDW_FILES = value;
			}
		}
		/// <summary>
		/// 对接成功证明状态 通过不通过
		/// </summary>
		public decimal? DJCG_STATUS
		{
			get{ return _DJCG_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_STATUS, _DJCG_STATUS, value);
				this._DJCG_STATUS = value;
			}
		}
		/// <summary>
		/// 对接成功证明意见
		/// </summary>
		public string DJCG_REMARK
		{
			get{ return _DJCG_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_REMARK, _DJCG_REMARK, value);
				this._DJCG_REMARK = value;
			}
		}
		/// <summary>
		/// 对接成功证明人
		/// </summary>
		public string DJCG_PEOPLE
		{
			get{ return _DJCG_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_PEOPLE, _DJCG_PEOPLE, value);
				this._DJCG_PEOPLE = value;
			}
		}
		/// <summary>
		/// 对接成功证明提交时间
		/// </summary>
		public DateTime? DJCG_TM
		{
			get{ return _DJCG_TM; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_TM, _DJCG_TM, value);
				this._DJCG_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DJCG_FILES
		{
			get{ return _DJCG_FILES; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_FILES, _DJCG_FILES, value);
				this._DJCG_FILES = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
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
				_.JYPT_NAME,
				_.YYHYFW,
				_.YYQYFW,
				_.KFGS,
				_.KFGS_CODE,
				_.YWGS,
				_.YWGS_CODE,
				_.LXR_NAME,
				_.LXR_PHONE,
				_.LXR_EMAIL,
				_.PT_URL,
				_.PT_IP,
				_.PT_QY,
				_.SF_BD,
				_.SF_HTTPS,
				_.PTAQJB,
				_.PTRZ,
				_.PTYW,
				_.PTDRFS,
				_.SF_JRFJ,
				_.PTAL,
				_.PTJJ,
				_.STATUS,
				_.STOP_REMARK,
				_.STOP_FILE,
				_.STOP_TM,
				_.CLHY_STATUS,
				_.CLHY_REMARK,
				_.CLHY_PEOPLE,
				_.CLHY_TM,
				_.ZGDW_STATUS,
				_.ZGDW_REMARK,
				_.ZGDW_PEOPLE,
				_.ZGDW_TM,
				_.CLHY_FILES,
				_.ZGDW_FILES,
				_.DJCG_STATUS,
				_.DJCG_REMARK,
				_.DJCG_PEOPLE,
				_.DJCG_TM,
				_.DJCG_FILES,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._JYPT_NAME,
				this._YYHYFW,
				this._YYQYFW,
				this._KFGS,
				this._KFGS_CODE,
				this._YWGS,
				this._YWGS_CODE,
				this._LXR_NAME,
				this._LXR_PHONE,
				this._LXR_EMAIL,
				this._PT_URL,
				this._PT_IP,
				this._PT_QY,
				this._SF_BD,
				this._SF_HTTPS,
				this._PTAQJB,
				this._PTRZ,
				this._PTYW,
				this._PTDRFS,
				this._SF_JRFJ,
				this._PTAL,
				this._PTJJ,
				this._STATUS,
				this._STOP_REMARK,
				this._STOP_FILE,
				this._STOP_TM,
				this._CLHY_STATUS,
				this._CLHY_REMARK,
				this._CLHY_PEOPLE,
				this._CLHY_TM,
				this._ZGDW_STATUS,
				this._ZGDW_REMARK,
				this._ZGDW_PEOPLE,
				this._ZGDW_TM,
				this._CLHY_FILES,
				this._ZGDW_FILES,
				this._DJCG_STATUS,
				this._DJCG_REMARK,
				this._DJCG_PEOPLE,
				this._DJCG_TM,
				this._DJCG_FILES,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_JYPT_ACCESS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_JYPT_ACCESS", "ID");
            /// <summary>
			/// 交易平台名称
			/// </summary>
			public readonly static Field JYPT_NAME = new Field("JYPT_NAME", "T_JYPT_ACCESS", "交易平台名称");
            /// <summary>
			/// 应用行业范围
			/// </summary>
			public readonly static Field YYHYFW = new Field("YYHYFW", "T_JYPT_ACCESS", "应用行业范围");
            /// <summary>
			/// 应用区域范围
			/// </summary>
			public readonly static Field YYQYFW = new Field("YYQYFW", "T_JYPT_ACCESS", "应用区域范围");
            /// <summary>
			/// 平台开发公司
			/// </summary>
			public readonly static Field KFGS = new Field("KFGS", "T_JYPT_ACCESS", "平台开发公司");
            /// <summary>
			/// 开发公司统一信用代码
			/// </summary>
			public readonly static Field KFGS_CODE = new Field("KFGS_CODE", "T_JYPT_ACCESS", "开发公司统一信用代码");
            /// <summary>
			/// 平台运维公司
			/// </summary>
			public readonly static Field YWGS = new Field("YWGS", "T_JYPT_ACCESS", "平台运维公司");
            /// <summary>
			/// 平台运维公司统一信用代码
			/// </summary>
			public readonly static Field YWGS_CODE = new Field("YWGS_CODE", "T_JYPT_ACCESS", "平台运维公司统一信用代码");
            /// <summary>
			/// 联系人姓名
			/// </summary>
			public readonly static Field LXR_NAME = new Field("LXR_NAME", "T_JYPT_ACCESS", "联系人姓名");
            /// <summary>
			/// 联系人电话
			/// </summary>
			public readonly static Field LXR_PHONE = new Field("LXR_PHONE", "T_JYPT_ACCESS", "联系人电话");
            /// <summary>
			/// 联系人电子邮箱
			/// </summary>
			public readonly static Field LXR_EMAIL = new Field("LXR_EMAIL", "T_JYPT_ACCESS", "联系人电子邮箱");
            /// <summary>
			/// 平台访问地址
			/// </summary>
			public readonly static Field PT_URL = new Field("PT_URL", "T_JYPT_ACCESS", "平台访问地址");
            /// <summary>
			/// 平台IP地址
			/// </summary>
			public readonly static Field PT_IP = new Field("PT_IP", "T_JYPT_ACCESS", "平台IP地址");
            /// <summary>
			/// 平台部署区域
			/// </summary>
			public readonly static Field PT_QY = new Field("PT_QY", "T_JYPT_ACCESS", "平台部署区域");
            /// <summary>
			/// 是否支持本地部署
			/// </summary>
			public readonly static Field SF_BD = new Field("SF_BD", "T_JYPT_ACCESS", "是否支持本地部署");
            /// <summary>
			/// 平台是否有HTTPS加密
			/// </summary>
			public readonly static Field SF_HTTPS = new Field("SF_HTTPS", "T_JYPT_ACCESS", "平台是否有HTTPS加密");
            /// <summary>
			/// 平台安全级别
			/// </summary>
			public readonly static Field PTAQJB = new Field("PTAQJB", "T_JYPT_ACCESS", "平台安全级别");
            /// <summary>
			/// 平台认证
			/// </summary>
			public readonly static Field PTRZ = new Field("PTRZ", "T_JYPT_ACCESS", "平台认证");
            /// <summary>
			/// 平台业务范围
			/// </summary>
			public readonly static Field PTYW = new Field("PTYW", "T_JYPT_ACCESS", "平台业务范围");
            /// <summary>
			/// 平台登入方式
			/// </summary>
			public readonly static Field PTDRFS = new Field("PTDRFS", "T_JYPT_ACCESS", "平台登入方式");
            /// <summary>
			/// 是否愿意加入福建省统一身份认证体系
			/// </summary>
			public readonly static Field SF_JRFJ = new Field("SF_JRFJ", "T_JYPT_ACCESS", "是否愿意加入福建省统一身份认证体系");
            /// <summary>
			/// 平台应用案例
			/// </summary>
			public readonly static Field PTAL = new Field("PTAL", "T_JYPT_ACCESS", "平台应用案例");
            /// <summary>
			/// 平台简介
			/// </summary>
			public readonly static Field PTJJ = new Field("PTJJ", "T_JYPT_ACCESS", "平台简介");
            /// <summary>
			/// 对接状态 对接中、对接暂停，对接完成
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_JYPT_ACCESS", "对接状态 对接中、对接暂停，对接完成");
            /// <summary>
			/// 对接暂停说明
			/// </summary>
			public readonly static Field STOP_REMARK = new Field("STOP_REMARK", "T_JYPT_ACCESS", "对接暂停说明");
            /// <summary>
			/// 对接暂停附件
			/// </summary>
			public readonly static Field STOP_FILE = new Field("STOP_FILE", "T_JYPT_ACCESS", "对接暂停附件");
            /// <summary>
			/// 对接暂停时间
			/// </summary>
			public readonly static Field STOP_TM = new Field("STOP_TM", "T_JYPT_ACCESS", "对接暂停时间");
            /// <summary>
			/// 材料核验状态 通过不通过
			/// </summary>
			public readonly static Field CLHY_STATUS = new Field("CLHY_STATUS", "T_JYPT_ACCESS", "材料核验状态 通过不通过");
            /// <summary>
			/// 材料核验意见
			/// </summary>
			public readonly static Field CLHY_REMARK = new Field("CLHY_REMARK", "T_JYPT_ACCESS", "材料核验意见");
            /// <summary>
			/// 材料核验人
			/// </summary>
			public readonly static Field CLHY_PEOPLE = new Field("CLHY_PEOPLE", "T_JYPT_ACCESS", "材料核验人");
            /// <summary>
			/// 材料核验提交时间
			/// </summary>
			public readonly static Field CLHY_TM = new Field("CLHY_TM", "T_JYPT_ACCESS", "材料核验提交时间");
            /// <summary>
			/// 主管单位状态 通过不通过
			/// </summary>
			public readonly static Field ZGDW_STATUS = new Field("ZGDW_STATUS", "T_JYPT_ACCESS", "主管单位状态 通过不通过");
            /// <summary>
			/// 主管单位意见
			/// </summary>
			public readonly static Field ZGDW_REMARK = new Field("ZGDW_REMARK", "T_JYPT_ACCESS", "主管单位意见");
            /// <summary>
			/// 主管单位人
			/// </summary>
			public readonly static Field ZGDW_PEOPLE = new Field("ZGDW_PEOPLE", "T_JYPT_ACCESS", "主管单位人");
            /// <summary>
			/// 主管单位提交时间
			/// </summary>
			public readonly static Field ZGDW_TM = new Field("ZGDW_TM", "T_JYPT_ACCESS", "主管单位提交时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLHY_FILES = new Field("CLHY_FILES", "T_JYPT_ACCESS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZGDW_FILES = new Field("ZGDW_FILES", "T_JYPT_ACCESS", "");
            /// <summary>
			/// 对接成功证明状态 通过不通过
			/// </summary>
			public readonly static Field DJCG_STATUS = new Field("DJCG_STATUS", "T_JYPT_ACCESS", "对接成功证明状态 通过不通过");
            /// <summary>
			/// 对接成功证明意见
			/// </summary>
			public readonly static Field DJCG_REMARK = new Field("DJCG_REMARK", "T_JYPT_ACCESS", "对接成功证明意见");
            /// <summary>
			/// 对接成功证明人
			/// </summary>
			public readonly static Field DJCG_PEOPLE = new Field("DJCG_PEOPLE", "T_JYPT_ACCESS", "对接成功证明人");
            /// <summary>
			/// 对接成功证明提交时间
			/// </summary>
			public readonly static Field DJCG_TM = new Field("DJCG_TM", "T_JYPT_ACCESS", "对接成功证明提交时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DJCG_FILES = new Field("DJCG_FILES", "T_JYPT_ACCESS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_JYPT_ACCESS", "");
        }
        #endregion
	}
}