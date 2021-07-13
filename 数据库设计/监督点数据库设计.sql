/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     2020/10/26 11:50:04                          */
/*==============================================================*/


drop view V_WARN_RESULT_EXPRESSION;

drop table WARN_EXPRESSION cascade constraints;

drop table WARN_EXPRESSION_DETAIL cascade constraints;

drop table WARN_EXPRESSION_NOTIFY cascade constraints;

drop table WARN_NOTIFY_CONFIG cascade constraints;

drop table WARN_RECORD cascade constraints;

drop table WARN_RESULT cascade constraints;

drop user GXDZJG;

drop sequence SEQ_WARN_EXPRESSION;

drop sequence SEQ_WARN_EXPRESSION_DETAIL;

create sequence SEQ_WARN_EXPRESSION
increment by 1
start with 140
 maxvalue 999999999999999999
 nominvalue
nocycle
 cache 10
noorder;

create sequence SEQ_WARN_EXPRESSION_DETAIL
increment by 1
start with 109
 maxvalue 9999999999999999999999999999
 nominvalue
nocycle
 cache 10
noorder;

/*==============================================================*/
/* User: GXDZJG                                                 */
/*==============================================================*/
create user GXDZJG 
  identified by "";

/*==============================================================*/
/* Table: WARN_EXPRESSION                                       */
/*==============================================================*/
create table WARN_EXPRESSION 
(
   M_ID                 NUMBER               not null,
   SP_NAME              VARCHAR2(2000)       not null
      constraint "BIN$2dmCyypCRpqerLEe7a+3IQ==$0" check ("SP_NAME" IS NOT NULL),
   SP_NODE_NAME         VARCHAR2(2000)       not null
      constraint "BIN$YSlEOP5XT2ibybCg4WDykQ==$0" check ("SP_NODE_NAME" IS NOT NULL),
   SP_FLOW_NAME         VARCHAR2(2000)       not null
      constraint "BIN$zG6zQvr3RdSZxQZdRF08Zw==$0" check ("SP_FLOW_NAME" IS NOT NULL),
   SP_TYPE              VARCHAR2(2000)       not null
      constraint "BIN$0kVeSKJ/RKGOzufp+MyFPQ==$0" check ("SP_TYPE" IS NOT NULL),
   SP_WAY               VARCHAR2(2000)       not null
      constraint "BIN$vNkmYD9xR7eOipbKznaVMQ==$0" check ("SP_WAY" IS NOT NULL),
   SP_POINT_RULE        VARCHAR2(2000),
   SP_POINT_TYPE        VARCHAR2(200),
   SP_STATUS            VARCHAR2(2),
   ISDELETE             NUMBER(1)            default 0,
   SQL                  CLOB,
   DELETE_TIME          DATE,
   CREATE_TIME          DATE                 default SYSDATE not null
      constraint "BIN$h74NMIe5Qvub6CWUUUON/A==$0" check ("CREATE_TIME" IS NOT NULL),
   DEPARTMENT_CODE      VARCHAR2(100),
   SP_NODE_NAME_EN      VARCHAR2(200),
   SP_MENU_NAME_EN      VARCHAR2(200),
   ORDERBY              NUMBER,
   REMARK               CLOB,
   constraint "BIN$zPH3GMD/R06NDF/cYwqW1w==$0" primary key (M_ID)
)
pctfree 10
initrans 1
storage
(
    initial 64K
    next 1024K
    minextents 1
    maxextents unlimited
)
logging
 nocompress
 lob
 (SQL)
    store as
         basicfile
 (tablespace GXDZJG
        chunk 8192
 retention nocache);

comment on table WARN_EXPRESSION is
'�ල����Ϣ';

comment on column WARN_EXPRESSION.M_ID is
'Ψһ��ʶ';

comment on column WARN_EXPRESSION.SP_NAME is
'�ල������';

comment on column WARN_EXPRESSION.SP_NODE_NAME is
'�ڵ�����';

comment on column WARN_EXPRESSION.SP_FLOW_NAME is
'��������';

comment on column WARN_EXPRESSION.SP_TYPE is
'�ල����';

comment on column WARN_EXPRESSION.SP_WAY is
'�ල��ʽ';

comment on column WARN_EXPRESSION.SP_POINT_RULE is
'�ල���������';

comment on column WARN_EXPRESSION.SP_POINT_TYPE is
'�ල������';

comment on column WARN_EXPRESSION.SP_STATUS is
'Ԥ��״̬��1�� 2�� 3�죩';

comment on column WARN_EXPRESSION.ISDELETE is
'�Ƿ�ɾ��';

