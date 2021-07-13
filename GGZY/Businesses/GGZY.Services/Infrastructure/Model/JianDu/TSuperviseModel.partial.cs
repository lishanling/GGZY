using System;
using System.Collections.Generic;
using System.Data;
using Dos.ORM;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_AFC_PROJECT_SUPERVISE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class TSuperviseModel
    {
        public List<UploadResData> FILES_ATTACHMENT { get; set; }

		/// <summary>
		/// 事项类型
		/// </summary>
		[Display(Name = "事项类型", Order = 50)]
		public string ENTITY_TYPE_TEXT {
            get
            {
                var txt = "";
                switch (ENTITY_TYPE_NAME)
                {
					case nameof(T_AFC_PROJECT):
                        txt = "招标计划";
                        break;
                    case nameof(RECORD_REVIEW):
                        txt = "招标备案";
						break;
                    case nameof(PT_ZXTS):
                        txt = "投诉处理";
						break;
                    case nameof(GGZYFW.DbEntity.WARN_RESULT):
                        txt = "监督点";
						break;
                    case nameof(GGZYFW.DbEntity.BD_VIOLATION_RECORD):
                        txt = "疑似违规点项目";
                        break;
                    case nameof(GGZYFW.DbEntity.BD_VIOLATION_ENTITY):
                        txt = "疑似违规点主体";
                        break;
					case nameof(TENDER_PROJECT):
                        txt = "招标项目";
                        break;
				}
                return txt;
            } }
		/// <summary>
		/// 反馈状态
		/// </summary>
		[Display(Name = "反馈状态", Order = 60)]
		public string STATUS_TEXT => STATUS > 0 ? "已反馈" : "未反馈";

		public List<string> BUTTONS { get; set; }
		/// <summary>
		/// 转发督查ID
		/// </summary>
		public string SUPERVISE_ID { get; set; }

		public string HY_DEPID { get; set; }
		#region Utils
		public WhereClipBuilder ConditionBuilder(SearchCondition search)
		{
			WhereClipBuilder condition = new WhereClipBuilder();
			if (!string.IsNullOrWhiteSpace(this.M_ID))
			{
				condition.And(T_SUPERVISE._.M_ID.Contain(this.M_ID));
			}
			if (!string.IsNullOrWhiteSpace(this.NAME))
			{
				condition.And(T_SUPERVISE._.NAME.Contain(this.NAME));
			}
			if (!string.IsNullOrWhiteSpace(this.CONTENT))
			{
				condition.And(T_SUPERVISE._.CONTENT.Contain(this.CONTENT));
			}
			if (!string.IsNullOrWhiteSpace(this.FILES))
			{
				condition.And(T_SUPERVISE._.FILES.Contain(this.FILES));
			}
			if (this.TIME != null)
			{
				condition.And(T_SUPERVISE._.TIME == (this.TIME));
			}
			if (!string.IsNullOrWhiteSpace(this.OP_ID))
			{
				condition.And(T_SUPERVISE._.OP_ID.Contain(this.OP_ID));
			}
			if (!string.IsNullOrWhiteSpace(this.OP_NAME))
			{
				condition.And(T_SUPERVISE._.OP_NAME.Contain(this.OP_NAME));
			}
			if (!string.IsNullOrWhiteSpace(this.DEP_ID))
			{
				condition.And(T_SUPERVISE._.DEP_ID.Contain(this.DEP_ID));
			}
			if (!string.IsNullOrWhiteSpace(this.DEP_NAME))
			{
				condition.And(T_SUPERVISE._.DEP_NAME.Contain(this.DEP_NAME));
			}
			if (!string.IsNullOrWhiteSpace(this.OBJ))
			{
				condition.And(T_SUPERVISE._.OBJ.Contain(this.OBJ));
			}
			if (!string.IsNullOrWhiteSpace(this.OBJ_NAME))
			{
				condition.And(T_SUPERVISE._.OBJ_NAME.Contain(this.OBJ_NAME));
			}
			if (!string.IsNullOrWhiteSpace(this.OBJ_DEP_ID))
			{
				condition.And(T_SUPERVISE._.OBJ_DEP_ID.Contain(this.OBJ_DEP_ID));
			}
			if (!string.IsNullOrWhiteSpace(this.OBJDEP_NAME))
			{
				condition.And(T_SUPERVISE._.OBJDEP_NAME.Contain(this.OBJDEP_NAME));
			}
			if (!string.IsNullOrWhiteSpace(this.CODE))
			{
				condition.And(T_SUPERVISE._.CODE.Contain(this.CODE));
			}
			if (this.ENTITY_ID != null)
			{
				condition.And(T_SUPERVISE._.ENTITY_ID == (this.ENTITY_ID));
			}
			if (!string.IsNullOrWhiteSpace(this.ENTITY_TYPE_NAME))
			{
				condition.And(T_SUPERVISE._.ENTITY_TYPE_NAME.Contain(this.ENTITY_TYPE_NAME));
			}
			if (this.STATUS != null)
			{
				condition.And(T_SUPERVISE._.STATUS == (this.STATUS));
			}
			if (!string.IsNullOrWhiteSpace(this.REGION_CODE))
			{
				condition.And(T_SUPERVISE._.REGION_CODE.Contain(this.REGION_CODE));
			}
			if (!string.IsNullOrWhiteSpace(this.TENDER_PROJECT_TYPE))
			{
				condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE.Contain(this.TENDER_PROJECT_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(this.ENTITY_NAME))
			{
				condition.And(T_SUPERVISE._.ENTITY_NAME.Contain(this.ENTITY_NAME));
			}

            if (search.BeginTime.HasValue)
            {
				condition.And(T_SUPERVISE._.TIME>=search.BeginTime);
			}
			if (search.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME <= search.EndTime);
            }
			return condition;
		}

		/// <summary>
		/// ENTITY_TYPE_NAME 转换对应的中文
		/// </summary>
		/// <param name="entityTypeName">ENTITY_TYPE_NAME</param>
		/// <param name="mergeBdViolation">疑似违规点是否合并</param>
		/// <returns></returns>
		public static string MapEntityType(string entityTypeName,bool mergeBdViolation=false)
        {
            var txt = "";
            switch (entityTypeName)
            {
                case nameof(T_AFC_PROJECT):
                    txt = "招标计划";
                    break;
                case nameof(RECORD_REVIEW):
                    txt = "招标备案";
                    break;
                case nameof(PT_ZXTS):
                    txt = "投诉处理";
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    txt = "监督点";
                    break;
                case nameof(GGZYFW.DbEntity.BD_VIOLATION_RECORD):
                    txt = "疑似违规点项目";
                    break;
                case nameof(GGZYFW.DbEntity.BD_VIOLATION_ENTITY):
                    txt = "疑似违规点主体";
                    break;
                case nameof(TENDER_PROJECT):
                    txt = "招标项目";
                    break;
            }
            return txt;
		}
		#endregion
	}
}