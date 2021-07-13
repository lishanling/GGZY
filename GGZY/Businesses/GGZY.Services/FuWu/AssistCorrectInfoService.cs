using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AssistCorrectInfoService : BaseServiceT<ASSIST_CORRECT_INFO>
    {
        public GeneralResult GetTenderInfo()
        {
            var r = new GeneralResult();
            string sql = @"select * from (
select a.tender_project_code,b.bid_section_code,case when b.price_unit = '1' then b.contract_reckon_price else b.contract_reckon_price/10000 end OLD_SECTION_AMOUNT ,
case when g.price_unit = '1' then g.bid_amount else g.bid_amount/10000 end OLD_WIN_AMOUNT,c.EVALUATING_METHOD OLD_EVAL_METHOD ,c.m_att_tender_file,
  case when c.CONTROL_PRICE_UNIT = '1' then c.CONTROL_PRICE else CONTROL_PRICE/10000 end OLD_CONTROL_AMOUNT,
  a.m_id tender_mid,b.m_id section_mid,c.m_id file_mid,g.m_id win_mid ,h.m_id notice_id,a.create_time,a.tender_project_name
 from tender_project a 
left join section b on a.tender_project_code = b.tender_project_code
left join (select * from tender_file_clari_modi where (tender_project_code,m_tm) in (select tender_project_code,max(m_tm) from tender_file_clari_modi group by tender_project_code))
 c on a.tender_project_code = c.tender_project_code and b.bid_section_code = c.bid_section_code
 left join win_result_anno g on g.tender_project_code = a.tender_project_code  and g.bid_section_code like '%'||b.bid_section_code||'%'  
 left join (select * from tender_ann_qua_inquery_ann where (tender_project_code,m_tm) in (select tender_project_code,max(m_tm) from tender_ann_qua_inquery_ann where NOTICE_NATURE = '1' and BULLETIN_TYPE = '1' group by tender_project_code))
 h on a.tender_project_code = h.tender_project_code and h.bid_section_codes like '%'||b.bid_section_code||'%'  
 where c.m_att_tender_file is not null and a.create_time >= to_date('2020-1-1','yyyy-mm-dd')
 and a.tender_project_code not in (select tender_project_code from tender_abnormity_report)
 and (a.tender_project_code,b.bid_section_code) not in (select tender_project_code,bid_section_code from assist_correct_info)
and b.tender_project_classify_code like 'A08%'
 order by a.create_time
 )
 where rownum <=1";

            

            var tender = FromSql(sql).ToDataTable().ToDictionary();
            if (tender.Count > 0)
            {


                //获取附件信息
                string ids = tender[0]["M_ATT_TENDER_FILE"].ToString();
                var attachments =
                    FromWhere<T_ATTACHMENT>(T_ATTACHMENT._.ID.In(ids.Split(',')) &&
                                            (T_ATTACHMENT._.ATTACHMENT_TYPE == "pdf" ||
                                             T_ATTACHMENT._.ATTACHMENT_TYPE == "PDF"))
                        .OrderByDescending(T_ATTACHMENT._.CREATE_TIME).ToList();
                tender[0].Add("FILE_URL", attachments.Count > 0 ? attachments[0].ATTACHMENT_FILE_NAME : "");
                r.SetSuccess(tender[0]);
                return r;
            }
            r.SetFail("恭喜你全部纠正完毕！");
            return r;

        }
    }
}
