using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AhwhBszxService : BaseServiceT<AHWH_BSZX>
    {
        #region 接口实现
        
		public List<AHWH_BSZX> FindList(AHWH_BSZX model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<AHWH_BSZX> PageList(AHWH_BSZX model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, AHWH_BSZX._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(AHWH_BSZX._.ID == ID);
			
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
        public GeneralResult Edit(AHWH_BSZX model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is AHWH_BSZX entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.TM=model.TM;
		entity.ISPUBLIC=model.ISPUBLIC;
		entity.CONTENTS=model.CONTENTS;
		entity.NAME=model.NAME;
		entity.REPLY=model.REPLY;
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
        public GeneralResult Add(AHWH_BSZX model)
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
                    Delete(AHWH_BSZX._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<AHWH_BSZX> model)
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
       	protected WhereClipBuilder ConditionBuilder(AHWH_BSZX model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(AHWH_BSZX._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(AHWH_BSZX._.TITLE.Contain(model.TITLE));
				}
				if(model.TM!=null)
				{
				  condition.And(AHWH_BSZX._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.ISPUBLIC))
				{
				  condition.And(AHWH_BSZX._.ISPUBLIC.Contain(model.ISPUBLIC));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENTS))
				{
				  condition.And(AHWH_BSZX._.CONTENTS.Contain(model.CONTENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(AHWH_BSZX._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REPLY))
				{
				  condition.And(AHWH_BSZX._.REPLY.Contain(model.REPLY));
				}
				if(!string.IsNullOrWhiteSpace(model.SOURCES))
				{
				  condition.And(AHWH_BSZX._.SOURCES.Contain(model.SOURCES));
				}
		return condition;
	}
        #endregion
    }
}