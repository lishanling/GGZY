using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.BigData
{
    public class BigDataSearchModel
    {
        private DateTime _BEGIN_TIME;
        private DateTime _END_TIME;
        public string method { get; set; }
        public DateTime BeginTime
        {
            get => _BEGIN_TIME.Date;
            set => _BEGIN_TIME = value;
        }

        public DateTime EndTime
        {
            get => _END_TIME.Date.AddDays(1);
            set => _END_TIME = value;
        }
        public string TENDER_PROJECT_TYPE { get; set; }
        public string pareacode { get; set; }
        public string AREACODE { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public int pageindex { get; set; }
        public int pagesize { get; set; }
        public string name { get; set; }
        public string mixcode { get; set; }
        public string INDUSTRY_TYPE { get; set; }
        public string biddername { get; set; }
        public string WIN_BIDDER_CODE { get; set; }
    }

}
