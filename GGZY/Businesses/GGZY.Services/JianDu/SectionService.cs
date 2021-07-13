using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SectionService : BaseServiceT<SECTION>
    {
        /// <summary>
        /// 生成 标段（包）编号-序号
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目编号</param>
        /// <returns></returns>
        public int Generate_BID_CODE_SEQ(string TENDER_PROJECT_CODE)
        {
            string sqlStr = string.Format("select NVL(max(to_number(substr(BID_SECTION_CODE,23))),0)+1 as MAXSEQ from SECTION t where BID_SECTION_CODE like '{0}___'", TENDER_PROJECT_CODE);
            var SEQNO = FromSql(sqlStr).ToScalar<int>();
            return SEQNO;
        }
        /// <summary>
        /// 显示招标项目下的标段包列表
        /// </summary>
        /// <param name="model">TENDER_PROJECT_CODE必传</param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult List(SECTION model, SearchCondition search)
        {
            if(null == model || String.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                throw new Exception("获取标段包列表失败：招标项目编号不能为空");
            }
            var condition = SECTION._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE;
            var count =FromWhere(condition).Count();
            var list = FromWhere(condition)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "18" && SYS_DIC._.VALUE == SECTION._.CONTROL_PRICE_UNIT)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "4" && SYS_DIC._.VALUE == SECTION._.CONTROL_PRICE_CURRENCY)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "5001" && SYS_DIC._.VALUE == SECTION._.TENDER_PROJECT_CLASSIFY_CODE)
                .OrderBy(SECTION._.CREATE_TIME.Desc)
                 .Page(search.PageSize, search.PageNo)
                .Select(
                SECTION._.M_ID,
                SECTION._.TENDER_PROJECT_CODE,
                SECTION._.BID_SECTION_CODE,
                SECTION._.BID_SECTION_NAME,
                SECTION._.TENDER_PROJECT_CLASSIFY_CODE,
                 SECTION._.BEGIN_DATE,
                 SECTION._.LIMITE_TIME,
                 SECTION._.CONTRACT_RECKON_PRICE,
                 SYS_DIC._.TEXT.As("CONTROL_PRICE_UNIT"),
                 new Field("TEXT","SYS_DIC2").As("CONTROL_PRICE_CURRENCY"),
                 new Field("TEXT", "SYS_DIC3").As("TENDER_PROJECT_CLASSIFY")
             ).ToList<dynamic>().ToPageTableResult(search, count);
            return list;
        }
        /// <summary>
        /// 标段包更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Save(SECTION model)
        {
            var result = new GeneralResult();
            var oldEntity = FirstOrNull(SECTION._.M_ID == model.M_ID);
            if (null == oldEntity)
            {
                result.SetFail("标段信息不存在或已删除");
                return result;
            }
            var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE );
            if(null == tender_project)
            {
                result.SetFail("招标项目信息不存在或已删除");
                return result;
            }

            var now = ServicesFactory.GGZYJD.CommonService.GetDBDateTime();

            //防止客户端非法赋值
            var section = new SECTION(model);
            section.AttachAll();
            section.M_ID = model.M_ID;
            section.TENDER_PROJECT_CODE = tender_project.TENDER_PROJECT_CODE;
            section.BID_SECTION_CODE = oldEntity.BID_SECTION_CODE;
            section.UNIFIED_DEAL_CODE = tender_project.UNIFIED_DEAL_CODE;
            section.PLATFORM_CODE = tender_project.PLATFORM_CODE;
            section.PUB_SERVICE_PLAT_CODE = tender_project.PUB_SERVICE_PLAT_CODE;
            
            //TODO:多个标段，标段包分类代码需要重新判断
            tender_project.Attach();
            tender_project.RTYPE = Jd.TenderProjectService.GetRType(tender_project.TENDER_PROJECT_TYPE, section.TENDER_PROJECT_CLASSIFY_CODE);

            var db = GetDbSession();
            using(var tran = db.BeginTransaction())
            {
                try
                {
                    tran.Update<SECTION>(section);
                    tran.Update<TENDER_PROJECT>(tender_project);
                    result.SetSuccess();
                    tran.Commit();
                    return result;
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    result.SetFail("更新失败:"+ex.Message);
                    Logger.Error("标段包更新失败:" + ex.Message + ",\r\n数据:" + Newtonsoft.Json.JsonConvert.SerializeObject(section), ex);
                    return result;
                }
            }
        }

    }
}