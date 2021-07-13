using System.Collections.Generic;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class JdJcTransResultModel:JC_TRANS_RESULT
    {
        //public string SEBDER { get; set; }
        //public string SEBDER_UNIT { get; set; }
        public List<UploadResData> RESULT_ATTACHMENTS { get; set; }
    }
}