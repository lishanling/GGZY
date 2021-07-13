using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class DoubleMatch : BaseMatchAttributes
    {
        public DoubleMatch(string errorMsg = "")
        {
            _errorMsg = errorMsg;
        }
        private string _errorMsg { get; set; }
        public override string errorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }
        public override bool Match(string matchStr, string name)
        {
            double t = 0;
            double.TryParse(matchStr, out t);
            if (t.Equals(0))
            {
                _errorMsg = string.IsNullOrEmpty(errorMsg) ? $"[{name}][{matchStr}]不是正确的数值类型" : _errorMsg;
                return true;
            };
            return false;
        }
    }
}
