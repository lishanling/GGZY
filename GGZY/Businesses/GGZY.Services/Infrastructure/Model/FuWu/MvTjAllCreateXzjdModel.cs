using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public class MvTjAllCreateXzjdModel:MV_TJ_ALLCREATE_XZJD
    {
        public string PROJECT_CATEGORY_TEXT { get; set; }
        public string PROJECT_CATEGORY_KIND { get; set; }
        public string PROJECT_TYPE_NAME { get; set; }
        public string TENDERER_NAME { get; set; }
        public string TENDER_AGENCY_NAME { get; set; }
        public string TENDER_AGENCY_CODE { get; set; }
        public string OWNER_NAME { get; set; }
        public string P_AREACODE { get; set; }
        public string P_AREANAME { get; set; }

        public string FW_TENDER_PROJECT_CODE => PROJECT_CODE;
        /// <summary>
        /// 对应监督平台TENDER_PROJECT.TENDER_PROJECT_CODE 可能为空
        /// 匹配一局
        /// 服务平台TENDER_PROJECT.TENDER_PROJECT_CODE=监督平台TENDER_PROJECT.TENDER_PROJECT_CODE_OLD1
        /// </summary>
        public string JD_TENDER_PROJECT_CODE { get; set; }
    }
}