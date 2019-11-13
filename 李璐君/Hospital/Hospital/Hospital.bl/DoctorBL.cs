using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;

namespace Hospital.Hospital.bl
{
    class DoctorBL
    {
        public DoctorBL()
        { 
        }
        public void InsertData(DoctorEntity entity)
        {
            try
            {
                DoctorDAL dal = new DoctorDAL();
                dal.InsertData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateData(DoctorEntity entity)
        {
            try
            {
                DoctorDAL dal = new DoctorDAL();
                dal.UpdateData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteData(int id)
        {
            try
            {
                DoctorDAL dal = new DoctorDAL();
                dal.DeleteData(id);
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
                DoctorDAL dal = new DoctorDAL();
                return dal.SelectData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
