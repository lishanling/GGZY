using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TAskanswerService : BaseServiceT<T_ASKANSWER>
    {
        #region 接口实现
        
		public List<T_ASKANSWER> FindList(T_ASKANSWER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ASKANSWER> PageList(T_ASKANSWER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ASKANSWER._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_ASKANSWER._.ID == ID);
			
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
        public GeneralResult Edit(T_ASKANSWER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_ASKANSWER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.ANN_ID=model.ANN_ID;
		entity.TYPE=model.TYPE;
		entity.TM=model.TM;
		entity.ASK_USERID=model.ASK_USERID;
		entity.ANSWER_USERID=model.ANSWER_USERID;
		entity.ANSWER_TM=model.ANSWER_TM;
		entity.RETURN=model.RETURN;
		entity.ASK_ZY_REASON=model.ASK_ZY_REASON;
		entity.ASK=model.ASK;
		entity.ANSWER=model.ANSWER;
		entity.TITLE=model.TITLE;
		entity.ZP_ID=model.ZP_ID;
		entity.IS_GS=model.IS_GS;
		entity.ANN_CODE=model.ANN_CODE;
		entity.TENDERER_CODE=model.TENDERER_CODE;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.NOTICE_NAME=model.NOTICE_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
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
        public GeneralResult Add(T_ASKANSWER model)
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
                    Delete(T_ASKANSWER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ASKANSWER> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ASKANSWER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_ASKANSWER._.ID==(model.ID));
				}
				if(model.ANN_ID!=null)
				{
				  condition.And(T_ASKANSWER._.ANN_ID==(model.ANN_ID));
				}
				if(model.TYPE!=null)
				{
				  condition.And(T_ASKANSWER._.TYPE==(model.TYPE));
				}
				if(model.TM!=null)
				{
				  condition.And(T_ASKANSWER._.TM==(model.TM));
				}
				if(model.ASK_USERID!=null)
				{
				  condition.And(T_ASKANSWER._.ASK_USERID==(model.ASK_USERID));
				}
				if(model.ANSWER_USERID!=null)
				{
				  condition.And(T_ASKANSWER._.ANSWER_USERID==(model.ANSWER_USERID));
				}
				if(model.ANSWER_TM!=null)
				{
				  condition.And(T_ASKANSWER._.ANSWER_TM==(model.ANSWER_TM));
				}
				if(model.RETURN!=null)
				{
				  condition.And(T_ASKANSWER._.RETURN==(model.RETURN));
				}
				if(!string.IsNullOrWhiteSpace(model.ASK_ZY_REASON))
				{
				  condition.And(T_ASKANSWER._.ASK_ZY_REASON.Contain(model.ASK_ZY_REASON));
				}
				if(!string.IsNullOrWhiteSpace(model.ASK))
				{
				  condition.And(T_ASKANSWER._.ASK.Contain(model.ASK));
				}
				if(!string.IsNullOrWhiteSpace(model.ANSWER))
				{
				  condition.And(T_ASKANSWER._.ANSWER.Contain(model.ANSWER));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_ASKANSWER._.TITLE.Contain(model.TITLE));
				}
				if(model.ZP_ID!=null)
				{
				  condition.And(T_ASKANSWER._.ZP_ID==(model.ZP_ID));
				}
				if(model.IS_GS!=null)
				{
				  condition.And(T_ASKANSWER._.IS_GS==(model.IS_GS));
				}
				if(!string.IsNullOrWhiteSpace(model.ANN_CODE))
				{
				  condition.And(T_ASKANSWER._.ANN_CODE.Contain(model.ANN_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(T_ASKANSWER._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_ASKANSWER._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_ASKANSWER._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_ASKANSWER._.M_TM==(model.M_TM));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(T_ASKANSWER._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(T_ASKANSWER._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(T_ASKANSWER._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(T_ASKANSWER._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(T_ASKANSWER._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(T_ASKANSWER._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(T_ASKANSWER._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_ASKANSWER._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(T_ASKANSWER._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(T_ASKANSWER._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(T_ASKANSWER._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(T_ASKANSWER._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}