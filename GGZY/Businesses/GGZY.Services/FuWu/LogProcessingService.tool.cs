using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class LogProcessingService : BaseServiceT<LOG_PROCESSING>
    {
        #region 接口实现
        
		public List<LOG_PROCESSING> FindList(LOG_PROCESSING model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<LOG_PROCESSING> PageList(LOG_PROCESSING model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, LOG_PROCESSING._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(LOG_PROCESSING._.ID == ID);
			
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
        public GeneralResult Edit(LOG_PROCESSING model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is LOG_PROCESSING entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NUM=model.NUM;
		entity.ACQUISITION_RULE=model.ACQUISITION_RULE;
		entity.COLLECTION_TYPE=model.COLLECTION_TYPE;
		entity.COLLECTION_METHOD=model.COLLECTION_METHOD;
		entity.COLLENTION_CONTENT=model.COLLENTION_CONTENT;
		entity.OPERATING=model.OPERATING;
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
        public GeneralResult Add(LOG_PROCESSING model)
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
                    Delete(LOG_PROCESSING._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<LOG_PROCESSING> model)
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
       	protected WhereClipBuilder ConditionBuilder(LOG_PROCESSING model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(LOG_PROCESSING._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NUM))
				{
				  condition.And(LOG_PROCESSING._.NUM.Contain(model.NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.ACQUISITION_RULE))
				{
				  condition.And(LOG_PROCESSING._.ACQUISITION_RULE.Contain(model.ACQUISITION_RULE));
				}
				if(!string.IsNullOrWhiteSpace(model.COLLECTION_TYPE))
				{
				  condition.And(LOG_PROCESSING._.COLLECTION_TYPE.Contain(model.COLLECTION_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COLLECTION_METHOD))
				{
				  condition.And(LOG_PROCESSING._.COLLECTION_METHOD.Contain(model.COLLECTION_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.COLLENTION_CONTENT))
				{
				  condition.And(LOG_PROCESSING._.COLLENTION_CONTENT.Contain(model.COLLENTION_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATING))
				{
				  condition.And(LOG_PROCESSING._.OPERATING.Contain(model.OPERATING));
				}
		return condition;
	}
        #endregion
    }
}