using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;
using KTPKIAPPCOMCLNTLib;

namespace GGZY.Services.FuWu
{
    public partial class TUserService
    {
        #region 登录

        /// <summary>
        /// 登录服务平台 账号 密码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult<T_USER> SignIn(LoginModel model)
        {
            var r = new GeneralResult<T_USER>();
            var entity = FirstOrNull(c => c.USERNAME == model.Name && (c.PASSWORD == model.Pwd || c.PASSWORD == model.Pwd.ToLower()));
            if (entity != null)
            {
                if (entity.ROLEIDS == ConfigHelper.AppSettings.AGNET_ROLEID && entity.IS_AUDIT != 1)
                {
                    r.SetFail("该用户还未审核通过，请联系平台管理员！");
                }
                else if (entity.IS_ENABLE != 1)
                {
                    r.SetFail("该用户被禁用，请联系平台管理员！");
                }
                else
                {
                    entity.Attach();
                    if (string.IsNullOrWhiteSpace(entity.SESSION_ID))
                    {
                        entity.SESSION_ID = Guid.NewGuid().ToString();
                    }

                    entity.AAAA = model.TruePwd;
                    entity.CA_INFO = string.Empty;
                    Update(entity);
                    r.SetSuccessT(entity);
                }
            }
            else
            {
                r.SetFail("用户名或者密码错误");
            }
            return r;
        }


        /// <summary>
        /// 登录服务平台 账号 密码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult<T_USER> PersonalSignIn(LoginModel model)
        {
            var r = new GeneralResult<T_USER>();
            var entity = FirstOrNull(c => c.USERNAME == model.Name && c.PASSWORD == model.Pwd && c.ROLEIDS == ConfigHelper.AppSettings.PERSON_ROLEID);
            if (entity != null)
            {
                if (entity.IS_ENABLE != 1)
                {
                    r.SetFail("该用户被禁用，请联系平台管理员！");
                }
                else
                {
                    entity.Attach();
                    if (string.IsNullOrWhiteSpace(entity.SESSION_ID))
                    {
                        entity.SESSION_ID = Guid.NewGuid().ToString();
                    }

                    entity.AAAA = model.TruePwd;
                    entity.CA_INFO = string.Empty;
                    Update(entity);
                    r.SetSuccessT(entity);
                }
            }
            else
            {
                r.SetFail("用户名或者密码错误");
            }
            return r;
        }

        #endregion
        /// <summary>
        /// 注册个人用户
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        public GeneralResult<T_USER> RegisterPersonalUser(RegisterModel registerModel)
        {
            var r = new GeneralResult<T_USER>();
            var model = registerModel.ToPersonalUser();
            var checkRsp = CheckUserUnique(model);
            if (checkRsp.Success)
            {
                model.ID = 0;
                model.TYPE = 1;
                model.ROLEIDS = ConfigHelper.AppSettings.PERSON_ROLEID;//一般用户
                model.IS_ENABLE = 1;
                model.REG_TM = DateTime.Now;
                model.ID = Insert(model);
                r.SetSuccessT(model);
            }
            else
            {
                r.SetFail(checkRsp.Msg);
            }
            return r;
            //return r;
        }


