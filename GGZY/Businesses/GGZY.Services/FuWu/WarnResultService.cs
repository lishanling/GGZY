using Dos.ORM;
using GGZY.Core.Models;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZY.Services.JianDu;
using GGZYJD.DbEntity;
using SYS_DIC = GGZYJD.DbEntity.SYS_DIC;

namespace GGZY.Services.FuWu
{
    public partial class WarnResultService
    {
        /// <summary>
        /// 根据项目信息筛选监督点列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="TENDER_PROJECT_CODE">招标项目名称</param>
        /// <param name="TENDER_PROJECT_NAME">招标项目编号</param>
        /// <returns></returns>
        public PageTableResult PageTable(SearchCondition search, string TENDER_PROJECT_CODE, string TENDER_PROJECT_NAME)
        {

            var condition = new WhereClipBuilder();

            if (!String.IsNullOrEmpty(TENDER_PROJECT_CODE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE);
            }

            if (!String.IsNullOrEmpty(TENDER_PROJECT_NAME))
            {
                condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.Like(TENDER_PROJECT_NAME));
            }


            var count = FromWhere<WARN_RESULT>()
                .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Where(condition.ToWhereClip())
                .Count();

            var datas = FromWhere<WARN_RESULT>()
                .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Where(condition.ToWhereClip())
                .Page(search.PageSize, search.PageNo)
                .Select(
                WARN_RESULT._.M_ID,
                GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                WARN_EXPRESSION._.SP_NAME,
                WARN_EXPRESSION._.SP_TYPE,
                WARN_EXPRESSION._.SP_FLOW_NAME,
                WARN_RESULT._.RESULT_STATUS,
                WARN_RESULT._.SP_TIME
                )
                .ToList<dynamic>();
            return new PageTableResult
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                Table = datas
            };
        }

        /// <summary>
        /// 监督点信息
        /// </summary>
        /// <param name="mId"></param>
        /// <returns></returns>
        public object WarnResultDetail(string mId)
        {
            var warnResult = FromWhere(WARN_RESULT._.M_ID == mId)
                .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID &&
                                           WARN_EXPRESSION._.ISDELETE != 1)
                .Select(
                    WARN_EXPRESSION._.SP_NAME,
                    WARN_EXPRESSION._.SP_TYPE,
                    WARN_EXPRESSION._.SP_FLOW_NAME,
                    WARN_EXPRESSION._.SP_NODE_NAME,
                    WARN_EXPRESSION._.SP_POINT_RULE,
                    WARN_EXPRESSION._.SP_POINT_TYPE,
                    WARN_EXPRESSION._.SP_WAY,
                    WARN_EXPRESSION._.SP_STATUS,
                    WARN_RESULT._.All)
                .ToFirst<FwWarnResultExpressionModel>();
            var warnRecords =
                Fw.WarnRecordService.FindList(WARN_RECORD._.SP_RESULT_ID == mId && WARN_RECORD._.ISDELETE != 1);
            return new
            {
                JDDXXNR = warnResult,
                JDDDT = warnRecords
            };
        }

        #region 监督类型
        public object SpStatus()
        {
            var r = FromWhere().Select(WARN_RESULT._.RESULT_STATUS).ToList();
            var values = r.Select(c => c.RESULT_STATUS).Distinct().ToList();
            return values;
        }
        #endregion

        #region 公安厅外网系统
        /// <summary>
        /// 根据项目信息筛选监督点列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="TENDER_PROJECT_CODE">招标项目名称</param>
        /// <returns></returns>
        public PageTableResult PageTable(SearchCondition search, string TENDER_PROJECT_CODE)
        {
            var condition = new WhereClipBuilder();

            if (!String.IsNullOrEmpty(TENDER_PROJECT_CODE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE);
            }


            var count = FromWhere<WARN_RESULT>()
                .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Where(condition.ToWhereClip())
                .Count();

            var datas = FromWhere<WARN_RESULT>()
                .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Where(condition.ToWhereClip())
                .Page(search.PageSize, search.PageNo)
                .Select(
                WARN_RESULT._.M_ID,
                GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                WARN_EXPRESSION._.SP_NAME,
                WARN_EXPRESSION._.SP_TYPE,
                WARN_EXPRESSION._.SP_FLOW_NAME,
                WARN_RESULT._.RESULT_STATUS,
                WARN_RESULT._.SP_TIME
                )
                .ToList<dynamic>();
            return new PageTableResult
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                Table = datas
            };
        }




        #endregion

        #region 招投标过程监督

        #region 项目监督-监督总数、正常、异常统计
        /// <summary>
        /// 全部监督点总数
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public GeneralResult pointCount(string tender_project_code, string type, SearchCondition search)
        {
            GeneralResult r = new GeneralResult();
            var condition = new WhereClipBuilder();

            var bm = Jd.TenderProjectService.FromWhere<GGZYJD.DbEntity.TENDER_PROJECT>()
               .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID)
               .Where(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == tender_project_code)
               .Select(
                T_USER_DEPARTMENT._.DNAME
                   ).ToScalar();


            switch (type)
            {
                case "0":
                    condition.And(WARN_RESULT._.TENDER_PROJECT_CODE == tender_project_code);
                    break;
                case "1":
                    condition.And(WARN_RESULT._.TENDER_PROJECT_CODE == tender_project_code);
                    condition.And(WARN_RESULT._.RESULT_STATUS == "1" && WARN_RESULT._.ISDELETE != 1);

                    break;
                case "3":
                    condition.And(WARN_RESULT._.TENDER_PROJECT_CODE == tender_project_code);
                    condition.And(WARN_RESULT._.RESULT_STATUS == "3" && WARN_RESULT._.ISDELETE != 1);

                    break;
                default:

                    break;
            }
            var total = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())
               .LeftJoin<WARN_RESULT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
               .Count();
            var feed = FromWhere()
                .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                //分页页码
                .Page(search.PageSize, search.PageNo)
                .Where(condition.ToWhereClip())
                .Select(
                    WARN_RESULT._.M_ID,
                    WARN_RESULT._.RESULT_STATUS,
                    WARN_EXPRESSION._.SP_NAME,
                    WARN_EXPRESSION._.SP_TYPE,
                    WARN_EXPRESSION._.SP_WAY,
                    WARN_EXPRESSION._.SP_POINT_RULE,
                    WARN_RESULT._.TENDER_PROJECT_CODE,
                    GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    WARN_RESULT._.SP_TIME
                ).ToList<dynamic>()
                .Select(t => new
                {
                    M_ID = t.M_ID,
                    RESULT_STATUS = t.RESULT_STATUS,
                    SP_NAME = t.SP_NAME,
                    SP_TYPE = t.SP_TYPE,
                    UNIT = bm,
                    SP_WAY = t.SP_WAY,
                    SP_TIME = t.SP_TIME,
                    SP_POINT_RULE = t.SP_POINT_RULE,
                    TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                    TENDER_PROJECT_NAME = t.TENDER_PROJECT_NAME
                    // PHONE = phone
                }).ToList();
            var pageList = feed.ToPageTableTResult(search, total);
            r.SetSuccess(pageList);

            if (null == type)
            {
                r.SetFail("信息不存在");
                return r;
            }


            return r;

        }


        /// <summary>
        /// 监督日志
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public GeneralResult Monitoring_Log(string tender_project_code, SearchCondition search)
        {
            GeneralResult r = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(WARN_RESULT._.TENDER_PROJECT_CODE == tender_project_code);
            //统计内容监督
            var contentSuper = FromWhere()
                        .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                         .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                        .Where(WARN_RESULT._.RESULT_STATUS == "3" && WARN_EXPRESSION._.SP_TYPE == "内容监督" && condition.ToWhereClip())
                        .Count();
            //统计时限监督
            var timeLimit = FromWhere()
                        .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                         .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                        .Where(WARN_RESULT._.RESULT_STATUS == "3" && WARN_EXPRESSION._.SP_TYPE == "时限监督" && condition.ToWhereClip())
                        .Count();

            var total = FromWhere(condition.ToWhereClip())
             .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
             .Count();
            var feed = Fw.WarnResultService.FromWhere(WARN_RESULT._.TENDER_PROJECT_CODE == tender_project_code)
             .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
            .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
            .LeftJoin<WARN_RECORD>(WARN_RECORD._.SP_RESULT_ID == WARN_RESULT._.M_ID)
            .Where(condition.ToWhereClip())
            //分页页码
             .Page(search.PageSize, search.PageNo)
            .Select(
                WARN_RESULT._.TENDER_PROJECT_CODE,
                WARN_RESULT._.M_ID,
                WARN_EXPRESSION._.SP_NAME,
                WARN_EXPRESSION._.SP_TYPE,
                WARN_RESULT._.RESULT_STATUS,
                WARN_RECORD._.OPERATE_TYPE,
                WARN_RECORD._.OPERATOR,
                WARN_RECORD._.CONTENT,
                WARN_RECORD._.CREATE_TIME,
                WARN_RECORD._.REMARK
            ).ToList<dynamic>();

            var pageList = feed.ToPageTableTResult(search, total);



            r.SetSuccess(new { contentSuper, timeLimit, pageList });

            return r;
        }

        #endregion

        #region 招投标过程监督-监督点详情-红灯变更
        /// <summary>
        /// 监督点详情
        /// </summary>
        public GeneralResult WarnResultDetails(WARN_RESULT model)
        {
            GeneralResult r = new GeneralResult();
            var condition = ConditionBuilder(model);


            var record = Fw.WarnResultService.FirstOrNull(condition);


            if (null == record)
            {
                r.SetFail("记录信息不存在");
                return r;
            }
            var project = Fw.WarnExpressionService.FirstOrNull(WARN_EXPRESSION._.M_ID == record.SP_ID);
            //动态
            var dynamic = Fw.WarnRecordService.FindList(WARN_RECORD._.SP_RESULT_ID == record.M_ID && WARN_RECORD._.OPERATE_TYPE == "1");
            //预警信息
            var dynamic2 = Fw.WarnRecordService.FindList(WARN_RECORD._.SP_RESULT_ID == record.M_ID && WARN_RECORD._.OPERATE_TYPE == "3");

            //反馈
            var feedback = Fw.WarnFeedBackService.FindList(WARN_FEEDBACK._.SP_RECORD_ID.In(dynamic2.Select(e => e.M_ID).ToArray()));
            //监督点信息
            var data = new
            {
                M_ID = record.M_ID,
                SP_NAME = project.SP_NAME,
                SP_STATUS = record.RESULT_STATUS,
                SP_TYPE = project.SP_TYPE,
                SP_WAY = project.SP_WAY,
                SP_POINT_RULE = project.SP_POINT_RULE,
                CONTENT = record.CONTENT,
                OPERATE_STATUS = record.OPERATE_STATUS

            };

            // LabelValueModel
            //监督点动态
            var der = dynamic.Where(w => w.SP_RESULT_ID == record.M_ID).Select(t => new
            {


                CREATE_TIME = t.CREATE_TIME,
                OPERATOR = t.OPERATOR,
                CONTENT = t.CONTENT
            });
            // 预警

            var early = dynamic2.Where(w => w.OPERATE_TYPE == "3").Select(t => new
            {
                M_ID = t.M_ID,
                CREATE_TIME = t.CREATE_TIME,
                OPERATOR = t.OPERATOR,
                INFO_ACCEPT_TELPHONE = t.INFO_ACCEPT_TELPHONE,
                CONTENT = t.CONTENT
            });
            //反馈
            var back = feedback.Select(t => new
            {
                OPERATOR = t.OPERATOR,
                CREATE_TIME = t.CREATE_TIME,
                FEEDBACK_ATTACHMENT = t.FEEDBACK_ATTACHMENT,
                CONTENT = t.CONTENT,
                ATTACHMENTS = String.IsNullOrWhiteSpace(t.FEEDBACK_ATTACHMENT) ? new List<GGZY.Core.Models.UploadResData>() :
            Jd.SysAttachmentService.FindAttachments(t.FEEDBACK_ATTACHMENT)

            });
            var list = new List<object>();
            foreach (var t in early)
            {

                list.Add(new
                {
                    Label = "发出预警",
                    t.M_ID,
                    t.CREATE_TIME,
                    t.OPERATOR,
                    t.INFO_ACCEPT_TELPHONE,
                    t.CONTENT

                });
            }

            foreach (var t in back)
            {
                list.Add(new
                {
                    Label = "反馈情况",
                    t.OPERATOR,
                    t.CREATE_TIME,
                    t.FEEDBACK_ATTACHMENT,
                    t.CONTENT,
                    t.ATTACHMENTS
                });

            }


            r.SetSuccess(new
            {
                //监督点内容
                Sp = data,
                //监督点动态
                Dynamic = der,
                //预警反馈
                Feedback = list
            });
            return r;
        }
        /// <summary>
        /// 红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult SuperviseChange(Traffic_Light_Change_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(WARN_RESULT._.M_ID == model.M_ID);

            if (dbEntity != null)
            {
                using (var trans = GetDbSession().BeginTransaction())
                {
                    dbEntity.Attach();
                    dbEntity.RESULT_STATUS = model.RESULT_STATUS;
                    dbEntity.SP_TIME = DateTime.Now;
                    //dbEntity.SUPERVISE_OP_ID = JdUser?.ID?.ToString();
                    //dbEntity.OPERATOR = JdUser?.USERNAME;
                    trans.Update(dbEntity);
                    var logEntity = new WARN_RECORD
                    {
                        M_ID = Guid.NewGuid().ToString("N"),
                        SP_RESULT_ID = model.M_ID,
                        OPERATOR = JdUser?.USERNAME,
                        CREATE_TIME = DateTime.Now,
                        OPERATE_TYPE = "2",
                        REMARK = model.REMARK,
                        WARN_NUMBER = "",
                        INFO_ACCEPT_TELPHONE = "",
                        ISDELETE = 0,
                        INFO_ACCEPT_TELPHONE1 = ""

                    };
                    trans.Insert(logEntity);
                    trans.Commit();
                    r.SetSuccess();
                    //model.SUPERVISE_REMARK
                }
            }
            else
            {
                r.SetFail("未找到对应记录信息");
            }

            return r;
        }


        #endregion

        #region 招投标过程监督-预警处理模块

        public PageTableResult WarnProcess(Early_Model model, SearchCondition search)
        {

            var condition = new WhereClipBuilder();
            #region condition 条件拼接
            //招标项目编号
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            //招标项目名称
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(WARN_EXPRESSION._.CREATE_TIME <= search.EndTime);
            }
            //状态
            if (!string.IsNullOrWhiteSpace(model.STATUS))
            {
                condition.And(WARN_EXPRESSION._.CREATE_TIME == model.STATUS);
            }
            //处理状态
            if (!string.IsNullOrWhiteSpace(model.PROCESS_STATUS))
            {
                condition.And(WARN_RESULT._.OPERATE_STATUS == model.PROCESS_STATUS);
            }
            //预警是否发送
            if (!string.IsNullOrWhiteSpace(model.FEEDBACK))
            {
                // string p = "1";
                if (model.FEEDBACK == "1")
                    condition.And(WARN_RESULT._.OPERATE_STATUS.In("'2'", "'3'", "'4'", "'5'"));
                else
                {
                    condition.And(WARN_RESULT._.OPERATE_STATUS.In("'1'"));
                }



            }

            switch (model.TYPE)
            {
                case "1":

                    break;
                case "2":

                    condition.And(WARN_RESULT._.OPERATE_STATUS == "1");
                    break;
                case "3":

                    condition.And(WARN_RESULT._.OPERATE_STATUS == "2");
                    break;
                case "4":
                    condition.And(WARN_RESULT._.OPERATE_STATUS == "2");
                    condition.And(WARN_RECORD._.OPERATE_TYPE == "3");
                    condition.And(WARN_FEEDBACK._.M_ID == null);
                    condition.And(new Field("getworkdate(WARN_RECORD.CREATE_TIME,10)") < DateTime.Now);
                    break;
                case "5":
                    condition.And(WARN_RESULT._.OPERATE_STATUS == "1");
                    condition.And(new Field("getworkdate(WARN_EXPRESSION.CREATE_TIME,15)") < DateTime.Now);
                    break;

                default:

                    break;
            }
            //数据记录条数
            //SYS_DIC字典表
            var total = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())
                .LeftJoin<WARN_RESULT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
                .LeftJoin<WARN_RECORD>(WARN_RECORD._.SP_RESULT_ID == WARN_RESULT._.M_ID)
                .Count();
            #endregion
            var list = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                          .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
                          .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                          .LeftJoin<WARN_RECORD>(WARN_RECORD._.SP_RESULT_ID == WARN_RESULT._.M_ID)
                          //分页页码
                          .Page(search.PageSize, search.PageNo)
                          .Select(
                            //todo 前端状态
                            WARN_RESULT._.M_ID,
                            GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                            GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                            WARN_EXPRESSION._.SP_TYPE,
                            WARN_EXPRESSION._.SP_WAY,
                            WARN_RESULT._.RESULT_STATUS.As("SP_STATUS"),
                            WARN_EXPRESSION._.CREATE_TIME.As("SP_TIME"),
                            WARN_RESULT._.OPERATE_STATUS,
                            WARN_EXPRESSION._.SP_NAME,
                            WARN_EXPRESSION._.SP_POINT_RULE,
                            WARN_RECORD._.CREATE_TIME

                   ).ToList<EarlyWarnModel>();
            list.ForEach(c =>
           {
               if (c.OPERATE_STATUS == "3")
               {
                   c.Buttons.Add("详情");
                   c.Buttons.Add("查看反馈");
               }
               else
               {
                   c.Buttons.Add("详情");
                   c.Buttons.Add("纠正");
                   c.Buttons.Add("预警");
               }

               // return c;
           });
            //返回列表值
            var pageList = list.ToPageTableTResult(search, total);
            return pageList;


        }

        /// <summary>
        /// 统计预警处理列表
        /// </summary>
        public List<object> FeedBackCount()
        {
            // var condition = new WhereClipBuilder();
            //var only = Fw.WarnResultService.FromWhere()
            //   .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
            //   .Count();
            //待处理
            var pend = Fw.WarnResultService.Count(WARN_RESULT._.OPERATE_STATUS == "1");
            //反馈待查看
            var feedback = Fw.WarnResultService.Count(WARN_RESULT._.OPERATE_STATUS == "2");
            //超期未反馈
            var total = Fw.WarnResultService.FromWhere(WARN_RESULT._.OPERATE_STATUS == "2" && WARN_RECORD._.OPERATE_TYPE == "3" && WARN_FEEDBACK._.SP_RECORD_ID == null && new Field("getworkdate(WARN_RECORD.CREATE_TIME,10)") < DateTime.Now)
                .LeftJoin<WARN_RECORD>(WARN_RESULT._.M_ID == WARN_RECORD._.SP_RESULT_ID)
                .LeftJoin<WARN_FEEDBACK>(WARN_FEEDBACK._.SP_RECORD_ID == WARN_RECORD._.M_ID)
               .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
               .Count();
            //超期未处理
            var total2 = Fw.WarnResultService.FromWhere(WARN_RESULT._.OPERATE_STATUS == "1" && new Field("getworkdate(WARN_EXPRESSION.CREATE_TIME,15)") < DateTime.Now)
                .LeftJoin<WARN_RECORD>(WARN_RESULT._.M_ID == WARN_RECORD._.SP_RESULT_ID)
                .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
               .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
               .Count();

            return new List<object>
            {
                new{ label="全部",value="0",type=1},
                new{ label="待办预警",value=pend,type=2},
                new{ label="反馈待查看",value=feedback,type=3},
                new{ label="超期未反馈",value=total,type=4},
                new{ label="超期未处理",value=total2,type=5}
            };

        }

        /// <summary>
        /// 查看反馈
        /// </summary>
        /// <param name="m_id"></param>
        public GeneralResult SeeFeedback(string m_id)
        {
            GeneralResult r = new GeneralResult();
            var record = Fw.WarnResultService.FirstOrNull(WARN_RESULT._.M_ID == m_id);
            if (null == record)
            {
                r.SetFail("记录信息不存在");
                return r;
            }
            //预警信息
            var dynamic2 = Fw.WarnRecordService.FindList(WARN_RECORD._.SP_RESULT_ID == record.M_ID && WARN_RECORD._.OPERATE_TYPE == "3");

            //反馈
            var feedback = Fw.WarnFeedBackService.FindList(WARN_FEEDBACK._.SP_RECORD_ID.In(dynamic2.Select(e => e.M_ID).ToArray()));
            //预警实体输出
            var early = dynamic2.Where(w => w.OPERATE_TYPE == "3").Select(t => new
            {
                CREATE_TIME = t.CREATE_TIME,
                OPERATOR = t.OPERATOR,
                INFO_ACCEPT_TELPHONE = t.INFO_ACCEPT_TELPHONE,
                REMARK = t.REMARK
            });
            //反馈
            var back = feedback.Select(t => new
            {
                OPERATOR = t.OPERATOR,
                CREATE_TIME = t.CREATE_TIME,
                FEEDBACK_ATTACHMENT = t.FEEDBACK_ATTACHMENT,
                REMARK = t.REMARK,
                ATTACHMENTS = String.IsNullOrWhiteSpace(t.FEEDBACK_ATTACHMENT) ? new List<GGZY.Core.Models.UploadResData>() :
            Jd.SysAttachmentService.FindAttachments(t.FEEDBACK_ATTACHMENT)

            });
            var list = new List<object>();
            foreach (var t in early)
            {

                list.Add(new
                {
                    Label = "发出预警",
                    t.CREATE_TIME,
                    t.OPERATOR,
                    t.INFO_ACCEPT_TELPHONE,
                    t.REMARK
                });
            }
            foreach (var t in back)
            {
                list.Add(new
                {
                    Label = "反馈情况",
                    t.OPERATOR,
                    t.CREATE_TIME,
                    t.FEEDBACK_ATTACHMENT,
                    t.REMARK,
                    t.ATTACHMENTS
                });
            }
            r.SetSuccess(list);
            return r;
        }
        /// <summary>
        /// 已阅读
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Read(Point_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(WARN_RESULT._.M_ID == model.M_ID);

            if (dbEntity != null)
            {

                dbEntity.Attach();
                dbEntity.OPERATE_STATUS = "4";
                dbEntity.SP_TIME = DateTime.Now;
                Update(dbEntity);
                r.SetSuccess();
                //model.SUPERVISE_REMARK

            }
            else
            {
                r.SetFail("未找到对应的监督记录信息");
            }

            return r;
        }
        /// <summary>
        /// 预警处理-联系人
        /// </summary>
        public GeneralResult Contacts(string mId)
        {
            GeneralResult r = new GeneralResult();
            var feed = Fw.WarnResultService.FirstOrNull(WARN_RESULT._.M_ID == mId);
            if (null == feed)
            {
                r.SetFail("信息不存在");
                return r;
            }

            var bj = Jd.TenderProjectService.FromWhere()
                .LeftJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == GGZYJD.DbEntity.TENDER_PROJECT._.CONSTRUCTION_ID)
                .LeftJoin<GGZYJD.DbEntity.T_USER>(GGZYJD.DbEntity.T_USER._.ID == T_AFC_PROJECT._.U_ID)
                .Where(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == feed.TENDER_PROJECT_CODE)
                .Select(
                  GGZYJD.DbEntity.T_USER._.MANAGE_NAME.As("name"),
                  GGZYJD.DbEntity.T_USER._.TELPHONE.As("phone"),
                  GGZYJD.DbEntity.T_USER._.ID.As("id")
                    )
                .ToList<dynamic>();
            var dljg = Jd.TenderProjectService.FromWhere()
               .LeftJoin<GGZYJD.DbEntity.T_USER>(GGZYJD.DbEntity.T_USER._.ID == GGZYJD.DbEntity.TENDER_PROJECT._.M_CREATOR)
               .Where(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == feed.TENDER_PROJECT_CODE)
               .Select(
                 GGZYJD.DbEntity.T_USER._.MANAGE_NAME.As("name"),
                 GGZYJD.DbEntity.T_USER._.TELPHONE.As("phone"),
                 GGZYJD.DbEntity.T_USER._.ID.As("id")
                   )
               .ToList<dynamic>();
            var ba = Jd.TenderProjectService.FromWhere()
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID)
                .Where(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == feed.TENDER_PROJECT_CODE)
                .Select(

                  T_USER_DEPARTMENT._.DNAME.As("name"),
                  T_USER_DEPARTMENT._.PHONE.As("phone"),
                  T_USER_DEPARTMENT._.DEPID.As("id")

                    )
                .ToList<dynamic>();

            var list = new List<object>
            {
                new
                {
                    name = "报建人",
                    id = Guid.NewGuid().ToString("N"),
                    phone = "",
                    childList = bj
                },
                new
                {
                    name = "代理机构",
                    id = Guid.NewGuid().ToString("N"),
                    phone = "",
                    childList = dljg
                },
                new
                {
                    name = "备案部门",
                    id = Guid.NewGuid().ToString("N"),
                    phone = "",
                    childList = ba
                }
            };

            r.SetSuccess(list);
            return r;

        }

        /// <summary>
        /// 发送插入数据库
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult earlyWarnRecord(Template_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(WARN_RESULT._.M_ID == model.M_ID);

            if (dbEntity != null)
            {
                var templat = Fw.WarnTemplateService.FirstOrNull(WARN_TEMPLATE._.CONTENT_TYPE == "1" && WARN_TEMPLATE._.TEMPLATE_TYPE == "1")
                    .READ_ONLY.Replace("{TENDER_PROJECT_NAME}", model.TENDER_PROJECT_NAME).ToString();
                using (var trans = GetDbSession().BeginTransaction())
                {
                    // 增加自定义模板
                    var logEntity = new WARN_RECORD
                    {
                        M_ID = Guid.NewGuid().ToString("N"),
                        OPERATOR = JdUser?.MANAGE_NAME?.ToString(),
                        SP_RESULT_ID = model.M_ID,
                        INFO_ACCEPT_TELPHONE = model.INFO_ACCEPT_TELPHONE,
                        CREATE_TIME = DateTime.Now,
                        //预警内容
                        REMARK = model.CONTENT_EDIT,
                        OPERATE_TYPE = "3",
                        CONTENT = templat,

                    };
                    trans.Insert(logEntity);

                    trans.Commit();
                }

                r.SetSuccess();
            }
            else
            {
                r.SetFail("发送失败");
            }

            return r;

        }
        /// <summary>
        /// 发送短信模块
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trans"></param>
        public GeneralResult sendMsgYJ(Template_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = Fw.WarnResultService.FirstOrNull(WARN_RESULT._.M_ID == model.M_ID);

            if (dbEntity != null)
            {
                var templat = Fw.WarnTemplateService.FirstOrNull(WARN_TEMPLATE._.CONTENT_TYPE == "1" && WARN_TEMPLATE._.TEMPLATE_TYPE == "1")
                    .READ_ONLY.Replace("{TENDER_PROJECT_NAME}", model.TENDER_PROJECT_NAME).ToString();

                var smsSend = new T_SMS_SEND
                {
                    ID = 0,
                    MODULE_NAME = "预警短信模块",
                    OPER_BY = JdUser?.ID,
                    RETRY = 0,
                    STATUS = 0,
                    TEL_PHONE = model.INFO_ACCEPT_TELPHONE,
                    SMS_CONTENT = templat,
                    YJ_SEND_TM = DateTime.Now,
                };
                GGZY.Services.Base.DbContext.Jd.Insert(smsSend);
                r.SetSuccess();
            }
            else
            {
                r.SetFail("发送失败");
            }

            return r;

        }


        #endregion


        #endregion

        #region 首页项目监督预警统计
        /// <summary>
        ///  首页项目监督预警统计-预警计数接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> ProjectAlarmCount(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//默认归属地
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');
                    if (model.REGION_CODE.Length < 6)
                    {
                        condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                        if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                        {
                            condition.And(WARN_RESULT._.REGION_CODE != "350128");//平潭综合试验区 350100 福州市
                        }
                    }
                    else
                    {
                        condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
                    }
                }
            }
            if (model.BeginTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
            }
            //RESULT_STATUS
            //处理状态OPERATE_STATUS 1:待处理 2：已发出预警信息 3： 已反馈  4：反馈已读  5：已办结 
            var con = condition.ToWhereClip();
            var result = Fw.WarnResultService.FromWhere(con);
            var total = result.Where(p => p.RESULT_STATUS == "2" || p.RESULT_STATUS == "3").Select(WARN_RESULT._.TENDER_PROJECT_CODE).Distinct().Count();//异常监督点数 红灯+黄灯
            var sended = result.GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE, WARN_RESULT._.OPERATE_STATUS).Where(p => p.OPERATE_STATUS == "2").Count();//发出预警数
            var responsed = result.GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE, WARN_RESULT._.OPERATE_STATUS).Where(p => p.OPERATE_STATUS == "3").Count();//已反馈
            var overted = sended - responsed;//未反馈
            return new List<LabelValueModel<int>>
            {
                new LabelValueModel<int>{Label = "项目异常总数",Value = total},
                new LabelValueModel<int>{Label = "发出预警数",Value = sended},
                new LabelValueModel<int>{Label = "预警已反馈数",Value = responsed},
                new LabelValueModel<int>{Label = "预警未反馈数",Value = overted},
            };
        }
        /// <summary>
        ///  首页项目监督预警统计-根据类型统计接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Object> ProjectGroupByType(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//默认归属地
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');
                    if (model.REGION_CODE.Length < 6)
                    {
                        condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                        if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                        {
                            condition.And(WARN_RESULT._.REGION_CODE != "350128");//平潭综合试验区 350100 福州市
                        }
                    }
                    else
                    {
                        condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
                    }
                }
            }
            if (model.BeginTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
            }

            var result = FromWhere(condition.ToWhereClip())
                 .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && WARN_RESULT._.TENDER_PROJECT_TYPE == SYS_DIC._.VALUE)
                 .GroupBy(SYS_DIC._.TEXT)
                 .Select(
                    SYS_DIC._.TEXT.As("name"),
                    WARN_RESULT._.TENDER_PROJECT_CODE.Distinct().Count().As("value")
                 ).ToList<Object>();
            return result;
        }
        /// <summary>
        /// 首页项目监督预警统计-归属地统计
        /// </summary>
        /// <param name="jdUserDepartId"></param>
        /// <returns></returns>
        public object ProjectGroupByRegion(TAfcProjectStatisticsModel model)
        {
            var areaname = new List<string>();
            var value = new List<string>();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//350100
            var condition = new WhereClipBuilder();
            var condition1 = new WhereClipBuilder();
            condition.And(WARN_RESULT._.RESULT_STATUS >= 2);//查询红灯和黄灯
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');//默认查询当前这个账号的归属地
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))//有查询条件的时候
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');//补6位
                }
                if (model.BeginTime != null)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
                }
                if (model.EndTime != null)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
                }
                bool isCity = false; //判断当前查询的归属地是否省市
                var mod = Jd.SysAreaQuanguoService;
                var ppCode = mod.FromWhere(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == pcode).First().PCODE;
                if (ppCode == pcode)
                {
                    isCity = true;
                }
                else
                {
                    var temp = mod.FromWhere(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == ppCode).ToFirstDefault();
                    if (temp.PCODE == temp.AREACODE)
                    {
                        isCity = true;
                    }
                }

                if (isCity)//省市 归属地编码0结尾
                {
                    if (pcode == "350000" || pcode == "350100")
                    {
                        condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE.NotIn("350128", "350000"));//平潭综合试验区 350100 福建省
                    }
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.PCODE == pcode);
                }
                else //归属地是区县
                {
                    condition1.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == pcode);
                }
                var mo = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip()).ToList();
                //关联查询 查询有数据的
                var s = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                    .InnerJoin<WARN_RESULT>(WARN_RESULT._.REGION_CODE == GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE && condition.ToWhereClip())
                    .Select(
                    GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("Label"),
                    WARN_RESULT._.TENDER_PROJECT_CODE.As("NAME")
                    ).Distinct().ToList<LabelValueModel>();
                var r = s.GroupBy(p => new { p.Label }).Select(p => new LabelValueModel
                {
                    Label = p.Key.Label,
                    Value = p.Count().ToString()
                }).ToList();
                var Labels = r.Select(c => c.Label).Distinct().ToList();
                var rs = mo.Where(p => !Labels.Contains(p.AREANAME)).Select(p => new LabelValueModel
                {
                    Label = p.AREANAME,
                    Value = "0",
                });
                r.AddRange(rs);
                areaname = r.Select(c => c.Label).ToList();
                value = r.Select(c => c.Value).ToList();
            }
            return new
            {
                areaname,
                value
            };
        }
    }

    #endregion
}

