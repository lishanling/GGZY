using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TUserExtend
    {
        private bool _TEMP_CODE;
        private string _TEMP_CODE_TYPE;

        public string ACCOUNT_TYPE_TEXT => ACCOUNT_TYPE?
            .Replace("1", "建设单位")
            .Replace("2", "招标人")
            .Replace("3", "招标代理机构");

        /// <summary>
        /// 临时信用代码
        /// </summary>
        public bool TempCode
        {
            get
            {
                if (!_TEMP_CODE)
                {
                    _TEMP_CODE= !string.IsNullOrWhiteSpace(UNIFIED_CREDIT_CODE)
                                && UNIFIED_CREDIT_CODE.StartsWith("Y1")
                                && (UNIFIED_CREDIT_CODE.EndsWith("D") ||
                                    UNIFIED_CREDIT_CODE.EndsWith("G"));
                }
                return _TEMP_CODE;
            }
            set => _TEMP_CODE = value;
        }

        /// <summary>
        /// 临时信用代码类型 D 单位 G 个人
        /// </summary>

        public string TempCodeType
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_TEMP_CODE_TYPE))
                {
                    _TEMP_CODE_TYPE= !string.IsNullOrWhiteSpace(UNIFIED_CREDIT_CODE) ? UNIFIED_CREDIT_CODE.Last().ToString() : String.Empty;
                }
                return _TEMP_CODE_TYPE;
            }
            set => _TEMP_CODE_TYPE = value;
        }

        /// <summary>
        /// 扫描件_统一信用代码
        /// </summary>
        public List<UploadResData> AIDS_UCC_INFO { get; set; }
        /// <summary>
        /// 扫描件_组织机构代码
        /// </summary>
        public List<UploadResData> AIDS_OC_INFO { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string MANAGE_NAME { get; set; }
    }
}