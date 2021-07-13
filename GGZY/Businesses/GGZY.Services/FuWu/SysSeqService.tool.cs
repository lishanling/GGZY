using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysSeqService : BaseServiceT<SYS_SEQ>
    {
        #region 接口实现
        
		public List<SYS_SEQ> FindList(SYS_SEQ model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_SEQ> PageList(SYS_SEQ model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_SEQ._.TB_NAME.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TB_NAME"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string TB_NAME)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_SEQ._.TB_NAME == TB_NAME);
			
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
        public GeneralResult Edit(SYS_SEQ model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TB_NAME);
	
	if(viewResult.Success  && viewResult.Data is SYS_SEQ entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TB_NAME=model.TB_NAME;
		entity.CUR_DATE=model.CUR_DATE;
		entity.CUR_SEQ=model.CUR_SEQ;
		entity.UPDATE_TIME=model.UPDATE_TIME;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(SYS_SEQ model)
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
                    Delete(SYS_SEQ._.TB_NAME.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_SEQ> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_SEQ model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_SEQ._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TB_NAME))
				{
				  condition.And(SYS_SEQ._.TB_NAME.Contain(model.TB_NAME));
				}
				if(model.CUR_DATE!=null)
				{
				  condition.And(SYS_SEQ._.CUR_DATE==(model.CUR_DATE));
				}
				if(model.CUR_SEQ!=null)
				{
				  condition.And(SYS_SEQ._.CUR_SEQ==(model.CUR_SEQ));
				}
				if(model.UPDATE_TIME!=null)
				{
				  condition.And(SYS_SEQ._.UPDATE_TIME==(model.UPDATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_SEQ._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}