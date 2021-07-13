using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TransferEnteHolderPreService : BaseServiceT<TRANSFER_ENTE_HOLDER_PRE>
    {
        #region 接口实现
        
		public List<TRANSFER_ENTE_HOLDER_PRE> FindList(TRANSFER_ENTE_HOLDER_PRE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TRANSFER_ENTE_HOLDER_PRE> PageList(TRANSFER_ENTE_HOLDER_PRE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TRANSFER_ENTE_HOLDER_PRE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TRANSFER_ENTE_HOLDER_PRE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TRANSFER_ENTE_HOLDER_PRE entity)
	{		
		entity.Attach();
		entity.SUBJECT_COMPANY_NAME=model.SUBJECT_COMPANY_NAME;
		entity.SUBJECT_COMPANY_CODE=model.SUBJECT_COMPANY_CODE;
		entity.TOP10_HOLDER_NAME=model.TOP10_HOLDER_NAME;
		entity.TOP10_HOLDER_NUMBER=model.TOP10_HOLDER_NUMBER;
		entity.TOP10_HOLDER_PERCENT=model.TOP10_HOLDER_PERCENT;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.M_ID=model.M_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_PRE_ID=model.M_PRE_ID;
		entity.M_UNIFIED_DEAL_CODE=model.M_UNIFIED_DEAL_CODE;
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
        public GeneralResult Add(TRANSFER_ENTE_HOLDER_PRE model)
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
                    Delete(TRANSFER_ENTE_HOLDER_PRE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TRANSFER_ENTE_HOLDER_PRE> model)
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
       	protected WhereClipBuilder ConditionBuilder(TRANSFER_ENTE_HOLDER_PRE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.SUBJECT_COMPANY_NAME))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.SUBJECT_COMPANY_NAME.Contain(model.SUBJECT_COMPANY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBJECT_COMPANY_CODE))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.SUBJECT_COMPANY_CODE.Contain(model.SUBJECT_COMPANY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TOP10_HOLDER_NAME))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.TOP10_HOLDER_NAME.Contain(model.TOP10_HOLDER_NAME));
				}
				if(model.TOP10_HOLDER_NUMBER!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.TOP10_HOLDER_NUMBER==(model.TOP10_HOLDER_NUMBER));
				}
				if(model.TOP10_HOLDER_PERCENT!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.TOP10_HOLDER_PERCENT==(model.TOP10_HOLDER_PERCENT));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_PRE_ID!=null)
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_PRE_ID==(model.M_PRE_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_UNIFIED_DEAL_CODE))
				{
				  condition.And(TRANSFER_ENTE_HOLDER_PRE._.M_UNIFIED_DEAL_CODE.Contain(model.M_UNIFIED_DEAL_CODE));
				}
		return condition;
	}
        #endregion
    }
}