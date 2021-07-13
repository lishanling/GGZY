using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvTjAllcreateXzjdService : BaseServiceT<MV_TJ_ALLCREATE_XZJD>
    {
        #region 接口实现

        public List<MV_TJ_ALLCREATE_XZJD> FindList(MV_TJ_ALLCREATE_XZJD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MV_TJ_ALLCREATE_XZJD> PageList(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<MV_TJ_ALLCREATE_XZJD> model)
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
        protected WhereClipBuilder ConditionBuilder(MV_TJ_ALLCREATE_XZJD model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.M_ID != null)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.M_ID == (model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
            }
            if (model.PROJECT_CATEGORY != null)
            {
                if (model.PROJECT_CATEGORY == -1)//非工程建设 全部
                {
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY!=1);
                }
                else if (model.PROJECT_CATEGORY == 4 || model.PROJECT_CATEGORY == 5)//矿业权
                {
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY.In(4,5));
                }
                else
                {
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY == (model.PROJECT_CATEGORY));
                }
               
            }
            if (!string.IsNullOrWhiteSpace(model.KIND))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.KIND.Contain(model.KIND));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.Contain(model.PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME.Contain(model.PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                if (model.PROJECT_TYPE.Contains(","))
                {
                    var projectType = model.PROJECT_TYPE.Split(',').ToList();
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE.In(projectType));
                }
                else
                {
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
                }
               
            }
            if (!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.T_TM != null)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.T_TM == (model.T_TM));
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.REGION_CODE.Contain(model.REGION_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.AREACODE.Contain(model.AREACODE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREANAME))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.AREANAME.Contain(model.AREANAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PLATFORM_NAME))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.PLATFORM_NAME.Contain(model.PLATFORM_NAME));
            }
            if (model.BID_OPEN_TIME != null)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.BID_OPEN_TIME == (model.BID_OPEN_TIME));
            }
            return condition;
        }
        #endregion
    }
}