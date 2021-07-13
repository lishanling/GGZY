using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtTransferService : BaseServiceT<T_ZT_TRANSFER>
    {
        #region 接口实现
        
		public List<T_ZT_TRANSFER> FindList(T_ZT_TRANSFER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_TRANSFER> PageList(T_ZT_TRANSFER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_TRANSFER._.LEGALCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="LEGALCODE">主体代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string LEGALCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_TRANSFER._.LEGALCODE == LEGALCODE);
			
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
        public GeneralResult Edit(T_ZT_TRANSFER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.LEGALCODE);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_TRANSFER entity)
	{		
		entity.Attach();
		entity.LEGALCODE=model.LEGALCODE;
		entity.NATIONASSET=model.NATIONASSET;
		entity.CENTRALENTERPRISE=model.CENTRALENTERPRISE;
		entity.MGRTYPE=model.MGRTYPE;
		entity.MGRORGNAME=model.MGRORGNAME;
		entity.MGRNAME=model.MGRNAME;
		entity.MGRCODE=model.MGRCODE;
		entity.CREATETIME=model.CREATETIME;
		entity.ECONOMYTYPE=model.ECONOMYTYPE;
		entity.COMPANYSCALE=model.COMPANYSCALE;
		entity.COMPANYSCOPE=model.COMPANYSCOPE;
		entity.EMPLOYEENUMBER=model.EMPLOYEENUMBER;
		entity.CUSTOMDEFINITIONDATAITEM=model.CUSTOMDEFINITIONDATAITEM;
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
        public GeneralResult Add(T_ZT_TRANSFER model)
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
                    Delete(T_ZT_TRANSFER._.LEGALCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_TRANSFER> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_TRANSFER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.LEGALCODE))
				{
				  condition.And(T_ZT_TRANSFER._.LEGALCODE.Contain(model.LEGALCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NATIONASSET))
				{
				  condition.And(T_ZT_TRANSFER._.NATIONASSET.Contain(model.NATIONASSET));
				}
				if(!string.IsNullOrWhiteSpace(model.CENTRALENTERPRISE))
				{
				  condition.And(T_ZT_TRANSFER._.CENTRALENTERPRISE.Contain(model.CENTRALENTERPRISE));
				}
				if(!string.IsNullOrWhiteSpace(model.MGRTYPE))
				{
				  condition.And(T_ZT_TRANSFER._.MGRTYPE.Contain(model.MGRTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.MGRORGNAME))
				{
				  condition.And(T_ZT_TRANSFER._.MGRORGNAME.Contain(model.MGRORGNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MGRNAME))
				{
				  condition.And(T_ZT_TRANSFER._.MGRNAME.Contain(model.MGRNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MGRCODE))
				{
				  condition.And(T_ZT_TRANSFER._.MGRCODE.Contain(model.MGRCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATETIME))
				{
				  condition.And(T_ZT_TRANSFER._.CREATETIME.Contain(model.CREATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ECONOMYTYPE))
				{
				  condition.And(T_ZT_TRANSFER._.ECONOMYTYPE.Contain(model.ECONOMYTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYSCALE))
				{
				  condition.And(T_ZT_TRANSFER._.COMPANYSCALE.Contain(model.COMPANYSCALE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYSCOPE))
				{
				  condition.And(T_ZT_TRANSFER._.COMPANYSCOPE.Contain(model.COMPANYSCOPE));
				}
				if(model.EMPLOYEENUMBER!=null)
				{
				  condition.And(T_ZT_TRANSFER._.EMPLOYEENUMBER==(model.EMPLOYEENUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CUSTOMDEFINITIONDATAITEM))
				{
				  condition.And(T_ZT_TRANSFER._.CUSTOMDEFINITIONDATAITEM.Contain(model.CUSTOMDEFINITIONDATAITEM));
				}
		return condition;
	}
        #endregion
    }
}