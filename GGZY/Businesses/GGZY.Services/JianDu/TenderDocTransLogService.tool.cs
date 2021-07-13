using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TenderDocTransLogService : BaseServiceT<TENDER_DOC_TRANS_LOG>
    {
        #region 接口实现
        
		public List<TENDER_DOC_TRANS_LOG> FindList(TENDER_DOC_TRANS_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_DOC_TRANS_LOG> PageList(TENDER_DOC_TRANS_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_DOC_TRANS_LOG._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(TENDER_DOC_TRANS_LOG._.ID == ID);
			
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
        public GeneralResult Edit(TENDER_DOC_TRANS_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_DOC_TRANS_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SOURCE_ID=model.SOURCE_ID;
		entity.TARGET_ID=model.TARGET_ID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.CREATE_ID=model.CREATE_ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.ATT_NAME=model.ATT_NAME;
		entity.GUID=model.GUID;
		entity.MD5=model.MD5;
		entity.IS_USE=model.IS_USE;
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
        public GeneralResult Add(TENDER_DOC_TRANS_LOG model)
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
                    Delete(TENDER_DOC_TRANS_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_DOC_TRANS_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_DOC_TRANS_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SOURCE_ID))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.SOURCE_ID.Contain(model.SOURCE_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TARGET_ID))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.TARGET_ID.Contain(model.TARGET_ID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_ID))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.CREATE_ID.Contain(model.CREATE_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORD_ID))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.RECORD_ID.Contain(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ATT_NAME))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.ATT_NAME.Contain(model.ATT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.GUID.Contain(model.GUID));
				}
				if(!string.IsNullOrWhiteSpace(model.MD5))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.MD5.Contain(model.MD5));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_USE))
				{
				  condition.And(TENDER_DOC_TRANS_LOG._.IS_USE.Contain(model.IS_USE));
				}
		return condition;
	}
        #endregion
    }
}