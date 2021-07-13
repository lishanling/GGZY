using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 数据统计类(TEXT,VALUE,COUNT)，用于统计分析
    /// </summary>
    public class DATA_STATISTICS
    {
        public string TEXT { get; set; }
        public string VALUE { get; set; }
        public int COUNT { get; set; }
        public int ORDER_ID { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public DATA_STATISTICS()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <param name="count"></param>
        /// <param name="order_id"></param>
        public DATA_STATISTICS(string text, string value, int count,int order_id=0)
        {
            TEXT = text;
            VALUE = value;
            COUNT = count;
            ORDER_ID = order_id;
        }
    }
  
}
