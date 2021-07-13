using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TProSupervisionService : BaseServiceT<T_PRO_SUPERVISION>
    {
        #region 接口实现
        
		public List<T_PRO_SUPERVISION> FindList(T_PRO_SUPERVISION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PRO_SUPERVISION> PageList(T_PRO_SUPERVISION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PRO_SUPERVISION._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_PRO_SUPERVISION._.ID == ID);
			
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
        public GeneralResult Edit(T_PRO_SUPERVISION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PRO_SUPERVISION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PRO_PLA_NUM=model.PRO_PLA_NUM;
		entity.PRO_NAME_NUM=model.PRO_NAME_NUM;
		entity.LOT_NUM=model.LOT_NUM;
		entity.PROJECT=model.PROJECT;
		entity.ANNOUNCE=model.ANNOUNCE;
		entity.TEN_PUR_TRA=model.TEN_PUR_TRA;
		entity.QUA_REV=model.QUA_REV;
		entity.Q_A=model.Q_A;
		entity.MARGIN=model.MARGIN;
		entity.OPEN_BIDS=model.OPEN_BIDS;
		entity.WINNING_BID=model.WINNING_BID;
		entity.WINNING_NOTICE=model.WINNING_NOTICE;
		entity.PRO_STATUS=model.PRO_STATUS;
		entity.PRO_PROCESS=model.PRO_PROCESS;
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
        public GeneralResult Add(T_PRO_SUPERVISION model)
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
                    Delete(T_PRO_SUPERVISION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PRO_SUPERVISION> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PRO_SUPERVISION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PRO_SUPERVISION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_PLA_NUM))
				{
				  condition.And(T_PRO_SUPERVISION._.PRO_PLA_NUM.Contain(model.PRO_PLA_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NAME_NUM))
				{
				  condition.And(T_PRO_SUPERVISION._.PRO_NAME_NUM.Contain(model.PRO_NAME_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.LOT_NUM))
				{
				  condition.And(T_PRO_SUPERVISION._.LOT_NUM.Contain(model.LOT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT))
				{
				  condition.And(T_PRO_SUPERVISION._.PROJECT.Contain(model.PROJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCE))
				{
				  condition.And(T_PRO_SUPERVISION._.ANNOUNCE.Contain(model.ANNOUNCE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEN_PUR_TRA))
				{
				  condition.And(T_PRO_SUPERVISION._.TEN_PUR_TRA.Contain(model.TEN_PUR_TRA));
				}
				if(!string.IsNullOrWhiteSpace(model.QUA_REV))
				{
				  condition.And(T_PRO_SUPERVISION._.QUA_REV.Contain(model.QUA_REV));
				}
				if(!string.IsNullOrWhiteSpace(model.Q_A))
				{
				  condition.And(T_PRO_SUPERVISION._.Q_A.Contain(model.Q_A));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN))
				{
				  condition.And(T_PRO_SUPERVISION._.MARGIN.Contain(model.MARGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_BIDS))
				{
				  condition.And(T_PRO_SUPERVISION._.OPEN_BIDS.Contain(model.OPEN_BIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.WINNING_BID))
				{
				  condition.And(T_PRO_SUPERVISION._.WINNING_BID.Contain(model.WINNING_BID));
				}
				if(!string.IsNullOrWhiteSpace(model.WINNING_NOTICE))
				{
				  condition.And(T_PRO_SUPERVISION._.WINNING_NOTICE.Contain(model.WINNING_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_STATUS))
				{
				  condition.And(T_PRO_SUPERVISION._.PRO_STATUS.Contain(model.PRO_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_PROCESS))
				{
				  condition.And(T_PRO_SUPERVISION._.PRO_PROCESS.Contain(model.PRO_PROCESS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_PRO_SUPERVISION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_PRO_SUPERVISION._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_PRO_SUPERVISION._.M_KEY.Contain(model.M_KEY));
				}
		return condition;
	}
        #endregion
    }
}