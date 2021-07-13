using System;
using System.Data;
using System.Globalization;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class DateMatchFieldValidator : AbstractFieldValidator
    {
        public string Format { get; set; }

        public override string GetName()
        {
            return "DateMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                var value = dtContext.GetStringValue(Field);
                try
                {
                    var dt = DateTime.ParseExact(value, Format, CultureInfo.CurrentCulture);
                }
                catch (Exception ex)
                {
                    ThrowHelper.ThrowIfTure(true,$"[{Field}]日期格式不正确");
                }
                
                
            }
        }


        public override string MockCorrectValue(string value)
        {
            return DateTime.Now.ToString(Format);
        }
    }
}