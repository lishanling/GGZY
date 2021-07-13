using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class EcaPcaxService : BaseServiceT<ECA_PCAX>
    {
        #region 接口实现
        
		public List<ECA_PCAX> FindList(ECA_PCAX model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ECA_PCAX> PageList(ECA_PCAX model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ECA_PCAX._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ECA_PCAX._.ID == ID);
			
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
        public GeneralResult Edit(ECA_PCAX model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is ECA_PCAX entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.EPLY_CODE=model.EPLY_CODE;
		entity.NAME=model.NAME;
		entity.GENDER=model.GENDER;
		entity.DATE_BIRTHDAY=model.DATE_BIRTHDAY;
		entity.ADMITA_CODE=model.ADMITA_CODE;
		entity.HIGHEST_EDU=model.HIGHEST_EDU;
		entity.CNT_NUMBER=model.CNT_NUMBER;
		entity.POS_ADDRESS=model.POS_ADDRESS;
		entity.POSTCODE=model.POSTCODE;
		entity.WTU_CODE=model.WTU_CODE;
		entity.IS_JOB=model.IS_JOB;
		entity.POST=model.POST;
		entity.TECH_TITLE=model.TECH_TITLE;
		entity.WORK_EXP=model.WORK_EXP;
		entity.WORK_YEARS=model.WORK_YEARS;
		entity.PQ_SEQUENCE=model.PQ_SEQUENCE;
		entity.PQ_LEVEL=model.PQ_LEVEL;
		entity.QC_CODE=model.QC_CODE;
		entity.RC_CODE=model.RC_CODE;
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
        public GeneralResult Add(ECA_PCAX model)
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
                    Delete(ECA_PCAX._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ECA_PCAX> model)
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
       	protected WhereClipBuilder ConditionBuilder(ECA_PCAX model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(ECA_PCAX._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.EPLY_CODE))
				{
				  condition.And(ECA_PCAX._.EPLY_CODE.Contain(model.EPLY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ECA_PCAX._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GENDER))
				{
				  condition.And(ECA_PCAX._.GENDER.Contain(model.GENDER));
				}
				if(model.DATE_BIRTHDAY!=null)
				{
				  condition.And(ECA_PCAX._.DATE_BIRTHDAY==(model.DATE_BIRTHDAY));
				}
				if(!string.IsNullOrWhiteSpace(model.ADMITA_CODE))
				{
				  condition.And(ECA_PCAX._.ADMITA_CODE.Contain(model.ADMITA_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.HIGHEST_EDU))
				{
				  condition.And(ECA_PCAX._.HIGHEST_EDU.Contain(model.HIGHEST_EDU));
				}
				if(!string.IsNullOrWhiteSpace(model.CNT_NUMBER))
				{
				  condition.And(ECA_PCAX._.CNT_NUMBER.Contain(model.CNT_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.POS_ADDRESS))
				{
				  condition.And(ECA_PCAX._.POS_ADDRESS.Contain(model.POS_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.POSTCODE))
				{
				  condition.And(ECA_PCAX._.POSTCODE.Contain(model.POSTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WTU_CODE))
				{
				  condition.And(ECA_PCAX._.WTU_CODE.Contain(model.WTU_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_JOB))
				{
				  condition.And(ECA_PCAX._.IS_JOB.Contain(model.IS_JOB));
				}
				if(!string.IsNullOrWhiteSpace(model.POST))
				{
				  condition.And(ECA_PCAX._.POST.Contain(model.POST));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_TITLE))
				{
				  condition.And(ECA_PCAX._.TECH_TITLE.Contain(model.TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.WORK_EXP))
				{
				  condition.And(ECA_PCAX._.WORK_EXP.Contain(model.WORK_EXP));
				}
				if(!string.IsNullOrWhiteSpace(model.WORK_YEARS))
				{
				  condition.And(ECA_PCAX._.WORK_YEARS.Contain(model.WORK_YEARS));
				}
				if(!string.IsNullOrWhiteSpace(model.PQ_SEQUENCE))
				{
				  condition.And(ECA_PCAX._.PQ_SEQUENCE.Contain(model.PQ_SEQUENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.PQ_LEVEL))
				{
				  condition.And(ECA_PCAX._.PQ_LEVEL.Contain(model.PQ_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.QC_CODE))
				{
				  condition.And(ECA_PCAX._.QC_CODE.Contain(model.QC_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.RC_CODE))
				{
				  condition.And(ECA_PCAX._.RC_CODE.Contain(model.RC_CODE));
				}
		return condition;
	}
        #endregion
    }
}