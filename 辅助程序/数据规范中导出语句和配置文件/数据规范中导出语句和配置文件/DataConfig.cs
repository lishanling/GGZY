using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace 数据规范中导出语句和配置文件
{
    public class DataConfig
    {
        public string DataNo { get; set; }
        public string DataName { get; set; }
        public string DataCnName { get; set; }

        public bool IsZXSJ { get; set; }
        public string GgfwDataNo { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class Field
    {
        public string Name { get; set; }
        public string CnName { get; set; }
        public List<Dictionary<string, object>> Validators { get; set; }
    }
}
