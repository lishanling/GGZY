using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderAgentExInfoService : BaseServiceT<TENDER_AGENT_EX_INFO>
    {
        #region 接口实现
        
		public List<TENDER_AGENT_EX_INFO> FindList(TENDER_AGENT_EX_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_AGENT_EX_INFO> PageList(TENDER_AGENT_EX_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_AGENT_EX_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TENDER_AGENT_EX_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TENDER_AGENT_EX_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_AGENT_EX_INFO entity)
	{		
		entity.Attach();
		entity.LEGAL_CODE=model.LEGAL_CODE;
		entity.QUAL_LEVEL=model.QUAL_LEVEL;
		entity.QUAL_NAME=model.QUAL_NAME;
		entity.QUAL_TYPE=model.QUAL_TYPE;
		entity.QUAL_CERT_NO=model.QUAL_CERT_NO;
		entity.QUAL_CERT_END_DATE=model.QUAL_CERT_END_DATE;
		entity.CUSTOM_DEFINITION_DATAITEM=model.CUSTOM_DEFINITION_DATAITEM;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_F_ID=model.M_F_ID;
		entity.M_ATT_QUAL_CART_DOC=model.M_ATT_QUAL_CART_DOC;
		entity.M_ID=model.M_ID;
		entity.M_USER_ID=model.M_USER_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
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
        public GeneralResult Add(TENDER_AGENT_EX_INFO model)
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
                    Delete(TENDER_AGENT_EX_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_AGENT_EX_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_AGENT_EX_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.LEGAL_CODE.Contain(model.LEGAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_LEVEL))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.QUAL_LEVEL.Contain(model.QUAL_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_NAME))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.QUAL_NAME.Contain(model.QUAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_CERT_NO))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.QUAL_CERT_NO.Contain(model.QUAL_CERT_NO));
				}
				if(model.QUAL_CERT_END_DATE!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.QUAL_CERT_END_DATE==(model.QUAL_CERT_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CUSTOM_DEFINITION_DATAITEM))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.CUSTOM_DEFINITION_DATAITEM.Contain(model.CUSTOM_DEFINITION_DATAITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_F_ID!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_F_ID==(model.M_F_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUAL_CART_DOC))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_ATT_QUAL_CART_DOC.Contain(model.M_ATT_QUAL_CART_DOC));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_USER_ID!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_USER_ID==(model.M_USER_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(TENDER_AGENT_EX_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}