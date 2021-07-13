using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class JdVideoBasicInfoModel:V_VIDEOBASICINFO
    {
        public string AREANAME => $"{SHENG}{SHI}{XIAN}";
        [JsonIgnore]
        public string SHENG { get; set; }
        [JsonIgnore]
        public string SHI { get; set; }
        [JsonIgnore]
        public string XIAN { get; set; }
    }
}