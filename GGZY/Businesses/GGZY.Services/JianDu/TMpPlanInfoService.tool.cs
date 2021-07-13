using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TMpPlanInfoService : BaseServiceT<T_MP_PLAN_INFO>
    {
        #region 接口实现
        
		public List<T_MP_PLAN_INFO> FindList(T_MP_PLAN_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MP_PLAN_INFO> PageList(T_MP_PLAN_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_MP_PLAN_INFO._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_MP_PLAN_INFO._.ID == ID);
			
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
        public GeneralResult Edit(T_MP_PLAN_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_MP_PLAN_INFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.ASC_ID=model.ASC_ID;
		entity.STAGE_TYPE=model.STAGE_TYPE;
		entity.ISUSER=model.ISUSER;
		entity.SUNIT=model.SUNIT;
		entity.OPEN_RANGE=model.OPEN_RANGE;
		entity.REMARK=model.REMARK;
		entity.KIND=model.KIND;
		entity.TYPE=model.TYPE;
		entity.CODE=model.CODE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CONTENT_URL=model.CONTENT_URL;
		entity.LEVEL_TYPE=model.LEVEL_TYPE;
		entity.SU_AREACODE=model.SU_AREACODE;
		entity.NODE_CODE=model.NODE_CODE;
		entity.JUDGE_DESC=model.JUDGE_DESC;
		entity.JUDGE_DESC2=model.JUDGE_DESC2;
		entity.MUTEX_MP=model.MUTEX_MP;
		entity.IS_HIDE=model.IS_HIDE;
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
        public GeneralResult Add(T_MP_PLAN_INFO model)
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
                    Delete(T_MP_PLAN_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MP_PLAN_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_MP_PLAN_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_MP_PLAN_INFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_MP_PLAN_INFO._.NAME.Contain(model.NAME));
				}
				if(model.ASC_ID!=null)
				{
				  condition.And(T_MP_PLAN_INFO._.ASC_ID==(model.ASC_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.STAGE_TYPE))
				{
				  condition.And(T_MP_PLAN_INFO._.STAGE_TYPE.Contain(model.STAGE_TYPE));
				}
				if(model.ISUSER!=null)
				{
				  condition.And(T_MP_PLAN_INFO._.ISUSER==(model.ISUSER));
				}
				if(!string.IsNullOrWhiteSpace(model.SUNIT))
				{
				  condition.And(T_MP_PLAN_INFO._.SUNIT.Contain(model.SUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_RANGE))
				{
				  condition.And(T_MP_PLAN_INFO._.OPEN_RANGE.Contain(model.OPEN_RANGE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_MP_PLAN_INFO._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.KIND))
				{
				  condition.And(T_MP_PLAN_INFO._.KIND.Contain(model.KIND));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_MP_PLAN_INFO._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_MP_PLAN_INFO._.CODE.Contain(model.CODE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_MP_PLAN_INFO._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT_URL))
				{
				  condition.And(T_MP_PLAN_INFO._.CONTENT_URL.Contain(model.CONTENT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.LEVEL_TYPE))
				{
				  condition.And(T_MP_PLAN_INFO._.LEVEL_TYPE.Contain(model.LEVEL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SU_AREACODE))
				{
				  condition.And(T_MP_PLAN_INFO._.SU_AREACODE.Contain(model.SU_AREACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NODE_CODE))
				{
				  condition.And(T_MP_PLAN_INFO._.NODE_CODE.Contain(model.NODE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.JUDGE_DESC))
				{
				  condition.And(T_MP_PLAN_INFO._.JUDGE_DESC.Contain(model.JUDGE_DESC));
				}
				if(!string.IsNullOrWhiteSpace(model.JUDGE_DESC2))
				{
				  condition.And(T_MP_PLAN_INFO._.JUDGE_DESC2.Contain(model.JUDGE_DESC2));
				}
				if(!string.IsNullOrWhiteSpace(model.MUTEX_MP))
				{
				  condition.And(T_MP_PLAN_INFO._.MUTEX_MP.Contain(model.MUTEX_MP));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_HIDE))
				{
				  condition.And(T_MP_PLAN_INFO._.IS_HIDE.Contain(model.IS_HIDE));
				}
		return condition;
	}
        #endregion
    }
}