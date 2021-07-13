using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using Dos.ORM;
using GGZY.DataV4Service.Logger;
using GGZY.DataV4Service.Model;

namespace GGZY.DataV4Service.Db
{
    /// <summary>
    /// 默认业务数据库的DAO
    /// </summary>
    public class DAO
    {

        public static DAO GGFW
        {
            get { return new DAO(DAOFactory.DAOGGFW, "GGWF"); }
        }
        public static DAO XZJD
        {
            get { return new DAO(DAOFactory.DAOXZJD, "XZJD"); }
        }

        private DbSession _dao;
        private string _name;
        private DbTrans _trans;

        public DAO(DbSession dao, string name)
        {
            _dao = dao;
            _name = name;
            _dao.RegisterSqlLogger(Console.WriteLine);
        }

        public bool ExecSql(string strSql)
        {
            int i = _dao.FromSql(strSql).ExecuteNonQuery();
            /*int i = 0;
            if (_trans != null)
            {
                i = _trans.FromSql(strSql).ExecuteNonQuery();
            }
            else
            {
                i = _dao.FromSql(strSql).ExecuteNonQuery();
            }*/

            return i > 0;
        }

        public string GetSingle(string strSql)
        {
            DataTable res;
            res = _dao.FromSql(strSql).ToDataTable();
            /*if (_trans != null)
            {
                res = _trans.FromSql(strSql).ToDataTable();
            }
            else
            {
                res = _dao.FromSql(strSql).ToDataTable();
            }*/

            if (res.Rows.Count > 0)
            {
                return res.Rows[0][0].ToString();
            }

            return "";
        }

        public DataSet GetDataSet(string sql)
        {
            try
            {
                return _dao.FromSql(sql).ToDataSet();
                /*if (_trans != null)
                {
                    return _trans.FromSql(sql).ToDataSet();
                }
                else
                {
                    return _dao.FromSql(sql).ToDataSet();
                }*/

            }
            catch (Exception e)
            {
                StrongLogger.Error(Newtonsoft.Json.JsonConvert.SerializeObject(new { sql, _dao }), "", "系统异常错误", e);
                throw;
            }

        }

        /// <summary>
        /// 获取数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            return _dao.Db.ConnectionString;
        }
        /*public DbTrans BeginTransaction()
        {
            _trans = _dao.BeginTransaction();
            return _trans;
        }*/

        /*public void RollBackTransaction()
        {
            _trans.Rollback();
        }*/

        /*public void CommitTransaction()
        {
            _trans.Commit();
        }*/

        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSql(string SQLString, params OracleParameter[] cmdParms)
        {
            SQLString = SQLString.Replace(Environment.NewLine, " ");
            string ConnectionString = this.GetConnectionString();
            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }
        #region 通过参数 获取Sql字符串
        /// <summary>
        /// 通过参数 获取Sql字符串
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        private static string GetSqlByParameter(string SQLString, params OracleParameter[] cmdParms)
        {
            string strParamDefined = "";
            string strParamValue = "";
            for (int i = 0; i < cmdParms.Length; i++)
            {
                string tmpType = cmdParms[i].OracleType.ToString(), tmpValue = cmdParms[i].Value.ToString();

                switch (cmdParms[i].OracleType)
                {
                    case OracleType.Char:
                    case OracleType.VarChar:
                    case OracleType.NVarChar:
                        tmpValue = "'" + tmpValue + "'";
                        tmpType = tmpType + "(" + cmdParms[i].Size + ")";
                        break;
                }

                strParamDefined += cmdParms[i].ParameterName + " " + tmpType + ",";
                strParamValue += cmdParms[i].ParameterName + "=" + tmpValue + ",";
            }
            string msg = "";
            msg += "    exec sp_executesql N'" + SQLString + "'";
            if (cmdParms.Length > 0)
            {
                msg += ",N'" + strParamDefined.Trim(',') + "'";
                msg += "," + strParamValue.Trim(',');
            }

            return msg;
        }
        #endregion
        private void PrepareCommand(OracleCommand cmd, OracleConnection conn, OracleTransaction trans, string cmdText, OracleParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach (OracleParameter parm in cmdParms)
                {
                    if ((parm.Direction == ParameterDirection.InputOutput || parm.Direction == ParameterDirection.Input) &&
                        (parm.Value == null || parm.Value.ToString() == ""))
                    {
                        parm.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parm);
                }
            }
        }

        public int AddAttacment(T_ATTACHMENT model)
        {
            model.ID = 0;
            int id = 0;
            if (_trans != null)
            {
                id = _trans.Insert(model);
            }
            else
            {
                id = _dao.Insert(model);
            }

            return id;

        }
    }
}
