using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTuisongService 
    {
        /// <summary>
        /// /设置重新推送报建信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ReSendAfcProject(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            if (!model.ID.HasValue)
            {
                r.SetFail("id不能为空");
            }
            else
            {
                using (var trans=GetDbSession().BeginTransaction())
                {
                    trans.Delete<T_TUISONG>(T_TUISONG._.ID == model.ID && T_TUISONG._.TABLENAME == "T_AFC_PROJECT");
                    trans.Delete<T_TUISONG>(T_TUISONG._.ID == model.ID && T_TUISONG._.TABLENAME == "PROJECT_NEW");
                    trans.Commit();
                }
                r.SetSuccess();
            }
            return r;
        }
	}
}