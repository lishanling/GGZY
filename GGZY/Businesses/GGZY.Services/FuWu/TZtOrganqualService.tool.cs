using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtOrganqualService : BaseServiceT<T_ZT_ORGANQUAL>
    {
        #region 接口实现
        
		public List<T_ZT_ORGANQUAL> FindList(T_ZT_ORGANQUAL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_ORGANQUAL> PageList(T_ZT_ORGANQUAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_ORGANQUAL._.ORGANNO.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ORGANNO">主体代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ORGANNO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_ORGANQUAL._.ORGANNO == ORGANNO);
			
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
        public GeneralResult Edit(T_ZT_ORGANQUAL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ORGANNO);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_ORGANQUAL entity)
	{		
		entity.Attach();
		entity.ORGANNO=model.ORGANNO;
		entity.QUALLEVEL=model.QUALLEVEL;
		entity.QUALNAME=model.QUALNAME;
		entity.QUALTYPE=model.QUALTYPE;
		entity.QUALCERTNO=model.QUALCERTNO;
		entity.QUALCERTENDDATE=model.QUALCERTENDDATE;
		entity.DATASOURCECODE=model.DATASOURCECODE;
		entity.DATATIMESTAMP=model.DATATIMESTAMP;
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
        public GeneralResult Add(T_ZT_ORGANQUAL model)
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
                    Delete(T_ZT_ORGANQUAL._.ORGANNO.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_ORGANQUAL> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_ORGANQUAL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ORGANNO))
				{
				  condition.And(T_ZT_ORGANQUAL._.ORGANNO.Contain(model.ORGANNO));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALLEVEL))
				{
				  condition.And(T_ZT_ORGANQUAL._.QUALLEVEL.Contain(model.QUALLEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALNAME))
				{
				  condition.And(T_ZT_ORGANQUAL._.QUALNAME.Contain(model.QUALNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALTYPE))
				{
				  condition.And(T_ZT_ORGANQUAL._.QUALTYPE.Contain(model.QUALTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALCERTNO))
				{
				  condition.And(T_ZT_ORGANQUAL._.QUALCERTNO.Contain(model.QUALCERTNO));
				}
				if(model.QUALCERTENDDATE!=null)
				{
				  condition.And(T_ZT_ORGANQUAL._.QUALCERTENDDATE==(model.QUALCERTENDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_ZT_ORGANQUAL._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
				if(model.DATATIMESTAMP!=null)
				{
				  condition.And(T_ZT_ORGANQUAL._.DATATIMESTAMP==(model.DATATIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}