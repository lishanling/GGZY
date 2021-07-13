using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DbSystemService : BaseServiceT<DB_SYSTEM>
    {
        #region 接口实现
        
		public List<DB_SYSTEM> FindList(DB_SYSTEM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DB_SYSTEM> PageList(DB_SYSTEM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DB_SYSTEM._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DB_SYSTEM._.ID == ID);
			
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
        public GeneralResult Edit(DB_SYSTEM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is DB_SYSTEM entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.C_CODE=model.C_CODE;
		entity.BU_CODE=model.BU_CODE;
		entity.F_NATURE=model.F_NATURE;
		entity.F_TYPE=model.F_TYPE;
		entity.SO_INDI=model.SO_INDI;
		entity.P_TYPE=model.P_TYPE;
		entity.S_METHOD=model.S_METHOD;
		entity.U_APPID=model.U_APPID;
		entity.U_APP=model.U_APP;
		entity.APP_DATE=model.APP_DATE;
		entity.APP_AOM=model.APP_AOM;
		entity.E_PERID=model.E_PERID;
		entity.E_PER=model.E_PER;
		entity.E_DATE=model.E_DATE;
		entity.U_AUDITORID=model.U_AUDITORID;
		entity.U_AUDITOR=model.U_AUDITOR;
		entity.U_CHECK_DATE=model.U_CHECK_DATE;
		entity.U_SENDERID=model.U_SENDERID;
		entity.U_SENDER=model.U_SENDER;
		entity.U_DATE=model.U_DATE;
		entity.M_TM=model.M_TM;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.DATA_KEY=model.DATA_KEY;
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
        public GeneralResult Add(DB_SYSTEM model)
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
                    Delete(DB_SYSTEM._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DB_SYSTEM> model)
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
       	protected WhereClipBuilder ConditionBuilder(DB_SYSTEM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(DB_SYSTEM._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.C_CODE))
				{
				  condition.And(DB_SYSTEM._.C_CODE.Contain(model.C_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BU_CODE))
				{
				  condition.And(DB_SYSTEM._.BU_CODE.Contain(model.BU_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.F_NATURE))
				{
				  condition.And(DB_SYSTEM._.F_NATURE.Contain(model.F_NATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.F_TYPE))
				{
				  condition.And(DB_SYSTEM._.F_TYPE.Contain(model.F_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SO_INDI))
				{
				  condition.And(DB_SYSTEM._.SO_INDI.Contain(model.SO_INDI));
				}
				if(!string.IsNullOrWhiteSpace(model.P_TYPE))
				{
				  condition.And(DB_SYSTEM._.P_TYPE.Contain(model.P_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.S_METHOD))
				{
				  condition.And(DB_SYSTEM._.S_METHOD.Contain(model.S_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.U_APPID))
				{
				  condition.And(DB_SYSTEM._.U_APPID.Contain(model.U_APPID));
				}
				if(!string.IsNullOrWhiteSpace(model.U_APP))
				{
				  condition.And(DB_SYSTEM._.U_APP.Contain(model.U_APP));
				}
				if(model.APP_DATE!=null)
				{
				  condition.And(DB_SYSTEM._.APP_DATE==(model.APP_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.APP_AOM))
				{
				  condition.And(DB_SYSTEM._.APP_AOM.Contain(model.APP_AOM));
				}
				if(!string.IsNullOrWhiteSpace(model.E_PERID))
				{
				  condition.And(DB_SYSTEM._.E_PERID.Contain(model.E_PERID));
				}
				if(!string.IsNullOrWhiteSpace(model.E_PER))
				{
				  condition.And(DB_SYSTEM._.E_PER.Contain(model.E_PER));
				}
				if(model.E_DATE!=null)
				{
				  condition.And(DB_SYSTEM._.E_DATE==(model.E_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.U_AUDITORID))
				{
				  condition.And(DB_SYSTEM._.U_AUDITORID.Contain(model.U_AUDITORID));
				}
				if(!string.IsNullOrWhiteSpace(model.U_AUDITOR))
				{
				  condition.And(DB_SYSTEM._.U_AUDITOR.Contain(model.U_AUDITOR));
				}
				if(model.U_CHECK_DATE!=null)
				{
				  condition.And(DB_SYSTEM._.U_CHECK_DATE==(model.U_CHECK_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.U_SENDERID))
				{
				  condition.And(DB_SYSTEM._.U_SENDERID.Contain(model.U_SENDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.U_SENDER))
				{
				  condition.And(DB_SYSTEM._.U_SENDER.Contain(model.U_SENDER));
				}
				if(model.U_DATE!=null)
				{
				  condition.And(DB_SYSTEM._.U_DATE==(model.U_DATE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DB_SYSTEM._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DB_SYSTEM._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(DB_SYSTEM._.DATA_KEY.Contain(model.DATA_KEY));
				}
		return condition;
	}
        #endregion
    }
}