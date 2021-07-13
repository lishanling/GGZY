using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSeqController:BaseController
    {
        /// <summary>
        /// 读取T_SEQ列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSeqs(T_SEQ model, SearchCondition condition)
        {
            var result = Fw.TSeqService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SEQ明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSeq(decimal ID)
        
        {
            var result = Fw.TSeqService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SEQ信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSeq(T_SEQ model)
        {
            var result = Fw.TSeqService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SEQ信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSeq(T_SEQ model)
        {
            var result = Fw.TSeqService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SEQ信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSeq(string ids)
        {
            var result = Fw.TSeqService.Delete(ids);
            return JResult(result); 
        }
    }
}