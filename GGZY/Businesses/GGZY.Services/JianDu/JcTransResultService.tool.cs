using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JcTransResultService : BaseServiceT<JC_TRANS_RESULT>
    {
        #region 接口实现
        
		public List<JC_TRANS_RESULT> FindList(JC_TRANS_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JC_TRANS_RESULT> PageList(JC_TRANS_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JC_TRANS_RESULT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JC_TRANS_RESULT._.ID == ID);
			
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
        public GeneralResult Edit(JC_TRANS_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is JC_TRANS_RESULT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.F_RECORD_ID=model.F_RECORD_ID;
		entity.RESULT_MSG=model.RESULT_MSG;
		entity.SENDER=model.SENDER;
		entity.SENDER_UNIT=model.SENDER_UNIT;
		entity.SEBDER_ID=model.SEBDER_ID;
		entity.SENDER_UNIT_ID=model.SENDER_UNIT_ID;
		entity.ATTACHMENTS=model.ATTACHMENTS;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
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
        public GeneralResult Add(JC_TRANS_RESULT model)
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
                    Delete(JC_TRANS_RESULT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JC_TRANS_RESULT> model)
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
       	protected WhereClipBuilder ConditionBuilder(JC_TRANS_RESULT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(JC_TRANS_RESULT._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORD_ID))
				{
				  condition.And(JC_TRANS_RESULT._.RECORD_ID.Contain(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.F_RECORD_ID))
				{
				  condition.And(JC_TRANS_RESULT._.F_RECORD_ID.Contain(model.F_RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.RESULT_MSG))
				{
				  condition.And(JC_TRANS_RESULT._.RESULT_MSG.Contain(model.RESULT_MSG));
				}
				if(!string.IsNullOrWhiteSpace(model.SENDER))
				{
				  condition.And(JC_TRANS_RESULT._.SENDER.Contain(model.SENDER));
				}
				if(!string.IsNullOrWhiteSpace(model.SENDER_UNIT))
				{
				  condition.And(JC_TRANS_RESULT._.SENDER_UNIT.Contain(model.SENDER_UNIT));
				}
				if(model.SEBDER_ID!=null)
				{
				  condition.And(JC_TRANS_RESULT._.SEBDER_ID==(model.SEBDER_ID));
				}
				if(model.SENDER_UNIT_ID!=null)
				{
				  condition.And(JC_TRANS_RESULT._.SENDER_UNIT_ID==(model.SENDER_UNIT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTS))
				{
				  condition.And(JC_TRANS_RESULT._.ATTACHMENTS.Contain(model.ATTACHMENTS));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(JC_TRANS_RESULT._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JC_TRANS_RESULT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.IS_DELETE!=null)
				{
				  condition.And(JC_TRANS_RESULT._.IS_DELETE==(model.IS_DELETE));
				}
		return condition;
	}
        #endregion
    }
}