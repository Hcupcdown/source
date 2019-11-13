using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Hospital.entity
{
    class KeShiEntity
    {
        private string OfficeName;
        private string OfficePeople;     
        private Decimal Money;
        public KeShiEntity()
        {
        }
        public string OfficeName1
        {
            get { return OfficeName; }
            set { OfficeName = value; }
        }
        public string OfficePeople1
        {
            get { return OfficePeople; }
            set { OfficePeople = value; }
        }
        public Decimal Money1
        {
            get { return Money; }
            set { Money = value; }
        }
        
    }
}
