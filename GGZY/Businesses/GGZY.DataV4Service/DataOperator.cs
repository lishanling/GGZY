using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using Dos.ORM;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Model;
using GGZY.DataV4Service.Validators.Title;

namespace GGZY.DataV4Service
{
    public class DataOperator
    {
        /// <summary>
        /// 对应不同的数据版本，
        /// 当前版本：V3
        /// </summary>
        private string _version;

        public DataOperator(string version)
        {
            _version = version;
        }

        public string GetSystemNo(string validation)
        {
            var dtValid = XmlHelper.ToDataSetByString(validation).Tables[0];
            var systemNo = dtValid.GetStringValue("SYSTEM_NO");
            ThrowHelper.ThrowIfTure(string.IsNullOrEmpty(systemNo), "SYSTEM_NO获取失败");
            return systemNo;
        }

        /// <summary>
        /// 身份验证
        /// </summary>
        /// <param name="validation"></param>
        public string ValidateToken(string validation)
        {
            var dtValid = XmlHelper.ToDataSetByString(validation).Tables[0];

            var TOKEN = dtValid.GetStringValue("TOKEN");
            var SYSTEM_NO = dtValid.GetStringValue("SYSTEM_NO");

            var expireSystemNos = new List<string> { "2020", "2021", "2002", "9999", "9998", "2030" };
            ThrowHelper.ThrowIfTure(expireSystemNos.Contains(SYSTEM_NO), "[SYSTEM_NO]已过期");

            string sql = "select * from T_JIEKOU_USER where system_no='" + SYSTEM_NO.ToClearSql() + "'";
            DataTable dt = DAO.GGFW.GetDataSet(sql).Tables[0];
            ThrowHelper.ThrowIfTure(dt.Rows.Count <= 0, "SYSTEM_NO无效");

            DataRow drUser = dt.Rows[0];
            string SECRET_KEY = (drUser["SECRET_KEY"] ?? "").ToString();
            string msg = DESEncrypt.Decode(TOKEN, SECRET_KEY);

            string time = msg.Substring(4, 14);

            string year = time.Substring(0, 4);
            string month = time.Substring(4, 2);
            string day = time.Substring(6, 2);
            string hour = time.Substring(8, 2);
            string min = time.Substring(10, 2);
            string sec = time.Substring(12, 2);
            DateTime dataDt = DateTime.Parse(year + "-" + month + "-" + day + " " + hour + ":" + min + ":" + sec);
            ThrowHelper.ThrowIfTure(Math.Abs((DateTime.Now - dataDt).TotalHours) > 12, "TOKEN过期");

            return SYSTEM_NO;
        }

        /// <summary>
        /// 获取xml文件中包含的三个节点
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<DataTable> GetXmlContent(string data)
        {
            var ds = XmlHelper.ToDataSetByString(data);
            var dtTitle = ds.Tables["title"];
            ThrowHelper.ThrowIfTure(dtTitle == null, "XML中缺少title节点");

            var dtContext = ds.Tables["context"];
            var DATA_TYPE = dtTitle.GetStringValue("DATA_TYPE");
            ThrowHelper.ThrowIfTure(!"3".Equals(DATA_TYPE) && dtContext == null, "XML中缺少context节点");

            DataTable dtFile = null;
            if (ds.Tables.Contains("SOURCE"))
            {
                dtFile = ds.Tables["SOURCE"];
            }
            return new List<DataTable> { dtTitle, dtContext, dtFile };
        }

        /// <summary>
        /// 验证Title节点
        /// </summary>
        public void ValidateTitle(DataTable dtTitle, DataTable dtContext, string systemNo)
        {
            new DataNoValidator().Validate(dtTitle, dtContext);
            var dataNo = dtTitle.GetStringValue(Constant.DATA_NO);
            var dataconfig = DataConfig.GetDataConfig(dataNo, _version);
            new DataEnValidator { DataConfig = dataconfig }.Validate(dtTitle, dtContext);
            new DataCnValidator().Validate(dtTitle, dtContext);
            new DataTypeValidator().Validate(dtTitle, dtContext);
            new DataKeyValidator(systemNo) { DataConfig = dataconfig }.Validate(dtTitle, dtContext);
            new CaKeyValidator().Validate(dtTitle, dtContext);
            new RouteWayValidator().Validate(dtTitle, dtContext);
            new Context5FieldValidator(systemNo).Validate(dtTitle, dtContext);

        }

