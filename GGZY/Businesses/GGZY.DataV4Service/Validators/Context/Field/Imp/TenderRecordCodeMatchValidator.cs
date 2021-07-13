using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class TenderRecordCodeMatchValidator : AbstractFieldValidator
    {
        public override string GetName()
        {
            return "TenderRecordCodeMatch";
        }
        public string ReviewType { get; set; }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {

            if (IfNotNull(dtTitle, dtContext))
            {
                string reviewCode = dtContext.GetStringValue(Field);
                string name = dtContext.GetStringValue("TENDER_PROJECT_NAME");
                ThrowHelper.ThrowIfTure(string.IsNullOrEmpty(reviewCode), "招标项目备案编号不能为空！");
                ThrowHelper.ThrowIfTure(string.IsNullOrEmpty(name), "招标项目名称不能为空！");
                if (reviewCode != "A999999999999999")
                {
                    //验证备案编号是否存在
                    string sql = $"select TENDER_PROJECT_CODE from RECORD_REVIEW  where REVIEW_CODE='{reviewCode}' and REVIEW_TYPE in ({ReviewType})";
                    //string sql = $"select TENDER_PROJECT_CODE from RECORD_REVIEW  where REVIEW_CODE='{reviewCode}' and REVIEW_TYPE  '%101%'";
                    DataTable dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                    //查询是否弄错了类型
                    if (dt.Rows.Count == 0)
                    {
                        sql = $"SELECT REVIEW_TYPE from RECORD_REVIEW  where REVIEW_CODE='{reviewCode}'";
                        DataTable typeDt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MT101,MZ101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为住建");
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MS101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为水利");
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MJ101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为交通");
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MY101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为海洋渔港");
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MG101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为工业");
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MX101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为信息化");
                        ThrowHelper.ThrowIfTure(typeDt.Rows.Count != 0 && "MN101".Contains(typeDt.Rows[0][0].ToString()), "已查询到该备案编号相关的备案数据，但该备案的招标项目类型为农业");
                    }
                    ThrowHelper.ThrowIfTure(dt.Rows.Count == 0, "未查询到该备案编号相关的备案数据");

                    //验证招标项目名称是否一致
                    sql = $"SELECT TENDER_PROJECT_NAME FROM TENDER_PROJECT WHERE TENDER_PROJECT_CODE IN (select TENDER_PROJECT_CODE from RECORD_REVIEW  where REVIEW_CODE='{reviewCode}' AND REVIEW_TYPE LIKE '%101%' )";
                    DataTable nameDt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                    bool isPass = false;
                    foreach (DataRow row in nameDt.Rows)
                    {
                        if (row[0].ToString().Equals(name))
                        {
                            isPass = true;
                        }
                    }
                    ThrowHelper.ThrowIfTure(!isPass, $"招标项目名称不一致，系统的中的招标项目名称为[{nameDt.Rows[0][0]}]");
                }

            }
        }

        public override string MockCorrectValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
