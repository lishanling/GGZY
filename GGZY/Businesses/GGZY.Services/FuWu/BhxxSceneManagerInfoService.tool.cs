using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhxxSceneManagerInfoService : BaseServiceT<BHXX_SCENE_MANAGER_INFO>
    {
        #region 接口实现
        
		public List<BHXX_SCENE_MANAGER_INFO> FindList(BHXX_SCENE_MANAGER_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BHXX_SCENE_MANAGER_INFO> PageList(BHXX_SCENE_MANAGER_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BHXX_SCENE_MANAGER_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BHXX_SCENE_MANAGER_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BHXX_SCENE_MANAGER_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BHXX_SCENE_MANAGER_INFO entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_VERSION=model.M_VERSION;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.BUILDER_LICENCE_NUM=model.BUILDER_LICENCE_NUM;
		entity.CORP_NAME=model.CORP_NAME;
		entity.CORP_CODE=model.CORP_CODE;
		entity.USERNAME=model.USERNAME;
		entity.IDCARD_TYPE_NUM=model.IDCARD_TYPE_NUM;
		entity.IDCARD=model.IDCARD;
		entity.REGISTER_TIME=model.REGISTER_TIME;
		entity.LOGOUT_TIME=model.LOGOUT_TIME;
		entity.POST_NAME=model.POST_NAME;
		entity.POST_CERT_NAME=model.POST_CERT_NAME;
		entity.POST_CERT_NUM=model.POST_CERT_NUM;
		entity.CERT_END_DATE=model.CERT_END_DATE;
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
        public GeneralResult Add(BHXX_SCENE_MANAGER_INFO model)
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
                    Delete(BHXX_SCENE_MANAGER_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BHXX_SCENE_MANAGER_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(BHXX_SCENE_MANAGER_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUILDER_LICENCE_NUM))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.BUILDER_LICENCE_NUM.Contain(model.BUILDER_LICENCE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.CORP_NAME))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.CORP_NAME.Contain(model.CORP_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CORP_CODE))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.CORP_CODE.Contain(model.CORP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.USERNAME))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.USERNAME.Contain(model.USERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARD_TYPE_NUM))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.IDCARD_TYPE_NUM.Contain(model.IDCARD_TYPE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARD))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.IDCARD.Contain(model.IDCARD));
				}
				if(model.REGISTER_TIME!=null)
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.REGISTER_TIME==(model.REGISTER_TIME));
				}
				if(model.LOGOUT_TIME!=null)
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.LOGOUT_TIME==(model.LOGOUT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_NAME))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.POST_NAME.Contain(model.POST_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_CERT_NAME))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.POST_CERT_NAME.Contain(model.POST_CERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_CERT_NUM))
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.POST_CERT_NUM.Contain(model.POST_CERT_NUM));
				}
				if(model.CERT_END_DATE!=null)
				{
				  condition.And(BHXX_SCENE_MANAGER_INFO._.CERT_END_DATE==(model.CERT_END_DATE));
				}
		return condition;
	}
        #endregion
    }
}