using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderFlowMarkService : BaseServiceT<TENDER_FLOW_MARK>
    {
        #region 接口实现
        
		public List<TENDER_FLOW_MARK> FindList(TENDER_FLOW_MARK model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_FLOW_MARK> PageList(TENDER_FLOW_MARK model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_FLOW_MARK._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(TENDER_FLOW_MARK._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TENDER_FLOW_MARK model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_FLOW_MARK entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PUBLICITY_NAME=model.PUBLICITY_NAME;
		entity.PUBLICITY_CONTENT=model.PUBLICITY_CONTENT;
		entity.PUBLICITY_REFER_TIME=model.PUBLICITY_REFER_TIME;
		entity.NOTICE_MEDIA=model.NOTICE_MEDIA;
		entity.URL=model.URL;
		entity.PUBLICITY_TYPE=model.PUBLICITY_TYPE;
		entity.PUBLICITY_START_TIME=model.PUBLICITY_START_TIME;
		entity.PUBLICITY_END_TIME=model.PUBLICITY_END_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_ATT_PUBLICITY_DOC=model.M_ATT_PUBLICITY_DOC;
		entity.M_STATUS=model.M_STATUS;
		entity.M_REMARK=model.M_REMARK;
		entity.M_ZPID=model.M_ZPID;
		entity.M_TYPE=model.M_TYPE;
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
        public GeneralResult Add(TENDER_FLOW_MARK model)
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
                    Delete(TENDER_FLOW_MARK._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_FLOW_MARK> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_FLOW_MARK model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(TENDER_FLOW_MARK._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(TENDER_FLOW_MARK._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(TENDER_FLOW_MARK._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITY_NAME))
				{
				  condition.And(TENDER_FLOW_MARK._.PUBLICITY_NAME.Contain(model.PUBLICITY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITY_CONTENT))
				{
				  condition.And(TENDER_FLOW_MARK._.PUBLICITY_CONTENT.Contain(model.PUBLICITY_CONTENT));
				}
				if(model.PUBLICITY_REFER_TIME!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.PUBLICITY_REFER_TIME==(model.PUBLICITY_REFER_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA))
				{
				  condition.And(TENDER_FLOW_MARK._.NOTICE_MEDIA.Contain(model.NOTICE_MEDIA));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(TENDER_FLOW_MARK._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITY_TYPE))
				{
				  condition.And(TENDER_FLOW_MARK._.PUBLICITY_TYPE.Contain(model.PUBLICITY_TYPE));
				}
				if(model.PUBLICITY_START_TIME!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.PUBLICITY_START_TIME==(model.PUBLICITY_START_TIME));
				}
				if(model.PUBLICITY_END_TIME!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.PUBLICITY_END_TIME==(model.PUBLICITY_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_FLOW_MARK._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_FLOW_MARK._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_FLOW_MARK._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_FLOW_MARK._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.M_CREATOR==(model.M_CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC))
				{
				  condition.And(TENDER_FLOW_MARK._.M_ATT_PUBLICITY_DOC.Contain(model.M_ATT_PUBLICITY_DOC));
				}
				if(model.M_STATUS!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.M_STATUS==(model.M_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_REMARK))
				{
				  condition.And(TENDER_FLOW_MARK._.M_REMARK.Contain(model.M_REMARK));
				}
				if(model.M_ZPID!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.M_ZPID==(model.M_ZPID));
				}
				if(model.M_TYPE!=null)
				{
				  condition.And(TENDER_FLOW_MARK._.M_TYPE==(model.M_TYPE));
				}
		return condition;
	}
        #endregion
    }
}