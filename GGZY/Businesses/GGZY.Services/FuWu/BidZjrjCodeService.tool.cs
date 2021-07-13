using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BidZjrjCodeService : BaseServiceT<BID_ZJRJ_CODE>
    {
        #region 接口实现
        
		public List<BID_ZJRJ_CODE> FindList(BID_ZJRJ_CODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BID_ZJRJ_CODE> PageList(BID_ZJRJ_CODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BID_ZJRJ_CODE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BID_ZJRJ_CODE._.ID == ID);
			
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
        public GeneralResult Edit(BID_ZJRJ_CODE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is BID_ZJRJ_CODE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BDMC=model.BDMC;
		entity.CPUXLH=model.CPUXLH;
		entity.GHSJ=model.GHSJ;
		entity.IPDZ=model.IPDZ;
		entity.JMSXLH=model.JMSXLH;
		entity.NCXLH=model.NCXLH;
		entity.RJBBH=model.RJBBH;
		entity.RJGSMC=model.RJGSMC;
		entity.TBRMC=model.TBRMC;
		entity.WKDZ=model.WKDZ;
		entity.YPXLH=model.YPXLH;
		entity.ZBXMMC=model.ZBXMMC;
		entity.TENDER_DOC_SUBMITTIME=model.TENDER_DOC_SUBMITTIME;
		entity.VALUATION_XML=model.VALUATION_XML;
		entity.CREATETIME=model.CREATETIME;
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
        public GeneralResult Add(BID_ZJRJ_CODE model)
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
                    Delete(BID_ZJRJ_CODE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BID_ZJRJ_CODE> model)
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
       	protected WhereClipBuilder ConditionBuilder(BID_ZJRJ_CODE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(BID_ZJRJ_CODE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(BID_ZJRJ_CODE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(BID_ZJRJ_CODE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(BID_ZJRJ_CODE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BDMC))
				{
				  condition.And(BID_ZJRJ_CODE._.BDMC.Contain(model.BDMC));
				}
				if(!string.IsNullOrWhiteSpace(model.CPUXLH))
				{
				  condition.And(BID_ZJRJ_CODE._.CPUXLH.Contain(model.CPUXLH));
				}
				if(!string.IsNullOrWhiteSpace(model.GHSJ))
				{
				  condition.And(BID_ZJRJ_CODE._.GHSJ.Contain(model.GHSJ));
				}
				if(!string.IsNullOrWhiteSpace(model.IPDZ))
				{
				  condition.And(BID_ZJRJ_CODE._.IPDZ.Contain(model.IPDZ));
				}
				if(!string.IsNullOrWhiteSpace(model.JMSXLH))
				{
				  condition.And(BID_ZJRJ_CODE._.JMSXLH.Contain(model.JMSXLH));
				}
				if(!string.IsNullOrWhiteSpace(model.NCXLH))
				{
				  condition.And(BID_ZJRJ_CODE._.NCXLH.Contain(model.NCXLH));
				}
				if(!string.IsNullOrWhiteSpace(model.RJBBH))
				{
				  condition.And(BID_ZJRJ_CODE._.RJBBH.Contain(model.RJBBH));
				}
				if(!string.IsNullOrWhiteSpace(model.RJGSMC))
				{
				  condition.And(BID_ZJRJ_CODE._.RJGSMC.Contain(model.RJGSMC));
				}
				if(!string.IsNullOrWhiteSpace(model.TBRMC))
				{
				  condition.And(BID_ZJRJ_CODE._.TBRMC.Contain(model.TBRMC));
				}
				if(!string.IsNullOrWhiteSpace(model.WKDZ))
				{
				  condition.And(BID_ZJRJ_CODE._.WKDZ.Contain(model.WKDZ));
				}
				if(!string.IsNullOrWhiteSpace(model.YPXLH))
				{
				  condition.And(BID_ZJRJ_CODE._.YPXLH.Contain(model.YPXLH));
				}
				if(!string.IsNullOrWhiteSpace(model.ZBXMMC))
				{
				  condition.And(BID_ZJRJ_CODE._.ZBXMMC.Contain(model.ZBXMMC));
				}
				if(model.TENDER_DOC_SUBMITTIME!=null)
				{
				  condition.And(BID_ZJRJ_CODE._.TENDER_DOC_SUBMITTIME==(model.TENDER_DOC_SUBMITTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUATION_XML))
				{
				  condition.And(BID_ZJRJ_CODE._.VALUATION_XML.Contain(model.VALUATION_XML));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(BID_ZJRJ_CODE._.CREATETIME==(model.CREATETIME));
				}
		return condition;
	}
        #endregion
    }
}