using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;

namespace GGZY.DataV4Service.Db
{
    /// <summary>
    /// 数据连接工厂
    /// </summary>
    public class DAOFactory
    {
        /// <summary>
        /// 默认业务数据库
        /// </summary>
        public static DbSession DAOGGFW
        {
            get
            {
                return CreateDAO("ggzyfw");
            }
        }


        public static DbSession DAOXZJD
        {
            get
            {
                return CreateDAO("ggzyjd");
            }
        }
        /// <summary>
        /// 生成数据库对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DbSession CreateDAO(string type)
        {
            return new DbSession(type);
        }

    }
}
