using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using Dos.ORM;
using GGZY.Core.Authentication;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;


namespace GGZY.Services.JianDu
{
    public partial class TUserService
    {
        #region 登录|注册

        /// <summary>
        /// 登录监督平台 账号 密码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult<T_USER> SignIn(LoginModel model)
        {
            var r = new GeneralResult<T_USER>();
            var entity = FirstOrNull(c => c.USERNAME == model.Name && (c.PASSWORD == model.Pwd || c.PASSWORD == model.Pwd.ToLower()));
            if (entity != null)
            {
                r.SetSuccessT(entity);
            }
            else
            {
                r.SetFail("用户名或者密码错误");
            }
            return r;
        }



        public GeneralResult<T_USER> RegisterUserMember(RegisterModel model)
        {
            var r = new GeneralResult<T_USER>();
            var validateRsp = model.JianDuUserValidate();
            if (validateRsp.Success)
            {
                var tUser = model.ToRegisterUser();
                var uniqueRsp = CheckUserUnique(tUser);
                if (uniqueRsp.Success)
                {
                    using (DbTrans trans = GetDbSession().BeginTransaction())
                    {
                        var attachments = model.UnifiedCreditCodeImg_ATTACHMENTS.Select(c => c.JdSysAttachment()).ToList();
                        attachments.AddRange(model.OrgCodeImg_ATTACHMENTS.Select(c => c.JdSysAttachment()));
                        trans.Insert(attachments);
                        tUser.TYPE = 3;
                        tUser.IS_ENABLE = 1;
                        tUser.REG_TM = DateTime.Now;
                        tUser.CREATETIME = tUser.REG_TM;
                        tUser.ROLEIDS = ConfigHelper.AppSettings.JD_MEMBER_REGISTER_ROLEIDS;
                        tUser.DEPARTID = ConfigHelper.AppSettings.JD_MEMBER_REGISTER_DEPARTID;
                        tUser.ID = trans.Insert(tUser);
                        var tUserExtend = model.ToUserExtend(tUser.ID);
                        tUserExtend.ID = trans.Insert(tUserExtend);

                        #region 设置角色信息(注册用户)

                        var zcyhRoleName = ConfigHelper.AppSettings.ZhuCeYongHu;
                        var registerUserRole = Jd.TUserRoleV2Service.FirstOrNull(T_USER_ROLE_V2._.NAME == zcyhRoleName);
                        if (registerUserRole != null)
                        {
                            var groupRole = new T_GENERAL_ATTRIBUTE_V2
                            {
                                MGUID = Guid.NewGuid().ToString("N"),
                                ENTITYNAME = nameof(T_USER),
                                ENTITYID = tUser.ID?.ToString(),
                                KEY = UserGroup.USER_GROUP_ID,
                                OBJECTID = ConfigHelper.APP_KEY_GGZYJD,
                                REMARK = $"公共资源监督平台用户角色分组{DateTime.Now:yyyyMMddHHmmss}",
                                VALUE = registerUserRole.GROUP_ID,
                            };
                            trans.Insert(groupRole);
                        }

                        #endregion
                        trans.Commit();
                        r.SetSuccessT(tUser);
                    }
                }
                else
                {
                    r.SetFail(uniqueRsp.Msg);
                }
            }
            else
            {
                r.SetFail(validateRsp.Msg);
            }

            return r;
        }


        /// <summary>
        /// 验证账号，邮箱，手机号等唯一性
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected GeneralResult CheckUserUnique(T_USER model)
        {
            var r = new GeneralResult();
            var entity = FirstOrNull(c =>
                c.USERNAME == model.USERNAME || c.EMAIL == model.EMAIL || c.TELPHONE == model.TELPHONE || c.MANAGE_NAME == model.MANAGE_NAME);
            if (entity != null)
            {
                if (entity.USERNAME == model.USERNAME)
                {
                    r.SetFail("账户名称已存在");
                }
                else if (model.EMAIL == entity.EMAIL)
                {
                    r.SetFail("电子邮箱已存在");
                }
                else if (model.MANAGE_NAME == entity.MANAGE_NAME)
                {
                    r.SetFail("昵称已存在");
                }
                else
                {
                    r.SetFail("手机号码已存在");
                }
            }
            else
            {
                r.SetSuccess();
            }

            return r;
        }


        #endregion
        public List<T_USER> FindUsers(T_USER model, List<string> uids)
        {
            var condition = ConditionBuilder(model);
            condition.And(T_USER._.ID.SelectIn(uids));
            var list = FindList(condition);
            return list;
        }


        #region 用户管理

