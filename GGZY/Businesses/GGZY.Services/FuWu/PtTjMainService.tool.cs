using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtTjMainService : BaseServiceT<PT_TJ_MAIN>
    {
        #region 接口实现
        
		public List<PT_TJ_MAIN> FindList(PT_TJ_MAIN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_TJ_MAIN> PageList(PT_TJ_MAIN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_TJ_MAIN._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TM">年月</param>
      /// <param name="AREACODE">行政级别</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(DateTime? TM,string AREACODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(PT_TJ_MAIN._.TM == TM);
			condition.And(PT_TJ_MAIN._.AREACODE == AREACODE);
			
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
        public GeneralResult Edit(PT_TJ_MAIN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TM,model.AREACODE);
	
	if(viewResult.Success  && viewResult.Data is PT_TJ_MAIN entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TM=model.TM;
		entity.AREACODE=model.AREACODE;
		entity.UPDATE_UID=model.UPDATE_UID;
		entity.DATACOUNT=model.DATACOUNT;
		entity.FILEPATH=model.FILEPATH;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(PT_TJ_MAIN model)
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
                    Delete(PT_TJ_MAIN._.TM.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_TJ_MAIN> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_TJ_MAIN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_TJ_MAIN._.ID==(model.ID));
				}
				if(model.TM!=null)
				{
				  condition.And(PT_TJ_MAIN._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(PT_TJ_MAIN._.AREACODE.Contain(model.AREACODE));
				}
				if(model.UPDATE_UID!=null)
				{
				  condition.And(PT_TJ_MAIN._.UPDATE_UID==(model.UPDATE_UID));
				}
				if(model.DATACOUNT!=null)
				{
				  condition.And(PT_TJ_MAIN._.DATACOUNT==(model.DATACOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.FILEPATH))
				{
				  condition.And(PT_TJ_MAIN._.FILEPATH.Contain(model.FILEPATH));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(PT_TJ_MAIN._.CREATE_TM==(model.CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}