using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class VUnifyUserService : BaseServiceT<V_UNIFY_USER>
    {
        #region 接口实现

        public List<V_UNIFY_USER> FindList(V_UNIFY_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<V_UNIFY_USER> PageList(V_UNIFY_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, V_UNIFY_USER._.REG_TM.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        #endregion

        #region Utils
        protected WhereClipBuilder ConditionBuilder(V_UNIFY_USER model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.APPKEY))
            {
                condition.And(V_UNIFY_USER._.APPKEY.Contain(model.APPKEY));
            }
            if (model.ID != null)
            {
                condition.And(V_UNIFY_USER._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.USERNAME))
            {
                condition.And(V_UNIFY_USER._.USERNAME.Contain(model.USERNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PASSWORD))
            {
                condition.And(V_UNIFY_USER._.PASSWORD.Contain(model.PASSWORD));
            }
            if (!string.IsNullOrWhiteSpace(model.EMAIL))
            {
                condition.And(V_UNIFY_USER._.EMAIL.Contain(model.EMAIL));
            }
            if (model.TYPE != null)
            {
                condition.And(V_UNIFY_USER._.TYPE == (model.TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.CA_CODE))
            {
                condition.And(V_UNIFY_USER._.CA_CODE.Contain(model.CA_CODE));
            }
            if (model.REG_TM != null)
            {
                condition.And(V_UNIFY_USER._.REG_TM == (model.REG_TM));
            }
            if (!string.IsNullOrWhiteSpace(model.API_CODE))
            {
                condition.And(V_UNIFY_USER._.API_CODE.Contain(model.API_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.API_KEY))
            {
                condition.And(V_UNIFY_USER._.API_KEY.Contain(model.API_KEY));
            }
            if (!string.IsNullOrWhiteSpace(model.ROLEIDS))
            {
                condition.And(V_UNIFY_USER._.ROLEIDS.Contain(model.ROLEIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.SESSION_ID))
            {
                condition.And(V_UNIFY_USER._.SESSION_ID.Contain(model.SESSION_ID));
            }
            if (model.P_ID != null)
            {
                condition.And(V_UNIFY_USER._.P_ID == (model.P_ID));
            }
            if (model.GENDER != null)
            {
                condition.And(V_UNIFY_USER._.GENDER == (model.GENDER));
            }
            if (model.IS_ENABLE != null)
            {
                condition.And(V_UNIFY_USER._.IS_ENABLE == (model.IS_ENABLE));
            }
            if (!string.IsNullOrWhiteSpace(model.COMPANY_CODE))
            {
                condition.And(V_UNIFY_USER._.COMPANY_CODE.Contain(model.COMPANY_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.MANAGE_NAME))
            {
                condition.And(V_UNIFY_USER._.MANAGE_NAME.Contain(model.MANAGE_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(V_UNIFY_USER._.AREACODE.Contain(model.AREACODE));
            }
            if (!string.IsNullOrWhiteSpace(model.MOBILE))
            {
                condition.And(V_UNIFY_USER._.MOBILE.Contain(model.MOBILE));
            }
            return condition;
        }
        #endregion
    }
}