using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordLogService : BaseServiceT<RECORD_LOG>
    {
        #region 接口实现
        
		public List<RECORD_LOG> FindList(RECORD_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_LOG> PageList(RECORD_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(RECORD_LOG._.ID == ID);
			
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
        public GeneralResult Edit(RECORD_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BA_ID=model.BA_ID;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.ATTCHAMENT=model.ATTCHAMENT;
		entity.DATA_AND_ATT=model.DATA_AND_ATT;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.SUBMIT_PERSON=model.SUBMIT_PERSON;
		entity.SUBMIT_DEPID=model.SUBMIT_DEPID;
		entity.OPER_ID=model.OPER_ID;
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
        public GeneralResult Add(RECORD_LOG model)
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
                    Delete(RECORD_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BA_ID))
				{
				  condition.And(RECORD_LOG._.BA_ID.Contain(model.BA_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(RECORD_LOG._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTCHAMENT))
				{
				  condition.And(RECORD_LOG._.ATTCHAMENT.Contain(model.ATTCHAMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_AND_ATT))
				{
				  condition.And(RECORD_LOG._.DATA_AND_ATT.Contain(model.DATA_AND_ATT));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(RECORD_LOG._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBMIT_PERSON))
				{
				  condition.And(RECORD_LOG._.SUBMIT_PERSON.Contain(model.SUBMIT_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBMIT_DEPID))
				{
				  condition.And(RECORD_LOG._.SUBMIT_DEPID.Contain(model.SUBMIT_DEPID));
				}
				if(!string.IsNullOrWhiteSpace(model.OPER_ID))
				{
				  condition.And(RECORD_LOG._.OPER_ID.Contain(model.OPER_ID));
				}
		return condition;
	}
        #endregion
    }
}