        /// <summary>
        /// 验证Context节点
        /// </summary>
        public void ValidateContext(DataTable dtTitle, DataTable dtContext)
        {
            var dataNo = dtTitle.GetStringValue("DATA_NO");
            var dataType = dtTitle.GetStringValue("DATA_TYPE");
            var dataConfig = DataConfig.GetDataConfig(dataNo, _version);
            dataConfig.Validate(dtTitle, dtContext);
            //验证数据是否重复，现在只有通用的有重复属性
            if ("1".Equals(dataType))
            {
                dataConfig.ValidateRepeat(dtContext);
            }
            //再拿通用的验证一下，通用的里有值域
            if (dataConfig.IsZXSJ && (!string.IsNullOrEmpty(dataConfig.GgfwDataNo)))
            {
                var ggfwDataConfig = DataConfig.GetDataConfig(dataConfig.GgfwDataNo, _version);
                ggfwDataConfig.ValidateDoMainOnly(dtTitle, dtContext);
                //再拿通用的验证重复，只有通用的几个关键表才验证重复
                if ("1".Equals(dataType))
                {
                    ggfwDataConfig.ValidateRepeat(dtContext);
                }
            }
        }

        /// <summary>
        /// 验证附件
        /// </summary>
        /// <param name="dtFile"></param>
        /// <param name="systemNo"></param>
        public void ValidateFile(DataTable dtFile, string systemNo)
        {
            //验证附件是否存在
            if (dtFile != null && dtFile.Rows.Count > 0)
            {
                ThrowHelper.ThrowIfTure(!dtFile.Columns.Contains("FILE_EN_NAME"), "缺少附件的英文名称");

                bool containDelete = dtFile.Columns.Contains("IS_DELETE");

                //验证附件的中文、英文名称
                for (int i = 0; i < dtFile.Rows.Count; i++)
                {
                    var fileEnName = dtFile.Rows[i]["FILE_EN_NAME"].ToString();
                    string sql = string.Format(@"select text,value from sys_dic where type='90' and value='{0}'"
                        , fileEnName.ToClearSql());
                    DataTable dic = DAO.GGFW.GetDataSet(sql).Tables[0];
                    ThrowHelper.ThrowIfTure(dic.Rows.Count < 1, $"[{fileEnName}]附件的英文名称有误");

                    if (containDelete && "1".Equals(dtFile.Rows[i]["IS_DELETE"].ToString()))
                    {

                    }
                    else
                    {
                        //验证文件夹中文件是否存在
                        ThrowHelper.ThrowIfTure(!dtFile.Columns.Contains("BINARY_CONTENT"),
                            $"[{fileEnName}]缺少[BINARY_CONTENT]");
                        var filePath = GetFtpFile(dtFile.Rows[i]["BINARY_CONTENT"].ToString(), systemNo);
                        ThrowHelper.ThrowIfTure(!File.Exists(filePath), $"找不到附件{dtFile.Rows[i]["BINARY_CONTENT"]}");

                    }
                }

            }
        }

