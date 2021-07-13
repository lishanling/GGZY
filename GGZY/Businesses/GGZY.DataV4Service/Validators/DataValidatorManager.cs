using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Validators.Context.Field;
using GGZY.DataV4Service.Validators.Context.Field.Imp;
using GGZY.DataV4Service.Validators.Context.Table;

namespace GGZY.DataV4Service.Validators
{
    public class DataValidatorManager
    {

        private static Dictionary<string, Type> _typeDict;

        public static void Init()
        {
            _typeDict = new Dictionary<string, Type>();
            var types = typeof(IDataValidator).Assembly.GetTypes();
            foreach (var type in types)
            {
                if ((typeof(AbstractFieldValidator).IsAssignableFrom(type)
                    || typeof(AbstractTableValidator).IsAssignableFrom(type))
                    && !type.IsAbstract)
                {
                    //                    _typeDict["NotNull"] = typeof(NotNullDataValidator);
                    var validator = Activator.CreateInstance(type, true) as IDataValidator;
                    _typeDict[validator.GetName()] = type;
                    
                }
            }
            
            
        }

        public static Type GetDataValidateType(string name)
        {
            if (_typeDict == null)
            {
                Init();
            }
            var type = _typeDict.GetValue(name);
            return type;
        }

        public static Dictionary<string, string> GetAll()
        {
            if (_typeDict == null)
            {
                Init();
            }
            var dict = new Dictionary<string,string>();
            foreach (var kv in _typeDict)
            {
                var type = kv.Value;
                var pros = string.Join(",", type.GetProperties().Select(e => e.Name).ToList());
                dict[kv.Key] = pros;
            }
            return dict;
        }
    }
}