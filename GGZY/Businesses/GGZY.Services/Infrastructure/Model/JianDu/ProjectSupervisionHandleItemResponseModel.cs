using System;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class ProjectSupervisionHandleItemResponseModel
    {
        private string _TYPE_TEXT;
        private string _HANDLE_TYPE_TEXT;

        /// <summary>
        /// 处理事项类型
        /// </summary>
        public string TYPE_TEXT
        {
            get
            {
                string typeText= _TYPE_TEXT;
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
                        typeText = $"触发监督点-{_TYPE_TEXT}";
                        break;
                    case nameof(JC_TRANS_PROJECT):
                        typeText = $"发出移送:{_TYPE_TEXT}";
                        break;
                    case nameof(GGZYFW.DbEntity.BD_VIOLATION_RECORD):
                        typeText = $"触发疑似违规点:{_TYPE_TEXT}";
                        break;
                    case nameof(JC_TRANS_PERSON):
                        typeText = $"向纪委移送公职人员:{_TYPE_TEXT}";
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
        /// 办理人员
        /// </summary>
        public string OPERATOR { get; set; }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string HANDLE_OPINION { get; set; }

        /// <summary>
        /// 处理状态
        /// 未处理 处理中 已处理
        /// </summary>
        public string HANDLE_TYPE_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_HANDLE_TYPE_TEXT))
                {
                    switch (HANDLE_TYPE)
                    {
                        case "1":
                            _HANDLE_TYPE_TEXT = "处理中";
                            break;
                        case "2":
                            _HANDLE_TYPE_TEXT = "已处理";
                            break;
                        default:
                            _HANDLE_TYPE_TEXT = "未处理";
                            break;
                    }
                }
                return _HANDLE_TYPE_TEXT;
            }
            set => _HANDLE_TYPE_TEXT = value;
        }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? HANDLE_TIME { get; set; }

        public string TYPE { get; set; }
        public string HANDLE_TYPE { get; set; }
        /// <summary>
        /// 移送来源
        /// </summary>
        public string FROM { get; set; }
        /// <summary>
        /// 移送对象
        /// </summary>
        public string TO { get; set; }


    }
}