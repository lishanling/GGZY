using System.Collections.Generic;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 处长门户 项目监督
    /// </summary>
    public partial class ProjectSupervisionService : BaseServiceT<JdEntity>
    {
        
        #region 行业部门

        public List<LabelValueModel> ProjectSupervisionHyType()
        {
            return new List<LabelValueModel>
            {
                new LabelValueModel{Id="",Label="全部",Value = ""},
                new LabelValueModel{Id="",Label="招标计划登记",Value = nameof(T_AFC_PROJECT)},
                new LabelValueModel{Id="",Label="招标备案",Value = nameof(RECORD_REVIEW)},
                new LabelValueModel{Id="",Label="投诉处理",Value = nameof(PT_ZXTS)},
                new LabelValueModel{Id="",Label="监督点",Value = nameof(GGZYFW.DbEntity.WARN_RESULT)},
            };
        }
        #endregion

        #region 纪委



        #endregion

        #region 公安



        #endregion
    }
}