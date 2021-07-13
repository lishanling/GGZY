using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;

namespace GGZY.FuWu.Models
{
    public class CustomResult : ActionResult
    {
        public string ContentType { get; set; } = "application/json";

        public Encoding ContentEncoding { get; set; } = Encoding.UTF8;
        public object Data
        {
            get;
            set;
        }

        public bool UseGeneralResult { get; set; } = true;
        public override void ExecuteResult(ControllerContext context)
        {
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = ContentType;
            response.ContentEncoding = ContentEncoding;
            if (UseGeneralResult)
            {
                var result = new GeneralResult();
                if (Data is Exception e)
                {
                    result.SetException(e.Message, e);
                }
                else if (Data is GeneralResult generalResult)
                {
                    result = generalResult;
                }
                else
                {
                    result.SetSuccess(Data);
                }

                var jsonStr = result.Serializer();
                response.Write(jsonStr);
            }
            else
            {
                var jsonStr = Data.Serializer();
                response.Write(jsonStr);
            }
        }
    }
}