using System;
using System.Collections.Generic;
using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class UniqueValueValidator : AbstractFieldValidator
    {
        public override string GetName()
        {
            return "UniqueValue";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue("DATA_TYPE");
            if (dataType == 1)
            {
                ValidateUnique(dtContext, DataConfig.TableName, DataConfig.Dao);
                //如果是专项数据，还需要验证另外一张表
                if (DataConfig.IsSaveGGFW())
                {
                    var dataConfigGgfw = DataConfig.GgfwDataConfig;
                    ValidateUnique(dtContext, dataConfigGgfw.TableName, dataConfigGgfw.Dao);
                }
            }

        }

        private void ValidateUnique(DataTable dtContext,string tableName,DAO dao)
        {
            var sql =
                $"select {Constant.M_ID} from {tableName} " +
                $"where {Field} ='{dtContext.GetStringValue(Field).ToClearSql()}'";
            var dt = dao.GetDataSet(sql).Tables[0];
            ThrowHelper.ThrowIfTure(dt.Rows.Count > 0, $"[{Field}]在系统中已存在");
        }

        public override string MockCorrectValue(string value)
        {
            var tablename = DataConfig.TableName;
            if ("PROJECT_CODE".Equals(Field))
            {
                return $"{GetProjectCode(tablename)}";
            }
            if ("TENDER_PROJECT_CODE".Equals(Field))
            {
                return $"{GetTpCode(tablename)}";
            }
            if ("BID_SECTION_CODE".Equals(Field))
            {
                return $"{GetSectionCode(tablename)}";
            }
            return value;
        }

        private static Dictionary<string, string> tenderProjectDict = new Dictionary<string, string>();
        private static Dictionary<string, string> projectDict = new Dictionary<string, string>();
        private static Dictionary<string, string> sectionDict = new Dictionary<string, string>();
        private static int projectSeq = 0;
        private static int tpSeq = 0;
        private static int sectionSeq = 0;

        private string GetProjectCode(string tablename)
        {
            var codeName = "PROJECT_CODE";
            if (tablename.StartsWith("ZJ_") || tablename.StartsWith("JT_")
                || tablename.StartsWith("SL_"))
            {
                codeName = tablename.Substring(0, 3) + codeName;
            }
            if (!projectDict.ContainsKey(codeName))
            {
                projectSeq++;
                projectDict[codeName] = $"M350000{DateTime.Now:ddHHmmss}{projectSeq.ToString().PadLeft(2, '0')}";
            }
            return projectDict[codeName];
        }
        public string GetTpCode(string tablename)
        {
            var codeName = "TENDER_PROJECT_CODE";
            if (tablename.StartsWith("ZJ_") || tablename.StartsWith("JT_")
                || tablename.StartsWith("SL_"))
            {
                codeName = tablename.Substring(0, 3) + codeName;
            }
            if (!tenderProjectDict.ContainsKey(codeName))
            {
                tpSeq++;
                tenderProjectDict[codeName] = GetProjectCode(tablename) + tpSeq.ToString().PadLeft(3, '0');
            }
            return tenderProjectDict[codeName];
        }

        private string GetSectionCode(string tablename)
        {
            var codeName = "BID_SECTION_CODE";
            if (tablename.StartsWith("ZJ_") || tablename.StartsWith("JT_")
                || tablename.StartsWith("SL_"))
            {
                codeName = tablename.Substring(0, 3) + codeName;
            }
            if (!sectionDict.ContainsKey(codeName))
            {
                sectionSeq++;
                sectionDict[codeName] = GetTpCode(tablename) + sectionSeq.ToString().PadLeft(3, '0');
            }
            return sectionDict[codeName];

        }
    }
}