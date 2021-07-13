using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TDownloadlistService : BaseServiceT<T_DOWNLOADLIST>
    {
        #region 接口实现
        
		public List<T_DOWNLOADLIST> FindList(T_DOWNLOADLIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_DOWNLOADLIST> PageList(T_DOWNLOADLIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_DOWNLOADLIST._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_DOWNLOADLIST._.ID == ID);
			
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
        public GeneralResult Edit(T_DOWNLOADLIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_DOWNLOADLIST entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.SUB_TITLE=model.SUB_TITLE;
		entity.ICON=model.ICON;
		entity.FILES=model.FILES;
		entity.REMARK=model.REMARK;
		entity.IS_PUBLIC=model.IS_PUBLIC;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATE_ID=model.CREATE_ID;
		entity.ORDER_BY=model.ORDER_BY;
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
        public GeneralResult Add(T_DOWNLOADLIST model)
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
                    Delete(T_DOWNLOADLIST._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_DOWNLOADLIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_DOWNLOADLIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_DOWNLOADLIST._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_DOWNLOADLIST._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUB_TITLE))
				{
				  condition.And(T_DOWNLOADLIST._.SUB_TITLE.Contain(model.SUB_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ICON))
				{
				  condition.And(T_DOWNLOADLIST._.ICON.Contain(model.ICON));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(T_DOWNLOADLIST._.FILES.Contain(model.FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_DOWNLOADLIST._.REMARK.Contain(model.REMARK));
				}
				if(model.IS_PUBLIC!=null)
				{
				  condition.And(T_DOWNLOADLIST._.IS_PUBLIC==(model.IS_PUBLIC));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_DOWNLOADLIST._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_ID))
				{
				  condition.And(T_DOWNLOADLIST._.CREATE_ID.Contain(model.CREATE_ID));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(T_DOWNLOADLIST._.ORDER_BY==(model.ORDER_BY));
				}
				if(model.TYPE!=null)
				{
				  condition.And(T_DOWNLOADLIST._.TYPE==(model.TYPE));
				}
		return condition;
	}
        #endregion
    }
}