using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMedicalTotleService : BaseServiceT<T_MEDICAL_TOTLE>
    {
        #region 接口实现
        
		public List<T_MEDICAL_TOTLE> FindList(T_MEDICAL_TOTLE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MEDICAL_TOTLE> PageList(T_MEDICAL_TOTLE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_MEDICAL_TOTLE._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">主键ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_MEDICAL_TOTLE._.ID == ID);
			
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
        public GeneralResult Edit(T_MEDICAL_TOTLE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_MEDICAL_TOTLE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.JY_DATE=model.JY_DATE;
		entity.FHJE=model.FHJE;
		entity.CPZS=model.CPZS;
		entity.YLJG=model.YLJG;
		entity.SCQY=model.SCQY;
		entity.PSQY=model.PSQY;
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
        public GeneralResult Add(T_MEDICAL_TOTLE model)
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
                    Delete(T_MEDICAL_TOTLE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MEDICAL_TOTLE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_MEDICAL_TOTLE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.ID==(model.ID));
				}
				if(model.JY_DATE!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.JY_DATE==(model.JY_DATE));
				}
				if(model.FHJE!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.FHJE==(model.FHJE));
				}
				if(model.CPZS!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.CPZS==(model.CPZS));
				}
				if(model.YLJG!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.YLJG==(model.YLJG));
				}
				if(model.SCQY!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.SCQY==(model.SCQY));
				}
				if(model.PSQY!=null)
				{
				  condition.And(T_MEDICAL_TOTLE._.PSQY==(model.PSQY));
				}
		return condition;
	}
        #endregion
    }
}