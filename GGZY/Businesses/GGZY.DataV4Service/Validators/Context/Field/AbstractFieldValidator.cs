using System.Data;
using System.Text;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field
{
    public abstract class AbstractFieldValidator : AbstractValidator
    {
        public string Field { get; set; }

        protected bool IfNotNull(DataTable dtTitle,DataTable dtContenxt)
        {
            var value = dtContenxt.GetStringValue(Field);
            return !string.IsNullOrEmpty(value);
        }

        public abstract string MockCorrectValue(string value);

        protected string GetStrByLength(string str, int length)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

    }
}