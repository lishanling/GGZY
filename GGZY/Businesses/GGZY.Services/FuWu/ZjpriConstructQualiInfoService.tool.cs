using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriConstructQualiInfoService : BaseServiceT<ZJPRI_CONSTRUCT_QUALI_INFO>
    {
        #region 接口实现
        
		public List<ZJPRI_CONSTRUCT_QUALI_INFO> FindList(ZJPRI_CONSTRUCT_QUALI_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_CONSTRUCT_QUALI_INFO> PageList(ZJPRI_CONSTRUCT_QUALI_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="QUALIFYID">资质信息主键</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? QUALIFYID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYID == QUALIFYID);
			
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
        public GeneralResult Edit(ZJPRI_CONSTRUCT_QUALI_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.QUALIFYID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_CONSTRUCT_QUALI_INFO entity)
	{		
		entity.Attach();
		entity.QUALIFYID=model.QUALIFYID;
		entity.COMPANYID=model.COMPANYID;
		entity.NAME=model.NAME;
		entity.QUALIFYSEQUENCEID=model.QUALIFYSEQUENCEID;
		entity.QUALIFYSEQUENCENAME=model.QUALIFYSEQUENCENAME;
		entity.QUALIFYTYPEID=model.QUALIFYTYPEID;
		entity.QUALIFYTYPENAME=model.QUALIFYTYPENAME;
		entity.QUALIFYLEVELID=model.QUALIFYLEVELID;
		entity.QUALIFYLEVELNAME=model.QUALIFYLEVELNAME;
		entity.APPROVETIME=model.APPROVETIME;
		entity.APPROVEDOCNUM=model.APPROVEDOCNUM;
		entity.QUALIFYALLOWSTATE=model.QUALIFYALLOWSTATE;
		entity.KIND=model.KIND;
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
        public GeneralResult Add(ZJPRI_CONSTRUCT_QUALI_INFO model)
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
                    Delete(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_CONSTRUCT_QUALI_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_CONSTRUCT_QUALI_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.QUALIFYID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYID==(model.QUALIFYID));
				}
				if(model.COMPANYID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.COMPANYID==(model.COMPANYID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.NAME.Contain(model.NAME));
				}
				if(model.QUALIFYSEQUENCEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYSEQUENCEID==(model.QUALIFYSEQUENCEID));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFYSEQUENCENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYSEQUENCENAME.Contain(model.QUALIFYSEQUENCENAME));
				}
				if(model.QUALIFYTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYTYPEID==(model.QUALIFYTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFYTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYTYPENAME.Contain(model.QUALIFYTYPENAME));
				}
				if(model.QUALIFYLEVELID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYLEVELID==(model.QUALIFYLEVELID));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFYLEVELNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYLEVELNAME.Contain(model.QUALIFYLEVELNAME));
				}
				if(model.APPROVETIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.APPROVETIME==(model.APPROVETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVEDOCNUM))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.APPROVEDOCNUM.Contain(model.APPROVEDOCNUM));
				}
				if(model.QUALIFYALLOWSTATE!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.QUALIFYALLOWSTATE==(model.QUALIFYALLOWSTATE));
				}
				if(model.KIND!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.KIND==(model.KIND));
				}
				if(model.BUSINESSSYSTEMTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.BUSINESSSYSTEMTYPEID==(model.BUSINESSSYSTEMTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSSYSTEMTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.BUSINESSSYSTEMTYPENAME.Contain(model.BUSINESSSYSTEMTYPENAME));
				}
				if(model.AREA!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.AREA==(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYWIDENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.COUNTRYWIDENAME.Contain(model.COUNTRYWIDENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_CONSTRUCT_QUALI_INFO._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
		return condition;
	}
        #endregion
    }
}