using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdWithdrawBlackListController:BaseController
    {
        /// <summary>
        /// 读取WITHDRAW_BLACK_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadWithdrawBlackLists(WITHDRAW_BLACK_LIST model, SearchCondition condition)
        {
            var result = Fw.WithdrawBlackListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取WITHDRAW_BLACK_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadWithdrawBlackList(decimal M_ID)
        
        {
            var result = Fw.WithdrawBlackListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建WITHDRAW_BLACK_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateWithdrawBlackList(WITHDRAW_BLACK_LIST model)
        {
            var result = Fw.WithdrawBlackListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新WITHDRAW_BLACK_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateWithdrawBlackList(WITHDRAW_BLACK_LIST model)
        {
            var result = Fw.WithdrawBlackListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除WITHDRAW_BLACK_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteWithdrawBlackList(string ids)
        {
            var result = Fw.WithdrawBlackListService.Delete(ids);
            return JResult(result); 
        }
    }
}