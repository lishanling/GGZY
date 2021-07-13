using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class REPROT_CODE_MatchFieldValidator : AbstractFieldValidator
    {
        public override string GetName()
        {
            return "REPROT_CODE_Match";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                //822和823的报建编号必须是t_afc_project的CODE 存在的，并且审核状态（APPROVAL_STATE = 3）通过
                string sql =
                    "select APPROVAL_STATE,CODE from t_afc_project where " +
                    $"CODE = '{dtContext.GetStringValue(Field)}' and APPROVAL_STATE = '3'";

                DataTable dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                ThrowHelper.ThrowIfTure(dt.Rows.Count < 1, "报建编号不正确，或者未审核通过");
                
            }
        }

        public override string MockCorrectValue(string value)
        {
            string sql =
                "select APPROVAL_STATE,CODE from t_afc_project where APPROVAL_STATE = '3'";

            DataTable dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["CODE"].ToString();
            }
            return value;
        }
    }
}