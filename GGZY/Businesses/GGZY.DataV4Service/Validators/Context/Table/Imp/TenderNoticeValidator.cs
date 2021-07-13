using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Exceptions;


namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class TenderNoticeValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "TenderNotcie";
        }
        public string TenderType { get; set; }
        public string Status { get; set; }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //厦门福州暂时先不验证
            string systemno = dtTitle.GetStringValue("DATA_KEY").Substring(0, 4);
            if ("0201,0202,0102,7100".Contains(systemno)) return;
            string tenderProjectCode = dtContext.GetStringValue("TENDER_PROJECT_CODE");
            //获取备案编号
            string sql = $"select tender_record_code from {TenderType}_tender_project where tender_project_code = '{tenderProjectCode}'";
            var dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
            ThrowHelper.ThrowIfTure(dt.Rows.Count == 0, $"无法查询到招标项目编号[{tenderProjectCode}]对应的备案编号");
            string code = dt.Rows[0][0].ToString();

            //获取备案状态
            if (code != "A999999999999999")
            {
                sql = $"select REVIEW_STATUS from record_review where review_code = '{code}'";
                dt = DataConfig.Dao.GetDataSet(sql).Tables[0];
                ThrowHelper.ThrowIfTure(dt.Rows.Count == 0, $"无法查询到备案编号[{code}]对应的备案记录");
                //获取状态的中文描述
                string status = dt.Rows[0][0].ToString();
                string statusName = "";
                if ("ZJ,XX,GY,YG".Contains(TenderType))
                {
                    statusName = ZJ_STATUS_DICT[status];
                    ThrowHelper.ThrowIfTure(status == "8", $"备案编号[{code}]的备案状态为[{statusName}]，但是招标代理还未提交招标文件备案，无法发布公告");

                }
                if ("SL,JT".Contains(TenderType))
                {
                    statusName = SL_STATUS_DICT[status];
                }
                ThrowHelper.ThrowIfTure(!Status.Contains(status), $"备案编号[{code}]的备案状态为[{statusName}]，无法发布公告");
            }
        }
        private Dictionary<string, string> ZJ_STATUS_DICT => new Dictionary<string, string>()
        {
            {"0","暂存" },
            {"1","未签收" },
            {"2","退回" },
            {"3","退回" },
            {"8","已签收" },
            {"4","待审核" },
            {"5","审核通过" },
            {"6","审核不通过" },
        };
        private Dictionary<string, string> SL_STATUS_DICT => new Dictionary<string, string>()
        {
            {"0","暂存" },
            {"1","待审查" },
            {"2","退回-不属于本部门监管的项目" },
            {"3","退回-备案材料不完整" },
            {"5","审查通过" },
            {"6","审查不通过" },
        };
    }
}
