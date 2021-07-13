using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class JdVideoPointInfoModel : JdVideoBasicInfoModel
    {
        public string ID { get; set; }
        public string PID { get; set; }

        public string NAME { get; set; }

        public string ICON { get; set; }

        #region V_VIDEOPOINTINFO

        public string ENNMCD { get; set; }
        public string CAMERAID { get; set; }
        public string ITEMNAME { get; set; }
        public string DEVICEID { get; set; }
        public int CHANNEL { get; set; }

        public int STATUS { get; set; }

        #endregion
    }
}