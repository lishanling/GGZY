using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ExtServiceAdviceService : BaseServiceT<EXT_SERVICE_ADVICE>
    {
        #region 接口实现
        
		public List<EXT_SERVICE_ADVICE> FindList(EXT_SERVICE_ADVICE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<EXT_SERVICE_ADVICE> PageList(EXT_SERVICE_ADVICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, EXT_SERVICE_ADVICE._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(EXT_SERVICE_ADVICE._.ID == ID);
			
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
        public GeneralResult Edit(EXT_SERVICE_ADVICE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is EXT_SERVICE_ADVICE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REALNAME=model.REALNAME;
		entity.PHONE=model.PHONE;
		entity.EMAIL=model.EMAIL;
		entity.TITLE=model.TITLE;
		entity.CONTENT=model.CONTENT;
		entity.TM=model.TM;
		entity.ANSWER=model.ANSWER;
		entity.ANSWER_USERID=model.ANSWER_USERID;
		entity.ANSWER_TM=model.ANSWER_TM;
		entity.RETURN=model.RETURN;
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
        public GeneralResult Add(EXT_SERVICE_ADVICE model)
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
                    Delete(EXT_SERVICE_ADVICE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<EXT_SERVICE_ADVICE> model)
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
       	protected WhereClipBuilder ConditionBuilder(EXT_SERVICE_ADVICE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(EXT_SERVICE_ADVICE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REALNAME))
				{
				  condition.And(EXT_SERVICE_ADVICE._.REALNAME.Contain(model.REALNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE))
				{
				  condition.And(EXT_SERVICE_ADVICE._.PHONE.Contain(model.PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(EXT_SERVICE_ADVICE._.EMAIL.Contain(model.EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(EXT_SERVICE_ADVICE._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(EXT_SERVICE_ADVICE._.CONTENT.Contain(model.CONTENT));
				}
				if(model.TM!=null)
				{
				  condition.And(EXT_SERVICE_ADVICE._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.ANSWER))
				{
				  condition.And(EXT_SERVICE_ADVICE._.ANSWER.Contain(model.ANSWER));
				}
				if(model.ANSWER_USERID!=null)
				{
				  condition.And(EXT_SERVICE_ADVICE._.ANSWER_USERID==(model.ANSWER_USERID));
				}
				if(model.ANSWER_TM!=null)
				{
				  condition.And(EXT_SERVICE_ADVICE._.ANSWER_TM==(model.ANSWER_TM));
				}
				if(model.RETURN!=null)
				{
				  condition.And(EXT_SERVICE_ADVICE._.RETURN==(model.RETURN));
				}
		return condition;
	}
        #endregion
    }
}