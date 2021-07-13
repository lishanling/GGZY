using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2TenderbulletinService : BaseServiceT<T_EC2_TENDERBULLETIN>
    {
        #region 接口实现
        
		public List<T_EC2_TENDERBULLETIN> FindList(T_EC2_TENDERBULLETIN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_TENDERBULLETIN> PageList(T_EC2_TENDERBULLETIN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_TENDERBULLETIN._.TENDERBULLETINCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TENDERBULLETINCODE">招标公告编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string TENDERBULLETINCODE,string TENDERPROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_TENDERBULLETIN._.TENDERBULLETINCODE == TENDERBULLETINCODE);
			condition.And(T_EC2_TENDERBULLETIN._.TENDERPROJECTCODE == TENDERPROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_TENDERBULLETIN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TENDERBULLETINCODE,model.TENDERPROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_TENDERBULLETIN entity)
	{		
		entity.Attach();
		entity.TENDERBULLETINCODE=model.TENDERBULLETINCODE;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.BULLETINNATURE=model.BULLETINNATURE;
		entity.BULLETINTYPE=model.BULLETINTYPE;
		entity.TENDERDOCGETSTARTTIME=model.TENDERDOCGETSTARTTIME;
		entity.TENDERDOCGETMETHOD=model.TENDERDOCGETMETHOD;
		entity.TENDERDOCDEADLINE=model.TENDERDOCDEADLINE;
		entity.BIDDOCREFERENDTIME=model.BIDDOCREFERENDTIME;
		entity.BIDDOCREFERMETHOD=model.BIDDOCREFERMETHOD;
		entity.BULLETINNAME=model.BULLETINNAME;
		entity.BULLETINCONTENT=model.BULLETINCONTENT;
		entity.BULLETINISSUETIME=model.BULLETINISSUETIME;
		entity.BIDSECTIONCODES=model.BIDSECTIONCODES;
		entity.TENDERMODE=model.TENDERMODE;
		entity.BULLETINENDTIME=model.BULLETINENDTIME;
		entity.BULLETINDUTY=model.BULLETINDUTY;
		entity.BULLETINDUTYCODETYPE=model.BULLETINDUTYCODETYPE;
		entity.BULLETINDUTYCODE=model.BULLETINDUTYCODE;
		entity.BULLETINMEDIA=model.BULLETINMEDIA;
		entity.URL=model.URL;
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
        public GeneralResult Add(T_EC2_TENDERBULLETIN model)
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
                    Delete(T_EC2_TENDERBULLETIN._.TENDERBULLETINCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_TENDERBULLETIN> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_TENDERBULLETIN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDERBULLETINCODE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.TENDERBULLETINCODE.Contain(model.TENDERBULLETINCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINNATURE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINNATURE.Contain(model.BULLETINNATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINTYPE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINTYPE.Contain(model.BULLETINTYPE));
				}
				if(model.TENDERDOCGETSTARTTIME!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.TENDERDOCGETSTARTTIME==(model.TENDERDOCGETSTARTTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERDOCGETMETHOD))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.TENDERDOCGETMETHOD.Contain(model.TENDERDOCGETMETHOD));
				}
				if(model.TENDERDOCDEADLINE!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.TENDERDOCDEADLINE==(model.TENDERDOCDEADLINE));
				}
				if(model.BIDDOCREFERENDTIME!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BIDDOCREFERENDTIME==(model.BIDDOCREFERENDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDOCREFERMETHOD))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BIDDOCREFERMETHOD.Contain(model.BIDDOCREFERMETHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINNAME))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINNAME.Contain(model.BULLETINNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINCONTENT))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINCONTENT.Contain(model.BULLETINCONTENT));
				}
				if(model.BULLETINISSUETIME!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINISSUETIME==(model.BULLETINISSUETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODES))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BIDSECTIONCODES.Contain(model.BIDSECTIONCODES));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERMODE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.TENDERMODE.Contain(model.TENDERMODE));
				}
				if(model.BULLETINENDTIME!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINENDTIME==(model.BULLETINENDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINDUTY))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINDUTY.Contain(model.BULLETINDUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINDUTYCODETYPE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINDUTYCODETYPE.Contain(model.BULLETINDUTYCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINDUTYCODE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINDUTYCODE.Contain(model.BULLETINDUTYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETINMEDIA))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.BULLETINMEDIA.Contain(model.BULLETINMEDIA));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_TENDERBULLETIN._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_TENDERBULLETIN._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}