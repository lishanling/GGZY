using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMiningDistrivtRangePubController:BaseController
    {
        /// <summary>
        /// 读取MINING_DISTRIVT_RANGE_PUB列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMiningDistrivtRangePubs(MINING_DISTRIVT_RANGE_PUB model, SearchCondition condition)
        {
            var result = Fw.MiningDistrivtRangePubService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MINING_DISTRIVT_RANGE_PUB明细
        /// </summary>
      /// <param name="NA_APP_NAME">项目名称</param>
      /// <param name="NA_APPLY_PERSON">申请人</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMiningDistrivtRangePub(string NA_APP_NAME,string NA_APPLY_PERSON)
        
        {
            var result = Fw.MiningDistrivtRangePubService.ViewByPk(NA_APP_NAME,NA_APPLY_PERSON);
            return JResult(result);
        }
        /// <summary>
        /// 创建MINING_DISTRIVT_RANGE_PUB信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMiningDistrivtRangePub(MINING_DISTRIVT_RANGE_PUB model)
        {
            var result = Fw.MiningDistrivtRangePubService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MINING_DISTRIVT_RANGE_PUB信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMiningDistrivtRangePub(MINING_DISTRIVT_RANGE_PUB model)
        {
            var result = Fw.MiningDistrivtRangePubService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MINING_DISTRIVT_RANGE_PUB信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMiningDistrivtRangePub(string ids)
        {
            var result = Fw.MiningDistrivtRangePubService.Delete(ids);
            return JResult(result); 
        }
    }
}