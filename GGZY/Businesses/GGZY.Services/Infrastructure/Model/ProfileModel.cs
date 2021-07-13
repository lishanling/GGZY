namespace GGZY.Services.Infrastructure.Model
{
    /// <summary>
    /// 当前登录用户 个人设置 密码修改 邮箱绑定 手机绑定 开启|关闭 短信提醒
    /// </summary>
    public class ProfileModel
    {
        public string ImgCode { get; set; }
        public string Code { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }

        public string OldPwd { get; set; }

        public decimal IsSendMsg { get; set; } = 0;


    }
}