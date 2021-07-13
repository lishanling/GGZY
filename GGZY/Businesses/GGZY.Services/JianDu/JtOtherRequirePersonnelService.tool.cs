using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtOtherRequirePersonnelService : BaseServiceT<JT_OTHER_REQUIRE_PERSONNEL>
    {
        #region 接口实现
        
		public List<JT_OTHER_REQUIRE_PERSONNEL> FindList(JT_OTHER_REQUIRE_PERSONNEL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_OTHER_REQUIRE_PERSONNEL> PageList(JT_OTHER_REQUIRE_PERSONNEL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_OTHER_REQUIRE_PERSONNEL._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_OTHER_REQUIRE_PERSONNEL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_OTHER_REQUIRE_PERSONNEL entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.PERSONNEL=model.PERSONNEL;
		entity.PERSON_NAME=model.PERSON_NAME;
		entity.NUMBERS=model.NUMBERS;
		entity.TITLE=model.TITLE;
		entity.PERSONNEL_REQUIRE=model.PERSONNEL_REQUIRE;
		entity.REMARK=model.REMARK;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(JT_OTHER_REQUIRE_PERSONNEL model)
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
                    Delete(JT_OTHER_REQUIRE_PERSONNEL._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_OTHER_REQUIRE_PERSONNEL> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_OTHER_REQUIRE_PERSONNEL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSONNEL))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.PERSONNEL.Contain(model.PERSONNEL));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSON_NAME))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.PERSON_NAME.Contain(model.PERSON_NAME));
				}
				if(model.NUMBERS!=null)
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.NUMBERS==(model.NUMBERS));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSONNEL_REQUIRE))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.PERSONNEL_REQUIRE.Contain(model.PERSONNEL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_TM==(model.M_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_OTHER_REQUIRE_PERSONNEL._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}