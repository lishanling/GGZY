using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ReviewLogService : BaseServiceT<REVIEW_LOG>
    {
        #region 接口实现
        
		public List<REVIEW_LOG> FindList(REVIEW_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<REVIEW_LOG> PageList(REVIEW_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, REVIEW_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(REVIEW_LOG._.ID == ID);
			
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
        public GeneralResult Edit(REVIEW_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is REVIEW_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SL_ID=model.SL_ID;
		entity.NODE_ID=model.NODE_ID;
		entity.BTN_ID=model.BTN_ID;
		entity.OPERNAME=model.OPERNAME;
		entity.USER_ID=model.USER_ID;
		entity.OPER_TM=model.OPER_TM;
		entity.C1=model.C1;
		entity.C2=model.C2;
		entity.C3=model.C3;
		entity.C4=model.C4;
		entity.C5=model.C5;
		entity.DATA_DIC=model.DATA_DIC;
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
        public GeneralResult Add(REVIEW_LOG model)
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
                    Delete(REVIEW_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<REVIEW_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(REVIEW_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(REVIEW_LOG._.ID==(model.ID));
				}
				if(model.SL_ID!=null)
				{
				  condition.And(REVIEW_LOG._.SL_ID==(model.SL_ID));
				}
				if(model.NODE_ID!=null)
				{
				  condition.And(REVIEW_LOG._.NODE_ID==(model.NODE_ID));
				}
				if(model.BTN_ID!=null)
				{
				  condition.And(REVIEW_LOG._.BTN_ID==(model.BTN_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERNAME))
				{
				  condition.And(REVIEW_LOG._.OPERNAME.Contain(model.OPERNAME));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(REVIEW_LOG._.USER_ID==(model.USER_ID));
				}
				if(model.OPER_TM!=null)
				{
				  condition.And(REVIEW_LOG._.OPER_TM==(model.OPER_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.C1))
				{
				  condition.And(REVIEW_LOG._.C1.Contain(model.C1));
				}
				if(!string.IsNullOrWhiteSpace(model.C2))
				{
				  condition.And(REVIEW_LOG._.C2.Contain(model.C2));
				}
				if(!string.IsNullOrWhiteSpace(model.C3))
				{
				  condition.And(REVIEW_LOG._.C3.Contain(model.C3));
				}
				if(!string.IsNullOrWhiteSpace(model.C4))
				{
				  condition.And(REVIEW_LOG._.C4.Contain(model.C4));
				}
				if(!string.IsNullOrWhiteSpace(model.C5))
				{
				  condition.And(REVIEW_LOG._.C5.Contain(model.C5));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_DIC))
				{
				  condition.And(REVIEW_LOG._.DATA_DIC.Contain(model.DATA_DIC));
				}
		return condition;
	}
        #endregion
    }
}