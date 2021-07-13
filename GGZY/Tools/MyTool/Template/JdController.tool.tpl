using System;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using GGZY.Framework.Controllers;

namespace GGZY.JianDu.Controllers
{
    public partial class Jd@(Model.FriendlyClassName)Controller:BaseController
    {
        /// <summary>
        /// 读取@(Model.ClassName)列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult Read@(Model.FriendlyClassName)s(@(Model.ClassName) model, SearchCondition condition)
        {
            var result = Jd.@(Model.FriendlyClassName)Service.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取@(Model.ClassName)明细
        /// </summary>
         @foreach(var item in Model.PrimaryKeyColumns)
        {
      @:/// <param name="@(item.ColumnName)">@(item.DeText)</param>
		}
        /// <returns></returns>
        /// <returns></returns>
		@{
	   var c="";
	   var c1="";
for(int i=0;i<Model.PrimaryKeyColumns.Count;i++)
	          {
var item=Model.PrimaryKeyColumns[i];
var typeName=item.TypeName;
if(typeName=="DateTime"||typeName=="DateTime?"){typeName="DateTime?";}
if(typeName=="int"){typeName="decimal";}
if(typeName=="int?"){typeName="decimal?";}
        c+=typeName+" "+item.ColumnName;
        c1+=item.ColumnName;
		if(i==Model.PrimaryKeyColumns.Count-1)
{
       @:public ActionResult Read@(Model.FriendlyClassName)(@c)
}
else
{
c+=",";
c1+=",";
}
			  }
		}        
        {
            var result = Jd.@(Model.FriendlyClassName)Service.ViewByPk(@c1);
            return JResult(result);
        }
        /// <summary>
        /// 创建@(Model.ClassName)信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Create@(Model.FriendlyClassName)(@(Model.ClassName) model)
        {
            var result = Jd.@(Model.FriendlyClassName)Service.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新@(Model.ClassName)信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Update@(Model.FriendlyClassName)(@(Model.ClassName) model)
        {
            var result = Jd.@(Model.FriendlyClassName)Service.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除@(Model.ClassName)信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult Delete@(Model.FriendlyClassName)(string ids)
        {
            var result = Jd.@(Model.FriendlyClassName)Service.Delete(ids);
            return JResult(result); 
        }
    }
}