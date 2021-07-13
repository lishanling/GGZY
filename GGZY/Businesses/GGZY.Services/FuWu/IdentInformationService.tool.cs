using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class IdentInformationService : BaseServiceT<IDENT_INFORMATION>
    {
        #region 接口实现
        
		public List<IDENT_INFORMATION> FindList(IDENT_INFORMATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<IDENT_INFORMATION> PageList(IDENT_INFORMATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, IDENT_INFORMATION._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(IDENT_INFORMATION._.ID == ID);
			
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
        public GeneralResult Edit(IDENT_INFORMATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is IDENT_INFORMATION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TEST_REPORT=model.TEST_REPORT;
		entity.TEST_ORGANIZETION=model.TEST_ORGANIZETION;
		entity.DETECTION_MECHANISM=model.DETECTION_MECHANISM;
		entity.CERTIFICATE=model.CERTIFICATE;
		entity.CERTIFICATE_IMAGE=model.CERTIFICATE_IMAGE;
		entity.CERTIFICATION_BODY=model.CERTIFICATION_BODY;
		entity.CERTIFICATION_NUM=model.CERTIFICATION_NUM;
		entity.CERTIFICATE_EXPIRATION=model.CERTIFICATE_EXPIRATION;
		entity.PATENT_CERTIFICATION=model.PATENT_CERTIFICATION;
		entity.PATENT_NUM=model.PATENT_NUM;
		entity.CERTIFICATION_AUTTHORITY=model.CERTIFICATION_AUTTHORITY;
		entity.CERTIFICATION_VALIDITY=model.CERTIFICATION_VALIDITY;
		entity.IMG=model.IMG;
		entity.CERTIFICATE_NAME=model.CERTIFICATE_NAME;
		entity.CERTIFICATE_LEVEL=model.CERTIFICATE_LEVEL;
		entity.CERTIFICATE_IMG=model.CERTIFICATE_IMG;
		entity.CERTIFICATION_AUTHORITY=model.CERTIFICATION_AUTHORITY;
		entity.CERTIFICATE_ISSUING=model.CERTIFICATE_ISSUING;
		entity.REMARKS=model.REMARKS;
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
        public GeneralResult Add(IDENT_INFORMATION model)
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
                    Delete(IDENT_INFORMATION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<IDENT_INFORMATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(IDENT_INFORMATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(IDENT_INFORMATION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_REPORT))
				{
				  condition.And(IDENT_INFORMATION._.TEST_REPORT.Contain(model.TEST_REPORT));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_ORGANIZETION))
				{
				  condition.And(IDENT_INFORMATION._.TEST_ORGANIZETION.Contain(model.TEST_ORGANIZETION));
				}
				if(!string.IsNullOrWhiteSpace(model.DETECTION_MECHANISM))
				{
				  condition.And(IDENT_INFORMATION._.DETECTION_MECHANISM.Contain(model.DETECTION_MECHANISM));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATE))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE.Contain(model.CERTIFICATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATE_IMAGE))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE_IMAGE.Contain(model.CERTIFICATE_IMAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATION_BODY))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATION_BODY.Contain(model.CERTIFICATION_BODY));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATION_NUM))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATION_NUM.Contain(model.CERTIFICATION_NUM));
				}
				if(model.CERTIFICATE_EXPIRATION!=null)
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE_EXPIRATION==(model.CERTIFICATE_EXPIRATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PATENT_CERTIFICATION))
				{
				  condition.And(IDENT_INFORMATION._.PATENT_CERTIFICATION.Contain(model.PATENT_CERTIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PATENT_NUM))
				{
				  condition.And(IDENT_INFORMATION._.PATENT_NUM.Contain(model.PATENT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATION_AUTTHORITY))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATION_AUTTHORITY.Contain(model.CERTIFICATION_AUTTHORITY));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATION_VALIDITY))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATION_VALIDITY.Contain(model.CERTIFICATION_VALIDITY));
				}
				if(!string.IsNullOrWhiteSpace(model.IMG))
				{
				  condition.And(IDENT_INFORMATION._.IMG.Contain(model.IMG));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATE_NAME))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE_NAME.Contain(model.CERTIFICATE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATE_LEVEL))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE_LEVEL.Contain(model.CERTIFICATE_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATE_IMG))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE_IMG.Contain(model.CERTIFICATE_IMG));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTIFICATION_AUTHORITY))
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATION_AUTHORITY.Contain(model.CERTIFICATION_AUTHORITY));
				}
				if(model.CERTIFICATE_ISSUING!=null)
				{
				  condition.And(IDENT_INFORMATION._.CERTIFICATE_ISSUING==(model.CERTIFICATE_ISSUING));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARKS))
				{
				  condition.And(IDENT_INFORMATION._.REMARKS.Contain(model.REMARKS));
				}
		return condition;
	}
        #endregion
    }
}