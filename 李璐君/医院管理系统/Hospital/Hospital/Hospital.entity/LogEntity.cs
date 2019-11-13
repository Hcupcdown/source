using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Hospital.entity
{
    class LogEntity
    {
        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        private string UserName;

        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private DateTime LoginTime;

        public DateTime LoginTime1
        {
            get { return LoginTime; }
            set { LoginTime = value; }
        }
        private string Message;

        public string Message1
        {
            get { return Message; }
            set { Message = value; }
        }
        public LogEntity()
        { 
        }
    }
}
