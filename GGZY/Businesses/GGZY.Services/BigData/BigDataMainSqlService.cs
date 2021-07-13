using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;

namespace GGZY.Services.BigData
{
    public partial class BigDataMainService
    {
        public List<Tuple<string, string, string>> sqlTuple => new List<Tuple<string, string, string>>()
        {
            new Tuple<string, string, string>("Main_TotalAmountCount", "",
                @"SELECT SUM(AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT
FROM v_big_allresult  t where 1=1   ###sql_where_tm###
"),
            new Tuple<string, string, string>("Main_TotalAmountCount_Rate", "",
                @"select type,SUM(AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
from v_big_allresult
where 1=1   
 ###sql_where_tm### group by type
"),
            new Tuple<string, string, string>("Main_JieYueAmount", "",
                @"select type,sum(AMOUNT)/10000 TOTAL_AMOUNT
from (
  /*工程建设节约*/
  select '工程建设' TYPE, b.NOTICE_SEND_TIME AS M_TM,
        (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
          - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END) 
           AMOUNT
  from SECTION  a
  inner join (select * from win_result_anno where (bid_section_code,BID_AMOUNT,m_tm) in (select  bid_section_code,BID_AMOUNT,max(m_tm) from win_result_anno group by bid_section_code,BID_AMOUNT)) b on a.bid_section_code=b.bid_section_code
  where nvl(a.CONTRACT_RECKON_PRICE,0)<>0  and nvl(b.BID_AMOUNT,0)<>0
   and ((CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
        - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END))>0
        and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END)<=300000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)<=300000
  union all
  /*政府采购节约*/
  select '政府采购' TYPE, b.WIN_BID_BULLETIN_START_TIME AS M_TM,
        (CASE to_char(a.UNIT_BUDGET) WHEN '1' THEN a.PROGRAM_BUDGET ELSE  a.PROGRAM_BUDGET/10000 END) 
          - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.WIN_BID_PRICE ELSE   b.WIN_BID_PRICE/10000 END) 
           AMOUNT
  from PURCHASE_PROJECT  a
  inner join BID_DEAL_ANNOUNCE b on a.PURCHASE_PROJECT_CODE=b.PURCHASE_PROJECT_CODE
  where nvl(a.PROGRAM_BUDGET,0)<>0  and nvl(b.WIN_BID_PRICE,0)<>0  
  and ((CASE to_char(a.UNIT_BUDGET) WHEN '1' THEN a.PROGRAM_BUDGET ELSE  a.PROGRAM_BUDGET/10000 END) 
        - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.WIN_BID_PRICE ELSE   b.WIN_BID_PRICE/10000 END))>0
        and (CASE to_char(a.UNIT_BUDGET) WHEN '1' THEN a.PROGRAM_BUDGET ELSE  a.PROGRAM_BUDGET/10000 END)<=300000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.WIN_BID_PRICE ELSE   b.WIN_BID_PRICE/10000 END)<=300000
) aa
where 1=1        

 ###sql_where_tm### group by type
"),
            new Tuple<string, string, string>("Main_AddAmount", "",
                @"select type,sum(AMOUNT)/10000 TOTAL_AMOUNT
from (
  /*9 国有产权交易（实物资产类）*/
  select '产权交易' TYPE, b.TRADE_DATE AS M_TM,
        (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN b.TRADE_VALUE ELSE  b.TRADE_VALUE/10000 END) 
          - (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN  a.PROJECT_PRICE ELSE   a.PROJECT_PRICE/10000 END) 
           AMOUNT
  from LISTING_PUB_INFO  a
  inner join TRADE_RESULT_INFO b on a.PROJECT_CODE=b.PROJECT_CODE
  where nvl(a.PROJECT_PRICE,0)<>0  and nvl(b.TRADE_VALUE,0)<>0  
  and ((CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.TRADE_VALUE ELSE   b.TRADE_VALUE/10000 END)
      - (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.PROJECT_PRICE ELSE  a.PROJECT_PRICE/10000 END) 
        )>0
        and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.PROJECT_PRICE ELSE  a.PROJECT_PRICE/10000 END)<=200000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.TRADE_VALUE ELSE   b.TRADE_VALUE/10000 END)<=200000
  union all
  /*10 国有产权交易（股权类）数据集*/
  select '产权交易' TYPE, b.TRADE_DATE M_TM,
         (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN b.TRADE_VALUE ELSE  b.TRADE_VALUE/10000 END) 
          - (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN  a.PROJECT_PRICE ELSE   a.PROJECT_PRICE/10000 END) 
           AMOUNT
  from STOCK_LISTING_PUB_INFO  a
  inner join STOCK_TRADE_RESULT_INFO b on a.PROJECT_CODE=b.PROJECT_CODE
  where nvl(a.PROJECT_PRICE,0)<>0  and nvl(b.TRADE_VALUE,0)<>0
  and ((CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.TRADE_VALUE ELSE   b.TRADE_VALUE/10000 END)
  - (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.PROJECT_PRICE ELSE  a.PROJECT_PRICE/10000 END) )>0
        and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.PROJECT_PRICE ELSE  a.PROJECT_PRICE/10000 END)<=200000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.TRADE_VALUE ELSE   b.TRADE_VALUE/10000 END)<=200000
) aa
where 1=1       
 ###sql_where_tm###   group by type
