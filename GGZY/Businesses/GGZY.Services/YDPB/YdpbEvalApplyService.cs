using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
	public partial class YdpbEvalApplyService : BaseServiceT<YDPB_EVAL_APPLY>
	{
		#region 接口实现

		public List<YDPB_EVAL_APPLY> FindList(YDPB_EVAL_APPLY model)
		{
			var condition = ConditionBuilder(model);
			var list = FindList(condition);
			return list;
		}

		public BootstrapTableResult<YDPB_EVAL_APPLY> PageList(YDPB_EVAL_APPLY model, SearchCondition search)
		{
			var condition = ConditionBuilder(model);
			var count = Count(condition);
			var pageList = PageList(condition, search, YDPB_EVAL_APPLY._.ID.Desc).ToBootstrapTableList(count);


			return pageList;
		}


		/// <summary>
		/// 查看
		/// </summary>
		/// <param name="ID">ID</param>
		/// <returns></returns>
		public GeneralResult ViewByPk(decimal? ID)


		{
			var result = new GeneralResult();
			var condition = new WhereClipBuilder();
			condition.And(YDPB_EVAL_APPLY._.ID == ID);

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
		public GeneralResult Edit(YDPB_EVAL_APPLY model)
		{
			var result = new GeneralResult();
			try
			{
				var viewResult = ViewByPk(model.ID);

				if (viewResult.Success && viewResult.Data is YDPB_EVAL_APPLY entity)
				{
					entity.Attach();
					entity.ID = model.ID;
					entity.APPLY_TYPE = model.APPLY_TYPE;
					entity.SERIES_NUMBER = model.SERIES_NUMBER;
					entity.TENDER_PROJECT = model.TENDER_PROJECT;
					entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
					entity.TENDER_PROJECT_ID = model.TENDER_PROJECT_ID;
					entity.BID_EVAL_END_TIME = model.BID_EVAL_END_TIME;
					entity.REMARK = model.REMARK;
					entity.STATUS = model.STATUS;
					entity.CREATOR_ID = model.CREATOR_ID;
					entity.CREATOR = model.CREATOR;
					entity.CREATE_TIME = model.CREATE_TIME;
					entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
					entity.IS_DELETE = model.IS_DELETE;
					entity.EXPERT_COUNT = model.EXPERT_COUNT;
					entity.FID = model.FID;
					entity.F_SERIES_NUMBER = model.F_SERIES_NUMBER;
					entity.EVAL_STATUS = model.EVAL_STATUS;
					entity.FLAG = model.FLAG;
					entity.IS_EVAL_EXPERT = model.IS_EVAL_EXPERT;
					entity.TENDER_AGENCY_NAME = model.TENDER_AGENCY_NAME;
					entity.TENDER_AGENCY_CODE = model.TENDER_AGENCY_CODE;
					entity.TENDER_AGENT_CONTRACT = model.TENDER_AGENT_CONTRACT;
					entity.BID_EVAL_START_TIME = model.BID_EVAL_START_TIME;
					entity.TENDER_AGENT_PHONE = model.TENDER_AGENT_PHONE;
					Update(entity);
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
		public GeneralResult Add(YDPB_EVAL_APPLY model)
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
					Delete(YDPB_EVAL_APPLY._.ID.SelectIn(idArr));
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
		public GeneralResult Import(List<YDPB_EVAL_APPLY> model)
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
		protected WhereClipBuilder ConditionBuilder(YDPB_EVAL_APPLY model)
		{
			WhereClipBuilder condition = new WhereClipBuilder();
			if (model.ID != null)
			{
				condition.And(YDPB_EVAL_APPLY._.ID == (model.ID));
			}
			if (model.APPLY_TYPE != null)
			{
				condition.And(YDPB_EVAL_APPLY._.APPLY_TYPE == (model.APPLY_TYPE));
			}
			if (!string.IsNullOrWhiteSpace(model.SERIES_NUMBER))
			{
				condition.And(YDPB_EVAL_APPLY._.SERIES_NUMBER.Contain(model.SERIES_NUMBER));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT))
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_PROJECT.Contain(model.TENDER_PROJECT));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
			}
			if (model.TENDER_PROJECT_ID != null)
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_PROJECT_ID == (model.TENDER_PROJECT_ID));
			}
			if (model.BID_EVAL_END_TIME != null)
			{
				condition.And(YDPB_EVAL_APPLY._.BID_EVAL_END_TIME == (model.BID_EVAL_END_TIME));
			}
			if (!string.IsNullOrWhiteSpace(model.REMARK))
			{
				condition.And(YDPB_EVAL_APPLY._.REMARK.Contain(model.REMARK));
			}
			if (model.STATUS != null)
			{
				condition.And(YDPB_EVAL_APPLY._.STATUS == (model.STATUS));
			}
			if (model.CREATOR_ID != null)
			{
				condition.And(YDPB_EVAL_APPLY._.CREATOR_ID == (model.CREATOR_ID));
			}
			if (!string.IsNullOrWhiteSpace(model.CREATOR))
			{
				condition.And(YDPB_EVAL_APPLY._.CREATOR.Contain(model.CREATOR));
			}
			if (model.CREATE_TIME != null)
			{
				condition.And(YDPB_EVAL_APPLY._.CREATE_TIME == (model.CREATE_TIME));
			}
			if (model.DATA_TIMESTAMP != null)
			{
				condition.And(YDPB_EVAL_APPLY._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
			}
			if (model.IS_DELETE != null)
			{
				condition.And(YDPB_EVAL_APPLY._.IS_DELETE == (model.IS_DELETE));
			}
			if (model.EXPERT_COUNT != null)
			{
				condition.And(YDPB_EVAL_APPLY._.EXPERT_COUNT == (model.EXPERT_COUNT));
			}
			if (model.FID != null)
			{
				condition.And(YDPB_EVAL_APPLY._.FID == (model.FID));
			}
			if (!string.IsNullOrWhiteSpace(model.F_SERIES_NUMBER))
			{
				condition.And(YDPB_EVAL_APPLY._.F_SERIES_NUMBER.Contain(model.F_SERIES_NUMBER));
			}
			if (model.EVAL_STATUS != null)
			{
				condition.And(YDPB_EVAL_APPLY._.EVAL_STATUS == (model.EVAL_STATUS));
			}
			if (model.FLAG != null)
			{
				condition.And(YDPB_EVAL_APPLY._.FLAG == (model.FLAG));
			}
			if (model.IS_EVAL_EXPERT != null)
			{
				condition.And(YDPB_EVAL_APPLY._.IS_EVAL_EXPERT == (model.IS_EVAL_EXPERT));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_AGENT_CONTRACT))
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_AGENT_CONTRACT.Contain(model.TENDER_AGENT_CONTRACT));
			}
			if (model.BID_EVAL_START_TIME != null)
			{
				condition.And(YDPB_EVAL_APPLY._.BID_EVAL_START_TIME == (model.BID_EVAL_START_TIME));
			}
			if (!string.IsNullOrWhiteSpace(model.TENDER_AGENT_PHONE))
			{
				condition.And(YDPB_EVAL_APPLY._.TENDER_AGENT_PHONE.Contain(model.TENDER_AGENT_PHONE));
			}
			return condition;
		}
		#endregion
	}
}