using System;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 监督平台主账号用户信息
    /// </summary>
    public class JdMainUserModel
    {
        #region T_USER

        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string USERNAME { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [JsonIgnore]
        public string PASSWORD { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string EMAIL { get; set; }
        /// <summary>
        /// 账号类别 0:工作台用户 1:个人用户 2:实名个人用户 3:报建备案用户
        /// </summary>
        public decimal? TYPE { get; set; }
        /// <summary>
        /// CA编码
        /// </summary>
        public string CA_CODE { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? REG_TM { get; set; }
        /// <summary>
        /// 交易平台编码
        /// </summary>
        public string API_CODE { get; set; }
        /// <summary>
        /// 交易平台密钥
        /// </summary>
        public string API_KEY { get; set; }
        /// <summary>
        /// 用户角色ID
        /// </summary>
        public string ROLEIDS { get; set; }
        /// <summary>
        /// 用户角色ID
        /// </summary>
        public string ROLEIDS_TEXT { get; set; }
        /// <summary>
        /// 登陆后生成的一个guid用于判断登陆状态
        /// </summary>
        public string SESSION_ID { get; set; }
        /// <summary>
        /// 父账号ID
        /// </summary>
        public decimal? P_ID { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public decimal? GENDER { get; set; }
        /// <summary>
        /// 是否启用注册完需要后台审核通过后才启用
        /// </summary>
        public decimal? IS_ENABLE { get; set; }
        /// <summary>
        /// 企业代码
        /// </summary>
        public string COMPANY_CODE { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string MANAGE_NAME { get; set; }
        /// <summary>
        /// 行政区划
        /// </summary>
        public string AREACODE { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string TELPHONE { get; set; }
        /// <summary>
        /// 激活码
        /// </summary>
        public string TOKEN { get; set; }
        /// <summary>
        /// 激活码过期时间
        /// </summary>
        public DateTime? TOKEN_EXPTIME { get; set; }
        /// <summary>
        /// 账号行业类型，多个用“,”分割
        /// </summary>
        public string HY_TYPE { get; set; }
        /// <summary>
        /// 管理行政区划，多个用“,”分割
        /// </summary>
        public string ACODES { get; set; }
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public decimal? DEPARTID { get; set; }
        /// <summary>
        /// 后台创建时间
        /// </summary>
        public DateTime? CREATETIME { get; set; }
        /// <summary>
        /// 后台创建人
        /// </summary>
        public decimal? CREATEID { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string PHONE { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string JOB { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string WORKSTATION { get; set; }
        /// <summary>
        /// 可查看备案审查部门
        /// </summary>
        public string DEPARTMENT { get; set; }
        /// <summary>
        /// 是否发送项目异常短信
        /// </summary>
        public decimal? ISSENDMSG { get; set; }
        /// <summary>
        /// 是否推送项目异常通知
        /// </summary>
        public decimal? ISPUSHMSG { get; set; }
        /// <summary>
        /// 审核部门
        /// </summary>
        public string OPERATION_DEPART { get; set; }
        /// <summary>
        /// 是否发送报建提醒短信
        /// </summary>
        public decimal? ISSENDMSG_BJ { get; set; }
        /// <summary>
        /// 是否启用发送短信
        /// </summary>
        public decimal? IS_SEND_MSG { get; set; }


        #endregion

       
    }
}