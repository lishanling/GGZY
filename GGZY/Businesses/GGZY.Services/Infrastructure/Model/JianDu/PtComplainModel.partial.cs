using System;
using System.Collections.Generic;
using System.Data;
using Dos.ORM;
using GGZY.Core.Models;
using GGZYJD.DbEntity;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_COMPLAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class PtComplainModel
    {
        private string _CODE;
        /// <summary>
        /// 类型
        /// </summary>
        public string TYPE_TEXT { get; set; }
        /// <summary>
        /// 发布人员姓名
        /// </summary>
        public string MANAGE_NAME { get; set; }

        /// <summary>
        /// 投诉类型
        /// </summary>
        public string PT_ZXTS_TYPE { get; set; }

        /// <summary>
        /// 投诉编号
        /// </summary>
        public string CODE
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_CODE))
                {
                    _CODE = "-1";
                }
                return _CODE;
            }
            set => _CODE = value;
        }
        /// <summary>
        /// 投诉类型
        /// </summary>
        public string PT_ZXTS_TYPE_TEXT => PT_ZXTS_TYPE == "1" ? "在线投诉" : PT_ZXTS_TYPE == "2" ? "线下投诉" : "人工发布";
        /// <summary>
        /// 附件
        /// </summary>
        public List<UploadResData> AIDS_ATTACHMENTS { get; set; }

        public string IS_PIBLIC_TEXT => IS_PUBLIC.HasValue && IS_PUBLIC.Value == 1 ? "是" : "否";
        public List<string> Buttons
        {
            get
            {
                var btns = new List<string>
                {
                    "EDIT",//编辑
                    "VIEW",//详情
                };
                if (!TS_ID.HasValue)
                {
                    btns.Add("DELETE");//删除
                }
                else
                {
                    btns.Add("DETAIL");//投诉详情
                }
                return btns;
            }
        }
        #region Utils
        public WhereClipBuilder ConditionBuilder(SearchCondition search = null)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            #region ModelBuilder
            if (this.ID != null)
            {
                condition.And(PT_COMPLAIN._.ID == (this.ID));
            }
            if (!string.IsNullOrWhiteSpace(this.TITLE))
            {
                condition.And(PT_COMPLAIN._.TITLE.Contain(this.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(this.TYPE))
            {
                condition.And(PT_COMPLAIN._.TYPE.Contain(this.TYPE));
            }
            if (!string.IsNullOrWhiteSpace(this.SOURCES))
            {
                condition.And(PT_COMPLAIN._.SOURCES.Contain(this.SOURCES));
            }
            if (this.TM != null)
            {
                condition.And(PT_COMPLAIN._.TM == (this.TM));
            }
            if (this.USER_ID != null)
            {
                condition.And(PT_COMPLAIN._.USER_ID == (this.USER_ID));
            }
            if (!string.IsNullOrWhiteSpace(this.CONTENTS))
            {
                condition.And(PT_COMPLAIN._.CONTENTS.Contain(this.CONTENTS));
            }
            if (!string.IsNullOrWhiteSpace(this.AIDS))
            {
                condition.And(PT_COMPLAIN._.AIDS.Contain(this.AIDS));
            }
            if (this.CREATE_TM != null)
            {
                condition.And(PT_COMPLAIN._.CREATE_TM == (this.CREATE_TM));
            }
            if (this.TS_ID != null)
            {
                condition.And(PT_COMPLAIN._.TS_ID == (this.TS_ID));
            }
            if (this.IS_PUBLIC != null)
            {
                condition.And(PT_COMPLAIN._.IS_PUBLIC == (this.IS_PUBLIC));
            }
            #endregion

            #region SeachBuilder

            if (search != null)
            {
                if (!string.IsNullOrWhiteSpace(search.KeyWord))
                {
                    condition.And(PT_COMPLAIN._.TITLE.Contain(search.KeyWord)
                    || PT_COMPLAIN._.CONTENTS.Contain(search.KeyWord)
                    || PT_COMPLAIN._.SOURCES.Contain(search.KeyWord));
                }

                if (search.BeginTime.HasValue)
                {
                    condition.And(PT_COMPLAIN._.TM>=search.BeginTime);
                }

                if (search.EndTime.HasValue)
                {
                    condition.And(PT_COMPLAIN._.TM <= search.BeginTime);
                }
            }

            #endregion
            return condition;
        }
        #endregion
    }
}