comment on column WARN_EXPRESSION.SQL is
'sqlִ����䣬��ȡչʾ������Ϣ';

comment on column WARN_EXPRESSION.DELETE_TIME is
'ɾ��ʱ��';

comment on column WARN_EXPRESSION.CREATE_TIME is
'���ʱ��';

comment on column WARN_EXPRESSION.DEPARTMENT_CODE is
'��ӦMGR_DEPERTMENT��CODE';

comment on column WARN_EXPRESSION.SP_NODE_NAME_EN is
'�ڵ�����Ӣ����������ǰ��˽���';

comment on column WARN_EXPRESSION.SP_MENU_NAME_EN is
'��Ӧ�˵�Ӣ���������ھ����ڱ�����˵���Щ�˵�չʾ�ļල��';

comment on column WARN_EXPRESSION.ORDERBY is
'˳��';

/*==============================================================*/
/* Table: WARN_EXPRESSION_DETAIL                                */
/*==============================================================*/
create table WARN_EXPRESSION_DETAIL 
(
   M_ID                 NUMBER               not null
      constraint "BIN$JFwILxxRTI6aZ1KWM85xKA==$0" check ("M_ID" IS NOT NULL),
   PARENT_M_ID          NUMBER               not null
      constraint "BIN$4FiVF54VQPyeaQ64csc+Gg==$0" check ("PARENT_M_ID" IS NOT NULL),
   SP_NAME              VARCHAR2(200)        not null
      constraint "BIN$6Ce0toyST4WMO6jf2hCXyg==$0" check ("SP_NAME" IS NOT NULL),
   MAIN_TABLE           VARCHAR2(200)        not null
      constraint "BIN$WAOwLBpHTuaTDsTiHkuoog==$0" check ("MAIN_TABLE" IS NOT NULL),
   MAIN_FIELD           VARCHAR2(200)        not null
      constraint "BIN$7wFxW+wdQDWMWE4xDwpjkw==$0" check ("MAIN_FIELD" IS NOT NULL),
   EXPRESSION_TYPE      VARCHAR2(200)        not null
      constraint "BIN$9b7AmpuDTUuM/LgVpdmFgg==$0" check ("EXPRESSION_TYPE" IS NOT NULL),
   TARGET_TABLE         VARCHAR2(200),
   TARGET_FIELD         VARCHAR2(200),
   CONST_NUMBER         VARCHAR2(200),
   CONST_STRING         VARCHAR2(500),
   EXECUTE_SQL          VARCHAR2(1000),
   ISDELETE             NUMBER(1)            default 0 not null
      constraint "BIN$4xHPZK/MRPOnDcFD+nTRdA==$0" check ("ISDELETE" IS NOT NULL),
   DELETE_TIME          DATE,
   CREAT_TIME           DATE                 default SYSDATE not null
      constraint "BIN$ywoYHGqITSeNpyAimBlaSA==$0" check ("CREAT_TIME" IS NOT NULL),
   LIMIT_DAY            NUMBER,
   LIMIT_DAY_UNIT       NUMBER               default 1,
   CHECK_TIME           DATE,
   constraint "BIN$iFNOrU2DTqGJ8kW2UhIzqw==$0" primary key (M_ID)
)
pctfree 10
initrans 1
storage
(
    initial 64K
    next 1024K
    minextents 1
    maxextents unlimited
)
tablespace GXDZJG
logging
 nocompress
 monitoring
 noparallel;

comment on table WARN_EXPRESSION_DETAIL is
'�ල����������';

comment on column WARN_EXPRESSION_DETAIL.M_ID is
'M_ID';

comment on column WARN_EXPRESSION_DETAIL.PARENT_M_ID is
'�ල��ID';

comment on column WARN_EXPRESSION_DETAIL.SP_NAME is
'��������';

comment on column WARN_EXPRESSION_DETAIL.MAIN_TABLE is
'�ල�ֶι���������';

comment on column WARN_EXPRESSION_DETAIL.MAIN_FIELD is
'�ල�ֶ�����';

comment on column WARN_EXPRESSION_DETAIL.EXPRESSION_TYPE is
'���ʽ����';

comment on column WARN_EXPRESSION_DETAIL.TARGET_TABLE is
'�Ƚ��ֶα�����';

comment on column WARN_EXPRESSION_DETAIL.TARGET_FIELD is
'�Ƚ��ֶ�����';

comment on column WARN_EXPRESSION_DETAIL.CONST_NUMBER is
'������ֵ��������[1,2]��ʽ';

