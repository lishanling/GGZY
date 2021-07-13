using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysAreaService : BaseServiceT<SYS_AREA>
    {
        #region 接口实现
        
		public List<SYS_AREA> FindList(SYS_AREA model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_AREA> PageList(SYS_AREA model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_AREA._.AREACODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="AREACODE"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string AREACODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_AREA._.AREACODE == AREACODE);
			
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
        public GeneralResult Edit(SYS_AREA model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.AREACODE);
	
	if(viewResult.Success  && viewResult.Data is SYS_AREA entity)
	{		
		entity.Attach();
		entity.AREACODE=model.AREACODE;
		entity.AREANAME=model.AREANAME;
		entity.P_X=model.P_X;
		entity.P_Y=model.P_Y;
		entity.A_MAXX=model.A_MAXX;
		entity.A_MAXY=model.A_MAXY;
		entity.A_MINX=model.A_MINX;
		entity.A_MINY=model.A_MINY;
		entity.SHI=model.SHI;
		entity.XIAN=model.XIAN;
		entity.JIEDAO=model.JIEDAO;
		entity.CUN=model.CUN;
		entity.PCODE=model.PCODE;
		entity.PPCODE=model.PPCODE;
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
        public GeneralResult Add(SYS_AREA model)
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
                    Delete(SYS_AREA._.AREACODE.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_AREA> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_AREA model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(SYS_AREA._.AREACODE.Contain(model.AREACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.AREANAME))
				{
				  condition.And(SYS_AREA._.AREANAME.Contain(model.AREANAME));
				}
				if(model.P_X!=null)
				{
				  condition.And(SYS_AREA._.P_X==(model.P_X));
				}
				if(model.P_Y!=null)
				{
				  condition.And(SYS_AREA._.P_Y==(model.P_Y));
				}
				if(model.A_MAXX!=null)
				{
				  condition.And(SYS_AREA._.A_MAXX==(model.A_MAXX));
				}
				if(model.A_MAXY!=null)
				{
				  condition.And(SYS_AREA._.A_MAXY==(model.A_MAXY));
				}
				if(model.A_MINX!=null)
				{
				  condition.And(SYS_AREA._.A_MINX==(model.A_MINX));
				}
				if(model.A_MINY!=null)
				{
				  condition.And(SYS_AREA._.A_MINY==(model.A_MINY));
				}
				if(!string.IsNullOrWhiteSpace(model.SHI))
				{
				  condition.And(SYS_AREA._.SHI.Contain(model.SHI));
				}
				if(!string.IsNullOrWhiteSpace(model.XIAN))
				{
				  condition.And(SYS_AREA._.XIAN.Contain(model.XIAN));
				}
				if(!string.IsNullOrWhiteSpace(model.JIEDAO))
				{
				  condition.And(SYS_AREA._.JIEDAO.Contain(model.JIEDAO));
				}
				if(!string.IsNullOrWhiteSpace(model.CUN))
				{
				  condition.And(SYS_AREA._.CUN.Contain(model.CUN));
				}
				if(!string.IsNullOrWhiteSpace(model.PCODE))
				{
				  condition.And(SYS_AREA._.PCODE.Contain(model.PCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PPCODE))
				{
				  condition.And(SYS_AREA._.PPCODE.Contain(model.PPCODE));
				}
		return condition;
	}
        #endregion
    }
}