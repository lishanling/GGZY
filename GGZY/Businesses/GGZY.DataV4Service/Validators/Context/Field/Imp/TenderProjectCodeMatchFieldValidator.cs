using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class TenderProjectCodeMatchFieldValidator : AbstractFieldValidator
    {
        public string TenderProjectTableName { get; set; }

        public override string GetName()
        {
            return "TenderProjectCodeMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                //专项数据上报需要到对应的招标项目表中进行验证
                if (string.IsNullOrEmpty(TenderProjectTableName))
                {
                    TenderProjectTableName = "TENDER_PROJECT";
                }
                string sql = $"select * from {TenderProjectTableName}  where " +
                             $"TENDER_PROJECT_CODE='{dtContext.GetStringValue(Field)}' ";

                DataTable dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                ThrowHelper.ThrowIfTure(dt.Rows.Count < 1, "招标项目数据未上报，请先上报");

                /*var version = dt.GetStringValue("M_VERSION");
                ThrowHelper.ThrowIfTure(!version.Equals(DataConfig.Version), "招标项目数据版本不正确");*/
            }

            //            string GetLogCode = string.Format(@"select * from T_TRANS_LOG where TENDER_PROJECT_CODE='{0}' and TYPE=2"
            //                , dtContext.Rows[0]["TENDER_PROJECT_CODE"].ToString());
            //
            //            DataTable ds = DAL.DAO.GetDataSet(GetLogCode).Tables[0];
            //            if (ds.Rows.Count > 0)
            //            {
            //                res["STATUS"] = "-1";
            //                res["MSG"] = "该招标项目是由专用数据集上报，请从专用数据集接口进行上报该项目其他表数据";
            //                return res;
            //            }
        }

        public override string MockCorrectValue(string value)
        {
            var uvValidator = new UniqueValueValidator();
            return uvValidator.GetTpCode(DataConfig.TableName);

        }
    }
}