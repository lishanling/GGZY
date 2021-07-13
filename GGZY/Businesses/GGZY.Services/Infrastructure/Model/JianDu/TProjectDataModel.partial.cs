using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TProjectDataModel
    {
        /// <summary>
        /// 所属环节名称 T_TP_TACHE
        /// </summary>
        public string TACHE_NAME { get; set; }
        /// <summary>
        /// 所属环节 T_TP_TACHE
        /// </summary>
        public string TACHE_CODE { get; set; }
        /// <summary>
        /// 监督点类型 T_MP_PLAN_INFO
        /// </summary>
        public string KIND { get; set; }
        public string KIND_TEXT { get; set; }
        /// <summary>
        /// 监督点名称 T_MP_PLAN_INFO
        /// </summary>
        public string MPNAME { get; set; }
        /// <summary>
        /// 监督点ID T_MP_PLAN_INFO
        /// </summary>
        public string MPID { get; set; }
        /// <summary>
        /// 监督方式 T_MP_PLAN_INFO
        /// </summary>
        public string ISUSER { get; set; }
        /// <summary>
        /// 监督点ID T_MP_PLAN_INFO
        /// </summary>
        public List<string> MPIDS { get; set; }
        /// <summary>
        /// 监督点状态 T_PM_JDINFO
        /// </summary>
        public string LEVEL_TYPE { get; set; }
        /// <summary>
        /// 监督点状态 T_PM_JDINFO
        /// </summary>
        public string LEVEL_TYPE_TEXT { get; set; }

        public string PROJECT_TYPE_TEXT { get; set; }
        public string PROJECT_CATEGORY_TEXT { get; set; }
        public string PROJECT_CATEGORY_KIND { get; set; }
        public string REGION_CODE_TEXT { get; set; }

        /// <summary>
        ///  修改时间 T_PM_JDINFO._.UPDATE_TM
        /// </summary>

        public DateTime? UPDATE_TM { get; set; }

        public string AREANAME { get; set; }

        #region Utils
        public WhereClipBuilder ConditionBuilder(SearchCondition search = null)
        {
            WhereClipBuilder condition = new WhereClipBuilder();

            #region MyRegion

            if (this.ID != null)
            {
                condition.And(T_PROJECT_DATA._.ID == (this.ID));
            }
            if (!string.IsNullOrWhiteSpace(this.BUSINESSID))
            {
                condition.And(T_PROJECT_DATA._.BUSINESSID.Contain(this.BUSINESSID));
            }
            if (!string.IsNullOrWhiteSpace(this.TP_CODE))
            {
                condition.And(T_PROJECT_DATA._.TP_CODE.Contain(this.TP_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_CODE))
            {
                condition.And(T_PROJECT_DATA._.PROJECT_CODE.Contain(this.PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_NAME))
            {
                condition.And(T_PROJECT_DATA._.PROJECT_NAME.Contain(this.PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_TYPE))
            {
                condition.And(T_PROJECT_DATA._.PROJECT_TYPE == (this.PROJECT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(this.REGION_CODE))
            {
                if (REGION_CODE.Equals("350128"))
                {
                    condition.And(T_PROJECT_DATA._.REGION_CODE == (this.REGION_CODE));
                }
                else
                {
                    var sub = REGION_CODE.MaxSubString(4);
                    condition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(sub) && T_PROJECT_DATA._.REGION_CODE != (this.REGION_CODE));
                }
            }
            if (this.CREATE_TIME != null)
            {
                condition.And(T_PROJECT_DATA._.CREATE_TIME == (this.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(this.PLATFORM_NAME))
            {
                condition.And(T_PROJECT_DATA._.PLATFORM_NAME.Contain(this.PLATFORM_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.PLATFORM_CODE))
            {
                condition.And(T_PROJECT_DATA._.PLATFORM_CODE.Contain(this.PLATFORM_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.OWNER_NAME))
            {
                condition.And(T_PROJECT_DATA._.OWNER_NAME.Contain(this.OWNER_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.AGENCY_NAME))
            {
                condition.And(T_PROJECT_DATA._.AGENCY_NAME.Contain(this.AGENCY_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.AGENCY_CODE))
            {
                condition.And(T_PROJECT_DATA._.AGENCY_CODE.Contain(this.AGENCY_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.SUPERVISE_DEPT_NAME))
            {
                condition.And(T_PROJECT_DATA._.SUPERVISE_DEPT_NAME.Contain(this.SUPERVISE_DEPT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.SUPERVISE_DEPT_CODE))
            {
                condition.And(T_PROJECT_DATA._.SUPERVISE_DEPT_CODE.Contain(this.SUPERVISE_DEPT_CODE));
            }
            if (this.IS_FINISH != null)
            {
                condition.And(T_PROJECT_DATA._.IS_FINISH == (this.IS_FINISH));
            }
            if (this.BROWSE_NUM != null)
            {
                condition.And(T_PROJECT_DATA._.BROWSE_NUM == (this.BROWSE_NUM));
            }
            if (this.T_TM != null)
            {
                condition.And(T_PROJECT_DATA._.T_TM == (this.T_TM));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_CATEGORY))
            {
                condition.And(T_PROJECT_DATA._.PROJECT_CATEGORY.Contain(this.PROJECT_CATEGORY));
            }
            if (!string.IsNullOrWhiteSpace(this.IN_NODE))
            {
                condition.And(T_PROJECT_DATA._.IN_NODE.Contain(this.IN_NODE));
            }
            if (this.START_TM != null)
            {
                condition.And(T_PROJECT_DATA._.START_TM == (this.START_TM));
            }
            if (!string.IsNullOrWhiteSpace(this.ERROR_NODES))
            {
                condition.And(T_PROJECT_DATA._.ERROR_NODES.Contain(this.ERROR_NODES));
            }
            if (!string.IsNullOrWhiteSpace(this.TYPE))
            {
                condition.And(T_PROJECT_DATA._.TYPE.Contain(this.TYPE));
            }


            #endregion



            if (search != null)
            {
                if (!string.IsNullOrWhiteSpace(search.KeyWord))
                {
                    condition.And(T_PROJECT_DATA._.PROJECT_CODE.Contain(search.KeyWord) || T_PROJECT_DATA._.PROJECT_NAME.Contain(search.KeyWord));
                }
                if (search.BeginTime.HasValue)
                {
                    condition.And(T_PROJECT_DATA._.CREATE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(T_PROJECT_DATA._.CREATE_TIME <= search.EndTime);
                }
            }

            if (!string.IsNullOrWhiteSpace(TACHE_CODE))//所属环节
            {
                condition.And(T_TP_TACHE._.CODE == TACHE_CODE);
            }
            if (!string.IsNullOrWhiteSpace(KIND))//监督点类型
            {
                condition.And(T_MP_PLAN_INFO._.KIND == KIND);
            }
            if (!string.IsNullOrWhiteSpace(ISUSER))//监督方式
            {
                condition.And(T_MP_PLAN_INFO._.ISUSER == ISUSER);
            }
            if (MPIDS!=null&& MPIDS.Any())//监督点
            {
                condition.And(T_MP_PLAN_INFO._.ID.In(MPIDS));
            }
            if (!string.IsNullOrWhiteSpace(LEVEL_TYPE))//监督点状态
            {
                condition.And(T_PM_JDINFO._.LEVEL_TYPE.Nvl(0) == LEVEL_TYPE);
            }
            return condition;
        }
        #endregion
    }
}