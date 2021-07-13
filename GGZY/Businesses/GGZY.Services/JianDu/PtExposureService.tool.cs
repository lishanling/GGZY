using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtExposureService : BaseServiceT<PT_EXPOSURE>
    {
        #region 接口实现
        
		public List<PT_EXPOSURE> FindList(PT_EXPOSURE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_EXPOSURE> PageList(PT_EXPOSURE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_EXPOSURE._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="NO"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string NO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(PT_EXPOSURE._.NO == NO);
			
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
        public GeneralResult Edit(PT_EXPOSURE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.NO);
	
	if(viewResult.Success  && viewResult.Data is PT_EXPOSURE entity)
	{		
		entity.Attach();
		entity.NO=model.NO;
		entity.ENTERPRISENAME=model.ENTERPRISENAME;
		entity.BUSINESSNO=model.BUSINESSNO;
		entity.LEGALREPRESENT=model.LEGALREPRESENT;
		entity.ILLEGAL=model.ILLEGAL;
		entity.DISHONESTYCONTENT=model.DISHONESTYCONTENT;
		entity.DISHONESTYDISCIPLINE=model.DISHONESTYDISCIPLINE;
		entity.TM=model.TM;
		entity.DISHONESTYTYPE=model.DISHONESTYTYPE;
		entity.BUSINESSADDRESS=model.BUSINESSADDRESS;
		entity.DEADLINE=model.DEADLINE;
		entity.LAWENFORCEMENTUNIT=model.LAWENFORCEMENTUNIT;
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
        public GeneralResult Add(PT_EXPOSURE model)
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
                    Delete(PT_EXPOSURE._.NO.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_EXPOSURE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_EXPOSURE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.NO))
				{
				  condition.And(PT_EXPOSURE._.NO.Contain(model.NO));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTERPRISENAME))
				{
				  condition.And(PT_EXPOSURE._.ENTERPRISENAME.Contain(model.ENTERPRISENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSNO))
				{
				  condition.And(PT_EXPOSURE._.BUSINESSNO.Contain(model.BUSINESSNO));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALREPRESENT))
				{
				  condition.And(PT_EXPOSURE._.LEGALREPRESENT.Contain(model.LEGALREPRESENT));
				}
				if(!string.IsNullOrWhiteSpace(model.ILLEGAL))
				{
				  condition.And(PT_EXPOSURE._.ILLEGAL.Contain(model.ILLEGAL));
				}
				if(!string.IsNullOrWhiteSpace(model.DISHONESTYCONTENT))
				{
				  condition.And(PT_EXPOSURE._.DISHONESTYCONTENT.Contain(model.DISHONESTYCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DISHONESTYDISCIPLINE))
				{
				  condition.And(PT_EXPOSURE._.DISHONESTYDISCIPLINE.Contain(model.DISHONESTYDISCIPLINE));
				}
				if(model.TM!=null)
				{
				  condition.And(PT_EXPOSURE._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.DISHONESTYTYPE))
				{
				  condition.And(PT_EXPOSURE._.DISHONESTYTYPE.Contain(model.DISHONESTYTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSADDRESS))
				{
				  condition.And(PT_EXPOSURE._.BUSINESSADDRESS.Contain(model.BUSINESSADDRESS));
				}
				if(model.DEADLINE!=null)
				{
				  condition.And(PT_EXPOSURE._.DEADLINE==(model.DEADLINE));
				}
				if(!string.IsNullOrWhiteSpace(model.LAWENFORCEMENTUNIT))
				{
				  condition.And(PT_EXPOSURE._.LAWENFORCEMENTUNIT.Contain(model.LAWENFORCEMENTUNIT));
				}
		return condition;
	}
        #endregion
    }
}