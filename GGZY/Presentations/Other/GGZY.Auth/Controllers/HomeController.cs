using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Log;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Helper;

namespace GGZY.Auth.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var portal = ConfigHelper.AppSettings.Admin;
            var path = Server.MapPath(portal);
            if (System.IO.File.Exists(path))
            {
                return Redirect(portal);
            }
            return Content("");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LogTaskAsync()
        {
            Task.Run(() =>
            {
                var url = "http://114.115.162.77:8060/api/logs";
                var postString = "{a:1:1}ystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                //log.Debug("提交数据开始,请求id:"+ requestid + ",url:" + url + ",data:" + postString);
                byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式 
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    webClient.Headers.Add("Content-Type", "application/json");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  

                    webClient.UploadDataTaskAsync(url, "POST", postData).ContinueWith(task =>
                    {
                        var result = Encoding.UTF8.GetString(task.Result); //解码 
                        Logger.Debug($"LogTaskAsync {result}");
                    });
                }
            },CancellationToken.None);
            var c = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Logger.Debug($"LogTaskAsync {c}");
            return Content(c);
        }

        public ActionResult LogAsync()
        {
            Task.Run(() =>
            {
                var url = "http://114.115.162.77:8060/api/logs";
                var postString = "{a:1:1}ystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aystem.Runtime.InteropServices.RuntimeInformation, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                //log.Debug("提交数据开始,请求id:"+ requestid + ",url:" + url + ",data:" + postString);
                byte[] postData = Encoding.UTF8.GetBytes(postString); //编码，尤其是汉字，事先要看下抓取网页的编码方式  
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    webClient.Headers.Add("Content-Type",
                        "application/json"); //采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                    webClient.UploadDataCompleted += (o, e) =>
                    {
                        var result = Encoding.UTF8.GetString(e.Result); //解码 
                        Logger.Debug($"LogAsync {result}");
                    };

                    webClient.UploadDataAsync(new Uri(url), "POST", postData);
                }
            });
            var c = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Logger.Debug($"LogAsync {c}");
            return Content(c);
        }

        
    }
}