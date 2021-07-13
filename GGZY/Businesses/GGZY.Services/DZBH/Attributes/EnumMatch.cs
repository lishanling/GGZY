using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    public class EnumMatch : BaseMatchAttributes
    {
        public EnumMatch(Type e, string errorMsg = "")
        {
            _errorMsg = errorMsg;
            _e = e;
        }
        private Type _e { get; set; }
        private string _errorMsg { get; set; }

        public override string errorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }
        public Type e
        {
            get { return _e; }
            set { _e = value; }
        }
        public override bool Match(string matchStr, string name)
        {
            _errorMsg = string.IsNullOrEmpty(_errorMsg) ? $"[{name}][{matchStr}]的值不在字典中" : _errorMsg;
            foreach (var value in Enum.GetValues(_e))
            {
                if (((int)value).ToString().Equals(matchStr))
                {
                    return false;
                }
            }

            return true;

        }
    }
}
