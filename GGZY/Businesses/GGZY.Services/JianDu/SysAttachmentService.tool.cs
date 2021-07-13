using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysAttachmentService : BaseServiceT<SYS_ATTACHMENT>
    {
        #region 接口实现
        
		public List<SYS_ATTACHMENT> FindList(SYS_ATTACHMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_ATTACHMENT> PageList(SYS_ATTACHMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_ATTACHMENT._.AID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="AID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? AID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_ATTACHMENT._.AID == AID);
			
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
        public GeneralResult Edit(SYS_ATTACHMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.AID);
	
	if(viewResult.Success  && viewResult.Data is SYS_ATTACHMENT entity)
	{		
		entity.Attach();
		entity.AID=model.AID;
		entity.AOBJID=model.AOBJID;
		entity.FILETYPE=model.FILETYPE;
		entity.FILEPATH=model.FILEPATH;
		entity.FILETILE=model.FILETILE;
		entity.CREATEID=model.CREATEID;
		entity.CREATETIME=model.CREATETIME;
		entity.UPDATEID=model.UPDATEID;
		entity.UPDATETIME=model.UPDATETIME;
		entity.REMARK=model.REMARK;
		entity.AOBJTYPE=model.AOBJTYPE;
		entity.ORDERID=model.ORDERID;
		entity.FILENUMBER=model.FILENUMBER;
		entity.ISCONVERTTOSWF=model.ISCONVERTTOSWF;
		entity.CONVERTDATETIME=model.CONVERTDATETIME;
		entity.CONVERTREMARK=model.CONVERTREMARK;
		entity.CONVERTSTATUS=model.CONVERTSTATUS;
		entity.FILECLASS=model.FILECLASS;
		entity.ISPRIVATE=model.ISPRIVATE;
		entity.ISEDIT=model.ISEDIT;
		entity.PREVIEWPATH=model.PREVIEWPATH;
		entity.GUID=model.GUID;
		entity.SIGN_INFO1=model.SIGN_INFO1;
		entity.MD5=model.MD5;
		entity.SIGN_INFO=model.SIGN_INFO;
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
        public GeneralResult Add(SYS_ATTACHMENT model)
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
                    Delete(SYS_ATTACHMENT._.AID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_ATTACHMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_ATTACHMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.AID!=null)
				{
				  condition.And(SYS_ATTACHMENT._.AID==(model.AID));
				}
				if(model.AOBJID!=null)
				{
				  condition.And(SYS_ATTACHMENT._.AOBJID==(model.AOBJID));
				}
				if(!string.IsNullOrWhiteSpace(model.FILETYPE))
				{
				  condition.And(SYS_ATTACHMENT._.FILETYPE.Contain(model.FILETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.FILEPATH))
				{
				  condition.And(SYS_ATTACHMENT._.FILEPATH.Contain(model.FILEPATH));
				}
				if(!string.IsNullOrWhiteSpace(model.FILETILE))
				{
				  condition.And(SYS_ATTACHMENT._.FILETILE.Contain(model.FILETILE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATEID))
				{
				  condition.And(SYS_ATTACHMENT._.CREATEID.Contain(model.CREATEID));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(SYS_ATTACHMENT._.CREATETIME==(model.CREATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UPDATEID))
				{
				  condition.And(SYS_ATTACHMENT._.UPDATEID.Contain(model.UPDATEID));
				}
				if(model.UPDATETIME!=null)
				{
				  condition.And(SYS_ATTACHMENT._.UPDATETIME==(model.UPDATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(SYS_ATTACHMENT._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.AOBJTYPE))
				{
				  condition.And(SYS_ATTACHMENT._.AOBJTYPE.Contain(model.AOBJTYPE));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(SYS_ATTACHMENT._.ORDERID==(model.ORDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.FILENUMBER))
				{
				  condition.And(SYS_ATTACHMENT._.FILENUMBER.Contain(model.FILENUMBER));
				}
				if(model.ISCONVERTTOSWF!=null)
				{
				  condition.And(SYS_ATTACHMENT._.ISCONVERTTOSWF==(model.ISCONVERTTOSWF));
				}
				if(model.CONVERTDATETIME!=null)
				{
				  condition.And(SYS_ATTACHMENT._.CONVERTDATETIME==(model.CONVERTDATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONVERTREMARK))
				{
				  condition.And(SYS_ATTACHMENT._.CONVERTREMARK.Contain(model.CONVERTREMARK));
				}
				if(model.CONVERTSTATUS!=null)
				{
				  condition.And(SYS_ATTACHMENT._.CONVERTSTATUS==(model.CONVERTSTATUS));
				}
				if(model.FILECLASS!=null)
				{
				  condition.And(SYS_ATTACHMENT._.FILECLASS==(model.FILECLASS));
				}
				if(model.ISPRIVATE!=null)
				{
				  condition.And(SYS_ATTACHMENT._.ISPRIVATE==(model.ISPRIVATE));
				}
				if(model.ISEDIT!=null)
				{
				  condition.And(SYS_ATTACHMENT._.ISEDIT==(model.ISEDIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PREVIEWPATH))
				{
				  condition.And(SYS_ATTACHMENT._.PREVIEWPATH.Contain(model.PREVIEWPATH));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(SYS_ATTACHMENT._.GUID.Contain(model.GUID));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_INFO1))
				{
				  condition.And(SYS_ATTACHMENT._.SIGN_INFO1.Contain(model.SIGN_INFO1));
				}
				if(!string.IsNullOrWhiteSpace(model.MD5))
				{
				  condition.And(SYS_ATTACHMENT._.MD5.Contain(model.MD5));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_INFO))
				{
				  condition.And(SYS_ATTACHMENT._.SIGN_INFO.Contain(model.SIGN_INFO));
				}
		return condition;
	}
        #endregion
    }
}