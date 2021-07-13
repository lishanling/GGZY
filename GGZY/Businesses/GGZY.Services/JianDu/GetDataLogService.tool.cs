using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class GetdatalogService : BaseServiceT<GETDATALOG>
    {
        #region 接口实现
        
		public List<GETDATALOG> FindList(GETDATALOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<GETDATALOG> PageList(GETDATALOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, GETDATALOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(GETDATALOG._.ID == ID);
			
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
        public GeneralResult Edit(GETDATALOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is GETDATALOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CONSTRUCT_ID=model.CONSTRUCT_ID;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.GETTIME=model.GETTIME;
		entity.TYPE=model.TYPE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATETIME=model.M_CREATETIME;
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
        public GeneralResult Add(GETDATALOG model)
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
                    Delete(GETDATALOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<GETDATALOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(GETDATALOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(GETDATALOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCT_ID))
				{
				  condition.And(GETDATALOG._.CONSTRUCT_ID.Contain(model.CONSTRUCT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(GETDATALOG._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.GETTIME!=null)
				{
				  condition.And(GETDATALOG._.GETTIME==(model.GETTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(GETDATALOG._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(GETDATALOG._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATETIME!=null)
				{
				  condition.And(GETDATALOG._.M_CREATETIME==(model.M_CREATETIME));
				}
		return condition;
	}
        #endregion
    }
}