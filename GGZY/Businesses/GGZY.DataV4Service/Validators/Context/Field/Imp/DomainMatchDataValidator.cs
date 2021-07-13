using System;
using System.Collections;
using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class DomainMatchDataValidator : AbstractFieldValidator
    {
        public string Type { get; set; }
        public string Remark { get; set; }

        public override string GetName()
        {
            return "DomainMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                var fieldValue = dtContext.GetStringValue(Field);
                if (fieldValue.Contains(";"))
                {
//                    fieldValue = fieldValue.Trim(';');
                    string[] Each_Type = fieldValue.Split(new []{';'},StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < Each_Type.Length; i++)
                    {
                        IsExistSysDict(Each_Type[i]);
                    }
                }
                else
                {
                    IsExistSysDict(fieldValue);
                }
            }
            
        }

        private void IsExistSysDict(string value)
        {
            var sql = "select VALUE from sys_dic where type='" + Type + "' and value='" + value.ToClearSql() + "'";
            if (!string.IsNullOrEmpty(Remark))
            {
                sql += " and remark='" + Remark + "'";
            }
            
            DataTable dic = DAO.GGFW.GetDataSet(sql).Tables[0];
            ThrowHelper.ThrowIfTure(dic.Rows.Count < 1, $"外键值不匹配,[{Field}]字段的值域中不存在{value}");
        }

        public override string MockCorrectValue(string value)
        {
            var sql = "select VALUE from sys_dic where type='" + Type + "'";
            if (!string.IsNullOrEmpty(Remark))
            {
                sql += " and remark='" + Remark + "'";
            }
            var dt = DAO.GGFW.GetDataSet(sql).Tables[0];
            if (dt.Rows.Count < 1)
            {
                var i = 1;
            }
            var l = value.Length;
            var newValue = dt.Rows[0]["VALUE"].ToString();
            var newL = newValue.Length;
            var count =(int)(l / (newL+1));
            if (count == 0)
            {
                return newValue;
            }
            return GetStrByLength(newValue + ";", count);
//            return dt.Rows[0]["VALUE"].ToString();

        }
    }
}