using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtTjBgController:BaseController
    {
        /// <summary>
        /// 读取PT_TJ_BG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtTjBgs(PT_TJ_BG model, SearchCondition condition)
        {
            var result = Fw.PtTjBgService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_TJ_BG明细
        /// </summary>
      /// <param name="TM">年月</param>
      /// <param name="QUARTER">季度</param>
      /// <param name="AREACODE">所属地区</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtTjBg(DateTime? TM,decimal QUARTER,string AREACODE)
        
        {
            var result = Fw.PtTjBgService.ViewByPk(TM,QUARTER,AREACODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_TJ_BG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtTjBg(PT_TJ_BG model)
        {
            var result = Fw.PtTjBgService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_TJ_BG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtTjBg(PT_TJ_BG model)
        {
            var result = Fw.PtTjBgService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_TJ_BG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtTjBg(string ids)
        {
            var result = Fw.PtTjBgService.Delete(ids);
            return JResult(result); 
        }
    }
}