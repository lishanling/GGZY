using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTbTableconfigController:BaseController
    {
        /// <summary>
        /// 读取TB_TABLECONFIG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTbTableconfigs(TB_TABLECONFIG model, SearchCondition condition)
        {
            var result = Fw.TbTableconfigService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TB_TABLECONFIG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTbTableconfig(decimal ID)
        
        {
            var result = Fw.TbTableconfigService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TB_TABLECONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTbTableconfig(TB_TABLECONFIG model)
        {
            var result = Fw.TbTableconfigService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TB_TABLECONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTbTableconfig(TB_TABLECONFIG model)
        {
            var result = Fw.TbTableconfigService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TB_TABLECONFIG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTbTableconfig(string ids)
        {
            var result = Fw.TbTableconfigService.Delete(ids);
            return JResult(result); 
        }
    }
}