using Dos.ORM;
using GGZY.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    /// <summary>
    /// 实体类MV_GGXX_XZJD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class MvGgxxXzjdModel
    {
        public string PROJECT_CATEGORY_TEXT { get; set; }
        [Display(Name = "业务类型", Order = 40)]
        public string PROJECT_TYPE_TEXT => PROTYPE_TEXT;
        /// <summary>
        /// 对应监督平台TENDER_PROJECT.TENDER_PROJECT_CODE 可能为空
        /// 匹配一局
        /// 服务平台TENDER_PROJECT.TENDER_PROJECT_CODE=监督平台TENDER_PROJECT.TENDER_PROJECT_CODE_OLD1
        /// </summary>
        public string JD_TENDER_PROJECT_CODE { get; set; }
        #region Utils
        public WhereClipBuilder ConditionBuilder(SearchCondition search = null)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (this.PROJECT_CATEGORY != null)
            {
                condition.And(_.PROJECT_CATEGORY == (this.PROJECT_CATEGORY));
            }
            if (!string.IsNullOrWhiteSpace(this.KIND))
            {
                condition.And(_.KIND.Contain(this.KIND));
            }
            if (this.M_ID != null)
            {
                condition.And(_.M_ID == (this.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_CODE))
            {
                condition.And(_.PROJECT_CODE.Contain(this.PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_NAME))
            {
                condition.And(_.PROJECT_NAME.Contain(this.PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.PROJECT_TYPE))
            {
                condition.And(_.PROJECT_TYPE.Contain(this.PROJECT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(this.PROTYPE_TEXT))
            {
                condition.And(_.PROTYPE_TEXT.Contain(this.PROTYPE_TEXT));
            }
            if (!string.IsNullOrWhiteSpace(this.NAME))
            {
                condition.And(_.NAME.Contain(this.NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.TITLE))
            {
                condition.And(_.TITLE.Contain(this.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(this.GGTYPE))
            {
                condition.And(_.GGTYPE.Contain(this.GGTYPE));
            }
            if (!string.IsNullOrWhiteSpace(this.REGION_CODE))
            {
                //condition.And(_.REGION_CODE.Contain(this.REGION_CODE));
                var areaCode = REGION_CODE.TrimEnd('0');
                if (areaCode.Length % 2 > 0)
                    areaCode = areaCode.PadRight(areaCode.Length + 1, '0');
                condition.And(_.REGION_CODE.BeginWith(areaCode));
            }
            if (!string.IsNullOrWhiteSpace(this.AREANAME))
            {
                condition.And(_.AREANAME.Contain(this.AREANAME));
            }
            if (!string.IsNullOrWhiteSpace(this.PLATFORM_CODE))
            {
                condition.And(_.PLATFORM_CODE.Contain(this.PLATFORM_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.PLATFORM_NAME))
            {
                condition.And(_.PLATFORM_NAME.Contain(this.PLATFORM_NAME));
            }
            if (this.TM != null)
            {
                condition.And(_.TM == (this.TM));
            }

            if (search != null)
            {
                if (search.BeginTime.HasValue)
                {
                    condition.And(MvGgxxXzjdModel._.TM >= search.BeginTime);
                }

                if (search.EndTime.HasValue)
                {
                    condition.And(MvGgxxXzjdModel._.TM <= search.EndTime);
                }

                if (!string.IsNullOrWhiteSpace(search.KeyWord))
                {
                    condition.And(MvGgxxXzjdModel._.PROJECT_CODE.Contain(search.KeyWord) || MvGgxxXzjdModel._.PROJECT_NAME.Contain(search.KeyWord));
                }
            }
            return condition;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "MV_GGXX_XZJD");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROJECT_CATEGORY = new Field("PROJECT_CATEGORY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field KIND = new Field("KIND");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field M_ID = new Field("M_ID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROTYPE_TEXT = new Field("PROTYPE_TEXT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field NAME = new Field("NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TITLE = new Field("TITLE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GGTYPE = new Field("GGTYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REGION_CODE = new Field("REGION_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field AREANAME = new Field("AREANAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLATFORM_NAME = new Field("PLATFORM_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TM = new Field("TM");

        }
        #endregion
    }
}