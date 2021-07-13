using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SocialCreditInfoService : BaseServiceT<SOCIAL_CREDIT_INFO>
    {
        #region 接口实现
        
		public List<SOCIAL_CREDIT_INFO> FindList(SOCIAL_CREDIT_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SOCIAL_CREDIT_INFO> PageList(SOCIAL_CREDIT_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SOCIAL_CREDIT_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SOCIAL_CREDIT_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SOCIAL_CREDIT_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SOCIAL_CREDIT_INFO entity)
	{		
		entity.Attach();
		entity.BODY_CODE=model.BODY_CODE;
		entity.BODY_NAME=model.BODY_NAME;
		entity.BODY_TYPE=model.BODY_TYPE;
		entity.BODY_ROLE=model.BODY_ROLE;
		entity.DATA=model.DATA;
		entity.SCOPE=model.SCOPE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_FILES=model.M_FILES;
		entity.M_ID=model.M_ID;
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
        public GeneralResult Add(SOCIAL_CREDIT_INFO model)
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
                    Delete(SOCIAL_CREDIT_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SOCIAL_CREDIT_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(SOCIAL_CREDIT_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BODY_CODE))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.BODY_CODE.Contain(model.BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_NAME))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.BODY_NAME.Contain(model.BODY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_TYPE))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.BODY_TYPE.Contain(model.BODY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_ROLE))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.BODY_ROLE.Contain(model.BODY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.DATA.Contain(model.DATA));
				}
				if(model.SCOPE!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.SCOPE==(model.SCOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_FILES))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_FILES.Contain(model.M_FILES));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SOCIAL_CREDIT_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}