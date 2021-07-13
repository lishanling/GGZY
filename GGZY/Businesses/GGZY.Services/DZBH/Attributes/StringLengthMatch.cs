using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    /// <summary>
    /// 字符串长度验证
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class StringLengthMatch : BaseMatchAttributes
    {

        public StringLengthMatch(int maxLength, string errorMsg = "")
        {
            this._maxLength = maxLength;
            this._errorMsg = errorMsg;
        }

        private int _maxLength { get; set; }
        private string _errorMsg { get; set; }

        public int MaxLength
        {
            get { return _maxLength; }
        }
        public override string errorMsg
        {
            set { _errorMsg = value; }
            get { return _errorMsg; }
        }

        public override bool Match(string matchStr, string name)
        {
            bool res = matchStr.Length > this.MaxLength;
            if (res)
            {
                if (string.IsNullOrEmpty(_errorMsg))
                {
                    _errorMsg = $"[{name}][{matchStr}]的长度太长！";
                    return true;
                }
            }
            return false;
        }
    }
}
