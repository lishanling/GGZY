using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriConstructEnterInfoService : BaseServiceT<ZJPRI_CONSTRUCT_ENTER_INFO>
    {
        #region 接口实现
        
		public List<ZJPRI_CONSTRUCT_ENTER_INFO> FindList(ZJPRI_CONSTRUCT_ENTER_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_CONSTRUCT_ENTER_INFO> PageList(ZJPRI_CONSTRUCT_ENTER_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_CONSTRUCT_ENTER_INFO._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">主键GUID默认生成</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ID == ID);
			
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
        public GeneralResult Edit(ZJPRI_CONSTRUCT_ENTER_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_CONSTRUCT_ENTER_INFO entity)
	{		
		entity.Attach();
		entity.COMPANYID=model.COMPANYID;
		entity.COMPANYMAINNAME=model.COMPANYMAINNAME;
		entity.USEDNAME=model.USEDNAME;
		entity.OFFICERID=model.OFFICERID;
		entity.OFFICERNAME=model.OFFICERNAME;
		entity.AREA=model.AREA;
		entity.COUNTRYWIDENAME=model.COUNTRYWIDENAME;
		entity.CODE=model.CODE;
		entity.REGISTERADDRESS=model.REGISTERADDRESS;
		entity.REGISTERPOSTCODE=model.REGISTERPOSTCODE;
		entity.DETAILADDRESS=model.DETAILADDRESS;
		entity.DETAILREGISTERPOSTCODE=model.DETAILREGISTERPOSTCODE;
		entity.BUSSINESSCHARTER=model.BUSSINESSCHARTER;
		entity.CORPORATIONNUMBER=model.CORPORATIONNUMBER;
		entity.SOCIALCREDITCODE=model.SOCIALCREDITCODE;
		entity.PRINCIPAL=model.PRINCIPAL;
		entity.MONETARYUNITID=model.MONETARYUNITID;
		entity.MONETARYUNITNAME=model.MONETARYUNITNAME;
		entity.ECONOMYTYPEID=model.ECONOMYTYPEID;
		entity.ECONOMYTYPENAME=model.ECONOMYTYPENAME;
		entity.BUSSINESSDATESTART=model.BUSSINESSDATESTART;
		entity.FAX=model.FAX;
		entity.PHONE=model.PHONE;
		entity.LINKMANMOBILE=model.LINKMANMOBILE;
		entity.EMAIL=model.EMAIL;
		entity.WEBSITE=model.WEBSITE;
		entity.LINKMAN=model.LINKMAN;
		entity.LINKMANTELEPHONE=model.LINKMANTELEPHONE;
		entity.BUSINESSSYSTEMTYPEID=model.BUSINESSSYSTEMTYPEID;
		entity.BUSINESSSYSTEMTYPENAME=model.BUSINESSSYSTEMTYPENAME;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.ZZ_TYPE=model.ZZ_TYPE;
		entity.ZZJGDMZ_SXTM=model.ZZJGDMZ_SXTM;
		entity.ZZJGDMZ_FILE=model.ZZJGDMZ_FILE;
		entity.YYZZ_SXTM=model.YYZZ_SXTM;
		entity.YYZZ_FILE=model.YYZZ_FILE;
		entity.SWDJZ_TYPE=model.SWDJZ_TYPE;
		entity.SWDJZ_NO=model.SWDJZ_NO;
		entity.SWDJZ_SXTM=model.SWDJZ_SXTM;
		entity.SWDJZ_FILE=model.SWDJZ_FILE;
		entity.ID=model.ID;
		entity.SOCIALCREDITCODE_FILE=model.SOCIALCREDITCODE_FILE;
		entity.LEGAL_CODE=model.LEGAL_CODE;
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
        public GeneralResult Add(ZJPRI_CONSTRUCT_ENTER_INFO model)
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
                    Delete(ZJPRI_CONSTRUCT_ENTER_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_CONSTRUCT_ENTER_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_CONSTRUCT_ENTER_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.COMPANYID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.COMPANYID==(model.COMPANYID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYMAINNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.COMPANYMAINNAME.Contain(model.COMPANYMAINNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.USEDNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.USEDNAME.Contain(model.USEDNAME));
				}
				if(model.OFFICERID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.OFFICERID==(model.OFFICERID));
				}
				if(!string.IsNullOrWhiteSpace(model.OFFICERNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.OFFICERNAME.Contain(model.OFFICERNAME));
				}
				if(model.AREA!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.AREA==(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYWIDENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.COUNTRYWIDENAME.Contain(model.COUNTRYWIDENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTERADDRESS))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.REGISTERADDRESS.Contain(model.REGISTERADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTERPOSTCODE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.REGISTERPOSTCODE.Contain(model.REGISTERPOSTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DETAILADDRESS))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.DETAILADDRESS.Contain(model.DETAILADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.DETAILREGISTERPOSTCODE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.DETAILREGISTERPOSTCODE.Contain(model.DETAILREGISTERPOSTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSSINESSCHARTER))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.BUSSINESSCHARTER.Contain(model.BUSSINESSCHARTER));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPORATIONNUMBER))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.CORPORATIONNUMBER.Contain(model.CORPORATIONNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SOCIALCREDITCODE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.SOCIALCREDITCODE.Contain(model.SOCIALCREDITCODE));
				}
				if(model.PRINCIPAL!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.PRINCIPAL==(model.PRINCIPAL));
				}
				if(model.MONETARYUNITID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.MONETARYUNITID==(model.MONETARYUNITID));
				}
				if(!string.IsNullOrWhiteSpace(model.MONETARYUNITNAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.MONETARYUNITNAME.Contain(model.MONETARYUNITNAME));
				}
				if(model.ECONOMYTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ECONOMYTYPEID==(model.ECONOMYTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.ECONOMYTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ECONOMYTYPENAME.Contain(model.ECONOMYTYPENAME));
				}
				if(model.BUSSINESSDATESTART!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.BUSSINESSDATESTART==(model.BUSSINESSDATESTART));
				}
				if(!string.IsNullOrWhiteSpace(model.FAX))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.FAX.Contain(model.FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.PHONE.Contain(model.PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LINKMANMOBILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.LINKMANMOBILE.Contain(model.LINKMANMOBILE));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.EMAIL.Contain(model.EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.WEBSITE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.WEBSITE.Contain(model.WEBSITE));
				}
				if(!string.IsNullOrWhiteSpace(model.LINKMAN))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.LINKMAN.Contain(model.LINKMAN));
				}
				if(!string.IsNullOrWhiteSpace(model.LINKMANTELEPHONE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.LINKMANTELEPHONE.Contain(model.LINKMANTELEPHONE));
				}
				if(model.BUSINESSSYSTEMTYPEID!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.BUSINESSSYSTEMTYPEID==(model.BUSINESSSYSTEMTYPEID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSSYSTEMTYPENAME))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.BUSINESSSYSTEMTYPENAME.Contain(model.BUSINESSSYSTEMTYPENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.ZZ_TYPE!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ZZ_TYPE==(model.ZZ_TYPE));
				}
				if(model.ZZJGDMZ_SXTM!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ZZJGDMZ_SXTM==(model.ZZJGDMZ_SXTM));
				}
				if(!string.IsNullOrWhiteSpace(model.ZZJGDMZ_FILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ZZJGDMZ_FILE.Contain(model.ZZJGDMZ_FILE));
				}
				if(model.YYZZ_SXTM!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.YYZZ_SXTM==(model.YYZZ_SXTM));
				}
				if(!string.IsNullOrWhiteSpace(model.YYZZ_FILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.YYZZ_FILE.Contain(model.YYZZ_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.SWDJZ_TYPE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.SWDJZ_TYPE.Contain(model.SWDJZ_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SWDJZ_NO))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.SWDJZ_NO.Contain(model.SWDJZ_NO));
				}
				if(model.SWDJZ_SXTM!=null)
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.SWDJZ_SXTM==(model.SWDJZ_SXTM));
				}
				if(!string.IsNullOrWhiteSpace(model.SWDJZ_FILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.SWDJZ_FILE.Contain(model.SWDJZ_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SOCIALCREDITCODE_FILE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.SOCIALCREDITCODE_FILE.Contain(model.SOCIALCREDITCODE_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
				{
				  condition.And(ZJPRI_CONSTRUCT_ENTER_INFO._.LEGAL_CODE.Contain(model.LEGAL_CODE));
				}
		return condition;
	}
        #endregion
    }
}