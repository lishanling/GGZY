using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MchgProgMgtService : BaseServiceT<MCHG_PROG_MGT>
    {
        #region 接口实现
        
		public List<MCHG_PROG_MGT> FindList(MCHG_PROG_MGT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MCHG_PROG_MGT> PageList(MCHG_PROG_MGT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, MCHG_PROG_MGT._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(MCHG_PROG_MGT._.ID == ID);
			
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
        public GeneralResult Edit(MCHG_PROG_MGT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is MCHG_PROG_MGT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.MCHG_WAY=model.MCHG_WAY;
		entity.MCHG_PROG=model.MCHG_PROG;
		entity.IS_ENABLE=model.IS_ENABLE;
		entity.ASSOCIATION_TABLE=model.ASSOCIATION_TABLE;
		entity.ASSOCIATION_FIELD=model.ASSOCIATION_FIELD;
		entity.ADD_PEOPLE=model.ADD_PEOPLE;
		entity.ADD_TIME=model.ADD_TIME;
		entity.ANNEX=model.ANNEX;
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
        public GeneralResult Add(MCHG_PROG_MGT model)
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
                    Delete(MCHG_PROG_MGT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<MCHG_PROG_MGT> model)
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
       	protected WhereClipBuilder ConditionBuilder(MCHG_PROG_MGT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(MCHG_PROG_MGT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.MCHG_WAY))
				{
				  condition.And(MCHG_PROG_MGT._.MCHG_WAY.Contain(model.MCHG_WAY));
				}
				if(!string.IsNullOrWhiteSpace(model.MCHG_PROG))
				{
				  condition.And(MCHG_PROG_MGT._.MCHG_PROG.Contain(model.MCHG_PROG));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_ENABLE))
				{
				  condition.And(MCHG_PROG_MGT._.IS_ENABLE.Contain(model.IS_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ASSOCIATION_TABLE))
				{
				  condition.And(MCHG_PROG_MGT._.ASSOCIATION_TABLE.Contain(model.ASSOCIATION_TABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ASSOCIATION_FIELD))
				{
				  condition.And(MCHG_PROG_MGT._.ASSOCIATION_FIELD.Contain(model.ASSOCIATION_FIELD));
				}
				if(!string.IsNullOrWhiteSpace(model.ADD_PEOPLE))
				{
				  condition.And(MCHG_PROG_MGT._.ADD_PEOPLE.Contain(model.ADD_PEOPLE));
				}
				if(model.ADD_TIME!=null)
				{
				  condition.And(MCHG_PROG_MGT._.ADD_TIME==(model.ADD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNEX))
				{
				  condition.And(MCHG_PROG_MGT._.ANNEX.Contain(model.ANNEX));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(MCHG_PROG_MGT._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}