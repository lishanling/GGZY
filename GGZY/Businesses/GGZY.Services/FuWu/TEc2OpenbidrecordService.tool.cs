using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2OpenbidrecordService : BaseServiceT<T_EC2_OPENBIDRECORD>
    {
        #region 接口实现
        
		public List<T_EC2_OPENBIDRECORD> FindList(T_EC2_OPENBIDRECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_OPENBIDRECORD> PageList(T_EC2_OPENBIDRECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_OPENBIDRECORD._.OPENBIDRECORDCODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="OPENBIDRECORDCODE">开标记录编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string OPENBIDRECORDCODE,string TENDERPROJECTCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_OPENBIDRECORD._.OPENBIDRECORDCODE == OPENBIDRECORDCODE);
			condition.And(T_EC2_OPENBIDRECORD._.TENDERPROJECTCODE == TENDERPROJECTCODE);
			
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
        public GeneralResult Edit(T_EC2_OPENBIDRECORD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.OPENBIDRECORDCODE,model.TENDERPROJECTCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_OPENBIDRECORD entity)
	{		
		entity.Attach();
		entity.OPENBIDRECORDCODE=model.OPENBIDRECORDCODE;
		entity.OPENBIDRECORDNAME=model.OPENBIDRECORDNAME;
		entity.TENDERPROJECTCODE=model.TENDERPROJECTCODE;
		entity.BIDSECTIONCODES=model.BIDSECTIONCODES;
		entity.BIDOPENINGACTOR=model.BIDOPENINGACTOR;
		entity.BIDOPENINGCONTENT=model.BIDOPENINGCONTENT;
		entity.BIDOPENINGADDRESS=model.BIDOPENINGADDRESS;
		entity.BIDOPENINGTIME=model.BIDOPENINGTIME;
		entity.URL=model.URL;
		entity.ATTACHMENTCODE=model.ATTACHMENTCODE;
		entity.VERSION=model.VERSION;
		entity.ISOPEN=model.ISOPEN;
		entity.OPENTYPE=model.OPENTYPE;
		entity.EXAMINERNAME=model.EXAMINERNAME;
		entity.EXAMINERCODETYPE=model.EXAMINERCODETYPE;
		entity.EXAMINERCODE=model.EXAMINERCODE;
		entity.VERIFYTIME=model.VERIFYTIME;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.CREATE_TIME=model.CREATE_TIME;
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
        public GeneralResult Add(T_EC2_OPENBIDRECORD model)
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
                List<string>idArr=new List<string>();
                foreach (var id in ids)
                {
                    idArr.AddRange(id.Split(','));
                }
				
                if (idArr.Any())
                {
                    Delete(T_EC2_OPENBIDRECORD._.OPENBIDRECORDCODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_EC2_OPENBIDRECORD> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_EC2_OPENBIDRECORD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.OPENBIDRECORDCODE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.OPENBIDRECORDCODE.Contain(model.OPENBIDRECORDCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENBIDRECORDNAME))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.OPENBIDRECORDNAME.Contain(model.OPENBIDRECORDNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERPROJECTCODE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.TENDERPROJECTCODE.Contain(model.TENDERPROJECTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODES))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.BIDSECTIONCODES.Contain(model.BIDSECTIONCODES));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDOPENINGACTOR))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.BIDOPENINGACTOR.Contain(model.BIDOPENINGACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDOPENINGCONTENT))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.BIDOPENINGCONTENT.Contain(model.BIDOPENINGCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDOPENINGADDRESS))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.BIDOPENINGADDRESS.Contain(model.BIDOPENINGADDRESS));
				}
				if(model.BIDOPENINGTIME!=null)
				{
				  condition.And(T_EC2_OPENBIDRECORD._.BIDOPENINGTIME==(model.BIDOPENINGTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_OPENBIDRECORD._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_OPENBIDRECORD._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_OPENBIDRECORD._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_OPENBIDRECORD._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}