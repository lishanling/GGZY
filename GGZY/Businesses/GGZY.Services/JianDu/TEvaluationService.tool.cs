using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TEvaluationService : BaseServiceT<T_EVALUATION>
    {
        #region 接口实现
        
		public List<T_EVALUATION> FindList(T_EVALUATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EVALUATION> PageList(T_EVALUATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EVALUATION._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EVALUATION._.ID == ID);
			
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
        public GeneralResult Edit(T_EVALUATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_EVALUATION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.EXPERT_NO=model.EXPERT_NO;
		entity.EXPERT_NAME=model.EXPERT_NAME;
		entity.SEX=model.SEX;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.ID_CARD=model.ID_CARD;
		entity.BIRTHDAY=model.BIRTHDAY;
		entity.AREA=model.AREA;
		entity.EDUCATE_SCHOLL=model.EDUCATE_SCHOLL;
		entity.EDUCATION=model.EDUCATION;
		entity.PHONE_NUMBER=model.PHONE_NUMBER;
		entity.POST_ADDRESS=model.POST_ADDRESS;
		entity.POSTCODE=model.POSTCODE;
		entity.COMPANY=model.COMPANY;
		entity.ONWORK=model.ONWORK;
		entity.POST=model.POST;
		entity.JOB_RESUME=model.JOB_RESUME;
		entity.MAJOR_CLASSIFIY=model.MAJOR_CLASSIFIY;
		entity.TECHNICAL_TITLE=model.TECHNICAL_TITLE;
		entity.PROFESSION_SEQUENCE=model.PROFESSION_SEQUENCE;
		entity.PROFESSION_REGISTER=model.PROFESSION_REGISTER;
		entity.WORK_YEAR=model.WORK_YEAR;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_KEY=model.M_KEY;
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
        public GeneralResult Add(T_EVALUATION model)
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
                    Delete(T_EVALUATION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EVALUATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EVALUATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_EVALUATION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NO))
				{
				  condition.And(T_EVALUATION._.EXPERT_NO.Contain(model.EXPERT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
				{
				  condition.And(T_EVALUATION._.EXPERT_NAME.Contain(model.EXPERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SEX))
				{
				  condition.And(T_EVALUATION._.SEX.Contain(model.SEX));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(T_EVALUATION._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(T_EVALUATION._.ID_CARD.Contain(model.ID_CARD));
				}
				if(model.BIRTHDAY!=null)
				{
				  condition.And(T_EVALUATION._.BIRTHDAY==(model.BIRTHDAY));
				}
				if(!string.IsNullOrWhiteSpace(model.AREA))
				{
				  condition.And(T_EVALUATION._.AREA.Contain(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.EDUCATE_SCHOLL))
				{
				  condition.And(T_EVALUATION._.EDUCATE_SCHOLL.Contain(model.EDUCATE_SCHOLL));
				}
				if(!string.IsNullOrWhiteSpace(model.EDUCATION))
				{
				  condition.And(T_EVALUATION._.EDUCATION.Contain(model.EDUCATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE_NUMBER))
				{
				  condition.And(T_EVALUATION._.PHONE_NUMBER.Contain(model.PHONE_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_ADDRESS))
				{
				  condition.And(T_EVALUATION._.POST_ADDRESS.Contain(model.POST_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.POSTCODE))
				{
				  condition.And(T_EVALUATION._.POSTCODE.Contain(model.POSTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY))
				{
				  condition.And(T_EVALUATION._.COMPANY.Contain(model.COMPANY));
				}
				if(!string.IsNullOrWhiteSpace(model.ONWORK))
				{
				  condition.And(T_EVALUATION._.ONWORK.Contain(model.ONWORK));
				}
				if(!string.IsNullOrWhiteSpace(model.POST))
				{
				  condition.And(T_EVALUATION._.POST.Contain(model.POST));
				}
				if(!string.IsNullOrWhiteSpace(model.JOB_RESUME))
				{
				  condition.And(T_EVALUATION._.JOB_RESUME.Contain(model.JOB_RESUME));
				}
				if(!string.IsNullOrWhiteSpace(model.MAJOR_CLASSIFIY))
				{
				  condition.And(T_EVALUATION._.MAJOR_CLASSIFIY.Contain(model.MAJOR_CLASSIFIY));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_TITLE))
				{
				  condition.And(T_EVALUATION._.TECHNICAL_TITLE.Contain(model.TECHNICAL_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROFESSION_SEQUENCE))
				{
				  condition.And(T_EVALUATION._.PROFESSION_SEQUENCE.Contain(model.PROFESSION_SEQUENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROFESSION_REGISTER))
				{
				  condition.And(T_EVALUATION._.PROFESSION_REGISTER.Contain(model.PROFESSION_REGISTER));
				}
				if(model.WORK_YEAR!=null)
				{
				  condition.And(T_EVALUATION._.WORK_YEAR==(model.WORK_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_EVALUATION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_EVALUATION._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_EVALUATION._.M_KEY.Contain(model.M_KEY));
				}
		return condition;
	}
        #endregion
    }
}