using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtAtypeService 
    {
       
        public object ArticleType(PT_ATYPE model, SearchCondition search)
        {
            //var all =Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:PT_ATYPE:ALL",()=>FindAll().OrderBy(c=>c.ORDER_ID).ToList());
            var all = FindAll();
            var roots = all.FindAll(c => c.PARENT_ID == model.PARENT_ID&&c.TEXT!="监督内容");//监督内容不展示 hwh提的的修改内容 //todo  应该在数据库中删除这个分类
            var r = roots.Select(type =>
            {
                var children = all.FindAll(c => c.PARENT_ID == type.ID);
                var item= new
                {
                    type.ID,
                    PID = type.PARENT_ID,
                    type.TEXT,
                    ChildrenId = string.Join(",", children.Select(c =>Convert.ToInt32(c.ID))),
                    ChildrenText = string.Join("", children.Select(c => c.TEXT)),
                    Children = children.Select(c => new
                    {
                        c.ID,
                        PID = c.PARENT_ID,
                        c.TEXT,
                        SHOWTYPE = string.IsNullOrWhiteSpace(c.SHOWTYPE) ? "0" : c.SHOWTYPE
                    })
                };
                return item;
            }).ToList();
            return r;
        }


        
    }
}