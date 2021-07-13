using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtCommentService : BaseServiceT<PT_COMMENT>
    {
        #region 接口实现
        
		public List<PT_COMMENT> FindList(PT_COMMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_COMMENT> PageList(PT_COMMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_COMMENT._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_COMMENT._.ID == ID);
			
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
        public GeneralResult Edit(PT_COMMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_COMMENT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.ARTICLEID=model.ARTICLEID;
		entity.COMMENTCONTENT=model.COMMENTCONTENT;
		entity.USERID=model.USERID;
		entity.ISSHOW=model.ISSHOW;
		entity.TM=model.TM;
		entity.PID=model.PID;
		entity.IP=model.IP;
		entity.RCONTENT=model.RCONTENT;
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
        public GeneralResult Add(PT_COMMENT model)
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
                    Delete(PT_COMMENT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_COMMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_COMMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_COMMENT._.ID==(model.ID));
				}
				if(model.ARTICLEID!=null)
				{
				  condition.And(PT_COMMENT._.ARTICLEID==(model.ARTICLEID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMMENTCONTENT))
				{
				  condition.And(PT_COMMENT._.COMMENTCONTENT.Contain(model.COMMENTCONTENT));
				}
				if(model.USERID!=null)
				{
				  condition.And(PT_COMMENT._.USERID==(model.USERID));
				}
				if(model.ISSHOW!=null)
				{
				  condition.And(PT_COMMENT._.ISSHOW==(model.ISSHOW));
				}
				if(model.TM!=null)
				{
				  condition.And(PT_COMMENT._.TM==(model.TM));
				}
				if(model.PID!=null)
				{
				  condition.And(PT_COMMENT._.PID==(model.PID));
				}
				if(!string.IsNullOrWhiteSpace(model.IP))
				{
				  condition.And(PT_COMMENT._.IP.Contain(model.IP));
				}
				if(!string.IsNullOrWhiteSpace(model.RCONTENT))
				{
				  condition.And(PT_COMMENT._.RCONTENT.Contain(model.RCONTENT));
				}
		return condition;
	}
        #endregion
    }
}