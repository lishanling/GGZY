using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 监督平台信息维护
    /// </summary>
    public partial class ManagerController
    {

        #region 网站信息发布

        #region 友情链接
        /// <summary>
        /// 读取PT_LINK列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadJdPtLinks(PT_LINK model, SearchCondition condition)
        {
            var result = Jd.PtLinkService.PageList(model, condition).ToPageTableResult(condition);
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_LINK明细
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
        public ActionResult ReadJdPtLink(decimal ID)
        {
            var result = Jd.PtLinkService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_LINK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateJdPtLink(PT_LINK model)
        {
            var result = Jd.PtLinkService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_LINK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateJdPtLink(PT_LINK model)
        {
            var result = Jd.PtLinkService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_LINK信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteJdPtLink(string ids)
        {
            var result = Jd.PtLinkService.Delete(ids);
            return JResult(result);
        }


        #endregion

        #region 发布类型

        /// <summary>
        /// 读取PT_ATYPE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadJdPtAtypes(PT_ATYPE model, SearchCondition condition)
        {
            var result = Jd.PtAtypeService.PageList(model, condition).ToPageTableResult(condition);
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_ATYPE明细
        /// </summary>
        /// <param name="ID">编号</param>
        /// <returns></returns>
        /// <returns></returns>
        public ActionResult ReadJdPtAtype(decimal ID)

        {
            var result = Jd.PtAtypeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_ATYPE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateJdPtAtype(PT_ATYPE model)
        {
            var result = Jd.PtAtypeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_ATYPE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateJdPtAtype(PT_ATYPE model)
        {
            var result = Jd.PtAtypeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_ATYPE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteJdPtAtype(string ids)
        {
            var result = Jd.PtAtypeService.Delete(ids);
            return JResult(result);
        }

        #endregion

        #region 监督平台-管理后台-工作台公告
        /// <summary>
        /// 公告列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ReadJdTNotices(T_NOTICE model, SearchCondition search)
        {
            var r = Jd.TNoticeService.NoticePageTable(model,search);
            return JResult(r);
        }
        /// <summary>
        /// 公告详情
        /// </summary>
        /// <returns></returns>
        public ActionResult ReadJdTNotice(decimal?id)
        {
            var r = Jd.TNoticeService.ViewByPk(id);
            return JResult(r);
        }
        /// <summary>
        /// 新增公告
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public ActionResult CreateJdTNotice(T_NOTICE notice)
        {
            var r = Jd.TNoticeService.CreateNotice(notice);
            return JResult(r);
        }
        /// <summary>
        /// 编辑公告
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public ActionResult UpdateJdTNotice(T_NOTICE notice)
        {
            var r = Jd.TNoticeService.UpdateNotice(notice);
            return JResult(r);
        }
        /// <summary>
        /// 删除公告
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteJdTNotice(string ids)
        {
            var r = Jd.TNoticeService.Delete(ids);
            return JResult(r);
        }
        #endregion
        #region

        #endregion

        #endregion

        #region 用户管理

        #region 注册用户查询

        /// <summary>
        /// 注册用户查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult RegisterUser(T_USER model, SearchCondition search)
        {
            var r = Jd.TUserService.RegisterUser(model, search);
            return JResult(r);
        }

        #endregion

        #region 组织机构 监督行业JDSYSDIC2002 行业类型 JDSYSDIC76

        /// <summary>
        /// 监督平台组织机构树
        /// </summary>
        /// <returns></returns>
        public ActionResult DepartmentTree()
        {
            var r = Jd.TUserDepartmentService.DepartmentTree();
            return JResult(r);
        }

        /// <summary>
        /// 读取T_USER_DEPARTMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadJdUserDepartments(T_USER_DEPARTMENT model, SearchCondition condition)
        {
            var result = Jd.TUserDepartmentService.PageTableList(model, condition);
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER_DEPARTMENT明细
        /// </summary>
        /// <param name="DEPID">单位ID</param>
        /// <returns></returns>
        /// <returns></returns>
        public ActionResult ReadJdUserDepartment(decimal DEPID)

        {
            var result = Jd.TUserDepartmentService.ReadJdUserDepartment(DEPID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER_DEPARTMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateJdUserDepartment(TUserDepartment model)
        {
            var result = Jd.TUserDepartmentService.CreateJdUserDepartment(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER_DEPARTMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateJdUserDepartment(TUserDepartment model)
        {
            var result = Jd.TUserDepartmentService.UpdateJdUserDepartment(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER_DEPARTMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteJdUserDepartment(string ids)
        {
            var result = Jd.TUserDepartmentService.Delete(ids);
            return JResult(result);
        }
        /// <summary>
        /// 监督行业
        /// </summary>
        /// <returns></returns>
        public ActionResult GetHYTypeZtree()
        {
            var r = Jd.SysDicService.GetSysDicTree2("2002");
            return JResult(r);
        }
        /// <summary>
        /// 监管部门
        /// </summary>
        /// <returns></returns>
        public ActionResult GetJGBMZtree()
        {
            var r = Jd.SysDicService.GetJGBMZtree();
            return JResult(r);
        }
        #endregion

        #region 用户管理

        /// <summary>
        /// 读取T_USER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadJdUsers(T_USER model, SearchCondition condition)
        {
            var result = Jd.TUserService.PageTable(model, condition);
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER明细
        /// </summary>
        /// <param name="model">ID</param>
        /// <returns></returns>
        /// <returns></returns>
        public ActionResult ReadJdUser(T_USER model)

        {
            var result = Jd.TUserService.ReadJdUser(model);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateJdUser(JdUserModel model)
        {
            var result = Jd.TUserService.CreateJdUser(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateJdUser(JdUserModel model)
        {
            var result = Jd.TUserService.UpdateJdUser(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteJdUser(string ids)
        {
            var result = Jd.TUserService.Delete(ids);
            return JResult(result);
        }

        /// <summary>
        /// 密码重置
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ResetJdPwd(T_USER model)
        {
            var result = Jd.TUserService.ResetPwd(model);
            return JResult(result);
        }
        #endregion

        #endregion


        #region 项目报建维护

        #region 报建项目信息

        /// <summary>
        /// 项目报建维护-报建项目信息列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult AfcProjectList(T_AFC_PROJECT model, SearchCondition search)
        {
            var r = Jd.TAfcProjectService.AfcProjectPageTable(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 删除招标项目
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public ActionResult DeleteAfcProject(string mid)
        {
            var r = Jd.TAfcProjectService.Delete(mid);
            return JResult(r);
        }
        /// <summary>
        /// 项目报建用户列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult AfcUserList(T_USER model, SearchCondition search)
        {
            var r = Jd.TUserService.AfcProjectUserList(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 获取审查单位接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult FindSpDepartment(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var r = Jd.TUserDepartmentService.FindSpDepartment(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 更新报建用户信息和审查单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAfcProjectUserAndSpDepartment(T_AFC_PROJECT model)
        {
            var r = Jd.TAfcProjectService.UpdateAfcProjectInfo(model);
            return JResult(r);
        }
        #endregion

        #region 报建项目日志

        /// <summary>
        /// 项目报建维护-报建项目日志列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult AfcLogList(T_AFC_LOG model, SearchCondition search)
        {
            var r = Jd.TAfcLogService.AfcLogPageTable(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 删除报建日志
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public ActionResult DeleteAfcLog(string mid)
        {
            var r = Jd.TAfcLogService.Delete(mid);
            return JResult(r);
        }
        /// <summary>
        /// 更新报建用户信息和审查单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAfcLogInfo(T_AFC_LOG model)
        {
            var r = Jd.TAfcLogService.UpdateAfcLogInfo(model);
            return JResult(r);
        }
        #endregion

        #endregion

        /// <summary>
        /// 根据角色信息读取用户列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="RoleName"></param>
        /// <param name="DeptName"></param>
        /// <param name="AreaCode"></param>
        /// <returns></returns>
        public ActionResult ReadUsersByRole(SearchCondition search, string RoleName = "纪委监委",
            string DeptName = "",string AreaCode = "")
        {
            var result = Jd.TUserService.PageTableByRoleName(search, DeptName, AreaCode, RoleName);
            return JResult(result);
        }
        /// <summary>
        /// 根据角色名称读取部门列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="RoleName"></param>
        /// <param name="DeptName"></param>
        /// <param name="AreaCode"></param>
        /// <returns></returns>
        public ActionResult ReadDepartByRole(SearchCondition search, string RoleName = "纪委监委",
          string DeptName = "", string AreaCode = "")
        {
            var result = Jd.TUserService.PageTableDepartByRoleName(search, DeptName, AreaCode, RoleName);
            return JResult(result);
        }


        #region 初始化数据

        /// <summary>
        /// 按照二期项目初始化用户角色和组织机构信息
        /// </summary>
        /// <returns></returns>
        public ActionResult InitialUserRoleAndDepartsV2()
        {
            var r = Jd.TUserService.InitialUserRoleAndDepartsV2();
            return JResult(r);
        }
        /// <summary>
        /// 按照二期项目初始化用户组织机构 父级id 归属地 可查看其他组织机构
        /// </summary>
        /// <returns></returns>
        public ActionResult InitialDepartmentParentIdsAndRegionsAndOtherIds()
        {
            var r = Jd.TUserDepartmentService.InitialDepartmentParentIdsAndRegionsAndOtherIds();
            return JResult(r);
        }

        #endregion
    }
}