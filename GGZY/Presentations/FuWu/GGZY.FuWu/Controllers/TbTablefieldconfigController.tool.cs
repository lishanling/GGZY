using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTbTablefieldconfigController:BaseController
    {
        /// <summary>
        /// 读取TB_TABLEFIELDCONFIG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTbTablefieldconfigs(TB_TABLEFIELDCONFIG model, SearchCondition condition)
        {
            var result = Fw.TbTablefieldconfigService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TB_TABLEFIELDCONFIG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTbTablefieldconfig(decimal ID)
        
        {
            var result = Fw.TbTablefieldconfigService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TB_TABLEFIELDCONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTbTablefieldconfig(TB_TABLEFIELDCONFIG model)
        {
            var result = Fw.TbTablefieldconfigService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TB_TABLEFIELDCONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTbTablefieldconfig(TB_TABLEFIELDCONFIG model)
        {
            var result = Fw.TbTablefieldconfigService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TB_TABLEFIELDCONFIG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTbTablefieldconfig(string ids)
        {
            var result = Fw.TbTablefieldconfigService.Delete(ids);
            return JResult(result); 
        }
    }
}