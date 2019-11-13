using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Hospital.Hospital.dal;
using Hospital.Hospital.entity;

namespace Hospital.Hospital.bl
{
    class LogBL
    {
        public LogBL()
        { 
        }
        public DataSet SelectData(string name)
        {
            try
            {
                LogDAL dal = new LogDAL();
                return dal.SelectData(name);
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
                LogDAL dal = new LogDAL();
                dal.InsertData(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
