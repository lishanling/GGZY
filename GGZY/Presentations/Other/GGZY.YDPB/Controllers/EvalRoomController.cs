using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Framework.Infrastructure.Filters;
using GGZY.Framework.Models;
using GGZY.Services.Base;
using GGZY.YDPB.Models;
using GGZYJD.DbEntity;
using Newtonsoft.Json.Linq;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Controllers
{
    [ApiAuthorizationFilter(Roles = "tradingCenter")]
    public class EvalRoomController:BaseController
    {
        /// <summary>
        /// 查看评标场地信息
        /// </summary>
        /// <param name="id">场地id</param>
        /// <returns></returns>
        [HttpGet]
        public GGZY.Core.Models.GeneralResult Get(decimal id)
        {
            return Jd.YdpbEvalRoomService.ViewByPkDetail(id);
        }
        /// <summary>
        /// 获取所有评标场地列表
        /// </summary>
        /// <param name="state"></param>
        /// <param name="enabled"></param>
        /// <returns></returns>
        [Route("api/EvalRoom/List")]
        [HttpGet]
        public GGZY.Core.Models.GeneralResult List([FromUri]decimal? state = null,[FromUri]decimal? enabled=null)
        {
            SearchCondition search = new SearchCondition();
            search.PageSize = 50;
            return Jd.YdpbEvalRoomService.PageList(state,enabled, search);
        }
        /// <summary>
        /// 添加场地
        /// </summary>
        /// <param name="dic">场地信息</param>
        /// <returns></returns>
        [HttpPost]
        public GGZY.Core.Models.GeneralResult Post([FromBody]dynamic dic)
        {
            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<YDPB_EVAL_ROOM>(dic.ToString());
            var cameras = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_ROOM_CAMERA>>(dic["CAMERA"].ToString());
            var seats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_ROOM_SEAT>>(dic["SEAT"].ToString());
            List<Dictionary<string, string>> filesDic = new List<Dictionary<string, string>>();
            if (dic["FILE"] != null && !String.IsNullOrEmpty(dic["FILE"].ToString()))
            {
                filesDic =Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(dic["FILE"].ToString());
            }
            List<YDPB_FILE> files = new List<YDPB_FILE>();
            filesDic.ForEach(file => {
                var fileEntity = new YDPB_FILE();
                fileEntity.ID = file["id"].ToString();
                fileEntity.URL = file["url"].ToString();
                fileEntity.NAME = file["name"].ToString();
                fileEntity.MD5 = file["md5"].ToString();
                fileEntity.CATEGORY = "场地信息表";
                files.Add(fileEntity);
            });
            
            return Jd.YdpbEvalRoomService.Add(entity,cameras,seats, files);
        }
        [HttpPut]
        public GGZY.Core.Models.GeneralResult Put(int id, [FromBody]dynamic dic)
        {
            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<YDPB_EVAL_ROOM>(dic.ToString());
            var cameras = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_ROOM_CAMERA>>(dic["CAMERA"].ToString());
            var seats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_ROOM_SEAT>>(dic["SEAT"].ToString());

            List<Dictionary<string, string>> filesDic = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(dic["FILE"].ToString());
            List<YDPB_FILE> files = new List<YDPB_FILE>();
            filesDic.ForEach(file => {
                var fileEntity = new YDPB_FILE();
                decimal fileid = 0;
                if (file.ContainsKey("file_id"))
                {
                    decimal.TryParse(file["file_id"].ToString(), out fileid);
                }
                fileEntity.FILE_ID = fileid;
                fileEntity.ID = file["id"].ToString();
                fileEntity.URL = file["url"].ToString();
                fileEntity.NAME = file["name"].ToString();
                if (file.ContainsKey("md5"))
                {
                    fileEntity.MD5 = file["md5"].ToString();
                }
                fileEntity.CATEGORY = "场地信息表";
                files.Add(fileEntity);
            });

            return Jd.YdpbEvalRoomService.Edit(id,entity, cameras, seats, files);
        }
        [HttpDelete]
        public GGZY.Core.Models.GeneralResult Delete(int id)
        {
            return Jd.YdpbEvalRoomService.Delete(id);
        }
        
        
        [HttpGet]
        public GeneralResult GetAvailableSeat([FromUri]DateTime? dt1,[FromUri]DateTime? dt2,[FromUri]string ORIGINAL_SERIES_NUMBER="")
        {
            return Jd.YdpbEvalRoomService.GetAvailableSeat(dt1, dt2, ORIGINAL_SERIES_NUMBER);
        }
    }
}