using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using GGZY.Core.Utils;
using GGZY.Services.Extensions;

namespace GGZY.Services.JianDu
{
    public partial class CommonService
    {

        #region General Table

        public List<LabelValueModel> GeneralTable(SearchCondition search, out int _)
        {
            var tableName = new Field("TABLE_NAME");
            var comments = new Field("COMMENTS");

            var whereClip = WhereClip.All;
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                whereClip = tableName.Contain(search.KeyWord.ToUpper()) || comments.Contain(search.KeyWord);
            }

            var query = FromTable("USER_TAB_COMMENTS").Where(whereClip);
            _ = query.Count();

            var r = query
                .OrderBy(tableName.Asc)
                .Select(tableName.As("Value"), comments.As("Label"))
                .Page(search.PageSize, search.PageNo)
                .ToList<LabelValueModel>();
            return r;
        }

        public List<GeneralColumn> GeneralColumn(string tbName)
        {
            var tableName = tbName.DesDecrypt();
            var sql = $@"SELECT A.COLUMN_ID AS SORT,
       A.COLUMN_NAME AS NAME,
       A.TABLE_NAME AS TABLENAME,
       A.DATA_TYPE AS JDBC_TYPE,
       A.DATA_LENGTH AS LENGTH,
       A.DATA_PRECISION AS PRECISION,
       A.DATA_SCALE AS SCALE,
       CASE A.NULLABLE
         WHEN 'Y' THEN
          '是'
         ELSE
          '否'
       END AS IS_NULL,
       A.DATA_DEFAULT AS DEFAULT_VAL,
       C.COMMENTS AS COMMENTS,
       CASE
         WHEN B.COLUMN_NAME IS NULL THEN
          '否'
         ELSE
          '是'
       END AS IS_PK
  FROM USER_TAB_COLUMNS A
  LEFT JOIN (SELECT USER_CONS_COLUMNS.*
               FROM USER_CONS_COLUMNS
              INNER JOIN USER_CONSTRAINTS
                 ON USER_CONS_COLUMNS.TABLE_NAME =
                    USER_CONSTRAINTS.TABLE_NAME
                AND USER_CONS_COLUMNS.CONSTRAINT_NAME =
                    USER_CONSTRAINTS.CONSTRAINT_NAME
                AND USER_CONSTRAINTS.CONSTRAINT_TYPE = 'P') B
    ON A.COLUMN_NAME = B.COLUMN_NAME
   AND A.TABLE_NAME = B.TABLE_NAME
 INNER JOIN USER_COL_COMMENTS C
    ON A.TABLE_NAME = C.TABLE_NAME
   AND A.COLUMN_NAME = C.COLUMN_NAME
   AND A.TABLE_NAME = :tablename
 ORDER BY A.COLUMN_ID
";
            var dt = FromSql(sql).AddInParameter(":tablename", DbType.String, tableName).ToList<GeneralColumn>();
            return dt;
        }

        public List<object> GenSearch(List<NameValueModel> dic, SearchCondition search, out int _)
        {
            var parms = dic.FindAll(c => !string.IsNullOrWhiteSpace(c.Value));
            var tableName = dic.FirstOrDefault(c => c.Name.Equals("tid", StringComparison.CurrentCultureIgnoreCase))
                ?.Value.DesDecrypt();
            var whereClip = new WhereClipBuilder();

            foreach (var item in parms)
            {
                if (item.Name.Equals("tid", StringComparison.CurrentCultureIgnoreCase))
                {
                    continue;
                }

                whereClip.And(new Field(item.Name).Contain(item.Value));
            }
            var query = FromTable(tableName).Where(whereClip.ToWhereClip());
            _ = query.Count();
            var fieldName = dic
                    .FirstOrDefault(c => !c.Name.Equals("tid", StringComparison.CurrentCultureIgnoreCase))?.Name;
            var orderByOperate = OrderByOperater.DESC;
            if (!string.IsNullOrWhiteSpace(search.OrderBy))
            {
                fieldName = search.OrderBy.Split(' ').FirstOrDefault();
                if (search.OrderBy.Contains("asc"))
                {
                    orderByOperate = OrderByOperater.ASC;
                }
            }
            var orderBy = new OrderByClip(fieldName, orderByOperate);
            var r = query
                .OrderBy(orderBy)
                .Page(search.PageSize, search.PageNo).ToList<object>();
            return r;
        }

        public object GenDetail(NameValueModel search)
        {
            var tableName = search.Id.DesDecrypt();
            var dt = FromTable(tableName).Where(new Field(search.Name) == search.Value).ToFirst<object>();
            return dt;
        }
        
        #endregion

    }
}