using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTRpStTreeNodeController:BaseController
    {
        /// <summary>
        /// 读取T_RP_ST_TREE_NODE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTRpStTreeNodes(T_RP_ST_TREE_NODE model, SearchCondition condition)
        {
            var result = Fw.TRpStTreeNodeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_RP_ST_TREE_NODE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTRpStTreeNode(decimal ID)
        
        {
            var result = Fw.TRpStTreeNodeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_RP_ST_TREE_NODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTRpStTreeNode(T_RP_ST_TREE_NODE model)
        {
            var result = Fw.TRpStTreeNodeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_RP_ST_TREE_NODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTRpStTreeNode(T_RP_ST_TREE_NODE model)
        {
            var result = Fw.TRpStTreeNodeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_RP_ST_TREE_NODE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTRpStTreeNode(string ids)
        {
            var result = Fw.TRpStTreeNodeService.Delete(ids);
            return JResult(result); 
        }
    }
}