using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AnomalyInfoService : BaseServiceT<ANOMALY_INFO>
    {
        #region 接口实现
        
		public List<ANOMALY_INFO> FindList(ANOMALY_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ANOMALY_INFO> PageList(ANOMALY_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ANOMALY_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">数据主键id</param>
      /// <param name="M_KEY">数据M_KEY</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID,string M_KEY)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ANOMALY_INFO._.M_ID == M_ID);
			condition.And(ANOMALY_INFO._.M_KEY == M_KEY);
			
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
        public GeneralResult Edit(ANOMALY_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID,model.M_KEY);
	
	if(viewResult.Success  && viewResult.Data is ANOMALY_INFO entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_KEY=model.M_KEY;
		entity.ANOMALY=model.ANOMALY;
		entity.M_TABLE=model.M_TABLE;
		entity.M_TM=model.M_TM;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.UPDATE_TIME=model.UPDATE_TIME;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.ID=model.ID;
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
        public GeneralResult Add(ANOMALY_INFO model)
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
                    Delete(ANOMALY_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ANOMALY_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(ANOMALY_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(ANOMALY_INFO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(ANOMALY_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.ANOMALY))
				{
				  condition.And(ANOMALY_INFO._.ANOMALY.Contain(model.ANOMALY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TABLE))
				{
				  condition.And(ANOMALY_INFO._.M_TABLE.Contain(model.M_TABLE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ANOMALY_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(ANOMALY_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(ANOMALY_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.UPDATE_TIME!=null)
				{
				  condition.And(ANOMALY_INFO._.UPDATE_TIME==(model.UPDATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ANOMALY_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.ID!=null)
				{
				  condition.And(ANOMALY_INFO._.ID==(model.ID));
				}
		return condition;
	}
        #endregion
    }
}