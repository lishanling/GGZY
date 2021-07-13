using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.BigData.Model;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.BigData
{
    public class CorrelationService : BaseService
    {
        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }

        /// <summary>
        /// 获取共同投标排名前10的企业
        /// </summary>
        /// <param name="companyList"></param>
        /// <returns></returns>
        public GeneralResult GetBidderTop10(List<string> companyList)
        {
            var r = new GeneralResult();
            //找出与所选企业有过共同投标的标段编号
            List<string> sectionCodes = new List<string>();
            int i = 0;
            foreach (string s in companyList)
            {
                //第一个企业获取全部标段编号
                if (i == 0)
                {
                    sectionCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.BID_SECTION_CODE).ToList<string>();
                }
                else
                {
                    //遍历每个目标企业，得到他们的标段编号列表并做交集
                    List<string> tempSectionCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.BID_SECTION_CODE).ToList<string>();
                    sectionCodes = sectionCodes.Intersect(tempSectionCodes).ToList();
                }

                i++;
            }

            //找出标段包列表中的所有投标企业及其标段包号包括他自己
            var list = GetDbSession().From<TENDER_LIST>()
                .Where(CreateInWhere(TENDER_LIST._.BID_SECTION_CODE, sectionCodes, 999).And(TENDER_LIST._.BIDDER_NAME.NotIn(companyList)))
                .Select(TENDER_LIST._.BID_SECTION_CODE, TENDER_LIST._.BIDDER_NAME).ToList();

            //对得出的数据进行分组并取前十
            var group = list.GroupBy(e => e.BIDDER_NAME).OrderByDescending(e => e.Count());
            var result = group.Select(e => new
            {
                BIDDER_NAME = e.Key,
                COU = e.Count()
            }).Take(10).ToList();
            r.SetSuccess(result);
            return r;
        }
        /// <summary>
        /// 与目标投标人，同场次数排名前十的招标人
        /// </summary>
        /// <param name="companyList"></param>
        /// <returns></returns>
        public GeneralResult GetTendererTop10(List<string> companyList)
        {
            var r = new GeneralResult();
            //找出与所选企业有过共同投标的招标项目编号
            List<string> tenderCodes = new List<string>();
            int i = 0;
            foreach (string s in companyList)
            {
                //第一个企业获取全部招标项目编号
                if (i == 0)
                {
                    tenderCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.TENDER_PROJECT_CODE).ToList<string>();
                }
                else
                {
                    //遍历每个目标企业，得到他们的招标项目编号列表并做交集
                    List<string> tempTenderCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.TENDER_PROJECT_CODE).ToList<string>();
                    tenderCodes = tenderCodes.Intersect(tempTenderCodes).ToList();
                }

                i++;
            }

            //找出招标项目中的招标人
            var list = GetDbSession().From<TENDER_PROJECT>()
                .Where(CreateInWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE, tenderCodes, 999).And(TENDER_PROJECT._.TENDERER_NAME.IsNotNull()))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDERER_NAME).ToList();

            //对得出的数据进行分组并取前十
            var group = list.GroupBy(e => e.TENDERER_NAME).OrderByDescending(e => e.Count());
            var result = group.Select(e => new
            {
                TENDERER_NAME = e.Key,
                COU = e.Count()
            }).Take(10).ToList();
            r.SetSuccess(result);
            return r;
        }
        /// <summary>
        /// 与目标投标人，同场次数排名前十的代理机构
        /// </summary>
        /// <param name="companyList"></param>
        /// <returns></returns>
        public GeneralResult GetTenderAgentTop10(List<string> companyList)
        {
            var r = new GeneralResult();
            //找出与所选企业有过共同投标的招标项目编号
            List<string> tenderCodes = new List<string>();
            int i = 0;
            foreach (string s in companyList)
            {
                //第一个企业获取全部招标项目编号
                if (i == 0)
                {
                    tenderCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.TENDER_PROJECT_CODE).ToList<string>();
                }
                else
                {
                    //遍历每个目标企业，得到他们的招标项目编号列表并做交集
                    List<string> tempTenderCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.TENDER_PROJECT_CODE).ToList<string>();
                    tenderCodes = tenderCodes.Intersect(tempTenderCodes).ToList();
                }

                i++;
            }

            //找出招标项目中的招标代理
            var list = GetDbSession().From<TENDER_PROJECT>()
                .Where(CreateInWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE, tenderCodes, 999).And(TENDER_PROJECT._.TENDER_AGENCY_NAME.IsNotNull()))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDER_AGENCY_NAME).ToList();

            //对得出的数据进行分组并取前十
            var group = list.GroupBy(e => e.TENDER_AGENCY_NAME).OrderByDescending(e => e.Count());
            var result = group.Select(e => new
            {
                TENDER_AGENCY_NAME = e.Key,
                COU = e.Count()
            }).Take(10).ToList();
            r.SetSuccess(result);
            return r;
        }

        #region 旧代码
        /*public GeneralResult GetBidderTop10(List<string> companyList)
       {
           var r = new GeneralResult();
           List<string> dList = new List<string>();
           companyList.ForEach(e => dList.Add("'" + e + "'"));
           string where = "";
           for (int i = 1; i < companyList.Count; i++)
           {
               where +=
                   $" and bid_section_code in (select bid_section_code from tender_list where bidder_name = '{companyList[i]}')";
           }
           var sql = $@"select * from (
           select bidder_name, count(1) cou from tender_list where bid_section_code in (
               select bid_section_code from tender_list where bidder_name = '{companyList[0]}'
           {where}
               )
           group by bidder_name
               order by cou desc
               )
           where bidder_name not in ({string.Join(",", dList.ToArray())}) and  rownum <= {10 + companyList.Count}";
           var dt = GetDbSession().FromSql(sql).ToDataTable().ToDictionary();
           r.SetSuccess(dt);
           return r;
       }*/


        #endregion

        /// <summary>
        /// 获取相同mac地址的企业
        /// </summary>
        /// <param name="companyList"></param>
        /// <returns></returns>
        public GeneralResult GetTheSameMacFromBidders(List<string> companyList)
        {
            var r = new GeneralResult();
            //找出与所选企业有过共同投标的标段编号
            List<string> MACS = new List<string>();
            int i = 0;
            foreach (string s in companyList)
            {
                //第一个企业获取全部标段编号
                if (i == 0)
                {
                    MACS = GetDbSession().From<BD_HAREDWARE_RESULT>()
                        .Where(BD_HAREDWARE_RESULT._.BIDDER_NAME.In(companyList))
                        .Select(BD_HAREDWARE_RESULT._.MAC_ADDRESS).ToList<string>();
                }
                else
                {
                    //遍历每个目标企业，得到他们的标段编号列表并做交集
                    List<string> tempMacs = GetDbSession().From<BD_HAREDWARE_RESULT>()
                        .Where(BD_HAREDWARE_RESULT._.BIDDER_NAME.In(companyList))
                        .Select(BD_HAREDWARE_RESULT._.MAC_ADDRESS).ToList<string>();
                    MACS = MACS.Intersect(tempMacs).ToList();
                }

                i++;
            }

            //找出标段包列表中的所有投标企业及其标段包号包括他自己
            var list = GetDbSession().From<BD_HAREDWARE_RESULT>()
                .Where(BD_HAREDWARE_RESULT._.MAC_ADDRESS.In(MACS))
                .Select(BD_HAREDWARE_RESULT._.BIDDER_NAME, BD_HAREDWARE_RESULT._.MAC_ADDRESS).ToList();

            //对得出的数据进行分组并取前十
            var group = list.GroupBy(e => e.MAC_ADDRESS).OrderByDescending(e => e.Count());
            var result = group.Select(e => new
            {
                MAC_ADDRESS = e.Key,
                COU = e.Count()
            }).Take(10).ToList();
            r.SetSuccess(result);
            return r;
        }

        #region 旧代码
        /*public GeneralResult GetTheSameMacFromBidders(List<string> companyList)
        {
            var r = new GeneralResult();
            List<string> dList = new List<string>();
            companyList.ForEach(e => dList.Add("'" + e + "'"));

            string sql = $@"select tender_project_code,bidder_name,cpu_id,hard_disk_serial_number,mac_address,TENDER_DOC_SUBMITTIME from (
with temp as (
select tender_project_code,bidder_name,cpu_id,hard_disk_serial_number,mac_address,TENDER_DOC_SUBMITTIME from bid_doc_charact_code where bidder_name in 
({string.Join(",", dList.ToArray())}))                           
select a.tender_project_code,c.tender_project_name,a.bidder_name,a.cpu_id,a.hard_disk_serial_number,a.mac_address,a.TENDER_DOC_SUBMITTIME from temp a
inner JOIN TEMP B ON A.mac_address = B.mac_address and a.cpu_id = b.cpu_id and a.hard_disk_serial_number = b.hard_disk_serial_number AND A.bidder_name <> B.bidder_name and a.mac_address <> '无' and a.mac_address <> '/' and a.mac_address <> '暂无' and a.mac_address <> '-'
left join tender_project c on c.tender_project_code = a.tender_project_code
)
group by tender_project_code,bidder_name,cpu_id,hard_disk_serial_number,mac_address,TENDER_DOC_SUBMITTIME";
            var dt = GetDbSession().FromSql(sql).ToDataTable().ToDictionary();
            if (dt.Count > 0)
            {
                var group = dt.GroupBy(e => e["MAC_ADDRESS"].ToString()).ToList();
                r.SetSuccess(group);
            }
            else
            {
                r.SetFail("未查询出相关信息！");
            }

            return r;
        }*/

        #endregion



        /// <summary>
        /// 获取目标投标人所有投标项目
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetTenderListByBidderList(int pageIndex, int pageSize, List<string> companyList)
        {
            var r = new GeneralResult();
            //找出目标企业的所有投标项目
            var sectionCodes = GetDbSession().From<TENDER_LIST>()
                .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                .Select(TENDER_LIST._.BID_SECTION_CODE).ToList<string>();

            var dt = GetDbSession().From<TENDER_PROJECT>()
                .LeftJoin<SECTION>(TENDER_PROJECT._.TENDER_PROJECT_CODE == SECTION._.TENDER_PROJECT_CODE)
                .Where(CreateInWhere(SECTION._.BID_SECTION_CODE, sectionCodes, 999))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    SECTION._.BID_SECTION_CODE, SECTION._.BID_SECTION_NAME)
                .Page(pageSize, pageIndex)
                .ToDataTable();
            var count = GetDbSession().From<TENDER_PROJECT>()
                .LeftJoin<SECTION>(TENDER_PROJECT._.TENDER_PROJECT_CODE == SECTION._.TENDER_PROJECT_CODE)
                .Where(CreateInWhere(SECTION._.BID_SECTION_CODE, sectionCodes, 999))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDERER_NAME,
                    SECTION._.BID_SECTION_CODE, SECTION._.BID_SECTION_NAME).Count();

            r.SetSuccess(new
            {
                PageNo = pageIndex,
                PageSize = pageSize,
                PageTotal = (count + pageSize - 1) / pageSize,
                Total = count,
                Table = dt
            });

            return r;
        }
        /// <summary>
        /// 目标投标人所有中标项目
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetWinTenderListByBidderList(int pageIndex, int pageSize, List<string> companyList)
        {
            var r = new GeneralResult();
            //找出目标企业的所有中标项目
            var sectionCodes = GetDbSession().From<WIN_RESULT_ANNO>()
                .Where(WIN_RESULT_ANNO._.WIN_BIDDER_NAME.In(companyList))
                .Select(WIN_RESULT_ANNO._.BID_SECTION_CODE).ToList<string>();
            //获取项目信息
            var dt = GetDbSession().From<TENDER_PROJECT>()
                .LeftJoin<SECTION>(TENDER_PROJECT._.TENDER_PROJECT_CODE == SECTION._.TENDER_PROJECT_CODE)
                .Where(CreateInWhere(SECTION._.BID_SECTION_CODE, sectionCodes, 999))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    SECTION._.BID_SECTION_CODE, SECTION._.BID_SECTION_NAME)
                .Page(pageSize, pageIndex)
                .ToDataTable();
            var count = GetDbSession().From<TENDER_PROJECT>()
                .LeftJoin<SECTION>(TENDER_PROJECT._.TENDER_PROJECT_CODE == SECTION._.TENDER_PROJECT_CODE)
                .Where(CreateInWhere(SECTION._.BID_SECTION_CODE, sectionCodes, 999))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDERER_NAME,
                    SECTION._.BID_SECTION_CODE, SECTION._.BID_SECTION_NAME).Count();

            r.SetSuccess(new
            {
                PageNo = pageIndex,
                PageSize = pageSize,
                PageTotal = (count + pageSize - 1) / pageSize,
                Total = count,
                Table = dt
            });

            return r;
        }

        /// <summary>
        /// 目标投标人，同场的项目
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetTheSameTenderByBidderList(int pageIndex, int pageSize, List<string> companyList)
        {
            var r = new GeneralResult();
            //找出与所选企业有过共同投标的标段编号
            List<string> sectionCodes = new List<string>();
            int i = 0;
            foreach (string s in companyList)
            {
                //第一个企业获取全部标段编号
                if (i == 0)
                {
                    sectionCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.BID_SECTION_CODE).ToList<string>();
                }
                else
                {
                    //遍历每个目标企业，得到他们的标段编号列表并做交集
                    List<string> tempSectionCodes = GetDbSession().From<TENDER_LIST>()
                        .Where(TENDER_LIST._.BIDDER_NAME.In(companyList))
                        .Select(TENDER_LIST._.BID_SECTION_CODE).ToList<string>();
                    sectionCodes = sectionCodes.Intersect(tempSectionCodes).ToList();
                }

                i++;
            }
            var dt = GetDbSession().From<TENDER_PROJECT>()
                .LeftJoin<SECTION>(TENDER_PROJECT._.TENDER_PROJECT_CODE == SECTION._.TENDER_PROJECT_CODE)
                .Where(CreateInWhere(SECTION._.BID_SECTION_CODE, sectionCodes, 999))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    SECTION._.BID_SECTION_CODE, SECTION._.BID_SECTION_NAME)
                .Page(pageSize, pageIndex)
                .ToDataTable();
            var count = GetDbSession().From<TENDER_PROJECT>()
                .LeftJoin<SECTION>(TENDER_PROJECT._.TENDER_PROJECT_CODE == SECTION._.TENDER_PROJECT_CODE)
                .Where(CreateInWhere(SECTION._.BID_SECTION_CODE, sectionCodes, 999))
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDERER_NAME,
                    SECTION._.BID_SECTION_CODE, SECTION._.BID_SECTION_NAME).Count();

            r.SetSuccess(new
            {
                PageNo = pageIndex,
                PageSize = pageSize,
                PageTotal = (count + pageSize - 1) / pageSize,
                Total = count,
                Table = dt
            });

            return r;
        }
        /// <summary>
        /// 获取配置
        /// </summary>
        /// <param name="name"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public GeneralResult GetConfig(string name, int num)
        {
            var r = new GeneralResult();
            RedisCacheManager redis = new RedisCacheManager();
            List<CorrelationConfigModel> config = new List<CorrelationConfigModel>();
            if (redis.IsSet("CorrelationConfig"))
            {
                config = redis.Get<List<CorrelationConfigModel>>("CorrelationConfig");
            }
            else
            {
                var configPath =
                    $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\correlation.json";
                string json = File.ReadAllText(configPath);
                config = JsonConvert.DeserializeObject<List<CorrelationConfigModel>>(json);
                redis.Set("CorrelationConfig", configPath, 30);
            }

            var rule = config.FirstOrDefault(e => e.name == name);
            if (rule != null)
            {
                List<RuleModel> result = new List<RuleModel>();
                foreach (var ruleModel in rule.ruleList)
                {
                    switch (ruleModel.@operator)
                    {
                        case ">=":
                            if (num >= ruleModel.number) result.Add(ruleModel);
                            break;
                        case "=":
                            if (num == ruleModel.number) result.Add(ruleModel);
                            break;
                        case "<=":
                            if (num <= ruleModel.number) result.Add(ruleModel);
                            break;
                    }
                }
                r.SetSuccess(result);

            }
            else
            {
                r.SetFail("暂无数据");

            }

            return r;
        }
        /// <summary>
        /// 获取企业列表
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetTenderBidderList(int pageIndex, int pageSize, string name, string code)
        {
            var r = new GeneralResult();
            var w = new WhereClipBuilder();
            if (!string.IsNullOrEmpty(name))
            {
                w.And(BD_HAREDWARE_RESULT._.BIDDER_NAME.Contain(name));
            }
            if (!string.IsNullOrEmpty(code))
            {
                w.And(BD_HAREDWARE_RESULT._.BIDDER_ORG_CODE.Contain(code));
            }
            DataTable dt = GetDbSession().From<BD_HAREDWARE_RESULT>().Where(w.ToWhereClip())
                .Select(BD_HAREDWARE_RESULT._.BIDDER_NAME, BD_HAREDWARE_RESULT._.BIDDER_ORG_CODE)
                .Page(pageSize, pageIndex).ToDataTable();
            int count = GetDbSession().From<BD_HAREDWARE_RESULT>().Where(w.ToWhereClip())
                .Select(BD_HAREDWARE_RESULT._.BIDDER_NAME, BD_HAREDWARE_RESULT._.BIDDER_ORG_CODE).Count();
            r.SetSuccess(new
            {
                PageNo = pageIndex,
                PageSize = pageSize,
                PageTotal = (count + pageSize - 1) / pageSize,
                Total = count,
                Table = dt
            });
            return r;
        }

        private WhereClip CreateInWhere(Field field, List<string> paramList, int size)
        {

            //拆分参数
            if (paramList.Count >= size)
            {
                List<List<string>> tempList = new List<List<string>>();
                for (int i = 1; i <= (paramList.Count + size - 1) / size; i++)
                {
                    tempList.Add(paramList.Skip((i - 1) * size).Take(size).ToList());
                }
                //组建wherein
                WhereClipBuilder where = new WhereClipBuilder();
                foreach (List<string> list in tempList)
                {
                    where.Or(field.In(list));
                }

                return where.ToWhereClip();
            }
            else
            {
                return field.In(paramList);
            }
        }
    }
}
