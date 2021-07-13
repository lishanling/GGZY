using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsDepconfigService : BaseServiceT<PT_ZXTS_DEPCONFIG>
    {
        #region 接口实现
        
		public List<PT_ZXTS_DEPCONFIG> FindList(PT_ZXTS_DEPCONFIG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ZXTS_DEPCONFIG> PageList(PT_ZXTS_DEPCONFIG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_ZXTS_DEPCONFIG._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_ZXTS_DEPCONFIG._.ID == ID);
			
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
        public GeneralResult Edit(PT_ZXTS_DEPCONFIG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_ZXTS_DEPCONFIG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.DEP_ID=model.DEP_ID;
		entity.USER_ID=model.USER_ID;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(PT_ZXTS_DEPCONFIG model)
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
                    Delete(PT_ZXTS_DEPCONFIG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ZXTS_DEPCONFIG> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_ZXTS_DEPCONFIG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_ZXTS_DEPCONFIG._.ID==(model.ID));
				}
				if(model.DEP_ID!=null)
				{
				  condition.And(PT_ZXTS_DEPCONFIG._.DEP_ID==(model.DEP_ID));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(PT_ZXTS_DEPCONFIG._.USER_ID==(model.USER_ID));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(PT_ZXTS_DEPCONFIG._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(PT_ZXTS_DEPCONFIG._.CREATE_TM==(model.CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}