using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class LogReportService : BaseServiceT<LOG_REPORT>
    {
        #region 接口实现
        
		public List<LOG_REPORT> FindList(LOG_REPORT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<LOG_REPORT> PageList(LOG_REPORT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, LOG_REPORT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(LOG_REPORT._.ID == ID);
			
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
        public GeneralResult Edit(LOG_REPORT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is LOG_REPORT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REPORT_NAME=model.REPORT_NAME;
		entity.REPORT_TYPE=model.REPORT_TYPE;
		entity.REPORT_PERIOD=model.REPORT_PERIOD;
		entity.REPORT_CONTENT=model.REPORT_CONTENT;
		entity.REPORT_TIME=model.REPORT_TIME;
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
        public GeneralResult Add(LOG_REPORT model)
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
                    Delete(LOG_REPORT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<LOG_REPORT> model)
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
       	protected WhereClipBuilder ConditionBuilder(LOG_REPORT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(LOG_REPORT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REPORT_NAME))
				{
				  condition.And(LOG_REPORT._.REPORT_NAME.Contain(model.REPORT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REPORT_TYPE))
				{
				  condition.And(LOG_REPORT._.REPORT_TYPE.Contain(model.REPORT_TYPE));
				}
				if(model.REPORT_PERIOD!=null)
				{
				  condition.And(LOG_REPORT._.REPORT_PERIOD==(model.REPORT_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.REPORT_CONTENT))
				{
				  condition.And(LOG_REPORT._.REPORT_CONTENT.Contain(model.REPORT_CONTENT));
				}
				if(model.REPORT_TIME!=null)
				{
				  condition.And(LOG_REPORT._.REPORT_TIME==(model.REPORT_TIME));
				}
		return condition;
	}
        #endregion
    }
}