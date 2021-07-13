using System.Data;
using System.Text;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class LengthMatchFieldValidator : AbstractFieldValidator
    {
        public int FixedLength { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }

        public override string GetName()
        {
            return "LengthMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                var value = dtContext.GetStringValue(Field);
                if (FixedLength > 0)
                {
                    if (value.Contains(";"))
                    {
                        var childValues = value.Split(';');
                        foreach (var child in childValues)
                        {
                            ThrowHelper.ThrowIfTure(child.Length != FixedLength, $"[{Field}]长度有误");
                        }
                    }
                    else
                    {
                        ThrowHelper.ThrowIfTure(value.Length != FixedLength, $"[{Field}]长度有误");
                    }
                    
                }
                if (MaxLength > 0)
                {
//                    var bytes = Encoding.Default.GetBytes(value);
                    ThrowHelper.ThrowIfTure(value.Length > MaxLength, $"[{Field}]长度超出范围");
                }
                if (MinLength > 0)
                {
                    //                    var bytes = Encoding.Default.GetBytes(value);
                    ThrowHelper.ThrowIfTure(value.Length < MinLength, $"[{Field}]长度太短");
                }
            }
            
        }

        public override string MockCorrectValue(string value)
        {
            if (FixedLength > 0)
            {
                return GetStrByLength("0", FixedLength);
            }
            if (MaxLength > 0)
            {
                return GetStrByLength("A", MaxLength);
            }
            return "0";
        }
    }
}