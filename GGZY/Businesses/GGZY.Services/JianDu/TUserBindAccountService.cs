using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using T_USER = GGZYJD.DbEntity.T_USER;

namespace GGZY.Services.JianDu
{
    public class TUserBindAccountService : BaseServiceT<T_USER_BIND_ACCOUNT>
    {
        public GeneralResult MztBindOldJdUser(string username, string password)
        {
            var r = new GeneralResult();
            //判断账号密码是否正确
            var user = FromWhere<T_USER>(
                T_USER._.USERNAME == username && T_USER._.PASSWORD == Encrypt.MD5(password, 32))
                .Select(T_USER._.ID, T_USER._.DEPARTID)
                .ToFirst();
            if (user == null)
            {
                r.SetFail("账号或密码不正确");
                return r;
            }
            //判断账号是否已被绑定
            var mztUser = Identity.MztUser();
            if (mztUser.JDUSERID != 0 && Identity.JdUser().DEPARTID != 658) //部门是658的账号为闽政通账号登录时自动生成的账号
            {
                r.SetFail("您已绑定其他账号！");
                return r;
            }

            if (DbContext.Fw.Count<MZTUSER>(MZTUSER._.JDUSERID == user.ID) > 0)
            {
                r.SetFail("该账号已被其他实名认证账号绑定！");
                return r;
            }

            //更新数据
            DbContext.Fw.Update<MZTUSER>(MZTUSER._.JDUSERID, user.ID, MZTUSER._.USER_ID == mztUser.USER_ID);
            //清除用户信息缓存
            GlobalCache.Instance.Remove($"{ConfigHelper.APP_KEY_GGZYJD}_SMRZ_{Identity.Ticket}");
            GlobalCache.Instance.Remove($"{ConfigHelper.APP_KEY_GGZYJD}_{Identity.Ticket}");
            r.SetSuccess("绑定成功");

            return r;
        }

        /// <summary>
        /// 获取当前用户相同信用代码的账号下拉
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetAccountList()
        {
            var r = new GeneralResult();
#if DEBUG
            string code = "Y1350102J20030301D";
#else
            string code = JdUser?.UserExtend.UNIFIED_CREDIT_CODE;
#endif
            if (!string.IsNullOrEmpty(code))
            {
                var list = FromWhere<T_USER_EXTEND>(T_USER_EXTEND._.UNIFIED_CREDIT_CODE == code)
                    .InnerJoin<T_USER>(T_USER._.ID == T_USER_EXTEND._.U_ID)
                    .Select(T_USER._.USERNAME.As("Label"), T_USER._.ID.As("Value"))
                    .ToList<LabelValueModel>();
                r.SetSuccess(list);
            }
            else
            {
                r.SetFail("查询不到该账号的统一社会信用代码");
            }
            return r;
        }
        /// <summary>
        /// 保存绑定账号数据
        /// </summary>
        /// <param name="accountList"></param>
        /// <returns></returns>
        public GeneralResult Add(List<T_USER_BIND_ACCOUNT> accountList)
        {
            var r = new GeneralResult();
            //验证列表的统一社会代码是否一致
            if (accountList.Count == 0)
            {
                r.SetFail("账号列表为空");
                return r;
            }

            string code = accountList[0].CREDIT_CODE;
            int mainId = accountList[0].MAIN_U_ID;
            if (accountList.Count(e => e.CREDIT_CODE != code) > 0)
            {
                r.SetFail("账号列表中所有的统一社会信用代码应当一致");
                return r;
            }
            if (accountList.Count(e => e.MAIN_U_ID != mainId) > 0)
            {
                r.SetFail("账号列表中所有的主账号应当一致");
                return r;
            }
            if (accountList.Count(e => e.MAIN_U_ID == e.CHILD_U_ID) != 1)
            {
                r.SetFail("账号列表中应当有且只有一个账号的主账号和子账号一致");
                return r;
            }
            //判断是否已存在,存在则修改，不存在新增
            List<T_USER_BIND_ACCOUNT> exitList = FromWhere(T_USER_BIND_ACCOUNT._.CREDIT_CODE == code).ToList();
            if (exitList.Count > 0)
            {
                //判断主账号是否已现有数据一致
                if (exitList[0].MAIN_U_ID != JdUser?.ID)
                {
                    r.SetFail("您的账号不是主账号，没有修改权限");
                    return r;
                }
                //批量删除并插入
                Delete(T_USER_BIND_ACCOUNT._.MAIN_U_ID == JdUser?.ID);
                accountList.ForEach(e => e.ID = Guid.NewGuid().ToString("N"));
                Insert(accountList);
                r.SetSuccess("保存成功");
                return r;
            }
            else
            {
                //批量赋值id
                accountList.ForEach(e => e.ID = Guid.NewGuid().ToString("N"));
                Insert(accountList);
                r.SetSuccess("保存成功");
                return r;
            }
        }
        /// <summary>
        /// 获取绑定账号列表
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetList()
        {
            var r = new GeneralResult();
#if DEBUG
            string code = "Y1350102J20030301D";
#else
            string code = JdUser?.UserExtend.UNIFIED_CREDIT_CODE;
#endif
            if (!string.IsNullOrEmpty(code))
            {
                var list = FromWhere(T_USER_BIND_ACCOUNT._.CREDIT_CODE == code).ToList();
                r.SetSuccess(list.Select(e => new
                {
                    e.ID,
                    e.MAIN_U_ID,
                    e.CHILD_U_ID,
                    e.CREDIT_CODE,
                    e.REMARK,
                    disabled = e.MAIN_U_ID == JdUser?.ID
                }));
            }
            else
            {
                r.SetFail("查询不到该账号的统一社会信用代码");
            }
            return r;
        }

        public JdMainUserModel GetMainUserIdByChidUsr(decimal? u_id)
        {
            var mainid = FromWhere(T_USER_BIND_ACCOUNT._.CHILD_U_ID == u_id).ToFirstDefault();
            if (mainid != null)
            {
                return Jd.TUserService.FromWhere(T_USER._.ID == mainid.MAIN_U_ID).ToFirst<JdMainUserModel>(); ;
            }

            return null;
        }
    }
}
