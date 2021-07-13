using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTuisongService : BaseServiceT<T_TUISONG>
    {
        #region 接口实现
        
		public List<T_TUISONG> FindList(T_TUISONG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TUISONG> PageList(T_TUISONG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TUISONG._.GUID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TUISONG._.GUID == GUID);
			
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
        public GeneralResult Edit(T_TUISONG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.GUID);
	
	if(viewResult.Success  && viewResult.Data is T_TUISONG entity)
	{		
		entity.Attach();
		entity.GUID=model.GUID;
		entity.ID=model.ID;
		entity.TABLENAME=model.TABLENAME;
		entity.CREATETIME=model.CREATETIME;
		entity.LASTTIME=model.LASTTIME;
		entity.ISSEND_ZHUJIAN=model.ISSEND_ZHUJIAN;
		entity.ISSEND_KONGJIAN=model.ISSEND_KONGJIAN;
		entity.ISSEND_1=model.ISSEND_1;
		entity.ISSEND_2=model.ISSEND_2;
		entity.ISSEND_3=model.ISSEND_3;
		entity.TOTALID=model.TOTALID;
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
        public GeneralResult Add(T_TUISONG model)
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
                    Delete(T_TUISONG._.GUID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TUISONG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TUISONG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(T_TUISONG._.GUID.Contain(model.GUID));
				}
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(T_TUISONG._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TABLENAME))
				{
				  condition.And(T_TUISONG._.TABLENAME.Contain(model.TABLENAME));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_TUISONG._.CREATETIME==(model.CREATETIME));
				}
				if(model.LASTTIME!=null)
				{
				  condition.And(T_TUISONG._.LASTTIME==(model.LASTTIME));
				}
				if(model.ISSEND_ZHUJIAN!=null)
				{
				  condition.And(T_TUISONG._.ISSEND_ZHUJIAN==(model.ISSEND_ZHUJIAN));
				}
				if(model.ISSEND_KONGJIAN!=null)
				{
				  condition.And(T_TUISONG._.ISSEND_KONGJIAN==(model.ISSEND_KONGJIAN));
				}
				if(model.ISSEND_1!=null)
				{
				  condition.And(T_TUISONG._.ISSEND_1==(model.ISSEND_1));
				}
				if(model.ISSEND_2!=null)
				{
				  condition.And(T_TUISONG._.ISSEND_2==(model.ISSEND_2));
				}
				if(model.ISSEND_3!=null)
				{
				  condition.And(T_TUISONG._.ISSEND_3==(model.ISSEND_3));
				}
				if(!string.IsNullOrWhiteSpace(model.TOTALID))
				{
				  condition.And(T_TUISONG._.TOTALID.Contain(model.TOTALID));
				}
		return condition;
	}
        #endregion
    }
}