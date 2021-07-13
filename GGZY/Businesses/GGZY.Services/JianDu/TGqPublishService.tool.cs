using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TGqPublishService : BaseServiceT<T_GQ_PUBLISH>
    {
        #region 接口实现
        
		public List<T_GQ_PUBLISH> FindList(T_GQ_PUBLISH model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_GQ_PUBLISH> PageList(T_GQ_PUBLISH model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_GQ_PUBLISH._.PROJECT_NO.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="PROJECT_NO">项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string PROJECT_NO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_GQ_PUBLISH._.PROJECT_NO == PROJECT_NO);
			
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
        public GeneralResult Edit(T_GQ_PUBLISH model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.PROJECT_NO);
	
	if(viewResult.Success  && viewResult.Data is T_GQ_PUBLISH entity)
	{		
		entity.Attach();
		entity.PROJECT_NO=model.PROJECT_NO;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_PRICE=model.PROJECT_PRICE;
		entity.PAY_MODE=model.PAY_MODE;
		entity.PAY_MODE_PART=model.PAY_MODE_PART;
		entity.PUBLISH_DAYSN3=model.PUBLISH_DAYSN3;
		entity.PUBLISH_START_TIME=model.PUBLISH_START_TIME;
		entity.PUBLISH_END_TIME=model.PUBLISH_END_TIME;
		entity.PUBLISH_DELAY_FLAG=model.PUBLISH_DELAY_FLAG;
		entity.DELAY_MAX=model.DELAY_MAX;
		entity.DELAY_PEROID=model.DELAY_PEROID;
		entity.PUBLISH_DESC=model.PUBLISH_DESC;
		entity.PUBLISH_DEAL_WAY=model.PUBLISH_DEAL_WAY;
		entity.BAIL_TYPE=model.BAIL_TYPE;
		entity.BAIL=model.BAIL;
		entity.BAIL_PAYMETHOD=model.BAIL_PAYMETHOD;
		entity.BAIL_DEAD_TIME=model.BAIL_DEAD_TIME;
		entity.BAIL_BANK_NO=model.BAIL_BANK_NO;
		entity.HAS_PRIORITY=model.HAS_PRIORITY;
		entity.UNIT_TRANSFER=model.UNIT_TRANSFER;
		entity.BUY_CONDITIONS=model.BUY_CONDITIONS;
		entity.SUBMIT_FILES=model.SUBMIT_FILES;
		entity.BAIL_CONTENT=model.BAIL_CONTENT;
		entity.BAIL_CONTENT_DEAL=model.BAIL_CONTENT_DEAL;
		entity.IMPORTANT=model.IMPORTANT;
		entity.SELL_CONDITIONS=model.SELL_CONDITIONS;
		entity.M_INDUSTRIESTYPE=model.M_INDUSTRIESTYPE;
		entity.M_NOTICECONTENT=model.M_NOTICECONTENT;
		entity.M_BULLETINTYPE=model.M_BULLETINTYPE;
		entity.M_NOTICENATURE=model.M_NOTICENATURE;
		entity.M_NOTICESENDTIME=model.M_NOTICESENDTIME;
		entity.M_AREACODE=model.M_AREACODE;
		entity.M_ANNOUNCEMENT_TITLE=model.M_ANNOUNCEMENT_TITLE;
		entity.CONTROLPRICE=model.CONTROLPRICE;
		entity.DATASOURCENAME=model.DATASOURCENAME;
		entity.DATASOURCECODE=model.DATASOURCECODE;
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
        public GeneralResult Add(T_GQ_PUBLISH model)
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
                    Delete(T_GQ_PUBLISH._.PROJECT_NO.SelectIn(idArr));
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
        public GeneralResult Import(List<T_GQ_PUBLISH> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_GQ_PUBLISH model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NO))
				{
				  condition.And(T_GQ_PUBLISH._.PROJECT_NO.Contain(model.PROJECT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(T_GQ_PUBLISH._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_PRICE))
				{
				  condition.And(T_GQ_PUBLISH._.PROJECT_PRICE.Contain(model.PROJECT_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAY_MODE))
				{
				  condition.And(T_GQ_PUBLISH._.PAY_MODE.Contain(model.PAY_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAY_MODE_PART))
				{
				  condition.And(T_GQ_PUBLISH._.PAY_MODE_PART.Contain(model.PAY_MODE_PART));
				}
				if(model.PUBLISH_DAYSN3!=null)
				{
				  condition.And(T_GQ_PUBLISH._.PUBLISH_DAYSN3==(model.PUBLISH_DAYSN3));
				}
				if(model.PUBLISH_START_TIME!=null)
				{
				  condition.And(T_GQ_PUBLISH._.PUBLISH_START_TIME==(model.PUBLISH_START_TIME));
				}
				if(model.PUBLISH_END_TIME!=null)
				{
				  condition.And(T_GQ_PUBLISH._.PUBLISH_END_TIME==(model.PUBLISH_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLISH_DELAY_FLAG))
				{
				  condition.And(T_GQ_PUBLISH._.PUBLISH_DELAY_FLAG.Contain(model.PUBLISH_DELAY_FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.DELAY_MAX))
				{
				  condition.And(T_GQ_PUBLISH._.DELAY_MAX.Contain(model.DELAY_MAX));
				}
				if(model.DELAY_PEROID!=null)
				{
				  condition.And(T_GQ_PUBLISH._.DELAY_PEROID==(model.DELAY_PEROID));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLISH_DESC))
				{
				  condition.And(T_GQ_PUBLISH._.PUBLISH_DESC.Contain(model.PUBLISH_DESC));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLISH_DEAL_WAY))
				{
				  condition.And(T_GQ_PUBLISH._.PUBLISH_DEAL_WAY.Contain(model.PUBLISH_DEAL_WAY));
				}
				if(!string.IsNullOrWhiteSpace(model.BAIL_TYPE))
				{
				  condition.And(T_GQ_PUBLISH._.BAIL_TYPE.Contain(model.BAIL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BAIL))
				{
				  condition.And(T_GQ_PUBLISH._.BAIL.Contain(model.BAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.BAIL_PAYMETHOD))
				{
				  condition.And(T_GQ_PUBLISH._.BAIL_PAYMETHOD.Contain(model.BAIL_PAYMETHOD));
				}
				if(model.BAIL_DEAD_TIME!=null)
				{
				  condition.And(T_GQ_PUBLISH._.BAIL_DEAD_TIME==(model.BAIL_DEAD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BAIL_BANK_NO))
				{
				  condition.And(T_GQ_PUBLISH._.BAIL_BANK_NO.Contain(model.BAIL_BANK_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.HAS_PRIORITY))
				{
				  condition.And(T_GQ_PUBLISH._.HAS_PRIORITY.Contain(model.HAS_PRIORITY));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_TRANSFER))
				{
				  condition.And(T_GQ_PUBLISH._.UNIT_TRANSFER.Contain(model.UNIT_TRANSFER));
				}
				if(!string.IsNullOrWhiteSpace(model.BUY_CONDITIONS))
				{
				  condition.And(T_GQ_PUBLISH._.BUY_CONDITIONS.Contain(model.BUY_CONDITIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBMIT_FILES))
				{
				  condition.And(T_GQ_PUBLISH._.SUBMIT_FILES.Contain(model.SUBMIT_FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.BAIL_CONTENT))
				{
				  condition.And(T_GQ_PUBLISH._.BAIL_CONTENT.Contain(model.BAIL_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BAIL_CONTENT_DEAL))
				{
				  condition.And(T_GQ_PUBLISH._.BAIL_CONTENT_DEAL.Contain(model.BAIL_CONTENT_DEAL));
				}
				if(!string.IsNullOrWhiteSpace(model.IMPORTANT))
				{
				  condition.And(T_GQ_PUBLISH._.IMPORTANT.Contain(model.IMPORTANT));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_CONDITIONS))
				{
				  condition.And(T_GQ_PUBLISH._.SELL_CONDITIONS.Contain(model.SELL_CONDITIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_INDUSTRIESTYPE))
				{
				  condition.And(T_GQ_PUBLISH._.M_INDUSTRIESTYPE.Contain(model.M_INDUSTRIESTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_NOTICECONTENT))
				{
				  condition.And(T_GQ_PUBLISH._.M_NOTICECONTENT.Contain(model.M_NOTICECONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_BULLETINTYPE))
				{
				  condition.And(T_GQ_PUBLISH._.M_BULLETINTYPE.Contain(model.M_BULLETINTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_NOTICENATURE))
				{
				  condition.And(T_GQ_PUBLISH._.M_NOTICENATURE.Contain(model.M_NOTICENATURE));
				}
				if(model.M_NOTICESENDTIME!=null)
				{
				  condition.And(T_GQ_PUBLISH._.M_NOTICESENDTIME==(model.M_NOTICESENDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.M_AREACODE))
				{
				  condition.And(T_GQ_PUBLISH._.M_AREACODE.Contain(model.M_AREACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ANNOUNCEMENT_TITLE))
				{
				  condition.And(T_GQ_PUBLISH._.M_ANNOUNCEMENT_TITLE.Contain(model.M_ANNOUNCEMENT_TITLE));
				}
				if(model.CONTROLPRICE!=null)
				{
				  condition.And(T_GQ_PUBLISH._.CONTROLPRICE==(model.CONTROLPRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCENAME))
				{
				  condition.And(T_GQ_PUBLISH._.DATASOURCENAME.Contain(model.DATASOURCENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_GQ_PUBLISH._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
		return condition;
	}
        #endregion
    }
}