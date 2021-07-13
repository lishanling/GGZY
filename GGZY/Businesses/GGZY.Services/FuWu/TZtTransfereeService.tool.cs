using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtTransfereeService : BaseServiceT<T_ZT_TRANSFEREE>
    {
        #region 接口实现
        
		public List<T_ZT_TRANSFEREE> FindList(T_ZT_TRANSFEREE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_TRANSFEREE> PageList(T_ZT_TRANSFEREE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_TRANSFEREE._.LEGALCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="LEGALCODE">主体代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string LEGALCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_TRANSFEREE._.LEGALCODE == LEGALCODE);
			
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
        public GeneralResult Edit(T_ZT_TRANSFEREE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.LEGALCODE);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_TRANSFEREE entity)
	{		
		entity.Attach();
		entity.LEGALCODE=model.LEGALCODE;
		entity.COMPANYINDUSTRY=model.COMPANYINDUSTRY;
		entity.COMPANYTIME=model.COMPANYTIME;
		entity.ECONOMYTYPE=model.ECONOMYTYPE;
		entity.COMPANYSCALE=model.COMPANYSCALE;
		entity.COMPANYSCOPE=model.COMPANYSCOPE;
		entity.CUSTOMDEFINITIONDATAITEM=model.CUSTOMDEFINITIONDATAITEM;
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
        public GeneralResult Add(T_ZT_TRANSFEREE model)
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
                    Delete(T_ZT_TRANSFEREE._.LEGALCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_TRANSFEREE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_TRANSFEREE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.LEGALCODE))
				{
				  condition.And(T_ZT_TRANSFEREE._.LEGALCODE.Contain(model.LEGALCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYINDUSTRY))
				{
				  condition.And(T_ZT_TRANSFEREE._.COMPANYINDUSTRY.Contain(model.COMPANYINDUSTRY));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYTIME))
				{
				  condition.And(T_ZT_TRANSFEREE._.COMPANYTIME.Contain(model.COMPANYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ECONOMYTYPE))
				{
				  condition.And(T_ZT_TRANSFEREE._.ECONOMYTYPE.Contain(model.ECONOMYTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYSCALE))
				{
				  condition.And(T_ZT_TRANSFEREE._.COMPANYSCALE.Contain(model.COMPANYSCALE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYSCOPE))
				{
				  condition.And(T_ZT_TRANSFEREE._.COMPANYSCOPE.Contain(model.COMPANYSCOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CUSTOMDEFINITIONDATAITEM))
				{
				  condition.And(T_ZT_TRANSFEREE._.CUSTOMDEFINITIONDATAITEM.Contain(model.CUSTOMDEFINITIONDATAITEM));
				}
		return condition;
	}
        #endregion
    }
}