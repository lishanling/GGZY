using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TheEelRowService : BaseServiceT<THE_EEL_ROW>
    {
        #region 接口实现
        
		public List<THE_EEL_ROW> FindList(THE_EEL_ROW model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<THE_EEL_ROW> PageList(THE_EEL_ROW model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, THE_EEL_ROW._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(THE_EEL_ROW._.ID == ID);
			
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
        public GeneralResult Edit(THE_EEL_ROW model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is THE_EEL_ROW entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.R_PRO=model.R_PRO;
		entity.BID_DOC=model.BID_DOC;
		entity.R_SCORE=model.R_SCORE;
		entity.R_RESUTL=model.R_RESUTL;
		entity.R_DATA=model.R_DATA;
		entity.REMARK=model.REMARK;
		entity.OPEN_TIME=model.OPEN_TIME;
		entity.TENDER_PROEJCT_CODE=model.TENDER_PROEJCT_CODE;
		entity.ZHC_NUM=model.ZHC_NUM;
		entity.FHC_NUM=model.FHC_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.BIDDER_NUM=model.BIDDER_NUM;
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
        public GeneralResult Add(THE_EEL_ROW model)
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
                    Delete(THE_EEL_ROW._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<THE_EEL_ROW> model)
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
       	protected WhereClipBuilder ConditionBuilder(THE_EEL_ROW model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(THE_EEL_ROW._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.R_PRO))
				{
				  condition.And(THE_EEL_ROW._.R_PRO.Contain(model.R_PRO));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC))
				{
				  condition.And(THE_EEL_ROW._.BID_DOC.Contain(model.BID_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.R_SCORE))
				{
				  condition.And(THE_EEL_ROW._.R_SCORE.Contain(model.R_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.R_RESUTL))
				{
				  condition.And(THE_EEL_ROW._.R_RESUTL.Contain(model.R_RESUTL));
				}
				if(!string.IsNullOrWhiteSpace(model.R_DATA))
				{
				  condition.And(THE_EEL_ROW._.R_DATA.Contain(model.R_DATA));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(THE_EEL_ROW._.REMARK.Contain(model.REMARK));
				}
				if(model.OPEN_TIME!=null)
				{
				  condition.And(THE_EEL_ROW._.OPEN_TIME==(model.OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROEJCT_CODE))
				{
				  condition.And(THE_EEL_ROW._.TENDER_PROEJCT_CODE.Contain(model.TENDER_PROEJCT_CODE));
				}
				if(model.ZHC_NUM!=null)
				{
				  condition.And(THE_EEL_ROW._.ZHC_NUM==(model.ZHC_NUM));
				}
				if(model.FHC_NUM!=null)
				{
				  condition.And(THE_EEL_ROW._.FHC_NUM==(model.FHC_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(THE_EEL_ROW._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(model.BIDDER_NUM!=null)
				{
				  condition.And(THE_EEL_ROW._.BIDDER_NUM==(model.BIDDER_NUM));
				}
		return condition;
	}
        #endregion
    }
}