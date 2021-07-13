using GGZY.Services.Infrastructure.Enums.Jd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class BD_VIOLATION_ENTITY_REQUEST
    {
        public BD_VIOLATION_ENTITY_REQUEST()
        {
            this.Buttons = new List<string>();
        }
        /// <summary>
        /// 招标项目代码
        /// </summary>
        public string ENTITY_CODE { get; set; }
        /// <summary>
        /// 主体名称
        /// </summary>
        public string ENTITY_NAME { get; set; }
        /// <summary>
        /// 主体编码
        /// </summary>
        public string AREA_CODE { get; set; }

        public DateTime? DATETIME_START { get; set; }

        public DateTime? DATETIME_END { get; set; }
        /// <summary>
        /// 疑似违规点代码
        /// </summary>
        public string POINT_CODE { get; set; }
        /// <summary>
        /// 主体类型
        /// </summary>
        public decimal ENTITY_TYPE { get; set; }

        public decimal? STATE { get; set; }

        /// <summary>
        /// 按钮返回
        /// </summary>
        public List<string> Buttons
        {
            get; set;
        }

    }
    public partial class JDCompareModel
    {

        public JDCompareModel()
        {
            this.Buttons = new List<string>();
        }
        /// <summary>
        /// 抄送部门信息
        /// </summary>

        #region JDCompareModel

        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

             /// <summary>
             /// 页面选择标题ID
             /// </summary>
             public string PAGE_TITLE_ID { get; set; }

              /// <summary>
              ///项目/主体选择标题ID
              /// </summary>
              public string PAGE_ID { get; set; }
             /// <summary>
             ///违规点状态
             /// </summary>
             public decimal? STATE { get; set; }
           
              /// <summary>
              /// 招标项目名称
              /// </summary>
              public string TENDER_PROJECT_NAME{ get; set; }

            /// <summary>
            /// 招标编号
            /// </summary>
            public string TENDER_PROJECT_CODE { get; set; }
            /// <summary>
            /// 检查时间
            /// </summary>
            public string CHECK_TIME{ get; set; }
             /// <summary>
             /// 创建时间
             /// </summary>
             public string CREATE_TIME { get; set; }
             /// <summary>
             /// 地区编码
             /// </summary>
             public string AREA_CODE{ get; set; }
            /// <summary>
            /// 疑似违规点编号
            /// </summary>
            public string POINT_CODE{ get; set; }

            /// <summary>
            /// 疑似违规点名称
            /// </summary>
            public string POINT_NAME { get; set; }

            /// <summary>
            /// 行业类型
            /// </summary>
            public string TENDER_PROJECT_TYPE { get; set; }
            /// <summary>
            /// 行业类型名称
            /// </summary>
            public string TENDER_PROJECT_TYPE_NAME { get; set; }
            /// <summary>
            /// 疑似违规点主名称
            /// </summary>
            public string CATEGORY_NAME{ get; set; }

             /// <summary>
             /// 疑似违规点名称一级编号
             /// </summary>
             public string CATEGORY_CODE { get; set; }
          /// <summary>
          /// 疑似违规点名称二级编号
          /// </summary>
          public string CATEGORY_CODE_TWO { get; set; }
          /// <summary>
            /// 地区名称
          /// </summary>
          public string AREANAME { get; set; }

           /// <summary>
           /// 违规记录类型  ENTITY:主体 PROJECT:项目
           /// </summary>
           public string RECORD_TYPE { get; set; }
            /// <summary>
            /// 违规记录类型  ENTITY:主体类型
            /// </summary>
            public string ENTITY_TYPE { get; set; }
            /// <summary>
            /// 企业主体代码
            /// </summary>
            public string ENTITY_CODE { get; set; }
             /// <summary>
             /// 单位名称
             /// </summary>
             public string ENTITY_NAME { get; set; }
            /// <summary>
            /// 移送类型
            /// </summary>
            public string TRANS_TYPE { get; set; }
            /// <summary>
            /// 按钮返回
            /// </summary>
            public List<string> Buttons
                 {
                get;set;
                 }
             
            #endregion

    }
}

