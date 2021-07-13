using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CorrectionItemService : BaseServiceT<CORRECTION_ITEM>
    {
        #region 接口实现
        
		public List<CORRECTION_ITEM> FindList(CORRECTION_ITEM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<CORRECTION_ITEM> PageList(CORRECTION_ITEM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, CORRECTION_ITEM._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(CORRECTION_ITEM._.M_ID == M_ID);
			
			  var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Edit(CORRECTION_ITEM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is CORRECTION_ITEM entity)
	{		
		entity.Attach();
		entity.PURCHASE_PROJECT_CODE=model.PURCHASE_PROJECT_CODE;
		entity.PURCHASE_PROJECT_NAME=model.PURCHASE_PROJECT_NAME;
		entity.PURCHASE_SECTION_CODE=model.PURCHASE_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.TERMINATION_BULLETIN_TITLE=model.TERMINATION_BULLETIN_TITLE;
		entity.TERMINATION_BULLETIN_CONTENT=model.TERMINATION_BULLETIN_CONTENT;
		entity.MODIFICATION_START_TIME=model.MODIFICATION_START_TIME;
		entity.URL=model.URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_MODIFICATION_ITEM=model.M_ATT_MODIFICATION_ITEM;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.M_VERSION=model.M_VERSION;
		entity.POST_BID_CLOSING_TIME=model.POST_BID_CLOSING_TIME;
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
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(CORRECTION_ITEM model)
        {
            var result = new GeneralResult();
            try
            {
                Insert(model);
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result; 
        }
		
		
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public GeneralResult Delete(params string[] ids)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                List<string>idArr=new List<string>();
                foreach (var id in ids)
                {
                    idArr.AddRange(id.Split(','));
                }
				
                if (idArr.Any())
                {
                    Delete(CORRECTION_ITEM._.M_ID.SelectIn(idArr));
                    result.SetSuccess(ids);
                }
                else
                {
                    result.SetFail($"请选择要删除的记录");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result.SetFail(e.Message, e);
            }
            return result;
        }
		
		/// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<CORRECTION_ITEM> model)
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
       	protected WhereClipBuilder ConditionBuilder(CORRECTION_ITEM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_CODE))
				{
				  condition.And(CORRECTION_ITEM._.PURCHASE_PROJECT_CODE.Contain(model.PURCHASE_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_NAME))
				{
				  condition.And(CORRECTION_ITEM._.PURCHASE_PROJECT_NAME.Contain(model.PURCHASE_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_CODE))
				{
				  condition.And(CORRECTION_ITEM._.PURCHASE_SECTION_CODE.Contain(model.PURCHASE_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(CORRECTION_ITEM._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TERMINATION_BULLETIN_TITLE))
				{
				  condition.And(CORRECTION_ITEM._.TERMINATION_BULLETIN_TITLE.Contain(model.TERMINATION_BULLETIN_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TERMINATION_BULLETIN_CONTENT))
				{
				  condition.And(CORRECTION_ITEM._.TERMINATION_BULLETIN_CONTENT.Contain(model.TERMINATION_BULLETIN_CONTENT));
				}
				if(model.MODIFICATION_START_TIME!=null)
				{
				  condition.And(CORRECTION_ITEM._.MODIFICATION_START_TIME==(model.MODIFICATION_START_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(CORRECTION_ITEM._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(CORRECTION_ITEM._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(CORRECTION_ITEM._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(CORRECTION_ITEM._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(CORRECTION_ITEM._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(CORRECTION_ITEM._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(CORRECTION_ITEM._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(CORRECTION_ITEM._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_MODIFICATION_ITEM))
				{
				  condition.And(CORRECTION_ITEM._.M_ATT_MODIFICATION_ITEM.Contain(model.M_ATT_MODIFICATION_ITEM));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(CORRECTION_ITEM._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(CORRECTION_ITEM._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(CORRECTION_ITEM._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(CORRECTION_ITEM._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(CORRECTION_ITEM._.M_VERSION.Contain(model.M_VERSION));
				}
				if(model.POST_BID_CLOSING_TIME!=null)
				{
				  condition.And(CORRECTION_ITEM._.POST_BID_CLOSING_TIME==(model.POST_BID_CLOSING_TIME));
				}
		return condition;
	}
        #endregion
    }
}