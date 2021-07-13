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
'违规行为调查结果';

comment on column BD_INQUIRE_RECORD.ID is
'ID';

comment on column BD_INQUIRE_RECORD.VIOLATION_RECORD_ID is
'违规行为记录ID';

comment on column BD_INQUIRE_RECORD.STATE is
'调查结果状态 0:未发现问题  1：发现问题并处理';

comment on column BD_INQUIRE_RECORD.DESCRIPTION is
'处理结果记录';

comment on column BD_INQUIRE_RECORD.GUIDS is
'相关附件GUID';

comment on column BD_INQUIRE_RECORD.OPERATION_USER is
'处理人';

comment on column BD_INQUIRE_RECORD.OPERATION_DEPT is
'处理人部门ID';

comment on column BD_INQUIRE_RECORD.OPERATION_TIME is
'处理时间';

comment on column BD_INQUIRE_RECORD.CREATE_TIME is
'创建时间';

comment on column BD_INQUIRE_RECORD.IS_DELETE is
'是否删除';

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
'疑似违规概况';

comment on column BD_VIOLATION_BASIC.ID is
'ID';

comment on column BD_VIOLATION_BASIC.NAME is
'名称';

comment on column BD_VIOLATION_BASIC.CODE is
'招标项目编码/主体统一社会信用代码';

comment on column BD_VIOLATION_BASIC.SCORE is
'综合违规率';

comment on column BD_VIOLATION_BASIC.REMARK is
'备注';

comment on column BD_VIOLATION_BASIC.RECORD_TYPE is
'类型 0：项目 1：主体';

comment on column BD_VIOLATION_BASIC.CREATE_TIME is
'创建时间';

comment on column BD_VIOLATION_BASIC.IS_DELETE is
'是否删除';

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
'违规行为主体';

comment on column BD_VIOLATION_ENTITY.ID is
'ID';

comment on column BD_VIOLATION_ENTITY.POINT_ID is
'疑似违规点ID';

comment on column BD_VIOLATION_ENTITY.POINT_CODE is
'疑似违规点编码';

comment on column BD_VIOLATION_ENTITY.POINT_NAME is
'疑似违规点名称';

comment on column BD_VIOLATION_ENTITY.ENTITY_NAME is
'主体名称';

comment on column BD_VIOLATION_ENTITY.ENTITY_CODE is
'主体统一社会信用代码';

comment on column BD_VIOLATION_ENTITY.AREA_CODE is
'所在地区';

comment on column BD_VIOLATION_ENTITY.CHECK_TIME is
'检测时间';

comment on column BD_VIOLATION_ENTITY.RESULT_MSG is
'分析结果';

comment on column BD_VIOLATION_ENTITY.SCORE is
'违规率';

comment on column BD_VIOLATION_ENTITY.STATE is
'调查状态 0:待调查 1：已调查';

comment on column BD_VIOLATION_ENTITY.TRANSFER_STATE is
'移送状态';

comment on column BD_VIOLATION_ENTITY.CREATE_TIME is
'创建时间';

comment on column BD_VIOLATION_ENTITY.IS_DELETE is
'是否删除';

comment on column BD_VIOLATION_ENTITY.ENTITY_TYPE is
'主体类型(1:招标人 2：代理机构 3：投标人)';

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
'违规行为详细记录';

comment on column BD_VIOLATION_HISTORY.ID is
'ID';

comment on column BD_VIOLATION_HISTORY.RECORD_ID is
'违规记录ID';

comment on column BD_VIOLATION_HISTORY.SOURCE_FIELD is
'源字段名称';

comment on column BD_VIOLATION_HISTORY.SOURCE_VALUE is
'源字段值';

comment on column BD_VIOLATION_HISTORY.TARGET_FIELD is
'比对字段名称';

comment on column BD_VIOLATION_HISTORY.TARGET_VALUE is
'比对字段值';

comment on column BD_VIOLATION_HISTORY.CREATE_TIME is
'数据生成时间';

comment on column BD_VIOLATION_HISTORY.IS_DELETE is
'是否删除';

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
'疑似违规点类别';