comment on column WARN_EXPRESSION_DETAIL.CONST_STRING is
'�����ı���������["a","b"]��ʽ';

comment on column WARN_EXPRESSION_DETAIL.EXECUTE_SQL is
'ֱ��ִ��SQL���';

comment on column WARN_EXPRESSION_DETAIL.ISDELETE is
'�Ƿ�ɾ��';

comment on column WARN_EXPRESSION_DETAIL.DELETE_TIME is
'ɾ��ʱ��';

comment on column WARN_EXPRESSION_DETAIL.CREAT_TIME is
'���ʱ��';

comment on column WARN_EXPRESSION_DETAIL.LIMIT_DAY is
'����ʱ�ޣ��죩';

comment on column WARN_EXPRESSION_DETAIL.LIMIT_DAY_UNIT is
'����ʱ�ޣ���λ�� 1:������ 2��������';

comment on column WARN_EXPRESSION_DETAIL.CHECK_TIME is
'�����ʱ��';

/*==============================================================*/
/* Table: WARN_EXPRESSION_NOTIFY                                */
/*==============================================================*/
create table WARN_EXPRESSION_NOTIFY 
(
   M_ID                 VARCHAR2(200)        default SYS_GUID() not null,
   SP_NAME              VARCHAR2(2000),
   SP_NODE_NAME         VARCHAR2(2000),
   TENDER_PROJECT_CODE  NVARCHAR2(20),
   TENDER_PROJECT_NAME  NVARCHAR2(600),
   NOTIFY_END_TIME      DATE,
   SP_POINT_TYPE        VARCHAR2(200),
   REGION_CODE          NVARCHAR2(6),
   TENDERER_CODE_TYPE   NVARCHAR2(20),
   CREATE_TIME          DATE                 default SYSDATE not null,
   ISDELETE             NUMBER(1)            default 0 not null,
   CHECK_UPDATE_SQL     NVARCHAR2(2000),
   IS_CHECK_STATUS      NUMBER(1)            default 0 not null,
   LAST_CHECK_TIME      DATE,
   SOURCE_M_ID          VARCHAR2(200),
   constraint P_WARN_EXPRESSION_NOTIFY_M_ID primary key (M_ID)
         using index pctfree 10
   initrans 2
   storage
   (
       initial 64K
       next 1024K
       minextents 1
       maxextents unlimited
   )
   logging
   tablespace GXDZJG
)
pctfree 10
initrans 1
storage
(
    initial 64K
    next 1024K
    minextents 1
    maxextents unlimited
)
tablespace GXDZJG
logging
 nocompress
 monitoring
 noparallel;

comment on table WARN_EXPRESSION_NOTIFY is
'WARN_EXPRESSION_NOTIFY';

comment on column WARN_EXPRESSION_NOTIFY.M_ID is
'Ψһ��ʶ';

comment on column WARN_EXPRESSION_NOTIFY.SP_NAME is
'�ල������';

comment on column WARN_EXPRESSION_NOTIFY.SP_NODE_NAME is
'�ڵ�����';

comment on column WARN_EXPRESSION_NOTIFY.TENDER_PROJECT_CODE is
'�б���Ŀ���';

comment on column WARN_EXPRESSION_NOTIFY.TENDER_PROJECT_NAME is
'�б���Ŀ����';

comment on column WARN_EXPRESSION_NOTIFY.NOTIFY_END_TIME is
'���ѽ�ֹʱ��';

comment on column WARN_EXPRESSION_NOTIFY.SP_POINT_TYPE is
'�ල������';

comment on column WARN_EXPRESSION_NOTIFY.REGION_CODE is
'�б���Ŀ���������������';

comment on column WARN_EXPRESSION_NOTIFY.TENDERER_CODE_TYPE is
'�б������';

comment on column WARN_EXPRESSION_NOTIFY.CREATE_TIME is
'���ʱ��';

comment on column WARN_EXPRESSION_NOTIFY.ISDELETE is
'�Ƿ�ɾ��';

comment on column WARN_EXPRESSION_NOTIFY.CHECK_UPDATE_SQL is
'״̬���µ�UPDATE���';

comment on column WARN_EXPRESSION_NOTIFY.IS_CHECK_STATUS is
'�Ƿ��Ѹ���״̬';

comment on column WARN_EXPRESSION_NOTIFY.LAST_CHECK_TIME is
'���һ��ִ��CHECK_UPDATE_SQL���ʱ��';

comment on column WARN_EXPRESSION_NOTIFY.SOURCE_M_ID is
'CHECK_UPDATE_SQL������Դ����M_ID';

