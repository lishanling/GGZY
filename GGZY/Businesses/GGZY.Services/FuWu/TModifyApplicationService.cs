using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TModifyApplicationService
    {
        public GeneralResult Review(string guid)
        {
            var r = new GeneralResult();
            T_MODIFY_APPLICATION model = FirstOrNull(T_MODIFY_APPLICATION._.GUID == guid);
            if (model != null)
            {
                //修改状态
                Update(T_MODIFY_APPLICATION._.REVIEW_STATUS, "3", T_MODIFY_APPLICATION._.GUID == guid);
                
                //todo 根据类型执行操作


                r.SetSuccess("修改成功");
            }
            r.SetFail("修改失败");
            return r;
        }
    }
}
