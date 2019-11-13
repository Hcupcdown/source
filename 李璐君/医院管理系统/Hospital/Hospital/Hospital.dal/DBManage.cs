using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Hospital.dal
{
    class DBManage
    {
        private SqlConnection sqlCon = null;
        private SqlCommand sqlCmd = null;
        private DataSet ds = new DataSet();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        public DBManage()
        {
            //调用建立数据库连接的方法
            this.createCon();
        }
        /// <summary>
        /// 建立数据库链接
        /// </summary>
        private void createCon()
        {
            string strURL = "server=localhost;uid=sa;pwd=tianliuyang84955761;";
            sqlCon = new SqlConnection(strURL);
            this.openSqlCon();
            sqlCon.ChangeDatabase("Hospital");
        }
        /// <summary>
        /// 打开数据库链接
        /// </summary>
        private void openSqlCon()
        {
            if(sqlCon.State==ConnectionState.Closed)
            {
                try
                {
                    sqlCon.Open();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 关闭数据库链接
        /// </summary>
        public void closeSqlCon()
        {
            if(sqlCon.State==ConnectionState.Open)
            {

                sqlCon.ChangeDatabase("master");
                sqlCon.Close();             
            }
        }
        /// <summary>
        /// 执行update，delete，insert语句
        /// </summary>
        /// <param name="strSql">sql语句</param>
        public void QueryData(string strSql)
        {
            try
            {
                sqlCmd = new SqlCommand(strSql, sqlCon);
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeSqlCon();
            }

        }
        /// <summary>
        ///  执行select语句
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <returns>返回数据集</returns>
        public DataSet Select(string strSql)
        {
            try
            {
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = strSql;
                adapter.SelectCommand = sqlCmd;
                ds.Tables.Clear();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeSqlCon();
                
            }
        }
    }
    
}
