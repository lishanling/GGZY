using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtAtypeService : BaseServiceT<PT_ATYPE>
    {
        #region 接口实现
        
		public List<PT_ATYPE> FindList(PT_ATYPE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ATYPE> PageList(PT_ATYPE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_ATYPE._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(PT_ATYPE._.ID == ID);
			
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
        public GeneralResult Edit(PT_ATYPE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_ATYPE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PARENT_ID=model.PARENT_ID;
		entity.TEXT=model.TEXT;
		entity.CODE=model.CODE;
		entity.ORDER_ID=model.ORDER_ID;
		entity.REMARK=model.REMARK;
		entity.SHOWTYPE=model.SHOWTYPE;
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
        public GeneralResult Add(PT_ATYPE model)
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
                    Delete(PT_ATYPE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ATYPE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_ATYPE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_ATYPE._.ID==(model.ID));
				}
				if(model.PARENT_ID!=null)
				{
				  condition.And(PT_ATYPE._.PARENT_ID==(model.PARENT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TEXT))
				{
				  condition.And(PT_ATYPE._.TEXT.Contain(model.TEXT));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(PT_ATYPE._.CODE.Contain(model.CODE));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(PT_ATYPE._.ORDER_ID==(model.ORDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(PT_ATYPE._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.SHOWTYPE))
				{
				  condition.And(PT_ATYPE._.SHOWTYPE.Contain(model.SHOWTYPE));
				}
		return condition;
	}
        #endregion
    }
}