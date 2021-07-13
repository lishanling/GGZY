using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TheEelSetAndAuthService : BaseServiceT<THE_EEL_SET_AND_AUTH>
    {
        #region 接口实现
        
		public List<THE_EEL_SET_AND_AUTH> FindList(THE_EEL_SET_AND_AUTH model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<THE_EEL_SET_AND_AUTH> PageList(THE_EEL_SET_AND_AUTH model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, THE_EEL_SET_AND_AUTH._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(THE_EEL_SET_AND_AUTH._.ID == ID);
			
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
        public GeneralResult Edit(THE_EEL_SET_AND_AUTH model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is THE_EEL_SET_AND_AUTH entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BID_PRO=model.BID_PRO;
		entity.EMV_CR=model.EMV_CR;
		entity.EBF_CR=model.EBF_CR;
		entity.EMV_EXPERT=model.EMV_EXPERT;
		entity.EBF_EXPERT=model.EBF_EXPERT;
		entity.REMARK=model.REMARK;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.OPEN_TIME=model.OPEN_TIME;
		entity.ZHC_EXPERTS=model.ZHC_EXPERTS;
		entity.FHC_EXPERTS=model.FHC_EXPERTS;
		entity.LEAD_EXPERT=model.LEAD_EXPERT;
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
        public GeneralResult Add(THE_EEL_SET_AND_AUTH model)
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
                    Delete(THE_EEL_SET_AND_AUTH._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<THE_EEL_SET_AND_AUTH> model)
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
       	protected WhereClipBuilder ConditionBuilder(THE_EEL_SET_AND_AUTH model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_PRO))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.BID_PRO.Contain(model.BID_PRO));
				}
				if(!string.IsNullOrWhiteSpace(model.EMV_CR))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.EMV_CR.Contain(model.EMV_CR));
				}
				if(!string.IsNullOrWhiteSpace(model.EBF_CR))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.EBF_CR.Contain(model.EBF_CR));
				}
				if(!string.IsNullOrWhiteSpace(model.EMV_EXPERT))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.EMV_EXPERT.Contain(model.EMV_EXPERT));
				}
				if(!string.IsNullOrWhiteSpace(model.EBF_EXPERT))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.EBF_EXPERT.Contain(model.EBF_EXPERT));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_TIME))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.OPEN_TIME.Contain(model.OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZHC_EXPERTS))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.ZHC_EXPERTS.Contain(model.ZHC_EXPERTS));
				}
				if(!string.IsNullOrWhiteSpace(model.FHC_EXPERTS))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.FHC_EXPERTS.Contain(model.FHC_EXPERTS));
				}
				if(!string.IsNullOrWhiteSpace(model.LEAD_EXPERT))
				{
				  condition.And(THE_EEL_SET_AND_AUTH._.LEAD_EXPERT.Contain(model.LEAD_EXPERT));
				}
		return condition;
	}
        #endregion
    }
}