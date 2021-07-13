using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMchgProgMgtController:BaseController
    {
        /// <summary>
        /// 读取MCHG_PROG_MGT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMchgProgMgts(MCHG_PROG_MGT model, SearchCondition condition)
        {
            var result = Fw.MchgProgMgtService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MCHG_PROG_MGT明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMchgProgMgt(decimal ID)
        
        {
            var result = Fw.MchgProgMgtService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建MCHG_PROG_MGT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMchgProgMgt(MCHG_PROG_MGT model)
        {
            var result = Fw.MchgProgMgtService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MCHG_PROG_MGT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMchgProgMgt(MCHG_PROG_MGT model)
        {
            var result = Fw.MchgProgMgtService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MCHG_PROG_MGT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMchgProgMgt(string ids)
        {
            var result = Fw.MchgProgMgtService.Delete(ids);
            return JResult(result); 
        }
    }
}