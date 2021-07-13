using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTMultimediaDataController
    {
        public ActionResult GetList(string fwTenderProjectCode)
        {
            return JResult(Jd.TMultimediaDataService.GetList(fwTenderProjectCode));
        }

        public ActionResult GetUrlParam(string id)
        {
            return JResult(Jd.TMultimediaDataService.GetUrlParam(id));
        }

        /// <summary>
        /// 监督服务·现场视频监督·电子评标视频
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetVideoList(MvTjAllCreateXzjdModel model, SearchCondition search)
        {
            var r = Jd.TMultimediaDataService.GetVideoList(model, search);
            return JResult(r);
        }
    }
}