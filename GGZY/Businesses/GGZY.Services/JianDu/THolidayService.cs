using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class THolidayService
    {
        /// <summary>
        /// 判断是否是工作日
        /// </summary>
        /// <param name="tm">时间</param>
        /// <returns></returns>
        public bool IsWorkTime(DateTime tm)
        {
            var date = tm.Date;
            var holiday = FirstOrNull(T_HOLIDAY._.TM == date);
            if (holiday != null)
            {
                if (holiday.TYPE == "1")
                    return false; //节假日
                if (holiday.TYPE == "2") return true; //周末补休
            }
            //获取日历中不上班的标准周末时间,判断是不是上班时间
            if (tm.DayOfWeek == DayOfWeek.Sunday || tm.DayOfWeek == DayOfWeek.Saturday)
                return false; //节假日
            return true;
        }

        /// <summary>
        /// 超时时间
        /// </summary>
        /// <param name="hTm"></param>
        /// <param name="d">默认3</param>
        /// <returns></returns>
        public DateTime OverTime(DateTime hTm,int d=3)
        {
            int count = 0;
            var dayCount = Math.Abs(d);
            while (count < dayCount)
            {
                hTm =d>0? hTm.AddDays(+1):hTm.AddDays(-1);

                if (IsWorkTime(hTm)) count++; //是工作日,+1
            }

            return hTm;
        }
        /// <summary>
        /// 取得工作日的日期
        /// </summary>
        /// <param name="tm">当前日期</param>
        /// <param name="d">几个工作日</param>
        /// <returns></returns>
        public  DateTime GetWorkDate(DateTime tm, int d)
        {
            DateTime hTm = tm;
            var dayCount = Math.Abs(d);
            if (tm.TimeOfDay.Hours >= 16)
            {

                dayCount++;
            }
            if (dayCount == 0 && !IsWorkTime(hTm))
            { //加0个工作日，判断当天是否工作日，
                dayCount++;
            }
            int count = 0;
            while (count < dayCount)
            {
                hTm =d>0? hTm.AddDays(+1):hTm.AddDays(-1);
                if (IsWorkTime(hTm)) count++; //是工作日,+1
            }
            return hTm;
        }



    }
}