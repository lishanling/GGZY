using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ExpertBidEvaluationService : BaseServiceT<EXPERT_BID_EVALUATION>
    {
        #region 接口实现
        
		public List<EXPERT_BID_EVALUATION> FindList(EXPERT_BID_EVALUATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<EXPERT_BID_EVALUATION> PageList(EXPERT_BID_EVALUATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, EXPERT_BID_EVALUATION._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(EXPERT_BID_EVALUATION._.M_ID == M_ID);
			
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
        public GeneralResult Edit(EXPERT_BID_EVALUATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is EXPERT_BID_EVALUATION entity)
	{		
		entity.Attach();
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.EXPERT_NAME=model.EXPERT_NAME;
		entity.SEX=model.SEX;
		entity.BIRTHDAY=model.BIRTHDAY;
		entity.DUTY=model.DUTY;
		entity.EDUCATION=model.EDUCATION;
		entity.PROFESSIONAL=model.PROFESSIONAL;
		entity.ONWORK=model.ONWORK;
		entity.COMPANY=model.COMPANY;
		entity.POST_ADDRESS=model.POST_ADDRESS;
		entity.POSTCODE=model.POSTCODE;
		entity.INDUSTRY=model.INDUSTRY;
		entity.AREA=model.AREA;
		entity.WORK_YEAR=model.WORK_YEAR;
		entity.PHONE_NUMBER=model.PHONE_NUMBER;
		entity.OTHER_NUMBER=model.OTHER_NUMBER;
		entity.DMISSON=model.DMISSON;
		entity.ENTER_DATE=model.ENTER_DATE;
		entity.BASE_TYPE=model.BASE_TYPE;
		entity.MAJOR_CODE=model.MAJOR_CODE;
		entity.IS_MAIN=model.IS_MAIN;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
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
        public GeneralResult Add(EXPERT_BID_EVALUATION model)
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
                    Delete(EXPERT_BID_EVALUATION._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<EXPERT_BID_EVALUATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(EXPERT_BID_EVALUATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(EXPERT_BID_EVALUATION._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(EXPERT_BID_EVALUATION._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
				{
				  condition.And(EXPERT_BID_EVALUATION._.EXPERT_NAME.Contain(model.EXPERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SEX))
				{
				  condition.And(EXPERT_BID_EVALUATION._.SEX.Contain(model.SEX));
				}
				if(model.BIRTHDAY!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.BIRTHDAY==(model.BIRTHDAY));
				}
				if(!string.IsNullOrWhiteSpace(model.DUTY))
				{
				  condition.And(EXPERT_BID_EVALUATION._.DUTY.Contain(model.DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.EDUCATION))
				{
				  condition.And(EXPERT_BID_EVALUATION._.EDUCATION.Contain(model.EDUCATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROFESSIONAL))
				{
				  condition.And(EXPERT_BID_EVALUATION._.PROFESSIONAL.Contain(model.PROFESSIONAL));
				}
				if(!string.IsNullOrWhiteSpace(model.ONWORK))
				{
				  condition.And(EXPERT_BID_EVALUATION._.ONWORK.Contain(model.ONWORK));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY))
				{
				  condition.And(EXPERT_BID_EVALUATION._.COMPANY.Contain(model.COMPANY));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_ADDRESS))
				{
				  condition.And(EXPERT_BID_EVALUATION._.POST_ADDRESS.Contain(model.POST_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.POSTCODE))
				{
				  condition.And(EXPERT_BID_EVALUATION._.POSTCODE.Contain(model.POSTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRY))
				{
				  condition.And(EXPERT_BID_EVALUATION._.INDUSTRY.Contain(model.INDUSTRY));
				}
				if(!string.IsNullOrWhiteSpace(model.AREA))
				{
				  condition.And(EXPERT_BID_EVALUATION._.AREA.Contain(model.AREA));
				}
				if(model.WORK_YEAR!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.WORK_YEAR==(model.WORK_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE_NUMBER))
				{
				  condition.And(EXPERT_BID_EVALUATION._.PHONE_NUMBER.Contain(model.PHONE_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_NUMBER))
				{
				  condition.And(EXPERT_BID_EVALUATION._.OTHER_NUMBER.Contain(model.OTHER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.DMISSON))
				{
				  condition.And(EXPERT_BID_EVALUATION._.DMISSON.Contain(model.DMISSON));
				}
				if(model.ENTER_DATE!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.ENTER_DATE==(model.ENTER_DATE));
				}
				if(model.BASE_TYPE!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.BASE_TYPE==(model.BASE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.MAJOR_CODE))
				{
				  condition.And(EXPERT_BID_EVALUATION._.MAJOR_CODE.Contain(model.MAJOR_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_MAIN))
				{
				  condition.And(EXPERT_BID_EVALUATION._.IS_MAIN.Contain(model.IS_MAIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(EXPERT_BID_EVALUATION._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(EXPERT_BID_EVALUATION._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(EXPERT_BID_EVALUATION._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}