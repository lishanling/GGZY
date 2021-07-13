using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.DZBH.ParamModel;
using GGZYFW.DbEntity;

namespace GGZY.Services.DZBH
{
    public class ExChangeService : BaseService
    {
        public GeneralResult ReceiveGuaranteeResult(string validation, string data)
        {
            var r = new GeneralResult();
            try
            {
                BhReceiveService<BH_GUARANTEE_RESULT> brs = new BhReceiveService<BH_GUARANTEE_RESULT>(validation, data);
                brs.Run();
                BH_GUARANTEE_RESULT bgr = brs.instance;
                //处理附件
                /*if (!string.IsNullOrEmpty(bgr.GUARANTEE_PDF_URL) && !string.IsNullOrEmpty(bgr.SECRET))
                {
                    bgr.GUARANTEE_PDF_URL = DownLoadFileAndDecrpty(bgr.GUARANTEE_PDF_URL, bgr.SECRET, bgr.GUARANTEE_PDF_MD5);
                }

                if (!string.IsNullOrEmpty(bgr.GUARANTEE_URL) && !string.IsNullOrEmpty(bgr.SECRET))
                {
                    bgr.GUARANTEE_URL = DownLoadFileAndDecrpty(bgr.GUARANTEE_URL, bgr.SECRET, bgr.GUARANTEE_MD5);
                }

                if (!string.IsNullOrEmpty(bgr.WARRANTY_URL) && !string.IsNullOrEmpty(bgr.SECRET))
                {
                    bgr.WARRANTY_URL = DownLoadFileAndDecrpty(bgr.WARRANTY_URL, bgr.SECRET, bgr.WARRANTY_MD5);
                }

                if (!string.IsNullOrEmpty(bgr.WARRANTY_PDF_URL) && !string.IsNullOrEmpty(bgr.SECRET))
                {
                    bgr.WARRANTY_PDF_URL =
                        DownLoadFileAndDecrpty(bgr.WARRANTY_PDF_URL, bgr.SECRET, bgr.WARRANTY_PDF_MD5);
                }*/
                //保存数据
                var exitModel = DbContext.Fw.From<BH_GUARANTEE_RESULT>()
                    .Where(BH_GUARANTEE_RESULT._.ORDER_ID == bgr.ORDER_ID).ToFirst();
                bgr.ID = 0;
                bgr.CREATE_TIME = DateTime.Now;
                if (exitModel != null)
                {
                    bgr.ID = exitModel.ID;
                    DbContext.Fw.Update(bgr);
                }
                else
                {
                    DbContext.Fw.Insert(bgr);
                }
                //修改订单的状态
                DbContext.Fw.Update<BH_SEND_APPLICATION_FORM>(BH_SEND_APPLICATION_FORM._.STATUS, 10,
                    BH_SEND_APPLICATION_FORM._.ORDER_ID == bgr.ORDER_ID);
                r.SetSuccess();
            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据验证不通过", e);
                    msg = "数据验证不通过：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }
                r.SetFail(msg);
            }

            return r;
        }

        public GeneralResult ChangeStatus(string validation, string data)
        {
            var r = new GeneralResult();
            try
            {
                BhReceiveService<ChangeStatusModel> brs = new BhReceiveService<ChangeStatusModel>(validation, data);
                brs.Run();
                ChangeStatusModel obj = brs.instance;
                Dictionary<Field, object> updateDic = new Dictionary<Field, object>();
                updateDic.Add(BH_SEND_APPLICATION_FORM._.STATUS, obj.STATUS);
                //判断数据是否存在
                ThrowHelper.ThrowIfTure(!DbContext.Fw.Exists<BH_SEND_APPLICATION_FORM>(BH_SEND_APPLICATION_FORM._.ORDER_ID == obj.ORDER_ID), $"[{obj.ORDER_ID}]数据不存在");
                if (!string.IsNullOrEmpty(obj.REMARK))
                {
                    updateDic.Add(BH_SEND_APPLICATION_FORM._.STATUS_REMARK, obj.REMARK);
                }

                DbContext.Fw.Update<BH_SEND_APPLICATION_FORM>(updateDic, BH_SEND_APPLICATION_FORM._.ORDER_ID == obj.ORDER_ID);
                r.SetSuccess();
            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据验证不通过", e);
                    msg = "数据验证不通过：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }
                r.SetFail(msg);
            }

            return r;
        }

