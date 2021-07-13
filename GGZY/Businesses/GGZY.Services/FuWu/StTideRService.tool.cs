using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StTideRService : BaseServiceT<ST_TIDE_R>
    {
        #region 接口实现
        
		public List<ST_TIDE_R> FindList(ST_TIDE_R model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ST_TIDE_R> PageList(ST_TIDE_R model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ST_TIDE_R._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ST_TIDE_R._.STCD == STCD);
			condition.And(ST_TIDE_R._.TM == TM);
			
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
        public GeneralResult Edit(ST_TIDE_R model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.STCD,model.TM);
	
	if(viewResult.Success  && viewResult.Data is ST_TIDE_R entity)
	{		
		entity.Attach();
		entity.STCD=model.STCD;
		entity.TM=model.TM;
		entity.TDZ=model.TDZ;
		entity.AIRP=model.AIRP;
		entity.TDCHRCD=model.TDCHRCD;
		entity.TDPTN=model.TDPTN;
		entity.HLTDMK=model.HLTDMK;
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
        public GeneralResult Add(ST_TIDE_R model)
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
                    Delete(ST_TIDE_R._.STCD.SelectIn(idArr));
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
        public GeneralResult Import(List<ST_TIDE_R> model)
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
       	protected WhereClipBuilder ConditionBuilder(ST_TIDE_R model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.STCD))
				{
				  condition.And(ST_TIDE_R._.STCD.Contain(model.STCD));
				}
				if(model.TM!=null)
				{
				  condition.And(ST_TIDE_R._.TM==(model.TM));
				}
				if(model.TDZ!=null)
				{
				  condition.And(ST_TIDE_R._.TDZ==(model.TDZ));
				}
				if(model.AIRP!=null)
				{
				  condition.And(ST_TIDE_R._.AIRP==(model.AIRP));
				}
				if(!string.IsNullOrWhiteSpace(model.TDCHRCD))
				{
				  condition.And(ST_TIDE_R._.TDCHRCD.Contain(model.TDCHRCD));
				}
				if(!string.IsNullOrWhiteSpace(model.TDPTN))
				{
				  condition.And(ST_TIDE_R._.TDPTN.Contain(model.TDPTN));
				}
				if(!string.IsNullOrWhiteSpace(model.HLTDMK))
				{
				  condition.And(ST_TIDE_R._.HLTDMK.Contain(model.HLTDMK));
				}
		return condition;
	}
        #endregion
    }
}