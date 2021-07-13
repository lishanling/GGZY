using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Base
{
    /// <summary>
    /// 监督平台后台-备案审核操作按钮
    /// </summary>
    public enum EnumReviewButton
    {
        /// <summary>
        /// 查看
        /// </summary>
        VIEW, //查看
        /// <summary>
        /// 操作记录
        /// </summary>
        HISTORY,//操作记录
        /// <summary>
        /// 保存
        /// </summary>
        SAVE, //保存
        /// <summary>
        /// 删除
        /// </summary>
        DELETE, //删除
        /// <summary>
        /// 提交、送审
        /// </summary>
        SUBMIT,//提交、送审
        /// <summary>
        /// 重新备案，列表页面使用，需整改状态则显示该按钮
        /// </summary>
        SUBMIT_AGAIN,
        /// <summary>
        /// 撤销
        /// </summary>
        CANCEL,//撤销
        /// <summary>
        /// 审核通过
        /// </summary>
        AUDIT,//审核通过
        /// <summary>
        /// 非住建签收
        /// </summary>
        RECEIVE_COMMON,
        /// <summary>
        /// 签收
        /// </summary>
        RECEIVE,//签收
        /// <summary>
        /// 退回
        /// </summary>
        FALLBACK,//退回


        FALLBACK2,//签收退回-不属于本项目
        FALLBACK3,//签收退回--资料不完成
        /// <summary>
        /// 签章
        /// </summary>
        SIGNUP,
        /// <summary>
        /// 审查意见
        /// </summary>
        SUBMIT_AUDIT,
        /// <summary>
        /// 审查意见修改
        /// </summary>
        SAVE_REMARK,

    }
    /// <summary>
    /// 监督平台后台-住建行业备案审核操作按钮
    /// </summary>
    public enum EnumZJReviewButton
    {
        [Description("招标文件备案")]
        TENDER_FILE_SAVE,
        [Description("接收")]
        RECEIVE,
        [Description("初审")]
        AUDIT_FIRST,
        [Description("非牵头人初审")]
        AUDIT_FIRST_COMMON,
        [Description("复审")]
        AUDIT_SENCOND,
        [Description("签发")]
        ISSUE,
        [Description("发出意见书")]
        SUBMISSION,
        [Description("招标条件备案-发出意见书")]
        SUBMISSION_TENDER_CONDITION,
        [Description("审查意见修改")]
        SAVE_FLOW_REMARK,
    }
    /// <summary>
    /// 备案记录的操作行为-OPERATION_BEHAVIOR
    /// </summary>
    public enum EnumOperation 
    {
        [Description("暂存")]
        暂存 =0,
        [Description("提交")]
        提交 =1,
        [Description("退回,不属于本部门监管的项目")]
        退回2 =2,
        [Description("退回,备案材料不完整")]
        退回3 =3,

        [Description("待审核")]
        待审核 =4,
        [Description("未发现问题")]
        未发现问题 =5,
        [Description("需整改")]
        需整改 =6,
        [Description("已签收")]
        已签收 =8,
        [Description("审查修改")]
        审查修改 =9,
        [Description("撤回")]
        撤回 =10,
        [Description("重新提交")]
        重新提交 =11
    }
}
