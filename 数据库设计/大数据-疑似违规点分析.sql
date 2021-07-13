/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     2020/7/28 20:19:27                           */
/*==============================================================*/


drop table BD_INQUIRE_RECORD cascade constraints;

drop table BD_VIOLATION_BASIC cascade constraints;

drop table BD_VIOLATION_ENTITY cascade constraints;

drop table BD_VIOLATION_HISTORY cascade constraints;

drop table BD_VIOLATION_POINT cascade constraints;

drop table BD_VIOLATION_POINT_DETAIL cascade constraints;

drop table BD_VIOLATION_RECORD cascade constraints;

drop sequence SEQ_BD_VIOLATION_POINT;

drop sequence SEQ_BD_VIOLATION_POINT_DETAIL;

create sequence SEQ_BD_VIOLATION_POINT
increment by 1
start with 1
 maxvalue 99999999999999999999
 minvalue 1
 cache 10
order;

create sequence SEQ_BD_VIOLATION_POINT_DETAIL
increment by 1
start with 1
 maxvalue 99999999999999999
 minvalue 1
 cache 10
order;

/*==============================================================*/
/* Table: BD_INQUIRE_RECORD                                     */
/*==============================================================*/
create table BD_INQUIRE_RECORD 
(
   ID                   VARCHAR2(50)         not null,
   VIOLATION_RECORD_ID  VARCHAR2(50)         not null,
   STATE                NUMBER               not null,
   DESCRIPTION          CLOB,
   GUIDS                CLOB,
   OPERATION_USER       NUMBER,
   OPERATION_DEPT       NUMBER,
   OPERATION_TIME       DATE                 default SYSDATE not null,
   CREATE_TIME          DATE                 default SYSDATE not null,
   IS_DELETE            NUMBER               default 0 not null,
   constraint PK_BD_INQUIRE_RECORD primary key (ID)
);

comment on table BD_INQUIRE_RECORD is
'Υ����Ϊ������';

comment on column BD_INQUIRE_RECORD.ID is
'ID';

comment on column BD_INQUIRE_RECORD.VIOLATION_RECORD_ID is
'Υ����Ϊ��¼ID';

comment on column BD_INQUIRE_RECORD.STATE is
'������״̬ 0:δ��������  1���������Ⲣ����';

comment on column BD_INQUIRE_RECORD.DESCRIPTION is
'��������¼';

comment on column BD_INQUIRE_RECORD.GUIDS is
'��ظ���GUID';

comment on column BD_INQUIRE_RECORD.OPERATION_USER is
'������';

comment on column BD_INQUIRE_RECORD.OPERATION_DEPT is
'�����˲���ID';

comment on column BD_INQUIRE_RECORD.OPERATION_TIME is
'����ʱ��';

comment on column BD_INQUIRE_RECORD.CREATE_TIME is
'����ʱ��';

comment on column BD_INQUIRE_RECORD.IS_DELETE is
'�Ƿ�ɾ��';

/*==============================================================*/
/* Table: BD_VIOLATION_BASIC                                    */
/*==============================================================*/
create table BD_VIOLATION_BASIC 
(
   ID                   VARCHAR2(50)         not null,
   NAME                 VARCHAR2(800),
   CODE                 VARCHAR2(50),
   SCORE                DECIMAL(18,4),
   REMARK               CLOB,
   RECORD_TYPE          NUMBER,
   CREATE_TIME          DATE                 default SYSDATE,
   IS_DELETE            NUMBER               default 0 not null,
   constraint PK_BD_VIOLATION_BASIC primary key (ID)
);

comment on table BD_VIOLATION_BASIC is
'����Υ��ſ�';

comment on column BD_VIOLATION_BASIC.ID is
'ID';

comment on column BD_VIOLATION_BASIC.NAME is
'����';

comment on column BD_VIOLATION_BASIC.CODE is
'�б���Ŀ����/����ͳһ������ô���';

comment on column BD_VIOLATION_BASIC.SCORE is
'�ۺ�Υ����';

