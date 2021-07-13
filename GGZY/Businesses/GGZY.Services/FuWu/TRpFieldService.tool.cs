using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TRpFieldService : BaseServiceT<T_RP_FIELD>
    {
        #region 接口实现
        
		public List<T_RP_FIELD> FindList(T_RP_FIELD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RP_FIELD> PageList(T_RP_FIELD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RP_FIELD._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_RP_FIELD._.ID == ID);
			
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
        public GeneralResult Edit(T_RP_FIELD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_RP_FIELD entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RP_CODE=model.RP_CODE;
		entity.FNAME_C=model.FNAME_C;
		entity.FNAME=model.FNAME;
		entity.FTYPE=model.FTYPE;
		entity.STYLE=model.STYLE;
		entity.FORMAT_METHOD=model.FORMAT_METHOD;
		entity.FORMAT_PAR=model.FORMAT_PAR;
		entity.ORDER_ID=model.ORDER_ID;
		entity.FOREIGN_SQL=model.FOREIGN_SQL;
		entity.WIDTH=model.WIDTH;
		entity.ALIGN=model.ALIGN;
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
        public GeneralResult Add(T_RP_FIELD model)
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
                    Delete(T_RP_FIELD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RP_FIELD> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RP_FIELD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RP_FIELD._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.RP_CODE))
				{
				  condition.And(T_RP_FIELD._.RP_CODE.Contain(model.RP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.FNAME_C))
				{
				  condition.And(T_RP_FIELD._.FNAME_C.Contain(model.FNAME_C));
				}
				if(!string.IsNullOrWhiteSpace(model.FNAME))
				{
				  condition.And(T_RP_FIELD._.FNAME.Contain(model.FNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FTYPE))
				{
				  condition.And(T_RP_FIELD._.FTYPE.Contain(model.FTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.STYLE))
				{
				  condition.And(T_RP_FIELD._.STYLE.Contain(model.STYLE));
				}
				if(!string.IsNullOrWhiteSpace(model.FORMAT_METHOD))
				{
				  condition.And(T_RP_FIELD._.FORMAT_METHOD.Contain(model.FORMAT_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.FORMAT_PAR))
				{
				  condition.And(T_RP_FIELD._.FORMAT_PAR.Contain(model.FORMAT_PAR));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_RP_FIELD._.ORDER_ID==(model.ORDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.FOREIGN_SQL))
				{
				  condition.And(T_RP_FIELD._.FOREIGN_SQL.Contain(model.FOREIGN_SQL));
				}
				if(model.WIDTH!=null)
				{
				  condition.And(T_RP_FIELD._.WIDTH==(model.WIDTH));
				}
				if(!string.IsNullOrWhiteSpace(model.ALIGN))
				{
				  condition.And(T_RP_FIELD._.ALIGN.Contain(model.ALIGN));
				}
		return condition;
	}
        #endregion
    }
}