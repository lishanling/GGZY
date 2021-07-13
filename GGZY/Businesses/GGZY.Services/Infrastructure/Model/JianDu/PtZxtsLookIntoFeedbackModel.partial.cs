using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GGZY.Core.Models;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
   
    public partial class PtZxtsLookIntoFeedbackModel
    {
        public List<UploadResData> FEEDBACK_AIDS_ATTACHMENTS { get; set; }

        public string CREATOR { get; set; }

        public string LOOK_OBJECT_TYPE_CODE
        {
            get
            {
                var code = String.Empty;
                switch (LOOK_OBJECT_TYPE)
                {
                    case "投诉人":
                        code = "tsr";
                        break;
                    case "招标人":
                        code = "zbr";
                        break;
                    case "被投诉人":
                        code = "btsr";
                        break;
                    case "代理机构":
                        code = "dljg";
                        break;
                    default:
                        code = "qt";
                        break;
                }
                return code;
            }
        }

        public bool IsTsr => !string.IsNullOrWhiteSpace(LOOK_OBJECT_TYPE) && LOOK_OBJECT_TYPE.Equals("投诉人");
        public bool IsZbr => !string.IsNullOrWhiteSpace(LOOK_OBJECT_TYPE) && LOOK_OBJECT_TYPE.Equals("招标人");
        public bool IsBtsr => !string.IsNullOrWhiteSpace(LOOK_OBJECT_TYPE) && LOOK_OBJECT_TYPE.Equals("被投诉人");
        public bool IsDljg => !string.IsNullOrWhiteSpace(LOOK_OBJECT_TYPE) && LOOK_OBJECT_TYPE.Equals("代理机构");
        public bool IsQt => !string.IsNullOrWhiteSpace(LOOK_OBJECT_TYPE) && LOOK_OBJECT_TYPE.Equals("其他");


        public void SetAids()
        {
            if (this.FEEDBACK_AIDS_ATTACHMENTS != null && this.FEEDBACK_AIDS_ATTACHMENTS.Any())
            {
                this.FEEDBACK_AIDS = string.Join(",", this.FEEDBACK_AIDS_ATTACHMENTS.Select(c => c.Id));
            }
            else
            {
                this.FEEDBACK_AIDS=String.Empty;
            }
            
        }
    }
}