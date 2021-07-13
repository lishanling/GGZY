using Dos.ORM;
using GGZY.Core.Utils;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Helper
{
    public partial class AppSettings
    {
        #region AppSettings

        /// <summary>
        /// 代理子账号角色ID
        /// key fw_agent_roleid
        /// 默认11
        /// </summary>
        public string AGNET_ROLEID => AppSettingUtils.GetString("fw_agent_roleid", T_USER.AGNET_ROLEID);

        /// <summary>
        /// 个人账号角色ID
        /// key fw_person_roleid
        /// 默认 3
        /// </summary>
        public string PERSON_ROLEID => AppSettingUtils.GetString("fw_person_roleid", T_USER.PERSON_ROLEID);

        /// <summary>
        /// 企业账号角色ID
        /// key fw_company_roleid
        /// 默认4
        /// </summary>
        public string COMPANY_ROLEID => AppSettingUtils.GetString("fw_company_roleid", T_USER.COMPANY_ROLEID);

        /// <summary>
        /// 服务平台文章缓存时间 分钟
        /// key fw_pt_article_cache_minute
        /// 默认60 分钟
        /// </summary>
        public int FW_PT_ARTICLE_CACHE_MINITE => AppSettingUtils.GetInt("fw_pt_article_cache_minute", 60);

        /// <summary>
        /// 服务链接文章缓存时间 分钟
        /// key fw_pt_link_cache_minute
        /// 默认60 分钟
        /// </summary>
        public int FW_PT_LINK_CACHE_MINITE => AppSettingUtils.GetInt("fw_pt_link_cache_minute", 60);

        /// <summary>
        /// 服务平台文章缓存时间 分钟
        /// key fw_pt_article_cache_minute
        /// 默认60 分钟
        /// </summary>
        public int JD_PT_ARTICLE_CACHE_MINITE => AppSettingUtils.GetInt("jd_pt_article_cache_minute", 60);

        /// <summary>
        /// 服务链接文章缓存时间 分钟
        /// key fw_pt_link_cache_minute
        /// 默认60 分钟
        /// </summary>
        public int JD_PT_LINK_CACHE_MINITE => AppSettingUtils.GetInt("jd_pt_link_cache_minute", 60);

        /// <summary>
        /// 本地文件保存地址(备案签收单的生成保存临时地址)
        /// </summary>
        public string UploadDirectory => AppSettingUtils.GetString("upload_directory", $"/uploads/");

        /// <summary>
        /// 测试服务器地址
        /// </summary>
        public string TestHost => AppSettingUtils.GetString("test_host", "http://114.115.162.77").TrimEnd('/');
        /// <summary>
        /// 文件服务器主机域名
        /// 测试地址 http://114.115.162.77:8066
        /// 生产地址 TODO appsettings  common_upload_host
        /// </summary>
        public string UploadHost => AppSettingUtils.GetString("common_upload_host", "http://114.115.162.77:8066").TrimEnd('/');
        /// <summary>
        /// 文件服务器上传地址
        /// </summary>
        public string UploadUrl => AppSettingUtils.GetString("common_upload_url", $"{UploadHost}/file/upload");
        /// <summary>
        /// 当前站点域名
        /// </summary>
        public string Host => AppSettingUtils.GetString("web_host");
        /// <summary>
        /// 公共服务平台文件获取地址
        /// </summary>
        public string GgzyfwFileUrl => AppSettingUtils.GetString("FileUrl", "https://ggzyfw.fj.gov.cn:9096/ff").TrimEnd('/');
        /// <summary>
        /// CA服务IP地址
        /// </summary>
        public string CAServerIp => AppSettingUtils.GetString("CAServerIP", "125.77.73.161:101");
        /// <summary>
        /// CA应用名称
        /// </summary>
        public string CAWebAppName => AppSettingUtils.GetString("CAWebAppName", "web");
        /// <summary>
        /// 首众证书保存地址
        /// </summary>
        public string ShouZhongPfx => AppSettingUtils.GetString("shouzhong_pfx");
        /// <summary>
        /// 在线投诉 撤销短信模板
        /// 【审查人员】投诉人直接撤销的短信提醒
        /// ＜投诉＞您提交的关于{0}的投诉（编号：{1}），已被{2}{3}，详情请登陆平台查看。
        /// </summary>
        public string SmsZXTS_TSR => AppSettingUtils.GetString("SmsZXTS_TSR", "<投诉>您提交的关于{0}的投诉（编号：{1}），已被{2}{3}，详情请登陆平台查看。");
        /// <summary>
        /// 在线投诉 撤销短信模板
        /// 【审查人员】投诉人直接撤销的短信提醒
        /// ＜投诉＞您有一条关于{0}的投诉已被投诉人{1}。
        /// </summary>
        public string SmsZXTS_CX => AppSettingUtils.GetString("SmsZXTS_CX", "<投诉>您有一条关于{0}的投诉已被投诉人{1}。");
        /// <summary>
        /// 在线投诉书 短信模板
        /// 【审查人员】下步操作人的短信提醒(待受理、待处理、申请撤诉)
        /// ＜投诉＞您有一条关于{0}的{1}投诉，请及时登陆平台操作。
        /// </summary>
        public string SmsZXTS_OP => AppSettingUtils.GetString("SmsZXTS_OP", "<投诉>您有一条关于{0}的{1}投诉，请及时登陆平台操作。");
        /// <summary>
        /// 在线投诉书 短信模板
        /// 【审查人员】签收人的短信提醒
        /// ＜投诉＞您有一份关于{0}的投诉，请及时登录平台操作并指定投诉经办人。
        /// </summary>
        public string SmsZXTS_SIGN => AppSettingUtils.GetString("SmsZXTS_Sign", "<投诉>您有一份关于{0}的投诉，请及时登录平台操作并指定投诉经办人。");

        /// <summary>
        /// 在线投诉书 短信模板
        /// 【报建备案人】短信提醒（处理）
        /// ＜投诉＞您单位的{0}的被投诉，已为{1}{2}，请登陆平台查看详情。
        /// </summary>
        public string SmsZXTS_BJBA => AppSettingUtils.GetString("SmsZXTS_BJBA", "<投诉>您单位的{0}被投诉，已为{1}{2}，请登陆平台查看详情。");
        /// <summary>
        /// 在线投诉书 调查取证
        /// 【福建省公共资源交易电子行政监督平台】招标项目名称：{0}，被投诉举报，请凭反馈码: {1}，到本平台进行情况反馈。步骤：平台门户-投诉举报-调查质证-输入反馈码；https://ggzyjd.fujian.gov.cn。
        /// </summary>
        public string SmsZXTS_DCQZ => AppSettingUtils.GetString("SmsZXTS_BJBA", "【福建省公共资源交易电子行政监督平台】招标项目名称：{0}，被投诉举报，请凭反馈码: {1}，到本平台进行情况反馈。步骤：平台门户-投诉举报-调查质证-输入反馈码；https://ggzyjd.fujian.gov.cn。");


        /// <summary>
        /// 在线投诉书 调查取证 处理 抄送短信 公开
        /// 【福建省公共资源交易电子行政监督平台】投诉标题:{0},已处理完结并公示,可前往查看处理结果。https://ggzyjd.fujian.gov.cn。
        /// </summary>
        public string SmsZXTS_DCQZ_CS_PUBLIC => AppSettingUtils.GetString("SmsZXTS_DCQZ_CS_PUBLIC", "【福建省公共资源交易电子行政监督平台】投诉标题:{0},已处理完结并公示,可前往查看处理结果。https://ggzyjd.fujian.gov.cn。");


        /// <summary>
        /// 在线投诉书 调查取证 处理 抄送短信 投诉人
        /// 【福建省公共资源交易电子行政监督平台】投诉标题:{0},投诉编号:{1},已处理完结并公示,可前往查看处理结果。步骤：平台门户-投诉举报-投诉查询-输入投诉编号查询；https://ggzyjd.fujian.gov.cn。
        /// </summary>
        public string SmsZXTS_DCQZ_CS_TSR => AppSettingUtils.GetString("SmsZXTS_DCQZ_CS_TSR", "【福建省公共资源交易电子行政监督平台】投诉标题:{0},投诉编号:{1},已处理完结并公示,可前往查看处理结果。步骤：平台门户-投诉举报-投诉查询-输入投诉编号查询；https://ggzyjd.fujian.gov.cn。");

        /// <summary>
        /// 在线投诉书 调查取证 处理 抄送短信 招标人 被投诉人 代理机构 其他
        /// 【福建省公共资源交易电子行政监督平台】投诉标题:{0},已处理完结,凭查询码:{1},已处理完结前往查看处理结果。步骤：平台门户-投诉举报-投诉查询-查询码查询;https://ggzyjd.fujian.gov.cn。
        /// </summary>
        public string SmsZXTS_DCQZ_CS => AppSettingUtils.GetString("SmsZXTS_DCQZ_CS", "【福建省公共资源交易电子行政监督平台】投诉标题:{0},已处理完结,凭查询码:{1},已处理完结前往查看处理结果。步骤：平台门户-投诉举报-投诉查询-查询码查询;https://ggzyjd.fujian.gov.cn。");



        /// <summary>
        /// 项目报建登记 待审查 短信模板
        /// ＜报建＞您有待审查的报建【{0}】已被撤回，报建人为【{1}】。
        /// </summary>
        public string SmsBJRetract => AppSettingUtils.GetString("SmsBJRetract", "<报建>您有待审查的报建【{0}】已被撤回，报建人为【{1}】。");
        /// <summary>
        /// 项目报建登记  短信模板
        /// ＜报建＞您有新的【{0}】条报建需要审查，请及时完成审查。
        /// </summary>
        public string SmsBJSubmitContext => AppSettingUtils.GetString("SmsBJSubmitContext", "<报建>您有新的【{0}】条报建需要审查，请及时完成审查。");
        /// <summary>
        /// 项目报建登记  短信模板
        /// ＜报建＞【{0}】,您好！您提交的【{1}】，已被【{2}】审查，审查结果为：【{3}】，请登陆平台查看。
        /// </summary>
        public string SmsBJAudit => AppSettingUtils.GetString("SmsBJAudit", "<报建>【{0}】,您好！您提交的【{1}】，已被【{2}】审查，审查结果为：【{3}】，请登陆平台查看。");
        /// <summary>
        /// 统一用户登录回调地址
        /// https://ggzyfw.fujian.gov.cn/OAuth/admin/index.html#/login?clientid=GGZYJD
        /// https://ggzyfw.fujian.gov.cn/OAuth/admin/index.html#/login?clientid=GGZYFW
        /// </summary>
        public string UNIFY_LOGIN_URL => AppSettingUtils.GetString("unify_login_url", $"https://ggzyfw.fujian.gov.cn/OAuth/admin/index.html#/login");
        /// <summary>
        /// 查询IP地址头部KEY值
        /// HTTP_X_FORWARDED_FOR,REMOTE_ADDR,HTTP_X_REAL_IP,X-Real-IP,X-FORWARDED-FOR
        /// </summary>
        public string ForwardedHTTPheader => AppSettingUtils.GetString("ForwardedHTTPheader", "HTTP_X_FORWARDED_FOR,REMOTE_ADDR,HTTP_X_REAL_IP,X-Real-IP,X-FORWARDED-FOR");
        /// <summary>
        /// 门户网站前端页面地址 ~/web/index.html
        /// </summary>
        public string Portal => AppSettingUtils.GetString("portal", "~/web/#/");
        /// <summary>
        /// 后台网站前端页面地址
        /// </summary>
        public string Admin => AppSettingUtils.GetString("admin", "~/admin/index.html");

        /// <summary>
        /// 备案提醒短信模板
        /// </summary>
        public string SmsRecordSubmitContext => AppSettingUtils.GetString("SmsRecordSubmitContext", "<备案>您有一条新的{0}{1}需要审查，备案人为{2}，请及时登陆平台处理。");
        /// <summary>
        /// 可以上传的附件格式
        /// </summary>
        public string AcceptFile => AppSettingUtils.GetString("accept_file", ".pdf,.jpg,.jpeg,.png,.bmp,.gif,.txt,.html,.xls,.doc,.xlsx,.docx,.zip,.gz,.rar");
        /// <summary>
        /// 可以预览的附件
        /// </summary>
        public string AcceptImg => AppSettingUtils.GetString("accept_view", ".pdf,.jpg,.jpeg,.png,.bmp,.gif,.txt");
        /// <summary>
        /// 非法文件
        /// </summary>
        public string UnAcceptFile => AppSettingUtils.GetString("un_accept_file", ".exe,.dll,.c,.java,.aspx,.VBS,.VBE,.JS,.JSE,.WSH,.WSF,.bat,.msi");
        /// <summary>
        /// https://ggzyfw.fujian.gov.cn
        /// </summary>
        public string GGZYFWHOST => AppSettingUtils.GetString("ggzyfw", "https://ggzyfw.fujian.gov.cn").TrimEnd('/', '\\');
        /// <summary>
        /// https://ggzyjd.fujian.gov.cn
        /// </summary>
        public string GGZYJDHOST => AppSettingUtils.GetString("ggzyjd", "https://ggzyjd.fujian.gov.cn").TrimEnd('/', '\\');
        /// <summary>
        /// https://ggzyfw.fj.gov.cn
        /// </summary>
        public string FJGGZYFWHOST => AppSettingUtils.GetString("ggzyfw_fj", "https://ggzyfw.fj.gov.cn").TrimEnd('/', '\\');
        /// <summary>
        /// https://ggzyjd.fj.gov.cn
        /// </summary>
        public string FJGGZYJDHOST => AppSettingUtils.GetString("ggzyfw_fj", "https://ggzyjd.fj.gov.cn").TrimEnd('/', '\\');

        public string JD_PORTAL_ASC_IV => AppSettingUtils.GetString("jd_portal_asc_iv", "AB6882A633472F39");
        public string JD_PORTAL_ASC_KEY => AppSettingUtils.GetString("jd_portal_asc_key", "B98DB5CA435B479D819C6B255CBCD62C");
        public string FW_PORTAL_ASC_IV => AppSettingUtils.GetString("fw_portal_asc_iv", "A8909931867B0425");
        public string FW_PORTAL_ASC_KEY => AppSettingUtils.GetString("fw_portal_asc_key", "BE45D593014E4A4EB4449737660876CE");
        public string FW_PORTAL_SIGN_KEY => AppSettingUtils.GetString("fw_portal_sign_key", "3637CB36B2E54A72A7002978D0506CDF");
        public string JD_PORTAL_SIGN_KEY => AppSettingUtils.GetString("jd_portal_sign_key", "E9498112A6CD42E0A4B2939CEBBC94CB");
        /// <summary>
        /// "9";//报建备案账号 角色对应ID 跟数据库中一致，，数据库中的这些数据不能删除 todo 修改 
        /// </summary>
        public string JD_MEMBER_REGISTER_ROLEIDS => AppSettingUtils.GetString("member_register_roleids", "9");
        /// <summary>
        ///  657;//报建备案机构 组织机构对应ID 跟数据库中一致，，数据库中的这些数据不能删除 todo 修改
        /// </summary>
        public decimal? JD_MEMBER_REGISTER_DEPARTID => AppSettingUtils.GetInt("member_register_departid", 657);
        /// <summary>
        /// 角色 纪委监委 名称
        /// </summary>
        public string JiWeiJianWei => AppSettingUtils.GetString("T_USER_ROLE_V2_JWJW", "纪委监委");
        /// <summary>
        /// 角色 公安厅 名称
        /// </summary>
        public string GongAnTing => AppSettingUtils.GetString("T_USER_ROLE_V2_GAT", "公安厅");
        /// <summary>
        /// 角色 注册用户 名称
        /// </summary>
        public string ZhuCeYongHu => AppSettingUtils.GetString("T_USER_ROLE_V2_REGISTER", "注册用户");
        /// <summary>
        /// 监督平台 纪委监委
        /// 组织机构DTYPE 1科室2办公司 3纪委监委4公安 空值无 默认空值
        /// </summary>
        public string JD_DEP_JIWEI_TYPE => AppSettingUtils.GetString("JD_DEP_JIWEI_DTYPE", "3");

        #endregion

        #region 闽政通社会实名认证和授权登录配置信息
        /// <summary>
        /// 闽政通社会实名认证和授权登录授权码
        /// </summary>
        public string MZT_CODE => AppSettingUtils.GetString("mzt_code", "2c9bbe6975c2a76a0175f8dea818047f2c9bbe6975c2a76a");
        /// <summary>
        /// 信任传递登录状态验证
        /// </summary>
        public string MZT_CHECK_URL => AppSettingUtils.GetString("mzt_check_url", "https://mztapp.fujian.gov.cn:8304/dataset/UnifiedController/checkLoginStatus.do");
        /// <summary>
        /// 信任传递登录状态回调地址
        /// </summary>
        public string MZT_CHECK_BACK_URL => AppSettingUtils.GetString("mzt_check_back_url", "http://114.115.162.77/jd/mztaccount/checkback");
        /// <summary>
        /// 实名认证登录地址
        /// </summary>
        public string MZT_LOGIN_URL => AppSettingUtils.GetString("mzt_login_url", "https://mztapp.fujian.gov.cn:8304/dataset/UnifiedController/goLogin.do");
        /// <summary>
        /// 实名认证登录回调地址
        /// </summary>
        public string MZT_LOGIN_BACK_URL => AppSettingUtils.GetString("mzt_login_back_url", "http://114.115.162.77/jd/mztaccount/loginback");
        /// <summary>
        /// 实名认证登出地址
        /// </summary>
        public string MZT_LOGOUT_URL => AppSettingUtils.GetString("mzt_logout_url", "https://mztapp.fujian.gov.cn:8304/dataset/UnifiedController/goUserCenter.do");
        /// <summary>
        /// 实名认证登录回调地址
        /// </summary>
        public string MZT_LOGOUT_BACK_URL => AppSettingUtils.GetString("mzt_logout_back_url", "http://114.115.162.77/jd/mztaccount/logoutback");
        /// <summary>
        /// 实名认证注册地址
        /// </summary>
        public string MZT_REGISTER_URL => AppSettingUtils.GetString("mzt_register_url", "https://mztapp.fujian.gov.cn:8304/dataset/UnifiedController/goRegist.do");
        /// <summary>
        /// 实名认证回调地址
        /// </summary>
        public string MZT_REGISTER_BACK_URL => AppSettingUtils.GetString("mzt_register_back_url", "http://114.115.162.77/jd/mztaccount/registerback");
        /// <summary>
        /// 实名认证用户中心
        /// </summary>
        public string MZT_USERCENTER_URL => AppSettingUtils.GetString("mzt_usercenter_url", "https://mztapp.fujian.gov.cn:8304/dataset/UnifiedController/goUserCenter.do");
        /// <summary>
        /// 实名认证获取用户信息地址
        /// </summary>
        public string MZT_GETUSER_URL => AppSettingUtils.GetString("mzt_getuser_url", "https://mztapp.fujian.gov.cn:8304/dataset/AppSerController/invokeservice.do");
        /// <summary>
        /// 跳回到前端的地址
        /// </summary>
        public string MZT_FRONT_URL => AppSettingUtils.GetString("mzt_front_url", "http://114.115.162.77/Oauth/admin/#/bind");
        /// <summary>
        /// 好差评获取评价地址的请求地址
        /// </summary>
        public string HCP_GET_URL => AppSettingUtils.GetString("hcp_get_url", "http://api.zwfw.fujian.gov.cn:71/api-gateway/gateway/96hyvzxl/wailian/webservice/getSaveEvaluationUrl?wsdl");
        /// <summary>
        /// 好差评获取token
        /// </summary>
        public string HCP_TOKEN_URL => AppSettingUtils.GetString("hcp_token_url", "http://api.zwfw.fujian.gov.cn:71/api-gateway/gateway/get-token");
        /// <summary>
        /// 好差评公钥
        /// </summary>
        public string HCP_PUBLIC_KEY => AppSettingUtils.GetString("hcp_public_key", "c13aeaacf3db44cd992d4feff557c7b1");
        /// <summary>
        /// 好差评私钥
        /// </summary>
        public string HCP_PRIVATE_KEY => AppSettingUtils.GetString("hcp_private_key", "5fe863633c93471eb77532c8141e9791");
        /// <summary>
        /// 好差评系统编码
        /// </summary>
        public string HCP_SYS_NO => AppSettingUtils.GetString("hcp_sys_no", "1F5DEB7572BA6C7752");
        /// <summary>
        /// 评价完的回调地址
        /// </summary>
        public string HCP_BACK_URL => AppSettingUtils.GetString("hcp_back_url", "http://114.115.162.77/jd");

        public int MZT_MINI_PROGRAM_DASHBOARD => AppSettingUtils.GetInt("mzt_mini_program_dashboard", 5);

        #endregion
    }
}