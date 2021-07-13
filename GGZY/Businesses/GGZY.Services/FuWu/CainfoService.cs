using System;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CainfoService 
    {
        /// <summary>
        /// 保存CA用户最新一次登录信息
        /// </summary>
        /// <param name="cainfo">CA信息</param>
        /// <param name="userId">用户ID</param>
        public void SaveCaUserLastLoginRecord(CAINFO cainfo,decimal?userId)
        {
            try
            {
                var entity = FirstOrNull(CAINFO._.SGD_GET_CERT_SERIAL == cainfo.SGD_GET_CERT_SERIAL);
                if (entity != null)
                {
                    entity.Attach();
                    entity.USER_ID = userId;
                    entity.LOGIN_TM=DateTime.Now;
                    Update(entity);
                }
                else
                {
                    cainfo.ID = 0;
                    cainfo.USER_ID = userId;
                    cainfo.LOGIN_TM = DateTime.Now;
                    Insert(cainfo);
                }
            }
            catch (Exception e)
            {
               Logger.Error($"保存CA用户最新一次登录信息失败:{e.Message}",e);
            }
        }
	}
}