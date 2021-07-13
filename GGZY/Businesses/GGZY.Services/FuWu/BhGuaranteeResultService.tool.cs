using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhGuaranteeResultService : BaseServiceT<BH_GUARANTEE_RESULT>
    {
        #region 接口实现

        public List<BH_GUARANTEE_RESULT> FindList(BH_GUARANTEE_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BH_GUARANTEE_RESULT> PageList(BH_GUARANTEE_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BH_GUARANTEE_RESULT._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">自增长</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(BH_GUARANTEE_RESULT._.ID == ID);

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
        public GeneralResult Edit(BH_GUARANTEE_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BH_GUARANTEE_RESULT entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.ORDER_ID = model.ORDER_ID;
                    entity.SERVICE_BEGIN_TIME = model.SERVICE_BEGIN_TIME;
                    entity.SERVICE_END_TIME = model.SERVICE_END_TIME;
                    entity.BID_BOND = model.BID_BOND;
                    entity.AMOUNT = model.AMOUNT;
                    entity.RATE = model.RATE;
                    entity.GUARANTEE_NO = model.GUARANTEE_NO;
                    entity.PAY_ACCOUNT = model.PAY_ACCOUNT;
                    entity.PAY_TYPE = model.PAY_TYPE;
                    entity.AUDIT_TYPE = model.AUDIT_TYPE;
                    entity.AUDIT_REMARK = model.AUDIT_REMARK;
                    entity.GUARANTEE_FILE_NAME = model.GUARANTEE_FILE_NAME;
                    entity.GUARANTEE_PDF_MD5 = model.GUARANTEE_PDF_MD5;
                    entity.GUARANTEE_PDF_URL = model.GUARANTEE_PDF_URL;
                    entity.SECRET = model.SECRET;
                    entity.M_DATA_KEY = model.M_DATA_KEY;
                    entity.GUARANTEE_SOURCE_URL = model.GUARANTEE_SOURCE_URL;
                    entity.GUARANTEE_SOURCE_MD5 = model.GUARANTEE_SOURCE_MD5;
                    entity.GUARANTEE_SOURCE_CATYPE = model.GUARANTEE_SOURCE_CATYPE;
                    entity.CREATE_TIME = model.CREATE_TIME;
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
        public GeneralResult Add(BH_GUARANTEE_RESULT model)
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
                    Delete(BH_GUARANTEE_RESULT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BH_GUARANTEE_RESULT> model)
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
        protected WhereClipBuilder ConditionBuilder(BH_GUARANTEE_RESULT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
#pragma warning disable CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            if (model.ID != null)
#pragma warning restore CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(BH_GUARANTEE_RESULT._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ORDER_ID))
            {
                condition.And(BH_GUARANTEE_RESULT._.ORDER_ID.Contain(model.ORDER_ID));
            }
            if (model.SERVICE_BEGIN_TIME != null)
            {
                condition.And(BH_GUARANTEE_RESULT._.SERVICE_BEGIN_TIME == (model.SERVICE_BEGIN_TIME));
            }
            if (model.SERVICE_END_TIME != null)
            {
                condition.And(BH_GUARANTEE_RESULT._.SERVICE_END_TIME == (model.SERVICE_END_TIME));
            }
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
            if (model.BID_BOND != null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(BH_GUARANTEE_RESULT._.BID_BOND == (model.BID_BOND));
            }
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
            if (model.AMOUNT != null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(BH_GUARANTEE_RESULT._.AMOUNT == (model.AMOUNT));
            }
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
            if (model.RATE != null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(BH_GUARANTEE_RESULT._.RATE == (model.RATE));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_NO))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_NO.Contain(model.GUARANTEE_NO));
            }
            if (!string.IsNullOrWhiteSpace(model.PAY_ACCOUNT))
            {
                condition.And(BH_GUARANTEE_RESULT._.PAY_ACCOUNT.Contain(model.PAY_ACCOUNT));
            }
            if (!string.IsNullOrWhiteSpace(model.PAY_TYPE))
            {
                condition.And(BH_GUARANTEE_RESULT._.PAY_TYPE.Contain(model.PAY_TYPE));
            }
#pragma warning disable CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            if (model.AUDIT_TYPE != null)
#pragma warning restore CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(BH_GUARANTEE_RESULT._.AUDIT_TYPE == (model.AUDIT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.AUDIT_REMARK))
            {
                condition.And(BH_GUARANTEE_RESULT._.AUDIT_REMARK.Contain(model.AUDIT_REMARK));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_FILE_NAME))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_FILE_NAME.Contain(model.GUARANTEE_FILE_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_PDF_MD5))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_PDF_MD5.Contain(model.GUARANTEE_PDF_MD5));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_PDF_URL))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_PDF_URL.Contain(model.GUARANTEE_PDF_URL));
            }
            if (!string.IsNullOrWhiteSpace(model.SECRET))
            {
                condition.And(BH_GUARANTEE_RESULT._.SECRET.Contain(model.SECRET));
            }
            if (!string.IsNullOrWhiteSpace(model.M_DATA_KEY))
            {
                condition.And(BH_GUARANTEE_RESULT._.M_DATA_KEY.Contain(model.M_DATA_KEY));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_SOURCE_URL))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_SOURCE_URL.Contain(model.GUARANTEE_SOURCE_URL));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_SOURCE_MD5))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_SOURCE_MD5.Contain(model.GUARANTEE_SOURCE_MD5));
            }
            if (!string.IsNullOrWhiteSpace(model.GUARANTEE_SOURCE_CATYPE))
            {
                condition.And(BH_GUARANTEE_RESULT._.GUARANTEE_SOURCE_CATYPE.Contain(model.GUARANTEE_SOURCE_CATYPE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BH_GUARANTEE_RESULT._.CREATE_TIME == (model.CREATE_TIME));
            }
            return condition;
        }
        #endregion
    }
}