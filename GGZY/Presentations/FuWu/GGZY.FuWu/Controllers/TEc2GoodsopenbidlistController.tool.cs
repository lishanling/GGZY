using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2GoodsopenbidlistController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_GOODSOPENBIDLIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Goodsopenbidlists(T_EC2_GOODSOPENBIDLIST model, SearchCondition condition)
        {
            var result = Fw.TEc2GoodsopenbidlistService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_GOODSOPENBIDLIST明细
        /// </summary>
      /// <param name="GOODSOPENBIDLISTCODE">开标明细（货物）编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Goodsopenbidlist(string GOODSOPENBIDLISTCODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2GoodsopenbidlistService.ViewByPk(GOODSOPENBIDLISTCODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_GOODSOPENBIDLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Goodsopenbidlist(T_EC2_GOODSOPENBIDLIST model)
        {
            var result = Fw.TEc2GoodsopenbidlistService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_GOODSOPENBIDLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Goodsopenbidlist(T_EC2_GOODSOPENBIDLIST model)
        {
            var result = Fw.TEc2GoodsopenbidlistService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_GOODSOPENBIDLIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Goodsopenbidlist(string ids)
        {
            var result = Fw.TEc2GoodsopenbidlistService.Delete(ids);
            return JResult(result); 
        }
    }
}