using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class YdRoomsetService : BaseServiceT<YD_ROOMSET>
    {
        #region 接口实现
        
		public List<YD_ROOMSET> FindList(YD_ROOMSET model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YD_ROOMSET> PageList(YD_ROOMSET model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, YD_ROOMSET._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(YD_ROOMSET._.ID == ID);
			
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
        public GeneralResult Edit(YD_ROOMSET model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is YD_ROOMSET entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REQUISITION_ID=model.REQUISITION_ID;
		entity.REQ_SUBTM=model.REQ_SUBTM;
		entity.TYPE=model.TYPE;
		entity.IS_START=model.IS_START;
		entity.START_TM=model.START_TM;
		entity.START_BY=model.START_BY;
		entity.TRAD_CENTER=model.TRAD_CENTER;
		entity.SQ_EVA_ROOM=model.SQ_EVA_ROOM;
		entity.RS_BTM=model.RS_BTM;
		entity.RS_ETM=model.RS_ETM;
		entity.ZJ_NUM=model.ZJ_NUM;
		entity.STATUS=model.STATUS;
		entity.REMARK=model.REMARK;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TM=model.CREATE_TM;
		entity.OPER_BY=model.OPER_BY;
		entity.OPER_TM=model.OPER_TM;
		entity.SH_EVA_ROOM=model.SH_EVA_ROOM;
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
        public GeneralResult Add(YD_ROOMSET model)
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
                    Delete(YD_ROOMSET._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YD_ROOMSET> model)
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
       	protected WhereClipBuilder ConditionBuilder(YD_ROOMSET model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(YD_ROOMSET._.ID==(model.ID));
				}
				if(model.REQUISITION_ID!=null)
				{
				  condition.And(YD_ROOMSET._.REQUISITION_ID==(model.REQUISITION_ID));
				}
				if(model.REQ_SUBTM!=null)
				{
				  condition.And(YD_ROOMSET._.REQ_SUBTM==(model.REQ_SUBTM));
				}
				if(model.TYPE!=null)
				{
				  condition.And(YD_ROOMSET._.TYPE==(model.TYPE));
				}
				if(model.IS_START!=null)
				{
				  condition.And(YD_ROOMSET._.IS_START==(model.IS_START));
				}
				if(model.START_TM!=null)
				{
				  condition.And(YD_ROOMSET._.START_TM==(model.START_TM));
				}
				if(model.START_BY!=null)
				{
				  condition.And(YD_ROOMSET._.START_BY==(model.START_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.TRAD_CENTER))
				{
				  condition.And(YD_ROOMSET._.TRAD_CENTER.Contain(model.TRAD_CENTER));
				}
				if(model.SQ_EVA_ROOM!=null)
				{
				  condition.And(YD_ROOMSET._.SQ_EVA_ROOM==(model.SQ_EVA_ROOM));
				}
				if(model.RS_BTM!=null)
				{
				  condition.And(YD_ROOMSET._.RS_BTM==(model.RS_BTM));
				}
				if(model.RS_ETM!=null)
				{
				  condition.And(YD_ROOMSET._.RS_ETM==(model.RS_ETM));
				}
				if(model.ZJ_NUM!=null)
				{
				  condition.And(YD_ROOMSET._.ZJ_NUM==(model.ZJ_NUM));
				}
				if(model.STATUS!=null)
				{
				  condition.And(YD_ROOMSET._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(YD_ROOMSET._.REMARK.Contain(model.REMARK));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(YD_ROOMSET._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(YD_ROOMSET._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.OPER_BY!=null)
				{
				  condition.And(YD_ROOMSET._.OPER_BY==(model.OPER_BY));
				}
				if(model.OPER_TM!=null)
				{
				  condition.And(YD_ROOMSET._.OPER_TM==(model.OPER_TM));
				}
				if(model.SH_EVA_ROOM!=null)
				{
				  condition.And(YD_ROOMSET._.SH_EVA_ROOM==(model.SH_EVA_ROOM));
				}
		return condition;
	}
        #endregion
    }
}