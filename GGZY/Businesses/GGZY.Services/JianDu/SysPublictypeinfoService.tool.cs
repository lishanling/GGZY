using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysPublictypeinfoService : BaseServiceT<SYS_PUBLICTYPEINFO>
    {
        #region 接口实现
        
		public List<SYS_PUBLICTYPEINFO> FindList(SYS_PUBLICTYPEINFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_PUBLICTYPEINFO> PageList(SYS_PUBLICTYPEINFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_PUBLICTYPEINFO._.PTIID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="PTIID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? PTIID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_PUBLICTYPEINFO._.PTIID == PTIID);
			
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
        public GeneralResult Edit(SYS_PUBLICTYPEINFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.PTIID);
	
	if(viewResult.Success  && viewResult.Data is SYS_PUBLICTYPEINFO entity)
	{		
		entity.Attach();
		entity.PTIID=model.PTIID;
		entity.PARENTTYPEID=model.PARENTTYPEID;
		entity.SIGN=model.SIGN;
		entity.TYPENAME=model.TYPENAME;
		entity.TYPEVALUE=model.TYPEVALUE;
		entity.TYPEVALUE2=model.TYPEVALUE2;
		entity.ISDEL=model.ISDEL;
		entity.ISENABLE=model.ISENABLE;
		entity.ORDERID=model.ORDERID;
		entity.REMARK=model.REMARK;
		entity.CREATEID=model.CREATEID;
		entity.ISFORUSER=model.ISFORUSER;
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
        public GeneralResult Add(SYS_PUBLICTYPEINFO model)
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
                    Delete(SYS_PUBLICTYPEINFO._.PTIID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_PUBLICTYPEINFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_PUBLICTYPEINFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.PTIID!=null)
				{
				  condition.And(SYS_PUBLICTYPEINFO._.PTIID==(model.PTIID));
				}
				if(model.PARENTTYPEID!=null)
				{
				  condition.And(SYS_PUBLICTYPEINFO._.PARENTTYPEID==(model.PARENTTYPEID));
				}
				if(model.SIGN!=null)
				{
				  condition.And(SYS_PUBLICTYPEINFO._.SIGN==(model.SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPENAME))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.TYPENAME.Contain(model.TYPENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPEVALUE))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.TYPEVALUE.Contain(model.TYPEVALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPEVALUE2))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.TYPEVALUE2.Contain(model.TYPEVALUE2));
				}
				if(!string.IsNullOrWhiteSpace(model.ISDEL))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.ISDEL.Contain(model.ISDEL));
				}
				if(!string.IsNullOrWhiteSpace(model.ISENABLE))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.ISENABLE.Contain(model.ISENABLE));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(SYS_PUBLICTYPEINFO._.ORDERID==(model.ORDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATEID))
				{
				  condition.And(SYS_PUBLICTYPEINFO._.CREATEID.Contain(model.CREATEID));
				}
				if(model.ISFORUSER!=null)
				{
				  condition.And(SYS_PUBLICTYPEINFO._.ISFORUSER==(model.ISFORUSER));
				}
		return condition;
	}
        #endregion
    }
}