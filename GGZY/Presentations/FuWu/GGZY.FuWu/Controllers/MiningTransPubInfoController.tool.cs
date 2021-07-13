using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMiningTransPubInfoController:BaseController
    {
        /// <summary>
        /// 读取MINING_TRANS_PUB_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMiningTransPubInfos(MINING_TRANS_PUB_INFO model, SearchCondition condition)
        {
            var result = Fw.MiningTransPubInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MINING_TRANS_PUB_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMiningTransPubInfo(decimal M_ID)
        
        {
            var result = Fw.MiningTransPubInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建MINING_TRANS_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMiningTransPubInfo(MINING_TRANS_PUB_INFO model)
        {
            var result = Fw.MiningTransPubInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MINING_TRANS_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMiningTransPubInfo(MINING_TRANS_PUB_INFO model)
        {
            var result = Fw.MiningTransPubInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MINING_TRANS_PUB_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMiningTransPubInfo(string ids)
        {
            var result = Fw.MiningTransPubInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}