using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtTjDataService : BaseServiceT<PT_TJ_DATA>
    {
        #region 接口实现
        
		public List<PT_TJ_DATA> FindList(PT_TJ_DATA model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_TJ_DATA> PageList(PT_TJ_DATA model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_TJ_DATA._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_TJ_DATA._.ID == ID);
			
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
        public GeneralResult Edit(PT_TJ_DATA model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_TJ_DATA entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.DATA_TYPE=model.DATA_TYPE;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_TYPE=model.PROJECT_TYPE;
		entity.TRANSACTION_MODE=model.TRANSACTION_MODE;
		entity.TRANSACTION_TYPE=model.TRANSACTION_TYPE;
		entity.TRANSACTION_AMOUNT=model.TRANSACTION_AMOUNT;
		entity.SAVING_AMOUNT=model.SAVING_AMOUNT;
		entity.VA_AMOUNT=model.VA_AMOUNT;
		entity.GI_AMOUNT=model.GI_AMOUNT;
		entity.EI_AMOUNT=model.EI_AMOUNT;
		entity.OI_AMOUNT=model.OI_AMOUNT;
		entity.TZZTXZ=model.TZZTXZ;
		entity.TM=model.TM;
		entity.UPDATE_UID=model.UPDATE_UID;
		entity.AREACODE=model.AREACODE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.MID=model.MID;
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
        public GeneralResult Add(PT_TJ_DATA model)
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
                    Delete(PT_TJ_DATA._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_TJ_DATA> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_TJ_DATA model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_TJ_DATA._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_TYPE))
				{
				  condition.And(PT_TJ_DATA._.DATA_TYPE.Contain(model.DATA_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(PT_TJ_DATA._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(PT_TJ_DATA._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
				{
				  condition.And(PT_TJ_DATA._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSACTION_MODE))
				{
				  condition.And(PT_TJ_DATA._.TRANSACTION_MODE.Contain(model.TRANSACTION_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSACTION_TYPE))
				{
				  condition.And(PT_TJ_DATA._.TRANSACTION_TYPE.Contain(model.TRANSACTION_TYPE));
				}
				if(model.TRANSACTION_AMOUNT!=null)
				{
				  condition.And(PT_TJ_DATA._.TRANSACTION_AMOUNT==(model.TRANSACTION_AMOUNT));
				}
				if(model.SAVING_AMOUNT!=null)
				{
				  condition.And(PT_TJ_DATA._.SAVING_AMOUNT==(model.SAVING_AMOUNT));
				}
				if(model.VA_AMOUNT!=null)
				{
				  condition.And(PT_TJ_DATA._.VA_AMOUNT==(model.VA_AMOUNT));
				}
				if(model.GI_AMOUNT!=null)
				{
				  condition.And(PT_TJ_DATA._.GI_AMOUNT==(model.GI_AMOUNT));
				}
				if(model.EI_AMOUNT!=null)
				{
				  condition.And(PT_TJ_DATA._.EI_AMOUNT==(model.EI_AMOUNT));
				}
				if(model.OI_AMOUNT!=null)
				{
				  condition.And(PT_TJ_DATA._.OI_AMOUNT==(model.OI_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.TZZTXZ))
				{
				  condition.And(PT_TJ_DATA._.TZZTXZ.Contain(model.TZZTXZ));
				}
				if(model.TM!=null)
				{
				  condition.And(PT_TJ_DATA._.TM==(model.TM));
				}
				if(model.UPDATE_UID!=null)
				{
				  condition.And(PT_TJ_DATA._.UPDATE_UID==(model.UPDATE_UID));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(PT_TJ_DATA._.AREACODE.Contain(model.AREACODE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(PT_TJ_DATA._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.MID!=null)
				{
				  condition.And(PT_TJ_DATA._.MID==(model.MID));
				}
		return condition;
	}
        #endregion
    }
}