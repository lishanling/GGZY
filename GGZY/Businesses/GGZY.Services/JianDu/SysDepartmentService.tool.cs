using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysDepartmentService : BaseServiceT<SYS_DEPARTMENT>
    {
        #region 接口实现
        
		public List<SYS_DEPARTMENT> FindList(SYS_DEPARTMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_DEPARTMENT> PageList(SYS_DEPARTMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_DEPARTMENT._.DEPID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="DEPID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? DEPID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_DEPARTMENT._.DEPID == DEPID);
			
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
        public GeneralResult Edit(SYS_DEPARTMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.DEPID);
	
	if(viewResult.Success  && viewResult.Data is SYS_DEPARTMENT entity)
	{		
		entity.Attach();
		entity.DEPID=model.DEPID;
		entity.DNAME=model.DNAME;
		entity.AREACODE=model.AREACODE;
		entity.PARENTID=model.PARENTID;
		entity.DREMARK=model.DREMARK;
		entity.LONGI=model.LONGI;
		entity.LATI=model.LATI;
		entity.DTYPE=model.DTYPE;
		entity.ORGPROPERTY=model.ORGPROPERTY;
		entity.ORDERID=model.ORDERID;
		entity.DEPCODE=model.DEPCODE;
		entity.ISCK=model.ISCK;
		entity.CKID=model.CKID;
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
        public GeneralResult Add(SYS_DEPARTMENT model)
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
                    Delete(SYS_DEPARTMENT._.DEPID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_DEPARTMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_DEPARTMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.DEPID!=null)
				{
				  condition.And(SYS_DEPARTMENT._.DEPID==(model.DEPID));
				}
				if(!string.IsNullOrWhiteSpace(model.DNAME))
				{
				  condition.And(SYS_DEPARTMENT._.DNAME.Contain(model.DNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(SYS_DEPARTMENT._.AREACODE.Contain(model.AREACODE));
				}
				if(model.PARENTID!=null)
				{
				  condition.And(SYS_DEPARTMENT._.PARENTID==(model.PARENTID));
				}
				if(!string.IsNullOrWhiteSpace(model.DREMARK))
				{
				  condition.And(SYS_DEPARTMENT._.DREMARK.Contain(model.DREMARK));
				}
				if(model.LONGI!=null)
				{
				  condition.And(SYS_DEPARTMENT._.LONGI==(model.LONGI));
				}
				if(model.LATI!=null)
				{
				  condition.And(SYS_DEPARTMENT._.LATI==(model.LATI));
				}
				if(!string.IsNullOrWhiteSpace(model.DTYPE))
				{
				  condition.And(SYS_DEPARTMENT._.DTYPE.Contain(model.DTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGPROPERTY))
				{
				  condition.And(SYS_DEPARTMENT._.ORGPROPERTY.Contain(model.ORGPROPERTY));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(SYS_DEPARTMENT._.ORDERID==(model.ORDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.DEPCODE))
				{
				  condition.And(SYS_DEPARTMENT._.DEPCODE.Contain(model.DEPCODE));
				}
				if(model.ISCK!=null)
				{
				  condition.And(SYS_DEPARTMENT._.ISCK==(model.ISCK));
				}
				if(model.CKID!=null)
				{
				  condition.And(SYS_DEPARTMENT._.CKID==(model.CKID));
				}
		return condition;
	}
        #endregion
    }
}