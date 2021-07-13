using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class ProjectSupervisionRequestModel:SearchCondition
    {
        /// <summary>
        /// 处理状态
        /// </summary>
        public string HANDLE_STATE { get; set; }
        /// <summary>
        /// 工程类型
        /// </summary>
        public string PROJECT_TYPE { get; set; }
        /// <summary>
        /// 项目类型（发包方式）
        /// </summary>
        public string FBFS { get; set; }
    }
}