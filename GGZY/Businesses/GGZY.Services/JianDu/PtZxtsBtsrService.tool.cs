using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsBtsrService : BaseServiceT<PT_ZXTS_BTSR>
    {
        #region 接口实现
        
		public List<PT_ZXTS_BTSR> FindList(PT_ZXTS_BTSR model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ZXTS_BTSR> PageList(PT_ZXTS_BTSR model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_ZXTS_BTSR._.ID.Desc).ToBootstrapTableList(count);

            
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
			var condition=new WhereClipBuilder();
			condition.And(PT_ZXTS_BTSR._.ID == ID);
			
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
        public GeneralResult Edit(PT_ZXTS_BTSR model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_ZXTS_BTSR entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TS_ID=model.TS_ID;
		entity.NAME=model.NAME;
		entity.TYPE=model.TYPE;
		entity.CODE=model.CODE;
		entity.ADRESS=model.ADRESS;
		entity.CONTACT=model.CONTACT;
		entity.CONTACT_PHONE=model.CONTACT_PHONE;
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
        public GeneralResult Add(PT_ZXTS_BTSR model)
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
                    Delete(PT_ZXTS_BTSR._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ZXTS_BTSR> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_ZXTS_BTSR model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_ZXTS_BTSR._.ID==(model.ID));
				}
				if(model.TS_ID!=null)
				{
				  condition.And(PT_ZXTS_BTSR._.TS_ID==(model.TS_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(PT_ZXTS_BTSR._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(PT_ZXTS_BTSR._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(PT_ZXTS_BTSR._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADRESS))
				{
				  condition.And(PT_ZXTS_BTSR._.ADRESS.Contain(model.ADRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT))
				{
				  condition.And(PT_ZXTS_BTSR._.CONTACT.Contain(model.CONTACT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_PHONE))
				{
				  condition.And(PT_ZXTS_BTSR._.CONTACT_PHONE.Contain(model.CONTACT_PHONE));
				}
		return condition;
	}
        #endregion
    }
}