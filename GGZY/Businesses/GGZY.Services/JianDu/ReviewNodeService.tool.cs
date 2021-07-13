using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ReviewNodeService : BaseServiceT<REVIEW_NODE>
    {
        #region 接口实现
        
		public List<REVIEW_NODE> FindList(REVIEW_NODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<REVIEW_NODE> PageList(REVIEW_NODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, REVIEW_NODE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(REVIEW_NODE._.ID == ID);
			
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
        public GeneralResult Edit(REVIEW_NODE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is REVIEW_NODE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.MAIN_ID=model.MAIN_ID;
		entity.NODE_NAME=model.NODE_NAME;
		entity.ORDER_BY=model.ORDER_BY;
		entity.TIMEOUT=model.TIMEOUT;
		entity.PREV_NODE=model.PREV_NODE;
		entity.ATTRIBUTES=model.ATTRIBUTES;
		entity.BUTTONS=model.BUTTONS;
		entity.IS_MULTI=model.IS_MULTI;
		entity.OPER_USE_NODE=model.OPER_USE_NODE;
		entity.PREV_MAIN_NODE=model.PREV_MAIN_NODE;
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
        public GeneralResult Add(REVIEW_NODE model)
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
                    Delete(REVIEW_NODE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<REVIEW_NODE> model)
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
       	protected WhereClipBuilder ConditionBuilder(REVIEW_NODE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(REVIEW_NODE._.ID==(model.ID));
				}
				if(model.MAIN_ID!=null)
				{
				  condition.And(REVIEW_NODE._.MAIN_ID==(model.MAIN_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NODE_NAME))
				{
				  condition.And(REVIEW_NODE._.NODE_NAME.Contain(model.NODE_NAME));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(REVIEW_NODE._.ORDER_BY==(model.ORDER_BY));
				}
				if(model.TIMEOUT!=null)
				{
				  condition.And(REVIEW_NODE._.TIMEOUT==(model.TIMEOUT));
				}
				if(model.PREV_NODE!=null)
				{
				  condition.And(REVIEW_NODE._.PREV_NODE==(model.PREV_NODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTRIBUTES))
				{
				  condition.And(REVIEW_NODE._.ATTRIBUTES.Contain(model.ATTRIBUTES));
				}
				if(!string.IsNullOrWhiteSpace(model.BUTTONS))
				{
				  condition.And(REVIEW_NODE._.BUTTONS.Contain(model.BUTTONS));
				}
				if(model.IS_MULTI!=null)
				{
				  condition.And(REVIEW_NODE._.IS_MULTI==(model.IS_MULTI));
				}
				if(model.OPER_USE_NODE!=null)
				{
				  condition.And(REVIEW_NODE._.OPER_USE_NODE==(model.OPER_USE_NODE));
				}
				if(model.PREV_MAIN_NODE!=null)
				{
				  condition.And(REVIEW_NODE._.PREV_MAIN_NODE==(model.PREV_MAIN_NODE));
				}
		return condition;
	}
        #endregion
    }
}