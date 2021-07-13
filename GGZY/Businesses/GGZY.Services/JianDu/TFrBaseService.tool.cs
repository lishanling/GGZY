using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TFrBaseService : BaseServiceT<T_FR_BASE>
    {
        #region 接口实现
        
		public List<T_FR_BASE> FindList(T_FR_BASE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_FR_BASE> PageList(T_FR_BASE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_FR_BASE._.ORGANNO.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ORGANNO">法人机构代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ORGANNO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_FR_BASE._.ORGANNO == ORGANNO);
			
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
        public GeneralResult Edit(T_FR_BASE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ORGANNO);
	
	if(viewResult.Success  && viewResult.Data is T_FR_BASE entity)
	{		
		entity.Attach();
		entity.ORGANNO=model.ORGANNO;
		entity.LEGALNAME=model.LEGALNAME;
		entity.LICENSENO=model.LICENSENO;
		entity.LICENSEENDDATE=model.LICENSEENDDATE;
		entity.TAXCERTNO=model.TAXCERTNO;
		entity.LOCALTAXCERTNO=model.LOCALTAXCERTNO;
		entity.TAXCERTENDDATE=model.TAXCERTENDDATE;
		entity.LOCALTAXCERTENDDATE=model.LOCALTAXCERTENDDATE;
		entity.BEFOREORGANNO=model.BEFOREORGANNO;
		entity.ORGANCERTENDDATE=model.ORGANCERTENDDATE;
		entity.LEGALREPRESENT=model.LEGALREPRESENT;
		entity.LEGALTYPE=model.LEGALTYPE;
		entity.REPRESENTPHONE=model.REPRESENTPHONE;
		entity.LEGALINDUSTRY=model.LEGALINDUSTRY;
		entity.CREDITRATE=model.CREDITRATE;
		entity.COUNTRYREGION=model.COUNTRYREGION;
		entity.LEGALADDRESS=model.LEGALADDRESS;
		entity.REGIONCODE=model.REGIONCODE;
		entity.BASICBANK=model.BASICBANK;
		entity.BASICBRANCHBANK=model.BASICBRANCHBANK;
		entity.BASICACCOUNTNO=model.BASICACCOUNTNO;
		entity.BASICACCOUNTNAME=model.BASICACCOUNTNAME;
		entity.BASICACCOUNTLICENSENO=model.BASICACCOUNTLICENSENO;
		entity.REGCAPITAL=model.REGCAPITAL;
		entity.REGCAPCURRENCY=model.REGCAPCURRENCY;
		entity.REGUNIT=model.REGUNIT;
		entity.LEGALCONTACT=model.LEGALCONTACT;
		entity.LEGALCONTACTPHONE=model.LEGALCONTACTPHONE;
		entity.LEGALWEB=model.LEGALWEB;
		entity.LEGALZIPCODE=model.LEGALZIPCODE;
		entity.LEGALEMAIL=model.LEGALEMAIL;
		entity.LEGALROLE=model.LEGALROLE;
		entity.REGISTERDATE=model.REGISTERDATE;
		entity.REGISTERADDRESS=model.REGISTERADDRESS;
		entity.LEGALSTATUS=model.LEGALSTATUS;
		entity.DATASOURCENAME=model.DATASOURCENAME;
		entity.DATASOURCECODE=model.DATASOURCECODE;
		entity.DATATIMESTAMP=model.DATATIMESTAMP;
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
        public GeneralResult Add(T_FR_BASE model)
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
                    Delete(T_FR_BASE._.ORGANNO.SelectIn(idArr));
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
        public GeneralResult Import(List<T_FR_BASE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_FR_BASE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ORGANNO))
				{
				  condition.And(T_FR_BASE._.ORGANNO.Contain(model.ORGANNO));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALNAME))
				{
				  condition.And(T_FR_BASE._.LEGALNAME.Contain(model.LEGALNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LICENSENO))
				{
				  condition.And(T_FR_BASE._.LICENSENO.Contain(model.LICENSENO));
				}
				if(model.LICENSEENDDATE!=null)
				{
				  condition.And(T_FR_BASE._.LICENSEENDDATE==(model.LICENSEENDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TAXCERTNO))
				{
				  condition.And(T_FR_BASE._.TAXCERTNO.Contain(model.TAXCERTNO));
				}
				if(!string.IsNullOrWhiteSpace(model.LOCALTAXCERTNO))
				{
				  condition.And(T_FR_BASE._.LOCALTAXCERTNO.Contain(model.LOCALTAXCERTNO));
				}
				if(model.TAXCERTENDDATE!=null)
				{
				  condition.And(T_FR_BASE._.TAXCERTENDDATE==(model.TAXCERTENDDATE));
				}
				if(model.LOCALTAXCERTENDDATE!=null)
				{
				  condition.And(T_FR_BASE._.LOCALTAXCERTENDDATE==(model.LOCALTAXCERTENDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFOREORGANNO))
				{
				  condition.And(T_FR_BASE._.BEFOREORGANNO.Contain(model.BEFOREORGANNO));
				}
				if(model.ORGANCERTENDDATE!=null)
				{
				  condition.And(T_FR_BASE._.ORGANCERTENDDATE==(model.ORGANCERTENDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALREPRESENT))
				{
				  condition.And(T_FR_BASE._.LEGALREPRESENT.Contain(model.LEGALREPRESENT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALTYPE))
				{
				  condition.And(T_FR_BASE._.LEGALTYPE.Contain(model.LEGALTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPRESENTPHONE))
				{
				  condition.And(T_FR_BASE._.REPRESENTPHONE.Contain(model.REPRESENTPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALINDUSTRY))
				{
				  condition.And(T_FR_BASE._.LEGALINDUSTRY.Contain(model.LEGALINDUSTRY));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDITRATE))
				{
				  condition.And(T_FR_BASE._.CREDITRATE.Contain(model.CREDITRATE));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYREGION))
				{
				  condition.And(T_FR_BASE._.COUNTRYREGION.Contain(model.COUNTRYREGION));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALADDRESS))
				{
				  condition.And(T_FR_BASE._.LEGALADDRESS.Contain(model.LEGALADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.REGIONCODE))
				{
				  condition.And(T_FR_BASE._.REGIONCODE.Contain(model.REGIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BASICBANK))
				{
				  condition.And(T_FR_BASE._.BASICBANK.Contain(model.BASICBANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASICBRANCHBANK))
				{
				  condition.And(T_FR_BASE._.BASICBRANCHBANK.Contain(model.BASICBRANCHBANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASICACCOUNTNO))
				{
				  condition.And(T_FR_BASE._.BASICACCOUNTNO.Contain(model.BASICACCOUNTNO));
				}
				if(!string.IsNullOrWhiteSpace(model.BASICACCOUNTNAME))
				{
				  condition.And(T_FR_BASE._.BASICACCOUNTNAME.Contain(model.BASICACCOUNTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BASICACCOUNTLICENSENO))
				{
				  condition.And(T_FR_BASE._.BASICACCOUNTLICENSENO.Contain(model.BASICACCOUNTLICENSENO));
				}
				if(model.REGCAPITAL!=null)
				{
				  condition.And(T_FR_BASE._.REGCAPITAL==(model.REGCAPITAL));
				}
				if(!string.IsNullOrWhiteSpace(model.REGCAPCURRENCY))
				{
				  condition.And(T_FR_BASE._.REGCAPCURRENCY.Contain(model.REGCAPCURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.REGUNIT))
				{
				  condition.And(T_FR_BASE._.REGUNIT.Contain(model.REGUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALCONTACT))
				{
				  condition.And(T_FR_BASE._.LEGALCONTACT.Contain(model.LEGALCONTACT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALCONTACTPHONE))
				{
				  condition.And(T_FR_BASE._.LEGALCONTACTPHONE.Contain(model.LEGALCONTACTPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALWEB))
				{
				  condition.And(T_FR_BASE._.LEGALWEB.Contain(model.LEGALWEB));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALZIPCODE))
				{
				  condition.And(T_FR_BASE._.LEGALZIPCODE.Contain(model.LEGALZIPCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALEMAIL))
				{
				  condition.And(T_FR_BASE._.LEGALEMAIL.Contain(model.LEGALEMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALROLE))
				{
				  condition.And(T_FR_BASE._.LEGALROLE.Contain(model.LEGALROLE));
				}
				if(model.REGISTERDATE!=null)
				{
				  condition.And(T_FR_BASE._.REGISTERDATE==(model.REGISTERDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTERADDRESS))
				{
				  condition.And(T_FR_BASE._.REGISTERADDRESS.Contain(model.REGISTERADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALSTATUS))
				{
				  condition.And(T_FR_BASE._.LEGALSTATUS.Contain(model.LEGALSTATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCENAME))
				{
				  condition.And(T_FR_BASE._.DATASOURCENAME.Contain(model.DATASOURCENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_FR_BASE._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
				if(model.DATATIMESTAMP!=null)
				{
				  condition.And(T_FR_BASE._.DATATIMESTAMP==(model.DATATIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}