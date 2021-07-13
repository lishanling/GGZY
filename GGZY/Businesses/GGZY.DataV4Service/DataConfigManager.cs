using System;
using System.Collections.Generic;
using System.Linq;

namespace GGZY.DataV4Service
{
    public class DataConfigManager
    {
        public static List<string> GetDataTypeList()
        {
            var list = _dataTypeNameDict.Select(e => e.Key).ToList();
            return list;
        }

        public static List<string> GetDataNameList(string dataType)
        {
            if (_dataTypeNameDict.ContainsKey(dataType))
            {
                var t = _dataTypeNameDict[dataType];
                var list = new List<string>();
                for (var i = t.Item1; i <= t.Item2; i++)
                {
                    list.Add(i.ToString());
                }
                return list;
            }
            return new List<string>();
        }

        private static Dictionary<string, Tuple<int,int>> _dataTypeNameDict =
            new Dictionary<string, Tuple<int, int>>
            {
                {"工程建设",new Tuple<int,int>(500,523)},
                {"工程建设(住建)",new Tuple<int,int>(800,827)},
                {"工程建设(水利)",new Tuple<int,int>(830,858)},
                {"工程建设(交通)",new Tuple<int,int>(860,909)},
                {"政府采购",new Tuple<int,int>(550,557)},
                {"土地使用权",new Tuple<int,int>(600,601)},
                {"矿业权出让",new Tuple<int,int>(650,660)},
                {"国有产权交易(实物资产类)",new Tuple<int,int>(700,701)},
                {"国有产权交易(股权类)",new Tuple<int,int>(750,753)},
                {"碳排放交易",new Tuple<int,int>(1000,1001)},
                {"排污权交易",new Tuple<int,int>(1050,1052)},
                {"药品采购数据集",new Tuple<int,int>(1104,1121)},
                {"主体数据类",new Tuple<int,int>(100,119)},
                {"专家数据类",new Tuple<int,int>(208,213)},
                {"信用数据类",new Tuple<int,int>(300,306)},
                {"监管数据类",new Tuple<int,int>(400,404)},
                {"其它交易类型",new Tuple<int,int>(1800,1801)}

            };
    }
}