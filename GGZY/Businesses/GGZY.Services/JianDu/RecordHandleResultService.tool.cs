using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordHandleResultService : BaseServiceT<RECORD_HANDLE_RESULT>
    {
        #region 接口实现
        
		public List<RECORD_HANDLE_RESULT> FindList(RECORD_HANDLE_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_HANDLE_RESULT> PageList(RECORD_HANDLE_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_HANDLE_RESULT._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? RECORD_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(RECORD_HANDLE_RESULT._.RECORD_ID == RECORD_ID);
			
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
        public GeneralResult Edit(RECORD_HANDLE_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RECORD_ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_HANDLE_RESULT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.DISSENT_CODE=model.DISSENT_CODE;
		entity.DISSENT_NAME=model.DISSENT_NAME;
		entity.DISSENT_CONTRACT=model.DISSENT_CONTRACT;
		entity.COMPLAINED_NAME=model.COMPLAINED_NAME;
		entity.COMPLAINED_CODE=model.COMPLAINED_CODE;
		entity.COMPLAINED_TYPE=model.COMPLAINED_TYPE;
		entity.COMPLAINED_CONTRACT=model.COMPLAINED_CONTRACT;
		entity.DISSENT_COMMIT_TIME=model.DISSENT_COMMIT_TIME;
		entity.DISSENT_TYPE=model.DISSENT_TYPE;
		entity.DISSENT_CONTENT=model.DISSENT_CONTENT;
		entity.GROUND_REASON=model.GROUND_REASON;
		entity.IS_ACCEPT_TIME=model.IS_ACCEPT_TIME;
		entity.DISSENT_OPINION=model.DISSENT_OPINION;
		entity.HANDLE_RESULT=model.HANDLE_RESULT;
		entity.HANDLE_BASIS=model.HANDLE_BASIS;
		entity.HANDLE_TIME=model.HANDLE_TIME;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
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
        public GeneralResult Add(RECORD_HANDLE_RESULT model)
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
                    Delete(RECORD_HANDLE_RESULT._.RECORD_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_HANDLE_RESULT> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_HANDLE_RESULT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(RECORD_HANDLE_RESULT._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_CODE))
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_CODE.Contain(model.DISSENT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_NAME))
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_NAME.Contain(model.DISSENT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_CONTRACT))
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_CONTRACT.Contain(model.DISSENT_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINED_NAME))
				{
				  condition.And(RECORD_HANDLE_RESULT._.COMPLAINED_NAME.Contain(model.COMPLAINED_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINED_CODE))
				{
				  condition.And(RECORD_HANDLE_RESULT._.COMPLAINED_CODE.Contain(model.COMPLAINED_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINED_TYPE))
				{
				  condition.And(RECORD_HANDLE_RESULT._.COMPLAINED_TYPE.Contain(model.COMPLAINED_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINED_CONTRACT))
				{
				  condition.And(RECORD_HANDLE_RESULT._.COMPLAINED_CONTRACT.Contain(model.COMPLAINED_CONTRACT));
				}
				if(model.DISSENT_COMMIT_TIME!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_COMMIT_TIME==(model.DISSENT_COMMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_TYPE))
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_TYPE.Contain(model.DISSENT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_CONTENT))
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_CONTENT.Contain(model.DISSENT_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.GROUND_REASON))
				{
				  condition.And(RECORD_HANDLE_RESULT._.GROUND_REASON.Contain(model.GROUND_REASON));
				}
				if(model.IS_ACCEPT_TIME!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.IS_ACCEPT_TIME==(model.IS_ACCEPT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_OPINION))
				{
				  condition.And(RECORD_HANDLE_RESULT._.DISSENT_OPINION.Contain(model.DISSENT_OPINION));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_RESULT))
				{
				  condition.And(RECORD_HANDLE_RESULT._.HANDLE_RESULT.Contain(model.HANDLE_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_BASIS))
				{
				  condition.And(RECORD_HANDLE_RESULT._.HANDLE_BASIS.Contain(model.HANDLE_BASIS));
				}
				if(model.HANDLE_TIME!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.HANDLE_TIME==(model.HANDLE_TIME));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_HANDLE_RESULT._.CREATOR==(model.CREATOR));
				}
		return condition;
	}
        #endregion
    }
}