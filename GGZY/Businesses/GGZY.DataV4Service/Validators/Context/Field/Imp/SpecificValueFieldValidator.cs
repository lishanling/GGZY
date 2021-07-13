using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class SpecificValueFieldValidator : AbstractFieldValidator
    {
        public string Value { get; set; }
        public override string GetName()
        {
            return "SpecificValue";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                var contextValue = dtContext.GetStringValue(Field);
                ThrowHelper.ThrowIfTure(!contextValue.Equals(Value),$"[{Field}]不符合规范");

            }
        }

        public override string MockCorrectValue(string value)
        {
            return value;
        }
    }
}