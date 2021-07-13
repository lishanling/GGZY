using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CainfoService : BaseServiceT<CAINFO>
    {
        #region 接口实现
        
		public List<CAINFO> FindList(CAINFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<CAINFO> PageList(CAINFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, CAINFO._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(CAINFO._.ID == ID);
			
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
        public GeneralResult Edit(CAINFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is CAINFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SGD_GET_CERT_VERSION=model.SGD_GET_CERT_VERSION;
		entity.SGD_GET_CERT_SERIAL=model.SGD_GET_CERT_SERIAL;
		entity.SGD_GET_CERT_SIGNALG=model.SGD_GET_CERT_SIGNALG;
		entity.SGD_GET_CERT_ISSUER_C=model.SGD_GET_CERT_ISSUER_C;
		entity.SGD_GET_CERT_ISSUER_O=model.SGD_GET_CERT_ISSUER_O;
		entity.SGD_GET_CERT_ISSUER_OU=model.SGD_GET_CERT_ISSUER_OU;
		entity.SGD_GET_CERT_ISSUER_S=model.SGD_GET_CERT_ISSUER_S;
		entity.SGD_GET_CERT_ISSUER_CN=model.SGD_GET_CERT_ISSUER_CN;
		entity.SGD_GET_CERT_ISSUER_L=model.SGD_GET_CERT_ISSUER_L;
		entity.SGD_GET_CERT_ISSUER_E=model.SGD_GET_CERT_ISSUER_E;
		entity.SGD_GET_CERT_NOTBEFORE=model.SGD_GET_CERT_NOTBEFORE;
		entity.SGD_GET_CERT_AFTER=model.SGD_GET_CERT_AFTER;
		entity.SGD_GET_CERT_SUBJECT_C=model.SGD_GET_CERT_SUBJECT_C;
		entity.SGD_GET_CERT_SUBJECT_O=model.SGD_GET_CERT_SUBJECT_O;
		entity.SGD_GET_CERT_SUBJECT_OU=model.SGD_GET_CERT_SUBJECT_OU;
		entity.SGD_GET_CERT_SUBJECT_S=model.SGD_GET_CERT_SUBJECT_S;
		entity.SGD_GET_CERT_SUBJECT_CN=model.SGD_GET_CERT_SUBJECT_CN;
		entity.SGD_GET_CERT_SUBJECT_L=model.SGD_GET_CERT_SUBJECT_L;
		entity.SGD_GET_CERT_SUBJECT_E=model.SGD_GET_CERT_SUBJECT_E;
		entity.SGD_GET_CERT_ISSUER_DN=model.SGD_GET_CERT_ISSUER_DN;
		entity.SGD_GET_CERT_SUBJECT_DN=model.SGD_GET_CERT_SUBJECT_DN;
		entity.SGD_GET_CERT_DER_PUBKEY=model.SGD_GET_CERT_DER_PUBKEY;
		entity.SGD_GET_CERT_DER_EXTENSIONS=model.SGD_GET_CERT_DER_EXTENSIONS;
		entity.SGD_EXT_AUTHORITYKEYIDENTIFIER=model.SGD_EXT_AUTHORITYKEYIDENTIFIER;
		entity.SGD_EXT_SUBJECTKEYIDENTIFIER=model.SGD_EXT_SUBJECTKEYIDENTIFIER;
		entity.SGD_EXT_KEYUSAGE=model.SGD_EXT_KEYUSAGE;
		entity.SGD_EXT_PRIVATEKEYUSAGEPERIO=model.SGD_EXT_PRIVATEKEYUSAGEPERIO;
		entity.SGD_EXT_CERTIFICATEPOLICIES=model.SGD_EXT_CERTIFICATEPOLICIES;
		entity.SGD_EXT_POLICYMAPPINGS=model.SGD_EXT_POLICYMAPPINGS;
		entity.SGD_EXT_BASICCONSTRAINTS=model.SGD_EXT_BASICCONSTRAINTS;
		entity.SGD_EXT_POLICYCONSTRAINTS=model.SGD_EXT_POLICYCONSTRAINTS;
		entity.SGD_EXT_EXTKEYUSAGE=model.SGD_EXT_EXTKEYUSAGE;
		entity.SGD_EXT_CRLDISTRIBUTIONPO=model.SGD_EXT_CRLDISTRIBUTIONPO;
		entity.SGD_EXT_NETSCAPE_CERT_TYPE=model.SGD_EXT_NETSCAPE_CERT_TYPE;
		entity.SGD_EXT_CERT_UNIQUEID=model.SGD_EXT_CERT_UNIQUEID;
		entity.SGD_EXT_IDENTIFYCARDNUMBER=model.SGD_EXT_IDENTIFYCARDNUMBER;
		entity.SGD_EXT_INURANCENUMBER=model.SGD_EXT_INURANCENUMBER;
		entity.SGD_EXT_ICREGISTRATIONNUMBER=model.SGD_EXT_ICREGISTRATIONNUMBER;
		entity.SGD_EXT_ORGANIZATIONCODE=model.SGD_EXT_ORGANIZATIONCODE;
		entity.SGD_EXT_TAXATIONNUMBER=model.SGD_EXT_TAXATIONNUMBER;
		entity.LOGIN_TM=model.LOGIN_TM;
		entity.USER_ID=model.USER_ID;
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
        public GeneralResult Add(CAINFO model)
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
                    Delete(CAINFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<CAINFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(CAINFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(CAINFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_VERSION))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_VERSION.Contain(model.SGD_GET_CERT_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SERIAL))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SERIAL.Contain(model.SGD_GET_CERT_SERIAL));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SIGNALG))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SIGNALG.Contain(model.SGD_GET_CERT_SIGNALG));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_C))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_C.Contain(model.SGD_GET_CERT_ISSUER_C));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_O))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_O.Contain(model.SGD_GET_CERT_ISSUER_O));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_OU))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_OU.Contain(model.SGD_GET_CERT_ISSUER_OU));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_S))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_S.Contain(model.SGD_GET_CERT_ISSUER_S));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_CN))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_CN.Contain(model.SGD_GET_CERT_ISSUER_CN));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_L))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_L.Contain(model.SGD_GET_CERT_ISSUER_L));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_E))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_E.Contain(model.SGD_GET_CERT_ISSUER_E));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_NOTBEFORE))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_NOTBEFORE.Contain(model.SGD_GET_CERT_NOTBEFORE));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_AFTER))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_AFTER.Contain(model.SGD_GET_CERT_AFTER));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_C))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_C.Contain(model.SGD_GET_CERT_SUBJECT_C));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_O))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_O.Contain(model.SGD_GET_CERT_SUBJECT_O));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_OU))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_OU.Contain(model.SGD_GET_CERT_SUBJECT_OU));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_S))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_S.Contain(model.SGD_GET_CERT_SUBJECT_S));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_CN))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_CN.Contain(model.SGD_GET_CERT_SUBJECT_CN));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_L))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_L.Contain(model.SGD_GET_CERT_SUBJECT_L));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_E))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_E.Contain(model.SGD_GET_CERT_SUBJECT_E));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_ISSUER_DN))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_ISSUER_DN.Contain(model.SGD_GET_CERT_ISSUER_DN));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_SUBJECT_DN))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_SUBJECT_DN.Contain(model.SGD_GET_CERT_SUBJECT_DN));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_DER_PUBKEY))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_DER_PUBKEY.Contain(model.SGD_GET_CERT_DER_PUBKEY));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_GET_CERT_DER_EXTENSIONS))
				{
				  condition.And(CAINFO._.SGD_GET_CERT_DER_EXTENSIONS.Contain(model.SGD_GET_CERT_DER_EXTENSIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_AUTHORITYKEYIDENTIFIER))
				{
				  condition.And(CAINFO._.SGD_EXT_AUTHORITYKEYIDENTIFIER.Contain(model.SGD_EXT_AUTHORITYKEYIDENTIFIER));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_SUBJECTKEYIDENTIFIER))
				{
				  condition.And(CAINFO._.SGD_EXT_SUBJECTKEYIDENTIFIER.Contain(model.SGD_EXT_SUBJECTKEYIDENTIFIER));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_KEYUSAGE))
				{
				  condition.And(CAINFO._.SGD_EXT_KEYUSAGE.Contain(model.SGD_EXT_KEYUSAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_PRIVATEKEYUSAGEPERIO))
				{
				  condition.And(CAINFO._.SGD_EXT_PRIVATEKEYUSAGEPERIO.Contain(model.SGD_EXT_PRIVATEKEYUSAGEPERIO));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_CERTIFICATEPOLICIES))
				{
				  condition.And(CAINFO._.SGD_EXT_CERTIFICATEPOLICIES.Contain(model.SGD_EXT_CERTIFICATEPOLICIES));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_POLICYMAPPINGS))
				{
				  condition.And(CAINFO._.SGD_EXT_POLICYMAPPINGS.Contain(model.SGD_EXT_POLICYMAPPINGS));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_BASICCONSTRAINTS))
				{
				  condition.And(CAINFO._.SGD_EXT_BASICCONSTRAINTS.Contain(model.SGD_EXT_BASICCONSTRAINTS));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_POLICYCONSTRAINTS))
				{
				  condition.And(CAINFO._.SGD_EXT_POLICYCONSTRAINTS.Contain(model.SGD_EXT_POLICYCONSTRAINTS));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_EXTKEYUSAGE))
				{
				  condition.And(CAINFO._.SGD_EXT_EXTKEYUSAGE.Contain(model.SGD_EXT_EXTKEYUSAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_CRLDISTRIBUTIONPO))
				{
				  condition.And(CAINFO._.SGD_EXT_CRLDISTRIBUTIONPO.Contain(model.SGD_EXT_CRLDISTRIBUTIONPO));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_NETSCAPE_CERT_TYPE))
				{
				  condition.And(CAINFO._.SGD_EXT_NETSCAPE_CERT_TYPE.Contain(model.SGD_EXT_NETSCAPE_CERT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_CERT_UNIQUEID))
				{
				  condition.And(CAINFO._.SGD_EXT_CERT_UNIQUEID.Contain(model.SGD_EXT_CERT_UNIQUEID));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_IDENTIFYCARDNUMBER))
				{
				  condition.And(CAINFO._.SGD_EXT_IDENTIFYCARDNUMBER.Contain(model.SGD_EXT_IDENTIFYCARDNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_INURANCENUMBER))
				{
				  condition.And(CAINFO._.SGD_EXT_INURANCENUMBER.Contain(model.SGD_EXT_INURANCENUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_ICREGISTRATIONNUMBER))
				{
				  condition.And(CAINFO._.SGD_EXT_ICREGISTRATIONNUMBER.Contain(model.SGD_EXT_ICREGISTRATIONNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_ORGANIZATIONCODE))
				{
				  condition.And(CAINFO._.SGD_EXT_ORGANIZATIONCODE.Contain(model.SGD_EXT_ORGANIZATIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SGD_EXT_TAXATIONNUMBER))
				{
				  condition.And(CAINFO._.SGD_EXT_TAXATIONNUMBER.Contain(model.SGD_EXT_TAXATIONNUMBER));
				}
				if(model.LOGIN_TM!=null)
				{
				  condition.And(CAINFO._.LOGIN_TM==(model.LOGIN_TM));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(CAINFO._.USER_ID==(model.USER_ID));
				}
		return condition;
	}
        #endregion
    }
}