        /// <summary>
        /// 获取监督平台用户信息
        /// </summary>
        /// <param name="jdUid"></param>
        /// <returns></returns>
        public JdUserModel JdUserInfo(decimal? jdUid = null)
        {
            if (!jdUid.HasValue)
            {
                jdUid = JdUser.ID;
            }
            var tUser = new T_USER();
            var selectField = tUser.GetFields().ToList();
            selectField.RemoveAll(c => c.Name.Equals("ROLEIDS", StringComparison.CurrentCultureIgnoreCase));
            selectField.Add(T_GENERAL_ATTRIBUTE_V2._.VALUE.As("ROLEIDS"));
            selectField.Add(new Field("VALUE", "T_GENERAL_ATTRIBUTE_V22").As("DEPARTIDS"));
            //selectField.Add(T_USER_ROLE_V2._.NAME.As("ROLEIDS_TEXT"));
            var jdUser = FromWhere(T_USER._.ID == jdUid)
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == UserGroup.USER_GROUP_ID &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == "DEPARTIDS" &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                // .LeftJoin<T_USER_ROLE_V2>(T_USER_ROLE_V2._.GROUP_ID == T_GENERAL_ATTRIBUTE_V2._.VALUE)
                //.LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID==T_USER._.DEPARTID)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE=="76"&& T_USER_DEPARTMENT._.HY_TYPE==SYS_DIC._.VALUE)
                .Select(selectField.ToArray()).ToFirst<JdUserModel>();
            if (jdUser != null)
            {
                jdUser.UserExtend = Jd.TUserExtendService.FindUserExtendByUid(jdUid);
                jdUser.UserDepartment = Jd.TUserDepartmentService.FindDepartmentByDepid(jdUser.DEPARTID);
                jdUser.MainUser = Jd.TUserBindAccountService.GetMainUserIdByChidUsr(jdUser.ID);
                if (!string.IsNullOrWhiteSpace(jdUser.ROLEIDS))
                {
                    var userRoleids = jdUser.ROLEIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var roles = Jd.TUserRoleV2Service.FindList(T_USER_ROLE_V2._.GROUP_ID.In(userRoleids));
                    jdUser.ROLEIDS_TEXT = string.Join(",", roles.Select(o => o.NAME));
                }
            }

            return jdUser;
        }

        /// <summary>
        /// 设置用户角色组
        /// </summary>
        /// <param name="userGroup"></param>
        public void SetUserRoles(UserGroup userGroup)
        {
            var entityName = UserGroup.ENTITY_NAME;
            var key = UserGroup.USER_GROUP_ID;
            var remark = $"公共资源监督平台用户角色分组";
            Jd.TGeneralAttributeV2Service.SaveAttribute(entityName, key, string.Join(",", userGroup.GROUP_IDS), userGroup.UID, remark, "GGZYJD");
        }

        /// <summary>
        /// 根据角色名称筛选该角色下的所有用户信息
        /// </summary>
        /// <param name="search"></param>
        /// <param name="DEPT_NAME"></param>
        /// <param name="AREA_CODE"></param>
        /// <param name="role_name"></param>
        /// <returns></returns>
        public GeneralResult PageTableDepartByRoleName(SearchCondition search, string DEPT_NAME = "", string AREA_CODE = "", string role_name = "纪委监委")
        {
            GeneralResult r = new GeneralResult();

            var roles = role_name.Split(new char[] { ',', '，' });
            List<string> role_strArray = new List<string>();
            roles.Distinct().ToList().ForEach(e =>
            {
                role_strArray.Add("'" + e + "'");
            });

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT DISTINCT D.DNAME    AS DEPT_NAME,");
            sb.AppendLine("       D.DEPID    AS DEPT_ID,");
            //.AppendLine("       U.ID       as \"USER_ID\",");
            //sb.AppendLine("       U.USERNAME as \"USER_NAME\",");
            sb.AppendLine("       D.PHONE,");
            sb.AppendLine("       A.Areaname as \"AREA_NAME\",");
            sb.AppendLine("       d.Areacode as \"AREA_CODE\"");
            sb.AppendLine("  FROM T_USER U");
            sb.AppendLine("  INNER JOIN T_USER_DEPARTMENT d");
            sb.AppendLine("    on d.depid = u.departid");
            sb.AppendLine("  LEFT JOIN SYS_AREA_QUANGUO A");
            sb.AppendLine("    on a.areacode = d.areacode");
            sb.AppendLine(" WHERE EXISTS (SELECT 1");
            sb.AppendLine("          FROM (select ext.entityid");
            sb.AppendLine("                  from t_general_attribute_v2 ext");
            sb.AppendLine("                 inner join t_user_role_v2 r");
            sb.AppendLine("                     on ext.value like '%'||  r.group_id || '%'");
            sb.AppendLine("                 where ext.entityname = 'T_USER'");
            sb.AppendLine("                   and key = 'USER_GROUP_ID'");
            sb.AppendLine("                   and r.status = 1");
            sb.AppendLine("                   and r.name in (" + String.Join(",", role_strArray) + ") ) rl");
            sb.AppendLine("         where u.id = rl.entityid)");
            if (!String.IsNullOrWhiteSpace(DEPT_NAME))
            {
                sb.AppendLine(" AND D.DNAME LIKE '%" + DEPT_NAME + "%' ");
            }
            if (!String.IsNullOrWhiteSpace(AREA_CODE))
            {
                sb.AppendLine(" AND D.areacode ='" + AREA_CODE + "' ");
            }
            sb.AppendLine(" Order by D.areacode");
            int count = 0;



            List<OracleParameter> param = new List<OracleParameter>();
            //param.Add(new OracleParameter(":name", OracleType.VarChar, 4000, String.Join(",", role_strArray).ToString()));
            var datas = FromSqlByPage(sb.ToString(), search.PageNo, search.PageSize, "AREA_CODE", param, out count)
                .ToDataTable();
            r.SetSuccess(new
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                PageTotal = Convert.ToInt32(Math.Ceiling(count * 1.0 / search.PageSize)),
                Table = datas
            });
            return r;
        }

