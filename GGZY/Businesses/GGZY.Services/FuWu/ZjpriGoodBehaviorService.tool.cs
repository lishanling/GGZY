using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriGoodBehaviorService : BaseServiceT<ZJPRI_GOOD_BEHAVIOR>
    {
        #region 接口实现
        
		public List<ZJPRI_GOOD_BEHAVIOR> FindList(ZJPRI_GOOD_BEHAVIOR model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_GOOD_BEHAVIOR> PageList(ZJPRI_GOOD_BEHAVIOR model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_GOOD_BEHAVIOR._.UK_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="UK_ID">唯一标识码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string UK_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_GOOD_BEHAVIOR._.UK_ID == UK_ID);
			
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
        public GeneralResult Edit(ZJPRI_GOOD_BEHAVIOR model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.UK_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_GOOD_BEHAVIOR entity)
	{		
		entity.Attach();
		entity.UK_ID=model.UK_ID;
		entity.STATE=model.STATE;
		entity.QYBSM=model.QYBSM;
		entity.CORPSCCODE=model.CORPSCCODE;
		entity.CORPCODE=model.CORPCODE;
		entity.CORPNAME=model.CORPNAME;
		entity.AWARDTYPE=model.AWARDTYPE;
		entity.EVALUATECRITERION=model.EVALUATECRITERION;
		entity.EVALUATEEVIDENCE=model.EVALUATEEVIDENCE;
		entity.AWARDFILENAME=model.AWARDFILENAME;
		entity.AWARDFILENUM=model.AWARDFILENUM;
		entity.AWARDDEPARTNAME=model.AWARDDEPARTNAME;
		entity.AWARDDATE=model.AWARDDATE;
		entity.PRJNAME=model.PRJNAME;
		entity.MINISTRYPRJNUM=model.MINISTRYPRJNUM;
		entity.PROVICEPRJNUM=model.PROVICEPRJNUM;
		entity.AWARDREASON=model.AWARDREASON;
		entity.AWARDEVIDENCE=model.AWARDEVIDENCE;
		entity.AWARDRESULT=model.AWARDRESULT;
		entity.CREDITSCORE=model.CREDITSCORE;
		entity.CREATEDEPNAME=model.CREATEDEPNAME;
		entity.CREATEUSERNAME=model.CREATEUSERNAME;
		entity.CREATEDATE=model.CREATEDATE;
		entity.CORPTYPE=model.CORPTYPE;
		entity.GUID=model.GUID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
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
        public GeneralResult Add(ZJPRI_GOOD_BEHAVIOR model)
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
                    Delete(ZJPRI_GOOD_BEHAVIOR._.UK_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_GOOD_BEHAVIOR> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_GOOD_BEHAVIOR model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.UK_ID))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.UK_ID.Contain(model.UK_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.STATE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.STATE.Contain(model.STATE));
				}
				if(!string.IsNullOrWhiteSpace(model.QYBSM))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.QYBSM.Contain(model.QYBSM));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPSCCODE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CORPSCCODE.Contain(model.CORPSCCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPCODE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CORPCODE.Contain(model.CORPCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPNAME))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CORPNAME.Contain(model.CORPNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDTYPE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDTYPE.Contain(model.AWARDTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATECRITERION))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.EVALUATECRITERION.Contain(model.EVALUATECRITERION));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATEEVIDENCE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.EVALUATEEVIDENCE.Contain(model.EVALUATEEVIDENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDFILENAME))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDFILENAME.Contain(model.AWARDFILENAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDFILENUM))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDFILENUM.Contain(model.AWARDFILENUM));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDDEPARTNAME))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDDEPARTNAME.Contain(model.AWARDDEPARTNAME));
				}
				if(model.AWARDDATE!=null)
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDDATE==(model.AWARDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRJNAME))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.PRJNAME.Contain(model.PRJNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MINISTRYPRJNUM))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.MINISTRYPRJNUM.Contain(model.MINISTRYPRJNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROVICEPRJNUM))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.PROVICEPRJNUM.Contain(model.PROVICEPRJNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDREASON))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDREASON.Contain(model.AWARDREASON));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDEVIDENCE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDEVIDENCE.Contain(model.AWARDEVIDENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.AWARDRESULT))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.AWARDRESULT.Contain(model.AWARDRESULT));
				}
				if(model.CREDITSCORE!=null)
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CREDITSCORE==(model.CREDITSCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATEDEPNAME))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CREATEDEPNAME.Contain(model.CREATEDEPNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATEUSERNAME))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CREATEUSERNAME.Contain(model.CREATEUSERNAME));
				}
				if(model.CREATEDATE!=null)
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CREATEDATE==(model.CREATEDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CORPTYPE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CORPTYPE.Contain(model.CORPTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.GUID.Contain(model.GUID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_GOOD_BEHAVIOR._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
		return condition;
	}
        #endregion
    }
}