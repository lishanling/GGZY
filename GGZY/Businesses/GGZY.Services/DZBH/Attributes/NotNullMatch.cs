using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    /// <summary>
    /// 验证非空
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class NotNullMatch : BaseMatchAttributes
    {
        public NotNullMatch(string errorMsg = "")
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

            if (string.IsNullOrWhiteSpace(matchStr))
            {
                _errorMsg = string.IsNullOrEmpty(_errorMsg) ? $"[{name}]不能为空" : _errorMsg;
                return true;
            }
            return false;
        }
    }
}
