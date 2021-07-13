using System;
using System.Collections.Generic;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class OperationRecordModel:OPERTION_RECORD
    {
        public string OPERATION_BEHAVIOR_TEXT => ((EnumOperation) Enum.Parse(typeof(EnumOperation), OPERATION_BEHAVIOR?.ToString()??""))
            .DisplayEnumDescription();
        public string OPERATION_PERSON_TYPE { get; set; }

        public string OPERATION_PERSON_DEP_NAME =>
            OPERATION_PERSON_TYPE == ((int)JdTUserType.BaoJianBeiAnYongHu).ToString() ? T_USER_EXTEND_DEP_NAME : T_USER_DEPARTMENT_DNAME;
        public string MANAGER_NAME { get; set; }
        [JsonIgnore]
        public string T_USER_DEPARTMENT_DNAME { get; set; }
        [JsonIgnore]
        public string T_USER_EXTEND_DEP_NAME { get; set; }
        public string REVIEW_TYPE_TEXT { get; set; }

        public string REVIEW_CODE { get; set; }

        public List<UploadResData> ATTACHMENT_ID_FILES { get; set; }
    }
}