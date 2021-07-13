using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExTrainAndTestController:BaseController
    {
        /// <summary>
        /// 读取EX_TRAIN_AND_TEST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExTrainAndTests(EX_TRAIN_AND_TEST model, SearchCondition condition)
        {
            var result = Fw.ExTrainAndTestService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EX_TRAIN_AND_TEST明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExTrainAndTest(decimal ID)
        
        {
            var result = Fw.ExTrainAndTestService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EX_TRAIN_AND_TEST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExTrainAndTest(EX_TRAIN_AND_TEST model)
        {
            var result = Fw.ExTrainAndTestService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EX_TRAIN_AND_TEST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExTrainAndTest(EX_TRAIN_AND_TEST model)
        {
            var result = Fw.ExTrainAndTestService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EX_TRAIN_AND_TEST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExTrainAndTest(string ids)
        {
            var result = Fw.ExTrainAndTestService.Delete(ids);
            return JResult(result); 
        }
    }
}