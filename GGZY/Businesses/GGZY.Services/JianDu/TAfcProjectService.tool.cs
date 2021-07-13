using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcProjectService : BaseServiceT<T_AFC_PROJECT>
    {
        #region 接口实现

        public List<T_AFC_PROJECT> FindList(T_AFC_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_AFC_PROJECT> PageList(T_AFC_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_AFC_PROJECT._.TM.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_AFC_PROJECT._.ID == ID);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Edit(T_AFC_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is T_AFC_PROJECT entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.CODE = model.CODE;
                    entity.TZ_CODE = model.TZ_CODE;
                    entity.PROJECT_CODE = model.PROJECT_CODE;
                    entity.PROJECT_NAME = model.PROJECT_NAME;
                    entity.PROJECT_TYPE = model.PROJECT_TYPE;
                    entity.PROJECT_ADDRESS = model.PROJECT_ADDRESS;
                    entity.REGION_CITY = model.REGION_CITY;
                    entity.REGION_COUNTY = model.REGION_COUNTY;
                    entity.JS_DEP = model.JS_DEP;
                    entity.JS_LEGAL_PERSON = model.JS_LEGAL_PERSON;
                    entity.JS_CODE = model.JS_CODE;
                    entity.JS_CODE_AIDS = model.JS_CODE_AIDS;
                    entity.UNIT_ADDRESS = model.UNIT_ADDRESS;
                    entity.MANAGER = model.MANAGER;
                    entity.MANAGER_PHONE = model.MANAGER_PHONE;
                    entity.APPROVAL_NAME = model.APPROVAL_NAME;
                    entity.APPROVAL_AIDS = model.APPROVAL_AIDS;
                    entity.APPROVAL_NUMBER = model.APPROVAL_NUMBER;
                    entity.APPROVAL_AUTHORITY = model.APPROVAL_AUTHORITY;
                    entity.GCGMJNR = model.GCGMJNR;
                    entity.TOTAL_INVEST = model.TOTAL_INVEST;
                    entity.TOTAL_INVEST_JA = model.TOTAL_INVEST_JA;
                    entity.FUND_SOURCE = model.FUND_SOURCE;
                    entity.CONTRIBUTION_SCALE_CZ = model.CONTRIBUTION_SCALE_CZ;
                    entity.CONTRIBUTION_SCALE_ZC = model.CONTRIBUTION_SCALE_ZC;
                    entity.CONTRIBUTION_SCALE_QT = model.CONTRIBUTION_SCALE_QT;
                    entity.FBFS_SURVEY = model.FBFS_SURVEY;
                    entity.FBFS_DESIGN = model.FBFS_DESIGN;
                    entity.FBFS_CONSTRUCT = model.FBFS_CONSTRUCT;
                    entity.FBFS_SUPERVISION = model.FBFS_SUPERVISION;
                    entity.FBFS_SBCL = model.FBFS_SBCL;
                    entity.FBFS_CONTRACT = model.FBFS_CONTRACT;
                    entity.TENDER_ORGANIZE_FORM = model.TENDER_ORGANIZE_FORM;
                    entity.IS_DJZ = model.IS_DJZ;
                    entity.REGISTER_AIDS = model.REGISTER_AIDS;
                    entity.OTHER_AIDS = model.OTHER_AIDS;
                    entity.REMARK = model.REMARK;
                    entity.U_ID = model.U_ID;
                    entity.DEP_NAME = model.DEP_NAME;
                    entity.TM = model.TM;
                    entity.APPROVAL_STATE = model.APPROVAL_STATE;
                    entity.APPROVAL_UID = model.APPROVAL_UID;
                    entity.APPROVAL_REMARK = model.APPROVAL_REMARK;
                    entity.APPROVAL_TM = model.APPROVAL_TM;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.APPROVAL_DEPID = model.APPROVAL_DEPID;
                    entity.APPROVAL_TACHE = model.APPROVAL_TACHE;
                    entity.ZBHZYJS_AIDS = model.ZBHZYJS_AIDS;
                    entity.APPROVAL_UNAME = model.APPROVAL_UNAME;
                    entity.APPROVAL_CONTACT_INFORMATION = model.APPROVAL_CONTACT_INFORMATION;
                    entity.KIND = model.KIND;
                    entity.FBFS_CKSJ = model.FBFS_CKSJ;
                    entity.FBFS_SYJC = model.FBFS_SYJC;
                    entity.FBFS_SJZX = model.FBFS_SJZX;
                    entity.FBFS_OTHER = model.FBFS_OTHER;
                    entity.M_DATA_SOURCE = model.M_DATA_SOURCE;
                    entity.OVER_TM = model.OVER_TM;
                    entity.JSXZ = model.JSXZ;
                    entity.GCYT = model.GCYT;
                    entity.ISMAJOR = model.ISMAJOR;
                    entity.CXXMINFO = model.CXXMINFO;
                    entity.JZJNINFO = model.JZJNINFO;
                    entity.APPROVAL_LEVEL = model.APPROVAL_LEVEL;
                    entity.APPROVAL_DATE = model.APPROVAL_DATE;
                    entity.GOVERNMENT_INVEST_FINANCE = model.GOVERNMENT_INVEST_FINANCE;
                    Update(entity);
                    result.SetSuccess(entity);
                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(T_AFC_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
                Insert(model);
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public GeneralResult Delete(params string[] ids)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                List<string> idArr = new List<string>();
                foreach (var id in ids)
                {
                    idArr.AddRange(id.Split(','));
                }

                if (idArr.Any())
                {
                    Delete(T_AFC_PROJECT._.ID.SelectIn(idArr));
                    result.SetSuccess(ids);
                }
                else
                {
                    result.SetFail($"请选择要删除的记录");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<T_AFC_PROJECT> model)
        {
            GeneralResult result = new GeneralResult();
            try
            {

                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }


        #endregion

        #region Utils
        public WhereClipBuilder ConditionBuilder(T_AFC_PROJECT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(T_AFC_PROJECT._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(T_AFC_PROJECT._.CODE.Contain(model.CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TZ_CODE))
            {
                condition.And(T_AFC_PROJECT._.TZ_CODE.Contain(model.TZ_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
            {
                condition.And(T_AFC_PROJECT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(T_AFC_PROJECT._.PROJECT_NAME.Contain(model.PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                if (model.PROJECT_TYPE.Contains(","))
                {
                    var projectTypes = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(T_AFC_PROJECT._.PROJECT_TYPE.In(projectTypes));
                }
                else
                {
                    condition.And(T_AFC_PROJECT._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
                }
            }

            if (!string.IsNullOrWhiteSpace(model.PROJECT_ADDRESS))
            {
                condition.And(T_AFC_PROJECT._.PROJECT_ADDRESS.Contain(model.PROJECT_ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CITY))
            {
                condition.And(T_AFC_PROJECT._.REGION_CITY.Contain(model.REGION_CITY));
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_COUNTY))
            {
                condition.And(T_AFC_PROJECT._.REGION_COUNTY.Contain(model.REGION_COUNTY));
            }
            if (!string.IsNullOrWhiteSpace(model.JS_DEP))
            {
                condition.And(T_AFC_PROJECT._.JS_DEP.Contain(model.JS_DEP));
            }
            if (!string.IsNullOrWhiteSpace(model.JS_LEGAL_PERSON))
            {
                condition.And(T_AFC_PROJECT._.JS_LEGAL_PERSON.Contain(model.JS_LEGAL_PERSON));
            }
            if (!string.IsNullOrWhiteSpace(model.JS_CODE))
            {
                condition.And(T_AFC_PROJECT._.JS_CODE.Contain(model.JS_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.JS_CODE_AIDS))
            {
                condition.And(T_AFC_PROJECT._.JS_CODE_AIDS.Contain(model.JS_CODE_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.UNIT_ADDRESS))
            {
                condition.And(T_AFC_PROJECT._.UNIT_ADDRESS.Contain(model.UNIT_ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.MANAGER))
            {
                condition.And(T_AFC_PROJECT._.MANAGER.Contain(model.MANAGER));
            }
            if (!string.IsNullOrWhiteSpace(model.MANAGER_PHONE))
            {
                condition.And(T_AFC_PROJECT._.MANAGER_PHONE.Contain(model.MANAGER_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_NAME))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_NAME.Contain(model.APPROVAL_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_AIDS))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_AIDS.Contain(model.APPROVAL_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_NUMBER))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_NUMBER.Contain(model.APPROVAL_NUMBER));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_AUTHORITY))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_AUTHORITY.Contain(model.APPROVAL_AUTHORITY));
            }
            if (!string.IsNullOrWhiteSpace(model.GCGMJNR))
            {
                condition.And(T_AFC_PROJECT._.GCGMJNR.Contain(model.GCGMJNR));
            }
            if (model.TOTAL_INVEST != null)
            {
                condition.And(T_AFC_PROJECT._.TOTAL_INVEST == (model.TOTAL_INVEST));
            }
            if (model.TOTAL_INVEST_JA != null)
            {
                condition.And(T_AFC_PROJECT._.TOTAL_INVEST_JA == (model.TOTAL_INVEST_JA));
            }
            if (!string.IsNullOrWhiteSpace(model.FUND_SOURCE))
            {
                condition.And(T_AFC_PROJECT._.FUND_SOURCE.Contain(model.FUND_SOURCE));
            }
            if (model.CONTRIBUTION_SCALE_CZ != null)
            {
                condition.And(T_AFC_PROJECT._.CONTRIBUTION_SCALE_CZ == (model.CONTRIBUTION_SCALE_CZ));
            }
            if (model.CONTRIBUTION_SCALE_ZC != null)
            {
                condition.And(T_AFC_PROJECT._.CONTRIBUTION_SCALE_ZC == (model.CONTRIBUTION_SCALE_ZC));
            }
            if (model.CONTRIBUTION_SCALE_QT != null)
            {
                condition.And(T_AFC_PROJECT._.CONTRIBUTION_SCALE_QT == (model.CONTRIBUTION_SCALE_QT));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_SURVEY))
            {
                condition.And(T_AFC_PROJECT._.FBFS_SURVEY.Contain(model.FBFS_SURVEY));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_DESIGN))
            {
                condition.And(T_AFC_PROJECT._.FBFS_DESIGN.Contain(model.FBFS_DESIGN));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_CONSTRUCT))
            {
                condition.And(T_AFC_PROJECT._.FBFS_CONSTRUCT.Contain(model.FBFS_CONSTRUCT));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_SUPERVISION))
            {
                condition.And(T_AFC_PROJECT._.FBFS_SUPERVISION.Contain(model.FBFS_SUPERVISION));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_SBCL))
            {
                condition.And(T_AFC_PROJECT._.FBFS_SBCL.Contain(model.FBFS_SBCL));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_CONTRACT))
            {
                condition.And(T_AFC_PROJECT._.FBFS_CONTRACT.Contain(model.FBFS_CONTRACT));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
            {
                condition.And(T_AFC_PROJECT._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
            }
            if (model.IS_DJZ != null)
            {
                condition.And(T_AFC_PROJECT._.IS_DJZ == (model.IS_DJZ));
            }
            if (!string.IsNullOrWhiteSpace(model.REGISTER_AIDS))
            {
                condition.And(T_AFC_PROJECT._.REGISTER_AIDS.Contain(model.REGISTER_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.OTHER_AIDS))
            {
                condition.And(T_AFC_PROJECT._.OTHER_AIDS.Contain(model.OTHER_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(T_AFC_PROJECT._.REMARK.Contain(model.REMARK));
            }
            if (model.U_ID != null)
            {
                condition.And(T_AFC_PROJECT._.U_ID == (model.U_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.DEP_NAME))
            {
                condition.And(T_AFC_PROJECT._.DEP_NAME.Contain(model.DEP_NAME));
            }
            if (model.TM != null)
            {
                condition.And(T_AFC_PROJECT._.TM == (model.TM));
            }
            if (model.APPROVAL_STATE != null)
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_STATE == (model.APPROVAL_STATE));
            }
            if (model.APPROVAL_UID != null)
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_UID == (model.APPROVAL_UID));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_REMARK))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_REMARK.Contain(model.APPROVAL_REMARK));
            }
            if (model.APPROVAL_TM != null)
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_TM == (model.APPROVAL_TM));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(T_AFC_PROJECT._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_DEPID))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_DEPID.Contain(model.APPROVAL_DEPID));
            }
            if (model.APPROVAL_TACHE != null)
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_TACHE == (model.APPROVAL_TACHE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZBHZYJS_AIDS))
            {
                condition.And(T_AFC_PROJECT._.ZBHZYJS_AIDS.Contain(model.ZBHZYJS_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_UNAME))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_UNAME.Contain(model.APPROVAL_UNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_CONTACT_INFORMATION))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_CONTACT_INFORMATION.Contain(model.APPROVAL_CONTACT_INFORMATION));
            }
            if (!string.IsNullOrWhiteSpace(model.KIND))
            {
                condition.And(T_AFC_PROJECT._.KIND.Contain(model.KIND));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_CKSJ))
            {
                condition.And(T_AFC_PROJECT._.FBFS_CKSJ.Contain(model.FBFS_CKSJ));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_SYJC))
            {
                condition.And(T_AFC_PROJECT._.FBFS_SYJC.Contain(model.FBFS_SYJC));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_SJZX))
            {
                condition.And(T_AFC_PROJECT._.FBFS_SJZX.Contain(model.FBFS_SJZX));
            }
            if (!string.IsNullOrWhiteSpace(model.FBFS_OTHER))
            {
                condition.And(T_AFC_PROJECT._.FBFS_OTHER.Contain(model.FBFS_OTHER));
            }
            if (!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
            {
                condition.And(T_AFC_PROJECT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
            }
            if (model.OVER_TM != null)
            {
                condition.And(T_AFC_PROJECT._.OVER_TM == (model.OVER_TM));
            }
            if (!string.IsNullOrWhiteSpace(model.JSXZ))
            {
                condition.And(T_AFC_PROJECT._.JSXZ.Contain(model.JSXZ));
            }
            if (!string.IsNullOrWhiteSpace(model.GCYT))
            {
                condition.And(T_AFC_PROJECT._.GCYT.Contain(model.GCYT));
            }
            if (model.ISMAJOR != null)
            {
                condition.And(T_AFC_PROJECT._.ISMAJOR == (model.ISMAJOR));
            }
            if (!string.IsNullOrWhiteSpace(model.CXXMINFO))
            {
                condition.And(T_AFC_PROJECT._.CXXMINFO.Contain(model.CXXMINFO));
            }
            if (!string.IsNullOrWhiteSpace(model.JZJNINFO))
            {
                condition.And(T_AFC_PROJECT._.JZJNINFO.Contain(model.JZJNINFO));
            }
            if (!string.IsNullOrWhiteSpace(model.APPROVAL_LEVEL))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_LEVEL.Contain(model.APPROVAL_LEVEL));
            }
            if (model.APPROVAL_DATE != null)
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_DATE == (model.APPROVAL_DATE));
            }
            if (model.GOVERNMENT_INVEST_FINANCE != null)
            {
                condition.And(T_AFC_PROJECT._.GOVERNMENT_INVEST_FINANCE == (model.GOVERNMENT_INVEST_FINANCE));
            }
            return condition;
        }
        #endregion
    }
}