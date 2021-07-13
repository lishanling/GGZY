using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CompareSelectAnnService : BaseServiceT<COMPARE_SELECT_ANN>
    {
        #region 接口实现
        
		public List<COMPARE_SELECT_ANN> FindList(COMPARE_SELECT_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<COMPARE_SELECT_ANN> PageList(COMPARE_SELECT_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, COMPARE_SELECT_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(COMPARE_SELECT_ANN._.M_ID == M_ID);
			
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
        public GeneralResult Edit(COMPARE_SELECT_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is COMPARE_SELECT_ANN entity)
	{		
		entity.Attach();
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.OWNER_NAME=model.OWNER_NAME;
		entity.AGENCY_FEE_STANDARD=model.AGENCY_FEE_STANDARD;
		entity.APPLICATION_END_TIME=model.APPLICATION_END_TIME;
		entity.M_STATUS=model.M_STATUS;
		entity.IS_GOVERNMENT_PLAY=model.IS_GOVERNMENT_PLAY;
		entity.AGENCY_CONDITION=model.AGENCY_CONDITION;
		entity.AGENCY_CONTENT=model.AGENCY_CONTENT;
		entity.ADD_TIME=model.ADD_TIME;
		entity.USERID=model.USERID;
		entity.REMARK=model.REMARK;
		entity.M_ID=model.M_ID;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.URL=model.URL;
		entity.CHECK_USERID=model.CHECK_USERID;
		entity.CHECK_TM=model.CHECK_TM;
		entity.REJECT_REASON=model.REJECT_REASON;
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
        public GeneralResult Add(COMPARE_SELECT_ANN model)
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
                    Delete(COMPARE_SELECT_ANN._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<COMPARE_SELECT_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(COMPARE_SELECT_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(COMPARE_SELECT_ANN._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(COMPARE_SELECT_ANN._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(COMPARE_SELECT_ANN._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_FEE_STANDARD))
				{
				  condition.And(COMPARE_SELECT_ANN._.AGENCY_FEE_STANDARD.Contain(model.AGENCY_FEE_STANDARD));
				}
				if(model.APPLICATION_END_TIME!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.APPLICATION_END_TIME==(model.APPLICATION_END_TIME));
				}
				if(model.M_STATUS!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.M_STATUS==(model.M_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_GOVERNMENT_PLAY))
				{
				  condition.And(COMPARE_SELECT_ANN._.IS_GOVERNMENT_PLAY.Contain(model.IS_GOVERNMENT_PLAY));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_CONDITION))
				{
				  condition.And(COMPARE_SELECT_ANN._.AGENCY_CONDITION.Contain(model.AGENCY_CONDITION));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_CONTENT))
				{
				  condition.And(COMPARE_SELECT_ANN._.AGENCY_CONTENT.Contain(model.AGENCY_CONTENT));
				}
				if(model.ADD_TIME!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.ADD_TIME==(model.ADD_TIME));
				}
				if(model.USERID!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.USERID==(model.USERID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(COMPARE_SELECT_ANN._.REMARK.Contain(model.REMARK));
				}
				if(model.M_ID!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(COMPARE_SELECT_ANN._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(COMPARE_SELECT_ANN._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(COMPARE_SELECT_ANN._.URL.Contain(model.URL));
				}
				if(model.CHECK_USERID!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.CHECK_USERID==(model.CHECK_USERID));
				}
				if(model.CHECK_TM!=null)
				{
				  condition.And(COMPARE_SELECT_ANN._.CHECK_TM==(model.CHECK_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REJECT_REASON))
				{
				  condition.And(COMPARE_SELECT_ANN._.REJECT_REASON.Contain(model.REJECT_REASON));
				}
		return condition;
	}
        #endregion
    }
}