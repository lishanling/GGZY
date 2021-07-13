using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class NonOilGasExplorRegAnnService : BaseServiceT<NON_OIL_GAS_EXPLOR_REG_ANN>
    {
        #region 接口实现
        
		public List<NON_OIL_GAS_EXPLOR_REG_ANN> FindList(NON_OIL_GAS_EXPLOR_REG_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<NON_OIL_GAS_EXPLOR_REG_ANN> PageList(NON_OIL_GAS_EXPLOR_REG_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, NON_OIL_GAS_EXPLOR_REG_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_ID == M_ID);
			
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
        public GeneralResult Edit(NON_OIL_GAS_EXPLOR_REG_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is NON_OIL_GAS_EXPLOR_REG_ANN entity)
	{		
		entity.Attach();
		entity.NA_ITEM_NAME=model.NA_ITEM_NAME;
		entity.PUBLISHING_TIME=model.PUBLISHING_TIME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.ID_LICENCEID=model.ID_LICENCEID;
		entity.IN_ITEM_TYPE=model.IN_ITEM_TYPE;
		entity.NA_APPLY_PERSON=model.NA_APPLY_PERSON;
		entity.APPLY_TYPE=model.APPLY_TYPE;
		entity.APPLY_CODE=model.APPLY_CODE;
		entity.APPLY_ROLE=model.APPLY_ROLE;
		entity.NA_PERAMBULATE_COMP=model.NA_PERAMBULATE_COMP;
		entity.QT_PERAMBULATE_MINE=model.QT_PERAMBULATE_MINE;
		entity.NA_JZZB=model.NA_JZZB;
		entity.DT_USEFULLIFE_START=model.DT_USEFULLIFE_START;
		entity.DT_USEFULLIFE_END=model.DT_USEFULLIFE_END;
		entity.QT_TOTAL_AREA=model.QT_TOTAL_AREA;
		entity.NA_GEOGRAPHY_POSITION=model.NA_GEOGRAPHY_POSITION;
		entity.APPROVE_ORG=model.APPROVE_ORG;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.URL=model.URL;
		entity.M_ID=model.M_ID;
		entity.M_ATT_NONOIL_EXPLOR_REGIST=model.M_ATT_NONOIL_EXPLOR_REGIST;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRA_AGENCY_NAME=model.TRA_AGENCY_NAME;
		entity.TRA_AGENCY_CODE=model.TRA_AGENCY_CODE;
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
        public GeneralResult Add(NON_OIL_GAS_EXPLOR_REG_ANN model)
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
                    Delete(NON_OIL_GAS_EXPLOR_REG_ANN._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<NON_OIL_GAS_EXPLOR_REG_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(NON_OIL_GAS_EXPLOR_REG_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.NA_ITEM_NAME))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.NA_ITEM_NAME.Contain(model.NA_ITEM_NAME));
				}
				if(model.PUBLISHING_TIME!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.PUBLISHING_TIME==(model.PUBLISHING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_LICENCEID))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.ID_LICENCEID.Contain(model.ID_LICENCEID));
				}
				if(!string.IsNullOrWhiteSpace(model.IN_ITEM_TYPE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.IN_ITEM_TYPE.Contain(model.IN_ITEM_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_APPLY_PERSON))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.NA_APPLY_PERSON.Contain(model.NA_APPLY_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLY_TYPE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.APPLY_TYPE.Contain(model.APPLY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLY_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.APPLY_CODE.Contain(model.APPLY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLY_ROLE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.APPLY_ROLE.Contain(model.APPLY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_PERAMBULATE_COMP))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.NA_PERAMBULATE_COMP.Contain(model.NA_PERAMBULATE_COMP));
				}
				if(model.QT_PERAMBULATE_MINE!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.QT_PERAMBULATE_MINE==(model.QT_PERAMBULATE_MINE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_JZZB))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.NA_JZZB.Contain(model.NA_JZZB));
				}
				if(model.DT_USEFULLIFE_START!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.DT_USEFULLIFE_START==(model.DT_USEFULLIFE_START));
				}
				if(model.DT_USEFULLIFE_END!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.DT_USEFULLIFE_END==(model.DT_USEFULLIFE_END));
				}
				if(model.QT_TOTAL_AREA!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.QT_TOTAL_AREA==(model.QT_TOTAL_AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_GEOGRAPHY_POSITION))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.NA_GEOGRAPHY_POSITION.Contain(model.NA_GEOGRAPHY_POSITION));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_ORG))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.APPROVE_ORG.Contain(model.APPROVE_ORG));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.URL.Contain(model.URL));
				}
				if(model.M_ID!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_NONOIL_EXPLOR_REGIST))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_ATT_NONOIL_EXPLOR_REGIST.Contain(model.M_ATT_NONOIL_EXPLOR_REGIST));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(NON_OIL_GAS_EXPLOR_REG_ANN._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}