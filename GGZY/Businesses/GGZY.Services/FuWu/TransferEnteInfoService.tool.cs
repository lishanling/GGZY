using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TransferEnteInfoService : BaseServiceT<TRANSFER_ENTE_INFO>
    {
        #region 接口实现
        
		public List<TRANSFER_ENTE_INFO> FindList(TRANSFER_ENTE_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TRANSFER_ENTE_INFO> PageList(TRANSFER_ENTE_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TRANSFER_ENTE_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TRANSFER_ENTE_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TRANSFER_ENTE_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TRANSFER_ENTE_INFO entity)
	{		
		entity.Attach();
		entity.SUBJECT_COMPANY_NAME=model.SUBJECT_COMPANY_NAME;
		entity.SELL_PERCENT=model.SELL_PERCENT;
		entity.SUBJECT_COMPANY_CODE=model.SUBJECT_COMPANY_CODE;
		entity.ZONE=model.ZONE;
		entity.INDUSTRY_CODE=model.INDUSTRY_CODE;
		entity.ECONOMY_TYPE=model.ECONOMY_TYPE;
		entity.EMPLOYEE_QUANTITY=model.EMPLOYEE_QUANTITY;
		entity.HAS_CONTAIN_GROUND=model.HAS_CONTAIN_GROUND;
		entity.LAST_AUDIT_YEAR=model.LAST_AUDIT_YEAR;
		entity.LAST_AUDIT_UNIT=model.LAST_AUDIT_UNIT;
		entity.LAST_AUDIT_ASSET=model.LAST_AUDIT_ASSET;
		entity.LAST_AUDIT_DEBT=model.LAST_AUDIT_DEBT;
		entity.LAST_AUDIT_EQUITY=model.LAST_AUDIT_EQUITY;
		entity.LAST_AUDIT_EARNING=model.LAST_AUDIT_EARNING;
		entity.LAST_AUDIT_PROFIT=model.LAST_AUDIT_PROFIT;
		entity.LAST_AUDIT_NETPROFIT=model.LAST_AUDIT_NETPROFIT;
		entity.FINANCE_REPORT_DATE=model.FINANCE_REPORT_DATE;
		entity.FINANCE_REPORT_TYPE=model.FINANCE_REPORT_TYPE;
		entity.TOTAL_CAPITAL=model.TOTAL_CAPITAL;
		entity.TOTAL_DEBT=model.TOTAL_DEBT;
		entity.OWENERSHIP_INTEREST=model.OWENERSHIP_INTEREST;
		entity.BUSINESS_INCOME=model.BUSINESS_INCOME;
		entity.BUSINESS_PROFIT=model.BUSINESS_PROFIT;
		entity.NET_PROFIT=model.NET_PROFIT;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.M_ID=model.M_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_PRE_ID=model.M_PRE_ID;
		entity.BID_CODE=model.BID_CODE;
		entity.CLASS_VER_CODE=model.CLASS_VER_CODE;
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
        public GeneralResult Add(TRANSFER_ENTE_INFO model)
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
                    Delete(TRANSFER_ENTE_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TRANSFER_ENTE_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(TRANSFER_ENTE_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.SUBJECT_COMPANY_NAME))
				{
				  condition.And(TRANSFER_ENTE_INFO._.SUBJECT_COMPANY_NAME.Contain(model.SUBJECT_COMPANY_NAME));
				}
				if(model.SELL_PERCENT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.SELL_PERCENT==(model.SELL_PERCENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBJECT_COMPANY_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.SUBJECT_COMPANY_CODE.Contain(model.SUBJECT_COMPANY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZONE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.ZONE.Contain(model.ZONE));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRY_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.INDUSTRY_CODE.Contain(model.INDUSTRY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ECONOMY_TYPE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.ECONOMY_TYPE.Contain(model.ECONOMY_TYPE));
				}
				if(model.EMPLOYEE_QUANTITY!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.EMPLOYEE_QUANTITY==(model.EMPLOYEE_QUANTITY));
				}
				if(!string.IsNullOrWhiteSpace(model.HAS_CONTAIN_GROUND))
				{
				  condition.And(TRANSFER_ENTE_INFO._.HAS_CONTAIN_GROUND.Contain(model.HAS_CONTAIN_GROUND));
				}
				if(model.LAST_AUDIT_YEAR!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_YEAR==(model.LAST_AUDIT_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.LAST_AUDIT_UNIT))
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_UNIT.Contain(model.LAST_AUDIT_UNIT));
				}
				if(model.LAST_AUDIT_ASSET!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_ASSET==(model.LAST_AUDIT_ASSET));
				}
				if(model.LAST_AUDIT_DEBT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_DEBT==(model.LAST_AUDIT_DEBT));
				}
				if(model.LAST_AUDIT_EQUITY!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_EQUITY==(model.LAST_AUDIT_EQUITY));
				}
				if(model.LAST_AUDIT_EARNING!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_EARNING==(model.LAST_AUDIT_EARNING));
				}
				if(model.LAST_AUDIT_PROFIT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_PROFIT==(model.LAST_AUDIT_PROFIT));
				}
				if(model.LAST_AUDIT_NETPROFIT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.LAST_AUDIT_NETPROFIT==(model.LAST_AUDIT_NETPROFIT));
				}
				if(model.FINANCE_REPORT_DATE!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.FINANCE_REPORT_DATE==(model.FINANCE_REPORT_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCE_REPORT_TYPE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.FINANCE_REPORT_TYPE.Contain(model.FINANCE_REPORT_TYPE));
				}
				if(model.TOTAL_CAPITAL!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.TOTAL_CAPITAL==(model.TOTAL_CAPITAL));
				}
				if(model.TOTAL_DEBT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.TOTAL_DEBT==(model.TOTAL_DEBT));
				}
				if(model.OWENERSHIP_INTEREST!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.OWENERSHIP_INTEREST==(model.OWENERSHIP_INTEREST));
				}
				if(model.BUSINESS_INCOME!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.BUSINESS_INCOME==(model.BUSINESS_INCOME));
				}
				if(model.BUSINESS_PROFIT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.BUSINESS_PROFIT==(model.BUSINESS_PROFIT));
				}
				if(model.NET_PROFIT!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.NET_PROFIT==(model.NET_PROFIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_PRE_ID!=null)
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_PRE_ID==(model.M_PRE_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.BID_CODE.Contain(model.BID_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLASS_VER_CODE))
				{
				  condition.And(TRANSFER_ENTE_INFO._.CLASS_VER_CODE.Contain(model.CLASS_VER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(TRANSFER_ENTE_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}