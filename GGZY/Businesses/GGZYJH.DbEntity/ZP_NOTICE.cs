using System;
using System.Data;
using Dos.ORM;

namespace GGZYJH.DbEntity
{
    /// <summary>
    /// 实体类ZP_NOTICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZP_NOTICE")]
    [Serializable]
    public partial class ZP_NOTICE : JhEntity
    {
        #region Model
        private decimal? _ZN_ID;
        private string _ZN_UNITNAME;
        private string _ZN_ADDRESS;
        private string _ZN_NAME;
        private string _ZN_PHONE;
        private string _ZN_POST;
        private string _ZN_FAX;
        private string _ZN_EMAIL;
        private string _ZN_ZID;
        private string _ZN_INDUSTRY;
        private DateTime? _ZN_OPENTIME;
        private string _ZN_BEACONTYPE;
        private string _ZN_MONEY;
        private string _ZN_WAY;
        private string _ZN_TITLE;
        private string _ZN_PROXY;
        private string _ZN_USERNAME;
        private string _ZN_AREA;
        private string _ZN_KEY;
        private string _ZN_GOV;
        private string _ZN_CONTENT;
        private DateTime? _ZN_TIME;
        private string _ZN_STATE;
        private DateTime? _ZN_EDITTIME;
        private string _ZN_USERID;
        private DateTime? _CRTIME;
        private string _ZN_ESTATE;
        private string _ZN_OESTATE;
        private string _ZN_ENAME;
        private string _ZN_ZRSTATE;
        private string _ZN_ZRSTATE1;
        private string _ZN_TAG;
        private string _ZN_LXPW;
        private string _ZN_PBSJ;
        private string _ZN_BMSJ;
        private string _ZN_JZSJ;
        private string _ZN_ZJLY_YZ;
        private string _ZN_ZJLY_SK;
        private string _ZN_ZJLY_QT;
        private DateTime? _ZR_N_TIME;
        private DateTime? _ZR_R_TIME;
        private string _ZN_PERSON_NAME;

