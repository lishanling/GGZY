using System;
using GGZY.Core.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class ProjectSupervisionResponseHyModel
    {
        private string _TYPE_TEXT;
        public string ID { get; set; }
        public DateTime? TM { get; set; }

        public string CODE { get; set; }
        public string NAME { get; set; }

        public string TYPE { get; set; }

        public DateTime? BID_OPEN_TIME { get; set; }
        public DateTime? NOTICE_SEND_TIME { get; set; }
        public string TYPE_TEXT
        {
            get
            {

                string typeText;
                switch (TYPE)
                {
                    case nameof(T_AFC_PROJECT):
                        typeText = "招标计划登记";
                        break;
                    case nameof(PT_ZXTS):
                        typeText = "投诉处理";
                        break;
                    case nameof(RECORD_REVIEW):
                        typeText = $"招标备案-{_TYPE_TEXT}";
                        break;
                    case nameof(GGZYFW.DbEntity.WARN_RESULT):
                        typeText = $"监督点-{_TYPE_TEXT}";
                        break;
                    default:
                        typeText = _TYPE_TEXT;
                        break;
                }
                return typeText;
            }
            set => _TYPE_TEXT = value;
        }

        /// <summary>
        /// 类型为T_AFC_PROJECT 专用 跳转详情页需要
        /// </summary>
        public string MID {
            get
            {
                if (TYPE == nameof(T_AFC_PROJECT))
                {
                    return ID.DesEncrypt();
                }
                return String.Empty;
            } }
        /// <summary>
        /// 类型为RECORD_REVIEW 招标备案专用 状态
        /// </summary>
        public string REVIEW_STATUS { get; set; }
        /// <summary>
        /// 类型为RECORD_REVIEW 招标备案专用 类型
        /// </summary>
        public string REVIEW_TYPE { get; set; }
        /// <summary>
        /// 工程类型
        /// </summary>
        public string TENDER_PROJECT_TYPE_TEXT { get; set; }
    }
}