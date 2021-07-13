using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BidViolationService : BaseServiceT<BID_VIOLATION>
    {
        #region 接口实现
        
		public List<BID_VIOLATION> FindList(BID_VIOLATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BID_VIOLATION> PageList(BID_VIOLATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BID_VIOLATION._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BID_VIOLATION._.ID == ID);
			
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
        public GeneralResult Edit(BID_VIOLATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is BID_VIOLATION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.VIOM_NAME=model.VIOM_NAME;
		entity.INFO_FROM=model.INFO_FROM;
		entity.REL_DATE=model.REL_DATE;
		entity.VIO_TYPE=model.VIO_TYPE;
		entity.VIO_OBJECT=model.VIO_OBJECT;
		entity.VIO_DATE=model.VIO_DATE;
		entity.VIO_DESC=model.VIO_DESC;
		entity.NOTI_DEPART=model.NOTI_DEPART;
		entity.PLT_BASIS=model.PLT_BASIS;
		entity.PLT_RESULT=model.PLT_RESULT;
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
        public GeneralResult Add(BID_VIOLATION model)
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
                    Delete(BID_VIOLATION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BID_VIOLATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(BID_VIOLATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(BID_VIOLATION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOM_NAME))
				{
				  condition.And(BID_VIOLATION._.VIOM_NAME.Contain(model.VIOM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INFO_FROM))
				{
				  condition.And(BID_VIOLATION._.INFO_FROM.Contain(model.INFO_FROM));
				}
				if(model.REL_DATE!=null)
				{
				  condition.And(BID_VIOLATION._.REL_DATE==(model.REL_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIO_TYPE))
				{
				  condition.And(BID_VIOLATION._.VIO_TYPE.Contain(model.VIO_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIO_OBJECT))
				{
				  condition.And(BID_VIOLATION._.VIO_OBJECT.Contain(model.VIO_OBJECT));
				}
				if(model.VIO_DATE!=null)
				{
				  condition.And(BID_VIOLATION._.VIO_DATE==(model.VIO_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIO_DESC))
				{
				  condition.And(BID_VIOLATION._.VIO_DESC.Contain(model.VIO_DESC));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTI_DEPART))
				{
				  condition.And(BID_VIOLATION._.NOTI_DEPART.Contain(model.NOTI_DEPART));
				}
				if(!string.IsNullOrWhiteSpace(model.PLT_BASIS))
				{
				  condition.And(BID_VIOLATION._.PLT_BASIS.Contain(model.PLT_BASIS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLT_RESULT))
				{
				  condition.And(BID_VIOLATION._.PLT_RESULT.Contain(model.PLT_RESULT));
				}
		return condition;
	}
        #endregion
    }
}