using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysDocumentsService : BaseServiceT<SYS_DOCUMENTS>
    {
        #region 接口实现
        
		public List<SYS_DOCUMENTS> FindList(SYS_DOCUMENTS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_DOCUMENTS> PageList(SYS_DOCUMENTS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_DOCUMENTS._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_DOCUMENTS._.ID == ID);
			
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
        public GeneralResult Edit(SYS_DOCUMENTS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_DOCUMENTS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.FILEORFOLDER=model.FILEORFOLDER;
		entity.FOLDERNAME=model.FOLDERNAME;
		entity.PID=model.PID;
		entity.ORDERID=model.ORDERID;
		entity.ISPRIVATE=model.ISPRIVATE;
		entity.ISEDIT=model.ISEDIT;
		entity.MODULEID=model.MODULEID;
		entity.SSJDID=model.SSJDID;
		entity.ATTACHMENTID=model.ATTACHMENTID;
		entity.CREATEID=model.CREATEID;
		entity.CREATETIME=model.CREATETIME;
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
        public GeneralResult Add(SYS_DOCUMENTS model)
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
                    Delete(SYS_DOCUMENTS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_DOCUMENTS> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_DOCUMENTS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_DOCUMENTS._.ID==(model.ID));
				}
				if(model.FILEORFOLDER!=null)
				{
				  condition.And(SYS_DOCUMENTS._.FILEORFOLDER==(model.FILEORFOLDER));
				}
				if(!string.IsNullOrWhiteSpace(model.FOLDERNAME))
				{
				  condition.And(SYS_DOCUMENTS._.FOLDERNAME.Contain(model.FOLDERNAME));
				}
				if(model.PID!=null)
				{
				  condition.And(SYS_DOCUMENTS._.PID==(model.PID));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(SYS_DOCUMENTS._.ORDERID==(model.ORDERID));
				}
				if(model.ISPRIVATE!=null)
				{
				  condition.And(SYS_DOCUMENTS._.ISPRIVATE==(model.ISPRIVATE));
				}
				if(model.ISEDIT!=null)
				{
				  condition.And(SYS_DOCUMENTS._.ISEDIT==(model.ISEDIT));
				}
				if(model.MODULEID!=null)
				{
				  condition.And(SYS_DOCUMENTS._.MODULEID==(model.MODULEID));
				}
				if(!string.IsNullOrWhiteSpace(model.SSJDID))
				{
				  condition.And(SYS_DOCUMENTS._.SSJDID.Contain(model.SSJDID));
				}
				if(model.ATTACHMENTID!=null)
				{
				  condition.And(SYS_DOCUMENTS._.ATTACHMENTID==(model.ATTACHMENTID));
				}
				if(model.CREATEID!=null)
				{
				  condition.And(SYS_DOCUMENTS._.CREATEID==(model.CREATEID));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(SYS_DOCUMENTS._.CREATETIME==(model.CREATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_DOCUMENTS._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}