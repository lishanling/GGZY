using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TbTablefieldconfigService : BaseServiceT<TB_TABLEFIELDCONFIG>
    {
        #region 接口实现
        
		public List<TB_TABLEFIELDCONFIG> FindList(TB_TABLEFIELDCONFIG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TB_TABLEFIELDCONFIG> PageList(TB_TABLEFIELDCONFIG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TB_TABLEFIELDCONFIG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TB_TABLEFIELDCONFIG._.ID == ID);
			
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
        public GeneralResult Edit(TB_TABLEFIELDCONFIG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TB_TABLEFIELDCONFIG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TCID=model.TCID;
		entity.FNAME=model.FNAME;
		entity.FVALUE=model.FVALUE;
		entity.PHYSICALCOLNAME=model.PHYSICALCOLNAME;
		entity.FTYPE=model.FTYPE;
		entity.ISKEY=model.ISKEY;
		entity.ISNULL=model.ISNULL;
		entity.ISSTATISTICS=model.ISSTATISTICS;
		entity.FROEIGNTB=model.FROEIGNTB;
		entity.FROEIGNNAME=model.FROEIGNNAME;
		entity.FROEIGNVALUE=model.FROEIGNVALUE;
		entity.FROEIGNSQL=model.FROEIGNSQL;
		entity.ISSEARCHFIELD=model.ISSEARCHFIELD;
		entity.SEARCHTYPE=model.SEARCHTYPE;
		entity.SEARCHSQL=model.SEARCHSQL;
		entity.SEARCHORDER=model.SEARCHORDER;
		entity.MINLEN=model.MINLEN;
		entity.MAXLEN=model.MAXLEN;
		entity.SIGNIFICANTDIGIT=model.SIGNIFICANTDIGIT;
		entity.DECIMALCOUNT=model.DECIMALCOUNT;
		entity.REGULAR=model.REGULAR;
		entity.ORDERID=model.ORDERID;
		entity.FIELDWIDTH=model.FIELDWIDTH;
		entity.ISVISIABLE=model.ISVISIABLE;
		entity.ISSELFADD=model.ISSELFADD;
		entity.DEFAULTVALUE=model.DEFAULTVALUE;
		entity.TEXTALGIN=model.TEXTALGIN;
		entity.SQLFORMAT=model.SQLFORMAT;
		entity.ISMUST=model.ISMUST;
		entity.UNIT=model.UNIT;
		entity.CONTROLTYPE=model.CONTROLTYPE;
		entity.EDITPAGEORDERID=model.EDITPAGEORDERID;
		entity.COLSPAN=model.COLSPAN;
		entity.CONTROLHEIGHT=model.CONTROLHEIGHT;
		entity.CONTROLWIDTH=model.CONTROLWIDTH;
		entity.ISIDENTITY=model.ISIDENTITY;
		entity.ISADD=model.ISADD;
		entity.ADDINITTYPE=model.ADDINITTYPE;
		entity.ISEMPORT=model.ISEMPORT;
		entity.FIELDTAG=model.FIELDTAG;
		entity.FIELDPAR=model.FIELDPAR;
		entity.REMARK=model.REMARK;
		entity.FORMATMETHOD=model.FORMATMETHOD;
		entity.FORMATPAR=model.FORMATPAR;
		entity.LINKID=model.LINKID;
		entity.LINKSQL=model.LINKSQL;
		entity.FROEIGNSQLFORAUDIT=model.FROEIGNSQLFORAUDIT;
		entity.VALIMSG=model.VALIMSG;
		entity.ISIMPORT=model.ISIMPORT;
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
        public GeneralResult Add(TB_TABLEFIELDCONFIG model)
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
                    Delete(TB_TABLEFIELDCONFIG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TB_TABLEFIELDCONFIG> model)
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
       	protected WhereClipBuilder ConditionBuilder(TB_TABLEFIELDCONFIG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ID==(model.ID));
				}
				if(model.TCID!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.TCID==(model.TCID));
				}
				if(!string.IsNullOrWhiteSpace(model.FNAME))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FNAME.Contain(model.FNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FVALUE))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FVALUE.Contain(model.FVALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.PHYSICALCOLNAME))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.PHYSICALCOLNAME.Contain(model.PHYSICALCOLNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FTYPE))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FTYPE.Contain(model.FTYPE));
				}
				if(model.ISKEY!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISKEY==(model.ISKEY));
				}
				if(model.ISNULL!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISNULL==(model.ISNULL));
				}
				if(model.ISSTATISTICS!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISSTATISTICS==(model.ISSTATISTICS));
				}
				if(!string.IsNullOrWhiteSpace(model.FROEIGNTB))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FROEIGNTB.Contain(model.FROEIGNTB));
				}
				if(!string.IsNullOrWhiteSpace(model.FROEIGNNAME))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FROEIGNNAME.Contain(model.FROEIGNNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FROEIGNVALUE))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FROEIGNVALUE.Contain(model.FROEIGNVALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.FROEIGNSQL))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FROEIGNSQL.Contain(model.FROEIGNSQL));
				}
				if(model.ISSEARCHFIELD!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISSEARCHFIELD==(model.ISSEARCHFIELD));
				}
				if(model.SEARCHTYPE!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.SEARCHTYPE==(model.SEARCHTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SEARCHSQL))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.SEARCHSQL.Contain(model.SEARCHSQL));
				}
				if(model.SEARCHORDER!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.SEARCHORDER==(model.SEARCHORDER));
				}
				if(model.MINLEN!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.MINLEN==(model.MINLEN));
				}
				if(model.MAXLEN!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.MAXLEN==(model.MAXLEN));
				}
				if(model.SIGNIFICANTDIGIT!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.SIGNIFICANTDIGIT==(model.SIGNIFICANTDIGIT));
				}
				if(model.DECIMALCOUNT!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.DECIMALCOUNT==(model.DECIMALCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.REGULAR))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.REGULAR.Contain(model.REGULAR));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ORDERID==(model.ORDERID));
				}
				if(model.FIELDWIDTH!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FIELDWIDTH==(model.FIELDWIDTH));
				}
				if(model.ISVISIABLE!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISVISIABLE==(model.ISVISIABLE));
				}
				if(model.ISSELFADD!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISSELFADD==(model.ISSELFADD));
				}
				if(!string.IsNullOrWhiteSpace(model.DEFAULTVALUE))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.DEFAULTVALUE.Contain(model.DEFAULTVALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEXTALGIN))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.TEXTALGIN.Contain(model.TEXTALGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.SQLFORMAT))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.SQLFORMAT.Contain(model.SQLFORMAT));
				}
				if(model.ISMUST!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISMUST==(model.ISMUST));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.UNIT.Contain(model.UNIT));
				}
				if(model.CONTROLTYPE!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.CONTROLTYPE==(model.CONTROLTYPE));
				}
				if(model.EDITPAGEORDERID!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.EDITPAGEORDERID==(model.EDITPAGEORDERID));
				}
				if(model.COLSPAN!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.COLSPAN==(model.COLSPAN));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROLHEIGHT))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.CONTROLHEIGHT.Contain(model.CONTROLHEIGHT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROLWIDTH))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.CONTROLWIDTH.Contain(model.CONTROLWIDTH));
				}
				if(model.ISIDENTITY!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISIDENTITY==(model.ISIDENTITY));
				}
				if(model.ISADD!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISADD==(model.ISADD));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDINITTYPE))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ADDINITTYPE.Contain(model.ADDINITTYPE));
				}
				if(model.ISEMPORT!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISEMPORT==(model.ISEMPORT));
				}
				if(model.FIELDTAG!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FIELDTAG==(model.FIELDTAG));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELDPAR))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FIELDPAR.Contain(model.FIELDPAR));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.FORMATMETHOD))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FORMATMETHOD.Contain(model.FORMATMETHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.FORMATPAR))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FORMATPAR.Contain(model.FORMATPAR));
				}
				if(!string.IsNullOrWhiteSpace(model.LINKID))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.LINKID.Contain(model.LINKID));
				}
				if(!string.IsNullOrWhiteSpace(model.LINKSQL))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.LINKSQL.Contain(model.LINKSQL));
				}
				if(!string.IsNullOrWhiteSpace(model.FROEIGNSQLFORAUDIT))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.FROEIGNSQLFORAUDIT.Contain(model.FROEIGNSQLFORAUDIT));
				}
				if(!string.IsNullOrWhiteSpace(model.VALIMSG))
				{
				  condition.And(TB_TABLEFIELDCONFIG._.VALIMSG.Contain(model.VALIMSG));
				}
				if(model.ISIMPORT!=null)
				{
				  condition.And(TB_TABLEFIELDCONFIG._.ISIMPORT==(model.ISIMPORT));
				}
		return condition;
	}
        #endregion
    }
}