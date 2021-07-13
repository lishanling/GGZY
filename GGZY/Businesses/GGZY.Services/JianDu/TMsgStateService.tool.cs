using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TMsgStateService : BaseServiceT<T_MSG_STATE>
    {
        #region 接口实现
        
		public List<T_MSG_STATE> FindList(T_MSG_STATE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MSG_STATE> PageList(T_MSG_STATE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_MSG_STATE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_MSG_STATE._.ID == ID);
			
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
        public GeneralResult Edit(T_MSG_STATE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_MSG_STATE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.U_ID=model.U_ID;
		entity.ISREAD=model.ISREAD;
		entity.READ_TM=model.READ_TM;
		entity.ISDEL=model.ISDEL;
		entity.DEL_TM=model.DEL_TM;
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
        public GeneralResult Add(T_MSG_STATE model)
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
                    Delete(T_MSG_STATE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MSG_STATE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_MSG_STATE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_MSG_STATE._.ID==(model.ID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(T_MSG_STATE._.U_ID==(model.U_ID));
				}
				if(model.ISREAD!=null)
				{
				  condition.And(T_MSG_STATE._.ISREAD==(model.ISREAD));
				}
				if(model.READ_TM!=null)
				{
				  condition.And(T_MSG_STATE._.READ_TM==(model.READ_TM));
				}
				if(model.ISDEL!=null)
				{
				  condition.And(T_MSG_STATE._.ISDEL==(model.ISDEL));
				}
				if(model.DEL_TM!=null)
				{
				  condition.And(T_MSG_STATE._.DEL_TM==(model.DEL_TM));
				}
				if(model.MID!=null)
				{
				  condition.And(T_MSG_STATE._.MID==(model.MID));
				}
		return condition;
	}
        #endregion
    }
}