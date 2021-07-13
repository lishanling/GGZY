using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JcTransEntityService : BaseServiceT<JC_TRANS_ENTITY>
    {
        #region 接口实现
        
		public List<JC_TRANS_ENTITY> FindList(JC_TRANS_ENTITY model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JC_TRANS_ENTITY> PageList(JC_TRANS_ENTITY model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JC_TRANS_ENTITY._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(JC_TRANS_ENTITY._.ID == ID);
			
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
        public GeneralResult Edit(JC_TRANS_ENTITY model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is JC_TRANS_ENTITY entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.ENTITY_NAME=model.ENTITY_NAME;
		entity.ENTITY_CODE=model.ENTITY_CODE;
		entity.ENTITY_TYPE=model.ENTITY_TYPE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.REGION_NAME=model.REGION_NAME;
		entity.RECORD_ID=model.RECORD_ID;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.IS_DELETE=model.IS_DELETE;
		//Update(entity);
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
        public GeneralResult Add(JC_TRANS_ENTITY model)
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
                    Delete(JC_TRANS_ENTITY._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JC_TRANS_ENTITY> model)
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
       	protected WhereClipBuilder ConditionBuilder(JC_TRANS_ENTITY model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(JC_TRANS_ENTITY._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTITY_NAME))
				{
				  condition.And(JC_TRANS_ENTITY._.ENTITY_NAME.Contain(model.ENTITY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTITY_CODE))
				{
				  condition.And(JC_TRANS_ENTITY._.ENTITY_CODE.Contain(model.ENTITY_CODE));
				}
				if(model.ENTITY_TYPE!=null)
				{
				  condition.And(JC_TRANS_ENTITY._.ENTITY_TYPE==(model.ENTITY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(JC_TRANS_ENTITY._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_NAME))
				{
				  condition.And(JC_TRANS_ENTITY._.REGION_NAME.Contain(model.REGION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORD_ID))
				{
				  condition.And(JC_TRANS_ENTITY._.RECORD_ID.Contain(model.RECORD_ID));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JC_TRANS_ENTITY._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.IS_DELETE!=null)
				{
				  condition.And(JC_TRANS_ENTITY._.IS_DELETE==(model.IS_DELETE));
				}
		return condition;
	}
        #endregion
    }
}