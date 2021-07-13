using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2OpenbidrecordController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_OPENBIDRECORD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Openbidrecords(T_EC2_OPENBIDRECORD model, SearchCondition condition)
        {
            var result = Fw.TEc2OpenbidrecordService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_OPENBIDRECORD明细
        /// </summary>
      /// <param name="OPENBIDRECORDCODE">开标记录编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Openbidrecord(string OPENBIDRECORDCODE,string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2OpenbidrecordService.ViewByPk(OPENBIDRECORDCODE,TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_OPENBIDRECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Openbidrecord(T_EC2_OPENBIDRECORD model)
        {
            var result = Fw.TEc2OpenbidrecordService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_OPENBIDRECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Openbidrecord(T_EC2_OPENBIDRECORD model)
        {
            var result = Fw.TEc2OpenbidrecordService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_OPENBIDRECORD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Openbidrecord(string ids)
        {
            var result = Fw.TEc2OpenbidrecordService.Delete(ids);
            return JResult(result); 
        }
    }
}