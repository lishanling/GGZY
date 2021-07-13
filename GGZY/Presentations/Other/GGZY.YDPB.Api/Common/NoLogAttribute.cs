using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.YDPB.Api.Common
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true)]
    public class NoLogAttribute : Attribute
    {
    }
}