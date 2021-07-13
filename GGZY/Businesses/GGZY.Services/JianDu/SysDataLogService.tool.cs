using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysDataLogService : BaseServiceT<SYS_DATA_LOG>
    {
        #region 接口实现
        
		public List<SYS_DATA_LOG> FindList(SYS_DATA_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_DATA_LOG> PageList(SYS_DATA_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_DATA_LOG._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_DATA_LOG._.ID == ID);
			
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
        public GeneralResult Edit(SYS_DATA_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_DATA_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.U_ID=model.U_ID;
		entity.TB_NAME=model.TB_NAME;
		entity.KEY_FIELD=model.KEY_FIELD;
		entity.KEY_VALUE=model.KEY_VALUE;
		entity.OPERATION=model.OPERATION;
		entity.REMARK=model.REMARK;
		entity.TM=model.TM;
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
        public GeneralResult Add(SYS_DATA_LOG model)
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
                    Delete(SYS_DATA_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_DATA_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_DATA_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_DATA_LOG._.ID==(model.ID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(SYS_DATA_LOG._.U_ID==(model.U_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TB_NAME))
				{
				  condition.And(SYS_DATA_LOG._.TB_NAME.Contain(model.TB_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY_FIELD))
				{
				  condition.And(SYS_DATA_LOG._.KEY_FIELD.Contain(model.KEY_FIELD));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY_VALUE))
				{
				  condition.And(SYS_DATA_LOG._.KEY_VALUE.Contain(model.KEY_VALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATION))
				{
				  condition.And(SYS_DATA_LOG._.OPERATION.Contain(model.OPERATION));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_DATA_LOG._.REMARK.Contain(model.REMARK));
				}
				if(model.TM!=null)
				{
				  condition.And(SYS_DATA_LOG._.TM==(model.TM));
				}
		return condition;
	}
        #endregion
    }
}