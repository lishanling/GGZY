using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ReviewButtonService : BaseServiceT<REVIEW_BUTTON>
    {
        #region 接口实现
        
		public List<REVIEW_BUTTON> FindList(REVIEW_BUTTON model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<REVIEW_BUTTON> PageList(REVIEW_BUTTON model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, REVIEW_BUTTON._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(REVIEW_BUTTON._.ID == ID);
			
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
        public GeneralResult Edit(REVIEW_BUTTON model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is REVIEW_BUTTON entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BT_NAME=model.BT_NAME;
		entity.BT_EVENT=model.BT_EVENT;
		entity.REMARK=model.REMARK;
		entity.TITLE=model.TITLE;
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
        public GeneralResult Add(REVIEW_BUTTON model)
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
                    Delete(REVIEW_BUTTON._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<REVIEW_BUTTON> model)
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
       	protected WhereClipBuilder ConditionBuilder(REVIEW_BUTTON model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(REVIEW_BUTTON._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BT_NAME))
				{
				  condition.And(REVIEW_BUTTON._.BT_NAME.Contain(model.BT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BT_EVENT))
				{
				  condition.And(REVIEW_BUTTON._.BT_EVENT.Contain(model.BT_EVENT));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(REVIEW_BUTTON._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(REVIEW_BUTTON._.TITLE.Contain(model.TITLE));
				}
		return condition;
	}
        #endregion
    }
}