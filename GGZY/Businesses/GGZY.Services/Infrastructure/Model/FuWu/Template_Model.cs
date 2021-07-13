using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public partial class Template_Model
    {
      


            /// <summary>
            /// M_ID
            /// </summary>
            public string M_ID { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            public string CREATE_TIME { get; set; }
            /// <summary>
            /// 模板内容（可编辑）
            /// </summary>
            public string CONTENT_EDIT { get; set; }
            /// <summary>
            /// 模板内容（只读）
            /// </summary>
            
            public string READ_ONLY { get; set; }
            /// <summary>
            /// 模板类型（1：固定模板2：自定义模板）
            /// </summary>
            public string TEMPLATE_TYPE { get; set; }
            /// <summary>
            /// 内容类型（1：预警短信内容2：站内短信内容）
            /// </summary>
            public string CONTENT_TYPE { get; set; }
            /// <summary>
            /// 创建人ID
            /// </summary>
            public string FOUNDER_ID { get; set; }
            /// <summary>
            /// 创建人单位ID
            /// </summary>
            public string FOUNDER_UNIT_ID { get; set; }
            /// <summary>
            /// 招标项目编号
            /// </summary>
            public string TENDER_PROJECT_CODE { get; set; }
            /// <summary>
            /// 招标项目名称
            /// </summary>
            public string TENDER_PROJECT_NAME { get; set; }
            /// <summary>
            /// 监督点名称
            /// </summary>
            public string SP_NAME { get; set; }
            /// <summary>
            /// 监督规则
            /// </summary>
            public string SP_POINT_RULE { get; set; }
            /// <summary>
            /// 监管单位联系电话
            /// </summary>
            public string APPROVAL_PHONE { get; set; }

            /// <summary>
            /// 短信接收人电话
            /// </summary>
            public string INFO_ACCEPT_TELPHONE { get; set; }
           


    }
}
