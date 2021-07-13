using System.Web.Mvc;

namespace GGZY.Framework.Controllers
{
    public class GenericController:BaseController
    {
        //public 

        #region UnitTest

        public ActionResult List()
        {
            return Content("List");
        }
        public ActionResult Detail()
        {
            return Content("Detail");
        }
        public ActionResult Create()
        {
            return Content("Create");
        }
        public ActionResult Update()
        {
            return Content("Update");
        }
        public ActionResult Delete()
        {
            return Content("Delete");
        }

        #endregion
    }
}