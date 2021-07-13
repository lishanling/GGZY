using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.SchedulerService.JobFactory
{
    public class AssemblyQualifiedTypeNameConverter : ConfigurationConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            Type result = null;
            string typeName = value as string;
            if (!string.IsNullOrWhiteSpace(typeName))
            {
                result = Type.GetType(typeName, false);
                if (result == null)
                {
                    throw new ArgumentException(string.Format("不能加载类型\"{0}\"", typeName));
                }
            }
            return result;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            Type type = value as Type;
            if (type == null)
            {
                throw new ArgumentNullException("value");
            }
            return type.AssemblyQualifiedName;
        }

    }
}
