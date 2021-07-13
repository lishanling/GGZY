using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq.Expressions;
using Dos.ORM;
using GGZYJD.DbEntity;

namespace GGZY.Services.Base
{
    public abstract partial class BaseService
    {
        public abstract DbSession GetDbSession();

        public bool Exists<TModel>(WhereClip where) where TModel : Entity
        {
            return GetDbSession().Exists<TModel>(where);
        }
        public virtual int Max<TModel>(Field field) where TModel : Entity
        {
            return GetDbSession().Max<TModel>(field);
        }
        public virtual int Max<TModel>(Field field, WhereClip where) where TModel : Entity
        {
            return GetDbSession().MaxWhere<TModel>(field,where);
        }
        public virtual int Insert<TModel>(TModel entity) where TModel : Entity
        {
            return GetDbSession().Insert<TModel>(entity);
        }
        public virtual int Insert<TModel>(IEnumerable<TModel> entities) where TModel : Entity
        {
            return GetDbSession().Insert<TModel>(entities);
        }

        public virtual int Delete<TModel>(TModel entity) where TModel : Entity
        {
            return GetDbSession().Delete<TModel>(entity);
        }
        public virtual int Delete<TModel>(IEnumerable<TModel> entity) where TModel : Entity
        {
            return GetDbSession().Delete<TModel>(entity);
        }
        public virtual int Delete<TModel>(WhereClip condition) where TModel : Entity
        {
            return GetDbSession().Delete<TModel>(condition);
        }

        public virtual int DeleteAll<TModel>() where TModel : Entity
        {
            return GetDbSession().DeleteAll<TModel>();
        }

        public virtual int Update<TModel>(TModel entity) where TModel : Entity
        {
            return GetDbSession().Update<TModel>(entity);
        }

        public virtual int Update<TModel>(Field field, object value, WhereClip where) where TModel : Entity
        {
            return GetDbSession().Update<TModel>(field, value, where);
        }
        public virtual int Update<TModel>(Dictionary<Field, object> dic, WhereClip where) where TModel : Entity
        {
            return GetDbSession().Update<TModel>(dic, where);
        }
        public virtual DataTable PageDataTable<TModel>(WhereClip where, int pageSize, int pageNo, OrderByClip orderBy = null, params Field[] fields) where TModel : Entity
        {
            return GetDbSession().PageDataTable<TModel>(where, pageSize, pageNo, orderBy, fields);
        }
        public virtual FromSection<TModel> FromWhere<TModel>(WhereClip where = null,string alias="") where TModel : Entity
        {
            return @where == null ? GetDbSession().From<TModel>(alias) : GetDbSession().From<TModel>(alias).Where(@where);
        }

        public virtual FromSection<Entity> FromTable(string tableName)
        {
            return GetDbSession().FromTable(tableName);
        }
        public virtual int Count<TModel>(WhereClip condition) where TModel : Entity
        {
            return GetDbSession().Count<TModel>(condition);
        }

        public virtual TModel FirstOrNull<TModel>(WhereClip condition) where TModel : Entity
        {
            return GetDbSession().FirstOrNull<TModel>(condition);
        }
        public virtual TModel FirstOrNull<TModel>(Expression<Func<TModel, bool>> lambdaWhere) where TModel : Entity
        {
            return GetDbSession().FirstOrNull<TModel>(lambdaWhere);
        }
        public virtual List<TModel> FindList<TModel>(WhereClip condition, OrderByClip orderBy = null) where TModel : Entity
        {
            return GetDbSession().FindList<TModel>(condition, orderBy);
        }
        public virtual List<TModel> FindAll<TModel>() where TModel : Entity
        {
            return GetDbSession().FindAll<TModel>();
        }

        public virtual List<TModel> PageList<TModel>(WhereClipBuilder condition, int pageSize, int pageNo, OrderByClip orderBy = null) where TModel : Entity
        {
            return GetDbSession().PageList<TModel>(condition, pageSize, pageNo, orderBy);
        }
        public virtual DataTable ToDataTable<TModel>(WhereClip where, OrderByClip orderBy = null, params Field[] fields) where TModel : Entity
        {
            return GetDbSession().ToDataTable<TModel>(where, orderBy, fields);
        }

        public virtual DataTable ToDataTable(string sql)
        {
            return GetDbSession().ToDataTable(sql);
        }

        public virtual DataSet ToDataSet(string sql)
        {
            return GetDbSession().ToDataSet(sql);
        }

        public virtual int ExecuteNonQuery(string sql)
        {
            return FromSql(sql).ExecuteNonQuery();
        }

        public virtual SqlSection FromSql(string sql)
        {
            return GetDbSession().FromSql(sql);
        }

        public virtual SqlSection FromSqlByPage(string sql, int pageIndex, int pageSize, string orderby, List<OracleParameter> dbParams, out int count)
        {

            count = GetDbSession().FromSql(sql).AddParameter(dbParams.ToArray()).Count();
            sql = $@"
                        select tmpRn RN,tmp2.* from (
                            select tmp.*,row_number() over(order by {orderby}) tmpRn from ({sql}) tmp   
                          ) tmp2
                         where tmpRn BETWEEN {pageSize}*({pageIndex}-1)+1 AND {pageSize}*{pageIndex}
                        ";
            return GetDbSession().FromSql(sql).AddParameter(dbParams.ToArray());
        }

    }
}
