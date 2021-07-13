using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUserQyzcService : BaseServiceT<T_USER_QYZC>
    {
        #region 接口实现
        
		public List<T_USER_QYZC> FindList(T_USER_QYZC model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER_QYZC> PageList(T_USER_QYZC model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_USER_QYZC._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_USER_QYZC._.ID == ID);
			
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
        public GeneralResult Edit(T_USER_QYZC model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_USER_QYZC entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.UNAME=model.UNAME;
		entity.CODE_TYPE=model.CODE_TYPE;
		entity.QY_CODE=model.QY_CODE;
		entity.LXR=model.LXR;
		entity.TEL_PHONE=model.TEL_PHONE;
		entity.CREATETIME=model.CREATETIME;
		entity.STATUS=model.STATUS;
		entity.FILES=model.FILES;
		entity.EMAIL=model.EMAIL;
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
        public GeneralResult Add(T_USER_QYZC model)
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
                    Delete(T_USER_QYZC._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER_QYZC> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_USER_QYZC model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_USER_QYZC._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.UNAME))
				{
				  condition.And(T_USER_QYZC._.UNAME.Contain(model.UNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE_TYPE))
				{
				  condition.And(T_USER_QYZC._.CODE_TYPE.Contain(model.CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.QY_CODE))
				{
				  condition.And(T_USER_QYZC._.QY_CODE.Contain(model.QY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR))
				{
				  condition.And(T_USER_QYZC._.LXR.Contain(model.LXR));
				}
				if(!string.IsNullOrWhiteSpace(model.TEL_PHONE))
				{
				  condition.And(T_USER_QYZC._.TEL_PHONE.Contain(model.TEL_PHONE));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_USER_QYZC._.CREATETIME==(model.CREATETIME));
				}
				if(model.STATUS!=null)
				{
				  condition.And(T_USER_QYZC._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(T_USER_QYZC._.FILES.Contain(model.FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(T_USER_QYZC._.EMAIL.Contain(model.EMAIL));
				}
		return condition;
	}
        #endregion
    }
}