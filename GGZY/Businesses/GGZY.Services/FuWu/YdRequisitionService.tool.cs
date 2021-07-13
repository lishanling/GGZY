using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class YdRequisitionService : BaseServiceT<YD_REQUISITION>
    {
        #region 接口实现
        
		public List<YD_REQUISITION> FindList(YD_REQUISITION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YD_REQUISITION> PageList(YD_REQUISITION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, YD_REQUISITION._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(YD_REQUISITION._.ID == ID);
			
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
        public GeneralResult Edit(YD_REQUISITION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is YD_REQUISITION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CODE=model.CODE;
		entity.NAME=model.NAME;
		entity.IS_DEL=model.IS_DEL;
		entity.STATUS=model.STATUS;
		entity.IS_DONE=model.IS_DONE;
		entity.FILES=model.FILES;
		entity.DONE_TM=model.DONE_TM;
		entity.DONE_BY=model.DONE_BY;
		entity.TP_ID=model.TP_ID;
		entity.SQ_BTM=model.SQ_BTM;
		entity.SQ_ETM=model.SQ_ETM;
		entity.MAIN_MEETING=model.MAIN_MEETING;
		entity.OTHER_MEETING=model.OTHER_MEETING;
		entity.REMARK=model.REMARK;
		entity.SUBMIT_TM=model.SUBMIT_TM;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TM=model.CREATE_TM;
		entity.DEL_BY=model.DEL_BY;
		entity.DEL_TM=model.DEL_TM;
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
        public GeneralResult Add(YD_REQUISITION model)
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
                    Delete(YD_REQUISITION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YD_REQUISITION> model)
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
       	protected WhereClipBuilder ConditionBuilder(YD_REQUISITION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(YD_REQUISITION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(YD_REQUISITION._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(YD_REQUISITION._.NAME.Contain(model.NAME));
				}
				if(model.IS_DEL!=null)
				{
				  condition.And(YD_REQUISITION._.IS_DEL==(model.IS_DEL));
				}
				if(model.STATUS!=null)
				{
				  condition.And(YD_REQUISITION._.STATUS==(model.STATUS));
				}
				if(model.IS_DONE!=null)
				{
				  condition.And(YD_REQUISITION._.IS_DONE==(model.IS_DONE));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(YD_REQUISITION._.FILES.Contain(model.FILES));
				}
				if(model.DONE_TM!=null)
				{
				  condition.And(YD_REQUISITION._.DONE_TM==(model.DONE_TM));
				}
				if(model.DONE_BY!=null)
				{
				  condition.And(YD_REQUISITION._.DONE_BY==(model.DONE_BY));
				}
				if(model.TP_ID!=null)
				{
				  condition.And(YD_REQUISITION._.TP_ID==(model.TP_ID));
				}
				if(model.SQ_BTM!=null)
				{
				  condition.And(YD_REQUISITION._.SQ_BTM==(model.SQ_BTM));
				}
				if(model.SQ_ETM!=null)
				{
				  condition.And(YD_REQUISITION._.SQ_ETM==(model.SQ_ETM));
				}
				if(!string.IsNullOrWhiteSpace(model.MAIN_MEETING))
				{
				  condition.And(YD_REQUISITION._.MAIN_MEETING.Contain(model.MAIN_MEETING));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_MEETING))
				{
				  condition.And(YD_REQUISITION._.OTHER_MEETING.Contain(model.OTHER_MEETING));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(YD_REQUISITION._.REMARK.Contain(model.REMARK));
				}
				if(model.SUBMIT_TM!=null)
				{
				  condition.And(YD_REQUISITION._.SUBMIT_TM==(model.SUBMIT_TM));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(YD_REQUISITION._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(YD_REQUISITION._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.DEL_BY!=null)
				{
				  condition.And(YD_REQUISITION._.DEL_BY==(model.DEL_BY));
				}
				if(model.DEL_TM!=null)
				{
				  condition.And(YD_REQUISITION._.DEL_TM==(model.DEL_TM));
				}
		return condition;
	}
        #endregion
    }
}