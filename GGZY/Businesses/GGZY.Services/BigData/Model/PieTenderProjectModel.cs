using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.BigData.Model
{
    /// <summary>
    /// 监察情况分析底下的四个饼图数据读取数据出来后转换的实体类
    /// </summary>
    public class PieTenderProjectModel
    {
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 招标方式
        /// </summary>
        public string TENDER_MODE { get; set; }
        /// <summary>
        /// 标段包分类
        /// </summary>
        public string TENDER_CLASS { get; set; }
        /// <summary>
        /// 招标组织形式
        /// </summary>
        public string TENDER_ORGANIZE_FORM { get; set; }
        /// <summary>
        /// 预审公告的数量，有预审公告说明是资格预设否则资格后审
        /// </summary>
        public int YSCOUNT { get; set; }
    }
}
