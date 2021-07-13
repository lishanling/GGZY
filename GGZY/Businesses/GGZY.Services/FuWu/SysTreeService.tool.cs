using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysTreeService : BaseServiceT<SYS_TREE>
    {
        #region 接口实现
        
		public List<SYS_TREE> FindList(SYS_TREE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_TREE> PageList(SYS_TREE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_TREE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_TREE._.ID == ID);
			
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
        public GeneralResult Edit(SYS_TREE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_TREE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PID=model.PID;
		entity.FLAG=model.FLAG;
		entity.NODETEXT=model.NODETEXT;
		entity.NODEVALUE=model.NODEVALUE;
		entity.NODEVALUE2=model.NODEVALUE2;
		entity.ORDERID=model.ORDERID;
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
        public GeneralResult Add(SYS_TREE model)
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
                    Delete(SYS_TREE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_TREE> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_TREE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_TREE._.ID==(model.ID));
				}
				if(model.PID!=null)
				{
				  condition.And(SYS_TREE._.PID==(model.PID));
				}
				if(model.FLAG!=null)
				{
				  condition.And(SYS_TREE._.FLAG==(model.FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.NODETEXT))
				{
				  condition.And(SYS_TREE._.NODETEXT.Contain(model.NODETEXT));
				}
				if(!string.IsNullOrWhiteSpace(model.NODEVALUE))
				{
				  condition.And(SYS_TREE._.NODEVALUE.Contain(model.NODEVALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.NODEVALUE2))
				{
				  condition.And(SYS_TREE._.NODEVALUE2.Contain(model.NODEVALUE2));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(SYS_TREE._.ORDERID==(model.ORDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_TREE._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}