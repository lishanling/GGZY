using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriConstructIntermediateService : BaseServiceT<ZJPRI_CONSTRUCT_INTERMEDIATE>
    {
        #region 接口实现
        
		public List<ZJPRI_CONSTRUCT_INTERMEDIATE> FindList(ZJPRI_CONSTRUCT_INTERMEDIATE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_CONSTRUCT_INTERMEDIATE> PageList(ZJPRI_CONSTRUCT_INTERMEDIATE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEPERSONID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TITLEPERSONID">职称人员ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? TITLEPERSONID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEPERSONID == TITLEPERSONID);
			
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
        public GeneralResult Edit(ZJPRI_CONSTRUCT_INTERMEDIATE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TITLEPERSONID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_CONSTRUCT_INTERMEDIATE entity)
	{		
		entity.Attach();
		entity.TITLEPERSONID=model.TITLEPERSONID;
		entity.BASEID=model.BASEID;
		entity.NAME=model.NAME;
		entity.IDENTITYCARDNUMBER=model.IDENTITYCARDNUMBER;
		entity.HIGHESTEDUCATION=model.HIGHESTEDUCATION;
		entity.TITLEID=model.TITLEID;
		entity.TITLENAME=model.TITLENAME;
		entity.TITLESPECIALITY=model.TITLESPECIALITY;
		entity.SPECIALITY=model.SPECIALITY;
		entity.GRADUATETIME=model.GRADUATETIME;
		entity.GRADUATESCHOOL=model.GRADUATESCHOOL;
		entity.COMPANYID=model.COMPANYID;
		entity.COMPANYMAINNAME=model.COMPANYMAINNAME;
		entity.POSITION=model.POSITION;
		entity.TELEPHONE=model.TELEPHONE;
		entity.MOBILEPHONE=model.MOBILEPHONE;
		entity.TITLENO=model.TITLENO;
		entity.TITLEURL=model.TITLEURL;
		entity.TITLEUNIT=model.TITLEUNIT;
		entity.BUSINESSSYSTEMTYPEID=model.BUSINESSSYSTEMTYPEID;
		entity.BUSINESSSYSTEMTYPENAME=model.BUSINESSSYSTEMTYPENAME;
		entity.AREA=model.AREA;
		entity.COUNTRYWIDENAME=model.COUNTRYWIDENAME;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.TITLE_FILE=model.TITLE_FILE;
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
        public GeneralResult Add(ZJPRI_CONSTRUCT_INTERMEDIATE model)
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
                    Delete(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEPERSONID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_CONSTRUCT_INTERMEDIATE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_CONSTRUCT_INTERMEDIATE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.TITLEPERSONID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEPERSONID==(model.TITLEPERSONID));
				}
				if(model.BASEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.BASEID==(model.BASEID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTITYCARDNUMBER))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.IDENTITYCARDNUMBER.Contain(model.IDENTITYCARDNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.HIGHESTEDUCATION))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.HIGHESTEDUCATION.Contain(model.HIGHESTEDUCATION));
				}
				if(model.TITLEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEID==(model.TITLEID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLENAME.Contain(model.TITLENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLESPECIALITY))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLESPECIALITY.Contain(model.TITLESPECIALITY));
				}
				if(!string.IsNullOrWhiteSpace(model.SPECIALITY))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.SPECIALITY.Contain(model.SPECIALITY));
				}
				if(model.GRADUATETIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.GRADUATETIME==(model.GRADUATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.GRADUATESCHOOL))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.GRADUATESCHOOL.Contain(model.GRADUATESCHOOL));
				}
				if(model.COMPANYID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.COMPANYID==(model.COMPANYID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYMAINNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.COMPANYMAINNAME.Contain(model.COMPANYMAINNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.POSITION))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.POSITION.Contain(model.POSITION));
				}
				if(!string.IsNullOrWhiteSpace(model.TELEPHONE))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TELEPHONE.Contain(model.TELEPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.MOBILEPHONE))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.MOBILEPHONE.Contain(model.MOBILEPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLENO))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLENO.Contain(model.TITLENO));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLEURL))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEURL.Contain(model.TITLEURL));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLEUNIT))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLEUNIT.Contain(model.TITLEUNIT));
				}
				if(model.BUSINESSSYSTEMTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.BUSINESSSYSTEMTYPEID==(model.BUSINESSSYSTEMTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSSYSTEMTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.BUSINESSSYSTEMTYPENAME.Contain(model.BUSINESSSYSTEMTYPENAME));
				}
				if(model.AREA!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.AREA==(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYWIDENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.COUNTRYWIDENAME.Contain(model.COUNTRYWIDENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE_FILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.TITLE_FILE.Contain(model.TITLE_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_CONSTRUCT_INTERMEDIATE._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
		return condition;
	}
        #endregion
    }
}