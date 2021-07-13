using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriConstructCertifiService : BaseServiceT<ZJPRI_CONSTRUCT_CERTIFI>
    {
        #region 接口实现
        
		public List<ZJPRI_CONSTRUCT_CERTIFI> FindList(ZJPRI_CONSTRUCT_CERTIFI model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_CONSTRUCT_CERTIFI> PageList(ZJPRI_CONSTRUCT_CERTIFI model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_CONSTRUCT_CERTIFI._.QUALIFYCERTIFICATEID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="QUALIFYCERTIFICATEID">资质证书ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? QUALIFYCERTIFICATEID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_CONSTRUCT_CERTIFI._.QUALIFYCERTIFICATEID == QUALIFYCERTIFICATEID);
			
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
        public GeneralResult Edit(ZJPRI_CONSTRUCT_CERTIFI model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.QUALIFYCERTIFICATEID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_CONSTRUCT_CERTIFI entity)
	{		
		entity.Attach();
		entity.QUALIFYCERTIFICATEID=model.QUALIFYCERTIFICATEID;
		entity.COMPANYID=model.COMPANYID;
		entity.COMPANYNAME=model.COMPANYNAME;
		entity.CERTIFICATIONTYPE=model.CERTIFICATIONTYPE;
		entity.ISSUEDEPARTMENT=model.ISSUEDEPARTMENT;
		entity.QUALIFYNUMBER=model.QUALIFYNUMBER;
		entity.ISSUEDATETIME=model.ISSUEDATETIME;
		entity.ISSUEDATE=model.ISSUEDATE;
		entity.ISSUEEXPIREDATETIME=model.ISSUEEXPIREDATETIME;
		entity.APPROVEDOCNUM=model.APPROVEDOCNUM;
		entity.REPLACESTATUS=model.REPLACESTATUS;
		entity.STATUS=model.STATUS;
		entity.FLOWNUMBER=model.FLOWNUMBER;
		entity.BUSINESSSYSTEMTYPEID=model.BUSINESSSYSTEMTYPEID;
		entity.BUSINESSSYSTEMTYPENAME=model.BUSINESSSYSTEMTYPENAME;
		entity.AREA=model.AREA;
		entity.COUNTRYWIDENAME=model.COUNTRYWIDENAME;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.ZZZS_FILE=model.ZZZS_FILE;
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
        public GeneralResult Add(ZJPRI_CONSTRUCT_CERTIFI model)
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
                    Delete(ZJPRI_CONSTRUCT_CERTIFI._.QUALIFYCERTIFICATEID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_CONSTRUCT_CERTIFI> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_CONSTRUCT_CERTIFI model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.QUALIFYCERTIFICATEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.QUALIFYCERTIFICATEID==(model.QUALIFYCERTIFICATEID));
				}
				if(model.COMPANYID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.COMPANYID==(model.COMPANYID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.COMPANYNAME.Contain(model.COMPANYNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATIONTYPE))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.CERTIFICATIONTYPE.Contain(model.CERTIFICATIONTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ISSUEDEPARTMENT))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.ISSUEDEPARTMENT.Contain(model.ISSUEDEPARTMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFYNUMBER))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.QUALIFYNUMBER.Contain(model.QUALIFYNUMBER));
				}
				if(model.ISSUEDATETIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.ISSUEDATETIME==(model.ISSUEDATETIME));
				}
				if(model.ISSUEDATE!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.ISSUEDATE==(model.ISSUEDATE));
				}
				if(model.ISSUEEXPIREDATETIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.ISSUEEXPIREDATETIME==(model.ISSUEEXPIREDATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVEDOCNUM))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.APPROVEDOCNUM.Contain(model.APPROVEDOCNUM));
				}
				if(model.REPLACESTATUS!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.REPLACESTATUS==(model.REPLACESTATUS));
				}
				if(model.STATUS!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.FLOWNUMBER))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.FLOWNUMBER.Contain(model.FLOWNUMBER));
				}
				if(model.BUSINESSSYSTEMTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.BUSINESSSYSTEMTYPEID==(model.BUSINESSSYSTEMTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSSYSTEMTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.BUSINESSSYSTEMTYPENAME.Contain(model.BUSINESSSYSTEMTYPENAME));
				}
				if(model.AREA!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.AREA==(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYWIDENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.COUNTRYWIDENAME.Contain(model.COUNTRYWIDENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZZZS_FILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_CERTIFI._.ZZZS_FILE.Contain(model.ZZZS_FILE));
				}
		return condition;
	}
        #endregion
    }
}