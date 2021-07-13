using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMiningDistrictRangePubController:BaseController
    {
        /// <summary>
        /// 读取MINING_DISTRICT_RANGE_PUB列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMiningDistrictRangePubs(MINING_DISTRICT_RANGE_PUB model, SearchCondition condition)
        {
            var result = Fw.MiningDistrictRangePubService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MINING_DISTRICT_RANGE_PUB明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMiningDistrictRangePub(decimal M_ID)
        
        {
            var result = Fw.MiningDistrictRangePubService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建MINING_DISTRICT_RANGE_PUB信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMiningDistrictRangePub(MINING_DISTRICT_RANGE_PUB model)
        {
            var result = Fw.MiningDistrictRangePubService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MINING_DISTRICT_RANGE_PUB信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMiningDistrictRangePub(MINING_DISTRICT_RANGE_PUB model)
        {
            var result = Fw.MiningDistrictRangePubService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MINING_DISTRICT_RANGE_PUB信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMiningDistrictRangePub(string ids)
        {
            var result = Fw.MiningDistrictRangePubService.Delete(ids);
            return JResult(result); 
        }
    }
}