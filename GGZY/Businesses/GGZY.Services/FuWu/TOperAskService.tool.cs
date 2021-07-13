using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TOperAskService : BaseServiceT<T_OPER_ASK>
    {
        #region 接口实现
        
		public List<T_OPER_ASK> FindList(T_OPER_ASK model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_OPER_ASK> PageList(T_OPER_ASK model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_OPER_ASK._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_OPER_ASK._.ID == ID);
			
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
        public GeneralResult Edit(T_OPER_ASK model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_OPER_ASK entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.CONTENT=model.CONTENT;
		entity.Q_AREA=model.Q_AREA;
		entity.TC_TM=model.TC_TM;
		entity.LX_TELPHONE=model.LX_TELPHONE;
		entity.TCR=model.TCR;
		entity.HFR=model.HFR;
		entity.HF_CONTENTS=model.HF_CONTENTS;
		entity.HF_TM=model.HF_TM;
		entity.CLJG=model.CLJG;
		entity.CLYJ=model.CLYJ;
		entity.CL_TM=model.CL_TM;
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
        public GeneralResult Add(T_OPER_ASK model)
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
                    Delete(T_OPER_ASK._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_OPER_ASK> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_OPER_ASK model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(T_OPER_ASK._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_OPER_ASK._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(T_OPER_ASK._.CONTENT.Contain(model.CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.Q_AREA))
				{
				  condition.And(T_OPER_ASK._.Q_AREA.Contain(model.Q_AREA));
				}
				if(model.TC_TM!=null)
				{
				  condition.And(T_OPER_ASK._.TC_TM==(model.TC_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.LX_TELPHONE))
				{
				  condition.And(T_OPER_ASK._.LX_TELPHONE.Contain(model.LX_TELPHONE));
				}
				if(model.TCR!=null)
				{
				  condition.And(T_OPER_ASK._.TCR==(model.TCR));
				}
				if(model.HFR!=null)
				{
				  condition.And(T_OPER_ASK._.HFR==(model.HFR));
				}
				if(!string.IsNullOrWhiteSpace(model.HF_CONTENTS))
				{
				  condition.And(T_OPER_ASK._.HF_CONTENTS.Contain(model.HF_CONTENTS));
				}
				if(model.HF_TM!=null)
				{
				  condition.And(T_OPER_ASK._.HF_TM==(model.HF_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CLJG))
				{
				  condition.And(T_OPER_ASK._.CLJG.Contain(model.CLJG));
				}
				if(!string.IsNullOrWhiteSpace(model.CLYJ))
				{
				  condition.And(T_OPER_ASK._.CLYJ.Contain(model.CLYJ));
				}
				if(model.CL_TM!=null)
				{
				  condition.And(T_OPER_ASK._.CL_TM==(model.CL_TM));
				}
		return condition;
	}
        #endregion
    }
}