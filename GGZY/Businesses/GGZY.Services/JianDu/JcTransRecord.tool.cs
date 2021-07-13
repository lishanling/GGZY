using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JcTransRecordService : BaseServiceT<JC_TRANS_RECORD>
    {
        #region 接口实现
        
		public List<JC_TRANS_RECORD> FindList(JC_TRANS_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JC_TRANS_RECORD> PageList(JC_TRANS_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JC_TRANS_RECORD._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JC_TRANS_RECORD._.ID == ID);
			
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
        public GeneralResult Edit(JC_TRANS_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is JC_TRANS_RECORD entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TRANS_CODE=model.TRANS_CODE;
		entity.TITLE=model.TITLE;
		entity.CONTENT=model.CONTENT;
		entity.RECEIVER=model.RECEIVER;
		entity.RECEIVER_PHONE=model.RECEIVER_PHONE;
		entity.TRANS_TIME=model.TRANS_TIME;
		entity.TRANS_TYPE=model.TRANS_TYPE;
		entity.TRANS_USER=model.TRANS_USER;
		entity.ATTACHMENT_IDS=model.ATTACHMENT_IDS;
		entity.TRANS_USER_ID=model.TRANS_USER_ID;
		entity.RECEIVER_UNIT_ID=model.RECEIVER_UNIT_ID;
		entity.RECEIVER_ID=model.RECEIVER_ID;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.TRANS_UNIT=model.TRANS_UNIT;
		entity.TRANS_UNITID=model.TRANS_UNITID;
		entity.HAS_RESULT=model.HAS_RESULT;
		entity.IS_NEW=model.IS_NEW;
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
        public GeneralResult Add(JC_TRANS_RECORD model)
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
                    Delete(JC_TRANS_RECORD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JC_TRANS_RECORD> model)
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
       	protected WhereClipBuilder ConditionBuilder(JC_TRANS_RECORD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(JC_TRANS_RECORD._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANS_CODE))
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_CODE.Contain(model.TRANS_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(JC_TRANS_RECORD._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(JC_TRANS_RECORD._.CONTENT.Contain(model.CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.RECEIVER))
				{
				  condition.And(JC_TRANS_RECORD._.RECEIVER.Contain(model.RECEIVER));
				}
				if(!string.IsNullOrWhiteSpace(model.RECEIVER_PHONE))
				{
				  condition.And(JC_TRANS_RECORD._.RECEIVER_PHONE.Contain(model.RECEIVER_PHONE));
				}
				if(model.TRANS_TIME!=null)
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_TIME==(model.TRANS_TIME));
				}
				if(model.TRANS_TYPE!=null)
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_TYPE==(model.TRANS_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANS_USER))
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_USER.Contain(model.TRANS_USER));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT_IDS))
				{
				  condition.And(JC_TRANS_RECORD._.ATTACHMENT_IDS.Contain(model.ATTACHMENT_IDS));
				}
				if(model.TRANS_USER_ID!=null)
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_USER_ID==(model.TRANS_USER_ID));
				}
				if(model.RECEIVER_UNIT_ID!=null)
				{
				  condition.And(JC_TRANS_RECORD._.RECEIVER_UNIT_ID==(model.RECEIVER_UNIT_ID));
				}
				if(model.RECEIVER_ID!=null)
				{
				  condition.And(JC_TRANS_RECORD._.RECEIVER_ID==(model.RECEIVER_ID));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JC_TRANS_RECORD._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANS_UNIT))
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_UNIT.Contain(model.TRANS_UNIT));
				}
				if(model.TRANS_UNITID!=null)
				{
				  condition.And(JC_TRANS_RECORD._.TRANS_UNITID==(model.TRANS_UNITID));
				}
				if(model.HAS_RESULT!=null)
				{
				  condition.And(JC_TRANS_RECORD._.HAS_RESULT==(model.HAS_RESULT));
				}
				if(model.IS_NEW!=null)
				{
				  condition.And(JC_TRANS_RECORD._.IS_NEW==(model.IS_NEW));
				}
				if(model.IS_DELETE!=null)
				{
				  condition.And(JC_TRANS_RECORD._.IS_DELETE==(model.IS_DELETE));
				}
		return condition;
	}
        #endregion
    }
}