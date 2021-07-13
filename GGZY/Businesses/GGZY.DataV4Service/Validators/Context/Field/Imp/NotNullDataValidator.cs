using System.Data;
using System.Reflection.Emit;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class NotNullDataValidator : AbstractFieldValidator
    {
        public override string GetName()
        {
            return "NotNull";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var value = dtContext.GetStringValue(Field);
            ThrowHelper.ThrowIfTure(string.IsNullOrEmpty(value),$"字段{Field}不能为空");
        }

        public override string MockCorrectValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "-";
            }
            return value;
        }
    }
}