using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtTjBgService : BaseServiceT<PT_TJ_BG>
    {
        #region 接口实现
        
		public List<PT_TJ_BG> FindList(PT_TJ_BG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_TJ_BG> PageList(PT_TJ_BG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_TJ_BG._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TM">年月</param>
      /// <param name="QUARTER">季度</param>
      /// <param name="AREACODE">所属地区</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(DateTime? TM,decimal? QUARTER,string AREACODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(PT_TJ_BG._.TM == TM);
			condition.And(PT_TJ_BG._.QUARTER == QUARTER);
			condition.And(PT_TJ_BG._.AREACODE == AREACODE);
			
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
        public GeneralResult Edit(PT_TJ_BG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TM,model.QUARTER,model.AREACODE);
	
	if(viewResult.Success  && viewResult.Data is PT_TJ_BG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TM=model.TM;
		entity.QUARTER=model.QUARTER;
		entity.UPDATE_UID=model.UPDATE_UID;
		entity.AREACODE=model.AREACODE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.AID=model.AID;
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
        public GeneralResult Add(PT_TJ_BG model)
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
                    Delete(PT_TJ_BG._.TM.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_TJ_BG> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_TJ_BG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_TJ_BG._.ID==(model.ID));
				}
				if(model.TM!=null)
				{
				  condition.And(PT_TJ_BG._.TM==(model.TM));
				}
				if(model.QUARTER!=null)
				{
				  condition.And(PT_TJ_BG._.QUARTER==(model.QUARTER));
				}
				if(model.UPDATE_UID!=null)
				{
				  condition.And(PT_TJ_BG._.UPDATE_UID==(model.UPDATE_UID));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(PT_TJ_BG._.AREACODE.Contain(model.AREACODE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(PT_TJ_BG._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.AID))
				{
				  condition.And(PT_TJ_BG._.AID.Contain(model.AID));
				}
		return condition;
	}
        #endregion
    }
}