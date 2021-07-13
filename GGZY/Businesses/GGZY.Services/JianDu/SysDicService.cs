using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysDicService 
    {
        /// <summary>
        /// 根据Type类型以及对应的Value值，返回Text信息
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FindTextValue(string type,string value)
        {
            var dic = FindDicByType(type).FirstOrDefault(w => w.VALUE == value);
            if(null == dic)
            {
                return "";
            }
            return dic.VALUE;
        }

        #region FindDictionaryTextValue 1 2 3 4 5 

        /// <summary>
        /// 按照TYPE
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pid"></param>
        /// <param name="vIndex"></param>
        /// <returns></returns>
        public List<LabelValueModel> FindDictionaryTextValue(string type, int? pid = null, int vIndex = 0)
        {
            if("3021".Equals(type))
            {
                var rtype = JdUser?.UserDepartment?.JGBM;
                if(String.IsNullOrEmpty(rtype))
                {
                    rtype = "MS";
                }
                var dicList = FindDicByType(type).Where(w => w.VALUE1 == rtype).OrderBy(od=>od.ORDER_ID).ToList()
                    .Select(c => new LabelValueModel
                    {
                        Id = c.ID?.ToString(),
                        Label = c.TEXT,
                        Value = c.VALUE
                    }).ToList();
                return dicList;
            }
            var dics = FindDicByType(type,pid).Select(c => new LabelValueModel
            {
                Id=c.ID?.ToString(),
                Label = c.TEXT,
                Value = vIndex == 1 ? c.VALUE1 : vIndex == 2 ? c.VALUE2 : vIndex == 3 ? c.VALUE3 : vIndex == 4 ? c.VALUE4 : vIndex == 5 ? c.VALUE5 : c.VALUE,
            }).ToList();
            return dics;
        }
        #endregion

        /// <summary>
        /// 信用分公示根据招标类型选择下拉框备案环节的内容
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value1"></param>
        /// <returns></returns>
        public List<LabelValueModel> FindDictionaryTextValue1(string type, string value1)
        {
            var dics = FindDicByType(type).FindAll(c => c.VALUE1 == value1).Select(c => new LabelValueModel
            {
                Id = c.VALUE1,
                Label = c.TEXT,
                Value = c.VALUE
            }).ToList();
            return dics;
        }
        /// <summary>
        /// 项目报建（招标计划） 
        /// </summary>
        /// <param name="type">工程类别 TYPE63 工程用途 TYPE78</param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public List<LabelValueModel> FindDictionaryTextByValue2(string type,string value2)
        {
            var dics = FindDicByType(type).FindAll(c=>c.VALUE2==value2).Select(c => new LabelValueModel
            {
                Id = c.VALUE2,
                Label = c.TEXT,
                Value = c.VALUE
            }).ToList();
            return dics;
        }

        /// <summary>
        /// 按照TYPE
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<SYS_DIC> FindDicByType(string type, int? pid = null)
        {
            var dics = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:SYS_DIC:TYPE_{type}",
                () =>
                {
                    var sysDics = FindList(SYS_DIC._.TYPE == type ).ToList();
                    return sysDics;
                }).OrderBy(od=>od.ORDER_ID).ThenBy(od=>od.VALUE).ToList();
            if (pid.HasValue)
            {
                dics = dics.FindAll(c => c.PID == pid);
            }
            return dics;
        }

        /// <summary>
        /// 按照TYPE
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Dictionary<string, IEnumerable<dynamic>> FindDictionaryTextValueList(List<string> types)
        {
            Dictionary<string, IEnumerable<dynamic>> dic = new Dictionary<string,IEnumerable<dynamic>>();
            foreach (var type in types)
            {
                dic.Add("JDSYSDIC"+type, FindDictionaryTextValue(type).Select(t=>new { label =t.Label,value =t.Value}));
            }
            return dic;
        }
        /// <summary>
        /// 根据招标项目编号获取备案类型列表（招标文件备案、澄清修改备案、异议处理结果备案、招标投标情况书面备案等）
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目编号</param>
        /// <returns></returns>
        public IEnumerable<dynamic> GetRecordReviewTypeList(string TENDER_PROJECT_CODE)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendLine("select dv.value,dv.text,dv.order_id,NVL(v.count,0) as Count ");
            sbSql.AppendLine(" from( ");
            sbSql.AppendLine(" select d.value,d.text,d.value1,min(d.order_id) as order_id from sys_dic d ");
            sbSql.AppendLine(" inner join TENDER_PROJECT tp on d.value1 =nvl(tp.rtype,'MC') ");
            sbSql.AppendLine(" where d.type='3021'and tp.tender_project_code='"+ TENDER_PROJECT_CODE + "' group by d.value,d.text,d.value1 ");
            sbSql.AppendLine(" ) dv ");
            sbSql.AppendLine(" left join ");
            sbSql.AppendLine(" (select t.TENDER_PROJECT_CODE, r.REVIEW_TYPE,nvl(t.rtype,'MC') as RTYPE, ");
            sbSql.AppendLine(" count(1) as count ");
            sbSql.AppendLine(" from TENDER_PROJECT  t ");
            sbSql.AppendLine(" inner join RECORD_REVIEW r on (t.TENDER_PROJECT_CODE = r.TENDER_PROJECT_CODE and r.tender_project_code='"+ TENDER_PROJECT_CODE + "' )");
            sbSql.AppendLine(" group by t.TENDER_PROJECT_CODE,r.REVIEW_TYPE,t.rtype) v ");
            sbSql.AppendLine(" on dv.VALUE1 = v.RTYPE AND dv.value = v.review_type ");
            sbSql.AppendLine(" order by order_id ");

            var data = FromSql(sbSql.ToString()).ToList<DATA_STATISTICS>();
            var sumEntity = new DATA_STATISTICS("所有","",data.Sum(s=>s.COUNT));
            data.Insert(0, sumEntity);
            return data.Select(t=>new { 
                label = t.TEXT,
                value = t.VALUE,
                count = t.COUNT,
                ENABLE_ADD = t.TEXT == "所有"?false:(Jd.RecordReviewService.CheckIsSingleByReviewType(TENDER_PROJECT_CODE, t.VALUE,null) as GeneralResult).Success
            });
        }

        #region 工程领域大数据

        /// <summary>
        /// 工程建设分类
        /// 按照当前账号组织机构配置的行业类型获取可查看行业列表
        /// </summary>
        /// <returns></returns>
        public List<SelectModel> EngineeringConstruction()
        {
            var l = new List<SelectModel>();
            var hyTypeList = JdUser?.UserDepartment?.HY_TYPE_LIST;
            if (hyTypeList != null && hyTypeList.Any())
            {
                var type69 = FindDictionaryTextValue("69").FindAll(c=>hyTypeList.Contains(c.Value));
                var type63 = FindDicByType("63");
                foreach (var t69 in type69)
                {
                    var children = type63.FindAll(c => c.VALUE2 == t69.Value).Select(c =>
                    {
                        var values =new List<string> { c.VALUE3, c.VALUE3.Replace("A", "G") };
                       
                        if (values.Any(v=>v.Contains("99-1")))
                        {
                            values.Add("A99");
                            values.Add("G99");
                        }
                        if (values.Any(v => v.Contains("03-")))
                        {
                            values.Add("A03");
                            values.Add("G03");
                        }
                        var m = new SelectModel
                        {
                            Label = c.TEXT,
                            Value = string.Join(",",values),
                            Children = null,
                        };
                        return m;


                    }).ToList();
                    var type69Value = string.Join(",", children.Select(c => c.Value));
                    l.Add(new SelectModel
                    {
                        Label = t69.Label,
                        Value = type69Value,
                        Children = children
                    });
                }
            }
            return l;
        }

        #endregion
        /// <summary>
        /// 项目备案
        /// </summary>
        /// <returns></returns>
        public List<SelectModel> ProjectRecord()
        {
            var l = new List<SelectModel>();
            var type65 = FindDictionaryTextValue("65");
            var type3021 = FindDicByType("3021");
            foreach (var t69 in type65)
            {
                var children = type3021.FindAll(c => c.VALUE1 == t69.Value).Select(c => new SelectModel
                {
                    Label = c.TEXT,
                    Value = c.VALUE,
                    Children = null,
                }).ToList();
                l.Add(new SelectModel
                {
                    Label = t69.Label,
                    Value = t69.Value,
                    Children = children
                });
            }
            return l;
        }

        public List<SelectModel> JdPortalProjectTypeTree()
        {
            var result =new List<SelectModel>();
            var p = FindList(SYS_DIC._.TYPE == "20200830", SYS_DIC._.ORDER_ID.Asc);
            var pids = p.Select(pi => pi.ID).ToList();
            var dic = FindList(SYS_DIC._.PID.In(pids),SYS_DIC._.ORDER_ID.Asc);
            var cids = dic.Select(g => g.ID).ToList();
            var children = FindList(SYS_DIC._.PID.In(cids), SYS_DIC._.ORDER_ID.Asc);
            foreach (var pi in p)
            {

                var piTree = new SelectModel(pi.VALUE, pi.TEXT);
                var sub = dic.FindAll(c => c.PID == pi.ID);
                foreach (var ci in sub)
                {
                    var subTree = new SelectModel(ci.VALUE, ci.TEXT)
                    {
                        Children = children.FindAll(o => o.PID == ci.ID).Select(c=>new SelectModel
                        {
                            Label=c.TEXT,Value=c.VALUE,Children = null
                        }).ToList()
                    };
                    piTree.Children.Add(subTree);
                }
            }
            return result;
        }
        /// <summary>
        /// 字典二级菜单
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<SelectModel> GetSysDicTree2(string type)
        {
            var result = new List<SelectModel>();
            var p = FindList(SYS_DIC._.TYPE == type, SYS_DIC._.ORDER_ID.Asc);
            var pids = p.FindAll(c => !c.PID.HasValue);
           
            foreach (var pi in pids)
            {
                var piTree = new SelectModel(pi.VALUE, pi.TEXT)
                {
                    Children = p.FindAll(o => o.PID == pi.ID).Select(c => new SelectModel
                    {
                        Label = c.TEXT,
                        Value = c.VALUE,
                        Children = null
                    }).ToList()
                };
                result.Add(piTree);
            }
            return result;
        }

        public List<SelectModel> GetJGBMZtree()
        {
            var result = new List<SelectModel>();
            var p = FindList(SYS_DIC._.TYPE == "65", SYS_DIC._.ORDER_ID.Asc);
            var pids = p.FindAll(c => string.IsNullOrWhiteSpace(c.VALUE1));

            foreach (var pi in pids)
            {
                var children = p.FindAll(o => o.VALUE1 == pi.VALUE).Select(c => new SelectModel
                {
                    Label = c.TEXT,
                    Value = c.VALUE,
                    Children = null
                }).ToList();
                var piTree = new SelectModel(pi.VALUE, pi.TEXT)
                {
                    Children = children.Any()?children:null
                };
                result.Add(piTree);
            }
            return result;
        }
    }
}