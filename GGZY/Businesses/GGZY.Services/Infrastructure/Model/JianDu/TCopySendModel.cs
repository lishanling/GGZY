using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TCopySendModel
    {
        /// <summary>
        /// 抄送部门信息
        /// </summary>

        #region TCopySendModel

        /// <summary>
        /// M_ID(处罚表ID)
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// ID(抄送表ID)
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 抄送部门名称
        /// </summary>
        public string CS_NAME { get; set; }

        /// <summary>
        /// 抄送部门ID
        /// </summary>

        public string CS_ID { get; set; }
        /// <summary>
        /// 抄送内容
        /// </summary>
        public string CS_CONTENT { get; set; }
        /// <summary>
        /// 抄送时间
        /// </summary>
        [Display(Name = "时间", Order = 50)]
        public string CS_TIME { get; set; }
        /// <summary>
        /// 用于存储处罚表中传过来的处罚ID
        /// </summary>
        public string CS_PUNISH_ID { get; set; }

        /// <summary>
        /// 处罚标题
        /// </summary>
        [Display(Name = "处罚标题", Order = 20)]
        public string PUNISH_TITLE { get; set; }
        /// <summary>
        /// 处罚对象
        /// </summary>
        public string PUNISH_ID { get; set; }
        /// <summary>
        /// 处罚编号
        /// </summary>
        [Display(Name = "处罚编号", Order = 10)]
        public string PUNISH_CODE { get; set; }
        /// <summary>
        /// 操作人（处罚来源）
        /// </summary>
        [Display(Name = "处罚来源", Order = 40)]
        public string USE_OPERATOR { get; set; }
        /// <summary>
        /// 处罚对象单位名称
        /// </summary>
        [Display(Name = "处罚对象", Order = 30)]
        public string PUNISH_DNAME { get; set; }

        #endregion

    }
}
