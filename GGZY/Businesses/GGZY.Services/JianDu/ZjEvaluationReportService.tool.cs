using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjEvaluationReportService : BaseServiceT<ZJ_EVALUATION_REPORT>
    {
        #region 接口实现
        
		public List<ZJ_EVALUATION_REPORT> FindList(ZJ_EVALUATION_REPORT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_EVALUATION_REPORT> PageList(ZJ_EVALUATION_REPORT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_EVALUATION_REPORT._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">数据自增长ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJ_EVALUATION_REPORT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_EVALUATION_REPORT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_EVALUATION_REPORT entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
		entity.END_TIME=model.END_TIME;
		entity.EVALUATION_RESULT=model.EVALUATION_RESULT;
		entity.EVALUATING_TYPE=model.EVALUATING_TYPE;
		entity.IS_SET_SIMILAR_PER=model.IS_SET_SIMILAR_PER;
		entity.CONTROL_PRICE=model.CONTROL_PRICE;
		entity.BID_EVALUATION_PRICE=model.BID_EVALUATION_PRICE;
		entity.K_DOWN_NUM=model.K_DOWN_NUM;
		entity.IS_SET_SIMILAR_PLUS=model.IS_SET_SIMILAR_PLUS;
		entity.BIDD_STANDARD_PRICE=model.BIDD_STANDARD_PRICE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.NOTICE_NAME=model.NOTICE_NAME;
		entity.EVALUATION_CONTENT=model.EVALUATION_CONTENT;
		entity.URL=model.URL;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
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
        public GeneralResult Add(ZJ_EVALUATION_REPORT model)
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
                    Delete(ZJ_EVALUATION_REPORT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_EVALUATION_REPORT> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_EVALUATION_REPORT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(model.END_TIME!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.END_TIME==(model.END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_RESULT))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.EVALUATION_RESULT.Contain(model.EVALUATION_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_TYPE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.EVALUATING_TYPE.Contain(model.EVALUATING_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SET_SIMILAR_PER))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.IS_SET_SIMILAR_PER.Contain(model.IS_SET_SIMILAR_PER));
				}
				if(model.CONTROL_PRICE!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.CONTROL_PRICE==(model.CONTROL_PRICE));
				}
				if(model.BID_EVALUATION_PRICE!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.BID_EVALUATION_PRICE==(model.BID_EVALUATION_PRICE));
				}
				if(model.K_DOWN_NUM!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.K_DOWN_NUM==(model.K_DOWN_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SET_SIMILAR_PLUS))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.IS_SET_SIMILAR_PLUS.Contain(model.IS_SET_SIMILAR_PLUS));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDD_STANDARD_PRICE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.BIDD_STANDARD_PRICE.Contain(model.BIDD_STANDARD_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_EVALUATION_REPORT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_CONTENT))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.EVALUATION_CONTENT.Contain(model.EVALUATION_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_EVALUATION_REPORT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}