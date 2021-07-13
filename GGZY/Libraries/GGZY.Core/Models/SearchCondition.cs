using System;
using System.Collections.Generic;
using System.Linq;

namespace GGZY.Core.Models
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public class SearchCondition
    {
        private string _SORT;
        private DateTime? _BEGIN_TIME;
        private DateTime? _END_TIME;


        /// <summary>
        /// 页码 从1开始
        /// </summary>
        public int PageNo { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; } = 10;
        /// <summary>
        /// 当前页第一条记录索引
        /// 如 1页10条 第一页第一条为1
        /// </summary>
        public int StartIndex => EndIndex - PageSize + 1;

        /// <summary>
        /// 当前页最后一条记录索引
        /// 如 1页10条，第一页最后一条为10
        /// </summary>
        public int EndIndex => PageNo * PageSize;

        /// <summary>
        /// 上一页最后一条记录索引
        /// 如 1页10条 当前页为第二页 则 上一页最后一条记录索引为10
        /// </summary>
        public int Skip => (PageNo - 1) * PageSize;

        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime? BeginTime
        {
            get => _BEGIN_TIME;
            set => _BEGIN_TIME = value;
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? EndTime
        {
            get => _END_TIME;
            set => _END_TIME = value;
        }

        /// <summary>
        /// 关键字
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary> 
        /// 排序字段 可空
        /// </summary>
        public string Sort
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_SORT) && !String.IsNullOrWhiteSpace(OrderBy))
                {
                    _SORT= OrderBy.Split(' ').FirstOrDefault();
                }
                return _SORT;
            }
            set => _SORT = value;
        }

        

        /// <summary>
        /// 倒叙DESC 正序 ASC 可空
        /// </summary>
        public string OrderBy { get; set; }

        public string Type { get; set; }

        #region MyRegion

        public const string RES_TYPE_API = "api";
        public const string RES_TYPE_VIEW = "view";

        public string RspType { get; set; } = RES_TYPE_API;


        #endregion

        public PageTableResult ToPageTableResult(int total=0)
        {
            return new PageTableResult
            {
                Total = total,
                PageSize = PageSize,
                PageNo = PageNo,
                Table = new List<object>( )
            };
        }
        public PageTableResult<T> ToPageTableTResult<T>(int total = 0)
        {
            return new PageTableResult<T>
            {
                Total = total,
                PageSize = PageSize,
                PageNo = PageNo,
                TData = null,
                Table = null,
            };
        }
    }
}