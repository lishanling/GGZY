using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2GoodsopenbidlistService : BaseServiceT<T_EC2_GOODSOPENBIDLIST>
    {
        #region 接口实现
        
		public List<T_EC2_GOODSOPENBIDLIST> FindList(T_EC2_GOODSOPENBIDLIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_GOODSOPENBIDLIST> PageList(T_EC2_GOODSOPENBIDLIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_GOODSOPENBIDLIST._.GOODSOPENBIDLISTCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="GOODSOPENBIDLISTCODE">开标明细（货物）编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string GOODSOPENBIDLISTCODE,string BIDSECTIONCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_GOODSOPENBIDLIST._.GOODSOPENBIDLISTCODE == GOODSOPENBIDLISTCODE);
			condition.And(T_EC2_GOODSOPENBIDLIST._.BIDSECTIONCODE == BIDSECTIONCODE);
			
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
        public GeneralResult Edit(T_EC2_GOODSOPENBIDLIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.GOODSOPENBIDLISTCODE,model.BIDSECTIONCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_GOODSOPENBIDLIST entity)
	{		
		entity.Attach();
		entity.GOODSOPENBIDLISTCODE=model.GOODSOPENBIDLISTCODE;
		entity.OPENBIDRECORDCODE=model.OPENBIDRECORDCODE;
		entity.BIDSECTIONCODE=model.BIDSECTIONCODE;
		entity.ISUNION=model.ISUNION;
		entity.UNIONCODETYPE=model.UNIONCODETYPE;
		entity.UNIONCODE=model.UNIONCODE;
		entity.UNIONNAME=model.UNIONNAME;
		entity.UNIONMEMBERBASICINFOVERSION=model.UNIONMEMBERBASICINFOVERSION;
		entity.BIDDERCODETYPE=model.BIDDERCODETYPE;
		entity.BIDDERCODE=model.BIDDERCODE;
		entity.BIDDERNAME=model.BIDDERNAME;
		entity.BIDDERBASICINFOVERSION=model.BIDDERBASICINFOVERSION;
		entity.DURATION=model.DURATION;
		entity.DELIVERYPLACE=model.DELIVERYPLACE;
		entity.BIDAMOUNT=model.BIDAMOUNT;
		entity.CURRENCYCODE=model.CURRENCYCODE;
		entity.PRICEUNIT=model.PRICEUNIT;
		entity.OTHERBIDPRICE=model.OTHERBIDPRICE;
		entity.OTHEROPENBIDCONTENT=model.OTHEROPENBIDCONTENT;
		entity.VERSION=model.VERSION;
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
        public GeneralResult Add(T_EC2_GOODSOPENBIDLIST model)
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
                    Delete(T_EC2_GOODSOPENBIDLIST._.GOODSOPENBIDLISTCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_GOODSOPENBIDLIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_GOODSOPENBIDLIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.GOODSOPENBIDLISTCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.GOODSOPENBIDLISTCODE.Contain(model.GOODSOPENBIDLISTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENBIDRECORDCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.OPENBIDRECORDCODE.Contain(model.OPENBIDRECORDCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.BIDSECTIONCODE.Contain(model.BIDSECTIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ISUNION))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.ISUNION.Contain(model.ISUNION));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIONCODETYPE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.UNIONCODETYPE.Contain(model.UNIONCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIONCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.UNIONCODE.Contain(model.UNIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIONNAME))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.UNIONNAME.Contain(model.UNIONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIONMEMBERBASICINFOVERSION))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.UNIONMEMBERBASICINFOVERSION.Contain(model.UNIONMEMBERBASICINFOVERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDERCODETYPE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.BIDDERCODETYPE.Contain(model.BIDDERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDERCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.BIDDERCODE.Contain(model.BIDDERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDERNAME))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.BIDDERNAME.Contain(model.BIDDERNAME));
				}
				if(model.BIDDERBASICINFOVERSION!=null)
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.BIDDERBASICINFOVERSION==(model.BIDDERBASICINFOVERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DURATION))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.DURATION.Contain(model.DURATION));
				}
				if(!string.IsNullOrWhiteSpace(model.DELIVERYPLACE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.DELIVERYPLACE.Contain(model.DELIVERYPLACE));
				}
				if(model.BIDAMOUNT!=null)
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.BIDAMOUNT==(model.BIDAMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCYCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.CURRENCYCODE.Contain(model.CURRENCYCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICEUNIT))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.PRICEUNIT.Contain(model.PRICEUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHERBIDPRICE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.OTHERBIDPRICE.Contain(model.OTHERBIDPRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHEROPENBIDCONTENT))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.OTHEROPENBIDCONTENT.Contain(model.OTHEROPENBIDCONTENT));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_GOODSOPENBIDLIST._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}