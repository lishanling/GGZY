using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TExpertBlacklistService : BaseServiceT<T_EXPERT_BLACKLIST>
    {
        #region 接口实现
        
		public List<T_EXPERT_BLACKLIST> FindList(T_EXPERT_BLACKLIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EXPERT_BLACKLIST> PageList(T_EXPERT_BLACKLIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EXPERT_BLACKLIST._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EXPERT_BLACKLIST._.ID == ID);
			
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
        public GeneralResult Edit(T_EXPERT_BLACKLIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_EXPERT_BLACKLIST entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.EXPERT_NO=model.EXPERT_NO;
		entity.EXPERT_NAME=model.EXPERT_NAME;
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.REASON_BLACK=model.REASON_BLACK;
		entity.M_ATTACHMENT=model.M_ATTACHMENT;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_KEY=model.M_KEY;
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
        public GeneralResult Add(T_EXPERT_BLACKLIST model)
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
                    Delete(T_EXPERT_BLACKLIST._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EXPERT_BLACKLIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EXPERT_BLACKLIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_EXPERT_BLACKLIST._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NO))
				{
				  condition.And(T_EXPERT_BLACKLIST._.EXPERT_NO.Contain(model.EXPERT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
				{
				  condition.And(T_EXPERT_BLACKLIST._.EXPERT_NAME.Contain(model.EXPERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(T_EXPERT_BLACKLIST._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(T_EXPERT_BLACKLIST._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REASON_BLACK))
				{
				  condition.And(T_EXPERT_BLACKLIST._.REASON_BLACK.Contain(model.REASON_BLACK));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATTACHMENT))
				{
				  condition.And(T_EXPERT_BLACKLIST._.M_ATTACHMENT.Contain(model.M_ATTACHMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_EXPERT_BLACKLIST._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_EXPERT_BLACKLIST._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_EXPERT_BLACKLIST._.M_KEY.Contain(model.M_KEY));
				}
		return condition;
	}
        #endregion
    }
}