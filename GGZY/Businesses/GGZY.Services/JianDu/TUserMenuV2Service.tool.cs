using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserMenuV2Service : BaseServiceT<T_USER_MENU_V2>
    {
        #region 接口实现

        public List<T_USER_MENU_V2> FindList(T_USER_MENU_V2 model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER_MENU_V2> PageList(T_USER_MENU_V2 model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_USER_MENU_V2._.MENU_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="MENU_ID">菜单编号</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string MENU_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_USER_MENU_V2._.MENU_ID == MENU_ID);

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
        public GeneralResult Edit(T_USER_MENU_V2 model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.MENU_ID);

                if (viewResult.Success && viewResult.Data is T_USER_MENU_V2 entity)
                {
                    entity.Attach();
                    entity.MENU_ID = model.MENU_ID;
                    entity.PARENT_ID = model.PARENT_ID;
                    entity.NAME = model.NAME;
                    entity.ALIAS = model.ALIAS;
                    entity.ICON = model.ICON;
                    entity.REMARK = model.REMARK;
                    entity.MODULE = model.MODULE;
                    entity.TYPE = model.TYPE;
                    entity.URL = model.URL;
                    entity.PARAMS = model.PARAMS;
                    entity.TARGET = model.TARGET;
                    entity.IS_NAVI = model.IS_NAVI;
                    entity.SORT = model.SORT;
                    entity.STATUS = model.STATUS;
                    entity.MENU_LEVEL = model.MENU_LEVEL;
                    entity.CHILDREN_TOTAL = model.CHILDREN_TOTAL;
                    entity.CREATEDBY = model.CREATEDBY;
                    entity.CREATEDTIME = model.CREATEDTIME;
                    entity.UPDATEDBY = model.UPDATEDBY;
                    entity.UPDATEDTIME = model.UPDATEDTIME;
                    entity.ISSHOW = model.ISSHOW;
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
        public GeneralResult Add(T_USER_MENU_V2 model)
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
                    Delete(T_USER_MENU_V2._.MENU_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER_MENU_V2> model)
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
        protected WhereClipBuilder ConditionBuilder(T_USER_MENU_V2 model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.MENU_ID))
            {
                condition.And(T_USER_MENU_V2._.MENU_ID.Contain(model.MENU_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.PARENT_ID))
            {
                condition.And(T_USER_MENU_V2._.PARENT_ID.Contain(model.PARENT_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(T_USER_MENU_V2._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ALIAS))
            {
                condition.And(T_USER_MENU_V2._.ALIAS.Contain(model.ALIAS));
            }
            if (!string.IsNullOrWhiteSpace(model.ICON))
            {
                condition.And(T_USER_MENU_V2._.ICON.Contain(model.ICON));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(T_USER_MENU_V2._.REMARK.Contain(model.REMARK));
            }
            if (!string.IsNullOrWhiteSpace(model.MODULE))
            {
                if (model.MODULE.Contains(","))
                {
                    var modules = model.MODULE.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(T_USER_MENU_V2._.MODULE.In(modules));
                }
                else
                {
                    condition.And(T_USER_MENU_V2._.MODULE.Contain(model.MODULE));
                }
               
            }
            if (model.TYPE != null)
            {
                condition.And(T_USER_MENU_V2._.TYPE == (model.TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.URL))
            {
                condition.And(T_USER_MENU_V2._.URL.Contain(model.URL));
            }
            if (!string.IsNullOrWhiteSpace(model.PARAMS))
            {
                condition.And(T_USER_MENU_V2._.PARAMS.Contain(model.PARAMS));
            }
            if (!string.IsNullOrWhiteSpace(model.TARGET))
            {
                condition.And(T_USER_MENU_V2._.TARGET.Contain(model.TARGET));
            }
            if (model.IS_NAVI != null)
            {
                condition.And(T_USER_MENU_V2._.IS_NAVI == (model.IS_NAVI));
            }
            if (model.SORT != null)
            {
                condition.And(T_USER_MENU_V2._.SORT == (model.SORT));
            }
            if (model.STATUS != null)
            {
                condition.And(T_USER_MENU_V2._.STATUS == (model.STATUS));
            }
            if (model.MENU_LEVEL != null)
            {
                condition.And(T_USER_MENU_V2._.MENU_LEVEL == (model.MENU_LEVEL));
            }
            if (model.CHILDREN_TOTAL != null)
            {
                condition.And(T_USER_MENU_V2._.CHILDREN_TOTAL == (model.CHILDREN_TOTAL));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATEDBY))
            {
                condition.And(T_USER_MENU_V2._.CREATEDBY.Contain(model.CREATEDBY));
            }
            if (model.CREATEDTIME != null)
            {
                condition.And(T_USER_MENU_V2._.CREATEDTIME == (model.CREATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.UPDATEDBY))
            {
                condition.And(T_USER_MENU_V2._.UPDATEDBY.Contain(model.UPDATEDBY));
            }
            if (model.UPDATEDTIME != null)
            {
                condition.And(T_USER_MENU_V2._.UPDATEDTIME == (model.UPDATEDTIME));
            }
            if (model.ISSHOW != null)
            {
                condition.And(T_USER_MENU_V2._.ISSHOW == (model.ISSHOW));
            }
            return condition;
        }
        #endregion
    }
}