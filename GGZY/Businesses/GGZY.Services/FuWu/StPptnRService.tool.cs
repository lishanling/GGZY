using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StPptnRService : BaseServiceT<ST_PPTN_R>
    {
        #region 接口实现
        
		public List<ST_PPTN_R> FindList(ST_PPTN_R model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ST_PPTN_R> PageList(ST_PPTN_R model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ST_PPTN_R._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="STCD"></param>
      /// <param name="TM"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string STCD,DateTime? TM)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ST_PPTN_R._.STCD == STCD);
			condition.And(ST_PPTN_R._.TM == TM);
			
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
        public GeneralResult Edit(ST_PPTN_R model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.STCD,model.TM);
	
	if(viewResult.Success  && viewResult.Data is ST_PPTN_R entity)
	{		
		entity.Attach();
		entity.STCD=model.STCD;
		entity.TM=model.TM;
		entity.DRP=model.DRP;
		entity.INTV=model.INTV;
		entity.PDR=model.PDR;
		entity.DYP=model.DYP;
		entity.WTH=model.WTH;
		entity.GTM=model.GTM;
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
        public GeneralResult Add(ST_PPTN_R model)
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
                    Delete(ST_PPTN_R._.STCD.SelectIn(idArr));
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
        public GeneralResult Import(List<ST_PPTN_R> model)
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
       	protected WhereClipBuilder ConditionBuilder(ST_PPTN_R model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.STCD))
				{
				  condition.And(ST_PPTN_R._.STCD.Contain(model.STCD));
				}
				if(model.TM!=null)
				{
				  condition.And(ST_PPTN_R._.TM==(model.TM));
				}
				if(model.DRP!=null)
				{
				  condition.And(ST_PPTN_R._.DRP==(model.DRP));
				}
				if(model.INTV!=null)
				{
				  condition.And(ST_PPTN_R._.INTV==(model.INTV));
				}
				if(model.PDR!=null)
				{
				  condition.And(ST_PPTN_R._.PDR==(model.PDR));
				}
				if(model.DYP!=null)
				{
				  condition.And(ST_PPTN_R._.DYP==(model.DYP));
				}
				if(!string.IsNullOrWhiteSpace(model.WTH))
				{
				  condition.And(ST_PPTN_R._.WTH.Contain(model.WTH));
				}
				if(model.GTM!=null)
				{
				  condition.And(ST_PPTN_R._.GTM==(model.GTM));
				}
		return condition;
	}
        #endregion
    }
}