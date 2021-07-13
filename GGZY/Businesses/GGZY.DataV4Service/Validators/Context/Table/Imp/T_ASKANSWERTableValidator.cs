using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class T_ASKANSWERTableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "T_ASKANSWER";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //质疑质询接口查询是否上传公告数据验证
//            var sql = "SELECT M_ID FROM TENDER_ANN_QUA_INQUERY_ANN WHERE TENDER_PROJECT_CODE='" 
//                + dtContext.GetStringValue("TENDER_PROJECT_CODE")
//                + "' AND to_char(BID_SECTION_CODES)='" 
//                + dtContext.GetStringValue("BID_SECTION_CODES") + "'";
//            DataTable dt = DAO.GGFW.GetDataSet(sql).Tables[0];
//            ThrowHelper.ThrowIfTure(dt.Rows.Count < 1, "未获取到相关公告信息");
          
        }

        public override void DoAfterSaveData(DataTable dtTitle, DataTable dtContext)
        {
            string RETURN = "";
            if (!string.IsNullOrEmpty(dtContext.GetStringValue("ANSWER")))
            {
                RETURN = "1";
            }
            else
            {
                RETURN = "0";
            }
            string UpSql = "UPDATE T_ASKANSWER SET IS_GS='1',TYPE='1',RETURN='" + RETURN 
                + $"' WHERE {DataConfig.M_KEY_Field}=" + dtTitle.GetStringValue(Constant.DATA_KEY);
            DAO.GGFW.ExecSql(UpSql);
        }
    }
}