        /// <summary>
        /// 注册企业用户
        /// </summary>
        /// <param name="registerModel">注册用户信息</param>
        /// <returns></returns>
        //public GeneralResult<T_USER> RegisterCompanyUser(RegisterModel registerModel)
        //{
        //    var r = new GeneralResult<T_USER>();
        //    var companyUser = registerModel.ToCompanyUser();
        //    var checkRsp = CheckUserUnique(companyUser, true);
        //    if (checkRsp.Success)
        //    {
        //        if (!string.IsNullOrWhiteSpace(registerModel.OrgCode))
        //        {//如果有统一信用代码 直接入T_USER表 
        //            companyUser.ID = 0;
        //            companyUser.TYPE = 2;
        //            companyUser.ROLEIDS = ConfigHelper.AppSettings.COMPANY_ROLEID;//企业账号
        //            companyUser.IS_ENABLE = 1;
        //            companyUser.REG_TM = DateTime.Now;
        //            companyUser.ID = Insert(companyUser);
        //            Fw.LegalPersonBaseService.BindCompanyUser(companyUser, registerModel.OrgCode);
        //            r.SetSuccessT(companyUser);
        //            r.State = "1";
        //        }
        //        else
        //        {
        //            Fw.LegalPersonBaseService.AddLegalPerson(registerModel);
        //            Fw.TUserQyzcService.Add(registerModel.ToCompanyRegisterUser());
        //            r.SetSuccessT(companyUser);
        //            r.State = "2";
        //        }
        //    }
        //    else
        //    {
        //        r.SetFail(checkRsp.Msg);
        //    }
        //    return r;
        //}
        /// <summary>
        /// 通过事务 注册企业用户
        /// </summary>
        /// <param name="registerModel">注册用户信息</param>
        /// <returns></returns>
        public GeneralResult<T_USER> RegisterCompanyUserByTrans(RegisterModel registerModel)
        {
            var r = new GeneralResult<T_USER>();
            var companyUser = registerModel.ToCompanyUser();
            var checkRsp = CheckUserUnique(companyUser, true);
            if (checkRsp.Success)
            {
                if (!string.IsNullOrWhiteSpace(registerModel.OrgCode))
                {//如果有统一信用代码 直接入T_USER表 
                    var legalPersonBound = Fw.LegalPersonBaseService.LegalPersonBound(registerModel.OrgCode);
                    if (legalPersonBound != null)
                    {
                        r.SetFail("该社会统一信用代码已注册");
                        //r.SetFail("该企业已注册过了");
                    }
                    else
                    {
                        var legalPerson = Fw.LegalPersonBaseService.LegalPerson(registerModel.OrgCode);
                        using (DbTrans trans = GetDbSession().BeginTransaction())
                        {
                            companyUser.ID = trans.Insert(companyUser);
                            if (legalPerson == null)
                            {
                                legalPerson = registerModel.ToLegalPersonBase(companyUser.ID);
                                trans.Insert(legalPerson);
                            }
                            else
                            {
                                legalPerson.Attach();
                                legalPerson.LEGAL_NAME = companyUser.USERNAME;
                                legalPerson.LEGAL_EMAIL = companyUser.EMAIL;
                                legalPerson.M_USER_ID = companyUser.ID;
                                trans.Update(legalPerson);
                            }
                            if (registerModel.ZCZM_ATTACHMENTS != null && registerModel.ZCZM_ATTACHMENTS.Any())
                            {
                                var attachments = registerModel.ZCZM_ATTACHMENTS.Select(c =>
                                {
                                    var att = c.FwSysAttachment();
                                    att.AOBJID = companyUser.ID;
                                    return att;
                                });
                                trans.Insert(attachments);
                            }
                            trans.Commit();
                        }
                        r.SetSuccessT(companyUser, "恭喜您！注册成功。");
                        r.State = "1";
                    }
                }
                else
                {
                    var legalPersonBound = Fw.LegalPersonBaseService.LegalPersonBound(registerModel.UnifiedCreditCode);
                    if (legalPersonBound != null)
                    {
                        r.SetFail($"企业注册失败！法人代码{registerModel.UnifiedCreditCode}已经注册过。");
                    }
                    else
                    {
                        var legalPerson = Fw.LegalPersonBaseService.LegalPerson(registerModel.UnifiedCreditCode);
                        using (DbTrans trans = GetDbSession().BeginTransaction())
                        {
                            if (legalPerson == null)
                            {
                                legalPerson = new LEGAL_PERSON_BASE
                                {
                                    LEGAL_NAME = registerModel.UserName,
                                    LEGAL_CODE = registerModel.UnifiedCreditCode,
                                    LEGAL_EMAIL = registerModel.Email,
                                };
                                trans.Insert(legalPerson);
                            }
                            else
                            {
                                legalPerson.Attach();
                                legalPerson.LEGAL_NAME = registerModel.UserName;
                                legalPerson.LEGAL_EMAIL = registerModel.Email;
                                trans.Update(legalPerson);
                            }
                            trans.Insert(registerModel.ToCompanyRegisterUser());
                            trans.Commit();
                        }
                        r.SetSuccessT(companyUser, "注册信息已经成功提交！请等待管理员审核。");
                        r.State = "2";
                    }
                }
            }
            else
            {
                r.SetFail(checkRsp.Msg);
            }
            return r;
        }
        /// <summary>
        /// 注册代理用户
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        public GeneralResult<T_USER> RegisterAgencyUser(RegisterModel registerModel)
        {
            var r = new GeneralResult<T_USER>();
            var model = registerModel.ToAgencyUser();
            var tokenRsp = TokenManager.CheckToken(registerModel.Pid);
            if (tokenRsp.Success)
            {
                if (tokenRsp.TData.Id.All(char.IsDigit))
                {
                    model.P_ID = tokenRsp.TData.Id.ToNullableDecimal();
                }
                else
                {
                    var fwUser = tokenRsp.TData.FwUser();
                    model.P_ID = fwUser?.ID;
                }

                var checkRsp = CheckUserUnique(model);
                if (checkRsp.Success)
                {
                    model.ID = 0;
                    model.TYPE = 2;
                    model.ROLEIDS = ConfigHelper.AppSettings.AGNET_ROLEID;//代理机构子账户
                    model.IS_ENABLE = 0;
                    model.REG_TM = DateTime.Now;
                    model.ID = Insert(model);
                    r.SetSuccessT(model);
                }
                else
                {
                    r.SetFail(checkRsp.Msg);
                }
            }
            else
            {
                r.SetFailEx($"CA证书验证错误", tokenRsp.Msg);
            }
            return r;
        }

