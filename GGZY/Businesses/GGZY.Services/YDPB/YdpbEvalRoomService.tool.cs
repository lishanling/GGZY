using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalRoomService : BaseServiceT<YDPB_EVAL_ROOM>
    {
        protected string FileServer = ConfigurationManager.AppSettings["FileServer"];

        public GeneralResult PageList(decimal? state, decimal? enabled, SearchCondition search)
        {
            var result = new GeneralResult();

            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_ROOM._.IS_DELETE ==0 && YDPB_EVAL_ROOM._.AREA_CODE == FwUser.AREACODE);
            if(state.HasValue)
            {
                condition.And(YDPB_EVAL_ROOM._.STATE == state);
            }
            if (enabled.HasValue)
            {
                condition.And(YDPB_EVAL_ROOM._.ENABLED == enabled);
            }

            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_EVAL_ROOM._.ID.Desc).Select(t => new
            {
                t.ID,
                t.EVAL_ROOM_NAME,
                t.ENABLED,
                t.CAMERA_COUNT,
                t.STATE,
                t.SEATS_COUNT,
                t.AVAILABLE_SEATS_COUNT,
                t.DATA_TIMESTAMP
            }).ToBootstrapTableList<dynamic>(count);

            result.SetSuccess(pageList);
            return result;
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPkDetail(decimal? ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_ROOM._.ID == ID);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null || dbModel.IS_DELETE.Value == 1)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                var dic = dbModel.ToDictionary();

                var con = new WhereClipBuilder();
                con.And(YDPB_EVAL_ROOM_CAMERA._.EVAL_ROOM_ID == ID && YDPB_EVAL_ROOM_CAMERA._.IS_DELETE == 0);
                var cameras = ServicesFactory.GGZYJD.YdpbEvalRoomCameraService.FindList(con);
                dic.Add("CAMERA", cameras);

                var conSeat = new WhereClipBuilder();
                conSeat.And(YDPB_EVAL_ROOM_SEAT._.FID == ID && YDPB_EVAL_ROOM_SEAT._.IS_DELETE == 0);
                var seats = ServicesFactory.GGZYJD.YdpbEvalRoomSeatService.FindList(conSeat).OrderBy(od=>od.SEAT_NUMBER).ToList();
                dic.Add("SEAT", seats);

                var conFile = new WhereClipBuilder();
                conFile.And(YDPB_FILE._.FID == ID && YDPB_FILE._.IS_DELETE == 0);
                var files = ServicesFactory.GGZYJD.YdpbFileService.FindList(conFile);
                //dic.Add("SEAT", seats);

                dic.Add("FILE", files.Select(t => new {
                    file_id = t.FILE_ID,
                    id = t.ID,
                    name = t.NAME,
                    url =  t.URL
                }));
                result.SetSuccess(dic);
            }
            return result;
        }

        /// <summary>
        /// 查看 返回实体模型
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public YDPB_EVAL_ROOM ViewByPkModel(decimal? ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_ROOM._.ID == ID);
            var dbModel = FirstOrNull(condition);
            return dbModel;
        }

        /// 查看 返回实体模型
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public YDPB_EVAL_ROOM ViewByNameModel(string areacode,string name)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_ROOM._.AREA_CODE ==areacode && YDPB_EVAL_ROOM._.EVAL_ROOM_NAME == name);
            var dbModel = FirstOrNull(condition);
            return dbModel;
        }

        public GeneralResult I_Seat_Check(string areaCode,int expertCount,DateTime? dtStart, DateTime? dtEnd)
        {
            var result = new GeneralResult();
            if(expertCount <= 0)
            {
                result.SetFail("预约评标席位数量错误");
                return result;
            }
            if (!dtStart.HasValue || !dtEnd.HasValue)
            {
                result.SetFail("评标开始/结束时间不能为空");
                return result;
            }
            if (dtStart.Value.Date != dtEnd.Value.Date)
            {
                result.SetFail("评标开始/结束时间不能跨天");
                return result;
            }
            var dt = FromWhere(YDPB_EVAL_ROOM._.IS_DELETE == 0 && YDPB_EVAL_ROOM._.ENABLED == 1 && YDPB_EVAL_ROOM._.STATE == 1 && YDPB_EVAL_ROOM._.AREA_CODE == areaCode)
                    .InnerJoin<YDPB_EVAL_ROOM_SEAT>(YDPB_EVAL_ROOM_SEAT._.IS_DELETE == 0 && YDPB_EVAL_ROOM_SEAT._.STATE == 1 && YDPB_EVAL_ROOM_SEAT._.FID == YDPB_EVAL_ROOM._.ID)
                    .LeftJoin<V_YDPB_ROOM_SEAT>(V_YDPB_ROOM_SEAT._.ROOMID == YDPB_EVAL_ROOM._.ID && V_YDPB_ROOM_SEAT._.SEATID == YDPB_EVAL_ROOM_SEAT._.ID
                    && V_YDPB_ROOM_SEAT._.EVAL_DATE == dtStart.Value.Date && !(V_YDPB_ROOM_SEAT._.START_TIME < dtEnd || V_YDPB_ROOM_SEAT._.END_TIME > dtStart))
                    .Select(YDPB_EVAL_ROOM._.ID, YDPB_EVAL_ROOM._.EVAL_ROOM_NAME, YDPB_EVAL_ROOM_SEAT._.SEAT_NUMBER, V_YDPB_ROOM_SEAT._.SEATID)
                    .ToDataTable();
           
            var dics = dt.Rows.Cast<DataRow>().Select(dr => {
                var dict = new Dictionary<string, object>();
                dict.Add("ID", dr["ID"]);
                dict.Add("EVAL_ROOM_NAME", dr["EVAL_ROOM_NAME"]);
                dict.Add("SEAT_NUMBER", dr["SEAT_NUMBER"]);
                dict.Add("SEATID", DBNull.Value == dr["SEATID"] ? 1 : 0);
                return dict;
            });
            var data = dics.GroupBy(g => new { EVAL_ROOM_NAME = g["EVAL_ROOM_NAME"].ToString(), ID = g["ID"] }).Select(t => new {
                EVAL_ROOM_ID = t.Key.ID,
                EVAL_ROOM_NAME = t.Key.EVAL_ROOM_NAME,
                IS_MEET = t.Where(w=>Convert.ToInt32(w["SEATID"]) ==1).Count() >=expertCount?1:0,
                FREE_SEAT_COUNT = t.Where(w => Convert.ToInt32(w["SEATID"]) == 1).Count()
            });

            var center = Jd.TradeCenterService.ViewByAreaCode(areaCode);
            if(null == center)
            {
                result.SetFail("交易中心信息不存在");
                return result;
            }

            var returnData = new
            {
                AREA_CODE = center.AREA_CODE,
                CENTER_NAME = center.UNIT_NAME,
                IS_MEET = data.Max(m => m.IS_MEET),
                FREE_SEAT_COUNT = data.Max(m => m.FREE_SEAT_COUNT)
            };
            result.SetSuccess(returnData);
            return result;
        }

        /// <summary>
        /// 获取可用的评标席位
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetAvailableSeat(DateTime? dtStart, DateTime? dtEnd, string ORIGINAL_SERIES_NUMBER)
        {
            var result = new GeneralResult();
            if (!dtStart.HasValue || !dtEnd.HasValue)
            {
                result.SetFail("评标开始/结束时间不能为空");
                return result;
            }
            if (dtStart.Value.Date != dtEnd.Value.Date)
            {
                result.SetFail("评标开始/结束时间不能跨天");
                return result;
            }
            var apply_id = 0;

            if (!String.IsNullOrEmpty(ORIGINAL_SERIES_NUMBER))
            {
                var apply = ServicesFactory.GGZYJD.YdpbEvalApplyService.FirstOrNull(YDPB_EVAL_APPLY._.SERIES_NUMBER == ORIGINAL_SERIES_NUMBER && YDPB_EVAL_APPLY._.IS_DELETE == 0);
                if (null != apply)
                {
                    apply_id = (int)apply.ID;
                }
            }
            string areaCode = FwUser.AREACODE;
            var dt = FromWhere(YDPB_EVAL_ROOM._.IS_DELETE == 0 && YDPB_EVAL_ROOM._.ENABLED == 1 && YDPB_EVAL_ROOM._.STATE == 1 && YDPB_EVAL_ROOM._.AREA_CODE == areaCode)
                    .InnerJoin<YDPB_EVAL_ROOM_SEAT>(YDPB_EVAL_ROOM_SEAT._.IS_DELETE == 0 && YDPB_EVAL_ROOM_SEAT._.STATE == 1 && YDPB_EVAL_ROOM_SEAT._.FID == YDPB_EVAL_ROOM._.ID)
                    .LeftJoin<V_YDPB_ROOM_SEAT>(V_YDPB_ROOM_SEAT._.APPLY_ID != apply_id && V_YDPB_ROOM_SEAT._.ROOMID == YDPB_EVAL_ROOM._.ID && V_YDPB_ROOM_SEAT._.SEATID == YDPB_EVAL_ROOM_SEAT._.ID
                    &&  V_YDPB_ROOM_SEAT._.EVAL_DATE == dtStart.Value.Date && !(V_YDPB_ROOM_SEAT._.START_TIME < dtEnd || V_YDPB_ROOM_SEAT._.END_TIME > dtStart))
                    .Select(YDPB_EVAL_ROOM._.ID, YDPB_EVAL_ROOM._.EVAL_ROOM_NAME, YDPB_EVAL_ROOM_SEAT._.SEAT_NUMBER, V_YDPB_ROOM_SEAT._.SEATID)
                    .ToDataTable();
            //var dics = new List<Dictionary<string, object>>();
            //Dictionary<string, string> dic = dt.Rows.Cast<DataRow>().ToDictionary(x => x[0].ToString(), x => x[1].ToString());
            var dics = dt.Rows.Cast<DataRow>().Select(dr => {
                var dict = new Dictionary<string, object>();
                dict.Add("ID", dr["ID"]);
                dict.Add("EVAL_ROOM_NAME", dr["EVAL_ROOM_NAME"]);
                dict.Add("SEAT_NUMBER", dr["SEAT_NUMBER"]);
                dict.Add("SEATID", DBNull.Value == dr["SEATID"] ? 1 : 0);
                return dict;
            });
            var data = dics.GroupBy(g => new { EVAL_ROOM_NAME = g["EVAL_ROOM_NAME"].ToString(), ID = g["ID"] }).Select(t => new {
                EVAL_ROOM_ID = t.Key.ID,
                EVAL_ROOM_NAME = t.Key.EVAL_ROOM_NAME,
                SEAT = t.OrderBy(od=>od["SEAT_NUMBER"]).Select(x => new {
                    SEAT_NUMBER = x["SEAT_NUMBER"],
                    STATE = t.Min(m=>m["SEATID"])
                }).Distinct()
            }); ;

            result.SetSuccess(data);
            return result;

        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Edit(int id, YDPB_EVAL_ROOM model, List<YDPB_EVAL_ROOM_CAMERA> cameras, List<YDPB_EVAL_ROOM_SEAT> seats, List<YDPB_FILE> files)
        {
            var result = new GeneralResult();


            var entity = ViewByPkModel(id);
            if (null == entity)
            {
                result.SetFail(OBJECT_NOT_EXIST);
                return result;
            }

            if (entity.AREA_CODE != FwUser.AREACODE)
            {
                result.SetFail("授权认证失败");
                return result;
            }
            if (!seats.Any())
            {
                result.SetFail("评标席位不能为空");
                return result;
            }
            var checkCondition = new WhereClipBuilder();
            checkCondition.And(YDPB_EVAL_ROOM._.IS_DELETE == 0 && YDPB_EVAL_ROOM._.EVAL_ROOM_NAME == model.EVAL_ROOM_NAME
                && YDPB_EVAL_ROOM._.AREA_CODE == FwUser.AREACODE && YDPB_EVAL_ROOM._.ID !=model.ID);
            var checkEntity = ServicesFactory.GGZYJD.YdpbEvalRoomService.FirstOrNull(checkCondition.ToWhereClip());
            if (checkEntity !=null)
            {
                result.SetFail("评标室名称重复");
                return result;
            }

            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                entity.Attach();
                entity.EVAL_ROOM_NAME = model.EVAL_ROOM_NAME;
                entity.EVAL_ROOM_ADDR = model.EVAL_ROOM_ADDR;
                entity.EVAL_METHOD = model.EVAL_METHOD;
                entity.SEATS_COUNT = seats.Count();
                entity.CAMERA_COUNT = cameras.Count;
                entity.ENABLED = model.ENABLED;
                entity.DATA_TIMESTAMP = DateTime.Now;
                entity.REMARK = model.REMARK;
                entity.AVAILABLE_SEATS_COUNT = seats.Where(seat => !(!seat.CAMERA_STATE.HasValue ||
                 !seat.PC_STATE.HasValue ||
                 !seat.SPEEKER_STATE.HasValue ||
                 !seat.NETWORK_STATE.HasValue ||
                 !seat.MIC_STATE.HasValue ||
                 seat.CAMERA_STATE == 0 ||
                 seat.PC_STATE == 0 ||
                 seat.SPEEKER_STATE == 0 ||
                 seat.MIC_STATE == 0 ||
                 seat.NETWORK_STATE == 0)).Count();
                entity.STATE = model.STATE = (cameras.Any(a => a.STATE == 0 || !a.STATE.HasValue) ||
                seats.Any(a =>
                !a.CAMERA_STATE.HasValue ||
                !a.PC_STATE.HasValue ||
                !a.SPEEKER_STATE.HasValue ||
                !a.NETWORK_STATE.HasValue ||
                !a.MIC_STATE.HasValue ||
                a.CAMERA_STATE == 0 ||
                a.PC_STATE == 0 ||
                a.SPEEKER_STATE == 0 ||
                a.MIC_STATE == 0 ||
                a.NETWORK_STATE == 0)) ? 0 : 1;


                cameras.ForEach(camera =>
                {
                    camera.EVAL_ROOM_ID = id;
                    if (camera.ID == 0)
                    {
                        camera.ID = db.Insert<YDPB_EVAL_ROOM_CAMERA>(tran, camera);
                        return;
                    }
                    var viewResultCamera = ServicesFactory.GGZYJD.YdpbEvalRoomCameraService.ViewByPk(camera.ID);
                    if (viewResultCamera.Success && viewResultCamera.Data is YDPB_EVAL_ROOM_CAMERA entityCamera)
                    {
                        entityCamera.Attach();
                        entityCamera.CAMERA_NAME = camera.CAMERA_NAME;
                        entityCamera.DATA_TIMESTAMP = DateTime.Now;
                        entityCamera.REMARK = camera.REMARK;
                        entityCamera.URL = camera.URL;
                        entityCamera.STATE = camera.STATE;
                        db.Update<YDPB_EVAL_ROOM_CAMERA>(tran, entityCamera);
                    }
                });

                seats.ForEach(seat =>
                {
                    seat.STATE = (!seat.CAMERA_STATE.HasValue ||
                    !seat.PC_STATE.HasValue ||
                    !seat.SPEEKER_STATE.HasValue ||
                    !seat.NETWORK_STATE.HasValue ||
                    !seat.MIC_STATE.HasValue ||
                    seat.CAMERA_STATE == 0 ||
                    seat.PC_STATE == 0 ||
                    seat.SPEEKER_STATE == 0 ||
                    seat.MIC_STATE == 0 ||
                    seat.NETWORK_STATE == 0) ? 0 : 1;
                    seat.FID = model.ID;
                    if (seat.ID == 0)
                    {
                        seat.ID = db.Insert<YDPB_EVAL_ROOM_SEAT>(tran, seat);
                        return;
                    }
                    var viewResultCamera = ServicesFactory.GGZYJD.YdpbEvalRoomSeatService.ViewByPk(seat.ID);
                    if (viewResultCamera.Success && viewResultCamera.Data is YDPB_EVAL_ROOM_SEAT entitySeat)
                    {
                        entitySeat.Attach();
                        entitySeat.CAMERA_STATE = seat.CAMERA_STATE;
                        entitySeat.DATA_TIMESTAMP = DateTime.Now;
                        entitySeat.MIC_STATE = seat.MIC_STATE;
                        entitySeat.NETWORK_STATE = seat.NETWORK_STATE;
                        entitySeat.PC_STATE = seat.PC_STATE;
                        entitySeat.REMARK = seat.REMARK;
                        entitySeat.SEAT_NUMBER = seat.SEAT_NUMBER;
                        entitySeat.SPEEKER_STATE = seat.SPEEKER_STATE;
                        entitySeat.STATE = seat.STATE;
                        db.Update<YDPB_EVAL_ROOM_SEAT>(tran, entitySeat);
                    }
                });

                files.ForEach(file =>
                {
                    if (file.FILE_ID == 0)
                    {
                        file.FID = id;
                        file.F_TABLE = "YDPB_EVAL_ROOM";
                        file.FILE_ID = db.Insert<YDPB_FILE>(tran, file);
                        return;
                    }
                });



                db.Update<YDPB_EVAL_ROOM>(tran, entity);
                var deleteCameraSql = "UPDATE YDPB_EVAL_ROOM_CAMERA set IS_DELETE =1 where EVAL_ROOM_ID=" + entity.ID + " AND  ID NOT IN(" + String.Join(",", cameras.Select(t => t.ID)) + ")";
                db.FromSql(deleteCameraSql).SetDbTransaction(tran).ExecuteNonQuery();

                var deleteSeatSql = "UPDATE YDPB_EVAL_ROOM_SEAT set IS_DELETE =1 where FID=" + entity.ID + " AND  ID NOT IN(" + String.Join(",", seats.Select(t => t.ID)) + ")";
                db.FromSql(deleteSeatSql).SetDbTransaction(tran).ExecuteNonQuery();

                var deleteFileSql = "UPDATE YDPB_FILE set IS_DELETE =1 where FID=" + entity.ID;
                if (files.Any())
                {
                    deleteFileSql += " AND  FILE_ID NOT IN(" + String.Join(",", files.Select(t => t.FILE_ID)) + ")";
                }
                db.FromSql(deleteFileSql).SetDbTransaction(tran).ExecuteNonQuery();

                tran.Commit();

                var dic = entity.ToDictionary();
                dic.Add("CAMERA", cameras);
                dic.Add("SEAT", seats);
                dic.Add("FILE", files.Select(t => new
                {
                    file_id = t.FILE_ID,
                    id = t.ID,
                    name = t.NAME,
                    url = String.Join("", FileServer, t.URL)
                }));
                result.SetSuccess(dic);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(YDPB_EVAL_ROOM model, List<YDPB_EVAL_ROOM_CAMERA> cameras, List<YDPB_EVAL_ROOM_SEAT> seats, List<YDPB_FILE> files)
        {
            var result = new GeneralResult();
            if(! seats.Any())
            {
                result.SetFail("评标席位不能为空");
                return result;
            }

            var checkCondition = new WhereClipBuilder();
            checkCondition.And(YDPB_EVAL_ROOM._.IS_DELETE ==0 && YDPB_EVAL_ROOM._.EVAL_ROOM_NAME == model.EVAL_ROOM_NAME 
                && YDPB_EVAL_ROOM._.AREA_CODE == FwUser.AREACODE);
            var checkEntity = ServicesFactory.GGZYJD.YdpbEvalRoomService.FirstOrNull(checkCondition.ToWhereClip());
            if(checkEntity !=null)
            {
                result.SetFail("评标室名称重复");
                return result;
            }
            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                model.STATE = (cameras.Any(a => a.STATE == 0 || !a.STATE.HasValue) ||
                    seats.Any(a =>
                    !a.CAMERA_STATE.HasValue ||
                    !a.PC_STATE.HasValue ||
                    !a.SPEEKER_STATE.HasValue ||
                    !a.NETWORK_STATE.HasValue ||
                    !a.MIC_STATE.HasValue ||
                    a.CAMERA_STATE == 0 ||
                    a.PC_STATE == 0 ||
                    a.SPEEKER_STATE == 0 ||
                    a.MIC_STATE == 0 ||
                    a.NETWORK_STATE == 0)) ? 0 : 1;
                model.AREA_CODE = FwUser.AREACODE;
                var centerInfo = GlobalDataService.Instance.Centers;
                if (centerInfo.ContainsKey(FwUser.AREACODE))
                {
                    model.CENTER_NAME = centerInfo[FwUser.AREACODE];
                }
                model.CAMERA_COUNT = cameras.Count;
                model.SEATS_COUNT = seats.Count;
                model.CREATOR = Identity.LoginName;
                model.CREATOR_ID = FwUser.ID;
                model.AVAILABLE_SEATS_COUNT = seats.Where(seat => !(!seat.CAMERA_STATE.HasValue ||
                    !seat.PC_STATE.HasValue ||
                    !seat.SPEEKER_STATE.HasValue ||
                    !seat.NETWORK_STATE.HasValue ||
                    !seat.MIC_STATE.HasValue ||
                    seat.CAMERA_STATE == 0 ||
                    seat.PC_STATE == 0 ||
                    seat.SPEEKER_STATE == 0 ||
                    seat.MIC_STATE == 0 ||
                    seat.NETWORK_STATE == 0)).Count();
                model.ID = db.Insert<YDPB_EVAL_ROOM>(tran, model);

                cameras.ForEach(camera => {
                    camera.EVAL_ROOM_ID = model.ID;
                    camera.ID = db.Insert<YDPB_EVAL_ROOM_CAMERA>(tran, camera);
                });


                seats.ForEach(seat => {
                    seat.STATE = (!seat.CAMERA_STATE.HasValue ||
                    !seat.PC_STATE.HasValue ||
                    !seat.SPEEKER_STATE.HasValue ||
                    !seat.NETWORK_STATE.HasValue ||
                    !seat.MIC_STATE.HasValue ||
                    seat.CAMERA_STATE == 0 ||
                    seat.PC_STATE == 0 ||
                    seat.SPEEKER_STATE == 0 ||
                    seat.MIC_STATE == 0 ||
                    seat.NETWORK_STATE == 0) ? 0 : 1;
                    seat.FID = model.ID;
                    seat.CREATOR = Identity.LoginName;
                    seat.CREATOR_ID = FwUser.ID;
                    seat.ID = db.Insert<YDPB_EVAL_ROOM_SEAT>(tran, seat);
                });

                files.ForEach(file => {
                    file.FID = model.ID;
                    file.F_TABLE = "YDPB_EVAL_ROOM";
                    file.CREATOR = Identity.LoginName;
                    file.CREATOR_ID = FwUser.ID;
                    file.FILE_ID = db.Insert<YDPB_FILE>(tran, file);
                });
                tran.Commit();

                var dic = model.ToDictionary();
                dic.Add("CAMERA", cameras);
                dic.Add("SEAT", seats);
                dic.Add("FILE", files.Select(t => new {
                    file_id = t.FILE_ID,
                    id = t.ID,
                    name = t.NAME,
                    url = String.Join("", FileServer, t.URL)
                }));
                result.SetSuccess(dic);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public GeneralResult Delete(int id)
        {
            GeneralResult result = new GeneralResult();
            var viewResult = ViewByPk(id);

            if (!(viewResult.Success && viewResult.Data is YDPB_EVAL_ROOM))
            {
                result.SetFail("信息不存在或已被删除");
                return result;
            }
            YDPB_EVAL_ROOM entity = (YDPB_EVAL_ROOM)viewResult.Data;
            if (entity.AREA_CODE != FwUser.AREACODE)
            {
                result.SetFail("授权认证失败");
                return result;
            }
            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                var sql = "UPDATE YDPB_EVAL_ROOM SET IS_DELETE=1 WHERE ID =" + id;
                db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();

                var deleteCameraSql = "UPDATE YDPB_EVAL_ROOM_CAMERA set IS_DELETE =1 where EVAL_ROOM_ID=" + id;
                db.FromSql(deleteCameraSql).SetDbTransaction(tran).ExecuteNonQuery();

                var deleteSeatSql = "UPDATE YDPB_EVAL_ROOM_SEAT set IS_DELETE =1 where FID=" + id;
                db.FromSql(deleteSeatSql).SetDbTransaction(tran).ExecuteNonQuery();
                tran.Commit();
                result.SetSuccess(id);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        private GeneralResult DeleteData(List<int> ids)
        {
            GeneralResult result = new GeneralResult();
            if (!ids.Any())
            {
                result.SetFail("要删除的数据不能为空");
                return result;
            }
            var db = GetDbSession();
            var tran = db.BeginTransaction();
            var id = string.Join(",", ids);
            try
            {
                var sql = "UPDATE YDPB_EVAL_ROOM SET IS_DELETE=1 WHERE ID  in(" + id + ")";
                db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();

                var deleteCameraSql = "UPDATE YDPB_EVAL_ROOM_CAMERA set IS_DELETE =1 where EVAL_ROOM_ID in (" + id + ")";
                db.FromSql(deleteCameraSql).SetDbTransaction(tran).ExecuteNonQuery();

                var deleteSeatSql = "UPDATE YDPB_EVAL_ROOM_SEAT set IS_DELETE =1 where FID in (" + id + ")";
                db.FromSql(deleteSeatSql).SetDbTransaction(tran).ExecuteNonQuery();
                tran.Commit();
                result.SetSuccess(id);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }
    }
}
