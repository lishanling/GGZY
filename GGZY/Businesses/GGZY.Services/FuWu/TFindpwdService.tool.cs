using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TFindpwdService : BaseServiceT<T_FINDPWD>
    {
        #region 接口实现
        
		public List<T_FINDPWD> FindList(T_FINDPWD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_FINDPWD> PageList(T_FINDPWD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_FINDPWD._.GUID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="GUID">主键，36位guid</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(Guid GUID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_FINDPWD._.GUID == GUID);
			
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
        public GeneralResult Edit(T_FINDPWD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.GUID);
	
	if(viewResult.Success  && viewResult.Data is T_FINDPWD entity)
	{		
		entity.Attach();
		entity.GUID=model.GUID;
		entity.U_ID=model.U_ID;
		entity.CREATE_DATE=model.CREATE_DATE;
		entity.IS_ENABLE=model.IS_ENABLE;
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
        public GeneralResult Add(T_FINDPWD model)
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
                    Delete(T_FINDPWD._.GUID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_FINDPWD> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_FINDPWD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.GUID!=null)
				{
				  condition.And(T_FINDPWD._.GUID==(model.GUID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(T_FINDPWD._.U_ID==(model.U_ID));
				}
				if(model.CREATE_DATE!=null)
				{
				  condition.And(T_FINDPWD._.CREATE_DATE==(model.CREATE_DATE));
				}
				if(model.IS_ENABLE!=null)
				{
				  condition.And(T_FINDPWD._.IS_ENABLE==(model.IS_ENABLE));
				}
		return condition;
	}
        #endregion
    }
}