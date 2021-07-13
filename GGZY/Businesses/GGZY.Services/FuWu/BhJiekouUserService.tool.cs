using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhJiekouUserService : BaseServiceT<BH_JIEKOU_USER>
    {
        #region 接口实现
        
		public List<BH_JIEKOU_USER> FindList(BH_JIEKOU_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BH_JIEKOU_USER> PageList(BH_JIEKOU_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BH_JIEKOU_USER._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BH_JIEKOU_USER._.ID == ID);
			
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
        public GeneralResult Edit(BH_JIEKOU_USER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is BH_JIEKOU_USER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.SYSTEM_NO=model.SYSTEM_NO;
		entity.SECRET=model.SECRET;
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
        public GeneralResult Add(BH_JIEKOU_USER model)
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
                    Delete(BH_JIEKOU_USER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BH_JIEKOU_USER> model)
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
       	protected WhereClipBuilder ConditionBuilder(BH_JIEKOU_USER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
#pragma warning disable CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
				if(model.ID!=null)
#pragma warning restore CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_JIEKOU_USER._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(BH_JIEKOU_USER._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NO))
				{
				  condition.And(BH_JIEKOU_USER._.SYSTEM_NO.Contain(model.SYSTEM_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.SECRET))
				{
				  condition.And(BH_JIEKOU_USER._.SECRET.Contain(model.SECRET));
				}
		return condition;
	}
        #endregion
    }
}