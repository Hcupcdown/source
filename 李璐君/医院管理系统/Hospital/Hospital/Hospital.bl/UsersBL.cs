using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Hospital.entity;
using Hospital.Hospital.dal;
using System.Data;

namespace Hospital.Hospital.bl
{
    class UsersBL
    {
        public UsersBL()
        {
        }
        public void UpdateUsers(string uName,string pwd)
        {
            try
            {
                UsersDAL dal = new UsersDAL();
                dal.UpdateData(uName,pwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertUsers(UsersEntity entity) 
        {
            try
            {
                UsersDAL dal = new UsersDAL();
                dal.InsertData(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateUsers(UsersEntity entity)
        {
            try
            {
                UsersDAL dal = new UsersDAL();
                dal.UpdateData(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteUsers(string UserName)
        {
            try
            {
                UsersDAL dal = new UsersDAL();
                dal.DeleteData(UserName);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SelectData(string UserName,string Pwd)
        {
            try
            {
                UsersDAL dal = new UsersDAL();
                return dal.SelectData(UserName,Pwd);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