comment on column BD_VIOLATION_POINT.ID is
'ID';

comment on column BD_VIOLATION_POINT.CATEGORY_NAME is
'类别名称';

comment on column BD_VIOLATION_POINT.CATEGORY_CODE is
'类别编码';

comment on column BD_VIOLATION_POINT.PARENT_ID is
'上级类别ID，根目录则设置为 0';

comment on column BD_VIOLATION_POINT.TENDER_PROJECT_TYPE is
'招标项目类型/行业类型';

comment on column BD_VIOLATION_POINT.IS_ENABLE is
'是否启用';

comment on column BD_VIOLATION_POINT.SORT is
'排序';

comment on column BD_VIOLATION_POINT.IS_DELETE is
'是否删除';

comment on column BD_VIOLATION_POINT.CREATE_TIME is
'创建时间';

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
'疑似违规点规则';

comment on column BD_VIOLATION_POINT_DETAIL.ID is
'ID';

comment on column BD_VIOLATION_POINT_DETAIL.NAME is
'违规点名称';

comment on column BD_VIOLATION_POINT_DETAIL.CODE is
'违规点编码';

comment on column BD_VIOLATION_POINT_DETAIL.DESCRIPTION is
'违规点简介';

comment on column BD_VIOLATION_POINT_DETAIL.RULE_DESCRIPTION is
'违规点规则描述';

comment on column BD_VIOLATION_POINT_DETAIL.RESULT_MSG is
'招标项目类型';

comment on column BD_VIOLATION_POINT_DETAIL.SCORE is
'违规概率';

comment on column BD_VIOLATION_POINT_DETAIL.POINT_TYPE is
'违规点类型(0:项目,1:主体)';

comment on column BD_VIOLATION_POINT_DETAIL.CHECK_EXPRESSION is
'违规检测SQL表达式';

comment on column BD_VIOLATION_POINT_DETAIL.RESULT_EXPRESSION is
'违规结果SQL表达式';

comment on column BD_VIOLATION_POINT_DETAIL.SORT is
'排序';

comment on column BD_VIOLATION_POINT_DETAIL.IS_ENABLE is
'是否启用';

comment on column BD_VIOLATION_POINT_DETAIL.CREATE_TIME is
'创建时间';

comment on column BD_VIOLATION_POINT_DETAIL.IS_DELETE is
'是否删除';

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
'违规行为记录';

comment on column BD_VIOLATION_RECORD.ID is
'ID';

comment on column BD_VIOLATION_RECORD.POINT_ID is
'疑似违规点ID';

comment on column BD_VIOLATION_RECORD.POINT_CODE is
'疑似违规点编码';

comment on column BD_VIOLATION_RECORD.POINT_NAME is
'疑似违规点名称';

comment on column BD_VIOLATION_RECORD.TENDER_PROJECT_NAME is
'招标项目名称';

comment on column BD_VIOLATION_RECORD.TENDER_PROJECT_CODE is
'招标项目编码';

comment on column BD_VIOLATION_RECORD.INDUSTRIES is
'行业分类(SYS_DIC TYPE 69)';

comment on column BD_VIOLATION_RECORD.TENDER_PROJECT_TYPE is
'招标项目类型((SYS_DIC TYPE 63)';

comment on column BD_VIOLATION_RECORD.AREA_CODE is
'项目所在地区';

comment on column BD_VIOLATION_RECORD.CHECK_TIME is
'检测时间';

comment on column BD_VIOLATION_RECORD.RESULT_MSG is
'分析结果';

comment on column BD_VIOLATION_RECORD.SCORE is
'违规率';

comment on column BD_VIOLATION_RECORD.STATE is
'调查状态 0:待调查 1：已调查';

comment on column BD_VIOLATION_RECORD.TRANSFER_STATE is
'移送状态';

comment on column BD_VIOLATION_RECORD.CREATE_TIME is
'创建时间';

comment on column BD_VIOLATION_RECORD.IS_DELETE is
'是否删除';

