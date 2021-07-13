using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTAnswerAnnController:BaseController
    {
        /// <summary>
        /// 读取T_ANSWER_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAnswerAnns(T_ANSWER_ANN model, SearchCondition condition)
        {
            var result = Fw.TAnswerAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ANSWER_ANN明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAnswerAnn(decimal ID)
        
        {
            var result = Fw.TAnswerAnnService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ANSWER_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAnswerAnn(T_ANSWER_ANN model)
        {
            var result = Fw.TAnswerAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ANSWER_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAnswerAnn(T_ANSWER_ANN model)
        {
            var result = Fw.TAnswerAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ANSWER_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAnswerAnn(string ids)
        {
            var result = Fw.TAnswerAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}