using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalApplyDetailService : BaseServiceT<YDPB_EVAL_APPLY_DETAIL>
    {
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public YDPB_EVAL_APPLY_DETAIL ViewByPkModel(decimal? ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_APPLY_DETAIL._.ID == ID);

            var dbModel = FirstOrNull(condition);
            return dbModel;
        }
    }
}
