using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2BidsectionService : BaseServiceT<T_EC2_BIDSECTION>
    {
        #region 接口实现
        
		public List<T_EC2_BIDSECTION> FindList(T_EC2_BIDSECTION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_BIDSECTION> PageList(T_EC2_BIDSECTION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_BIDSECTION._.BIDSECTIONCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string BIDSECTIONCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_BIDSECTION._.BIDSECTIONCODE == BIDSECTIONCODE);
			
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
        public GeneralResult Edit(T_EC2_BIDSECTION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.BIDSECTIONCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_BIDSECTION entity)
	{		
		entity.Attach();
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.BIDSECTIONCODE=model.BIDSECTIONCODE;
		entity.TRADEPLATFBIDSECTIONCODE=model.TRADEPLATFBIDSECTIONCODE;
		entity.BIDSECTIONNAME=model.BIDSECTIONNAME;
		entity.BIDSECTIONCONTENT=model.BIDSECTIONCONTENT;
		entity.TENDERPROJECTCLASSIFYCODE=model.TENDERPROJECTCLASSIFYCODE;
		entity.TENDERERCODETYPE=model.TENDERERCODETYPE;
		entity.TENDERERCODE=model.TENDERERCODE;
		entity.TENDERERNAME=model.TENDERERNAME;
		entity.TENDERERBASICINFOVERSION=model.TENDERERBASICINFOVERSION;
		entity.TENDERMODE=model.TENDERMODE;
		entity.CONTRACTRECKONPRICE=model.CONTRACTRECKONPRICE;
		entity.CURRENCYCODE=model.CURRENCYCODE;
		entity.PRICEUNIT=model.PRICEUNIT;
		entity.BIDQUALIFICATION=model.BIDQUALIFICATION;
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
        public GeneralResult Add(T_EC2_BIDSECTION model)
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
                    Delete(T_EC2_BIDSECTION._.BIDSECTIONCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_BIDSECTION> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_BIDSECTION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.BIDSECTIONCODE.Contain(model.BIDSECTIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADEPLATFBIDSECTIONCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.TRADEPLATFBIDSECTIONCODE.Contain(model.TRADEPLATFBIDSECTIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONNAME))
				{
				  condition.And(T_EC2_BIDSECTION._.BIDSECTIONNAME.Contain(model.BIDSECTIONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCONTENT))
				{
				  condition.And(T_EC2_BIDSECTION._.BIDSECTIONCONTENT.Contain(model.BIDSECTIONCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCLASSIFYCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERPROJECTCLASSIFYCODE.Contain(model.TENDERPROJECTCLASSIFYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERERCODETYPE))
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERERCODETYPE.Contain(model.TENDERERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERERCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERERCODE.Contain(model.TENDERERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERERNAME))
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERERNAME.Contain(model.TENDERERNAME));
				}
				if(model.TENDERERBASICINFOVERSION!=null)
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERERBASICINFOVERSION==(model.TENDERERBASICINFOVERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERMODE))
				{
				  condition.And(T_EC2_BIDSECTION._.TENDERMODE.Contain(model.TENDERMODE));
				}
				if(model.CONTRACTRECKONPRICE!=null)
				{
				  condition.And(T_EC2_BIDSECTION._.CONTRACTRECKONPRICE==(model.CONTRACTRECKONPRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCYCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.CURRENCYCODE.Contain(model.CURRENCYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICEUNIT))
				{
				  condition.And(T_EC2_BIDSECTION._.PRICEUNIT.Contain(model.PRICEUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDQUALIFICATION))
				{
				  condition.And(T_EC2_BIDSECTION._.BIDQUALIFICATION.Contain(model.BIDQUALIFICATION));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_BIDSECTION._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_BIDSECTION._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_BIDSECTION._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_BIDSECTION._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_BIDSECTION._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_BIDSECTION._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_BIDSECTION._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_BIDSECTION._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_BIDSECTION._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}