using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class ReviewSuperviseProjectModel
    {
        #region 招标项目模型重构

        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// M_ID
        /// </summary>
        public decimal? M_ID { get; set; }

        /// <summary>
        /// 招标项目名称
        /// </summary>
        [Display(Name = "招标项目名称", Order = 20)]
        public string TENDER_PROJECT_NAME { get; set; }

        /// <summary>
        /// 招标计划编号
        /// </summary>
        [Display(Name = "招标编号", Order = 10)]
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 提交时间
        /// </summary>
        [Display(Name = "创建时间", Order = 80)]
        public string CREATE_TIME { get; set; }
        /// <summary>
        /// 所在地
        /// </summary>
        public string REGION_CODE { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        [Display(Name = "业务类型", Order =70)]
        public string TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 审查单位ID
        /// </summary>
        public string RECORD_DEPID { get; set; }
        /// <summary>
        /// 招标人名称
        /// </summary>
        [Display(Name = "招标人名称", Order = 30)]
        public string TENDERER_NAME { get; set; }
        /// <summary>
        /// 招标代理机构名称
        /// </summary>
        [Display(Name = "代理机构", Order = 40)]
        public string TENDER_AGENCY_NAME { get; set; }
        /// <summary>
        /// 审查单位名称
        /// </summary>
        [Display(Name = "审查单位", Order = 50)]
        public string DNAME { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        [Display(Name = "地区", Order =60)]
        public string AREANAME { get; set; }

 

        #endregion



    }
}
