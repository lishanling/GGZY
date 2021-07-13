using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TPcNodeService : BaseServiceT<T_PC_NODE>
    {
        #region 接口实现
        
		public List<T_PC_NODE> FindList(T_PC_NODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PC_NODE> PageList(T_PC_NODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PC_NODE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_PC_NODE._.ID == ID);
			
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
        public GeneralResult Edit(T_PC_NODE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PC_NODE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PC_CODE=model.PC_CODE;
		entity.CODE=model.CODE;
		entity.TEXT=model.TEXT;
		entity.X=model.X;
		entity.Y=model.Y;
		entity.WIDTH=model.WIDTH;
		entity.HEIGHT=model.HEIGHT;
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
        public GeneralResult Add(T_PC_NODE model)
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
                    Delete(T_PC_NODE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PC_NODE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PC_NODE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PC_NODE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PC_CODE))
				{
				  condition.And(T_PC_NODE._.PC_CODE.Contain(model.PC_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_PC_NODE._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEXT))
				{
				  condition.And(T_PC_NODE._.TEXT.Contain(model.TEXT));
				}
				if(model.X!=null)
				{
				  condition.And(T_PC_NODE._.X==(model.X));
				}
				if(model.Y!=null)
				{
				  condition.And(T_PC_NODE._.Y==(model.Y));
				}
				if(model.WIDTH!=null)
				{
				  condition.And(T_PC_NODE._.WIDTH==(model.WIDTH));
				}
				if(model.HEIGHT!=null)
				{
				  condition.And(T_PC_NODE._.HEIGHT==(model.HEIGHT));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_PC_NODE._.TYPE.Contain(model.TYPE));
				}
		return condition;
	}
        #endregion
    }
}