using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;

namespace Hospital.Hospital.bl
{
    class GuaHaoItemBL
    {
        public GuaHaoItemBL()
        { 
        }
        public DataSet SelectData()
        {
            try
            {
                GuaHaoItemDAL dal = new GuaHaoItemDAL();
                return dal.SelectData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
