using System.Collections.Generic;
using Newtonsoft.Json;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 住建软硬件雷同
    /// </summary>
    public partial class ZjSoftwareAndHardwareSimilarModel
    {
		public string BIDDER_NAME { get; set; }
        public string BIDDER_ORG_CODE { get; set; }
        public string TENDER_PROJECT_CODE { get; set; }
        public string TENDER_PROJECT_NAME { get; set; }
        public string TENDER_PROJECT_TYPE { get; set; }
        public string MAC_ADDRESS { get; set; }
        public string CPU_ID { get; set; }
        public string HARD_DISK_SERIAL_NUMBER { get; set; }
        public string MEMORY_SERIAL_NUMBER { get; set; }
        public string M_TM { get; set; }

        public bool IsSimilar => SimilarCount > 0;

        public int SimilarCount => Similar?.Count ?? 0;
        [JsonIgnore]
        public List<ZjSoftwareAndHardwareSimilarModel> Similar { get; set; }
    }
}