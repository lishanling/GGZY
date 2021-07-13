using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Portal.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        [PortalUnFilter]
        public ActionResult Index()
        {
            var portal = ConfigHelper.AppSettings.Portal;
            var path = Server.MapPath(portal);
            if (System.IO.File.Exists(path))
            {
                return Redirect(portal);
            }
            return Content("");
        }
        /// <summary>
        /// 获取附件
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        public ActionResult GetFile(string fid)
        {

            var d = fid.ToNullableDecimal();
            string file = "FILE_NOT_FUNND";
            if (d.HasValue)
            {
                var fileRsp = Fw.SysAttachmentService.ViewByPk(d);
                if (fileRsp.Success)
                {
                    var attachment = fileRsp.Data as SYS_ATTACHMENT;
                    file = Server.MapPath($"~/{attachment?.FILEPATH}");
                }
            }
            else if (fid.StartsWith("ATT") && Cache.IsSet(fid))
            {
                var attachments = Cache.Get<List<T_ATTACHMENT>>(fid);
                file = Server.MapPath($"~/file/{attachments.FirstOrDefault()?.ATTACHMENT_FILE_NAME}");
            }
            else
            {
                return Redirect("http://114.115.162.77:8066/file/getcontent/5e71c880faae1535cc7ca28f.jpg");
            }
            return File(file, file.ContentType());
        }
        /// <summary>
        /// 相关链接
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Link(PT_LINK model)
        {
            var list = Fw.PtLinkService.Link(model);
            return JResult(list);
        }

        public ActionResult BottomRender()
        {
            return JResult("");
        }
        /// <summary>
        /// 关键字检索
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Search(SearchCondition search)
        {
            if (string.IsNullOrWhiteSpace(search.KeyWord))
            {
                return FResult("请输入关键字");
            }
            var r = Fw.CommonService.KeywordSearch(search);
            return JResult(r);
        }
        /// <summary>
        /// 交易平台接入 福建今日公告数量
        /// </summary>
        /// <returns></returns>
        public ActionResult NoticeCount(string areaCode)
        {
            var r = Fw.CommonService.NoticeCount(areaCode);
            return JResult(r);
        }
        /// <summary>
        /// 交易平台接入 福建交易平台列表
        /// </summary>
        /// <returns></returns>
        public ActionResult TradePlatformAccessList(T_JYPT_ACCESS model, SearchCondition condition)
        {
            var r = Fw.TJyptAccessService.TradePlatformAccessList(model, condition);
            return JResult(r);
        }

    }
}