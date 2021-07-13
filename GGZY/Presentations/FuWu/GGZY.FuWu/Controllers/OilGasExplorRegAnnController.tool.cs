using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdOilGasExplorRegAnnController:BaseController
    {
        /// <summary>
        /// 读取OIL_GAS_EXPLOR_REG_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadOilGasExplorRegAnns(OIL_GAS_EXPLOR_REG_ANN model, SearchCondition condition)
        {
            var result = Fw.OilGasExplorRegAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取OIL_GAS_EXPLOR_REG_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadOilGasExplorRegAnn(decimal M_ID)
        
        {
            var result = Fw.OilGasExplorRegAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建OIL_GAS_EXPLOR_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateOilGasExplorRegAnn(OIL_GAS_EXPLOR_REG_ANN model)
        {
            var result = Fw.OilGasExplorRegAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新OIL_GAS_EXPLOR_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateOilGasExplorRegAnn(OIL_GAS_EXPLOR_REG_ANN model)
        {
            var result = Fw.OilGasExplorRegAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除OIL_GAS_EXPLOR_REG_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteOilGasExplorRegAnn(string ids)
        {
            var result = Fw.OilGasExplorRegAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}