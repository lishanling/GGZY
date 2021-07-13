using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
	public partial class MvGgxxXzjdService : BaseServiceT<MV_GGXX_XZJD>
	{

		#region Utils
		protected WhereClipBuilder ConditionBuilder(MV_GGXX_XZJD model)
		{
			WhereClipBuilder condition = new WhereClipBuilder();
			if (model.PROJECT_CATEGORY != null)
			{
				condition.And(MV_GGXX_XZJD._.PROJECT_CATEGORY == (model.PROJECT_CATEGORY));
			}
			if (!string.IsNullOrWhiteSpace(model.KIND))
			{
				condition.And(MV_GGXX_XZJD._.KIND.Contain(model.KIND));
			}
			if (model.M_ID != null)
			{
				condition.And(MV_GGXX_XZJD._.M_ID == (model.M_ID));
			}
			if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
			{
				condition.And(MV_GGXX_XZJD._.PROJECT_CODE.Contain(model.PROJECT_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
			{
				condition.And(MV_GGXX_XZJD._.PROJECT_NAME.Contain(model.PROJECT_NAME));
			}
			if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
			{
				condition.And(MV_GGXX_XZJD._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.PROTYPE_TEXT))
			{
				condition.And(MV_GGXX_XZJD._.PROTYPE_TEXT.Contain(model.PROTYPE_TEXT));
			}
			if (!string.IsNullOrWhiteSpace(model.NAME))
			{
				condition.And(MV_GGXX_XZJD._.NAME.Contain(model.NAME));
			}
			if (!string.IsNullOrWhiteSpace(model.TITLE))
			{
				condition.And(MV_GGXX_XZJD._.TITLE.Contain(model.TITLE));
			}
			if (!string.IsNullOrWhiteSpace(model.GGTYPE))
			{
				condition.And(MV_GGXX_XZJD._.GGTYPE.Contain(model.GGTYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
			{
				condition.And(MV_GGXX_XZJD._.REGION_CODE.Contain(model.REGION_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.AREANAME))
			{
				condition.And(MV_GGXX_XZJD._.AREANAME.Contain(model.AREANAME));
			}
			if (!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
			{
				condition.And(MV_GGXX_XZJD._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.PLATFORM_NAME))
			{
				condition.And(MV_GGXX_XZJD._.PLATFORM_NAME.Contain(model.PLATFORM_NAME));
			}
			if (model.TM != null)
			{
				condition.And(MV_GGXX_XZJD._.TM == (model.TM));
			}
			return condition;
		}
		#endregion
	}
}