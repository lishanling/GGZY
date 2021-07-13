using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdNonOilGasExplorRegAnnController:BaseController
    {
        /// <summary>
        /// 读取NON_OIL_GAS_EXPLOR_REG_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadNonOilGasExplorRegAnns(NON_OIL_GAS_EXPLOR_REG_ANN model, SearchCondition condition)
        {
            var result = Fw.NonOilGasExplorRegAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取NON_OIL_GAS_EXPLOR_REG_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadNonOilGasExplorRegAnn(decimal M_ID)
        
        {
            var result = Fw.NonOilGasExplorRegAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建NON_OIL_GAS_EXPLOR_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateNonOilGasExplorRegAnn(NON_OIL_GAS_EXPLOR_REG_ANN model)
        {
            var result = Fw.NonOilGasExplorRegAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新NON_OIL_GAS_EXPLOR_REG_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateNonOilGasExplorRegAnn(NON_OIL_GAS_EXPLOR_REG_ANN model)
        {
            var result = Fw.NonOilGasExplorRegAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除NON_OIL_GAS_EXPLOR_REG_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteNonOilGasExplorRegAnn(string ids)
        {
            var result = Fw.NonOilGasExplorRegAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}