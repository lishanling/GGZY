using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TbParticipateService 
    {
        #region 服务门户
        /// <summary>
        /// 收藏|关注
        /// </summary>
        /// <param name="annid">公告ID</param>
        /// <returns></returns>
        public GeneralResult Attention(decimal? annid)
        {
            var r = new GeneralResult();
            if (!annid.HasValue)
            {
                r.SetFail("参数错误");
            }
            else if (IsAttention(annid))
            {
                r.SetSuccess(msg:"您已经参与关注！");
            }
            {
                var model = new TB_PARTICIPATE
                {
                    ID = 0,
                    ANN_ID = annid,
                    U_ID = FwUser.ID
                };
                Insert(model);
                r.SetSuccess(msg:"成功参与关注");
            }
            return r;
        }
        /// <summary>
        /// 是否已经关注
        /// </summary>
        /// <param name="annid">公告ID</param>
        /// <returns></returns>
        public bool IsAttention(decimal? annid)
        {
            var isExist =annid.HasValue&& Exists(TB_PARTICIPATE._.U_ID == FwUser.ID && TB_PARTICIPATE._.ANN_ID == annid);
            return isExist;
        }
        #endregion
    }
}