using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GGZY.Core.Models
{

    public class BootstrapTableResult
    {
        public Int64 total { get; set; }

        public IEnumerable<object> rows { get; set; }
    }

    public class BootstrapDataTableResult
    {
        public Int64 total { get; set; }

        public DataTable rows { get; set; }
    }

    public class BootstrapTableResult<T>
    {
        public Int64 total { get; set; }

        public IEnumerable<T> rows { get; set; }
    }



    public static class BootstrapTableResultExtensions
    {
        public static BootstrapTableResult<T> ToBootstrapTableList<T>(this IEnumerable<T> list, int? total = null)
        {
            var result = new BootstrapTableResult<T>
            {
                total = total ?? list.ToList().Count,
                rows = list,
            };
            return result;
        }
        public static BootstrapDataTableResult ToBootstrapTableList(this DataTable list, int? total = null)
        {
            var result = new BootstrapDataTableResult
            {
                total = total ?? list.Rows.Count,
                rows = list,
            };
            return result;
        }

        public static PageTableResult ToPageTableResult<T>(this IEnumerable<T> list, SearchCondition search, int total)
        {

            return new PageTableResult
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = total,
                Table = list,
                //PageTotal = (int)(count / search.PageSize) + (count % search.PageSize != 0 ? 1 : 0)
            };
        }
        public static PageTableResult<T> ToPageTableTResult<T>(this IEnumerable<T> list, SearchCondition search, int total)
        {
           
            return new PageTableResult<T>
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = total,
                TData = list,
                Table = list,
                //PageTotal = (int)(count / search.PageSize) + (count % search.PageSize != 0 ? 1 : 0)
            };
        }
        public static PageTableResult<T> ToPageTableTResult<T>(this IEnumerable<T> list, SearchCondition search, int total, Func<T, T> selector = null)
        {
            var enumerable = list.ToList();
            if (selector != null)
            {
                enumerable = list.Select(selector).ToList();
            }
            return new PageTableResult<T>
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = total,
                TData = enumerable,
                Table = enumerable,
                //PageTotal = (int)(count / search.PageSize) + (count % search.PageSize != 0 ? 1 : 0)
            };
        }
        public static PageTableResult ToPageTableResult<T>(this IEnumerable<T> list, SearchCondition search, int? total = null, Func<T, object> selector = null)
        {
            object enumerable = list.ToList();
            var count = total ?? list.ToList().Count;
            if (selector != null)
            {
                enumerable = list.Select(selector).ToList();
            }
            return new PageTableResult
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                Table = enumerable,
                //PageTotal = (int)(count / search.PageSize) + (count % search.PageSize != 0 ? 1 : 0)
            };
        }

        public static PageTableResult ToPageTableResult<T>(this BootstrapTableResult<T> rsp, SearchCondition search, Func<T, object> selector = null)
        {
            object table = rsp.rows;
            if (selector != null)
            {
                table = rsp.rows.Select(selector).ToList();
            }
            return new PageTableResult
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = rsp.total,
                Table = table,
                //PageTotal = pageTotal
            };
        }



    }


}