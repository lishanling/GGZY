using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace GGZY.Core.Models
{
    public class PageTableResult
    {
        public int PageTotal => (int) (Total / PageSize) + (Total % PageSize != 0 ? 1 : 0);
        public int PageNo { get; set; }

        public Int64 Total { get; set; }

        public int PageSize { get; set; }

        public object Table { get; set; }
    }

    public class PageTableResult<T>: PageTableResult
    {
        [JsonIgnore]
        public IEnumerable<T> TData { get; set; }
    }

}