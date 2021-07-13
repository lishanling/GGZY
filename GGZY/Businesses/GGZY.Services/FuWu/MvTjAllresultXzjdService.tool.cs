using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
	public partial class MvTjAllresultXzjdService : BaseServiceT<MV_TJ_ALLRESULT_XZJD>
	{
		#region 接口实现

		public List<MV_TJ_ALLRESULT_XZJD> FindList(MV_TJ_ALLRESULT_XZJD model)
		{
			var condition = ConditionBuilder(model);
			var list = FindList(condition);
			return list;
		}

		public BootstrapTableResult<MV_TJ_ALLRESULT_XZJD> PageList(MV_TJ_ALLRESULT_XZJD model, SearchCondition search)
		{
			var condition = ConditionBuilder(model);
			var count = Count(condition);
			var pageList = PageList(condition, search, MV_TJ_ALLRESULT_XZJD._.M_TM.Desc).ToBootstrapTableList(count);


			return pageList;
		}


		/// <summary>
		/// 导入
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public GeneralResult Import(List<MV_TJ_ALLRESULT_XZJD> model)
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
		protected WhereClipBuilder ConditionBuilder(MV_TJ_ALLRESULT_XZJD model)
		{
			WhereClipBuilder condition = new WhereClipBuilder();
			if (model.M_TM != null)
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.M_TM == (model.M_TM));
			}
			if (!string.IsNullOrWhiteSpace(model.SECTION_CODE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.SECTION_CODE.Contain(model.SECTION_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE.Contain(model.PROJECT_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
			}
			if (model.AMOUNT != null)
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.AMOUNT == (model.AMOUNT));
			}
			if (!string.IsNullOrWhiteSpace(model.AREACODE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.AREACODE.Contain(model.AREACODE));
			}
			if (!string.IsNullOrWhiteSpace(model.AREANAME))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.AREANAME.Contain(model.AREANAME));
			}
			if (!string.IsNullOrWhiteSpace(model.KIND))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.KIND.Contain(model.KIND));
			}
			if (!string.IsNullOrWhiteSpace(model.M_TABLE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.M_TABLE.Contain(model.M_TABLE));
			}
			if (!string.IsNullOrWhiteSpace(model.EVALUATION_RESULT))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.EVALUATION_RESULT.Contain(model.EVALUATION_RESULT));
			}
			if (model.RECKON_AMOUNT != null)
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.RECKON_AMOUNT == (model.RECKON_AMOUNT));
			}
			if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_MODE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.TENDER_MODE.Contain(model.TENDER_MODE));
			}
			if (!string.IsNullOrWhiteSpace(model.ORGANIZE_FORM))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.ORGANIZE_FORM.Contain(model.ORGANIZE_FORM));
			}
			if (!string.IsNullOrWhiteSpace(model.BULLETIN_TYPE))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.BULLETIN_TYPE.Contain(model.BULLETIN_TYPE));
			}
			if (model.LISTING_TYPE != null)
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.LISTING_TYPE == (model.LISTING_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.IN_BUY_KIND))
			{
				condition.And(MV_TJ_ALLRESULT_XZJD._.IN_BUY_KIND.Contain(model.IN_BUY_KIND));
			}
			return condition;
		}
		#endregion
	}
}