using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TExpertExtractionService : BaseServiceT<T_EXPERT_EXTRACTION>
    {
        #region 接口实现
        
		public List<T_EXPERT_EXTRACTION> FindList(T_EXPERT_EXTRACTION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EXPERT_EXTRACTION> PageList(T_EXPERT_EXTRACTION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EXPERT_EXTRACTION._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_EXPERT_EXTRACTION._.ID == ID);
			
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
        public GeneralResult Edit(T_EXPERT_EXTRACTION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_EXPERT_EXTRACTION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.EXPERT_NO=model.EXPERT_NO;
		entity.EXPERT_NAME=model.EXPERT_NAME;
		entity.SEX=model.SEX;
		entity.ID_CARD=model.ID_CARD;
		entity.EXPERT_EXTRACT_TYPE=model.EXPERT_EXTRACT_TYPE;
		entity.EXPERT_EXTRACT_NUMBER=model.EXPERT_EXTRACT_NUMBER;
		entity.EXPERT_EXTRACT_RESULT=model.EXPERT_EXTRACT_RESULT;
		entity.EVALUATION_COMMITTEE=model.EVALUATION_COMMITTEE;
		entity.M_ATTACHMENT=model.M_ATTACHMENT;
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
        public GeneralResult Add(T_EXPERT_EXTRACTION model)
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
                    Delete(T_EXPERT_EXTRACTION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EXPERT_EXTRACTION> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EXPERT_EXTRACTION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_EXPERT_EXTRACTION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NO))
				{
				  condition.And(T_EXPERT_EXTRACTION._.EXPERT_NO.Contain(model.EXPERT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
				{
				  condition.And(T_EXPERT_EXTRACTION._.EXPERT_NAME.Contain(model.EXPERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SEX))
				{
				  condition.And(T_EXPERT_EXTRACTION._.SEX.Contain(model.SEX));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(T_EXPERT_EXTRACTION._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_EXTRACT_TYPE))
				{
				  condition.And(T_EXPERT_EXTRACTION._.EXPERT_EXTRACT_TYPE.Contain(model.EXPERT_EXTRACT_TYPE));
				}
				if(model.EXPERT_EXTRACT_NUMBER!=null)
				{
				  condition.And(T_EXPERT_EXTRACTION._.EXPERT_EXTRACT_NUMBER==(model.EXPERT_EXTRACT_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_EXTRACT_RESULT))
				{
				  condition.And(T_EXPERT_EXTRACTION._.EXPERT_EXTRACT_RESULT.Contain(model.EXPERT_EXTRACT_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_COMMITTEE))
				{
				  condition.And(T_EXPERT_EXTRACTION._.EVALUATION_COMMITTEE.Contain(model.EVALUATION_COMMITTEE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATTACHMENT))
				{
				  condition.And(T_EXPERT_EXTRACTION._.M_ATTACHMENT.Contain(model.M_ATTACHMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_EXPERT_EXTRACTION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_EXPERT_EXTRACTION._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_EXPERT_EXTRACTION._.M_KEY.Contain(model.M_KEY));
				}
		return condition;
	}
        #endregion
    }
}