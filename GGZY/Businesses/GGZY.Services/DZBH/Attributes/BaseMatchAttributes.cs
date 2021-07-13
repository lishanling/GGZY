using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public abstract class BaseMatchAttributes : Attribute
    {
        public abstract string errorMsg { get; set; }

        public abstract bool Match(string matchStr,string name);
    }
}
