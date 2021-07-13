using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class YdEvaRoomService : BaseServiceT<YD_EVA_ROOM>
    {
        #region 接口实现
        
		public List<YD_EVA_ROOM> FindList(YD_EVA_ROOM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YD_EVA_ROOM> PageList(YD_EVA_ROOM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, YD_EVA_ROOM._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(YD_EVA_ROOM._.ID == ID);
			
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
        public GeneralResult Edit(YD_EVA_ROOM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is YD_EVA_ROOM entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.BELONG_BY=model.BELONG_BY;
		entity.STATUS=model.STATUS;
		entity.SEAT_COUNT=model.SEAT_COUNT;
		entity.ADDRESS=model.ADDRESS;
		entity.IS_DEL=model.IS_DEL;
		entity.DEV_INFO=model.DEV_INFO;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TM=model.CREATE_TM;
		entity.DEL_BY=model.DEL_BY;
		entity.DEL_TM=model.DEL_TM;
		entity.ORDER_BY=model.ORDER_BY;
		entity.FILES=model.FILES;
		entity.VIDEO_ENABLE=model.VIDEO_ENABLE;
		entity.LOGINACCOUNT=model.LOGINACCOUNT;
		entity.SERVERIP=model.SERVERIP;
		entity.SERVERPORT=model.SERVERPORT;
		entity.VPASSWORD=model.VPASSWORD;
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
        public GeneralResult Add(YD_EVA_ROOM model)
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
                    Delete(YD_EVA_ROOM._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YD_EVA_ROOM> model)
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
       	protected WhereClipBuilder ConditionBuilder(YD_EVA_ROOM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(YD_EVA_ROOM._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(YD_EVA_ROOM._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BELONG_BY))
				{
				  condition.And(YD_EVA_ROOM._.BELONG_BY.Contain(model.BELONG_BY));
				}
				if(model.STATUS!=null)
				{
				  condition.And(YD_EVA_ROOM._.STATUS==(model.STATUS));
				}
				if(model.SEAT_COUNT!=null)
				{
				  condition.And(YD_EVA_ROOM._.SEAT_COUNT==(model.SEAT_COUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(YD_EVA_ROOM._.ADDRESS.Contain(model.ADDRESS));
				}
				if(model.IS_DEL!=null)
				{
				  condition.And(YD_EVA_ROOM._.IS_DEL==(model.IS_DEL));
				}
				if(!string.IsNullOrWhiteSpace(model.DEV_INFO))
				{
				  condition.And(YD_EVA_ROOM._.DEV_INFO.Contain(model.DEV_INFO));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(YD_EVA_ROOM._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(YD_EVA_ROOM._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.DEL_BY!=null)
				{
				  condition.And(YD_EVA_ROOM._.DEL_BY==(model.DEL_BY));
				}
				if(model.DEL_TM!=null)
				{
				  condition.And(YD_EVA_ROOM._.DEL_TM==(model.DEL_TM));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(YD_EVA_ROOM._.ORDER_BY==(model.ORDER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(YD_EVA_ROOM._.FILES.Contain(model.FILES));
				}
				if(model.VIDEO_ENABLE!=null)
				{
				  condition.And(YD_EVA_ROOM._.VIDEO_ENABLE==(model.VIDEO_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGINACCOUNT))
				{
				  condition.And(YD_EVA_ROOM._.LOGINACCOUNT.Contain(model.LOGINACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVERIP))
				{
				  condition.And(YD_EVA_ROOM._.SERVERIP.Contain(model.SERVERIP));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVERPORT))
				{
				  condition.And(YD_EVA_ROOM._.SERVERPORT.Contain(model.SERVERPORT));
				}
				if(!string.IsNullOrWhiteSpace(model.VPASSWORD))
				{
				  condition.And(YD_EVA_ROOM._.VPASSWORD.Contain(model.VPASSWORD));
				}
		return condition;
	}
        #endregion
    }
}