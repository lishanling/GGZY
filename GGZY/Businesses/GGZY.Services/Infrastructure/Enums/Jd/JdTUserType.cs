namespace GGZY.Services.Infrastructure.Enums.Jd
{
    /// <summary>
    /// 监督平台  数据表T_USER  字段 TYPE  枚举
    /// 对应SYS_DIC字典TYPE值68用户信息表--账号类别
    /// </summary>
    public enum JdTUserType
    {

        /// <summary>
        /// 工作台用户 0
        /// </summary>
        GongZuoTaiYongHu = 0,
        /// <summary>
        /// 个人用户 1
        /// </summary>
        GeRenYongHu = 1,
        /// <summary>
        /// 实名个人用户 2
        /// </summary>
        ShiMingGeRenYongHu = 2,
        /// <summary>
        /// 报建备案用户 3
        /// </summary>
        BaoJianBeiAnYongHu = 3,
        /// <summary>
        /// 纪委监委 5
        /// </summary>
        JiWeiJianWei =5,
        /// <summary>
        /// 公安 6
        /// </summary>
        GongAn=6,
    }
}