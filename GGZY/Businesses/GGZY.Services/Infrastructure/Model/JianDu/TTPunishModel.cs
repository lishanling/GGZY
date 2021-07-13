using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TTPunishModel
    {
        /// <summary>
        /// 监督平台用户信息
        /// </summary>

        #region TTPunishModel

        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 部门名称(组织机构)
        /// </summary>
        public string DNAME { get; set; }
        /// <summary>
        /// 行业编号代码
        /// </summary>

        public string KINDS { get; set; }
        /// <summary>
        /// 地区编码
        /// </summary>
        public string AREACODE { get; set; }
        /// <summary>
        /// 地区名称
        /// </summary>
        public string AREANAME { get; set; }
        /// <summary>
        /// 行业名称
        /// </summary>
        public string KIND_TEXT { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Display(Name = "电话", Order = 40)]
        public string PUNISH_PHONE { get; set; }

        /// <summary>
        /// 处罚对象ID
        /// </summary>
        public string PUNISH_ID { get; set; }

        /// <summary>
        /// 处罚编号
        /// </summary>
        [Display(Name = "处罚编号", Order = 10)]
        public string PUNISH_CODE { get; set; }
        /// <summary>
        /// 处罚标题
        /// </summaryz
        [Display(Name = "处罚标题", Order = 20)]
        public string PUNISH_TITLE { get; set; }
        /// <summary>
        /// 处罚时间
        /// </summary>
        
        public string PUNISH_TIME { get; set; }

        [Display(Name = "时间", Order = 70)]

        public string PUNISH_TIME_FORMAT => string.IsNullOrEmpty(PUNISH_TIME) ? "" : Convert.ToDateTime(PUNISH_TIME).ToString("yyyy-MM-dd");
        /// <summary>
        /// 处罚部门名称(组织机构)
        /// </summary>
        [Display(Name = "处罚对象", Order = 30)]
        public string PUNISH_DNAME { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [Display(Name = "操作人", Order = 50)]
        public string USE_OPERATOR { get; set; }


        /// <summary>
        ///关联招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }

        /// <summary>
        /// 固定电话
        /// </summary>
        public string PHONE { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string TELPHONE { get; set; }

        /// <summary>
        ///总类型
        /// </summary>
        public string HY_TYPE { get; set; }
        /// <summary>
        ///操作人真实姓名
        /// </summary>
        public string MANAGE_NAME { get; set; }

        #endregion
    }
}
