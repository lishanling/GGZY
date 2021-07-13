using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using Newtonsoft.Json.Linq;

namespace GGZY.Framework.Infrastructure.Filters
{
    public class SqlFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {//application/json;charset=UTF-8
            if (filterContext.HttpContext.Request.ContentType.Contains("application/json"))
            {
                var actionParameters = filterContext.ActionDescriptor.GetParameters();
                try
                {
                    foreach (var p in actionParameters)
                    {
                        if (filterContext.ActionParameters[p.ParameterName] != null)
                        {
                            var parmValue = filterContext.ActionParameters[p.ParameterName];
                            if (p.ParameterType == typeof(string) || p.ParameterType == typeof(String))
                            {
                                if (!parmValue.ToString().CheckSqlStr())
                                {
                                    filterContext.ActionParameters[p.ParameterName] = parmValue.ToString().FilterSql();
                                }
                            }
                            else if (parmValue is List<string> listStr)
                            {
                                var list1 = new List<string>();
                                foreach (var o in listStr)
                                {
                                    list1.Add(!o.ToString().CheckSqlStr() ? o.ToString().FilterSql() : o);
                                }
                                filterContext.ActionParameters[p.ParameterName] = list1;
                            }
                            else if (p.ParameterType.IsGenericType)
                            {
                                var list = parmValue as IEnumerable<object>;
                                if (list != null)
                                {
                                    foreach (var o in list)
                                    {
                                        SetPValue(o, o.GetType());
                                    }
                                    filterContext.ActionParameters[p.ParameterName] = list;
                                }
                            }
                            else if (!p.ParameterType.IsPrimitive && !p.ParameterType.IsValueType)
                            {

                                SetPValue(parmValue, p.ParameterType);
                                filterContext.ActionParameters[p.ParameterName] = parmValue;
                            }
                        }

                    }
                }
                catch (Exception e)
                {
                   Logger.Error($"SqlFilter Error:{e.Message};P:{actionParameters}",e);
                }
            }

            #region MyRegion

            //if (!string.IsNullOrWhiteSpace(inputStream)&&!inputStream.CheckSqlStr())
            //{
            //    JObject jObject = JObject.Parse(inputStream);
            //    foreach (var item in jObject)
            //    {
            //        if (item.Value.Type == JTokenType.Array)
            //        {

            //        }else if (item.Value.Type == JTokenType.Object)
            //        {

            //        }
            //        else if(item.Value!=null&&string.IsNullOrWhiteSpace(item.Value.ToString()))
            //        {
            //            if (!item.Value.ToString().CheckSqlStr())
            //            {
            //                filterContext.ActionParameters[item.Key] = item.Value.ToString().FilterSql();
            //            }
            //            else
            //            {

            //                filterContext.ActionParameters[item.Key] = item.Value;
            //            }

            //        }
            //    }
            //}


            #endregion
            base.OnActionExecuting(filterContext);
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
                                list1.Add(!o.CheckSqlStr() ? o.FilterSql() : o);
                            }
                            prop.SetValue(obj, list1);
                        }
                        else if (pValue is List<int> listInt)
                        {
                            prop.SetValue(obj, listInt);
                        }
                        else if (pValue is List<decimal> listDecimal)
                        {
                            prop.SetValue(obj, listDecimal);
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