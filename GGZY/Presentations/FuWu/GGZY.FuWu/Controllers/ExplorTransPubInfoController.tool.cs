using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExplorTransPubInfoController:BaseController
    {
        /// <summary>
        /// 读取EXPLOR_TRANS_PUB_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExplorTransPubInfos(EXPLOR_TRANS_PUB_INFO model, SearchCondition condition)
        {
            var result = Fw.ExplorTransPubInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXPLOR_TRANS_PUB_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExplorTransPubInfo(decimal M_ID)
        
        {
            var result = Fw.ExplorTransPubInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXPLOR_TRANS_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExplorTransPubInfo(EXPLOR_TRANS_PUB_INFO model)
        {
            var result = Fw.ExplorTransPubInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXPLOR_TRANS_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExplorTransPubInfo(EXPLOR_TRANS_PUB_INFO model)
        {
            var result = Fw.ExplorTransPubInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXPLOR_TRANS_PUB_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExplorTransPubInfo(string ids)
        {
            var result = Fw.ExplorTransPubInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}