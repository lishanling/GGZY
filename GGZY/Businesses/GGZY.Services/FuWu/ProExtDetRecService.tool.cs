using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProExtDetRecService : BaseServiceT<PRO_EXT_DET_REC>
    {
        #region 接口实现
        
		public List<PRO_EXT_DET_REC> FindList(PRO_EXT_DET_REC model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRO_EXT_DET_REC> PageList(PRO_EXT_DET_REC model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRO_EXT_DET_REC._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRO_EXT_DET_REC._.ID == ID);
			
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
        public GeneralResult Edit(PRO_EXT_DET_REC model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRO_EXT_DET_REC entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PRO_CODE=model.PRO_CODE;
		entity.PRO_NAME=model.PRO_NAME;
		entity.REC_TIME=model.REC_TIME;
		entity.REC_PERSON=model.REC_PERSON;
		entity.WORK_DESC=model.WORK_DESC;
		entity.COMM_REC=model.COMM_REC;
		entity.ACT_PROB_REC=model.ACT_PROB_REC;
		entity.RESULT=model.RESULT;
		entity.SUM_UP=model.SUM_UP;
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
        public GeneralResult Add(PRO_EXT_DET_REC model)
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
                    Delete(PRO_EXT_DET_REC._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRO_EXT_DET_REC> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRO_EXT_DET_REC model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRO_EXT_DET_REC._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_CODE))
				{
				  condition.And(PRO_EXT_DET_REC._.PRO_CODE.Contain(model.PRO_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NAME))
				{
				  condition.And(PRO_EXT_DET_REC._.PRO_NAME.Contain(model.PRO_NAME));
				}
				if(model.REC_TIME!=null)
				{
				  condition.And(PRO_EXT_DET_REC._.REC_TIME==(model.REC_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REC_PERSON))
				{
				  condition.And(PRO_EXT_DET_REC._.REC_PERSON.Contain(model.REC_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.WORK_DESC))
				{
				  condition.And(PRO_EXT_DET_REC._.WORK_DESC.Contain(model.WORK_DESC));
				}
				if(!string.IsNullOrWhiteSpace(model.COMM_REC))
				{
				  condition.And(PRO_EXT_DET_REC._.COMM_REC.Contain(model.COMM_REC));
				}
				if(!string.IsNullOrWhiteSpace(model.ACT_PROB_REC))
				{
				  condition.And(PRO_EXT_DET_REC._.ACT_PROB_REC.Contain(model.ACT_PROB_REC));
				}
				if(!string.IsNullOrWhiteSpace(model.RESULT))
				{
				  condition.And(PRO_EXT_DET_REC._.RESULT.Contain(model.RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUM_UP))
				{
				  condition.And(PRO_EXT_DET_REC._.SUM_UP.Contain(model.SUM_UP));
				}
		return condition;
	}
        #endregion
    }
}