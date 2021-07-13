using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MiningDistrivtRangePubService : BaseServiceT<MINING_DISTRIVT_RANGE_PUB>
    {
        #region 接口实现
        
		public List<MINING_DISTRIVT_RANGE_PUB> FindList(MINING_DISTRIVT_RANGE_PUB model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MINING_DISTRIVT_RANGE_PUB> PageList(MINING_DISTRIVT_RANGE_PUB model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, MINING_DISTRIVT_RANGE_PUB._.NA_APP_NAME.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="NA_APP_NAME">项目名称</param>
      /// <param name="NA_APPLY_PERSON">申请人</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string NA_APP_NAME,string NA_APPLY_PERSON)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(MINING_DISTRIVT_RANGE_PUB._.NA_APP_NAME == NA_APP_NAME);
			condition.And(MINING_DISTRIVT_RANGE_PUB._.NA_APPLY_PERSON == NA_APPLY_PERSON);
			
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
        public GeneralResult Edit(MINING_DISTRIVT_RANGE_PUB model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.NA_APP_NAME,model.NA_APPLY_PERSON);
	
	if(viewResult.Success  && viewResult.Data is MINING_DISTRIVT_RANGE_PUB entity)
	{		
		entity.Attach();
		entity.NA_APP_NAME=model.NA_APP_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.NA_APPLY_PERSON=model.NA_APPLY_PERSON;
		entity.APPLY_TYPE=model.APPLY_TYPE;
		entity.APPLY_CODE=model.APPLY_CODE;
		entity.APPLY_ROLE=model.APPLY_ROLE;
		entity.QT_DESIGN_SCOPE=model.QT_DESIGN_SCOPE;
		entity.NA_SCOPE_UNIT=model.NA_SCOPE_UNIT;
		entity.NA_GOV_NAME=model.NA_GOV_NAME;
		entity.IN_BUY_KIND=model.IN_BUY_KIND;
		entity.IN_MINE_COME=model.IN_MINE_COME;
		entity.DT_RECIVE_DATE=model.DT_RECIVE_DATE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(MINING_DISTRIVT_RANGE_PUB model)
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
                    Delete(MINING_DISTRIVT_RANGE_PUB._.NA_APP_NAME.SelectIn(idArr));
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
        public GeneralResult Import(List<MINING_DISTRIVT_RANGE_PUB> model)
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
       	protected WhereClipBuilder ConditionBuilder(MINING_DISTRIVT_RANGE_PUB model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.NA_APP_NAME))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.NA_APP_NAME.Contain(model.NA_APP_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_APPLY_PERSON))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.NA_APPLY_PERSON.Contain(model.NA_APPLY_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLY_TYPE))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.APPLY_TYPE.Contain(model.APPLY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLY_CODE))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.APPLY_CODE.Contain(model.APPLY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLY_ROLE))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.APPLY_ROLE.Contain(model.APPLY_ROLE));
				}
				if(model.QT_DESIGN_SCOPE!=null)
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.QT_DESIGN_SCOPE==(model.QT_DESIGN_SCOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_SCOPE_UNIT))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.NA_SCOPE_UNIT.Contain(model.NA_SCOPE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_GOV_NAME))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.NA_GOV_NAME.Contain(model.NA_GOV_NAME));
				}
				if(model.IN_BUY_KIND!=null)
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.IN_BUY_KIND==(model.IN_BUY_KIND));
				}
				if(model.IN_MINE_COME!=null)
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.IN_MINE_COME==(model.IN_MINE_COME));
				}
				if(model.DT_RECIVE_DATE!=null)
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.DT_RECIVE_DATE==(model.DT_RECIVE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(MINING_DISTRIVT_RANGE_PUB._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}