using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2WinbidbulletinService : BaseServiceT<T_EC2_WINBIDBULLETIN>
    {
        #region 接口实现
        
		public List<T_EC2_WINBIDBULLETIN> FindList(T_EC2_WINBIDBULLETIN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_WINBIDBULLETIN> PageList(T_EC2_WINBIDBULLETIN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_WINBIDBULLETIN._.WINBIDBULLETINCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="WINBIDBULLETINCODE">中标公告编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string WINBIDBULLETINCODE,string TENDERPROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_WINBIDBULLETIN._.WINBIDBULLETINCODE == WINBIDBULLETINCODE);
			condition.And(T_EC2_WINBIDBULLETIN._.TENDERPROJECTCODE == TENDERPROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_WINBIDBULLETIN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.WINBIDBULLETINCODE,model.TENDERPROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_WINBIDBULLETIN entity)
	{		
		entity.Attach();
		entity.WINBIDBULLETINCODE=model.WINBIDBULLETINCODE;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.TENDERPROJECTNAME=model.TENDERPROJECTNAME;
		entity.BIDSECTIONCODES=model.BIDSECTIONCODES;
		entity.BULLETINNAME=model.BULLETINNAME;
		entity.BULLETINTYPE=model.BULLETINTYPE;
		entity.BULLETINISSUETIME=model.BULLETINISSUETIME;
		entity.BULLETINCONTENT=model.BULLETINCONTENT;
		entity.URL=model.URL;
		entity.ATTACHMENTCODE=model.ATTACHMENTCODE;
		entity.VERSION=model.VERSION;
		entity.ISOPEN=model.ISOPEN;
		entity.OPENTYPE=model.OPENTYPE;
		entity.EXAMINERNAME=model.EXAMINERNAME;
		entity.EXAMINERCODETYPE=model.EXAMINERCODETYPE;
		entity.EXAMINERCODE=model.EXAMINERCODE;
		entity.VERIFYTIME=model.VERIFYTIME;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.CREATE_TIME=model.CREATE_TIME;
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
        public GeneralResult Add(T_EC2_WINBIDBULLETIN model)
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
                    Delete(T_EC2_WINBIDBULLETIN._.WINBIDBULLETINCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_WINBIDBULLETIN> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_WINBIDBULLETIN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.WINBIDBULLETINCODE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.WINBIDBULLETINCODE.Contain(model.WINBIDBULLETINCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTNAME))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.TENDERPROJECTNAME.Contain(model.TENDERPROJECTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODES))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.BIDSECTIONCODES.Contain(model.BIDSECTIONCODES));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINNAME))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.BULLETINNAME.Contain(model.BULLETINNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINTYPE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.BULLETINTYPE.Contain(model.BULLETINTYPE));
				}
				if(model.BULLETINISSUETIME!=null)
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.BULLETINISSUETIME==(model.BULLETINISSUETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINCONTENT))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.BULLETINCONTENT.Contain(model.BULLETINCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_WINBIDBULLETIN._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}