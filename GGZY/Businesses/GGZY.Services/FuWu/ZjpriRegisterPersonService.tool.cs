using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriRegisterPersonService : BaseServiceT<ZJPRI_REGISTER_PERSON>
    {
        #region 接口实现
        
		public List<ZJPRI_REGISTER_PERSON> FindList(ZJPRI_REGISTER_PERSON model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_REGISTER_PERSON> PageList(ZJPRI_REGISTER_PERSON model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_REGISTER_PERSON._.CERTNUM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="CERTNUM">注册证书编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string CERTNUM)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_REGISTER_PERSON._.CERTNUM == CERTNUM);
			
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
        public GeneralResult Edit(ZJPRI_REGISTER_PERSON model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.CERTNUM);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_REGISTER_PERSON entity)
	{		
		entity.Attach();
		entity.PERSONID=model.PERSONID;
		entity.NAME=model.NAME;
		entity.IDENTITYCARDNUMBER=model.IDENTITYCARDNUMBER;
		entity.SPECIALTYPEID=model.SPECIALTYPEID;
		entity.SPECIALTYPENAME=model.SPECIALTYPENAME;
		entity.CERTNUM=model.CERTNUM;
		entity.AWARDDEPT=model.AWARDDEPT;
		entity.AWARDDATE=model.AWARDDATE;
		entity.STAMPNUM=model.STAMPNUM;
		entity.EFFECTDATE=model.EFFECTDATE;
		entity.REGNUM=model.REGNUM;
		entity.COMPANYMAINID=model.COMPANYMAINID;
		entity.COMPANYMAINNAME=model.COMPANYMAINNAME;
		entity.SPECIALTY=model.SPECIALTY;
		entity.YXQQ=model.YXQQ;
		entity.YXQZ=model.YXQZ;
		entity.BUSINESSSYSTEMTYPEID=model.BUSINESSSYSTEMTYPEID;
		entity.BUSINESSSYSTEMTYPENAME=model.BUSINESSSYSTEMTYPENAME;
		entity.AREA=model.AREA;
		entity.COUNTRYWIDENAME=model.COUNTRYWIDENAME;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.CERT_FILE=model.CERT_FILE;
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
        public GeneralResult Add(ZJPRI_REGISTER_PERSON model)
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
                    Delete(ZJPRI_REGISTER_PERSON._.CERTNUM.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_REGISTER_PERSON> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_REGISTER_PERSON model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.PERSONID!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.PERSONID==(model.PERSONID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTITYCARDNUMBER))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.IDENTITYCARDNUMBER.Contain(model.IDENTITYCARDNUMBER));
				}
				if(model.SPECIALTYPEID!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.SPECIALTYPEID==(model.SPECIALTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.SPECIALTYPENAME))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.SPECIALTYPENAME.Contain(model.SPECIALTYPENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTNUM))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.CERTNUM.Contain(model.CERTNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDDEPT))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.AWARDDEPT.Contain(model.AWARDDEPT));
				}
				if(model.AWARDDATE!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.AWARDDATE==(model.AWARDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.STAMPNUM))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.STAMPNUM.Contain(model.STAMPNUM));
				}
				if(model.EFFECTDATE!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.EFFECTDATE==(model.EFFECTDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGNUM))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.REGNUM.Contain(model.REGNUM));
				}
				if(model.COMPANYMAINID!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.COMPANYMAINID==(model.COMPANYMAINID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYMAINNAME))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.COMPANYMAINNAME.Contain(model.COMPANYMAINNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SPECIALTY))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.SPECIALTY.Contain(model.SPECIALTY));
				}
				if(!string.IsNullOrWhiteSpace(model.YXQQ))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.YXQQ.Contain(model.YXQQ));
				}
				if(!string.IsNullOrWhiteSpace(model.YXQZ))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.YXQZ.Contain(model.YXQZ));
				}
				if(model.BUSINESSSYSTEMTYPEID!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.BUSINESSSYSTEMTYPEID==(model.BUSINESSSYSTEMTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSSYSTEMTYPENAME))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.BUSINESSSYSTEMTYPENAME.Contain(model.BUSINESSSYSTEMTYPENAME));
				}
				if(model.AREA!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.AREA==(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYWIDENAME))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.COUNTRYWIDENAME.Contain(model.COUNTRYWIDENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.CERT_FILE))
				{
				  condition.And(ZJPRI_REGISTER_PERSON._.CERT_FILE.Contain(model.CERT_FILE));
				}
		return condition;
	}
        #endregion
    }
}