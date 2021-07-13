using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TRpService : BaseServiceT<T_RP>
    {
        #region 接口实现
        
		public List<T_RP> FindList(T_RP model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RP> PageList(T_RP model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RP._.RP_CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="RP_CODE"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string RP_CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RP._.RP_CODE == RP_CODE);
			
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
        public GeneralResult Edit(T_RP model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RP_CODE);
	
	if(viewResult.Success  && viewResult.Data is T_RP entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RP_CODE=model.RP_CODE;
		entity.NAME=model.NAME;
		entity.DB_CONFIG=model.DB_CONFIG;
		entity.HEAD_TYPE=model.HEAD_TYPE;
		entity.HEAD_HTML=model.HEAD_HTML;
		entity.SQL_TYPE=model.SQL_TYPE;
		entity.GET_DATA_SQL=model.GET_DATA_SQL;
		entity.RP_TYPE=model.RP_TYPE;
		entity.SEARCH_TYPE=model.SEARCH_TYPE;
		entity.SEARCH_HTML=model.SEARCH_HTML;
		entity.SEARCH_PARAM=model.SEARCH_PARAM;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.STCD_TYPE=model.STCD_TYPE;
		entity.RP_PARAM=model.RP_PARAM;
		entity.PAGE_FOOT=model.PAGE_FOOT;
		entity.PAGE_TITLE=model.PAGE_TITLE;
		entity.PAGE_HEAD=model.PAGE_HEAD;
		entity.RP_SERVER_PARAM=model.RP_SERVER_PARAM;
		entity.TREE_CODE=model.TREE_CODE;
		entity.PAGE_HEAD_SCRIPT_TYPE=model.PAGE_HEAD_SCRIPT_TYPE;
		entity.PAGE_HEAD_SCRIPT=model.PAGE_HEAD_SCRIPT;
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
        public GeneralResult Add(T_RP model)
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
                    Delete(T_RP._.RP_CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RP> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RP model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RP._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.RP_CODE))
				{
				  condition.And(T_RP._.RP_CODE.Contain(model.RP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_RP._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DB_CONFIG))
				{
				  condition.And(T_RP._.DB_CONFIG.Contain(model.DB_CONFIG));
				}
				if(model.HEAD_TYPE!=null)
				{
				  condition.And(T_RP._.HEAD_TYPE==(model.HEAD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.HEAD_HTML))
				{
				  condition.And(T_RP._.HEAD_HTML.Contain(model.HEAD_HTML));
				}
				if(model.SQL_TYPE!=null)
				{
				  condition.And(T_RP._.SQL_TYPE==(model.SQL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.GET_DATA_SQL))
				{
				  condition.And(T_RP._.GET_DATA_SQL.Contain(model.GET_DATA_SQL));
				}
				if(model.RP_TYPE!=null)
				{
				  condition.And(T_RP._.RP_TYPE==(model.RP_TYPE));
				}
				if(model.SEARCH_TYPE!=null)
				{
				  condition.And(T_RP._.SEARCH_TYPE==(model.SEARCH_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SEARCH_HTML))
				{
				  condition.And(T_RP._.SEARCH_HTML.Contain(model.SEARCH_HTML));
				}
				if(!string.IsNullOrWhiteSpace(model.SEARCH_PARAM))
				{
				  condition.And(T_RP._.SEARCH_PARAM.Contain(model.SEARCH_PARAM));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_BY))
				{
				  condition.And(T_RP._.CREATE_BY.Contain(model.CREATE_BY));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_RP._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.STCD_TYPE))
				{
				  condition.And(T_RP._.STCD_TYPE.Contain(model.STCD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.RP_PARAM))
				{
				  condition.And(T_RP._.RP_PARAM.Contain(model.RP_PARAM));
				}
				if(!string.IsNullOrWhiteSpace(model.PAGE_FOOT))
				{
				  condition.And(T_RP._.PAGE_FOOT.Contain(model.PAGE_FOOT));
				}
				if(!string.IsNullOrWhiteSpace(model.PAGE_TITLE))
				{
				  condition.And(T_RP._.PAGE_TITLE.Contain(model.PAGE_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAGE_HEAD))
				{
				  condition.And(T_RP._.PAGE_HEAD.Contain(model.PAGE_HEAD));
				}
				if(!string.IsNullOrWhiteSpace(model.RP_SERVER_PARAM))
				{
				  condition.And(T_RP._.RP_SERVER_PARAM.Contain(model.RP_SERVER_PARAM));
				}
				if(!string.IsNullOrWhiteSpace(model.TREE_CODE))
				{
				  condition.And(T_RP._.TREE_CODE.Contain(model.TREE_CODE));
				}
				if(model.PAGE_HEAD_SCRIPT_TYPE!=null)
				{
				  condition.And(T_RP._.PAGE_HEAD_SCRIPT_TYPE==(model.PAGE_HEAD_SCRIPT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAGE_HEAD_SCRIPT))
				{
				  condition.And(T_RP._.PAGE_HEAD_SCRIPT.Contain(model.PAGE_HEAD_SCRIPT));
				}
		return condition;
	}
        #endregion
    }
}