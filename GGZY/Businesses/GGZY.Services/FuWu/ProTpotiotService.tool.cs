using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProTpotiotService : BaseServiceT<PRO_TPOTIOT>
    {
        #region 接口实现
        
		public List<PRO_TPOTIOT> FindList(PRO_TPOTIOT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRO_TPOTIOT> PageList(PRO_TPOTIOT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRO_TPOTIOT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRO_TPOTIOT._.ID == ID);
			
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
        public GeneralResult Edit(PRO_TPOTIOT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRO_TPOTIOT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PRO_CODE=model.PRO_CODE;
		entity.PRO_NAME=model.PRO_NAME;
		entity.PRO_TPIC=model.PRO_TPIC;
		entity.MONEY=model.MONEY;
		entity.PRO_SITUATION=model.PRO_SITUATION;
		entity.PRO_DOCPT=model.PRO_DOCPT;
		entity.CRT_PROGRESS=model.CRT_PROGRESS;
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
        public GeneralResult Add(PRO_TPOTIOT model)
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
                    Delete(PRO_TPOTIOT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRO_TPOTIOT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRO_TPOTIOT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRO_TPOTIOT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_CODE))
				{
				  condition.And(PRO_TPOTIOT._.PRO_CODE.Contain(model.PRO_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NAME))
				{
				  condition.And(PRO_TPOTIOT._.PRO_NAME.Contain(model.PRO_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_TPIC))
				{
				  condition.And(PRO_TPOTIOT._.PRO_TPIC.Contain(model.PRO_TPIC));
				}
				if(!string.IsNullOrWhiteSpace(model.MONEY))
				{
				  condition.And(PRO_TPOTIOT._.MONEY.Contain(model.MONEY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_SITUATION))
				{
				  condition.And(PRO_TPOTIOT._.PRO_SITUATION.Contain(model.PRO_SITUATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_DOCPT))
				{
				  condition.And(PRO_TPOTIOT._.PRO_DOCPT.Contain(model.PRO_DOCPT));
				}
				if(!string.IsNullOrWhiteSpace(model.CRT_PROGRESS))
				{
				  condition.And(PRO_TPOTIOT._.CRT_PROGRESS.Contain(model.CRT_PROGRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(PRO_TPOTIOT._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}