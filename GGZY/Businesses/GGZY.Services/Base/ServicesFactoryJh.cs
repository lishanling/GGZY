using GGZY.Services.ZBCG;

namespace GGZY.Services.Base
{
    public partial class ServicesFactoryJh
    {
        public CommonService CommonService { get; set; }
        public ZpFaqService ZpFaqService { get; set; }
        public ZpNoticeService ZpNoticeService { get; set; }
        public ZpResultService ZpResultService { get; set; }
    }
}