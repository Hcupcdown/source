using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Hospital.Hospital.entity;

namespace Hospital.Hospital.dal
{
    class LogDAL
    {
        public LogDAL()
        { 
        }
        public DataSet SelectData(string name)
        {
            string strSql;
            if (name == "" || name == null)
            {
                strSql = "select * from Log";
            }
            else
            {
                strSql = "select * from Log where UserName='"+name+"'";
            }
            try
            {
                DBManage dbm = new DBManage();
                return dbm.Select(strSql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void InsertData(LogEntity entity)
        {
            try
            {
                string strSql = "insert into Log values('" + entity.UserName1 + "','" + entity.LoginTime1 + "','" + entity.Message1 + "')";
                DBManage dbm = new DBManage();
                dbm.QueryData(strSql);
               
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
