using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JcTransProjectService : BaseServiceT<JC_TRANS_PROJECT>
    {
        #region 接口实现
        
		public List<JC_TRANS_PROJECT> FindList(JC_TRANS_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JC_TRANS_PROJECT> PageList(JC_TRANS_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JC_TRANS_PROJECT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JC_TRANS_PROJECT._.ID == ID);
			
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
        public GeneralResult Edit(JC_TRANS_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is JC_TRANS_PROJECT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_NAME=model.TENDER_NAME;
		entity.TENDER_CONTRACT=model.TENDER_CONTRACT;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.TENDER_ANENCY_CODE=model.TENDER_ANENCY_CODE;
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
        public GeneralResult Add(JC_TRANS_PROJECT model)
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
                    Delete(JC_TRANS_PROJECT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JC_TRANS_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(JC_TRANS_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(JC_TRANS_PROJECT._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(JC_TRANS_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JC_TRANS_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NAME))
				{
				  condition.And(JC_TRANS_PROJECT._.TENDER_NAME.Contain(model.TENDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTRACT))
				{
				  condition.And(JC_TRANS_PROJECT._.TENDER_CONTRACT.Contain(model.TENDER_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(JC_TRANS_PROJECT._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ANENCY_CODE))
				{
				  condition.And(JC_TRANS_PROJECT._.TENDER_ANENCY_CODE.Contain(model.TENDER_ANENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORD_ID))
				{
				  condition.And(JC_TRANS_PROJECT._.RECORD_ID.Contain(model.RECORD_ID));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JC_TRANS_PROJECT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.IS_DELETE!=null)
				{
				  condition.And(JC_TRANS_PROJECT._.IS_DELETE==(model.IS_DELETE));
				}
		return condition;
	}
        #endregion
    }
}