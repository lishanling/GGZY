using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriExtPeopleService : BaseServiceT<ZJPRI_EXT_PEOPLE>
    {
        #region 接口实现
        
		public List<ZJPRI_EXT_PEOPLE> FindList(ZJPRI_EXT_PEOPLE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_EXT_PEOPLE> PageList(ZJPRI_EXT_PEOPLE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_EXT_PEOPLE._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_EXT_PEOPLE._.ID == ID);
			
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
        public GeneralResult Edit(ZJPRI_EXT_PEOPLE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_EXT_PEOPLE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_FILE=model.ID_CARD_FILE;
		entity.BTIME=model.BTIME;
		entity.ETIME=model.ETIME;
		entity.COMPANYNAME=model.COMPANYNAME;
		entity.ZJPRI_CONSTRUCT_KEYPERSON=model.ZJPRI_CONSTRUCT_KEYPERSON;
		entity.ZJPRI_CONSTRUCT_INTERMEDIATE=model.ZJPRI_CONSTRUCT_INTERMEDIATE;
		entity.ZJPRI_REGISTER_PERSON=model.ZJPRI_REGISTER_PERSON;
		entity.ZJPRI_EMPLOYEES_QUALI=model.ZJPRI_EMPLOYEES_QUALI;
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
        public GeneralResult Add(ZJPRI_EXT_PEOPLE model)
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
                    Delete(ZJPRI_EXT_PEOPLE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_EXT_PEOPLE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_EXT_PEOPLE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ID.Contain(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_FILE))
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ID_CARD_FILE.Contain(model.ID_CARD_FILE));
				}
				if(model.BTIME!=null)
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.BTIME==(model.BTIME));
				}
				if(model.ETIME!=null)
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ETIME==(model.ETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANYNAME))
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.COMPANYNAME.Contain(model.COMPANYNAME));
				}
				if(model.ZJPRI_CONSTRUCT_KEYPERSON!=null)
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ZJPRI_CONSTRUCT_KEYPERSON==(model.ZJPRI_CONSTRUCT_KEYPERSON));
				}
				if(model.ZJPRI_CONSTRUCT_INTERMEDIATE!=null)
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ZJPRI_CONSTRUCT_INTERMEDIATE==(model.ZJPRI_CONSTRUCT_INTERMEDIATE));
				}
				if(model.ZJPRI_REGISTER_PERSON!=null)
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ZJPRI_REGISTER_PERSON==(model.ZJPRI_REGISTER_PERSON));
				}
				if(model.ZJPRI_EMPLOYEES_QUALI!=null)
				{
				  condition.And(ZJPRI_EXT_PEOPLE._.ZJPRI_EMPLOYEES_QUALI==(model.ZJPRI_EMPLOYEES_QUALI));
				}
		return condition;
	}
        #endregion
    }
}