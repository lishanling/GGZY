using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMessageService : BaseServiceT<T_MESSAGE>
    {
        #region 接口实现
        
		public List<T_MESSAGE> FindList(T_MESSAGE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MESSAGE> PageList(T_MESSAGE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_MESSAGE._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_MESSAGE._.ID == ID);
			
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
        public GeneralResult Edit(T_MESSAGE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_MESSAGE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SID=model.SID;
		entity.RID=model.RID;
		entity.MID=model.MID;
		entity.TID=model.TID;
		entity.TM=model.TM;
		entity.STATUS=model.STATUS;
		entity.IS_DEL=model.IS_DEL;
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
        public GeneralResult Add(T_MESSAGE model)
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
                    Delete(T_MESSAGE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MESSAGE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_MESSAGE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_MESSAGE._.ID==(model.ID));
				}
				if(model.SID!=null)
				{
				  condition.And(T_MESSAGE._.SID==(model.SID));
				}
				if(model.RID!=null)
				{
				  condition.And(T_MESSAGE._.RID==(model.RID));
				}
				if(model.MID!=null)
				{
				  condition.And(T_MESSAGE._.MID==(model.MID));
				}
				if(model.TID!=null)
				{
				  condition.And(T_MESSAGE._.TID==(model.TID));
				}
				if(model.TM!=null)
				{
				  condition.And(T_MESSAGE._.TM==(model.TM));
				}
				if(model.STATUS!=null)
				{
				  condition.And(T_MESSAGE._.STATUS==(model.STATUS));
				}
				if(model.IS_DEL!=null)
				{
				  condition.And(T_MESSAGE._.IS_DEL==(model.IS_DEL));
				}
		return condition;
	}
        #endregion
    }
}