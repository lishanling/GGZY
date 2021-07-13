using System.Data;
using System.Globalization;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class CannotModifyDataValidator :AbstractFieldValidator
    {
        public override string GetName()
        {
            return "CannotModify";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue(Constant.DATA_TYPE);
            if (dataType == 2)
            {
                var dataKey = dtTitle.GetStringValue(Constant.DATA_KEY);
                var sql = $"select {Field} from {DataConfig.TableName} where {DataConfig.M_KEY_Field} ='" + dataKey.ToClearSql() + "'";
                var dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                if (!dt.GetStringValue(Field).Equals(dtContext.GetStringValue(Field)))
                {
                    ThrowHelper.ThrowIfTure(true,$"[{Field}]不能修改");
                }
            }
        }

        public override string MockCorrectValue(string value)
        {
            return value;
        }
    }
}