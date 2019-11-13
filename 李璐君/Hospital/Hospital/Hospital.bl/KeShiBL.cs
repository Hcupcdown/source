using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;

namespace Hospital.Hospital.bl
{
    class KeShiBL
    {
        public KeShiBL()
        { 
        }
        public void InsertData(KeShiEntity entity)
        {
            try
            {
                KeShiDAL dal = new KeShiDAL();
                dal.InsertData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateData(KeShiEntity entity)
        {
            try
            {
                KeShiDAL dal = new KeShiDAL();
                dal.UpdateData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteData(string name)
        {
            try
            {
                KeShiDAL dal = new KeShiDAL();
                dal.DeleteData(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SelectData()
        {
            try
            {
                KeShiDAL dal = new KeShiDAL();
                return dal.SelectData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
