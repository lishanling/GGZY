using System.Collections.Generic;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class JdJcTransRecordModel:JC_TRANS_RECORD
    {
        public List<UploadResData> RECORD_ATTACHMENTS { get; set; }

        public JC_TRANS_PROJECT PROJECT { get; set; }
        public JC_TRANS_ENTITY ENTITY { get; set; }
        public JC_TRANS_PERSON PERSON { get; set; }
        public JC_TRANS_DETAIL  DETAIL { get; set; }
        public List<JdJcTransResultModel> RESULTS { get; set; }
    }
}