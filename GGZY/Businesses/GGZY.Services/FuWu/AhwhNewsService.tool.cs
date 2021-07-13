using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AhwhNewsService : BaseServiceT<AHWH_NEWS>
    {
        #region 接口实现
        
		public List<AHWH_NEWS> FindList(AHWH_NEWS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<AHWH_NEWS> PageList(AHWH_NEWS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, AHWH_NEWS._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(AHWH_NEWS._.ID == ID);
			
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
        public GeneralResult Edit(AHWH_NEWS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is AHWH_NEWS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.U_ID=model.U_ID;
		entity.TIME=model.TIME;
		entity.TYPE=model.TYPE;
		entity.READ_NUM=model.READ_NUM;
		entity.TITLE=model.TITLE;
		entity.CONTENTS=model.CONTENTS;
		entity.SOURCES=model.SOURCES;
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
        public GeneralResult Add(AHWH_NEWS model)
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
                    Delete(AHWH_NEWS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<AHWH_NEWS> model)
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
       	protected WhereClipBuilder ConditionBuilder(AHWH_NEWS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(AHWH_NEWS._.ID==(model.ID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(AHWH_NEWS._.U_ID==(model.U_ID));
				}
				if(model.TIME!=null)
				{
				  condition.And(AHWH_NEWS._.TIME==(model.TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(AHWH_NEWS._.TYPE.Contain(model.TYPE));
				}
				if(model.READ_NUM!=null)
				{
				  condition.And(AHWH_NEWS._.READ_NUM==(model.READ_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(AHWH_NEWS._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENTS))
				{
				  condition.And(AHWH_NEWS._.CONTENTS.Contain(model.CONTENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.SOURCES))
				{
				  condition.And(AHWH_NEWS._.SOURCES.Contain(model.SOURCES));
				}
		return condition;
	}
        #endregion
    }
}