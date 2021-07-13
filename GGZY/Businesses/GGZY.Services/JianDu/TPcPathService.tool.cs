using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TPcPathService : BaseServiceT<T_PC_PATH>
    {
        #region 接口实现
        
		public List<T_PC_PATH> FindList(T_PC_PATH model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PC_PATH> PageList(T_PC_PATH model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PC_PATH._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_PC_PATH._.ID == ID);
			
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
        public GeneralResult Edit(T_PC_PATH model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PC_PATH entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PC_CODE=model.PC_CODE;
		entity.FROM_NODE=model.FROM_NODE;
		entity.TO_NODE=model.TO_NODE;
		entity.TEXT=model.TEXT;
		entity.X=model.X;
		entity.Y=model.Y;
		entity.DOTS=model.DOTS;
		entity.TYPE=model.TYPE;
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
        public GeneralResult Add(T_PC_PATH model)
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
                    Delete(T_PC_PATH._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PC_PATH> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PC_PATH model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PC_PATH._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PC_CODE))
				{
				  condition.And(T_PC_PATH._.PC_CODE.Contain(model.PC_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.FROM_NODE))
				{
				  condition.And(T_PC_PATH._.FROM_NODE.Contain(model.FROM_NODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TO_NODE))
				{
				  condition.And(T_PC_PATH._.TO_NODE.Contain(model.TO_NODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEXT))
				{
				  condition.And(T_PC_PATH._.TEXT.Contain(model.TEXT));
				}
				if(model.X!=null)
				{
				  condition.And(T_PC_PATH._.X==(model.X));
				}
				if(model.Y!=null)
				{
				  condition.And(T_PC_PATH._.Y==(model.Y));
				}
				if(!string.IsNullOrWhiteSpace(model.DOTS))
				{
				  condition.And(T_PC_PATH._.DOTS.Contain(model.DOTS));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_PC_PATH._.TYPE.Contain(model.TYPE));
				}
		return condition;
	}
        #endregion
    }
}