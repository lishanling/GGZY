using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.DZBH.ParamModel;
using GGZYFW.DbEntity;

namespace GGZY.Services.DZBH
{
    public class ClaimService : BaseServiceT<BH_SEND_CLAIM_FORM>
    {
        public GeneralResult Add(BH_SEND_CLAIM_FORM obj, List<BH_ATTACHMENT> Attachment)
        {
            GeneralResult res = new GeneralResult();
            int id = 0;
            //处理附件
            if (Attachment != null && Attachment.Count > 0 && Attachment.First() != null)
            {
                if (!DbContext.Fw.Exists<BH_ATTACHMENT>(BH_ATTACHMENT._.ID == Attachment.First().ID))
                {
                    DbContext.Fw.Insert(Attachment.First());
                }
                obj.CLIAM_ATTACHMENT_MD5 = Attachment.First().MD5;
                obj.CLIAM_ATTACHMENT_URL = Attachment.First().URL;
                obj.CLIAM_ATTACHMENT_AID = Attachment.First().ID;
            }
            /*if (obj.M_ID != 0)
            {
                obj.CREATE_TIME = DateTime.Now;
                Update(obj);
                id = obj.M_ID;
            }
            else
            {*/
            obj.USER_ID = FwUser.ID;
            obj.M_ID = 0;
            obj.CREATE_TIME = DateTime.Now;
            id = Insert(obj);
            //}
            res.SetSuccess(new { obj.ORDER_ID, ID = id });
            return res;
        }
        public GeneralResult List(ListSearchModel search)
        {
            GeneralResult res = new GeneralResult();
            var where = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.OrderId))
            {
                where.And(BH_SEND_CLAIM_FORM._.ORDER_ID.Contain(search.OrderId));
            }
            if (!string.IsNullOrWhiteSpace(search.GuranteeNo))
            {
                where.And(BH_SEND_CLAIM_FORM._.GUARANTEE_NO.Contain(search.GuranteeNo));
            }
            if (!string.IsNullOrWhiteSpace(search.TenderProjectCode))
            {
                where.And(BH_SEND_CLAIM_FORM._.TENDER_PROJECT_CODE.Contain(search.TenderProjectCode));
            }
            if (!string.IsNullOrWhiteSpace(search.TenderProjectName))
            {
                where.And(BH_SEND_CLAIM_FORM._.TENDER_PROJECT_NAME.Contain(search.TenderProjectName));
            }
            if (!string.IsNullOrWhiteSpace(search.SectionCode))
            {
                where.And(BH_SEND_CLAIM_FORM._.SECTION_CODE.Contain(search.SectionCode));
            }
            if (!string.IsNullOrWhiteSpace(search.SectionName))
            {
                where.And(BH_SEND_CLAIM_FORM._.SECTION_NAME.Contain(search.SectionName));
            }

            if (!DateTime.MinValue.Equals(search.StartOpenTime))
            {
                where.And(BH_SEND_CLAIM_FORM._.BID_OPEN_TIME >= search.StartOpenTime);
            }
            if (!DateTime.MinValue.Equals(search.EndOpenTime))
            {
                where.And(BH_SEND_CLAIM_FORM._.BID_OPEN_TIME < search.EndOpenTime);
            }