/*==============================================================*/
/* Table: WARN_NOTIFY_CONFIG                                    */
/*==============================================================*/
create table WARN_NOTIFY_CONFIG 
(
   M_ID                 VARCHAR2(200)        not null,
   SP_ID                VARCHAR2(200),
   SP_NAME              VARCHAR2(2000),
   SP_DETAIL_ID         VARCHAR2(200),
   SP_DETAIL_NAME       VARCHAR2(2000),
   SP_NODE_NAME         VARCHAR2(2000),
   MAIN_TABLE           VARCHAR2(50)         not null,
   EXECUTE_SQL          VARCHAR2(4000)       not null,
   LASTCHECKTIME        DATE                 default SYSDATE not null,
   CREATE_TIME          DATE                 default SYSDATE not null,
   ISDELETE             NUMBER(1),
   CHECK_UPDATE_SQL     VARCHAR2(2000),
   constraint P_WARN_NOTIFY_CONFIG primary key (M_ID)
         using index pctfree 10
   initrans 2
   storage
   (
       initial 64K
       next 1024K
       minextents 1
       maxextents unlimited
   )
   logging
   tablespace GXDZJG
)
pctfree 10
initrans 1
storage
(
    initial 64K
    next 1024K
    minextents 1
    maxextents unlimited
)
tablespace GXDZJG
logging
 nocompress
 monitoring
 noparallel;

comment on table WARN_NOTIFY_CONFIG is
'�ල��Ԥ��֪ͨ����ʱģ������';

comment on column WARN_NOTIFY_CONFIG.M_ID is
'Ωһ��־';

comment on column WARN_NOTIFY_CONFIG.SP_ID is
'�ල��ID';

comment on column WARN_NOTIFY_CONFIG.SP_NAME is
'�ල������';

comment on column WARN_NOTIFY_CONFIG.SP_DETAIL_ID is
'�ල���������ID';

comment on column WARN_NOTIFY_CONFIG.SP_DETAIL_NAME is
'�ල�������������';

comment on column WARN_NOTIFY_CONFIG.SP_NODE_NAME is
'�ڵ�����';

comment on column WARN_NOTIFY_CONFIG.MAIN_TABLE is
'����������';

comment on column WARN_NOTIFY_CONFIG.EXECUTE_SQL is
'���ִ��SQL���';

comment on column WARN_NOTIFY_CONFIG.LASTCHECKTIME is
'�����ִ��ʱ��';

comment on column WARN_NOTIFY_CONFIG.CREATE_TIME is
'��¼���ʱ��';

comment on column WARN_NOTIFY_CONFIG.ISDELETE is
'�Ƿ�ɾ��';

comment on column WARN_NOTIFY_CONFIG.CHECK_UPDATE_SQL is
'��������ʱִ�и������ģ��';

/*==============================================================*/
/* Table: WARN_RECORD                                           */
/*==============================================================*/
create table WARN_RECORD 
(
   M_ID                 VARCHAR2(200)        not null,
   SP_RESULT_ID         VARCHAR2(200),
   OPERATOR             VARCHAR2(2000),
   CREATE_TIME          DATE,
   CONTENT              VARCHAR2(2000),
   OPERATE_TYPE         VARCHAR2(2),
   REMARK               CLOB,
   WARN_NUMBER          VARCHAR2(200),
   INFO_ACCEPT_TELPHONE VARCHAR2(2000),
   ISDELETE             NUMBER(1)            default 0,
   INFO_ACCEPT_TELPHONE1 VARCHAR2(2000),
   constraint "BIN$POquRVz+Sb6sSNBSJBtHSw==$0" primary key (M_ID)
)
pctfree 10
initrans 1
storage
(
    initial 64K
    next 1024K
    minextents 1
    maxextents unlimited
)
tablespace GXDZJG
logging
 nocompress
 lob
 (REMARK)
    store as
         basicfile
 (tablespace GXDZJG
        chunk 8192
 retention nocache);

comment on table WARN_RECORD is
'�ල��¼';

comment on column WARN_RECORD.M_ID is
'Ψһ��ʶ';

comment on column WARN_RECORD.SP_RESULT_ID is
'��Ӧ���id';

comment on column WARN_RECORD.OPERATOR is
'�����ˣ�����Ϊϵͳ';

comment on column WARN_RECORD.CREATE_TIME is
'����ʱ��';

comment on column WARN_RECORD.CONTENT is
'���ݣ���Ա�ע������ʾ��������¼�����������д������';

