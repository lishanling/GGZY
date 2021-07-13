namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class RecordReviewProcessResponseModel
    {
        public string TENDER_PROJECT_CODE { get; set; }
        public string VALUE { get; set; }
        public string TEXT { get; set; }

        /// <summary>
        ///  PROCESS_STATUS 值说明
        ///  0 暂存，未提交，REVIEW_STATUS=0
        ///  1 已提交，流程审批中
        ///  2 审批不通过 REVIEW_STATUS IN 2 3 6
        ///  4 审批通过 REVIEW_STATUS=4
        /// </summary>
        /// <remarks>
        /// REVIEW_STATUS
        /// 0暂存1待审查2退回-不属于本部门监管的项目3退回-备案材料不完整5审查通过6审查不通过)（8签收、9意见修改(无效)）
        /// (住建状态：0暂存1未签收2退回-3退回-8已签收4待审核5审核通过6审核不通过)
        /// </remarks>
        public decimal? PROCESS_STATUS { get; set; }
        public string PROCESS_STATUS_TEXT
        {
            get
            {
                var txt = string.Empty;
                switch (PROCESS_STATUS)
                {
                    case 0:
                        txt = "暂存，未提交";
                        break;
                    case 1:
                        txt = "已提交，流程审批中";
                        break;
                    case 2:
                        txt = "未通过，需整改";
                        break;
                    case 4:
                        txt = "审批通过";
                        break;
                }
                return txt;
            }
        }
    }
}