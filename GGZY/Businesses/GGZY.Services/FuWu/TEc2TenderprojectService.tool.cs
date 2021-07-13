using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2TenderprojectService : BaseServiceT<T_EC2_TENDERPROJECT>
    {
        #region 接口实现
        
		public List<T_EC2_TENDERPROJECT> FindList(T_EC2_TENDERPROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_TENDERPROJECT> PageList(T_EC2_TENDERPROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_TENDERPROJECT._.TENDERPROJECTCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string TENDERPROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_TENDERPROJECT._.TENDERPROJECTCODE == TENDERPROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_TENDERPROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TENDERPROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_TENDERPROJECT entity)
	{		
		entity.Attach();
		entity.PROJECTCODE=model.PROJECTCODE;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.TRADEPLATFTENDERPROJECTCODE=model.TRADEPLATFTENDERPROJECTCODE;
		entity.TENDERPROJECTNAME=model.TENDERPROJECTNAME;
		entity.TENDERPROJECTCLASSIFYCODE=model.TENDERPROJECTCLASSIFYCODE;
		entity.REGIONCODE=model.REGIONCODE;
		entity.TENDERCONTENT=model.TENDERCONTENT;
		entity.TENDERERCODETYPE=model.TENDERERCODETYPE;
		entity.TENDERERCODE=model.TENDERERCODE;
		entity.TENDERERNAME=model.TENDERERNAME;
		entity.TENDERAGENCYCODETYPE=model.TENDERAGENCYCODETYPE;
		entity.TENDERAGENCYCODE=model.TENDERAGENCYCODE;
		entity.TENDERAGENCYNAME=model.TENDERAGENCYNAME;
		entity.TENDERERAGENCYBASICINFOVERSION=model.TENDERERAGENCYBASICINFOVERSION;
		entity.TENDERMODE=model.TENDERMODE;
		entity.TENDERORGANIZEFORM=model.TENDERORGANIZEFORM;
		entity.CREATETIME=model.CREATETIME;
		entity.SUPERVISEDEPTCODETYPE=model.SUPERVISEDEPTCODETYPE;
		entity.SUPERVISEDEPTCODE=model.SUPERVISEDEPTCODE;
		entity.SUPERVISEDEPTNAME=model.SUPERVISEDEPTNAME;
		entity.APPROVEDEPTCODETYPE=model.APPROVEDEPTCODETYPE;
		entity.APPROVEDEPTCODE=model.APPROVEDEPTCODE;
		entity.APPROVEDEPTNAME=model.APPROVEDEPTNAME;
		entity.PLATFORMCODE=model.PLATFORMCODE;
		entity.PUBSERVICEPLATCODE=model.PUBSERVICEPLATCODE;
		entity.INFOREPORTERNAME=model.INFOREPORTERNAME;
		entity.INFOREPORTERCODETYPE=model.INFOREPORTERCODETYPE;
		entity.INFOREPORTERCODE=model.INFOREPORTERCODE;
		entity.EXAMINERNAME=model.EXAMINERNAME;
		entity.EXAMINERCODETYPE=model.EXAMINERCODETYPE;
		entity.EXAMINERCODE=model.EXAMINERCODE;
		entity.ATTACHMENTCODE=model.ATTACHMENTCODE;
		entity.VERSION=model.VERSION;
		entity.ISOPEN=model.ISOPEN;
		entity.OPENTYPE=model.OPENTYPE;
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
        public GeneralResult Add(T_EC2_TENDERPROJECT model)
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
                    Delete(T_EC2_TENDERPROJECT._.TENDERPROJECTCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_TENDERPROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_TENDERPROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECTCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.PROJECTCODE.Contain(model.PROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADEPLATFTENDERPROJECTCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TRADEPLATFTENDERPROJECTCODE.Contain(model.TRADEPLATFTENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERPROJECTNAME.Contain(model.TENDERPROJECTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCLASSIFYCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERPROJECTCLASSIFYCODE.Contain(model.TENDERPROJECTCLASSIFYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGIONCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.REGIONCODE.Contain(model.REGIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERCONTENT))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERCONTENT.Contain(model.TENDERCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERERCODETYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERERCODETYPE.Contain(model.TENDERERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERERCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERERCODE.Contain(model.TENDERERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERERNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERERNAME.Contain(model.TENDERERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERAGENCYCODETYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERAGENCYCODETYPE.Contain(model.TENDERAGENCYCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERAGENCYCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERAGENCYCODE.Contain(model.TENDERAGENCYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERAGENCYNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERAGENCYNAME.Contain(model.TENDERAGENCYNAME));
				}
				if(model.TENDERERAGENCYBASICINFOVERSION!=null)
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERERAGENCYBASICINFOVERSION==(model.TENDERERAGENCYBASICINFOVERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERMODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERMODE.Contain(model.TENDERMODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERORGANIZEFORM))
				{
				  condition.And(T_EC2_TENDERPROJECT._.TENDERORGANIZEFORM.Contain(model.TENDERORGANIZEFORM));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_EC2_TENDERPROJECT._.CREATETIME==(model.CREATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISEDEPTCODETYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.SUPERVISEDEPTCODETYPE.Contain(model.SUPERVISEDEPTCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISEDEPTCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.SUPERVISEDEPTCODE.Contain(model.SUPERVISEDEPTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISEDEPTNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.SUPERVISEDEPTNAME.Contain(model.SUPERVISEDEPTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVEDEPTCODETYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.APPROVEDEPTCODETYPE.Contain(model.APPROVEDEPTCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVEDEPTCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.APPROVEDEPTCODE.Contain(model.APPROVEDEPTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVEDEPTNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.APPROVEDEPTNAME.Contain(model.APPROVEDEPTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORMCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.PLATFORMCODE.Contain(model.PLATFORMCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBSERVICEPLATCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.PUBSERVICEPLATCODE.Contain(model.PUBSERVICEPLATCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.INFOREPORTERNAME.Contain(model.INFOREPORTERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERCODETYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.INFOREPORTERCODETYPE.Contain(model.INFOREPORTERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.INFOREPORTERCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.INFOREPORTERCODE.Contain(model.INFOREPORTERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_TENDERPROJECT._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_TENDERPROJECT._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_TENDERPROJECT._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_TENDERPROJECT._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_TENDERPROJECT._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_TENDERPROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}