using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.YDPB.Api.Models
{
    public class RequestModel
    {
        public Validation validation { get; set; }

        public Dictionary<string, object> data{ get; set; }
    }

    public class Validation
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public string DATAUUID { get; set; }
        /// <summary>
        /// Token
        /// </summary>
        public string TOKEN { get; set; }

        public string SYSTEM_NO{get;set;}

        public string TIME { get; set; }
    }
}