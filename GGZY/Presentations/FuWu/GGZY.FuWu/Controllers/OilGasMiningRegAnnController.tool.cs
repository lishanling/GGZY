using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdOilGasMiningRegAnnController:BaseController
    {
        /// <summary>
        /// 读取OIL_GAS_MINING_REG_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadOilGasMiningRegAnns(OIL_GAS_MINING_REG_ANN model, SearchCondition condition)
        {
            var result = Fw.OilGasMiningRegAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取OIL_GAS_MINING_REG_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadOilGasMiningRegAnn(decimal M_ID)
        
        {
            var result = Fw.OilGasMiningRegAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建OIL_GAS_MINING_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateOilGasMiningRegAnn(OIL_GAS_MINING_REG_ANN model)
        {
            var result = Fw.OilGasMiningRegAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新OIL_GAS_MINING_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateOilGasMiningRegAnn(OIL_GAS_MINING_REG_ANN model)
        {
            var result = Fw.OilGasMiningRegAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除OIL_GAS_MINING_REG_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteOilGasMiningRegAnn(string ids)
        {
            var result = Fw.OilGasMiningRegAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}