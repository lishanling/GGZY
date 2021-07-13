using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlWinResultAnnoService : BaseServiceT<SL_WIN_RESULT_ANNO>
    {
        #region 接口实现
        
		public List<SL_WIN_RESULT_ANNO> FindList(SL_WIN_RESULT_ANNO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_WIN_RESULT_ANNO> PageList(SL_WIN_RESULT_ANNO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_WIN_RESULT_ANNO._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">数据自增长ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SL_WIN_RESULT_ANNO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_WIN_RESULT_ANNO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_WIN_RESULT_ANNO entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.NOTICE_NAME=model.NOTICE_NAME;
		entity.NOTICE_CONTENT=model.NOTICE_CONTENT;
		entity.NOTICE_SEND_TIME=model.NOTICE_SEND_TIME;
		entity.NOTICE_MEDIA=model.NOTICE_MEDIA;
		entity.URL=model.URL;
		entity.NOTICE_NATURE=model.NOTICE_NATURE;
		entity.BULLETIN_TYPE=model.BULLETIN_TYPE;
		entity.WIN_BIDDER_NAME=model.WIN_BIDDER_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.WIN_BIDDER_CODE=model.WIN_BIDDER_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.BID_CURRENCY=model.BID_CURRENCY;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.UNION_CODE=model.UNION_CODE;
		entity.UNION_NAME=model.UNION_NAME;
		entity.RATE=model.RATE;
		entity.OTHER_WIN_PRICE=model.OTHER_WIN_PRICE;
		entity.OTHER_CONTENT=model.OTHER_CONTENT;
		entity.BULLETIN_DUTY=model.BULLETIN_DUTY;
		entity.EXAMINER_NAME=model.EXAMINER_NAME;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.OTHER_BID_PRICE=model.OTHER_BID_PRICE;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
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
        public GeneralResult Add(SL_WIN_RESULT_ANNO model)
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
                    Delete(SL_WIN_RESULT_ANNO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_WIN_RESULT_ANNO> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_WIN_RESULT_ANNO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_CONTENT))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.NOTICE_CONTENT.Contain(model.NOTICE_CONTENT));
				}
				if(model.NOTICE_SEND_TIME!=null)
				{
				  condition.And(SL_WIN_RESULT_ANNO._.NOTICE_SEND_TIME==(model.NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.NOTICE_MEDIA.Contain(model.NOTICE_MEDIA));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NATURE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.NOTICE_NATURE.Contain(model.NOTICE_NATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_TYPE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BULLETIN_TYPE.Contain(model.BULLETIN_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_NAME))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.WIN_BIDDER_NAME.Contain(model.WIN_BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.WIN_BIDDER_CODE.Contain(model.WIN_BIDDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(model.BID_AMOUNT!=null)
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BID_AMOUNT==(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CURRENCY))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BID_CURRENCY.Contain(model.BID_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_WIN_RESULT_ANNO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_WIN_RESULT_ANNO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_WIN_RESULT_ANNO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_WIN_RESULT_ANNO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.UNION_CODE.Contain(model.UNION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_NAME))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.UNION_NAME.Contain(model.UNION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.RATE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.RATE.Contain(model.RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_WIN_PRICE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.OTHER_WIN_PRICE.Contain(model.OTHER_WIN_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONTENT))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.OTHER_CONTENT.Contain(model.OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_DUTY))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.BULLETIN_DUTY.Contain(model.BULLETIN_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINER_NAME))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.EXAMINER_NAME.Contain(model.EXAMINER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_BID_PRICE))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.OTHER_BID_PRICE.Contain(model.OTHER_BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_WIN_RESULT_ANNO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}