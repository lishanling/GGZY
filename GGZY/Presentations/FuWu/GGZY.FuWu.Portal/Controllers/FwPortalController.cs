using GGZY.Framework.Controllers;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Helper;

namespace GGZY.FuWu.Portal.Controllers
{
    public class FwPortalController:BaseController
    {
        public FwPortalController()
        {
            SKey = ConfigHelper.AppSettings.FW_PORTAL_ASC_KEY;// "BE45D593014E4A4EB4449737660876CE";
            Iv = ConfigHelper.AppSettings.FW_PORTAL_ASC_IV;// "A8909931867B0425";
        }
    }
}