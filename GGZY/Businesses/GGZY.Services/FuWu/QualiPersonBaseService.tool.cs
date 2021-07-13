using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class QualiPersonBaseService : BaseServiceT<QUALI_PERSON_BASE>
    {
        #region 接口实现
        
		public List<QUALI_PERSON_BASE> FindList(QUALI_PERSON_BASE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<QUALI_PERSON_BASE> PageList(QUALI_PERSON_BASE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, QUALI_PERSON_BASE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(QUALI_PERSON_BASE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(QUALI_PERSON_BASE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is QUALI_PERSON_BASE entity)
	{		
		entity.Attach();
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.PERSON_NAME=model.PERSON_NAME;
		entity.GENDER=model.GENDER;
		entity.BIRTHDATE=model.BIRTHDATE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.PERSON_EDU=model.PERSON_EDU;
		entity.PERSON_PHONE=model.PERSON_PHONE;
		entity.UNIT_CODE=model.UNIT_CODE;
		entity.UNIT_NAME=model.UNIT_NAME;
		entity.ON_JOB=model.ON_JOB;
		entity.JOB=model.JOB;
		entity.TECH_TITLE=model.TECH_TITLE;
		entity.WORK_START_DATE=model.WORK_START_DATE;
		entity.WORKING_EXPERIENCE=model.WORKING_EXPERIENCE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_ID_CARD_DOC=model.M_ATT_ID_CARD_DOC;
		entity.M_F_ID=model.M_F_ID;
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
        public GeneralResult Add(QUALI_PERSON_BASE model)
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
                    Delete(QUALI_PERSON_BASE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<QUALI_PERSON_BASE> model)
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
       	protected WhereClipBuilder ConditionBuilder(QUALI_PERSON_BASE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(QUALI_PERSON_BASE._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(QUALI_PERSON_BASE._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSON_NAME))
				{
				  condition.And(QUALI_PERSON_BASE._.PERSON_NAME.Contain(model.PERSON_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GENDER))
				{
				  condition.And(QUALI_PERSON_BASE._.GENDER.Contain(model.GENDER));
				}
				if(model.BIRTHDATE!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.BIRTHDATE==(model.BIRTHDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(QUALI_PERSON_BASE._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSON_EDU))
				{
				  condition.And(QUALI_PERSON_BASE._.PERSON_EDU.Contain(model.PERSON_EDU));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSON_PHONE))
				{
				  condition.And(QUALI_PERSON_BASE._.PERSON_PHONE.Contain(model.PERSON_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_CODE))
				{
				  condition.And(QUALI_PERSON_BASE._.UNIT_CODE.Contain(model.UNIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_NAME))
				{
				  condition.And(QUALI_PERSON_BASE._.UNIT_NAME.Contain(model.UNIT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ON_JOB))
				{
				  condition.And(QUALI_PERSON_BASE._.ON_JOB.Contain(model.ON_JOB));
				}
				if(!string.IsNullOrWhiteSpace(model.JOB))
				{
				  condition.And(QUALI_PERSON_BASE._.JOB.Contain(model.JOB));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_TITLE))
				{
				  condition.And(QUALI_PERSON_BASE._.TECH_TITLE.Contain(model.TECH_TITLE));
				}
				if(model.WORK_START_DATE!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.WORK_START_DATE==(model.WORK_START_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.WORKING_EXPERIENCE))
				{
				  condition.And(QUALI_PERSON_BASE._.WORKING_EXPERIENCE.Contain(model.WORKING_EXPERIENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(QUALI_PERSON_BASE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(QUALI_PERSON_BASE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(QUALI_PERSON_BASE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(QUALI_PERSON_BASE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_ID_CARD_DOC))
				{
				  condition.And(QUALI_PERSON_BASE._.M_ATT_ID_CARD_DOC.Contain(model.M_ATT_ID_CARD_DOC));
				}
				if(model.M_F_ID!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.M_F_ID==(model.M_F_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(QUALI_PERSON_BASE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(QUALI_PERSON_BASE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}