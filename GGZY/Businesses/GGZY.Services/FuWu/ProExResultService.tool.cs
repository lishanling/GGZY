using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProExResultService : BaseServiceT<PRO_EX_RESULT>
    {
        #region 接口实现
        
		public List<PRO_EX_RESULT> FindList(PRO_EX_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRO_EX_RESULT> PageList(PRO_EX_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRO_EX_RESULT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRO_EX_RESULT._.ID == ID);
			
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
        public GeneralResult Edit(PRO_EX_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRO_EX_RESULT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PRO_CODE=model.PRO_CODE;
		entity.PRO_NAME=model.PRO_NAME;
		entity.PHS_METHOD=model.PHS_METHOD;
		entity.ELT_STIME=model.ELT_STIME;
		entity.ELT_DAYS=model.ELT_DAYS;
		entity.CNT_PERSON=model.CNT_PERSON;
		entity.CNT_TEL=model.CNT_TEL;
		entity.EX_CODE=model.EX_CODE;
		entity.EX_NAME=model.EX_NAME;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(PRO_EX_RESULT model)
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
                    Delete(PRO_EX_RESULT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRO_EX_RESULT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRO_EX_RESULT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRO_EX_RESULT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_CODE))
				{
				  condition.And(PRO_EX_RESULT._.PRO_CODE.Contain(model.PRO_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NAME))
				{
				  condition.And(PRO_EX_RESULT._.PRO_NAME.Contain(model.PRO_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PHS_METHOD))
				{
				  condition.And(PRO_EX_RESULT._.PHS_METHOD.Contain(model.PHS_METHOD));
				}
				if(model.ELT_STIME!=null)
				{
				  condition.And(PRO_EX_RESULT._.ELT_STIME==(model.ELT_STIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ELT_DAYS))
				{
				  condition.And(PRO_EX_RESULT._.ELT_DAYS.Contain(model.ELT_DAYS));
				}
				if(!string.IsNullOrWhiteSpace(model.CNT_PERSON))
				{
				  condition.And(PRO_EX_RESULT._.CNT_PERSON.Contain(model.CNT_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.CNT_TEL))
				{
				  condition.And(PRO_EX_RESULT._.CNT_TEL.Contain(model.CNT_TEL));
				}
				if(!string.IsNullOrWhiteSpace(model.EX_CODE))
				{
				  condition.And(PRO_EX_RESULT._.EX_CODE.Contain(model.EX_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EX_NAME))
				{
				  condition.And(PRO_EX_RESULT._.EX_NAME.Contain(model.EX_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(PRO_EX_RESULT._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}