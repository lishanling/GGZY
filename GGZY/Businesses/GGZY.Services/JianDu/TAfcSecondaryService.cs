using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcSecondaryService 
    {
        /// <summary>
        /// 通过项目代码获取二装项目信息
        /// </summary>
        /// <param name="tzCode"></param>
        /// <returns></returns>
        public List<T_AFC_SECONDARY> FindAfcSecondaryByTzCode(string tzCode)
        {
            return FindList(T_AFC_SECONDARY._.TZ_CODE == tzCode);
        }
	}
}