        public GeneralResult ReceiveApplicationForm(string validation, string data)
        {
            var r = new GeneralResult();
            try
            {
                BhReceiveService<BH_SEND_APPLICATION_FORM> brs = new BhReceiveService<BH_SEND_APPLICATION_FORM>(validation, data);
                brs.Run();
                BH_SEND_APPLICATION_FORM obj = brs.instance;
                //处理附件
                //todo
                //保存数据
                //DZBHService DZBH = new DZBHService();
                obj.CREATE_TIME = DateTime.Now;
                obj.USER_ID = -9;
                //obj.ORDER_ID = DZBH.CreateOrderId(obj.CITY_CODE);
                obj.M_DATA_KEY = brs.DataKey;
                obj.M_ID = 0;
                obj.CREATE_TIME = DateTime.Now;
                var exitModel = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID == obj.ORDER_ID).ToFirst();
                if (exitModel != null)
                {
                    obj.M_ID = exitModel.M_ID;
                    DbContext.Fw.Update(obj);
                }
                else
                {
                    DbContext.Fw.Insert(obj);
                }

                r.SetSuccess();
            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据验证不通过", e);
                    msg = "数据验证不通过：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }
                r.SetFail(msg);
            }

            return r;
        }
        public GeneralResult ReceiveClaim(string validation, string data)
        {
            var r = new GeneralResult();
            try
            {
                BhReceiveService<BH_RECEIVE_CLAIM> brs = new BhReceiveService<BH_RECEIVE_CLAIM>(validation, data);
                brs.Run();
                BH_RECEIVE_CLAIM obj = brs.instance;
                obj.CREATE_TIME = DateTime.Now;
                obj.USER_ID = -9;
                //obj.ORDER_ID = DZBH.CreateOrderId(obj.CITY_CODE);
                obj.M_DATA_KEY = brs.DataKey;
                obj.M_ID = 0;
                var exitModel = DbContext.Fw.From<BH_RECEIVE_CLAIM>()
                    .Where(BH_RECEIVE_CLAIM._.ORDER_ID == obj.ORDER_ID).ToFirst();
                if (exitModel != null)
                {
                    obj.M_ID = exitModel.M_ID;
                    DbContext.Fw.Update(obj);
                }
                else
                {
                    DbContext.Fw.Insert(obj);
                }

                r.SetSuccess();
            }
            catch (Exception e)
            {
                string msg = "";
                if (e is MyException)
                {
                    Logger.Error("数据验证不通过", e);
                    msg = "数据验证不通过：" + e.Message;
                }
                else
                {
                    Logger.Error("系统错误", e);
                    msg = "系统错误：" + e.Message;
                }
                r.SetFail(msg);
            }

            return r;
        }

        private string DownLoadFileAndDecrpty(string downloadUrl, string xinfeng, string md5)
        {
            string savePath = AppDomain.CurrentDomain.BaseDirectory + "/File/SIGN/GUARANTEE/DOWNLOAD/";
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            string saveUrl = savePath + Guid.NewGuid().ToString("N") + ".pdf";
            var wc = new WebClient();
            wc.DownloadFile(downloadUrl, saveUrl);

            string outPath = AppDomain.CurrentDomain.BaseDirectory + "/File/SIGN/GUARANTEE/DECRYPT/";
            if (!Directory.Exists(outPath))
            {
                Directory.CreateDirectory(outPath);
            }

            string outUrl = outPath + Guid.NewGuid().ToString("N") + ".pdf";
            //解密
            string key = TokenHelper.DecryptFile(saveUrl, outUrl, xinfeng);
            string fileMd5 = Encrypt.GetFileMD5(outUrl).ToUpper();
            ThrowHelper.ThrowIfTure(fileMd5 != md5, $"解密后的文件MD5[{fileMd5}]与数据中的MD5[{md5}]不一致");
            return outUrl.TrimStart(AppDomain.CurrentDomain.BaseDirectory.ToCharArray());
        }

        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }
    }
}
