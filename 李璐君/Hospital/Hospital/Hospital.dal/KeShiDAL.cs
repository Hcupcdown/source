using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Hospital.dal
{
    class KeShiDAL
    {
        public KeShiDAL()
        { 
        }
        public void UpdateData(KeShiEntity keShi)
        {
            string strSql = "update Office set OfficePeople='"+keShi.OfficePeople1+
                "' , Money=" + keShi.Money1 + " where OfficeName='"+keShi.OfficeName1+"'";
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
        public void InsertData(KeShiEntity keShi)
        {
            string strSql = "insert into Office values('"+keShi.OfficeName1+
                "','"+keShi.OfficePeople1+"',"+keShi.Money1+")";
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
        public void DeleteData(string name)
        {
            string strSql = "delete from Office where OfficeName='" + name + "'";
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
        public DataSet SelectData()
        {

            string strSql = "select * from Office";
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
