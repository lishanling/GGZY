using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PurchaseQualiInqueryAnnService : BaseServiceT<PURCHASE_QUALI_INQUERY_ANN>
    {
        #region 接口实现
        
		public List<PURCHASE_QUALI_INQUERY_ANN> FindList(PURCHASE_QUALI_INQUERY_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PURCHASE_QUALI_INQUERY_ANN> PageList(PURCHASE_QUALI_INQUERY_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PURCHASE_QUALI_INQUERY_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PURCHASE_QUALI_INQUERY_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PURCHASE_QUALI_INQUERY_ANN entity)
	{		
		entity.Attach();
		entity.PURCHASE_PROJECT_CODE=model.PURCHASE_PROJECT_CODE;
		entity.PURCHASE_PROJECT_NAME=model.PURCHASE_PROJECT_NAME;
		entity.PURCHASE_SECTION_CODE=model.PURCHASE_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BULLETIN_TITLE=model.BULLETIN_TITLE;
		entity.BULLETIN_CONTENT=model.BULLETIN_CONTENT;
		entity.BULLETIN_START_TIME=model.BULLETIN_START_TIME;
		entity.BULLETIN_MEDIA=model.BULLETIN_MEDIA;
		entity.URL=model.URL;
		entity.BID_CLOSING_TIME=model.BID_CLOSING_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_PURCHASE_FILE=model.M_ATT_PURCHASE_FILE;
		entity.M_ATT_PURCHASE_NOTICE=model.M_ATT_PURCHASE_NOTICE;
		entity.M_ATT_QUALIFI_PREVIEW_FILE=model.M_ATT_QUALIFI_PREVIEW_FILE;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.BULLETIN_BID_NUM=model.BULLETIN_BID_NUM;
		entity.M_VERSION=model.M_VERSION;
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
        public GeneralResult Add(PURCHASE_QUALI_INQUERY_ANN model)
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
                    Delete(PURCHASE_QUALI_INQUERY_ANN._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PURCHASE_QUALI_INQUERY_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(PURCHASE_QUALI_INQUERY_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_CODE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.PURCHASE_PROJECT_CODE.Contain(model.PURCHASE_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_NAME))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.PURCHASE_PROJECT_NAME.Contain(model.PURCHASE_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_CODE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.PURCHASE_SECTION_CODE.Contain(model.PURCHASE_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_TITLE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_TITLE.Contain(model.BULLETIN_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_CONTENT))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_CONTENT.Contain(model.BULLETIN_CONTENT));
				}
				if(model.BULLETIN_START_TIME!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_START_TIME==(model.BULLETIN_START_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_MEDIA))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_MEDIA.Contain(model.BULLETIN_MEDIA));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.URL.Contain(model.URL));
				}
				if(model.BID_CLOSING_TIME!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.BID_CLOSING_TIME==(model.BID_CLOSING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PURCHASE_FILE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_ATT_PURCHASE_FILE.Contain(model.M_ATT_PURCHASE_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PURCHASE_NOTICE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_ATT_PURCHASE_NOTICE.Contain(model.M_ATT_PURCHASE_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUALIFI_PREVIEW_FILE))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_ATT_QUALIFI_PREVIEW_FILE.Contain(model.M_ATT_QUALIFI_PREVIEW_FILE));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.BULLETIN_BID_NUM!=null)
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_BID_NUM==(model.BULLETIN_BID_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PURCHASE_QUALI_INQUERY_ANN._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}