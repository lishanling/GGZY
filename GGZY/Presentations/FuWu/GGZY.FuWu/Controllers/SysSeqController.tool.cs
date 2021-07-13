using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysSeqController:BaseController
    {
        /// <summary>
        /// 读取SYS_SEQ列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysSeqs(SYS_SEQ model, SearchCondition condition)
        {
            var result = Fw.SysSeqService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_SEQ明细
        /// </summary>
      /// <param name="TB_NAME"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysSeq(string TB_NAME)
        
        {
            var result = Fw.SysSeqService.ViewByPk(TB_NAME);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_SEQ信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysSeq(SYS_SEQ model)
        {
            var result = Fw.SysSeqService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_SEQ信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysSeq(SYS_SEQ model)
        {
            var result = Fw.SysSeqService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_SEQ信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysSeq(string ids)
        {
            var result = Fw.SysSeqService.Delete(ids);
            return JResult(result); 
        }
    }
}