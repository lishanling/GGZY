using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TAnswerAnnService : BaseServiceT<T_ANSWER_ANN>
    {
        #region 接口实现
        
		public List<T_ANSWER_ANN> FindList(T_ANSWER_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ANSWER_ANN> PageList(T_ANSWER_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ANSWER_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_ANSWER_ANN._.ID == ID);
			
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
        public GeneralResult Edit(T_ANSWER_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_ANSWER_ANN entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.ANN_ID=model.ANN_ID;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.ANN_CONTENT=model.ANN_CONTENT;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_TM=model.M_TM;
		entity.M_ATT_FILE_EX_TDOC=model.M_ATT_FILE_EX_TDOC;
		entity.TITLE=model.TITLE;
		entity.M_ZPID=model.M_ZPID;
		entity.M_STATUS=model.M_STATUS;
		entity.M_REMARK=model.M_REMARK;
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
        public GeneralResult Add(T_ANSWER_ANN model)
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
                    Delete(T_ANSWER_ANN._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ANSWER_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ANSWER_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_ANSWER_ANN._.ID==(model.ID));
				}
				if(model.ANN_ID!=null)
				{
				  condition.And(T_ANSWER_ANN._.ANN_ID==(model.ANN_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_ANSWER_ANN._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(T_ANSWER_ANN._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.ANN_CONTENT))
				{
				  condition.And(T_ANSWER_ANN._.ANN_CONTENT.Contain(model.ANN_CONTENT));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(T_ANSWER_ANN._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_ANSWER_ANN._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC))
				{
				  condition.And(T_ANSWER_ANN._.M_ATT_FILE_EX_TDOC.Contain(model.M_ATT_FILE_EX_TDOC));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_ANSWER_ANN._.TITLE.Contain(model.TITLE));
				}
				if(model.M_ZPID!=null)
				{
				  condition.And(T_ANSWER_ANN._.M_ZPID==(model.M_ZPID));
				}
				if(model.M_STATUS!=null)
				{
				  condition.And(T_ANSWER_ANN._.M_STATUS==(model.M_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_REMARK))
				{
				  condition.And(T_ANSWER_ANN._.M_REMARK.Contain(model.M_REMARK));
				}
		return condition;
	}
        #endregion
    }
}