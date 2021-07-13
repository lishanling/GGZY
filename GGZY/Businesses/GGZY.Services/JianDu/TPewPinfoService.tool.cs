using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TPewPinfoService : BaseServiceT<T_PEW_PINFO>
    {
        #region 接口实现
        
		public List<T_PEW_PINFO> FindList(T_PEW_PINFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PEW_PINFO> PageList(T_PEW_PINFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PEW_PINFO._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_PEW_PINFO._.ID == ID);
			
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
        public GeneralResult Edit(T_PEW_PINFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PEW_PINFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PROT_PNUM=model.PROT_PNUM;
		entity.PRO_NAME=model.PRO_NAME;
		entity.PRO_NUM=model.PRO_NUM;
		entity.TEN_NUM=model.TEN_NUM;
		entity.SUTP=model.SUTP;
		entity.NOTICE=model.NOTICE;
		entity.BPS_FILE=model.BPS_FILE;
		entity.QTIONS_REVIEW=model.QTIONS_REVIEW;
		entity.Q_A=model.Q_A;
		entity.S_DEP=model.S_DEP;
		entity.OBB_SITUATION=model.OBB_SITUATION;
		entity.WTBD_PUBLICITY=model.WTBD_PUBLICITY;
		entity.WTBD_NOTICE=model.WTBD_NOTICE;
		entity.PRO_STATUS=model.PRO_STATUS;
		entity.PRO_PROCESS=model.PRO_PROCESS;
		entity.CPT_INFO=model.CPT_INFO;
		entity.STS_REPORT=model.STS_REPORT;
		entity.EPT_EXTRACT=model.EPT_EXTRACT;
		entity.EPT_EVAL=model.EPT_EVAL;
		entity.EPT_BLACKLIST=model.EPT_BLACKLIST;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_KEY=model.M_KEY;
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
        public GeneralResult Add(T_PEW_PINFO model)
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
                    Delete(T_PEW_PINFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PEW_PINFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PEW_PINFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PEW_PINFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PROT_PNUM))
				{
				  condition.And(T_PEW_PINFO._.PROT_PNUM.Contain(model.PROT_PNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NAME))
				{
				  condition.And(T_PEW_PINFO._.PRO_NAME.Contain(model.PRO_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_NUM))
				{
				  condition.And(T_PEW_PINFO._.PRO_NUM.Contain(model.PRO_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.TEN_NUM))
				{
				  condition.And(T_PEW_PINFO._.TEN_NUM.Contain(model.TEN_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.SUTP))
				{
				  condition.And(T_PEW_PINFO._.SUTP.Contain(model.SUTP));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE))
				{
				  condition.And(T_PEW_PINFO._.NOTICE.Contain(model.NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.BPS_FILE))
				{
				  condition.And(T_PEW_PINFO._.BPS_FILE.Contain(model.BPS_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.QTIONS_REVIEW))
				{
				  condition.And(T_PEW_PINFO._.QTIONS_REVIEW.Contain(model.QTIONS_REVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.Q_A))
				{
				  condition.And(T_PEW_PINFO._.Q_A.Contain(model.Q_A));
				}
				if(!string.IsNullOrWhiteSpace(model.S_DEP))
				{
				  condition.And(T_PEW_PINFO._.S_DEP.Contain(model.S_DEP));
				}
				if(!string.IsNullOrWhiteSpace(model.OBB_SITUATION))
				{
				  condition.And(T_PEW_PINFO._.OBB_SITUATION.Contain(model.OBB_SITUATION));
				}
				if(!string.IsNullOrWhiteSpace(model.WTBD_PUBLICITY))
				{
				  condition.And(T_PEW_PINFO._.WTBD_PUBLICITY.Contain(model.WTBD_PUBLICITY));
				}
				if(!string.IsNullOrWhiteSpace(model.WTBD_NOTICE))
				{
				  condition.And(T_PEW_PINFO._.WTBD_NOTICE.Contain(model.WTBD_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_STATUS))
				{
				  condition.And(T_PEW_PINFO._.PRO_STATUS.Contain(model.PRO_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.PRO_PROCESS))
				{
				  condition.And(T_PEW_PINFO._.PRO_PROCESS.Contain(model.PRO_PROCESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CPT_INFO))
				{
				  condition.And(T_PEW_PINFO._.CPT_INFO.Contain(model.CPT_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.STS_REPORT))
				{
				  condition.And(T_PEW_PINFO._.STS_REPORT.Contain(model.STS_REPORT));
				}
				if(!string.IsNullOrWhiteSpace(model.EPT_EXTRACT))
				{
				  condition.And(T_PEW_PINFO._.EPT_EXTRACT.Contain(model.EPT_EXTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.EPT_EVAL))
				{
				  condition.And(T_PEW_PINFO._.EPT_EVAL.Contain(model.EPT_EVAL));
				}
				if(!string.IsNullOrWhiteSpace(model.EPT_BLACKLIST))
				{
				  condition.And(T_PEW_PINFO._.EPT_BLACKLIST.Contain(model.EPT_BLACKLIST));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_PEW_PINFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_PEW_PINFO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_PEW_PINFO._.M_KEY.Contain(model.M_KEY));
				}
		return condition;
	}
        #endregion
    }
}