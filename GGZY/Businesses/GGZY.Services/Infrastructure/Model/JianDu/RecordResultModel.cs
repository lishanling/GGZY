using System;
using System.Collections.Generic;
using GGZY.Core.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class RecordResultModel
    {
        public List<UploadResData> FILES_ATTACHMENT { get; set; }
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 调查结果状态 0:未发现问题  1：发现问题并处理
        /// </summary>
        public decimal? STATE { get; set; }
        /// <summary>
        /// 违规行为记录ID
        /// </summary>
        public string VIOLATION_RECORD_ID { get; set; }
        /// <summary>
        /// 处理结果记录
        /// </summary>
        public string DESCRIPTION { get; set; }
        /// <summary>
        /// 相关附件GUID
        /// </summary>
        public string GUIDS { get; set; }
        /// <summary>
        /// 处理人
        /// </summary>
        public decimal? OPERATION_USER { get; set; }
        /// <summary>
        /// 处理人部门ID
        /// </summary>
        public decimal? OPERATION_DEPT { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime OPERATION_TIME { get; set; }
        /// <summary>
        ///创建时间
        /// </summary>
        public DateTime CREATE_TIME { get; set; }
        /// <summary>
        ///是否删除
        /// </summary>
        public decimal? IS_DELETE { get; set; }
        /// <summary>
        ///疑似违规行为类型 0：项目 1：主体
        /// </summary>
        public decimal? POINT_TYPE { get; set; }
    }
}
