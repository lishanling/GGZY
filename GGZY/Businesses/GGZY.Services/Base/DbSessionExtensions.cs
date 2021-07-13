using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using Dos.ORM;

namespace GGZY.Services.Base
{
    public static class DbSessionExtensions
    {
        #region Base Extensions

        public static int Count<T>(this DbSession dbSession, WhereClipBuilder condition) where T : Entity
        {
            return dbSession.Count<T>(condition.ToWhereClip());
        }

        public static T FirstOrNull<T>(this DbSession dbSession, WhereClipBuilder condition) where T : Entity
        {
            return dbSession.FirstOrNull<T>(condition.ToWhereClip());
        }
        public static T FirstOrNull<T>(this DbSession dbSession, WhereClip condition) where T : Entity
        {
            return dbSession.From<T>().Where(condition).ToFirst();
        }
        public static T FirstOrNull<T>(this DbSession dbSession, Expression<Func<T, bool>> lambdaWhere) where T : Entity
        {
            return dbSession.From<T>().Where(lambdaWhere).ToFirst();

        }
        public static T FirstDefault<T>(this DbSession dbSession, WhereClipBuilder condition) where T : Entity
        {
            return dbSession.FirstDefault<T>(condition.ToWhereClip());
        }
        public static T FirstDefault<T>(this DbSession dbSession, WhereClip condition) where T : Entity
        {
            return dbSession.From<T>().Where(condition).ToFirstDefault();
        }
        public static DataTable ToDataTable(this DbSession dbSession, string sql, params DbParameter[] parameters)
        {
            if (parameters != null && parameters.Any())
            {
                return dbSession.FromSql(sql).AddParameter(parameters).ToDataTable();
            }
            return dbSession.FromSql(sql).ToDataTable();
        }
        public static DataTable ToDataTable<T>(this DbSession dbSession, WhereClip condition, OrderByClip orderBy = null, params Field[] fields) where T : Entity
        {
            var fromSession = dbSession.From<T>().Where(condition);
            if (orderBy != null)
            {
                fromSession = fromSession.OrderBy(orderBy);
            }

            if (fields != null && fields.Any())
            {
                fromSession = fromSession.Select(fields);
            }
            return fromSession.ToDataTable();
        }

        public static DataTable PageDataTable<T>(this DbSession dbSession, WhereClip condition, int pageSize, int pageNo, OrderByClip orderBy = null, params Field[] fields) where T : Entity
        {
            var fromSession = dbSession.From<T>().Where(condition);
            if (orderBy != null)
            {
                fromSession = fromSession.OrderBy(orderBy);
            }

            if (fields != null && fields.Any())
            {
                fromSession = fromSession.Select(fields);
            }
            return fromSession.Page(pageSize, pageNo).ToDataTable();
        }
        public static DataSet ToDataSet(this DbSession dbSession, string sql, params DbParameter[] parameters)
        {
            if (parameters != null && parameters.Any())
            {
                return dbSession.FromSql(sql).AddParameter(parameters).ToDataSet();
            }
            return dbSession.FromSql(sql).ToDataSet();
        }
        public static DataSet ToDataSet<T>(this DbSession dbSession, WhereClip condition, OrderByClip orderBy = null) where T : Entity
        {
            var fromSession = dbSession.From<T>().Where(condition);
            if (orderBy != null)
            {
                return fromSession.OrderBy(orderBy).ToDataSet();
            }
            return fromSession.ToDataSet();
        }

        public static List<T> FindList<T>(this DbSession dbSession, WhereClipBuilder condition, OrderByClip orderBy = null) where T : Entity
        {

            return dbSession.FindList<T>(condition.ToWhereClip(), orderBy);
        }
        public static List<T> FindList<T>(this DbSession dbSession, WhereClip condition, OrderByClip orderBy = null) where T : Entity
        {
            var fromSession = dbSession.From<T>().Where(condition);
            if (orderBy != null)
            {
                return fromSession.OrderBy(orderBy).ToList();
            }
            return fromSession.ToList();
        }
        public static List<T> FindAll<T>(this DbSession dbSession) where T : Entity
        {
            return dbSession.From<T>().ToList();
        }

        public static List<T> PageList<T>(this DbSession dbSession, WhereClipBuilder conditon, int pageSize, int pageNo,
            OrderByClip orderBy = null) where T : Entity
        {
            var fromSession = dbSession.From<T>().Where(conditon.ToWhereClip());
            if (orderBy != null)
            {
                fromSession = fromSession.OrderBy(orderBy);
            }
            fromSession = fromSession.Page(pageSize, pageNo);
            return fromSession.ToList();
        }

        #endregion


        public static int Max<TModel>(this DbSession dbSession, Field field) where TModel : Entity
        {
            return dbSession.From<TModel>().Select(field.Max()).ToScalar<int>();
        }
        public static int MaxWhere<TModel>(this DbSession dbSession, Field field,WhereClip where) where TModel : Entity
        {
            return dbSession.From<TModel>().Where(where).Select(field.Max()).ToScalar<int>();
        }
        public static int Insert<TModel>(this DbSession dbSession, TModel entity) where TModel : Entity
        {
            return dbSession.Insert<TModel>(entity);
        }
        public static int Insert<TModel>(this DbSession dbSession, IEnumerable<TModel> entities) where TModel : Entity
        {
            return dbSession.Insert<TModel>(entities);
        }

        public static int Delete<TModel>(this DbSession dbSession, TModel entity) where TModel : Entity
        {
            return dbSession.Delete<TModel>(entity);
        }

        public static int Delete<TModel>(this DbSession dbSession, WhereClip condition) where TModel : Entity
        {
            return dbSession.Delete<TModel>(condition);
        }

        public static int Update<TModel>(this DbSession dbSession, TModel entity) where TModel : Entity
        {
            return dbSession.Update<TModel>(entity);
        }

        public static int Update<TModel>(this DbSession dbSession, Field field, object value, WhereClip where) where TModel : Entity
        {
            return dbSession.Update<TModel>(field, value, where);
        }
        public static int Update<TModel>(this DbSession dbSession, Dictionary<Field, object> dic, WhereClip where) where TModel : Entity
        {
            return dbSession.Update<TModel>(dic, where);
        }
        public static FromSection<TModel> FromWhere<TModel>(this DbSession dbSession, WhereClip where) where TModel : Entity
        {
            return dbSession.From<TModel>().Where(where);
        }

        public static int Count<TModel>(this DbSession dbSession, WhereClip condition) where TModel : Entity
        {
            return dbSession.Count<TModel>(condition);
        }

        public static int ExecuteNonQuery(this DbSession dbSession, string sql)
        {
            return dbSession.FromSql(sql).ExecuteNonQuery();
        }

        public static SqlSection FromSql(this DbSession dbSession, string sql)
        {
            return dbSession.FromSql(sql);
        }
    }
}