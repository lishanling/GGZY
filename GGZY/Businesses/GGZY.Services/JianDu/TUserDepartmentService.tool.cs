using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserDepartmentService : BaseServiceT<T_USER_DEPARTMENT>
    {
        #region 接口实现
        
		public List<T_USER_DEPARTMENT> FindList(T_USER_DEPARTMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER_DEPARTMENT> PageList(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_USER_DEPARTMENT._.DEPID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="DEPID">单位ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? DEPID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_USER_DEPARTMENT._.DEPID == DEPID);
			
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
        public GeneralResult Edit(T_USER_DEPARTMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.DEPID);
	
	if(viewResult.Success  && viewResult.Data is T_USER_DEPARTMENT entity)
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
		entity.KINDS=model.KINDS;
		entity.ISALLKIND=model.ISALLKIND;
		entity.OTHERIDS=model.OTHERIDS;
		entity.DCODE=model.DCODE;
		entity.ISBJ=model.ISBJ;
		entity.ISBA=model.ISBA;
		entity.PHONE=model.PHONE;
		entity.JGBM=model.JGBM;
		entity.DADDRESS=model.DADDRESS;
		entity.ISTS=model.ISTS;
		entity.HY_TYPE=model.HY_TYPE;
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
        public GeneralResult Add(T_USER_DEPARTMENT model)
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
                    Delete(T_USER_DEPARTMENT._.DEPID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER_DEPARTMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_USER_DEPARTMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.DEPID!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.DEPID==(model.DEPID));
				}
				if(!string.IsNullOrWhiteSpace(model.DNAME))
				{
				  condition.And(T_USER_DEPARTMENT._.DNAME.Contain(model.DNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(T_USER_DEPARTMENT._.AREACODE.Contain(model.AREACODE));
				}
				if(model.PARENTID!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.PARENTID==(model.PARENTID));
				}
				if(!string.IsNullOrWhiteSpace(model.DREMARK))
				{
				  condition.And(T_USER_DEPARTMENT._.DREMARK.Contain(model.DREMARK));
				}
				if(model.LONGI!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.LONGI==(model.LONGI));
				}
				if(model.LATI!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.LATI==(model.LATI));
				}
				if(!string.IsNullOrWhiteSpace(model.DTYPE))
				{
				  condition.And(T_USER_DEPARTMENT._.DTYPE.Contain(model.DTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGPROPERTY))
				{
				  condition.And(T_USER_DEPARTMENT._.ORGPROPERTY.Contain(model.ORGPROPERTY));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.ORDERID==(model.ORDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.DEPCODE))
				{
				  condition.And(T_USER_DEPARTMENT._.DEPCODE.Contain(model.DEPCODE));
				}
				if(model.ISCK!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.ISCK==(model.ISCK));
				}
				if(model.CKID!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.CKID==(model.CKID));
				}
				if(!string.IsNullOrWhiteSpace(model.KINDS))
				{
				  condition.And(T_USER_DEPARTMENT._.KINDS.Contain(model.KINDS));
				}
				if(model.ISALLKIND!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.ISALLKIND==(model.ISALLKIND));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHERIDS))
				{
				  condition.And(T_USER_DEPARTMENT._.OTHERIDS.Contain(model.OTHERIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.DCODE))
				{
				  condition.And(T_USER_DEPARTMENT._.DCODE.Contain(model.DCODE));
				}
				if(model.ISBJ!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.ISBJ==(model.ISBJ));
				}
				if(model.ISBA!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.ISBA==(model.ISBA));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE))
				{
				  condition.And(T_USER_DEPARTMENT._.PHONE.Contain(model.PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.JGBM))
				{
				  condition.And(T_USER_DEPARTMENT._.JGBM.Contain(model.JGBM));
				}
				if(!string.IsNullOrWhiteSpace(model.DADDRESS))
				{
				  condition.And(T_USER_DEPARTMENT._.DADDRESS.Contain(model.DADDRESS));
				}
				if(model.ISTS!=null)
				{
				  condition.And(T_USER_DEPARTMENT._.ISTS==(model.ISTS));
				}
				if(!string.IsNullOrWhiteSpace(model.HY_TYPE))
				{
				  condition.And(T_USER_DEPARTMENT._.HY_TYPE.Contain(model.HY_TYPE));
				}
		return condition;
	}
        #endregion
    }
}