using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TpewInfoService : BaseServiceT<TPEW_INFO>
    {
        #region 接口实现
        
		public List<TPEW_INFO> FindList(TPEW_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TPEW_INFO> PageList(TPEW_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TPEW_INFO._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TPEW_INFO._.ID == ID);
			
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
        public GeneralResult Edit(TPEW_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TPEW_INFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.EW_NUMBER=model.EW_NUMBER;
		entity.TP_NUMBER=model.TP_NUMBER;
		entity.STATUS=model.STATUS;
		entity.SUPV_POINT_ID=model.SUPV_POINT_ID;
		entity.RECEIVER=model.RECEIVER;
		entity.EW_CONTENT=model.EW_CONTENT;
		entity.APV_PEOPLE=model.APV_PEOPLE;
		entity.APV_TIME=model.APV_TIME;
		entity.CREATE_PEOPLE=model.CREATE_PEOPLE;
		entity.CREATE_TIME=model.CREATE_TIME;
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
        public GeneralResult Add(TPEW_INFO model)
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
                    Delete(TPEW_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TPEW_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(TPEW_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TPEW_INFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.EW_NUMBER))
				{
				  condition.And(TPEW_INFO._.EW_NUMBER.Contain(model.EW_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.TP_NUMBER))
				{
				  condition.And(TPEW_INFO._.TP_NUMBER.Contain(model.TP_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.STATUS))
				{
				  condition.And(TPEW_INFO._.STATUS.Contain(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPV_POINT_ID))
				{
				  condition.And(TPEW_INFO._.SUPV_POINT_ID.Contain(model.SUPV_POINT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.RECEIVER))
				{
				  condition.And(TPEW_INFO._.RECEIVER.Contain(model.RECEIVER));
				}
				if(!string.IsNullOrWhiteSpace(model.EW_CONTENT))
				{
				  condition.And(TPEW_INFO._.EW_CONTENT.Contain(model.EW_CONTENT));
				}
				if(model.APV_PEOPLE!=null)
				{
				  condition.And(TPEW_INFO._.APV_PEOPLE==(model.APV_PEOPLE));
				}
				if(model.APV_TIME!=null)
				{
				  condition.And(TPEW_INFO._.APV_TIME==(model.APV_TIME));
				}
				if(model.CREATE_PEOPLE!=null)
				{
				  condition.And(TPEW_INFO._.CREATE_PEOPLE==(model.CREATE_PEOPLE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(TPEW_INFO._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}