using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class MgrLogService : BaseServiceT<MGR_LOG>
    {
        #region 接口实现
        
		public List<MGR_LOG> FindList(MGR_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MGR_LOG> PageList(MGR_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, MGR_LOG._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">主键</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(MGR_LOG._.ID == ID);
			
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
        public GeneralResult Edit(MGR_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is MGR_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.LOGLEVEL=model.LOGLEVEL;
		entity.LOGTIME=model.LOGTIME;
		entity.MESSAGE=model.MESSAGE;
		entity.ACCOUNT=model.ACCOUNT;
		entity.URL=model.URL;
		entity.URLREFERRER=model.URLREFERRER;
		entity.BROWSER=model.BROWSER;
		entity.IP=model.IP;
		entity.HOST=model.HOST;
		entity.SYSTEM=model.SYSTEM;
		entity.TYPE=model.TYPE;
		entity.LOGFROM=model.LOGFROM;
		entity.METHOD=model.METHOD;
		entity.LOGGER=model.LOGGER;
		entity.THREADID=model.THREADID;
		entity.LOCATE=model.LOCATE;
		entity.MAC=model.MAC;
		entity.EX=model.EX;
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
        public GeneralResult Add(MGR_LOG model)
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
                    Delete(MGR_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<MGR_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(MGR_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(MGR_LOG._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGLEVEL))
				{
				  condition.And(MGR_LOG._.LOGLEVEL.Contain(model.LOGLEVEL));
				}
				if(model.LOGTIME!=null)
				{
				  condition.And(MGR_LOG._.LOGTIME==(model.LOGTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MESSAGE))
				{
				  condition.And(MGR_LOG._.MESSAGE.Contain(model.MESSAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCOUNT))
				{
				  condition.And(MGR_LOG._.ACCOUNT.Contain(model.ACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(MGR_LOG._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.URLREFERRER))
				{
				  condition.And(MGR_LOG._.URLREFERRER.Contain(model.URLREFERRER));
				}
				if(!string.IsNullOrWhiteSpace(model.BROWSER))
				{
				  condition.And(MGR_LOG._.BROWSER.Contain(model.BROWSER));
				}
				if(!string.IsNullOrWhiteSpace(model.IP))
				{
				  condition.And(MGR_LOG._.IP.Contain(model.IP));
				}
				if(!string.IsNullOrWhiteSpace(model.HOST))
				{
				  condition.And(MGR_LOG._.HOST.Contain(model.HOST));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM))
				{
				  condition.And(MGR_LOG._.SYSTEM.Contain(model.SYSTEM));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(MGR_LOG._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGFROM))
				{
				  condition.And(MGR_LOG._.LOGFROM.Contain(model.LOGFROM));
				}
				if(!string.IsNullOrWhiteSpace(model.METHOD))
				{
				  condition.And(MGR_LOG._.METHOD.Contain(model.METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGGER))
				{
				  condition.And(MGR_LOG._.LOGGER.Contain(model.LOGGER));
				}
				if(!string.IsNullOrWhiteSpace(model.THREADID))
				{
				  condition.And(MGR_LOG._.THREADID.Contain(model.THREADID));
				}
				if(!string.IsNullOrWhiteSpace(model.LOCATE))
				{
				  condition.And(MGR_LOG._.LOCATE.Contain(model.LOCATE));
				}
				if(!string.IsNullOrWhiteSpace(model.MAC))
				{
				  condition.And(MGR_LOG._.MAC.Contain(model.MAC));
				}
				if(!string.IsNullOrWhiteSpace(model.EX))
				{
				  condition.And(MGR_LOG._.EX.Contain(model.EX));
				}
		return condition;
	}
        #endregion
    }
}