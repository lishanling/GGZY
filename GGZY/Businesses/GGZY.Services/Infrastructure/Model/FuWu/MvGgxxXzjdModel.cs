using System;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    /// <summary>
    /// 实体类MV_GGXX_XZJD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class MvGgxxXzjdModel
    {
        #region Model


        /// <summary>
        /// 
        /// </summary>
        public decimal? PROJECT_CATEGORY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string KIND { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? M_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "项目名称", Order = 10)]
        public string PROJECT_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_TYPE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PROTYPE_TEXT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TITLE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GGTYPE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string REGION_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "地区", Order = 20)]
        public string AREANAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PLATFORM_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "来源平台", Order = 30)]
        public string PLATFORM_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TM { get; set; }

        [Display(Name = "时间", Order = 30)]
        public string TM_FORMAT => TM?.ToString("yyyy-MM-dd HH : ss") ?? "";
        #endregion

    }
}