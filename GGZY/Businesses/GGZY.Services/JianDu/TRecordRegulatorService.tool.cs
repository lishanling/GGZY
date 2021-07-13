using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TRecordRegulatorService : BaseServiceT<T_RECORD_REGULATOR>
    {
        #region 接口实现
        
		public List<T_RECORD_REGULATOR> FindList(T_RECORD_REGULATOR model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RECORD_REGULATOR> PageList(T_RECORD_REGULATOR model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RECORD_REGULATOR._.RCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="RCODE">监管部门编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string RCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RECORD_REGULATOR._.RCODE == RCODE);
			
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
        public GeneralResult Edit(T_RECORD_REGULATOR model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RCODE);
	
	if(viewResult.Success  && viewResult.Data is T_RECORD_REGULATOR entity)
	{		
		entity.Attach();
		entity.RCODE=model.RCODE;
		entity.RNAME=model.RNAME;
		entity.LONGI=model.LONGI;
		entity.LATI=model.LATI;
		entity.ADDRESS=model.ADDRESS;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(T_RECORD_REGULATOR model)
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
                    Delete(T_RECORD_REGULATOR._.RCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RECORD_REGULATOR> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RECORD_REGULATOR model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.RCODE))
				{
				  condition.And(T_RECORD_REGULATOR._.RCODE.Contain(model.RCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.RNAME))
				{
				  condition.And(T_RECORD_REGULATOR._.RNAME.Contain(model.RNAME));
				}
				if(model.LONGI!=null)
				{
				  condition.And(T_RECORD_REGULATOR._.LONGI==(model.LONGI));
				}
				if(model.LATI!=null)
				{
				  condition.And(T_RECORD_REGULATOR._.LATI==(model.LATI));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(T_RECORD_REGULATOR._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_RECORD_REGULATOR._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}