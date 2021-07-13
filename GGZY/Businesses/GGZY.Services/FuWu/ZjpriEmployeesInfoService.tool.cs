using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriEmployeesInfoService : BaseServiceT<ZJPRI_EMPLOYEES_INFO>
    {
        #region 接口实现
        
		public List<ZJPRI_EMPLOYEES_INFO> FindList(ZJPRI_EMPLOYEES_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_EMPLOYEES_INFO> PageList(ZJPRI_EMPLOYEES_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_EMPLOYEES_INFO._.PERSONID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="PERSONID">人员ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? PERSONID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_EMPLOYEES_INFO._.PERSONID == PERSONID);
			
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
        public GeneralResult Edit(ZJPRI_EMPLOYEES_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.PERSONID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_EMPLOYEES_INFO entity)
	{		
		entity.Attach();
		entity.PERSONID=model.PERSONID;
		entity.NAME=model.NAME;
		entity.SEX=model.SEX;
		entity.BIRTHDAY=model.BIRTHDAY;
		entity.IDENTITYCARDTYPE=model.IDENTITYCARDTYPE;
		entity.IDENTITYCARDNUMBER=model.IDENTITYCARDNUMBER;
		entity.HIGHESTEDUCATION=model.HIGHESTEDUCATION;
		entity.TELEPHONE=model.TELEPHONE;
		entity.MOBILEPHONE=model.MOBILEPHONE;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
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
        public GeneralResult Add(ZJPRI_EMPLOYEES_INFO model)
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
                    Delete(ZJPRI_EMPLOYEES_INFO._.PERSONID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_EMPLOYEES_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_EMPLOYEES_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.PERSONID!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.PERSONID==(model.PERSONID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SEX))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.SEX.Contain(model.SEX));
				}
				if(model.BIRTHDAY!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.BIRTHDAY==(model.BIRTHDAY));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTITYCARDTYPE))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.IDENTITYCARDTYPE.Contain(model.IDENTITYCARDTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTITYCARDNUMBER))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.IDENTITYCARDNUMBER.Contain(model.IDENTITYCARDNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.HIGHESTEDUCATION))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.HIGHESTEDUCATION.Contain(model.HIGHESTEDUCATION));
				}
				if(!string.IsNullOrWhiteSpace(model.TELEPHONE))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.TELEPHONE.Contain(model.TELEPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.MOBILEPHONE))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.MOBILEPHONE.Contain(model.MOBILEPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_EMPLOYEES_INFO._.VERSION.Contain(model.VERSION));
				}
		return condition;
	}
        #endregion
    }
}