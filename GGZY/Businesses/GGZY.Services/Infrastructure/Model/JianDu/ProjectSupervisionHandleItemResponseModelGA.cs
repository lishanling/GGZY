using System;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 项目监督 公安 处理项目及事项 详情 处理事项
    /// </summary>
    public class ProjectSupervisionHandleItemResponseModelGA
    {
        private string _TITLE;

        public string TITLE
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_TITLE))
                {
                    var txt = TYPE == "RECEIVE" ? "收到移送" : "发出移送";
                    return $"{txt}:{_TITLE}";
                }
                return _TITLE;
            }
            set => _TITLE = value;
        }

        public decimal? HAS_RESULT { get; set; }
        public string HAS_RESULT_TEXT => HAS_RESULT == 1 ? "已处理" : "未处理";
        public string TRANS_USER { get; set; }
        public string UNIT_NAME { get; set; }
        public string RESULT_MSG { get; set; }
        public string TRANS_TIME { get; set; }
        public string TYPE { get; set; }
    }
}