using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class SECTION: JdEntity
    {
        /// <summary>
        /// 构造函数，客户端提交数据时过滤非开放数据
        /// </summary>
        /// <param name="sec"></param>
        /// <param name="now"></param>
        public SECTION(SECTION sec, DateTime? now = null)
        {
            if (!now.HasValue)
            {
                now = DateTime.Now;
            }
            M_ID = 0;
            BID_SECTION_NAME = sec.BID_SECTION_NAME;
            BID_SECTION_CONTENT = sec.BID_SECTION_CONTENT;
            TENDER_PROJECT_CLASSIFY_CODE = sec.TENDER_PROJECT_CLASSIFY_CODE;
            CONTRACT_RECKON_PRICE = sec.CONTRACT_RECKON_PRICE;
            CURRENCY_CODE = sec.CURRENCY_CODE;
            PRICE_UNIT = sec.PRICE_UNIT;
            BID_QUALIFICATION = sec.BID_QUALIFICATION;
            BEGIN_DATE = sec.BEGIN_DATE;
            LIMITE_TIME = sec.LIMITE_TIME;
            DATA_TIMESTAMP = now;
            CREATE_TIME = now;
            CONTROL_PRICE = sec.CONTROL_PRICE;
            CONTROL_PRICE_CURRENCY = sec.CONTROL_PRICE_CURRENCY;
            CONTROL_PRICE_UNIT = sec.CONTROL_PRICE_UNIT;
        }
        public SECTION()
        {

        }
        public override string GetSequence()
        {
            return "seq_section";
        }

        public override Field GetIdentityField()
        {
            return _.M_ID;
        }
    }
}
