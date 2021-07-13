using System;
using System.Data;
using Dos.ORM;
using Newtonsoft.Json.Linq;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_XMCODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_XMCODE
    {
        public DateTime? APPLY_DATE => MODIFYTIME;
        public string Type => "XMCODE";
        public string TOTAL_MONEY
        {
            get
            {
                var money = string.Empty;
                if (!string.IsNullOrWhiteSpace(JSON))
                {
                    //TODO 
                }
                return money;
            }
        }
    }
}