using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Hospital.entity
{
    class GuaZhenItemEntity
    {
        public GuaZhenItemEntity()
        {
        }
        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        private string Item;

        public string Item1
        {
            get { return Item; }
            set { Item = value; }
        }
        private decimal Money;

        public decimal Money1
        {
            get { return Money; }
            set { Money = value; }
        } 
    }
}
