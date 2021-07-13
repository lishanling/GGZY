using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdNonOilGasMiningRegAnnController:BaseController
    {
        /// <summary>
        /// 读取NON_OIL_GAS_MINING_REG_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadNonOilGasMiningRegAnns(NON_OIL_GAS_MINING_REG_ANN model, SearchCondition condition)
        {
            var result = Fw.NonOilGasMiningRegAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取NON_OIL_GAS_MINING_REG_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadNonOilGasMiningRegAnn(decimal M_ID)
        
        {
            var result = Fw.NonOilGasMiningRegAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建NON_OIL_GAS_MINING_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateNonOilGasMiningRegAnn(NON_OIL_GAS_MINING_REG_ANN model)
        {
            var result = Fw.NonOilGasMiningRegAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新NON_OIL_GAS_MINING_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateNonOilGasMiningRegAnn(NON_OIL_GAS_MINING_REG_ANN model)
        {
            var result = Fw.NonOilGasMiningRegAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除NON_OIL_GAS_MINING_REG_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteNonOilGasMiningRegAnn(string ids)
        {
            var result = Fw.NonOilGasMiningRegAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}