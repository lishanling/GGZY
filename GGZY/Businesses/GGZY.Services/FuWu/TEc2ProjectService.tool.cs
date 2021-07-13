using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2ProjectService : BaseServiceT<T_EC2_PROJECT>
    {
        #region 接口实现
        
		public List<T_EC2_PROJECT> FindList(T_EC2_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_PROJECT> PageList(T_EC2_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_PROJECT._.PROJECTCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="PROJECTCODE">项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string PROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_PROJECT._.PROJECTCODE == PROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.PROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_PROJECT entity)
	{		
		entity.Attach();
		entity.PROJECTCODE=model.PROJECTCODE;
		entity.TRADEPLATFPROJECTCODE=model.TRADEPLATFPROJECTCODE;
		entity.PROJECTNAME=model.PROJECTNAME;
		entity.REGIONCODE=model.REGIONCODE;
		entity.ADDRESS=model.ADDRESS;
		entity.LEGALPERSON=model.LEGALPERSON;
		entity.INDUSTRIESTYPE=model.INDUSTRIESTYPE;
		entity.FUNDSOURCE=model.FUNDSOURCE;
		entity.PROJECTSCALE=model.PROJECTSCALE;
		entity.CONNECTOR=model.CONNECTOR;
		entity.CONTACTINFORMATION=model.CONTACTINFORMATION;
		entity.APPROVALNAME=model.APPROVALNAME;
		entity.APPROVALNUMBER=model.APPROVALNUMBER;
		entity.APPROVALAUTHORITY=model.APPROVALAUTHORITY;
		entity.CREATETIME=model.CREATETIME;
		entity.ATTACHMENTCODE=model.ATTACHMENTCODE;
		entity.VERSION=model.VERSION;
		entity.ISOPEN=model.ISOPEN;
		entity.OPENTYPE=model.OPENTYPE;
		entity.EXAMINERNAME=model.EXAMINERNAME;
		entity.EXAMINERCODETYPE=model.EXAMINERCODETYPE;
		entity.EXAMINERCODE=model.EXAMINERCODE;
		entity.VERIFYTIME=model.VERIFYTIME;
		entity.INVESTMENTAMOUNT=model.INVESTMENTAMOUNT;
		entity.CURRENCYCODE=model.CURRENCYCODE;
		entity.PRICEUNIT=model.PRICEUNIT;
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
        public GeneralResult Add(T_EC2_PROJECT model)
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
                    Delete(T_EC2_PROJECT._.PROJECTCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECTCODE))
				{
				  condition.And(T_EC2_PROJECT._.PROJECTCODE.Contain(model.PROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADEPLATFPROJECTCODE))
				{
				  condition.And(T_EC2_PROJECT._.TRADEPLATFPROJECTCODE.Contain(model.TRADEPLATFPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECTNAME))
				{
				  condition.And(T_EC2_PROJECT._.PROJECTNAME.Contain(model.PROJECTNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REGIONCODE))
				{
				  condition.And(T_EC2_PROJECT._.REGIONCODE.Contain(model.REGIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(T_EC2_PROJECT._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGALPERSON))
				{
				  condition.And(T_EC2_PROJECT._.LEGALPERSON.Contain(model.LEGALPERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRIESTYPE))
				{
				  condition.And(T_EC2_PROJECT._.INDUSTRIESTYPE.Contain(model.INDUSTRIESTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.FUNDSOURCE))
				{
				  condition.And(T_EC2_PROJECT._.FUNDSOURCE.Contain(model.FUNDSOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECTSCALE))
				{
				  condition.And(T_EC2_PROJECT._.PROJECTSCALE.Contain(model.PROJECTSCALE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONNECTOR))
				{
				  condition.And(T_EC2_PROJECT._.CONNECTOR.Contain(model.CONNECTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTINFORMATION))
				{
				  condition.And(T_EC2_PROJECT._.CONTACTINFORMATION.Contain(model.CONTACTINFORMATION));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVALNAME))
				{
				  condition.And(T_EC2_PROJECT._.APPROVALNAME.Contain(model.APPROVALNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVALNUMBER))
				{
				  condition.And(T_EC2_PROJECT._.APPROVALNUMBER.Contain(model.APPROVALNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVALAUTHORITY))
				{
				  condition.And(T_EC2_PROJECT._.APPROVALAUTHORITY.Contain(model.APPROVALAUTHORITY));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_EC2_PROJECT._.CREATETIME==(model.CREATETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_PROJECT._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_PROJECT._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_PROJECT._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_PROJECT._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_PROJECT._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_PROJECT._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_PROJECT._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_PROJECT._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(model.INVESTMENTAMOUNT!=null)
				{
				  condition.And(T_EC2_PROJECT._.INVESTMENTAMOUNT==(model.INVESTMENTAMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCYCODE))
				{
				  condition.And(T_EC2_PROJECT._.CURRENCYCODE.Contain(model.CURRENCYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICEUNIT))
				{
				  condition.And(T_EC2_PROJECT._.PRICEUNIT.Contain(model.PRICEUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_PROJECT._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}