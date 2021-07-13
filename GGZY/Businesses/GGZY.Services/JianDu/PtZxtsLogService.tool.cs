using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsLogService : BaseServiceT<PT_ZXTS_LOG>
    {
        #region 接口实现
        
		public List<PT_ZXTS_LOG> FindList(PT_ZXTS_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ZXTS_LOG> PageList(PT_ZXTS_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_ZXTS_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_ZXTS_LOG._.ID == ID);
			
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
        public GeneralResult Edit(PT_ZXTS_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_ZXTS_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TS_ID=model.TS_ID;
		entity.RECORDER_UID=model.RECORDER_UID;
		entity.RECORDER_UNAME=model.RECORDER_UNAME;
		entity.RECORDER_DEPID=model.RECORDER_DEPID;
		entity.RECORDER_TM=model.RECORDER_TM;
		entity.RECORDER_OPERATION=model.RECORDER_OPERATION;
		entity.RECORDER_REMARK=model.RECORDER_REMARK;
		entity.RECORDER_AIDS=model.RECORDER_AIDS;
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
        public GeneralResult Add(PT_ZXTS_LOG model)
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
                    Delete(PT_ZXTS_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ZXTS_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_ZXTS_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_ZXTS_LOG._.ID==(model.ID));
				}
				if(model.TS_ID!=null)
				{
				  condition.And(PT_ZXTS_LOG._.TS_ID==(model.TS_ID));
				}
				if(model.RECORDER_UID!=null)
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_UID==(model.RECORDER_UID));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORDER_UNAME))
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_UNAME.Contain(model.RECORDER_UNAME));
				}
				if(model.RECORDER_DEPID!=null)
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_DEPID==(model.RECORDER_DEPID));
				}
				if(model.RECORDER_TM!=null)
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_TM==(model.RECORDER_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORDER_OPERATION))
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_OPERATION.Contain(model.RECORDER_OPERATION));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORDER_REMARK))
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_REMARK.Contain(model.RECORDER_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.RECORDER_AIDS))
				{
				  condition.And(PT_ZXTS_LOG._.RECORDER_AIDS.Contain(model.RECORDER_AIDS));
				}
		return condition;
	}
        #endregion
    }
}