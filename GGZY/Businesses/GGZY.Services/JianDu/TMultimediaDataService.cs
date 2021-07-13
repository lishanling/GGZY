using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TMultimediaDataService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fwTenderProjectCode">服务平台招标项目编号</param>
        /// <returns></returns>
        public GeneralResult GetList(string fwTenderProjectCode)
        {
            var r = new GeneralResult();
            string sql = $@"SELECT M.ID,
           M.BID_SECTION_CODE,
           S.BID_SECTION_NAME,
           p.tender_project_name,
           plat.system_name,
           TO_CHAR(K.BID_OPEN_TIME, 'yyyy-mm-dd hh24:mi:ss') BID_OPEN_TIME,
           M.URL
      FROM T_MULTIMEDIA_DATA M
           INNER JOIN （SELECT * FROM SECTION@DZJYPT WHERE TENDER_PROJECT_CODE='{fwTenderProjectCode}') S ON M.BID_SECTION_CODE = S.BID_SECTION_CODE  
           INNER JOIN （SELECT * FROM V_KBSJ_XZJD@DZJYPT WHERE TENDER_PROJECT_CODE='{fwTenderProjectCode}') K ON M.TENDER_PROJECT_CODE = K.TENDER_PROJECT_CODE
           inner join tender_project@DZJYPT p on p.tender_project_code = m.tender_project_code
           inner join t_user_tradeplatform@dzjypt plat on plat.platform_code = p.platform_code
  AND  M.BID_SECTION_CODE IN (SELECT * FROM TABLE(SPLIT(K.BID_SECTION_CODES,';')))
     WHERE M.TENDER_PROJECT_CODE ='{fwTenderProjectCode}' ";
            var list = FromSql(sql).ToDataTable();
            r.SetSuccess(list);
            return r;
        }

        public GeneralResult GetUrlParam(string id)
        {
            var r = new GeneralResult();
            string sql = $@"select Z.APP_SECRET
                            from T_MULTIMEDIA_DATA M
                            LEFT JOIN ZY_JIEKOU_USER Z ON M.DATA_SOURCE = Z.APP_ID WHERE M.ID='{id}'";
            var dt = FromSql(sql).ToDataTable();
            string secret = dt.Rows[0]["APP_SECRET"].ToString();
            string TIMESTAMP = GetTimeStamp();
            string SIGN = CreateToken("11" + TIMESTAMP, secret);
            r.SetSuccess(new
            {
                TIMESTAMP,
                SIGN
            });
            return r;
        }
        private string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        private string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }
        /// <summary>
        /// 监督服务·现场视频监督·电子评标视频
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult GetVideoList(MvTjAllCreateXzjdModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.BID_OPEN_TIME.IsNotNull());
            //用户可查看用户所在行政区划和用户自行上传的数据、省级都可查看全省的数据
            var jdUserAreaCode = JdUser?.RootAreaCode;
            var rootJdUserAreaCode = jdUserAreaCode?.TrimEnd('0');
            #region 用户可查看用户所在行政区划和用户自行上传的数据、省级都可查看全省的数据
            if (!string.IsNullOrWhiteSpace(jdUserAreaCode))
            {
                if (jdUserAreaCode == "350100")
                {
                    var subQuery = Jd.TJiekouUserService
                        .FromWhere(T_JIEKOU_USER._.AREACODE.Contain(jdUserAreaCode) && T_JIEKOU_USER._.AREACODE != "350128")
                        .Select(T_JIEKOU_USER._.PLATFORM_CODE);
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE.Contain(jdUserAreaCode) && DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE != "350128" || DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PLATFORM_CODE.SubQueryIn(subQuery));
                }
                else if (jdUserAreaCode == "350000")
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.AREACODE.BeginWith("35"));
                }
                else if (jdUserAreaCode.Contains("3503") && jdUserAreaCode.Length == 6)
                {//莆田的特殊处理
                    var subQuery = Jd.TJiekouUserService.FromWhere(T_JIEKOU_USER._.AREACODE.Contain(rootJdUserAreaCode)).Select(T_JIEKOU_USER._.PLATFORM_CODE);
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE.Contain("3503") || DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PLATFORM_CODE.SubQueryIn(subQuery));
                }
                else
                {
                    var subQuery = Jd.TJiekouUserService.FromWhere(T_JIEKOU_USER._.AREACODE.Contain(rootJdUserAreaCode)).Select(T_JIEKOU_USER._.PLATFORM_CODE);
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE.Contain(jdUserAreaCode) || DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PLATFORM_CODE.SubQueryIn(subQuery));
                }
            }

            #endregion

            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME.Contain(search.KeyWord)||DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.Contain(search.KeyWord));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME.Contain(model.PROJECT_NAME) );
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.Contain(model.PROJECT_CODE));
            }

            if (search.BeginTime.HasValue )
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.BID_OPEN_TIME>= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.BID_OPEN_TIME <= search.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE==model.PROJECT_TYPE);
            }
            if (model.PROJECT_CATEGORY.HasValue)
            {//KYQ 矿业权
                if (model.PROJECT_CATEGORY == 4 || model.PROJECT_CATEGORY == 5)
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY.In(4,5));
                }
                else
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY == model.PROJECT_CATEGORY);
                }
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                if (model.AREACODE == "350000" || model.AREACODE == "350128")//省本级和平潭实验区
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE==model.AREACODE);
                }
                else if (model.AREACODE == "350100")//福州市不包含平潭实验区
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE .BeginWith("3501")&&DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE!="350128");
                }
                else
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE.BeginWith(model.AREACODE.Substring(0,Math.Min(4,model.AREACODE.Length))));
                }
            }
            else
            {
                condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.REGION_CODE.BeginWith("350"));
            }
            //获取标段包中包含对应类型的招标项目
            if (!string.IsNullOrWhiteSpace(search.Type))
            {
                if (search.Type == "A99")
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.SubQueryIn(Jd.SectionService.FromWhere<DBLINK_DZJYPT_SECTION>(DBLINK_DZJYPT_SECTION._.TENDER_PROJECT_CLASSIFY_CODE.Substring(0,3).NotIn("A03", "A04", "A05", "A08", "A10")).Select(DBLINK_DZJYPT_SECTION._.TENDER_PROJECT_CODE)));
                   
                }
                else
                {
                    condition.And(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.SubQueryIn(Jd.SectionService.FromWhere<DBLINK_DZJYPT_SECTION>(DBLINK_DZJYPT_SECTION._.TENDER_PROJECT_CLASSIFY_CODE.BeginWith(search.Type)).Select(DBLINK_DZJYPT_SECTION._.TENDER_PROJECT_CODE)));
                }
            }

            var query = FromWhere(condition.ToWhereClip())
                .InnerJoin<DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD>(
                    DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE == T_MULTIMEDIA_DATA._.TENDER_PROJECT_CODE);
            var count = query.Count();
            if (count > 0)
            {
                var list = query
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" &&
                                       SYS_DIC._.VALUE == DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" &&
                                       SYS_DIC._.VALUE == DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY)
                    .Select(
                        SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                        new Field("TEXT","SYS_DIC2").As("PROJECT_CATEGORY_TEXT"),
                        new Field("VALUE1", "SYS_DIC2").As("PROJECT_CATEGORY_KIND"),
                        DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.All).Distinct()
                    .OrderBy(DBLINK_DZJYPT_MV_TJ_ALLCREATE_XZJD._.BID_OPEN_TIME.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<MvTjAllCreateXzjdModel>();
                var fwTenderProjectCodes = list.Select(c => c.PROJECT_CODE).ToArray();
                var jdTenderProject = Jd.TenderProjectService.GetJdTenderProjectsFwTpCodes(fwTenderProjectCodes);
                var plist = list.ToPageTableResult(search, count, c =>
                {
                    c.JD_TENDER_PROJECT_CODE = jdTenderProject
                        .FirstOrDefault(o => o.TENDER_PROJECT_CODE_OLD1 == c.PROJECT_CODE)?.TENDER_PROJECT_CODE;
                    return c;
                });
                return plist;
            }
            return search.ToPageTableResult();
        }
    }
}