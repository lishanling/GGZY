using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public class StatController : BaseController
    {
        #region 工程建设统计

        /// <summary>
        /// 增加对建设工程施工招标统计月报表 A08
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="vn"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult GongChengJianShe(SearchCondition condition, string vn = "")
        {
            var r = Jd.VGongChengTongJiService.TongJi(condition);
            if (string.IsNullOrWhiteSpace(vn))
            {
                return JResult(r);
            }

            ViewBag.SearchCondition = condition;
            return View(vn, r);
        }

        [AllowAnonymous]
        public ActionResult Export(SearchCondition condition)
        {
            var r = Jd.VGongChengTongJiService.TongJi(condition);
            if (r.Success)
            {
                /*var csv = r.TData.ToCsv();
                var bytes = Encoding.Default.GetBytes(csv);
                var name = $"{condition.BeginTime:yyyyMMdd}＜={r.TData.Name}＜{condition.EndTime:yyyyMMdd}.xlsx";
                return File(bytes, name.ContentType(), name);*/
                List<Tuple<string, string>> headList = new List<Tuple<string, string>>()
                {
                    new Tuple<string, string>("GCMC","工程名称"),
                    new Tuple<string, string>("HYFL","行业类别"),
                    new Tuple<string, string>("BABM","备案部门"),
                    new Tuple<string, string>("ZJLY","资金来源"),
                    new Tuple<string, string>("ZBR","招标人"),
                    new Tuple<string, string>("ZBDLDW","招标代理单位"),
                    new Tuple<string, string>("ZBFS","招标方式"),
                    new Tuple<string, string>("PBBF","评标办法"),
                    new Tuple<string, string>("GCGM","工程规模"),
                    new Tuple<string, string>("YSJ","预算价(万元)"),
                    new Tuple<string, string>("ZBKZJ","招标控制价(万元)"),
                    new Tuple<string, string>("ZBJ","中标价(万元)"),
                    new Tuple<string, string>("YYSJBJ","与预算价比较"),
                    new Tuple<string, string>("YKZJBJ","与控制价比较"),
                    new Tuple<string, string>("DEGQ","定额工期"),
                    new Tuple<string, string>("JSGQ","建设工期"),
                    new Tuple<string, string>("GQSD","建设工期比定额工期缩短(%)"),
                    new Tuple<string, string>("KBRQ","开标日期"),
                    new Tuple<string, string>("TBDWGS","投标单位个数"),
                    new Tuple<string, string>("ZBDW","中标单位"),
                    new Tuple<string, string>("ZBDWYJ","中标单位业绩"),
                    new Tuple<string, string>("ZBDWXYF","中标单位信用分") ,
                    new Tuple<string, string>("XMFZR","项目负责人"),
                    new Tuple<string, string>("XMFZRYJ","项目负责人业绩"),
                    new Tuple<string, string>("XMJSFZR","项目技术负责人"),
                    new Tuple<string, string>("PBWYHCY","评标委员会成员"),
                    new Tuple<string, string>("BEIZHU","备注"),
                };
                string name = $"{r.TData.Name}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                string saveUrl = $"/exportExcel/{name}";
                string saveDomainUrl = ExcelHelper.ListToExcel(r.TData.List, headList, saveUrl);
                return File(saveDomainUrl, "application/vnd.ms-excel", name);
            }
            return Content($"<script>alert('{r.Msg}');</script>");
        }

        [AllowAnonymous]
        public ActionResult GCJS(string type)
        {
            return View($"GCJS_{type}");
        }

        [AllowAnonymous]
        public ActionResult TongJi(SearchCondition search)
        {
            var r = Jd.VGongChengTongJiService.DoStat(search);
            if (search.RspType == SearchCondition.RES_TYPE_API)
            {
                return JResult(r.ToPageTableResult(search));
            }
            return JResult(r, false);
        }
        [AllowAnonymous]
        public ActionResult TongJiCount(SearchCondition search)
        {
            var r = Jd.VGongChengTongJiService.DoCount(search);
            return JResult(r, false);
        }
        #endregion
    }
}