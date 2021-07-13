using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MZTUSER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MZTUSER")]
    [Serializable]
    public partial class MZTUSER : FwEntity
    {
        #region Model
        private string _USER_ID;
        private string _USER_NAME;
        private string _USER_IDCARD;
        private string _USER_TYPE;
        private string _CARD_TYPE;
        private string _USER_MOBILE;
        private string _USER_ACCOUNT;
        private string _USER_AUTHLEVEL;
        private string _USER_CITYCODE;
        private string _USER_CONFIGPASS;
        private DateTime? _USER_JUNTIME;
        private DateTime? _USER_HITIME;
        private string _LEGAL_KEYID;
        private DateTime? _CERTS_EFFECTDATE;
        private DateTime? _CERTS_VALIDDATE;
        private string _CZD_CITYCODE;
        private string _CZD_AREACODE;
        private string _CZD_ADDRESS;
        private string _GESTURE_PASS;
        private string _NATION_LEVEL;
        private decimal? _POPULATION_AGE;
        private string _POPULATION_SEX;
        private DateTime? _POPULATION_BIRTHDAY;
        private string _POPULATION_NATION;
        private string _POPULATION_PROCODE;
        private string _POPULATION_CITYCODE;
        private string _POPULATION_AREACODE;
        private string _POPULATION_CPROCODE;
        private string _POPULATION_CCITYCODE;
        private string _POPULATION_CAREACODE;
        private string _POPULATION_CADDRESS;
        private DateTime? _POPULATION_CREATETIME;
        private string _POPULATION_EDU;
        private string _POPULATION_ALIPAY;
        private string _POPULATION_WX;
        private string _POPULATION_HJDZ;
        private string _POPULATION_JZDZ;
        private string _POPULATION_GZDW;
        private string _LEGALPERSON_NAME;
        private string _MAINACC_USERID;
        private string _LEGALPERSON_PROCODE;
        private string _LEGALPERSON_CITYCODE;
        private string _LEGALPERSON_AREACODE;
        private string _LEGALPERSON_ADDRESS;
        private string _LEGALPERSON_ZPROCODE;
        private string _LEGALPERSON_ZCITYCODE;
        private string _LEGALPERSON_ZAREACODE;
        private string _LEGALPERSON_ZADDRESS;
        private string _LEGALPERSON_EMAIL;
        private string _LEGALPERSON_PHONE;
        private DateTime? _LEGALPERSON_CREAETDATE;
        private string _LEGALPERSON_IDCARD;
        private string _LEGALPERSON_ORGTYPE;
        private string _LEGALPERSON_JBREMAIL;
        private string _LEGALPERSON_JBRNAME;
        private string _LEGALPERSON_JBRIDCARD;
        private DateTime? _LEGALPERSON_NJRQ;
        private decimal? _LEGALPERSON_NJQX;
        private string _LEGALPERSON_JYFW;
        private string _LEGALPERSON_HYMC;
        private string _LEGALPERSON_JJLX;
        private decimal? _LEGALPERSON_ZGRS;
        private string _LEGALPERSON_ZCZB;
        private string _LEGALPERSON_ZIPCODE;
        private string _LEGALPERSON_PZJG;
        private string _LEGALPERSON_ZZJGDM;
        private string _LEGALPERSON_QYXZ;
        private string _LEGALPERSON_GSZCH;
        private DateTime? _LEGALPERSON_BZRQ;
        private string _LEGALPERSON_BZDW;
        private DateTime? _LEGALPERSON_YXQQS;
        private DateTime? _LEGALPERSON_YXQJZ;
        private string _LEGALPERSON_NJQK;
        private string _LEGALPERSON_BGSX;
        private DateTime? _LEGALPERSON_SCBZ;
        private DateTime? _LEGALPERSON_FZRQ;
        private DateTime? _LEGALPERSON_CLRQ;
        private string _LEGALPERSON_TZZZCD;
        private string _LEGALPERSON_XZQH;
        private string _LEGALPERSON_DSNSRSBH;
        private DateTime? _LEGALPERSON_DSDJ;
        private string _LEGALPERSON_DSDJJG;
        private string _LEGALPERSON_DSZXYY;
        private DateTime? _LEGALPERSON_DSZXRQ;
        private string _LEGALPERSON_GSSBH;
        private DateTime? _LEGALPERSON_GSSWDJ;
        private string _LEGALPERSON_GSSWJG;
        private string _LEGALPERSON_GSZXYY;
        private DateTime? _LEGALPERSON_GSZXRQ;
        private string _LEGALPERSON_FRSJH;
        private string _LEGALPERSON_NATION;
        private string _LEGALPERSON_CZDZ;
        private string _LEGALPERSON_JBRSJH;
        private string _LEGALPERSON_FRXB;
        private string _LEGALPERSON_TYPE;
        private string _LEGALPERSON_ACCTYPE;
        private string _ENTERPRISEADDRESS;
        private decimal? _ENTERPRISECAPITAL;
        private string _ENTERPRISERANGE;
        private DateTime? _ENTERPRISEREGISTERDATE;
        private DateTime? _ENTERPRISEBEGINDATE;
        private DateTime? _ENTERPRISEENDDATE;
        private DateTime? _ENTERPRISEAPPROVALDATE;
        private string _ENTERPRISEAPPROVERAGENCY;
        private string _ACTAREA;
        private string _ASSOCIATIONCONTENT;
        private string _REGADDRESS;
        private string _INDUSTRY;
        private DateTime? _REGDATE;
        private decimal? _REGMONEY;
        private string _COMPETENTORG;
        private string _CHARITYORG;
        private string _SOCIALORGTYPE;
        private string _FUNDKIND;
        private string _REGRANGE;
        private string _REGORGANIZER;
        private string _REGAUTHORITY;
        private string _FUNDSOURCE;
        private DateTime? _CERT_YXQS;
        private DateTime? _CERT_YXJZ;
        private string _AGENTCERTTYPE;
        private string _DMZJ_PATH;
        private string _YWTYDM;
        private string _WDMLX;
        private string _YYZZ_PATH;
        private DateTime? _CREATE_TIME;
        private DateTime? _MODIFY_TIME;
        private decimal? _STATUS;
        private decimal? _JDUSERID;
        private decimal? _FWUSERID;

        /// <summary>
        /// 用户id
        /// </summary>
        public string USER_ID
        {
            get { return _USER_ID; }
            set
            {
                this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
                this._USER_ID = value;
            }
        }
        /// <summary>
        /// 用户姓名或单位名称
        /// </summary>
        public string USER_NAME
        {
            get { return _USER_NAME; }
            set
            {
                this.OnPropertyValueChange(_.USER_NAME, _USER_NAME, value);
                this._USER_NAME = value;
            }
        }
        /// <summary>
        /// 证件号码或者统一社会信用代码
        /// </summary>
        public string USER_IDCARD
        {
            get { return _USER_IDCARD; }
            set
            {
                this.OnPropertyValueChange(_.USER_IDCARD, _USER_IDCARD, value);
                this._USER_IDCARD = value;
            }
        }
        /// <summary>
        /// 用户类型(1:个人用户 2:法人用户)
        /// </summary>
        public string USER_TYPE
        {
            get { return _USER_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.USER_TYPE, _USER_TYPE, value);
                this._USER_TYPE = value;
            }
        }
        /// <summary>
        /// 注册用户的证件类型，可选值如下 居民身份证:111,普通护照:414, 台湾居民来往大陆通行证:511, 港澳居民来往内地 通行证: 516, 其他:999
        /// </summary>
        public string CARD_TYPE
        {
            get { return _CARD_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.CARD_TYPE, _CARD_TYPE, value);
                this._CARD_TYPE = value;
            }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        public string USER_MOBILE
        {
            get { return _USER_MOBILE; }
            set
            {
                this.OnPropertyValueChange(_.USER_MOBILE, _USER_MOBILE, value);
                this._USER_MOBILE = value;
            }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string USER_ACCOUNT
        {
            get { return _USER_ACCOUNT; }
            set
            {
                this.OnPropertyValueChange(_.USER_ACCOUNT, _USER_ACCOUNT, value);
                this._USER_ACCOUNT = value;
            }
        }
        /// <summary>
        /// 认证级别(0:未认证 1:初级 2:高级3:eid 高 级认证状态)
        /// </summary>
        public string USER_AUTHLEVEL
        {
            get { return _USER_AUTHLEVEL; }
            set
            {
                this.OnPropertyValueChange(_.USER_AUTHLEVEL, _USER_AUTHLEVEL, value);
                this._USER_AUTHLEVEL = value;
            }
        }
        /// <summary>
        /// 用户所在地市编码
        /// </summary>
        public string USER_CITYCODE
        {
            get { return _USER_CITYCODE; }
            set
            {
                this.OnPropertyValueChange(_.USER_CITYCODE, _USER_CITYCODE, value);
                this._USER_CITYCODE = value;
            }
        }
        /// <summary>
        /// 是否设置了密保问题(1:是 -1:否)
        /// </summary>
        public string USER_CONFIGPASS
        {
            get { return _USER_CONFIGPASS; }
            set
            {
                this.OnPropertyValueChange(_.USER_CONFIGPASS, _USER_CONFIGPASS, value);
                this._USER_CONFIGPASS = value;
            }
        }
        /// <summary>
        /// 初级认证的时间
        /// </summary>
        public DateTime? USER_JUNTIME
        {
            get { return _USER_JUNTIME; }
            set
            {
                this.OnPropertyValueChange(_.USER_JUNTIME, _USER_JUNTIME, value);
                this._USER_JUNTIME = value;
            }
        }
        /// <summary>
        /// 高级认证的时间
        /// </summary>
        public DateTime? USER_HITIME
        {
            get { return _USER_HITIME; }
            set
            {
                this.OnPropertyValueChange(_.USER_HITIME, _USER_HITIME, value);
                this._USER_HITIME = value;
            }
        }
        /// <summary>
        /// Ukey 唯一标识号，这个有值的情况下，代 表法人进行了 CA 认证。
        /// </summary>
        public string LEGAL_KEYID
        {
            get { return _LEGAL_KEYID; }
            set
            {
                this.OnPropertyValueChange(_.LEGAL_KEYID, _LEGAL_KEYID, value);
                this._LEGAL_KEYID = value;
            }
        }
        /// <summary>
        /// 身份证有效期开始
        /// </summary>
        public DateTime? CERTS_EFFECTDATE
        {
            get { return _CERTS_EFFECTDATE; }
            set
            {
                this.OnPropertyValueChange(_.CERTS_EFFECTDATE, _CERTS_EFFECTDATE, value);
                this._CERTS_EFFECTDATE = value;
            }
        }
        /// <summary>
        /// 身份证有效期结束
        /// </summary>
        public DateTime? CERTS_VALIDDATE
        {
            get { return _CERTS_VALIDDATE; }
            set
            {
                this.OnPropertyValueChange(_.CERTS_VALIDDATE, _CERTS_VALIDDATE, value);
                this._CERTS_VALIDDATE = value;
            }
        }
        /// <summary>
        /// 常住地地市编码
        /// </summary>
        public string CZD_CITYCODE
        {
            get { return _CZD_CITYCODE; }
            set
            {
                this.OnPropertyValueChange(_.CZD_CITYCODE, _CZD_CITYCODE, value);
                this._CZD_CITYCODE = value;
            }
        }
        /// <summary>
        /// 常住地区县编码
        /// </summary>
        public string CZD_AREACODE
        {
            get { return _CZD_AREACODE; }
            set
            {
                this.OnPropertyValueChange(_.CZD_AREACODE, _CZD_AREACODE, value);
                this._CZD_AREACODE = value;
            }
        }
        /// <summary>
        /// 常住地址
        /// </summary>
        public string CZD_ADDRESS
        {
            get { return _CZD_ADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.CZD_ADDRESS, _CZD_ADDRESS, value);
                this._CZD_ADDRESS = value;
            }
        }
        /// <summary>
        /// 手势密码
        /// </summary>
        public string GESTURE_PASS
        {
            get { return _GESTURE_PASS; }
            set
            {
                this.OnPropertyValueChange(_.GESTURE_PASS, _GESTURE_PASS, value);
                this._GESTURE_PASS = value;
            }
        }
        /// <summary>
        /// 国家认证级别(3,4,5)
        /// </summary>
        public string NATION_LEVEL
        {
            get { return _NATION_LEVEL; }
            set
            {
                this.OnPropertyValueChange(_.NATION_LEVEL, _NATION_LEVEL, value);
                this._NATION_LEVEL = value;
            }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public decimal? POPULATION_AGE
        {
            get { return _POPULATION_AGE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_AGE, _POPULATION_AGE, value);
                this._POPULATION_AGE = value;
            }
        }
        /// <summary>
        /// 性别(1:男 2:女)
        /// </summary>
        public string POPULATION_SEX
        {
            get { return _POPULATION_SEX; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_SEX, _POPULATION_SEX, value);
                this._POPULATION_SEX = value;
            }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? POPULATION_BIRTHDAY
        {
            get { return _POPULATION_BIRTHDAY; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_BIRTHDAY, _POPULATION_BIRTHDAY, value);
                this._POPULATION_BIRTHDAY = value;
            }
        }
        /// <summary>
        /// 民族代码
        /// </summary>
        public string POPULATION_NATION
        {
            get { return _POPULATION_NATION; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_NATION, _POPULATION_NATION, value);
                this._POPULATION_NATION = value;
            }
        }
        /// <summary>
        /// 籍贯省份代码
        /// </summary>
        public string POPULATION_PROCODE
        {
            get { return _POPULATION_PROCODE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_PROCODE, _POPULATION_PROCODE, value);
                this._POPULATION_PROCODE = value;
            }
        }
        /// <summary>
        /// 籍贯城市代码
        /// </summary>
        public string POPULATION_CITYCODE
        {
            get { return _POPULATION_CITYCODE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_CITYCODE, _POPULATION_CITYCODE, value);
                this._POPULATION_CITYCODE = value;
            }
        }
        /// <summary>
        /// 籍贯县区代码
        /// </summary>
        public string POPULATION_AREACODE
        {
            get { return _POPULATION_AREACODE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_AREACODE, _POPULATION_AREACODE, value);
                this._POPULATION_AREACODE = value;
            }
        }
        /// <summary>
        /// 常住省份代码
        /// </summary>
        public string POPULATION_CPROCODE
        {
            get { return _POPULATION_CPROCODE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_CPROCODE, _POPULATION_CPROCODE, value);
                this._POPULATION_CPROCODE = value;
            }
        }
        /// <summary>
        /// 常住城市代码
        /// </summary>
        public string POPULATION_CCITYCODE
        {
            get { return _POPULATION_CCITYCODE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_CCITYCODE, _POPULATION_CCITYCODE, value);
                this._POPULATION_CCITYCODE = value;
            }
        }
        /// <summary>
        /// 常住县区代码
        /// </summary>
        public string POPULATION_CAREACODE
        {
            get { return _POPULATION_CAREACODE; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_CAREACODE, _POPULATION_CAREACODE, value);
                this._POPULATION_CAREACODE = value;
            }
        }
        /// <summary>
        /// 常住地址
        /// </summary>
        public string POPULATION_CADDRESS
        {
            get { return _POPULATION_CADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_CADDRESS, _POPULATION_CADDRESS, value);
                this._POPULATION_CADDRESS = value;
            }
        }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime? POPULATION_CREATETIME
        {
            get { return _POPULATION_CREATETIME; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_CREATETIME, _POPULATION_CREATETIME, value);
                this._POPULATION_CREATETIME = value;
            }
        }
        /// <summary>
        /// 文化程度
        /// </summary>
        public string POPULATION_EDU
        {
            get { return _POPULATION_EDU; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_EDU, _POPULATION_EDU, value);
                this._POPULATION_EDU = value;
            }
        }
        /// <summary>
        /// 支付宝账号
        /// </summary>
        public string POPULATION_ALIPAY
        {
            get { return _POPULATION_ALIPAY; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_ALIPAY, _POPULATION_ALIPAY, value);
                this._POPULATION_ALIPAY = value;
            }
        }
        /// <summary>
        /// 微信账号
        /// </summary>
        public string POPULATION_WX
        {
            get { return _POPULATION_WX; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_WX, _POPULATION_WX, value);
                this._POPULATION_WX = value;
            }
        }
        /// <summary>
        /// 户籍地址
        /// </summary>
        public string POPULATION_HJDZ
        {
            get { return _POPULATION_HJDZ; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_HJDZ, _POPULATION_HJDZ, value);
                this._POPULATION_HJDZ = value;
            }
        }
        /// <summary>
        /// 居住地址
        /// </summary>
        public string POPULATION_JZDZ
        {
            get { return _POPULATION_JZDZ; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_JZDZ, _POPULATION_JZDZ, value);
                this._POPULATION_JZDZ = value;
            }
        }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string POPULATION_GZDW
        {
            get { return _POPULATION_GZDW; }
            set
            {
                this.OnPropertyValueChange(_.POPULATION_GZDW, _POPULATION_GZDW, value);
                this._POPULATION_GZDW = value;
            }
        }
        /// <summary>
        /// 法定代表人
        /// </summary>
        public string LEGALPERSON_NAME
        {
            get { return _LEGALPERSON_NAME; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_NAME, _LEGALPERSON_NAME, value);
                this._LEGALPERSON_NAME = value;
            }
        }
        /// <summary>
        /// 如果当前登录的是法人子账号，那么该单位有法人主账号，那么该字段是主账号的 ID
        /// </summary>
        public string MAINACC_USERID
        {
            get { return _MAINACC_USERID; }
            set
            {
                this.OnPropertyValueChange(_.MAINACC_USERID, _MAINACC_USERID, value);
                this._MAINACC_USERID = value;
            }
        }
        /// <summary>
        /// 单位所在省份编码
        /// </summary>
        public string LEGALPERSON_PROCODE
        {
            get { return _LEGALPERSON_PROCODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_PROCODE, _LEGALPERSON_PROCODE, value);
                this._LEGALPERSON_PROCODE = value;
            }
        }
        /// <summary>
        /// 单位所在城市编码
        /// </summary>
        public string LEGALPERSON_CITYCODE
        {
            get { return _LEGALPERSON_CITYCODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_CITYCODE, _LEGALPERSON_CITYCODE, value);
                this._LEGALPERSON_CITYCODE = value;
            }
        }
        /// <summary>
        /// 单位所在县区编码
        /// </summary>
        public string LEGALPERSON_AREACODE
        {
            get { return _LEGALPERSON_AREACODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_AREACODE, _LEGALPERSON_AREACODE, value);
                this._LEGALPERSON_AREACODE = value;
            }
        }
        /// <summary>
        /// 单位通信地址
        /// </summary>
        public string LEGALPERSON_ADDRESS
        {
            get { return _LEGALPERSON_ADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ADDRESS, _LEGALPERSON_ADDRESS, value);
                this._LEGALPERSON_ADDRESS = value;
            }
        }
        /// <summary>
        /// 单位注册省份编码
        /// </summary>
        public string LEGALPERSON_ZPROCODE
        {
            get { return _LEGALPERSON_ZPROCODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZPROCODE, _LEGALPERSON_ZPROCODE, value);
                this._LEGALPERSON_ZPROCODE = value;
            }
        }
        /// <summary>
        /// 单位注册城市编码
        /// </summary>
        public string LEGALPERSON_ZCITYCODE
        {
            get { return _LEGALPERSON_ZCITYCODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZCITYCODE, _LEGALPERSON_ZCITYCODE, value);
                this._LEGALPERSON_ZCITYCODE = value;
            }
        }
        /// <summary>
        /// 单位注册县区编码
        /// </summary>
        public string LEGALPERSON_ZAREACODE
        {
            get { return _LEGALPERSON_ZAREACODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZAREACODE, _LEGALPERSON_ZAREACODE, value);
                this._LEGALPERSON_ZAREACODE = value;
            }
        }
        /// <summary>
        /// 单位注册地址
        /// </summary>
        public string LEGALPERSON_ZADDRESS
        {
            get { return _LEGALPERSON_ZADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZADDRESS, _LEGALPERSON_ZADDRESS, value);
                this._LEGALPERSON_ZADDRESS = value;
            }
        }
        /// <summary>
        /// 单位邮箱
        /// </summary>
        public string LEGALPERSON_EMAIL
        {
            get { return _LEGALPERSON_EMAIL; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_EMAIL, _LEGALPERSON_EMAIL, value);
                this._LEGALPERSON_EMAIL = value;
            }
        }
        /// <summary>
        /// 单位联系电话
        /// </summary>
        public string LEGALPERSON_PHONE
        {
            get { return _LEGALPERSON_PHONE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_PHONE, _LEGALPERSON_PHONE, value);
                this._LEGALPERSON_PHONE = value;
            }
        }
        /// <summary>
        /// 单位成立日期
        /// </summary>
        public DateTime? LEGALPERSON_CREAETDATE
        {
            get { return _LEGALPERSON_CREAETDATE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_CREAETDATE, _LEGALPERSON_CREAETDATE, value);
                this._LEGALPERSON_CREAETDATE = value;
            }
        }
        /// <summary>
        /// 法人身份证
        /// </summary>
        public string LEGALPERSON_IDCARD
        {
            get { return _LEGALPERSON_IDCARD; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_IDCARD, _LEGALPERSON_IDCARD, value);
                this._LEGALPERSON_IDCARD = value;
            }
        }
        /// <summary>
        /// 机构类型
        /// </summary>
        public string LEGALPERSON_ORGTYPE
        {
            get { return _LEGALPERSON_ORGTYPE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ORGTYPE, _LEGALPERSON_ORGTYPE, value);
                this._LEGALPERSON_ORGTYPE = value;
            }
        }
        /// <summary>
        /// 经办人邮箱
        /// </summary>
        public string LEGALPERSON_JBREMAIL
        {
            get { return _LEGALPERSON_JBREMAIL; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_JBREMAIL, _LEGALPERSON_JBREMAIL, value);
                this._LEGALPERSON_JBREMAIL = value;
            }
        }
        /// <summary>
        /// 经办人姓名
        /// </summary>
        public string LEGALPERSON_JBRNAME
        {
            get { return _LEGALPERSON_JBRNAME; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_JBRNAME, _LEGALPERSON_JBRNAME, value);
                this._LEGALPERSON_JBRNAME = value;
            }
        }
        /// <summary>
        /// 经办人身份证
        /// </summary>
        public string LEGALPERSON_JBRIDCARD
        {
            get { return _LEGALPERSON_JBRIDCARD; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_JBRIDCARD, _LEGALPERSON_JBRIDCARD, value);
                this._LEGALPERSON_JBRIDCARD = value;
            }
        }
        /// <summary>
        /// 年检日期(质监)
        /// </summary>
        public DateTime? LEGALPERSON_NJRQ
        {
            get { return _LEGALPERSON_NJRQ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_NJRQ, _LEGALPERSON_NJRQ, value);
                this._LEGALPERSON_NJRQ = value;
            }
        }
        /// <summary>
        /// 年检期限
        /// </summary>
        public decimal? LEGALPERSON_NJQX
        {
            get { return _LEGALPERSON_NJQX; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_NJQX, _LEGALPERSON_NJQX, value);
                this._LEGALPERSON_NJQX = value;
            }
        }
        /// <summary>
        /// 经营范围
        /// </summary>
        public string LEGALPERSON_JYFW
        {
            get { return _LEGALPERSON_JYFW; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_JYFW, _LEGALPERSON_JYFW, value);
                this._LEGALPERSON_JYFW = value;
            }
        }
        /// <summary>
        /// 行业名称
        /// </summary>
        public string LEGALPERSON_HYMC
        {
            get { return _LEGALPERSON_HYMC; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_HYMC, _LEGALPERSON_HYMC, value);
                this._LEGALPERSON_HYMC = value;
            }
        }
        /// <summary>
        /// 经济类型
        /// </summary>
        public string LEGALPERSON_JJLX
        {
            get { return _LEGALPERSON_JJLX; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_JJLX, _LEGALPERSON_JJLX, value);
                this._LEGALPERSON_JJLX = value;
            }
        }
        /// <summary>
        /// 职工人数
        /// </summary>
        public decimal? LEGALPERSON_ZGRS
        {
            get { return _LEGALPERSON_ZGRS; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZGRS, _LEGALPERSON_ZGRS, value);
                this._LEGALPERSON_ZGRS = value;
            }
        }
        /// <summary>
        /// 注册资本
        /// </summary>
        public string LEGALPERSON_ZCZB
        {
            get { return _LEGALPERSON_ZCZB; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZCZB, _LEGALPERSON_ZCZB, value);
                this._LEGALPERSON_ZCZB = value;
            }
        }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string LEGALPERSON_ZIPCODE
        {
            get { return _LEGALPERSON_ZIPCODE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZIPCODE, _LEGALPERSON_ZIPCODE, value);
                this._LEGALPERSON_ZIPCODE = value;
            }
        }
        /// <summary>
        /// 批准机构名称
        /// </summary>
        public string LEGALPERSON_PZJG
        {
            get { return _LEGALPERSON_PZJG; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_PZJG, _LEGALPERSON_PZJG, value);
                this._LEGALPERSON_PZJG = value;
            }
        }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string LEGALPERSON_ZZJGDM
        {
            get { return _LEGALPERSON_ZZJGDM; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ZZJGDM, _LEGALPERSON_ZZJGDM, value);
                this._LEGALPERSON_ZZJGDM = value;
            }
        }
        /// <summary>
        /// 企业性质
        /// </summary>
        public string LEGALPERSON_QYXZ
        {
            get { return _LEGALPERSON_QYXZ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_QYXZ, _LEGALPERSON_QYXZ, value);
                this._LEGALPERSON_QYXZ = value;
            }
        }
        /// <summary>
        /// 工商注册号
        /// </summary>
        public string LEGALPERSON_GSZCH
        {
            get { return _LEGALPERSON_GSZCH; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_GSZCH, _LEGALPERSON_GSZCH, value);
                this._LEGALPERSON_GSZCH = value;
            }
        }
        /// <summary>
        /// 颁证日期
        /// </summary>
        public DateTime? LEGALPERSON_BZRQ
        {
            get { return _LEGALPERSON_BZRQ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_BZRQ, _LEGALPERSON_BZRQ, value);
                this._LEGALPERSON_BZRQ = value;
            }
        }
        /// <summary>
        /// 颁证单位
        /// </summary>
        public string LEGALPERSON_BZDW
        {
            get { return _LEGALPERSON_BZDW; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_BZDW, _LEGALPERSON_BZDW, value);
                this._LEGALPERSON_BZDW = value;
            }
        }
        /// <summary>
        /// 有效期起始
        /// </summary>
        public DateTime? LEGALPERSON_YXQQS
        {
            get { return _LEGALPERSON_YXQQS; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_YXQQS, _LEGALPERSON_YXQQS, value);
                this._LEGALPERSON_YXQQS = value;
            }
        }
        /// <summary>
        /// 有效期截止
        /// </summary>
        public DateTime? LEGALPERSON_YXQJZ
        {
            get { return _LEGALPERSON_YXQJZ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_YXQJZ, _LEGALPERSON_YXQJZ, value);
                this._LEGALPERSON_YXQJZ = value;
            }
        }
        /// <summary>
        /// 年检情况(质监)
        /// </summary>
        public string LEGALPERSON_NJQK
        {
            get { return _LEGALPERSON_NJQK; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_NJQK, _LEGALPERSON_NJQK, value);
                this._LEGALPERSON_NJQK = value;
            }
        }
        /// <summary>
        /// 变更事项(质监)
        /// </summary>
        public string LEGALPERSON_BGSX
        {
            get { return _LEGALPERSON_BGSX; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_BGSX, _LEGALPERSON_BGSX, value);
                this._LEGALPERSON_BGSX = value;
            }
        }
        /// <summary>
        /// 首次办证日期
        /// </summary>
        public DateTime? LEGALPERSON_SCBZ
        {
            get { return _LEGALPERSON_SCBZ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_SCBZ, _LEGALPERSON_SCBZ, value);
                this._LEGALPERSON_SCBZ = value;
            }
        }
        /// <summary>
        /// 废置日期
        /// </summary>
        public DateTime? LEGALPERSON_FZRQ
        {
            get { return _LEGALPERSON_FZRQ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_FZRQ, _LEGALPERSON_FZRQ, value);
                this._LEGALPERSON_FZRQ = value;
            }
        }
        /// <summary>
        /// 成立日期
        /// </summary>
        public DateTime? LEGALPERSON_CLRQ
        {
            get { return _LEGALPERSON_CLRQ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_CLRQ, _LEGALPERSON_CLRQ, value);
                this._LEGALPERSON_CLRQ = value;
            }
        }
        /// <summary>
        /// 投资者注册地
        /// </summary>
        public string LEGALPERSON_TZZZCD
        {
            get { return _LEGALPERSON_TZZZCD; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_TZZZCD, _LEGALPERSON_TZZZCD, value);
                this._LEGALPERSON_TZZZCD = value;
            }
        }
        /// <summary>
        /// 行政区划
        /// </summary>
        public string LEGALPERSON_XZQH
        {
            get { return _LEGALPERSON_XZQH; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_XZQH, _LEGALPERSON_XZQH, value);
                this._LEGALPERSON_XZQH = value;
            }
        }
        /// <summary>
        /// 地税纳税人识别号
        /// </summary>
        public string LEGALPERSON_DSNSRSBH
        {
            get { return _LEGALPERSON_DSNSRSBH; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_DSNSRSBH, _LEGALPERSON_DSNSRSBH, value);
                this._LEGALPERSON_DSNSRSBH = value;
            }
        }
        /// <summary>
        /// 地税税务登记日期
        /// </summary>
        public DateTime? LEGALPERSON_DSDJ
        {
            get { return _LEGALPERSON_DSDJ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_DSDJ, _LEGALPERSON_DSDJ, value);
                this._LEGALPERSON_DSDJ = value;
            }
        }
        /// <summary>
        /// 地税税务登记机关
        /// </summary>
        public string LEGALPERSON_DSDJJG
        {
            get { return _LEGALPERSON_DSDJJG; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_DSDJJG, _LEGALPERSON_DSDJJG, value);
                this._LEGALPERSON_DSDJJG = value;
            }
        }
        /// <summary>
        /// 地税注销原因
        /// </summary>
        public string LEGALPERSON_DSZXYY
        {
            get { return _LEGALPERSON_DSZXYY; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_DSZXYY, _LEGALPERSON_DSZXYY, value);
                this._LEGALPERSON_DSZXYY = value;
            }
        }
        /// <summary>
        /// 地税注销日期
        /// </summary>
        public DateTime? LEGALPERSON_DSZXRQ
        {
            get { return _LEGALPERSON_DSZXRQ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_DSZXRQ, _LEGALPERSON_DSZXRQ, value);
                this._LEGALPERSON_DSZXRQ = value;
            }
        }
        /// <summary>
        /// 国税纳税人识别号
        /// </summary>
        public string LEGALPERSON_GSSBH
        {
            get { return _LEGALPERSON_GSSBH; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_GSSBH, _LEGALPERSON_GSSBH, value);
                this._LEGALPERSON_GSSBH = value;
            }
        }
        /// <summary>
        /// 国税税务登记日期
        /// </summary>
        public DateTime? LEGALPERSON_GSSWDJ
        {
            get { return _LEGALPERSON_GSSWDJ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_GSSWDJ, _LEGALPERSON_GSSWDJ, value);
                this._LEGALPERSON_GSSWDJ = value;
            }
        }
        /// <summary>
        /// 国税税务登记机关
        /// </summary>
        public string LEGALPERSON_GSSWJG
        {
            get { return _LEGALPERSON_GSSWJG; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_GSSWJG, _LEGALPERSON_GSSWJG, value);
                this._LEGALPERSON_GSSWJG = value;
            }
        }
        /// <summary>
        /// 国税注销原因
        /// </summary>
        public string LEGALPERSON_GSZXYY
        {
            get { return _LEGALPERSON_GSZXYY; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_GSZXYY, _LEGALPERSON_GSZXYY, value);
                this._LEGALPERSON_GSZXYY = value;
            }
        }
        /// <summary>
        /// 国税注销日期
        /// </summary>
        public DateTime? LEGALPERSON_GSZXRQ
        {
            get { return _LEGALPERSON_GSZXRQ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_GSZXRQ, _LEGALPERSON_GSZXRQ, value);
                this._LEGALPERSON_GSZXRQ = value;
            }
        }
        /// <summary>
        /// 法人手机号
        /// </summary>
        public string LEGALPERSON_FRSJH
        {
            get { return _LEGALPERSON_FRSJH; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_FRSJH, _LEGALPERSON_FRSJH, value);
                this._LEGALPERSON_FRSJH = value;
            }
        }
        /// <summary>
        /// 法人民族代码
        /// </summary>
        public string LEGALPERSON_NATION
        {
            get { return _LEGALPERSON_NATION; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_NATION, _LEGALPERSON_NATION, value);
                this._LEGALPERSON_NATION = value;
            }
        }
        /// <summary>
        /// 法人常住地址
        /// </summary>
        public string LEGALPERSON_CZDZ
        {
            get { return _LEGALPERSON_CZDZ; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_CZDZ, _LEGALPERSON_CZDZ, value);
                this._LEGALPERSON_CZDZ = value;
            }
        }
        /// <summary>
        /// 经办人手机号
        /// </summary>
        public string LEGALPERSON_JBRSJH
        {
            get { return _LEGALPERSON_JBRSJH; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_JBRSJH, _LEGALPERSON_JBRSJH, value);
                this._LEGALPERSON_JBRSJH = value;
            }
        }
        /// <summary>
        /// 法人性别(1:男 2:女)
        /// </summary>
        public string LEGALPERSON_FRXB
        {
            get { return _LEGALPERSON_FRXB; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_FRXB, _LEGALPERSON_FRXB, value);
                this._LEGALPERSON_FRXB = value;
            }
        }
        /// <summary>
        /// 法人类型
        /// </summary>
        public string LEGALPERSON_TYPE
        {
            get { return _LEGALPERSON_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_TYPE, _LEGALPERSON_TYPE, value);
                this._LEGALPERSON_TYPE = value;
            }
        }
        /// <summary>
        /// 法人账号类型
        /// </summary>
        public string LEGALPERSON_ACCTYPE
        {
            get { return _LEGALPERSON_ACCTYPE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALPERSON_ACCTYPE, _LEGALPERSON_ACCTYPE, value);
                this._LEGALPERSON_ACCTYPE = value;
            }
        }
        /// <summary>
        /// 企业机构注册地址
        /// </summary>
        public string ENTERPRISEADDRESS
        {
            get { return _ENTERPRISEADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEADDRESS, _ENTERPRISEADDRESS, value);
                this._ENTERPRISEADDRESS = value;
            }
        }
        /// <summary>
        /// 企业机构注册金额单位万元
        /// </summary>
        public decimal? ENTERPRISECAPITAL
        {
            get { return _ENTERPRISECAPITAL; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISECAPITAL, _ENTERPRISECAPITAL, value);
                this._ENTERPRISECAPITAL = value;
            }
        }
        /// <summary>
        /// 企业机构经营范围
        /// </summary>
        public string ENTERPRISERANGE
        {
            get { return _ENTERPRISERANGE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISERANGE, _ENTERPRISERANGE, value);
                this._ENTERPRISERANGE = value;
            }
        }
        /// <summary>
        /// 企业机构注册日期
        /// </summary>
        public DateTime? ENTERPRISEREGISTERDATE
        {
            get { return _ENTERPRISEREGISTERDATE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEREGISTERDATE, _ENTERPRISEREGISTERDATE, value);
                this._ENTERPRISEREGISTERDATE = value;
            }
        }
        /// <summary>
        /// 营业限期起始
        /// </summary>
        public DateTime? ENTERPRISEBEGINDATE
        {
            get { return _ENTERPRISEBEGINDATE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEBEGINDATE, _ENTERPRISEBEGINDATE, value);
                this._ENTERPRISEBEGINDATE = value;
            }
        }
        /// <summary>
        /// 营业限期截止
        /// </summary>
        public DateTime? ENTERPRISEENDDATE
        {
            get { return _ENTERPRISEENDDATE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEENDDATE, _ENTERPRISEENDDATE, value);
                this._ENTERPRISEENDDATE = value;
            }
        }
        /// <summary>
        /// 核准日期
        /// </summary>
        public DateTime? ENTERPRISEAPPROVALDATE
        {
            get { return _ENTERPRISEAPPROVALDATE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEAPPROVALDATE, _ENTERPRISEAPPROVALDATE, value);
                this._ENTERPRISEAPPROVALDATE = value;
            }
        }
        /// <summary>
        /// 核准机构
        /// </summary>
        public string ENTERPRISEAPPROVERAGENCY
        {
            get { return _ENTERPRISEAPPROVERAGENCY; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEAPPROVERAGENCY, _ENTERPRISEAPPROVERAGENCY, value);
                this._ENTERPRISEAPPROVERAGENCY = value;
            }
        }
        /// <summary>
        /// 社会组织活动范围
        /// </summary>
        public string ACTAREA
        {
            get { return _ACTAREA; }
            set
            {
                this.OnPropertyValueChange(_.ACTAREA, _ACTAREA, value);
                this._ACTAREA = value;
            }
        }
        /// <summary>
        /// 业务范围
        /// </summary>
        public string ASSOCIATIONCONTENT
        {
            get { return _ASSOCIATIONCONTENT; }
            set
            {
                this.OnPropertyValueChange(_.ASSOCIATIONCONTENT, _ASSOCIATIONCONTENT, value);
                this._ASSOCIATIONCONTENT = value;
            }
        }
        /// <summary>
        /// 住所
        /// </summary>
        public string REGADDRESS
        {
            get { return _REGADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.REGADDRESS, _REGADDRESS, value);
                this._REGADDRESS = value;
            }
        }
        /// <summary>
        /// 所属行(事)业
        /// </summary>
        public string INDUSTRY
        {
            get { return _INDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRY, _INDUSTRY, value);
                this._INDUSTRY = value;
            }
        }
        /// <summary>
        /// 登记日期
        /// </summary>
        public DateTime? REGDATE
        {
            get { return _REGDATE; }
            set
            {
                this.OnPropertyValueChange(_.REGDATE, _REGDATE, value);
                this._REGDATE = value;
            }
        }
        /// <summary>
        /// 注册资金(单位万元)
        /// </summary>
        public decimal? REGMONEY
        {
            get { return _REGMONEY; }
            set
            {
                this.OnPropertyValueChange(_.REGMONEY, _REGMONEY, value);
                this._REGMONEY = value;
            }
        }
        /// <summary>
        /// 业务主管单位
        /// </summary>
        public string COMPETENTORG
        {
            get { return _COMPETENTORG; }
            set
            {
                this.OnPropertyValueChange(_.COMPETENTORG, _COMPETENTORG, value);
                this._COMPETENTORG = value;
            }
        }
        /// <summary>
        /// _0：非慈善组织；1：是慈善组织
        /// </summary>
        public string CHARITYORG
        {
            get { return _CHARITYORG; }
            set
            {
                this.OnPropertyValueChange(_.CHARITYORG, _CHARITYORG, value);
                this._CHARITYORG = value;
            }
        }
        /// <summary>
        /// _1：民营非企业；2：社会团体；3：基金会
        /// </summary>
        public string SOCIALORGTYPE
        {
            get { return _SOCIALORGTYPE; }
            set
            {
                this.OnPropertyValueChange(_.SOCIALORGTYPE, _SOCIALORGTYPE, value);
                this._SOCIALORGTYPE = value;
            }
        }
        /// <summary>
        /// 基金会类型(1 公募基金会；2：非公募基 金会)
        /// </summary>
        public string FUNDKIND
        {
            get { return _FUNDKIND; }
            set
            {
                this.OnPropertyValueChange(_.FUNDKIND, _FUNDKIND, value);
                this._FUNDKIND = value;
            }
        }
        /// <summary>
        /// 宗旨和业务范围
        /// </summary>
        public string REGRANGE
        {
            get { return _REGRANGE; }
            set
            {
                this.OnPropertyValueChange(_.REGRANGE, _REGRANGE, value);
                this._REGRANGE = value;
            }
        }
        /// <summary>
        /// 举办单位
        /// </summary>
        public string REGORGANIZER
        {
            get { return _REGORGANIZER; }
            set
            {
                this.OnPropertyValueChange(_.REGORGANIZER, _REGORGANIZER, value);
                this._REGORGANIZER = value;
            }
        }
        /// <summary>
        /// 登记管理机关
        /// </summary>
        public string REGAUTHORITY
        {
            get { return _REGAUTHORITY; }
            set
            {
                this.OnPropertyValueChange(_.REGAUTHORITY, _REGAUTHORITY, value);
                this._REGAUTHORITY = value;
            }
        }
        /// <summary>
        /// 经费来源
        /// </summary>
        public string FUNDSOURCE
        {
            get { return _FUNDSOURCE; }
            set
            {
                this.OnPropertyValueChange(_.FUNDSOURCE, _FUNDSOURCE, value);
                this._FUNDSOURCE = value;
            }
        }
        /// <summary>
        /// 法人证件有效起始日期
        /// </summary>
        public DateTime? CERT_YXQS
        {
            get { return _CERT_YXQS; }
            set
            {
                this.OnPropertyValueChange(_.CERT_YXQS, _CERT_YXQS, value);
                this._CERT_YXQS = value;
            }
        }
        /// <summary>
        /// 法人证件有效到期日期
        /// </summary>
        public DateTime? CERT_YXJZ
        {
            get { return _CERT_YXJZ; }
            set
            {
                this.OnPropertyValueChange(_.CERT_YXJZ, _CERT_YXJZ, value);
                this._CERT_YXJZ = value;
            }
        }
        /// <summary>
        /// 经办人证件类型
        /// </summary>
        public string AGENTCERTTYPE
        {
            get { return _AGENTCERTTYPE; }
            set
            {
                this.OnPropertyValueChange(_.AGENTCERTTYPE, _AGENTCERTTYPE, value);
                this._AGENTCERTTYPE = value;
            }
        }
        /// <summary>
        /// 代码证件图片
        /// </summary>
        public string DMZJ_PATH
        {
            get { return _DMZJ_PATH; }
            set
            {
                this.OnPropertyValueChange(_.DMZJ_PATH, _DMZJ_PATH, value);
                this._DMZJ_PATH = value;
            }
        }
        /// <summary>
        /// 有无统一社会信用代码(1:有 -1:无)
        /// </summary>
        public string YWTYDM
        {
            get { return _YWTYDM; }
            set
            {
                this.OnPropertyValueChange(_.YWTYDM, _YWTYDM, value);
                this._YWTYDM = value;
            }
        }
        /// <summary>
        /// 无社会代码类型(1:机构筹措中,2 个体户)
        /// </summary>
        public string WDMLX
        {
            get { return _WDMLX; }
            set
            {
                this.OnPropertyValueChange(_.WDMLX, _WDMLX, value);
                this._WDMLX = value;
            }
        }
        /// <summary>
        /// 营业执照图片路径
        /// </summary>
        public string YYZZ_PATH
        {
            get { return _YYZZ_PATH; }
            set
            {
                this.OnPropertyValueChange(_.YYZZ_PATH, _YYZZ_PATH, value);
                this._YYZZ_PATH = value;
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
        /// 修改时间
        /// </summary>
        public DateTime? MODIFY_TIME
        {
            get { return _MODIFY_TIME; }
            set
            {
                this.OnPropertyValueChange(_.MODIFY_TIME, _MODIFY_TIME, value);
                this._MODIFY_TIME = value;
            }
        }
        /// <summary>
        /// 状态1有效0无效
        /// </summary>
        public decimal? STATUS
        {
            get { return _STATUS; }
            set
            {
                this.OnPropertyValueChange(_.STATUS, _STATUS, value);
                this._STATUS = value;
            }
        }
        /// <summary>
        /// 监督平台绑定的用户id
        /// </summary>
        public decimal? JDUSERID
        {
            get { return _JDUSERID; }
            set
            {
                this.OnPropertyValueChange(_.JDUSERID, _JDUSERID, value);
                this._JDUSERID = value;
            }
        }
        /// <summary>
        /// 服务平台绑定的用户id
        /// </summary>
        public decimal? FWUSERID
        {
            get { return _FWUSERID; }
            set
            {
                this.OnPropertyValueChange(_.FWUSERID, _FWUSERID, value);
                this._FWUSERID = value;
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
                _.USER_ID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.USER_ID,
                _.USER_NAME,
                _.USER_IDCARD,
                _.USER_TYPE,
                _.CARD_TYPE,
                _.USER_MOBILE,
                _.USER_ACCOUNT,
                _.USER_AUTHLEVEL,
                _.USER_CITYCODE,
                _.USER_CONFIGPASS,
                _.USER_JUNTIME,
                _.USER_HITIME,
                _.LEGAL_KEYID,
                _.CERTS_EFFECTDATE,
                _.CERTS_VALIDDATE,
                _.CZD_CITYCODE,
                _.CZD_AREACODE,
                _.CZD_ADDRESS,
                _.GESTURE_PASS,
                _.NATION_LEVEL,
                _.POPULATION_AGE,
                _.POPULATION_SEX,
                _.POPULATION_BIRTHDAY,
                _.POPULATION_NATION,
                _.POPULATION_PROCODE,
                _.POPULATION_CITYCODE,
                _.POPULATION_AREACODE,
                _.POPULATION_CPROCODE,
                _.POPULATION_CCITYCODE,
                _.POPULATION_CAREACODE,
                _.POPULATION_CADDRESS,
                _.POPULATION_CREATETIME,
                _.POPULATION_EDU,
                _.POPULATION_ALIPAY,
                _.POPULATION_WX,
                _.POPULATION_HJDZ,
                _.POPULATION_JZDZ,
                _.POPULATION_GZDW,
                _.LEGALPERSON_NAME,
                _.MAINACC_USERID,
                _.LEGALPERSON_PROCODE,
                _.LEGALPERSON_CITYCODE,
                _.LEGALPERSON_AREACODE,
                _.LEGALPERSON_ADDRESS,
                _.LEGALPERSON_ZPROCODE,
                _.LEGALPERSON_ZCITYCODE,
                _.LEGALPERSON_ZAREACODE,
                _.LEGALPERSON_ZADDRESS,
                _.LEGALPERSON_EMAIL,
                _.LEGALPERSON_PHONE,
                _.LEGALPERSON_CREAETDATE,
                _.LEGALPERSON_IDCARD,
                _.LEGALPERSON_ORGTYPE,
                _.LEGALPERSON_JBREMAIL,
                _.LEGALPERSON_JBRNAME,
                _.LEGALPERSON_JBRIDCARD,
                _.LEGALPERSON_NJRQ,
                _.LEGALPERSON_NJQX,
                _.LEGALPERSON_JYFW,
                _.LEGALPERSON_HYMC,
                _.LEGALPERSON_JJLX,
                _.LEGALPERSON_ZGRS,
                _.LEGALPERSON_ZCZB,
                _.LEGALPERSON_ZIPCODE,
                _.LEGALPERSON_PZJG,
                _.LEGALPERSON_ZZJGDM,
                _.LEGALPERSON_QYXZ,
                _.LEGALPERSON_GSZCH,
                _.LEGALPERSON_BZRQ,
                _.LEGALPERSON_BZDW,
                _.LEGALPERSON_YXQQS,
                _.LEGALPERSON_YXQJZ,
                _.LEGALPERSON_NJQK,
                _.LEGALPERSON_BGSX,
                _.LEGALPERSON_SCBZ,
                _.LEGALPERSON_FZRQ,
                _.LEGALPERSON_CLRQ,
                _.LEGALPERSON_TZZZCD,
                _.LEGALPERSON_XZQH,
                _.LEGALPERSON_DSNSRSBH,
                _.LEGALPERSON_DSDJ,
                _.LEGALPERSON_DSDJJG,
                _.LEGALPERSON_DSZXYY,
                _.LEGALPERSON_DSZXRQ,
                _.LEGALPERSON_GSSBH,
                _.LEGALPERSON_GSSWDJ,
                _.LEGALPERSON_GSSWJG,
                _.LEGALPERSON_GSZXYY,
                _.LEGALPERSON_GSZXRQ,
                _.LEGALPERSON_FRSJH,
                _.LEGALPERSON_NATION,
                _.LEGALPERSON_CZDZ,
                _.LEGALPERSON_JBRSJH,
                _.LEGALPERSON_FRXB,
                _.LEGALPERSON_TYPE,
                _.LEGALPERSON_ACCTYPE,
                _.ENTERPRISEADDRESS,
                _.ENTERPRISECAPITAL,
                _.ENTERPRISERANGE,
                _.ENTERPRISEREGISTERDATE,
                _.ENTERPRISEBEGINDATE,
                _.ENTERPRISEENDDATE,
                _.ENTERPRISEAPPROVALDATE,
                _.ENTERPRISEAPPROVERAGENCY,
                _.ACTAREA,
                _.ASSOCIATIONCONTENT,
                _.REGADDRESS,
                _.INDUSTRY,
                _.REGDATE,
                _.REGMONEY,
                _.COMPETENTORG,
                _.CHARITYORG,
                _.SOCIALORGTYPE,
                _.FUNDKIND,
                _.REGRANGE,
                _.REGORGANIZER,
                _.REGAUTHORITY,
                _.FUNDSOURCE,
                _.CERT_YXQS,
                _.CERT_YXJZ,
                _.AGENTCERTTYPE,
                _.DMZJ_PATH,
                _.YWTYDM,
                _.WDMLX,
                _.YYZZ_PATH,
                _.CREATE_TIME,
                _.MODIFY_TIME,
                _.STATUS,
                _.JDUSERID,
                _.FWUSERID,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._USER_ID,
                this._USER_NAME,
                this._USER_IDCARD,
                this._USER_TYPE,
                this._CARD_TYPE,
                this._USER_MOBILE,
                this._USER_ACCOUNT,
                this._USER_AUTHLEVEL,
                this._USER_CITYCODE,
                this._USER_CONFIGPASS,
                this._USER_JUNTIME,
                this._USER_HITIME,
                this._LEGAL_KEYID,
                this._CERTS_EFFECTDATE,
                this._CERTS_VALIDDATE,
                this._CZD_CITYCODE,
                this._CZD_AREACODE,
                this._CZD_ADDRESS,
                this._GESTURE_PASS,
                this._NATION_LEVEL,
                this._POPULATION_AGE,
                this._POPULATION_SEX,
                this._POPULATION_BIRTHDAY,
                this._POPULATION_NATION,
                this._POPULATION_PROCODE,
                this._POPULATION_CITYCODE,
                this._POPULATION_AREACODE,
                this._POPULATION_CPROCODE,
                this._POPULATION_CCITYCODE,
                this._POPULATION_CAREACODE,
                this._POPULATION_CADDRESS,
                this._POPULATION_CREATETIME,
                this._POPULATION_EDU,
                this._POPULATION_ALIPAY,
                this._POPULATION_WX,
                this._POPULATION_HJDZ,
                this._POPULATION_JZDZ,
                this._POPULATION_GZDW,
                this._LEGALPERSON_NAME,
                this._MAINACC_USERID,
                this._LEGALPERSON_PROCODE,
                this._LEGALPERSON_CITYCODE,
                this._LEGALPERSON_AREACODE,
                this._LEGALPERSON_ADDRESS,
                this._LEGALPERSON_ZPROCODE,
                this._LEGALPERSON_ZCITYCODE,
                this._LEGALPERSON_ZAREACODE,
                this._LEGALPERSON_ZADDRESS,
                this._LEGALPERSON_EMAIL,
                this._LEGALPERSON_PHONE,
                this._LEGALPERSON_CREAETDATE,
                this._LEGALPERSON_IDCARD,
                this._LEGALPERSON_ORGTYPE,
                this._LEGALPERSON_JBREMAIL,
                this._LEGALPERSON_JBRNAME,
                this._LEGALPERSON_JBRIDCARD,
                this._LEGALPERSON_NJRQ,
                this._LEGALPERSON_NJQX,
                this._LEGALPERSON_JYFW,
                this._LEGALPERSON_HYMC,
                this._LEGALPERSON_JJLX,
                this._LEGALPERSON_ZGRS,
                this._LEGALPERSON_ZCZB,
                this._LEGALPERSON_ZIPCODE,
                this._LEGALPERSON_PZJG,
                this._LEGALPERSON_ZZJGDM,
                this._LEGALPERSON_QYXZ,
                this._LEGALPERSON_GSZCH,
                this._LEGALPERSON_BZRQ,
                this._LEGALPERSON_BZDW,
                this._LEGALPERSON_YXQQS,
                this._LEGALPERSON_YXQJZ,
                this._LEGALPERSON_NJQK,
                this._LEGALPERSON_BGSX,
                this._LEGALPERSON_SCBZ,
                this._LEGALPERSON_FZRQ,
                this._LEGALPERSON_CLRQ,
                this._LEGALPERSON_TZZZCD,
                this._LEGALPERSON_XZQH,
                this._LEGALPERSON_DSNSRSBH,
                this._LEGALPERSON_DSDJ,
                this._LEGALPERSON_DSDJJG,
                this._LEGALPERSON_DSZXYY,
                this._LEGALPERSON_DSZXRQ,
                this._LEGALPERSON_GSSBH,
                this._LEGALPERSON_GSSWDJ,
                this._LEGALPERSON_GSSWJG,
                this._LEGALPERSON_GSZXYY,
                this._LEGALPERSON_GSZXRQ,
                this._LEGALPERSON_FRSJH,
                this._LEGALPERSON_NATION,
                this._LEGALPERSON_CZDZ,
                this._LEGALPERSON_JBRSJH,
                this._LEGALPERSON_FRXB,
                this._LEGALPERSON_TYPE,
                this._LEGALPERSON_ACCTYPE,
                this._ENTERPRISEADDRESS,
                this._ENTERPRISECAPITAL,
                this._ENTERPRISERANGE,
                this._ENTERPRISEREGISTERDATE,
                this._ENTERPRISEBEGINDATE,
                this._ENTERPRISEENDDATE,
                this._ENTERPRISEAPPROVALDATE,
                this._ENTERPRISEAPPROVERAGENCY,
                this._ACTAREA,
                this._ASSOCIATIONCONTENT,
                this._REGADDRESS,
                this._INDUSTRY,
                this._REGDATE,
                this._REGMONEY,
                this._COMPETENTORG,
                this._CHARITYORG,
                this._SOCIALORGTYPE,
                this._FUNDKIND,
                this._REGRANGE,
                this._REGORGANIZER,
                this._REGAUTHORITY,
                this._FUNDSOURCE,
                this._CERT_YXQS,
                this._CERT_YXJZ,
                this._AGENTCERTTYPE,
                this._DMZJ_PATH,
                this._YWTYDM,
                this._WDMLX,
                this._YYZZ_PATH,
                this._CREATE_TIME,
                this._MODIFY_TIME,
                this._STATUS,
                this._JDUSERID,
                this._FWUSERID,
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
            public readonly static Field All = new Field("*", "MZTUSER");
            /// <summary>
            /// 用户id
            /// </summary>
            public readonly static Field USER_ID = new Field("USER_ID", "MZTUSER", "用户id");
            /// <summary>
            /// 用户姓名或单位名称
            /// </summary>
            public readonly static Field USER_NAME = new Field("USER_NAME", "MZTUSER", "用户姓名或单位名称");
            /// <summary>
            /// 证件号码或者统一社会信用代码
            /// </summary>
            public readonly static Field USER_IDCARD = new Field("USER_IDCARD", "MZTUSER", "证件号码或者统一社会信用代码");
            /// <summary>
            /// 用户类型(1:个人用户 2:法人用户)
            /// </summary>
            public readonly static Field USER_TYPE = new Field("USER_TYPE", "MZTUSER", "用户类型(1:个人用户 2:法人用户)");
            /// <summary>
            /// 注册用户的证件类型，可选值如下 居民身份证:111,普通护照:414, 台湾居民来往大陆通行证:511, 港澳居民来往内地 通行证: 516, 其他:999
            /// </summary>
            public readonly static Field CARD_TYPE = new Field("CARD_TYPE", "MZTUSER", "注册用户的证件类型，可选值如下 居民身份证:111,普通护照:414, 台湾居民来往大陆通行证:511, 港澳居民来往内地 通行证: 516, 其他:999");
            /// <summary>
            /// 手机号
            /// </summary>
            public readonly static Field USER_MOBILE = new Field("USER_MOBILE", "MZTUSER", "手机号");
            /// <summary>
            /// 用户名
            /// </summary>
            public readonly static Field USER_ACCOUNT = new Field("USER_ACCOUNT", "MZTUSER", "用户名");
            /// <summary>
            /// 认证级别(0:未认证 1:初级 2:高级3:eid 高 级认证状态)
            /// </summary>
            public readonly static Field USER_AUTHLEVEL = new Field("USER_AUTHLEVEL", "MZTUSER", "认证级别(0:未认证 1:初级 2:高级3:eid 高 级认证状态)");
            /// <summary>
            /// 用户所在地市编码
            /// </summary>
            public readonly static Field USER_CITYCODE = new Field("USER_CITYCODE", "MZTUSER", "用户所在地市编码");
            /// <summary>
            /// 是否设置了密保问题(1:是 -1:否)
            /// </summary>
            public readonly static Field USER_CONFIGPASS = new Field("USER_CONFIGPASS", "MZTUSER", "是否设置了密保问题(1:是 -1:否)");
            /// <summary>
            /// 初级认证的时间
            /// </summary>
            public readonly static Field USER_JUNTIME = new Field("USER_JUNTIME", "MZTUSER", "初级认证的时间");
            /// <summary>
            /// 高级认证的时间
            /// </summary>
            public readonly static Field USER_HITIME = new Field("USER_HITIME", "MZTUSER", "高级认证的时间");
            /// <summary>
            /// Ukey 唯一标识号，这个有值的情况下，代 表法人进行了 CA 认证。
            /// </summary>
            public readonly static Field LEGAL_KEYID = new Field("LEGAL_KEYID", "MZTUSER", "Ukey 唯一标识号，这个有值的情况下，代 表法人进行了 CA 认证。");
            /// <summary>
            /// 身份证有效期开始
            /// </summary>
            public readonly static Field CERTS_EFFECTDATE = new Field("CERTS_EFFECTDATE", "MZTUSER", "身份证有效期开始");
            /// <summary>
            /// 身份证有效期结束
            /// </summary>
            public readonly static Field CERTS_VALIDDATE = new Field("CERTS_VALIDDATE", "MZTUSER", "身份证有效期结束");
            /// <summary>
            /// 常住地地市编码
            /// </summary>
            public readonly static Field CZD_CITYCODE = new Field("CZD_CITYCODE", "MZTUSER", "常住地地市编码");
            /// <summary>
            /// 常住地区县编码
            /// </summary>
            public readonly static Field CZD_AREACODE = new Field("CZD_AREACODE", "MZTUSER", "常住地区县编码");
            /// <summary>
            /// 常住地址
            /// </summary>
            public readonly static Field CZD_ADDRESS = new Field("CZD_ADDRESS", "MZTUSER", "常住地址");
            /// <summary>
            /// 手势密码
            /// </summary>
            public readonly static Field GESTURE_PASS = new Field("GESTURE_PASS", "MZTUSER", "手势密码");
            /// <summary>
            /// 国家认证级别(3,4,5)
            /// </summary>
            public readonly static Field NATION_LEVEL = new Field("NATION_LEVEL", "MZTUSER", "国家认证级别(3,4,5)");
            /// <summary>
            /// 年龄
            /// </summary>
            public readonly static Field POPULATION_AGE = new Field("POPULATION_AGE", "MZTUSER", "年龄");
            /// <summary>
            /// 性别(1:男 2:女)
            /// </summary>
            public readonly static Field POPULATION_SEX = new Field("POPULATION_SEX", "MZTUSER", "性别(1:男 2:女)");
            /// <summary>
            /// 出生日期
            /// </summary>
            public readonly static Field POPULATION_BIRTHDAY = new Field("POPULATION_BIRTHDAY", "MZTUSER", "出生日期");
            /// <summary>
            /// 民族代码
            /// </summary>
            public readonly static Field POPULATION_NATION = new Field("POPULATION_NATION", "MZTUSER", "民族代码");
            /// <summary>
            /// 籍贯省份代码
            /// </summary>
            public readonly static Field POPULATION_PROCODE = new Field("POPULATION_PROCODE", "MZTUSER", "籍贯省份代码");
            /// <summary>
            /// 籍贯城市代码
            /// </summary>
            public readonly static Field POPULATION_CITYCODE = new Field("POPULATION_CITYCODE", "MZTUSER", "籍贯城市代码");
            /// <summary>
            /// 籍贯县区代码
            /// </summary>
            public readonly static Field POPULATION_AREACODE = new Field("POPULATION_AREACODE", "MZTUSER", "籍贯县区代码");
            /// <summary>
            /// 常住省份代码
            /// </summary>
            public readonly static Field POPULATION_CPROCODE = new Field("POPULATION_CPROCODE", "MZTUSER", "常住省份代码");
            /// <summary>
            /// 常住城市代码
            /// </summary>
            public readonly static Field POPULATION_CCITYCODE = new Field("POPULATION_CCITYCODE", "MZTUSER", "常住城市代码");
            /// <summary>
            /// 常住县区代码
            /// </summary>
            public readonly static Field POPULATION_CAREACODE = new Field("POPULATION_CAREACODE", "MZTUSER", "常住县区代码");
            /// <summary>
            /// 常住地址
            /// </summary>
            public readonly static Field POPULATION_CADDRESS = new Field("POPULATION_CADDRESS", "MZTUSER", "常住地址");
            /// <summary>
            /// 入库时间
            /// </summary>
            public readonly static Field POPULATION_CREATETIME = new Field("POPULATION_CREATETIME", "MZTUSER", "入库时间");
            /// <summary>
            /// 文化程度
            /// </summary>
            public readonly static Field POPULATION_EDU = new Field("POPULATION_EDU", "MZTUSER", "文化程度");
            /// <summary>
            /// 支付宝账号
            /// </summary>
            public readonly static Field POPULATION_ALIPAY = new Field("POPULATION_ALIPAY", "MZTUSER", "支付宝账号");
            /// <summary>
            /// 微信账号
            /// </summary>
            public readonly static Field POPULATION_WX = new Field("POPULATION_WX", "MZTUSER", "微信账号");
            /// <summary>
            /// 户籍地址
            /// </summary>
            public readonly static Field POPULATION_HJDZ = new Field("POPULATION_HJDZ", "MZTUSER", "户籍地址");
            /// <summary>
            /// 居住地址
            /// </summary>
            public readonly static Field POPULATION_JZDZ = new Field("POPULATION_JZDZ", "MZTUSER", "居住地址");
            /// <summary>
            /// 工作单位
            /// </summary>
            public readonly static Field POPULATION_GZDW = new Field("POPULATION_GZDW", "MZTUSER", "工作单位");
            /// <summary>
            /// 法定代表人
            /// </summary>
            public readonly static Field LEGALPERSON_NAME = new Field("LEGALPERSON_NAME", "MZTUSER", "法定代表人");
            /// <summary>
            /// 如果当前登录的是法人子账号，那么该单位有法人主账号，那么该字段是主账号的 ID
            /// </summary>
            public readonly static Field MAINACC_USERID = new Field("MAINACC_USERID", "MZTUSER", "如果当前登录的是法人子账号，那么该单位有法人主账号，那么该字段是主账号的 ID");
            /// <summary>
            /// 单位所在省份编码
            /// </summary>
            public readonly static Field LEGALPERSON_PROCODE = new Field("LEGALPERSON_PROCODE", "MZTUSER", "单位所在省份编码");
            /// <summary>
            /// 单位所在城市编码
            /// </summary>
            public readonly static Field LEGALPERSON_CITYCODE = new Field("LEGALPERSON_CITYCODE", "MZTUSER", "单位所在城市编码");
            /// <summary>
            /// 单位所在县区编码
            /// </summary>
            public readonly static Field LEGALPERSON_AREACODE = new Field("LEGALPERSON_AREACODE", "MZTUSER", "单位所在县区编码");
            /// <summary>
            /// 单位通信地址
            /// </summary>
            public readonly static Field LEGALPERSON_ADDRESS = new Field("LEGALPERSON_ADDRESS", "MZTUSER", "单位通信地址");
            /// <summary>
            /// 单位注册省份编码
            /// </summary>
            public readonly static Field LEGALPERSON_ZPROCODE = new Field("LEGALPERSON_ZPROCODE", "MZTUSER", "单位注册省份编码");
            /// <summary>
            /// 单位注册城市编码
            /// </summary>
            public readonly static Field LEGALPERSON_ZCITYCODE = new Field("LEGALPERSON_ZCITYCODE", "MZTUSER", "单位注册城市编码");
            /// <summary>
            /// 单位注册县区编码
            /// </summary>
            public readonly static Field LEGALPERSON_ZAREACODE = new Field("LEGALPERSON_ZAREACODE", "MZTUSER", "单位注册县区编码");
            /// <summary>
            /// 单位注册地址
            /// </summary>
            public readonly static Field LEGALPERSON_ZADDRESS = new Field("LEGALPERSON_ZADDRESS", "MZTUSER", "单位注册地址");
            /// <summary>
            /// 单位注册地址
            /// </summary>
            public readonly static Field LEGALPERSON_EMAIL = new Field("LEGALPERSON_EMAIL", "MZTUSER", "单位邮箱");
            /// <summary>
            /// 单位联系电话
            /// </summary>
            public readonly static Field LEGALPERSON_PHONE = new Field("LEGALPERSON_PHONE", "MZTUSER", "单位联系电话");
            /// <summary>
            /// 单位成立日期
            /// </summary>
            public readonly static Field LEGALPERSON_CREAETDATE = new Field("LEGALPERSON_CREAETDATE", "MZTUSER", "单位成立日期");
            /// <summary>
            /// 法人身份证
            /// </summary>
            public readonly static Field LEGALPERSON_IDCARD = new Field("LEGALPERSON_IDCARD", "MZTUSER", "法人身份证");
            /// <summary>
            /// 机构类型
            /// </summary>
            public readonly static Field LEGALPERSON_ORGTYPE = new Field("LEGALPERSON_ORGTYPE", "MZTUSER", "机构类型");
            /// <summary>
            /// 经办人邮箱
            /// </summary>
            public readonly static Field LEGALPERSON_JBREMAIL = new Field("LEGALPERSON_JBREMAIL", "MZTUSER", "经办人邮箱");
            /// <summary>
            /// 经办人姓名
            /// </summary>
            public readonly static Field LEGALPERSON_JBRNAME = new Field("LEGALPERSON_JBRNAME", "MZTUSER", "经办人姓名");
            /// <summary>
            /// 经办人身份证
            /// </summary>
            public readonly static Field LEGALPERSON_JBRIDCARD = new Field("LEGALPERSON_JBRIDCARD", "MZTUSER", "经办人身份证");
            /// <summary>
            /// 年检日期(质监)
            /// </summary>
            public readonly static Field LEGALPERSON_NJRQ = new Field("LEGALPERSON_NJRQ", "MZTUSER", "年检日期(质监)");
            /// <summary>
            /// 年检期限
            /// </summary>
            public readonly static Field LEGALPERSON_NJQX = new Field("LEGALPERSON_NJQX", "MZTUSER", "年检期限");
            /// <summary>
            /// 经营范围
            /// </summary>
            public readonly static Field LEGALPERSON_JYFW = new Field("LEGALPERSON_JYFW", "MZTUSER", "经营范围");
            /// <summary>
            /// 行业名称
            /// </summary>
            public readonly static Field LEGALPERSON_HYMC = new Field("LEGALPERSON_HYMC", "MZTUSER", "行业名称");
            /// <summary>
            /// 经济类型
            /// </summary>
            public readonly static Field LEGALPERSON_JJLX = new Field("LEGALPERSON_JJLX", "MZTUSER", "经济类型");
            /// <summary>
            /// 职工人数
            /// </summary>
            public readonly static Field LEGALPERSON_ZGRS = new Field("LEGALPERSON_ZGRS", "MZTUSER", "职工人数");
            /// <summary>
            /// 注册资本
            /// </summary>
            public readonly static Field LEGALPERSON_ZCZB = new Field("LEGALPERSON_ZCZB", "MZTUSER", "注册资本");
            /// <summary>
            /// 邮政编码
            /// </summary>
            public readonly static Field LEGALPERSON_ZIPCODE = new Field("LEGALPERSON_ZIPCODE", "MZTUSER", "邮政编码");
            /// <summary>
            /// 批准机构名称
            /// </summary>
            public readonly static Field LEGALPERSON_PZJG = new Field("LEGALPERSON_PZJG", "MZTUSER", "批准机构名称");
            /// <summary>
            /// 组织机构代码
            /// </summary>
            public readonly static Field LEGALPERSON_ZZJGDM = new Field("LEGALPERSON_ZZJGDM", "MZTUSER", "组织机构代码");
            /// <summary>
            /// 企业性质
            /// </summary>
            public readonly static Field LEGALPERSON_QYXZ = new Field("LEGALPERSON_QYXZ", "MZTUSER", "企业性质");
            /// <summary>
            /// 工商注册号
            /// </summary>
            public readonly static Field LEGALPERSON_GSZCH = new Field("LEGALPERSON_GSZCH", "MZTUSER", "工商注册号");
            /// <summary>
            /// 颁证日期
            /// </summary>
            public readonly static Field LEGALPERSON_BZRQ = new Field("LEGALPERSON_BZRQ", "MZTUSER", "颁证日期");
            /// <summary>
            /// 颁证单位
            /// </summary>
            public readonly static Field LEGALPERSON_BZDW = new Field("LEGALPERSON_BZDW", "MZTUSER", "颁证单位");
            /// <summary>
            /// 有效期起始
            /// </summary>
            public readonly static Field LEGALPERSON_YXQQS = new Field("LEGALPERSON_YXQQS", "MZTUSER", "有效期起始");
            /// <summary>
            /// 有效期截止
            /// </summary>
            public readonly static Field LEGALPERSON_YXQJZ = new Field("LEGALPERSON_YXQJZ", "MZTUSER", "有效期截止");
            /// <summary>
            /// 年检情况(质监)
            /// </summary>
            public readonly static Field LEGALPERSON_NJQK = new Field("LEGALPERSON_NJQK", "MZTUSER", "年检情况(质监)");
            /// <summary>
            /// 变更事项(质监)
            /// </summary>
            public readonly static Field LEGALPERSON_BGSX = new Field("LEGALPERSON_BGSX", "MZTUSER", "变更事项(质监)");
            /// <summary>
            /// 首次办证日期
            /// </summary>
            public readonly static Field LEGALPERSON_SCBZ = new Field("LEGALPERSON_SCBZ", "MZTUSER", "首次办证日期");
            /// <summary>
            /// 废置日期
            /// </summary>
            public readonly static Field LEGALPERSON_FZRQ = new Field("LEGALPERSON_FZRQ", "MZTUSER", "废置日期");
            /// <summary>
            /// 成立日期
            /// </summary>
            public readonly static Field LEGALPERSON_CLRQ = new Field("LEGALPERSON_CLRQ", "MZTUSER", "成立日期");
            /// <summary>
            /// 投资者注册地
            /// </summary>
            public readonly static Field LEGALPERSON_TZZZCD = new Field("LEGALPERSON_TZZZCD", "MZTUSER", "投资者注册地");
            /// <summary>
            /// 行政区划
            /// </summary>
            public readonly static Field LEGALPERSON_XZQH = new Field("LEGALPERSON_XZQH", "MZTUSER", "行政区划");
            /// <summary>
            /// 地税纳税人识别号
            /// </summary>
            public readonly static Field LEGALPERSON_DSNSRSBH = new Field("LEGALPERSON_DSNSRSBH", "MZTUSER", "地税纳税人识别号");
            /// <summary>
            /// 地税税务登记日期
            /// </summary>
            public readonly static Field LEGALPERSON_DSDJ = new Field("LEGALPERSON_DSDJ", "MZTUSER", "地税税务登记日期");
            /// <summary>
            /// 地税税务登记机关
            /// </summary>
            public readonly static Field LEGALPERSON_DSDJJG = new Field("LEGALPERSON_DSDJJG", "MZTUSER", "地税税务登记机关");
            /// <summary>
            /// 地税注销原因
            /// </summary>
            public readonly static Field LEGALPERSON_DSZXYY = new Field("LEGALPERSON_DSZXYY", "MZTUSER", "地税注销原因");
            /// <summary>
            /// 地税注销日期
            /// </summary>
            public readonly static Field LEGALPERSON_DSZXRQ = new Field("LEGALPERSON_DSZXRQ", "MZTUSER", "地税注销日期");
            /// <summary>
            /// 国税纳税人识别号
            /// </summary>
            public readonly static Field LEGALPERSON_GSSBH = new Field("LEGALPERSON_GSSBH", "MZTUSER", "国税纳税人识别号");
            /// <summary>
            /// 国税税务登记日期
            /// </summary>
            public readonly static Field LEGALPERSON_GSSWDJ = new Field("LEGALPERSON_GSSWDJ", "MZTUSER", "国税税务登记日期");
            /// <summary>
            /// 国税税务登记机关
            /// </summary>
            public readonly static Field LEGALPERSON_GSSWJG = new Field("LEGALPERSON_GSSWJG", "MZTUSER", "国税税务登记机关");
            /// <summary>
            /// 国税注销原因
            /// </summary>
            public readonly static Field LEGALPERSON_GSZXYY = new Field("LEGALPERSON_GSZXYY", "MZTUSER", "国税注销原因");
            /// <summary>
            /// 国税注销日期
            /// </summary>
            public readonly static Field LEGALPERSON_GSZXRQ = new Field("LEGALPERSON_GSZXRQ", "MZTUSER", "国税注销日期");
            /// <summary>
            /// 法人手机号
            /// </summary>
            public readonly static Field LEGALPERSON_FRSJH = new Field("LEGALPERSON_FRSJH", "MZTUSER", "法人手机号");
            /// <summary>
            /// 法人民族代码
            /// </summary>
            public readonly static Field LEGALPERSON_NATION = new Field("LEGALPERSON_NATION", "MZTUSER", "法人民族代码");
            /// <summary>
            /// 法人常住地址
            /// </summary>
            public readonly static Field LEGALPERSON_CZDZ = new Field("LEGALPERSON_CZDZ", "MZTUSER", "法人常住地址");
            /// <summary>
            /// 经办人手机号
            /// </summary>
            public readonly static Field LEGALPERSON_JBRSJH = new Field("LEGALPERSON_JBRSJH", "MZTUSER", "经办人手机号");
            /// <summary>
            /// 法人性别(1:男 2:女)
            /// </summary>
            public readonly static Field LEGALPERSON_FRXB = new Field("LEGALPERSON_FRXB", "MZTUSER", "法人性别(1:男 2:女)");
            /// <summary>
            /// 法人类型
            /// </summary>
            public readonly static Field LEGALPERSON_TYPE = new Field("LEGALPERSON_TYPE", "MZTUSER", "法人类型");
            /// <summary>
            /// 法人账号类型
            /// </summary>
            public readonly static Field LEGALPERSON_ACCTYPE = new Field("LEGALPERSON_ACCTYPE", "MZTUSER", "法人账号类型");
            /// <summary>
            /// 企业机构注册地址
            /// </summary>
            public readonly static Field ENTERPRISEADDRESS = new Field("ENTERPRISEADDRESS", "MZTUSER", "企业机构注册地址");
            /// <summary>
            /// 企业机构注册金额单位万元
            /// </summary>
            public readonly static Field ENTERPRISECAPITAL = new Field("ENTERPRISECAPITAL", "MZTUSER", "企业机构注册金额单位万元");
            /// <summary>
            /// 企业机构经营范围
            /// </summary>
            public readonly static Field ENTERPRISERANGE = new Field("ENTERPRISERANGE", "MZTUSER", "企业机构经营范围");
            /// <summary>
            /// 企业机构注册日期
            /// </summary>
            public readonly static Field ENTERPRISEREGISTERDATE = new Field("ENTERPRISEREGISTERDATE", "MZTUSER", "企业机构注册日期");
            /// <summary>
            /// 营业限期起始
            /// </summary>
            public readonly static Field ENTERPRISEBEGINDATE = new Field("ENTERPRISEBEGINDATE", "MZTUSER", "营业限期起始");
            /// <summary>
            /// 营业限期截止
            /// </summary>
            public readonly static Field ENTERPRISEENDDATE = new Field("ENTERPRISEENDDATE", "MZTUSER", "营业限期截止");
            /// <summary>
            /// 核准日期
            /// </summary>
            public readonly static Field ENTERPRISEAPPROVALDATE = new Field("ENTERPRISEAPPROVALDATE", "MZTUSER", "核准日期");
            /// <summary>
            /// 核准机构
            /// </summary>
            public readonly static Field ENTERPRISEAPPROVERAGENCY = new Field("ENTERPRISEAPPROVERAGENCY", "MZTUSER", "核准机构");
            /// <summary>
            /// 社会组织活动范围
            /// </summary>
            public readonly static Field ACTAREA = new Field("ACTAREA", "MZTUSER", "社会组织活动范围");
            /// <summary>
            /// 业务范围
            /// </summary>
            public readonly static Field ASSOCIATIONCONTENT = new Field("ASSOCIATIONCONTENT", "MZTUSER", "业务范围");
            /// <summary>
            /// 住所
            /// </summary>
            public readonly static Field REGADDRESS = new Field("REGADDRESS", "MZTUSER", "住所");
            /// <summary>
            /// 所属行(事)业
            /// </summary>
            public readonly static Field INDUSTRY = new Field("INDUSTRY", "MZTUSER", "所属行(事)业");
            /// <summary>
            /// 登记日期
            /// </summary>
            public readonly static Field REGDATE = new Field("REGDATE", "MZTUSER", "登记日期");
            /// <summary>
            /// 注册资金(单位万元)
            /// </summary>
            public readonly static Field REGMONEY = new Field("REGMONEY", "MZTUSER", "注册资金(单位万元)");
            /// <summary>
            /// 业务主管单位
            /// </summary>
            public readonly static Field COMPETENTORG = new Field("COMPETENTORG", "MZTUSER", "业务主管单位");
            /// <summary>
            /// _0：非慈善组织；1：是慈善组织
            /// </summary>
            public readonly static Field CHARITYORG = new Field("CHARITYORG", "MZTUSER", "_0：非慈善组织；1：是慈善组织");
            /// <summary>
            /// _1：民营非企业；2：社会团体；3：基金会
            /// </summary>
            public readonly static Field SOCIALORGTYPE = new Field("SOCIALORGTYPE", "MZTUSER", "_1：民营非企业；2：社会团体；3：基金会");
            /// <summary>
            /// 基金会类型(1 公募基金会；2：非公募基 金会)
            /// </summary>
            public readonly static Field FUNDKIND = new Field("FUNDKIND", "MZTUSER", "基金会类型(1 公募基金会；2：非公募基 金会)");
            /// <summary>
            /// 宗旨和业务范围
            /// </summary>
            public readonly static Field REGRANGE = new Field("REGRANGE", "MZTUSER", "宗旨和业务范围");
            /// <summary>
            /// 举办单位
            /// </summary>
            public readonly static Field REGORGANIZER = new Field("REGORGANIZER", "MZTUSER", "举办单位");
            /// <summary>
            /// 登记管理机关
            /// </summary>
            public readonly static Field REGAUTHORITY = new Field("REGAUTHORITY", "MZTUSER", "登记管理机关");
            /// <summary>
            /// 经费来源
            /// </summary>
            public readonly static Field FUNDSOURCE = new Field("FUNDSOURCE", "MZTUSER", "经费来源");
            /// <summary>
            /// 法人证件有效起始日期
            /// </summary>
            public readonly static Field CERT_YXQS = new Field("CERT_YXQS", "MZTUSER", "法人证件有效起始日期");
            /// <summary>
            /// 法人证件有效到期日期
            /// </summary>
            public readonly static Field CERT_YXJZ = new Field("CERT_YXJZ", "MZTUSER", "法人证件有效到期日期");
            /// <summary>
            /// 经办人证件类型
            /// </summary>
            public readonly static Field AGENTCERTTYPE = new Field("AGENTCERTTYPE", "MZTUSER", "经办人证件类型");
            /// <summary>
            /// 代码证件图片
            /// </summary>
            public readonly static Field DMZJ_PATH = new Field("DMZJ_PATH", "MZTUSER", "代码证件图片");
            /// <summary>
            /// 有无统一社会信用代码(1:有 -1:无)
            /// </summary>
            public readonly static Field YWTYDM = new Field("YWTYDM", "MZTUSER", "有无统一社会信用代码(1:有 -1:无)");
            /// <summary>
            /// 无社会代码类型(1:机构筹措中,2 个体户)
            /// </summary>
            public readonly static Field WDMLX = new Field("WDMLX", "MZTUSER", "无社会代码类型(1:机构筹措中,2 个体户)");
            /// <summary>
            /// 营业执照图片路径
            /// </summary>
            public readonly static Field YYZZ_PATH = new Field("YYZZ_PATH", "MZTUSER", "营业执照图片路径");
            /// <summary>
            /// 创建时间
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "MZTUSER", "创建时间");
            /// <summary>
            /// 修改时间
            /// </summary>
            public readonly static Field MODIFY_TIME = new Field("MODIFY_TIME", "MZTUSER", "修改时间");
            /// <summary>
            /// 状态1有效0无效
            /// </summary>
            public readonly static Field STATUS = new Field("STATUS", "MZTUSER", "状态1有效0无效");
            /// <summary>
            /// 监督平台绑定的用户id
            /// </summary>
            public readonly static Field JDUSERID = new Field("JDUSERID", "MZTUSER", "监督平台绑定的用户id");
            /// <summary>
            /// 服务平台绑定的用户id
            /// </summary>
            public readonly static Field FWUSERID = new Field("FWUSERID", "MZTUSER", "服务平台绑定的用户id");
        }
        #endregion
    }
}