using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtPractitionerService : BaseServiceT<T_ZT_PRACTITIONER>
    {
        #region 接口实现
        
		public List<T_ZT_PRACTITIONER> FindList(T_ZT_PRACTITIONER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_PRACTITIONER> PageList(T_ZT_PRACTITIONER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_PRACTITIONER._.IDCARD.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="IDCARD">身份证件号码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string IDCARD)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_PRACTITIONER._.IDCARD == IDCARD);
			
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
        public GeneralResult Edit(T_ZT_PRACTITIONER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.IDCARD);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_PRACTITIONER entity)
	{		
		entity.Attach();
		entity.IDCARD=model.IDCARD;
		entity.IDCARDTYPE=model.IDCARDTYPE;
		entity.PERSONNAME=model.PERSONNAME;
		entity.GENDER=model.GENDER;
		entity.BIRTHDATE=model.BIRTHDATE;
		entity.REGIONCODE=model.REGIONCODE;
		entity.PERSONEDU=model.PERSONEDU;
		entity.PERSONPHONE=model.PERSONPHONE;
		entity.UNITCODE=model.UNITCODE;
		entity.UNITNAME=model.UNITNAME;
		entity.ONJOB=model.ONJOB;
		entity.JOB=model.JOB;
		entity.TECHTITLE=model.TECHTITLE;
		entity.WORKSTARTDATE=model.WORKSTARTDATE;
		entity.WORKINGEXPERIENCE=model.WORKINGEXPERIENCE;
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
        public GeneralResult Add(T_ZT_PRACTITIONER model)
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
                    Delete(T_ZT_PRACTITIONER._.IDCARD.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_PRACTITIONER> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_PRACTITIONER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.IDCARD))
				{
				  condition.And(T_ZT_PRACTITIONER._.IDCARD.Contain(model.IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARDTYPE))
				{
				  condition.And(T_ZT_PRACTITIONER._.IDCARDTYPE.Contain(model.IDCARDTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSONNAME))
				{
				  condition.And(T_ZT_PRACTITIONER._.PERSONNAME.Contain(model.PERSONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GENDER))
				{
				  condition.And(T_ZT_PRACTITIONER._.GENDER.Contain(model.GENDER));
				}
				if(model.BIRTHDATE!=null)
				{
				  condition.And(T_ZT_PRACTITIONER._.BIRTHDATE==(model.BIRTHDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGIONCODE))
				{
				  condition.And(T_ZT_PRACTITIONER._.REGIONCODE.Contain(model.REGIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSONEDU))
				{
				  condition.And(T_ZT_PRACTITIONER._.PERSONEDU.Contain(model.PERSONEDU));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSONPHONE))
				{
				  condition.And(T_ZT_PRACTITIONER._.PERSONPHONE.Contain(model.PERSONPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNITCODE))
				{
				  condition.And(T_ZT_PRACTITIONER._.UNITCODE.Contain(model.UNITCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNITNAME))
				{
				  condition.And(T_ZT_PRACTITIONER._.UNITNAME.Contain(model.UNITNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ONJOB))
				{
				  condition.And(T_ZT_PRACTITIONER._.ONJOB.Contain(model.ONJOB));
				}
				if(!string.IsNullOrWhiteSpace(model.JOB))
				{
				  condition.And(T_ZT_PRACTITIONER._.JOB.Contain(model.JOB));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHTITLE))
				{
				  condition.And(T_ZT_PRACTITIONER._.TECHTITLE.Contain(model.TECHTITLE));
				}
				if(model.WORKSTARTDATE!=null)
				{
				  condition.And(T_ZT_PRACTITIONER._.WORKSTARTDATE==(model.WORKSTARTDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.WORKINGEXPERIENCE))
				{
				  condition.And(T_ZT_PRACTITIONER._.WORKINGEXPERIENCE.Contain(model.WORKINGEXPERIENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_ZT_PRACTITIONER._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
				if(model.DATATIMESTAMP!=null)
				{
				  condition.And(T_ZT_PRACTITIONER._.DATATIMESTAMP==(model.DATATIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}