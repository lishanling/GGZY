using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysDicService : BaseServiceT<SYS_DIC>
    {
        #region 接口实现
        
		public List<SYS_DIC> FindList(SYS_DIC model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public List<SYS_DIC> FindList(List<string> type)
        {
            var condition = new WhereClipBuilder();

            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_DIC> PageList(SYS_DIC model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_DIC._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_DIC._.ID == ID);
			
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
        public GeneralResult Edit(SYS_DIC model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_DIC entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TYPE=model.TYPE;
		entity.TEXT=model.TEXT;
		entity.VALUE=model.VALUE;
		entity.ORDER_ID=model.ORDER_ID;
		entity.VALUE1=model.VALUE1;
		entity.VALUE2=model.VALUE2;
		entity.VALUE3=model.VALUE3;
		entity.VALUE4=model.VALUE4;
		entity.VALUE5=model.VALUE5;
		entity.PID=model.PID;
		entity.REMARK=model.REMARK;
		entity.IS_DEL=model.IS_DEL;
		entity.IS_ENABLE=model.IS_ENABLE;
		entity.OP_BY=model.OP_BY;
		entity.OP_TIME=model.OP_TIME;
		entity.PLATFORM=model.PLATFORM;
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
        public GeneralResult Add(SYS_DIC model)
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
                    Delete(SYS_DIC._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_DIC> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_DIC model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_DIC._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(SYS_DIC._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEXT))
				{
				  condition.And(SYS_DIC._.TEXT.Contain(model.TEXT));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE))
				{
				  condition.And(SYS_DIC._.VALUE.Contain(model.VALUE));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(SYS_DIC._.ORDER_ID==(model.ORDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE1))
				{
				  condition.And(SYS_DIC._.VALUE1.Contain(model.VALUE1));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE2))
				{
				  condition.And(SYS_DIC._.VALUE2.Contain(model.VALUE2));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE3))
				{
				  condition.And(SYS_DIC._.VALUE3.Contain(model.VALUE3));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE4))
				{
				  condition.And(SYS_DIC._.VALUE4.Contain(model.VALUE4));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE5))
				{
				  condition.And(SYS_DIC._.VALUE5.Contain(model.VALUE5));
				}
				if(model.PID!=null)
				{
				  condition.And(SYS_DIC._.PID==(model.PID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_DIC._.REMARK.Contain(model.REMARK));
				}
				if(model.IS_DEL!=null)
				{
				  condition.And(SYS_DIC._.IS_DEL==(model.IS_DEL));
				}
				if(model.IS_ENABLE!=null)
				{
				  condition.And(SYS_DIC._.IS_ENABLE==(model.IS_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.OP_BY))
				{
				  condition.And(SYS_DIC._.OP_BY.Contain(model.OP_BY));
				}
				if(model.OP_TIME!=null)
				{
				  condition.And(SYS_DIC._.OP_TIME==(model.OP_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM))
				{
				  condition.And(SYS_DIC._.PLATFORM.Contain(model.PLATFORM));
				}
		return condition;
	}
        #endregion
    }
}