using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
	public partial class BidderProjectMemberService : BaseServiceT<BIDDER_PROJECT_MEMBER>
	{
		#region 接口实现

		public List<BIDDER_PROJECT_MEMBER> FindList(BIDDER_PROJECT_MEMBER model)
		{
			var condition = ConditionBuilder(model);
			var list = FindList(condition);
			return list;
		}

		public BootstrapTableResult<BIDDER_PROJECT_MEMBER> PageList(BIDDER_PROJECT_MEMBER model, SearchCondition search)
		{
			var condition = ConditionBuilder(model);
			var count = Count(condition);
			var pageList = PageList(condition, search, BIDDER_PROJECT_MEMBER._.M_TM.Desc).ToBootstrapTableList(count);


			return pageList;
		}


		/// <summary>
		/// 查看
		/// </summary>
		/// <param name="M_ID"></param>
		/// <returns></returns>
		public GeneralResult ViewByPk(decimal? M_ID)


		{
			var result = new GeneralResult();
			var condition = new WhereClipBuilder();
			condition.And(BIDDER_PROJECT_MEMBER._.M_ID == M_ID);

			var dbModel = FirstOrNull(condition);
			if (dbModel == null)
			{
				result.SetFail(OBJECT_NOT_EXIST);
			}
			else
			{
				result.SetSuccess(dbModel);
			}
			return result;
		}

		/// <summary>
		/// 编辑
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public GeneralResult Edit(BIDDER_PROJECT_MEMBER model)
		{
			var result = new GeneralResult();
			try
			{
				var viewResult = ViewByPk(model.M_ID);

				if (viewResult.Success && viewResult.Data is BIDDER_PROJECT_MEMBER entity)
				{
					entity.Attach();
					entity.M_ID = model.M_ID;
					entity.M_KEY = model.M_KEY;
					entity.M_DATA_SOURCE = model.M_DATA_SOURCE;
					entity.M_TM = model.M_TM;
					entity.M_VERSION = model.M_VERSION;
					entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
					entity.BID_SECTION_CODE = model.BID_SECTION_CODE;
					entity.UNIFIED_DEAL_CODE = model.UNIFIED_DEAL_CODE;
					entity.BIDDER_NAME = model.BIDDER_NAME;
					entity.BIDDER_CODE_TYPE = model.BIDDER_CODE_TYPE;
					entity.BIDDER_ORG_CODE = model.BIDDER_ORG_CODE;
					entity.NAME = model.NAME;
					entity.PHONE = model.PHONE;
					entity.ID_CARD_NO = model.ID_CARD_NO;
					entity.POSITION = model.POSITION;
					entity.TECHNICAL_POST = model.TECHNICAL_POST;
					entity.CERTIFICATE_NO = model.CERTIFICATE_NO;
					entity.CERTIFICATE_TYPE = model.CERTIFICATE_TYPE;
					entity.CERTIFICATE_FULL_NAME = model.CERTIFICATE_FULL_NAME;
					entity.CERTIFICATE_LEVLE = model.CERTIFICATE_LEVLE;
					entity.YEARS_OF_WORKING = model.YEARS_OF_WORKING;
					entity.CREDIT_SCORE = model.CREDIT_SCORE;
					entity.GRADUATE_SCHOOL = model.GRADUATE_SCHOOL;
					entity.PLATFORM_CODE = model.PLATFORM_CODE;
					entity.PUB_SERVICE_PLAT_CODE = model.PUB_SERVICE_PLAT_CODE;
					entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
					entity.TRADE_PLAT = model.TRADE_PLAT;
					entity.PUB_SERVICE_PLAT = model.PUB_SERVICE_PLAT;
					//Update(entity);
					result.SetSuccess(entity);
				}
				else
				{
					result.SetFail(viewResult.Msg);
				}
			}
			catch (Exception e)
			{
				result.SetFail(e.Message, e);
			}
			return result;
		}
		/// <summary>
		/// 新增
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public GeneralResult Add(BIDDER_PROJECT_MEMBER model)
		{
			var result = new GeneralResult();
			try
			{
				Insert(model);
				result.SetSuccess(model);
			}
			catch (Exception e)
			{
				result.SetFail(e.Message, e);
			}
			return result;
		}


		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="ids"></param>
		/// <returns></returns>
		public GeneralResult Delete(params string[] ids)
		{
			GeneralResult result = new GeneralResult();
			try
			{
				List<string> idArr = new List<string>();
				foreach (var id in ids)
				{
					idArr.AddRange(id.Split(','));
				}

				if (idArr.Any())
				{
					Delete(BIDDER_PROJECT_MEMBER._.M_ID.SelectIn(idArr));
					result.SetSuccess(ids);
				}
				else
				{
					result.SetFail($"请选择要删除的记录");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				result.SetFail(e.Message, e);
			}
			return result;
		}

		/// <summary>
		/// 导入
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public GeneralResult Import(List<BIDDER_PROJECT_MEMBER> model)
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
		protected WhereClipBuilder ConditionBuilder(BIDDER_PROJECT_MEMBER model)
		{
			WhereClipBuilder condition = new WhereClipBuilder();
			if (model.M_ID != null)
			{
				condition.And(BIDDER_PROJECT_MEMBER._.M_ID == (model.M_ID));
			}
			if (!string.IsNullOrWhiteSpace(model.M_KEY))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.M_KEY.Contain(model.M_KEY));
			}
			if (!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
			}
			if (model.M_TM != null)
			{
				condition.And(BIDDER_PROJECT_MEMBER._.M_TM == (model.M_TM));
			}
			if (!string.IsNullOrWhiteSpace(model.M_VERSION))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.M_VERSION.Contain(model.M_VERSION));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.BIDDER_NAME.Contain(model.BIDDER_NAME));
			}
			if (!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.NAME))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.NAME.Contain(model.NAME));
			}
			if (!string.IsNullOrWhiteSpace(model.PHONE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.PHONE.Contain(model.PHONE));
			}
			if (!string.IsNullOrWhiteSpace(model.ID_CARD_NO))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.ID_CARD_NO.Contain(model.ID_CARD_NO));
			}
			if (!string.IsNullOrWhiteSpace(model.POSITION))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.POSITION.Contain(model.POSITION));
			}
			if (!string.IsNullOrWhiteSpace(model.TECHNICAL_POST))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.TECHNICAL_POST.Contain(model.TECHNICAL_POST));
			}
			if (!string.IsNullOrWhiteSpace(model.CERTIFICATE_NO))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.CERTIFICATE_NO.Contain(model.CERTIFICATE_NO));
			}
			if (!string.IsNullOrWhiteSpace(model.CERTIFICATE_TYPE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.CERTIFICATE_TYPE.Contain(model.CERTIFICATE_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.CERTIFICATE_FULL_NAME))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.CERTIFICATE_FULL_NAME.Contain(model.CERTIFICATE_FULL_NAME));
			}
			if (!string.IsNullOrWhiteSpace(model.CERTIFICATE_LEVLE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.CERTIFICATE_LEVLE.Contain(model.CERTIFICATE_LEVLE));
			}
			if (model.YEARS_OF_WORKING != null)
			{
				condition.And(BIDDER_PROJECT_MEMBER._.YEARS_OF_WORKING == (model.YEARS_OF_WORKING));
			}
			if (model.CREDIT_SCORE != null)
			{
				condition.And(BIDDER_PROJECT_MEMBER._.CREDIT_SCORE == (model.CREDIT_SCORE));
			}
			if (!string.IsNullOrWhiteSpace(model.GRADUATE_SCHOOL))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.GRADUATE_SCHOOL.Contain(model.GRADUATE_SCHOOL));
			}
			if (!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
			}
			if (model.DATA_TIMESTAMP != null)
			{
				condition.And(BIDDER_PROJECT_MEMBER._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
			}
			if (!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.TRADE_PLAT.Contain(model.TRADE_PLAT));
			}
			if (!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
			{
				condition.And(BIDDER_PROJECT_MEMBER._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
			}
			return condition;
		}
		#endregion
	}
}