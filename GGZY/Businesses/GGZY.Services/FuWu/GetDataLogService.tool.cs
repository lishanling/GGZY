using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class GetDataLogService : BaseServiceT<GET_DATA_LOG>
    {
        #region 接口实现
        
		public List<GET_DATA_LOG> FindList(GET_DATA_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<GET_DATA_LOG> PageList(GET_DATA_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, GET_DATA_LOG._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(GET_DATA_LOG._.ID == ID);
			
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
        public GeneralResult Edit(GET_DATA_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is GET_DATA_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REMOTE_ADDR=model.REMOTE_ADDR;
		entity.HTTP_VIA=model.HTTP_VIA;
		entity.HTTP_X_FORWARDED_FOR=model.HTTP_X_FORWARDED_FOR;
		entity.URL=model.URL;
		entity.CLIENT_ID=model.CLIENT_ID;
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
        public GeneralResult Add(GET_DATA_LOG model)
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
                    Delete(GET_DATA_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<GET_DATA_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(GET_DATA_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(GET_DATA_LOG._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMOTE_ADDR))
				{
				  condition.And(GET_DATA_LOG._.REMOTE_ADDR.Contain(model.REMOTE_ADDR));
				}
				if(!string.IsNullOrWhiteSpace(model.HTTP_VIA))
				{
				  condition.And(GET_DATA_LOG._.HTTP_VIA.Contain(model.HTTP_VIA));
				}
				if(!string.IsNullOrWhiteSpace(model.HTTP_X_FORWARDED_FOR))
				{
				  condition.And(GET_DATA_LOG._.HTTP_X_FORWARDED_FOR.Contain(model.HTTP_X_FORWARDED_FOR));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(GET_DATA_LOG._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_ID))
				{
				  condition.And(GET_DATA_LOG._.CLIENT_ID.Contain(model.CLIENT_ID));
				}
				if(model.TM!=null)
				{
				  condition.And(GET_DATA_LOG._.TM==(model.TM));
				}
		return condition;
	}
        #endregion
    }
}