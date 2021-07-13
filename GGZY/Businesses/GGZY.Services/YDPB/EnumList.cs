using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services
{
    /// <summary>
    /// 申请状态
    /// </summary>
    public enum Audit_Status
    {
        待审批 = 0,
        审核通过 = 1,
        审核不通过 = 2,
        已办理 = 3
    }

    /// <summary>
    /// 场地申请类型
    /// </summary>
    public enum Apply_Type
    {
        场地申请 = 0,
        场地变更 = 1,
        场地取消 = 2
    }
    /// <summary>
    /// 用户角色
    /// </summary>
    public enum UserRole
    {
        agency = 11,
        tradingCenter = 26
    }
}
