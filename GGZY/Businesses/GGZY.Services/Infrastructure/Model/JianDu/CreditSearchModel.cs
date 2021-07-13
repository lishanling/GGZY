using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class CreditSearchModel : SearchCondition
    {
        public string SearchKey { get; set; }
        public string REVIEW_TYPE { get; set; }
        public string PROBLEM_ATTRIBUTE { get; set; }
        public DateTime BeginTM { get; set; }
        public DateTime EndTM { get; set; }
    }
}
