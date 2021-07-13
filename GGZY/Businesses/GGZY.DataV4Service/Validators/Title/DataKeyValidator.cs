using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Title
{
    public class DataKeyValidator : AbstractTitleValidator
    {
        private readonly string _systemNo;

        public DataKeyValidator(string systemNo)
        {
            _systemNo = systemNo;
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataKey = ValidateNullValue(dtTitle, "DATA_KEY");
            
            ThrowHelper.ThrowIfTure(dataKey.Length != 22, "DATA_KEY长度有误");

            var DATA_KEY_SYSNO = dataKey.Substring(0, 4);
            var DATA_KEY_DATA_NO = dataKey.Substring(4, 3);
            var DATA_KEY_DATA_NO_four = dataKey.Substring(4, 4);//新出排污权等的编码是四位数的

            ThrowHelper.ThrowIfTure(DATA_KEY_SYSNO != _systemNo, $"DATA_KEY中有SYSTEM_NO不等于{_systemNo}");
            var dataNo = dtTitle.GetStringValue("DATA_NO");
            ThrowHelper.ThrowIfTure(DATA_KEY_DATA_NO != dataNo && DATA_KEY_DATA_NO_four != dataNo,
                $"DATA_KEY有DATA_NO不等于{dataNo}");
            

            string sql = $"select {DataConfig.M_KEY_Field},M_DATA_SOURCE,M_TM from " + DataConfig.TableName 
                + $" where {DataConfig.M_KEY_Field}='" + dataKey.ToClearSql() + "'";
            //DataConfig.Dao.BeginTransaction();
            DataTable dt = DataConfig.Dao.GetDataSet(sql).Tables[0];

            //DataConfig.Dao.CommitTransaction();
            var dataSource = dt.GetStringValue("M_DATA_SOURCE");
           
            var dataType = dtTitle.GetIntValue("DATA_TYPE");
            if (!string.IsNullOrEmpty(dataSource))
            {
                ThrowHelper.ThrowIfTure(dataType == 1, "DATA_KEY为" + dataKey + "已存在");
                ThrowHelper.ThrowIfTure(!dataSource.Equals(_systemNo), "当前的DATA_KEY无权操作");
            }
            else
            {
                ThrowHelper.ThrowIfTure(dataType == 2 || dataType == 3, "DATA_KEY为" + dataKey + "不存在");
            }

        }
    }
}