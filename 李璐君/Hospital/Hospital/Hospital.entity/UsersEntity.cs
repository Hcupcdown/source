using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Hospital.entity
{
    class UsersEntity
    {
        private string userName;
        private string userPwd;
        private string name;
        private string buMen;
        private int quanXian;
        public static string un;
        public static string pass;
        public UsersEntity()
        {
 
        }
        public string UUserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public string UPwd
        {
            get
            {
                return userPwd;
            }
            set
            {
                userPwd = value;
            }
        }
        public string UName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string UbuMen
        {
            get
            {
                return buMen;
            }
            set
            {
                buMen = value;
            }
        }
        public int UquanXian
        {
            get
            {
                return quanXian;
            }
            set
            {
                quanXian = value;
            }
        }
    }
   
}
