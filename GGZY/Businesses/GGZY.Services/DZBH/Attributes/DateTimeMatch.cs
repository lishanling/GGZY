using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class DateTimeMatch : BaseMatchAttributes
    {
        public DateTimeMatch(string errorMsg = "")
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
            DateTime t = DateTime.MinValue;
            DateTime.TryParseExact(matchStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out t);
            if (t.Equals(DateTime.MinValue))
            {
                _errorMsg = string.IsNullOrEmpty(_errorMsg) ? $"[{name}][{matchStr}]不是正确的时间格式" : _errorMsg;
                return true;
            };
            return false;
        }
    }
}