            where.And(BH_SEND_CLAIM_FORM._.USER_ID == FwUser.ID);
            List<Field> cols = new List<Field>()
            {
                BH_SEND_CLAIM_FORM._.M_ID,
                BH_SEND_CLAIM_FORM._.TENDER_PROJECT_CODE,
                BH_SEND_CLAIM_FORM._.TENDER_PROJECT_NAME,
                BH_SEND_CLAIM_FORM._.SECTION_CODE,
                BH_SEND_CLAIM_FORM._.SECTION_NAME,
                BH_SEND_CLAIM_FORM._.ORDER_ID,
                BH_SEND_CLAIM_FORM._.BID_OPEN_TIME,
                BH_SEND_CLAIM_FORM._.BID_BOND,
                BH_SEND_CLAIM_FORM._.CREATE_TIME,
                BH_SEND_CLAIM_FORM._.GUARANTEE_NO,
                BH_SEND_CLAIM_FORM._.CLAIM_AMOUNT,
                BH_SEND_CLAIM_FORM._.GUARANTOR_NAME,
            };
            //Logger.Debug("开始获取数据");
            var total = Count(where);
            var list = DbContext.Fw.From<BH_SEND_CLAIM_FORM>()
                .Where(where.ToWhereClip())
                .Select(cols.ToArray())
                .Page(search.PageSize, search.PageNo)
                .OrderBy(BH_SEND_CLAIM_FORM._.CREATE_TIME.Desc)
                .ToList();
            //Logger.Debug("开始组装数据");
            /*List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
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
            }*/
            //Logger.Debug("数据组装完成");
            res.SetSuccess(list.ToPageTableResult(search, total));
            return res;
        }
        public GeneralResult ViewByPk(int ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(BH_SEND_CLAIM_FORM._.M_ID == ID);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                var orderModel = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID == dbModel.ORDER_ID).ToFirst();
                var guaranteeModel = DbContext.Fw.From<BH_GUARANTEE_RESULT>()
                    .Where(BH_GUARANTEE_RESULT._.GUARANTEE_NO == dbModel.GUARANTEE_NO).ToFirst();
                var region = DbContext.Fw.From<SYS_AREA_QUANGUO>().Where(SYS_AREA_QUANGUO._.AREACODE == dbModel.CITY_CODE)
                    .ToFirst().AREANAME;
                var project_type = DictModel.ProjectTypeDict.GetStringValue(dbModel.TENDER_PROJECT_TYPE);
                //添加附件
                Dictionary<string, object> dict = dbModel.ToDict();
                dict.Add("CLIAM_ATTACHMENT", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == dbModel.CLIAM_ATTACHMENT_AID).ToList().ToBhAttachments());
                dict.Add("QUALFICATION_FILE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == orderModel.QUALFICATION_FILE_AIDS).ToList().ToBhAttachments());
                dict.Add("BUSINESS_LICENSE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == orderModel.BUSINESS_LICENSE_AIDS).ToList().ToBhAttachments());
                dict.Add("TENDER_FILE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == orderModel.TENDER_FILE_AIDS).ToList().ToBhAttachments());
                var GUARANTEE_ATT = new List<object>();
                GUARANTEE_ATT.Add(new
                {
                    id = guaranteeModel.GUARANTEE_FILE_NAME,
                    url = guaranteeModel.GUARANTEE_URL,
                    name = guaranteeModel.GUARANTEE_FILE_NAME,
                    md5 = guaranteeModel.GUARANTEE_MD5,
                });
                dict.Add("GUARANTEE_ATT", GUARANTEE_ATT);
                dict.Add("CITY_CODE_TEXT", region);
                dict.Add("TENDER_PROJECT_TYPE_TEXT", project_type);
                result.SetSuccess(dict);
            }
            return result;
        }

        public GeneralResult GetOrderInfo(string orderId, string guranteeNo)
        {
            var result = new GeneralResult();
            if (string.IsNullOrEmpty(orderId) || string.IsNullOrEmpty(guranteeNo))
            {
                result.SetFail("订单编号和保函编号不能为空");
                return result;
            }
            List<Field> cols = new List<Field>();
            var data = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                .InnerJoin<BH_GUARANTEE_RESULT>(BH_SEND_APPLICATION_FORM._.ORDER_ID == BH_GUARANTEE_RESULT._.ORDER_ID)
                .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID == orderId &&
                       BH_GUARANTEE_RESULT._.GUARANTEE_NO == guranteeNo)
                .Select(cols.ToArray()).ToDataTable().ToDictionary();
            if (data.Count > 0)
            {
                //插入附件
                data[0].Add("QUALFICATION_FILE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == data[0].GetStringValue("QUALFICATION_FILE_AIDS")).ToList().ToBhAttachments());
                data[0].Add("BUSINESS_LICENSE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == data[0].GetStringValue("BUSINESS_LICENSE_AIDS")).ToList().ToBhAttachments());
                data[0].Add("TENDER_FILE", DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == data[0].GetStringValue("TENDER_FILE_AIDS")).ToList().ToBhAttachments());
                var GUARANTEE_ATT = new List<object>();
                GUARANTEE_ATT.Add(new
                {
                    id = data[0].GetStringValue("GUARANTEE_FILE_NAME"),
                    url = data[0].GetStringValue("GUARANTEE_URL"),
                    name = data[0].GetStringValue("GUARANTEE_FILE_NAME"),
                    md5 = data[0].GetStringValue("GUARANTEE_MD5"),
                });
                data[0].Add("GUARANTEE_ATT", GUARANTEE_ATT);
                result.SetSuccess(data);
            }
            else
            {
                result.SetFail("未查询到相关保函信息");
            }

            return result;
        }
    }
}
