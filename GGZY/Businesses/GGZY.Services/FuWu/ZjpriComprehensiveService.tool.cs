using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriComprehensiveService : BaseServiceT<ZJPRI_COMPREHENSIVE>
    {
        #region 接口实现
        
		public List<ZJPRI_COMPREHENSIVE> FindList(ZJPRI_COMPREHENSIVE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_COMPREHENSIVE> PageList(ZJPRI_COMPREHENSIVE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_COMPREHENSIVE._.DK_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="DK_ID">唯一标识码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string DK_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_COMPREHENSIVE._.DK_ID == DK_ID);
			
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
        public GeneralResult Edit(ZJPRI_COMPREHENSIVE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.DK_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_COMPREHENSIVE entity)
	{		
		entity.Attach();
		entity.DK_ID=model.DK_ID;
		entity.INDUSTRY=model.INDUSTRY;
		entity.RANK=model.RANK;
		entity.CORPNAME=model.CORPNAME;
		entity.SCCORPCODE=model.SCCORPCODE;
		entity.CORPCODE=model.CORPCODE;
		entity.SCORE=model.SCORE;
		entity.SYEAR=model.SYEAR;
		entity.QUARTER=model.QUARTER;
		entity.SCORETYPE=model.SCORETYPE;
		entity.SCOREDATE=model.SCOREDATE;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
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
        public GeneralResult Add(ZJPRI_COMPREHENSIVE model)
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
                    Delete(ZJPRI_COMPREHENSIVE._.DK_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_COMPREHENSIVE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_COMPREHENSIVE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.DK_ID))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.DK_ID.Contain(model.DK_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRY))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.INDUSTRY.Contain(model.INDUSTRY));
				}
				if(model.RANK!=null)
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.RANK==(model.RANK));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPNAME))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.CORPNAME.Contain(model.CORPNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SCCORPCODE))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.SCCORPCODE.Contain(model.SCCORPCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPCODE))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.CORPCODE.Contain(model.CORPCODE));
				}
				if(model.SCORE!=null)
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.SCORE==(model.SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.SYEAR))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.SYEAR.Contain(model.SYEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.QUARTER))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.QUARTER.Contain(model.QUARTER));
				}
				if(!string.IsNullOrWhiteSpace(model.SCORETYPE))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.SCORETYPE.Contain(model.SCORETYPE));
				}
				if(model.SCOREDATE!=null)
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.SCOREDATE==(model.SCOREDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_COMPREHENSIVE._.VERSION.Contain(model.VERSION));
				}
		return condition;
	}
        #endregion
    }
}