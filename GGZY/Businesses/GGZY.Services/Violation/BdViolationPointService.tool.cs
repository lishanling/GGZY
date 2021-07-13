using Dos.ORM;
using GGZY.Core.Models;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationPointService
    {
        public GeneralResult List(string code = "")
        {
            var r = new GeneralResult();

            var condition = new WhereClipBuilder();
            condition.And(BD_VIOLATION_POINT._.IS_DELETE == 0 &&
                BD_VIOLATION_POINT._.IS_ENABLE == 1);
            if (!String.IsNullOrWhiteSpace(code))
            {
                condition.And(BD_VIOLATION_POINT._.CATEGORY_CODE.BeginWith(code.ToUpper())
                    && BD_VIOLATION_POINT._.CATEGORY_CODE != code.ToUpper());
            }
            else
            {
                condition.And(BD_VIOLATION_POINT._.PARENT_ID == 0);
            }



            //查询所有的违规点对应的项目以及主体记录
            StringBuilder sbType = new StringBuilder();
            sbType.AppendLine("  SELECT DISTINCT POINT_CODE, 'ENTITY' AS RECORD_TYPE");
            sbType.AppendLine("    FROM BD_VIOLATION_ENTITY");
            sbType.AppendLine("  UNION ALL");
            sbType.AppendLine("  SELECT DISTINCT POINT_CODE, 'PROJECT' AS RECORD_TYPE");
            sbType.AppendLine("    FROM BD_VIOLATION_RECORD");

            var types = FromSql(sbType.ToString()).ToList<POINT_TYPE>();

            //父级CODE不为空
            if (!String.IsNullOrWhiteSpace(code))
            {
                var cond = new WhereClipBuilder();
                cond.And(BD_VIOLATION_POINT_DETAIL._.CODE.BeginWith(code.ToUpper()));
                var result = FindList<BD_VIOLATION_POINT_DETAIL>(cond.ToWhereClip())
                    .OrderByDescending(od => od.IS_ENABLE)
                    .OrderBy(od => od.SORT)
                    .Select(t => new
                    {
                        label = t.NAME,
                        value = t.CODE,
                        record_type = t.IS_ENABLE == 0 ? new List<string>() : types.Where(w => w.POINT_CODE.StartsWith(t.CODE)).Select(t1 => t1.RECORD_TYPE).Distinct()
                    }).ToList();

                r.SetSuccess(new
                {
                    has_child = result.Any() ? 1 : 0,
                    data = result
                });
                return r;
            }


            var data = FindList(condition.ToWhereClip())
                .OrderBy(od => od.SORT)
                .Select(t => new
                {
                    label = t.CATEGORY_NAME,
                    value = t.CATEGORY_CODE,
                    record_type = types.Where(w => w.POINT_CODE.StartsWith(t.CATEGORY_CODE)).Select(t1 => t1.RECORD_TYPE).Distinct()
                }).ToList();


            r.SetSuccess(new
            {
                has_child = data.Any() ? 1 : 0,
                data = data
            });
            return r;
        }

        /// <summary>
        /// 树形结构返回违规类别信息
        /// </summary>
        /// <param name="code">父级违规类别编码</param>
        /// <returns></returns>
        public dynamic TreeList(string code = "")
        {
            var r = new GeneralResult();
            //查询所有的违规点对应的项目以及主体记录
            StringBuilder sbType = new StringBuilder();
            sbType.AppendLine("  SELECT DISTINCT POINT_CODE, 'ENTITY' AS RECORD_TYPE");
            sbType.AppendLine("    FROM BD_VIOLATION_ENTITY");
            sbType.AppendLine("  UNION ALL");
            sbType.AppendLine("  SELECT  DISTINCT POINT_CODE, 'PROJECT' AS RECORD_TYPE");
            sbType.AppendLine("    FROM BD_VIOLATION_RECORD");

            var types = FromSql(sbType.ToString()).ToList<POINT_TYPE>();

            var data = GetChild(types,code);

            var record_type = types.Select(t => t.RECORD_TYPE);
            if (! String.IsNullOrWhiteSpace(code))
            {
                record_type = types.Where(w=>w.POINT_CODE.StartsWith(code)).Select(t => t.RECORD_TYPE);
            }
            data.Insert(0, new RETURN_POINT { label = "全部", value = code, record_type = types.Select(t=>t.RECORD_TYPE).Distinct(), children = null });

            return data;
        }


        private List<RETURN_POINT> GetChild(List<POINT_TYPE> types, string code = "")
        {

            var condition = new WhereClipBuilder();
            condition.And(BD_VIOLATION_POINT._.IS_DELETE == 0 &&
                BD_VIOLATION_POINT._.IS_ENABLE == 1);
            if (!String.IsNullOrWhiteSpace(code))
            {
                condition.And(BD_VIOLATION_POINT._.CATEGORY_CODE.BeginWith(code.ToUpper())
                    && BD_VIOLATION_POINT._.CATEGORY_CODE != code.ToUpper());
            }
            else
            {
                condition.And(BD_VIOLATION_POINT._.PARENT_ID == 0);
            }


            //父级CODE不为空
            if (!String.IsNullOrWhiteSpace(code))
            {
                var cond = new WhereClipBuilder();
                cond.And(BD_VIOLATION_POINT_DETAIL._.CODE.BeginWith(code.ToUpper()) &&
                    BD_VIOLATION_POINT_DETAIL._.CODE != code.ToUpper());
                var result = FindList<BD_VIOLATION_POINT_DETAIL>(cond.ToWhereClip())
                    .OrderByDescending(od => od.IS_ENABLE)
                    .OrderBy(od => od.SORT)
                    .Select(t => new RETURN_POINT
                    {
                        label = t.NAME,
                        value = t.CODE,
                        record_type = t.IS_ENABLE == 0 ? new List<string>() : types.Where(w => w.POINT_CODE.StartsWith(t.CODE)).Select(t1 => t1.RECORD_TYPE).Distinct(),
                        children = null
                    }).ToList();

                return result;
            }


            var data = FindList(condition.ToWhereClip())
                .OrderBy(od => od.SORT)
                .Select(t => new RETURN_POINT
                {
                    label = t.CATEGORY_NAME,
                    value = t.CATEGORY_CODE,
                    record_type = types.Where(w => w.POINT_CODE.StartsWith(t.CATEGORY_CODE)).Select(t1 => t1.RECORD_TYPE).Distinct(),
                    children = GetChild(types,t.CATEGORY_CODE)
                }).ToList();

            return data;
        }

        public class POINT_TYPE
        {
            /// <summary>
            /// 违规类别编码
            /// </summary>
            public string POINT_CODE { get; set; }
            /// <summary>
            /// 违规记录类型  ENTITY:主体 PROJECT:项目
            /// </summary>
            public string RECORD_TYPE { get; set; }
        }

        /// <summary>
        /// 返回给前端使用的违规项目类别树形列表信息
        /// </summary>
        public class RETURN_POINT
        {
            public string label { get; set; }
            public string value { get; set; }
            //规记录类型 ENTITY:主体 PROJECT:项目
            public IEnumerable<string> record_type { get; set; }

            public List<RETURN_POINT> children { get; set; }
        }
    }
}