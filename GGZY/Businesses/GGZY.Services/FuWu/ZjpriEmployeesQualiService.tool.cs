using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriEmployeesQualiService : BaseServiceT<ZJPRI_EMPLOYEES_QUALI>
    {
        #region 接口实现
        
		public List<ZJPRI_EMPLOYEES_QUALI> FindList(ZJPRI_EMPLOYEES_QUALI model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_EMPLOYEES_QUALI> PageList(ZJPRI_EMPLOYEES_QUALI model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_EMPLOYEES_QUALI._.CERTIFICATEID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="CERTIFICATEID">证书ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? CERTIFICATEID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATEID == CERTIFICATEID);
			
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
        public GeneralResult Edit(ZJPRI_EMPLOYEES_QUALI model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.CERTIFICATEID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_EMPLOYEES_QUALI entity)
	{		
		entity.Attach();
		entity.CERTIFICATEID=model.CERTIFICATEID;
		entity.BASEPERSONNAME=model.BASEPERSONNAME;
		entity.IDENTITYCARDNUMBER=model.IDENTITYCARDNUMBER;
		entity.CERTIFICATEORGAN=model.CERTIFICATEORGAN;
		entity.CERTIFICATETIME=model.CERTIFICATETIME;
		entity.CERTIFICATENUMBER=model.CERTIFICATENUMBER;
		entity.PERIODTIME=model.PERIODTIME;
		entity.WORKUNIT=model.WORKUNIT;
		entity.CERTIFICATETYPEID=model.CERTIFICATETYPEID;
		entity.CERTIFICATETYPENAME=model.CERTIFICATETYPENAME;
		entity.ISCANCEL=model.ISCANCEL;
		entity.KIND=model.KIND;
		entity.KINDNAME=model.KINDNAME;
		entity.GUID=model.GUID;
		entity.BASEID=model.BASEID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.CERTIFICATE_FILE=model.CERTIFICATE_FILE;
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
        public GeneralResult Add(ZJPRI_EMPLOYEES_QUALI model)
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
                    Delete(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATEID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_EMPLOYEES_QUALI> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_EMPLOYEES_QUALI model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.CERTIFICATEID!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATEID==(model.CERTIFICATEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BASEPERSONNAME))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.BASEPERSONNAME.Contain(model.BASEPERSONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTITYCARDNUMBER))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.IDENTITYCARDNUMBER.Contain(model.IDENTITYCARDNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATEORGAN))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATEORGAN.Contain(model.CERTIFICATEORGAN));
				}
				if(model.CERTIFICATETIME!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATETIME==(model.CERTIFICATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATENUMBER))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATENUMBER.Contain(model.CERTIFICATENUMBER));
				}
				if(model.PERIODTIME!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.PERIODTIME==(model.PERIODTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.WORKUNIT))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.WORKUNIT.Contain(model.WORKUNIT));
				}
				if(model.CERTIFICATETYPEID!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATETYPEID==(model.CERTIFICATETYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATETYPENAME))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATETYPENAME.Contain(model.CERTIFICATETYPENAME));
				}
				if(model.ISCANCEL!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.ISCANCEL==(model.ISCANCEL));
				}
				if(model.KIND!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.KIND==(model.KIND));
				}
				if(!string.IsNullOrWhiteSpace(model.KINDNAME))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.KINDNAME.Contain(model.KINDNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.GUID.Contain(model.GUID));
				}
				if(model.BASEID!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.BASEID==(model.BASEID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATE_FILE))
				{
				  condition.And(ZJPRI_EMPLOYEES_QUALI._.CERTIFICATE_FILE.Contain(model.CERTIFICATE_FILE));
				}
		return condition;
	}
        #endregion
    }
}