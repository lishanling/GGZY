using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2WincandidatebulletinService : BaseServiceT<T_EC2_WINCANDIDATEBULLETIN>
    {
        #region 接口实现
        
		public List<T_EC2_WINCANDIDATEBULLETIN> FindList(T_EC2_WINCANDIDATEBULLETIN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_WINCANDIDATEBULLETIN> PageList(T_EC2_WINCANDIDATEBULLETIN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_WINCANDIDATEBULLETIN._.WINCANDIDATEBULLETINCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="WINCANDIDATEBULLETINCODE">中标候选人公示编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string WINCANDIDATEBULLETINCODE,string TENDERPROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_WINCANDIDATEBULLETIN._.WINCANDIDATEBULLETINCODE == WINCANDIDATEBULLETINCODE);
			condition.And(T_EC2_WINCANDIDATEBULLETIN._.TENDERPROJECTCODE == TENDERPROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_WINCANDIDATEBULLETIN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.WINCANDIDATEBULLETINCODE,model.TENDERPROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_WINCANDIDATEBULLETIN entity)
	{		
		entity.Attach();
		entity.WINCANDIDATEBULLETINCODE=model.WINCANDIDATEBULLETINCODE;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.TENDERPROJECTNAME=model.TENDERPROJECTNAME;
		entity.BIDSECTIONCODES=model.BIDSECTIONCODES;
		entity.PUBLICITYNAME=model.PUBLICITYNAME;
		entity.PUBLICITYTYPE=model.PUBLICITYTYPE;
		entity.PUBLICITYSTARTTIME=model.PUBLICITYSTARTTIME;
		entity.PUBLICITYENDTIME=model.PUBLICITYENDTIME;
		entity.PUBLICITYCONTENT=model.PUBLICITYCONTENT;
		entity.PUBLICITYREFERTIME=model.PUBLICITYREFERTIME;
		entity.BULLETINISSUETIME=model.BULLETINISSUETIME;
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
        public GeneralResult Add(T_EC2_WINCANDIDATEBULLETIN model)
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
                    Delete(T_EC2_WINCANDIDATEBULLETIN._.WINCANDIDATEBULLETINCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_WINCANDIDATEBULLETIN> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_WINCANDIDATEBULLETIN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.WINCANDIDATEBULLETINCODE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.WINCANDIDATEBULLETINCODE.Contain(model.WINCANDIDATEBULLETINCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTNAME))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.TENDERPROJECTNAME.Contain(model.TENDERPROJECTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODES))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.BIDSECTIONCODES.Contain(model.BIDSECTIONCODES));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITYNAME))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.PUBLICITYNAME.Contain(model.PUBLICITYNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITYTYPE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.PUBLICITYTYPE.Contain(model.PUBLICITYTYPE));
				}
				if(model.PUBLICITYSTARTTIME!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.PUBLICITYSTARTTIME==(model.PUBLICITYSTARTTIME));
				}
				if(model.PUBLICITYENDTIME!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.PUBLICITYENDTIME==(model.PUBLICITYENDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITYCONTENT))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.PUBLICITYCONTENT.Contain(model.PUBLICITYCONTENT));
				}
				if(model.PUBLICITYREFERTIME!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.PUBLICITYREFERTIME==(model.PUBLICITYREFERTIME));
				}
				if(model.BULLETINISSUETIME!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.BULLETINISSUETIME==(model.BULLETINISSUETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_WINCANDIDATEBULLETIN._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}