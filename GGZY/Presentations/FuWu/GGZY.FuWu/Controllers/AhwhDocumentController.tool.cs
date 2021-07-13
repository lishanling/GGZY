using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAhwhDocumentController:BaseController
    {
        /// <summary>
        /// 读取AHWH_DOCUMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAhwhDocuments(AHWH_DOCUMENT model, SearchCondition condition)
        {
            var result = Fw.AhwhDocumentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AHWH_DOCUMENT明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAhwhDocument(decimal ID)
        
        {
            var result = Fw.AhwhDocumentService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AHWH_DOCUMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAhwhDocument(AHWH_DOCUMENT model)
        {
            var result = Fw.AhwhDocumentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AHWH_DOCUMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAhwhDocument(AHWH_DOCUMENT model)
        {
            var result = Fw.AhwhDocumentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AHWH_DOCUMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAhwhDocument(string ids)
        {
            var result = Fw.AhwhDocumentService.Delete(ids);
            return JResult(result); 
        }
    }
}