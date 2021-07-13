using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtContructSuperTimeService : BaseServiceT<JT_CONTRUCT_SUPER_TIME>
    {
        #region 接口实现
        
		public List<JT_CONTRUCT_SUPER_TIME> FindList(JT_CONTRUCT_SUPER_TIME model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_CONTRUCT_SUPER_TIME> PageList(JT_CONTRUCT_SUPER_TIME model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_CONTRUCT_SUPER_TIME._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_CONTRUCT_SUPER_TIME._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_CONTRUCT_SUPER_TIME model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_CONTRUCT_SUPER_TIME entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.CONSTRUCTION_SECTION=model.CONSTRUCTION_SECTION;
		entity.CONTRACT_PRE_SERVICE=model.CONTRACT_PRE_SERVICE;
		entity.CONSTRUCT_STAGE_TIME=model.CONSTRUCT_STAGE_TIME;
		entity.SUPERVISION_PERIOD=model.SUPERVISION_PERIOD;
		entity.DEFECT_PERIOD_DUTY=model.DEFECT_PERIOD_DUTY;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.IS_SUPERVISION_PERIOD=model.IS_SUPERVISION_PERIOD;
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
        public GeneralResult Add(JT_CONTRUCT_SUPER_TIME model)
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
                    Delete(JT_CONTRUCT_SUPER_TIME._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_CONTRUCT_SUPER_TIME> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_CONTRUCT_SUPER_TIME model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_SECTION))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.CONSTRUCTION_SECTION.Contain(model.CONSTRUCTION_SECTION));
				}
				if(model.CONTRACT_PRE_SERVICE!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.CONTRACT_PRE_SERVICE==(model.CONTRACT_PRE_SERVICE));
				}
				if(model.CONSTRUCT_STAGE_TIME!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.CONSTRUCT_STAGE_TIME==(model.CONSTRUCT_STAGE_TIME));
				}
				if(model.SUPERVISION_PERIOD!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.SUPERVISION_PERIOD==(model.SUPERVISION_PERIOD));
				}
				if(model.DEFECT_PERIOD_DUTY!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.DEFECT_PERIOD_DUTY==(model.DEFECT_PERIOD_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.M_TM==(model.M_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SUPERVISION_PERIOD))
				{
				  condition.And(JT_CONTRUCT_SUPER_TIME._.IS_SUPERVISION_PERIOD.Contain(model.IS_SUPERVISION_PERIOD));
				}
		return condition;
	}
        #endregion
    }
}