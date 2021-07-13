using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtTransferController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_TRANSFER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtTransfers(T_ZT_TRANSFER model, SearchCondition condition)
        {
            var result = Fw.TZtTransferService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_TRANSFER明细
        /// </summary>
      /// <param name="LEGALCODE">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtTransfer(string LEGALCODE)
        
        {
            var result = Fw.TZtTransferService.ViewByPk(LEGALCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_TRANSFER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtTransfer(T_ZT_TRANSFER model)
        {
            var result = Fw.TZtTransferService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_TRANSFER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtTransfer(T_ZT_TRANSFER model)
        {
            var result = Fw.TZtTransferService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_TRANSFER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtTransfer(string ids)
        {
            var result = Fw.TZtTransferService.Delete(ids);
            return JResult(result); 
        }
    }
}