using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class BlackListService : BaseServiceT<BLACK_LIST>
    {
        #region 接口实现
        
		public List<BLACK_LIST> FindList(BLACK_LIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BLACK_LIST> PageList(BLACK_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BLACK_LIST._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(BLACK_LIST._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BLACK_LIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BLACK_LIST entity)
	{		
		entity.Attach();
		entity.BLACKLIST_CODE=model.BLACKLIST_CODE;
		entity.BODY_NAME=model.BODY_NAME;
		entity.BODY_CODE=model.BODY_CODE;
		entity.BODY_TYPE=model.BODY_TYPE;
		entity.BODY_ROLE=model.BODY_ROLE;
		entity.RECORD_REASON=model.RECORD_REASON;
		entity.RECORD_DATE=model.RECORD_DATE;
		entity.GOVERNMENT=model.GOVERNMENT;
		entity.DOCUMENT_CODE=model.DOCUMENT_CODE;
		entity.REVOCATION_STATUS=model.REVOCATION_STATUS;
		entity.CONFINED_ACTION=model.CONFINED_ACTION;
		entity.SCOPE=model.SCOPE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_BLACKLIST_DOC=model.M_ATT_BLACKLIST_DOC;
		entity.USER_ID=model.USER_ID;
		entity.COMMIT_TIME=model.COMMIT_TIME;
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
        public GeneralResult Add(BLACK_LIST model)
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
                    Delete(BLACK_LIST._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BLACK_LIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(BLACK_LIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BLACKLIST_CODE))
				{
				  condition.And(BLACK_LIST._.BLACKLIST_CODE.Contain(model.BLACKLIST_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_NAME))
				{
				  condition.And(BLACK_LIST._.BODY_NAME.Contain(model.BODY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_CODE))
				{
				  condition.And(BLACK_LIST._.BODY_CODE.Contain(model.BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_TYPE))
				{
				  condition.And(BLACK_LIST._.BODY_TYPE.Contain(model.BODY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_ROLE))
				{
				  condition.And(BLACK_LIST._.BODY_ROLE.Contain(model.BODY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORD_REASON))
				{
				  condition.And(BLACK_LIST._.RECORD_REASON.Contain(model.RECORD_REASON));
				}
				if(model.RECORD_DATE!=null)
				{
				  condition.And(BLACK_LIST._.RECORD_DATE==(model.RECORD_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.GOVERNMENT))
				{
				  condition.And(BLACK_LIST._.GOVERNMENT.Contain(model.GOVERNMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DOCUMENT_CODE))
				{
				  condition.And(BLACK_LIST._.DOCUMENT_CODE.Contain(model.DOCUMENT_CODE));
				}
				if(model.REVOCATION_STATUS!=null)
				{
				  condition.And(BLACK_LIST._.REVOCATION_STATUS==(model.REVOCATION_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFINED_ACTION))
				{
				  condition.And(BLACK_LIST._.CONFINED_ACTION.Contain(model.CONFINED_ACTION));
				}
				if(model.SCOPE!=null)
				{
				  condition.And(BLACK_LIST._.SCOPE==(model.SCOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(BLACK_LIST._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(BLACK_LIST._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(BLACK_LIST._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BLACK_LIST._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BLACK_LIST._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BLACK_LIST._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(BLACK_LIST._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_BLACKLIST_DOC))
				{
				  condition.And(BLACK_LIST._.M_ATT_BLACKLIST_DOC.Contain(model.M_ATT_BLACKLIST_DOC));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(BLACK_LIST._.USER_ID==(model.USER_ID));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(BLACK_LIST._.COMMIT_TIME==(model.COMMIT_TIME));
				}
		return condition;
	}
        #endregion
    }
}