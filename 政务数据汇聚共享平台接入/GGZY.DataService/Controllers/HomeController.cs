using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
namespace GGZY.DataService.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<a href='/ConvergenceService/PublicSecurityDepartment'>户籍人口统计</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/EnterpInfo'>根据企业全称查询法人姓名和身份证号码（编号：I040104）</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/queryByEnterp'>根据企业全称查询企业基本信息</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/IDCheck'>验证身份证号码和姓名是否匹配（编号：I010101）</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/queryByOrgan'>根据社会组织全称查询社会组织信息  编号：I030201</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/queryByMc'>根据单位全称查询事业单位基本信息（编号：I080102）</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/queryPayByOrganMonth'>根据单位全称、缴交月份查询员工养老保险缴交信息</a><br/>");
            sb.AppendLine("<a href='/ConvergenceService/queryPayByIDMonth'>根据身份证号码、缴交月份查询个人养老保险缴交信息（编号：I020102）</a><br/>");
            return Content(sb.ToString());
        }

       
    }
}