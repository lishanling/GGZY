using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtPractitionerachievementService : BaseServiceT<T_ZT_PRACTITIONERACHIEVEMENT>
    {
        #region 接口实现
        
		public List<T_ZT_PRACTITIONERACHIEVEMENT> FindList(T_ZT_PRACTITIONERACHIEVEMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_PRACTITIONERACHIEVEMENT> PageList(T_ZT_PRACTITIONERACHIEVEMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_PRACTITIONERACHIEVEMENT._.IDCARDNO.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="IDCARDNO">人员身份证件号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string IDCARDNO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.IDCARDNO == IDCARDNO);
			
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
        public GeneralResult Edit(T_ZT_PRACTITIONERACHIEVEMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.IDCARDNO);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_PRACTITIONERACHIEVEMENT entity)
	{		
		entity.Attach();
		entity.IDCARDNO=model.IDCARDNO;
		entity.IDCARDTYPE=model.IDCARDTYPE;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.TENDERPROJECTNAME=model.TENDERPROJECTNAME;
		entity.SECTIONNO=model.SECTIONNO;
		entity.SECTIONNAME=model.SECTIONNAME;
		entity.OWNERNO=model.OWNERNO;
		entity.OWNERNAME=model.OWNERNAME;
		entity.CONTRACTAMOUNT=model.CONTRACTAMOUNT;
		entity.TRADETYPE=model.TRADETYPE;
		entity.SETTLEAMOUNT=model.SETTLEAMOUNT;
		entity.CURRENCY=model.CURRENCY;
		entity.MONEYUNIT=model.MONEYUNIT;
		entity.CONTRACTSIGNDATE=model.CONTRACTSIGNDATE;
		entity.CONTRACTFINISHDATE=model.CONTRACTFINISHDATE;
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
        public GeneralResult Add(T_ZT_PRACTITIONERACHIEVEMENT model)
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
                    Delete(T_ZT_PRACTITIONERACHIEVEMENT._.IDCARDNO.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_PRACTITIONERACHIEVEMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_PRACTITIONERACHIEVEMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.IDCARDNO))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.IDCARDNO.Contain(model.IDCARDNO));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARDTYPE))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.IDCARDTYPE.Contain(model.IDCARDTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTNAME))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.TENDERPROJECTNAME.Contain(model.TENDERPROJECTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTIONNO))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.SECTIONNO.Contain(model.SECTIONNO));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTIONNAME))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.SECTIONNAME.Contain(model.SECTIONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNERNO))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.OWNERNO.Contain(model.OWNERNO));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNERNAME))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.OWNERNAME.Contain(model.OWNERNAME));
				}
				if(model.CONTRACTAMOUNT!=null)
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.CONTRACTAMOUNT==(model.CONTRACTAMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADETYPE))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.TRADETYPE.Contain(model.TRADETYPE));
				}
				if(model.SETTLEAMOUNT!=null)
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.SETTLEAMOUNT==(model.SETTLEAMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.CURRENCY.Contain(model.CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.MONEYUNIT))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.MONEYUNIT.Contain(model.MONEYUNIT));
				}
				if(model.CONTRACTSIGNDATE!=null)
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.CONTRACTSIGNDATE==(model.CONTRACTSIGNDATE));
				}
				if(model.CONTRACTFINISHDATE!=null)
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.CONTRACTFINISHDATE==(model.CONTRACTFINISHDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
				if(model.DATATIMESTAMP!=null)
				{
				  condition.And(T_ZT_PRACTITIONERACHIEVEMENT._.DATATIMESTAMP==(model.DATATIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}