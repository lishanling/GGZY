using System.Collections.Generic;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_AFC_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// 监督平台项目报建列表返回值对象
    /// </summary>
    public partial class TAfcProjectModel
    {
        /// <summary>
        /// 填报人姓名
        /// </summary>
        public string U_ID_NAME { get; set; }


        public string MID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_MID))
                {
                    _MID = ID?.ToString();//.DesEncrypt();
                }
                return _MID;
            }
            set => _MID = value;
        }
        [Display(Name = "工程类型", Order = 50)]
        public string PROJECT_TYPE_NAME { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        [Display(Name = "地区", Order = 40)]
        public string REGION_CITY_NAME { get; set; }

        public string REGION_COUNTY_NAME { get; set; }
        public string REGION
        {
            get => $"{REGION_CITY_NAME}{REGION_COUNTY_NAME}";
        }
        /// <summary>
        /// 报建类型
        /// </summary>
        public string KIND_TEXT { get; set; }
        /// <summary>
        /// 建设性质
        /// </summary>
        public string JSXZ_TEXT { get; set; }
        /// <summary>
        /// 工程用途
        /// </summary>
        public string GCYT_TEXT { get; set; }
        public string APPROVAL_STATE_NAME { get; set; }
        public string ISMAJOR_NAME { get; set; }
        public string IS_DJZ_NAME { get; set; }
        public string APPROVAL_TACHE_NAME { get; set; }
        public string TENDER_ORGANIZE_FORM_NAME { get; set; }
        public string APPROVAL_STATE_TACHE_NAME
        {
            get => $"{APPROVAL_STATE_NAME}({APPROVAL_TACHE_NAME})";
        }
        /// <summary>
        /// 审批人员姓名
        /// </summary>
        [Display(Name = "提交单位", Order = 30)]
        public string APPROVAL_DEPNAME { get; set; }
        /// <summary>
        /// 审批人员姓名
        /// </summary>
        [Display(Name = "审查单位", Order = 70)]
        public string APPROVAL_DEPNAME_TEXT { get; set; }
        /// <summary>
        /// 审批人员电话
        /// </summary>
        public string APPROVAL_DEP_PHONE { get; set; }
        public string OPRATION { get; set; }
        /// <summary>
        /// 是否审查人员
        /// </summary>
        public int IS_CENSOR { get; set; }
        /// <summary>
        /// 是否获取数据
        /// </summary>
        [Display(Name = "接口获取", Order = 80)]
        public string IS_GET { get; set; }
        /// <summary>
        /// 是否有交易数据
        /// </summary>
        [Display(Name = "交易数据", Order = 90)]
        public string HAS_DATA { get; set; }

        public string JD_PROJECT_CODE { get; set; }
        public string JD_TENDER_PROJECT_CODE { get; set; }
        public string FW_TENDER_PROJECT_CODE { get; set; }

        public bool IsV9527
        {
            get =>
                (!string.IsNullOrWhiteSpace(APPROVAL_LEVEL) || APPROVAL_DATE.HasValue ||
                 GOVERNMENT_INVEST_FINANCE.HasValue);
        }

        /// <summary>
        /// 推送数量
        /// </summary>
        public int SendCount { get; set; }

        private List<string> _buttons;
        private string _MID;
        private string _IS_FROM_TZZXPT;

        /// <summary>
        /// 操作按钮
        /// </summary>
        public List<string> Buttons
        {
            get => _buttons ?? (_buttons = new List<string>());

            set => _buttons = value;
        }



        /// <summary>
        /// 组织机构代码证书
        /// </summary>
        public List<UploadResData> JS_CODE_ATTACHMENT { get; set; }
        /// <summary>
        /// 项目立项或批准文件
        /// </summary>
        public List<UploadResData> APPROVAL_ATTACHMENT { get; set; }
        /// <summary>
        /// 工程项目立项登记表
        /// </summary>
        public List<UploadResData> REGISTER_ATTACHMENT { get; set; }
        /// <summary>
        /// 其他文件
        /// </summary>
        public List<UploadResData> OTHER_ATTACHMENT { get; set; }
        /// <summary>
        /// 招标事项核准意见书
        /// </summary>
        public List<UploadResData> ZBHZYJS_ATTACHMENT { get; set; }


        #region 招标项目变更申请

        public T_AFC_CHANGE AfcChange { get; set; }
        public decimal? AFC_ID { get; set; }
        /// <summary>
        /// 变更申请附件
        /// </summary>
        public string CHANGE_AIDS { get; set; }

        /// <summary>
        /// 变更备注
        /// </summary>
        public string CHANGE_REMARK { get; set; }
        /// <summary>
        /// 变更申请附件
        /// </summary>
        public List<UploadResData> CHANGE_AIDS_ATTACHMENT { get; set; }

        #endregion

        #region 处长门户

        /// <summary>
        /// 处长门户 登记备案 项目类型(发包方式)
        /// </summary>
        public string FBFS { get; set; }

        #endregion

        /// <summary>
        /// 是否来自投资在线平台
        /// </summary>
        public string IS_FROM_TZZXPT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_IS_FROM_TZZXPT) && !string.IsNullOrWhiteSpace(APPROVAL_DEPID))
                {
                    _IS_FROM_TZZXPT = APPROVAL_DEPID == "99999" ? "是" : "否";
                }
                
                return _IS_FROM_TZZXPT;
            }
            set => _IS_FROM_TZZXPT = value;
        }
    }
}