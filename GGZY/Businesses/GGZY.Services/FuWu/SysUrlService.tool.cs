using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysUrlService : BaseServiceT<SYS_URL>
    {
        #region 接口实现
        
		public List<SYS_URL> FindList(SYS_URL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_URL> PageList(SYS_URL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_URL._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_URL._.ID == ID);
			
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
        public GeneralResult Edit(SYS_URL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_URL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.MENUID=model.MENUID;
		entity.URL=model.URL;
		entity.PARAM=model.PARAM;
		entity.POWER=model.POWER;
		entity.IS_ENABLE=model.IS_ENABLE;
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
        public GeneralResult Add(SYS_URL model)
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
                    Delete(SYS_URL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_URL> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_URL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_URL._.ID==(model.ID));
				}
				if(model.MENUID!=null)
				{
				  condition.And(SYS_URL._.MENUID==(model.MENUID));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(SYS_URL._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PARAM))
				{
				  condition.And(SYS_URL._.PARAM.Contain(model.PARAM));
				}
				if(!string.IsNullOrWhiteSpace(model.POWER))
				{
				  condition.And(SYS_URL._.POWER.Contain(model.POWER));
				}
				if(model.IS_ENABLE!=null)
				{
				  condition.And(SYS_URL._.IS_ENABLE==(model.IS_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_URL._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}