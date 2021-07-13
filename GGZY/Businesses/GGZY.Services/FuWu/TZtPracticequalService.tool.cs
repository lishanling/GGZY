using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtPracticequalService : BaseServiceT<T_ZT_PRACTICEQUAL>
    {
        #region 接口实现
        
		public List<T_ZT_PRACTICEQUAL> FindList(T_ZT_PRACTICEQUAL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_PRACTICEQUAL> PageList(T_ZT_PRACTICEQUAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_PRACTICEQUAL._.IDCARD.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="IDCARD">执业人员证件号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string IDCARD)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_PRACTICEQUAL._.IDCARD == IDCARD);
			
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
        public GeneralResult Edit(T_ZT_PRACTICEQUAL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.IDCARD);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_PRACTICEQUAL entity)
	{		
		entity.Attach();
		entity.QUALNAME=model.QUALNAME;
		entity.QUALTYPE=model.QUALTYPE;
		entity.IDCARD=model.IDCARD;
		entity.IDCARDTYPE=model.IDCARDTYPE;
		entity.CERTNO=model.CERTNO;
		entity.CERTENDDATE=model.CERTENDDATE;
		entity.DATASOURCECODE=model.DATASOURCECODE;
		entity.DATATIMESTAMP=model.DATATIMESTAMP;
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
        public GeneralResult Add(T_ZT_PRACTICEQUAL model)
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
                    Delete(T_ZT_PRACTICEQUAL._.IDCARD.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_PRACTICEQUAL> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_PRACTICEQUAL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.QUALNAME))
				{
				  condition.And(T_ZT_PRACTICEQUAL._.QUALNAME.Contain(model.QUALNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALTYPE))
				{
				  condition.And(T_ZT_PRACTICEQUAL._.QUALTYPE.Contain(model.QUALTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARD))
				{
				  condition.And(T_ZT_PRACTICEQUAL._.IDCARD.Contain(model.IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARDTYPE))
				{
				  condition.And(T_ZT_PRACTICEQUAL._.IDCARDTYPE.Contain(model.IDCARDTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CERTNO))
				{
				  condition.And(T_ZT_PRACTICEQUAL._.CERTNO.Contain(model.CERTNO));
				}
				if(model.CERTENDDATE!=null)
				{
				  condition.And(T_ZT_PRACTICEQUAL._.CERTENDDATE==(model.CERTENDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_ZT_PRACTICEQUAL._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
				if(model.DATATIMESTAMP!=null)
				{
				  condition.And(T_ZT_PRACTICEQUAL._.DATATIMESTAMP==(model.DATATIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}