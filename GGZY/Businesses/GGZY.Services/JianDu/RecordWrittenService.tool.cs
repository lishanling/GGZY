using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordWrittenService : BaseServiceT<RECORD_WRITTEN>
    {
        #region 接口实现
        
		public List<RECORD_WRITTEN> FindList(RECORD_WRITTEN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_WRITTEN> PageList(RECORD_WRITTEN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_WRITTEN._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(RECORD_WRITTEN._.ID == ID);
			
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
        public GeneralResult Edit(RECORD_WRITTEN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_WRITTEN entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.WIN_UNIT_NAME=model.WIN_UNIT_NAME;
		entity.WIN_UNIT_CODE=model.WIN_UNIT_CODE;
		entity.WIN_UNIT_CREDIT_GRADE=model.WIN_UNIT_CREDIT_GRADE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
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
        public GeneralResult Add(RECORD_WRITTEN model)
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
                    Delete(RECORD_WRITTEN._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_WRITTEN> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_WRITTEN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_WRITTEN._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_WRITTEN._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_UNIT_NAME))
				{
				  condition.And(RECORD_WRITTEN._.WIN_UNIT_NAME.Contain(model.WIN_UNIT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_UNIT_CODE))
				{
				  condition.And(RECORD_WRITTEN._.WIN_UNIT_CODE.Contain(model.WIN_UNIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_UNIT_CREDIT_GRADE))
				{
				  condition.And(RECORD_WRITTEN._.WIN_UNIT_CREDIT_GRADE.Contain(model.WIN_UNIT_CREDIT_GRADE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_WRITTEN._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_WRITTEN._.CREATOR==(model.CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(RECORD_WRITTEN._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
		return condition;
	}
        #endregion
    }
}