        /// <summary>
        /// 根据角色名称筛选该角色下的所有用户信息
        /// </summary>
        /// <param name="search"></param>
        /// <param name="DEPT_NAME"></param>
        /// <param name="AREA_CODE"></param>
        /// <param name="role_name"></param>
        /// <returns></returns>
        public GeneralResult PageTableByRoleName(SearchCondition search, string DEPT_NAME = "", string AREA_CODE = "", string role_name = "纪委监委")
        {
            GeneralResult r = new GeneralResult();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT D.DNAME    AS DEPT_NAME,");
            sb.AppendLine("       D.DEPID    AS DEPT_ID,");
            sb.AppendLine("       U.ID       as \"USER_ID\",");
            sb.AppendLine("       U.USERNAME as \"USER_NAME\",");
            sb.AppendLine("       U.PHONE,");
            sb.AppendLine("       A.Areaname as \"AREA_NAME\",");
            sb.AppendLine("       A.Areacode as \"AREA_CODE\"");
            sb.AppendLine("  FROM T_USER U");
            sb.AppendLine("  LEFT JOIN T_USER_DEPARTMENT d");
            sb.AppendLine("    on d.depid = u.departid");
            sb.AppendLine("  LEFT JOIN SYS_AREA_QUANGUO A");
            sb.AppendLine("    on a.areacode = d.areacode");
            sb.AppendLine(" WHERE EXISTS (SELECT 1");
            sb.AppendLine("          FROM (select ext.entityid");
            sb.AppendLine("                  from t_general_attribute_v2 ext");
            sb.AppendLine("                 inner join t_user_role_v2 r");
            sb.AppendLine("                      on ext.value like '%'||  r.group_id || '%'");
            sb.AppendLine("                 where ext.entityname = 'T_USER'");
            sb.AppendLine("                   and key = 'USER_GROUP_ID'");
            sb.AppendLine("                   and r.status = 1");
            sb.AppendLine("                   and r.name = :name) rl");
            sb.AppendLine("         where u.id = rl.entityid)");
            if (!String.IsNullOrWhiteSpace(DEPT_NAME))
            {
                sb.AppendLine(" AND D.DNAME LIKE '%" + DEPT_NAME + "%' ");
            }
            if (!String.IsNullOrWhiteSpace(AREA_CODE))
            {
                sb.AppendLine(" AND D.areacode ='" + AREA_CODE + "' ");
            }
            sb.AppendLine(" Order by D.areacode");
            int count = 0;
            List<OracleParameter> param = new List<OracleParameter>();
            param.Add(new OracleParameter(":name", role_name));
            var datas = FromSqlByPage(sb.ToString(), search.PageNo, search.PageSize, "AREA_CODE", param, out count)
                .ToDataTable();
            r.SetSuccess(new
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                PageTotal = Convert.ToInt32(Math.Ceiling(count * 1.0 / search.PageSize)),
                Table = datas
            });
            return r;
        }

        /// <summary>
        /// 公安厅外网系统
        /// 根据角色名称筛选该角色下的所有用户信息
        /// </summary>
        /// <param name="search"></param>
        /// <param name="DEPT_NAME"></param>
        /// <param name="AREA_CODE"></param>
        /// <param name="role_name"></param>
        /// <returns></returns>
        public GeneralResult PageTableClueByRoleName(SearchCondition search, string DEPT_NAME = "", string AREA_CODE = "", string role_name = "公安厅")
        {
            GeneralResult r = new GeneralResult();

            var roles = role_name.Split(new char[] { ',', '，' });
            List<string> role_strArray = new List<string>();
            roles.Distinct().ToList().ForEach(e =>
            {
                role_strArray.Add("'" + e + "'");
            });

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT DISTINCT D.DNAME    AS DEPT_NAME,");
            sb.AppendLine("       D.DEPID    AS DEPT_ID,");
            //.AppendLine("       U.ID       as \"USER_ID\",");
            //sb.AppendLine("       U.USERNAME as \"USER_NAME\",");
            sb.AppendLine("       D.PHONE,");
            sb.AppendLine("       A.Areaname as \"AREA_NAME\",");
            sb.AppendLine("       d.Areacode as \"AREA_CODE\"");
            sb.AppendLine("  FROM T_USER U");
            sb.AppendLine("  INNER JOIN T_USER_DEPARTMENT d");
            sb.AppendLine("    on d.depid = u.departid");
            sb.AppendLine("  LEFT JOIN SYS_AREA_QUANGUO A");
            sb.AppendLine("    on a.areacode = d.areacode");
            sb.AppendLine(" WHERE EXISTS (SELECT 1");
            sb.AppendLine("          FROM (select ext.entityid");
            sb.AppendLine("                  from t_general_attribute_v2 ext");
            sb.AppendLine("                 inner join t_user_role_v2 r");
            sb.AppendLine("                     on ext.value like '%'||  r.group_id || '%'");
            sb.AppendLine("                 where ext.entityname = 'T_USER'");
            sb.AppendLine("                   and key = 'USER_GROUP_ID'");
            sb.AppendLine("                   and r.status = 1");
            sb.AppendLine("                   and r.name in (" + String.Join(",", role_strArray) + ") ) rl");
            sb.AppendLine("         where u.id = rl.entityid)");
            if (!String.IsNullOrWhiteSpace(DEPT_NAME))
            {
                sb.AppendLine(" AND D.DNAME LIKE '%" + DEPT_NAME + "%' ");
            }
            if (!String.IsNullOrWhiteSpace(AREA_CODE))
            {
                sb.AppendLine(" AND D.areacode ='" + AREA_CODE + "' ");
            }
            sb.AppendLine(" Order by D.areacode");
            int count = 0;



            List<OracleParameter> param = new List<OracleParameter>();
            //param.Add(new OracleParameter(":name", OracleType.VarChar, 4000, String.Join(",", role_strArray).ToString()));
            var datas = FromSqlByPage(sb.ToString(), search.PageNo, search.PageSize, "AREA_CODE", param, out count)
                .ToDataTable();
            r.SetSuccess(new
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                PageTotal = Convert.ToInt32(Math.Ceiling(count * 1.0 / search.PageSize)),
                Table = datas
            });
            return r;
        }





        /// <summary>
        /// 监督平台用户列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageTable(T_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var selectField = model.GetFields().ToList();
            selectField.RemoveAll(c => c.Name.Equals("ROLEIDS", StringComparison.CurrentCultureIgnoreCase));
            selectField.Add(T_GENERAL_ATTRIBUTE_V2._.VALUE.As("ROLEIDS"));
            //selectField.Add(T_USER_ROLE_V2._.NAME.As("ROLEIDS_TEXT"));
            selectField.Add(new Field("VALUE", "T_GENERAL_ATTRIBUTE_V22").As("DEPARTIDS"));
            selectField.Add(T_USER_DEPARTMENT._.DNAME.As("DEPARTID_TEXT"));
            selectField.Add(SYS_DIC._.TEXT.As("TYPE_TEXT"));
            var list = FromWhere(condition.ToWhereClip())
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == UserGroup.USER_GROUP_ID &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                //.LeftJoin<T_USER_ROLE_V2>(T_USER_ROLE_V2._.GROUP_ID == T_GENERAL_ATTRIBUTE_V2._.VALUE)
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == "DEPARTIDS" &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_USER._.DEPARTID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "68" && SYS_DIC._.VALUE == T_USER._.TYPE)
                .Select(selectField.ToArray())
                .Page(search.PageSize, search.PageNo)
                .OrderBy(T_USER._.ID.Desc)
                .ToList<JdUserModel>();
            var roleids = string.Join(",", list.Select(c => c.ROLEIDS))
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var roles = Jd.TUserRoleV2Service.FindList(T_USER_ROLE_V2._.GROUP_ID.In(roleids));
            var pageList = list.ToPageTableResult(search, count, c =>
            {
                if (!string.IsNullOrWhiteSpace(c.ROLEIDS))
                {
                    var userRoleids = c.ROLEIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var userRoles = roles.FindAll(r => userRoleids.Contains(r.GROUP_ID));
                    c.ROLEIDS_TEXT = string.Join(",", userRoles.Select(o => o.NAME));
                }
                return c;
            });
            return pageList;
        }

        /// <summary>
        /// 注册用户查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult RegisterUser(T_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            condition.And(T_USER._.TYPE == 3);//报建备案用户
            var query = FromWhere()
                .InnerJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID == T_USER._.ID && condition.ToWhereClip());
            var total = query.Count();

            var selectField = model.GetFields().ToList();
            selectField.RemoveAll(c => c.Name.Equals("ROLEIDS", StringComparison.CurrentCultureIgnoreCase));
            selectField.Add(T_GENERAL_ATTRIBUTE_V2._.VALUE.As("ROLEIDS"));
            selectField.Add(T_USER_ROLE_V2._.NAME.As("ROLEIDS_TEXT"));
            selectField.Add(new Field("VALUE", "T_GENERAL_ATTRIBUTE_V22").As("DEPARTIDS"));
            var list = query
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == UserGroup.USER_GROUP_ID &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                .LeftJoin<T_USER_ROLE_V2>(T_USER_ROLE_V2._.GROUP_ID == T_GENERAL_ATTRIBUTE_V2._.VALUE)
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == "DEPARTIDS" &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                .Select(selectField.ToArray())
                .OrderBy(T_USER._.ID.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<JdUserModel>();
            var pagelist = list.ToPageTableResult(search, total);
            return pagelist;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ReadJdUser(T_USER model)
        {
            var result = new GeneralResult();
            try
            {
                var selectField = model.GetFields().ToList();
                selectField.RemoveAll(c => c.Name.Equals("ROLEIDS", StringComparison.CurrentCultureIgnoreCase));
                selectField.Add(T_GENERAL_ATTRIBUTE_V2._.VALUE.As("ROLEIDS"));
                //selectField.Add(T_USER_ROLE_V2._.NAME.As("ROLEIDS_TEXT"));
                selectField.Add(new Field("VALUE", "T_GENERAL_ATTRIBUTE_V22").As("DEPARTIDS"));
                var dbModel = FromWhere(T_USER._.ID == model.ID)
                    .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                        T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                        T_GENERAL_ATTRIBUTE_V2._.KEY == UserGroup.USER_GROUP_ID &&
                        T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                    //.LeftJoin<T_USER_ROLE_V2>(T_USER_ROLE_V2._.GROUP_ID == T_GENERAL_ATTRIBUTE_V2._.VALUE)
                    .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                        T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                        T_GENERAL_ATTRIBUTE_V2._.KEY == "DEPARTIDS" &&
                        T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                    .Select(selectField.ToArray()).ToFirst<JdUserModel>();
                if (dbModel != null)
                {
                    if (!string.IsNullOrWhiteSpace(dbModel.ROLEIDS))
                    {
                        var userRoleids = dbModel.ROLEIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        var roles = Jd.TUserRoleV2Service.FindList(T_USER_ROLE_V2._.GROUP_ID.In(userRoleids));
                        dbModel.ROLEIDS_TEXT = string.Join(",", roles.Select(o => o.NAME));
                    }
                }
                result.SetSuccess(dbModel);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult CreateJdUser(JdUserModel model)
        {
            var result = new GeneralResult();
            try
            {
                model.ID = 0;
                var depids = model.DEPARTIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                model.DEPARTID = Convert.ToDecimal(depids.LastOrDefault());
                var entity = model.ConvertTo<T_USER>();
                model.ID = Insert(entity);

                SetUserRoles(new UserGroup
                {
                    GROUP_IDS = model.ROLEIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                    UID = model.ID?.ToString()
                });
                Jd.TGeneralAttributeV2Service.SaveAttribute(nameof(T_USER), "DEPARTIDS", model.DEPARTIDS, model.ID?.ToString(), $"监督平台用户组织机构递归信息");
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult UpdateJdUser(JdUserModel model)
        {
            var result = new GeneralResult();
            try
            {
                var depids = model.DEPARTIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                model.DEPARTID = Convert.ToDecimal(depids.LastOrDefault());
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is T_USER entity)
                {
                    entity.Attach();
                    entity.USERNAME = model.USERNAME;
                    entity.MANAGE_NAME = model.MANAGE_NAME;
                    entity.DEPARTID = model.DEPARTID;
                    //entity.ROLEIDS = model.ROLEIDS;
                    entity.IS_ENABLE = model.IS_ENABLE;
                    entity.TYPE = model.TYPE;
                    entity.PHONE = model.PHONE;
                    entity.JOB = model.JOB;
                    entity.WORKSTATION = model.WORKSTATION;
                    entity.DEPARTMENT = model.DEPARTMENT;
                    entity.OPERATION_DEPART = model.OPERATION_DEPART;
                    entity.TELPHONE = model.TELPHONE;
                    entity.IS_SEND_MSG = model.IS_SEND_MSG;
                    if (!string.IsNullOrWhiteSpace(model.PASSWORD))
                    {
                        entity.PASSWORD = model.PASSWORD;
                    }

                    //entity.EMAIL = model.EMAIL;
                    //entity.CA_CODE = model.CA_CODE;
                    //entity.REG_TM = model.REG_TM;
                    //entity.API_CODE = model.API_CODE;
                    //entity.API_KEY = model.API_KEY;
                    //entity.SESSION_ID = model.SESSION_ID;
                    //entity.P_ID = model.P_ID;
                    //entity.GENDER = model.GENDER;
                    //entity.COMPANY_CODE = model.COMPANY_CODE;
                    //entity.AREACODE = model.AREACODE;
                    //entity.TOKEN = model.TOKEN;
                    //entity.TOKEN_EXPTIME = model.TOKEN_EXPTIME;
                    //entity.HY_TYPE = model.HY_TYPE;
                    //entity.ACODES = model.ACODES;
                    //entity.CREATETIME = model.CREATETIME;
                    //entity.CREATEID = model.CREATEID;
                    //entity.ISSENDMSG = model.ISSENDMSG;
                    //entity.ISPUSHMSG = model.ISPUSHMSG;
                    //entity.ISSENDMSG_BJ = model.ISSENDMSG_BJ;
                    Update(entity);

                    SetUserRoles(new UserGroup
                    {
                        GROUP_IDS = model.ROLEIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                        UID = model.ID?.ToString()
                    });
                    Jd.TGeneralAttributeV2Service.SaveAttribute(nameof(T_USER), "DEPARTIDS", model.DEPARTIDS, model.ID?.ToString(), $"监督平台用户组织机构递归信息");
                    result.SetSuccess(entity);
                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ResetPwd(T_USER model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is T_USER entity)
                {
                    entity.Attach();
                    entity.PASSWORD = "e10adc3949ba59abbe56e057f20f883e";// CommonUtils.Md5Str("123456"); <!--重置密码,默认是【123456】小写32为MD5加密-->

                    Update(entity);
                    result.SetSuccess(entity);
                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }
        #endregion


        #region 项目报建模块用户操作

        #region 短信消息用户


        /// <summary>
        /// 用户id查找 启用发送短信用户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public List<T_USER> FindSendMsgByUid(params decimal?[] uid)
        {
            var list = new List<T_USER>();
            if (uid.Length > 0)
            {
                var uids = uid.Where(c => c.HasValue).ToList();
                if (uids.Any())
                {
                    list = FindList(T_USER._.TYPE == 0
                                    && T_USER._.IS_ENABLE == 1
                                    && T_USER._.IS_SEND_MSG == 1
                                    && T_USER._.ID.In(uid));
                }
            }

            return list;

        }
        /// <summary>
        /// 部门id查找 启用发送短信用户信息
        /// </summary>
        /// <param name="departId"></param>
        /// <returns></returns>
        public List<T_USER> FindSendMsgByDepartId(string departId)
        {
            return FindList(T_USER._.TYPE == 0
                            && T_USER._.IS_ENABLE == 1
                            && T_USER._.IS_SEND_MSG == 1
                            && T_USER._.DEPARTID == departId);
        }

        /// <summary>
        /// 查找 项目报建短信发送用户信息
        /// </summary>
        /// <param name="departId"></param>
        /// <returns></returns>
        public List<T_USER> FindProjectReportBuildApproverByDepartId(string departId)
        {
            return FindList(T_USER._.TYPE == 0
                            && T_USER._.IS_ENABLE == 1
                            && T_USER._.ISSENDMSG_BJ == 1
                            && T_USER._.DEPARTID == departId);
        }
        /// <summary>
        /// 查找 项目报建短信发送用户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public List<T_USER> FindProjectReportBuilderByUid(decimal? uid)
        {
            return FindList(T_USER._.IS_ENABLE == 1
                            && T_USER._.ISSENDMSG_BJ == 1
                            && T_USER._.ID == uid);
        }

        #endregion

        #region 监督平台项目报建用户列表

        /// <summary>
        /// 监督平台项目报建用户列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <remarks>
        /// 判断用户是否是报建人
        /// JdUser.TYPE != 3 || JdUser.UserExtend == null || string.IsNullOrWhiteSpace(JdUser.UserExtend.DEP_NAME)
        /// </remarks>
        /// <returns></returns>
        public PageTableResult AfcProjectUserList(T_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            condition.And(T_USER._.TYPE == 3);//报建备案用户
            condition.And(T_USER._.IS_ENABLE == 1);//是否启用
            var query = FromWhere()
                .InnerJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID == T_USER._.ID && condition.ToWhereClip());
            var total = query.Count();

            var selectField = model.GetFields().ToList();
            selectField.RemoveAll(c => c.Name.Equals("ROLEIDS", StringComparison.CurrentCultureIgnoreCase));
            selectField.Add(T_GENERAL_ATTRIBUTE_V2._.VALUE.As("ROLEIDS"));
            selectField.Add(T_USER_ROLE_V2._.NAME.As("ROLEIDS_TEXT"));
            var pagelist = query
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == UserGroup.ENTITY_NAME &&
                    T_GENERAL_ATTRIBUTE_V2._.KEY == UserGroup.USER_GROUP_ID &&
                    T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER._.ID.ToChar())
                .LeftJoin<T_USER_ROLE_V2>(T_USER_ROLE_V2._.GROUP_ID == T_GENERAL_ATTRIBUTE_V2._.VALUE)
                .Select(selectField.ToArray())
                .OrderBy(T_USER._.ID.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<JdUserModel>()
                .ToPageTableResult(search, total);
            return pagelist;
        }

        #endregion

        #endregion

        /// <summary>
        /// 当前登录用户相同部门人员信息（启用状态 工作台用户 IS_ENABLE == 1 TYPE == "0"）
        /// </summary>
        /// <returns></returns>
        public List<object> FindUerByDepartId()
        {
            return FromWhere(T_USER._.IS_ENABLE == 1 && T_USER._.TYPE == "0" && T_USER._.DEPARTID == JdUser.DEPARTID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER._.DEPARTID == T_USER_DEPARTMENT._.DEPID)
                .Select(T_USER._.ID, T_USER._.MANAGE_NAME, T_USER._.PHONE, T_USER._.TELPHONE, T_USER_DEPARTMENT._.DNAME)
                .ToList<object>();
        }

        #region 个人设置 邮箱 电话 密码修改
        /// <summary>
        /// 绑定邮箱
        /// </summary>
        /// <param name="model"></param>
        /// <param name="checkCode">验证图片验证码 </param>
        /// <returns></returns>
        public GeneralResult BindEmail(ProfileModel model, Func<string, bool> checkCode)
        {
            var r = new GeneralResult();
            if (!checkCode.Invoke(model.ImgCode))
            {
                r.SetFail("验证码错误");
                return r;
            }
            if (string.IsNullOrWhiteSpace(model.Email))
            {
                r.SetFail("请输入电子邮箱地址");
                return r;
            }

            if (model.Email.Length > 50)
            {
                r.SetFail("电子邮箱地址长度不能超过50个字符");
                return r;
            }

            var jdUserId = JdUser.ID;
            if (Exists(T_USER._.EMAIL == model.Email && T_USER._.ID != jdUserId))
            {
                r.SetFail($"该电子邮箱已被注册");
            }

            Update(T_USER._.EMAIL, model.Email, T_USER._.ID == jdUserId);
            r.SetSuccess(msg: "邮箱绑定成功");
            return r;
        }
        /// <summary>
        /// 绑定手机
        /// </summary>
        /// <param name="model"></param>
        /// <param name="checkCode">验证短信验证码 </param>
        /// <returns></returns>
        public GeneralResult BindMobile(ProfileModel model)
        {
            var r = SmsModel.ValidateMobileCode(model.Mobile, model.Code);
            if (r.Success)
            {
                var jdUserId = JdUser.ID;
                if (Exists(T_USER._.TELPHONE == model.Mobile && T_USER._.ID != jdUserId))
                {
                    r.SetFail($"该手机号码已被人使用，请确保手机号码唯一");
                }
                Update(T_USER._.TELPHONE, model.Mobile, T_USER._.ID == jdUserId);
                r.SetSuccess(msg: "手机绑定成功");
            }

            return r;
        }
        /// <summary>
        /// 短信提醒
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult SetMsgRemind(ProfileModel model)
        {
            var r = new GeneralResult();

            var jdUserId = JdUser.ID;
            var user = FirstOrNull(T_USER._.ID == jdUserId);
            if (string.IsNullOrWhiteSpace(user.TELPHONE))
            {
                r.SetFail("请先绑定手机号码");
            }
            else
            {
                user.Attach();
                user.IS_SEND_MSG = model.IsSendMsg;//是否启用发送短信
                user.ISSENDMSG = model.IsSendMsg;//是否发送项目异常短信
                user.ISSENDMSG_BJ = model.IsSendMsg;//是否发送报建提醒短信
                Update(user);
            }
            r.SetSuccess(msg: $"{(model.IsSendMsg == 1 ? "开启" : "关闭")}短信提醒成功！");
            return r;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ChangePwd(ProfileModel model)
        {
            var r = new GeneralResult();
            var profile = JdUserInfo();
            var oldPwd = profile.PASSWORD;
            if (!oldPwd.Equals(model.OldPwd, StringComparison.CurrentCultureIgnoreCase))
            {
                var unifyUser = Fw.UnifyUserService.FirstOrNull(GGZYFW.DbEntity.UNIFY_USER._.MGUID == Identity.Id);
                if (!oldPwd.Equals(unifyUser.PWD, StringComparison.CurrentCultureIgnoreCase))
                {
                    r.SetFail("密码错误，请输入正确的密码！");
                    return r;
                }
            }
            var jdUserId = JdUser.ID;
            Update<T_USER>(T_USER._.PASSWORD, model.Pwd, T_USER._.ID == jdUserId);
            Fw.UnifyUserService.Update(GGZYFW.DbEntity.UNIFY_USER._.PWD, model.Pwd, GGZYFW.DbEntity.UNIFY_USER._.MGUID == Identity.Id);
            r.SetSuccess(msg: $"密码修改成功");
            return r;
        }


        #endregion

        #region 监督首页统计


        #region 当前登录用户部门地区列表信息
        /// <summary>
        /// GetRegionCity
        /// </summary>
        /// <returns></returns>
        public List<object> JdUserDepartRegions()
        {
            var r = new List<object>();
            if (!string.IsNullOrWhiteSpace(JdUser?.UserDepartment?.AREACODE))
            {
                var areaCode = JdUser.UserDepartment.AREACODE;
                var rootCode = areaCode.TrimEnd('0');
                var whereBuilder = new WhereClipBuilder();
                if (rootCode.Length < 6)
                {
                    if (rootCode.Length % 2 > 0)
                    {
                        rootCode = rootCode.PadRight(rootCode.Length + 1, '0');
                    }
                    //数据库里多了一个352000，删数据库怕影响其他地方的统计，在此代码里过滤掉
                    whereBuilder.And(SYS_AREA_QUANGUO._.AREACODE != "352000");
                    switch (rootCode.Length)
                    {
                        case 2:
                            whereBuilder.And($"SYS_AREA_QUANGUO.AREACODE LIKE '{rootCode}__00'");
                            if (rootCode == "35")//福建省，添加平潭
                            {
                                whereBuilder.Or(SYS_AREA_QUANGUO._.AREACODE == "350128");
                            }
                            break;
                        case 4:
                            whereBuilder.And($"SYS_AREA_QUANGUO.AREACODE LIKE '{rootCode}__'");
                            if (rootCode == "3501")//福州市，排除平潭
                            {
                                whereBuilder.And(SYS_AREA_QUANGUO._.AREACODE != "350128");
                            }
                            break;
                        default:
                            whereBuilder.And(SYS_AREA_QUANGUO._.AREACODE == areaCode);
                            break;
                    }
                }
                else
                {
                    whereBuilder.And(SYS_AREA_QUANGUO._.AREACODE==rootCode);
                }
                var regions =
                    Jd.SysAreaQuanguoService.FindList(whereBuilder.ToWhereClip(), SYS_AREA_QUANGUO._.ORDER_BY.Asc);
                r = regions.Select(c => (object)new
                {
                    label = c.AREACODE == "350000" ? "全省" : c.AREANAME,
                    value = c.AREACODE.TrimEnd('0'),
                    c.AREACODE,
                    c.AREANAME
                }).ToList();
            }
            return r;
        }
        #endregion

        #region 获取登录用户部门行业类型

        /// <summary>
        /// GetUerHyType
        /// </summary>
        /// <returns></returns>
        public List<object> JdUserDepartIndustries()
        {
            var r = new List<object>();
            var dic = JdUser?.UserDepartment?.SYS_DIC_63;
            if (dic != null && dic.Any())
            {
                var hyList = JdUser.UserDepartment.HY_TYPE_LIST;
                var hyDic = Jd.SysDicService.FromWhere(SYS_DIC._.TYPE == "76" && SYS_DIC._.VALUE.In(hyList)).ToList();
                foreach (var kind in hyDic)
                {
                    var aValues = dic.FindAll(c=>c.VALUE2==kind.VALUE).Select(c => c.VALUE3).ToList();//A01 A02
                    var tenderProjectType = string.Join(",", aValues);//A01,A02
                    var gValues = aValues.Select(c => c.Replace("A", "G")).ToList();//G01,G02
                    if (aValues.Any(c => c.Contains("99-1")))
                    {
                        gValues.Add("A99");
                        gValues.Add("G99");
                    }
                    if (aValues.Any(c => c.Contains("03-")))
                    {
                        gValues.Add("A03");
                        gValues.Add("G03");
                    }
                    gValues.AddRange(aValues);
                    var fwTenderProjectType = string.Join(",", gValues);//A01,A02,G01,G02

                    r.Add(new
                    {
                        label = kind.TEXT,
                        value = kind.VALUE,//T_AFC_PROJECT.KIND
                        projectType = string.Join(",", dic.Select(c => c.VALUE)),//01 02 03 T_AFC_PROJECT.PROJECT_TYPE
                        tenderProjectType = tenderProjectType,//监督平台 TENDER_PROJECT.TENDER_PROJECT_TYPE
                        fwTenderProjectType = fwTenderProjectType,//服务平台TENDER_PROJECT.TENDER_PROJECT_TYPE
                    });
                }
            }
            return r;
        }

        #endregion

        #endregion

        /// <summary>
        /// 闽政通 手机号码认证
        /// 用于身份认证绑定数据读取权限
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>

        public CustomAuthenticationIdentity GetCustomAuthenticationIdentity(string tel)
        {
            var jdMobileUser = FromWhere(T_USER._.PHONE == tel || T_USER._.TELPHONE == tel).ToFirst<JdUserModel>();
            CustomAuthenticationIdentity mobileIdentity = jdMobileUser?.CustomAuthenticationIdentity();
            return mobileIdentity;
        }
    }
}