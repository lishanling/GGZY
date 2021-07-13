using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class LoginLogService : BaseServiceT<LOGIN_LOG>
    {
        #region 接口实现
        
		public List<LOGIN_LOG> FindList(LOGIN_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<LOGIN_LOG> PageList(LOGIN_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, LOGIN_LOG._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(LOGIN_LOG._.ID == ID);
			
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
        public GeneralResult Edit(LOGIN_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is LOGIN_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REMOTE_ADDR=model.REMOTE_ADDR;
		entity.HTTP_VIA=model.HTTP_VIA;
		entity.HTTP_X_FORWARDED_FOR=model.HTTP_X_FORWARDED_FOR;
		entity.USERNAME=model.USERNAME;
		entity.TM=model.TM;
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
        public GeneralResult Add(LOGIN_LOG model)
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
                    Delete(LOGIN_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<LOGIN_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(LOGIN_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(LOGIN_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMOTE_ADDR))
				{
				  condition.And(LOGIN_LOG._.REMOTE_ADDR.Contain(model.REMOTE_ADDR));
				}
				if(!string.IsNullOrWhiteSpace(model.HTTP_VIA))
				{
				  condition.And(LOGIN_LOG._.HTTP_VIA.Contain(model.HTTP_VIA));
				}
				if(!string.IsNullOrWhiteSpace(model.HTTP_X_FORWARDED_FOR))
				{
				  condition.And(LOGIN_LOG._.HTTP_X_FORWARDED_FOR.Contain(model.HTTP_X_FORWARDED_FOR));
				}
				if(!string.IsNullOrWhiteSpace(model.USERNAME))
				{
				  condition.And(LOGIN_LOG._.USERNAME.Contain(model.USERNAME));
				}
				if(model.TM!=null)
				{
				  condition.And(LOGIN_LOG._.TM==(model.TM));
				}
		return condition;
	}
        #endregion
    }
}