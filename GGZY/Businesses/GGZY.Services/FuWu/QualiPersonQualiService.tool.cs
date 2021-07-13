using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class QualiPersonQualiService : BaseServiceT<QUALI_PERSON_QUALI>
    {
        #region 接口实现
        
		public List<QUALI_PERSON_QUALI> FindList(QUALI_PERSON_QUALI model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<QUALI_PERSON_QUALI> PageList(QUALI_PERSON_QUALI model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, QUALI_PERSON_QUALI._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(QUALI_PERSON_QUALI._.M_ID == M_ID);
			
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
        public GeneralResult Edit(QUALI_PERSON_QUALI model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is QUALI_PERSON_QUALI entity)
	{		
		entity.Attach();
		entity.QUAL_NAME=model.QUAL_NAME;
		entity.QUAL_TYPE=model.QUAL_TYPE;
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.CERT_NO=model.CERT_NO;
		entity.CERT_END_DATE=model.CERT_END_DATE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ATT_QUALI_PERSON_QUALI=model.M_ATT_QUALI_PERSON_QUALI;
		entity.M_F_ID=model.M_F_ID;
		entity.M_ID=model.M_ID;
		entity.M_ATT_PROFESSIONAL_CART_DOC=model.M_ATT_PROFESSIONAL_CART_DOC;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_VERSION=model.M_VERSION;
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
        public GeneralResult Add(QUALI_PERSON_QUALI model)
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
                    Delete(QUALI_PERSON_QUALI._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<QUALI_PERSON_QUALI> model)
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
       	protected WhereClipBuilder ConditionBuilder(QUALI_PERSON_QUALI model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.QUAL_NAME))
				{
				  condition.And(QUALI_PERSON_QUALI._.QUAL_NAME.Contain(model.QUAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(QUALI_PERSON_QUALI._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(QUALI_PERSON_QUALI._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(QUALI_PERSON_QUALI._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CERT_NO))
				{
				  condition.And(QUALI_PERSON_QUALI._.CERT_NO.Contain(model.CERT_NO));
				}
				if(model.CERT_END_DATE!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.CERT_END_DATE==(model.CERT_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(QUALI_PERSON_QUALI._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(QUALI_PERSON_QUALI._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(QUALI_PERSON_QUALI._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(QUALI_PERSON_QUALI._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUALI_PERSON_QUALI))
				{
				  condition.And(QUALI_PERSON_QUALI._.M_ATT_QUALI_PERSON_QUALI.Contain(model.M_ATT_QUALI_PERSON_QUALI));
				}
				if(model.M_F_ID!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.M_F_ID==(model.M_F_ID));
				}
				if(model.M_ID!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROFESSIONAL_CART_DOC))
				{
				  condition.And(QUALI_PERSON_QUALI._.M_ATT_PROFESSIONAL_CART_DOC.Contain(model.M_ATT_PROFESSIONAL_CART_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(QUALI_PERSON_QUALI._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(QUALI_PERSON_QUALI._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}