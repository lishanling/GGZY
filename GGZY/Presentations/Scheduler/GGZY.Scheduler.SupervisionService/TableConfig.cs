using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.SupervisionService
{
    public class TableConfig
    {
        public string TableName { get; set; }

        public string TableField { get; set; }

        public DateTime? Check_Time { get; set; }
    }
}
