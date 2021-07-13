using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class AreaCodeMatchFieldValidator : AbstractFieldValidator
    {
        public int Begin { get; set; }

        public override string GetName()
        {
            return "AreaCodeMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                ThrowHelper.ThrowIfTure(dtContext.GetStringValue(Field).Length < 6 + Begin, $"[{Field}]的行政区划码长度有误");
                var areaCode = dtContext.GetStringValue(Field).Substring(Begin, 6);

                DataTable dt = DAO.GGFW.GetDataSet("select areacode from sys_area_quanguo where areacode='"
                                                  + areaCode + "'").Tables[0];
                ThrowHelper.ThrowIfTure(dt.Rows.Count <= 0, $"[{Field}]的行政区划码有误");
            }


        }

        public override string MockCorrectValue(string value)
        {
            var v1 = GetStrByLength("M", Begin);
            var v2 = "";
            if (value.Length >= Begin + 6)
            {
                v1 = value.Substring(0, Begin);
                v2 = value.Substring(Begin + 6);
            }
            return $"{v1}350000{v2}";
        }
    }
}