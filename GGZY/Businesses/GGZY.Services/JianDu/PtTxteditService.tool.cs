using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtTxteditService : BaseServiceT<PT_TXTEDIT>
    {
        #region 接口实现
        
		public List<PT_TXTEDIT> FindList(PT_TXTEDIT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_TXTEDIT> PageList(PT_TXTEDIT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_TXTEDIT._.CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="CODE">文本编码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(PT_TXTEDIT._.CODE == CODE);
			
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
        public GeneralResult Edit(PT_TXTEDIT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.CODE);
	
	if(viewResult.Success  && viewResult.Data is PT_TXTEDIT entity)
	{		
		entity.Attach();
		entity.CODE=model.CODE;
		entity.NAME=model.NAME;
		entity.FILEPATH=model.FILEPATH;
		entity.CTYPE=model.CTYPE;
		entity.CONTENT=model.CONTENT;
		entity.GTYPE=model.GTYPE;
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
        public GeneralResult Add(PT_TXTEDIT model)
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
                    Delete(PT_TXTEDIT._.CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_TXTEDIT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_TXTEDIT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(PT_TXTEDIT._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(PT_TXTEDIT._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FILEPATH))
				{
				  condition.And(PT_TXTEDIT._.FILEPATH.Contain(model.FILEPATH));
				}
				if(model.CTYPE!=null)
				{
				  condition.And(PT_TXTEDIT._.CTYPE==(model.CTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(PT_TXTEDIT._.CONTENT.Contain(model.CONTENT));
				}
				if(model.GTYPE!=null)
				{
				  condition.And(PT_TXTEDIT._.GTYPE==(model.GTYPE));
				}
		return condition;
	}
        #endregion
    }
}