comment on column BD_VIOLATION_BASIC.REMARK is
'��ע';

comment on column BD_VIOLATION_BASIC.RECORD_TYPE is
'���� 0����Ŀ 1������';

comment on column BD_VIOLATION_BASIC.CREATE_TIME is
'����ʱ��';

comment on column BD_VIOLATION_BASIC.IS_DELETE is
'�Ƿ�ɾ��';

/*==============================================================*/
/* Table: BD_VIOLATION_ENTITY                                   */
/*==============================================================*/
create table BD_VIOLATION_ENTITY 
(
   ID                   VARCHAR2(50)         not null,
   POINT_ID             NUMBER               default 0,
   POINT_CODE           VARCHAR2(50),
   POINT_NAME           VARCHAR2(200),
   ENTITY_NAME          VARCHAR2(200),
   ENTITY_CODE          VARCHAR2(50),
   AREA_CODE            VARCHAR2(6),
   CHECK_TIME           DATE                 default SYSDATE,
   RESULT_MSG           CLOB,
   RESULT_DATA          CLOB,
   SCORE                DECIMAL(18,4),
   STATE                NUMBER               default 0 not null,
   TRANSFER_STATE       NUMBER               default 0,
   CREATE_TIME          DATE                 default SYSDATE,
   IS_DELETE            NUMBER               default 0 not null,
   ENTITY_TYPE          NUMBER               default 0 not null,
   constraint PK_BD_VIOLATION_ENTITY primary key (ID)
);

comment on table BD_VIOLATION_ENTITY is
'Υ����Ϊ����';

comment on column BD_VIOLATION_ENTITY.ID is
'ID';

comment on column BD_VIOLATION_ENTITY.POINT_ID is
'����Υ���ID';

comment on column BD_VIOLATION_ENTITY.POINT_CODE is
'����Υ������';

comment on column BD_VIOLATION_ENTITY.POINT_NAME is
'����Υ�������';

comment on column BD_VIOLATION_ENTITY.ENTITY_NAME is
'��������';

comment on column BD_VIOLATION_ENTITY.ENTITY_CODE is
'����ͳһ������ô���';

comment on column BD_VIOLATION_ENTITY.AREA_CODE is
'���ڵ���';

comment on column BD_VIOLATION_ENTITY.CHECK_TIME is
'���ʱ��';

comment on column BD_VIOLATION_ENTITY.RESULT_MSG is
'�������';

comment on column BD_VIOLATION_ENTITY.SCORE is
'Υ����';

comment on column BD_VIOLATION_ENTITY.STATE is
'����״̬ 0:������ 1���ѵ���';

comment on column BD_VIOLATION_ENTITY.TRANSFER_STATE is
'����״̬';

comment on column BD_VIOLATION_ENTITY.CREATE_TIME is
'����ʱ��';

comment on column BD_VIOLATION_ENTITY.IS_DELETE is
'�Ƿ�ɾ��';

comment on column BD_VIOLATION_ENTITY.ENTITY_TYPE is
'��������(1:�б��� 2��������� 3��Ͷ����)';

/*==============================================================*/
/* Table: BD_VIOLATION_HISTORY                                  */
/*==============================================================*/
create table BD_VIOLATION_HISTORY 
(
   ID                   VARCHAR2(50)         not null,
   RECORD_ID            VARCHAR2(50),
   SOURCE_FIELD         VARCHAR2(200),
   SOURCE_VALUE         VARCHAR2(4000),
   TARGET_FIELD         VARCHAR2(200),
   TARGET_VALUE         VARCHAR2(4000),
   CREATE_TIME          DATE                 default SYSDATE,
   IS_DELETE            NUMBER               default 0,
   constraint PK_BD_VIOLATION_HISTORY primary key (ID)
);

comment on table BD_VIOLATION_HISTORY is
'Υ����Ϊ��ϸ��¼';

comment on column BD_VIOLATION_HISTORY.ID is
'ID';

