using System;
using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class NumberMatchFieldValidator : AbstractFieldValidator
    {
        //todo 整数、小数分开判断
        public int IntegerFigures { get; set; }
        public int DecimalFigures { get; set; }

        public override string GetName()
        {
            return "NumberMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                var value = dtContext.GetStringValue(Field);
                var arrs = value.Split('.');
                var intFig = arrs[0];
                ThrowHelper.ThrowIfTure(intFig.Length > IntegerFigures, $"[{Field}整数部分超出范围]");
                /*if (double.TryParse(intFig, out var a) == false)
                {
                    ThrowHelper.ThrowIfTure(true, $"[{Field}整数部分格式不正确]");
                }*/

                if (DecimalFigures > 0 && arrs.Length > 1)
                {
                    ThrowHelper.ThrowIfTure(arrs.Length != 2, $"[{Field}格式错误]");
                    var demFig = arrs[1];
                    ThrowHelper.ThrowIfTure(demFig.Length > DecimalFigures, $"[{Field}小数部分超出范围]");
                    if (double.TryParse(value, out var b) == false)
                    {
                        ThrowHelper.ThrowIfTure(true, $"[{Field}格式不正确]");
                    }
                }
            }
        }

        public override string MockCorrectValue(string value)
        {
            var intFig = GetStrByLength("8", IntegerFigures);
            if (DecimalFigures > 0)
            {
                var demFig = GetStrByLength("6", DecimalFigures);
                intFig += "." + demFig;
            }
            return intFig;
        }
    }
}