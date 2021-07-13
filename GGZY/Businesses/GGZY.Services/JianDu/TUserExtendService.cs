using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserExtendService
    {
        public TUserExtend FindUserExtendByUid(decimal? uid)
        {
            var dbModel = FromWhere(T_USER_EXTEND._.U_ID == uid).ToFirst<TUserExtend>();
            if (dbModel != null)
            {
                dbModel.AIDS_OC_INFO = Jd.CommonService.Attachments(dbModel.AIDS_OC, "Sys", true);
                dbModel.AIDS_UCC_INFO = Jd.CommonService.Attachments(dbModel.AIDS_UCC, "Sys", true);
            }
            return dbModel;
        }
        static object RegiesterTempCode_LockObj = new object();
        public GeneralResult CreateTempCode(string countyCode, string type)
        {
            var r = new GeneralResult();
            if (string.IsNullOrWhiteSpace(countyCode))
            {
                r.SetFail("请选择单位所在地");
            }
            else if (string.IsNullOrWhiteSpace(type) || (type != "G" && type != "D"))
            {
                r.SetFail("请选择临时信用代码类型");
            }
            else
            {
                lock (RegiesterTempCode_LockObj)
                {
                    var today = DateTime.Today.ToString("yyyyMMdd");
                    var unifiedCreditCodeSeq = FromWhere(T_USER_EXTEND._.UNIFIED_CREDIT_CODE.Contain(today)
                                                         && T_USER_EXTEND._.UNIFIED_CREDIT_CODE.BeginWith("Y1"))
                                                   .Count() + 1;
                    if (unifiedCreditCodeSeq >= 100)
                    {
                        r.SetFail("今日临时信用代码已超过100,未避免临时统一社会信用代码重复，请明日再来生成！");
                    }
                    else
                    {
                        var xhStr = unifiedCreditCodeSeq.ToString().PadLeft(2, '0');
                        r.SetSuccess(new
                        {
                            UnifiedCreditCode = $"Y1{countyCode}J{today}{xhStr}{type}",
                            OrgCode = $"J{today}{xhStr}"
                        });
                    }
                }


            }

            return r;
        }

        public GeneralResult SaveUserExtend(TUserExtend model)
        {
            var r = new GeneralResult();
            string[] cols = new[] {
                "DEP_NAME","DEP_KIND" ,"UNIFIED_CREDIT_CODE" ,"ORGAN_CODE" ,
                "PROV_CODE","CITY_CODE","COUNTY_CODE","POSTAL_CODE","ADDRESS","CONTACTS","CONTACTS_PHONE","AIDS_UCC","ACCOUNT_TYPE"
            };
            foreach (var propertyInfo in model.GetPropertyInfos())
            {
                if (cols.Any(c => c == propertyInfo.Name) && propertyInfo.Name != "COUNTY_CODE")
                {
                    var v = propertyInfo.GetValue(model);
                    if (string.IsNullOrWhiteSpace(v?.ToString()))
                    {
                        r.SetFail("数据填写不完整");
                        return r;
                    }
                }
            }
            if (model.TempCode && model.TempCodeType == "G" && string.IsNullOrWhiteSpace(model.IDCARD))
            {
                r.SetFail("身份证号码不能为空");
                return r;
            }
            //if (model.TempCode)
            //{
            //    r = CreateTempCode(model.COUNTY_CODE, model.TempCodeType);
            //    if (r.Success)
            //    {
            //        model.UNIFIED_CREDIT_CODE = r.Data.PropertyToString("UNIFIED_CREDIT_CODE");
            //        model.ORGAN_CODE = r.Data.PropertyToString("ORGAN_CODE");
            //    }
            //    else
            //    {
            //        return r;
            //    }
            //}
            var jdUserId = JdUser?.ID;
            var dbEntity = FirstOrNull(T_USER_EXTEND._.U_ID == jdUserId);
            var dbUser = Jd.TUserService.FirstOrNull(T_USER._.ID == jdUserId);
            using (var trans = GetDbSession().BeginTransaction())
            {
                if (model.AIDS_UCC_INFO != null && model.AIDS_UCC_INFO.Any())
                {
                    model.AIDS_UCC = string.Join(",", model.AIDS_UCC_INFO.Select(c => c.Id));
                }
                if (model.AIDS_OC_INFO != null && model.AIDS_OC_INFO.Any())
                {
                    model.AIDS_OC = string.Join(",", model.AIDS_OC_INFO.Select(c => c.Id));
                }
               
                var ucc = model.AIDS_UCC_INFO?.Select(c => c.JdSysAttachment(jdUserId)).ToList();
                var oc = model.AIDS_OC_INFO?.Select(c => c.JdSysAttachment(jdUserId)).ToList();
                if (dbEntity == null)
                {
                    model.U_ID = jdUserId;
                    var dbModel = model.ConvertTo<T_USER_EXTEND>();
                    if (ucc != null)
                    {
                        trans.Insert(ucc);
                    }

                    if (oc != null)
                    {
                        trans.Insert(oc);
                    }
                   
                    
                    trans.Insert(dbModel);
                }
                else
                {
                    if (dbEntity.UNIFIED_CREDIT_CODE.StartsWith("Y1") &&
                        dbEntity.UNIFIED_CREDIT_CODE != model.UNIFIED_CREDIT_CODE)
                    {
                        r.SetFail("临时统一社会信用代码不可更改");
                        return r;
                    }
                    dbEntity.DEP_NAME = model.DEP_NAME;
                    dbEntity.DEP_KIND = model.DEP_KIND;
                    dbEntity.UNIFIED_CREDIT_CODE = model.UNIFIED_CREDIT_CODE;
                    dbEntity.ORGAN_CODE = model.ORGAN_CODE;
                    dbEntity.PROV_CODE = model.PROV_CODE;
                    dbEntity.CITY_CODE = model.CITY_CODE;
                    dbEntity.COUNTY_CODE = model.COUNTY_CODE;
                    dbEntity.POSTAL_CODE = model.POSTAL_CODE;
                    dbEntity.ADDRESS = model.ADDRESS;
                    dbEntity.CONTACTS = model.CONTACTS;
                    dbEntity.CONTACTS_PHONE = model.CONTACTS_PHONE;
                    if (dbEntity.AIDS_UCC != model.AIDS_UCC)
                    {
                        dbEntity.AIDS_UCC = model.AIDS_UCC;
                        if (ucc != null)
                        {
                            trans.Insert(ucc);
                        }

                    }
                    if (dbEntity.AIDS_OC != model.AIDS_OC)
                    {
                        dbEntity.AIDS_OC = model.AIDS_OC;
                        if (oc != null)
                        {
                            trans.Insert(oc);
                        }
                    }
                    dbEntity.ACCOUNT_TYPE = model.ACCOUNT_TYPE;
                    dbEntity.IDCARD = model.IDCARD;
                    trans.Update(dbEntity);
                }

                if (dbUser != null)
                {
                    dbUser.Attach();
                    dbUser.MANAGE_NAME = model.MANAGE_NAME;
                    trans.Update(dbUser);
                }
                trans.Commit();
                r.SetSuccess();
            }

            return r;
        }
    }
}