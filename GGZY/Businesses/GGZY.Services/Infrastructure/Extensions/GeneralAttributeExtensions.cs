using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Extensions
{
  public static  class GeneralAttributeExtensions
    {
        public static T_GENERAL_ATTRIBUTE_V2 ToJdAttribute(this GeneralAttribute model)
        {
            return model.ConvertTo<T_GENERAL_ATTRIBUTE_V2>();
            //return new T_GENERAL_ATTRIBUTE_V2
            //{
            //    ENTITYID=model.EntityId,
            //    ENTITYNAME=model.EntityName,
            //    KEY=model.Key,
            //    VALUE=model.Value,
            //    OBJECTID=model.ObjectId,
            //    MGUID=model.MGUID,
            //    REMARK=model.REMARK
            //};
        }

    

        /// <summary>
        /// Get an attribute of an entity
        /// </summary>
        /// <typeparam name="TPropType">Property type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="key">Key</param>
        /// <param name="entityId">entityId</param>
        /// <param name="objectId">Load a value specific for a certain store; pass 0 to load a value shared for all stores</param>
        /// <returns>Attribute</returns>
        public static TPropType GetAttribute<TPropType>(this object entity,string entityId,string key, string objectId="GGZYJD")
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            string keyGroup =entity.GetType().Name;

            var props =ServicesFactory.GGZYJD.TGeneralAttributeV2Service.GetAttributesForEntity(entityId, keyGroup);
            //little hack here (only for unit testing). we should write ecpect-return rules in unit tests for such cases
            if (props == null)
                return default;

            props = props.Where(x => x.OBJECTID == objectId).ToList();
            if (props.Count == 0)
                return default;

            var prop = props.FirstOrDefault(ga =>
                ga.KEY.Equals(key, StringComparison.InvariantCultureIgnoreCase)); //should be culture invariant

            if (prop == null || string.IsNullOrEmpty(prop.VALUE))
                return default;

            #region  return CommonHelper.To<TPropType>(prop.VALUE);

            var value = prop.VALUE;
            var destinationType = typeof(TPropType);
            var culture = CultureInfo.InvariantCulture;
            if (!string.IsNullOrWhiteSpace(value))
            {

                var sourceType = value.GetType();

                var destinationConverter = TypeDescriptor.GetConverter(destinationType);
                if (destinationConverter.CanConvertFrom(value.GetType()))
                    return (TPropType)destinationConverter.ConvertFrom(null, culture, value);

                var sourceConverter = TypeDescriptor.GetConverter(sourceType);
                if (sourceConverter.CanConvertTo(destinationType))
                    return (TPropType)sourceConverter.ConvertTo(null, culture, value, destinationType);

#pragma warning disable CS0184 // 给定表达式始终不是所提供的(“int”)类型
                if (destinationType.IsEnum && value is int)
#pragma warning restore CS0184 // 给定表达式始终不是所提供的(“int”)类型
                    return (TPropType)Enum.ToObject(destinationType, Convert.ToInt32(value));

                if (!destinationType.IsInstanceOfType(value))
                    return (TPropType)Convert.ChangeType(value, destinationType, culture);
            }

            #endregion
           
            return default;
        }

    }
}
