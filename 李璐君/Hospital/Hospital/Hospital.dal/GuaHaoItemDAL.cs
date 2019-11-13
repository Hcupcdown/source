using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Hospital.dal
{
    class GuaHaoItemDAL
    {
        public GuaHaoItemDAL()
        {
        }
        public DataSet SelectData()
        {

            string strSql = "select * from GuaZhenItem";
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
