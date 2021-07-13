using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsRevokeService : BaseServiceT<PT_ZXTS_REVOKE>
    {
        #region 接口实现
        
		public List<PT_ZXTS_REVOKE> FindList(PT_ZXTS_REVOKE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ZXTS_REVOKE> PageList(PT_ZXTS_REVOKE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_ZXTS_REVOKE._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_ZXTS_REVOKE._.ID == ID);
			
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
        public GeneralResult Edit(PT_ZXTS_REVOKE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_ZXTS_REVOKE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TS_ID=model.TS_ID;
		entity.TYPE=model.TYPE;
		entity.TM=model.TM;
		entity.REMARK=model.REMARK;
		entity.REVOKE_AIDS=model.REVOKE_AIDS;
		entity.OTHER_AIDS=model.OTHER_AIDS;
		entity.APPROVAL_UID=model.APPROVAL_UID;
		entity.APPROVAL_STATE=model.APPROVAL_STATE;
		entity.APPROVAL_REMARK=model.APPROVAL_REMARK;
		entity.APPROVAL_TM=model.APPROVAL_TM;
		entity.APPROVAL_AIDS=model.APPROVAL_AIDS;
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
        public GeneralResult Add(PT_ZXTS_REVOKE model)
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
                    Delete(PT_ZXTS_REVOKE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ZXTS_REVOKE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_ZXTS_REVOKE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_ZXTS_REVOKE._.ID==(model.ID));
				}
				if(model.TS_ID!=null)
				{
				  condition.And(PT_ZXTS_REVOKE._.TS_ID==(model.TS_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(PT_ZXTS_REVOKE._.TYPE.Contain(model.TYPE));
				}
				if(model.TM!=null)
				{
				  condition.And(PT_ZXTS_REVOKE._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(PT_ZXTS_REVOKE._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.REVOKE_AIDS))
				{
				  condition.And(PT_ZXTS_REVOKE._.REVOKE_AIDS.Contain(model.REVOKE_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_AIDS))
				{
				  condition.And(PT_ZXTS_REVOKE._.OTHER_AIDS.Contain(model.OTHER_AIDS));
				}
				if(model.APPROVAL_UID!=null)
				{
				  condition.And(PT_ZXTS_REVOKE._.APPROVAL_UID==(model.APPROVAL_UID));
				}
				if(model.APPROVAL_STATE!=null)
				{
				  condition.And(PT_ZXTS_REVOKE._.APPROVAL_STATE==(model.APPROVAL_STATE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_REMARK))
				{
				  condition.And(PT_ZXTS_REVOKE._.APPROVAL_REMARK.Contain(model.APPROVAL_REMARK));
				}
				if(model.APPROVAL_TM!=null)
				{
				  condition.And(PT_ZXTS_REVOKE._.APPROVAL_TM==(model.APPROVAL_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_AIDS))
				{
				  condition.And(PT_ZXTS_REVOKE._.APPROVAL_AIDS.Contain(model.APPROVAL_AIDS));
				}
		return condition;
	}
        #endregion
    }
}