        /// <summary>
        /// 验证账号，邮箱，手机号等唯一性
        /// </summary>
        /// <param name="model"></param>
        /// <param name="isCompany">是否企业用户</param>
        /// <returns></returns>
        protected GeneralResult CheckUserUnique(T_USER model, bool isCompany = false)
        {
            var r = new GeneralResult();
            var where = T_USER._.EMAIL == model.EMAIL || T_USER._.USERNAME == model.USERNAME;
            if (!string.IsNullOrWhiteSpace(model.ZP_PHONE))
            {
                where = where.Or(T_USER._.ZP_PHONE == model.ZP_PHONE);
            }
            var entity = FirstOrNull(where);
            if (entity != null)
            {
                if (entity.USERNAME == model.USERNAME)
                {
                    r.SetFail(isCompany ? "该企业已注册过了" : "账户名称已存在");
                }
                else if (model.EMAIL == entity.EMAIL)
                {
                    r.SetFail("电子邮箱已存在");
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(model.ZP_PHONE))
                    {
                        r.SetFail("手机号码已存在");
                    }
                    else
                    {
                        r.SetSuccess();
                    }
                }
            }
            else
            {
                r.SetSuccess();
            }

            return r;
        }

        /// <summary>
        /// 获取CA随机值
        /// </summary>
        /// <returns></returns>
        public object GetRandomForSign()
        {
            var ca = new CertificateAuthorityModel
            {
                SessionId = Guid.NewGuid().ToString("N")
            };

            Cache.Get(ca.SessionId, () => Guid.NewGuid().ToString());
            ca.SrcData = ca.GetRandom();
            return new
            {
                ca.SrcData,
                ca.SessionId
            };
        }
        public GeneralResult<T_USER> CaSignIn(CertificateAuthorityModel ca)
        {
            var r = new GeneralResult<T_USER>();
            var caInfoResult = ca.GetCaInfo();
            if (caInfoResult.Success)
            {
                if (string.IsNullOrWhiteSpace(ca.Data.SGD_EXT_ORGANIZATIONCODE) && string.IsNullOrWhiteSpace(ca.Data.SGD_GET_CERT_SUBJECT_CN))
                {
                    r.SetFail("证书需包含组织机构代码证或者企业名称", data: ca.Data);
                }
                else
                {
                    var legalPerson = Fw.LegalPersonBaseService.LegalPerson(ca.Data.SGD_EXT_ORGANIZATIONCODE,
                        ca.Data.SGD_GET_CERT_SUBJECT_CN.Trim());
                    if (legalPerson == null)
                    {
                        r.SetFail("你企业还未注册，请先注册！", data: ca.Data);

                    }
                    else
                    {
                        var user = FirstOrNull(T_USER._.ID == legalPerson.M_USER_ID);
                        if (user != null)
                        {
                            if (user.IS_AUDIT != 1 && user.ROLEIDS == T_USER.AGNET_ROLEID)
                            {
                                r.SetFail("该用户还未审核通过，请联系平台管理员！");
                                return r;
                            }
                            if (user.IS_ENABLE != 1)
                            {
                                r.SetFail("该用户被禁用，请联系平台管理员！");
                                return r;
                            }
                            if (string.IsNullOrEmpty(user.SESSION_ID))
                            {//唯一在线  用下面的就是唯一在线
                                user.SESSION_ID = Guid.NewGuid().ToString();
                            }
                            user.CA_INFO = ca.Data.Serializer();
                            Fw.CainfoService.SaveCaUserLastLoginRecord(ca.Data, user.ID);
                            r.SetSuccessT(user);
                            //r.SetSuccess();
                        }
                        else
                        {
                            r.SetFail($"无效的CA，请联系系统管理员！", data: ca.Data);
                        }
                    }
                }
            }
            else
            {
                r.SetFail(caInfoResult.Msg);
            }
            return r;
        }


        public List<T_USER> FindUsers(T_USER model, List<string> uids)
        {
            var condition = ConditionBuilder(model);
            condition.And(T_USER._.ID.SelectIn(uids));
            var list = FindList(condition);
            return list;
        }
        /// <summary>
        /// 通过用户ID获取用户实体对象
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public T_USER FindUserByUid(decimal? uid)
        {
            return FirstOrNull(T_USER._.ID == uid);
        }
    }
}