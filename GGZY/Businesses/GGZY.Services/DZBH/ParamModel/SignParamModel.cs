using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH.ParamModel
{
    /// <summary>
    /// 签章返回的参数信息
    /// </summary>
    public class SignParamModel
    {
        public string @params { get; set; }
        public string is_upload_pdf { get; set; }
        public string pc_info { get; set; }
        public string file_info { get; set; }
        public string ca_info { get; set; }
    }
}
