using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStStbprpBController:BaseController
    {
        /// <summary>
        /// 读取ST_STBPRP_B列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStStbprpBs(ST_STBPRP_B model, SearchCondition condition)
        {
            var result = Fw.StStbprpBService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ST_STBPRP_B明细
        /// </summary>
      /// <param name="STCD"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStStbprpB(string STCD)
        
        {
            var result = Fw.StStbprpBService.ViewByPk(STCD);
            return JResult(result);
        }
        /// <summary>
        /// 创建ST_STBPRP_B信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStStbprpB(ST_STBPRP_B model)
        {
            var result = Fw.StStbprpBService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ST_STBPRP_B信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStStbprpB(ST_STBPRP_B model)
        {
            var result = Fw.StStbprpBService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ST_STBPRP_B信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStStbprpB(string ids)
        {
            var result = Fw.StStbprpBService.Delete(ids);
            return JResult(result); 
        }
    }
}