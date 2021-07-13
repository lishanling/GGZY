using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJH.DbEntity;

namespace GGZY.Services.ZBCG
{
    public partial class ZpNoticeService : BaseServiceT<ZP_NOTICE>
    {
        #region 接口实现

        public List<ZP_NOTICE> FindList(ZP_NOTICE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZP_NOTICE> PageList(ZP_NOTICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, ZP_NOTICE._.ZN_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ZN_ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ZN_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(ZP_NOTICE._.ZN_ID == ZN_ID);

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
        public GeneralResult Edit(ZP_NOTICE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ZN_ID);

                if (viewResult.Success && viewResult.Data is ZP_NOTICE entity)
                {
                    entity.Attach();
                    entity.ZN_ID = model.ZN_ID;
                    entity.ZN_UNITNAME = model.ZN_UNITNAME;
                    entity.ZN_ADDRESS = model.ZN_ADDRESS;
                    entity.ZN_NAME = model.ZN_NAME;
                    entity.ZN_PHONE = model.ZN_PHONE;
                    entity.ZN_POST = model.ZN_POST;
                    entity.ZN_FAX = model.ZN_FAX;
                    entity.ZN_EMAIL = model.ZN_EMAIL;
                    entity.ZN_ZID = model.ZN_ZID;
                    entity.ZN_INDUSTRY = model.ZN_INDUSTRY;
                    entity.ZN_OPENTIME = model.ZN_OPENTIME;
                    entity.ZN_BEACONTYPE = model.ZN_BEACONTYPE;
                    entity.ZN_MONEY = model.ZN_MONEY;
                    entity.ZN_WAY = model.ZN_WAY;
                    entity.ZN_TITLE = model.ZN_TITLE;
                    entity.ZN_PROXY = model.ZN_PROXY;
                    entity.ZN_USERNAME = model.ZN_USERNAME;
                    entity.ZN_AREA = model.ZN_AREA;
                    entity.ZN_KEY = model.ZN_KEY;
                    entity.ZN_GOV = model.ZN_GOV;
                    entity.ZN_CONTENT = model.ZN_CONTENT;
                    entity.ZN_TIME = model.ZN_TIME;
                    entity.ZN_STATE = model.ZN_STATE;
                    entity.ZN_EDITTIME = model.ZN_EDITTIME;
                    entity.ZN_USERID = model.ZN_USERID;
                    entity.CRTIME = model.CRTIME;
                    entity.ZN_ESTATE = model.ZN_ESTATE;
                    entity.ZN_OESTATE = model.ZN_OESTATE;
                    entity.ZN_ENAME = model.ZN_ENAME;
                    entity.ZN_ZRSTATE = model.ZN_ZRSTATE;
                    entity.ZN_ZRSTATE1 = model.ZN_ZRSTATE1;
                    entity.ZN_TAG = model.ZN_TAG;
                    entity.ZN_LXPW = model.ZN_LXPW;
                    entity.ZN_PBSJ = model.ZN_PBSJ;
                    entity.ZN_BMSJ = model.ZN_BMSJ;
                    entity.ZN_JZSJ = model.ZN_JZSJ;
                    entity.ZN_ZJLY_YZ = model.ZN_ZJLY_YZ;
                    entity.ZN_ZJLY_SK = model.ZN_ZJLY_SK;
                    entity.ZN_ZJLY_QT = model.ZN_ZJLY_QT;
                    entity.ZR_N_TIME = model.ZR_N_TIME;
                    entity.ZR_R_TIME = model.ZR_R_TIME;
                    entity.ZN_PERSON_NAME = model.ZN_PERSON_NAME;
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
        public GeneralResult Add(ZP_NOTICE model)
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
                    Delete(ZP_NOTICE._.ZN_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZP_NOTICE> model)
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
        protected WhereClipBuilder ConditionBuilder(ZP_NOTICE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ZN_ID != null)
            {
                condition.And(ZP_NOTICE._.ZN_ID == (model.ZN_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_UNITNAME))
            {
                condition.And(ZP_NOTICE._.ZN_UNITNAME.Contain(model.ZN_UNITNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ADDRESS))
            {
                condition.And(ZP_NOTICE._.ZN_ADDRESS.Contain(model.ZN_ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_NAME))
            {
                condition.And(ZP_NOTICE._.ZN_NAME.Contain(model.ZN_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_PHONE))
            {
                condition.And(ZP_NOTICE._.ZN_PHONE.Contain(model.ZN_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_POST))
            {
                condition.And(ZP_NOTICE._.ZN_POST.Contain(model.ZN_POST));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_FAX))
            {
                condition.And(ZP_NOTICE._.ZN_FAX.Contain(model.ZN_FAX));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_EMAIL))
            {
                condition.And(ZP_NOTICE._.ZN_EMAIL.Contain(model.ZN_EMAIL));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZID))
            {
                condition.And(ZP_NOTICE._.ZN_ZID.Contain(model.ZN_ZID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_INDUSTRY))
            {
                condition.And(ZP_NOTICE._.ZN_INDUSTRY.Contain(model.ZN_INDUSTRY));
            }
            if (model.ZN_OPENTIME != null)
            {
                condition.And(ZP_NOTICE._.ZN_OPENTIME == (model.ZN_OPENTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_BEACONTYPE))
            {
                condition.And(ZP_NOTICE._.ZN_BEACONTYPE.Contain(model.ZN_BEACONTYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_MONEY))
            {
                condition.And(ZP_NOTICE._.ZN_MONEY.Contain(model.ZN_MONEY));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_WAY))
            {
                condition.And(ZP_NOTICE._.ZN_WAY.Contain(model.ZN_WAY));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_TITLE))
            {
                condition.And(ZP_NOTICE._.ZN_TITLE.Contain(model.ZN_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_PROXY))
            {
                condition.And(ZP_NOTICE._.ZN_PROXY.Contain(model.ZN_PROXY));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_USERNAME))
            {
                condition.And(ZP_NOTICE._.ZN_USERNAME.Contain(model.ZN_USERNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_AREA))
            {
                condition.And(ZP_NOTICE._.ZN_AREA.Contain(model.ZN_AREA));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_KEY))
            {
                condition.And(ZP_NOTICE._.ZN_KEY.Contain(model.ZN_KEY));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_GOV))
            {
                condition.And(ZP_NOTICE._.ZN_GOV.Contain(model.ZN_GOV));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_CONTENT))
            {
                condition.And(ZP_NOTICE._.ZN_CONTENT.Contain(model.ZN_CONTENT));
            }
            if (model.ZN_TIME != null)
            {
                condition.And(ZP_NOTICE._.ZN_TIME == (model.ZN_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_STATE))
            {
                condition.And(ZP_NOTICE._.ZN_STATE.Contain(model.ZN_STATE));
            }
            if (model.ZN_EDITTIME != null)
            {
                condition.And(ZP_NOTICE._.ZN_EDITTIME == (model.ZN_EDITTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_USERID))
            {
                condition.And(ZP_NOTICE._.ZN_USERID.Contain(model.ZN_USERID));
            }
            if (model.CRTIME != null)
            {
                condition.And(ZP_NOTICE._.CRTIME == (model.CRTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ESTATE))
            {
                condition.And(ZP_NOTICE._.ZN_ESTATE.Contain(model.ZN_ESTATE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_OESTATE))
            {
                condition.And(ZP_NOTICE._.ZN_OESTATE.Contain(model.ZN_OESTATE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ENAME))
            {
                condition.And(ZP_NOTICE._.ZN_ENAME.Contain(model.ZN_ENAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZRSTATE))
            {
                condition.And(ZP_NOTICE._.ZN_ZRSTATE.Contain(model.ZN_ZRSTATE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZRSTATE1))
            {
                condition.And(ZP_NOTICE._.ZN_ZRSTATE1.Contain(model.ZN_ZRSTATE1));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_TAG))
            {
                condition.And(ZP_NOTICE._.ZN_TAG.Contain(model.ZN_TAG));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_LXPW))
            {
                condition.And(ZP_NOTICE._.ZN_LXPW.Contain(model.ZN_LXPW));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_PBSJ))
            {
                condition.And(ZP_NOTICE._.ZN_PBSJ.Contain(model.ZN_PBSJ));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_BMSJ))
            {
                condition.And(ZP_NOTICE._.ZN_BMSJ.Contain(model.ZN_BMSJ));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_JZSJ))
            {
                condition.And(ZP_NOTICE._.ZN_JZSJ.Contain(model.ZN_JZSJ));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZJLY_YZ))
            {
                condition.And(ZP_NOTICE._.ZN_ZJLY_YZ.Contain(model.ZN_ZJLY_YZ));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZJLY_SK))
            {
                condition.And(ZP_NOTICE._.ZN_ZJLY_SK.Contain(model.ZN_ZJLY_SK));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZJLY_QT))
            {
                condition.And(ZP_NOTICE._.ZN_ZJLY_QT.Contain(model.ZN_ZJLY_QT));
            }
            if (model.ZR_N_TIME != null)
            {
                condition.And(ZP_NOTICE._.ZR_N_TIME == (model.ZR_N_TIME));
            }
            if (model.ZR_R_TIME != null)
            {
                condition.And(ZP_NOTICE._.ZR_R_TIME == (model.ZR_R_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_PERSON_NAME))
            {
                condition.And(ZP_NOTICE._.ZN_PERSON_NAME.Contain(model.ZN_PERSON_NAME));
            }
            return condition;
        }
        #endregion
    }
}