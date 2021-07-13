using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvUserTenderListService : BaseServiceT<MV_USER_TENDER_LIST>
    {
        #region 接口实现

        public List<MV_USER_TENDER_LIST> FindList(MV_USER_TENDER_LIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MV_USER_TENDER_LIST> PageList(MV_USER_TENDER_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, MV_USER_TENDER_LIST._.RATE.Desc).ToBootstrapTableList(count);
            return pageList;
        }






        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<MV_USER_TENDER_LIST> model)
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
        protected WhereClipBuilder ConditionBuilder(MV_USER_TENDER_LIST model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.LEGAL_NAME))
            {
                condition.And(MV_USER_TENDER_LIST._.LEGAL_NAME.Contain(model.LEGAL_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SHI))
            {
                condition.And(MV_USER_TENDER_LIST._.SHI.Contain(model.SHI));
            }
            if (!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
            {
                condition.And(MV_USER_TENDER_LIST._.LEGAL_CODE.Contain(model.LEGAL_CODE));
            }
            if (model.COUNT != null)
            {
                condition.And(MV_USER_TENDER_LIST._.COUNT == (model.COUNT));
            }
            if (model.WIN_COUNT != null)
            {
                condition.And(MV_USER_TENDER_LIST._.WIN_COUNT == (model.WIN_COUNT));
            }
            if (model.RATE != null)
            {
                condition.And(MV_USER_TENDER_LIST._.RATE == (model.RATE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(MV_USER_TENDER_LIST._.AREACODE.Contain(model.AREACODE));
            }
            return condition;
        }
        #endregion
    }
}