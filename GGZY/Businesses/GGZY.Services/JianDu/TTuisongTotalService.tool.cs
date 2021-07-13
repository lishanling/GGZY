using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTuisongTotalService : BaseServiceT<T_TUISONG_TOTAL>
    {
        #region 接口实现
        
		public List<T_TUISONG_TOTAL> FindList(T_TUISONG_TOTAL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TUISONG_TOTAL> PageList(T_TUISONG_TOTAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TUISONG_TOTAL._.GUID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="GUID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string GUID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_TUISONG_TOTAL._.GUID == GUID);
			
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
        public GeneralResult Edit(T_TUISONG_TOTAL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.GUID);
	
	if(viewResult.Success  && viewResult.Data is T_TUISONG_TOTAL entity)
	{		
		entity.Attach();
		entity.GUID=model.GUID;
		entity.COUNT=model.COUNT;
		entity.CREATETIME=model.CREATETIME;
		entity.TABLENAME=model.TABLENAME;
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
        public GeneralResult Add(T_TUISONG_TOTAL model)
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
                    Delete(T_TUISONG_TOTAL._.GUID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TUISONG_TOTAL> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TUISONG_TOTAL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(T_TUISONG_TOTAL._.GUID.Contain(model.GUID));
				}
				if(model.COUNT!=null)
				{
				  condition.And(T_TUISONG_TOTAL._.COUNT==(model.COUNT));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_TUISONG_TOTAL._.CREATETIME==(model.CREATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TABLENAME))
				{
				  condition.And(T_TUISONG_TOTAL._.TABLENAME.Contain(model.TABLENAME));
				}
		return condition;
	}
        #endregion
    }
}