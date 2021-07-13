using System;
using System.Data;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Validators.Context.Field.Imp;

namespace GGZY.DataV4Service.Validators.Title
{
    public class Context5FieldValidator : AbstractTitleValidator
    {
        private readonly string _systemNo;

        public Context5FieldValidator(string systemNo)
        {
            _systemNo = systemNo;
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue(Constant.DATA_TYPE);
            if (dataType == 3) return;


            var PLATFORM_CODE = ValidateNullValue(dtContext, Constant.PLATFORM_CODE);
            var PUB_SERVICE_PLAT_CODE = ValidateNullValue(dtContext, Constant.PUB_SERVICE_PLAT_CODE);
            var DATA_TIMESTAMP = ValidateNullValue(dtContext, Constant.DATA_TIMESTAMP);


            ThrowHelper.ThrowIfTure(PLATFORM_CODE.Length != 18, "交易系统标识码长度不正确");
            ThrowHelper.ThrowIfTure(PUB_SERVICE_PLAT_CODE.Length != 18, "交易服务系统标识码长度不正确");
            //如果不是工程建设的不用判断以下两个
            int x = dtTitle.GetIntValue(Constant.DATA_NO, 0);
            if ((x >= 500 && x <= 523) || (x >= 800 && x <= 909) || (x >=9000 && x <= 9640 ))
            {
                var TRADE_PLAT = ValidateNullValue(dtContext, Constant.TRADE_PLAT);
                var PUB_SERVICE_PLAT = ValidateNullValue(dtContext, Constant.PUB_SERVICE_PLAT);
                ThrowHelper.ThrowIfTure(TRADE_PLAT.Length != 11, "电子招标投标交易平台或发布工具标识码长度不正确");
                ThrowHelper.ThrowIfTure(PUB_SERVICE_PLAT.Length != 11, "电子招标投标公共服务平台标识码长度不正确");
            }

            new DateMatchFieldValidator { Field = "DATA_TIMESTAMP", Format = "yyyyMMddHHmmss" }
                .Validate(dtTitle, dtContext);

            string str = Convert.ToString(DAO.GGFW.GetSingle("select PLATFORM_CODE from T_JIEKOU_USER where SYSTEM_NO='" + _systemNo.ToClearSql() + "'"));//数据库中存的交易系统标识码
            if (str != "" && !("," + str + ",").Contains("," + PLATFORM_CODE + ","))
            {
                ThrowHelper.ThrowIfTure(true, "交易系统标识码[PLATFORM_CODE]填写无效");
            }
        }
    }
}