comment on column BD_VIOLATION_HISTORY.RECORD_ID is
'Υ���¼ID';

comment on column BD_VIOLATION_HISTORY.SOURCE_FIELD is
'Դ�ֶ�����';

comment on column BD_VIOLATION_HISTORY.SOURCE_VALUE is
'Դ�ֶ�ֵ';

comment on column BD_VIOLATION_HISTORY.TARGET_FIELD is
'�ȶ��ֶ�����';

comment on column BD_VIOLATION_HISTORY.TARGET_VALUE is
'�ȶ��ֶ�ֵ';

comment on column BD_VIOLATION_HISTORY.CREATE_TIME is
'��������ʱ��';

comment on column BD_VIOLATION_HISTORY.IS_DELETE is
'�Ƿ�ɾ��';

/*==============================================================*/
/* Table: BD_VIOLATION_POINT                                    */
/*==============================================================*/
create table BD_VIOLATION_POINT 
(
   ID                   NUMBER               not null,
   CATEGORY_NAME        VARCHAR2(200),
   CATEGORY_CODE        VARCHAR2(50),
   PARENT_ID            NUMBER               default 0 not null,
   TENDER_PROJECT_TYPE  VARCHAR2(2000),
   IS_ENABLE            NUMBER               default 1 not null,
   SORT                 NUMBER               default 0,
   IS_DELETE            NUMBER               default 0 not null,
   CREATE_TIME          DATE                 default SYSDATE not null,
   constraint PK_BD_VIOLATION_POINT primary key (ID)
);

comment on table BD_VIOLATION_POINT is
'����Υ������';

comment on column BD_VIOLATION_POINT.ID is
'ID';

comment on column BD_VIOLATION_POINT.CATEGORY_NAME is
'�������';

comment on column BD_VIOLATION_POINT.CATEGORY_CODE is
'������';

comment on column BD_VIOLATION_POINT.PARENT_ID is
'�ϼ����ID����Ŀ¼������Ϊ 0';

comment on column BD_VIOLATION_POINT.TENDER_PROJECT_TYPE is
'�б���Ŀ����/��ҵ����';

comment on column BD_VIOLATION_POINT.IS_ENABLE is
'�Ƿ�����';

comment on column BD_VIOLATION_POINT.SORT is
'����';

comment on column BD_VIOLATION_POINT.IS_DELETE is
'�Ƿ�ɾ��';

comment on column BD_VIOLATION_POINT.CREATE_TIME is
'����ʱ��';

/*==============================================================*/
/* Table: BD_VIOLATION_POINT_DETAIL                             */
/*==============================================================*/
create table BD_VIOLATION_POINT_DETAIL 
(
   ID                   NUMBER               not null,
   NAME                 VARCHAR(200),
   CODE                 VARCHAR(50),
   DESCRIPTION          CLOB,
   RULE_DESCRIPTION     CLOB,
   RESULT_MSG           VARCHAR2(2000),
   SCORE                DECIMAL(18,4)        default 0,
   POINT_TYPE           NUMBER               default 0 not null,
   CHECK_EXPRESSION     CLOB,
   RESULT_EXPRESSION    CLOB,
   CHECK_TIME           DATE,
   SORT                 NUMBER               default 0,
   IS_ENABLE            NUMERIC              default 1 not null,
   CREATE_TIME          DATE                 default SYSDATE not null,
   IS_DELETE            NUMERIC              default 0 not null,
   constraint PK_BD_VIOLATION_POINT_DETAIL primary key (ID)
);

comment on table BD_VIOLATION_POINT_DETAIL is
'����Υ������';

comment on column BD_VIOLATION_POINT_DETAIL.ID is
'ID';

comment on column BD_VIOLATION_POINT_DETAIL.NAME is
'Υ�������';

comment on column BD_VIOLATION_POINT_DETAIL.CODE is
'Υ������';

comment on column BD_VIOLATION_POINT_DETAIL.DESCRIPTION is
'Υ�����';

comment on column BD_VIOLATION_POINT_DETAIL.RULE_DESCRIPTION is
'Υ����������';

