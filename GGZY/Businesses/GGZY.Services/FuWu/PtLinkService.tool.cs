using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtLinkService : BaseServiceT<PT_LINK>
    {
        #region 接口实现
        
		public List<PT_LINK> FindList(PT_LINK model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_LINK> PageList(PT_LINK model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_LINK._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_LINK._.ID == ID);
			
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
        public GeneralResult Edit(PT_LINK model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_LINK entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.ADDRESS=model.ADDRESS;
		entity.TYPE=model.TYPE;
		entity.TIME=model.TIME;
		entity.ORDERID=model.ORDERID;
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
        public GeneralResult Add(PT_LINK model)
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
                    Delete(PT_LINK._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_LINK> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_LINK model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_LINK._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(PT_LINK._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(PT_LINK._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(PT_LINK._.TYPE.Contain(model.TYPE));
				}
				if(model.TIME!=null)
				{
				  condition.And(PT_LINK._.TIME==(model.TIME));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(PT_LINK._.ORDERID==(model.ORDERID));
				}
		return condition;
	}
        #endregion
    }
}