using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GAT.Core.Models;
using GAT.Services.Base;
using GAT.DbEntity;

namespace GAT.Services
{
    public partial class @(Model.FriendlyClassName)Service : BaseServiceT<@(Model.ClassName)>
    {
        #region 接口实现
        
		public List<@(Model.ClassName)> FindList(@(Model.ClassName) model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<@(Model.ClassName)> PageList(@(Model.ClassName) model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
				   @{
	   var sort="";
for(int i=0;i<Model.Columns.Count;i++)
	          {
var item=Model.Columns[i];
var typeName=item.TypeName;
if(typeName=="DateTime"||typeName=="DateTime?")
{
if(sort==""){sort=item.ColumnName;}else if(item.ColumnName=="CREATE_TM"&&sort!="M_TM"&&sort!="TM"){sort=item.ColumnName;}else if(item.ColumnName=="TM"&&sort!="M_TM"){sort=item.ColumnName;}else if(item.ColumnName=="M_TM"){sort=item.ColumnName;}
}
if(sort==""&&Model.PrimaryKeyColumns.Count>0){sort=Model.PrimaryKeyColumns[0].ColumnName;}        
		if(i==Model.Columns.Count-1)
{
       @:var pageList =PageList(condition,search, @(Model.ClassName)._.@(sort).Desc).ToBootstrapTableList(count);
}
}
				   }
            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
	   @foreach(var item in Model.PrimaryKeyColumns)
        {
      @:/// <param name="@(item.ColumnName)">@(item.DeText)</param>
		}
        /// <returns></returns>
	   @{
	   var c="";
for(int i=0;i<Model.PrimaryKeyColumns.Count;i++)
	          {
var item=Model.PrimaryKeyColumns[i];
var typeName=item.TypeName;
if(typeName=="DateTime"||typeName=="DateTime?"){typeName="DateTime?";}
if(typeName=="int"){typeName="decimal?";}
if(typeName=="int?"){typeName="decimal?";}
        c+=typeName+" "+item.ColumnName;
		if(i==Model.PrimaryKeyColumns.Count-1)
{
       @:public GeneralResult ViewByPk(@c)
}
else
{
c+=",";
}
		}
	   }
        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			@foreach(var item in Model.PrimaryKeyColumns)
        {
			@:condition.And(@(Model.ClassName)._.@(item.ColumnName) == @(item.ColumnName));
		}
			
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
        public GeneralResult Edit(@(Model.ClassName) model)
        {
            var result = new GeneralResult();
            try
            {
               @{
	   var d="";
for(int i=0;i<Model.PrimaryKeyColumns.Count;i++)
	          {
var item=Model.PrimaryKeyColumns[i];

        d+="model."+item.ColumnName;
		if(i==Model.PrimaryKeyColumns.Count-1)
{
		@:var viewResult=ViewByPk(@d);
}
else
{
d+=",";
}			
}
}	
	if(viewResult.Success  && viewResult.Data is @(Model.ClassName) entity)
	{		
		entity.Attach();
		@foreach(var item in Model.Columns)
{
		@:entity.@(item.ColumnName)=model.@(item.ColumnName);
}
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
        public GeneralResult Add(@(Model.ClassName) model)
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
                    Delete(@(Model.ClassName)._.@(Model.PrimaryKeyColumns[0].ColumnName).SelectIn(idArr));
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
        public GeneralResult Import(List<@(Model.ClassName)> model)
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
       	protected WhereClipBuilder ConditionBuilder(@Model.ClassName model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
		@foreach (var item in Model.Columns)
		{
			if (item.TypeName.Contains("string") || item.TypeName.Contains("String"))
			{
				@:if(!string.IsNullOrWhiteSpace(model.@(item.ColumnName)))
				@:{
				@:  condition.And(@(Model.ClassName)._.@(item.ColumnName).Contain(model.@(item.ColumnName)));
				@:}
			}
			else //if (item.TypeName.Contains("int")||item.TypeName.Contains("Int32"))
			{
				@:if(model.@(item.ColumnName)!=null)
				@:{
				@:  condition.And(@(Model.ClassName)._.@(item.ColumnName)==(model.@(item.ColumnName)));
				@:}
			}
		}
		return condition;
	}
        #endregion
    }
}