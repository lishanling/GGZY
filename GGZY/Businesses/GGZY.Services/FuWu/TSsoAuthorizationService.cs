using System;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSsoAuthorizationService 
    {
        #region MyRegion
        /// <summary>
        /// 通过client_id uid 获取access_token
        /// </summary>
        /// <param name="client_id"></param>
        /// <param name="uid"></param>
        /// <returns></returns>
        public T_SSO_AUTHORIZATION GetAuthorizationInfo(string client_id, decimal? uid)
        {
            var dbEntity = FirstOrNull(T_SSO_AUTHORIZATION._.CLIENT_ID ==
                                       client_id && T_SSO_AUTHORIZATION._.USER_ID == uid && T_SSO_AUTHORIZATION._.EXPIRAT_TM > DateTime.Now);
            if (dbEntity != null)
            {
                dbEntity.Attach();
                dbEntity.EXPIRAT_TM = DateTime.Now.AddDays(1);
                Update(dbEntity);
            }
            else
            {
                dbEntity=new T_SSO_AUTHORIZATION
                {
                    ID = 0,
                    USER_ID=uid,
                    CREATE_TM = DateTime.Now,
                    EXPIRAT_TM=DateTime.Now.AddDays(1),
                    CLIENT_ID=client_id,
                    ACCESS_TOKEN = Guid.NewGuid().ToString("N")
                };
                Insert(dbEntity);
            }

            return dbEntity;
        }
        /// <summary>
        /// 通过access_token换取 授权信息
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        public T_SSO_AUTHORIZATION AuthorizationInfo(string access_token)
        {
            return FirstOrNull(T_SSO_AUTHORIZATION._.ACCESS_TOKEN == access_token &&
                               T_SSO_AUTHORIZATION._.EXPIRAT_TM > DateTime.Now);
        }

        #endregion
    }
}