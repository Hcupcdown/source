using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Hospital.entity
{
    class GuaZhenItem
    {
        private int Id;

        public int Id1
        {
            get { return Id; }
        }
        private string Item;

        public string Item1
        {
            get { return Item; }
            set { Item = value; }
        }
        private Decimal Money;

        public Decimal Money1
        {
            get { return Money; }
            set { Money = value; }
        } 
        public GuaZhenItem()
        { 
        }

    }
}
