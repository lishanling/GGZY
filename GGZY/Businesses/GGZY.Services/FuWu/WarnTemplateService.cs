using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.FuWu
{
    public partial class WarnTemplateService
    {
        /// <summary>
        /// 增加自定义模板
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult templateAdd(Template_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = Fw.WarnResultService.FirstOrNull(WARN_RESULT._.M_ID == model.M_ID);
            if (dbEntity != null)
            {
                //增加自定义模板
                var logEntity = new WARN_TEMPLATE
                {
                    M_ID = Guid.NewGuid().ToString("N"),
                    FOUNDER_ID = JdUser?.ID?.ToString(),
                    FOUNDER_UNIT_ID = JdUser?.DEPARTID,
                    CREATE_TIME = DateTime.Now,
                    TEMPLATE_TYPE = "2",
                    CONTENT_TYPE = "2",
                    CONTENT_EDIT = model.CONTENT_EDIT,
                    READ_ONLY= "招标项目编号{TENDER_PROJECT_CODE},招标项目名称{TENDER_PROJECT_NAME}"
                };
                Insert(logEntity);
                r.SetSuccess();
            }       
            else
            {
                r.SetFail("未找到对应的信息");
            }

            return r;

        }
        /// <summary>
        /// 修改模板
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult templateUpdate(Template_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(WARN_TEMPLATE._.M_ID == model.M_ID);

            if (dbEntity != null&& dbEntity.TEMPLATE_TYPE=="2")
            {
              
                    dbEntity.Attach();
                    dbEntity.CONTENT_EDIT = model.CONTENT_EDIT;
                    Update(dbEntity);   
                    r.SetSuccess();
                }
            
            else
            {
                r.SetFail("未找到对应的监督记录信息");
            }

            return r;

        }
        /// <summary>
        /// 删除模板
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult templateDelete(Template_Model model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(WARN_TEMPLATE._.M_ID == model.M_ID);

            if (dbEntity != null&& dbEntity.TEMPLATE_TYPE=="2")
            {
           
                    Delete(dbEntity);
                    r.SetSuccess();    
            }
            else
            {
                r.SetFail("未找到对应的监督记录信息");
            }

            return r;

        }
        /// <summary>
        /// 查看模板
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult templateSee(Template_Model model, SearchCondition search)
        {

            var condition = new WhereClipBuilder();
             
            condition.And(WARN_TEMPLATE._.CONTENT_TYPE == model.CONTENT_TYPE);
          
            #region condition 条件拼接
           

            switch (model.CONTENT_TYPE)
            {
                case "1":
                    break;
                case "2":
                    condition.And(WARN_TEMPLATE._.TEMPLATE_TYPE == "1" || (WARN_TEMPLATE._.TEMPLATE_TYPE == 2&& WARN_TEMPLATE._.FOUNDER_UNIT_ID == JdUser.DEPARTID));
                    break;
              

                default:

                    break;
            }


            #endregion

            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("\\{[^\\{]*?\\}");
            var ba = Jd.TenderProjectService.FromWhere()
               .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID)
               .Where(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == model.TENDER_PROJECT_CODE)
               .Select(
                 T_USER_DEPARTMENT._.PHONE
                   )
               .ToScalar<dynamic>();


            var count = FromWhere(condition.ToWhereClip()).Count();
            //列表返回值
            var list = Fw.WarnTemplateService.FromWhere(condition.ToWhereClip())
                 .Page(search.PageSize, search.PageNo)
                      .Select(
                       //todo 前端状态
                       WARN_TEMPLATE._.M_ID,
                       WARN_TEMPLATE._.CONTENT_TYPE,
                       WARN_TEMPLATE._.TEMPLATE_TYPE,
                       WARN_TEMPLATE._.READ_ONLY,
                       WARN_TEMPLATE._.CONTENT_EDIT
               ).ToList()
               .Select(t => new
               {
                   M_ID = t.M_ID,
                   CONTENT_TYPE = t.CONTENT_TYPE,
                   TEMPLATE_TYPE = t.TEMPLATE_TYPE,
                   READ_ONLY = t.READ_ONLY == null ? "" : reg.Replace(t.READ_ONLY, "******"),
                   CONTENT_EDIT = t.CONTENT_EDIT == null ? "" : reg.Replace(t.CONTENT_EDIT, "******"),
                   //可看
                  READONLY_CONTENT = t.READ_ONLY == null ? "" : t.READ_ONLY.Replace("{TENDER_PROJECT_CODE}", model.TENDER_PROJECT_CODE).Replace("{TENDER_PROJECT_NAME}", model.TENDER_PROJECT_NAME).Replace("{SP_NMAE}", model.SP_NAME).Replace("{SP_POINT_RULE}", model.SP_POINT_RULE).Replace("{APPROVAL_PHONE}", ba)
                  

               }).ToList<dynamic>().ToPageTableResult(search, count);
            //返回列表值
           
            
            return list;


        }




    }
}
