using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdLetterOfGuaranteeController:BaseController
    {
        /// <summary>
        /// 读取LETTER_OF_GUARANTEE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadLetterOfGuarantees(LETTER_OF_GUARANTEE model, SearchCondition condition)
        {
            var result = Fw.LetterOfGuaranteeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LETTER_OF_GUARANTEE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadLetterOfGuarantee(decimal M_ID)
        
        {
            var result = Fw.LetterOfGuaranteeService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LETTER_OF_GUARANTEE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateLetterOfGuarantee(LETTER_OF_GUARANTEE model)
        {
            var result = Fw.LetterOfGuaranteeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LETTER_OF_GUARANTEE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateLetterOfGuarantee(LETTER_OF_GUARANTEE model)
        {
            var result = Fw.LetterOfGuaranteeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LETTER_OF_GUARANTEE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteLetterOfGuarantee(string ids)
        {
            var result = Fw.LetterOfGuaranteeService.Delete(ids);
            return JResult(result); 
        }
    }
}