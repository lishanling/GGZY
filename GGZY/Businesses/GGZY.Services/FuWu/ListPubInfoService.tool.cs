using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ListPubInfoService : BaseServiceT<LIST_PUB_INFO>
    {
        #region 接口实现
        
		public List<LIST_PUB_INFO> FindList(LIST_PUB_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<LIST_PUB_INFO> PageList(LIST_PUB_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, LIST_PUB_INFO._.PROJECT_CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="PROJECT_CODE">项目编号</param>
      /// <param name="SELLER_CODE">转让方代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string PROJECT_CODE,string SELLER_CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(LIST_PUB_INFO._.PROJECT_CODE == PROJECT_CODE);
			condition.And(LIST_PUB_INFO._.SELLER_CODE == SELLER_CODE);
			
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
        public GeneralResult Edit(LIST_PUB_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.PROJECT_CODE,model.SELLER_CODE);
	
	if(viewResult.Success  && viewResult.Data is LIST_PUB_INFO entity)
	{		
		entity.Attach();
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PROJECT_CLASSIFY_CODE=model.PROJECT_CLASSIFY_CODE;
		entity.PROJECT_TYPE=model.PROJECT_TYPE;
		entity.SELLER_NAME=model.SELLER_NAME;
		entity.SELLER_CODE=model.SELLER_CODE;
		entity.SELLER_TYPE=model.SELLER_TYPE;
		entity.SELLER_ROLE=model.SELLER_ROLE;
		entity.ZONE=model.ZONE;
		entity.PROJECT_PRICE=model.PROJECT_PRICE;
		entity.PUBLISH_DURATION=model.PUBLISH_DURATION;
		entity.PUBLISH_DATE=model.PUBLISH_DATE;
		entity.POST_PONE=model.POST_PONE;
		entity.PRE_EXCHANGE_TYPE=model.PRE_EXCHANGE_TYPE;
		entity.TRANSFER_NOTES=model.TRANSFER_NOTES;
		entity.PROJECT_URL=model.PROJECT_URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(LIST_PUB_INFO model)
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
                    Delete(LIST_PUB_INFO._.PROJECT_CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<LIST_PUB_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(LIST_PUB_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(LIST_PUB_INFO._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(LIST_PUB_INFO._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(LIST_PUB_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CLASSIFY_CODE))
				{
				  condition.And(LIST_PUB_INFO._.PROJECT_CLASSIFY_CODE.Contain(model.PROJECT_CLASSIFY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
				{
				  condition.And(LIST_PUB_INFO._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_NAME))
				{
				  condition.And(LIST_PUB_INFO._.SELLER_NAME.Contain(model.SELLER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_CODE))
				{
				  condition.And(LIST_PUB_INFO._.SELLER_CODE.Contain(model.SELLER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_TYPE))
				{
				  condition.And(LIST_PUB_INFO._.SELLER_TYPE.Contain(model.SELLER_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_ROLE))
				{
				  condition.And(LIST_PUB_INFO._.SELLER_ROLE.Contain(model.SELLER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZONE))
				{
				  condition.And(LIST_PUB_INFO._.ZONE.Contain(model.ZONE));
				}
				if(model.PROJECT_PRICE!=null)
				{
				  condition.And(LIST_PUB_INFO._.PROJECT_PRICE==(model.PROJECT_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLISH_DURATION))
				{
				  condition.And(LIST_PUB_INFO._.PUBLISH_DURATION.Contain(model.PUBLISH_DURATION));
				}
				if(model.PUBLISH_DATE!=null)
				{
				  condition.And(LIST_PUB_INFO._.PUBLISH_DATE==(model.PUBLISH_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_PONE))
				{
				  condition.And(LIST_PUB_INFO._.POST_PONE.Contain(model.POST_PONE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRE_EXCHANGE_TYPE))
				{
				  condition.And(LIST_PUB_INFO._.PRE_EXCHANGE_TYPE.Contain(model.PRE_EXCHANGE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSFER_NOTES))
				{
				  condition.And(LIST_PUB_INFO._.TRANSFER_NOTES.Contain(model.TRANSFER_NOTES));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_URL))
				{
				  condition.And(LIST_PUB_INFO._.PROJECT_URL.Contain(model.PROJECT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(LIST_PUB_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(LIST_PUB_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(LIST_PUB_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}