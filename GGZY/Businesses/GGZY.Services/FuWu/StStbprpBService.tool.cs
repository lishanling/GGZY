using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StStbprpBService : BaseServiceT<ST_STBPRP_B>
    {
        #region 接口实现
        
		public List<ST_STBPRP_B> FindList(ST_STBPRP_B model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ST_STBPRP_B> PageList(ST_STBPRP_B model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ST_STBPRP_B._.STCD.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="STCD"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string STCD)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ST_STBPRP_B._.STCD == STCD);
			
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
        public GeneralResult Edit(ST_STBPRP_B model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.STCD);
	
	if(viewResult.Success  && viewResult.Data is ST_STBPRP_B entity)
	{		
		entity.Attach();
		entity.STCD=model.STCD;
		entity.STNM=model.STNM;
		entity.RVNM=model.RVNM;
		entity.HNNM=model.HNNM;
		entity.BSNM=model.BSNM;
		entity.LGTD=model.LGTD;
		entity.LTTD=model.LTTD;
		entity.STLC=model.STLC;
		entity.ADDVCD=model.ADDVCD;
		entity.DTMNM=model.DTMNM;
		entity.DTMEL=model.DTMEL;
		entity.DTPR=model.DTPR;
		entity.STTP=model.STTP;
		entity.FRGRD=model.FRGRD;
		entity.ESSTYM=model.ESSTYM;
		entity.BGFRYM=model.BGFRYM;
		entity.ATCUNIT=model.ATCUNIT;
		entity.ADMAUTH=model.ADMAUTH;
		entity.LOCALITY=model.LOCALITY;
		entity.STBK=model.STBK;
		entity.STAZT=model.STAZT;
		entity.DSTRVM=model.DSTRVM;
		entity.DRNA=model.DRNA;
		entity.PHCD=model.PHCD;
		entity.USFL=model.USFL;
		entity.COMMENTS=model.COMMENTS;
		entity.MODITIME=model.MODITIME;
		entity.SORTID=model.SORTID;
		entity.SORTID_ALL=model.SORTID_ALL;
		entity.SORTID_RIVER=model.SORTID_RIVER;
		entity.TYPE=model.TYPE;
		entity.TSTCD=model.TSTCD;
		entity.GSTCD=model.GSTCD;
		entity.HOUR=model.HOUR;
		entity.ISAUTO=model.ISAUTO;
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
        public GeneralResult Add(ST_STBPRP_B model)
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
                    Delete(ST_STBPRP_B._.STCD.SelectIn(idArr));
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
        public GeneralResult Import(List<ST_STBPRP_B> model)
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
       	protected WhereClipBuilder ConditionBuilder(ST_STBPRP_B model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.STCD))
				{
				  condition.And(ST_STBPRP_B._.STCD.Contain(model.STCD));
				}
				if(!string.IsNullOrWhiteSpace(model.STNM))
				{
				  condition.And(ST_STBPRP_B._.STNM.Contain(model.STNM));
				}
				if(!string.IsNullOrWhiteSpace(model.RVNM))
				{
				  condition.And(ST_STBPRP_B._.RVNM.Contain(model.RVNM));
				}
				if(!string.IsNullOrWhiteSpace(model.HNNM))
				{
				  condition.And(ST_STBPRP_B._.HNNM.Contain(model.HNNM));
				}
				if(!string.IsNullOrWhiteSpace(model.BSNM))
				{
				  condition.And(ST_STBPRP_B._.BSNM.Contain(model.BSNM));
				}
				if(!string.IsNullOrWhiteSpace(model.LGTD))
				{
				  condition.And(ST_STBPRP_B._.LGTD.Contain(model.LGTD));
				}
				if(!string.IsNullOrWhiteSpace(model.LTTD))
				{
				  condition.And(ST_STBPRP_B._.LTTD.Contain(model.LTTD));
				}
				if(!string.IsNullOrWhiteSpace(model.STLC))
				{
				  condition.And(ST_STBPRP_B._.STLC.Contain(model.STLC));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDVCD))
				{
				  condition.And(ST_STBPRP_B._.ADDVCD.Contain(model.ADDVCD));
				}
				if(!string.IsNullOrWhiteSpace(model.DTMNM))
				{
				  condition.And(ST_STBPRP_B._.DTMNM.Contain(model.DTMNM));
				}
				if(model.DTMEL!=null)
				{
				  condition.And(ST_STBPRP_B._.DTMEL==(model.DTMEL));
				}
				if(model.DTPR!=null)
				{
				  condition.And(ST_STBPRP_B._.DTPR==(model.DTPR));
				}
				if(!string.IsNullOrWhiteSpace(model.STTP))
				{
				  condition.And(ST_STBPRP_B._.STTP.Contain(model.STTP));
				}
				if(!string.IsNullOrWhiteSpace(model.FRGRD))
				{
				  condition.And(ST_STBPRP_B._.FRGRD.Contain(model.FRGRD));
				}
				if(!string.IsNullOrWhiteSpace(model.ESSTYM))
				{
				  condition.And(ST_STBPRP_B._.ESSTYM.Contain(model.ESSTYM));
				}
				if(!string.IsNullOrWhiteSpace(model.BGFRYM))
				{
				  condition.And(ST_STBPRP_B._.BGFRYM.Contain(model.BGFRYM));
				}
				if(!string.IsNullOrWhiteSpace(model.ATCUNIT))
				{
				  condition.And(ST_STBPRP_B._.ATCUNIT.Contain(model.ATCUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.ADMAUTH))
				{
				  condition.And(ST_STBPRP_B._.ADMAUTH.Contain(model.ADMAUTH));
				}
				if(!string.IsNullOrWhiteSpace(model.LOCALITY))
				{
				  condition.And(ST_STBPRP_B._.LOCALITY.Contain(model.LOCALITY));
				}
				if(!string.IsNullOrWhiteSpace(model.STBK))
				{
				  condition.And(ST_STBPRP_B._.STBK.Contain(model.STBK));
				}
				if(model.STAZT!=null)
				{
				  condition.And(ST_STBPRP_B._.STAZT==(model.STAZT));
				}
				if(model.DSTRVM!=null)
				{
				  condition.And(ST_STBPRP_B._.DSTRVM==(model.DSTRVM));
				}
				if(model.DRNA!=null)
				{
				  condition.And(ST_STBPRP_B._.DRNA==(model.DRNA));
				}
				if(!string.IsNullOrWhiteSpace(model.PHCD))
				{
				  condition.And(ST_STBPRP_B._.PHCD.Contain(model.PHCD));
				}
				if(!string.IsNullOrWhiteSpace(model.USFL))
				{
				  condition.And(ST_STBPRP_B._.USFL.Contain(model.USFL));
				}
				if(!string.IsNullOrWhiteSpace(model.COMMENTS))
				{
				  condition.And(ST_STBPRP_B._.COMMENTS.Contain(model.COMMENTS));
				}
				if(model.MODITIME!=null)
				{
				  condition.And(ST_STBPRP_B._.MODITIME==(model.MODITIME));
				}
				if(model.SORTID!=null)
				{
				  condition.And(ST_STBPRP_B._.SORTID==(model.SORTID));
				}
				if(model.SORTID_ALL!=null)
				{
				  condition.And(ST_STBPRP_B._.SORTID_ALL==(model.SORTID_ALL));
				}
				if(model.SORTID_RIVER!=null)
				{
				  condition.And(ST_STBPRP_B._.SORTID_RIVER==(model.SORTID_RIVER));
				}
				if(model.TYPE!=null)
				{
				  condition.And(ST_STBPRP_B._.TYPE==(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TSTCD))
				{
				  condition.And(ST_STBPRP_B._.TSTCD.Contain(model.TSTCD));
				}
				if(!string.IsNullOrWhiteSpace(model.GSTCD))
				{
				  condition.And(ST_STBPRP_B._.GSTCD.Contain(model.GSTCD));
				}
				if(model.HOUR!=null)
				{
				  condition.And(ST_STBPRP_B._.HOUR==(model.HOUR));
				}
				if(model.ISAUTO!=null)
				{
				  condition.And(ST_STBPRP_B._.ISAUTO==(model.ISAUTO));
				}
		return condition;
	}
        #endregion
    }
}