using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaMediNegoPurchaseListService : BaseServiceT<DEA_MEDI_NEGO_PURCHASE_LIST>
    {
        #region 接口实现
        
		public List<DEA_MEDI_NEGO_PURCHASE_LIST> FindList(DEA_MEDI_NEGO_PURCHASE_LIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_MEDI_NEGO_PURCHASE_LIST> PageList(DEA_MEDI_NEGO_PURCHASE_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_MEDI_NEGO_PURCHASE_LIST._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_MEDI_NEGO_PURCHASE_LIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_MEDI_NEGO_PURCHASE_LIST entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJNAME=model.PROJNAME;
		entity.DRUGGROUP=model.DRUGGROUP;
		entity.CATAID=model.CATAID;
		entity.CATANAME=model.CATANAME;
		entity.CATANUM=model.CATANUM;
		entity.CATACONTENT=model.CATACONTENT;
		entity.CATASTATUS=model.CATASTATUS;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(DEA_MEDI_NEGO_PURCHASE_LIST model)
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
                    Delete(DEA_MEDI_NEGO_PURCHASE_LIST._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_MEDI_NEGO_PURCHASE_LIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_MEDI_NEGO_PURCHASE_LIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJNAME))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.PROJNAME.Contain(model.PROJNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGGROUP))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.DRUGGROUP.Contain(model.DRUGGROUP));
				}
				if(!string.IsNullOrWhiteSpace(model.CATAID))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.CATAID.Contain(model.CATAID));
				}
				if(!string.IsNullOrWhiteSpace(model.CATANAME))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.CATANAME.Contain(model.CATANAME));
				}
				if(model.CATANUM!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.CATANUM==(model.CATANUM));
				}
				if(!string.IsNullOrWhiteSpace(model.CATACONTENT))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.CATACONTENT.Contain(model.CATACONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.CATASTATUS))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.CATASTATUS.Contain(model.CATASTATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_MEDI_NEGO_PURCHASE_LIST._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}