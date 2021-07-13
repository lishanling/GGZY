using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordSectionInfoService : BaseServiceT<RECORD_SECTION_INFO>
    {
        #region 接口实现
        
		public List<RECORD_SECTION_INFO> FindList(RECORD_SECTION_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_SECTION_INFO> PageList(RECORD_SECTION_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_SECTION_INFO._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(RECORD_SECTION_INFO._.ID == ID);
			
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
        public GeneralResult Edit(RECORD_SECTION_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_SECTION_INFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.ENTERPRISE_NOTICE_CODE=model.ENTERPRISE_NOTICE_CODE;
		entity.DEPARTMENT_NOTICE_CODE=model.DEPARTMENT_NOTICE_CODE;
		entity.WIN_BID_DATE=model.WIN_BID_DATE;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.WIN_BIDDER_NAME=model.WIN_BIDDER_NAME;
		entity.WIN_BIDDER_CODE=model.WIN_BIDDER_CODE;
		entity.PROJECT_LEADER_NAME=model.PROJECT_LEADER_NAME;
		entity.PROJECT_LEADER_CODE=model.PROJECT_LEADER_CODE;
		entity.WIN_BIDDER_WAY=model.WIN_BIDDER_WAY;
		entity.BID_EVALUATE_INFO=model.BID_EVALUATE_INFO;
		entity.OTHER_EVALUATE_RECORD=model.OTHER_EVALUATE_RECORD;
		entity.WIN_BIDDER_PUBLIC=model.WIN_BIDDER_PUBLIC;
		entity.WIN_BID_INFO=model.WIN_BID_INFO;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
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
        public GeneralResult Add(RECORD_SECTION_INFO model)
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
                    Delete(RECORD_SECTION_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_SECTION_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_SECTION_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_SECTION_INFO._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_SECTION_INFO._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTERPRISE_NOTICE_CODE))
				{
				  condition.And(RECORD_SECTION_INFO._.ENTERPRISE_NOTICE_CODE.Contain(model.ENTERPRISE_NOTICE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEPARTMENT_NOTICE_CODE))
				{
				  condition.And(RECORD_SECTION_INFO._.DEPARTMENT_NOTICE_CODE.Contain(model.DEPARTMENT_NOTICE_CODE));
				}
				if(model.WIN_BID_DATE!=null)
				{
				  condition.And(RECORD_SECTION_INFO._.WIN_BID_DATE==(model.WIN_BID_DATE));
				}
				if(model.BID_AMOUNT!=null)
				{
				  condition.And(RECORD_SECTION_INFO._.BID_AMOUNT==(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_NAME))
				{
				  condition.And(RECORD_SECTION_INFO._.WIN_BIDDER_NAME.Contain(model.WIN_BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_CODE))
				{
				  condition.And(RECORD_SECTION_INFO._.WIN_BIDDER_CODE.Contain(model.WIN_BIDDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEADER_NAME))
				{
				  condition.And(RECORD_SECTION_INFO._.PROJECT_LEADER_NAME.Contain(model.PROJECT_LEADER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEADER_CODE))
				{
				  condition.And(RECORD_SECTION_INFO._.PROJECT_LEADER_CODE.Contain(model.PROJECT_LEADER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_WAY))
				{
				  condition.And(RECORD_SECTION_INFO._.WIN_BIDDER_WAY.Contain(model.WIN_BIDDER_WAY));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_EVALUATE_INFO))
				{
				  condition.And(RECORD_SECTION_INFO._.BID_EVALUATE_INFO.Contain(model.BID_EVALUATE_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_EVALUATE_RECORD))
				{
				  condition.And(RECORD_SECTION_INFO._.OTHER_EVALUATE_RECORD.Contain(model.OTHER_EVALUATE_RECORD));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_PUBLIC))
				{
				  condition.And(RECORD_SECTION_INFO._.WIN_BIDDER_PUBLIC.Contain(model.WIN_BIDDER_PUBLIC));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_INFO))
				{
				  condition.And(RECORD_SECTION_INFO._.WIN_BID_INFO.Contain(model.WIN_BID_INFO));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_SECTION_INFO._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_SECTION_INFO._.CREATOR==(model.CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(RECORD_SECTION_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(RECORD_SECTION_INFO._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
		return condition;
	}
        #endregion
    }
}