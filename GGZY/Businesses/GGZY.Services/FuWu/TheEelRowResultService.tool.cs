using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TheEelRowResultService : BaseServiceT<THE_EEL_ROW_RESULT>
    {
        #region 接口实现
        
		public List<THE_EEL_ROW_RESULT> FindList(THE_EEL_ROW_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<THE_EEL_ROW_RESULT> PageList(THE_EEL_ROW_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, THE_EEL_ROW_RESULT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(THE_EEL_ROW_RESULT._.ID == ID);
			
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
        public GeneralResult Edit(THE_EEL_ROW_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is THE_EEL_ROW_RESULT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BIDDER=model.BIDDER;
		entity.REAL_NAME=model.REAL_NAME;
		entity.ID_CARD=model.ID_CARD;
		entity.RESULT=model.RESULT;
		entity.BUSINESS_SCORE=model.BUSINESS_SCORE;
		entity.TECHNOLOGY_SCORE=model.TECHNOLOGY_SCORE;
		entity.REMARK=model.REMARK;
		entity.IS_DELETE=model.IS_DELETE;
		entity.FID=model.FID;
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
        public GeneralResult Add(THE_EEL_ROW_RESULT model)
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
                    Delete(THE_EEL_ROW_RESULT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<THE_EEL_ROW_RESULT> model)
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
       	protected WhereClipBuilder ConditionBuilder(THE_EEL_ROW_RESULT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(THE_EEL_ROW_RESULT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER))
				{
				  condition.And(THE_EEL_ROW_RESULT._.BIDDER.Contain(model.BIDDER));
				}
				if(!string.IsNullOrWhiteSpace(model.REAL_NAME))
				{
				  condition.And(THE_EEL_ROW_RESULT._.REAL_NAME.Contain(model.REAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(THE_EEL_ROW_RESULT._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.RESULT))
				{
				  condition.And(THE_EEL_ROW_RESULT._.RESULT.Contain(model.RESULT));
				}
				if(model.BUSINESS_SCORE!=null)
				{
				  condition.And(THE_EEL_ROW_RESULT._.BUSINESS_SCORE==(model.BUSINESS_SCORE));
				}
				if(model.TECHNOLOGY_SCORE!=null)
				{
				  condition.And(THE_EEL_ROW_RESULT._.TECHNOLOGY_SCORE==(model.TECHNOLOGY_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(THE_EEL_ROW_RESULT._.REMARK.Contain(model.REMARK));
				}
				if(model.IS_DELETE!=null)
				{
				  condition.And(THE_EEL_ROW_RESULT._.IS_DELETE==(model.IS_DELETE));
				}
				if(model.FID!=null)
				{
				  condition.And(THE_EEL_ROW_RESULT._.FID==(model.FID));
				}
		return condition;
	}
        #endregion
    }
}