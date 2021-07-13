using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TGeneralAttributeV2Service
    {
        #region Constants

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : entity ID
        /// {1} : key group
        /// </remarks>
        private const string GenericAttributeKey = "Sys.GenericAttribute.{0}-{1}";
        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        private const string GenericAttributePatternKey = "Sys.GenericAttribute.";
        #endregion

        /// <summary>
        /// Deletes an attribute
        /// </summary>
        /// <param name="attribute">Attribute</param>
        public virtual void DeleteAttribute(T_GENERAL_ATTRIBUTE_V2 attribute)
        {
            if (attribute == null)
                throw new ArgumentNullException("attribute");

            Delete(attribute);

            //cache
            Cache.RemoveByPattern(GenericAttributePatternKey);

        }
        /// <summary>
        /// Updates the attribute
        /// </summary>
        /// <param name="attribute">Attribute</param>
        public virtual void UpdateAttribute(T_GENERAL_ATTRIBUTE_V2 attribute)
        {
            if (attribute == null)
                throw new ArgumentNullException("attribute");

            Update(attribute);

            //cache
            Cache.RemoveByPattern(GenericAttributePatternKey);

        }


        /// <summary>
        /// Inserts an attribute
        /// </summary>
        /// <param name="attribute">attribute</param>
        public virtual void InsertAttribute(T_GENERAL_ATTRIBUTE_V2 attribute)
        {
            if (attribute == null)
                throw new ArgumentNullException("attribute");

            Insert(attribute);

            //cache
            Cache.RemoveByPattern(GenericAttributePatternKey);

        }
        /// <summary>
        /// Get attributes
        /// </summary>
        /// <param name="entityId">Entity identifier</param>
        /// <param name="entityName">Key group</param>
        /// <param name="prop">Key group</param>
        /// <returns>Get attributes</returns>
        public virtual IList<T_GENERAL_ATTRIBUTE_V2> GetAttributesForEntity(string entityId, string entityName)
        {
            string key = string.Format(GenericAttributeKey, entityId, entityName);
            return Cache.Get(key, () =>
            {
                var attributes = FindList(T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == entityName && T_GENERAL_ATTRIBUTE_V2._.ENTITYID == entityId);
                return attributes;
            });
        }


        /// <summary>
        /// Save attribute value
        /// </summary>
        /// <typeparam name="TPropType">Property type</typeparam>
        /// <param name="entity">entityName</param>
        /// <param name="entityId">entityId</param>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <param name="remark">remark</param>
        /// <param name="objectId">objectId</param>
        public virtual void SaveAttribute<TPropType>(object entity, string key, TPropType value, string entityId = "", string remark = "", string objectId = "GGZYJD")
        {
            var entityType = entity.GetType();
            var entityName = entityType.Name;
            if (entityType == typeof(string))
            {
                entityName = entity.ToString();
            }
            SaveAttribute(entityName, key, value, entityId, remark, objectId);
        }

        /// <summary>
        /// Save attribute value
        /// </summary>
        /// <typeparam name="TPropType">Property type</typeparam>
        /// <param name="entityName">entityName</param>
        /// <param name="entityId">entityId</param>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <param name="remark">remark</param>
        /// <param name="objectId">objectId</param>
        public virtual void SaveAttribute<TPropType>(string entityName, string key, TPropType value, string entityId = "", string remark = "", string objectId = "GGZYJD")
        {
            var props = GetAttributesForEntity(entityId, entityName).ToList();
            var prop = props.FirstOrDefault(ga => ga.KEY.Equals(key, StringComparison.InvariantCultureIgnoreCase)&&ga.OBJECTID.Equals(objectId,StringComparison.CurrentCultureIgnoreCase)); //should be culture invariant

            var valueStr = value?.ToString();

            if (prop != null)
            {
                if (string.IsNullOrWhiteSpace(valueStr))
                {
                    //delete
                    DeleteAttribute(prop);
                }
                else
                {
                    //update
                    prop.Attach();
                    prop.VALUE = valueStr;
                    UpdateAttribute(prop);
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(valueStr))
                {
                    if (string.IsNullOrWhiteSpace(remark))
                    {
                        remark = $"对象{entityName}通用属性{key}记录{entityId}值为{valueStr}";
                    }


                    prop = new T_GENERAL_ATTRIBUTE_V2
                    {
                        MGUID = Guid.NewGuid().ToString("N"),
                        ENTITYNAME = entityName,
                        ENTITYID = entityId,
                        KEY = key,
                        OBJECTID = objectId,
                        REMARK = $"{DateTime.Now:yyyyMMddHHmmss} {remark}",
                        VALUE = valueStr,
                    };
                    InsertAttribute(prop);
                }
            }
        }
    }
}