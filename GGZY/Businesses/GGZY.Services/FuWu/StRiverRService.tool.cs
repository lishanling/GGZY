using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StRiverRService : BaseServiceT<ST_RIVER_R>
    {
        #region 接口实现
        
		public List<ST_RIVER_R> FindList(ST_RIVER_R model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ST_RIVER_R> PageList(ST_RIVER_R model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ST_RIVER_R._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ST_RIVER_R._.STCD == STCD);
			condition.And(ST_RIVER_R._.TM == TM);
			
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
        public GeneralResult Edit(ST_RIVER_R model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.STCD,model.TM);
	
	if(viewResult.Success  && viewResult.Data is ST_RIVER_R entity)
	{		
		entity.Attach();
		entity.STCD=model.STCD;
		entity.TM=model.TM;
		entity.Z=model.Z;
		entity.Q=model.Q;
		entity.XSA=model.XSA;
		entity.XSAVV=model.XSAVV;
		entity.XSMXV=model.XSMXV;
		entity.FLWCHRCD=model.FLWCHRCD;
		entity.WPTN=model.WPTN;
		entity.MSQMT=model.MSQMT;
		entity.MSAMT=model.MSAMT;
		entity.MSVMT=model.MSVMT;
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
        public GeneralResult Add(ST_RIVER_R model)
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
                    Delete(ST_RIVER_R._.STCD.SelectIn(idArr));
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
        public GeneralResult Import(List<ST_RIVER_R> model)
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
       	protected WhereClipBuilder ConditionBuilder(ST_RIVER_R model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.STCD))
				{
				  condition.And(ST_RIVER_R._.STCD.Contain(model.STCD));
				}
				if(model.TM!=null)
				{
				  condition.And(ST_RIVER_R._.TM==(model.TM));
				}
				if(model.Z!=null)
				{
				  condition.And(ST_RIVER_R._.Z==(model.Z));
				}
				if(model.Q!=null)
				{
				  condition.And(ST_RIVER_R._.Q==(model.Q));
				}
				if(model.XSA!=null)
				{
				  condition.And(ST_RIVER_R._.XSA==(model.XSA));
				}
				if(model.XSAVV!=null)
				{
				  condition.And(ST_RIVER_R._.XSAVV==(model.XSAVV));
				}
				if(model.XSMXV!=null)
				{
				  condition.And(ST_RIVER_R._.XSMXV==(model.XSMXV));
				}
				if(!string.IsNullOrWhiteSpace(model.FLWCHRCD))
				{
				  condition.And(ST_RIVER_R._.FLWCHRCD.Contain(model.FLWCHRCD));
				}
				if(!string.IsNullOrWhiteSpace(model.WPTN))
				{
				  condition.And(ST_RIVER_R._.WPTN.Contain(model.WPTN));
				}
				if(!string.IsNullOrWhiteSpace(model.MSQMT))
				{
				  condition.And(ST_RIVER_R._.MSQMT.Contain(model.MSQMT));
				}
				if(!string.IsNullOrWhiteSpace(model.MSAMT))
				{
				  condition.And(ST_RIVER_R._.MSAMT.Contain(model.MSAMT));
				}
				if(!string.IsNullOrWhiteSpace(model.MSVMT))
				{
				  condition.And(ST_RIVER_R._.MSVMT.Contain(model.MSVMT));
				}
		return condition;
	}
        #endregion
    }
}