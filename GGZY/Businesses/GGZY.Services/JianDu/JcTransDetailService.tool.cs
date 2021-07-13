using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JcTransDetailService : BaseServiceT<JC_TRANS_DETAIL>
    {
        #region 接口实现
        
		public List<JC_TRANS_DETAIL> FindList(JC_TRANS_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JC_TRANS_DETAIL> PageList(JC_TRANS_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JC_TRANS_DETAIL._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(JC_TRANS_DETAIL._.ID == ID);
			
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
        public GeneralResult Edit(JC_TRANS_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is JC_TRANS_DETAIL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.VIOLATION_TYPE=model.VIOLATION_TYPE;
		entity.VIOLATION_ID=model.VIOLATION_ID;
		entity.VIOLATION_POINT_CODE=model.VIOLATION_POINT_CODE;
		entity.VIOLATION_POINT_NAME=model.VIOLATION_POINT_NAME;
		entity.VIOLATION_POINT_TYPE=model.VIOLATION_POINT_TYPE;
		entity.CHECK_TIME=model.CHECK_TIME;
		entity.STATUS=model.STATUS;
		entity.RECORD_ID=model.RECORD_ID;
		entity.F_RECORD_ID=model.F_RECORD_ID;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.IS_DELETE=model.IS_DELETE;
		//Update(entity);
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
        public GeneralResult Add(JC_TRANS_DETAIL model)
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
                    Delete(JC_TRANS_DETAIL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JC_TRANS_DETAIL> model)
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
       	protected WhereClipBuilder ConditionBuilder(JC_TRANS_DETAIL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(JC_TRANS_DETAIL._.ID.Contain(model.ID));
				}
				if(model.VIOLATION_TYPE!=null)
				{
				  condition.And(JC_TRANS_DETAIL._.VIOLATION_TYPE==(model.VIOLATION_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATION_ID))
				{
				  condition.And(JC_TRANS_DETAIL._.VIOLATION_ID.Contain(model.VIOLATION_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATION_POINT_CODE))
				{
				  condition.And(JC_TRANS_DETAIL._.VIOLATION_POINT_CODE.Contain(model.VIOLATION_POINT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATION_POINT_NAME))
				{
				  condition.And(JC_TRANS_DETAIL._.VIOLATION_POINT_NAME.Contain(model.VIOLATION_POINT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATION_POINT_TYPE))
				{
				  condition.And(JC_TRANS_DETAIL._.VIOLATION_POINT_TYPE.Contain(model.VIOLATION_POINT_TYPE));
				}
				if(model.CHECK_TIME!=null)
				{
				  condition.And(JC_TRANS_DETAIL._.CHECK_TIME==(model.CHECK_TIME));
				}
				if(model.STATUS!=null)
				{
				  condition.And(JC_TRANS_DETAIL._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORD_ID))
				{
				  condition.And(JC_TRANS_DETAIL._.RECORD_ID.Contain(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.F_RECORD_ID))
				{
				  condition.And(JC_TRANS_DETAIL._.F_RECORD_ID.Contain(model.F_RECORD_ID));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JC_TRANS_DETAIL._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.IS_DELETE!=null)
				{
				  condition.And(JC_TRANS_DETAIL._.IS_DELETE==(model.IS_DELETE));
				}
		return condition;
	}
        #endregion
    }
}