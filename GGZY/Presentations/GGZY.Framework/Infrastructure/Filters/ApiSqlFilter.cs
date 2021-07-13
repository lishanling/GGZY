using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using GGZY.Core.Extensions;
using GGZY.Core.Log;

namespace GGZY.Framework.Infrastructure.Filters
{
    public class ApiSqlFilter :ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

            var actionParameters = actionContext.ActionDescriptor.GetParameters();
            foreach (var p in actionParameters)
            {
                var parmValue = actionContext.ActionArguments[p.ParameterName];
                var pType = p.ParameterType;

                if (parmValue != null)
                {
                    if (pType == typeof(string) || pType == typeof(String))
                    {
                        if (!parmValue.ToString().CheckSqlStr())
                        {
                            actionContext.ActionArguments[p.ParameterName] = parmValue.ToString().FilterSql();
                        }
                    }
                    else if (parmValue is List<string> listStr)
                    {
                        var list1 = new List<string>();
                        foreach (var o in listStr)
                        {
                            list1.Add(!o.ToString().CheckSqlStr() ? o.ToString().FilterSql() : o);
                        }
                        actionContext.ActionArguments[p.ParameterName] = list1;
                    }
                    else if (pType.IsGenericType)
                    {
                        var list = parmValue as IEnumerable<object>;
                        if (list != null)
                        {
                            foreach (var o in list)
                            {
                                SetPValue(o, o.GetType());
                            }
                            actionContext.ActionArguments[p.ParameterName] = list;
                        }
                    }
                    else if (!pType.IsPrimitive && !pType.IsValueType)
                    {

                        SetPValue(parmValue, pType);
                        actionContext.ActionArguments[p.ParameterName] = parmValue;
                    }
                }
            }
            base.OnActionExecuting(actionContext);
        }

        public void SetPValue(object obj, Type type)
        {
            foreach (var prop in type.GetProperties())
            {
                var pValue = prop.GetValue(obj);
                if (pValue != null)
                {

                    if (prop.CanRead && prop.CanWrite)
                    {
                        if (prop.PropertyType == typeof(string) || prop.PropertyType == typeof(String))
                        {
                            if (!pValue.ToString().CheckSqlStr())
                            {
                                var v = Convert.ChangeType(pValue.ToString().FilterSql(), prop.PropertyType);
                                prop.SetValue(obj, v);
                            }
                        }

                        else if (pValue is List<string> listStr)
                        {
                            var list1 = new List<string>();
                            foreach (var o in listStr)
                            {
                                list1.Add(!o.ToString().CheckSqlStr() ? o.ToString().FilterSql() : o);
                            }
                            prop.SetValue(obj, list1);
                        }

                        else if (pValue is IEnumerable<object> list)
                        {
                            foreach (var o in list)
                            {
                                SetPValue(o, o.GetType());
                            }
                            prop.SetValue(obj, list);
                        }
                        else if (!prop.PropertyType.IsPrimitive && !prop.PropertyType.IsValueType)
                        {
                            SetPValue(pValue, prop.PropertyType);
                            prop.SetValue(obj, pValue);
                        }
                    }
                }
            }

        }

    }
}