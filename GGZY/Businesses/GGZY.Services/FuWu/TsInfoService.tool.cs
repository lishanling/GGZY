using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TsInfoService : BaseServiceT<TS_INFO>
    {
        #region 接口实现
        
		public List<TS_INFO> FindList(TS_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TS_INFO> PageList(TS_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TS_INFO._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TS_INFO._.ID == ID);
			
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
        public GeneralResult Edit(TS_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TS_INFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.LP_INFO=model.LP_INFO;
		entity.TP_INFO=model.TP_INFO;
		entity.BAM_INFO=model.BAM_INFO;
		entity.BID_INFO=model.BID_INFO;
		entity.PHR_INFO=model.PHR_INFO;
		entity.PAM_INFO=model.PAM_INFO;
		entity.SUP_INFO=model.SUP_INFO;
		entity.TROR_INFO=model.TROR_INFO;
		entity.TREE_INFO=model.TREE_INFO;
		entity.CP_INFO=model.CP_INFO;
		entity.LP_TP_INFO=model.LP_TP_INFO;
		entity.PRER_BINFO=model.PRER_BINFO;
		entity.PRER_QINFO=model.PRER_QINFO;
		entity.PRER_PINFO=model.PRER_PINFO;
		entity.NP_BINFO=model.NP_BINFO;
		entity.DE_UNIT=model.DE_UNIT;
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
        public GeneralResult Add(TS_INFO model)
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
                    Delete(TS_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TS_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(TS_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TS_INFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.LP_INFO))
				{
				  condition.And(TS_INFO._.LP_INFO.Contain(model.LP_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.TP_INFO))
				{
				  condition.And(TS_INFO._.TP_INFO.Contain(model.TP_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.BAM_INFO))
				{
				  condition.And(TS_INFO._.BAM_INFO.Contain(model.BAM_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_INFO))
				{
				  condition.And(TS_INFO._.BID_INFO.Contain(model.BID_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.PHR_INFO))
				{
				  condition.And(TS_INFO._.PHR_INFO.Contain(model.PHR_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.PAM_INFO))
				{
				  condition.And(TS_INFO._.PAM_INFO.Contain(model.PAM_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.SUP_INFO))
				{
				  condition.And(TS_INFO._.SUP_INFO.Contain(model.SUP_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.TROR_INFO))
				{
				  condition.And(TS_INFO._.TROR_INFO.Contain(model.TROR_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.TREE_INFO))
				{
				  condition.And(TS_INFO._.TREE_INFO.Contain(model.TREE_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.CP_INFO))
				{
				  condition.And(TS_INFO._.CP_INFO.Contain(model.CP_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.LP_TP_INFO))
				{
				  condition.And(TS_INFO._.LP_TP_INFO.Contain(model.LP_TP_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.PRER_BINFO))
				{
				  condition.And(TS_INFO._.PRER_BINFO.Contain(model.PRER_BINFO));
				}
				if(!string.IsNullOrWhiteSpace(model.PRER_QINFO))
				{
				  condition.And(TS_INFO._.PRER_QINFO.Contain(model.PRER_QINFO));
				}
				if(!string.IsNullOrWhiteSpace(model.PRER_PINFO))
				{
				  condition.And(TS_INFO._.PRER_PINFO.Contain(model.PRER_PINFO));
				}
				if(!string.IsNullOrWhiteSpace(model.NP_BINFO))
				{
				  condition.And(TS_INFO._.NP_BINFO.Contain(model.NP_BINFO));
				}
				if(!string.IsNullOrWhiteSpace(model.DE_UNIT))
				{
				  condition.And(TS_INFO._.DE_UNIT.Contain(model.DE_UNIT));
				}
		return condition;
	}
        #endregion
    }
}