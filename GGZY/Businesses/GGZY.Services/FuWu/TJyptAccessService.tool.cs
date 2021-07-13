using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TJyptAccessService : BaseServiceT<T_JYPT_ACCESS>
    {
        #region 接口实现
        
		public List<T_JYPT_ACCESS> FindList(T_JYPT_ACCESS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_JYPT_ACCESS> PageList(T_JYPT_ACCESS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_JYPT_ACCESS._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_JYPT_ACCESS._.ID == ID);
			
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
        public GeneralResult Edit(T_JYPT_ACCESS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_JYPT_ACCESS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.JYPT_NAME=model.JYPT_NAME;
		entity.YYHYFW=model.YYHYFW;
		entity.YYQYFW=model.YYQYFW;
		entity.KFGS=model.KFGS;
		entity.KFGS_CODE=model.KFGS_CODE;
		entity.YWGS=model.YWGS;
		entity.YWGS_CODE=model.YWGS_CODE;
		entity.LXR_NAME=model.LXR_NAME;
		entity.LXR_PHONE=model.LXR_PHONE;
		entity.LXR_EMAIL=model.LXR_EMAIL;
		entity.PT_URL=model.PT_URL;
		entity.PT_IP=model.PT_IP;
		entity.PT_QY=model.PT_QY;
		entity.SF_BD=model.SF_BD;
		entity.SF_HTTPS=model.SF_HTTPS;
		entity.PTAQJB=model.PTAQJB;
		entity.PTRZ=model.PTRZ;
		entity.PTYW=model.PTYW;
		entity.PTDRFS=model.PTDRFS;
		entity.SF_JRFJ=model.SF_JRFJ;
		entity.PTAL=model.PTAL;
		entity.PTJJ=model.PTJJ;
		entity.STATUS=model.STATUS;
		entity.STOP_REMARK=model.STOP_REMARK;
		entity.STOP_FILE=model.STOP_FILE;
		entity.STOP_TM=model.STOP_TM;
		entity.CLHY_STATUS=model.CLHY_STATUS;
		entity.CLHY_REMARK=model.CLHY_REMARK;
		entity.CLHY_PEOPLE=model.CLHY_PEOPLE;
		entity.CLHY_TM=model.CLHY_TM;
		entity.ZGDW_STATUS=model.ZGDW_STATUS;
		entity.ZGDW_REMARK=model.ZGDW_REMARK;
		entity.ZGDW_PEOPLE=model.ZGDW_PEOPLE;
		entity.ZGDW_TM=model.ZGDW_TM;
		entity.CLHY_FILES=model.CLHY_FILES;
		entity.ZGDW_FILES=model.ZGDW_FILES;
		entity.DJCG_STATUS=model.DJCG_STATUS;
		entity.DJCG_REMARK=model.DJCG_REMARK;
		entity.DJCG_PEOPLE=model.DJCG_PEOPLE;
		entity.DJCG_TM=model.DJCG_TM;
		entity.DJCG_FILES=model.DJCG_FILES;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(T_JYPT_ACCESS model)
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
                    Delete(T_JYPT_ACCESS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_JYPT_ACCESS> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_JYPT_ACCESS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_JYPT_ACCESS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.JYPT_NAME))
				{
				  condition.And(T_JYPT_ACCESS._.JYPT_NAME.Contain(model.JYPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.YYHYFW))
				{
				  condition.And(T_JYPT_ACCESS._.YYHYFW.Contain(model.YYHYFW));
				}
				if(!string.IsNullOrWhiteSpace(model.YYQYFW))
				{
				  condition.And(T_JYPT_ACCESS._.YYQYFW.Contain(model.YYQYFW));
				}
				if(!string.IsNullOrWhiteSpace(model.KFGS))
				{
				  condition.And(T_JYPT_ACCESS._.KFGS.Contain(model.KFGS));
				}
				if(!string.IsNullOrWhiteSpace(model.KFGS_CODE))
				{
				  condition.And(T_JYPT_ACCESS._.KFGS_CODE.Contain(model.KFGS_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.YWGS))
				{
				  condition.And(T_JYPT_ACCESS._.YWGS.Contain(model.YWGS));
				}
				if(!string.IsNullOrWhiteSpace(model.YWGS_CODE))
				{
				  condition.And(T_JYPT_ACCESS._.YWGS_CODE.Contain(model.YWGS_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR_NAME))
				{
				  condition.And(T_JYPT_ACCESS._.LXR_NAME.Contain(model.LXR_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR_PHONE))
				{
				  condition.And(T_JYPT_ACCESS._.LXR_PHONE.Contain(model.LXR_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LXR_EMAIL))
				{
				  condition.And(T_JYPT_ACCESS._.LXR_EMAIL.Contain(model.LXR_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.PT_URL))
				{
				  condition.And(T_JYPT_ACCESS._.PT_URL.Contain(model.PT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PT_IP))
				{
				  condition.And(T_JYPT_ACCESS._.PT_IP.Contain(model.PT_IP));
				}
				if(!string.IsNullOrWhiteSpace(model.PT_QY))
				{
				  condition.And(T_JYPT_ACCESS._.PT_QY.Contain(model.PT_QY));
				}
				if(!string.IsNullOrWhiteSpace(model.SF_BD))
				{
				  condition.And(T_JYPT_ACCESS._.SF_BD.Contain(model.SF_BD));
				}
				if(!string.IsNullOrWhiteSpace(model.SF_HTTPS))
				{
				  condition.And(T_JYPT_ACCESS._.SF_HTTPS.Contain(model.SF_HTTPS));
				}
				if(!string.IsNullOrWhiteSpace(model.PTAQJB))
				{
				  condition.And(T_JYPT_ACCESS._.PTAQJB.Contain(model.PTAQJB));
				}
				if(!string.IsNullOrWhiteSpace(model.PTRZ))
				{
				  condition.And(T_JYPT_ACCESS._.PTRZ.Contain(model.PTRZ));
				}
				if(!string.IsNullOrWhiteSpace(model.PTYW))
				{
				  condition.And(T_JYPT_ACCESS._.PTYW.Contain(model.PTYW));
				}
				if(!string.IsNullOrWhiteSpace(model.PTDRFS))
				{
				  condition.And(T_JYPT_ACCESS._.PTDRFS.Contain(model.PTDRFS));
				}
				if(!string.IsNullOrWhiteSpace(model.SF_JRFJ))
				{
				  condition.And(T_JYPT_ACCESS._.SF_JRFJ.Contain(model.SF_JRFJ));
				}
				if(!string.IsNullOrWhiteSpace(model.PTAL))
				{
				  condition.And(T_JYPT_ACCESS._.PTAL.Contain(model.PTAL));
				}
				if(!string.IsNullOrWhiteSpace(model.PTJJ))
				{
				  condition.And(T_JYPT_ACCESS._.PTJJ.Contain(model.PTJJ));
				}
				if(model.STATUS!=null)
				{
				  condition.And(T_JYPT_ACCESS._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.STOP_REMARK))
				{
				  condition.And(T_JYPT_ACCESS._.STOP_REMARK.Contain(model.STOP_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.STOP_FILE))
				{
				  condition.And(T_JYPT_ACCESS._.STOP_FILE.Contain(model.STOP_FILE));
				}
				if(model.STOP_TM!=null)
				{
				  condition.And(T_JYPT_ACCESS._.STOP_TM==(model.STOP_TM));
				}
				if(model.CLHY_STATUS!=null)
				{
				  condition.And(T_JYPT_ACCESS._.CLHY_STATUS==(model.CLHY_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLHY_REMARK))
				{
				  condition.And(T_JYPT_ACCESS._.CLHY_REMARK.Contain(model.CLHY_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.CLHY_PEOPLE))
				{
				  condition.And(T_JYPT_ACCESS._.CLHY_PEOPLE.Contain(model.CLHY_PEOPLE));
				}
				if(model.CLHY_TM!=null)
				{
				  condition.And(T_JYPT_ACCESS._.CLHY_TM==(model.CLHY_TM));
				}
				if(model.ZGDW_STATUS!=null)
				{
				  condition.And(T_JYPT_ACCESS._.ZGDW_STATUS==(model.ZGDW_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.ZGDW_REMARK))
				{
				  condition.And(T_JYPT_ACCESS._.ZGDW_REMARK.Contain(model.ZGDW_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.ZGDW_PEOPLE))
				{
				  condition.And(T_JYPT_ACCESS._.ZGDW_PEOPLE.Contain(model.ZGDW_PEOPLE));
				}
				if(model.ZGDW_TM!=null)
				{
				  condition.And(T_JYPT_ACCESS._.ZGDW_TM==(model.ZGDW_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CLHY_FILES))
				{
				  condition.And(T_JYPT_ACCESS._.CLHY_FILES.Contain(model.CLHY_FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.ZGDW_FILES))
				{
				  condition.And(T_JYPT_ACCESS._.ZGDW_FILES.Contain(model.ZGDW_FILES));
				}
				if(model.DJCG_STATUS!=null)
				{
				  condition.And(T_JYPT_ACCESS._.DJCG_STATUS==(model.DJCG_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.DJCG_REMARK))
				{
				  condition.And(T_JYPT_ACCESS._.DJCG_REMARK.Contain(model.DJCG_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.DJCG_PEOPLE))
				{
				  condition.And(T_JYPT_ACCESS._.DJCG_PEOPLE.Contain(model.DJCG_PEOPLE));
				}
				if(model.DJCG_TM!=null)
				{
				  condition.And(T_JYPT_ACCESS._.DJCG_TM==(model.DJCG_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.DJCG_FILES))
				{
				  condition.And(T_JYPT_ACCESS._.DJCG_FILES.Contain(model.DJCG_FILES));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_JYPT_ACCESS._.CREATE_TM==(model.CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}