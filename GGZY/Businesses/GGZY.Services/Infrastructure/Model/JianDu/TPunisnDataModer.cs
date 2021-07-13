using GGZY.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TPunisnDataModel
    {
        public List<UploadResData> FILES_ATTACHMENT { get; set; }

        #region 用于处罚详情返回

        /// <summary>
        /// M_ID(只用于前端返回使用，数据表中主键为ID)
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 处罚来源 部门名称(组织机构) 
        /// </summary>
        public string DNAME { get; set; }
     

        /// <summary>
        ///处罚对象联系电话
        /// </summary>
        public string PUNISH_PHONE { get; set; }

        /// <summary>
        /// 处罚对象ID
        /// </summary>
        public string PUNISH_ID { get; set; }

        /// <summary>
        /// 处罚编号
        /// </summary>
        public string PUNISH_CODE { get; set; }
        /// <summary>
        /// 处罚标题
        /// </summary>
        public string PUNISH_TITLE { get; set; }
        /// <summary>
        /// 处罚时间
        /// </summary>
        public string PUNISH_TIME { get; set; }

        /// <summary>
        /// 处罚部门名称(组织机构)
        /// </summary>
        public string PUNISH_DNAME { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public string USE_OPERATOR { get; set; }

        /// <summary>
        /// 处罚来源联系电话（执行处罚操作人的电话）
        /// </summary>
        public string CF_PHONE { get; set; }

        /// <summary>
        /// 关联招标项目
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        ///招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }

        /// <summary>
        /// 处罚记录—附件上传（以，隔开）
        /// </summary>
        public string PUNISH_FILE { get; set; }

        /// <summary>
        /// 处罚内容
        /// </summary>
        public string PUNISH_CONTENT { get; set; }

        //以下用于附件条件
        public string VALUE { get; set; }
        public string LABEL { get; set; }
        public string TIME { get; set; }

        public object DATA { get; set; }

        public List<TPunisnDataModel> SuperviseFeedback { get; set; }
        #endregion
    }
}
