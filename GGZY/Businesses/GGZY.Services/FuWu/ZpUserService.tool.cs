using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZpUserService : BaseServiceT<ZP_USER>
    {
        #region 接口实现
        
		public List<ZP_USER> FindList(ZP_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZP_USER> PageList(ZP_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZP_USER._.ZP_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ZP_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ZP_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZP_USER._.ZP_ID == ZP_ID);
			
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
        public GeneralResult Edit(ZP_USER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ZP_ID);
	
	if(viewResult.Success  && viewResult.Data is ZP_USER entity)
	{		
		entity.Attach();
		entity.ZP_ID=model.ZP_ID;
		entity.ZP_USERNAME=model.ZP_USERNAME;
		entity.ZP_PASSWORD=model.ZP_PASSWORD;
		entity.ZP_PERSONNAME=model.ZP_PERSONNAME;
		entity.ZP_PHONE=model.ZP_PHONE;
		entity.ZP_POST=model.ZP_POST;
		entity.ZP_FAX=model.ZP_FAX;
		entity.ZP_UNIT=model.ZP_UNIT;
		entity.ZP_ADDRESS=model.ZP_ADDRESS;
		entity.ZP_INDUSTRY=model.ZP_INDUSTRY;
		entity.ZP_USERTYPE=model.ZP_USERTYPE;
		entity.ZP_USERSTATE=model.ZP_USERSTATE;
		entity.ZP_EMAIL=model.ZP_EMAIL;
		entity.CRTIME=model.CRTIME;
		entity.ZP_SEX=model.ZP_SEX;
		entity.ZP_EDUCATION=model.ZP_EDUCATION;
		entity.ZP_TITLE=model.ZP_TITLE;
		entity.ZP_RETIREMENT=model.ZP_RETIREMENT;
		entity.ZP_SPECIALITY=model.ZP_SPECIALITY;
		entity.ZP_EDITTIME=model.ZP_EDITTIME;
		entity.ZP_STATE=model.ZP_STATE;
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
        public GeneralResult Add(ZP_USER model)
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
                    Delete(ZP_USER._.ZP_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZP_USER> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZP_USER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ZP_ID!=null)
				{
				  condition.And(ZP_USER._.ZP_ID==(model.ZP_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_USERNAME))
				{
				  condition.And(ZP_USER._.ZP_USERNAME.Contain(model.ZP_USERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_PASSWORD))
				{
				  condition.And(ZP_USER._.ZP_PASSWORD.Contain(model.ZP_PASSWORD));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_PERSONNAME))
				{
				  condition.And(ZP_USER._.ZP_PERSONNAME.Contain(model.ZP_PERSONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_PHONE))
				{
				  condition.And(ZP_USER._.ZP_PHONE.Contain(model.ZP_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_POST))
				{
				  condition.And(ZP_USER._.ZP_POST.Contain(model.ZP_POST));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_FAX))
				{
				  condition.And(ZP_USER._.ZP_FAX.Contain(model.ZP_FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_UNIT))
				{
				  condition.And(ZP_USER._.ZP_UNIT.Contain(model.ZP_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_ADDRESS))
				{
				  condition.And(ZP_USER._.ZP_ADDRESS.Contain(model.ZP_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_INDUSTRY))
				{
				  condition.And(ZP_USER._.ZP_INDUSTRY.Contain(model.ZP_INDUSTRY));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_USERTYPE))
				{
				  condition.And(ZP_USER._.ZP_USERTYPE.Contain(model.ZP_USERTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_USERSTATE))
				{
				  condition.And(ZP_USER._.ZP_USERSTATE.Contain(model.ZP_USERSTATE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_EMAIL))
				{
				  condition.And(ZP_USER._.ZP_EMAIL.Contain(model.ZP_EMAIL));
				}
				if(model.CRTIME!=null)
				{
				  condition.And(ZP_USER._.CRTIME==(model.CRTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_SEX))
				{
				  condition.And(ZP_USER._.ZP_SEX.Contain(model.ZP_SEX));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_EDUCATION))
				{
				  condition.And(ZP_USER._.ZP_EDUCATION.Contain(model.ZP_EDUCATION));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_TITLE))
				{
				  condition.And(ZP_USER._.ZP_TITLE.Contain(model.ZP_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_RETIREMENT))
				{
				  condition.And(ZP_USER._.ZP_RETIREMENT.Contain(model.ZP_RETIREMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_SPECIALITY))
				{
				  condition.And(ZP_USER._.ZP_SPECIALITY.Contain(model.ZP_SPECIALITY));
				}
				if(model.ZP_EDITTIME!=null)
				{
				  condition.And(ZP_USER._.ZP_EDITTIME==(model.ZP_EDITTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_STATE))
				{
				  condition.And(ZP_USER._.ZP_STATE.Contain(model.ZP_STATE));
				}
		return condition;
	}
        #endregion
    }
}