comment on column WARN_RECORD.OPERATE_TYPE is
'�������� 1ϵͳ  2����  3Ԥ��';

comment on column WARN_RECORD.REMARK is
'��ע������˵������Ԥ������';

comment on column WARN_RECORD.WARN_NUMBER is
'Ԥ�����';

comment on column WARN_RECORD.INFO_ACCEPT_TELPHONE is
'��Ϣ�����˺���';

comment on column WARN_RECORD.ISDELETE is
'�Ƿ�ɾ��';

comment on column WARN_RECORD.INFO_ACCEPT_TELPHONE1 is
'��Ϣ�����˺���,��һ��չ�ַ�ʽ';

/*==============================================================*/
/* Table: WARN_RESULT                                           */
/*==============================================================*/
create table WARN_RESULT 
(
   M_ID                 VARCHAR2(200)        not null,
   MAIN_M_ID            VARCHAR2(200),
   SUB_M_ID             VARCHAR2(2000),
   TENDER_PROJECT_CODE  VARCHAR2(200),
   PROJECT_CODE         VARCHAR2(200),
   BID_SECTION_CODE     VARCHAR2(2000),
   SP_ID                NUMBER,
   RESULT_STATUS        VARCHAR2(2),
   OPERATE_STATUS       VARCHAR2(2),
   REGION_CODE          VARCHAR2(6),
   TENDER_PROJECT_TYPE  VARCHAR2(3),
   CONTENT              CLOB,
   SP_TIME              DATE,
   DATA_TIMESTAMP       DATE,
   DEAL_LIMIT_TIME      DATE,
   LAST_RECORD_TIME     DATE,
   ISDELETE             NUMBER(1)            default 0,
   constraint "BIN$Cuev8dQcRoapup5LB6STdg==$0" primary key (M_ID)
)
pctfree 10
initrans 1
storage
(
    initial 64K
    next 1024K
    minextents 1
    maxextents unlimited
)
tablespace GXDZJG
logging
 nocompress
 lob
 (CONTENT)
    store as
         basicfile
 (tablespace GXDZJG
        chunk 8192
 retention nocache);

comment on table WARN_RESULT is
'�ල���';

comment on column WARN_RESULT.M_ID is
'Ψһ��ʶ';

comment on column WARN_RESULT.MAIN_M_ID is
'����id����Ӧ����������';

comment on column WARN_RESULT.SUB_M_ID is
'�ӱ�id���ֺŸ���������+����+ID+�ֺ�+����+����+ID��';

comment on column WARN_RESULT.TENDER_PROJECT_CODE is
'�б���Ŀ���';

comment on column WARN_RESULT.PROJECT_CODE is
'��Ŀ���';

comment on column WARN_RESULT.BID_SECTION_CODE is
'��α��';

comment on column WARN_RESULT.SP_ID is
'��Ӧ�ļල��id';

comment on column WARN_RESULT.RESULT_STATUS is
'״̬��0δ�ල 1�� 2�� 3�죩';

comment on column WARN_RESULT.OPERATE_STATUS is
'����״̬';

comment on column WARN_RESULT.REGION_CODE is
'��Ŀ���ڵ���';

comment on column WARN_RESULT.TENDER_PROJECT_TYPE is
'�б���Ŀ���ͣ�����ס��ˮ����ͨ';

comment on column WARN_RESULT.CONTENT is
'�ල������';

comment on column WARN_RESULT.SP_TIME is
'�ලʱ��';

comment on column WARN_RESULT.DATA_TIMESTAMP is
'ʱ���';

comment on column WARN_RESULT.DEAL_LIMIT_TIME is
'����ʱ��';

comment on column WARN_RESULT.LAST_RECORD_TIME is
'�����ʱ��';

comment on column WARN_RESULT.ISDELETE is
'�Ƿ�ɾ��';

/*==============================================================*/
/* View: V_WARN_RESULT_EXPRESSION                               */
/*==============================================================*/
create or replace view V_WARN_RESULT_EXPRESSION as
select tender_project_code,sp_node_name_en,SP_MENU_NAME_EN,max(RESULT_STATUS) status from(
SELECT A.TENDER_PROJECT_CODE,A.RESULT_STATUS,B.SP_NODE_NAME_EN ,b.SP_MENU_NAME_EN FROM  warn_RESULT  A
INNER JOIN WARN_EXPRESSION B ON A.SP_ID = B.M_ID
)
group by tender_project_code,sp_node_name_en,SP_MENU_NAME_EN;

 comment on table V_WARN_RESULT_EXPRESSION is
'V_WARN_RESULT_EXPRESSION';

