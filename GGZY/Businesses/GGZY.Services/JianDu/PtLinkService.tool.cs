using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtLinkService : BaseServiceT<PT_LINK>
    {
        #region 接口实现

        public List<PT_LINK> FindList(PT_LINK model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_LINK> PageList(PT_LINK model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, PT_LINK._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<PT_LINK> model)
        {
            GeneralResult result = new GeneralResult();
            try
            {

                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }


        #endregion

        #region Utils
        protected WhereClipBuilder ConditionBuilder(PT_LINK model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(PT_LINK._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TITLE))
            {
                condition.And(PT_LINK._.TITLE.Contain(model.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.ADDRESS))
            {
                condition.And(PT_LINK._.ADDRESS.Contain(model.ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.TYPE))
            {
                condition.And(PT_LINK._.TYPE.Contain(model.TYPE));
            }
            if (model.TIME != null)
            {
                condition.And(PT_LINK._.TIME == (model.TIME));
            }
            if (model.ORDERID != null)
            {
                condition.And(PT_LINK._.ORDERID == (model.ORDERID));
            }
            return condition;
        }
        #endregion
    }
}