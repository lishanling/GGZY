using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TableFliedService : BaseServiceT<TABLE_FLIED>
    {
        #region 接口实现
        
		public List<TABLE_FLIED> FindList(TABLE_FLIED model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TABLE_FLIED> PageList(TABLE_FLIED model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TABLE_FLIED._.CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="CODE">编码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(TABLE_FLIED._.CODE == CODE);
			
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
        public GeneralResult Edit(TABLE_FLIED model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.CODE);
	
	if(viewResult.Success  && viewResult.Data is TABLE_FLIED entity)
	{		
		entity.Attach();
		entity.CODE=model.CODE;
		entity.EN=model.EN;
		entity.CHS=model.CHS;
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
        public GeneralResult Add(TABLE_FLIED model)
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
                    Delete(TABLE_FLIED._.CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<TABLE_FLIED> model)
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
       	protected WhereClipBuilder ConditionBuilder(TABLE_FLIED model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.CODE!=null)
				{
				  condition.And(TABLE_FLIED._.CODE==(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EN))
				{
				  condition.And(TABLE_FLIED._.EN.Contain(model.EN));
				}
				if(!string.IsNullOrWhiteSpace(model.CHS))
				{
				  condition.And(TABLE_FLIED._.CHS.Contain(model.CHS));
				}
		return condition;
	}
        #endregion
    }
}