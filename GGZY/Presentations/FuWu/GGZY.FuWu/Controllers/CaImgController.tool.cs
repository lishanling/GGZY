using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCaImgController:BaseController
    {
        /// <summary>
        /// 读取CA_IMG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCaImgs(CA_IMG model, SearchCondition condition)
        {
            var result = Fw.CaImgService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取CA_IMG明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCaImg(decimal ID)
        
        {
            var result = Fw.CaImgService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建CA_IMG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCaImg(CA_IMG model)
        {
            var result = Fw.CaImgService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新CA_IMG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCaImg(CA_IMG model)
        {
            var result = Fw.CaImgService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除CA_IMG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCaImg(string ids)
        {
            var result = Fw.CaImgService.Delete(ids);
            return JResult(result); 
        }
    }
}