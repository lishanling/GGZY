using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserService
    {
        /// <summary>
        /// 按照二期项目初始化用户角色和组织机构信息
        /// </summary>
        /// <returns></returns>
        public GeneralResult InitialUserRoleAndDepartsV2()
        {
            var r = new GeneralResult();
            var roleV1 = Jd.TUserRoleService.FindAll();
            var roleV2 = Jd.TUserRoleV2Service.FindAll();
            var users = FindAll();
            var departs = Jd.TUserDepartmentService.FindAll();

            foreach (var model in users)
            {
               
                if (model.DEPARTID.HasValue)
                {
                    var departArr = new List<string> {model.DEPARTID.ToString()};
                    Jd.TUserDepartmentService.FindParentDepId(departArr, departs);
                    departArr.Reverse();
                    var departIds = string.Join(",", departArr);

                    Jd.TGeneralAttributeV2Service.SaveAttribute(nameof(T_USER), "DEPARTIDS", departIds, model.ID?.ToString(), $"监督平台用户组织机构递归信息");
                }

                if (!string.IsNullOrWhiteSpace(model.ROLEIDS))
                {

                    var roleV1Array = model.ROLEIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var modelRoleV1 = roleV1.FindAll(c => roleV1Array.Contains(c.ID.ToString()));
                    if (modelRoleV1.Any())
                    {
                        var names = modelRoleV1.Select(c => c.NAME).ToList();
                        var modelRoleV2 = roleV2.FindAll(c => names.Contains(c.NAME));
                        if (modelRoleV2.Any())
                        {
                            var groupIds = modelRoleV2.Select(c => c.GROUP_ID).ToList();
                            SetUserRoles(new UserGroup
                            {
                                GROUP_IDS = groupIds,
                                UID = model.ID?.ToString()
                            });
                        }
                    }
                }
            }
            return r;
        }

       
    }
}