using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysPopedomService : BaseServiceT<SYS_POPEDOM>
    {
        #region 接口实现
        
		public List<SYS_POPEDOM> FindList(SYS_POPEDOM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_POPEDOM> PageList(SYS_POPEDOM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_POPEDOM._.POPID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="POPID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? POPID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_POPEDOM._.POPID == POPID);
			
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
        public GeneralResult Edit(SYS_POPEDOM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.POPID);
	
	if(viewResult.Success  && viewResult.Data is SYS_POPEDOM entity)
	{		
		entity.Attach();
		entity.POPID=model.POPID;
		entity.MENUID=model.MENUID;
		entity.POPTYPE=model.POPTYPE;
		entity.OBJECTTYPE=model.OBJECTTYPE;
		entity.OBJECTID=model.OBJECTID;
		entity.REMARK=model.REMARK;
		entity.CREATEID=model.CREATEID;
		entity.CREATETIME=model.CREATETIME;
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
        public GeneralResult Add(SYS_POPEDOM model)
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
                    Delete(SYS_POPEDOM._.POPID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_POPEDOM> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_POPEDOM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.POPID!=null)
				{
				  condition.And(SYS_POPEDOM._.POPID==(model.POPID));
				}
				if(model.MENUID!=null)
				{
				  condition.And(SYS_POPEDOM._.MENUID==(model.MENUID));
				}
				if(!string.IsNullOrWhiteSpace(model.POPTYPE))
				{
				  condition.And(SYS_POPEDOM._.POPTYPE.Contain(model.POPTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.OBJECTTYPE))
				{
				  condition.And(SYS_POPEDOM._.OBJECTTYPE.Contain(model.OBJECTTYPE));
				}
				if(model.OBJECTID!=null)
				{
				  condition.And(SYS_POPEDOM._.OBJECTID==(model.OBJECTID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_POPEDOM._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATEID))
				{
				  condition.And(SYS_POPEDOM._.CREATEID.Contain(model.CREATEID));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(SYS_POPEDOM._.CREATETIME==(model.CREATETIME));
				}
		return condition;
	}
        #endregion
    }
}