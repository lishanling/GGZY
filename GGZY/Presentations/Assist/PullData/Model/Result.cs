using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullData.Model
{
    [Serializable]
    public class Result
    {
        public string Code { get; set; }
        public string Message { get; set; }

        public string Content { get; set; }


    }
}