        /// <summary>
        /// 保存数据到数据库中
        /// </summary>
        /// <param name="dtTitle"></param>
        /// <param name="dtContext"></param>
        /// <param name="dtFile"></param>
        /// <param name="systemNo"></param>
        public void SaveData(DataTable dtTitle, DataTable dtContext, DataTable dtFile, string systemNo)
        {

            var dataNo = dtTitle.GetStringValue("DATA_NO");
            var dataConfig = DataConfig.GetDataConfig(dataNo, _version);
            //var dbTrans = dataConfig.Dao.BeginTransaction();
            DataConfig dataConfigGgfw = null;
            if (dataConfig.IsSaveGGFW())
            {
                dataConfigGgfw = dataConfig.GgfwDataConfig;
                //var ggfwDbTrans = dataConfigGgfw.Dao.BeginTransaction();
            }
            try
            {
                var fileDict = SaveFiles(dtFile, dataConfig.TableName, systemNo,
                    dtTitle.GetStringValue(Constant.DATA_KEY), dataConfig.Dao);
                dataConfig.SaveData_Param(dtTitle, dtContext, fileDict, _version, dataConfig.TableName, systemNo, dataConfig.Dao);
                if (!dataConfig.IsZXSJ)
                {
                    dataConfig.ChangeT_UPLOAD(dtTitle.GetStringValue(Constant.DATA_KEY), dtTitle.GetStringValue(Constant.DATA_TYPE));
                }

                if (dataConfig.IsSaveGGFW())
                {
                    fileDict = SaveFiles(dtFile, dataConfigGgfw.TableName, systemNo,
                        dtTitle.GetStringValue(Constant.DATA_KEY), dataConfigGgfw.Dao);
                    dataConfigGgfw.SaveData_Param(dtTitle, dtContext, fileDict, _version, dataConfigGgfw.TableName,
                        systemNo, dataConfigGgfw.Dao);
                }
                MoveFiles(dtFile, systemNo, dtTitle.GetStringValue(Constant.DATA_KEY));

                //dataConfig.Dao.CommitTransaction();
                if (dataConfig.IsSaveGGFW())
                {
                    //dataConfigGgfw.Dao.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                //dataConfig.Dao.RollBackTransaction();
                if (dataConfig.IsSaveGGFW())
                {
                    //dataConfigGgfw.Dao.RollBackTransaction();
                }
                throw ex;
            }
        }


        /// <summary>
        /// 将附件信息添加到数据库, 并返回附件ID,  多个附件使用,分割
        /// </summary>
        private Dictionary<string, string> SaveFiles(DataTable dtFile, string tableName, string systemNo, string dataKey, DAO dao)
        {
            var dict = new Dictionary<string, string>();

            if (dtFile != null && dtFile.Rows.Count > 0)
            {
                bool containDelete = dtFile.Columns.Contains("IS_DELETE");
                for (int i = 0; i < dtFile.Rows.Count; i++)
                {
                    DataRow dr = dtFile.Rows[i];
                    var fileEnName = dr["FILE_EN_NAME"].ToString();
                    if (containDelete && "1".Equals(dr["IS_DELETE"].ToString()))
                    {
                        dict["M_ATT_" + fileEnName] = "";
                    }
                    else
                    {
                        T_ATTACHMENT mm = new T_ATTACHMENT();
                        mm.SYSTEM_NO = systemNo;
                        mm.TB_NAME = tableName;
                        mm.ATTACHMENT_SET_CODE = (dr["FILE_EN_NAME"] ?? "").ToString().Trim();     //附件关联数据集标识符
                        mm.ATTACHMENT_NAME = (dr["FILE_NAME"] ?? "").ToString().Trim();      //附件名称
                        mm.ATTACHMENT_FILE_NAME = GetSaveFtpFileV((dr["BINARY_CONTENT"] ?? "").ToString().Trim(), systemNo, dataKey);        //附件文件名
                        mm.ATTACHMENT_TYPE = Path.GetExtension(mm.ATTACHMENT_FILE_NAME).Trim('.');          //附件类型
                        mm.CREATE_TIME = DateTime.Now;
                        mm.MD5 = GetMD5HashFromFile(GetFtpFile((dr["BINARY_CONTENT"] ?? "").ToString(), systemNo));
                        int newid = dao.AddAttacment(mm);

                        switch (mm.ATTACHMENT_SET_CODE)
                        {
                            case "QUALIFICATION_PREVIEW_FILE": mm.ATTACHMENT_SET_CODE = "QUALIFI_PREVIEW_FILE"; break;//资格预审文件
                            case "EXPLORATION_TRANSFER_ANNOUCEMNET": mm.ATTACHMENT_SET_CODE = "EXPLOR_TRANSFER_ANNOUCE"; break;//探矿权招拍挂出让公告信息
                            case "MINING_TRANSFER_ANNOUCEMNET": mm.ATTACHMENT_SET_CODE = "MINING_TRANSFER_ANNOUCE"; break;//采矿权招拍挂出让公告信息
                            case "EXPLORATION_TRANSFER_RESULT": mm.ATTACHMENT_SET_CODE = "EXPLOR_TRANSFER_RESULT"; break;//探矿权招拍挂出让结果公示信息
                            case "OTHER_EXPLORATION_PUBLIC_INFOR": mm.ATTACHMENT_SET_CODE = "OTHER_EXPLOR_PUBLIC_INF"; break;//其他方式出让矿业权公开信息（探矿权出让公开信息）  
                            case "OTHER_MINING_PUBLIC_INFOR": mm.ATTACHMENT_SET_CODE = "OTHER_MINING_PUBLIC_INFO"; break;//其他方式出让矿业权公开信息（采矿权出让公开信息）
                            case "NONOIL_EXPLORATION_REGISTRATION": mm.ATTACHMENT_SET_CODE = "NONOIL_EXPLOR_REGIST"; break;//非油气探矿权登记公示信息
                            case "OIL_EXPLORATION_ANNOUCEMNET": mm.ATTACHMENT_SET_CODE = "OIL_EXPLOR_ANNOUCEMNET"; break; //油气探矿权登记公告信息
                            case "NONOIL_MINING_REGISTRATION": mm.ATTACHMENT_SET_CODE = "NONOIL_MINING_REGIST"; break; //非油气采矿权登记公示信息
                            case "CORPORATION_AUTHORITY_FILE": mm.ATTACHMENT_SET_CODE = "COR_AUTHORITY_FILE"; break; //招标项目表 主要负责人的授权书
                        }
                        string FNAME = "M_ATT_" + mm.ATTACHMENT_SET_CODE;
                        if (!dict.ContainsKey(FNAME))
                        {
                            dict[FNAME] = newid.ToString();
                        }
                        else
                        {
                            dict[FNAME] = dict[FNAME] + "," + newid;
                        }

                    }
                }
            }
            return dict;
        }

        /// <summary>
        /// 移动附件
        /// </summary>
        private void MoveFiles(DataTable dtFile, string systemNo, string dataKey)
        {
            if (dtFile != null && dtFile.Rows.Count > 0)
            {
                bool containDelete = dtFile.Columns.Contains("IS_DELETE");

                for (int i = 0; i < dtFile.Rows.Count; i++)
                {
                    DataRow dr = dtFile.Rows[i];
                    if (containDelete && "1".Equals(dr["IS_DELETE"].ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        string filePath = GetFtpFile((dr["BINARY_CONTENT"] ?? "").ToString(), systemNo);
                        string uploadFile = ConfigurationManager.AppSettings["FTPSavePath"] +
                            GetSaveFtpFileV((dr["BINARY_CONTENT"] ?? "").ToString(), systemNo, dataKey);

                        string dir = Path.GetDirectoryName(uploadFile);
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }

                        if (File.Exists(uploadFile))
                        {
                            File.Delete(uploadFile);
                        }

                        File.Move(filePath, uploadFile);
                    }
                }
            }
        }


        private string GetFtpFile(string filepath, string systemNo)
        {
            return ConfigurationManager.AppSettings["FTPPath"] + "/" + systemNo + "/"
                   + filepath.Replace("..", "").Replace(":", "").Replace("\\", "/").TrimStart('/');
        }

        /// <summary>
        /// 获取将FTP文件保存的 相对路径
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private string GetSaveFtpFileV(string filepath, string systemNo, string dataKey)
        {
            return "/" + systemNo + "/" + DateTime.Now.ToString("yyyy/MM/dd/")
                   + dataKey + "/"
                   + filepath.Replace("..", "").Replace(":", "").Replace("\\", "/").TrimStart('/');
        }

        private string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }
    }
}