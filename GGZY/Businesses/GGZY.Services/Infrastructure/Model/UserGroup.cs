using System.Collections.Generic;

namespace GGZY.Services.Infrastructure.Model
{
    public class UserGroup
    {
        public const string ENTITY_NAME = "T_USER";
        public const string USER_GROUP_ID = "USER_GROUP_ID";
        public string UID { get; set; }
        public List<string> GROUP_IDS { get; set; }
    }
}