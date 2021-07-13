using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2TenderagencyinfoService : BaseServiceT<T_EC2_TENDERAGENCYINFO>
    {
        #region 接口实现
        
		public List<T_EC2_TENDERAGENCYINFO> FindList(T_EC2_TENDERAGENCYINFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_TENDERAGENCYINFO> PageList(T_EC2_TENDERAGENCYINFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_TENDERAGENCYINFO._.TENDERAGENCYCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TENDERAGENCYCODE">招标代理机构代码</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string TENDERAGENCYCODE,string TENDERPROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_TENDERAGENCYINFO._.TENDERAGENCYCODE == TENDERAGENCYCODE);
			condition.And(T_EC2_TENDERAGENCYINFO._.TENDERPROJECTCODE == TENDERPROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_TENDERAGENCYINFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TENDERAGENCYCODE,model.TENDERPROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_TENDERAGENCYINFO entity)
	{		
		entity.Attach();
		entity.TENDERAGENCYCODETYPE=model.TENDERAGENCYCODETYPE;
		entity.TENDERAGENCYCODE=model.TENDERAGENCYCODE;
		entity.TENDERAGENCYNAME=model.TENDERAGENCYNAME;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.ARTIFICIALPERSON=model.ARTIFICIALPERSON;
		entity.ARTIFICIALPERSONCODETYPE=model.ARTIFICIALPERSONCODETYPE;
		entity.ARTIFICIALPERSONCODE=model.ARTIFICIALPERSONCODE;
		entity.CONTACTNUMBER=model.CONTACTNUMBER;
		entity.COUNTRYREGION=model.COUNTRYREGION;
		entity.UNITNATURE=model.UNITNATURE;
		entity.REGIONCODE=model.REGIONCODE;
		entity.INDUSTRYCODE=model.INDUSTRYCODE;
		entity.LICNUMBER=model.LICNUMBER;
		entity.CACODE=model.CACODE;
		entity.TAXNUMBER=model.TAXNUMBER;
		entity.CREDITRATE=model.CREDITRATE;
		entity.OPENINGBANK=model.OPENINGBANK;
		entity.BASICACCOUNT=model.BASICACCOUNT;
		entity.REGCAPITAL=model.REGCAPITAL;
		entity.REGCAPCURRENCY=model.REGCAPCURRENCY;
		entity.REGUNIT=model.REGUNIT;
		entity.INFOREPORTERNAME=model.INFOREPORTERNAME;
		entity.INFOREPORTERCODETYPE=model.INFOREPORTERCODETYPE;
		entity.INFOREPORTERCODE=model.INFOREPORTERCODE;
		entity.INFOREPORTERCONTACTNUMBER=model.INFOREPORTERCONTACTNUMBER;
		entity.CONTACTADDRESS=model.CONTACTADDRESS;
		entity.ZIPCODE=model.ZIPCODE;
		entity.EMAIL=model.EMAIL;
		entity.PARTICIPANTTYPE=model.PARTICIPANTTYPE;
		entity.PLATFVERIFIER=model.PLATFVERIFIER;
		entity.PLATFVERIFIERTIME=model.PLATFVERIFIERTIME;
		entity.VERIFYTIME=model.VERIFYTIME;
		entity.PLATFORMCODE=model.PLATFORMCODE;
		entity.PLATFORMNAME=model.PLATFORMNAME;
		entity.EXAMINERNAME=model.EXAMINERNAME;
		entity.EXAMINERCODETYPE=model.EXAMINERCODETYPE;
		entity.EXAMINERCODE=model.EXAMINERCODE;
		entity.ORGANIZATIONATTACHMENTCODE=model.ORGANIZATIONATTACHMENTCODE;
		entity.LICATTACHMENTCODE=model.LICATTACHMENTCODE;
		entity.TAXATTACHMENTCODE=model.TAXATTACHMENTCODE;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.CREATE_TIME=model.CREATE_TIME;
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
        public GeneralResult Add(T_EC2_TENDERAGENCYINFO model)
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
                    Delete(T_EC2_TENDERAGENCYINFO._.TENDERAGENCYCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_TENDERAGENCYINFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_TENDERAGENCYINFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDERAGENCYCODETYPE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.TENDERAGENCYCODETYPE.Contain(model.TENDERAGENCYCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERAGENCYCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.TENDERAGENCYCODE.Contain(model.TENDERAGENCYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERAGENCYNAME))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.TENDERAGENCYNAME.Contain(model.TENDERAGENCYNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ARTIFICIALPERSON))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.ARTIFICIALPERSON.Contain(model.ARTIFICIALPERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.ARTIFICIALPERSONCODETYPE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.ARTIFICIALPERSONCODETYPE.Contain(model.ARTIFICIALPERSONCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ARTIFICIALPERSONCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.ARTIFICIALPERSONCODE.Contain(model.ARTIFICIALPERSONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTNUMBER))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.CONTACTNUMBER.Contain(model.CONTACTNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRYREGION))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.COUNTRYREGION.Contain(model.COUNTRYREGION));
				}
				if(!string.IsNullOrWhiteSpace(model.UNITNATURE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.UNITNATURE.Contain(model.UNITNATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGIONCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.REGIONCODE.Contain(model.REGIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRYCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.INDUSTRYCODE.Contain(model.INDUSTRYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LICNUMBER))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.LICNUMBER.Contain(model.LICNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CACODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.CACODE.Contain(model.CACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TAXNUMBER))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.TAXNUMBER.Contain(model.TAXNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDITRATE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.CREDITRATE.Contain(model.CREDITRATE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENINGBANK))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.OPENINGBANK.Contain(model.OPENINGBANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASICACCOUNT))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.BASICACCOUNT.Contain(model.BASICACCOUNT));
				}
				if(model.REGCAPITAL!=null)
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.REGCAPITAL==(model.REGCAPITAL));
				}
				if(!string.IsNullOrWhiteSpace(model.REGCAPCURRENCY))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.REGCAPCURRENCY.Contain(model.REGCAPCURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.REGUNIT))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.REGUNIT.Contain(model.REGUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERNAME))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.INFOREPORTERNAME.Contain(model.INFOREPORTERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERCODETYPE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.INFOREPORTERCODETYPE.Contain(model.INFOREPORTERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.INFOREPORTERCODE.Contain(model.INFOREPORTERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERCONTACTNUMBER))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.INFOREPORTERCONTACTNUMBER.Contain(model.INFOREPORTERCONTACTNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTADDRESS))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.CONTACTADDRESS.Contain(model.CONTACTADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.ZIPCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.ZIPCODE.Contain(model.ZIPCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.EMAIL.Contain(model.EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.PARTICIPANTTYPE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.PARTICIPANTTYPE.Contain(model.PARTICIPANTTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFVERIFIER))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.PLATFVERIFIER.Contain(model.PLATFVERIFIER));
				}
				if(model.PLATFVERIFIERTIME!=null)
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.PLATFVERIFIERTIME==(model.PLATFVERIFIERTIME));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORMCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.PLATFORMCODE.Contain(model.PLATFORMCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORMNAME))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.PLATFORMNAME.Contain(model.PLATFORMNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGANIZATIONATTACHMENTCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.ORGANIZATIONATTACHMENTCODE.Contain(model.ORGANIZATIONATTACHMENTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LICATTACHMENTCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.LICATTACHMENTCODE.Contain(model.LICATTACHMENTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TAXATTACHMENTCODE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.TAXATTACHMENTCODE.Contain(model.TAXATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_TENDERAGENCYINFO._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}