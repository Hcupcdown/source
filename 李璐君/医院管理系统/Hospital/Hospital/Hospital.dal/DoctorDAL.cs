using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Hospital.dal
{
    class DoctorDAL
    {
        public DoctorDAL()
        { 
        }
        public void UpdateData(DoctorEntity doctor)
        {
            string strSql = "update Doctor set Name='" + doctor.Name1 + "',Sex='" + doctor.Sex1 +
                "',Age=" + doctor.Age1 + ",XueLi='" + doctor.XueLi1 + "',ZhiCheng='" + doctor.ZhiCheng1 +
                "',KeShi='"+doctor.KeShi1+"' where Id="+doctor.Id1+"";
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
        public void InsertData(DoctorEntity doctor)
        {
            string strSql = "insert into Doctor values('"+doctor.Name1+"','"+doctor.Sex1+"',"+doctor.Age1+
            ",'"+doctor.XueLi1+"','"+doctor.ZhiCheng1+"','"+doctor.KeShi1+"')";
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
        public void DeleteData(int id)
        {
            string strSql = "delete from Doctor where Id=" + id + "";
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

            string strSql = "select * from Doctor";
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
