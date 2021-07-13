﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 招标计划
    /// </summary>
    public partial class TSuperviseResultService
    {
        #region 发起督察
        /// <summary>
        /// 督察
        /// </summary>
        /// <returns></returns>
        public GeneralResult TenderProjectSupervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = nameof(TENDER_PROJECT);
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            var tenderProject = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.M_ID == model.ENTITY_ID);
            model.ENTITY_NAME = tenderProject?.TENDER_PROJECT_NAME;
            model.TENDER_PROJECT_CODE = tenderProject?.TENDER_PROJECT_CODE;
            model.TENDER_PROJECT_NAME = tenderProject?.TENDER_PROJECT_NAME;
            model.REGION_CODE = tenderProject?.REGION_CODE;
            model.TENDER_PROJECT_TYPE =tenderProject?.TENDER_PROJECT_TYPE;
            if (!string.IsNullOrWhiteSpace(model.OBJ) && decimal.TryParse(model.OBJ, out decimal objId))
            {
                //var obj = Jd.TUserService.JdUserInfo(objId);
                var obj = Jd.TUserDepartmentService.FindDepartmentByDepid(objId);
                model.OBJ_NAME = obj?.DNAME;
                model.OBJ_DEP_ID = obj?.DEPID?.ToString();
                model.OBJDEP_NAME = obj?.DNAME;// obj?.UserDepartment?.DNAME;
                model.CODE = CreateSuperviseCode();
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.FILES_ATTACHMENT.Select(c => c.JdSysAttachment()).ToList();
                    trans.Insert(attachments);
                    model.FILES = string.Join(",", attachments.Select(c => c.GUID));
                    var entity = model.ConvertTo<T_SUPERVISE>();

                    trans.Insert(entity);

                    #region 督查操作记录

                    var log = new T_SUPERVISE_LOG
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = model.M_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        LOG_TIME = DateTime.Now,
                        LOG_TYPE = "10",
                        LOG_TYPE_TXT = "发起督察",
                        SUPERVISE_FEEDBACK_ID = String.Empty,
                        SUPERVISE_FORWORD_ID = string.Empty,
                    };
                    trans.Insert(log);

                    #endregion

                    #region 督查流转实例
                    var forward = new T_SUPERVISE_FORWARD
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = model.M_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        FORWARD_TIME = DateTime.Now,
                        SUPERVISE_INSTANCE_ID = model.M_ID,
                    };
                    trans.Insert(forward);


                    #endregion
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail("请选择督查对象");
            }

            return r;
        }

        #endregion
    }
}