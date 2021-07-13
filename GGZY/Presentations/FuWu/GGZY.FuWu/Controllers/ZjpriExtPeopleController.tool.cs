using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriExtPeopleController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_EXT_PEOPLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriExtPeoples(ZJPRI_EXT_PEOPLE model, SearchCondition condition)
        {
            var result = Fw.ZjpriExtPeopleService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_EXT_PEOPLE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriExtPeople(string ID)
        
        {
            var result = Fw.ZjpriExtPeopleService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_EXT_PEOPLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriExtPeople(ZJPRI_EXT_PEOPLE model)
        {
            var result = Fw.ZjpriExtPeopleService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_EXT_PEOPLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriExtPeople(ZJPRI_EXT_PEOPLE model)
        {
            var result = Fw.ZjpriExtPeopleService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_EXT_PEOPLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriExtPeople(string ids)
        {
            var result = Fw.ZjpriExtPeopleService.Delete(ids);
            return JResult(result); 
        }
    }
}