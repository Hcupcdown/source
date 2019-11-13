using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Hospital.dal
{
    class GuaHaoDAL
    {
        public GuaHaoDAL()
        { 
        }
        public void UpdateData(GuaHaoEntity entity)
        {
            string strSql = "update Regist set Type='"+entity.Type1+"',Mode='"+entity.Mode1+"',Name='"+entity.Name1+
                "',Sex='"+entity.Sex1+"',Age="+entity.Age1+",Folk='"+entity.Folk1+"',Phone='"+entity.Phone1+"',Address='"+entity.Address1+
            "',DoctorName='"+entity.DoctorName1+"',Office='"+entity.Office1+"',Item='"+entity.Item1+"',GuaHaoMoney="+entity.GuaHaoMoney1+
            ",ZhenDuanMoney="+entity.ZhenDuanMoney1+",UserName='"+entity.UserName1+"',Bool="+entity.Bool1+" where Id="+entity.Id1+"";
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
        public void InsertData(GuaHaoEntity entity)
        {
            string strSql = "insert into Regist values('" + entity.Type1 + "','" + entity.Mode1 + "','" + entity.Name1 +"','" +
                entity.Sex1 + "'," + entity.Age1 + ",'" + entity.Folk1 + "','" + entity.Phone1 + "','" + entity.Address1 +
            "','" + entity.DoctorName1 + "','" + entity.Office1 + "','" + entity.Item1 + "'," + entity.GuaHaoMoney1 +
            "," + entity.ZhenDuanMoney1 + ",'" + entity.UserName1 + "'," + entity.Bool1 + ")";
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
        public DataSet SelectData(int b)
        {
            string strSql;
            if (b==1)
            {
                strSql= "select * from Regist where Bool=1";
            }
            else if (b == 0)
            {
                strSql = "select * from Regist where Bool=0";
            }
            else
            {
                strSql = "select * from Regist where Id="+b+" and Bool=1";
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
