using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TCaAccessService : BaseServiceT<T_CA_ACCESS>
    {
        #region 接口实现
        
		public List<T_CA_ACCESS> FindList(T_CA_ACCESS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_CA_ACCESS> PageList(T_CA_ACCESS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_CA_ACCESS._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_CA_ACCESS._.ID == ID);
			
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
        public GeneralResult Edit(T_CA_ACCESS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_CA_ACCESS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SQDW=model.SQDW;
		entity.SQDW_CODE=model.SQDW_CODE;
		entity.CPMC=model.CPMC;
		entity.CPGS=model.CPGS;
		entity.CPGS_CODE=model.CPGS_CODE;
		entity.LXR_NAME=model.LXR_NAME;
		entity.LXR_PHONE=model.LXR_PHONE;
		entity.LXR_EMAIL=model.LXR_EMAIL;
		entity.CA_FILES=model.CA_FILES;
		entity.CA_TEST_FILES=model.CA_TEST_FILES;
		entity.OSCP=model.OSCP;
		entity.CRL_TYPE=model.CRL_TYPE;
		entity.HTTP_URL=model.HTTP_URL;
		entity.LDAP_URL=model.LDAP_URL;
		entity.LDAP_PORT=model.LDAP_PORT;
		entity.LDAP_ROOT=model.LDAP_ROOT;
		entity.CRL_PATH=model.CRL_PATH;
		entity.CRL_ATTRIBUTES=model.CRL_ATTRIBUTES;
		entity.LDAP_NAME=model.LDAP_NAME;
		entity.LDAP_PWD=model.LDAP_PWD;
		entity.CLMC=model.CLMC;
		entity.CREATE_TM=model.CREATE_TM;
		entity.NO=model.NO;
		entity.STATUS=model.STATUS;
		entity.STOP_REMARK=model.STOP_REMARK;
		entity.STOP_FILE=model.STOP_FILE;
		entity.STOP_TM=model.STOP_TM;
		entity.CLHY_STATUS=model.CLHY_STATUS;
		entity.CLHY_REMARK=model.CLHY_REMARK;
		entity.CLHY_PEOPLE=model.CLHY_PEOPLE;
		entity.CLHY_TM=model.CLHY_TM;
		entity.ZGDW_STATUS=model.ZGDW_STATUS;
		entity.ZGDW_REMARK=model.ZGDW_REMARK;
		entity.ZGDW_PEOPLE=model.ZGDW_PEOPLE;
		entity.ZGDW_TM=model.ZGDW_TM;
		entity.CLHY_FILES=model.CLHY_FILES;
		entity.ZGDW_FILES=model.ZGDW_FILES;
		entity.DJCG_STATUS=model.DJCG_STATUS;
		entity.DJCG_REMARK=model.DJCG_REMARK;
		entity.DJCG_PEOPLE=model.DJCG_PEOPLE;
		entity.DJCG_TM=model.DJCG_TM;
		entity.DJCG_FILES=model.DJCG_FILES;
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
        public GeneralResult Add(T_CA_ACCESS model)
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
                    Delete(T_CA_ACCESS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_CA_ACCESS> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_CA_ACCESS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_CA_ACCESS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SQDW))
				{
				  condition.And(T_CA_ACCESS._.SQDW.Contain(model.SQDW));
				}
				if(!string.IsNullOrWhiteSpace(model.SQDW_CODE))
				{
				  condition.And(T_CA_ACCESS._.SQDW_CODE.Contain(model.SQDW_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CPMC))
				{
				  condition.And(T_CA_ACCESS._.CPMC.Contain(model.CPMC));
				}
				if(!string.IsNullOrWhiteSpace(model.CPGS))
				{
				  condition.And(T_CA_ACCESS._.CPGS.Contain(model.CPGS));
				}
				if(!string.IsNullOrWhiteSpace(model.CPGS_CODE))
				{
				  condition.And(T_CA_ACCESS._.CPGS_CODE.Contain(model.CPGS_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR_NAME))
				{
				  condition.And(T_CA_ACCESS._.LXR_NAME.Contain(model.LXR_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR_PHONE))
				{
				  condition.And(T_CA_ACCESS._.LXR_PHONE.Contain(model.LXR_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR_EMAIL))
				{
				  condition.And(T_CA_ACCESS._.LXR_EMAIL.Contain(model.LXR_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_FILES))
				{
				  condition.And(T_CA_ACCESS._.CA_FILES.Contain(model.CA_FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_TEST_FILES))
				{
				  condition.And(T_CA_ACCESS._.CA_TEST_FILES.Contain(model.CA_TEST_FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.OSCP))
				{
				  condition.And(T_CA_ACCESS._.OSCP.Contain(model.OSCP));
				}
				if(!string.IsNullOrWhiteSpace(model.CRL_TYPE))
				{
				  condition.And(T_CA_ACCESS._.CRL_TYPE.Contain(model.CRL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.HTTP_URL))
				{
				  condition.And(T_CA_ACCESS._.HTTP_URL.Contain(model.HTTP_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.LDAP_URL))
				{
				  condition.And(T_CA_ACCESS._.LDAP_URL.Contain(model.LDAP_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.LDAP_PORT))
				{
				  condition.And(T_CA_ACCESS._.LDAP_PORT.Contain(model.LDAP_PORT));
				}
				if(!string.IsNullOrWhiteSpace(model.LDAP_ROOT))
				{
				  condition.And(T_CA_ACCESS._.LDAP_ROOT.Contain(model.LDAP_ROOT));
				}
				if(!string.IsNullOrWhiteSpace(model.CRL_PATH))
				{
				  condition.And(T_CA_ACCESS._.CRL_PATH.Contain(model.CRL_PATH));
				}
				if(!string.IsNullOrWhiteSpace(model.CRL_ATTRIBUTES))
				{
				  condition.And(T_CA_ACCESS._.CRL_ATTRIBUTES.Contain(model.CRL_ATTRIBUTES));
				}
				if(!string.IsNullOrWhiteSpace(model.LDAP_NAME))
				{
				  condition.And(T_CA_ACCESS._.LDAP_NAME.Contain(model.LDAP_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LDAP_PWD))
				{
				  condition.And(T_CA_ACCESS._.LDAP_PWD.Contain(model.LDAP_PWD));
				}
				if(!string.IsNullOrWhiteSpace(model.CLMC))
				{
				  condition.And(T_CA_ACCESS._.CLMC.Contain(model.CLMC));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_CA_ACCESS._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.NO))
				{
				  condition.And(T_CA_ACCESS._.NO.Contain(model.NO));
				}
				if(model.STATUS!=null)
				{
				  condition.And(T_CA_ACCESS._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.STOP_REMARK))
				{
				  condition.And(T_CA_ACCESS._.STOP_REMARK.Contain(model.STOP_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.STOP_FILE))
				{
				  condition.And(T_CA_ACCESS._.STOP_FILE.Contain(model.STOP_FILE));
				}
				if(model.STOP_TM!=null)
				{
				  condition.And(T_CA_ACCESS._.STOP_TM==(model.STOP_TM));
				}
				if(model.CLHY_STATUS!=null)
				{
				  condition.And(T_CA_ACCESS._.CLHY_STATUS==(model.CLHY_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLHY_REMARK))
				{
				  condition.And(T_CA_ACCESS._.CLHY_REMARK.Contain(model.CLHY_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.CLHY_PEOPLE))
				{
				  condition.And(T_CA_ACCESS._.CLHY_PEOPLE.Contain(model.CLHY_PEOPLE));
				}
				if(model.CLHY_TM!=null)
				{
				  condition.And(T_CA_ACCESS._.CLHY_TM==(model.CLHY_TM));
				}
				if(model.ZGDW_STATUS!=null)
				{
				  condition.And(T_CA_ACCESS._.ZGDW_STATUS==(model.ZGDW_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.ZGDW_REMARK))
				{
				  condition.And(T_CA_ACCESS._.ZGDW_REMARK.Contain(model.ZGDW_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.ZGDW_PEOPLE))
				{
				  condition.And(T_CA_ACCESS._.ZGDW_PEOPLE.Contain(model.ZGDW_PEOPLE));
				}
				if(model.ZGDW_TM!=null)
				{
				  condition.And(T_CA_ACCESS._.ZGDW_TM==(model.ZGDW_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CLHY_FILES))
				{
				  condition.And(T_CA_ACCESS._.CLHY_FILES.Contain(model.CLHY_FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.ZGDW_FILES))
				{
				  condition.And(T_CA_ACCESS._.ZGDW_FILES.Contain(model.ZGDW_FILES));
				}
				if(model.DJCG_STATUS!=null)
				{
				  condition.And(T_CA_ACCESS._.DJCG_STATUS==(model.DJCG_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.DJCG_REMARK))
				{
				  condition.And(T_CA_ACCESS._.DJCG_REMARK.Contain(model.DJCG_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.DJCG_PEOPLE))
				{
				  condition.And(T_CA_ACCESS._.DJCG_PEOPLE.Contain(model.DJCG_PEOPLE));
				}
				if(model.DJCG_TM!=null)
				{
				  condition.And(T_CA_ACCESS._.DJCG_TM==(model.DJCG_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.DJCG_FILES))
				{
				  condition.And(T_CA_ACCESS._.DJCG_FILES.Contain(model.DJCG_FILES));
				}
		return condition;
	}
        #endregion
    }
}