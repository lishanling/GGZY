using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators
{
    public abstract class AbstractValidator : IDataValidator
    {
        public DataConfig DataConfig { get; set; }

        public abstract string GetName();
       

        public abstract void Validate(DataTable dtTitle, DataTable dtContext);

        protected string ValidateNullValue(DataTable dt, string key,string msg = "")
        {
            var value = dt.GetStringValue(key);
            ThrowHelper.ThrowIfTure(string.IsNullOrEmpty(value), 
                string.IsNullOrEmpty(msg)?$"{key}不能为空":msg);
            return value;
        }

    }
}