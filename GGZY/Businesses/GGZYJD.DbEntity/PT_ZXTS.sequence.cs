using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>

    public partial class PT_ZXTS 
    {
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_PT_ZXTS";
        }

       
        //public static string StateText(string state)
        //{
        //    switch (state)
        //    {
        //        case "1":
        //            state = "待签收";
        //            break;
        //        case "2":
        //            state = "待受理";
        //            break;
        //        case "3":
        //            state = "不予受理";
        //            break;
        //        case "4":
        //            state = "待处理";
        //            break;
        //        case "5":
        //            state = "已处理";
        //            break;
        //        case "6":
        //            state = "申请撤诉";
        //            break;
        //        case "7":
        //            state = "不予撤诉";
        //            break;
        //        case "8":
        //            state = "同意撤诉";
        //            break;
        //        case "9":
        //            state = "撤销";
        //            break;
        //    }

        //    return state;
        //}
    }
}