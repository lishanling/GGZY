using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriExtSelfproveService : BaseServiceT<ZJPRI_EXT_SELFPROVE>
    {
        #region 接口实现
        
		public List<ZJPRI_EXT_SELFPROVE> FindList(ZJPRI_EXT_SELFPROVE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_EXT_SELFPROVE> PageList(ZJPRI_EXT_SELFPROVE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_EXT_SELFPROVE._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_EXT_SELFPROVE._.ID == ID);
			
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
        public GeneralResult Edit(ZJPRI_EXT_SELFPROVE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_EXT_SELFPROVE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.Z_TYPE=model.Z_TYPE;
		entity.Z_CONTENT=model.Z_CONTENT;
		entity.IS_PUBLIC=model.IS_PUBLIC;
		entity.FILES=model.FILES;
		entity.CREATE_TM=model.CREATE_TM;
		entity.LEGAL_NAME=model.LEGAL_NAME;
		entity.LEGAL_CODE=model.LEGAL_CODE;
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
        public GeneralResult Add(ZJPRI_EXT_SELFPROVE model)
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
                    Delete(ZJPRI_EXT_SELFPROVE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_EXT_SELFPROVE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_EXT_SELFPROVE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.Z_TYPE))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.Z_TYPE.Contain(model.Z_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.Z_CONTENT))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.Z_CONTENT.Contain(model.Z_CONTENT));
				}
				if(model.IS_PUBLIC!=null)
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.IS_PUBLIC==(model.IS_PUBLIC));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.FILES.Contain(model.FILES));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_NAME))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.LEGAL_NAME.Contain(model.LEGAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
				{
				  condition.And(ZJPRI_EXT_SELFPROVE._.LEGAL_CODE.Contain(model.LEGAL_CODE));
				}
		return condition;
	}
        #endregion
    }
}