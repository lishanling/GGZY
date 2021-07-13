using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTMultimediaDataController:BaseController
    {
        /// <summary>
        /// 读取T_MULTIMEDIA_DATA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTMultimediaDatas(T_MULTIMEDIA_DATA model, SearchCondition condition)
        {
            var result = Jd.TMultimediaDataService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MULTIMEDIA_DATA明细
        /// </summary>
      /// <param name="ID">主键</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMultimediaData(decimal ID)
        
        {
            var result = Jd.TMultimediaDataService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MULTIMEDIA_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMultimediaData(T_MULTIMEDIA_DATA model)
        {
            var result = Jd.TMultimediaDataService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MULTIMEDIA_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMultimediaData(T_MULTIMEDIA_DATA model)
        {
            var result = Jd.TMultimediaDataService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MULTIMEDIA_DATA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMultimediaData(string ids)
        {
            var result = Jd.TMultimediaDataService.Delete(ids);
            return JResult(result); 
        }
    }
}