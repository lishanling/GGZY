using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Dos.ORM;
using GGZY.Core.Models;

namespace GGZY.Services.Base
{
    public class BaseServiceFw<TModel> :BaseService where TModel:Entity
    {
        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }
        public virtual int Max(Field field)
        {
            return base.Max<TModel>(field);
        }
        public virtual int Insert(TModel entity)
        {
            return base.Insert<TModel>(entity);
        }
        public virtual int Insert(IEnumerable<TModel> entity)
        {
            return base.Insert(entity);
        }
        public virtual int Delete(WhereClip condition)
        {
            return base.Delete<TModel>(condition);
        }
        public virtual int Delete(TModel entity)
        {
            return base.Delete<TModel>(entity);
        }
        public virtual int Delete(IEnumerable<TModel> entities)
        {
            return base.Delete<TModel>(entities);
        }

        public virtual int DeleteAll()
        {
            return base.DeleteAll<TModel>();
        }
        public virtual int Update(TModel entity)
        {
            return base.Update(entity);
        }

        public virtual int Update(Field field, object value, WhereClip where)
        {
            return base.Update<TModel>(field, value, where);
        }
        public virtual int Update(Dictionary<Field, object> dic, WhereClip where)
        {
            return base.Update<TModel>(dic, where);
        }

        public virtual TModel FirstOrNull(WhereClipBuilder condition)
        {
            
            return this.FirstOrNull(condition.ToWhereClip());
        }
        public virtual TModel FirstOrNull(WhereClip condition)
        {
            return base.FirstOrNull<TModel>(condition);
        }
        public virtual TModel FirstOrNull(Expression<Func<TModel, bool>> lambdaWhere) 
        {
            return base.FirstOrNull(lambdaWhere);
        }

        public virtual List<TModel> FindAll()
        {
            return base.FindAll<TModel>();
        }

        public virtual List<TModel> FindList(WhereClipBuilder condition, OrderByClip orderBy = null)
        {
            return FindList(condition.ToWhereClip(), orderBy);
        }
        public virtual List<TModel> FindList(WhereClip condition, OrderByClip orderBy = null)
        {
            return base.FindList<TModel>(condition, orderBy);
        }
        public virtual List<TModel> PageList(WhereClipBuilder condition, SearchCondition cmd, OrderByClip orderBy = null)
        {
            return base.PageList<TModel>(condition, cmd.PageSize, cmd.PageNo, orderBy);
        }

        public virtual int Count(WhereClipBuilder condition)
        {
            return Count(condition.ToWhereClip());
        }

        public virtual int Count(WhereClip condition)
        {
            return base.Count<TModel>(condition);
        }

        public new DataTable ToDataTable(string sql)
        {
            return base.ToDataTable(sql);
        }

        public new DataSet ToDataSet(string sql)
        {
            return base.ToDataSet(sql);
        }

        public virtual DataTable ToDataTable(WhereClip where, OrderByClip orderBy = null, params Field[] fields)
        {
            return base.ToDataTable<TModel>(where, orderBy, fields);
        }

        public virtual DataTable PageDataTable(WhereClip where, SearchCondition cmd, OrderByClip orderBy = null, params Field[] fields)
        {
            return base.PageDataTable<TModel>(where, cmd.PageSize, cmd.PageNo, orderBy, fields);
        }

        public virtual FromSection<TModel> FromWhere(WhereClip where)
        {
            return base.FromWhere<TModel>(where);
        }




    }
}