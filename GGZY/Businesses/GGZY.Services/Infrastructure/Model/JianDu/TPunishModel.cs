using GGZY.Core.Models;
using GGZY.Services.FuWu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_Punish。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    //[Serializable]
    public partial class TPunishModel
    {

        public List<UploadResData> FILES_ATTACHMENT { get; set; }

        #region

        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 处罚记录—处罚编号
        /// </summary>
        public string PUNISH_CODE { get; set; }

        /// <summary>
        /// 处罚记录—处罚标题
        /// </summary>
        public string PUNISH_TITLE { get; set; }

        /// <summary>
        /// 处罚记录-处罚对象(组织机构ID)
        /// </summary>

        public string PUNISH_ID { get; set; }


        /// <summary>
        /// 处罚记录-关联项目（招标项目编号）
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }


        /// <summary>
        /// 处罚记录—处罚时间
        /// </summary>
        public DateTime? PUNISH_TIME { get; set; }

        /// <summary>
        /// 处罚记录-操作人
        /// </summary>
        public string USE_OPERATOR { get; set; }

        /// <summary>
        /// 处罚记录—处罚内容
        /// </summary>
        public string PUNISH_CONTENT { get; set; }

        /// <summary>
        /// 处罚记录—附件上传（以，隔开）
        /// </summary>
        public string PUNISH_FILE { get; set; }

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
        public DateTime? CS_TIME { get; set; }
        /// <summary>
        /// 上级对象ID
        /// </summary>
        public string  PARENTID { get; set; }
        /// <summary>
        /// 发出到抄送表中的处罚id
        /// </summary>
        public string CS_PUNISH_ID { get; set; }
        /// <summary>
        /// 行业类型
        /// </summary>
        public string TENDER_PROJECT_TYPE{ get; set; }
        /// <summary>
        /// 地区编号
        /// </summary>
        public string REGION_CODE{ get; set; }
        #endregion
    }
}
