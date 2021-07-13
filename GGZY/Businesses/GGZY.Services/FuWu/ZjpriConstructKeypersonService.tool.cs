using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriConstructKeypersonService : BaseServiceT<ZJPRI_CONSTRUCT_KEYPERSON>
    {
        #region 接口实现
        
		public List<ZJPRI_CONSTRUCT_KEYPERSON> FindList(ZJPRI_CONSTRUCT_KEYPERSON model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_CONSTRUCT_KEYPERSON> PageList(ZJPRI_CONSTRUCT_KEYPERSON model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_CONSTRUCT_KEYPERSON._.MAINPERSONID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="MAINPERSONID">主要人员ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? MAINPERSONID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.MAINPERSONID == MAINPERSONID);
			
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
        public GeneralResult Edit(ZJPRI_CONSTRUCT_KEYPERSON model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.MAINPERSONID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_CONSTRUCT_KEYPERSON entity)
	{		
		entity.Attach();
		entity.MAINPERSONID=model.MAINPERSONID;
		entity.BASEID=model.BASEID;
		entity.NAME=model.NAME;
		entity.SEX=model.SEX;
		entity.TYPEID=model.TYPEID;
		entity.TYPENAME=model.TYPENAME;
		entity.BIRTHDAY=model.BIRTHDAY;
		entity.POSITION=model.POSITION;
		entity.TITLEID=model.TITLEID;
		entity.TITLENAME=model.TITLENAME;
		entity.HIGHESTEDUCATION=model.HIGHESTEDUCATION;
		entity.GRADUATIONTIME=model.GRADUATIONTIME;
		entity.GRADUATESCHOOL=model.GRADUATESCHOOL;
		entity.SPECIALITY=model.SPECIALITY;
		entity.CAREERYEAR=model.CAREERYEAR;
		entity.TELEPHONE=model.TELEPHONE;
		entity.MOBILEPHONE=model.MOBILEPHONE;
		entity.IDENTITYCARDNUMBER=model.IDENTITYCARDNUMBER;
		entity.COMPANYID=model.COMPANYID;
		entity.COMPANYMAINNAME=model.COMPANYMAINNAME;
		entity.ETHNIC=model.ETHNIC;
		entity.DEGREE=model.DEGREE;
		entity.QUALIFICATION=model.QUALIFICATION;
		entity.BUSINESSSYSTEMTYPEID=model.BUSINESSSYSTEMTYPEID;
		entity.BUSINESSSYSTEMTYPENAME=model.BUSINESSSYSTEMTYPENAME;
		entity.AREA=model.AREA;
		entity.COUNTRYWIDENAME=model.COUNTRYWIDENAME;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
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
        public GeneralResult Add(ZJPRI_CONSTRUCT_KEYPERSON model)
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
                    Delete(ZJPRI_CONSTRUCT_KEYPERSON._.MAINPERSONID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_CONSTRUCT_KEYPERSON> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_CONSTRUCT_KEYPERSON model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.MAINPERSONID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.MAINPERSONID==(model.MAINPERSONID));
				}
				if(model.BASEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.BASEID==(model.BASEID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.NAME.Contain(model.NAME));
				}
				if(model.SEX!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.SEX==(model.SEX));
				}
				if(model.TYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.TYPEID==(model.TYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.TYPENAME.Contain(model.TYPENAME));
				}
				if(model.BIRTHDAY!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.BIRTHDAY==(model.BIRTHDAY));
				}
				if(!string.IsNullOrWhiteSpace(model.POSITION))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.POSITION.Contain(model.POSITION));
				}
				if(model.TITLEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.TITLEID==(model.TITLEID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.TITLENAME.Contain(model.TITLENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.HIGHESTEDUCATION))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.HIGHESTEDUCATION.Contain(model.HIGHESTEDUCATION));
				}
				if(model.GRADUATIONTIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.GRADUATIONTIME==(model.GRADUATIONTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.GRADUATESCHOOL))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.GRADUATESCHOOL.Contain(model.GRADUATESCHOOL));
				}
				if(!string.IsNullOrWhiteSpace(model.SPECIALITY))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.SPECIALITY.Contain(model.SPECIALITY));
				}
				if(model.CAREERYEAR!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.CAREERYEAR==(model.CAREERYEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.TELEPHONE))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.TELEPHONE.Contain(model.TELEPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.MOBILEPHONE))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.MOBILEPHONE.Contain(model.MOBILEPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTITYCARDNUMBER))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.IDENTITYCARDNUMBER.Contain(model.IDENTITYCARDNUMBER));
				}
				if(model.COMPANYID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.COMPANYID==(model.COMPANYID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYMAINNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.COMPANYMAINNAME.Contain(model.COMPANYMAINNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ETHNIC))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.ETHNIC.Contain(model.ETHNIC));
				}
				if(!string.IsNullOrWhiteSpace(model.DEGREE))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.DEGREE.Contain(model.DEGREE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.QUALIFICATION.Contain(model.QUALIFICATION));
				}
				if(model.BUSINESSSYSTEMTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.BUSINESSSYSTEMTYPEID==(model.BUSINESSSYSTEMTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSSYSTEMTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.BUSINESSSYSTEMTYPENAME.Contain(model.BUSINESSSYSTEMTYPENAME));
				}
				if(model.AREA!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.AREA==(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYWIDENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.COUNTRYWIDENAME.Contain(model.COUNTRYWIDENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_CONSTRUCT_KEYPERSON._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
		return condition;
	}
        #endregion
    }
}