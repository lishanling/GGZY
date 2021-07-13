using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TComplaintsProcessService : BaseServiceT<T_COMPLAINTS_PROCESS>
    {
        #region 接口实现
        
		public List<T_COMPLAINTS_PROCESS> FindList(T_COMPLAINTS_PROCESS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_COMPLAINTS_PROCESS> PageList(T_COMPLAINTS_PROCESS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_COMPLAINTS_PROCESS._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_COMPLAINTS_PROCESS._.ID == ID);
			
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
        public GeneralResult Edit(T_COMPLAINTS_PROCESS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_COMPLAINTS_PROCESS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.ITEM_NUM=model.ITEM_NUM;
		entity.PRO_NAME=model.PRO_NAME;
		entity.PRO_TYPE=model.PRO_TYPE;
		entity.COMPLAINT=model.COMPLAINT;
		entity.CODE=model.CODE;
		entity.NAME=model.NAME;
		entity.CONTENT=model.CONTENT;
		entity.TIME=model.TIME;
		entity.ACCEPTOR=model.ACCEPTOR;
		entity.RECRPTION_TIME=model.RECRPTION_TIME;
		entity.DEAL_PEO=model.DEAL_PEO;
		entity.DEAL_TIME=model.DEAL_TIME;
		entity.PRO_CONTENT=model.PRO_CONTENT;
		entity.PUBLISHER=model.PUBLISHER;
		entity.PUB_TIME=model.PUB_TIME;
		entity.ANNEX=model.ANNEX;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_KEY=model.M_KEY;
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
        public GeneralResult Add(T_COMPLAINTS_PROCESS model)
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
                    Delete(T_COMPLAINTS_PROCESS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_COMPLAINTS_PROCESS> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_COMPLAINTS_PROCESS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_COMPLAINTS_PROCESS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ITEM_NUM))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.ITEM_NUM.Contain(model.ITEM_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NAME))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.PRO_NAME.Contain(model.PRO_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_TYPE))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.PRO_TYPE.Contain(model.PRO_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.COMPLAINT.Contain(model.COMPLAINT));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.CONTENT.Contain(model.CONTENT));
				}
				if(model.TIME!=null)
				{
				  condition.And(T_COMPLAINTS_PROCESS._.TIME==(model.TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPTOR))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.ACCEPTOR.Contain(model.ACCEPTOR));
				}
				if(model.RECRPTION_TIME!=null)
				{
				  condition.And(T_COMPLAINTS_PROCESS._.RECRPTION_TIME==(model.RECRPTION_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DEAL_PEO))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.DEAL_PEO.Contain(model.DEAL_PEO));
				}
				if(model.DEAL_TIME!=null)
				{
				  condition.And(T_COMPLAINTS_PROCESS._.DEAL_TIME==(model.DEAL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_CONTENT))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.PRO_CONTENT.Contain(model.PRO_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLISHER))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.PUBLISHER.Contain(model.PUBLISHER));
				}
				if(model.PUB_TIME!=null)
				{
				  condition.And(T_COMPLAINTS_PROCESS._.PUB_TIME==(model.PUB_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNEX))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.ANNEX.Contain(model.ANNEX));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_COMPLAINTS_PROCESS._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_COMPLAINTS_PROCESS._.M_KEY.Contain(model.M_KEY));
				}
		return condition;
	}
        #endregion
    }
}