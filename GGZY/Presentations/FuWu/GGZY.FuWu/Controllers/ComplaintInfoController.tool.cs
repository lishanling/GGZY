using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdComplaintInfoController:BaseController
    {
        /// <summary>
        /// 读取COMPLAINT_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadComplaintInfos(COMPLAINT_INFO model, SearchCondition condition)
        {
            var result = Fw.ComplaintInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取COMPLAINT_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadComplaintInfo(decimal M_ID)
        
        {
            var result = Fw.ComplaintInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建COMPLAINT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateComplaintInfo(COMPLAINT_INFO model)
        {
            var result = Fw.ComplaintInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新COMPLAINT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateComplaintInfo(COMPLAINT_INFO model)
        {
            var result = Fw.ComplaintInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除COMPLAINT_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteComplaintInfo(string ids)
        {
            var result = Fw.ComplaintInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}