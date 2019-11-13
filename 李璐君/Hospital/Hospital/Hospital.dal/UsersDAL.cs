using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Hospital.dal
{
    class UsersDAL
    {
        public UsersDAL()
        {
        }
        //ÐÞ¸ÄÃÜÂë
        public void UpdateData(string uName,string pwd)
        {
            string strSql = "update Users set PWD='"+pwd+"' where UserName='"+uName+"'";
            try
            {
                DBManage dbm = new DBManage();
                dbm.QueryData(strSql);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateData(UsersEntity users)
        {
            string strSql = "update Users set PWD='"+users.UPwd+"',BuMen='"+users.UbuMen+
                "',Purview='"+users.UquanXian+"' where UserName='"+users.UUserName+"'";
            try
            {
                DBManage dbm = new DBManage();
                dbm.QueryData(strSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertData(UsersEntity users)
        {
            string strSql = "insert into Users values('"+users.UUserName+
                "','"+users.UPwd+"','"+users.UName+"','"+users.UbuMen+
                "',"+users.UquanXian+")";
            try
            {
                DBManage dbm = new DBManage();
                dbm.QueryData(strSql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteData(string userName)
        {
            string strSql = "delete from Users where UserName='"+userName+"'";
            try
            {
                DBManage dbm = new DBManage();
                dbm.QueryData(strSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SelectData(string userName,string pwd)
        {
            string strSql;
            if (userName == string.Empty||userName ==null)
            {
                strSql = "select * from Users";
            }
            else
            {
                strSql = "select * from Users where UserName='"+
                    userName+"' and PWD='"+pwd+"'";
            }
            try
            {
                DBManage dbm = new DBManage();
                return dbm.Select(strSql);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
