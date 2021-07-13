using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdZjBidDocCharactCodeController:BaseController
    {
        /// <summary>
        /// 读取ZJ_BID_DOC_CHARACT_CODE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjBidDocCharactCodes(ZJ_BID_DOC_CHARACT_CODE model, SearchCondition condition)
        {
            var result = Jd.ZjBidDocCharactCodeService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJ_BID_DOC_CHARACT_CODE明细
        /// </summary>
      /// <param name="M_ID">数据自增长ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjBidDocCharactCode(decimal M_ID)
        
        {
            var result = Jd.ZjBidDocCharactCodeService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJ_BID_DOC_CHARACT_CODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjBidDocCharactCode(ZJ_BID_DOC_CHARACT_CODE model)
        {
            var result = Jd.ZjBidDocCharactCodeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJ_BID_DOC_CHARACT_CODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjBidDocCharactCode(ZJ_BID_DOC_CHARACT_CODE model)
        {
            var result = Jd.ZjBidDocCharactCodeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJ_BID_DOC_CHARACT_CODE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjBidDocCharactCode(string ids)
        {
            var result = Jd.ZjBidDocCharactCodeService.Delete(ids);
            return JResult(result); 
        }
    }
}