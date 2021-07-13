using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TCertificateService : BaseServiceT<T_CERTIFICATE>
    {
        #region 接口实现
        
		public List<T_CERTIFICATE> FindList(T_CERTIFICATE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_CERTIFICATE> PageList(T_CERTIFICATE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_CERTIFICATE._.M_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">M_ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_CERTIFICATE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(T_CERTIFICATE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is T_CERTIFICATE entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.CODE=model.CODE;
		entity.NAME=model.NAME;
		entity.TYPE=model.TYPE;
		entity.ZSTGS=model.ZSTGS;
		entity.RZJG=model.RZJG;
		entity.YXQ=model.YXQ;
		entity.M_F_ID=model.M_F_ID;
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
        public GeneralResult Add(T_CERTIFICATE model)
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
                    Delete(T_CERTIFICATE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_CERTIFICATE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_CERTIFICATE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(T_CERTIFICATE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_CERTIFICATE._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_CERTIFICATE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_CERTIFICATE._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZSTGS))
				{
				  condition.And(T_CERTIFICATE._.ZSTGS.Contain(model.ZSTGS));
				}
				if(!string.IsNullOrWhiteSpace(model.RZJG))
				{
				  condition.And(T_CERTIFICATE._.RZJG.Contain(model.RZJG));
				}
				if(model.YXQ!=null)
				{
				  condition.And(T_CERTIFICATE._.YXQ==(model.YXQ));
				}
				if(model.M_F_ID!=null)
				{
				  condition.And(T_CERTIFICATE._.M_F_ID==(model.M_F_ID));
				}
		return condition;
	}
        #endregion
    }
}