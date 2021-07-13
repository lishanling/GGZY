using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJH.DbEntity;

namespace GGZY.Services.ZBCG
{
    public partial class ZpResultService : BaseServiceT<ZP_RESULT>
    {
        #region 接口实现

        public List<ZP_RESULT> FindList(ZP_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZP_RESULT> PageList(ZP_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, ZP_RESULT._.ZR_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ZR_ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ZR_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(ZP_RESULT._.ZR_ID == ZR_ID);

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
        public GeneralResult Edit(ZP_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ZR_ID);

                if (viewResult.Success && viewResult.Data is ZP_RESULT entity)
                {
                    entity.Attach();
                    entity.ZR_ID = model.ZR_ID;
                    entity.ZR_UNIT = model.ZR_UNIT;
                    entity.ZR_ADDRESS = model.ZR_ADDRESS;
                    entity.ZR_NAME = model.ZR_NAME;
                    entity.ZR_PHONE = model.ZR_PHONE;
                    entity.ZR_POST = model.ZR_POST;
                    entity.ZR_FAX = model.ZR_FAX;
                    entity.ZR_EMAIL = model.ZR_EMAIL;
                    entity.ZR_BID = model.ZR_BID;
                    entity.ZR_CODE = model.ZR_CODE;
                    entity.ZR_TITLE = model.ZR_TITLE;
                    entity.ZR_ZUNIT = model.ZR_ZUNIT;
                    entity.ZR_QUOTE = model.ZR_QUOTE;
                    entity.ZR_INDUSTRY = model.ZR_INDUSTRY;
                    entity.ZR_PROXY = model.ZR_PROXY;
                    entity.ZR_CONTENT = model.ZR_CONTENT;
                    entity.CRTIME = model.CRTIME;
                    entity.ZR_GOV = model.ZR_GOV;
                    entity.ZR_EDITTIME = model.ZR_EDITTIME;
                    entity.ZR_STATE = model.ZR_STATE;
                    entity.ZR_USERID = model.ZR_USERID;
                    entity.ZR_TYPE = model.ZR_TYPE;
                    entity.ZR_TAG = model.ZR_TAG;
                    entity.ZN_ZJLY_YZ = model.ZN_ZJLY_YZ;
                    entity.ZN_ZJLY_SK = model.ZN_ZJLY_SK;
                    entity.ZN_ZJLY_QT = model.ZN_ZJLY_QT;
                    entity.ZN_GSQ_KSSJ = model.ZN_GSQ_KSSJ;
                    entity.ZN_GSQ_JZSJ = model.ZN_GSQ_JZSJ;
                    entity.ZR_QUOTES = model.ZR_QUOTES;
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
        public GeneralResult Add(ZP_RESULT model)
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
                    Delete(ZP_RESULT._.ZR_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZP_RESULT> model)
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
        protected WhereClipBuilder ConditionBuilder(ZP_RESULT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ZR_ID != null)
            {
                condition.And(ZP_RESULT._.ZR_ID == (model.ZR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_UNIT))
            {
                condition.And(ZP_RESULT._.ZR_UNIT.Contain(model.ZR_UNIT));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_ADDRESS))
            {
                condition.And(ZP_RESULT._.ZR_ADDRESS.Contain(model.ZR_ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_NAME))
            {
                condition.And(ZP_RESULT._.ZR_NAME.Contain(model.ZR_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_PHONE))
            {
                condition.And(ZP_RESULT._.ZR_PHONE.Contain(model.ZR_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_POST))
            {
                condition.And(ZP_RESULT._.ZR_POST.Contain(model.ZR_POST));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_FAX))
            {
                condition.And(ZP_RESULT._.ZR_FAX.Contain(model.ZR_FAX));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_EMAIL))
            {
                condition.And(ZP_RESULT._.ZR_EMAIL.Contain(model.ZR_EMAIL));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_BID))
            {
                condition.And(ZP_RESULT._.ZR_BID.Contain(model.ZR_BID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_CODE))
            {
                condition.And(ZP_RESULT._.ZR_CODE.Contain(model.ZR_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_TITLE))
            {
                condition.And(ZP_RESULT._.ZR_TITLE.Contain(model.ZR_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_ZUNIT))
            {
                condition.And(ZP_RESULT._.ZR_ZUNIT.Contain(model.ZR_ZUNIT));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_QUOTE))
            {
                condition.And(ZP_RESULT._.ZR_QUOTE.Contain(model.ZR_QUOTE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_INDUSTRY))
            {
                condition.And(ZP_RESULT._.ZR_INDUSTRY.Contain(model.ZR_INDUSTRY));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_PROXY))
            {
                condition.And(ZP_RESULT._.ZR_PROXY.Contain(model.ZR_PROXY));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_CONTENT))
            {
                condition.And(ZP_RESULT._.ZR_CONTENT.Contain(model.ZR_CONTENT));
            }
            if (model.CRTIME != null)
            {
                condition.And(ZP_RESULT._.CRTIME == (model.CRTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_GOV))
            {
                condition.And(ZP_RESULT._.ZR_GOV.Contain(model.ZR_GOV));
            }
            if (model.ZR_EDITTIME != null)
            {
                condition.And(ZP_RESULT._.ZR_EDITTIME == (model.ZR_EDITTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_STATE))
            {
                condition.And(ZP_RESULT._.ZR_STATE.Contain(model.ZR_STATE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_USERID))
            {
                condition.And(ZP_RESULT._.ZR_USERID.Contain(model.ZR_USERID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_TYPE))
            {
                condition.And(ZP_RESULT._.ZR_TYPE.Contain(model.ZR_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZR_TAG))
            {
                condition.And(ZP_RESULT._.ZR_TAG.Contain(model.ZR_TAG));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZJLY_YZ))
            {
                condition.And(ZP_RESULT._.ZN_ZJLY_YZ.Contain(model.ZN_ZJLY_YZ));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZJLY_SK))
            {
                condition.And(ZP_RESULT._.ZN_ZJLY_SK.Contain(model.ZN_ZJLY_SK));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_ZJLY_QT))
            {
                condition.And(ZP_RESULT._.ZN_ZJLY_QT.Contain(model.ZN_ZJLY_QT));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_GSQ_KSSJ))
            {
                condition.And(ZP_RESULT._.ZN_GSQ_KSSJ.Contain(model.ZN_GSQ_KSSJ));
            }
            if (!string.IsNullOrWhiteSpace(model.ZN_GSQ_JZSJ))
            {
                condition.And(ZP_RESULT._.ZN_GSQ_JZSJ.Contain(model.ZN_GSQ_JZSJ));
            }
            if (model.ZR_QUOTES != null)
            {
                condition.And(ZP_RESULT._.ZR_QUOTES == (model.ZR_QUOTES));
            }
            return condition;
        }
        #endregion
    }
}