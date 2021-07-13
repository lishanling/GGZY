using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsDepconfigService
    {
        #region 投诉签收设置
        /// <summary>
        /// 添加签收人
        /// </summary>
        /// <param name="uIds"></param>
        /// <returns></returns>
        public GeneralResult AddTsDepConfig(decimal[] uIds)
        {
            var r = new GeneralResult();
            if (uIds == null || !uIds.Any())
            {
                r.SetFail("添加失败,请选择要添加的人员");
            }
            else
            {
                var now = DateTime.Now;
                var jdUserId = JdUser.ID;
                var departId = JdUser.DEPARTID;
                if (Exists(PT_ZXTS_DEPCONFIG._.DEP_ID == departId && PT_ZXTS_DEPCONFIG._.USER_ID.In(uIds)))
                {
                    r.SetFail("添加失败,存在已添加的人员,请重新选择");
                }
                else
                {
                    var models = uIds.Select(c => new PT_ZXTS_DEPCONFIG
                    {
                        ID = 0,
                        USER_ID = c,
                        DEP_ID = departId,
                        CREATE_TM = now,
                        CREATE_BY = jdUserId,
                    });
                    Insert(models);
                    r.SetSuccess();
                }
            }
            return r;
        }
        /// <summary>
        /// 移除签收人
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GeneralResult RemoveTsDepConfig(decimal id)
        {
            var r = new GeneralResult();
            var departId = JdUser.DEPARTID;
            var dbEntity = FirstOrNull(PT_ZXTS_DEPCONFIG._.ID == id && PT_ZXTS_DEPCONFIG._.DEP_ID == departId);
            if (dbEntity == null)
            {
                r.SetFail("未找到对应的签收人信息");
            }
            else
            {
                Delete(dbEntity);
                r.SetSuccess();
            }
            return r;
        }

        /// <summary>
        /// 签收人列表
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult TsDepConfigList(SearchCondition search)
        {
            var departId = JdUser.DEPARTID;
            var condition = new WhereClipBuilder(PT_ZXTS_DEPCONFIG._.DEP_ID == departId);
            if (string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(T_USER._.MANAGE_NAME.Contain(search.KeyWord) || T_USER_DEPARTMENT._.DNAME.Contain(search.KeyWord));
            }

            var query = FromWhere(condition.ToWhereClip())
                .LeftJoin<T_USER>(T_USER._.ID == PT_ZXTS_DEPCONFIG._.USER_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS_DEPCONFIG._.DEP_ID);
            var total = query.Count();
            var list = query.OrderBy(PT_ZXTS_DEPCONFIG._.ID.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    T_USER._.MANAGE_NAME
                    , T_USER._.PHONE
                    , T_USER._.TELPHONE
                    , T_USER_DEPARTMENT._.DNAME
                    , PT_ZXTS_DEPCONFIG._.ID
                    , PT_ZXTS_DEPCONFIG._.USER_ID
                    , PT_ZXTS_DEPCONFIG._.DEP_ID
                ).ToList<object>();
            var pageList = list.ToPageTableResult(search, total);
            return pageList;

        }
        /// <summary>
        /// 是否有签收权限
        /// </summary>
        /// <returns></returns>
        public bool HasReceiptPermission()
        {
            var departId = JdUser.DEPARTID;
            var jdUserId = JdUser.ID;
            return Exists(PT_ZXTS_DEPCONFIG._.DEP_ID == departId && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId);
        }
        #endregion
    }
}