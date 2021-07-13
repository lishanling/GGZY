using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.DZBH.ParamModel;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.DZBH
{
    public class DZBHService : BaseServiceT<BH_SEND_APPLICATION_FORM>
    {
        private string baseUrl = AppSettingUtils.GetString("baseUrl");
        private string FileServerUrl = AppSettingUtils.GetString("FileServerUrl");
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns></returns>
        public GeneralResult Add(BH_SEND_APPLICATION_FORM obj, string status, List<BH_ATTACHMENT> QUALFICATION_FILE, List<BH_ATTACHMENT> BUSINESS_LICENSE, List<BH_ATTACHMENT> TENDER_FILE, string orderPdfGuid)
        {
            GeneralResult res = new GeneralResult();
            obj.STATUS = status;
            int id = 0;
            //处理附件
            if (QUALFICATION_FILE != null && QUALFICATION_FILE.Count > 0 && QUALFICATION_FILE.First() != null)
            {
                if (!DbContext.Fw.Exists<BH_ATTACHMENT>(BH_ATTACHMENT._.ID == QUALFICATION_FILE.First().ID))
                {
                    DbContext.Fw.Insert(QUALFICATION_FILE.First());
                }
                obj.QUALFICATION_FILE_URL = QUALFICATION_FILE.First().URL;
                obj.QUALFICATION_FILE_MD5 = QUALFICATION_FILE.First().MD5;
                obj.QUALFICATION_FILE_AIDS = QUALFICATION_FILE.First().ID;
            }
            if (BUSINESS_LICENSE != null && BUSINESS_LICENSE.Count > 0 && BUSINESS_LICENSE.First() != null)
            {
                if (!DbContext.Fw.Exists<BH_ATTACHMENT>(BH_ATTACHMENT._.ID == BUSINESS_LICENSE.First().ID))
                    DbContext.Fw.Insert(BUSINESS_LICENSE.First());
                obj.BUSINESS_LICENSE_URL = BUSINESS_LICENSE.First().URL;
                obj.BUSINESS_LICENSE_MD5 = BUSINESS_LICENSE.First().MD5;
                obj.BUSINESS_LICENSE_AIDS = BUSINESS_LICENSE.First().ID;
            }
            if (TENDER_FILE != null && TENDER_FILE.Count > 0 && TENDER_FILE.First() != null)
            {
                if (!DbContext.Fw.Exists<BH_ATTACHMENT>(BH_ATTACHMENT._.ID == TENDER_FILE.First().ID))
                    DbContext.Fw.Insert(TENDER_FILE.First());
                obj.TENDER_FILE_URL = TENDER_FILE.First().URL;
                obj.TENDER_FILE_MD5 = TENDER_FILE.First().MD5;
                obj.TENDER_FILE_AIDS = TENDER_FILE.First().ID;
            }
            //保存订单号附件
            if (!string.IsNullOrEmpty(orderPdfGuid))
            {
                var aModel = DbContext.Fw.From<BH_SIGN_ATTACHMENT>().Where(BH_SIGN_ATTACHMENT._.GUID == orderPdfGuid).ToFirst();
                obj.ORDER_URL = aModel.SIGN_PDF_URL;
                obj.ORDER_AIDS = aModel.GUID;
                obj.ORDER_MD5 = aModel.SIGN_PDF_MD5;
            }
            if (obj.M_ID != 0)
            {
                obj.CREATE_TIME = DateTime.Now;
                Update(obj);
                id = obj.M_ID;
            }
            else
            {
                obj.USER_ID = FwUser.ID;
                //obj.USER_ID = -1;
                obj.ORDER_ID = CreateOrderId(obj.CITY_CODE);
                obj.M_DATA_KEY = Guid.NewGuid().ToString("N");
                obj.M_ID = 0;
                obj.CREATE_TIME = DateTime.Now;
                id = Insert(obj);
            }
            res.SetSuccess(new { obj.ORDER_ID, ID = id });
            //发送请求到承保系统
            if (status == "2")
            {
                SendToChengBao(id);
            }
            return res;
        }
        /// <summary>
        /// 返回列表
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult IndexList(SearchCondition search, string status)
        {
            GeneralResult res = new GeneralResult();
            var where = new WhereClipBuilder();
            if (status == "5")
            {
                where.And(BH_SEND_APPLICATION_FORM._.STATUS.NotIn("4", "10"));
            }
            else
            {
                where.And(BH_SEND_APPLICATION_FORM._.STATUS == status);
            }

            where.And(BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID);
            List<Field> cols = new List<Field>()
            {
                BH_SEND_APPLICATION_FORM._.M_ID,
                BH_SEND_APPLICATION_FORM._.STATUS,
                BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE,
                BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME,
                BH_SEND_APPLICATION_FORM._.SECTION_CODE,
                BH_SEND_APPLICATION_FORM._.SECTION_NAME,
                BH_SEND_APPLICATION_FORM._.ORDER_ID,
                BH_SEND_APPLICATION_FORM._.BID_OPEN_TIME,
                BH_SEND_APPLICATION_FORM._.BID_BOND,
                BH_SEND_APPLICATION_FORM._.CREATE_TIME,
                BH_GUARANTEE_RESULT._.CREATE_TIME.As("AUDIT_TIME"),
                BH_GUARANTEE_RESULT._.AUDIT_REMARK,
            };
            var total = Count(where);
            var list = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                .LeftJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                .Where(where.ToWhereClip())
                .Select(cols.ToArray())
                .Page(search.PageSize, search.PageNo)
                .OrderBy(BH_SEND_APPLICATION_FORM._.CREATE_TIME.Desc)
                .ToDataTable();
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (DataRow a in list.Rows)
            {
                var status_text = DictModel.StatusDict.GetValue(a["STATUS"].ToString());
                result.Add(new Dictionary<string, object>()
                {
                    {"M_ID",a["M_ID"] },
                    {"STATUS_TEXT",status_text },
                    {"STATUS",a["STATUS"] },
                    {"TENDER_PROJECT_CODE",a["TENDER_PROJECT_CODE"] },
                    {"TENDER_PROJECT_NAME",a["TENDER_PROJECT_NAME"] },
                    {"SECTION_CODE",a["SECTION_CODE"] },
                    {"SECTION_NAME",a["SECTION_NAME"] },
                    {"ORDER_ID",a["ORDER_ID"] },
                    {"BID_OPEN_TIME",a["BID_OPEN_TIME"] },
                    {"BID_BOND",a["BID_BOND"] },
                    {"CREATE_TIME",a["CREATE_TIME"] },
                    {"AUDIT_TIME",a["AUDIT_TIME"] },
                    {"AUDIT_REMARK",a["AUDIT_REMARK"] }
                });
            }
            res.SetSuccess(result.ToPageTableResult(search, total));
            return res;
        }
        /// <summary>
        /// 返回列表
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult List(ListSearchModel search)
        {
            GeneralResult res = new GeneralResult();
            var where = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.OrderId))
            {
                where.And(BH_SEND_APPLICATION_FORM._.ORDER_ID.Contain(search.OrderId));
            }
            if (!string.IsNullOrWhiteSpace(search.GuranteeNo))
            {
                where.And(BH_GUARANTEE_RESULT._.GUARANTEE_NO.Contain(search.GuranteeNo));
            }
            if (!string.IsNullOrWhiteSpace(search.TenderProjectCode))
            {
                where.And(BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE.Contain(search.TenderProjectCode));
            }
            if (!string.IsNullOrWhiteSpace(search.TenderProjectName))
            {
                where.And(BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME.Contain(search.TenderProjectName));
            }
            if (!string.IsNullOrWhiteSpace(search.SectionCode))
            {
                where.And(BH_SEND_APPLICATION_FORM._.SECTION_CODE.Contain(search.SectionCode));
            }
            if (!string.IsNullOrWhiteSpace(search.SectionName))
            {
                where.And(BH_SEND_APPLICATION_FORM._.SECTION_NAME.Contain(search.SectionName));
            }
            if (!string.IsNullOrWhiteSpace(search.Status))
            {
                where.And(BH_SEND_APPLICATION_FORM._.STATUS == search.Status);
            }
            else
            {
                if (!string.IsNullOrEmpty(search.Type) && search.Type != "0")
                {
                    switch (search.Type)
                    {
                        case "1":
                            where.And(BH_SEND_APPLICATION_FORM._.STATUS.In("1", "2", "3", "5", "6", "7", "8", "9"));
                            break;
                        case "2":
                            where.And(BH_SEND_APPLICATION_FORM._.STATUS.In("4"));
                            break;
                        case "3":
                            where.And(BH_SEND_APPLICATION_FORM._.STATUS.In("10"));
                            break;
                    }
                }
            }


            if (!DateTime.MinValue.Equals(search.StartOpenTime))
            {
                where.And(BH_SEND_APPLICATION_FORM._.BID_OPEN_TIME >= search.StartOpenTime);
            }
            if (!DateTime.MinValue.Equals(search.EndOpenTime))
            {
                where.And(BH_SEND_APPLICATION_FORM._.BID_OPEN_TIME < search.EndOpenTime);
            }

            where.And(BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID);
            List<Field> cols = new List<Field>()
            {
                BH_SEND_APPLICATION_FORM._.M_ID,
                BH_SEND_APPLICATION_FORM._.STATUS,
                BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE,
                BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME,
                BH_SEND_APPLICATION_FORM._.SECTION_CODE,
                BH_SEND_APPLICATION_FORM._.SECTION_NAME,
                BH_SEND_APPLICATION_FORM._.ORDER_ID,
                BH_SEND_APPLICATION_FORM._.BID_OPEN_TIME,
                BH_SEND_APPLICATION_FORM._.BID_BOND,
                BH_SEND_APPLICATION_FORM._.CREATE_TIME,
                BH_GUARANTEE_RESULT._.CREATE_TIME.As("AUDIT_TIME"),
                BH_GUARANTEE_RESULT._.AUDIT_REMARK,
                BH_GUARANTEE_RESULT._.GUARANTEE_NO,
                BH_GUARANTEE_RESULT._.GUARANTEE_PDF_URL,
            };
            //Logger.Debug("开始获取数据");
            var total = Count(where);
            var list = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                .LeftJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                .Where(where.ToWhereClip())
                .Select(cols.ToArray())
                .Page(search.PageSize, search.PageNo)
                .OrderBy(BH_SEND_APPLICATION_FORM._.CREATE_TIME.Desc)
                .ToDataTable();
            //Logger.Debug("开始组装数据");
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (DataRow a in list.Rows)
            {
                var status = DictModel.StatusDict.GetValue(a["STATUS"].ToString());
                result.Add(new Dictionary<string, object>()
                {
                    {"M_ID",a["M_ID"] },
                    {"STATUS_TEXT",status },
                    {"STATUS",a["STATUS"] },
                    {"TENDER_PROJECT_CODE",a["TENDER_PROJECT_CODE"] },
                    {"TENDER_PROJECT_NAME",a["TENDER_PROJECT_NAME"] },
                    {"SECTION_CODE",a["SECTION_CODE"] },
                    {"SECTION_NAME",a["SECTION_NAME"] },
                    {"ORDER_ID",a["ORDER_ID"] },
                    {"BID_OPEN_TIME",a["BID_OPEN_TIME"] },
                    {"BID_BOND",a["BID_BOND"] },
                    {"CREATE_TIME",a["CREATE_TIME"] },
                    {"AUDIT_TIME",a["AUDIT_TIME"] },
                    {"AUDIT_REMARK",a["AUDIT_REMARK"] },
                    {"GUARANTEE_NO",a["GUARANTEE_NO"] },
                    {"GUARANTEE_PDF_URL",a["GUARANTEE_PDF_URL"] },
                });
            }
            //Logger.Debug("数据组装完成");
            res.SetSuccess(result.ToPageTableResult(search, total));
            return res;
        }

        /// <summary>
        /// 获取系统详细信息
        /// </summary>
        /// <param name="systemNo"></param>
        /// <returns></returns>
        public GeneralResult GetSystemInfo(string systemNo)
        {
            GeneralResult res = new GeneralResult();
            var obj = DbContext.Fw.From<BH_JIEKOU_USER>().Where(BH_JIEKOU_USER._.SYSTEM_NO == systemNo).First();
            res.SetSuccess(new
            {
                GUARANTOR_CREDIT_CODE = obj.SYSTEM_CREDIT_CODE,
                GUARANTOR_NAME = obj.NAME,
                GUARANTOR_CONTACT_NAME = obj.SYSTEM_CONTACT_NAME,
                GUARANTOR_CONTACT_TEL = obj.SYSTEM_CONTACT_TEL,
                SYSTEM_NO = obj.SYSTEM_NO,
            });
            return res;
        }
        /// <summary>
        /// 根据招标项目编号获取详细信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public GeneralResult GetTenderProjectInfo(string code)
        {
            GeneralResult res = new GeneralResult();
            string sql =
                @"select a.m_id id,c.INVEST_PROJECT_CODE,d.VALID_PERIOD,c.APPROVAL_NUMBER APPROVAL_CODE,b.TENDER_PROJECT_CODE,b.TENDER_PROJECT_NAME,a.bid_section_code SECTION_CODE,A.BID_SECTION_NAME SECTION_NAME,nvl(case when price_unit = '1' then  a.CONTRACT_RECKON_PRICE* 10000 else a.CONTRACT_RECKON_PRICE  end,0) CONTRACT_RECKON_PRICE,
b.TENDERER_NAME TENDERER,b.TENDERER_CODE TENDERER_CREDIT_CODE,b.REGION_CODE CITY_CODE,replace(b.TENDER_PROJECT_TYPE,'G','A') TENDER_PROJECT_TYPE,d.BID_OPEN_TIME, d.BID_OPEN_TIME SERVICE_BEGIN_TIME, case when d.bid_open_time is null then d.bid_open_time else d.bid_open_time + 28 end SERVICE_END_TIME,
nvl(case when d.MARGIN_AMOUNT_UNIT = '1' then d.MARGIN_AMOUNT * 10000 else d.MARGIN_AMOUNT end,0) BID_BOND,a.data_timestamp  timestamp ,(g.sheng || g.shi) city_name,e.TENDERER_CONTACTOR TENDERER_CONTACT,e.TENDERER_PHONE_NUMBER TENDERER_CONTACT_TEL 
from section a
left join tender_project b on a.tender_project_code = b.tender_project_code
left join project c on b.project_code = c.project_code
left join (select tender_project_code,MARGIN_AMOUNT_UNIT,MARGIN_AMOUNT,BID_OPEN_TIME,VALID_PERIOD from tender_file_clari_modi group by tender_project_code,MARGIN_AMOUNT_UNIT,MARGIN_AMOUNT,BID_OPEN_TIME,VALID_PERIOD) d on b.tender_project_code = d.tender_project_code
left join (select tender_project_code,TENDERER_CONTACTOR,TENDERER_PHONE_NUMBER from tender_ann_qua_inquery_ann 
where (tender_project_code,notice_send_time) in (select tender_project_code,max(notice_send_time) from tender_ann_qua_inquery_ann group by tender_project_code)) e on b.tender_project_code = e.tender_project_code
left join sys_area_quanguo g on c.REGION_CODE = g.AREACODE "
                + $" where a.tender_project_code = '{code.ToClearSql()}'";
            var dt = DbContext.Fw.FromSql(sql).ToDataTable().ToDictionary();
            if (dt.Count > 0)
            {
                foreach (Dictionary<string, object> dict in dt)
                {
                    var cityCode = dict["CITY_CODE"].ToString();
                    if (cityCode == "350128")
                    {
                        dict.Add("CITY_CODE_", "350000,350128");
                    }
                    else
                    {
                        dict.Add("CITY_CODE_", cityCode.EndsWith("00") ? $"350000,{cityCode},{cityCode.Substring(0, 4)}01" : $"350000,{cityCode.Substring(0, 4)}00,{cityCode}");
                    }

                }
                res.SetSuccess(dt);
            }
            else
            {
                res.SetFail("招标项目信息不存在");
            }

            return res;
        }
        /// <summary>
        /// 智能搜索
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public GeneralResult GetAutoTenderProjectName(string key)
        {
            GeneralResult res = new GeneralResult();
            string where = $" and a.tender_project_name like '%{key.ToClearSql()}%'";
            string sql = @"select * from (
select a.tender_project_code,a.tender_project_name from tender_project a
left join (
select tender_project_code,BID_OPEN_TIME from tender_ann_qua_inquery_ann c where  c.notice_send_time = (select max(notice_send_time) from tender_ann_qua_inquery_ann where tender_project_code = c.tender_project_code group by tender_project_code)
) b
on a.tender_project_code = b.tender_project_code
where b.bid_open_time > sysdate" + where + @"
order by b.bid_open_time
)
where rownum <=10";
            DataTable dt = DbContext.Fw.FromSql(sql).ToDataTable();
            var dict = new List<object>();
            foreach (DataRow row in dt.Rows)
            {
                dict.Add(new
                {
                    Lable = row[1],
                    Value = row[0]
                });
            }
            res.SetSuccess(dict);

            return res;
        }
        /// <summary>
        /// 电子保函订单号验证
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        /*public GeneralResult CheckOrder(string OrderId, string CheckType)
        {
            GeneralResult res = new GeneralResult();
            string resut = "";
            if (CheckType == "1")
            {
                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                    .Select(BH_SEND_APPLICATION_FORM._.ORDER_ID, BH_GUARANTEE_RESULT._.GUARANTEE_NO, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME)
                    .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID == OrderId).ToDataTable().ToDictionary().FirstOrDefault();
                resut = obj != null ? $"系统存在订单编号为{OrderId}的电子保函信息，其电子保函编号为{obj["GUARANTEE_NO"]}，运用的招标项目为({obj["TENDER_PROJECT_NAME"]})、招标项目编号：（{obj["TENDER_PROJECT_CODE"]}）" : $"系统不存在订单编号为{OrderId}的电子保函信息";
            }
            else
            {
                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                    .Select(BH_SEND_APPLICATION_FORM._.ORDER_ID, BH_GUARANTEE_RESULT._.GUARANTEE_NO, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE)
                    .Where(BH_GUARANTEE_RESULT._.GUARANTEE_NO == OrderId).ToDataTable().ToDict();
                resut = obj != null ? $"系统存在电子保函编号为{OrderId}的电子保函信息，其订单编号为{obj["ORDER_ID"]}，运用的招标项目为({obj["TENDER_PROJECT_NAME"]})、招标项目编号：（{obj["TENDER_PROJECT_CODE"]}）" : $"系统不存在电子保函编号为{OrderId}的电子保函信息";
            }
            res.SetSuccess(new { STATUS = resut });
            return res;

        }*/
        public GeneralResult CheckOrder(string OrderId, string CheckType)
        {
            GeneralResult res = new GeneralResult();
            object result;
            if (CheckType == "1")
            {
                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                    .Select(BH_SEND_APPLICATION_FORM._.ORDER_ID, BH_GUARANTEE_RESULT._.GUARANTEE_NO, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME)
                    .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID == OrderId).ToDataTable().ToDictionary().FirstOrDefault();
                if (obj != null)
                {
                    result = new
                    {
                        STATUS = 1,
                        ORDER_ID = OrderId,
                        GUARANTEE_NO = obj["GUARANTEE_NO"],
                        TENDER_PROJECT_NAME = obj["TENDER_PROJECT_NAME"],
                        TENDER_PROJECT_CODE = obj["TENDER_PROJECT_CODE"],
                    };
                }
                else
                {
                    result = new
                    {
                        STATUS = 0,
                        ORDER_ID = OrderId,
                        GUARANTEE_NO = "",
                        TENDER_PROJECT_NAME = "",
                        TENDER_PROJECT_CODE = "",
                    };
                }
            }
            else
            {
                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                    .Select(BH_SEND_APPLICATION_FORM._.ORDER_ID, BH_GUARANTEE_RESULT._.GUARANTEE_NO, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE, BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME)
                    .Where(BH_GUARANTEE_RESULT._.GUARANTEE_NO == OrderId).ToDataTable().ToDictionary().FirstOrDefault();
                if (obj != null)
                {
                    result = new
                    {
                        STATUS = 1,
                        ORDER_ID = obj["ORDER_ID"],
                        GUARANTEE_NO = OrderId,
                        TENDER_PROJECT_NAME = obj["TENDER_PROJECT_NAME"],
                        TENDER_PROJECT_CODE = obj["TENDER_PROJECT_CODE"],
                    };
                }
                else
                {
                    result = new
                    {
                        STATUS = 0,
                        ORDER_ID = "",
                        GUARANTEE_NO = OrderId,
                        TENDER_PROJECT_NAME = "",
                        TENDER_PROJECT_CODE = "",
                    };
                }
            }
            res.SetSuccess(result);
            return res;

        }

        public GeneralResult GetChengBaoTree(string regionCode)
        {
            //todo：根据行政区划进行判断显示哪些金融机构，现在只有三明
            string regionCn = "";
            if (regionCode.Contains("3504"))
            {
                regionCn = "三明市";
            }
            GeneralResult res = new GeneralResult();
            var list = DbContext.Fw.From<BH_JIEKOU_USER>().Where(BH_JIEKOU_USER._.TYPE == "1" && BH_JIEKOU_USER._.REGION == regionCn).ToList();
            //第一级获取地区
            var first = list.GroupBy(e => e.REGION)
                .OrderBy(e => e.Min(a => a.ORDERBY)).Select(e =>
                    new Dictionary<string, object>()
                    {
                        {"label", e.Key},
                        {"value", e.Key},
                    }).ToList();
            //生成第二级交易中心名称
            foreach (var user in first)
            {
                string region = user["value"].ToString();
                List<Dictionary<string, object>> second = new List<Dictionary<string, object>>();
                //添加子交易中心
                second.AddRange(list.Where(e => e.REGION == region).GroupBy(e => e.CENTER_NAME)
                    .OrderBy(e => e.Min(a => a.ORDERBY)).Select(e =>
                        new Dictionary<string, object>()
                        {
                            {"label", e.Key},
                            {"value", e.Key},
                        }).ToList());
                //第三级生成行业
                foreach (var industry in second)
                {
                    string thirdCenterName = industry["value"].ToString();
                    var third = list.Where(e => e.CENTER_NAME == thirdCenterName && e.REGION == region).GroupBy(e => e.INDUSTRY_NAME)
                        .OrderBy(e => e.Min(a => a.ORDERBY)).Select(e =>
                        new Dictionary<string, object>()
                        {
                            {"label", e.Key},
                            {"value", e.Key},
                        }).ToList();
                    //第四级生成承保机构
                    foreach (var chengbao in third)
                    {
                        string industryName = chengbao["value"].ToString();
                        var fourth = list.Where(e => e.INDUSTRY_NAME == industryName && e.CENTER_NAME == thirdCenterName && e.REGION == region).OrderBy(e => e.ORDERBY).Select(
                            e =>
                                new Dictionary<string, object>()
                                {
                                    {"label", e.SHOW_NAME},
                                    {"value", e.SYSTEM_NO},
                                }).ToList();
                        chengbao.Add("children", fourth);
                    }
                    industry.Add("children", third);
                }
                user.Add("children", second);
            }
            res.SetSuccess(first);
            return res;
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(int ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(BH_SEND_APPLICATION_FORM._.M_ID == ID);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                //添加附件
                Dictionary<string, object> dict = dbModel.ToDict();
                dict.Add("QUALFICATION_FILE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == dbModel.QUALFICATION_FILE_AIDS).ToList().ToBhAttachments());
                dict.Add("BUSINESS_LICENSE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == dbModel.BUSINESS_LICENSE_AIDS).ToList().ToBhAttachments());
                dict.Add("TENDER_FILE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == dbModel.TENDER_FILE_AIDS).ToList().ToBhAttachments());
                //填保函文件和申请单文件
                var attachment = DbContext.Fw.From<BH_SIGN_ATTACHMENT>()
                    .Where(BH_SIGN_ATTACHMENT._.GUID == dbModel.SIGN_GUID).ToFirst();
                string sqdUrl = attachment != null ? "/bh" + attachment.SIGN_PDF_URL : "";
                dict.Add("SQD_URL", sqdUrl);

                var jieguo = DbContext.Fw.From<BH_GUARANTEE_RESULT>()
                    .Where(BH_GUARANTEE_RESULT._.ORDER_ID == dbModel.ORDER_ID).ToFirst();
                //构建电子保函文件url
                string dzbhUrl = "";
                if (jieguo != null && !string.IsNullOrEmpty(jieguo.GUARANTEE_URL))
                {
                    dzbhUrl = $"/bh/adminv/#/fileAnalysis?orderId={dbModel.ORDER_ID}";
                }
                else if (jieguo != null)
                {
                    dzbhUrl =
                         string.IsNullOrEmpty(jieguo.GUARANTEE_PDF_URL) ? jieguo.GUARANTEE_PDF_URL : "";

                }

                string auditRemark = jieguo != null ? jieguo.AUDIT_REMARK : "";
                string auditTime = jieguo != null ? jieguo.CREATE_TIME.ToString("yyyy-MM-dd HH:mm:ss") : "";
                //dict.Add("DZBH_URL", dzbhUrl);
                dict.Add("DZBH_URL", jieguo?.GUARANTEE_URL);
                dict.Add("AUDIT_REMARK", auditRemark);
                dict.Add("AUDIT_TIME", auditTime);

                result.SetSuccess(dict);
            }
            return result;
        }

        public GeneralResult GetIndexCount()
        {
            var r = new GeneralResult();
            var where = new WhereClipBuilder();
            where.And(BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID);
            var dt = DbContext.Fw.From<BH_GUARANTEE_RESULT>()
                .InnerJoin<BH_SEND_APPLICATION_FORM>(BH_SEND_APPLICATION_FORM._.ORDER_ID ==
                                                     BH_GUARANTEE_RESULT._.ORDER_ID).Where(where.ToWhereClip()).Select(
                    BH_GUARANTEE_RESULT._.ID.Count().As("LeiJiCount"),
                    BH_GUARANTEE_RESULT._.AMOUNT.Sum().As("LeiJiSum")).ToDataTable();
            var nowMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            where.And((BH_SEND_APPLICATION_FORM._.CREATE_TIME >= nowMonth).And(BH_GUARANTEE_RESULT._.CREATE_TIME < nowMonth.AddMonths(1)));
            var dt1 = DbContext.Fw.From<BH_GUARANTEE_RESULT>()
                .InnerJoin<BH_SEND_APPLICATION_FORM>(BH_SEND_APPLICATION_FORM._.ORDER_ID ==
                                                     BH_GUARANTEE_RESULT._.ORDER_ID).Where(where.ToWhereClip()).Select(
                    BH_GUARANTEE_RESULT._.ID.Count().As("MonthCount"),
                    BH_GUARANTEE_RESULT._.AMOUNT.Sum().As("MonthSum")).ToDataTable();
            //计算今日保函情况
            DateTime today = DateTime.Now.Date;
            DateTime todayEnd = today.AddDays(1);
            //审核通过
            int pass = DbContext.Fw.From<BH_GUARANTEE_RESULT>().InnerJoin<BH_SEND_APPLICATION_FORM>(BH_GUARANTEE_RESULT._.ORDER_ID == BH_SEND_APPLICATION_FORM._.ORDER_ID)
                .Where(BH_GUARANTEE_RESULT._.CREATE_TIME >= today && BH_GUARANTEE_RESULT._.CREATE_TIME < todayEnd &&
                BH_GUARANTEE_RESULT._.AUDIT_TYPE == "1" && BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID).Count();
            //待审核
            int check = DbContext.Fw.Count<BH_SEND_APPLICATION_FORM>(
                BH_SEND_APPLICATION_FORM._.CREATE_TIME >= today && BH_SEND_APPLICATION_FORM._.CREATE_TIME < todayEnd &&
                BH_SEND_APPLICATION_FORM._.STATUS == "2" && BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID);
            //待支付
            int toBePay = DbContext.Fw.Count<BH_SEND_APPLICATION_FORM>(
                BH_SEND_APPLICATION_FORM._.CREATE_TIME >= today && BH_SEND_APPLICATION_FORM._.CREATE_TIME < todayEnd &&
                BH_SEND_APPLICATION_FORM._.STATUS == "3" && BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID);
            //退回
            int back = DbContext.Fw.From<BH_GUARANTEE_RESULT>().InnerJoin<BH_SEND_APPLICATION_FORM>(BH_GUARANTEE_RESULT._.ORDER_ID == BH_SEND_APPLICATION_FORM._.ORDER_ID)
                .Where(BH_GUARANTEE_RESULT._.CREATE_TIME >= today && BH_GUARANTEE_RESULT._.CREATE_TIME < todayEnd &&
                       BH_GUARANTEE_RESULT._.AUDIT_TYPE == "0" && BH_SEND_APPLICATION_FORM._.USER_ID == FwUser.ID).Count();

            r.SetSuccess(new
            {
                MonthCount = dt1.Rows[0]["MonthCount"] ?? 0,
                MonthSum = !string.IsNullOrEmpty(dt1.Rows[0]["MonthSum"].ToString()) ? dt1.Rows[0]["MonthSum"] : 0,
                LeiJiCount = dt.Rows[0]["LeiJiCount"] ?? 0,
                LeiJiSum = !string.IsNullOrEmpty(dt.Rows[0]["LeiJiSum"].ToString()) ? dt.Rows[0]["LeiJiSum"] : 0,
                todayData = new
                {
                    pass,
                    check,
                    toBePay,
                    back
                }
            });
            return r;
        }
        /// <summary>
        /// 获取项目类型字典
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetProjectType()
        {
            var result = new GeneralResult();
            List<Dictionary<string, string>> dict = new List<Dictionary<string, string>>();
            foreach (var type in DictModel.ProjectTypeDict)
            {
                dict.Add(new Dictionary<string, string>()
                {
                    {"value",type.Key },
                    {"label",type.Value },
                });
            }
            result.SetSuccess(dict);
            return result;
        }
        /// <summary>
        /// 创建订单号
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public string CreateOrderId(string regionCode)
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            var numObj = DbContext.Fw.From<BH_ORDERID_NUM>().Where(BH_ORDERID_NUM._.THISDATE == date).First();
            int num = numObj?.THISNUM + 1 ?? 1;
            //已存在则修改，不存在则插入
            if (numObj != null)
            {
                numObj.THISNUM = num;
                DbContext.Fw.Update(numObj);
            }
            else
            {
                DbContext.Fw.Insert<BH_ORDERID_NUM>(new BH_ORDERID_NUM
                {
                    GUID = Guid.NewGuid().ToString(),
                    THISDATE = date,
                    THISNUM = num
                });
            }
            return $"FJ{regionCode}{date}{num.ToString().PadLeft(6, '0')}";
        }
        //发送信息到承保机构
        public string SendToChengBao(int formId)
        {
            string result = "";
            try
            {
                var model = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>().Where(BH_SEND_APPLICATION_FORM._.M_ID == formId)
                .ToFirst();
                if (model != null)
                {
                    Logger.Debug($"[{model.ORDER_ID}]取到数据开始处理发送信息");
                    //要发送的字段
                    List<string> cols = new List<string>()
                {
                    "ORDER_ID", "APPROVAL_CODE", "TENDER_PROJECT_CODE", "TENDER_PROJECT_NAME", "SECTION_CODE",
                    "SECTION_NAME", "CONTRACT_RECKON_PRICE", "TENDERER", "TENDERER_CREDIT_CODE", "TENDERER_BANK_CODE",
                    "TENDERER_BANK_OPENBANK", "CITY_CODE", "TENDER_PROJECT_TYPE", "BID_OPEN_TIME", "BID_BOND",
                    "GUARANTOR_NAME", "GUARANTOR_CREDIT_CODE", "GUARANTOR_CONTACT_NAME", "GUARANTOR_CONTACT_TEL",
                    "BIDDER_NAME",
                    "BIDDER_CREDIT_CODE", "BIDDER_CONTACT_NAME", "BIDDER_CONTACT_TEL", "BIDDER_ADDRESS", "BIDDER_EAMIL",
                    "BIDDER_TAXPAYER_CODE", "LEGAL_PERSON_NAME", "LEGAL_PERSON_IDCARD", "LEGAL_PERSON_TEL", "ORDER_URL",
                    "ORDER_MD5", "TENDER_FILE_URL", "TENDER_FILE_MD5", "QUALFICATION_FILE_URL", "QUALFICATION_FILE_MD5",
                    "BUSINESS_LICENSE_URL", "BUSINESS_LICENSE_MD5", "SECRET","LEGAL_PERSON_IDCARD_TYPE","TENDERER_BANK_ACCOUNT",
                    "TENDERER_CONTACT","TENDERER_CONTACT_TEL","VALID_PERIOD","INVEST_PROJECT_CODE","TENDERER_CONTACT_TEL","TENDERER_CONTACT",
                    "TENDERER_BANK_ACCOUNT","BIDDER_CONTACT_IDCARD","BIDDER_CONTACT_IDCARD_TYPE"
                };
                    //组建附件字段
                    var attachment = DbContext.Fw.From<BH_SIGN_ATTACHMENT>()
                        .Where(BH_SIGN_ATTACHMENT._.GUID == model.SIGN_GUID).ToFirst();
                    string appBaseUrl = AppDomain.CurrentDomain.BaseDirectory;
                    if (attachment != null)
                    {
                        /*string sourceUrl = appBaseUrl + attachment.SIGN_PDF_URL;
                        string encrptyUrl = appBaseUrl + "/File/SIGN/SQD/ENCRPPTY/" + DateTime.Now.ToString("yyyyMMdd") + "/";
                        if (!Directory.Exists(encrptyUrl))
                        {
                            Directory.CreateDirectory(encrptyUrl);
                        }
                        string encrptyFile = encrptyUrl + attachment.SIGN_PDF_FILENAME;
                        string key = Guid.NewGuid().ToString("N");//密钥
                        Logger.Debug($"[{model.ORDER_ID}]加密文件的密钥为{key}");
                        string xinfeng = TokenHelper.EncryptFile(sourceUrl, encrptyFile, key);*/

                        //model.ORDER_URL = baseUrl + encrptyFile.TrimStart(appBaseUrl.ToCharArray());
                        model.ORDER_URL = baseUrl + attachment.SIGN_PDF_URL;
                        model.ORDER_MD5 = attachment.SIGN_PDF_MD5;
                        //model.SECRET = xinfeng;
                        model.SECRET = "";
                    }

                    model.TENDER_FILE_URL = FileServerUrl + model.TENDER_FILE_URL;
                    model.QUALFICATION_FILE_URL = FileServerUrl + model.QUALFICATION_FILE_URL;
                    model.BUSINESS_LICENSE_URL = FileServerUrl + model.BUSINESS_LICENSE_URL;
                    var system = DbContext.Fw.From<BH_JIEKOU_USER>().Where(BH_JIEKOU_USER._.SYSTEM_NO == model.SYSTEM_NO)
                        .ToFirst();
                    if (system != null)
                    {
                        Logger.Debug($"[{model.ORDER_ID}]开始发送数据");
                        DateTime now = DateTime.Now;
                        string dataKey = Guid.NewGuid().ToString("N");
                        var send = new BhSendService<BH_SEND_APPLICATION_FORM>(system.SEND_URL, model.SYSTEM_NO, system.SECRET, now.ToString("yyyyMMddHHmmss"), dataKey, model, cols);
                        result = send.Send();
                        //处理返回的信息
                        Logger.Debug($"申请单保险公司返回数据1：result={result}");
                        var resDt = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
                        var status = resDt["STATUS"].ToString();
                        Logger.Debug($"申请单保险公司返回数据：STATUS={status}");
                        if (status == "1")
                        {
                            var resData = resDt["DATA"].ToString();
                            var dataDt = JsonConvert.DeserializeObject<Dictionary<string, object>>(resData);
                            var url = dataDt["URL"].ToString();
                            var orderid = dataDt["ORDER_ID"].ToString();
                            Logger.Debug($"申请单保险公司返回数据：ORDER_ID={orderid}");
                            DbContext.Fw.Update<BH_SEND_APPLICATION_FORM>(BH_SEND_APPLICATION_FORM._.RECEIVE_URL, url,
                                BH_SEND_APPLICATION_FORM._.M_ID == formId);
                            Logger.Debug($"[{model.ORDER_ID}]完成");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Logger.Error($"{formId}发送数据失败", e);
                throw;
            }

            return result;

        }
        /// <summary>
        /// 跳转到承保机构
        /// </summary>
        /// <returns></returns>
        public string JumpToChengBao(int id, out string sendResult)
        {
            sendResult = "";
            var model = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>().Where(BH_SEND_APPLICATION_FORM._.M_ID == id)
                .ToFirst();
            if (model != null && !string.IsNullOrEmpty(model.RECEIVE_URL))
            {
                string time = DateTime.Now.ToString("yyyyMMddHHmmss");
                var url = $"{model.RECEIVE_URL}&time={time}";
                var jiekou = DbContext.Fw.From<BH_JIEKOU_USER>().Where(BH_JIEKOU_USER._.SYSTEM_NO == model.SYSTEM_NO).ToFirst();
                if (jiekou == null || string.IsNullOrEmpty(jiekou.SECRET))
                {
                    return "未找到正确信息";
                }

                string token = TokenHelper.CreateToken(url, jiekou.SECRET);
                return $"{url}&token={token}";

            }
            else if (string.IsNullOrEmpty(model.RECEIVE_URL))
            {
                sendResult = SendToChengBao(id);
                //再次重新获取并跳转
                var model1 = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>().Where(BH_SEND_APPLICATION_FORM._.M_ID == id)
                    .ToFirst();
                if (model1 != null && !string.IsNullOrEmpty(model1.RECEIVE_URL))
                {
                    string time = DateTime.Now.ToString("yyyyMMddHHmmss");
                    var url = $"{model1.RECEIVE_URL}&time={time}";
                    var jiekou = DbContext.Fw.From<BH_JIEKOU_USER>().Where(BH_JIEKOU_USER._.SYSTEM_NO == model1.SYSTEM_NO).ToFirst();
                    if (jiekou == null || string.IsNullOrEmpty(jiekou.SECRET))
                    {
                        return "未找到正确信息";
                    }

                    string token = TokenHelper.CreateToken(url, jiekou.SECRET);
                    return $"{url}&token={token}";
                }

                return "";
            }

            return "";
        }

        public string Reset(string orderId)
        {
            DbContext.Fw.Update<BH_SEND_APPLICATION_FORM>(BH_SEND_APPLICATION_FORM._.RECEIVE_URL, "",
                BH_SEND_APPLICATION_FORM._.M_ID == 221);
            DbContext.Fw.Delete<BH_GUARANTEE_RESULT>(BH_GUARANTEE_RESULT._.ORDER_ID == orderId);
            return "成功";
        }
    }
}
