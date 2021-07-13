using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ExTrainAndTestService : BaseServiceT<EX_TRAIN_AND_TEST>
    {
        #region 接口实现
        
		public List<EX_TRAIN_AND_TEST> FindList(EX_TRAIN_AND_TEST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<EX_TRAIN_AND_TEST> PageList(EX_TRAIN_AND_TEST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, EX_TRAIN_AND_TEST._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(EX_TRAIN_AND_TEST._.ID == ID);
			
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
        public GeneralResult Edit(EX_TRAIN_AND_TEST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is EX_TRAIN_AND_TEST entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.EX_CODE=model.EX_CODE;
		entity.EX_NAME=model.EX_NAME;
		entity.TAT_OBJECT=model.TAT_OBJECT;
		entity.TAT_CONTENT=model.TAT_CONTENT;
		entity.TAT_DATE=model.TAT_DATE;
		entity.TAT_ADDRESS=model.TAT_ADDRESS;
		entity.TAT_SIGN_UP=model.TAT_SIGN_UP;
		entity.TAT_COST=model.TAT_COST;
		entity.OTHER_MATTER=model.OTHER_MATTER;
		entity.ID_CARD=model.ID_CARD;
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
        public GeneralResult Add(EX_TRAIN_AND_TEST model)
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
                    Delete(EX_TRAIN_AND_TEST._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<EX_TRAIN_AND_TEST> model)
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
       	protected WhereClipBuilder ConditionBuilder(EX_TRAIN_AND_TEST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(EX_TRAIN_AND_TEST._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.EX_CODE))
				{
				  condition.And(EX_TRAIN_AND_TEST._.EX_CODE.Contain(model.EX_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EX_NAME))
				{
				  condition.And(EX_TRAIN_AND_TEST._.EX_NAME.Contain(model.EX_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TAT_OBJECT))
				{
				  condition.And(EX_TRAIN_AND_TEST._.TAT_OBJECT.Contain(model.TAT_OBJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.TAT_CONTENT))
				{
				  condition.And(EX_TRAIN_AND_TEST._.TAT_CONTENT.Contain(model.TAT_CONTENT));
				}
				if(model.TAT_DATE!=null)
				{
				  condition.And(EX_TRAIN_AND_TEST._.TAT_DATE==(model.TAT_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TAT_ADDRESS))
				{
				  condition.And(EX_TRAIN_AND_TEST._.TAT_ADDRESS.Contain(model.TAT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TAT_SIGN_UP))
				{
				  condition.And(EX_TRAIN_AND_TEST._.TAT_SIGN_UP.Contain(model.TAT_SIGN_UP));
				}
				if(!string.IsNullOrWhiteSpace(model.TAT_COST))
				{
				  condition.And(EX_TRAIN_AND_TEST._.TAT_COST.Contain(model.TAT_COST));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_MATTER))
				{
				  condition.And(EX_TRAIN_AND_TEST._.OTHER_MATTER.Contain(model.OTHER_MATTER));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(EX_TRAIN_AND_TEST._.ID_CARD.Contain(model.ID_CARD));
				}
		return condition;
	}
        #endregion
    }
}