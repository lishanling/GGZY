using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;

namespace GGZY.Core.Models
{
    public partial class GeneralAttribute
    {
        #region Properties

        /// <summary>
        /// 实体主键
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 实体扩展属性，对应字段名称 
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 实体扩展属性值，对应字段名称 
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 通用属性归属对象 比如平台标识
        /// </summary>
        public string ObjectId { get; set; }

        public string MGUID { get; set; }

        public string REMARK { get; set; }

        private string CacheKey => $"GenericAttribute:{ObjectId}:{EntityName}:{EntityId}";
        #endregion

        #region Fields



        #endregion

        #region Ctor

        public GeneralAttribute() { }

        #endregion
    }
}