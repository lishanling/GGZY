using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTpDataService : BaseServiceT<T_TP_DATA>
    {
        #region 接口实现
        
		public List<T_TP_DATA> FindList(T_TP_DATA model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TP_DATA> PageList(T_TP_DATA model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TP_DATA._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TP_DATA._.ID == ID);
			
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
        public GeneralResult Edit(T_TP_DATA model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TP_DATA entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CODE=model.CODE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.UPDATE_TM=model.UPDATE_TM;
		entity.FIELD_1=model.FIELD_1;
		entity.FIELD_2=model.FIELD_2;
		entity.FIELD_3=model.FIELD_3;
		entity.FIELD_4=model.FIELD_4;
		entity.FIELD_5=model.FIELD_5;
		entity.FIELD_6=model.FIELD_6;
		entity.FIELD_7=model.FIELD_7;
		entity.FIELD_8=model.FIELD_8;
		entity.FIELD_9=model.FIELD_9;
		entity.FIELD_10=model.FIELD_10;
		entity.FIELD_11=model.FIELD_11;
		entity.FIELD_12=model.FIELD_12;
		entity.FIELD_13=model.FIELD_13;
		entity.FIELD_14=model.FIELD_14;
		entity.FIELD_15=model.FIELD_15;
		entity.FIELD_16=model.FIELD_16;
		entity.FIELD_17=model.FIELD_17;
		entity.FIELD_18=model.FIELD_18;
		entity.FIELD_19=model.FIELD_19;
		entity.FIELD_20=model.FIELD_20;
		entity.FIELD_21=model.FIELD_21;
		entity.FIELD_22=model.FIELD_22;
		entity.FIELD_23=model.FIELD_23;
		entity.FIELD_24=model.FIELD_24;
		entity.FIELD_25=model.FIELD_25;
		entity.FIELD_26=model.FIELD_26;
		entity.FIELD_27=model.FIELD_27;
		entity.FIELD_28=model.FIELD_28;
		entity.FIELD_29=model.FIELD_29;
		entity.FIELD_30=model.FIELD_30;
		entity.FIELD_31=model.FIELD_31;
		entity.FIELD_32=model.FIELD_32;
		entity.FIELD_33=model.FIELD_33;
		entity.FIELD_34=model.FIELD_34;
		entity.FIELD_35=model.FIELD_35;
		entity.FIELD_36=model.FIELD_36;
		entity.FIELD_37=model.FIELD_37;
		entity.FIELD_38=model.FIELD_38;
		entity.FIELD_39=model.FIELD_39;
		entity.FIELD_40=model.FIELD_40;
		entity.BFIELD_1=model.BFIELD_1;
		entity.BFIELD_2=model.BFIELD_2;
		entity.BFIELD_3=model.BFIELD_3;
		entity.BFIELD_4=model.BFIELD_4;
		entity.BFIELD_5=model.BFIELD_5;
		entity.BFIELD_6=model.BFIELD_6;
		entity.FIELD_41=model.FIELD_41;
		entity.FIELD_42=model.FIELD_42;
		entity.FIELD_43=model.FIELD_43;
		entity.FIELD_44=model.FIELD_44;
		entity.FIELD_45=model.FIELD_45;
		entity.BUSINESSID=model.BUSINESSID;
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
        public GeneralResult Add(T_TP_DATA model)
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
                    Delete(T_TP_DATA._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TP_DATA> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TP_DATA model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TP_DATA._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_TP_DATA._.CODE.Contain(model.CODE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_TP_DATA._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.UPDATE_TM!=null)
				{
				  condition.And(T_TP_DATA._.UPDATE_TM==(model.UPDATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_1))
				{
				  condition.And(T_TP_DATA._.FIELD_1.Contain(model.FIELD_1));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_2))
				{
				  condition.And(T_TP_DATA._.FIELD_2.Contain(model.FIELD_2));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_3))
				{
				  condition.And(T_TP_DATA._.FIELD_3.Contain(model.FIELD_3));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_4))
				{
				  condition.And(T_TP_DATA._.FIELD_4.Contain(model.FIELD_4));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_5))
				{
				  condition.And(T_TP_DATA._.FIELD_5.Contain(model.FIELD_5));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_6))
				{
				  condition.And(T_TP_DATA._.FIELD_6.Contain(model.FIELD_6));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_7))
				{
				  condition.And(T_TP_DATA._.FIELD_7.Contain(model.FIELD_7));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_8))
				{
				  condition.And(T_TP_DATA._.FIELD_8.Contain(model.FIELD_8));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_9))
				{
				  condition.And(T_TP_DATA._.FIELD_9.Contain(model.FIELD_9));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_10))
				{
				  condition.And(T_TP_DATA._.FIELD_10.Contain(model.FIELD_10));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_11))
				{
				  condition.And(T_TP_DATA._.FIELD_11.Contain(model.FIELD_11));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_12))
				{
				  condition.And(T_TP_DATA._.FIELD_12.Contain(model.FIELD_12));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_13))
				{
				  condition.And(T_TP_DATA._.FIELD_13.Contain(model.FIELD_13));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_14))
				{
				  condition.And(T_TP_DATA._.FIELD_14.Contain(model.FIELD_14));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_15))
				{
				  condition.And(T_TP_DATA._.FIELD_15.Contain(model.FIELD_15));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_16))
				{
				  condition.And(T_TP_DATA._.FIELD_16.Contain(model.FIELD_16));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_17))
				{
				  condition.And(T_TP_DATA._.FIELD_17.Contain(model.FIELD_17));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_18))
				{
				  condition.And(T_TP_DATA._.FIELD_18.Contain(model.FIELD_18));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_19))
				{
				  condition.And(T_TP_DATA._.FIELD_19.Contain(model.FIELD_19));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_20))
				{
				  condition.And(T_TP_DATA._.FIELD_20.Contain(model.FIELD_20));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_21))
				{
				  condition.And(T_TP_DATA._.FIELD_21.Contain(model.FIELD_21));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_22))
				{
				  condition.And(T_TP_DATA._.FIELD_22.Contain(model.FIELD_22));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_23))
				{
				  condition.And(T_TP_DATA._.FIELD_23.Contain(model.FIELD_23));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_24))
				{
				  condition.And(T_TP_DATA._.FIELD_24.Contain(model.FIELD_24));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_25))
				{
				  condition.And(T_TP_DATA._.FIELD_25.Contain(model.FIELD_25));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_26))
				{
				  condition.And(T_TP_DATA._.FIELD_26.Contain(model.FIELD_26));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_27))
				{
				  condition.And(T_TP_DATA._.FIELD_27.Contain(model.FIELD_27));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_28))
				{
				  condition.And(T_TP_DATA._.FIELD_28.Contain(model.FIELD_28));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_29))
				{
				  condition.And(T_TP_DATA._.FIELD_29.Contain(model.FIELD_29));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_30))
				{
				  condition.And(T_TP_DATA._.FIELD_30.Contain(model.FIELD_30));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_31))
				{
				  condition.And(T_TP_DATA._.FIELD_31.Contain(model.FIELD_31));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_32))
				{
				  condition.And(T_TP_DATA._.FIELD_32.Contain(model.FIELD_32));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_33))
				{
				  condition.And(T_TP_DATA._.FIELD_33.Contain(model.FIELD_33));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_34))
				{
				  condition.And(T_TP_DATA._.FIELD_34.Contain(model.FIELD_34));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_35))
				{
				  condition.And(T_TP_DATA._.FIELD_35.Contain(model.FIELD_35));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_36))
				{
				  condition.And(T_TP_DATA._.FIELD_36.Contain(model.FIELD_36));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_37))
				{
				  condition.And(T_TP_DATA._.FIELD_37.Contain(model.FIELD_37));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_38))
				{
				  condition.And(T_TP_DATA._.FIELD_38.Contain(model.FIELD_38));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_39))
				{
				  condition.And(T_TP_DATA._.FIELD_39.Contain(model.FIELD_39));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_40))
				{
				  condition.And(T_TP_DATA._.FIELD_40.Contain(model.FIELD_40));
				}
				if(!string.IsNullOrWhiteSpace(model.BFIELD_1))
				{
				  condition.And(T_TP_DATA._.BFIELD_1.Contain(model.BFIELD_1));
				}
				if(!string.IsNullOrWhiteSpace(model.BFIELD_2))
				{
				  condition.And(T_TP_DATA._.BFIELD_2.Contain(model.BFIELD_2));
				}
				if(!string.IsNullOrWhiteSpace(model.BFIELD_3))
				{
				  condition.And(T_TP_DATA._.BFIELD_3.Contain(model.BFIELD_3));
				}
				if(!string.IsNullOrWhiteSpace(model.BFIELD_4))
				{
				  condition.And(T_TP_DATA._.BFIELD_4.Contain(model.BFIELD_4));
				}
				if(!string.IsNullOrWhiteSpace(model.BFIELD_5))
				{
				  condition.And(T_TP_DATA._.BFIELD_5.Contain(model.BFIELD_5));
				}
				if(!string.IsNullOrWhiteSpace(model.BFIELD_6))
				{
				  condition.And(T_TP_DATA._.BFIELD_6.Contain(model.BFIELD_6));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_41))
				{
				  condition.And(T_TP_DATA._.FIELD_41.Contain(model.FIELD_41));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_42))
				{
				  condition.And(T_TP_DATA._.FIELD_42.Contain(model.FIELD_42));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_43))
				{
				  condition.And(T_TP_DATA._.FIELD_43.Contain(model.FIELD_43));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_44))
				{
				  condition.And(T_TP_DATA._.FIELD_44.Contain(model.FIELD_44));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_45))
				{
				  condition.And(T_TP_DATA._.FIELD_45.Contain(model.FIELD_45));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSID))
				{
				  condition.And(T_TP_DATA._.BUSINESSID.Contain(model.BUSINESSID));
				}
		return condition;
	}
        #endregion
    }
}