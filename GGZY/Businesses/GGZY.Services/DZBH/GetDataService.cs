using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Services.DZBH
{
    public class GetDataService : BaseService
    {
        public Hashtable CheckDataByNo(string validation, string data)
        {
            Logger.Debug($"保单批量验真接口：data={data}&validation={validation}");
            Hashtable ht = new Hashtable();
            if (string.IsNullOrEmpty(validation) || string.IsNullOrEmpty(data))
            {
                ht = new Hashtable()
                {
                    ["STATUS"] = "0",
                    ["MSG"] = "参数不能为空"
                };
                return ht;
            }

            try
            {
                BhGetDataService gds = new BhGetDataService(validation, data, "使用保函编号或订单号列表批量查询验证接口");
                gds.Run();
                string orderIds = gds.data.GetStringValue("ORDER_IDS");
                string guaranteeIds = gds.data.GetStringValue("GUARANTEE_NOS");
                //判断参数是否为空
                ThrowHelper.ThrowIfTure(string.IsNullOrWhiteSpace(orderIds) && string.IsNullOrWhiteSpace(guaranteeIds),
                    "订单号和保函编号参数不能全为空");
                List<string> orderIdList = orderIds.Split(';').ToList();
                List<string> guaranteeIdList = guaranteeIds.Split(';').ToList();

                List<Field> cols = new List<Field>()
                {
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME,
                    BH_SEND_APPLICATION_FORM._.ORDER_ID,
                    BH_GUARANTEE_RESULT._.GUARANTEE_NO,
                    BH_GUARANTEE_RESULT._.AUDIT_TYPE.As("RESULT"),
                    BH_GUARANTEE_RESULT._.AUDIT_REMARK.As("REMARK"),
                    BH_SEND_APPLICATION_FORM._.SECTION_CODE,
                    BH_SEND_APPLICATION_FORM._.SECTION_NAME,
                    BH_SEND_APPLICATION_FORM._.TENDERER,
                    BH_SEND_APPLICATION_FORM._.TENDERER_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.SERVICE_BEGIN_TIME,
                    BH_SEND_APPLICATION_FORM._.SERVICE_END_TIME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_NAME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.BIDDER_NAME,
                    BH_SEND_APPLICATION_FORM._.BIDDER_CREDIT_CODE,
                    BH_GUARANTEE_RESULT._.BID_BOND,
                    BH_GUARANTEE_RESULT._.CREATE_TIME,
                    BH_GUARANTEE_RESULT._.GUARANTEE_URL,
                    BH_GUARANTEE_RESULT._.GUARANTEE_MD5
                };

                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_GUARANTEE_RESULT._.ORDER_ID ==
                                                    BH_SEND_APPLICATION_FORM._.ORDER_ID)
                    .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID.In(orderIdList)
                        .Or(BH_GUARANTEE_RESULT._.GUARANTEE_NO.In(guaranteeIdList)))
                    .Select(cols.ToArray())
                    .ToDataTable();
                //判断查询的数据是否均已开标
                foreach (DataRow row in obj.Rows)
                {
                    var code = row["TENDER_PROJECT_CODE"].ToString();
                    //判断开标时间是否已过
                    string kbsql =
                        $"select  to_char(bid_open_time,'yyyy-mm-dd hh24:mi:ss') time from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' and notice_send_time = (select max(notice_send_time) from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' group by tender_project_code)";
                    DataTable bkDt = DbContext.Fw.FromSql(kbsql).ToDataTable();
                    ThrowHelper.ThrowIfTure(bkDt.Rows.Count == 0, "未查询到该项目开标时间");
                    ThrowHelper.ThrowIfTure(DateTimeHelper.ToDateTime(bkDt.Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss") > DateTime.Now, "该项目尚未开标，目前无法查询");
                }


                ht = new Hashtable()
                {
                    ["STATUS"] = "1",
                    ["MSG"] = "",
                    ["DATA"] = obj
                };

            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据错误", e);
                    msg = "数据错误：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }

                ht["STATUS"] = "0";
                ht["MSG"] = msg;
            }

            return ht;
        }
        public Hashtable CheckDataByBidderName(string validation, string data)
        {
            Logger.Debug($"保单通过投保人批量验真接口：data={data}&validation={validation}");
            Hashtable ht = new Hashtable();
            if (string.IsNullOrEmpty(validation) || string.IsNullOrEmpty(data))
            {
                ht = new Hashtable()
                {
                    ["STATUS"] = "0",
                    ["MSG"] = "参数不能为空"
                };
                return ht;
            }

            try
            {
                BhGetDataService gds = new BhGetDataService(validation, data, "使用保函编号或订单号列表批量查询验证接口");
                gds.Run();
                string code = gds.data.GetStringValue("TENDER_PROJECT_CODE");
                string bidder = gds.data.GetStringValue("BIDDER_NAME");
                //判断参数是否为空
                ThrowHelper.ThrowIfTure(string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(bidder),
                    "招标项目编号和投保人不能为空");
                //判断开标时间是否已过
                string kbsql =
                    $"select  to_char(bid_open_time,'yyyy-mm-dd hh24:mi:ss') time from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' and notice_send_time = (select max(notice_send_time) from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' group by tender_project_code)";
                DataTable bkDt = DbContext.Fw.FromSql(kbsql).ToDataTable();
                ThrowHelper.ThrowIfTure(bkDt.Rows.Count == 0, "未查询到该项目开标时间");
                ThrowHelper.ThrowIfTure(DateTimeHelper.ToDateTime(bkDt.Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss") > DateTime.Now, "该项目尚未开标，目前无法查询");

                List<Field> cols = new List<Field>()
                {
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME,
                    BH_SEND_APPLICATION_FORM._.ORDER_ID,
                    BH_GUARANTEE_RESULT._.GUARANTEE_NO,
                    BH_GUARANTEE_RESULT._.AUDIT_TYPE.As("RESULT"),
                    BH_GUARANTEE_RESULT._.AUDIT_REMARK.As("REMARK"),
                    BH_SEND_APPLICATION_FORM._.SECTION_CODE,
                    BH_SEND_APPLICATION_FORM._.SECTION_NAME,
                    BH_SEND_APPLICATION_FORM._.TENDERER,
                    BH_SEND_APPLICATION_FORM._.TENDERER_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.SERVICE_BEGIN_TIME,
                    BH_SEND_APPLICATION_FORM._.SERVICE_END_TIME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_NAME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.BIDDER_NAME,
                    BH_SEND_APPLICATION_FORM._.BIDDER_CREDIT_CODE,
                    BH_GUARANTEE_RESULT._.BID_BOND,
                    BH_GUARANTEE_RESULT._.CREATE_TIME,
                    BH_GUARANTEE_RESULT._.GUARANTEE_URL,
                    BH_GUARANTEE_RESULT._.GUARANTEE_MD5
                };

                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_GUARANTEE_RESULT._.ORDER_ID ==
                                                    BH_SEND_APPLICATION_FORM._.ORDER_ID)
                    .Where((BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE == code)
                        .And(BH_SEND_APPLICATION_FORM._.BIDDER_NAME == bidder))
                    .Select(cols.ToArray())
                    .ToDataTable();
                ht = new Hashtable()
                {
                    ["STATUS"] = "1",
                    ["MSG"] = "",
                    ["DATA"] = obj
                };

            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据错误", e);
                    msg = "数据错误：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }

                ht["STATUS"] = "0";
                ht["MSG"] = msg;
            }

            return ht;
        }

        public Hashtable CheckDataByCode(string validation, string data)
        {
            Logger.Debug($"保单招标项目编号验真接口：data={data}&validation={validation}");
            Hashtable ht = new Hashtable();
            if (string.IsNullOrEmpty(validation) || string.IsNullOrEmpty(data))
            {
                ht = new Hashtable()
                {
                    ["STATUS"] = "0",
                    ["MSG"] = "参数不能为空"
                };
                return ht;
            }

            try
            {
                BhGetDataService gds = new BhGetDataService(validation, data, "使用招标项目编号批量查询验证接口");
                gds.Run();
                string code = gds.data.GetStringValue("TENDER_PROJECT_CODE");
                string name = gds.data.GetStringValue("TENDER_PROJECT_NAME");
                //判断招标项目编号是否为空
                ThrowHelper.ThrowIfTure(string.IsNullOrWhiteSpace(code), "招标项目编号不能为空");
                //判断开标时间是否已过
                string kbsql =
                    $"select  to_char(bid_open_time,'yyyy-mm-dd hh24:mi:ss') time from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' and notice_send_time = (select max(notice_send_time) from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' group by tender_project_code)";
                DataTable bkDt = DbContext.Fw.FromSql(kbsql).ToDataTable();
                ThrowHelper.ThrowIfTure(bkDt.Rows.Count == 0, "未查询到该项目开标时间");
                ThrowHelper.ThrowIfTure(DateTimeHelper.ToDateTime(bkDt.Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss") > DateTime.Now, "该项目尚未开标，目前无法查询");

                List<Field> cols = new List<Field>()
                {
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME,
                    BH_SEND_APPLICATION_FORM._.ORDER_ID,
                    BH_GUARANTEE_RESULT._.GUARANTEE_NO,
                    //BH_GUARANTEE_RESULT._.AUDIT_TYPE.As("RESULT"),
                    new Field("'1'").As("RESULT"),
                    BH_GUARANTEE_RESULT._.AUDIT_REMARK.As("REMARK"),
                    BH_SEND_APPLICATION_FORM._.SECTION_CODE,
                    BH_SEND_APPLICATION_FORM._.SECTION_NAME,
                    BH_SEND_APPLICATION_FORM._.TENDERER,
                    BH_SEND_APPLICATION_FORM._.TENDERER_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.SERVICE_BEGIN_TIME,
                    BH_SEND_APPLICATION_FORM._.SERVICE_END_TIME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_NAME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.BIDDER_NAME,
                    BH_SEND_APPLICATION_FORM._.BIDDER_CREDIT_CODE,
                    BH_GUARANTEE_RESULT._.BID_BOND,
                    BH_GUARANTEE_RESULT._.CREATE_TIME,
                    BH_GUARANTEE_RESULT._.GUARANTEE_URL,
                    BH_GUARANTEE_RESULT._.GUARANTEE_MD5
                };

                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_GUARANTEE_RESULT._.ORDER_ID ==
                                                    BH_SEND_APPLICATION_FORM._.ORDER_ID)
                    .Where(BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE == code)
                    .Select(cols.ToArray())
                    .ToDataTable();
                ht = new Hashtable()
                {
                    ["STATUS"] = "1",
                    ["MSG"] = "",
                    ["DATA"] = obj
                };

            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据错误", e);
                    msg = "数据错误：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }

                ht["STATUS"] = "0";
                ht["MSG"] = msg;
            }

            return ht;
        }

        public Hashtable CheckDataById(string validation, string data)
        {
            Logger.Debug($"保单信息接口：data={data}&validation={validation}");
            Hashtable ht = new Hashtable();
            if (string.IsNullOrEmpty(validation) || string.IsNullOrEmpty(data))
            {
                ht = new Hashtable()
                {
                    ["STATUS"] = "0",
                    ["MSG"] = "参数不能为空"
                };
                return ht;
            }

            try
            {
                BhGetDataService gds = new BhGetDataService(validation, data, "电子保函详细信息查询接口");
                gds.Run();
                string id = gds.data.GetStringValue("ORDER_ID").ToClearSql();
                string no = gds.data.GetStringValue("GUARANTEE_NO").ToClearSql();
                string msgCode = gds.data.GetStringValue("MESSAGE_TOKEN").ToClearSql();
                //判断招标项目编号是否为空
                ThrowHelper.ThrowIfTure(string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(no),
                    "订单号和保函单号不能全为空");
                List<Field> cols = new List<Field>()
                {
                    BH_SEND_APPLICATION_FORM._.ORDER_ID,
                    BH_SEND_APPLICATION_FORM._.APPROVAL_CODE,
                    BH_SEND_APPLICATION_FORM._.INVEST_PROJECT_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_NAME,
                    BH_SEND_APPLICATION_FORM._.SECTION_CODE,
                    BH_SEND_APPLICATION_FORM._.SECTION_NAME,
                    BH_SEND_APPLICATION_FORM._.CONTRACT_RECKON_PRICE,
                    BH_SEND_APPLICATION_FORM._.TENDERER,
                    BH_SEND_APPLICATION_FORM._.TENDERER_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDERER_BANK_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDERER_BANK_OPENBANK,
                    BH_SEND_APPLICATION_FORM._.TENDERER_BANK_ACCOUNT,
                    BH_SEND_APPLICATION_FORM._.CITY_CODE,
                    BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_TYPE,
                    BH_SEND_APPLICATION_FORM._.BID_OPEN_TIME,
                    BH_SEND_APPLICATION_FORM._.VALID_PERIOD,
                    BH_GUARANTEE_RESULT._.CREATE_TIME,
                    BH_SEND_APPLICATION_FORM._.SERVICE_BEGIN_TIME,
                    BH_SEND_APPLICATION_FORM._.SERVICE_END_TIME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_NAME,
                    BH_SEND_APPLICATION_FORM._.GUARANTOR_CREDIT_CODE,
                    BH_SEND_APPLICATION_FORM._.BIDDER_NAME,
                    BH_SEND_APPLICATION_FORM._.BIDDER_CREDIT_CODE,
                    BH_GUARANTEE_RESULT._.GUARANTEE_NO,
                    BH_GUARANTEE_RESULT._.BID_BOND,
                    BH_GUARANTEE_RESULT._.GUARANTEE_URL,
                    BH_GUARANTEE_RESULT._.GUARANTEE_MD5,
                    BH_GUARANTEE_RESULT._.GUARANTEE_SOURCE_CATYPE,

                };
                WhereClipBuilder where = new WhereClipBuilder();
                if (!string.IsNullOrEmpty(no))
                {
                    where.And(BH_GUARANTEE_RESULT._.GUARANTEE_NO == no);
                }
                else
                {
                    where.And(BH_GUARANTEE_RESULT._.ORDER_ID == id);
                }
                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_GUARANTEE_RESULT._.ORDER_ID == BH_SEND_APPLICATION_FORM._.ORDER_ID)
                    .Where(where.ToWhereClip())
                    .Select(cols.ToArray())
                    .ToDataTable().ToDictionary();
                ThrowHelper.ThrowIfTure(obj.Count == 0, "查无数据");
                string code = obj[0]["TENDER_PROJECT_CODE"].ToString();
                //判断开标时间是否已过
                string kbsql =
                    $"select  to_char(bid_open_time,'yyyy-mm-dd hh24:mi:ss') time from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' and notice_send_time = (select max(notice_send_time) from tender_ann_qua_inquery_ann where tender_project_code = '{code.ToClearSql()}' group by tender_project_code)";
                DataTable bkDt = DbContext.Fw.FromSql(kbsql).ToDataTable();
                ThrowHelper.ThrowIfTure(bkDt.Rows.Count == 0, "未查询到该项目开标时间");
                ThrowHelper.ThrowIfTure(DateTimeHelper.ToDateTime(bkDt.Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss") > DateTime.Now && string.IsNullOrEmpty(msgCode), "该项目尚未开标，目前无法查询，若要查询请输入短信验证码");
                //未开标验证短信验证码
                if (DateTimeHelper.ToDateTime(bkDt.Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss") > DateTime.Now)
                {
                    var msgobj = DbContext.Fw.From<BH_SMS_INFO>().Where((BH_SMS_INFO._.GUARANTEE_NO == no)
                        .And(BH_SMS_INFO._.ORDER_ID == id).And(BH_SMS_INFO._.CODE == msgCode)).ToFirst();
                    ThrowHelper.ThrowIfTure(msgobj == null, "短信验证码验证失败,请重试");
                    ThrowHelper.ThrowIfTure(msgobj.OVER_TIME < DateTime.Now, "短信验证码已过期");
                    ThrowHelper.ThrowIfTure(msgobj.IS_USE != 0, "短信验证码已使用");
                    //记录短信验证码已使用
                    DbContext.Fw.Update<BH_SMS_INFO>(BH_SMS_INFO._.IS_USE, 1, (BH_SMS_INFO._.GUID == msgobj.GUID));
                }
                //为url增加前缀地址
                Dictionary<string, object> resultData = null;
                if (obj.Count > 0)
                {
                    resultData = obj[0];
                    /*if (!resultData["GUARANTEE_PDF_URL"].ToString().ToLower().StartsWith("http://"))
                    {
                        resultData["GUARANTEE_PDF_URL"] =
                            AppSettingUtils.GetString("baseUrl") + resultData["GUARANTEE_PDF_URL"].ToString();
                    }*/
                }
                ht = new Hashtable()
                {
                    ["STATUS"] = "1",
                    ["MSG"] = "",
                    ["DATA"] = resultData
                };
            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据错误：", e);
                    msg = "数据错误：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }

                ht["STATUS"] = "0";
                ht["MSG"] = msg;
            }

            return ht;
        }

        public Hashtable SendMessageToken(string validation, string data)
        {
            Logger.Debug($"发送验证码接口：data={data}&validation={validation}");
            Hashtable ht = new Hashtable();
            if (string.IsNullOrEmpty(validation) || string.IsNullOrEmpty(data))
            {
                ht = new Hashtable()
                {
                    ["STATUS"] = "0",
                    ["MSG"] = "参数不能为空"
                };
                return ht;
            }
            try
            {
                BhGetDataService gds = new BhGetDataService(validation, data, "短信发送接口");
                gds.Run();
                string id = gds.data.GetStringValue("ORDER_ID");
                string no = gds.data.GetStringValue("GUARANTEE_NO");
                //判断是否有保函
                var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .InnerJoin<BH_GUARANTEE_RESULT>(BH_GUARANTEE_RESULT._.ORDER_ID ==
                                                    BH_SEND_APPLICATION_FORM._.ORDER_ID)
                    .Where((BH_SEND_APPLICATION_FORM._.ORDER_ID == id).And(BH_GUARANTEE_RESULT._.GUARANTEE_NO == no))
                    .Select(BH_SEND_APPLICATION_FORM._.BIDDER_CONTACT_TEL)
                    .ToDataTable();
                if (obj.Rows.Count > 0)
                {
                    var tel = obj.Rows[0][0].ToString();
                    if (tel.Length == 11)
                    {
                        //发送短信
                        string code = CreateRandomCode(6);
                        string msg = $"验证码: {code}，10分钟内输入有效，仅用于查询电子保函信息，请勿告知他人。工作人员不会向您索取。";
                        SmsModel sms = new SmsModel { Mobile = tel, Content = msg, Suffix = "福建省电子保函对接服务平台" };
                        sms.SendSms();
                        //记录验证码信息
                        BH_SMS_INFO smsInfo = new BH_SMS_INFO()
                        {
                            GUID = Guid.NewGuid().ToString(),
                            CODE = code,
                            CREATE_TIME = DateTime.Now,
                            OVER_TIME = DateTime.Now.AddMinutes(10),
                            IS_USE = 0,
                            MSG = msg,
                            PHONE = tel,
                            ORDER_ID = id,
                            GUARANTEE_NO = no
                        };
                        DbContext.Fw.Insert(smsInfo);


                        var result = new
                        {
                            GUARANTOR_CONTACT_TEL = tel.Substring(0, 3) + "****" + tel.Substring(7, 4)
                        };

                        ht = new Hashtable()
                        {
                            ["STATUS"] = "1",
                            ["MSG"] = "",
                            ["DATA"] = result
                        };
                    }
                    else
                    {
                        ht = new Hashtable()
                        {
                            ["STATUS"] = "0",
                            ["MSG"] = "投标人手机号不正确",
                        };
                    }
                }
                else
                {
                    ht = new Hashtable()
                    {
                        ["STATUS"] = "0",
                        ["MSG"] = "未查询到相关数据",
                    };
                }
            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据错误", e);
                    msg = "数据错误：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }

                ht["STATUS"] = "0";
                ht["MSG"] = msg;
            }

            return ht;
        }

        public object GetSmsCode(string orderId, string phone)
        {
            var model = DbContext.Fw.From<BH_SMS_INFO>()
                .Where((BH_SMS_INFO._.PHONE == phone).And(BH_SMS_INFO._.ORDER_ID == orderId)).OrderByDescending(BH_SMS_INFO._.CREATE_TIME).ToList();
            var json = model.Select(e => new
            {
                e.CODE,
                e.CREATE_TIME,
                e.ORDER_ID,
                e.PHONE,
                e.IS_USE,
                e.OVER_TIME
            });
            return json;
        }
        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(9);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }
    }
}
