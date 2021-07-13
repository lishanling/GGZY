using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Sms;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class SendMsgTableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "SendMsg";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //do nothing

        }

        public override void DoAfterSaveData(DataTable dtTitle, DataTable dtContext)
        {
            //新增的时候才发短信
            if (dtTitle.Rows[0]["DATA_TYPE"].ToString() == "1")
            {
                //todo 短信发送代码，待补充
                //获取发送短信的信息
                string sqlStr = @"SELECT a.TENDER_PROJECT_NAME,U.TELPHONE AS BAR,Q.TELPHONE AS BJR FROM TENDER_PROJECT a 
            INNER JOIN PROJECT B ON A.PROJECT_CODE=B.PROJECT_CODE
            INNER JOIN T_AFC_PROJECT C ON B.CONSTRUCTION_ID=C.CODE
            LEFT JOIN T_USER U ON A.M_CREATOR = U.ID  AND U.IS_SEND_MSG=1 and U.IS_ENABLE=1
            LEFT JOIN T_USER Q ON C.U_ID = Q.ID  AND U.IS_SEND_MSG=1 and U.IS_ENABLE=1
            WHERE TENDER_PROJECT_CODE_OLD1='" + dtContext.Rows[0]["TENDER_PROJECT_CODE"] + "'";
                DataTable dt = DAO.XZJD.GetDataSet(sqlStr).Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    return;
                }
                string BJR = dt.Rows[0]["BJR"].ToString();
                string BAR = dt.Rows[0]["BAR"].ToString();

                //发送短信
                if (BJR != "")
                {
                    string msg = string.Format("贵单位下的【{0}】，经系统检测已收到中标结果公示，请通知代理机构在15天内进行招投标情况书面报告备案。"
                        , dt.Rows[0]["TENDER_PROJECT_NAME"].ToString());
                    ISmsClass sms = new SmsChinaWJ("行政监督平台");
                    string json = sms.SendNoLimit(BJR, msg);
                }
                if (BAR != "")
                {
                    string msg = string.Format("贵单位提交的【{0}】，经系统检测已收到中标结果公示，请于15天内登录平台进行招投标情况书面报告备案。"
                        , dt.Rows[0]["TENDER_PROJECT_NAME"].ToString());
                    ISmsClass sms = new SmsChinaWJ("行政监督平台");
                    string json = sms.SendNoLimit(BAR, msg);
                }
            }

        }
    }
}