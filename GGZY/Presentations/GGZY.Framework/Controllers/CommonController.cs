
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Linq;
using GGZY.Core.Models;
using GGZYFW.DbEntity;
using Microsoft.CSharp;
using Dos.ORM;
using System.Web.UI;
using GGZY.Framework.Models;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [AllowAnonymous, PortalUnFilter]
    public class CommonController : BaseController
    {
        /// <summary>
        /// 获取交易平台列表
        /// </summary>
        /// <returns></returns>
        public ActionResult TradePlatforms()
        {
            var r = Fw.TUserTradeplatformService.TradePlatforms();
            return JResult(r);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="vIdx"></param>
        /// <returns></returns>
        public ActionResult SysDic(string type, int vIdx = 0,int? pid=null)
        {
            if (!string.IsNullOrWhiteSpace(type))
            {

                #region 监督平台通用字典

                if (type.IndexOf("jdsysdic", StringComparison.CurrentCultureIgnoreCase) > -1)
                {
                    var sysType = Regex.Replace(type, "jdsysdic", "", RegexOptions.IgnoreCase);

                    #region FindDictionaryTextValue 1 2 3 4 5 

                   var r = Jd.SysDicService.FindDictionaryTextValue(sysType,pid,vIdx);

                    #endregion

                    return JResult(r);
                }
                if (type.IndexOf("fwsysdic", StringComparison.CurrentCultureIgnoreCase) > -1)
                {
                    var sysType = Regex.Replace(type, "fwsysdic", "", RegexOptions.IgnoreCase);
                    

                    #region FindDictionaryTextValue 1 2 3 4 5 

                   var r = Fw.SysDicService.FindDictionaryTextValue(sysType, pid, vIdx);

                    #endregion

                    return JResult(r);
                }

                #endregion

                #region 统一用户App

                if (string.Compare("fwunifyapp", type, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    return JResult(Fw.UnifyAppService.AppDic());
                }

                #endregion

                #region 获取监督部门数据

                if (string.Compare("jiandubumen", type, StringComparison.CurrentCultureIgnoreCase) == 0)//获取监督部门数据
                {
                    return JResult(Jd.TRecordRegulatorService.FindJianDuDepartment());
                }

                #endregion

                switch (type)
                {
                    case "fujian_region":
                        return JResult(new List<object>
                        {
                            new LabelValueModel{
                                Value="350000",
                                Label= "省本级"
                            },
                            new LabelValueModel{
                                Value="350100",
                                Label= "福州市"
                            },
                            new LabelValueModel{
                                Value="350128",
                                Label= "平潭综合实验区"
                            },
                            new LabelValueModel{
                                Value="350200",
                                Label= "厦门市"
                            },
                            new LabelValueModel{
                                Value="350300",
                                Label= "莆田市"
                            },
                            new LabelValueModel{
                                Value="350400",
                                Label= "三明市"
                            },
                            new LabelValueModel{
                                Value="350500",
                                Label= "泉州市"
                            },
                            new LabelValueModel{
                                Value="350600",
                                Label= "漳州市"
                            },
                            new LabelValueModel{
                                Value="350700",
                                Label= "南平市"
                            },
                            new LabelValueModel{
                                Value="350800",
                                Label= "龙岩市"
                            },
                            new LabelValueModel{
                                Value="350900",
                                Label= "宁德市"
                            }
                        });
                    
                }
            }
            throw new Exception("参数错误");
        }

        /// <summary>
        /// 返回字典配置树形结构信息
        /// </summary>
        /// <param name="type"></param>
        /// <param name="rootvalue">要筛选的根节点对应value</param>
        /// <returns></returns>
        public ActionResult SysDicTree(string type, string rootvalue = "")
        {
            if (String.IsNullOrEmpty(type))
            {
                throw new Exception("参数错误");
            }
            var sysType = Regex.Replace(type, "jdsysdic", "", RegexOptions.IgnoreCase);
            var condition = new WhereClipBuilder();
            condition.And(SYS_DIC._.TYPE == sysType);
            if (!String.IsNullOrWhiteSpace(rootvalue))
            {
                condition.And(SYS_DIC._.VALUE.BeginWith(rootvalue));
            }
            var datas = Jd.SysDicService.FindList<SYS_DIC>(condition.ToWhereClip());
            var minLength = datas.Select(t => t.VALUE.Length).Min();
            var roots = datas.Where(w => w.VALUE.Length == minLength)
                .OrderBy(od => od.VALUE)
                .Select(t => new Dictionary<string, object>{
                    { "id" ,t.ID },
                    { "label" , t.TEXT },
                    { "value" , t.VALUE },
                    { "children" , new List<Dictionary<string, object>>()} })
                .ToList();
            roots.ForEach(e => GetChildSysDic(e, datas));

            GeneralResult r = new GeneralResult();
            r.SetSuccess(roots);
            return JResult(r);
        }

        protected void GetChildSysDic(Dictionary<string, object> dic, List<SYS_DIC> sources)
        {
            var data = sources.Where(w => w.PID == Convert.ToInt32(dic["id"]))
                .OrderBy(od => od.VALUE).ToList();
            if (data.Any())
            {
                var child = data.Select(t =>
                new Dictionary<string, object>{
                    { "id" ,t.ID },
                    { "label" , t.TEXT },
                    { "value" , t.VALUE },
                    { "children" , new List<Dictionary<string, object>>() }}).ToList();
                child.ToList().ForEach(e =>
                {
                    GetChildSysDic(e, sources.Where(w => w.VALUE.Contains(dic["value"].ToString())).ToList());
                });
                dic["children"] = child;
            }
        }

        /// <summary>
        /// 项目报建（招标计划）-工程类别 TYPE63
        /// </summary>
        /// <param name="kind">1 2 3 4 5 6 7</param>
        /// <returns></returns>
        public ActionResult JdAfcProjectType(string kind)
        {
            return JResult(Jd.SysDicService.FindDictionaryTextByValue2("63", kind));
        }
        /// <summary>
        /// 根据类型和value1获取字典内容
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value1"></param>
        /// <returns></returns>
        public ActionResult GetDicByType(string type, string value1)
        {
            return JResult(Jd.SysDicService.FindDictionaryTextValue1(type, value1));
        }
        /// <summary>
        /// 项目报建（招标计划）-工程用途 TYPE78
        /// </summary>
        /// <param name="projectType"></param>
        /// <returns></returns>
        public ActionResult JdAfcProjectPurpose(string projectType)
        {
            return JResult(Jd.SysDicService.FindDictionaryTextByValue2("78", projectType));
        }
        /// <summary>
        /// 获取监督平台多个类型配置
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ActionResult SysDics(string type)
        {
            if (String.IsNullOrEmpty(type))
            {
                throw new Exception("参数错误");
            }
            var types = type.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries).ToList().Distinct();
            List<string> typeList = new List<string>();
            foreach (var t in types)
            {
                if (t.IndexOf("jdsysdic", StringComparison.CurrentCultureIgnoreCase) == -1)
                {
                    return FResult("类型参数必须归属同一平台", true);
                }
                var sysType = Regex.Replace(t, "jdsysdic", "", RegexOptions.IgnoreCase);
                typeList.Add(sysType);
            }
            return JResult(Jd.SysDicService.FindDictionaryTextValueList(typeList));
        }

        /// <summary>
        /// 工程建设
        /// </summary>
        /// <returns></returns>
        public ActionResult EnginCtor()
        {
            var r = Jd.SysDicService.EngineeringConstruction();
            return JResult(r);
        }

        /// <summary>
        /// 项目备案
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectRecord()
        {
            var r = Jd.SysDicService.ProjectRecord();
            return JResult(r);
        }
        /// <summary>
        /// 报建用户审核环节
        /// 红圈处-状态不对
        /// （1）补录不需要审核，状态里不会有补录这项（补录功能参见原型中的功能说明）
        /// （2）变更申请 和 报建变更，流程上已经合并了，现在只有报建变更，
        /// （可参见图二红字说明），具体逻辑参见原型
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterUserApprovalTache()
        {
            var r = Jd.SysDicService.FindDictionaryTextValue("66");
            r.RemoveAll(c => c.Label == "变更申请" || c.Value == "2");
            r.RemoveAll(c => c.Label == "补录" || c.Value == "4");
            return JResult(r);
        }
    }
}