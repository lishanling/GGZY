using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using PullData.Model;

namespace GGZY.Services.JianDu
{
    public class PunishService : BaseServiceT<TENDER_LIST>
    {
        public BootstrapDataTableResult Check(string tenderCode, string tenderName, SearchCondition search)
        {
            WhereClipBuilder where = new WhereClipBuilder();
            if (!string.IsNullOrEmpty(tenderCode))
            {
                where.And(TENDER_PROJECT._.TENDER_PROJECT_CODE == tenderCode);
            }
            else if (!string.IsNullOrEmpty(tenderName))
            {
                where.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(tenderName));
            }
            else
            {
                return new BootstrapDataTableResult();
            }
            List<Field> cols = new List<Field>()
            {
                TENDER_PROJECT._.TENDERER_CODE,
                TENDER_PROJECT._.TENDER_PROJECT_NAME,
                TENDER_LIST._.BIDDER_NAME,
                TENDER_LIST._.BIDDER_ORG_CODE
            };
            var count = DbContext.Fw.From<TENDER_LIST>()
                .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .Where(where.ToWhereClip()).Select(cols.ToArray()).Count();
            var dt = DbContext.Fw.From<TENDER_LIST>()
                .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .Where(where.ToWhereClip()).Select(cols.ToArray()).Page(search.PageSize, search.PageNo).ToDataTable();
            dt.Columns.Add(new DataColumn("ISAT"));
            dt.Columns.Add(new DataColumn("NAMElIST"));
            dt.Columns.Add(new DataColumn("MEMO"));
            dt.Columns.Add(new DataColumn("CONTENT"));
            PullData.Main m = new PullData.Main();
            foreach (DataRow row in dt.Rows)
            {
                string bidderCode = row["BIDDER_ORG_CODE"].ToString();
                string bidderName = row["BIDDER_NAME"].ToString();
                PoorCreditResult cr = m.CheckOrg(bidderCode);
                string isAt = cr.Code == "00" ? "是" : "否";
                
                row["ISAT"] = isAt;
                row["CONTENT"] = cr.Content;
                row["MEMO"] = cr.Memo;
                row["NAMElIST"] = cr.NameList;
            }

            return dt.ToBootstrapTableList(count);
        }
    }
}
