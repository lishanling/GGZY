using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcXmcodeService 
    {
        /// <summary>
        /// 通过项目编号查找厦门的项目
        /// </summary>
        /// <param name="tzCode"></param>
        /// <returns></returns>
        public List<T_AFC_XMCODE> FindAfcXmCodeByTzCode(string tzCode)
        {
            return FindList(T_AFC_XMCODE._.TZ_CODE == tzCode);
        }
	}
}