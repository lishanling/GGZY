using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMedicalService : BaseServiceT<T_MEDICAL>
    {
        #region 接口实现
        
		public List<T_MEDICAL> FindList(T_MEDICAL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MEDICAL> PageList(T_MEDICAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_MEDICAL._.SYNC_PROD_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="SYNC_PROD_ID">主键ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string SYNC_PROD_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_MEDICAL._.SYNC_PROD_ID == SYNC_PROD_ID);
			
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
        public GeneralResult Edit(T_MEDICAL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.SYNC_PROD_ID);
	
	if(viewResult.Success  && viewResult.Data is T_MEDICAL entity)
	{		
		entity.Attach();
		entity.SYNC_PROD_ID=model.SYNC_PROD_ID;
		entity.DIRCODE=model.DIRCODE;
		entity.DIRNAME=model.DIRNAME;
		entity.NAMECN=model.NAMECN;
		entity.DRUGWAY=model.DRUGWAY;
		entity.SMLNAME=model.SMLNAME;
		entity.NORMF=model.NORMF;
		entity.CONVERTF=model.CONVERTF;
		entity.FACNAME=model.FACNAME;
		entity.SELECTEDGOODS=model.SELECTEDGOODS;
		entity.SALELIMIT=model.SALELIMIT;
		entity.PAYPRICE=model.PAYPRICE;
		entity.LIMITEDRANGE=model.LIMITEDRANGE;
		entity.UPDATE_TIME=model.UPDATE_TIME;
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
        public GeneralResult Add(T_MEDICAL model)
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
                    Delete(T_MEDICAL._.SYNC_PROD_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MEDICAL> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_MEDICAL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.SYNC_PROD_ID))
				{
				  condition.And(T_MEDICAL._.SYNC_PROD_ID.Contain(model.SYNC_PROD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DIRCODE))
				{
				  condition.And(T_MEDICAL._.DIRCODE.Contain(model.DIRCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DIRNAME))
				{
				  condition.And(T_MEDICAL._.DIRNAME.Contain(model.DIRNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.NAMECN))
				{
				  condition.And(T_MEDICAL._.NAMECN.Contain(model.NAMECN));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGWAY))
				{
				  condition.And(T_MEDICAL._.DRUGWAY.Contain(model.DRUGWAY));
				}
				if(!string.IsNullOrWhiteSpace(model.SMLNAME))
				{
				  condition.And(T_MEDICAL._.SMLNAME.Contain(model.SMLNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.NORMF))
				{
				  condition.And(T_MEDICAL._.NORMF.Contain(model.NORMF));
				}
				if(!string.IsNullOrWhiteSpace(model.CONVERTF))
				{
				  condition.And(T_MEDICAL._.CONVERTF.Contain(model.CONVERTF));
				}
				if(!string.IsNullOrWhiteSpace(model.FACNAME))
				{
				  condition.And(T_MEDICAL._.FACNAME.Contain(model.FACNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELECTEDGOODS))
				{
				  condition.And(T_MEDICAL._.SELECTEDGOODS.Contain(model.SELECTEDGOODS));
				}
				if(!string.IsNullOrWhiteSpace(model.SALELIMIT))
				{
				  condition.And(T_MEDICAL._.SALELIMIT.Contain(model.SALELIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYPRICE))
				{
				  condition.And(T_MEDICAL._.PAYPRICE.Contain(model.PAYPRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.LIMITEDRANGE))
				{
				  condition.And(T_MEDICAL._.LIMITEDRANGE.Contain(model.LIMITEDRANGE));
				}
				if(model.UPDATE_TIME!=null)
				{
				  condition.And(T_MEDICAL._.UPDATE_TIME==(model.UPDATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}