        /// <summary>
        /// 
        /// </summary>
        public decimal? ZN_ID
        {
            get { return _ZN_ID; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ID, _ZN_ID, value);
                this._ZN_ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_UNITNAME
        {
            get { return _ZN_UNITNAME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_UNITNAME, _ZN_UNITNAME, value);
                this._ZN_UNITNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ADDRESS
        {
            get { return _ZN_ADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ADDRESS, _ZN_ADDRESS, value);
                this._ZN_ADDRESS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_NAME
        {
            get { return _ZN_NAME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_NAME, _ZN_NAME, value);
                this._ZN_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_PHONE
        {
            get { return _ZN_PHONE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_PHONE, _ZN_PHONE, value);
                this._ZN_PHONE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_POST
        {
            get { return _ZN_POST; }
            set
            {
                this.OnPropertyValueChange(_.ZN_POST, _ZN_POST, value);
                this._ZN_POST = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_FAX
        {
            get { return _ZN_FAX; }
            set
            {
                this.OnPropertyValueChange(_.ZN_FAX, _ZN_FAX, value);
                this._ZN_FAX = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_EMAIL
        {
            get { return _ZN_EMAIL; }
            set
            {
                this.OnPropertyValueChange(_.ZN_EMAIL, _ZN_EMAIL, value);
                this._ZN_EMAIL = value;
            }
        }
        /// <summary>
        /// 招标编号
        /// </summary>
        public string ZN_ZID
        {
            get { return _ZN_ZID; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZID, _ZN_ZID, value);
                this._ZN_ZID = value;
            }
        }
        /// <summary>
        /// 所属行业
        /// </summary>
        public string ZN_INDUSTRY
        {
            get { return _ZN_INDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.ZN_INDUSTRY, _ZN_INDUSTRY, value);
                this._ZN_INDUSTRY = value;
            }
        }
        /// <summary>
        /// 开标时间
        /// </summary>
        public DateTime? ZN_OPENTIME
        {
            get { return _ZN_OPENTIME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_OPENTIME, _ZN_OPENTIME, value);
                this._ZN_OPENTIME = value;
            }
        }
        /// <summary>
        /// 标讯类别
        /// </summary>
        public string ZN_BEACONTYPE
        {
            get { return _ZN_BEACONTYPE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_BEACONTYPE, _ZN_BEACONTYPE, value);
                this._ZN_BEACONTYPE = value;
            }
        }
        /// <summary>
        /// 资金来源
        /// </summary>
        public string ZN_MONEY
        {
            get { return _ZN_MONEY; }
            set
            {
                this.OnPropertyValueChange(_.ZN_MONEY, _ZN_MONEY, value);
                this._ZN_MONEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_WAY
        {
            get { return _ZN_WAY; }
            set
            {
                this.OnPropertyValueChange(_.ZN_WAY, _ZN_WAY, value);
                this._ZN_WAY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_TITLE
        {
            get { return _ZN_TITLE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_TITLE, _ZN_TITLE, value);
                this._ZN_TITLE = value;
            }
        }
        /// <summary>
        /// 招标代理
        /// </summary>
        public string ZN_PROXY
        {
            get { return _ZN_PROXY; }
            set
            {
                this.OnPropertyValueChange(_.ZN_PROXY, _ZN_PROXY, value);
                this._ZN_PROXY = value;
            }
        }
        /// <summary>
        /// 业主名称
        /// </summary>
        public string ZN_USERNAME
        {
            get { return _ZN_USERNAME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_USERNAME, _ZN_USERNAME, value);
                this._ZN_USERNAME = value;
            }
        }
        /// <summary>
        /// 所属地区
        /// </summary>
        public string ZN_AREA
        {
            get { return _ZN_AREA; }
            set
            {
                this.OnPropertyValueChange(_.ZN_AREA, _ZN_AREA, value);
                this._ZN_AREA = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_KEY
        {
            get { return _ZN_KEY; }
            set
            {
                this.OnPropertyValueChange(_.ZN_KEY, _ZN_KEY, value);
                this._ZN_KEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_GOV
        {
            get { return _ZN_GOV; }
            set
            {
                this.OnPropertyValueChange(_.ZN_GOV, _ZN_GOV, value);
                this._ZN_GOV = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_CONTENT
        {
            get { return _ZN_CONTENT; }
            set
            {
                this.OnPropertyValueChange(_.ZN_CONTENT, _ZN_CONTENT, value);
                this._ZN_CONTENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZN_TIME
        {
            get { return _ZN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_TIME, _ZN_TIME, value);
                this._ZN_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_STATE
        {
            get { return _ZN_STATE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_STATE, _ZN_STATE, value);
                this._ZN_STATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZN_EDITTIME
        {
            get { return _ZN_EDITTIME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_EDITTIME, _ZN_EDITTIME, value);
                this._ZN_EDITTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_USERID
        {
            get { return _ZN_USERID; }
            set
            {
                this.OnPropertyValueChange(_.ZN_USERID, _ZN_USERID, value);
                this._ZN_USERID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CRTIME
        {
            get { return _CRTIME; }
            set
            {
                this.OnPropertyValueChange(_.CRTIME, _CRTIME, value);
                this._CRTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ESTATE
        {
            get { return _ZN_ESTATE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ESTATE, _ZN_ESTATE, value);
                this._ZN_ESTATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_OESTATE
        {
            get { return _ZN_OESTATE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_OESTATE, _ZN_OESTATE, value);
                this._ZN_OESTATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ENAME
        {
            get { return _ZN_ENAME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ENAME, _ZN_ENAME, value);
                this._ZN_ENAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZRSTATE
        {
            get { return _ZN_ZRSTATE; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZRSTATE, _ZN_ZRSTATE, value);
                this._ZN_ZRSTATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZRSTATE1
        {
            get { return _ZN_ZRSTATE1; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZRSTATE1, _ZN_ZRSTATE1, value);
                this._ZN_ZRSTATE1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_TAG
        {
            get { return _ZN_TAG; }
            set
            {
                this.OnPropertyValueChange(_.ZN_TAG, _ZN_TAG, value);
                this._ZN_TAG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_LXPW
        {
            get { return _ZN_LXPW; }
            set
            {
                this.OnPropertyValueChange(_.ZN_LXPW, _ZN_LXPW, value);
                this._ZN_LXPW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_PBSJ
        {
            get { return _ZN_PBSJ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_PBSJ, _ZN_PBSJ, value);
                this._ZN_PBSJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_BMSJ
        {
            get { return _ZN_BMSJ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_BMSJ, _ZN_BMSJ, value);
                this._ZN_BMSJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_JZSJ
        {
            get { return _ZN_JZSJ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_JZSJ, _ZN_JZSJ, value);
                this._ZN_JZSJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZJLY_YZ
        {
            get { return _ZN_ZJLY_YZ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZJLY_YZ, _ZN_ZJLY_YZ, value);
                this._ZN_ZJLY_YZ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZJLY_SK
        {
            get { return _ZN_ZJLY_SK; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZJLY_SK, _ZN_ZJLY_SK, value);
                this._ZN_ZJLY_SK = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZJLY_QT
        {
            get { return _ZN_ZJLY_QT; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZJLY_QT, _ZN_ZJLY_QT, value);
                this._ZN_ZJLY_QT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZR_N_TIME
        {
            get { return _ZR_N_TIME; }
            set
            {
                this.OnPropertyValueChange(_.ZR_N_TIME, _ZR_N_TIME, value);
                this._ZR_N_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZR_R_TIME
        {
            get { return _ZR_R_TIME; }
            set
            {
                this.OnPropertyValueChange(_.ZR_R_TIME, _ZR_R_TIME, value);
                this._ZR_R_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_PERSON_NAME
        {
            get { return _ZN_PERSON_NAME; }
            set
            {
                this.OnPropertyValueChange(_.ZN_PERSON_NAME, _ZN_PERSON_NAME, value);
                this._ZN_PERSON_NAME = value;
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
                _.ZN_ID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ZN_ID,
                _.ZN_UNITNAME,
                _.ZN_ADDRESS,
                _.ZN_NAME,
                _.ZN_PHONE,
                _.ZN_POST,
                _.ZN_FAX,
                _.ZN_EMAIL,
                _.ZN_ZID,
                _.ZN_INDUSTRY,
                _.ZN_OPENTIME,
                _.ZN_BEACONTYPE,
                _.ZN_MONEY,
                _.ZN_WAY,
                _.ZN_TITLE,
                _.ZN_PROXY,
                _.ZN_USERNAME,
                _.ZN_AREA,
                _.ZN_KEY,
                _.ZN_GOV,
                _.ZN_CONTENT,
                _.ZN_TIME,
                _.ZN_STATE,
                _.ZN_EDITTIME,
                _.ZN_USERID,
                _.CRTIME,
                _.ZN_ESTATE,
                _.ZN_OESTATE,
                _.ZN_ENAME,
                _.ZN_ZRSTATE,
                _.ZN_ZRSTATE1,
                _.ZN_TAG,
                _.ZN_LXPW,
                _.ZN_PBSJ,
                _.ZN_BMSJ,
                _.ZN_JZSJ,
                _.ZN_ZJLY_YZ,
                _.ZN_ZJLY_SK,
                _.ZN_ZJLY_QT,
                _.ZR_N_TIME,
                _.ZR_R_TIME,
                _.ZN_PERSON_NAME,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ZN_ID,
                this._ZN_UNITNAME,
                this._ZN_ADDRESS,
                this._ZN_NAME,
                this._ZN_PHONE,
                this._ZN_POST,
                this._ZN_FAX,
                this._ZN_EMAIL,
                this._ZN_ZID,
                this._ZN_INDUSTRY,
                this._ZN_OPENTIME,
                this._ZN_BEACONTYPE,
                this._ZN_MONEY,
                this._ZN_WAY,
                this._ZN_TITLE,
                this._ZN_PROXY,
                this._ZN_USERNAME,
                this._ZN_AREA,
                this._ZN_KEY,
                this._ZN_GOV,
                this._ZN_CONTENT,
                this._ZN_TIME,
                this._ZN_STATE,
                this._ZN_EDITTIME,
                this._ZN_USERID,
                this._CRTIME,
                this._ZN_ESTATE,
                this._ZN_OESTATE,
                this._ZN_ENAME,
                this._ZN_ZRSTATE,
                this._ZN_ZRSTATE1,
                this._ZN_TAG,
                this._ZN_LXPW,
                this._ZN_PBSJ,
                this._ZN_BMSJ,
                this._ZN_JZSJ,
                this._ZN_ZJLY_YZ,
                this._ZN_ZJLY_SK,
                this._ZN_ZJLY_QT,
                this._ZR_N_TIME,
                this._ZR_R_TIME,
                this._ZN_PERSON_NAME,
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
            public readonly static Field All = new Field("*", "ZP_NOTICE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ID = new Field("ZN_ID", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_UNITNAME = new Field("ZN_UNITNAME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ADDRESS = new Field("ZN_ADDRESS", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_NAME = new Field("ZN_NAME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_PHONE = new Field("ZN_PHONE", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_POST = new Field("ZN_POST", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_FAX = new Field("ZN_FAX", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_EMAIL = new Field("ZN_EMAIL", "ZP_NOTICE", "");
            /// <summary>
			/// 招标编号
			/// </summary>
			public readonly static Field ZN_ZID = new Field("ZN_ZID", "ZP_NOTICE", "招标编号");
            /// <summary>
			/// 所属行业
			/// </summary>
			public readonly static Field ZN_INDUSTRY = new Field("ZN_INDUSTRY", "ZP_NOTICE", "所属行业");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field ZN_OPENTIME = new Field("ZN_OPENTIME", "ZP_NOTICE", "开标时间");
            /// <summary>
			/// 标讯类别
			/// </summary>
			public readonly static Field ZN_BEACONTYPE = new Field("ZN_BEACONTYPE", "ZP_NOTICE", "标讯类别");
            /// <summary>
			/// 资金来源
			/// </summary>
			public readonly static Field ZN_MONEY = new Field("ZN_MONEY", "ZP_NOTICE", "资金来源");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_WAY = new Field("ZN_WAY", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_TITLE = new Field("ZN_TITLE", "ZP_NOTICE", "");
            /// <summary>
			/// 招标代理
			/// </summary>
			public readonly static Field ZN_PROXY = new Field("ZN_PROXY", "ZP_NOTICE", "招标代理");
            /// <summary>
			/// 业主名称
			/// </summary>
			public readonly static Field ZN_USERNAME = new Field("ZN_USERNAME", "ZP_NOTICE", "业主名称");
            /// <summary>
			/// 所属地区
			/// </summary>
			public readonly static Field ZN_AREA = new Field("ZN_AREA", "ZP_NOTICE", "所属地区");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_KEY = new Field("ZN_KEY", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_GOV = new Field("ZN_GOV", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_CONTENT = new Field("ZN_CONTENT", "ZP_NOTICE", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_TIME = new Field("ZN_TIME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_STATE = new Field("ZN_STATE", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_EDITTIME = new Field("ZN_EDITTIME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_USERID = new Field("ZN_USERID", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CRTIME = new Field("CRTIME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ESTATE = new Field("ZN_ESTATE", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_OESTATE = new Field("ZN_OESTATE", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ENAME = new Field("ZN_ENAME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZRSTATE = new Field("ZN_ZRSTATE", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZRSTATE1 = new Field("ZN_ZRSTATE1", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_TAG = new Field("ZN_TAG", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_LXPW = new Field("ZN_LXPW", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_PBSJ = new Field("ZN_PBSJ", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_BMSJ = new Field("ZN_BMSJ", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_JZSJ = new Field("ZN_JZSJ", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZJLY_YZ = new Field("ZN_ZJLY_YZ", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZJLY_SK = new Field("ZN_ZJLY_SK", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZJLY_QT = new Field("ZN_ZJLY_QT", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_N_TIME = new Field("ZR_N_TIME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_R_TIME = new Field("ZR_R_TIME", "ZP_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_PERSON_NAME = new Field("ZN_PERSON_NAME", "ZP_NOTICE", "");
        }
        #endregion
    }
}