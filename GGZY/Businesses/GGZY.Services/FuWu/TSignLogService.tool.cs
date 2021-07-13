using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSignLogService : BaseServiceT<T_SIGN_LOG>
    {
        #region 接口实现
        
		public List<T_SIGN_LOG> FindList(T_SIGN_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SIGN_LOG> PageList(T_SIGN_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SIGN_LOG._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_SIGN_LOG._.ID == ID);
			
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
        public GeneralResult Edit(T_SIGN_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SIGN_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.KEY_ID=model.KEY_ID;
		entity.TCID=model.TCID;
		entity.FILE_URL=model.FILE_URL;
		entity.MD5=model.MD5;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATE_BY=model.CREATE_BY;
		entity.IS_BASE64=model.IS_BASE64;
		entity.PARAMS=model.PARAMS;
		entity.PC_INFO=model.PC_INFO;
		entity.FILE_INFO=model.FILE_INFO;
		entity.CA_INFO=model.CA_INFO;
		entity.FILE_LENGTH=model.FILE_LENGTH;
		entity.IS_EFFECTIVE=model.IS_EFFECTIVE;
		entity.EXT_SIGN_FILE_URL=model.EXT_SIGN_FILE_URL;
		entity.USER_URL_PROTOCOL=model.USER_URL_PROTOCOL;
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
        public GeneralResult Add(T_SIGN_LOG model)
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
                    Delete(T_SIGN_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SIGN_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SIGN_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(T_SIGN_LOG._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY_ID))
				{
				  condition.And(T_SIGN_LOG._.KEY_ID.Contain(model.KEY_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TCID))
				{
				  condition.And(T_SIGN_LOG._.TCID.Contain(model.TCID));
				}
				if(!string.IsNullOrWhiteSpace(model.FILE_URL))
				{
				  condition.And(T_SIGN_LOG._.FILE_URL.Contain(model.FILE_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.MD5))
				{
				  condition.And(T_SIGN_LOG._.MD5.Contain(model.MD5));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_SIGN_LOG._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(T_SIGN_LOG._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.IS_BASE64!=null)
				{
				  condition.And(T_SIGN_LOG._.IS_BASE64==(model.IS_BASE64));
				}
				if(!string.IsNullOrWhiteSpace(model.PARAMS))
				{
				  condition.And(T_SIGN_LOG._.PARAMS.Contain(model.PARAMS));
				}
				if(!string.IsNullOrWhiteSpace(model.PC_INFO))
				{
				  condition.And(T_SIGN_LOG._.PC_INFO.Contain(model.PC_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.FILE_INFO))
				{
				  condition.And(T_SIGN_LOG._.FILE_INFO.Contain(model.FILE_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_INFO))
				{
				  condition.And(T_SIGN_LOG._.CA_INFO.Contain(model.CA_INFO));
				}
				if(model.FILE_LENGTH!=null)
				{
				  condition.And(T_SIGN_LOG._.FILE_LENGTH==(model.FILE_LENGTH));
				}
				if(model.IS_EFFECTIVE!=null)
				{
				  condition.And(T_SIGN_LOG._.IS_EFFECTIVE==(model.IS_EFFECTIVE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXT_SIGN_FILE_URL))
				{
				  condition.And(T_SIGN_LOG._.EXT_SIGN_FILE_URL.Contain(model.EXT_SIGN_FILE_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.USER_URL_PROTOCOL))
				{
				  condition.And(T_SIGN_LOG._.USER_URL_PROTOCOL.Contain(model.USER_URL_PROTOCOL));
				}
		return condition;
	}
        #endregion
    }
}