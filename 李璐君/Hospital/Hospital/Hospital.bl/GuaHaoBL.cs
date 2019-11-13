using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;

namespace Hospital.Hospital.bl
{
    class GuaHaoBL
    {
        public GuaHaoBL()
        { 
        }
        public void InsertData(GuaHaoEntity entity)
        {
            try
            {
                GuaHaoDAL dal = new GuaHaoDAL();
                dal.InsertData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateData(GuaHaoEntity entity)
        {
            try
            {
                GuaHaoDAL dal = new GuaHaoDAL();
                dal.UpdateData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SelectData(int b)
        {
            try
            {
                GuaHaoDAL dal = new GuaHaoDAL();
                return dal.SelectData(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