comment on column BD_VIOLATION_POINT_DETAIL.RESULT_MSG is
'�б���Ŀ����';

comment on column BD_VIOLATION_POINT_DETAIL.SCORE is
'Υ�����';

comment on column BD_VIOLATION_POINT_DETAIL.POINT_TYPE is
'Υ�������(0:��Ŀ,1:����)';

comment on column BD_VIOLATION_POINT_DETAIL.CHECK_EXPRESSION is
'Υ����SQL���ʽ';

comment on column BD_VIOLATION_POINT_DETAIL.RESULT_EXPRESSION is
'Υ����SQL���ʽ';

comment on column BD_VIOLATION_POINT_DETAIL.SORT is
'����';

comment on column BD_VIOLATION_POINT_DETAIL.IS_ENABLE is
'�Ƿ�����';

comment on column BD_VIOLATION_POINT_DETAIL.CREATE_TIME is
'����ʱ��';

comment on column BD_VIOLATION_POINT_DETAIL.IS_DELETE is
'�Ƿ�ɾ��';

/*==============================================================*/
/* Table: BD_VIOLATION_RECORD                                   */
/*==============================================================*/
create table BD_VIOLATION_RECORD 
(
   ID                   VARCHAR2(50)         not null,
   POINT_ID             NUMBER               default 0,
   POINT_CODE           VARCHAR2(50),
   POINT_NAME           VARCHAR2(200),
   TENDER_PROJECT_NAME  VARCHAR2(600),
   TENDER_PROJECT_CODE  VARCHAR2(50),
   INDUSTRIES           NUMBER,
   TENDER_PROJECT_TYPE  VARCHAR2(50),
   AREA_CODE            VARCHAR2(6),
   CHECK_TIME           DATE                 default SYSDATE,
   RESULT_MSG           CLOB,
   RESULT_DATA          CLOB,
   SCORE                DECIMAL(18,4),
   STATE                NUMBER               default 0 not null,
   TRANSFER_STATE       NUMBER               default 0,
   CREATE_TIME          DATE                 default SYSDATE,
   IS_DELETE            NUMBER               default 0 not null,
   constraint PK_BD_VIOLATION_RECORD primary key (ID)
);

comment on table BD_VIOLATION_RECORD is
'Υ����Ϊ��¼';

comment on column BD_VIOLATION_RECORD.ID is
'ID';

comment on column BD_VIOLATION_RECORD.POINT_ID is
'����Υ���ID';

comment on column BD_VIOLATION_RECORD.POINT_CODE is
'����Υ������';

comment on column BD_VIOLATION_RECORD.POINT_NAME is
'����Υ�������';

comment on column BD_VIOLATION_RECORD.TENDER_PROJECT_NAME is
'�б���Ŀ����';

comment on column BD_VIOLATION_RECORD.TENDER_PROJECT_CODE is
'�б���Ŀ����';

comment on column BD_VIOLATION_RECORD.INDUSTRIES is
'��ҵ����(SYS_DIC TYPE 69)';

comment on column BD_VIOLATION_RECORD.TENDER_PROJECT_TYPE is
'�б���Ŀ����((SYS_DIC TYPE 63)';

comment on column BD_VIOLATION_RECORD.AREA_CODE is
'��Ŀ���ڵ���';

comment on column BD_VIOLATION_RECORD.CHECK_TIME is
'���ʱ��';

comment on column BD_VIOLATION_RECORD.RESULT_MSG is
'�������';

comment on column BD_VIOLATION_RECORD.SCORE is
'Υ����';

comment on column BD_VIOLATION_RECORD.STATE is
'����״̬ 0:������ 1���ѵ���';

comment on column BD_VIOLATION_RECORD.TRANSFER_STATE is
'����״̬';

comment on column BD_VIOLATION_RECORD.CREATE_TIME is
'����ʱ��';

comment on column BD_VIOLATION_RECORD.IS_DELETE is
'�Ƿ�ɾ��';

