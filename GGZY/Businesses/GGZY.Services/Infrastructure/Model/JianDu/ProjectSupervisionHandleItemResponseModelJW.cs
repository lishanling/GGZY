using System;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 项目监督 纪委监委 处理项目及事项 详情 处理事项
    /// </summary>
    public class ProjectSupervisionHandleItemResponseModelJW
    {
#pragma warning disable CS0169 // 从不使用字段“ProjectSupervisionHandleItemResponseModelJW._SXLX_TEXT”
        private string _SXLX_TEXT;
#pragma warning restore CS0169 // 从不使用字段“ProjectSupervisionHandleItemResponseModelJW._SXLX_TEXT”
#pragma warning disable CS0169 // 从不使用字段“ProjectSupervisionHandleItemResponseModelJW._SUB_SXLX_TEXT”
        private string _SUB_SXLX_TEXT;
#pragma warning restore CS0169 // 从不使用字段“ProjectSupervisionHandleItemResponseModelJW._SUB_SXLX_TEXT”
        public string SXLX { get; set; }

        //public string SXLX_TEXT
        //{
        //    get
        //    {
        //        if (string.IsNullOrWhiteSpace(_SXLX_TEXT))
        //        {
        //            switch (SXLX)
        //            {
        //                case nameof(T_SUPERVISE_RESULT):
        //                    _SXLX_TEXT = "触发检查点:";
        //                    break;
        //                case nameof(JC_TRANS_RECORD):
        //                    _SXLX_TEXT = "";
        //                    break;
        //            }
        //        }

        //        return _SXLX_TEXT;
        //    }
        //    set => _SXLX_TEXT = value;
        //}

        public string SUB_SXLX { get; set; }

        //public string SUB_SXLX_TEXT
        //{
        //    get
        //    {
        //        if (string.IsNullOrWhiteSpace(_SUB_SXLX_TEXT))
        //        {
        //            switch (SUB_SXLX)
        //            {
        //                case nameof(T_AFC_PROJECT):
        //                    _SUB_SXLX_TEXT = "触发检查点:";
        //                    break;
        //                case nameof(RECORD_REVIEW):
        //                    _SUB_SXLX_TEXT = "触发检查点:";
        //                    break;
        //                case nameof(PT_ZXTS):
        //                    _SUB_SXLX_TEXT = "触发检查点:";
        //                    break;
        //                case nameof(GGZYFW.DbEntity.WARN_RESULT):
        //                    _SUB_SXLX_TEXT = "触发检查点:";
        //                    break;
        //                case nameof(JC_TRANS_RECORD):
        //                    _SUB_SXLX_TEXT = "";
        //                    break;
        //            }
        //        }
        //        return _SUB_SXLX_TEXT;
        //    }
        //    set => _SUB_SXLX_TEXT = value;
        //}

        public string TITLE { get; set; }

        public decimal? STATUS { get; set; }
        public string STATUS_TEXT => STATUS == 1 ? "已处理" : "未处理";
        public string OPERATOR { get; set; }
        public string OPINION { get; set; }
        public DateTime? TM { get; set; }
    }
}