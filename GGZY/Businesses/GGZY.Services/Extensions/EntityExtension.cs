using Dos.ORM;
using GGZY.Services.Base;
using GGZY.Services.FuWu;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Extensions
{
    public static class EntityExtension
    {
        /// <summary>
        /// 公共资源服务-业务工厂
        /// </summary>
        private static ServicesFactoryFw Fw => ServicesFactory.GGZYFW;

        /// <summary>
        /// 公共资源监督-业务工厂
        /// </summary>
        private static ServicesFactoryJd Jd => ServicesFactory.GGZYJD;
        /// <summary>  
        ///   
        /// 将对象属性转换为key-value对  
        /// </summary>  
        /// <param name="o"></param>  
        /// <returns></returns>  
        public static Dictionary<string, object> ToDictionary(this object o)
        {
            Dictionary<string, object> map = new Dictionary<string, object>();
            Type t = o.GetType();
            PropertyInfo[] pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo p in pi)
            {
                MethodInfo mi = p.GetGetMethod();
                if (mi != null && mi.IsPublic)
                {
                    if (p.GetCustomAttribute(typeof(Newtonsoft.Json.JsonIgnoreAttribute)) != null)
                    {
                        continue;
                    }
                    if (mi.ReturnType == typeof(String))
                    {
                        string value = p.GetValue(o, null)?.ToString();
                        string name = p.Name;
                        if (string.IsNullOrEmpty(value))
                        {
                            map.Add(name, "");
                            continue;
                        }
                        map.Add(p.Name, mi.Invoke(o, new Object[] { }).ToString());
                        continue;
                    }
                    map.Add(p.Name, mi.Invoke(o, new Object[] { }));
                }
            }
            return map;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">招标文件备案</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_BIDDOC_NORMAL entity)
        {
            var dic = entity.ToDictionary();
            var dicConfigs = new Dictionary<string, string>() {
                { "DOC_PRICE_UNIT","18"},
                { "DOC_PRICE_CURRENCY","4"},
                { "MARGIN_UNIT","18"},
                { "MARGIN_CURRENCY_CODE","4"},
                { "CONTROL_UNIT","18"},
                { "CONTROL_CURRENCY_CODE","4"},
                { "PERFORM_UNIT","18"},
                { "PERFORM_CURRENCY_CODE","4"},
                { "MARGIN_PAY_TYPE","29"},
                { "QUAL_TYPE","30"},
            };
            BindDic(dic, dicConfigs);
            return dic;
        }


        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">澄清修改备案</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_CLASSIFY_NORMAL entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "DOC_PRICE_UNIT","18"},
                { "DOC_PRICE_CURRENCY","4"},
                { "MARGIN_UNIT","18"},
                { "MARGIN_CURRENCY_CODE","4"},
                { "CONTROL_UNIT","18"},
                { "CONTROL_CURRENCY_CODE","4"},
                { "PERFORM_UNIT","18"},
                { "PERFORM_CURRENCY_CODE","4"},
                { "MARGIN_PAY_TYPE","29"},
                { "QUAL_TYPE","30"},
            };
            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">异议处理结果备案</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_HANDLE_RESULT entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "COMPLAINED_TYPE","3025"},
                { "DISSENT_TYPE","3026"},
                { "DISSENT_OPINION","3027"}
            };
            BindDic(dic, dicConfigs);
            if (dic.ContainsKey("BID_SECTION_CODES")
                && (null == dic["BID_SECTION_CODES"] || dic["BID_SECTION_CODES"].ToString() == ""))
            {
                dic.Add("BID_SECTION_CODES_TEXT", "全部");
            }
            if (dic.ContainsKey("DISSENT_TYPE_TEXT")
                && (null == dic["DISSENT_TYPE_TEXT"] || dic["DISSENT_TYPE_TEXT"].ToString() == ""))
            {
                dic["DISSENT_TYPE_TEXT"] = "全部";
            }
            return dic;
        }
        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">合同备案结果</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_CONTRACT entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "BID_AMOUNT_CURRENCY","4"},
                { "BID_AMOUNT_UNIT","18"},
                { "CONTRACT_AMOUNT_CURRENCY","4"},
                { "CONTRACT_AMOUNT_UNIT","18"}
            };
            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">住建招标投标情况书面报告</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_BIDDING_WRITE entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "TENDER_PROJECT_TYPE","308"},
                {"TENDER_MODE","1000" },
                {"TENDER_ORGANIZE_FORM","21"}
            };
            BindDic(dic, dicConfigs);
            
            return dic;
        }
        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">住建招标投标情况书面报告</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_SECTION_INFO entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "WIN_BIDDER_WAY","307"}
            };
            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">合同备案结果</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_WRITTEN entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "WIN_UNIT_CREDIT_GRADE","3030"}
            };
            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">合同备案结果</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_CLASSIFY entity)
        {
            var dic = entity.ToDictionary();

            var dicConfigs = new Dictionary<string, string>() {
                { "TENDER_TYPE","3022"},
                  { "CONTROL_UNIT","18"},
                { "CONTROL_CURRENCY_CODE","4"},
                { "MARGIN_UNIT","18"},
                { "MARGIN_CURRENCY_CODE","4"},
                 { "PERFORM_UNIT","18"},
                { "PERFORM_CURRENCY_CODE","4"},
                {"EVALUATING_METHOD","3023" }
            };

            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">招标文件备案</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this GGZYJD.DbEntity.PROJECT entity)
        {
            var dic = entity.ToDictionary();
            var dicConfigs = new Dictionary<string, string>() {
                { "INDUSTRIES_TYPE","2000" }
            };
            BindDic(dic, dicConfigs);
            return dic;
        }
        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">招标文件备案</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this TENDER_PROJECT entity)
        {
            var dic = entity.ToDictionary();
            var dicConfigs = new Dictionary<string, string>() {
                { "TENDER_PROJECT_TYPE","2002"},
                {"TENDER_MODE","1000" },
                {"TENDER_ORGANIZE_FORM","21"},
                {"TENDERER_CODE_TYPE","2001"},
                {"TENDERER_ROLE","26"},
                {"TENDER_AGENCY_CODE_TYPE","2001"},
                {"TENDER_AGENCY_ROLE","26" }
            };
            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 自动关联配置字典表，并根据配置从字典表读取配置，增加 字段名_TEXT 字段信息
        /// </summary>
        /// <param name="entity">招标文件备案</param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this BD_VIOLATION_RECORD_LIST entity)
        {
            var dic = entity.ToDictionary();
            var dicConfigs = new Dictionary<string, string>() {
                { "TENDER_PROJECT_TYPE","VALUE1-63"},
                { "INDUSTRIES","69"}
            };
            BindDic(dic, dicConfigs);
            return dic;
        }

        /// <summary>
        /// 标段
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this SECTION entity)
        {
            var dic = entity.ToDictionary();
            var dicConfigs = new Dictionary<string, string>() {
                //{ "TENDER_PROJECT_CLASSIFY_CODE","5001"},
                {"CURRENCY_CODE","4" },
                {"PRICE_UNIT","18"},
                {"CONTROL_PRICE_CURRENCY","4"},
                {"CONTROL_PRICE_UNIT","18"}
            };
            BindDic(dic, dicConfigs);
            DEAL_TENDER_PROJECT_CLASSIFY(dic);
            return dic;
        }
        /// <summary>
        /// 处理标段信息返回给前端的标段包编号信息
        /// </summary>
        /// <param name="dic"></param>
        private static void DEAL_TENDER_PROJECT_CLASSIFY(Dictionary<string,object> dic)
        {
            if(! dic.ContainsKey("TENDER_PROJECT_CLASSIFY_CODE") || dic["TENDER_PROJECT_CLASSIFY_CODE"] == null)
            {
                return;
            }
            var TENDER_PROJECT_CLASSIFY_CODE = dic["TENDER_PROJECT_CLASSIFY_CODE"].ToString();

            var values = new List<string>();
            values.Add(TENDER_PROJECT_CLASSIFY_CODE);

            if(TENDER_PROJECT_CLASSIFY_CODE.Length % 2 ==1)
            {
                while(TENDER_PROJECT_CLASSIFY_CODE.Length >=2)
                {
                    TENDER_PROJECT_CLASSIFY_CODE = TENDER_PROJECT_CLASSIFY_CODE.Substring(0, TENDER_PROJECT_CLASSIFY_CODE.Length - 2);
                    values.Add(TENDER_PROJECT_CLASSIFY_CODE);
                }
            }

            
            var configs = Jd.SysDicService.FindList(SYS_DIC._.TYPE == "5001" && SYS_DIC._.VALUE.In(values)).OrderBy(od=>od.VALUE.Length).ToList();
            
            var codes = configs.Select(t => t.VALUE).ToList();
            var texts = configs.Select(t => t.TEXT).ToList();
            dic.Add("TENDER_PROJECT_CLASSIFY_CODES", codes);
            dic.Add("TENDER_PROJECT_CLASSIFY_TEXTS", texts);
        }

        /// <summary>
        /// 住建-招标文件备案信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Dictionary<string, object> ToBindDicDictionary(this RECORD_RESIDENTIAL_BIDDOC entity)
        {
            var dic = entity.ToDictionary();
            var dicConfigs = new Dictionary<string, string>() {
                 { "TENDER_TYPE","3022"},
                {"TENDER_MODE","1000" },
                {"CONTROL_PRICE_CURRENCY","4"},
                {"CONTROL_PRICE_UNIT","18"},
                { "MARGIN_UNIT","18"},
                { "MARGIN_CURRENCY_CODE","4"},
                {"PERFORM_UNIT","18" },
                { "PERFORM_CURRENCY_CODE","4"},
                { "EVALUATING_METHOD","3023"}
            };
            BindDic(dic, dicConfigs);
            return dic;
        }
        /// <summary>
        /// 关联字典表显示Text信息处理
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="dicConfigs"></param>
        /// <returns></returns>
        private static void BindDic(Dictionary<string,object> dic,Dictionary<string,string> dicConfigs)
        {
            List<string> types = new List<string>();

            foreach (KeyValuePair<string, string> item in dicConfigs)
            {
                if (!types.Contains(item.Value))
                {
                    types.Add(item.Value.Replace("VALUE1-",""));
                }
            }

            var configs = Jd.SysDicService.FindList(SYS_DIC._.TYPE.In(types));

            foreach (KeyValuePair<string, string> item in dicConfigs)
            {
                if (!dic.ContainsKey(item.Key) || dic.ContainsKey(item.Key + "_TEXT"))
                {
                    continue;
                }
                if (dic[item.Key] == null)
                {
                    dic.Add(item.Key + "_TEXT", null);
                    continue;
                }
                if(item.Value.Contains("VALUE1-"))
                {
                    if (!dic[item.Key].ToString().Contains(","))
                    {
                        var text = configs.Where(w => w.TYPE == item.Value.Replace("VALUE1-", "") && w.VALUE1 == dic[item.Key]?.ToString()).FirstOrDefault()?.TEXT;
                        dic.Add(item.Key + "_TEXT", text?.ToString());
                        continue;
                    }

                    if (true)
                    {
                        var values = dic[item.Key].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        var texts = configs.Where(w => w.TYPE == item.Value.Replace("VALUE1-", "") && values.Contains(w.VALUE1))
                            .Select(t => t.TEXT).ToList();
                        if (!texts.Any())
                        {
                            dic.Add(item.Key + "_TEXT", null);
                            continue;
                        }
                        dic.Add(item.Key + "_TEXT", String.Join(",", texts));
                    }

                }
                if (!dic[item.Key].ToString().Contains(","))
                {
                    var text = configs.Where(w => w.TYPE == item.Value && w.VALUE == dic[item.Key]?.ToString()).FirstOrDefault()?.TEXT;
                    dic.Add(item.Key + "_TEXT", text?.ToString());
                    continue;
                }
                if (true)
                {
                    var values = dic[item.Key].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var texts = configs.Where(w => w.TYPE == item.Value && values.Contains(w.VALUE))
                        .Select(t=>t.TEXT).ToList();
                    if (!texts.Any())
                    {
                        dic.Add(item.Key + "_TEXT", null);
                        continue;
                    }
                    dic.Add(item.Key + "_TEXT", String.Join(",", texts));
                }
            }
        }
    }
}