"),
            new Tuple<string, string, string>("Main_ChartAmountCount_Month", "",
                @"select type,to_char(M_TM,'yyyy-mm') TM,SUM(AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
from v_big_allresult
where 1=1    
###sql_where_tm### 
group by type,to_char(M_TM,'yyyy-mm')
      order by type,to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("Main_ChartAmountCount_Day", "",
                @"select type,to_char(M_TM,'yyyy-mm-dd') TM,SUM(AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
from MV_ALLRESULT
where 1=1  
###sql_where_tm###
group by type,to_char(M_TM,'yyyy-mm-dd')
      order by type,to_char(M_TM,'yyyy-mm-dd')
"),
            new Tuple<string, string, string>("CQ_List_AmountCount_sheng", "",
                @"select a.areaname,nvl( TOTAL_AMOUNT/10000,'0') TOTAL_AMOUNT,nvl(TOTAL_COUNT,0) TOTAL_COUNT
from (select areacode,areaname from DSJ_AREA where pcode='350000') a
left join (
  select substr(areacode, 0, 4)||'00' areacode,SUM(WIN_AMOUNT) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
  from V_BIG_GUQUAN    
  where 1=1 and  add_amount>0 and type=:type
###sql_where_tm###  
group by substr(areacode, 0, 4)
        ) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("CQ_List_AmountCount", "",
                @"
select a.areaname,nvl( TOTAL_AMOUNT/10000,'0') TOTAL_AMOUNT,nvl(TOTAL_COUNT,0) TOTAL_COUNT
from (select areacode,areaname from DSJ_AREA where pcode=#pareacode#) a
left join (
  select areacode,SUM(WIN_AMOUNT) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
  from V_BIG_GUQUAN    
  where 1=1 and type=:type and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) 
###sql_where_tm### 
group by areacode
        ) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("CQ_Chart_RateType", "",
                @"select type,SUM(WIN_AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
 from V_BIG_GUQUAN    
  where 1=1 
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm###  group by type
"),
            new Tuple<string, string, string>("CQ_Chart_RateJYType", "",
                @" select JY_TYPE,SUM(WIN_AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
 from V_BIG_GUQUAN    
  where 1=1 
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm###  
group by JY_TYPE
"),
            new Tuple<string, string, string>("CQ_Value_AmountCount", "",
                @"select type,SUM(WIN_AMOUNT/10000) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT ,sum(ADD_AMOUNT/10000) ADD_AMOUNT,round(sum(ADD_AMOUNT)*100/sum(PLAN_AMOUNT),2) ADD_RATE
from V_BIG_GUQUAN    
where 1=1 and add_amount>0
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm###  group by type
"),
            new Tuple<string, string, string>("CQ_Value_Rate", "",
                @"select round( sum(CASE when PROJECT_CODE is null THEN 0 ELSE  1 END )*100  /count(1),2) Rate
from (
select b.PROJECT_CODE from
LISTING_PUB_INFO a
left join TRADE_RESULT_INFO b on a.PROJECT_CODE=b.PROJECT_CODE  
inner join DSJ_AREA area ON a.ZONE=area.AREACODE
where 1=1  
###sql_where_publish###
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
union all 
 select b.PROJECT_CODE
          from STOCK_LISTING_PUB_INFO a
          left join STOCK_TRADE_RESULT_INFO b
            on a.PROJECT_CODE = b.PROJECT_CODE
         inner join DSJ_AREA area
            ON a.M_ZONE = area.AREACODE
            where 1=1
###sql_where_publish###
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
)
"),
            new Tuple<string, string, string>("CQ_Table_AmountCount_Plan", "",
                @" select type,SUM(PLAN_AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
 from (
    select 'sw' as Type,a.PUBLISH_DATE
           , CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.PROJECT_PRICE ELSE  a.PROJECT_PRICE/10000 END  PLAN_AMOUNT
           ,a.PUBLISH_DATE M_TM
           ,area.areaname,area.areacode
    from LISTING_PUB_INFO a
    inner join DSJ_AREA area ON a.ZONE=area.AREACODE
    union all
    select 'gq' as Type,a.PUBLISH_DATE
           , CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.PROJECT_PRICE ELSE  a.PROJECT_PRICE/10000 END  PLAN_AMOUNT
           ,a.PUBLISH_DATE M_TM
           ,area.areaname,area.areacode
    from STOCK_LISTING_PUB_INFO a
    inner join TRANSFER_ENTE_INFO c on a.project_code=c.project_code
    inner join DSJ_AREA area ON c.ZONE=area.AREACODE
 ) a
  where 1=1 
###sql_where_tm### 
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
 group by type
"),
            new Tuple<string, string, string>("CQ_Chart_JiaoYiByDate", "",
                @"select to_char(M_TM,'yyyy-mm') TM,SUM(PLAN_AMOUNT)/10000 PLAN_AMOUNT,SUM(WIN_AMOUNT)/10000 AS WIN_AMOUNT,SUM(ADD_AMOUNT)/10000 ADD_AMOUNT 
    from V_BIG_GUQUAN   
    where 1=1 and add_amount>0
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm### 
group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("GCJS_LeftAmountCount_sheng", "",
                @"select a.areaname,nvl( TOTAL_AMOUNT,'0') TOTAL_AMOUNT,nvl(TOTAL_COUNT,0) TOTAL_COUNT
from (select areacode,areaname from DSJ_AREA where pcode='350000') a
left join (
  select substr(areacode, 0, 4)||'00' areacode,SUM(AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
  from v_big_allresult
  where type='工程建设' 
###sql_where_tm###  
###tendertypeS### project_type in ($tendertype$)  ###tendertypeE###
 group by substr(areacode, 0, 4)
        ) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("GCJS_LeftAmountCount", "",
                @"select a.areaname,nvl( TOTAL_AMOUNT,'0')/10000 TOTAL_AMOUNT,nvl(TOTAL_COUNT,0) TOTAL_COUNT
from (select areacode,areaname from DSJ_AREA where pcode=:pareacode) a
left join (
  select areacode,SUM(AMOUNT) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
  from v_big_allresult
  where type='工程建设' 
###tendertypeS### project_type in ($tendertype$)  ###tendertypeE###
###pareacodeS### and areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm### 
group by areacode
 ) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("GCJS_LeftJieYue_sheng", "",
                @"select a.areaname,nvl( AMOUNT,'0') TOTAL_AMOUNT
from (select areacode,areaname from DSJ_AREA where pcode='350000') a
left join (
  select substr(area.areacode, 0, 4)||'00' areacode, 
         sum(
      (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
        - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END) 
          )/10000
           AMOUNT
  from SECTION  a
  inner join WIN_RESULT_ANNO b on a.bid_section_code=b.bid_section_code
  inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = b.TENDER_PROJECT_CODE
  inner join DSJ_AREA AREA on AREA.OLDCODE = PRO.REGION_CODE
  where nvl(a.CONTRACT_RECKON_PRICE,0)<>0  and nvl(b.BID_AMOUNT,0)<>0
  and ((CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
        - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END))>0
   and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END)<=300000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)<=300000
###sql_where_Winbid_tm###  
group by substr(area.areacode, 0, 4)||'00'
        ) b on a.areacode=b.areacode
        order by TOTAL_AMOUNT desc
"),
            new Tuple<string, string, string>("GCJS_LeftJieYue", "",
                @"select a.areaname,nvl( AMOUNT,'0')/10000 TOTAL_AMOUNT
from (select areacode,areaname from DSJ_AREA where pcode=#pareacode#) a
left join (
  select area.areacode, 
         sum(
      (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
        - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END) 
          )/10000
           AMOUNT
  from SECTION  a
  inner join WIN_RESULT_ANNO b on a.bid_section_code=b.bid_section_code
  inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = b.TENDER_PROJECT_CODE
  inner join DSJ_AREA AREA on AREA.OLDCODE = PRO.REGION_CODE
  where nvl(a.CONTRACT_RECKON_PRICE,0)<>0  and nvl(b.BID_AMOUNT,0)<>0
  and ((CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
        - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END))>0
   and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END)<=300000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)<=300000  
  and area.areacode in (select areacode from DSJ_AREA where pcode=:pareacode)
###tendertypeS### pro.project_type in ($tendertype$)  ###tendertypeE###

###sql_where_Winbid_tm###  
 group by area.areacode
        ) b on a.areacode=b.areacode
        order by TOTAL_AMOUNT desc
"),
            new Tuple<string, string, string>("GCJS_ChartType", "",
                @" select b.TEXT TYPE,SUM(AMOUNT)/10000 AS AMOUNT
  from v_big_allresult a
  right join  (select VALUE,TEXT from sys_dic where type='2002' and pid='2525')  b on a.PROJECT_TYPE=b.VALUE
  where type='工程建设' 
###pareacodeS### and a.areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm### 
 group by b.TEXT
"),
            new Tuple<string, string, string>("GCJS_JiaoYeMethod", "",
                @"
select b.TEXT TYPE,SUM(AMOUNT)/10000 AS AMOUNT,COUNT(1) TOTAL_COUNT
  from v_big_allresult a
  inner join  (select VALUE,TEXT from sys_dic where type='1000')  b on a.TENDER_MODE=b.VALUE
  where type='工程建设' AND substr(AREACODE,0,2)='35'
###tendertypeS### project_type in ($tendertype$)  ###tendertypeE###
###pareacodeS### and a.areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_tm### group by b.TEXT
"),
            new Tuple<string, string, string>("GCJS_ChartJieYue_Month", "",
                @"
select  to_char(M_TM,'yyyy-mm') TM,sum(AMOUNT)/10000 AMOUNT  
from ( 
    select area.areacode,         
        (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
          - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)          
             AMOUNT,b.M_TM as M_TM
    from SECTION  a
    inner join WIN_RESULT_ANNO b on a.bid_section_code=b.bid_section_code
    inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = b.TENDER_PROJECT_CODE
    inner join DSJ_AREA AREA on AREA.OLDCODE = PRO.REGION_CODE
    where nvl(a.CONTRACT_RECKON_PRICE,0)<>0  and nvl(b.BID_AMOUNT,0)<>0 
    and ((CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
          - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END))>0
   and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END)<=200000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)<=200000  
###pareacodeS### and AREA.areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_Winbid_tm### 
) aa
      group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("GCJS_ChartJieYue_Day", "",
                @"select  to_char(M_TM,'yyyy-mm-dd') TM,sum(AMOUNT)/10000 AMOUNT  
from ( 
    select area.areacode,         
        (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
          - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)       
             AMOUNT,b.M_TM as M_TM
    from SECTION  a
    inner join WIN_RESULT_ANNO b on a.bid_section_code=b.bid_section_code
    inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = b.TENDER_PROJECT_CODE
    inner join DSJ_AREA AREA on AREA.OLDCODE = PRO.REGION_CODE
    where nvl(a.CONTRACT_RECKON_PRICE,0)<>0  and nvl(b.BID_AMOUNT,0)<>0
    and ((CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END) 
          - (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END))>0
   and (CASE to_char(a.PRICE_UNIT) WHEN '1' THEN a.CONTRACT_RECKON_PRICE ELSE  a.CONTRACT_RECKON_PRICE/10000 END)<=300000   
   and (CASE to_char(b.PRICE_UNIT) WHEN '1' THEN  b.BID_AMOUNT ELSE   b.BID_AMOUNT/10000 END)<=300000  
###pareacodeS### and AREA.areacode in (select areacode from DSJ_AREA where pcode=:pareacode) ###pareacodeE###
###sql_where_Winbid_tm###  
 ) aa
      group by to_char(M_TM,'yyyy-mm-dd')
      order by to_char(M_TM,'yyyy-mm-dd')
"),
            new Tuple<string, string, string>("PROXY_Amount", "",
                @"select * 
from     
(    
    SELECT TENDER_AGENCY_NAME,SUM(AMOUNT) AS TOTAL_AMOUNT
    from V_BIG_PROXY
    where 1=1 
###sql_where_tm###  
 group by TENDER_AGENCY_NAME
    order by SUM(AMOUNT) desc
) aa
where rownum<=10
"),
            new Tuple<string, string, string>("PROXY_Count", "",
                @"
select * 
from     
(    
    SELECT TENDER_AGENCY_NAME,COUNT(1) TOTAL_COUNT
    from V_BIG_PROXY
    where 1=1 and TENDER_AGENCY_NAME is not null 
###sql_where_tm###  
group by TENDER_AGENCY_NAME
    order by COUNT(1) desc
) aa
where rownum<=10
"),
            new Tuple<string, string, string>("PROXY_MIDDLE", "",
                @"select name,count(1) value from 
(
  select 
      case when amount<200 then '200万以下' 
           when amount>=200 and amount<1000 then '200万-1000万'
           when amount>=1000 and amount<3000 then '1000万-3000万'
           when amount>=3000 and amount<10000 then '3000万-1亿'
           when amount>=10000 then '1亿以上'
      end name  
  from V_BIG_PROXY  
  where 1=1 
###sql_where_tm### 
  ) aaa
      group by name
      order by value
"),
            new Tuple<string, string, string>("PROXY_AREA", "",
                @"select a.areaname,nvl(TOTAL_COUNT,0) TOTAL_COUNT
from (select areacode,areaname from sys_area where pcode='350000') a
left join (
  select substr(AREACODE,0,4)||'00' AREACODE,count(1) TOTAL_COUNT
  from (
    select  distinct TENDER_AGENCY_CODE,AREACODE
    from V_BIG_PROXY
    where 1=1 
###sql_where_tm### 
 ) aa
  group by substr(AREACODE,0,4)
) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("PROXY_QUYU_COUNT", "",
                @"
select quyu,count(1) COUNT 
from V_BIG_DAILI
where 1=1 
###sql_where_tm### 
group by quyu  
"),
            new Tuple<string, string, string>("PROXY_TYPE", "",
                @"select TYPE,count(1) COUNT 
from V_BIG_DAILI
where 1=1 
###sql_where_tm###  group by type
"),
            new Tuple<string, string, string>("GCJSLY_TotalAmountCount", "",
                @"SELECT SUM(AMOUNT)/10000 AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT
FROM v_big_allresult  t
where 1=1 and project_type=:INDUSTRY_TYPE        
###sql_where_tm###
"),
            new Tuple<string, string, string>("GCJSLY_Total", "",
                @"select '招标公告数' type,count(1) COUNT
from (
     select NOTICE_SEND_TIME M_TM,pro.TENDER_PROJECT_TYPE  PROJECT_TYPE
     from TENDER_ANN_QUA_INQUERY_ANN  a
     inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = A.TENDER_PROJECT_CODE  
) aa
where 1=1 and PROJECT_TYPE=:INDUSTRY_TYPE
###sql_where_tm###
union all select '中标公示数' type,sum(count) COUNT from(
select '中标公示数' type,count(1) COUNT
from (
     select NOTICE_SEND_TIME M_TM ,pro.TENDER_PROJECT_TYPE  PROJECT_TYPE
     from WIN_RESULT_ANNO a
     inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = A.TENDER_PROJECT_CODE 
) aa
where 1=1 and PROJECT_TYPE=:INDUSTRY_TYPE
###sql_where_tm###
union all
select '中标候选人公示数' type,count(1) COUNT
from (
     select PUBLICITY_REFER_TIME M_TM ,pro.TENDER_PROJECT_TYPE  PROJECT_TYPE
     from TENDER_CANDIDATE_ANNOUNCE a
     inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = A.TENDER_PROJECT_CODE 
) aa
where 1=1 and PROJECT_TYPE=:INDUSTRY_TYPE
###sql_where_tm###
)union all
select '投标人数' type,count(1) count
from MV_GCJSLY_Rank 
where 1=1 and project_type=:INDUSTRY_TYPE
###sql_where_tm###
union all
select '专家数' type,count(1) COUNT
from (
     select EXPERT_CHECK_IN_TIME M_TM ,pro.TENDER_PROJECT_TYPE  PROJECT_TYPE
     from BID_EVALUATION_EXPERT a
     inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = A.TENDER_PROJECT_CODE 
     ) aa
where 1=1 and PROJECT_TYPE=:INDUSTRY_TYPE
###sql_where_tm###
"),
            new Tuple<string, string, string>("GCJSLY_Rank", "",
                @"select * 
from (
  select BID_SECTION_NAME,TENDER_PROJECT_NAME,count(1) count
  from MV_GCJSLY_Rank aaa
  where 1=1 and project_type=:INDUSTRY_TYPE
###sql_where_tm###  
  group by BID_SECTION_NAME,TENDER_PROJECT_NAME
  order by count(1) desc
) where rownum<=5
"),
            new Tuple<string, string, string>("GCJSLY_Chart_AmountCount", "",
                @"select a.areaname,nvl( TOTAL_AMOUNT,'0') TOTAL_AMOUNT,nvl(TOTAL_COUNT,0) TOTAL_COUNT
from (select areacode,areaname from sys_area where pcode='350000') a
left join (
  select substr(areacode, 0, 4)||'00' areacode,SUM(AMOUNT) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT 
  from v_big_allresult
  where type='工程建设' and project_type=:INDUSTRY_TYPE     
###sql_where_tm### 
group by substr(areacode, 0, 4)
      ) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("GCJSLY_Chart_Type", "",
                @"SELECT b.text,b.value,SUM(AMOUNT) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT
FROM (
    select distinct A.NOTICE_SEND_TIME AS M_TM, A.BID_SECTION_CODE AS SECTION_CODE,A.TENDER_PROJECT_CODE AS PROJECT_CODE, CASE to_char(A.PRICE_UNIT) WHEN '1' THEN A.BID_AMOUNT ELSE  A.BID_AMOUNT/10000 END AMOUNT
        ,to_char(PRO.TENDER_PROJECT_TYPE) as PROJECT_TYPE
        ,substr(TENDER_PROJECT_CLASSIFY_CODE,0,3) SECTION_TYPE
    from WIN_RESULT_ANNO A
    inner join SECTION C ON  A.BID_SECTION_CODE = C.BID_SECTION_CODE
    inner join TENDER_PROJECT PRO on PRO.TENDER_PROJECT_CODE = A.TENDER_PROJECT_CODE
)  aa
inner join (select text,value from sys_dic where type='5001' and PID='31772' ) b on aa.SECTION_TYPE=b.value
where 1=1 and project_type=:INDUSTRY_TYPE
###sql_where_tm### 
group by b.text,b.value
      order by b.value
"),
            new Tuple<string, string, string>("Man_Val_AllCount", "",
                @" select count(1) count from(
      select count(1) count
      from TENDER_LIST
      where 1=1 
###sql_where_tm###  
 group by tender_project_code, bid_section_code, bidder_name)
"),
            new Tuple<string, string, string>("Man_Val_ManCount", "",
                @"select count(1) count
from v_big_man
where 1=1 
###sql_where_tm### 
"),
            new Tuple<string, string, string>("Man_Val_ZIYE", "",
                @"select count(1) count
from QUALI_PERSON_BASE
where 1=1 
###sql_where_tm###  
"),
            new Tuple<string, string, string>("Man_List_WinCount", "",
                @"
select * from 
(
select WIN_BIDDER_NAME,count(1) count
from WIN_RESULT_ANNO
where 1=1 
###sql_where_tm###
group by WIN_BIDDER_NAME
order by count(1) desc
) aa
where rownum<=10
"),
            new Tuple<string, string, string>("Man_Map", "",
                @"select AREA.AREACODE,AREA.AREANAME,count from 
(
  select substr(AREACODE,0,2) || '0000' AREACODE, count(1) count
  from v_big_man
  where 1=1 
###sql_where_tm###
 group by substr(AREACODE,0,2)
      ) a
      inner join SYS_AREA_QUANGUO AREA on AREA.AREACODE = a.AREACODE
      order by COUNT desc
"),
            new Tuple<string, string, string>("MAN_TYPE", "",
                @"select TYPE,count(1) COUNT 
from v_big_man
where 1=1 
###sql_where_tm### 
group by TYPE  
order by COUNT desc 
"),
            new Tuple<string, string, string>("MAN_Amount_FenBu", "",
                @"select Type,count(1) count from 
(
  select 
      case when amount<1000 then '1' 
           when amount>=1000 and amount<2500 then '2'
           when amount>=2500 and amount<5000 then '3'
           when amount>=5000  then '4'
      end Type  
  from v_big_man 
  where 1=1 
###sql_where_tm### ) aaa
      group by Type
"),
            new Tuple<string, string, string>("MAN_Chart_1", "",
                @"select TM, count(1) count
from ( select distinct BIDDER_ORG_CODE,to_char(M_TM,'yyyy-mm') TM from TENDER_LIST
where 1=1 
###sql_where_tm###  ) TENDER_LIST
      group by TM
"),
            new Tuple<string, string, string>("MAN_Chart_2", "",
                @"select TM,count(1) count from(
select to_char(M_TM,'yyyy-mm') TM, count(1) count
from TENDER_LIST
where 1=1 
###sql_where_tm###
 group by to_char(M_TM,'yyyy-mm'),tender_project_code, bid_section_code, bidder_name
       )group by TM order by TM
"),
            new Tuple<string, string, string>("MAN_Chart_3", "",
                @"select to_char(M_TM,'yyyy-mm') TM, count(1) count
from WIN_RESULT_ANNO
where 1=1 
###sql_where_tm### group by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("EXPERT_INFO", "",
                @" SELECT  V.EXPERT_NAME,V.ID_CARD_TYPE,D.TEXT ID_CARD_TYPE_TEXT,V.ID_CARD,
               BASE_TYPE, '综合评标专家' BASE_TYPE_TEXT,t.MAJOR_CODE,D3.TEXT MAJOR_CODE_TEXT,T.DUTY,T.ONWORK,D1.TEXT ONWORK_TEXT,
                T.AREA,D2.AREANAME AREA_TEXT,T.PROFESSIONAL
        FROM v_big_jg_expert V
        LEFT JOIN EXPERT_BID_EVALUATION T ON V.ID_CARD = T.ID_CARD
        LEFT JOIN SYS_DIC D ON D.TYPE=7 AND  V.ID_CARD_TYPE = D.VALUE
        LEFT JOIN SYS_DIC D1 ON D1.TYPE=2003 AND  T.ONWORK = D1.VALUE
        LEFT JOIN SYS_AREA_QUANGUO D2 ON D2.AREACODE=T.AREA
        /*LEFT JOIN SYS_DIC D2 ON D2.TYPE=9016 AND  T.AREA = D2.VALUE*/
        LEFT JOIN SYS_DIC D3 ON D3.TYPE=5001 AND T.MAJOR_CODE=D3.VALUE
        WHERE V.ID_CARD =:code and rownum = 1
"),
            new Tuple<string, string, string>("EXPERT_CHART_INFO", "",
                @"select to_char(a.M_TM,'yyyy-mm') TM,count(1) count
        from v_big_jg a
        inner join  v_big_jg_expert b on a.PROJECT_CODE = B.TENDER_PROJECT_CODE
        where B.ID_CARD=:code
###sql_where_winsendtm###  
group by to_char(a.M_TM,'yyyy-mm')
      order by to_char(a.M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("EXPERT_AREA", "",
                @"select substr(AREA.areacode,0,4)||'00' area,count(1) count,areaN.AREANAME
  from  v_big_jg b 
 inner join  v_big_jg_expert c on  b.PROJECT_CODE =c.TENDER_PROJECT_CODE
  inner join Sys_Area_Quanguo area on AREA.areacode =b.AREACODE
  inner join Sys_Area_Quanguo areaN on areaN.areacode =substr(AREA.areacode,0,4)||'00'
  where  c.ID_CARD=:code
###sql_where_winsendtm###  
group by substr(AREA.areacode,0,4),areaN.AREANAME
"),
            new Tuple<string, string, string>("EXPERT_AGENCY", "",
                @" select * 
      from (
        select b.TENDER_AGENCY_NAME,count(1) count
        from  v_big_jg b 
       inner join  v_big_jg_expert c on  b.PROJECT_CODE =c.TENDER_PROJECT_CODE
        where c.ID_CARD =:code
###sql_where_winsendtm###  
group by b.TENDER_AGENCY_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("EXPERT_TENDERER", "",
                @"select * 
      from (
        select a.TENDERER_NAME,count(1) count
         from v_big_jg a
         inner join  v_big_jg_expert b on a.PROJECT_CODE = B.TENDER_PROJECT_CODE
        where B.ID_CARD=:code
###sql_where_winsendtm###  
group by a.TENDERER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("EXPERT_BIDDER", "",
                @"select * 
      from (
        select A.BIDDER_NAME,count(1) count
        from TENDER_LIST A
        LEFT JOIN  TENDER_PROJECT b  ON A.TENDER_PROJECT_CODE =b.TENDER_PROJECT_CODE
        LEFT JOIN TENDER_ANN_QUA_INQUERY_ANN d ON A.TENDER_PROJECT_CODE =d.TENDER_PROJECT_CODE
       inner join  v_big_jg_expert c on  b.TENDER_PROJECT_CODE =c.TENDER_PROJECT_CODE
       where c.ID_CARD=:code
###sql_where_winsendtm###   
group by A.BIDDER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("EXPERT_WIN_BIDDER", "",
                @"select * 
      from (
        select a.WIN_BIDDER_NAME,count(1) count
         from v_big_jg a
         inner join  v_big_jg_expert b on a.PROJECT_CODE = B.TENDER_PROJECT_CODE
        where B.ID_CARD=:code
###sql_where_winsendtm### 
group by a.WIN_BIDDER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("TENDER_INFO", "",
                @"select a.LEGAL_NAME,a.LEGAL_CODE,a.LEGAL_CONTACT,a.LEGAL_CONTACT_PHONE
       ,b.QUAL_NAME
from v_big_legal_base a
left join TENDERER_EX_INFO b on a.LEGAL_CODE=b.LEGAL_CODE
where a.LEGAL_NAME=:code
"),
            new Tuple<string, string, string>("TENDER_INFO_TYPE", "",
                @"select * from (
  select c.text,count(1) count
  from v_big_jg_tender a
  inner join tender_project b on a.TENDER_PROJECT_CODE=b.tender_project_code
  inner join (select text,value from sys_dic where pid='2525') c on b.TENDER_PROJECT_TYPE=c.value
  where  a.Bidder_name=:code
  group by text
  order by count(1) desc
)
where rownum<=2
"),
            new Tuple<string, string, string>("TENDER_INFO_AREA", "",
                @"select aa.*,area.areaname from (
  select substr(AREA.areacode,0,4)|| '00' areacode,count(1) count
  from v_big_jg_tender a
  inner join tender_project b on a.TENDER_PROJECT_CODE=b.tender_project_code
  inner join Sys_Area_Quanguo area on AREA.areacode =b.REGION_CODE
  where  a.Bidder_name=:code
  group by substr(AREA.areacode,0,4)
  order by count(1) desc
) aa
inner join Sys_Area_Quanguo area on AREA.areacode =aa.areacode
where rownum<=2
"),
            new Tuple<string, string, string>("TENDER_INFO_MAX", "",
                @"select max(MAX_AMOUNT) from(
select CASE to_char(PRICE_UNIT) WHEN '1' THEN BID_AMOUNT ELSE  BID_AMOUNT/10000 END MAX_AMOUNT 
from  WIN_RESULT_ANNO A
where  WIN_BIDDER_name=:code
) where MAX_AMOUNT<300000
"),
            new Tuple<string, string, string>("TENDER_CHART_TOUBIAO", "",
                @"select to_char(M_TM,'yyyy-mm') TM,count(1) count
from v_big_jg_tender a
where Bidder_name=:code
###sql_where_checktm### 
group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("TENDER_CHART_WIN", "",
                @"select to_char(M_TM,'yyyy-mm') TM,count(1) count
from v_big_jg_tender a
where Bidder_name=:code
      and TENDER_PROJECT_CODE in ( select TENDER_PROJECT_CODE from  WIN_RESULT_ANNO where WIN_Bidder_name=:code)
###sql_where_checktm###  
group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("TENDER_AREA", "",
                @"      select SUM(decode(type,'投标',count,0)) as tender ,
 SUM(decode(type,'中标',count,0)) as WIN, AREA,AREANAME FROM ( 
       select  '投标' type,substr(AREA.areacode,0,4)||'00' area,count(1) count,areaN.AREANAME
        from v_big_jg_tender a
        inner join TENDER_PROJECT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
        inner join Sys_Area_Quanguo area on AREA.areacode =b.REGION_CODE
        inner join Sys_Area_Quanguo areaN on areaN.areacode =substr(AREA.areacode,0,4)||'00'
        where   Bidder_name=:code
###sql_where_checktm###  
group by substr(AREA.areacode,0,4),areaN.AREANAME
union all
 select '中标' type,substr(AREA.areacode,0,4)||'00' area,count(1) count,areaN.AREANAME
  from v_big_jg_tender a
  inner join TENDER_PROJECT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  inner join Sys_Area_Quanguo area on AREA.areacode =b.REGION_CODE
  inner join Sys_Area_Quanguo areaN on areaN.areacode =substr(AREA.areacode,0,4)||'00'
  where   Bidder_name=:code
  and a.TENDER_PROJECT_CODE in ( select TENDER_PROJECT_CODE from  WIN_RESULT_ANNO where WIN_Bidder_name=:code)
###sql_where_checktm###  
group by substr(AREA.areacode,0,4),areaN.AREANAME)
  GROUP BY AREA,AREANAME
"),
            new Tuple<string, string, string>("TENDER_PROXY", "",
                @"select * 
from (
  select b.TENDER_AGENCY_NAME,count(1) count
  from v_big_jg_tender a
  inner join TENDER_PROJECT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  where  Bidder_name=:code
###sql_where_checktm###
 group by b.TENDER_AGENCY_NAME
  order by count(1) desc
) aa
"),
            new Tuple<string, string, string>("TENDER_PROXY_WIN", "",
                @"select * 
from (
  select b.TENDER_AGENCY_NAME,count(1) count
  from v_big_jg_tender a
  inner join TENDER_PROJECT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  where Bidder_name=:code and a.TENDER_PROJECT_CODE in ( select TENDER_PROJECT_CODE from  WIN_RESULT_ANNO where  WIN_BIDDER_name=:code)
###sql_where_checktm### 
  group by b.TENDER_AGENCY_NAME
  order by count(1) desc
) aa
"),
            new Tuple<string, string, string>("TENDER_TENDERER", "",
                @"select * 
from (
  select b.TENDERER_NAME,count(1) count
  from v_big_jg_tender a
  inner join TENDER_PROJECT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  where Bidder_name=:code
###sql_where_checktm###  
  group by b.TENDERER_NAME
  order by count(1) desc
) aa
"),
            new Tuple<string, string, string>("TENDER_TENDERER_WIN", "",
                @"select * 
from (
  select b.TENDERER_NAME,count(1) count
  from v_big_jg_tender a
  inner join TENDER_PROJECT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  where   Bidder_name=:code and a.TENDER_PROJECT_CODE in ( select TENDER_PROJECT_CODE from  WIN_RESULT_ANNO where  WIN_BIDDER_name=:code)
###sql_where_checktm###  
  group by b.TENDERER_NAME
  order by count(1) desc
) aa
"),
            new Tuple<string, string, string>("TENDER_EXPERT", "",
                @"select * 
from (
  select b.EXPERT_NAME,count(1) count
  from v_big_jg_tender a
  inner join BID_EVALUATION_EXPERT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  where  Bidder_name=:code
###sql_where_checktm###  
  group by b.EXPERT_NAME
  order by count(1) desc
) aa
"),
            new Tuple<string, string, string>("TENDER_EXPERT_WIN", "",
                @"select * 
from (
  select b.EXPERT_NAME,count(1) count
  from v_big_jg_tender a
  inner join BID_EVALUATION_EXPERT b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE
  where  Bidder_name=:code and a.TENDER_PROJECT_CODE in ( select TENDER_PROJECT_CODE from  WIN_RESULT_ANNO where WIN_BIDDER_name=:code)
###sql_where_checktm###  
  group by b.EXPERT_NAME
  order by count(1) desc
) aa
"),
            new Tuple<string, string, string>("TENDER_OTHER", "",
                @"    select * from (
    select * 
from (
  select A.BIDDER_NAME,count(1) count
  from (SELECT BIDDER_NAME,TENDER_PROJECT_CODE  from v_big_jg_tender where 1=1 
###sql_where_checktm###  
)
  a
  inner join  (SELECT BIDDER_NAME,TENDER_PROJECT_CODE  from v_big_jg_tender where  1=1 
###sql_where_checktm###  
) b on a.TENDER_PROJECT_CODE =b.TENDER_PROJECT_CODE 
   where a.Bidder_name<>:code and b.Bidder_name=:code
  
  group by A.BIDDER_NAME
 
) aa  order by count desc
)
"),
            new Tuple<string, string, string>("TENDER_OTHER_WIN", "",
                @"select * 
      from (
        select BIDDER_NAME,count(1) count
          from (select TENDER_PROJECT_CODE,BIDDER_NAME from TENDER_LIST) a
          inner join(select TENDER_PROJECT_CODE,WIN_BIDDER_NAME,notice_send_time CHECK_TM from  WIN_RESULT_ANNO) b on a.TENDER_PROJECT_CODE=b.TENDER_PROJECT_CODE and WIN_BIDDER_NAME=:code
            where 1=1 and BIDDER_NAME<>:code
###sql_where_checktm### 
group by BIDDER_NAME
        order by count(1) desc
      ) aa
      where rownum<=5
"),
            new Tuple<string, string, string>("TENDER_WIN_COUNT", "",
                @"SELECT SUM(COUNT) COUNT FROM (
      select COUNT(1) COUNT from
      (SELECT TENDER_PROJECT_CODE,notice_send_time CHECK_TM,BID_SECTION_CODE FROM WIN_RESULT_ANNO WHERE WIN_BIDDER_NAME=:code)
      WHERE 1=1
###sql_where_checktm### 
group by TENDER_PROJECT_CODE,BID_SECTION_CODE)
"),
            new Tuple<string, string, string>("USER_TENDER_LIST_OLD", "count desc",
                @"select c.Legal_Name
       ,nvl(area.shi,'-') shi
        ,nvl(a.LEGAL_CODE,'-') LEGAL_CODE
       ,c.count
       ,nvl(d.count,0) win_count
       ,nvl(round(d.count*100/c.count),0) RATE
from  ( select Legal_name,sum(COUNT) count from MV_TENDER_LIST_COUNT
where 1=1 
###sql_where_tm### 
group by Legal_Name) c
left join (SELECT max(LEGAL_CODE) LEGAL_CODE,Legal_Name,max(REGION_CODE) REGION_CODE FROM LEGAL_PERSON_BASE WHERE LEGAL_ROLE like '%03%' group by Legal_Name) a  on a.Legal_Name=c.Legal_Name
left join (select distinct oldcode,shi,pcode from DSJ_AREA) area on a.REGION_CODE=area.OLDCODE
left join (select aa.win_bidder_name Legal_Name,count(1) count from WIN_RESULT_ANNO aa 
INNER JOIN v_big_jg_tender bb ON aa.TENDER_PROJECT_CODE=bb.TENDER_PROJECT_CODE AND aa.WIN_BIDDER_NAME=bb.BIDDER_NAME WHERE 1=1 
###sql_where_tm_bb### 
group by win_bidder_name) d on a.Legal_Name=d.Legal_Name
where 1=1  
###areacodeS### and area.pcode=:AREACODE ###areacodeE###
###nameS### and a.Legal_Name like '%'|| :name ||  '%' ###nameE###
###codeS### and a.LEGAL_CODE like '%'|| :code ||  '%' ###codeE###
"),
            new Tuple<string, string, string>("USER_TENDER_LIST", "count desc",
                @"SELECT * FROM MV_USER_TENDER_LIST WHERE 1=1
###areacodeS### and AREACODE=:AREACODE ###areacodeE###
###nameS### and Legal_Name like '%'|| :name ||  '%' ###nameE###
###codeS### and LEGAL_CODE like '%'|| :code ||  '%' ###codeE###
"),
            new Tuple<string, string, string>("USER_AGENCY_LIST", "count desc",
                @"select c.Legal_Name
       ,nvl(area.shi,'-') shi
        ,nvl(a.LEGAL_CODE,'-') LEGAL_CODE
       ,c.count
       ,d.count win_count
       ,round(d.count*100/c.count) RATE
from 
 (select TENDER_AGENCY_NAME LEGAL_NAME,count(1) count from TENDER_PROJECT a
 LEFT join(SELECT DISTINCT TENDER_PROJECT_CODE FROM  tender_ann_qua_inquery_ann cc where  1=1
###sql_where_year### 
 )b on a.tender_project_code=b.tender_project_code  group by TENDER_AGENCY_NAME) c 
left join (SELECT max(LEGAL_CODE) LEGAL_CODE,Legal_Name,max(REGION_CODE) REGION_CODE FROM LEGAL_PERSON_BASE WHERE LEGAL_ROLE='02' or LEGAL_ROLE='02,03' group by Legal_Name) a on a.Legal_Name=c.Legal_Name
left join DSJ_AREA area on a.REGION_CODE=area.OLDCODE
left join (
      select bb.TENDER_AGENCY_NAME LEGAL_NAME,count(1) count 
            from WIN_RESULT_ANNO  aa
      inner join TENDER_PROJECT bb on aa.tender_project_code=bb.tender_project_code
      inner join SYS_AREA_QUANGUO AREA on AREA.AREACODE = bb.REGION_CODE
      inner join tender_ann_qua_inquery_ann cc on bb.tender_project_code=cc.tender_project_code
      WHERE  1=1
###sql_where_year### 
group by bb.TENDER_AGENCY_NAME  
) d on c.Legal_Name=d.Legal_Name
where 1=1 and length( c.Legal_Name)>5
###areacodeS### and AREACODE=:AREACODE ###areacodeE###
###nameS### and Legal_Name like '%'|| :name ||  '%' ###nameE###
###codeS### and LEGAL_CODE like '%'|| :code ||  '%' ###codeE###
"),
            new Tuple<string, string, string>("USER_TENDERER_LIST", "count desc",
                @"select c.Legal_Name
       ,nvl(area.shi,'-') shi
        ,nvl(a.LEGAL_CODE,'-') LEGAL_CODE
       ,c.count
       ,d.count win_count
       ,round(d.count*100/c.count) RATE
from 
 (select a.TENDERER_NAME LEGAL_NAME,count(1) count from TENDER_PROJECT a
  LEFT join(SELECT DISTINCT TENDER_PROJECT_CODE FROM  tender_ann_qua_inquery_ann cc where  1=1 
###sql_where_year### 
 ) b on a.tender_project_code=b.tender_project_code 
 group by TENDERER_NAME) c 
left join (SELECT max(LEGAL_CODE) LEGAL_CODE,Legal_Name,max(REGION_CODE) REGION_CODE FROM LEGAL_PERSON_BASE WHERE LEGAL_ROLE like '%01%' group by Legal_Name) a on a.Legal_Name=c.Legal_Name
left join DSJ_AREA area on a.REGION_CODE=area.OLDCODE
left join (
      select bb.TENDERER_NAME LEGAL_NAME,count(1) count 
            from (select tender_project_code from WIN_RESULT_ANNO group by tender_project_code)  aa
      inner join TENDER_PROJECT bb on aa.tender_project_code=bb.tender_project_code
            inner join tender_ann_qua_inquery_ann cc on bb.tender_project_code=cc.tender_project_code 
      WHERE  1=1
###sql_where_year### 
group by bb.TENDERER_NAME  
) d on c.Legal_Name=d.Legal_Name
where 1=1 and length( c.Legal_Name)>5
###areacodeS### and AREACODE=:AREACODE ###areacodeE###
###nameS### and Legal_Name like '%'|| :name ||  '%' ###nameE###
###codeS### and LEGAL_CODE like '%'|| :code ||  '%' ###codeE###
"),
            new Tuple<string, string, string>("USER_EXPERT_LIST", "rate,legal_code desc",
                @"select (LOSE_COUNT+AGAIN_COUNT+WIN_COUNT) COUNT,LOSE_COUNT,AGAIN_COUNT,WIN_COUNT,legal_name,id_card,legal_code,shi,ROUND(WIN_COUNT*100/(LOSE_COUNT+AGAIN_COUNT+WIN_COUNT),2) rate 
from(
select sum(decode(evaluation_result,'1',count,0)) as LOSE_COUNT
,sum(decode(evaluation_result,'2',count,0)) as AGAIN_COUNT
,sum(decode(evaluation_result,'3',count,0)) as WIN_COUNT
, a.expert_name LEGAL_NAME,a.id_card LEGAL_CODE,a.id_card
,area.shi
from (select distinct expert_name,id_card,AREA from EXPERT_BID_EVALUATION) a
inner join DSJ_AREA area on a.AREA=area.OLDCODE
inner join 
(select a.ID_CARD LEGAL_CODE,count(1) count,b.evaluation_result from BID_EVALUATION_EXPERT a inner join EVALUATION_REPORT b 
on a.tender_project_code=b.tender_project_code and a.bid_section_code=b.bid_section_code where 1=1
###sql_where_expertcheck### 
 group by a.ID_CARD,b.evaluation_result)
  c on a.id_card=c.LEGAL_CODE
where 1=1 

###areacodeS### and AREACODE=:AREACODE ###areacodeE###
###nameS### and a.expert_name like '%'|| :name ||  '%' ###nameE###
###codeS### and a.id_card like '%'|| :code ||  '%' ###codeE###
group by a.expert_name,a.id_card,id_card,area.shi)
"),
            new Tuple<string, string, string>("WIN_BIDDER_LIST", "项目编号 desc",
                @"select aa.win_bidder_name 单位,cc.TENDER_PROJECT_CODE 项目编号,cc.NOTICE_NAME 项目名称,CC.m_id,cc.NOTICE_NATURE,
（case when aa.price_unit = '1' then aa.bid_amount else aa.bid_amount/10000 end） 中标价 from WIN_RESULT_ANNO aa 
INNER JOIN v_big_jg_tender bb ON aa.TENDER_PROJECT_CODE=bb.TENDER_PROJECT_CODE AND aa.WIN_BIDDER_NAME=bb.BIDDER_NAME 
inner join tender_ann_qua_inquery_ann cc on aa.tender_project_code = cc.tender_project_code
WHERE 1=1
and aa.win_bidder_name = :biddername and  cc.NOTICE_NATURE = '1' and cc.BULLETIN_TYPE = '1'
###sql_where_tm_bb###
"),
            new Tuple<string, string, string>("TENDER_BIDDER_LIST", "项目编号 desc",
                @"select aa.bidder_name 单位,cc.TENDER_PROJECT_CODE 项目编号,cc.NOTICE_NAME 项目名称,CC.m_id,cc.NOTICE_NATURE from (select bidder_name,CHECKIN_TIME M_TM,tender_project_code from tender_list group by bidder_name,CHECKIN_TIME,tender_project_code) aa
      inner join tender_ann_qua_inquery_ann cc on aa.tender_project_code = cc.tender_project_code
      WHERE 1=1
and aa.bidder_name = :biddername and  cc.NOTICE_NATURE = '1' and cc.BULLETIN_TYPE = '1'
###sql_where_tm_aa###
"),
            new Tuple<string, string, string>("AGENCY_INFO", "",
                @" SELECT T.TENDER_AGENCY_NAME AS LEGAL_NAME,T.TENDER_AGENCY_CODE LEGAL_CODE,T1.LEGAL_CONTACT,T1.LEGAL_CONTACT_PHONE,T2.QUAL_NAME
      FROM TENDER_PROJECT T
      LEFT JOIN LEGAL_PERSON_BASE T1 ON T.TENDER_AGENCY_NAME = T1.LEGAL_NAME
      LEFT JOIN TENDER_AGENT_EX_INFO T2 ON T1.LEGAL_CODE = T2.LEGAL_CODE
      WHERE T.TENDER_AGENCY_NAME =:code and rownum=1
"),
            new Tuple<string, string, string>("AGENCY_INFO_MODE", "",
                @"select * from (
        SELECT C.TEXT,count(1) COUNT
        FROM v_big_jg V
        LEFT JOIN  TENDER_PROJECT T ON V.PROJECT_CODE = T.TENDER_PROJECT_CODE
        inner join (select text,value from sys_dic where type='1000') c on T.TENDER_MODE=c.value
        where  T.TENDER_AGENCY_NAME =:code
         GROUP BY TEXT
         order by count(1) desc
         )
      where rownum<=2
"),
            new Tuple<string, string, string>("AGENCY_INFO_TYPE", "",
                @"      select * from (
        SELECT C.TEXT,count(1) COUNT
        FROM v_big_jg V
        LEFT JOIN  TENDER_PROJECT T ON V.PROJECT_CODE = T.TENDER_PROJECT_CODE
        inner join (select text,value from sys_dic where pid='2525') c on T.TENDER_PROJECT_TYPE=c.value
        where  T.TENDER_AGENCY_NAME =:code
         GROUP BY TEXT
         order by count(1) desc
         )
      where rownum<=2
"),
            new Tuple<string, string, string>("AGENCY_INFO_AREA", "",
                @"select aa.*,area.areaname from (
  select substr(AREA.areacode,0,4)|| '00' areacode,count(1) count
  from v_big_jg b
  inner join Sys_Area_Quanguo area on AREA.areacode =b.AREACODE
  where  b.TENDER_AGENCY_NAME=:code
  group by substr(AREA.areacode,0,4)
  order by count(1) desc
) aa
inner join Sys_Area_Quanguo area on AREA.areacode =aa.areacode
where rownum<=2
"),
            new Tuple<string, string, string>("AGENCY_INFO_MAX", "",
                @"select max(AMOUNT) MAX_AMOUNT 
      from v_big_jg
      where TENDER_AGENCY_NAME=:code and AMOUNT<200000
"),
            new Tuple<string, string, string>("AGENCY_CHART_INFO", "",
                @" select to_char(M_TM,'yyyy-mm') TM,count(1) count
        from v_big_jg a
        where a.TENDER_AGENCY_NAME=:code
###sql_where_winsendtm### 
group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("AGENCY_AREA", "",
                @" select substr(AREA.areacode,0,4)||'00' area,count(1) count,areaN.AREANAME
  from  v_big_jg b 
  inner join Sys_Area_Quanguo area on AREA.areacode =b.AREACODE
  inner join Sys_Area_Quanguo areaN on areaN.areacode =substr(AREA.areacode,0,4)||'00'
  where  b.TENDER_AGENCY_NAME=:code
###sql_where_winsendtm###  
  group by substr(AREA.areacode,0,4),areaN.AREANAME
"),
            new Tuple<string, string, string>("PROXY_TENDERER", "",
                @" select * 
      from (
        select b.TENDERER_NAME,count(1) count
        from  v_big_jg b 
        where  b.TENDER_AGENCY_NAME=:code
###sql_where_winsendtm###  
 group by b.TENDERER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("PROXY_WIN_BIDDER", "",
                @" select * 
      from (
        select a.WIN_BIDDER_NAME,count(1) count
         from v_big_jg a
        where TENDER_AGENCY_NAME=:code
###sql_where_winsendtm### 
 group by a.WIN_BIDDER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("PROXY_EXPERT", "",
                @"select * 
    from (
      select b.EXPERT_NAME,count(1) count
      from v_big_jg a
      inner join BID_EVALUATION_EXPERT b on a.PROJECT_CODE=b.TENDER_PROJECT_CODE
      where  a.TENDER_AGENCY_NAME=:code
###sql_where_winsendtm### 
group by b.EXPERT_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("PROXY_BIDDER_DIAG", "",
                @"select * 
    from (
      select BIDDER_NAME,count(1) count
      from TENDER_LIST a
      inner join v_big_jg b on a.TENDER_PROJECT_CODE=b.PROJECT_CODE
      where  b.TENDER_AGENCY_NAME=:code
###sql_where_winsendtm###  
group by BIDDER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("TENDERER_INFO", "",
                @" SELECT T.TENDERER_NAME AS LEGAL_NAME,T.TENDER_AGENCY_CODE LEGAL_CODE,T1.LEGAL_CONTACT,T1.LEGAL_CONTACT_PHONE,T2.QUAL_NAME
      FROM TENDER_PROJECT T
      LEFT JOIN LEGAL_PERSON_BASE T1 ON T.TENDERER_NAME = T1.LEGAL_NAME
      LEFT JOIN TENDER_AGENT_EX_INFO T2 ON T1.LEGAL_CODE = T2.LEGAL_CODE
      WHERE T.TENDERER_NAME =:code
"),
            new Tuple<string, string, string>("TENDERER_INFO_MODE", "",
                @"select * from (
        SELECT C.TEXT,count(1) COUNT
        FROM v_big_jg V
        LEFT JOIN  TENDER_PROJECT T ON V.PROJECT_CODE = T.TENDER_PROJECT_CODE
        inner join (select text,value from sys_dic where type='1000') c on T.TENDER_MODE=c.value
        where  T.TENDERER_NAME =:code
         GROUP BY TEXT
         order by count(1) desc
         )
      where rownum<=2
"),
            new Tuple<string, string, string>("TENDERER_INFO_TYPE", "",
                @"select * from (
        SELECT C.TEXT,count(1) COUNT
        FROM v_big_jg V
        LEFT JOIN  TENDER_PROJECT T ON V.PROJECT_CODE = T.TENDER_PROJECT_CODE
        inner join (select text,value from sys_dic where pid='2525') c on T.TENDER_PROJECT_TYPE=c.value
        where  T.TENDERER_NAME =:code
         GROUP BY TEXT
         order by count(1) desc
         )
      where rownum<=2
"),
            new Tuple<string, string, string>("TENDERER_INFO_AREA", "",
                @"select aa.*,area.areaname from (
        select substr(AREA.areacode,0,4)|| '00' areacode,count(1) count
        from v_big_jg b
        inner join Sys_Area_Quanguo area on AREA.areacode =b.AREACODE
        where  b.TENDERER_NAME=:code
        group by substr(AREA.areacode,0,4)
        order by count(1) desc
      ) aa
      inner join Sys_Area_Quanguo area on AREA.areacode =aa.areacode
      where rownum<=2
"),
            new Tuple<string, string, string>("TENDERER_INFO_MAX", "",
                @"select max(AMOUNT) MAX_AMOUNT 
        from v_big_jg
        where TENDERER_NAME=:code
        and AMOUNT<300000
"),
            new Tuple<string, string, string>("TENDERER_CHART_INFO", "",
                @"select to_char(M_TM,'yyyy-mm') TM,count(1) count
        from v_big_jg a
        where a.TENDERER_NAME=:code
###sql_where_winsendtm###  
group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("TENDERER_AREA", "",
                @"select substr(AREA.areacode,0,4)||'00' area,count(1) count,areaN.AREANAME
  from  v_big_jg b 
  inner join Sys_Area_Quanguo area on AREA.areacode =b.AREACODE
  inner join Sys_Area_Quanguo areaN on areaN.areacode =substr(AREA.areacode,0,4)||'00'
  where  b.TENDERER_NAME=:code
###sql_where_winsendtm### 
  group by substr(AREA.areacode,0,4),areaN.AREANAME
"),
            new Tuple<string, string, string>("TENDERER_PROXY", "",
                @" select * 
      from (
        select b.TENDER_AGENCY_NAME,count(1) count
        from  v_big_jg b 
        where  b.TENDERER_NAME=:code
###sql_where_winsendtm###  
group by b.TENDER_AGENCY_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("TENDERER_WIN_BIDDER", "",
                @"select * 
      from (
        select a.WIN_BIDDER_NAME,count(1) count
         from v_big_jg a
        where TENDERER_NAME=:code
###sql_where_winsendtm###
 group by a.WIN_BIDDER_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("TENDERER_EXPERT", "",
                @"select * 
    from (
      select b.EXPERT_NAME,count(1) count
      from v_big_jg a
      inner join BID_EVALUATION_EXPERT b on a.PROJECT_CODE=b.TENDER_PROJECT_CODE
      where  a.TENDERER_NAME=:code
###sql_where_winsendtm### 
group by b.EXPERT_NAME
        order by count(1) desc
      ) aa
"),
            new Tuple<string, string, string>("TENDERER_BIDDER_DIAG", "",
                @" select * 
    from (
      select BIDDER_NAME,count(1) count
      from TENDER_LIST a
      inner join v_big_jg b on a.TENDER_PROJECT_CODE=b.PROJECT_CODE
      where  b.TENDERER_NAME=:code
###sql_where_winsendtm###  
group by BIDDER_NAME
        order by count(1) desc
      ) aa
      where rownum<=10
"),
            new Tuple<string, string, string>("DZJG_LIST", "CREATE_TIME desc",
                @"select a.tender_project_name,a.TENDERER_NAME,a.region_code
       ,area.shi
       ,b.text TENDER_PROJECT_TYPE
       ,c.count SECTION_COUNT
       ,pro.CREATE_TIME
from tender_project a
inner join (select text,value from sys_dic where pid=2525) b on a.TENDER_PROJECT_TYPE=b.value
inner join (
  select tender_project_code,count(1) count
  from section WHERE M_DATA_SOURCE='9999'
  group by tender_project_code
) c on a.tender_project_code=c.tender_project_code
inner join DSJ_AREA area on a.region_code=area.oldcode
inner join project pro on a.project_code=pro.project_code
where 1=1 
###areacodeS### and area.pcode=:AREACODE ###areacodeE###
###sql_where_tm_pro###
"),
            new Tuple<string, string, string>("WIN_LIST", "",
                @"select count(1) COUNT from WIN_RESULT_ANNO where   WIN_BIDDER_CODE=:WIN_BIDDER_CODE

"),
            new Tuple<string, string, string>("JG_ZAOBIAO_COUNT", "",
                @"select count(1) count,sum(amount) amount from(
      select TENDERER_NAME ,sum(amount) amount
      from v_big_jg where nvl(TENDERER_NAME,'-')<>'-' and AMOUNT<300000 
###sql_where_tm###  
group by TENDERER_NAME ) a
  where 1=1 
"),
            new Tuple<string, string, string>("JG_ZAOBIAO_CHART_AMOUNT", "",
                @"select Type,count(1) count,sum(AMOUNT) AMOUNT from 
(
   select 
      case when amount<200 then '1' 
          when amount>=200 and amount<1000 then '2'
          when amount>=1000 and amount<3000 then '3'
          when amount>=3000 and amount<10000 then '4'
          when amount>=10000  then '5'
      end Type  ,AMOUNT
  from v_big_jg   
  where 1=1  and AMOUNT<300000
###sql_where_tm### 
) aaa
      group by Type
      order by COUNT
"),
            new Tuple<string, string, string>("JG_ZAOBIAO_LIST_COUNT", "",
                @"select aa.*,rownum as rn
from (select TENDERER_NAME, count(distinct project_code) count
          from v_big_jg
          where 1=1 
###sql_where_tm### 
group by TENDERER_NAME
         order by count desc) aa
where rownum <= 10
"),
            new Tuple<string, string, string>("JG_PROXY_COUNT", "",
                @"select count(1) count,sum(amount) amount from(
 select TENDER_AGENCY_NAME ,sum(amount) amount
 from v_big_jg where nvl(TENDER_AGENCY_NAME,'-')<>'-' and AMOUNT<300000 
###sql_where_tm###  
group by TENDER_AGENCY_NAME ) a
  where 1=1 
"),
            new Tuple<string, string, string>("JG_PROXY_CHART_AMOUNT", "",
                @"select Type,count(1) count,sum(AMOUNT) AMOUNT from 
(
    select 
      case when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A08' then '1' 
          when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A05' then '2'
          when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A03' then '3'
          when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A04' then '4'
          when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A06' then '5'
          when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A01' then '6'
          else '7'
      end Type,AMOUNT  
  from v_big_jg a
  inner join(SELECT TENDER_PROJECT_CLASSIFY_CODE,BID_SECTION_CODE FROM section) b on b.bid_section_code=a.section_code/* in (select * from table(split(a.section_code)))*/
  where 1=1  and AMOUNT<300000
###sql_where_tm### ) aaa
      group by Type
      order by COUNT
"),
            new Tuple<string, string, string>("JG_PROXY_LIST_COUNT", "",
                @"select aa.*,rownum as rn
from (select tender_agency_name, count(distinct project_code) count
          from v_big_jg
          where 1=1 
###sql_where_tm###  
group by tender_agency_name
         order by count desc) aa
where rownum <= 10
"),
            new Tuple<string, string, string>("JG_TENDER_COUNT", "",
                @" select count(1) count from(
      select BIDDER_NAME
      from v_big_jg_tender where nvl(BIDDER_NAME,'-')<>'-' 
###sql_where_tm### 

group by BIDDER_NAME ) a
  where 1=1 
"),
            new Tuple<string, string, string>("JG_TENDER_LIST_COUNT", "",
                @"select * from (
select aa.*,rownum as rn
from (select BIDDER_NAME BIDDER_ORG_CODE,BIDDER_NAME, count(distinct TENDER_PROJECT_CODE) count
          from v_big_jg_tender
          where 1=1 
###sql_where_tm###   
group by BIDDER_NAME order by count desc
        ) aa  

) where rn <= 10 
"),
            new Tuple<string, string, string>("JG_TENDERER_CHART_AMOUNT", "",
                @"
select Type,count(1) count,sum(AMOUNT) AMOUNT from 
(
   select 
        case when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A08' then '1' 
            when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A05' then '2'
            when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A03' then '3'
            when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A04' then '4'
            when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A06' then '5'
            when substr(TENDER_PROJECT_CLASSIFY_CODE,0,3)='A01' then '6'
            else '7'
        end Type,AMOUNT
    from v_big_jg a
    inner join (SELECT TENDER_PROJECT_CLASSIFY_CODE,BID_SECTION_CODE FROM section) b on b.bid_section_code=a.section_code/* in (select * from table(split(a.section_code)))*/
    inner join (SELECT BID_SECTION_CODE,BIDDER_ORG_CODE FROM tender_list) c on b.bid_section_code=c.bid_section_code
    where 1=1  and AMOUNT<300000
###sql_where_tm###  ) aaa
      group by Type
      order by COUNT
"),
            new Tuple<string, string, string>("JG_EXPERT_COUNT", "",
                @" select count(1) count from(
      select ID_CARD
      from v_big_jg_expert where nvl(ID_CARD,'-')<>'-' 
###sql_where_tm###  group by ID_CARD ) a
  where 1=1 
"),
            new Tuple<string, string, string>("JG_EXPERT_CHART_AMOUNT", "",
                @"select Type,count(1) count from 
(
   select 
      case when count<5 then '1' 
          when count>=5 and count<10 then '2'
          when count>=10 and count<15 then '3'
          when count>=15 and count<20 then '4'                             
          when count>=20 and count<30 then '5'
          when count>=30  then '6'
      end Type  
  from (
      select id_card,count(1) count 
      from v_big_jg_expert 
      where 1=1 
###sql_where_tm###  
 group by id_card
      ) aa
      ) aaa
      group by Type
      order by COUNT
"),
            new Tuple<string, string, string>("JG_EXPERT_LIST_COUNT", "",
                @"select aa.*,rownum as rn
from (select expert_name,ID_CARD, count(distinct TENDER_PROJECT_CODE) count
          from v_big_jg_expert
          where 1=1 
###sql_where_tm### 
group by expert_name,ID_CARD
         order by count desc) aa
where rownum <= 10
"),
            new Tuple<string, string, string>("LAND_Chart_AmountCount", "",
                @"select a.areaname,round(nvl( TOTAL_AMOUNT/10000,'0'),3) TOTAL_AMOUNT,nvl(TOTAL_COUNT,0) TOTAL_COUNT,round(nvl(AVG_AMOUNT/10000,0),3) AVG_AMOUNT
from (select areacode,areaname from DSJ_AREA where pcode='350000') a
left join (
  select substr(areacode, 0, 4)||'00' areacode,SUM(WIN_AMOUNT) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT ,round(avg(AVG_AMOUNT),2) AVG_AMOUNT
  from V_BIG_LAND
  where 1=1 
###sql_where_tm###  
 group by substr(areacode, 0, 4)
      ) b on a.areacode=b.areacode
"),
            new Tuple<string, string, string>("LAND_Chart_Type", "",
                @"  select TYPE,count(1) TOTAL_COUNT
  from V_BIG_LAND
  where 1=1   
###sql_where_tm###  group by type
"),
            new Tuple<string, string, string>("LAND_AmountCount", "",
                @" select round(nvl(SUM(WIN_AMOUNT)/10000,0),3) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT ,nvl(round(avg(AVG_AMOUNT/10000),3),0) AVG_AMOUNT
  from V_BIG_LAND
  where 1=1  
###sql_where_tm###  
"),
            new Tuple<string, string, string>("LAND_Chart_AmountCountByDate", "",
                @"select to_char(M_TM,'yyyy-mm') TM,round(SUM(WIN_AMOUNT/10000),3) AS TOTAL_AMOUNT,COUNT(1) TOTAL_COUNT ,round(avg(AVG_AMOUNT/10000),3) AVG_AMOUNT
from V_BIG_LAND
where 1=1 
###sql_where_tm###  
 group by to_char(M_TM,'yyyy-mm')
      order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("ZFCG_TotalAmountCount", "",
                @"SELECT SUM(WIN_AMOUNT)/10000 AS TOTAL_AMOUNT,sum(PLAN_AMOUNT)/10000 PLAN_AMOUNT,COUNT(1) TOTAL_COUNT, (sum(PLAN_AMOUNT)-SUM(WIN_AMOUNT))/10000 JIEYUE_AMOUNT, 
       round((sum(PLAN_AMOUNT)-SUM(WIN_AMOUNT))*100/sum(PLAN_AMOUNT),2) JIEYUE_RATE
FROM v_big_caiguo  t
where 1=1  and nvl(PLAN_AMOUNT,0)<>0  and nvl(WIN_AMOUNT,0)<>0     
###sql_where_tm###
"),
            new Tuple<string, string, string>("ZFCG_Rank", "",
                @"select SUB_PROJECT_NAME,WIN_AMOUNT/10000  WIN_AMOUNT from 
(
  select * 
  from v_big_caiguo
  where 1=1  
###sql_where_tm###  
  order by  win_amount desc
) aa
where rownum<=5
"),
            new Tuple<string, string, string>("ZFCG_Chart_CaiGouType", "",
                @"select PURCHASER_MODE_NAME,sum(WIN_AMOUNT)/10000  WIN_AMOUNT
from v_big_caiguo
where 1=1  
###sql_where_tm###  
group by PURCHASER_MODE_NAME
"),
            new Tuple<string, string, string>("ZFCG_Chart_CaiGouZuZiType", "",
                @"select PURCHASER_ORGANIZE_FORM_NAME,sum(WIN_AMOUNT)/10000  WIN_AMOUNT
from v_big_caiguo
where 1=1     
###sql_where_tm###  
group by PURCHASER_ORGANIZE_FORM_NAME
"),
            new Tuple<string, string, string>("ZFCG_BigProject", "",
                @"SELECT SUM(WIN_AMOUNT)/10000 AS TOTAL_AMOUNT,Count(1) COUNT
FROM v_big_caiguo  t
where WIN_AMOUNT>=10000  
###sql_where_tm###  
"),
            new Tuple<string, string, string>("ZFCG_PPP", "",
                @"select to_char(M_TM,'yyyy-mm') MONTH,sum(WIN_AMOUNT)/10000 WIN_AMOUNT,count(1) TOTAL_COUNT
from v_big_caiguo
where 1=1    
###sql_where_tm###  
group by to_char(M_TM,'yyyy-mm')
order by to_char(M_TM,'yyyy-mm')
"),
            new Tuple<string, string, string>("ZFCG_PPP_DAY", "",
                @"select to_char(M_TM,'yyyy-mm-dd') DAY,sum(WIN_AMOUNT)/10000 WIN_AMOUNT,count(1) TOTAL_COUNT
from v_big_caiguo
where 1=1   
###sql_where_tm### 

group by to_char(M_TM,'yyyy-mm-dd')
order by to_char(M_TM,'yyyy-mm-dd')
")
        };


    }
}
