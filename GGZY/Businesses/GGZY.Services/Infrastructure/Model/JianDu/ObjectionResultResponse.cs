using GGZY.Core.Extensions;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class ObjectionResultResponse
    {
        private string _ID;

        public string ID
        {
            get => _ID.DesEncrypt();
            set => _ID = value;
        }

        public string REVIEW_CODE { get; set; }
        public string TENDER_PROJECT_CODE { get; set; }
        public string TENDER_PROJECT_TYPE { get; set; }
        public string TENDER_PROJECT_NAME { get; set; }
        public string DISSENT_TYPE { get; set; }
        public string TENDER_AGENCY_NAME { get; set; }
        public string TENDERER_NAME { get; set; }
        public string COMMIT_TIME { get; set; }
        public string TM { get; set; }
    }
}