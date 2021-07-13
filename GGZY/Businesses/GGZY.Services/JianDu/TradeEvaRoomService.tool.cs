using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TradeEvaRoomService : BaseServiceT<TRADE_EVA_ROOM>
    {
        #region 接口实现
        
		public List<TRADE_EVA_ROOM> FindList(TRADE_EVA_ROOM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TRADE_EVA_ROOM> PageList(TRADE_EVA_ROOM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TRADE_EVA_ROOM._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TRADE_EVA_ROOM._.ID == ID);
			
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
        public GeneralResult Edit(TRADE_EVA_ROOM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TRADE_EVA_ROOM entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.CODE=model.CODE;
		entity.ADDRESS=model.ADDRESS;
		entity.DEV_INFO=model.DEV_INFO;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(TRADE_EVA_ROOM model)
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
                    Delete(TRADE_EVA_ROOM._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TRADE_EVA_ROOM> model)
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
       	protected WhereClipBuilder ConditionBuilder(TRADE_EVA_ROOM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TRADE_EVA_ROOM._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(TRADE_EVA_ROOM._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(TRADE_EVA_ROOM._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(TRADE_EVA_ROOM._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.DEV_INFO))
				{
				  condition.And(TRADE_EVA_ROOM._.DEV_INFO.Contain(model.DEV_INFO));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(TRADE_EVA_ROOM._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(TRADE_EVA_ROOM._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(TRADE_EVA_ROOM._.ORDER_BY==(model.ORDER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(TRADE_EVA_ROOM._.FILES.Contain(model.FILES));
				}
				if(model.VIDEO_ENABLE!=null)
				{
				  condition.And(TRADE_EVA_ROOM._.VIDEO_ENABLE==(model.VIDEO_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGINACCOUNT))
				{
				  condition.And(TRADE_EVA_ROOM._.LOGINACCOUNT.Contain(model.LOGINACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVERIP))
				{
				  condition.And(TRADE_EVA_ROOM._.SERVERIP.Contain(model.SERVERIP));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVERPORT))
				{
				  condition.And(TRADE_EVA_ROOM._.SERVERPORT.Contain(model.SERVERPORT));
				}
				if(!string.IsNullOrWhiteSpace(model.VPASSWORD))
				{
				  condition.And(TRADE_EVA_ROOM._.VPASSWORD.Contain(model.VPASSWORD));
				}
		return condition;
	}
        #endregion
    }
}