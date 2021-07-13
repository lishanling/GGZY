using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TbTableconfigService : BaseServiceT<TB_TABLECONFIG>
    {
        #region 接口实现
        
		public List<TB_TABLECONFIG> FindList(TB_TABLECONFIG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TB_TABLECONFIG> PageList(TB_TABLECONFIG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TB_TABLECONFIG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TB_TABLECONFIG._.ID == ID);
			
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
        public GeneralResult Edit(TB_TABLECONFIG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TB_TABLECONFIG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PTID=model.PTID;
		entity.TBNAME=model.TBNAME;
		entity.DBCONFIG=model.DBCONFIG;
		entity.TBSAVETBNAME=model.TBSAVETBNAME;
		entity.PAGESIZE=model.PAGESIZE;
		entity.HEADHTML=model.HEADHTML;
		entity.SELECTSQLTYPE=model.SELECTSQLTYPE;
		entity.SELECTSQL=model.SELECTSQL;
		entity.INSERTSQLTYPE=model.INSERTSQLTYPE;
		entity.INSERTSQL=model.INSERTSQL;
		entity.UPDATESQLTYPE=model.UPDATESQLTYPE;
		entity.UPDATESQL=model.UPDATESQL;
		entity.DELETESQLTYPE=model.DELETESQLTYPE;
		entity.DELETESQL=model.DELETESQL;
		entity.FIELDIDS=model.FIELDIDS;
		entity.TABLETYPE=model.TABLETYPE;
		entity.ISADD=model.ISADD;
		entity.ISDELETE=model.ISDELETE;
		entity.ISEDIT=model.ISEDIT;
		entity.ISUPDATE=model.ISUPDATE;
		entity.ISSORT=model.ISSORT;
		entity.SORTFIELD=model.SORTFIELD;
		entity.ISIMPORT=model.ISIMPORT;
		entity.IMPORTBEGINROW=model.IMPORTBEGINROW;
		entity.ISIMPORTXLSTEMP=model.ISIMPORTXLSTEMP;
		entity.ISEXPORT=model.ISEXPORT;
		entity.EMPORTBEGINROW=model.EMPORTBEGINROW;
		entity.EMPORTXLSTEMP=model.EMPORTXLSTEMP;
		entity.ISHASROWNUM=model.ISHASROWNUM;
		entity.REMARK=model.REMARK;
		entity.EDITFORMWIDTH=model.EDITFORMWIDTH;
		entity.EDITFORMHEIGHT=model.EDITFORMHEIGHT;
		entity.ORDERFIELD=model.ORDERFIELD;
		entity.IMPORTSQLTYPE=model.IMPORTSQLTYPE;
		entity.IMPORTSQL=model.IMPORTSQL;
		entity.EXPORTSQLTYPE=model.EXPORTSQLTYPE;
		entity.EXPORTSQL=model.EXPORTSQL;
		entity.LOGFIELDIDS=model.LOGFIELDIDS;
		entity.GETMODELSQLTYPE=model.GETMODELSQLTYPE;
		entity.GETMODELSQL=model.GETMODELSQL;
		entity.MODELTYPE=model.MODELTYPE;
		entity.PREVIEWADDRESS=model.PREVIEWADDRESS;
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
        public GeneralResult Add(TB_TABLECONFIG model)
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
                    Delete(TB_TABLECONFIG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TB_TABLECONFIG> model)
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
       	protected WhereClipBuilder ConditionBuilder(TB_TABLECONFIG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TB_TABLECONFIG._.ID==(model.ID));
				}
				if(model.PTID!=null)
				{
				  condition.And(TB_TABLECONFIG._.PTID==(model.PTID));
				}
				if(!string.IsNullOrWhiteSpace(model.TBNAME))
				{
				  condition.And(TB_TABLECONFIG._.TBNAME.Contain(model.TBNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DBCONFIG))
				{
				  condition.And(TB_TABLECONFIG._.DBCONFIG.Contain(model.DBCONFIG));
				}
				if(!string.IsNullOrWhiteSpace(model.TBSAVETBNAME))
				{
				  condition.And(TB_TABLECONFIG._.TBSAVETBNAME.Contain(model.TBSAVETBNAME));
				}
				if(model.PAGESIZE!=null)
				{
				  condition.And(TB_TABLECONFIG._.PAGESIZE==(model.PAGESIZE));
				}
				if(!string.IsNullOrWhiteSpace(model.HEADHTML))
				{
				  condition.And(TB_TABLECONFIG._.HEADHTML.Contain(model.HEADHTML));
				}
				if(model.SELECTSQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.SELECTSQLTYPE==(model.SELECTSQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELECTSQL))
				{
				  condition.And(TB_TABLECONFIG._.SELECTSQL.Contain(model.SELECTSQL));
				}
				if(model.INSERTSQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.INSERTSQLTYPE==(model.INSERTSQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.INSERTSQL))
				{
				  condition.And(TB_TABLECONFIG._.INSERTSQL.Contain(model.INSERTSQL));
				}
				if(model.UPDATESQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.UPDATESQLTYPE==(model.UPDATESQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.UPDATESQL))
				{
				  condition.And(TB_TABLECONFIG._.UPDATESQL.Contain(model.UPDATESQL));
				}
				if(model.DELETESQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.DELETESQLTYPE==(model.DELETESQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.DELETESQL))
				{
				  condition.And(TB_TABLECONFIG._.DELETESQL.Contain(model.DELETESQL));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELDIDS))
				{
				  condition.And(TB_TABLECONFIG._.FIELDIDS.Contain(model.FIELDIDS));
				}
				if(model.TABLETYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.TABLETYPE==(model.TABLETYPE));
				}
				if(model.ISADD!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISADD==(model.ISADD));
				}
				if(model.ISDELETE!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISDELETE==(model.ISDELETE));
				}
				if(model.ISEDIT!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISEDIT==(model.ISEDIT));
				}
				if(model.ISUPDATE!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISUPDATE==(model.ISUPDATE));
				}
				if(model.ISSORT!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISSORT==(model.ISSORT));
				}
				if(!string.IsNullOrWhiteSpace(model.SORTFIELD))
				{
				  condition.And(TB_TABLECONFIG._.SORTFIELD.Contain(model.SORTFIELD));
				}
				if(model.ISIMPORT!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISIMPORT==(model.ISIMPORT));
				}
				if(model.IMPORTBEGINROW!=null)
				{
				  condition.And(TB_TABLECONFIG._.IMPORTBEGINROW==(model.IMPORTBEGINROW));
				}
				if(!string.IsNullOrWhiteSpace(model.ISIMPORTXLSTEMP))
				{
				  condition.And(TB_TABLECONFIG._.ISIMPORTXLSTEMP.Contain(model.ISIMPORTXLSTEMP));
				}
				if(model.ISEXPORT!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISEXPORT==(model.ISEXPORT));
				}
				if(model.EMPORTBEGINROW!=null)
				{
				  condition.And(TB_TABLECONFIG._.EMPORTBEGINROW==(model.EMPORTBEGINROW));
				}
				if(!string.IsNullOrWhiteSpace(model.EMPORTXLSTEMP))
				{
				  condition.And(TB_TABLECONFIG._.EMPORTXLSTEMP.Contain(model.EMPORTXLSTEMP));
				}
				if(model.ISHASROWNUM!=null)
				{
				  condition.And(TB_TABLECONFIG._.ISHASROWNUM==(model.ISHASROWNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(TB_TABLECONFIG._.REMARK.Contain(model.REMARK));
				}
				if(model.EDITFORMWIDTH!=null)
				{
				  condition.And(TB_TABLECONFIG._.EDITFORMWIDTH==(model.EDITFORMWIDTH));
				}
				if(model.EDITFORMHEIGHT!=null)
				{
				  condition.And(TB_TABLECONFIG._.EDITFORMHEIGHT==(model.EDITFORMHEIGHT));
				}
				if(!string.IsNullOrWhiteSpace(model.ORDERFIELD))
				{
				  condition.And(TB_TABLECONFIG._.ORDERFIELD.Contain(model.ORDERFIELD));
				}
				if(model.IMPORTSQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.IMPORTSQLTYPE==(model.IMPORTSQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.IMPORTSQL))
				{
				  condition.And(TB_TABLECONFIG._.IMPORTSQL.Contain(model.IMPORTSQL));
				}
				if(model.EXPORTSQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.EXPORTSQLTYPE==(model.EXPORTSQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPORTSQL))
				{
				  condition.And(TB_TABLECONFIG._.EXPORTSQL.Contain(model.EXPORTSQL));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGFIELDIDS))
				{
				  condition.And(TB_TABLECONFIG._.LOGFIELDIDS.Contain(model.LOGFIELDIDS));
				}
				if(model.GETMODELSQLTYPE!=null)
				{
				  condition.And(TB_TABLECONFIG._.GETMODELSQLTYPE==(model.GETMODELSQLTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.GETMODELSQL))
				{
				  condition.And(TB_TABLECONFIG._.GETMODELSQL.Contain(model.GETMODELSQL));
				}
				if(!string.IsNullOrWhiteSpace(model.MODELTYPE))
				{
				  condition.And(TB_TABLECONFIG._.MODELTYPE.Contain(model.MODELTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PREVIEWADDRESS))
				{
				  condition.And(TB_TABLECONFIG._.PREVIEWADDRESS.Contain(model.PREVIEWADDRESS));
				}
		return condition;
	}
        #endregion
    }
}