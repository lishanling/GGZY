using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AgencyAprInfoService : BaseServiceT<AGENCY_APR_INFO>
    {
        #region 接口实现
        
		public List<AGENCY_APR_INFO> FindList(AGENCY_APR_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<AGENCY_APR_INFO> PageList(AGENCY_APR_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, AGENCY_APR_INFO._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(AGENCY_APR_INFO._.ID == ID);
			
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
        public GeneralResult Edit(AGENCY_APR_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is AGENCY_APR_INFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.AGENCY_CODE=model.AGENCY_CODE;
		entity.AGENCY_NAME=model.AGENCY_NAME;
		entity.SCORE=model.SCORE;
		entity.APR_CONTENT=model.APR_CONTENT;
		entity.APR_DATE=model.APR_DATE;
		entity.APR_PERSON=model.APR_PERSON;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(AGENCY_APR_INFO model)
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
                    Delete(AGENCY_APR_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<AGENCY_APR_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(AGENCY_APR_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(AGENCY_APR_INFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_CODE))
				{
				  condition.And(AGENCY_APR_INFO._.AGENCY_CODE.Contain(model.AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_NAME))
				{
				  condition.And(AGENCY_APR_INFO._.AGENCY_NAME.Contain(model.AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SCORE))
				{
				  condition.And(AGENCY_APR_INFO._.SCORE.Contain(model.SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.APR_CONTENT))
				{
				  condition.And(AGENCY_APR_INFO._.APR_CONTENT.Contain(model.APR_CONTENT));
				}
				if(model.APR_DATE!=null)
				{
				  condition.And(AGENCY_APR_INFO._.APR_DATE==(model.APR_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.APR_PERSON))
				{
				  condition.And(AGENCY_APR_INFO._.APR_PERSON.Contain(model.APR_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(AGENCY_APR_INFO._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}