using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class VVideobasicinfoService : BaseServiceT<V_VIDEOBASICINFO>
    {
        #region 接口实现
        
		public List<V_VIDEOBASICINFO> FindList(V_VIDEOBASICINFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<V_VIDEOBASICINFO> PageList(V_VIDEOBASICINFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, V_VIDEOBASICINFO._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="VID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? VID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(V_VIDEOBASICINFO._.VID == VID);
			
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
        public GeneralResult Edit(V_VIDEOBASICINFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.VID);
	
	if(viewResult.Success  && viewResult.Data is V_VIDEOBASICINFO entity)
	{		
		entity.Attach();
		entity.VID=model.VID;
		entity.VNAME=model.VNAME;
		entity.SERVERIP=model.SERVERIP;
		entity.SERVERPORT=model.SERVERPORT;
		entity.LOGINACCOUNT=model.LOGINACCOUNT;
		entity.VPASSWORD=model.VPASSWORD;
		entity.VISIBLE=model.VISIBLE;
		entity.AREACODE=model.AREACODE;
		entity.RTYPE=model.RTYPE;
		entity.ORDER_BY=model.ORDER_BY;
		entity.VCODE=model.VCODE;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(V_VIDEOBASICINFO model)
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
                    Delete(V_VIDEOBASICINFO._.VID.SelectIn(idArr));
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
        public GeneralResult Import(List<V_VIDEOBASICINFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(V_VIDEOBASICINFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.VID!=null)
				{
				  condition.And(V_VIDEOBASICINFO._.VID==(model.VID));
				}
				if(!string.IsNullOrWhiteSpace(model.VNAME))
				{
				  condition.And(V_VIDEOBASICINFO._.VNAME.Contain(model.VNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVERIP))
				{
				  condition.And(V_VIDEOBASICINFO._.SERVERIP.Contain(model.SERVERIP));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVERPORT))
				{
				  condition.And(V_VIDEOBASICINFO._.SERVERPORT.Contain(model.SERVERPORT));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGINACCOUNT))
				{
				  condition.And(V_VIDEOBASICINFO._.LOGINACCOUNT.Contain(model.LOGINACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.VPASSWORD))
				{
				  condition.And(V_VIDEOBASICINFO._.VPASSWORD.Contain(model.VPASSWORD));
				}
				if(model.VISIBLE!=null)
				{
				  condition.And(V_VIDEOBASICINFO._.VISIBLE==(model.VISIBLE));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(V_VIDEOBASICINFO._.AREACODE.Contain(model.AREACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.RTYPE))
				{
				  condition.And(V_VIDEOBASICINFO._.RTYPE.Contain(model.RTYPE));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(V_VIDEOBASICINFO._.ORDER_BY==(model.ORDER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.VCODE))
				{
				  condition.And(V_VIDEOBASICINFO._.VCODE.Contain(model.VCODE));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(V_VIDEOBASICINFO._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(V_VIDEOBASICINFO._.CREATE_TM==(model.CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}