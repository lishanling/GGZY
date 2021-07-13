using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TNoticeService : BaseServiceT<T_NOTICE>
    {
        #region 接口实现
        
		public List<T_NOTICE> FindList(T_NOTICE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_NOTICE> PageList(T_NOTICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_NOTICE._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_NOTICE._.ID == ID);
			
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
        public GeneralResult Edit(T_NOTICE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_NOTICE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.U_ID=model.U_ID;
		entity.IMG_AID=model.IMG_AID;
		entity.CONTENTS_SHORT=model.CONTENTS_SHORT;
		entity.CONTENTS=model.CONTENTS;
		entity.TM=model.TM;
		entity.STATE=model.STATE;
		entity.ISTOP=model.ISTOP;
		entity.FLAGS=model.FLAGS;
		entity.ORDERID=model.ORDERID;
		entity.REMOTE=model.REMOTE;
		entity.AUTOLITPIC=model.AUTOLITPIC;
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
        public GeneralResult Add(T_NOTICE model)
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
                    Delete(T_NOTICE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_NOTICE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_NOTICE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_NOTICE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_NOTICE._.TITLE.Contain(model.TITLE));
				}
				if(model.U_ID!=null)
				{
				  condition.And(T_NOTICE._.U_ID==(model.U_ID));
				}
				if(model.IMG_AID!=null)
				{
				  condition.And(T_NOTICE._.IMG_AID==(model.IMG_AID));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENTS_SHORT))
				{
				  condition.And(T_NOTICE._.CONTENTS_SHORT.Contain(model.CONTENTS_SHORT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENTS))
				{
				  condition.And(T_NOTICE._.CONTENTS.Contain(model.CONTENTS));
				}
				if(model.TM!=null)
				{
				  condition.And(T_NOTICE._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.STATE))
				{
				  condition.And(T_NOTICE._.STATE.Contain(model.STATE));
				}
				if(model.ISTOP!=null)
				{
				  condition.And(T_NOTICE._.ISTOP==(model.ISTOP));
				}
				if(!string.IsNullOrWhiteSpace(model.FLAGS))
				{
				  condition.And(T_NOTICE._.FLAGS.Contain(model.FLAGS));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(T_NOTICE._.ORDERID==(model.ORDERID));
				}
				if(model.REMOTE!=null)
				{
				  condition.And(T_NOTICE._.REMOTE==(model.REMOTE));
				}
				if(model.AUTOLITPIC!=null)
				{
				  condition.And(T_NOTICE._.AUTOLITPIC==(model.AUTOLITPIC));
				}
		return condition;
	}
        #endregion
    }
}