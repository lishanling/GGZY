using System;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdPtComplainController
    {
        /// <summary>
        /// 投诉信息发布列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ComplaintPageList(PtComplainModel model, SearchCondition search)
        {
            var r = Jd.PtComplainService.PageList(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Detail(decimal? ID)
        {
            var r = Jd.PtComplainService.Detail(ID,(type,id)=> CommonAttachmentBuilder(id,"Jd", fType: type));
            return JResult(r);
        }


        /// <summary>
        /// 新增|编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Save(PtComplainModel model)
        {
            model.CONTENTS = HttpUtility.HtmlDecode(model.CONTENTS);
            var r =model.ID.HasValue&&model.ID>0?
                Jd.PtComplainService.Edit(model):
                Jd.PtComplainService.Add(model);
            return JResult(r);
        } 
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(decimal id)
        {
            var r = Jd.PtComplainService.DeleteComplaint(id);
            return JResult(r);
        }
    }
}