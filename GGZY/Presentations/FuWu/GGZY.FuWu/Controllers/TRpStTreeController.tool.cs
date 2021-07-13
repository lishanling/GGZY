using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTRpStTreeController:BaseController
    {
        /// <summary>
        /// 读取T_RP_ST_TREE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTRpStTrees(T_RP_ST_TREE model, SearchCondition condition)
        {
            var result = Fw.TRpStTreeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_RP_ST_TREE明细
        /// </summary>
      /// <param name="TREE_CODE"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTRpStTree(string TREE_CODE)
        
        {
            var result = Fw.TRpStTreeService.ViewByPk(TREE_CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_RP_ST_TREE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTRpStTree(T_RP_ST_TREE model)
        {
            var result = Fw.TRpStTreeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_RP_ST_TREE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTRpStTree(T_RP_ST_TREE model)
        {
            var result = Fw.TRpStTreeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_RP_ST_TREE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTRpStTree(string ids)
        {
            var result = Fw.TRpStTreeService.Delete(ids);
            return JResult(result); 
        }
    }
}