using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BidWorkControlService : BaseServiceT<BID_WORK_CONTROL>
    {
        #region 接口实现
        
		public List<BID_WORK_CONTROL> FindList(BID_WORK_CONTROL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BID_WORK_CONTROL> PageList(BID_WORK_CONTROL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BID_WORK_CONTROL._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BID_WORK_CONTROL._.ID == ID);
			
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
        public GeneralResult Edit(BID_WORK_CONTROL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is BID_WORK_CONTROL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BID_PRO=model.BID_PRO;
		entity.BID_CR=model.BID_CR;
		entity.BID_TIME=model.BID_TIME;
		entity.EXPERT=model.EXPERT;
		entity.EXPERT_COST=model.EXPERT_COST;
		entity.PM=model.PM;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(BID_WORK_CONTROL model)
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
                    Delete(BID_WORK_CONTROL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BID_WORK_CONTROL> model)
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
       	protected WhereClipBuilder ConditionBuilder(BID_WORK_CONTROL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(BID_WORK_CONTROL._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_PRO))
				{
				  condition.And(BID_WORK_CONTROL._.BID_PRO.Contain(model.BID_PRO));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CR))
				{
				  condition.And(BID_WORK_CONTROL._.BID_CR.Contain(model.BID_CR));
				}
				if(model.BID_TIME!=null)
				{
				  condition.And(BID_WORK_CONTROL._.BID_TIME==(model.BID_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT))
				{
				  condition.And(BID_WORK_CONTROL._.EXPERT.Contain(model.EXPERT));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_COST))
				{
				  condition.And(BID_WORK_CONTROL._.EXPERT_COST.Contain(model.EXPERT_COST));
				}
				if(!string.IsNullOrWhiteSpace(model.PM))
				{
				  condition.And(BID_WORK_CONTROL._.PM.Contain(model.PM));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(BID_WORK_CONTROL._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}