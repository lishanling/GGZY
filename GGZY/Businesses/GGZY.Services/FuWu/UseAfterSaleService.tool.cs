using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class UseAfterSaleService : BaseServiceT<USE_AFTER_SALE>
    {
        #region 接口实现
        
		public List<USE_AFTER_SALE> FindList(USE_AFTER_SALE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<USE_AFTER_SALE> PageList(USE_AFTER_SALE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, USE_AFTER_SALE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(USE_AFTER_SALE._.ID == ID);
			
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
        public GeneralResult Edit(USE_AFTER_SALE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is USE_AFTER_SALE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.USE=model.USE;
		entity.DEBUG=model.DEBUG;
		entity.DESIGN_CONTECT=model.DESIGN_CONTECT;
		entity.INSTALLATION_SUPERVESOR=model.INSTALLATION_SUPERVESOR;
		entity.TRAIN=model.TRAIN;
		entity.PROJECT_MANAGE=model.PROJECT_MANAGE;
		entity.GUARANTEE_SERVICE=model.GUARANTEE_SERVICE;
		entity.PORDUCT_PERFONMANCE=model.PORDUCT_PERFONMANCE;
		entity.PACKAGE=model.PACKAGE;
		entity.DESIGN_INSTALL=model.DESIGN_INSTALL;
		entity.AFTER_SALE_SERVICE=model.AFTER_SALE_SERVICE;
		entity.AFTER_SALE_CONTECT=model.AFTER_SALE_CONTECT;
		entity.PHONE=model.PHONE;
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
        public GeneralResult Add(USE_AFTER_SALE model)
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
                    Delete(USE_AFTER_SALE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<USE_AFTER_SALE> model)
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
       	protected WhereClipBuilder ConditionBuilder(USE_AFTER_SALE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(USE_AFTER_SALE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.USE))
				{
				  condition.And(USE_AFTER_SALE._.USE.Contain(model.USE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEBUG))
				{
				  condition.And(USE_AFTER_SALE._.DEBUG.Contain(model.DEBUG));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGN_CONTECT))
				{
				  condition.And(USE_AFTER_SALE._.DESIGN_CONTECT.Contain(model.DESIGN_CONTECT));
				}
				if(!string.IsNullOrWhiteSpace(model.INSTALLATION_SUPERVESOR))
				{
				  condition.And(USE_AFTER_SALE._.INSTALLATION_SUPERVESOR.Contain(model.INSTALLATION_SUPERVESOR));
				}
				if(!string.IsNullOrWhiteSpace(model.TRAIN))
				{
				  condition.And(USE_AFTER_SALE._.TRAIN.Contain(model.TRAIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_MANAGE))
				{
				  condition.And(USE_AFTER_SALE._.PROJECT_MANAGE.Contain(model.PROJECT_MANAGE));
				}
				if(model.GUARANTEE_SERVICE!=null)
				{
				  condition.And(USE_AFTER_SALE._.GUARANTEE_SERVICE==(model.GUARANTEE_SERVICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PORDUCT_PERFONMANCE))
				{
				  condition.And(USE_AFTER_SALE._.PORDUCT_PERFONMANCE.Contain(model.PORDUCT_PERFONMANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.PACKAGE))
				{
				  condition.And(USE_AFTER_SALE._.PACKAGE.Contain(model.PACKAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGN_INSTALL))
				{
				  condition.And(USE_AFTER_SALE._.DESIGN_INSTALL.Contain(model.DESIGN_INSTALL));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_SALE_SERVICE))
				{
				  condition.And(USE_AFTER_SALE._.AFTER_SALE_SERVICE.Contain(model.AFTER_SALE_SERVICE));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_SALE_CONTECT))
				{
				  condition.And(USE_AFTER_SALE._.AFTER_SALE_CONTECT.Contain(model.AFTER_SALE_CONTECT));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE))
				{
				  condition.And(USE_AFTER_SALE._.PHONE.Contain(model.PHONE));
				}
		return condition;
	}
        #endregion
    }
}